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
    public interface IToolsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsAddCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-add-custom-server/">REST API Reference for NewAiToolsAddCustomServer Operation</seealso>
        /// <returns>NewAiToolsMutationResult</returns>
        NewAiToolsMutationResult NewAiToolsAddCustomServer(NewAiToolsAddCustomServerRequest newAiToolsAddCustomServerRequest);

        /// <summary>
        /// Add custom server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsAddCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-add-custom-server/">REST API Reference for NewAiToolsAddCustomServer Operation</seealso>
        /// <returns>ApiResponse of NewAiToolsMutationResult</returns>
        ApiResponse<NewAiToolsMutationResult> NewAiToolsAddCustomServerWithHttpInfo(NewAiToolsAddCustomServerRequest newAiToolsAddCustomServerRequest);
        /// <summary>
        /// Get allow always
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-allow-always/">REST API Reference for NewAiToolsGetAllowAlways Operation</seealso>
        /// <returns>List&lt;string&gt;</returns>
        List<string> NewAiToolsGetAllowAlways(string entityId);

        /// <summary>
        /// Get allow always
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-allow-always/">REST API Reference for NewAiToolsGetAllowAlways Operation</seealso>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> NewAiToolsGetAllowAlwaysWithHttpInfo(string entityId);
        /// <summary>
        /// Get custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-custom-server/">REST API Reference for NewAiToolsGetCustomServer Operation</seealso>
        /// <returns>Object</returns>
        Object NewAiToolsGetCustomServer(string name, string entityId);

        /// <summary>
        /// Get custom server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-custom-server/">REST API Reference for NewAiToolsGetCustomServer Operation</seealso>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> NewAiToolsGetCustomServerWithHttpInfo(string name, string entityId);
        /// <summary>
        /// Get disabled
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-disabled/">REST API Reference for NewAiToolsGetDisabled Operation</seealso>
        /// <returns>Dictionary&lt;string, List&lt;string&gt;&gt;</returns>
        Dictionary<string, List<string>> NewAiToolsGetDisabled(string entityId);

        /// <summary>
        /// Get disabled
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-disabled/">REST API Reference for NewAiToolsGetDisabled Operation</seealso>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;string&gt;&gt;</returns>
        ApiResponse<Dictionary<string, List<string>>> NewAiToolsGetDisabledWithHttpInfo(string entityId);
        /// <summary>
        /// Is allow always
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverType"></param>
        /// <param name="toolName"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-is-allow-always/">REST API Reference for NewAiToolsIsAllowAlways Operation</seealso>
        /// <returns>bool</returns>
        bool NewAiToolsIsAllowAlways(string serverType, string toolName, string entityId);

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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-is-allow-always/">REST API Reference for NewAiToolsIsAllowAlways Operation</seealso>
        /// <returns>ApiResponse of bool</returns>
        ApiResponse<bool> NewAiToolsIsAllowAlwaysWithHttpInfo(string serverType, string toolName, string entityId);
        /// <summary>
        /// Is tool disabled
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverType"></param>
        /// <param name="toolName"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-is-tool-disabled/">REST API Reference for NewAiToolsIsToolDisabled Operation</seealso>
        /// <returns>bool</returns>
        bool NewAiToolsIsToolDisabled(string serverType, string toolName, string entityId);

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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-is-tool-disabled/">REST API Reference for NewAiToolsIsToolDisabled Operation</seealso>
        /// <returns>ApiResponse of bool</returns>
        ApiResponse<bool> NewAiToolsIsToolDisabledWithHttpInfo(string serverType, string toolName, string entityId);
        /// <summary>
        /// List custom servers
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-list-custom-servers/">REST API Reference for NewAiToolsListCustomServers Operation</seealso>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        Dictionary<string, Object> NewAiToolsListCustomServers(string entityId);

        /// <summary>
        /// List custom servers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-list-custom-servers/">REST API Reference for NewAiToolsListCustomServers Operation</seealso>
        /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>
        ApiResponse<Dictionary<string, Object>> NewAiToolsListCustomServersWithHttpInfo(string entityId);
        /// <summary>
        /// List system tools
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-list-system-tools/">REST API Reference for NewAiToolsListSystemTools Operation</seealso>
        /// <returns>Dictionary&lt;string, List&lt;NewAiTMCPItem&gt;&gt;</returns>
        Dictionary<string, List<NewAiTMCPItem>> NewAiToolsListSystemTools(string entityId);

        /// <summary>
        /// List system tools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-list-system-tools/">REST API Reference for NewAiToolsListSystemTools Operation</seealso>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;NewAiTMCPItem&gt;&gt;</returns>
        ApiResponse<Dictionary<string, List<NewAiTMCPItem>>> NewAiToolsListSystemToolsWithHttpInfo(string entityId);
        /// <summary>
        /// Remove custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsRemoveCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-remove-custom-server/">REST API Reference for NewAiToolsRemoveCustomServer Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        NewAiSuccessResponse NewAiToolsRemoveCustomServer(NewAiToolsRemoveCustomServerRequest newAiToolsRemoveCustomServerRequest);

        /// <summary>
        /// Remove custom server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsRemoveCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-remove-custom-server/">REST API Reference for NewAiToolsRemoveCustomServer Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        ApiResponse<NewAiSuccessResponse> NewAiToolsRemoveCustomServerWithHttpInfo(NewAiToolsRemoveCustomServerRequest newAiToolsRemoveCustomServerRequest);
        /// <summary>
        /// Replace all custom servers
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsReplaceAllCustomServersRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-replace-all-custom-servers/">REST API Reference for NewAiToolsReplaceAllCustomServers Operation</seealso>
        /// <returns>NewAiToolsBulkResult</returns>
        NewAiToolsBulkResult NewAiToolsReplaceAllCustomServers(NewAiToolsReplaceAllCustomServersRequest newAiToolsReplaceAllCustomServersRequest);

        /// <summary>
        /// Replace all custom servers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsReplaceAllCustomServersRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-replace-all-custom-servers/">REST API Reference for NewAiToolsReplaceAllCustomServers Operation</seealso>
        /// <returns>ApiResponse of NewAiToolsBulkResult</returns>
        ApiResponse<NewAiToolsBulkResult> NewAiToolsReplaceAllCustomServersWithHttpInfo(NewAiToolsReplaceAllCustomServersRequest newAiToolsReplaceAllCustomServersRequest);
        /// <summary>
        /// Set allow always
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsSetAllowAlwaysRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-set-allow-always/">REST API Reference for NewAiToolsSetAllowAlways Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        NewAiSuccessResponse NewAiToolsSetAllowAlways(NewAiToolsSetAllowAlwaysRequest newAiToolsSetAllowAlwaysRequest);

        /// <summary>
        /// Set allow always
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsSetAllowAlwaysRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-set-allow-always/">REST API Reference for NewAiToolsSetAllowAlways Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        ApiResponse<NewAiSuccessResponse> NewAiToolsSetAllowAlwaysWithHttpInfo(NewAiToolsSetAllowAlwaysRequest newAiToolsSetAllowAlwaysRequest);
        /// <summary>
        /// Set disabled
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsSetDisabledRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-set-disabled/">REST API Reference for NewAiToolsSetDisabled Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        NewAiSuccessResponse NewAiToolsSetDisabled(NewAiToolsSetDisabledRequest newAiToolsSetDisabledRequest);

        /// <summary>
        /// Set disabled
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsSetDisabledRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-set-disabled/">REST API Reference for NewAiToolsSetDisabled Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        ApiResponse<NewAiSuccessResponse> NewAiToolsSetDisabledWithHttpInfo(NewAiToolsSetDisabledRequest newAiToolsSetDisabledRequest);
        /// <summary>
        /// Update custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsUpdateCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-update-custom-server/">REST API Reference for NewAiToolsUpdateCustomServer Operation</seealso>
        /// <returns>NewAiToolsMutationResult</returns>
        NewAiToolsMutationResult NewAiToolsUpdateCustomServer(NewAiToolsUpdateCustomServerRequest newAiToolsUpdateCustomServerRequest);

        /// <summary>
        /// Update custom server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsUpdateCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-update-custom-server/">REST API Reference for NewAiToolsUpdateCustomServer Operation</seealso>
        /// <returns>ApiResponse of NewAiToolsMutationResult</returns>
        ApiResponse<NewAiToolsMutationResult> NewAiToolsUpdateCustomServerWithHttpInfo(NewAiToolsUpdateCustomServerRequest newAiToolsUpdateCustomServerRequest);
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
        /// <param name="newAiToolsAddCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-add-custom-server/">REST API Reference for NewAiToolsAddCustomServer Operation</seealso>
        /// <returns>Task of NewAiToolsMutationResult</returns>
        Task<NewAiToolsMutationResult> NewAiToolsAddCustomServerAsync(NewAiToolsAddCustomServerRequest newAiToolsAddCustomServerRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Add custom server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsAddCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-add-custom-server/">REST API Reference for NewAiToolsAddCustomServer Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiToolsMutationResult)</returns>
        Task<ApiResponse<NewAiToolsMutationResult>> NewAiToolsAddCustomServerWithHttpInfoAsync(NewAiToolsAddCustomServerRequest newAiToolsAddCustomServerRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get allow always
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-allow-always/">REST API Reference for NewAiToolsGetAllowAlways Operation</seealso>
        /// <returns>Task of List&lt;string&gt;</returns>
        Task<List<string>> NewAiToolsGetAllowAlwaysAsync(string entityId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get allow always
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-allow-always/">REST API Reference for NewAiToolsGetAllowAlways Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        Task<ApiResponse<List<string>>> NewAiToolsGetAllowAlwaysWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-custom-server/">REST API Reference for NewAiToolsGetCustomServer Operation</seealso>
        /// <returns>Task of Object</returns>
        Task<Object> NewAiToolsGetCustomServerAsync(string name, string entityId, CancellationToken cancellationToken = default);

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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-custom-server/">REST API Reference for NewAiToolsGetCustomServer Operation</seealso>
        /// <returns>Task of ApiResponse (Object)</returns>
        Task<ApiResponse<Object>> NewAiToolsGetCustomServerWithHttpInfoAsync(string name, string entityId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get disabled
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-disabled/">REST API Reference for NewAiToolsGetDisabled Operation</seealso>
        /// <returns>Task of Dictionary&lt;string, List&lt;string&gt;&gt;</returns>
        Task<Dictionary<string, List<string>>> NewAiToolsGetDisabledAsync(string entityId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get disabled
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-disabled/">REST API Reference for NewAiToolsGetDisabled Operation</seealso>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, List&lt;string&gt;&gt;)</returns>
        Task<ApiResponse<Dictionary<string, List<string>>>> NewAiToolsGetDisabledWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-is-allow-always/">REST API Reference for NewAiToolsIsAllowAlways Operation</seealso>
        /// <returns>Task of bool</returns>
        Task<bool> NewAiToolsIsAllowAlwaysAsync(string serverType, string toolName, string entityId, CancellationToken cancellationToken = default);

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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-is-allow-always/">REST API Reference for NewAiToolsIsAllowAlways Operation</seealso>
        /// <returns>Task of ApiResponse (bool)</returns>
        Task<ApiResponse<bool>> NewAiToolsIsAllowAlwaysWithHttpInfoAsync(string serverType, string toolName, string entityId, CancellationToken cancellationToken = default);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-is-tool-disabled/">REST API Reference for NewAiToolsIsToolDisabled Operation</seealso>
        /// <returns>Task of bool</returns>
        Task<bool> NewAiToolsIsToolDisabledAsync(string serverType, string toolName, string entityId, CancellationToken cancellationToken = default);

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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-is-tool-disabled/">REST API Reference for NewAiToolsIsToolDisabled Operation</seealso>
        /// <returns>Task of ApiResponse (bool)</returns>
        Task<ApiResponse<bool>> NewAiToolsIsToolDisabledWithHttpInfoAsync(string serverType, string toolName, string entityId, CancellationToken cancellationToken = default);
        /// <summary>
        /// List custom servers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-list-custom-servers/">REST API Reference for NewAiToolsListCustomServers Operation</seealso>
        /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>
        Task<Dictionary<string, Object>> NewAiToolsListCustomServersAsync(string entityId, CancellationToken cancellationToken = default);

        /// <summary>
        /// List custom servers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-list-custom-servers/">REST API Reference for NewAiToolsListCustomServers Operation</seealso>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>
        Task<ApiResponse<Dictionary<string, Object>>> NewAiToolsListCustomServersWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default);
        /// <summary>
        /// List system tools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-list-system-tools/">REST API Reference for NewAiToolsListSystemTools Operation</seealso>
        /// <returns>Task of Dictionary&lt;string, List&lt;NewAiTMCPItem&gt;&gt;</returns>
        Task<Dictionary<string, List<NewAiTMCPItem>>> NewAiToolsListSystemToolsAsync(string entityId, CancellationToken cancellationToken = default);

        /// <summary>
        /// List system tools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-list-system-tools/">REST API Reference for NewAiToolsListSystemTools Operation</seealso>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, List&lt;NewAiTMCPItem&gt;&gt;)</returns>
        Task<ApiResponse<Dictionary<string, List<NewAiTMCPItem>>>> NewAiToolsListSystemToolsWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove custom server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsRemoveCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-remove-custom-server/">REST API Reference for NewAiToolsRemoveCustomServer Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        Task<NewAiSuccessResponse> NewAiToolsRemoveCustomServerAsync(NewAiToolsRemoveCustomServerRequest newAiToolsRemoveCustomServerRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove custom server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsRemoveCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-remove-custom-server/">REST API Reference for NewAiToolsRemoveCustomServer Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        Task<ApiResponse<NewAiSuccessResponse>> NewAiToolsRemoveCustomServerWithHttpInfoAsync(NewAiToolsRemoveCustomServerRequest newAiToolsRemoveCustomServerRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace all custom servers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsReplaceAllCustomServersRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-replace-all-custom-servers/">REST API Reference for NewAiToolsReplaceAllCustomServers Operation</seealso>
        /// <returns>Task of NewAiToolsBulkResult</returns>
        Task<NewAiToolsBulkResult> NewAiToolsReplaceAllCustomServersAsync(NewAiToolsReplaceAllCustomServersRequest newAiToolsReplaceAllCustomServersRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Replace all custom servers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsReplaceAllCustomServersRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-replace-all-custom-servers/">REST API Reference for NewAiToolsReplaceAllCustomServers Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiToolsBulkResult)</returns>
        Task<ApiResponse<NewAiToolsBulkResult>> NewAiToolsReplaceAllCustomServersWithHttpInfoAsync(NewAiToolsReplaceAllCustomServersRequest newAiToolsReplaceAllCustomServersRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set allow always
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsSetAllowAlwaysRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-set-allow-always/">REST API Reference for NewAiToolsSetAllowAlways Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        Task<NewAiSuccessResponse> NewAiToolsSetAllowAlwaysAsync(NewAiToolsSetAllowAlwaysRequest newAiToolsSetAllowAlwaysRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set allow always
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsSetAllowAlwaysRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-set-allow-always/">REST API Reference for NewAiToolsSetAllowAlways Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        Task<ApiResponse<NewAiSuccessResponse>> NewAiToolsSetAllowAlwaysWithHttpInfoAsync(NewAiToolsSetAllowAlwaysRequest newAiToolsSetAllowAlwaysRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set disabled
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsSetDisabledRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-set-disabled/">REST API Reference for NewAiToolsSetDisabled Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        Task<NewAiSuccessResponse> NewAiToolsSetDisabledAsync(NewAiToolsSetDisabledRequest newAiToolsSetDisabledRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set disabled
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsSetDisabledRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-set-disabled/">REST API Reference for NewAiToolsSetDisabled Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        Task<ApiResponse<NewAiSuccessResponse>> NewAiToolsSetDisabledWithHttpInfoAsync(NewAiToolsSetDisabledRequest newAiToolsSetDisabledRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update custom server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsUpdateCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-update-custom-server/">REST API Reference for NewAiToolsUpdateCustomServer Operation</seealso>
        /// <returns>Task of NewAiToolsMutationResult</returns>
        Task<NewAiToolsMutationResult> NewAiToolsUpdateCustomServerAsync(NewAiToolsUpdateCustomServerRequest newAiToolsUpdateCustomServerRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update custom server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsUpdateCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-update-custom-server/">REST API Reference for NewAiToolsUpdateCustomServer Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiToolsMutationResult)</returns>
        Task<ApiResponse<NewAiToolsMutationResult>> NewAiToolsUpdateCustomServerWithHttpInfoAsync(NewAiToolsUpdateCustomServerRequest newAiToolsUpdateCustomServerRequest, CancellationToken cancellationToken = default);
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
        /// <param name="newAiToolsAddCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-add-custom-server/">REST API Reference for NewAiToolsAddCustomServer Operation</seealso>
        /// <returns>NewAiToolsMutationResult</returns>
        public NewAiToolsMutationResult NewAiToolsAddCustomServer(NewAiToolsAddCustomServerRequest newAiToolsAddCustomServerRequest)
        {
            var localVarResponse = NewAiToolsAddCustomServerWithHttpInfo(newAiToolsAddCustomServerRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Add custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsAddCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-add-custom-server/">REST API Reference for NewAiToolsAddCustomServer Operation</seealso>
        /// <returns>ApiResponse of NewAiToolsMutationResult</returns>
        public ApiResponse<NewAiToolsMutationResult> NewAiToolsAddCustomServerWithHttpInfo(NewAiToolsAddCustomServerRequest newAiToolsAddCustomServerRequest)
        {
            // verify the required parameter 'newAiToolsAddCustomServerRequest' is set
            if (newAiToolsAddCustomServerRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiToolsAddCustomServerRequest' when calling ToolsApi->NewAiToolsAddCustomServer");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiToolsAddCustomServerRequest != null) localVarRequestOptions.Data = newAiToolsAddCustomServerRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<NewAiToolsMutationResult>("/api/2.0/ai/tools/add-custom-server", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiToolsAddCustomServer", localVarResponse);
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
        /// <param name="newAiToolsAddCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-add-custom-server/">REST API Reference for NewAiToolsAddCustomServer Operation</seealso>
        /// <returns>Task of NewAiToolsMutationResult</returns>
        public async Task<NewAiToolsMutationResult> NewAiToolsAddCustomServerAsync(NewAiToolsAddCustomServerRequest newAiToolsAddCustomServerRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiToolsAddCustomServerWithHttpInfoAsync(newAiToolsAddCustomServerRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Add custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsAddCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-add-custom-server/">REST API Reference for NewAiToolsAddCustomServer Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiToolsMutationResult)</returns>
        public async Task<ApiResponse<NewAiToolsMutationResult>> NewAiToolsAddCustomServerWithHttpInfoAsync(NewAiToolsAddCustomServerRequest newAiToolsAddCustomServerRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiToolsAddCustomServerRequest' is set
            if (newAiToolsAddCustomServerRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiToolsAddCustomServerRequest' when calling ToolsApi->NewAiToolsAddCustomServer");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiToolsAddCustomServerRequest != null) localVarRequestOptions.Data = newAiToolsAddCustomServerRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<NewAiToolsMutationResult>("/api/2.0/ai/tools/add-custom-server", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiToolsAddCustomServer", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-allow-always/">REST API Reference for NewAiToolsGetAllowAlways Operation</seealso>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> NewAiToolsGetAllowAlways(string entityId)
        {
            var localVarResponse = NewAiToolsGetAllowAlwaysWithHttpInfo(entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get allow always
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-allow-always/">REST API Reference for NewAiToolsGetAllowAlways Operation</seealso>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse<List<string>> NewAiToolsGetAllowAlwaysWithHttpInfo(string entityId)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->NewAiToolsGetAllowAlways");

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
                var exception = ExceptionFactory("NewAiToolsGetAllowAlways", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-allow-always/">REST API Reference for NewAiToolsGetAllowAlways Operation</seealso>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async Task<List<string>> NewAiToolsGetAllowAlwaysAsync(string entityId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiToolsGetAllowAlwaysWithHttpInfoAsync(entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get allow always
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-allow-always/">REST API Reference for NewAiToolsGetAllowAlways Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async Task<ApiResponse<List<string>>> NewAiToolsGetAllowAlwaysWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->NewAiToolsGetAllowAlways");

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
                var exception = ExceptionFactory("NewAiToolsGetAllowAlways", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-custom-server/">REST API Reference for NewAiToolsGetCustomServer Operation</seealso>
        /// <returns>Object</returns>
        public Object NewAiToolsGetCustomServer(string name, string entityId)
        {
            var localVarResponse = NewAiToolsGetCustomServerWithHttpInfo(name, entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-custom-server/">REST API Reference for NewAiToolsGetCustomServer Operation</seealso>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse<Object> NewAiToolsGetCustomServerWithHttpInfo(string name, string entityId)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling ToolsApi->NewAiToolsGetCustomServer");

            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->NewAiToolsGetCustomServer");

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
                var exception = ExceptionFactory("NewAiToolsGetCustomServer", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-custom-server/">REST API Reference for NewAiToolsGetCustomServer Operation</seealso>
        /// <returns>Task of Object</returns>
        public async Task<Object> NewAiToolsGetCustomServerAsync(string name, string entityId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiToolsGetCustomServerWithHttpInfoAsync(name, entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-custom-server/">REST API Reference for NewAiToolsGetCustomServer Operation</seealso>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async Task<ApiResponse<Object>> NewAiToolsGetCustomServerWithHttpInfoAsync(string name, string entityId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling ToolsApi->NewAiToolsGetCustomServer");

            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->NewAiToolsGetCustomServer");

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
                var exception = ExceptionFactory("NewAiToolsGetCustomServer", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-disabled/">REST API Reference for NewAiToolsGetDisabled Operation</seealso>
        /// <returns>Dictionary&lt;string, List&lt;string&gt;&gt;</returns>
        public Dictionary<string, List<string>> NewAiToolsGetDisabled(string entityId)
        {
            var localVarResponse = NewAiToolsGetDisabledWithHttpInfo(entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get disabled
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-disabled/">REST API Reference for NewAiToolsGetDisabled Operation</seealso>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;string&gt;&gt;</returns>
        public ApiResponse<Dictionary<string, List<string>>> NewAiToolsGetDisabledWithHttpInfo(string entityId)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->NewAiToolsGetDisabled");

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
                var exception = ExceptionFactory("NewAiToolsGetDisabled", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-disabled/">REST API Reference for NewAiToolsGetDisabled Operation</seealso>
        /// <returns>Task of Dictionary&lt;string, List&lt;string&gt;&gt;</returns>
        public async Task<Dictionary<string, List<string>>> NewAiToolsGetDisabledAsync(string entityId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiToolsGetDisabledWithHttpInfoAsync(entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get disabled
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-disabled/">REST API Reference for NewAiToolsGetDisabled Operation</seealso>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, List&lt;string&gt;&gt;)</returns>
        public async Task<ApiResponse<Dictionary<string, List<string>>>> NewAiToolsGetDisabledWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->NewAiToolsGetDisabled");

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
                var exception = ExceptionFactory("NewAiToolsGetDisabled", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-is-allow-always/">REST API Reference for NewAiToolsIsAllowAlways Operation</seealso>
        /// <returns>bool</returns>
        public bool NewAiToolsIsAllowAlways(string serverType, string toolName, string entityId)
        {
            var localVarResponse = NewAiToolsIsAllowAlwaysWithHttpInfo(serverType, toolName, entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Is allow always
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverType"></param>
        /// <param name="toolName"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-is-allow-always/">REST API Reference for NewAiToolsIsAllowAlways Operation</seealso>
        /// <returns>ApiResponse of bool</returns>
        public ApiResponse<bool> NewAiToolsIsAllowAlwaysWithHttpInfo(string serverType, string toolName, string entityId)
        {
            // verify the required parameter 'serverType' is set
            if (serverType == null)
                throw new ApiException(400, "Missing required parameter 'serverType' when calling ToolsApi->NewAiToolsIsAllowAlways");

            // verify the required parameter 'toolName' is set
            if (toolName == null)
                throw new ApiException(400, "Missing required parameter 'toolName' when calling ToolsApi->NewAiToolsIsAllowAlways");

            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->NewAiToolsIsAllowAlways");

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
                var exception = ExceptionFactory("NewAiToolsIsAllowAlways", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-is-allow-always/">REST API Reference for NewAiToolsIsAllowAlways Operation</seealso>
        /// <returns>Task of bool</returns>
        public async Task<bool> NewAiToolsIsAllowAlwaysAsync(string serverType, string toolName, string entityId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiToolsIsAllowAlwaysWithHttpInfoAsync(serverType, toolName, entityId, cancellationToken).ConfigureAwait(false);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-is-allow-always/">REST API Reference for NewAiToolsIsAllowAlways Operation</seealso>
        /// <returns>Task of ApiResponse (bool)</returns>
        public async Task<ApiResponse<bool>> NewAiToolsIsAllowAlwaysWithHttpInfoAsync(string serverType, string toolName, string entityId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'serverType' is set
            if (serverType == null)
                throw new ApiException(400, "Missing required parameter 'serverType' when calling ToolsApi->NewAiToolsIsAllowAlways");

            // verify the required parameter 'toolName' is set
            if (toolName == null)
                throw new ApiException(400, "Missing required parameter 'toolName' when calling ToolsApi->NewAiToolsIsAllowAlways");

            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->NewAiToolsIsAllowAlways");

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
                var exception = ExceptionFactory("NewAiToolsIsAllowAlways", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-is-tool-disabled/">REST API Reference for NewAiToolsIsToolDisabled Operation</seealso>
        /// <returns>bool</returns>
        public bool NewAiToolsIsToolDisabled(string serverType, string toolName, string entityId)
        {
            var localVarResponse = NewAiToolsIsToolDisabledWithHttpInfo(serverType, toolName, entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Is tool disabled
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverType"></param>
        /// <param name="toolName"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-is-tool-disabled/">REST API Reference for NewAiToolsIsToolDisabled Operation</seealso>
        /// <returns>ApiResponse of bool</returns>
        public ApiResponse<bool> NewAiToolsIsToolDisabledWithHttpInfo(string serverType, string toolName, string entityId)
        {
            // verify the required parameter 'serverType' is set
            if (serverType == null)
                throw new ApiException(400, "Missing required parameter 'serverType' when calling ToolsApi->NewAiToolsIsToolDisabled");

            // verify the required parameter 'toolName' is set
            if (toolName == null)
                throw new ApiException(400, "Missing required parameter 'toolName' when calling ToolsApi->NewAiToolsIsToolDisabled");

            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->NewAiToolsIsToolDisabled");

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
                var exception = ExceptionFactory("NewAiToolsIsToolDisabled", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-is-tool-disabled/">REST API Reference for NewAiToolsIsToolDisabled Operation</seealso>
        /// <returns>Task of bool</returns>
        public async Task<bool> NewAiToolsIsToolDisabledAsync(string serverType, string toolName, string entityId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiToolsIsToolDisabledWithHttpInfoAsync(serverType, toolName, entityId, cancellationToken).ConfigureAwait(false);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-is-tool-disabled/">REST API Reference for NewAiToolsIsToolDisabled Operation</seealso>
        /// <returns>Task of ApiResponse (bool)</returns>
        public async Task<ApiResponse<bool>> NewAiToolsIsToolDisabledWithHttpInfoAsync(string serverType, string toolName, string entityId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'serverType' is set
            if (serverType == null)
                throw new ApiException(400, "Missing required parameter 'serverType' when calling ToolsApi->NewAiToolsIsToolDisabled");

            // verify the required parameter 'toolName' is set
            if (toolName == null)
                throw new ApiException(400, "Missing required parameter 'toolName' when calling ToolsApi->NewAiToolsIsToolDisabled");

            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->NewAiToolsIsToolDisabled");

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
                var exception = ExceptionFactory("NewAiToolsIsToolDisabled", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-list-custom-servers/">REST API Reference for NewAiToolsListCustomServers Operation</seealso>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        public Dictionary<string, Object> NewAiToolsListCustomServers(string entityId)
        {
            var localVarResponse = NewAiToolsListCustomServersWithHttpInfo(entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List custom servers
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-list-custom-servers/">REST API Reference for NewAiToolsListCustomServers Operation</seealso>
        /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>
        public ApiResponse<Dictionary<string, Object>> NewAiToolsListCustomServersWithHttpInfo(string entityId)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->NewAiToolsListCustomServers");

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
                var exception = ExceptionFactory("NewAiToolsListCustomServers", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-list-custom-servers/">REST API Reference for NewAiToolsListCustomServers Operation</seealso>
        /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>
        public async Task<Dictionary<string, Object>> NewAiToolsListCustomServersAsync(string entityId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiToolsListCustomServersWithHttpInfoAsync(entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List custom servers
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-list-custom-servers/">REST API Reference for NewAiToolsListCustomServers Operation</seealso>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>
        public async Task<ApiResponse<Dictionary<string, Object>>> NewAiToolsListCustomServersWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->NewAiToolsListCustomServers");

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
                var exception = ExceptionFactory("NewAiToolsListCustomServers", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-list-system-tools/">REST API Reference for NewAiToolsListSystemTools Operation</seealso>
        /// <returns>Dictionary&lt;string, List&lt;NewAiTMCPItem&gt;&gt;</returns>
        public Dictionary<string, List<NewAiTMCPItem>> NewAiToolsListSystemTools(string entityId)
        {
            var localVarResponse = NewAiToolsListSystemToolsWithHttpInfo(entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List system tools
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-list-system-tools/">REST API Reference for NewAiToolsListSystemTools Operation</seealso>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;NewAiTMCPItem&gt;&gt;</returns>
        public ApiResponse<Dictionary<string, List<NewAiTMCPItem>>> NewAiToolsListSystemToolsWithHttpInfo(string entityId)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->NewAiToolsListSystemTools");

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
            var localVarResponse = Client.Get<Dictionary<string, List<NewAiTMCPItem>>>("/api/2.0/ai/tools/list-system-tools", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiToolsListSystemTools", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-list-system-tools/">REST API Reference for NewAiToolsListSystemTools Operation</seealso>
        /// <returns>Task of Dictionary&lt;string, List&lt;NewAiTMCPItem&gt;&gt;</returns>
        public async Task<Dictionary<string, List<NewAiTMCPItem>>> NewAiToolsListSystemToolsAsync(string entityId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiToolsListSystemToolsWithHttpInfoAsync(entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List system tools
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-list-system-tools/">REST API Reference for NewAiToolsListSystemTools Operation</seealso>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, List&lt;NewAiTMCPItem&gt;&gt;)</returns>
        public async Task<ApiResponse<Dictionary<string, List<NewAiTMCPItem>>>> NewAiToolsListSystemToolsWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->NewAiToolsListSystemTools");

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

            var localVarResponse = await AsynchronousClient.GetAsync<Dictionary<string, List<NewAiTMCPItem>>>("/api/2.0/ai/tools/list-system-tools", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiToolsListSystemTools", localVarResponse);
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
        /// <param name="newAiToolsRemoveCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-remove-custom-server/">REST API Reference for NewAiToolsRemoveCustomServer Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        public NewAiSuccessResponse NewAiToolsRemoveCustomServer(NewAiToolsRemoveCustomServerRequest newAiToolsRemoveCustomServerRequest)
        {
            var localVarResponse = NewAiToolsRemoveCustomServerWithHttpInfo(newAiToolsRemoveCustomServerRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsRemoveCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-remove-custom-server/">REST API Reference for NewAiToolsRemoveCustomServer Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        public ApiResponse<NewAiSuccessResponse> NewAiToolsRemoveCustomServerWithHttpInfo(NewAiToolsRemoveCustomServerRequest newAiToolsRemoveCustomServerRequest)
        {
            // verify the required parameter 'newAiToolsRemoveCustomServerRequest' is set
            if (newAiToolsRemoveCustomServerRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiToolsRemoveCustomServerRequest' when calling ToolsApi->NewAiToolsRemoveCustomServer");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiToolsRemoveCustomServerRequest != null) localVarRequestOptions.Data = newAiToolsRemoveCustomServerRequest;


            // make the HTTP request
            var localVarResponse = Client.Delete<NewAiSuccessResponse>("/api/2.0/ai/tools/remove-custom-server", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiToolsRemoveCustomServer", localVarResponse);
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
        /// <param name="newAiToolsRemoveCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-remove-custom-server/">REST API Reference for NewAiToolsRemoveCustomServer Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        public async Task<NewAiSuccessResponse> NewAiToolsRemoveCustomServerAsync(NewAiToolsRemoveCustomServerRequest newAiToolsRemoveCustomServerRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiToolsRemoveCustomServerWithHttpInfoAsync(newAiToolsRemoveCustomServerRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsRemoveCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-remove-custom-server/">REST API Reference for NewAiToolsRemoveCustomServer Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        public async Task<ApiResponse<NewAiSuccessResponse>> NewAiToolsRemoveCustomServerWithHttpInfoAsync(NewAiToolsRemoveCustomServerRequest newAiToolsRemoveCustomServerRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiToolsRemoveCustomServerRequest' is set
            if (newAiToolsRemoveCustomServerRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiToolsRemoveCustomServerRequest' when calling ToolsApi->NewAiToolsRemoveCustomServer");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiToolsRemoveCustomServerRequest != null) localVarRequestOptions.Data = newAiToolsRemoveCustomServerRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<NewAiSuccessResponse>("/api/2.0/ai/tools/remove-custom-server", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiToolsRemoveCustomServer", localVarResponse);
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
        /// <param name="newAiToolsReplaceAllCustomServersRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-replace-all-custom-servers/">REST API Reference for NewAiToolsReplaceAllCustomServers Operation</seealso>
        /// <returns>NewAiToolsBulkResult</returns>
        public NewAiToolsBulkResult NewAiToolsReplaceAllCustomServers(NewAiToolsReplaceAllCustomServersRequest newAiToolsReplaceAllCustomServersRequest)
        {
            var localVarResponse = NewAiToolsReplaceAllCustomServersWithHttpInfo(newAiToolsReplaceAllCustomServersRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Replace all custom servers
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsReplaceAllCustomServersRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-replace-all-custom-servers/">REST API Reference for NewAiToolsReplaceAllCustomServers Operation</seealso>
        /// <returns>ApiResponse of NewAiToolsBulkResult</returns>
        public ApiResponse<NewAiToolsBulkResult> NewAiToolsReplaceAllCustomServersWithHttpInfo(NewAiToolsReplaceAllCustomServersRequest newAiToolsReplaceAllCustomServersRequest)
        {
            // verify the required parameter 'newAiToolsReplaceAllCustomServersRequest' is set
            if (newAiToolsReplaceAllCustomServersRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiToolsReplaceAllCustomServersRequest' when calling ToolsApi->NewAiToolsReplaceAllCustomServers");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiToolsReplaceAllCustomServersRequest != null) localVarRequestOptions.Data = newAiToolsReplaceAllCustomServersRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<NewAiToolsBulkResult>("/api/2.0/ai/tools/replace-all-custom-servers", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiToolsReplaceAllCustomServers", localVarResponse);
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
        /// <param name="newAiToolsReplaceAllCustomServersRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-replace-all-custom-servers/">REST API Reference for NewAiToolsReplaceAllCustomServers Operation</seealso>
        /// <returns>Task of NewAiToolsBulkResult</returns>
        public async Task<NewAiToolsBulkResult> NewAiToolsReplaceAllCustomServersAsync(NewAiToolsReplaceAllCustomServersRequest newAiToolsReplaceAllCustomServersRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiToolsReplaceAllCustomServersWithHttpInfoAsync(newAiToolsReplaceAllCustomServersRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Replace all custom servers
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsReplaceAllCustomServersRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-replace-all-custom-servers/">REST API Reference for NewAiToolsReplaceAllCustomServers Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiToolsBulkResult)</returns>
        public async Task<ApiResponse<NewAiToolsBulkResult>> NewAiToolsReplaceAllCustomServersWithHttpInfoAsync(NewAiToolsReplaceAllCustomServersRequest newAiToolsReplaceAllCustomServersRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiToolsReplaceAllCustomServersRequest' is set
            if (newAiToolsReplaceAllCustomServersRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiToolsReplaceAllCustomServersRequest' when calling ToolsApi->NewAiToolsReplaceAllCustomServers");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiToolsReplaceAllCustomServersRequest != null) localVarRequestOptions.Data = newAiToolsReplaceAllCustomServersRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<NewAiToolsBulkResult>("/api/2.0/ai/tools/replace-all-custom-servers", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiToolsReplaceAllCustomServers", localVarResponse);
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
        /// <param name="newAiToolsSetAllowAlwaysRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-set-allow-always/">REST API Reference for NewAiToolsSetAllowAlways Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        public NewAiSuccessResponse NewAiToolsSetAllowAlways(NewAiToolsSetAllowAlwaysRequest newAiToolsSetAllowAlwaysRequest)
        {
            var localVarResponse = NewAiToolsSetAllowAlwaysWithHttpInfo(newAiToolsSetAllowAlwaysRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set allow always
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsSetAllowAlwaysRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-set-allow-always/">REST API Reference for NewAiToolsSetAllowAlways Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        public ApiResponse<NewAiSuccessResponse> NewAiToolsSetAllowAlwaysWithHttpInfo(NewAiToolsSetAllowAlwaysRequest newAiToolsSetAllowAlwaysRequest)
        {
            // verify the required parameter 'newAiToolsSetAllowAlwaysRequest' is set
            if (newAiToolsSetAllowAlwaysRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiToolsSetAllowAlwaysRequest' when calling ToolsApi->NewAiToolsSetAllowAlways");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiToolsSetAllowAlwaysRequest != null) localVarRequestOptions.Data = newAiToolsSetAllowAlwaysRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<NewAiSuccessResponse>("/api/2.0/ai/tools/set-allow-always", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiToolsSetAllowAlways", localVarResponse);
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
        /// <param name="newAiToolsSetAllowAlwaysRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-set-allow-always/">REST API Reference for NewAiToolsSetAllowAlways Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        public async Task<NewAiSuccessResponse> NewAiToolsSetAllowAlwaysAsync(NewAiToolsSetAllowAlwaysRequest newAiToolsSetAllowAlwaysRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiToolsSetAllowAlwaysWithHttpInfoAsync(newAiToolsSetAllowAlwaysRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set allow always
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsSetAllowAlwaysRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-set-allow-always/">REST API Reference for NewAiToolsSetAllowAlways Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        public async Task<ApiResponse<NewAiSuccessResponse>> NewAiToolsSetAllowAlwaysWithHttpInfoAsync(NewAiToolsSetAllowAlwaysRequest newAiToolsSetAllowAlwaysRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiToolsSetAllowAlwaysRequest' is set
            if (newAiToolsSetAllowAlwaysRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiToolsSetAllowAlwaysRequest' when calling ToolsApi->NewAiToolsSetAllowAlways");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiToolsSetAllowAlwaysRequest != null) localVarRequestOptions.Data = newAiToolsSetAllowAlwaysRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<NewAiSuccessResponse>("/api/2.0/ai/tools/set-allow-always", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiToolsSetAllowAlways", localVarResponse);
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
        /// <param name="newAiToolsSetDisabledRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-set-disabled/">REST API Reference for NewAiToolsSetDisabled Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        public NewAiSuccessResponse NewAiToolsSetDisabled(NewAiToolsSetDisabledRequest newAiToolsSetDisabledRequest)
        {
            var localVarResponse = NewAiToolsSetDisabledWithHttpInfo(newAiToolsSetDisabledRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set disabled
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsSetDisabledRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-set-disabled/">REST API Reference for NewAiToolsSetDisabled Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        public ApiResponse<NewAiSuccessResponse> NewAiToolsSetDisabledWithHttpInfo(NewAiToolsSetDisabledRequest newAiToolsSetDisabledRequest)
        {
            // verify the required parameter 'newAiToolsSetDisabledRequest' is set
            if (newAiToolsSetDisabledRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiToolsSetDisabledRequest' when calling ToolsApi->NewAiToolsSetDisabled");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiToolsSetDisabledRequest != null) localVarRequestOptions.Data = newAiToolsSetDisabledRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<NewAiSuccessResponse>("/api/2.0/ai/tools/set-disabled", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiToolsSetDisabled", localVarResponse);
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
        /// <param name="newAiToolsSetDisabledRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-set-disabled/">REST API Reference for NewAiToolsSetDisabled Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        public async Task<NewAiSuccessResponse> NewAiToolsSetDisabledAsync(NewAiToolsSetDisabledRequest newAiToolsSetDisabledRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiToolsSetDisabledWithHttpInfoAsync(newAiToolsSetDisabledRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set disabled
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsSetDisabledRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-set-disabled/">REST API Reference for NewAiToolsSetDisabled Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        public async Task<ApiResponse<NewAiSuccessResponse>> NewAiToolsSetDisabledWithHttpInfoAsync(NewAiToolsSetDisabledRequest newAiToolsSetDisabledRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiToolsSetDisabledRequest' is set
            if (newAiToolsSetDisabledRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiToolsSetDisabledRequest' when calling ToolsApi->NewAiToolsSetDisabled");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiToolsSetDisabledRequest != null) localVarRequestOptions.Data = newAiToolsSetDisabledRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<NewAiSuccessResponse>("/api/2.0/ai/tools/set-disabled", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiToolsSetDisabled", localVarResponse);
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
        /// <param name="newAiToolsUpdateCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-update-custom-server/">REST API Reference for NewAiToolsUpdateCustomServer Operation</seealso>
        /// <returns>NewAiToolsMutationResult</returns>
        public NewAiToolsMutationResult NewAiToolsUpdateCustomServer(NewAiToolsUpdateCustomServerRequest newAiToolsUpdateCustomServerRequest)
        {
            var localVarResponse = NewAiToolsUpdateCustomServerWithHttpInfo(newAiToolsUpdateCustomServerRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsUpdateCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-update-custom-server/">REST API Reference for NewAiToolsUpdateCustomServer Operation</seealso>
        /// <returns>ApiResponse of NewAiToolsMutationResult</returns>
        public ApiResponse<NewAiToolsMutationResult> NewAiToolsUpdateCustomServerWithHttpInfo(NewAiToolsUpdateCustomServerRequest newAiToolsUpdateCustomServerRequest)
        {
            // verify the required parameter 'newAiToolsUpdateCustomServerRequest' is set
            if (newAiToolsUpdateCustomServerRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiToolsUpdateCustomServerRequest' when calling ToolsApi->NewAiToolsUpdateCustomServer");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiToolsUpdateCustomServerRequest != null) localVarRequestOptions.Data = newAiToolsUpdateCustomServerRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<NewAiToolsMutationResult>("/api/2.0/ai/tools/update-custom-server", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiToolsUpdateCustomServer", localVarResponse);
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
        /// <param name="newAiToolsUpdateCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-update-custom-server/">REST API Reference for NewAiToolsUpdateCustomServer Operation</seealso>
        /// <returns>Task of NewAiToolsMutationResult</returns>
        public async Task<NewAiToolsMutationResult> NewAiToolsUpdateCustomServerAsync(NewAiToolsUpdateCustomServerRequest newAiToolsUpdateCustomServerRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiToolsUpdateCustomServerWithHttpInfoAsync(newAiToolsUpdateCustomServerRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiToolsUpdateCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-update-custom-server/">REST API Reference for NewAiToolsUpdateCustomServer Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiToolsMutationResult)</returns>
        public async Task<ApiResponse<NewAiToolsMutationResult>> NewAiToolsUpdateCustomServerWithHttpInfoAsync(NewAiToolsUpdateCustomServerRequest newAiToolsUpdateCustomServerRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiToolsUpdateCustomServerRequest' is set
            if (newAiToolsUpdateCustomServerRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiToolsUpdateCustomServerRequest' when calling ToolsApi->NewAiToolsUpdateCustomServer");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiToolsUpdateCustomServerRequest != null) localVarRequestOptions.Data = newAiToolsUpdateCustomServerRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<NewAiToolsMutationResult>("/api/2.0/ai/tools/update-custom-server", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiToolsUpdateCustomServer", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
