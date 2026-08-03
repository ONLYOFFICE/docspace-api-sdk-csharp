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
    public interface IAssignmentsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Assign
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAssignmentsAssignRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-assign/">REST API Reference for NewAiAssignmentsAssign Operation</seealso>
        /// <returns>NewAiAssignmentMutationResult</returns>
        NewAiAssignmentMutationResult NewAiAssignmentsAssign(NewAiAssignmentsAssignRequest newAiAssignmentsAssignRequest);

        /// <summary>
        /// Assign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAssignmentsAssignRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-assign/">REST API Reference for NewAiAssignmentsAssign Operation</seealso>
        /// <returns>ApiResponse of NewAiAssignmentMutationResult</returns>
        ApiResponse<NewAiAssignmentMutationResult> NewAiAssignmentsAssignWithHttpInfo(NewAiAssignmentsAssignRequest newAiAssignmentsAssignRequest);
        /// <summary>
        /// Bulk assign
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-bulk-assign/">REST API Reference for NewAiAssignmentsBulkAssign Operation</seealso>
        /// <returns>NewAiBulkAssignmentResult</returns>
        NewAiBulkAssignmentResult NewAiAssignmentsBulkAssign(Dictionary<string, string> requestBody);

        /// <summary>
        /// Bulk assign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-bulk-assign/">REST API Reference for NewAiAssignmentsBulkAssign Operation</seealso>
        /// <returns>ApiResponse of NewAiBulkAssignmentResult</returns>
        ApiResponse<NewAiBulkAssignmentResult> NewAiAssignmentsBulkAssignWithHttpInfo(Dictionary<string, string> requestBody);
        /// <summary>
        /// Cascade profile delete
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-cascade-profile-delete/">REST API Reference for NewAiAssignmentsCascadeProfileDelete Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        NewAiSuccessResponse NewAiAssignmentsCascadeProfileDelete(string body);

        /// <summary>
        /// Cascade profile delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-cascade-profile-delete/">REST API Reference for NewAiAssignmentsCascadeProfileDelete Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        ApiResponse<NewAiSuccessResponse> NewAiAssignmentsCascadeProfileDeleteWithHttpInfo(string body);
        /// <summary>
        /// Get all assignments
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-get-all-assignments/">REST API Reference for NewAiAssignmentsGetAllAssignments Operation</seealso>
        /// <returns>Dictionary&lt;string, string&gt;</returns>
        Dictionary<string, string> NewAiAssignmentsGetAllAssignments(string entityId);

        /// <summary>
        /// Get all assignments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-get-all-assignments/">REST API Reference for NewAiAssignmentsGetAllAssignments Operation</seealso>
        /// <returns>ApiResponse of Dictionary&lt;string, string&gt;</returns>
        ApiResponse<Dictionary<string, string>> NewAiAssignmentsGetAllAssignmentsWithHttpInfo(string entityId);
        /// <summary>
        /// Get assignment
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-get-assignment/">REST API Reference for NewAiAssignmentsGetAssignment Operation</seealso>
        /// <returns>string</returns>
        string NewAiAssignmentsGetAssignment(string actionType);

        /// <summary>
        /// Get assignment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-get-assignment/">REST API Reference for NewAiAssignmentsGetAssignment Operation</seealso>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> NewAiAssignmentsGetAssignmentWithHttpInfo(string actionType);
        /// <summary>
        /// Resolve for action
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-resolve-for-action/">REST API Reference for NewAiAssignmentsResolveForAction Operation</seealso>
        /// <returns>NewAiResolvedAssignment</returns>
        NewAiResolvedAssignment NewAiAssignmentsResolveForAction(string actionType, string entityId);

        /// <summary>
        /// Resolve for action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-resolve-for-action/">REST API Reference for NewAiAssignmentsResolveForAction Operation</seealso>
        /// <returns>ApiResponse of NewAiResolvedAssignment</returns>
        ApiResponse<NewAiResolvedAssignment> NewAiAssignmentsResolveForActionWithHttpInfo(string actionType, string entityId);
        /// <summary>
        /// Try resolve for action
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-try-resolve-for-action/">REST API Reference for NewAiAssignmentsTryResolveForAction Operation</seealso>
        /// <returns>NewAiResolvedAssignment</returns>
        NewAiResolvedAssignment NewAiAssignmentsTryResolveForAction(string actionType, string entityId);

        /// <summary>
        /// Try resolve for action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-try-resolve-for-action/">REST API Reference for NewAiAssignmentsTryResolveForAction Operation</seealso>
        /// <returns>ApiResponse of NewAiResolvedAssignment</returns>
        ApiResponse<NewAiResolvedAssignment> NewAiAssignmentsTryResolveForActionWithHttpInfo(string actionType, string entityId);
        /// <summary>
        /// Unassign
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-unassign/">REST API Reference for NewAiAssignmentsUnassign Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        NewAiSuccessResponse NewAiAssignmentsUnassign(string body);

        /// <summary>
        /// Unassign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-unassign/">REST API Reference for NewAiAssignmentsUnassign Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        ApiResponse<NewAiSuccessResponse> NewAiAssignmentsUnassignWithHttpInfo(string body);
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
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAssignmentsAssignRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-assign/">REST API Reference for NewAiAssignmentsAssign Operation</seealso>
        /// <returns>Task of NewAiAssignmentMutationResult</returns>
        Task<NewAiAssignmentMutationResult> NewAiAssignmentsAssignAsync(NewAiAssignmentsAssignRequest newAiAssignmentsAssignRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Assign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAssignmentsAssignRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-assign/">REST API Reference for NewAiAssignmentsAssign Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiAssignmentMutationResult)</returns>
        Task<ApiResponse<NewAiAssignmentMutationResult>> NewAiAssignmentsAssignWithHttpInfoAsync(NewAiAssignmentsAssignRequest newAiAssignmentsAssignRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk assign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-bulk-assign/">REST API Reference for NewAiAssignmentsBulkAssign Operation</seealso>
        /// <returns>Task of NewAiBulkAssignmentResult</returns>
        Task<NewAiBulkAssignmentResult> NewAiAssignmentsBulkAssignAsync(Dictionary<string, string> requestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Bulk assign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-bulk-assign/">REST API Reference for NewAiAssignmentsBulkAssign Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiBulkAssignmentResult)</returns>
        Task<ApiResponse<NewAiBulkAssignmentResult>> NewAiAssignmentsBulkAssignWithHttpInfoAsync(Dictionary<string, string> requestBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Cascade profile delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-cascade-profile-delete/">REST API Reference for NewAiAssignmentsCascadeProfileDelete Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        Task<NewAiSuccessResponse> NewAiAssignmentsCascadeProfileDeleteAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Cascade profile delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-cascade-profile-delete/">REST API Reference for NewAiAssignmentsCascadeProfileDelete Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        Task<ApiResponse<NewAiSuccessResponse>> NewAiAssignmentsCascadeProfileDeleteWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get all assignments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-get-all-assignments/">REST API Reference for NewAiAssignmentsGetAllAssignments Operation</seealso>
        /// <returns>Task of Dictionary&lt;string, string&gt;</returns>
        Task<Dictionary<string, string>> NewAiAssignmentsGetAllAssignmentsAsync(string entityId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get all assignments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-get-all-assignments/">REST API Reference for NewAiAssignmentsGetAllAssignments Operation</seealso>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, string&gt;)</returns>
        Task<ApiResponse<Dictionary<string, string>>> NewAiAssignmentsGetAllAssignmentsWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get assignment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-get-assignment/">REST API Reference for NewAiAssignmentsGetAssignment Operation</seealso>
        /// <returns>Task of string</returns>
        Task<string> NewAiAssignmentsGetAssignmentAsync(string actionType, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get assignment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-get-assignment/">REST API Reference for NewAiAssignmentsGetAssignment Operation</seealso>
        /// <returns>Task of ApiResponse (string)</returns>
        Task<ApiResponse<string>> NewAiAssignmentsGetAssignmentWithHttpInfoAsync(string actionType, CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolve for action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-resolve-for-action/">REST API Reference for NewAiAssignmentsResolveForAction Operation</seealso>
        /// <returns>Task of NewAiResolvedAssignment</returns>
        Task<NewAiResolvedAssignment> NewAiAssignmentsResolveForActionAsync(string actionType, string entityId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Resolve for action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-resolve-for-action/">REST API Reference for NewAiAssignmentsResolveForAction Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiResolvedAssignment)</returns>
        Task<ApiResponse<NewAiResolvedAssignment>> NewAiAssignmentsResolveForActionWithHttpInfoAsync(string actionType, string entityId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Try resolve for action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-try-resolve-for-action/">REST API Reference for NewAiAssignmentsTryResolveForAction Operation</seealso>
        /// <returns>Task of NewAiResolvedAssignment</returns>
        Task<NewAiResolvedAssignment> NewAiAssignmentsTryResolveForActionAsync(string actionType, string entityId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Try resolve for action
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-try-resolve-for-action/">REST API Reference for NewAiAssignmentsTryResolveForAction Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiResolvedAssignment)</returns>
        Task<ApiResponse<NewAiResolvedAssignment>> NewAiAssignmentsTryResolveForActionWithHttpInfoAsync(string actionType, string entityId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Unassign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-unassign/">REST API Reference for NewAiAssignmentsUnassign Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        Task<NewAiSuccessResponse> NewAiAssignmentsUnassignAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Unassign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-unassign/">REST API Reference for NewAiAssignmentsUnassign Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        Task<ApiResponse<NewAiSuccessResponse>> NewAiAssignmentsUnassignWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAssignmentsAssignRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-assign/">REST API Reference for NewAiAssignmentsAssign Operation</seealso>
        /// <returns>NewAiAssignmentMutationResult</returns>
        public NewAiAssignmentMutationResult NewAiAssignmentsAssign(NewAiAssignmentsAssignRequest newAiAssignmentsAssignRequest)
        {
            var localVarResponse = NewAiAssignmentsAssignWithHttpInfo(newAiAssignmentsAssignRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Assign
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAssignmentsAssignRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-assign/">REST API Reference for NewAiAssignmentsAssign Operation</seealso>
        /// <returns>ApiResponse of NewAiAssignmentMutationResult</returns>
        public ApiResponse<NewAiAssignmentMutationResult> NewAiAssignmentsAssignWithHttpInfo(NewAiAssignmentsAssignRequest newAiAssignmentsAssignRequest)
        {
            // verify the required parameter 'newAiAssignmentsAssignRequest' is set
            if (newAiAssignmentsAssignRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAssignmentsAssignRequest' when calling AssignmentsApi->NewAiAssignmentsAssign");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAssignmentsAssignRequest != null) localVarRequestOptions.Data = newAiAssignmentsAssignRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<NewAiAssignmentMutationResult>("/api/2.0/ai/assignments/assign", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAssignmentsAssign", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAssignmentsAssignRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-assign/">REST API Reference for NewAiAssignmentsAssign Operation</seealso>
        /// <returns>Task of NewAiAssignmentMutationResult</returns>
        public async Task<NewAiAssignmentMutationResult> NewAiAssignmentsAssignAsync(NewAiAssignmentsAssignRequest newAiAssignmentsAssignRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAssignmentsAssignWithHttpInfoAsync(newAiAssignmentsAssignRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Assign
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAssignmentsAssignRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-assign/">REST API Reference for NewAiAssignmentsAssign Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiAssignmentMutationResult)</returns>
        public async Task<ApiResponse<NewAiAssignmentMutationResult>> NewAiAssignmentsAssignWithHttpInfoAsync(NewAiAssignmentsAssignRequest newAiAssignmentsAssignRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiAssignmentsAssignRequest' is set
            if (newAiAssignmentsAssignRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAssignmentsAssignRequest' when calling AssignmentsApi->NewAiAssignmentsAssign");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAssignmentsAssignRequest != null) localVarRequestOptions.Data = newAiAssignmentsAssignRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<NewAiAssignmentMutationResult>("/api/2.0/ai/assignments/assign", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAssignmentsAssign", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-bulk-assign/">REST API Reference for NewAiAssignmentsBulkAssign Operation</seealso>
        /// <returns>NewAiBulkAssignmentResult</returns>
        public NewAiBulkAssignmentResult NewAiAssignmentsBulkAssign(Dictionary<string, string> requestBody)
        {
            var localVarResponse = NewAiAssignmentsBulkAssignWithHttpInfo(requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk assign
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-bulk-assign/">REST API Reference for NewAiAssignmentsBulkAssign Operation</seealso>
        /// <returns>ApiResponse of NewAiBulkAssignmentResult</returns>
        public ApiResponse<NewAiBulkAssignmentResult> NewAiAssignmentsBulkAssignWithHttpInfo(Dictionary<string, string> requestBody)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling AssignmentsApi->NewAiAssignmentsBulkAssign");

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
            var localVarResponse = Client.Put<NewAiBulkAssignmentResult>("/api/2.0/ai/assignments/bulk-assign", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAssignmentsBulkAssign", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-bulk-assign/">REST API Reference for NewAiAssignmentsBulkAssign Operation</seealso>
        /// <returns>Task of NewAiBulkAssignmentResult</returns>
        public async Task<NewAiBulkAssignmentResult> NewAiAssignmentsBulkAssignAsync(Dictionary<string, string> requestBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAssignmentsBulkAssignWithHttpInfoAsync(requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk assign
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-bulk-assign/">REST API Reference for NewAiAssignmentsBulkAssign Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiBulkAssignmentResult)</returns>
        public async Task<ApiResponse<NewAiBulkAssignmentResult>> NewAiAssignmentsBulkAssignWithHttpInfoAsync(Dictionary<string, string> requestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling AssignmentsApi->NewAiAssignmentsBulkAssign");

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

            var localVarResponse = await AsynchronousClient.PutAsync<NewAiBulkAssignmentResult>("/api/2.0/ai/assignments/bulk-assign", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAssignmentsBulkAssign", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-cascade-profile-delete/">REST API Reference for NewAiAssignmentsCascadeProfileDelete Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        public NewAiSuccessResponse NewAiAssignmentsCascadeProfileDelete(string body)
        {
            var localVarResponse = NewAiAssignmentsCascadeProfileDeleteWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Cascade profile delete
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-cascade-profile-delete/">REST API Reference for NewAiAssignmentsCascadeProfileDelete Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        public ApiResponse<NewAiSuccessResponse> NewAiAssignmentsCascadeProfileDeleteWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AssignmentsApi->NewAiAssignmentsCascadeProfileDelete");

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
            var localVarResponse = Client.Delete<NewAiSuccessResponse>("/api/2.0/ai/assignments/cascade-profile-delete", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAssignmentsCascadeProfileDelete", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-cascade-profile-delete/">REST API Reference for NewAiAssignmentsCascadeProfileDelete Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        public async Task<NewAiSuccessResponse> NewAiAssignmentsCascadeProfileDeleteAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAssignmentsCascadeProfileDeleteWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Cascade profile delete
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-cascade-profile-delete/">REST API Reference for NewAiAssignmentsCascadeProfileDelete Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        public async Task<ApiResponse<NewAiSuccessResponse>> NewAiAssignmentsCascadeProfileDeleteWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AssignmentsApi->NewAiAssignmentsCascadeProfileDelete");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<NewAiSuccessResponse>("/api/2.0/ai/assignments/cascade-profile-delete", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAssignmentsCascadeProfileDelete", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-get-all-assignments/">REST API Reference for NewAiAssignmentsGetAllAssignments Operation</seealso>
        /// <returns>Dictionary&lt;string, string&gt;</returns>
        public Dictionary<string, string> NewAiAssignmentsGetAllAssignments(string entityId)
        {
            var localVarResponse = NewAiAssignmentsGetAllAssignmentsWithHttpInfo(entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all assignments
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-get-all-assignments/">REST API Reference for NewAiAssignmentsGetAllAssignments Operation</seealso>
        /// <returns>ApiResponse of Dictionary&lt;string, string&gt;</returns>
        public ApiResponse<Dictionary<string, string>> NewAiAssignmentsGetAllAssignmentsWithHttpInfo(string entityId)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling AssignmentsApi->NewAiAssignmentsGetAllAssignments");

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
            var localVarResponse = Client.Get<Dictionary<string, string>>("/api/2.0/ai/assignments/get-all-assignments", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAssignmentsGetAllAssignments", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-get-all-assignments/">REST API Reference for NewAiAssignmentsGetAllAssignments Operation</seealso>
        /// <returns>Task of Dictionary&lt;string, string&gt;</returns>
        public async Task<Dictionary<string, string>> NewAiAssignmentsGetAllAssignmentsAsync(string entityId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAssignmentsGetAllAssignmentsWithHttpInfoAsync(entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all assignments
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-get-all-assignments/">REST API Reference for NewAiAssignmentsGetAllAssignments Operation</seealso>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, string&gt;)</returns>
        public async Task<ApiResponse<Dictionary<string, string>>> NewAiAssignmentsGetAllAssignmentsWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling AssignmentsApi->NewAiAssignmentsGetAllAssignments");

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

            var localVarResponse = await AsynchronousClient.GetAsync<Dictionary<string, string>>("/api/2.0/ai/assignments/get-all-assignments", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAssignmentsGetAllAssignments", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-get-assignment/">REST API Reference for NewAiAssignmentsGetAssignment Operation</seealso>
        /// <returns>string</returns>
        public string NewAiAssignmentsGetAssignment(string actionType)
        {
            var localVarResponse = NewAiAssignmentsGetAssignmentWithHttpInfo(actionType);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get assignment
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-get-assignment/">REST API Reference for NewAiAssignmentsGetAssignment Operation</seealso>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse<string> NewAiAssignmentsGetAssignmentWithHttpInfo(string actionType)
        {
            // verify the required parameter 'actionType' is set
            if (actionType == null)
                throw new ApiException(400, "Missing required parameter 'actionType' when calling AssignmentsApi->NewAiAssignmentsGetAssignment");

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
                var exception = ExceptionFactory("NewAiAssignmentsGetAssignment", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-get-assignment/">REST API Reference for NewAiAssignmentsGetAssignment Operation</seealso>
        /// <returns>Task of string</returns>
        public async Task<string> NewAiAssignmentsGetAssignmentAsync(string actionType, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAssignmentsGetAssignmentWithHttpInfoAsync(actionType, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get assignment
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-get-assignment/">REST API Reference for NewAiAssignmentsGetAssignment Operation</seealso>
        /// <returns>Task of ApiResponse (string)</returns>
        public async Task<ApiResponse<string>> NewAiAssignmentsGetAssignmentWithHttpInfoAsync(string actionType, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'actionType' is set
            if (actionType == null)
                throw new ApiException(400, "Missing required parameter 'actionType' when calling AssignmentsApi->NewAiAssignmentsGetAssignment");

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
                var exception = ExceptionFactory("NewAiAssignmentsGetAssignment", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-resolve-for-action/">REST API Reference for NewAiAssignmentsResolveForAction Operation</seealso>
        /// <returns>NewAiResolvedAssignment</returns>
        public NewAiResolvedAssignment NewAiAssignmentsResolveForAction(string actionType, string entityId)
        {
            var localVarResponse = NewAiAssignmentsResolveForActionWithHttpInfo(actionType, entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Resolve for action
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-resolve-for-action/">REST API Reference for NewAiAssignmentsResolveForAction Operation</seealso>
        /// <returns>ApiResponse of NewAiResolvedAssignment</returns>
        public ApiResponse<NewAiResolvedAssignment> NewAiAssignmentsResolveForActionWithHttpInfo(string actionType, string entityId)
        {
            // verify the required parameter 'actionType' is set
            if (actionType == null)
                throw new ApiException(400, "Missing required parameter 'actionType' when calling AssignmentsApi->NewAiAssignmentsResolveForAction");

            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling AssignmentsApi->NewAiAssignmentsResolveForAction");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "actionType", actionType));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));


            // make the HTTP request
            var localVarResponse = Client.Get<NewAiResolvedAssignment>("/api/2.0/ai/assignments/resolve-for-action", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAssignmentsResolveForAction", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-resolve-for-action/">REST API Reference for NewAiAssignmentsResolveForAction Operation</seealso>
        /// <returns>Task of NewAiResolvedAssignment</returns>
        public async Task<NewAiResolvedAssignment> NewAiAssignmentsResolveForActionAsync(string actionType, string entityId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAssignmentsResolveForActionWithHttpInfoAsync(actionType, entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Resolve for action
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-resolve-for-action/">REST API Reference for NewAiAssignmentsResolveForAction Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiResolvedAssignment)</returns>
        public async Task<ApiResponse<NewAiResolvedAssignment>> NewAiAssignmentsResolveForActionWithHttpInfoAsync(string actionType, string entityId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'actionType' is set
            if (actionType == null)
                throw new ApiException(400, "Missing required parameter 'actionType' when calling AssignmentsApi->NewAiAssignmentsResolveForAction");

            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling AssignmentsApi->NewAiAssignmentsResolveForAction");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "actionType", actionType));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<NewAiResolvedAssignment>("/api/2.0/ai/assignments/resolve-for-action", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAssignmentsResolveForAction", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-try-resolve-for-action/">REST API Reference for NewAiAssignmentsTryResolveForAction Operation</seealso>
        /// <returns>NewAiResolvedAssignment</returns>
        public NewAiResolvedAssignment NewAiAssignmentsTryResolveForAction(string actionType, string entityId)
        {
            var localVarResponse = NewAiAssignmentsTryResolveForActionWithHttpInfo(actionType, entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Try resolve for action
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-try-resolve-for-action/">REST API Reference for NewAiAssignmentsTryResolveForAction Operation</seealso>
        /// <returns>ApiResponse of NewAiResolvedAssignment</returns>
        public ApiResponse<NewAiResolvedAssignment> NewAiAssignmentsTryResolveForActionWithHttpInfo(string actionType, string entityId)
        {
            // verify the required parameter 'actionType' is set
            if (actionType == null)
                throw new ApiException(400, "Missing required parameter 'actionType' when calling AssignmentsApi->NewAiAssignmentsTryResolveForAction");

            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling AssignmentsApi->NewAiAssignmentsTryResolveForAction");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "actionType", actionType));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));


            // make the HTTP request
            var localVarResponse = Client.Get<NewAiResolvedAssignment>("/api/2.0/ai/assignments/try-resolve-for-action", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAssignmentsTryResolveForAction", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-try-resolve-for-action/">REST API Reference for NewAiAssignmentsTryResolveForAction Operation</seealso>
        /// <returns>Task of NewAiResolvedAssignment</returns>
        public async Task<NewAiResolvedAssignment> NewAiAssignmentsTryResolveForActionAsync(string actionType, string entityId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAssignmentsTryResolveForActionWithHttpInfoAsync(actionType, entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Try resolve for action
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-try-resolve-for-action/">REST API Reference for NewAiAssignmentsTryResolveForAction Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiResolvedAssignment)</returns>
        public async Task<ApiResponse<NewAiResolvedAssignment>> NewAiAssignmentsTryResolveForActionWithHttpInfoAsync(string actionType, string entityId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'actionType' is set
            if (actionType == null)
                throw new ApiException(400, "Missing required parameter 'actionType' when calling AssignmentsApi->NewAiAssignmentsTryResolveForAction");

            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling AssignmentsApi->NewAiAssignmentsTryResolveForAction");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "actionType", actionType));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<NewAiResolvedAssignment>("/api/2.0/ai/assignments/try-resolve-for-action", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAssignmentsTryResolveForAction", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-unassign/">REST API Reference for NewAiAssignmentsUnassign Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        public NewAiSuccessResponse NewAiAssignmentsUnassign(string body)
        {
            var localVarResponse = NewAiAssignmentsUnassignWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Unassign
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-unassign/">REST API Reference for NewAiAssignmentsUnassign Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        public ApiResponse<NewAiSuccessResponse> NewAiAssignmentsUnassignWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AssignmentsApi->NewAiAssignmentsUnassign");

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
            var localVarResponse = Client.Delete<NewAiSuccessResponse>("/api/2.0/ai/assignments/unassign", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAssignmentsUnassign", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-unassign/">REST API Reference for NewAiAssignmentsUnassign Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        public async Task<NewAiSuccessResponse> NewAiAssignmentsUnassignAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAssignmentsUnassignWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Unassign
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-assignments-unassign/">REST API Reference for NewAiAssignmentsUnassign Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        public async Task<ApiResponse<NewAiSuccessResponse>> NewAiAssignmentsUnassignWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AssignmentsApi->NewAiAssignmentsUnassign");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<NewAiSuccessResponse>("/api/2.0/ai/assignments/unassign", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAssignmentsUnassign", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
