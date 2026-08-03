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
    public interface IAgentsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAgentsCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-create/">REST API Reference for NewAiAgentsCreate Operation</seealso>
        /// <returns>NewAiFolderIntegerWrapper</returns>
        NewAiFolderIntegerWrapper NewAiAgentsCreate(NewAiAgentsCreateRequest newAiAgentsCreateRequest);

        /// <summary>
        /// Create an agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAgentsCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-create/">REST API Reference for NewAiAgentsCreate Operation</seealso>
        /// <returns>ApiResponse of NewAiFolderIntegerWrapper</returns>
        ApiResponse<NewAiFolderIntegerWrapper> NewAiAgentsCreateWithHttpInfo(NewAiAgentsCreateRequest newAiAgentsCreateRequest);
        /// <summary>
        /// Delete an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="newAiAgentsDeleteRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-delete/">REST API Reference for NewAiAgentsDelete Operation</seealso>
        /// <returns>NewAiFileOperationWrapper</returns>
        NewAiFileOperationWrapper NewAiAgentsDelete(string id, NewAiAgentsDeleteRequest newAiAgentsDeleteRequest);

        /// <summary>
        /// Delete an agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="newAiAgentsDeleteRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-delete/">REST API Reference for NewAiAgentsDelete Operation</seealso>
        /// <returns>ApiResponse of NewAiFileOperationWrapper</returns>
        ApiResponse<NewAiFileOperationWrapper> NewAiAgentsDeleteWithHttpInfo(string id, NewAiAgentsDeleteRequest newAiAgentsDeleteRequest);
        /// <summary>
        /// Get an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-get/">REST API Reference for NewAiAgentsGet Operation</seealso>
        /// <returns>NewAiFolderIntegerWrapper</returns>
        NewAiFolderIntegerWrapper NewAiAgentsGet(string id);

        /// <summary>
        /// Get an agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-get/">REST API Reference for NewAiAgentsGet Operation</seealso>
        /// <returns>ApiResponse of NewAiFolderIntegerWrapper</returns>
        ApiResponse<NewAiFolderIntegerWrapper> NewAiAgentsGetWithHttpInfo(string id);
        /// <summary>
        /// List agents
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-list/">REST API Reference for NewAiAgentsList Operation</seealso>
        /// <returns>NewAiFolderContentIntegerWrapper</returns>
        NewAiFolderContentIntegerWrapper NewAiAgentsList();

        /// <summary>
        /// List agents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-list/">REST API Reference for NewAiAgentsList Operation</seealso>
        /// <returns>ApiResponse of NewAiFolderContentIntegerWrapper</returns>
        ApiResponse<NewAiFolderContentIntegerWrapper> NewAiAgentsListWithHttpInfo();
        /// <summary>
        /// List agent news items
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-news/">REST API Reference for NewAiAgentsNews Operation</seealso>
        /// <returns>NewAiNewItemsAgentNewItemsArrayWrapper</returns>
        NewAiNewItemsAgentNewItemsArrayWrapper NewAiAgentsNews();

        /// <summary>
        /// List agent news items
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-news/">REST API Reference for NewAiAgentsNews Operation</seealso>
        /// <returns>ApiResponse of NewAiNewItemsAgentNewItemsArrayWrapper</returns>
        ApiResponse<NewAiNewItemsAgentNewItemsArrayWrapper> NewAiAgentsNewsWithHttpInfo();
        /// <summary>
        /// Reset agents' quota
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAgentsResetQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-reset-quota/">REST API Reference for NewAiAgentsResetQuota Operation</seealso>
        /// <returns>NewAiFolderIntegerArrayWrapper</returns>
        NewAiFolderIntegerArrayWrapper NewAiAgentsResetQuota(NewAiAgentsResetQuotaRequest newAiAgentsResetQuotaRequest);

        /// <summary>
        /// Reset agents' quota
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAgentsResetQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-reset-quota/">REST API Reference for NewAiAgentsResetQuota Operation</seealso>
        /// <returns>ApiResponse of NewAiFolderIntegerArrayWrapper</returns>
        ApiResponse<NewAiFolderIntegerArrayWrapper> NewAiAgentsResetQuotaWithHttpInfo(NewAiAgentsResetQuotaRequest newAiAgentsResetQuotaRequest);
        /// <summary>
        /// Update an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="newAiAgentsUpdateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-update/">REST API Reference for NewAiAgentsUpdate Operation</seealso>
        /// <returns>NewAiFolderIntegerWrapper</returns>
        NewAiFolderIntegerWrapper NewAiAgentsUpdate(string id, NewAiAgentsUpdateRequest newAiAgentsUpdateRequest);

        /// <summary>
        /// Update an agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="newAiAgentsUpdateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-update/">REST API Reference for NewAiAgentsUpdate Operation</seealso>
        /// <returns>ApiResponse of NewAiFolderIntegerWrapper</returns>
        ApiResponse<NewAiFolderIntegerWrapper> NewAiAgentsUpdateWithHttpInfo(string id, NewAiAgentsUpdateRequest newAiAgentsUpdateRequest);
        /// <summary>
        /// Update agents' quota
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAgentsUpdateQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-update-quota/">REST API Reference for NewAiAgentsUpdateQuota Operation</seealso>
        /// <returns>NewAiFolderIntegerArrayWrapper</returns>
        NewAiFolderIntegerArrayWrapper NewAiAgentsUpdateQuota(NewAiAgentsUpdateQuotaRequest newAiAgentsUpdateQuotaRequest);

        /// <summary>
        /// Update agents' quota
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAgentsUpdateQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-update-quota/">REST API Reference for NewAiAgentsUpdateQuota Operation</seealso>
        /// <returns>ApiResponse of NewAiFolderIntegerArrayWrapper</returns>
        ApiResponse<NewAiFolderIntegerArrayWrapper> NewAiAgentsUpdateQuotaWithHttpInfo(NewAiAgentsUpdateQuotaRequest newAiAgentsUpdateQuotaRequest);
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
        /// <param name="newAiAgentsCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-create/">REST API Reference for NewAiAgentsCreate Operation</seealso>
        /// <returns>Task of NewAiFolderIntegerWrapper</returns>
        Task<NewAiFolderIntegerWrapper> NewAiAgentsCreateAsync(NewAiAgentsCreateRequest newAiAgentsCreateRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAgentsCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-create/">REST API Reference for NewAiAgentsCreate Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiFolderIntegerWrapper)</returns>
        Task<ApiResponse<NewAiFolderIntegerWrapper>> NewAiAgentsCreateWithHttpInfoAsync(NewAiAgentsCreateRequest newAiAgentsCreateRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="newAiAgentsDeleteRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-delete/">REST API Reference for NewAiAgentsDelete Operation</seealso>
        /// <returns>Task of NewAiFileOperationWrapper</returns>
        Task<NewAiFileOperationWrapper> NewAiAgentsDeleteAsync(string id, NewAiAgentsDeleteRequest newAiAgentsDeleteRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete an agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="newAiAgentsDeleteRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-delete/">REST API Reference for NewAiAgentsDelete Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiFileOperationWrapper)</returns>
        Task<ApiResponse<NewAiFileOperationWrapper>> NewAiAgentsDeleteWithHttpInfoAsync(string id, NewAiAgentsDeleteRequest newAiAgentsDeleteRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-get/">REST API Reference for NewAiAgentsGet Operation</seealso>
        /// <returns>Task of NewAiFolderIntegerWrapper</returns>
        Task<NewAiFolderIntegerWrapper> NewAiAgentsGetAsync(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get an agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-get/">REST API Reference for NewAiAgentsGet Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiFolderIntegerWrapper)</returns>
        Task<ApiResponse<NewAiFolderIntegerWrapper>> NewAiAgentsGetWithHttpInfoAsync(string id, CancellationToken cancellationToken = default);
        /// <summary>
        /// List agents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-list/">REST API Reference for NewAiAgentsList Operation</seealso>
        /// <returns>Task of NewAiFolderContentIntegerWrapper</returns>
        Task<NewAiFolderContentIntegerWrapper> NewAiAgentsListAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// List agents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-list/">REST API Reference for NewAiAgentsList Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiFolderContentIntegerWrapper)</returns>
        Task<ApiResponse<NewAiFolderContentIntegerWrapper>> NewAiAgentsListWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// List agent news items
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-news/">REST API Reference for NewAiAgentsNews Operation</seealso>
        /// <returns>Task of NewAiNewItemsAgentNewItemsArrayWrapper</returns>
        Task<NewAiNewItemsAgentNewItemsArrayWrapper> NewAiAgentsNewsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// List agent news items
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-news/">REST API Reference for NewAiAgentsNews Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiNewItemsAgentNewItemsArrayWrapper)</returns>
        Task<ApiResponse<NewAiNewItemsAgentNewItemsArrayWrapper>> NewAiAgentsNewsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Reset agents' quota
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAgentsResetQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-reset-quota/">REST API Reference for NewAiAgentsResetQuota Operation</seealso>
        /// <returns>Task of NewAiFolderIntegerArrayWrapper</returns>
        Task<NewAiFolderIntegerArrayWrapper> NewAiAgentsResetQuotaAsync(NewAiAgentsResetQuotaRequest newAiAgentsResetQuotaRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Reset agents' quota
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAgentsResetQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-reset-quota/">REST API Reference for NewAiAgentsResetQuota Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiFolderIntegerArrayWrapper)</returns>
        Task<ApiResponse<NewAiFolderIntegerArrayWrapper>> NewAiAgentsResetQuotaWithHttpInfoAsync(NewAiAgentsResetQuotaRequest newAiAgentsResetQuotaRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="newAiAgentsUpdateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-update/">REST API Reference for NewAiAgentsUpdate Operation</seealso>
        /// <returns>Task of NewAiFolderIntegerWrapper</returns>
        Task<NewAiFolderIntegerWrapper> NewAiAgentsUpdateAsync(string id, NewAiAgentsUpdateRequest newAiAgentsUpdateRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an agent
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="newAiAgentsUpdateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-update/">REST API Reference for NewAiAgentsUpdate Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiFolderIntegerWrapper)</returns>
        Task<ApiResponse<NewAiFolderIntegerWrapper>> NewAiAgentsUpdateWithHttpInfoAsync(string id, NewAiAgentsUpdateRequest newAiAgentsUpdateRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update agents' quota
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAgentsUpdateQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-update-quota/">REST API Reference for NewAiAgentsUpdateQuota Operation</seealso>
        /// <returns>Task of NewAiFolderIntegerArrayWrapper</returns>
        Task<NewAiFolderIntegerArrayWrapper> NewAiAgentsUpdateQuotaAsync(NewAiAgentsUpdateQuotaRequest newAiAgentsUpdateQuotaRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update agents' quota
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAgentsUpdateQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-update-quota/">REST API Reference for NewAiAgentsUpdateQuota Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiFolderIntegerArrayWrapper)</returns>
        Task<ApiResponse<NewAiFolderIntegerArrayWrapper>> NewAiAgentsUpdateQuotaWithHttpInfoAsync(NewAiAgentsUpdateQuotaRequest newAiAgentsUpdateQuotaRequest, CancellationToken cancellationToken = default);
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
        /// <param name="newAiAgentsCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-create/">REST API Reference for NewAiAgentsCreate Operation</seealso>
        /// <returns>NewAiFolderIntegerWrapper</returns>
        public NewAiFolderIntegerWrapper NewAiAgentsCreate(NewAiAgentsCreateRequest newAiAgentsCreateRequest)
        {
            var localVarResponse = NewAiAgentsCreateWithHttpInfo(newAiAgentsCreateRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAgentsCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-create/">REST API Reference for NewAiAgentsCreate Operation</seealso>
        /// <returns>ApiResponse of NewAiFolderIntegerWrapper</returns>
        public ApiResponse<NewAiFolderIntegerWrapper> NewAiAgentsCreateWithHttpInfo(NewAiAgentsCreateRequest newAiAgentsCreateRequest)
        {
            // verify the required parameter 'newAiAgentsCreateRequest' is set
            if (newAiAgentsCreateRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAgentsCreateRequest' when calling AgentsApi->NewAiAgentsCreate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAgentsCreateRequest != null) localVarRequestOptions.Data = newAiAgentsCreateRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<NewAiFolderIntegerWrapper>("/api/2.0/ai/agents", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAgentsCreate", localVarResponse);
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
        /// <param name="newAiAgentsCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-create/">REST API Reference for NewAiAgentsCreate Operation</seealso>
        /// <returns>Task of NewAiFolderIntegerWrapper</returns>
        public async Task<NewAiFolderIntegerWrapper> NewAiAgentsCreateAsync(NewAiAgentsCreateRequest newAiAgentsCreateRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAgentsCreateWithHttpInfoAsync(newAiAgentsCreateRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAgentsCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-create/">REST API Reference for NewAiAgentsCreate Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiFolderIntegerWrapper)</returns>
        public async Task<ApiResponse<NewAiFolderIntegerWrapper>> NewAiAgentsCreateWithHttpInfoAsync(NewAiAgentsCreateRequest newAiAgentsCreateRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiAgentsCreateRequest' is set
            if (newAiAgentsCreateRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAgentsCreateRequest' when calling AgentsApi->NewAiAgentsCreate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAgentsCreateRequest != null) localVarRequestOptions.Data = newAiAgentsCreateRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<NewAiFolderIntegerWrapper>("/api/2.0/ai/agents", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAgentsCreate", localVarResponse);
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
        /// <param name="newAiAgentsDeleteRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-delete/">REST API Reference for NewAiAgentsDelete Operation</seealso>
        /// <returns>NewAiFileOperationWrapper</returns>
        public NewAiFileOperationWrapper NewAiAgentsDelete(string id, NewAiAgentsDeleteRequest newAiAgentsDeleteRequest)
        {
            var localVarResponse = NewAiAgentsDeleteWithHttpInfo(id, newAiAgentsDeleteRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="newAiAgentsDeleteRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-delete/">REST API Reference for NewAiAgentsDelete Operation</seealso>
        /// <returns>ApiResponse of NewAiFileOperationWrapper</returns>
        public ApiResponse<NewAiFileOperationWrapper> NewAiAgentsDeleteWithHttpInfo(string id, NewAiAgentsDeleteRequest newAiAgentsDeleteRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AgentsApi->NewAiAgentsDelete");

            // verify the required parameter 'newAiAgentsDeleteRequest' is set
            if (newAiAgentsDeleteRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAgentsDeleteRequest' when calling AgentsApi->NewAiAgentsDelete");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (newAiAgentsDeleteRequest != null) localVarRequestOptions.Data = newAiAgentsDeleteRequest;


            // make the HTTP request
            var localVarResponse = Client.Delete<NewAiFileOperationWrapper>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAgentsDelete", localVarResponse);
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
        /// <param name="newAiAgentsDeleteRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-delete/">REST API Reference for NewAiAgentsDelete Operation</seealso>
        /// <returns>Task of NewAiFileOperationWrapper</returns>
        public async Task<NewAiFileOperationWrapper> NewAiAgentsDeleteAsync(string id, NewAiAgentsDeleteRequest newAiAgentsDeleteRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAgentsDeleteWithHttpInfoAsync(id, newAiAgentsDeleteRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="newAiAgentsDeleteRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-delete/">REST API Reference for NewAiAgentsDelete Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiFileOperationWrapper)</returns>
        public async Task<ApiResponse<NewAiFileOperationWrapper>> NewAiAgentsDeleteWithHttpInfoAsync(string id, NewAiAgentsDeleteRequest newAiAgentsDeleteRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AgentsApi->NewAiAgentsDelete");

            // verify the required parameter 'newAiAgentsDeleteRequest' is set
            if (newAiAgentsDeleteRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAgentsDeleteRequest' when calling AgentsApi->NewAiAgentsDelete");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (newAiAgentsDeleteRequest != null) localVarRequestOptions.Data = newAiAgentsDeleteRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<NewAiFileOperationWrapper>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAgentsDelete", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-get/">REST API Reference for NewAiAgentsGet Operation</seealso>
        /// <returns>NewAiFolderIntegerWrapper</returns>
        public NewAiFolderIntegerWrapper NewAiAgentsGet(string id)
        {
            var localVarResponse = NewAiAgentsGetWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-get/">REST API Reference for NewAiAgentsGet Operation</seealso>
        /// <returns>ApiResponse of NewAiFolderIntegerWrapper</returns>
        public ApiResponse<NewAiFolderIntegerWrapper> NewAiAgentsGetWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AgentsApi->NewAiAgentsGet");

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
            var localVarResponse = Client.Get<NewAiFolderIntegerWrapper>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAgentsGet", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-get/">REST API Reference for NewAiAgentsGet Operation</seealso>
        /// <returns>Task of NewAiFolderIntegerWrapper</returns>
        public async Task<NewAiFolderIntegerWrapper> NewAiAgentsGetAsync(string id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAgentsGetWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-get/">REST API Reference for NewAiAgentsGet Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiFolderIntegerWrapper)</returns>
        public async Task<ApiResponse<NewAiFolderIntegerWrapper>> NewAiAgentsGetWithHttpInfoAsync(string id, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AgentsApi->NewAiAgentsGet");

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

            var localVarResponse = await AsynchronousClient.GetAsync<NewAiFolderIntegerWrapper>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAgentsGet", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-list/">REST API Reference for NewAiAgentsList Operation</seealso>
        /// <returns>NewAiFolderContentIntegerWrapper</returns>
        public NewAiFolderContentIntegerWrapper NewAiAgentsList()
        {
            var localVarResponse = NewAiAgentsListWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// List agents
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-list/">REST API Reference for NewAiAgentsList Operation</seealso>
        /// <returns>ApiResponse of NewAiFolderContentIntegerWrapper</returns>
        public ApiResponse<NewAiFolderContentIntegerWrapper> NewAiAgentsListWithHttpInfo()
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
            var localVarResponse = Client.Get<NewAiFolderContentIntegerWrapper>("/api/2.0/ai/agents", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAgentsList", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-list/">REST API Reference for NewAiAgentsList Operation</seealso>
        /// <returns>Task of NewAiFolderContentIntegerWrapper</returns>
        public async Task<NewAiFolderContentIntegerWrapper> NewAiAgentsListAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAgentsListWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List agents
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-list/">REST API Reference for NewAiAgentsList Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiFolderContentIntegerWrapper)</returns>
        public async Task<ApiResponse<NewAiFolderContentIntegerWrapper>> NewAiAgentsListWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<NewAiFolderContentIntegerWrapper>("/api/2.0/ai/agents", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAgentsList", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-news/">REST API Reference for NewAiAgentsNews Operation</seealso>
        /// <returns>NewAiNewItemsAgentNewItemsArrayWrapper</returns>
        public NewAiNewItemsAgentNewItemsArrayWrapper NewAiAgentsNews()
        {
            var localVarResponse = NewAiAgentsNewsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// List agent news items
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-news/">REST API Reference for NewAiAgentsNews Operation</seealso>
        /// <returns>ApiResponse of NewAiNewItemsAgentNewItemsArrayWrapper</returns>
        public ApiResponse<NewAiNewItemsAgentNewItemsArrayWrapper> NewAiAgentsNewsWithHttpInfo()
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
            var localVarResponse = Client.Get<NewAiNewItemsAgentNewItemsArrayWrapper>("/api/2.0/ai/agents/news", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAgentsNews", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-news/">REST API Reference for NewAiAgentsNews Operation</seealso>
        /// <returns>Task of NewAiNewItemsAgentNewItemsArrayWrapper</returns>
        public async Task<NewAiNewItemsAgentNewItemsArrayWrapper> NewAiAgentsNewsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAgentsNewsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List agent news items
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-news/">REST API Reference for NewAiAgentsNews Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiNewItemsAgentNewItemsArrayWrapper)</returns>
        public async Task<ApiResponse<NewAiNewItemsAgentNewItemsArrayWrapper>> NewAiAgentsNewsWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<NewAiNewItemsAgentNewItemsArrayWrapper>("/api/2.0/ai/agents/news", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAgentsNews", localVarResponse);
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
        /// <param name="newAiAgentsResetQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-reset-quota/">REST API Reference for NewAiAgentsResetQuota Operation</seealso>
        /// <returns>NewAiFolderIntegerArrayWrapper</returns>
        public NewAiFolderIntegerArrayWrapper NewAiAgentsResetQuota(NewAiAgentsResetQuotaRequest newAiAgentsResetQuotaRequest)
        {
            var localVarResponse = NewAiAgentsResetQuotaWithHttpInfo(newAiAgentsResetQuotaRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Reset agents' quota
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAgentsResetQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-reset-quota/">REST API Reference for NewAiAgentsResetQuota Operation</seealso>
        /// <returns>ApiResponse of NewAiFolderIntegerArrayWrapper</returns>
        public ApiResponse<NewAiFolderIntegerArrayWrapper> NewAiAgentsResetQuotaWithHttpInfo(NewAiAgentsResetQuotaRequest newAiAgentsResetQuotaRequest)
        {
            // verify the required parameter 'newAiAgentsResetQuotaRequest' is set
            if (newAiAgentsResetQuotaRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAgentsResetQuotaRequest' when calling AgentsApi->NewAiAgentsResetQuota");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAgentsResetQuotaRequest != null) localVarRequestOptions.Data = newAiAgentsResetQuotaRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<NewAiFolderIntegerArrayWrapper>("/api/2.0/ai/agents/resetquota", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAgentsResetQuota", localVarResponse);
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
        /// <param name="newAiAgentsResetQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-reset-quota/">REST API Reference for NewAiAgentsResetQuota Operation</seealso>
        /// <returns>Task of NewAiFolderIntegerArrayWrapper</returns>
        public async Task<NewAiFolderIntegerArrayWrapper> NewAiAgentsResetQuotaAsync(NewAiAgentsResetQuotaRequest newAiAgentsResetQuotaRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAgentsResetQuotaWithHttpInfoAsync(newAiAgentsResetQuotaRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Reset agents' quota
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAgentsResetQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-reset-quota/">REST API Reference for NewAiAgentsResetQuota Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiFolderIntegerArrayWrapper)</returns>
        public async Task<ApiResponse<NewAiFolderIntegerArrayWrapper>> NewAiAgentsResetQuotaWithHttpInfoAsync(NewAiAgentsResetQuotaRequest newAiAgentsResetQuotaRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiAgentsResetQuotaRequest' is set
            if (newAiAgentsResetQuotaRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAgentsResetQuotaRequest' when calling AgentsApi->NewAiAgentsResetQuota");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAgentsResetQuotaRequest != null) localVarRequestOptions.Data = newAiAgentsResetQuotaRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<NewAiFolderIntegerArrayWrapper>("/api/2.0/ai/agents/resetquota", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAgentsResetQuota", localVarResponse);
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
        /// <param name="newAiAgentsUpdateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-update/">REST API Reference for NewAiAgentsUpdate Operation</seealso>
        /// <returns>NewAiFolderIntegerWrapper</returns>
        public NewAiFolderIntegerWrapper NewAiAgentsUpdate(string id, NewAiAgentsUpdateRequest newAiAgentsUpdateRequest)
        {
            var localVarResponse = NewAiAgentsUpdateWithHttpInfo(id, newAiAgentsUpdateRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="newAiAgentsUpdateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-update/">REST API Reference for NewAiAgentsUpdate Operation</seealso>
        /// <returns>ApiResponse of NewAiFolderIntegerWrapper</returns>
        public ApiResponse<NewAiFolderIntegerWrapper> NewAiAgentsUpdateWithHttpInfo(string id, NewAiAgentsUpdateRequest newAiAgentsUpdateRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AgentsApi->NewAiAgentsUpdate");

            // verify the required parameter 'newAiAgentsUpdateRequest' is set
            if (newAiAgentsUpdateRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAgentsUpdateRequest' when calling AgentsApi->NewAiAgentsUpdate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (newAiAgentsUpdateRequest != null) localVarRequestOptions.Data = newAiAgentsUpdateRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<NewAiFolderIntegerWrapper>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAgentsUpdate", localVarResponse);
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
        /// <param name="newAiAgentsUpdateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-update/">REST API Reference for NewAiAgentsUpdate Operation</seealso>
        /// <returns>Task of NewAiFolderIntegerWrapper</returns>
        public async Task<NewAiFolderIntegerWrapper> NewAiAgentsUpdateAsync(string id, NewAiAgentsUpdateRequest newAiAgentsUpdateRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAgentsUpdateWithHttpInfoAsync(id, newAiAgentsUpdateRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update an agent
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="newAiAgentsUpdateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-update/">REST API Reference for NewAiAgentsUpdate Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiFolderIntegerWrapper)</returns>
        public async Task<ApiResponse<NewAiFolderIntegerWrapper>> NewAiAgentsUpdateWithHttpInfoAsync(string id, NewAiAgentsUpdateRequest newAiAgentsUpdateRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AgentsApi->NewAiAgentsUpdate");

            // verify the required parameter 'newAiAgentsUpdateRequest' is set
            if (newAiAgentsUpdateRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAgentsUpdateRequest' when calling AgentsApi->NewAiAgentsUpdate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (newAiAgentsUpdateRequest != null) localVarRequestOptions.Data = newAiAgentsUpdateRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<NewAiFolderIntegerWrapper>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAgentsUpdate", localVarResponse);
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
        /// <param name="newAiAgentsUpdateQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-update-quota/">REST API Reference for NewAiAgentsUpdateQuota Operation</seealso>
        /// <returns>NewAiFolderIntegerArrayWrapper</returns>
        public NewAiFolderIntegerArrayWrapper NewAiAgentsUpdateQuota(NewAiAgentsUpdateQuotaRequest newAiAgentsUpdateQuotaRequest)
        {
            var localVarResponse = NewAiAgentsUpdateQuotaWithHttpInfo(newAiAgentsUpdateQuotaRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update agents' quota
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAgentsUpdateQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-update-quota/">REST API Reference for NewAiAgentsUpdateQuota Operation</seealso>
        /// <returns>ApiResponse of NewAiFolderIntegerArrayWrapper</returns>
        public ApiResponse<NewAiFolderIntegerArrayWrapper> NewAiAgentsUpdateQuotaWithHttpInfo(NewAiAgentsUpdateQuotaRequest newAiAgentsUpdateQuotaRequest)
        {
            // verify the required parameter 'newAiAgentsUpdateQuotaRequest' is set
            if (newAiAgentsUpdateQuotaRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAgentsUpdateQuotaRequest' when calling AgentsApi->NewAiAgentsUpdateQuota");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAgentsUpdateQuotaRequest != null) localVarRequestOptions.Data = newAiAgentsUpdateQuotaRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<NewAiFolderIntegerArrayWrapper>("/api/2.0/ai/agents/agentquota", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAgentsUpdateQuota", localVarResponse);
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
        /// <param name="newAiAgentsUpdateQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-update-quota/">REST API Reference for NewAiAgentsUpdateQuota Operation</seealso>
        /// <returns>Task of NewAiFolderIntegerArrayWrapper</returns>
        public async Task<NewAiFolderIntegerArrayWrapper> NewAiAgentsUpdateQuotaAsync(NewAiAgentsUpdateQuotaRequest newAiAgentsUpdateQuotaRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAgentsUpdateQuotaWithHttpInfoAsync(newAiAgentsUpdateQuotaRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update agents' quota
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAgentsUpdateQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-agents-update-quota/">REST API Reference for NewAiAgentsUpdateQuota Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiFolderIntegerArrayWrapper)</returns>
        public async Task<ApiResponse<NewAiFolderIntegerArrayWrapper>> NewAiAgentsUpdateQuotaWithHttpInfoAsync(NewAiAgentsUpdateQuotaRequest newAiAgentsUpdateQuotaRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiAgentsUpdateQuotaRequest' is set
            if (newAiAgentsUpdateQuotaRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAgentsUpdateQuotaRequest' when calling AgentsApi->NewAiAgentsUpdateQuota");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAgentsUpdateQuotaRequest != null) localVarRequestOptions.Data = newAiAgentsUpdateQuotaRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<NewAiFolderIntegerArrayWrapper>("/api/2.0/ai/agents/agentquota", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAgentsUpdateQuota", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
