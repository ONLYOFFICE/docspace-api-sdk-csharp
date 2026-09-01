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
    public interface IProfilesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates an AI provider profile. The name must be unique and the credentials are validated against the provider before the profile is stored; the portal's first profile also takes the `Default` assignment slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiCreateProfileInput">Input for creating a new profile — the same shape as `Profile` without the engine-generated fields (`id`, `createdAt`).</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-create/">REST API Reference for AiProfilesCreate Operation</seealso>
        /// <returns>AiProfileMutationResult</returns>
        AiProfileMutationResult AiProfilesCreate(AiCreateProfileInput aiCreateProfileInput);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates an AI provider profile. The name must be unique and the credentials are validated against the provider before the profile is stored; the portal's first profile also takes the `Default` assignment slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiCreateProfileInput">Input for creating a new profile — the same shape as `Profile` without the engine-generated fields (`id`, `createdAt`).</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-create/">REST API Reference for AiProfilesCreate Operation</seealso>
        /// <returns>ApiResponse of AiProfileMutationResult</returns>
        ApiResponse<AiProfileMutationResult> AiProfilesCreateWithHttpInfo(AiCreateProfileInput aiCreateProfileInput);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes an AI provider profile and cleans up the assignments pointing at it - the `Default` slot moves to the first remaining profile, the other slots are unbound.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-delete/">REST API Reference for AiProfilesDelete Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiProfilesDelete(string body);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes an AI provider profile and cleans up the assignments pointing at it - the `Default` slot moves to the first remaining profile, the other slots are unbound.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-delete/">REST API Reference for AiProfilesDelete Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiProfilesDeleteWithHttpInfo(string body);
        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// Returns one AI provider profile, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The AI provider profile identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-get-by-id/">REST API Reference for AiProfilesGetById Operation</seealso>
        /// <returns>AiProfilesGetById200Response</returns>
        AiProfilesGetById200Response AiProfilesGetById(string id);

        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// Returns one AI provider profile, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The AI provider profile identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-get-by-id/">REST API Reference for AiProfilesGetById Operation</seealso>
        /// <returns>ApiResponse of AiProfilesGetById200Response</returns>
        ApiResponse<AiProfilesGetById200Response> AiProfilesGetByIdWithHttpInfo(string id);
        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// Lists the portal's AI provider profiles.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list/">REST API Reference for AiProfilesList Operation</seealso>
        /// <returns>List&lt;AiProfile&gt;</returns>
        List<AiProfile> AiProfilesList();

        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// Lists the portal's AI provider profiles.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list/">REST API Reference for AiProfilesList Operation</seealso>
        /// <returns>ApiResponse of List&lt;AiProfile&gt;</returns>
        ApiResponse<List<AiProfile>> AiProfilesListWithHttpInfo();
        /// <summary>
        /// List models
        /// </summary>
        /// <remarks>
        /// Lists the models the given profile's provider offers, as reported by the provider itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The AI provider profile identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list-models/">REST API Reference for AiProfilesListModels Operation</seealso>
        /// <returns>List&lt;AiModel&gt;</returns>
        List<AiModel> AiProfilesListModels(string profileId);

        /// <summary>
        /// List models
        /// </summary>
        /// <remarks>
        /// Lists the models the given profile's provider offers, as reported by the provider itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The AI provider profile identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list-models/">REST API Reference for AiProfilesListModels Operation</seealso>
        /// <returns>ApiResponse of List&lt;AiModel&gt;</returns>
        ApiResponse<List<AiModel>> AiProfilesListModelsWithHttpInfo(string profileId);
        /// <summary>
        /// List provider models
        /// </summary>
        /// <remarks>
        /// Lists the models a provider offers for the supplied endpoint and key, before any profile is created from them.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiProfilesListProviderModelsRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list-provider-models/">REST API Reference for AiProfilesListProviderModels Operation</seealso>
        /// <returns>List&lt;AiModel&gt;</returns>
        List<AiModel> AiProfilesListProviderModels(AiProfilesListProviderModelsRequest aiProfilesListProviderModelsRequest);

        /// <summary>
        /// List provider models
        /// </summary>
        /// <remarks>
        /// Lists the models a provider offers for the supplied endpoint and key, before any profile is created from them.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiProfilesListProviderModelsRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list-provider-models/">REST API Reference for AiProfilesListProviderModels Operation</seealso>
        /// <returns>ApiResponse of List&lt;AiModel&gt;</returns>
        ApiResponse<List<AiModel>> AiProfilesListProviderModelsWithHttpInfo(AiProfilesListProviderModelsRequest aiProfilesListProviderModelsRequest);
        /// <summary>
        /// Test connection
        /// </summary>
        /// <remarks>
        /// Checks a stored profile's credentials against its provider and reports the provider's own error when the call fails. Nothing is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-test-connection/">REST API Reference for AiProfilesTestConnection Operation</seealso>
        /// <returns>AiProfilesTestConnection200Response</returns>
        AiProfilesTestConnection200Response AiProfilesTestConnection(string body);

        /// <summary>
        /// Test connection
        /// </summary>
        /// <remarks>
        /// Checks a stored profile's credentials against its provider and reports the provider's own error when the call fails. Nothing is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-test-connection/">REST API Reference for AiProfilesTestConnection Operation</seealso>
        /// <returns>ApiResponse of AiProfilesTestConnection200Response</returns>
        ApiResponse<AiProfilesTestConnection200Response> AiProfilesTestConnectionWithHttpInfo(string body);
        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// Updates an AI provider profile, re-checking name uniqueness and the provider credentials.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiProfile">Complete AI provider + model configuration saved by the user. Profiles are the primary way users save and reuse provider configurations.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-update/">REST API Reference for AiProfilesUpdate Operation</seealso>
        /// <returns>AiProfileMutationResult</returns>
        AiProfileMutationResult AiProfilesUpdate(AiProfile aiProfile);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// Updates an AI provider profile, re-checking name uniqueness and the provider credentials.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiProfile">Complete AI provider + model configuration saved by the user. Profiles are the primary way users save and reuse provider configurations.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-update/">REST API Reference for AiProfilesUpdate Operation</seealso>
        /// <returns>ApiResponse of AiProfileMutationResult</returns>
        ApiResponse<AiProfileMutationResult> AiProfilesUpdateWithHttpInfo(AiProfile aiProfile);
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
        /// Creates an AI provider profile. The name must be unique and the credentials are validated against the provider before the profile is stored; the portal's first profile also takes the `Default` assignment slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiCreateProfileInput">Input for creating a new profile — the same shape as `Profile` without the engine-generated fields (`id`, `createdAt`).</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-create/">REST API Reference for AiProfilesCreate Operation</seealso>
        /// <returns>Task of AiProfileMutationResult</returns>
        Task<AiProfileMutationResult> AiProfilesCreateAsync(AiCreateProfileInput aiCreateProfileInput, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates an AI provider profile. The name must be unique and the credentials are validated against the provider before the profile is stored; the portal's first profile also takes the `Default` assignment slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiCreateProfileInput">Input for creating a new profile — the same shape as `Profile` without the engine-generated fields (`id`, `createdAt`).</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-create/">REST API Reference for AiProfilesCreate Operation</seealso>
        /// <returns>Task of ApiResponse (AiProfileMutationResult)</returns>
        Task<ApiResponse<AiProfileMutationResult>> AiProfilesCreateWithHttpInfoAsync(AiCreateProfileInput aiCreateProfileInput, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes an AI provider profile and cleans up the assignments pointing at it - the `Default` slot moves to the first remaining profile, the other slots are unbound.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-delete/">REST API Reference for AiProfilesDelete Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiProfilesDeleteAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes an AI provider profile and cleans up the assignments pointing at it - the `Default` slot moves to the first remaining profile, the other slots are unbound.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-delete/">REST API Reference for AiProfilesDelete Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiProfilesDeleteWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// Returns one AI provider profile, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The AI provider profile identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-get-by-id/">REST API Reference for AiProfilesGetById Operation</seealso>
        /// <returns>Task of AiProfilesGetById200Response</returns>
        Task<AiProfilesGetById200Response> AiProfilesGetByIdAsync(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// Returns one AI provider profile, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The AI provider profile identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-get-by-id/">REST API Reference for AiProfilesGetById Operation</seealso>
        /// <returns>Task of ApiResponse (AiProfilesGetById200Response)</returns>
        Task<ApiResponse<AiProfilesGetById200Response>> AiProfilesGetByIdWithHttpInfoAsync(string id, CancellationToken cancellationToken = default);
        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// Lists the portal's AI provider profiles.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list/">REST API Reference for AiProfilesList Operation</seealso>
        /// <returns>Task of List&lt;AiProfile&gt;</returns>
        Task<List<AiProfile>> AiProfilesListAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// Lists the portal's AI provider profiles.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list/">REST API Reference for AiProfilesList Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;AiProfile&gt;)</returns>
        Task<ApiResponse<List<AiProfile>>> AiProfilesListWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// List models
        /// </summary>
        /// <remarks>
        /// Lists the models the given profile's provider offers, as reported by the provider itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The AI provider profile identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list-models/">REST API Reference for AiProfilesListModels Operation</seealso>
        /// <returns>Task of List&lt;AiModel&gt;</returns>
        Task<List<AiModel>> AiProfilesListModelsAsync(string profileId, CancellationToken cancellationToken = default);

        /// <summary>
        /// List models
        /// </summary>
        /// <remarks>
        /// Lists the models the given profile's provider offers, as reported by the provider itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The AI provider profile identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list-models/">REST API Reference for AiProfilesListModels Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;AiModel&gt;)</returns>
        Task<ApiResponse<List<AiModel>>> AiProfilesListModelsWithHttpInfoAsync(string profileId, CancellationToken cancellationToken = default);
        /// <summary>
        /// List provider models
        /// </summary>
        /// <remarks>
        /// Lists the models a provider offers for the supplied endpoint and key, before any profile is created from them.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiProfilesListProviderModelsRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list-provider-models/">REST API Reference for AiProfilesListProviderModels Operation</seealso>
        /// <returns>Task of List&lt;AiModel&gt;</returns>
        Task<List<AiModel>> AiProfilesListProviderModelsAsync(AiProfilesListProviderModelsRequest aiProfilesListProviderModelsRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// List provider models
        /// </summary>
        /// <remarks>
        /// Lists the models a provider offers for the supplied endpoint and key, before any profile is created from them.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiProfilesListProviderModelsRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list-provider-models/">REST API Reference for AiProfilesListProviderModels Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;AiModel&gt;)</returns>
        Task<ApiResponse<List<AiModel>>> AiProfilesListProviderModelsWithHttpInfoAsync(AiProfilesListProviderModelsRequest aiProfilesListProviderModelsRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Test connection
        /// </summary>
        /// <remarks>
        /// Checks a stored profile's credentials against its provider and reports the provider's own error when the call fails. Nothing is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-test-connection/">REST API Reference for AiProfilesTestConnection Operation</seealso>
        /// <returns>Task of AiProfilesTestConnection200Response</returns>
        Task<AiProfilesTestConnection200Response> AiProfilesTestConnectionAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Test connection
        /// </summary>
        /// <remarks>
        /// Checks a stored profile's credentials against its provider and reports the provider's own error when the call fails. Nothing is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-test-connection/">REST API Reference for AiProfilesTestConnection Operation</seealso>
        /// <returns>Task of ApiResponse (AiProfilesTestConnection200Response)</returns>
        Task<ApiResponse<AiProfilesTestConnection200Response>> AiProfilesTestConnectionWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// Updates an AI provider profile, re-checking name uniqueness and the provider credentials.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiProfile">Complete AI provider + model configuration saved by the user. Profiles are the primary way users save and reuse provider configurations.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-update/">REST API Reference for AiProfilesUpdate Operation</seealso>
        /// <returns>Task of AiProfileMutationResult</returns>
        Task<AiProfileMutationResult> AiProfilesUpdateAsync(AiProfile aiProfile, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// Updates an AI provider profile, re-checking name uniqueness and the provider credentials.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiProfile">Complete AI provider + model configuration saved by the user. Profiles are the primary way users save and reuse provider configurations.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-update/">REST API Reference for AiProfilesUpdate Operation</seealso>
        /// <returns>Task of ApiResponse (AiProfileMutationResult)</returns>
        Task<ApiResponse<AiProfileMutationResult>> AiProfilesUpdateWithHttpInfoAsync(AiProfile aiProfile, CancellationToken cancellationToken = default);
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
        /// <remarks>
        /// Creates an AI provider profile. The name must be unique and the credentials are validated against the provider before the profile is stored; the portal's first profile also takes the `Default` assignment slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiCreateProfileInput">Input for creating a new profile — the same shape as `Profile` without the engine-generated fields (`id`, `createdAt`).</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-create/">REST API Reference for AiProfilesCreate Operation</seealso>
        /// <returns>AiProfileMutationResult</returns>
        public AiProfileMutationResult AiProfilesCreate(AiCreateProfileInput aiCreateProfileInput)
        {
            var localVarResponse = AiProfilesCreateWithHttpInfo(aiCreateProfileInput);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates an AI provider profile. The name must be unique and the credentials are validated against the provider before the profile is stored; the portal's first profile also takes the `Default` assignment slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiCreateProfileInput">Input for creating a new profile — the same shape as `Profile` without the engine-generated fields (`id`, `createdAt`).</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-create/">REST API Reference for AiProfilesCreate Operation</seealso>
        /// <returns>ApiResponse of AiProfileMutationResult</returns>
        public ApiResponse<AiProfileMutationResult> AiProfilesCreateWithHttpInfo(AiCreateProfileInput aiCreateProfileInput)
        {
            // verify the required parameter 'aiCreateProfileInput' is set
            if (aiCreateProfileInput == null)
                throw new ApiException(400, "Missing required parameter 'aiCreateProfileInput' when calling ProfilesApi->AiProfilesCreate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiCreateProfileInput != null) localVarRequestOptions.Data = aiCreateProfileInput;


            // make the HTTP request
            var localVarResponse = Client.Post<AiProfileMutationResult>("/api/2.0/ai/profiles/create", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiProfilesCreate", localVarResponse);
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
        /// <remarks>
        /// Creates an AI provider profile. The name must be unique and the credentials are validated against the provider before the profile is stored; the portal's first profile also takes the `Default` assignment slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiCreateProfileInput">Input for creating a new profile — the same shape as `Profile` without the engine-generated fields (`id`, `createdAt`).</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-create/">REST API Reference for AiProfilesCreate Operation</seealso>
        /// <returns>Task of AiProfileMutationResult</returns>
        public async Task<AiProfileMutationResult> AiProfilesCreateAsync(AiCreateProfileInput aiCreateProfileInput, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiProfilesCreateWithHttpInfoAsync(aiCreateProfileInput, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates an AI provider profile. The name must be unique and the credentials are validated against the provider before the profile is stored; the portal's first profile also takes the `Default` assignment slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiCreateProfileInput">Input for creating a new profile — the same shape as `Profile` without the engine-generated fields (`id`, `createdAt`).</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-create/">REST API Reference for AiProfilesCreate Operation</seealso>
        /// <returns>Task of ApiResponse (AiProfileMutationResult)</returns>
        public async Task<ApiResponse<AiProfileMutationResult>> AiProfilesCreateWithHttpInfoAsync(AiCreateProfileInput aiCreateProfileInput, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiCreateProfileInput' is set
            if (aiCreateProfileInput == null)
                throw new ApiException(400, "Missing required parameter 'aiCreateProfileInput' when calling ProfilesApi->AiProfilesCreate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiCreateProfileInput != null) localVarRequestOptions.Data = aiCreateProfileInput;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiProfileMutationResult>("/api/2.0/ai/profiles/create", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiProfilesCreate", localVarResponse);
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
        /// <remarks>
        /// Deletes an AI provider profile and cleans up the assignments pointing at it - the `Default` slot moves to the first remaining profile, the other slots are unbound.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-delete/">REST API Reference for AiProfilesDelete Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiProfilesDelete(string body)
        {
            var localVarResponse = AiProfilesDeleteWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes an AI provider profile and cleans up the assignments pointing at it - the `Default` slot moves to the first remaining profile, the other slots are unbound.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-delete/">REST API Reference for AiProfilesDelete Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiProfilesDeleteWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProfilesApi->AiProfilesDelete");

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
            var localVarResponse = Client.Delete<AiSuccessResponse>("/api/2.0/ai/profiles/delete", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiProfilesDelete", localVarResponse);
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
        /// <remarks>
        /// Deletes an AI provider profile and cleans up the assignments pointing at it - the `Default` slot moves to the first remaining profile, the other slots are unbound.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-delete/">REST API Reference for AiProfilesDelete Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiProfilesDeleteAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiProfilesDeleteWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes an AI provider profile and cleans up the assignments pointing at it - the `Default` slot moves to the first remaining profile, the other slots are unbound.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-delete/">REST API Reference for AiProfilesDelete Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiProfilesDeleteWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProfilesApi->AiProfilesDelete");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<AiSuccessResponse>("/api/2.0/ai/profiles/delete", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiProfilesDelete", localVarResponse);
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
        /// <remarks>
        /// Returns one AI provider profile, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The AI provider profile identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-get-by-id/">REST API Reference for AiProfilesGetById Operation</seealso>
        /// <returns>AiProfilesGetById200Response</returns>
        public AiProfilesGetById200Response AiProfilesGetById(string id)
        {
            var localVarResponse = AiProfilesGetByIdWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// Returns one AI provider profile, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The AI provider profile identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-get-by-id/">REST API Reference for AiProfilesGetById Operation</seealso>
        /// <returns>ApiResponse of AiProfilesGetById200Response</returns>
        public ApiResponse<AiProfilesGetById200Response> AiProfilesGetByIdWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ProfilesApi->AiProfilesGetById");

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
            var localVarResponse = Client.Get<AiProfilesGetById200Response>("/api/2.0/ai/profiles/get-by-id", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiProfilesGetById", localVarResponse);
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
        /// <remarks>
        /// Returns one AI provider profile, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The AI provider profile identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-get-by-id/">REST API Reference for AiProfilesGetById Operation</seealso>
        /// <returns>Task of AiProfilesGetById200Response</returns>
        public async Task<AiProfilesGetById200Response> AiProfilesGetByIdAsync(string id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiProfilesGetByIdWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// Returns one AI provider profile, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The AI provider profile identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-get-by-id/">REST API Reference for AiProfilesGetById Operation</seealso>
        /// <returns>Task of ApiResponse (AiProfilesGetById200Response)</returns>
        public async Task<ApiResponse<AiProfilesGetById200Response>> AiProfilesGetByIdWithHttpInfoAsync(string id, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ProfilesApi->AiProfilesGetById");

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

            var localVarResponse = await AsynchronousClient.GetAsync<AiProfilesGetById200Response>("/api/2.0/ai/profiles/get-by-id", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiProfilesGetById", localVarResponse);
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
        /// <remarks>
        /// Lists the portal's AI provider profiles.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list/">REST API Reference for AiProfilesList Operation</seealso>
        /// <returns>List&lt;AiProfile&gt;</returns>
        public List<AiProfile> AiProfilesList()
        {
            var localVarResponse = AiProfilesListWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// Lists the portal's AI provider profiles.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list/">REST API Reference for AiProfilesList Operation</seealso>
        /// <returns>ApiResponse of List&lt;AiProfile&gt;</returns>
        public ApiResponse<List<AiProfile>> AiProfilesListWithHttpInfo()
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
            var localVarResponse = Client.Get<List<AiProfile>>("/api/2.0/ai/profiles/list", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiProfilesList", localVarResponse);
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
        /// <remarks>
        /// Lists the portal's AI provider profiles.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list/">REST API Reference for AiProfilesList Operation</seealso>
        /// <returns>Task of List&lt;AiProfile&gt;</returns>
        public async Task<List<AiProfile>> AiProfilesListAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiProfilesListWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// Lists the portal's AI provider profiles.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list/">REST API Reference for AiProfilesList Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;AiProfile&gt;)</returns>
        public async Task<ApiResponse<List<AiProfile>>> AiProfilesListWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<List<AiProfile>>("/api/2.0/ai/profiles/list", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiProfilesList", localVarResponse);
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
        /// <remarks>
        /// Lists the models the given profile's provider offers, as reported by the provider itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The AI provider profile identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list-models/">REST API Reference for AiProfilesListModels Operation</seealso>
        /// <returns>List&lt;AiModel&gt;</returns>
        public List<AiModel> AiProfilesListModels(string profileId)
        {
            var localVarResponse = AiProfilesListModelsWithHttpInfo(profileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List models
        /// </summary>
        /// <remarks>
        /// Lists the models the given profile's provider offers, as reported by the provider itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The AI provider profile identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list-models/">REST API Reference for AiProfilesListModels Operation</seealso>
        /// <returns>ApiResponse of List&lt;AiModel&gt;</returns>
        public ApiResponse<List<AiModel>> AiProfilesListModelsWithHttpInfo(string profileId)
        {
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling ProfilesApi->AiProfilesListModels");

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
            var localVarResponse = Client.Get<List<AiModel>>("/api/2.0/ai/profiles/list-models", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiProfilesListModels", localVarResponse);
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
        /// <remarks>
        /// Lists the models the given profile's provider offers, as reported by the provider itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The AI provider profile identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list-models/">REST API Reference for AiProfilesListModels Operation</seealso>
        /// <returns>Task of List&lt;AiModel&gt;</returns>
        public async Task<List<AiModel>> AiProfilesListModelsAsync(string profileId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiProfilesListModelsWithHttpInfoAsync(profileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List models
        /// </summary>
        /// <remarks>
        /// Lists the models the given profile's provider offers, as reported by the provider itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The AI provider profile identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list-models/">REST API Reference for AiProfilesListModels Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;AiModel&gt;)</returns>
        public async Task<ApiResponse<List<AiModel>>> AiProfilesListModelsWithHttpInfoAsync(string profileId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling ProfilesApi->AiProfilesListModels");

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

            var localVarResponse = await AsynchronousClient.GetAsync<List<AiModel>>("/api/2.0/ai/profiles/list-models", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiProfilesListModels", localVarResponse);
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
        /// <remarks>
        /// Lists the models a provider offers for the supplied endpoint and key, before any profile is created from them.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiProfilesListProviderModelsRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list-provider-models/">REST API Reference for AiProfilesListProviderModels Operation</seealso>
        /// <returns>List&lt;AiModel&gt;</returns>
        public List<AiModel> AiProfilesListProviderModels(AiProfilesListProviderModelsRequest aiProfilesListProviderModelsRequest)
        {
            var localVarResponse = AiProfilesListProviderModelsWithHttpInfo(aiProfilesListProviderModelsRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List provider models
        /// </summary>
        /// <remarks>
        /// Lists the models a provider offers for the supplied endpoint and key, before any profile is created from them.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiProfilesListProviderModelsRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list-provider-models/">REST API Reference for AiProfilesListProviderModels Operation</seealso>
        /// <returns>ApiResponse of List&lt;AiModel&gt;</returns>
        public ApiResponse<List<AiModel>> AiProfilesListProviderModelsWithHttpInfo(AiProfilesListProviderModelsRequest aiProfilesListProviderModelsRequest)
        {
            // verify the required parameter 'aiProfilesListProviderModelsRequest' is set
            if (aiProfilesListProviderModelsRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiProfilesListProviderModelsRequest' when calling ProfilesApi->AiProfilesListProviderModels");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiProfilesListProviderModelsRequest != null) localVarRequestOptions.Data = aiProfilesListProviderModelsRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<List<AiModel>>("/api/2.0/ai/profiles/list-provider-models", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiProfilesListProviderModels", localVarResponse);
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
        /// <remarks>
        /// Lists the models a provider offers for the supplied endpoint and key, before any profile is created from them.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiProfilesListProviderModelsRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list-provider-models/">REST API Reference for AiProfilesListProviderModels Operation</seealso>
        /// <returns>Task of List&lt;AiModel&gt;</returns>
        public async Task<List<AiModel>> AiProfilesListProviderModelsAsync(AiProfilesListProviderModelsRequest aiProfilesListProviderModelsRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiProfilesListProviderModelsWithHttpInfoAsync(aiProfilesListProviderModelsRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List provider models
        /// </summary>
        /// <remarks>
        /// Lists the models a provider offers for the supplied endpoint and key, before any profile is created from them.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiProfilesListProviderModelsRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list-provider-models/">REST API Reference for AiProfilesListProviderModels Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;AiModel&gt;)</returns>
        public async Task<ApiResponse<List<AiModel>>> AiProfilesListProviderModelsWithHttpInfoAsync(AiProfilesListProviderModelsRequest aiProfilesListProviderModelsRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiProfilesListProviderModelsRequest' is set
            if (aiProfilesListProviderModelsRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiProfilesListProviderModelsRequest' when calling ProfilesApi->AiProfilesListProviderModels");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiProfilesListProviderModelsRequest != null) localVarRequestOptions.Data = aiProfilesListProviderModelsRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<List<AiModel>>("/api/2.0/ai/profiles/list-provider-models", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiProfilesListProviderModels", localVarResponse);
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
        /// <remarks>
        /// Checks a stored profile's credentials against its provider and reports the provider's own error when the call fails. Nothing is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-test-connection/">REST API Reference for AiProfilesTestConnection Operation</seealso>
        /// <returns>AiProfilesTestConnection200Response</returns>
        public AiProfilesTestConnection200Response AiProfilesTestConnection(string body)
        {
            var localVarResponse = AiProfilesTestConnectionWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Test connection
        /// </summary>
        /// <remarks>
        /// Checks a stored profile's credentials against its provider and reports the provider's own error when the call fails. Nothing is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-test-connection/">REST API Reference for AiProfilesTestConnection Operation</seealso>
        /// <returns>ApiResponse of AiProfilesTestConnection200Response</returns>
        public ApiResponse<AiProfilesTestConnection200Response> AiProfilesTestConnectionWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProfilesApi->AiProfilesTestConnection");

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
            var localVarResponse = Client.Post<AiProfilesTestConnection200Response>("/api/2.0/ai/profiles/test-connection", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiProfilesTestConnection", localVarResponse);
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
        /// <remarks>
        /// Checks a stored profile's credentials against its provider and reports the provider's own error when the call fails. Nothing is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-test-connection/">REST API Reference for AiProfilesTestConnection Operation</seealso>
        /// <returns>Task of AiProfilesTestConnection200Response</returns>
        public async Task<AiProfilesTestConnection200Response> AiProfilesTestConnectionAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiProfilesTestConnectionWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Test connection
        /// </summary>
        /// <remarks>
        /// Checks a stored profile's credentials against its provider and reports the provider's own error when the call fails. Nothing is written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-test-connection/">REST API Reference for AiProfilesTestConnection Operation</seealso>
        /// <returns>Task of ApiResponse (AiProfilesTestConnection200Response)</returns>
        public async Task<ApiResponse<AiProfilesTestConnection200Response>> AiProfilesTestConnectionWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProfilesApi->AiProfilesTestConnection");

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

            var localVarResponse = await AsynchronousClient.PostAsync<AiProfilesTestConnection200Response>("/api/2.0/ai/profiles/test-connection", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiProfilesTestConnection", localVarResponse);
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
        /// <remarks>
        /// Updates an AI provider profile, re-checking name uniqueness and the provider credentials.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiProfile">Complete AI provider + model configuration saved by the user. Profiles are the primary way users save and reuse provider configurations.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-update/">REST API Reference for AiProfilesUpdate Operation</seealso>
        /// <returns>AiProfileMutationResult</returns>
        public AiProfileMutationResult AiProfilesUpdate(AiProfile aiProfile)
        {
            var localVarResponse = AiProfilesUpdateWithHttpInfo(aiProfile);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// Updates an AI provider profile, re-checking name uniqueness and the provider credentials.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiProfile">Complete AI provider + model configuration saved by the user. Profiles are the primary way users save and reuse provider configurations.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-update/">REST API Reference for AiProfilesUpdate Operation</seealso>
        /// <returns>ApiResponse of AiProfileMutationResult</returns>
        public ApiResponse<AiProfileMutationResult> AiProfilesUpdateWithHttpInfo(AiProfile aiProfile)
        {
            // verify the required parameter 'aiProfile' is set
            if (aiProfile == null)
                throw new ApiException(400, "Missing required parameter 'aiProfile' when calling ProfilesApi->AiProfilesUpdate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiProfile != null) localVarRequestOptions.Data = aiProfile;


            // make the HTTP request
            var localVarResponse = Client.Put<AiProfileMutationResult>("/api/2.0/ai/profiles/update", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiProfilesUpdate", localVarResponse);
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
        /// <remarks>
        /// Updates an AI provider profile, re-checking name uniqueness and the provider credentials.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiProfile">Complete AI provider + model configuration saved by the user. Profiles are the primary way users save and reuse provider configurations.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-update/">REST API Reference for AiProfilesUpdate Operation</seealso>
        /// <returns>Task of AiProfileMutationResult</returns>
        public async Task<AiProfileMutationResult> AiProfilesUpdateAsync(AiProfile aiProfile, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiProfilesUpdateWithHttpInfoAsync(aiProfile, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// Updates an AI provider profile, re-checking name uniqueness and the provider credentials.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiProfile">Complete AI provider + model configuration saved by the user. Profiles are the primary way users save and reuse provider configurations.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-update/">REST API Reference for AiProfilesUpdate Operation</seealso>
        /// <returns>Task of ApiResponse (AiProfileMutationResult)</returns>
        public async Task<ApiResponse<AiProfileMutationResult>> AiProfilesUpdateWithHttpInfoAsync(AiProfile aiProfile, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiProfile' is set
            if (aiProfile == null)
                throw new ApiException(400, "Missing required parameter 'aiProfile' when calling ProfilesApi->AiProfilesUpdate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiProfile != null) localVarRequestOptions.Data = aiProfile;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<AiProfileMutationResult>("/api/2.0/ai/profiles/update", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiProfilesUpdate", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
