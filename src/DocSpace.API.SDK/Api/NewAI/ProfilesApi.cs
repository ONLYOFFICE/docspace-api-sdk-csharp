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
    public interface IProfilesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiCreateProfileInput">Input for creating a new profile — the same shape as  {@link  Profile }  without the engine-generated fields (`id`, `createdAt`).</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-create/">REST API Reference for NewAiProfilesCreate Operation</seealso>
        /// <returns>NewAiProfileMutationResult</returns>
        NewAiProfileMutationResult NewAiProfilesCreate(NewAiCreateProfileInput newAiCreateProfileInput);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiCreateProfileInput">Input for creating a new profile — the same shape as  {@link  Profile }  without the engine-generated fields (`id`, `createdAt`).</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-create/">REST API Reference for NewAiProfilesCreate Operation</seealso>
        /// <returns>ApiResponse of NewAiProfileMutationResult</returns>
        ApiResponse<NewAiProfileMutationResult> NewAiProfilesCreateWithHttpInfo(NewAiCreateProfileInput newAiCreateProfileInput);
        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-delete/">REST API Reference for NewAiProfilesDelete Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        NewAiSuccessResponse NewAiProfilesDelete(string body);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-delete/">REST API Reference for NewAiProfilesDelete Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        ApiResponse<NewAiSuccessResponse> NewAiProfilesDeleteWithHttpInfo(string body);
        /// <summary>
        /// Get by id
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-get-by-id/">REST API Reference for NewAiProfilesGetById Operation</seealso>
        /// <returns>NewAiProfile</returns>
        NewAiProfile NewAiProfilesGetById(string id);

        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-get-by-id/">REST API Reference for NewAiProfilesGetById Operation</seealso>
        /// <returns>ApiResponse of NewAiProfile</returns>
        ApiResponse<NewAiProfile> NewAiProfilesGetByIdWithHttpInfo(string id);
        /// <summary>
        /// List
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list/">REST API Reference for NewAiProfilesList Operation</seealso>
        /// <returns>List&lt;NewAiProfile&gt;</returns>
        List<NewAiProfile> NewAiProfilesList();

        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list/">REST API Reference for NewAiProfilesList Operation</seealso>
        /// <returns>ApiResponse of List&lt;NewAiProfile&gt;</returns>
        ApiResponse<List<NewAiProfile>> NewAiProfilesListWithHttpInfo();
        /// <summary>
        /// List models
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list-models/">REST API Reference for NewAiProfilesListModels Operation</seealso>
        /// <returns>List&lt;NewAiModel&gt;</returns>
        List<NewAiModel> NewAiProfilesListModels(string profileId);

        /// <summary>
        /// List models
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list-models/">REST API Reference for NewAiProfilesListModels Operation</seealso>
        /// <returns>ApiResponse of List&lt;NewAiModel&gt;</returns>
        ApiResponse<List<NewAiModel>> NewAiProfilesListModelsWithHttpInfo(string profileId);
        /// <summary>
        /// List provider models
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiProfilesListProviderModelsRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list-provider-models/">REST API Reference for NewAiProfilesListProviderModels Operation</seealso>
        /// <returns>List&lt;NewAiModel&gt;</returns>
        List<NewAiModel> NewAiProfilesListProviderModels(NewAiProfilesListProviderModelsRequest newAiProfilesListProviderModelsRequest);

        /// <summary>
        /// List provider models
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiProfilesListProviderModelsRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list-provider-models/">REST API Reference for NewAiProfilesListProviderModels Operation</seealso>
        /// <returns>ApiResponse of List&lt;NewAiModel&gt;</returns>
        ApiResponse<List<NewAiModel>> NewAiProfilesListProviderModelsWithHttpInfo(NewAiProfilesListProviderModelsRequest newAiProfilesListProviderModelsRequest);
        /// <summary>
        /// Test connection
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-test-connection/">REST API Reference for NewAiProfilesTestConnection Operation</seealso>
        /// <returns>NewAiProfilesTestConnection200Response</returns>
        NewAiProfilesTestConnection200Response NewAiProfilesTestConnection(string body);

        /// <summary>
        /// Test connection
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-test-connection/">REST API Reference for NewAiProfilesTestConnection Operation</seealso>
        /// <returns>ApiResponse of NewAiProfilesTestConnection200Response</returns>
        ApiResponse<NewAiProfilesTestConnection200Response> NewAiProfilesTestConnectionWithHttpInfo(string body);
        /// <summary>
        /// Update
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiProfile">Complete AI provider + model configuration saved by the user. Profiles are the primary way users save and reuse provider configurations.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-update/">REST API Reference for NewAiProfilesUpdate Operation</seealso>
        /// <returns>NewAiProfileMutationResult</returns>
        NewAiProfileMutationResult NewAiProfilesUpdate(NewAiProfile newAiProfile);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiProfile">Complete AI provider + model configuration saved by the user. Profiles are the primary way users save and reuse provider configurations.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-update/">REST API Reference for NewAiProfilesUpdate Operation</seealso>
        /// <returns>ApiResponse of NewAiProfileMutationResult</returns>
        ApiResponse<NewAiProfileMutationResult> NewAiProfilesUpdateWithHttpInfo(NewAiProfile newAiProfile);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProfilesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiCreateProfileInput">Input for creating a new profile — the same shape as  {@link  Profile }  without the engine-generated fields (`id`, `createdAt`).</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-create/">REST API Reference for NewAiProfilesCreate Operation</seealso>
        /// <returns>Task of NewAiProfileMutationResult</returns>
        Task<NewAiProfileMutationResult> NewAiProfilesCreateAsync(NewAiCreateProfileInput newAiCreateProfileInput, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiCreateProfileInput">Input for creating a new profile — the same shape as  {@link  Profile }  without the engine-generated fields (`id`, `createdAt`).</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-create/">REST API Reference for NewAiProfilesCreate Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiProfileMutationResult)</returns>
        Task<ApiResponse<NewAiProfileMutationResult>> NewAiProfilesCreateWithHttpInfoAsync(NewAiCreateProfileInput newAiCreateProfileInput, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-delete/">REST API Reference for NewAiProfilesDelete Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        Task<NewAiSuccessResponse> NewAiProfilesDeleteAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-delete/">REST API Reference for NewAiProfilesDelete Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        Task<ApiResponse<NewAiSuccessResponse>> NewAiProfilesDeleteWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-get-by-id/">REST API Reference for NewAiProfilesGetById Operation</seealso>
        /// <returns>Task of NewAiProfile</returns>
        Task<NewAiProfile> NewAiProfilesGetByIdAsync(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-get-by-id/">REST API Reference for NewAiProfilesGetById Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiProfile)</returns>
        Task<ApiResponse<NewAiProfile>> NewAiProfilesGetByIdWithHttpInfoAsync(string id, CancellationToken cancellationToken = default);
        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list/">REST API Reference for NewAiProfilesList Operation</seealso>
        /// <returns>Task of List&lt;NewAiProfile&gt;</returns>
        Task<List<NewAiProfile>> NewAiProfilesListAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list/">REST API Reference for NewAiProfilesList Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;NewAiProfile&gt;)</returns>
        Task<ApiResponse<List<NewAiProfile>>> NewAiProfilesListWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// List models
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list-models/">REST API Reference for NewAiProfilesListModels Operation</seealso>
        /// <returns>Task of List&lt;NewAiModel&gt;</returns>
        Task<List<NewAiModel>> NewAiProfilesListModelsAsync(string profileId, CancellationToken cancellationToken = default);

        /// <summary>
        /// List models
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list-models/">REST API Reference for NewAiProfilesListModels Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;NewAiModel&gt;)</returns>
        Task<ApiResponse<List<NewAiModel>>> NewAiProfilesListModelsWithHttpInfoAsync(string profileId, CancellationToken cancellationToken = default);
        /// <summary>
        /// List provider models
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiProfilesListProviderModelsRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list-provider-models/">REST API Reference for NewAiProfilesListProviderModels Operation</seealso>
        /// <returns>Task of List&lt;NewAiModel&gt;</returns>
        Task<List<NewAiModel>> NewAiProfilesListProviderModelsAsync(NewAiProfilesListProviderModelsRequest newAiProfilesListProviderModelsRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// List provider models
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiProfilesListProviderModelsRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list-provider-models/">REST API Reference for NewAiProfilesListProviderModels Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;NewAiModel&gt;)</returns>
        Task<ApiResponse<List<NewAiModel>>> NewAiProfilesListProviderModelsWithHttpInfoAsync(NewAiProfilesListProviderModelsRequest newAiProfilesListProviderModelsRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Test connection
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-test-connection/">REST API Reference for NewAiProfilesTestConnection Operation</seealso>
        /// <returns>Task of NewAiProfilesTestConnection200Response</returns>
        Task<NewAiProfilesTestConnection200Response> NewAiProfilesTestConnectionAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Test connection
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-test-connection/">REST API Reference for NewAiProfilesTestConnection Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiProfilesTestConnection200Response)</returns>
        Task<ApiResponse<NewAiProfilesTestConnection200Response>> NewAiProfilesTestConnectionWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiProfile">Complete AI provider + model configuration saved by the user. Profiles are the primary way users save and reuse provider configurations.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-update/">REST API Reference for NewAiProfilesUpdate Operation</seealso>
        /// <returns>Task of NewAiProfileMutationResult</returns>
        Task<NewAiProfileMutationResult> NewAiProfilesUpdateAsync(NewAiProfile newAiProfile, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiProfile">Complete AI provider + model configuration saved by the user. Profiles are the primary way users save and reuse provider configurations.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-update/">REST API Reference for NewAiProfilesUpdate Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiProfileMutationResult)</returns>
        Task<ApiResponse<NewAiProfileMutationResult>> NewAiProfilesUpdateWithHttpInfoAsync(NewAiProfile newAiProfile, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProfilesApi : IProfilesApiSync, IProfilesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProfilesApi : IDisposable, IProfilesApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public ProfilesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public ProfilesApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public ProfilesApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public ProfilesApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class.
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
        public ProfilesApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class using a Configuration object.
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
        public ProfilesApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ProfilesApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Create
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiCreateProfileInput">Input for creating a new profile — the same shape as  {@link  Profile }  without the engine-generated fields (`id`, `createdAt`).</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-create/">REST API Reference for NewAiProfilesCreate Operation</seealso>
        /// <returns>NewAiProfileMutationResult</returns>
        public NewAiProfileMutationResult NewAiProfilesCreate(NewAiCreateProfileInput newAiCreateProfileInput)
        {
            var localVarResponse = NewAiProfilesCreateWithHttpInfo(newAiCreateProfileInput);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiCreateProfileInput">Input for creating a new profile — the same shape as  {@link  Profile }  without the engine-generated fields (`id`, `createdAt`).</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-create/">REST API Reference for NewAiProfilesCreate Operation</seealso>
        /// <returns>ApiResponse of NewAiProfileMutationResult</returns>
        public ApiResponse<NewAiProfileMutationResult> NewAiProfilesCreateWithHttpInfo(NewAiCreateProfileInput newAiCreateProfileInput)
        {
            // verify the required parameter 'newAiCreateProfileInput' is set
            if (newAiCreateProfileInput == null)
                throw new ApiException(400, "Missing required parameter 'newAiCreateProfileInput' when calling ProfilesApi->NewAiProfilesCreate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiCreateProfileInput != null) localVarRequestOptions.Data = newAiCreateProfileInput;


            // make the HTTP request
            var localVarResponse = Client.Post<NewAiProfileMutationResult>("/api/2.0/ai/profiles/create", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiProfilesCreate", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiCreateProfileInput">Input for creating a new profile — the same shape as  {@link  Profile }  without the engine-generated fields (`id`, `createdAt`).</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-create/">REST API Reference for NewAiProfilesCreate Operation</seealso>
        /// <returns>Task of NewAiProfileMutationResult</returns>
        public async Task<NewAiProfileMutationResult> NewAiProfilesCreateAsync(NewAiCreateProfileInput newAiCreateProfileInput, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiProfilesCreateWithHttpInfoAsync(newAiCreateProfileInput, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiCreateProfileInput">Input for creating a new profile — the same shape as  {@link  Profile }  without the engine-generated fields (`id`, `createdAt`).</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-create/">REST API Reference for NewAiProfilesCreate Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiProfileMutationResult)</returns>
        public async Task<ApiResponse<NewAiProfileMutationResult>> NewAiProfilesCreateWithHttpInfoAsync(NewAiCreateProfileInput newAiCreateProfileInput, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiCreateProfileInput' is set
            if (newAiCreateProfileInput == null)
                throw new ApiException(400, "Missing required parameter 'newAiCreateProfileInput' when calling ProfilesApi->NewAiProfilesCreate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiCreateProfileInput != null) localVarRequestOptions.Data = newAiCreateProfileInput;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<NewAiProfileMutationResult>("/api/2.0/ai/profiles/create", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiProfilesCreate", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-delete/">REST API Reference for NewAiProfilesDelete Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        public NewAiSuccessResponse NewAiProfilesDelete(string body)
        {
            var localVarResponse = NewAiProfilesDeleteWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-delete/">REST API Reference for NewAiProfilesDelete Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        public ApiResponse<NewAiSuccessResponse> NewAiProfilesDeleteWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProfilesApi->NewAiProfilesDelete");

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
            var localVarResponse = Client.Delete<NewAiSuccessResponse>("/api/2.0/ai/profiles/delete", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiProfilesDelete", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-delete/">REST API Reference for NewAiProfilesDelete Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        public async Task<NewAiSuccessResponse> NewAiProfilesDeleteAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiProfilesDeleteWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-delete/">REST API Reference for NewAiProfilesDelete Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        public async Task<ApiResponse<NewAiSuccessResponse>> NewAiProfilesDeleteWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProfilesApi->NewAiProfilesDelete");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<NewAiSuccessResponse>("/api/2.0/ai/profiles/delete", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiProfilesDelete", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get by id
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-get-by-id/">REST API Reference for NewAiProfilesGetById Operation</seealso>
        /// <returns>NewAiProfile</returns>
        public NewAiProfile NewAiProfilesGetById(string id)
        {
            var localVarResponse = NewAiProfilesGetByIdWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get by id
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-get-by-id/">REST API Reference for NewAiProfilesGetById Operation</seealso>
        /// <returns>ApiResponse of NewAiProfile</returns>
        public ApiResponse<NewAiProfile> NewAiProfilesGetByIdWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ProfilesApi->NewAiProfilesGetById");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "id", id));


            // make the HTTP request
            var localVarResponse = Client.Get<NewAiProfile>("/api/2.0/ai/profiles/get-by-id", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiProfilesGetById", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get by id
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-get-by-id/">REST API Reference for NewAiProfilesGetById Operation</seealso>
        /// <returns>Task of NewAiProfile</returns>
        public async Task<NewAiProfile> NewAiProfilesGetByIdAsync(string id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiProfilesGetByIdWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get by id
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-get-by-id/">REST API Reference for NewAiProfilesGetById Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiProfile)</returns>
        public async Task<ApiResponse<NewAiProfile>> NewAiProfilesGetByIdWithHttpInfoAsync(string id, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ProfilesApi->NewAiProfilesGetById");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "id", id));


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<NewAiProfile>("/api/2.0/ai/profiles/get-by-id", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiProfilesGetById", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list/">REST API Reference for NewAiProfilesList Operation</seealso>
        /// <returns>List&lt;NewAiProfile&gt;</returns>
        public List<NewAiProfile> NewAiProfilesList()
        {
            var localVarResponse = NewAiProfilesListWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// List
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list/">REST API Reference for NewAiProfilesList Operation</seealso>
        /// <returns>ApiResponse of List&lt;NewAiProfile&gt;</returns>
        public ApiResponse<List<NewAiProfile>> NewAiProfilesListWithHttpInfo()
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
            var localVarResponse = Client.Get<List<NewAiProfile>>("/api/2.0/ai/profiles/list", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiProfilesList", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list/">REST API Reference for NewAiProfilesList Operation</seealso>
        /// <returns>Task of List&lt;NewAiProfile&gt;</returns>
        public async Task<List<NewAiProfile>> NewAiProfilesListAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiProfilesListWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list/">REST API Reference for NewAiProfilesList Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;NewAiProfile&gt;)</returns>
        public async Task<ApiResponse<List<NewAiProfile>>> NewAiProfilesListWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<List<NewAiProfile>>("/api/2.0/ai/profiles/list", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiProfilesList", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List models
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list-models/">REST API Reference for NewAiProfilesListModels Operation</seealso>
        /// <returns>List&lt;NewAiModel&gt;</returns>
        public List<NewAiModel> NewAiProfilesListModels(string profileId)
        {
            var localVarResponse = NewAiProfilesListModelsWithHttpInfo(profileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List models
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list-models/">REST API Reference for NewAiProfilesListModels Operation</seealso>
        /// <returns>ApiResponse of List&lt;NewAiModel&gt;</returns>
        public ApiResponse<List<NewAiModel>> NewAiProfilesListModelsWithHttpInfo(string profileId)
        {
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling ProfilesApi->NewAiProfilesListModels");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "profileId", profileId));


            // make the HTTP request
            var localVarResponse = Client.Get<List<NewAiModel>>("/api/2.0/ai/profiles/list-models", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiProfilesListModels", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List models
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list-models/">REST API Reference for NewAiProfilesListModels Operation</seealso>
        /// <returns>Task of List&lt;NewAiModel&gt;</returns>
        public async Task<List<NewAiModel>> NewAiProfilesListModelsAsync(string profileId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiProfilesListModelsWithHttpInfoAsync(profileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List models
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list-models/">REST API Reference for NewAiProfilesListModels Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;NewAiModel&gt;)</returns>
        public async Task<ApiResponse<List<NewAiModel>>> NewAiProfilesListModelsWithHttpInfoAsync(string profileId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling ProfilesApi->NewAiProfilesListModels");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "profileId", profileId));


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<List<NewAiModel>>("/api/2.0/ai/profiles/list-models", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiProfilesListModels", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List provider models
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiProfilesListProviderModelsRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list-provider-models/">REST API Reference for NewAiProfilesListProviderModels Operation</seealso>
        /// <returns>List&lt;NewAiModel&gt;</returns>
        public List<NewAiModel> NewAiProfilesListProviderModels(NewAiProfilesListProviderModelsRequest newAiProfilesListProviderModelsRequest)
        {
            var localVarResponse = NewAiProfilesListProviderModelsWithHttpInfo(newAiProfilesListProviderModelsRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List provider models
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiProfilesListProviderModelsRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list-provider-models/">REST API Reference for NewAiProfilesListProviderModels Operation</seealso>
        /// <returns>ApiResponse of List&lt;NewAiModel&gt;</returns>
        public ApiResponse<List<NewAiModel>> NewAiProfilesListProviderModelsWithHttpInfo(NewAiProfilesListProviderModelsRequest newAiProfilesListProviderModelsRequest)
        {
            // verify the required parameter 'newAiProfilesListProviderModelsRequest' is set
            if (newAiProfilesListProviderModelsRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiProfilesListProviderModelsRequest' when calling ProfilesApi->NewAiProfilesListProviderModels");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiProfilesListProviderModelsRequest != null) localVarRequestOptions.Data = newAiProfilesListProviderModelsRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<List<NewAiModel>>("/api/2.0/ai/profiles/list-provider-models", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiProfilesListProviderModels", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List provider models
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiProfilesListProviderModelsRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list-provider-models/">REST API Reference for NewAiProfilesListProviderModels Operation</seealso>
        /// <returns>Task of List&lt;NewAiModel&gt;</returns>
        public async Task<List<NewAiModel>> NewAiProfilesListProviderModelsAsync(NewAiProfilesListProviderModelsRequest newAiProfilesListProviderModelsRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiProfilesListProviderModelsWithHttpInfoAsync(newAiProfilesListProviderModelsRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List provider models
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiProfilesListProviderModelsRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-list-provider-models/">REST API Reference for NewAiProfilesListProviderModels Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;NewAiModel&gt;)</returns>
        public async Task<ApiResponse<List<NewAiModel>>> NewAiProfilesListProviderModelsWithHttpInfoAsync(NewAiProfilesListProviderModelsRequest newAiProfilesListProviderModelsRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiProfilesListProviderModelsRequest' is set
            if (newAiProfilesListProviderModelsRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiProfilesListProviderModelsRequest' when calling ProfilesApi->NewAiProfilesListProviderModels");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiProfilesListProviderModelsRequest != null) localVarRequestOptions.Data = newAiProfilesListProviderModelsRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<List<NewAiModel>>("/api/2.0/ai/profiles/list-provider-models", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiProfilesListProviderModels", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Test connection
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-test-connection/">REST API Reference for NewAiProfilesTestConnection Operation</seealso>
        /// <returns>NewAiProfilesTestConnection200Response</returns>
        public NewAiProfilesTestConnection200Response NewAiProfilesTestConnection(string body)
        {
            var localVarResponse = NewAiProfilesTestConnectionWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Test connection
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-test-connection/">REST API Reference for NewAiProfilesTestConnection Operation</seealso>
        /// <returns>ApiResponse of NewAiProfilesTestConnection200Response</returns>
        public ApiResponse<NewAiProfilesTestConnection200Response> NewAiProfilesTestConnectionWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProfilesApi->NewAiProfilesTestConnection");

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
            var localVarResponse = Client.Post<NewAiProfilesTestConnection200Response>("/api/2.0/ai/profiles/test-connection", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiProfilesTestConnection", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Test connection
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-test-connection/">REST API Reference for NewAiProfilesTestConnection Operation</seealso>
        /// <returns>Task of NewAiProfilesTestConnection200Response</returns>
        public async Task<NewAiProfilesTestConnection200Response> NewAiProfilesTestConnectionAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiProfilesTestConnectionWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Test connection
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-test-connection/">REST API Reference for NewAiProfilesTestConnection Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiProfilesTestConnection200Response)</returns>
        public async Task<ApiResponse<NewAiProfilesTestConnection200Response>> NewAiProfilesTestConnectionWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProfilesApi->NewAiProfilesTestConnection");

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

            var localVarResponse = await AsynchronousClient.PostAsync<NewAiProfilesTestConnection200Response>("/api/2.0/ai/profiles/test-connection", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiProfilesTestConnection", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiProfile">Complete AI provider + model configuration saved by the user. Profiles are the primary way users save and reuse provider configurations.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-update/">REST API Reference for NewAiProfilesUpdate Operation</seealso>
        /// <returns>NewAiProfileMutationResult</returns>
        public NewAiProfileMutationResult NewAiProfilesUpdate(NewAiProfile newAiProfile)
        {
            var localVarResponse = NewAiProfilesUpdateWithHttpInfo(newAiProfile);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiProfile">Complete AI provider + model configuration saved by the user. Profiles are the primary way users save and reuse provider configurations.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-update/">REST API Reference for NewAiProfilesUpdate Operation</seealso>
        /// <returns>ApiResponse of NewAiProfileMutationResult</returns>
        public ApiResponse<NewAiProfileMutationResult> NewAiProfilesUpdateWithHttpInfo(NewAiProfile newAiProfile)
        {
            // verify the required parameter 'newAiProfile' is set
            if (newAiProfile == null)
                throw new ApiException(400, "Missing required parameter 'newAiProfile' when calling ProfilesApi->NewAiProfilesUpdate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiProfile != null) localVarRequestOptions.Data = newAiProfile;


            // make the HTTP request
            var localVarResponse = Client.Put<NewAiProfileMutationResult>("/api/2.0/ai/profiles/update", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiProfilesUpdate", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiProfile">Complete AI provider + model configuration saved by the user. Profiles are the primary way users save and reuse provider configurations.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-update/">REST API Reference for NewAiProfilesUpdate Operation</seealso>
        /// <returns>Task of NewAiProfileMutationResult</returns>
        public async Task<NewAiProfileMutationResult> NewAiProfilesUpdateAsync(NewAiProfile newAiProfile, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiProfilesUpdateWithHttpInfoAsync(newAiProfile, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiProfile">Complete AI provider + model configuration saved by the user. Profiles are the primary way users save and reuse provider configurations.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-profiles-update/">REST API Reference for NewAiProfilesUpdate Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiProfileMutationResult)</returns>
        public async Task<ApiResponse<NewAiProfileMutationResult>> NewAiProfilesUpdateWithHttpInfoAsync(NewAiProfile newAiProfile, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiProfile' is set
            if (newAiProfile == null)
                throw new ApiException(400, "Missing required parameter 'newAiProfile' when calling ProfilesApi->NewAiProfilesUpdate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiProfile != null) localVarRequestOptions.Data = newAiProfile;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<NewAiProfileMutationResult>("/api/2.0/ai/profiles/update", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiProfilesUpdate", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
