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
    public interface IAgentsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-create/">REST API Reference for AiAgentsCreate Operation</seealso>
        /// <returns>AiFolderIntegerWrapper</returns>
        AiFolderIntegerWrapper AiAgentsCreate(AiAgentsCreateRequest aiAgentsCreateRequest);

        /// <summary>
        /// Create an agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-create/">REST API Reference for AiAgentsCreate Operation</seealso>
        /// <returns>ApiResponse of AiFolderIntegerWrapper</returns>
        ApiResponse<AiFolderIntegerWrapper> AiAgentsCreateWithHttpInfo(AiAgentsCreateRequest aiAgentsCreateRequest);
        /// <summary>
        /// Delete an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="aiAgentsDeleteRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-delete/">REST API Reference for AiAgentsDelete Operation</seealso>
        /// <returns>AiFileOperationWrapper</returns>
        AiFileOperationWrapper AiAgentsDelete(string id, AiAgentsDeleteRequest aiAgentsDeleteRequest);

        /// <summary>
        /// Delete an agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="aiAgentsDeleteRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-delete/">REST API Reference for AiAgentsDelete Operation</seealso>
        /// <returns>ApiResponse of AiFileOperationWrapper</returns>
        ApiResponse<AiFileOperationWrapper> AiAgentsDeleteWithHttpInfo(string id, AiAgentsDeleteRequest aiAgentsDeleteRequest);
        /// <summary>
        /// Get an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-get/">REST API Reference for AiAgentsGet Operation</seealso>
        /// <returns>AiFolderIntegerWrapper</returns>
        AiFolderIntegerWrapper AiAgentsGet(string id);

        /// <summary>
        /// Get an agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-get/">REST API Reference for AiAgentsGet Operation</seealso>
        /// <returns>ApiResponse of AiFolderIntegerWrapper</returns>
        ApiResponse<AiFolderIntegerWrapper> AiAgentsGetWithHttpInfo(string id);
        /// <summary>
        /// List agents
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-list/">REST API Reference for AiAgentsList Operation</seealso>
        /// <returns>AiFolderContentIntegerWrapper</returns>
        AiFolderContentIntegerWrapper AiAgentsList();

        /// <summary>
        /// List agents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-list/">REST API Reference for AiAgentsList Operation</seealso>
        /// <returns>ApiResponse of AiFolderContentIntegerWrapper</returns>
        ApiResponse<AiFolderContentIntegerWrapper> AiAgentsListWithHttpInfo();
        /// <summary>
        /// List agent news items
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-news/">REST API Reference for AiAgentsNews Operation</seealso>
        /// <returns>AiNewItemsAgentNewItemsArrayWrapper</returns>
        AiNewItemsAgentNewItemsArrayWrapper AiAgentsNews();

        /// <summary>
        /// List agent news items
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-news/">REST API Reference for AiAgentsNews Operation</seealso>
        /// <returns>ApiResponse of AiNewItemsAgentNewItemsArrayWrapper</returns>
        ApiResponse<AiNewItemsAgentNewItemsArrayWrapper> AiAgentsNewsWithHttpInfo();
        /// <summary>
        /// Reset agents' quota
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsResetQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-reset-quota/">REST API Reference for AiAgentsResetQuota Operation</seealso>
        /// <returns>AiFolderIntegerArrayWrapper</returns>
        AiFolderIntegerArrayWrapper AiAgentsResetQuota(AiAgentsResetQuotaRequest aiAgentsResetQuotaRequest);

        /// <summary>
        /// Reset agents' quota
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsResetQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-reset-quota/">REST API Reference for AiAgentsResetQuota Operation</seealso>
        /// <returns>ApiResponse of AiFolderIntegerArrayWrapper</returns>
        ApiResponse<AiFolderIntegerArrayWrapper> AiAgentsResetQuotaWithHttpInfo(AiAgentsResetQuotaRequest aiAgentsResetQuotaRequest);
        /// <summary>
        /// Update an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="aiAgentsUpdateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update/">REST API Reference for AiAgentsUpdate Operation</seealso>
        /// <returns>AiFolderIntegerWrapper</returns>
        AiFolderIntegerWrapper AiAgentsUpdate(string id, AiAgentsUpdateRequest aiAgentsUpdateRequest);

        /// <summary>
        /// Update an agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="aiAgentsUpdateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update/">REST API Reference for AiAgentsUpdate Operation</seealso>
        /// <returns>ApiResponse of AiFolderIntegerWrapper</returns>
        ApiResponse<AiFolderIntegerWrapper> AiAgentsUpdateWithHttpInfo(string id, AiAgentsUpdateRequest aiAgentsUpdateRequest);
        /// <summary>
        /// Update agents' quota
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsUpdateQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update-quota/">REST API Reference for AiAgentsUpdateQuota Operation</seealso>
        /// <returns>AiFolderIntegerArrayWrapper</returns>
        AiFolderIntegerArrayWrapper AiAgentsUpdateQuota(AiAgentsUpdateQuotaRequest aiAgentsUpdateQuotaRequest);

        /// <summary>
        /// Update agents' quota
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsUpdateQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update-quota/">REST API Reference for AiAgentsUpdateQuota Operation</seealso>
        /// <returns>ApiResponse of AiFolderIntegerArrayWrapper</returns>
        ApiResponse<AiFolderIntegerArrayWrapper> AiAgentsUpdateQuotaWithHttpInfo(AiAgentsUpdateQuotaRequest aiAgentsUpdateQuotaRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAgentsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create an agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-create/">REST API Reference for AiAgentsCreate Operation</seealso>
        /// <returns>Task of AiFolderIntegerWrapper</returns>
        Task<AiFolderIntegerWrapper> AiAgentsCreateAsync(AiAgentsCreateRequest aiAgentsCreateRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-create/">REST API Reference for AiAgentsCreate Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderIntegerWrapper)</returns>
        Task<ApiResponse<AiFolderIntegerWrapper>> AiAgentsCreateWithHttpInfoAsync(AiAgentsCreateRequest aiAgentsCreateRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="aiAgentsDeleteRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-delete/">REST API Reference for AiAgentsDelete Operation</seealso>
        /// <returns>Task of AiFileOperationWrapper</returns>
        Task<AiFileOperationWrapper> AiAgentsDeleteAsync(string id, AiAgentsDeleteRequest aiAgentsDeleteRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete an agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="aiAgentsDeleteRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-delete/">REST API Reference for AiAgentsDelete Operation</seealso>
        /// <returns>Task of ApiResponse (AiFileOperationWrapper)</returns>
        Task<ApiResponse<AiFileOperationWrapper>> AiAgentsDeleteWithHttpInfoAsync(string id, AiAgentsDeleteRequest aiAgentsDeleteRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-get/">REST API Reference for AiAgentsGet Operation</seealso>
        /// <returns>Task of AiFolderIntegerWrapper</returns>
        Task<AiFolderIntegerWrapper> AiAgentsGetAsync(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get an agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-get/">REST API Reference for AiAgentsGet Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderIntegerWrapper)</returns>
        Task<ApiResponse<AiFolderIntegerWrapper>> AiAgentsGetWithHttpInfoAsync(string id, CancellationToken cancellationToken = default);
        /// <summary>
        /// List agents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-list/">REST API Reference for AiAgentsList Operation</seealso>
        /// <returns>Task of AiFolderContentIntegerWrapper</returns>
        Task<AiFolderContentIntegerWrapper> AiAgentsListAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// List agents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-list/">REST API Reference for AiAgentsList Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderContentIntegerWrapper)</returns>
        Task<ApiResponse<AiFolderContentIntegerWrapper>> AiAgentsListWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// List agent news items
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-news/">REST API Reference for AiAgentsNews Operation</seealso>
        /// <returns>Task of AiNewItemsAgentNewItemsArrayWrapper</returns>
        Task<AiNewItemsAgentNewItemsArrayWrapper> AiAgentsNewsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// List agent news items
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-news/">REST API Reference for AiAgentsNews Operation</seealso>
        /// <returns>Task of ApiResponse (AiNewItemsAgentNewItemsArrayWrapper)</returns>
        Task<ApiResponse<AiNewItemsAgentNewItemsArrayWrapper>> AiAgentsNewsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Reset agents' quota
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsResetQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-reset-quota/">REST API Reference for AiAgentsResetQuota Operation</seealso>
        /// <returns>Task of AiFolderIntegerArrayWrapper</returns>
        Task<AiFolderIntegerArrayWrapper> AiAgentsResetQuotaAsync(AiAgentsResetQuotaRequest aiAgentsResetQuotaRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Reset agents' quota
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsResetQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-reset-quota/">REST API Reference for AiAgentsResetQuota Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderIntegerArrayWrapper)</returns>
        Task<ApiResponse<AiFolderIntegerArrayWrapper>> AiAgentsResetQuotaWithHttpInfoAsync(AiAgentsResetQuotaRequest aiAgentsResetQuotaRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="aiAgentsUpdateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update/">REST API Reference for AiAgentsUpdate Operation</seealso>
        /// <returns>Task of AiFolderIntegerWrapper</returns>
        Task<AiFolderIntegerWrapper> AiAgentsUpdateAsync(string id, AiAgentsUpdateRequest aiAgentsUpdateRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="aiAgentsUpdateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update/">REST API Reference for AiAgentsUpdate Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderIntegerWrapper)</returns>
        Task<ApiResponse<AiFolderIntegerWrapper>> AiAgentsUpdateWithHttpInfoAsync(string id, AiAgentsUpdateRequest aiAgentsUpdateRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update agents' quota
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsUpdateQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update-quota/">REST API Reference for AiAgentsUpdateQuota Operation</seealso>
        /// <returns>Task of AiFolderIntegerArrayWrapper</returns>
        Task<AiFolderIntegerArrayWrapper> AiAgentsUpdateQuotaAsync(AiAgentsUpdateQuotaRequest aiAgentsUpdateQuotaRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update agents' quota
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsUpdateQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update-quota/">REST API Reference for AiAgentsUpdateQuota Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderIntegerArrayWrapper)</returns>
        Task<ApiResponse<AiFolderIntegerArrayWrapper>> AiAgentsUpdateQuotaWithHttpInfoAsync(AiAgentsUpdateQuotaRequest aiAgentsUpdateQuotaRequest, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAgentsApi : IAgentsApiSync, IAgentsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AgentsApi : IDisposable, IAgentsApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public AgentsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public AgentsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AgentsApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public AgentsApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AgentsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public AgentsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsApi"/> class.
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
        public AgentsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="AgentsApi"/> class using a Configuration object.
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
        public AgentsApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="AgentsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public AgentsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Create an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-create/">REST API Reference for AiAgentsCreate Operation</seealso>
        /// <returns>AiFolderIntegerWrapper</returns>
        public AiFolderIntegerWrapper AiAgentsCreate(AiAgentsCreateRequest aiAgentsCreateRequest)
        {
            var localVarResponse = AiAgentsCreateWithHttpInfo(aiAgentsCreateRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-create/">REST API Reference for AiAgentsCreate Operation</seealso>
        /// <returns>ApiResponse of AiFolderIntegerWrapper</returns>
        public ApiResponse<AiFolderIntegerWrapper> AiAgentsCreateWithHttpInfo(AiAgentsCreateRequest aiAgentsCreateRequest)
        {
            // verify the required parameter 'aiAgentsCreateRequest' is set
            if (aiAgentsCreateRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAgentsCreateRequest' when calling AgentsApi->AiAgentsCreate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAgentsCreateRequest != null) localVarRequestOptions.Data = aiAgentsCreateRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<AiFolderIntegerWrapper>("/api/2.0/ai/agents", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsCreate", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-create/">REST API Reference for AiAgentsCreate Operation</seealso>
        /// <returns>Task of AiFolderIntegerWrapper</returns>
        public async Task<AiFolderIntegerWrapper> AiAgentsCreateAsync(AiAgentsCreateRequest aiAgentsCreateRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAgentsCreateWithHttpInfoAsync(aiAgentsCreateRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-create/">REST API Reference for AiAgentsCreate Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderIntegerWrapper)</returns>
        public async Task<ApiResponse<AiFolderIntegerWrapper>> AiAgentsCreateWithHttpInfoAsync(AiAgentsCreateRequest aiAgentsCreateRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiAgentsCreateRequest' is set
            if (aiAgentsCreateRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAgentsCreateRequest' when calling AgentsApi->AiAgentsCreate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAgentsCreateRequest != null) localVarRequestOptions.Data = aiAgentsCreateRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiFolderIntegerWrapper>("/api/2.0/ai/agents", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsCreate", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="aiAgentsDeleteRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-delete/">REST API Reference for AiAgentsDelete Operation</seealso>
        /// <returns>AiFileOperationWrapper</returns>
        public AiFileOperationWrapper AiAgentsDelete(string id, AiAgentsDeleteRequest aiAgentsDeleteRequest)
        {
            var localVarResponse = AiAgentsDeleteWithHttpInfo(id, aiAgentsDeleteRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="aiAgentsDeleteRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-delete/">REST API Reference for AiAgentsDelete Operation</seealso>
        /// <returns>ApiResponse of AiFileOperationWrapper</returns>
        public ApiResponse<AiFileOperationWrapper> AiAgentsDeleteWithHttpInfo(string id, AiAgentsDeleteRequest aiAgentsDeleteRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AgentsApi->AiAgentsDelete");

            // verify the required parameter 'aiAgentsDeleteRequest' is set
            if (aiAgentsDeleteRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAgentsDeleteRequest' when calling AgentsApi->AiAgentsDelete");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (aiAgentsDeleteRequest != null) localVarRequestOptions.Data = aiAgentsDeleteRequest;


            // make the HTTP request
            var localVarResponse = Client.Delete<AiFileOperationWrapper>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsDelete", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="aiAgentsDeleteRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-delete/">REST API Reference for AiAgentsDelete Operation</seealso>
        /// <returns>Task of AiFileOperationWrapper</returns>
        public async Task<AiFileOperationWrapper> AiAgentsDeleteAsync(string id, AiAgentsDeleteRequest aiAgentsDeleteRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAgentsDeleteWithHttpInfoAsync(id, aiAgentsDeleteRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="aiAgentsDeleteRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-delete/">REST API Reference for AiAgentsDelete Operation</seealso>
        /// <returns>Task of ApiResponse (AiFileOperationWrapper)</returns>
        public async Task<ApiResponse<AiFileOperationWrapper>> AiAgentsDeleteWithHttpInfoAsync(string id, AiAgentsDeleteRequest aiAgentsDeleteRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AgentsApi->AiAgentsDelete");

            // verify the required parameter 'aiAgentsDeleteRequest' is set
            if (aiAgentsDeleteRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAgentsDeleteRequest' when calling AgentsApi->AiAgentsDelete");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (aiAgentsDeleteRequest != null) localVarRequestOptions.Data = aiAgentsDeleteRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<AiFileOperationWrapper>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsDelete", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-get/">REST API Reference for AiAgentsGet Operation</seealso>
        /// <returns>AiFolderIntegerWrapper</returns>
        public AiFolderIntegerWrapper AiAgentsGet(string id)
        {
            var localVarResponse = AiAgentsGetWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-get/">REST API Reference for AiAgentsGet Operation</seealso>
        /// <returns>ApiResponse of AiFolderIntegerWrapper</returns>
        public ApiResponse<AiFolderIntegerWrapper> AiAgentsGetWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AgentsApi->AiAgentsGet");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request
            var localVarResponse = Client.Get<AiFolderIntegerWrapper>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsGet", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-get/">REST API Reference for AiAgentsGet Operation</seealso>
        /// <returns>Task of AiFolderIntegerWrapper</returns>
        public async Task<AiFolderIntegerWrapper> AiAgentsGetAsync(string id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAgentsGetWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-get/">REST API Reference for AiAgentsGet Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderIntegerWrapper)</returns>
        public async Task<ApiResponse<AiFolderIntegerWrapper>> AiAgentsGetWithHttpInfoAsync(string id, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AgentsApi->AiAgentsGet");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<AiFolderIntegerWrapper>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsGet", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List agents
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-list/">REST API Reference for AiAgentsList Operation</seealso>
        /// <returns>AiFolderContentIntegerWrapper</returns>
        public AiFolderContentIntegerWrapper AiAgentsList()
        {
            var localVarResponse = AiAgentsListWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// List agents
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-list/">REST API Reference for AiAgentsList Operation</seealso>
        /// <returns>ApiResponse of AiFolderContentIntegerWrapper</returns>
        public ApiResponse<AiFolderContentIntegerWrapper> AiAgentsListWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = Client.Get<AiFolderContentIntegerWrapper>("/api/2.0/ai/agents", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsList", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List agents
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-list/">REST API Reference for AiAgentsList Operation</seealso>
        /// <returns>Task of AiFolderContentIntegerWrapper</returns>
        public async Task<AiFolderContentIntegerWrapper> AiAgentsListAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAgentsListWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List agents
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-list/">REST API Reference for AiAgentsList Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderContentIntegerWrapper)</returns>
        public async Task<ApiResponse<AiFolderContentIntegerWrapper>> AiAgentsListWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<AiFolderContentIntegerWrapper>("/api/2.0/ai/agents", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsList", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List agent news items
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-news/">REST API Reference for AiAgentsNews Operation</seealso>
        /// <returns>AiNewItemsAgentNewItemsArrayWrapper</returns>
        public AiNewItemsAgentNewItemsArrayWrapper AiAgentsNews()
        {
            var localVarResponse = AiAgentsNewsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// List agent news items
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-news/">REST API Reference for AiAgentsNews Operation</seealso>
        /// <returns>ApiResponse of AiNewItemsAgentNewItemsArrayWrapper</returns>
        public ApiResponse<AiNewItemsAgentNewItemsArrayWrapper> AiAgentsNewsWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = Client.Get<AiNewItemsAgentNewItemsArrayWrapper>("/api/2.0/ai/agents/news", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsNews", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List agent news items
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-news/">REST API Reference for AiAgentsNews Operation</seealso>
        /// <returns>Task of AiNewItemsAgentNewItemsArrayWrapper</returns>
        public async Task<AiNewItemsAgentNewItemsArrayWrapper> AiAgentsNewsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAgentsNewsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List agent news items
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-news/">REST API Reference for AiAgentsNews Operation</seealso>
        /// <returns>Task of ApiResponse (AiNewItemsAgentNewItemsArrayWrapper)</returns>
        public async Task<ApiResponse<AiNewItemsAgentNewItemsArrayWrapper>> AiAgentsNewsWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<AiNewItemsAgentNewItemsArrayWrapper>("/api/2.0/ai/agents/news", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsNews", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Reset agents' quota
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsResetQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-reset-quota/">REST API Reference for AiAgentsResetQuota Operation</seealso>
        /// <returns>AiFolderIntegerArrayWrapper</returns>
        public AiFolderIntegerArrayWrapper AiAgentsResetQuota(AiAgentsResetQuotaRequest aiAgentsResetQuotaRequest)
        {
            var localVarResponse = AiAgentsResetQuotaWithHttpInfo(aiAgentsResetQuotaRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Reset agents' quota
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsResetQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-reset-quota/">REST API Reference for AiAgentsResetQuota Operation</seealso>
        /// <returns>ApiResponse of AiFolderIntegerArrayWrapper</returns>
        public ApiResponse<AiFolderIntegerArrayWrapper> AiAgentsResetQuotaWithHttpInfo(AiAgentsResetQuotaRequest aiAgentsResetQuotaRequest)
        {
            // verify the required parameter 'aiAgentsResetQuotaRequest' is set
            if (aiAgentsResetQuotaRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAgentsResetQuotaRequest' when calling AgentsApi->AiAgentsResetQuota");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAgentsResetQuotaRequest != null) localVarRequestOptions.Data = aiAgentsResetQuotaRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<AiFolderIntegerArrayWrapper>("/api/2.0/ai/agents/resetquota", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsResetQuota", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Reset agents' quota
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsResetQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-reset-quota/">REST API Reference for AiAgentsResetQuota Operation</seealso>
        /// <returns>Task of AiFolderIntegerArrayWrapper</returns>
        public async Task<AiFolderIntegerArrayWrapper> AiAgentsResetQuotaAsync(AiAgentsResetQuotaRequest aiAgentsResetQuotaRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAgentsResetQuotaWithHttpInfoAsync(aiAgentsResetQuotaRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Reset agents' quota
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsResetQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-reset-quota/">REST API Reference for AiAgentsResetQuota Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderIntegerArrayWrapper)</returns>
        public async Task<ApiResponse<AiFolderIntegerArrayWrapper>> AiAgentsResetQuotaWithHttpInfoAsync(AiAgentsResetQuotaRequest aiAgentsResetQuotaRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiAgentsResetQuotaRequest' is set
            if (aiAgentsResetQuotaRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAgentsResetQuotaRequest' when calling AgentsApi->AiAgentsResetQuota");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAgentsResetQuotaRequest != null) localVarRequestOptions.Data = aiAgentsResetQuotaRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<AiFolderIntegerArrayWrapper>("/api/2.0/ai/agents/resetquota", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsResetQuota", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="aiAgentsUpdateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update/">REST API Reference for AiAgentsUpdate Operation</seealso>
        /// <returns>AiFolderIntegerWrapper</returns>
        public AiFolderIntegerWrapper AiAgentsUpdate(string id, AiAgentsUpdateRequest aiAgentsUpdateRequest)
        {
            var localVarResponse = AiAgentsUpdateWithHttpInfo(id, aiAgentsUpdateRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="aiAgentsUpdateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update/">REST API Reference for AiAgentsUpdate Operation</seealso>
        /// <returns>ApiResponse of AiFolderIntegerWrapper</returns>
        public ApiResponse<AiFolderIntegerWrapper> AiAgentsUpdateWithHttpInfo(string id, AiAgentsUpdateRequest aiAgentsUpdateRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AgentsApi->AiAgentsUpdate");

            // verify the required parameter 'aiAgentsUpdateRequest' is set
            if (aiAgentsUpdateRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAgentsUpdateRequest' when calling AgentsApi->AiAgentsUpdate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (aiAgentsUpdateRequest != null) localVarRequestOptions.Data = aiAgentsUpdateRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<AiFolderIntegerWrapper>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsUpdate", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="aiAgentsUpdateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update/">REST API Reference for AiAgentsUpdate Operation</seealso>
        /// <returns>Task of AiFolderIntegerWrapper</returns>
        public async Task<AiFolderIntegerWrapper> AiAgentsUpdateAsync(string id, AiAgentsUpdateRequest aiAgentsUpdateRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAgentsUpdateWithHttpInfoAsync(id, aiAgentsUpdateRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="aiAgentsUpdateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update/">REST API Reference for AiAgentsUpdate Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderIntegerWrapper)</returns>
        public async Task<ApiResponse<AiFolderIntegerWrapper>> AiAgentsUpdateWithHttpInfoAsync(string id, AiAgentsUpdateRequest aiAgentsUpdateRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AgentsApi->AiAgentsUpdate");

            // verify the required parameter 'aiAgentsUpdateRequest' is set
            if (aiAgentsUpdateRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAgentsUpdateRequest' when calling AgentsApi->AiAgentsUpdate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (aiAgentsUpdateRequest != null) localVarRequestOptions.Data = aiAgentsUpdateRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<AiFolderIntegerWrapper>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsUpdate", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update agents' quota
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsUpdateQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update-quota/">REST API Reference for AiAgentsUpdateQuota Operation</seealso>
        /// <returns>AiFolderIntegerArrayWrapper</returns>
        public AiFolderIntegerArrayWrapper AiAgentsUpdateQuota(AiAgentsUpdateQuotaRequest aiAgentsUpdateQuotaRequest)
        {
            var localVarResponse = AiAgentsUpdateQuotaWithHttpInfo(aiAgentsUpdateQuotaRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update agents' quota
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsUpdateQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update-quota/">REST API Reference for AiAgentsUpdateQuota Operation</seealso>
        /// <returns>ApiResponse of AiFolderIntegerArrayWrapper</returns>
        public ApiResponse<AiFolderIntegerArrayWrapper> AiAgentsUpdateQuotaWithHttpInfo(AiAgentsUpdateQuotaRequest aiAgentsUpdateQuotaRequest)
        {
            // verify the required parameter 'aiAgentsUpdateQuotaRequest' is set
            if (aiAgentsUpdateQuotaRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAgentsUpdateQuotaRequest' when calling AgentsApi->AiAgentsUpdateQuota");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAgentsUpdateQuotaRequest != null) localVarRequestOptions.Data = aiAgentsUpdateQuotaRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<AiFolderIntegerArrayWrapper>("/api/2.0/ai/agents/agentquota", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsUpdateQuota", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update agents' quota
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsUpdateQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update-quota/">REST API Reference for AiAgentsUpdateQuota Operation</seealso>
        /// <returns>Task of AiFolderIntegerArrayWrapper</returns>
        public async Task<AiFolderIntegerArrayWrapper> AiAgentsUpdateQuotaAsync(AiAgentsUpdateQuotaRequest aiAgentsUpdateQuotaRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAgentsUpdateQuotaWithHttpInfoAsync(aiAgentsUpdateQuotaRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update agents' quota
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsUpdateQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update-quota/">REST API Reference for AiAgentsUpdateQuota Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderIntegerArrayWrapper)</returns>
        public async Task<ApiResponse<AiFolderIntegerArrayWrapper>> AiAgentsUpdateQuotaWithHttpInfoAsync(AiAgentsUpdateQuotaRequest aiAgentsUpdateQuotaRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiAgentsUpdateQuotaRequest' is set
            if (aiAgentsUpdateQuotaRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAgentsUpdateQuotaRequest' when calling AgentsApi->AiAgentsUpdateQuota");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAgentsUpdateQuotaRequest != null) localVarRequestOptions.Data = aiAgentsUpdateQuotaRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<AiFolderIntegerArrayWrapper>("/api/2.0/ai/agents/agentquota", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsUpdateQuota", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
