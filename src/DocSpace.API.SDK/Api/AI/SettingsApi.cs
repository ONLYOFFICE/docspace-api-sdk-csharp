// (c) Copyright Ascensio System SIA 2025
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
        /// Retrieves the combined AI configuration for the current portal, including the status of web search,  vectorization, and AI readiness, along with tool names and the portal MCP server identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-settings/">REST API Reference for GetAiSettings Operation</seealso>
        /// <returns>AiSettingsWrapper</returns>
        AiSettingsWrapper GetAiSettings();

        /// <summary>
        /// Get AI settings
        /// </summary>
        /// <remarks>
        /// Retrieves the combined AI configuration for the current portal, including the status of web search,  vectorization, and AI readiness, along with tool names and the portal MCP server identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-settings/">REST API Reference for GetAiSettings Operation</seealso>
        /// <returns>ApiResponse of AiSettingsWrapper</returns>
        ApiResponse<AiSettingsWrapper> GetAiSettingsWithHttpInfo();
        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <remarks>
        /// Retrieves the current embedding provider settings used for document vectorization,  including the configured provider type and whether the API key needs to be reset.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-vectorization-settings/">REST API Reference for GetVectorizationSettings Operation</seealso>
        /// <returns>VectorizationSettingsWrapper</returns>
        VectorizationSettingsWrapper GetVectorizationSettings();

        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <remarks>
        /// Retrieves the current embedding provider settings used for document vectorization,  including the configured provider type and whether the API key needs to be reset.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-vectorization-settings/">REST API Reference for GetVectorizationSettings Operation</seealso>
        /// <returns>ApiResponse of VectorizationSettingsWrapper</returns>
        ApiResponse<VectorizationSettingsWrapper> GetVectorizationSettingsWithHttpInfo();
        /// <summary>
        /// Get web search settings
        /// </summary>
        /// <remarks>
        /// Retrieves the current web search integration settings for AI chat sessions,  including whether web search is enabled, the configured search engine type, and whether the API key needs to be reset.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-web-search-settings/">REST API Reference for GetWebSearchSettings Operation</seealso>
        /// <returns>WebSearchSettingsWrapper</returns>
        WebSearchSettingsWrapper GetWebSearchSettings();

        /// <summary>
        /// Get web search settings
        /// </summary>
        /// <remarks>
        /// Retrieves the current web search integration settings for AI chat sessions,  including whether web search is enabled, the configured search engine type, and whether the API key needs to be reset.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-web-search-settings/">REST API Reference for GetWebSearchSettings Operation</seealso>
        /// <returns>ApiResponse of WebSearchSettingsWrapper</returns>
        ApiResponse<WebSearchSettingsWrapper> GetWebSearchSettingsWithHttpInfo();
        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <remarks>
        /// Configures the embedding provider used for document vectorization at the portal level.  Vectorization enables semantic search and knowledge retrieval capabilities in AI chat sessions.  Allows selecting the embedding provider type and providing the API key for the chosen provider.  Only portal administrators can modify these settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setEmbeddingConfigRequestBody">The embedding provider configuration parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-vectorization-settings/">REST API Reference for SetVectorizationSettings Operation</seealso>
        /// <returns>VectorizationSettingsWrapper</returns>
        VectorizationSettingsWrapper SetVectorizationSettings(SetEmbeddingConfigRequestBody setEmbeddingConfigRequestBody);

        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <remarks>
        /// Configures the embedding provider used for document vectorization at the portal level.  Vectorization enables semantic search and knowledge retrieval capabilities in AI chat sessions.  Allows selecting the embedding provider type and providing the API key for the chosen provider.  Only portal administrators can modify these settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setEmbeddingConfigRequestBody">The embedding provider configuration parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-vectorization-settings/">REST API Reference for SetVectorizationSettings Operation</seealso>
        /// <returns>ApiResponse of VectorizationSettingsWrapper</returns>
        ApiResponse<VectorizationSettingsWrapper> SetVectorizationSettingsWithHttpInfo(SetEmbeddingConfigRequestBody setEmbeddingConfigRequestBody);
        /// <summary>
        /// Update web search settings
        /// </summary>
        /// <remarks>
        /// Configures the web search integration for AI chat sessions at the portal level.  Allows enabling or disabling web search, selecting the search engine type, and providing the API key for the chosen engine.  Only portal administrators can modify these settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setWebSearchSettingsRequestBody">The web search configuration parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-web-search-settings/">REST API Reference for SetWebSearchSettings Operation</seealso>
        /// <returns>WebSearchSettingsWrapper</returns>
        WebSearchSettingsWrapper SetWebSearchSettings(SetWebSearchSettingsRequestBody setWebSearchSettingsRequestBody);

        /// <summary>
        /// Update web search settings
        /// </summary>
        /// <remarks>
        /// Configures the web search integration for AI chat sessions at the portal level.  Allows enabling or disabling web search, selecting the search engine type, and providing the API key for the chosen engine.  Only portal administrators can modify these settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setWebSearchSettingsRequestBody">The web search configuration parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-web-search-settings/">REST API Reference for SetWebSearchSettings Operation</seealso>
        /// <returns>ApiResponse of WebSearchSettingsWrapper</returns>
        ApiResponse<WebSearchSettingsWrapper> SetWebSearchSettingsWithHttpInfo(SetWebSearchSettingsRequestBody setWebSearchSettingsRequestBody);
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
        /// Retrieves the combined AI configuration for the current portal, including the status of web search,  vectorization, and AI readiness, along with tool names and the portal MCP server identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-settings/">REST API Reference for GetAiSettings Operation</seealso>
        /// <returns>Task of AiSettingsWrapper</returns>
        Task<AiSettingsWrapper> GetAiSettingsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get AI settings
        /// </summary>
        /// <remarks>
        /// Retrieves the combined AI configuration for the current portal, including the status of web search,  vectorization, and AI readiness, along with tool names and the portal MCP server identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-settings/">REST API Reference for GetAiSettings Operation</seealso>
        /// <returns>Task of ApiResponse (AiSettingsWrapper)</returns>
        Task<ApiResponse<AiSettingsWrapper>> GetAiSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <remarks>
        /// Retrieves the current embedding provider settings used for document vectorization,  including the configured provider type and whether the API key needs to be reset.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-vectorization-settings/">REST API Reference for GetVectorizationSettings Operation</seealso>
        /// <returns>Task of VectorizationSettingsWrapper</returns>
        Task<VectorizationSettingsWrapper> GetVectorizationSettingsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <remarks>
        /// Retrieves the current embedding provider settings used for document vectorization,  including the configured provider type and whether the API key needs to be reset.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-vectorization-settings/">REST API Reference for GetVectorizationSettings Operation</seealso>
        /// <returns>Task of ApiResponse (VectorizationSettingsWrapper)</returns>
        Task<ApiResponse<VectorizationSettingsWrapper>> GetVectorizationSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get web search settings
        /// </summary>
        /// <remarks>
        /// Retrieves the current web search integration settings for AI chat sessions,  including whether web search is enabled, the configured search engine type, and whether the API key needs to be reset.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-web-search-settings/">REST API Reference for GetWebSearchSettings Operation</seealso>
        /// <returns>Task of WebSearchSettingsWrapper</returns>
        Task<WebSearchSettingsWrapper> GetWebSearchSettingsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get web search settings
        /// </summary>
        /// <remarks>
        /// Retrieves the current web search integration settings for AI chat sessions,  including whether web search is enabled, the configured search engine type, and whether the API key needs to be reset.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-web-search-settings/">REST API Reference for GetWebSearchSettings Operation</seealso>
        /// <returns>Task of ApiResponse (WebSearchSettingsWrapper)</returns>
        Task<ApiResponse<WebSearchSettingsWrapper>> GetWebSearchSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <remarks>
        /// Configures the embedding provider used for document vectorization at the portal level.  Vectorization enables semantic search and knowledge retrieval capabilities in AI chat sessions.  Allows selecting the embedding provider type and providing the API key for the chosen provider.  Only portal administrators can modify these settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setEmbeddingConfigRequestBody">The embedding provider configuration parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-vectorization-settings/">REST API Reference for SetVectorizationSettings Operation</seealso>
        /// <returns>Task of VectorizationSettingsWrapper</returns>
        Task<VectorizationSettingsWrapper> SetVectorizationSettingsAsync(SetEmbeddingConfigRequestBody setEmbeddingConfigRequestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <remarks>
        /// Configures the embedding provider used for document vectorization at the portal level.  Vectorization enables semantic search and knowledge retrieval capabilities in AI chat sessions.  Allows selecting the embedding provider type and providing the API key for the chosen provider.  Only portal administrators can modify these settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setEmbeddingConfigRequestBody">The embedding provider configuration parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-vectorization-settings/">REST API Reference for SetVectorizationSettings Operation</seealso>
        /// <returns>Task of ApiResponse (VectorizationSettingsWrapper)</returns>
        Task<ApiResponse<VectorizationSettingsWrapper>> SetVectorizationSettingsWithHttpInfoAsync(SetEmbeddingConfigRequestBody setEmbeddingConfigRequestBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update web search settings
        /// </summary>
        /// <remarks>
        /// Configures the web search integration for AI chat sessions at the portal level.  Allows enabling or disabling web search, selecting the search engine type, and providing the API key for the chosen engine.  Only portal administrators can modify these settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setWebSearchSettingsRequestBody">The web search configuration parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-web-search-settings/">REST API Reference for SetWebSearchSettings Operation</seealso>
        /// <returns>Task of WebSearchSettingsWrapper</returns>
        Task<WebSearchSettingsWrapper> SetWebSearchSettingsAsync(SetWebSearchSettingsRequestBody setWebSearchSettingsRequestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update web search settings
        /// </summary>
        /// <remarks>
        /// Configures the web search integration for AI chat sessions at the portal level.  Allows enabling or disabling web search, selecting the search engine type, and providing the API key for the chosen engine.  Only portal administrators can modify these settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setWebSearchSettingsRequestBody">The web search configuration parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-web-search-settings/">REST API Reference for SetWebSearchSettings Operation</seealso>
        /// <returns>Task of ApiResponse (WebSearchSettingsWrapper)</returns>
        Task<ApiResponse<WebSearchSettingsWrapper>> SetWebSearchSettingsWithHttpInfoAsync(SetWebSearchSettingsRequestBody setWebSearchSettingsRequestBody, CancellationToken cancellationToken = default);
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
        /// Retrieves the combined AI configuration for the current portal, including the status of web search,  vectorization, and AI readiness, along with tool names and the portal MCP server identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-settings/">REST API Reference for GetAiSettings Operation</seealso>
        /// <returns>AiSettingsWrapper</returns>
        public AiSettingsWrapper GetAiSettings()
        {
            var localVarResponse = GetAiSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get AI settings
        /// </summary>
        /// <remarks>
        /// Retrieves the combined AI configuration for the current portal, including the status of web search,  vectorization, and AI readiness, along with tool names and the portal MCP server identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-settings/">REST API Reference for GetAiSettings Operation</seealso>
        /// <returns>ApiResponse of AiSettingsWrapper</returns>
        public ApiResponse<AiSettingsWrapper> GetAiSettingsWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<AiSettingsWrapper>("/api/2.0/ai/config", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAiSettings", localVarResponse);
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
        /// Retrieves the combined AI configuration for the current portal, including the status of web search,  vectorization, and AI readiness, along with tool names and the portal MCP server identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-settings/">REST API Reference for GetAiSettings Operation</seealso>
        /// <returns>Task of AiSettingsWrapper</returns>
        public async Task<AiSettingsWrapper> GetAiSettingsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAiSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get AI settings
        /// </summary>
        /// <remarks>
        /// Retrieves the combined AI configuration for the current portal, including the status of web search,  vectorization, and AI readiness, along with tool names and the portal MCP server identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ai-settings/">REST API Reference for GetAiSettings Operation</seealso>
        /// <returns>Task of ApiResponse (AiSettingsWrapper)</returns>
        public async Task<ApiResponse<AiSettingsWrapper>> GetAiSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<AiSettingsWrapper>("/api/2.0/ai/config", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAiSettings", localVarResponse);
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
        /// Retrieves the current embedding provider settings used for document vectorization,  including the configured provider type and whether the API key needs to be reset.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-vectorization-settings/">REST API Reference for GetVectorizationSettings Operation</seealso>
        /// <returns>VectorizationSettingsWrapper</returns>
        public VectorizationSettingsWrapper GetVectorizationSettings()
        {
            var localVarResponse = GetVectorizationSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <remarks>
        /// Retrieves the current embedding provider settings used for document vectorization,  including the configured provider type and whether the API key needs to be reset.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-vectorization-settings/">REST API Reference for GetVectorizationSettings Operation</seealso>
        /// <returns>ApiResponse of VectorizationSettingsWrapper</returns>
        public ApiResponse<VectorizationSettingsWrapper> GetVectorizationSettingsWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<VectorizationSettingsWrapper>("/api/2.0/ai/config/vectorization", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetVectorizationSettings", localVarResponse);
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
        /// Retrieves the current embedding provider settings used for document vectorization,  including the configured provider type and whether the API key needs to be reset.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-vectorization-settings/">REST API Reference for GetVectorizationSettings Operation</seealso>
        /// <returns>Task of VectorizationSettingsWrapper</returns>
        public async Task<VectorizationSettingsWrapper> GetVectorizationSettingsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetVectorizationSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <remarks>
        /// Retrieves the current embedding provider settings used for document vectorization,  including the configured provider type and whether the API key needs to be reset.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-vectorization-settings/">REST API Reference for GetVectorizationSettings Operation</seealso>
        /// <returns>Task of ApiResponse (VectorizationSettingsWrapper)</returns>
        public async Task<ApiResponse<VectorizationSettingsWrapper>> GetVectorizationSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<VectorizationSettingsWrapper>("/api/2.0/ai/config/vectorization", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetVectorizationSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get web search settings
        /// </summary>
        /// <remarks>
        /// Retrieves the current web search integration settings for AI chat sessions,  including whether web search is enabled, the configured search engine type, and whether the API key needs to be reset.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-web-search-settings/">REST API Reference for GetWebSearchSettings Operation</seealso>
        /// <returns>WebSearchSettingsWrapper</returns>
        public WebSearchSettingsWrapper GetWebSearchSettings()
        {
            var localVarResponse = GetWebSearchSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get web search settings
        /// </summary>
        /// <remarks>
        /// Retrieves the current web search integration settings for AI chat sessions,  including whether web search is enabled, the configured search engine type, and whether the API key needs to be reset.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-web-search-settings/">REST API Reference for GetWebSearchSettings Operation</seealso>
        /// <returns>ApiResponse of WebSearchSettingsWrapper</returns>
        public ApiResponse<WebSearchSettingsWrapper> GetWebSearchSettingsWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<WebSearchSettingsWrapper>("/api/2.0/ai/config/web-search", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetWebSearchSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get web search settings
        /// </summary>
        /// <remarks>
        /// Retrieves the current web search integration settings for AI chat sessions,  including whether web search is enabled, the configured search engine type, and whether the API key needs to be reset.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-web-search-settings/">REST API Reference for GetWebSearchSettings Operation</seealso>
        /// <returns>Task of WebSearchSettingsWrapper</returns>
        public async Task<WebSearchSettingsWrapper> GetWebSearchSettingsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetWebSearchSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get web search settings
        /// </summary>
        /// <remarks>
        /// Retrieves the current web search integration settings for AI chat sessions,  including whether web search is enabled, the configured search engine type, and whether the API key needs to be reset.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-web-search-settings/">REST API Reference for GetWebSearchSettings Operation</seealso>
        /// <returns>Task of ApiResponse (WebSearchSettingsWrapper)</returns>
        public async Task<ApiResponse<WebSearchSettingsWrapper>> GetWebSearchSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<WebSearchSettingsWrapper>("/api/2.0/ai/config/web-search", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetWebSearchSettings", localVarResponse);
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
        /// Configures the embedding provider used for document vectorization at the portal level.  Vectorization enables semantic search and knowledge retrieval capabilities in AI chat sessions.  Allows selecting the embedding provider type and providing the API key for the chosen provider.  Only portal administrators can modify these settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setEmbeddingConfigRequestBody">The embedding provider configuration parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-vectorization-settings/">REST API Reference for SetVectorizationSettings Operation</seealso>
        /// <returns>VectorizationSettingsWrapper</returns>
        public VectorizationSettingsWrapper SetVectorizationSettings(SetEmbeddingConfigRequestBody setEmbeddingConfigRequestBody)
        {
            var localVarResponse = SetVectorizationSettingsWithHttpInfo(setEmbeddingConfigRequestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <remarks>
        /// Configures the embedding provider used for document vectorization at the portal level.  Vectorization enables semantic search and knowledge retrieval capabilities in AI chat sessions.  Allows selecting the embedding provider type and providing the API key for the chosen provider.  Only portal administrators can modify these settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setEmbeddingConfigRequestBody">The embedding provider configuration parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-vectorization-settings/">REST API Reference for SetVectorizationSettings Operation</seealso>
        /// <returns>ApiResponse of VectorizationSettingsWrapper</returns>
        public ApiResponse<VectorizationSettingsWrapper> SetVectorizationSettingsWithHttpInfo(SetEmbeddingConfigRequestBody setEmbeddingConfigRequestBody)
        {
            // verify the required parameter 'setEmbeddingConfigRequestBody' is set
            if (setEmbeddingConfigRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'setEmbeddingConfigRequestBody' when calling SettingsApi->SetVectorizationSettings");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (setEmbeddingConfigRequestBody != null) localVarRequestOptions.Data = setEmbeddingConfigRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<VectorizationSettingsWrapper>("/api/2.0/ai/config/vectorization", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetVectorizationSettings", localVarResponse);
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
        /// Configures the embedding provider used for document vectorization at the portal level.  Vectorization enables semantic search and knowledge retrieval capabilities in AI chat sessions.  Allows selecting the embedding provider type and providing the API key for the chosen provider.  Only portal administrators can modify these settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setEmbeddingConfigRequestBody">The embedding provider configuration parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-vectorization-settings/">REST API Reference for SetVectorizationSettings Operation</seealso>
        /// <returns>Task of VectorizationSettingsWrapper</returns>
        public async Task<VectorizationSettingsWrapper> SetVectorizationSettingsAsync(SetEmbeddingConfigRequestBody setEmbeddingConfigRequestBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetVectorizationSettingsWithHttpInfoAsync(setEmbeddingConfigRequestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <remarks>
        /// Configures the embedding provider used for document vectorization at the portal level.  Vectorization enables semantic search and knowledge retrieval capabilities in AI chat sessions.  Allows selecting the embedding provider type and providing the API key for the chosen provider.  Only portal administrators can modify these settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setEmbeddingConfigRequestBody">The embedding provider configuration parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-vectorization-settings/">REST API Reference for SetVectorizationSettings Operation</seealso>
        /// <returns>Task of ApiResponse (VectorizationSettingsWrapper)</returns>
        public async Task<ApiResponse<VectorizationSettingsWrapper>> SetVectorizationSettingsWithHttpInfoAsync(SetEmbeddingConfigRequestBody setEmbeddingConfigRequestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'setEmbeddingConfigRequestBody' is set
            if (setEmbeddingConfigRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'setEmbeddingConfigRequestBody' when calling SettingsApi->SetVectorizationSettings");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (setEmbeddingConfigRequestBody != null) localVarRequestOptions.Data = setEmbeddingConfigRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<VectorizationSettingsWrapper>("/api/2.0/ai/config/vectorization", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetVectorizationSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update web search settings
        /// </summary>
        /// <remarks>
        /// Configures the web search integration for AI chat sessions at the portal level.  Allows enabling or disabling web search, selecting the search engine type, and providing the API key for the chosen engine.  Only portal administrators can modify these settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setWebSearchSettingsRequestBody">The web search configuration parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-web-search-settings/">REST API Reference for SetWebSearchSettings Operation</seealso>
        /// <returns>WebSearchSettingsWrapper</returns>
        public WebSearchSettingsWrapper SetWebSearchSettings(SetWebSearchSettingsRequestBody setWebSearchSettingsRequestBody)
        {
            var localVarResponse = SetWebSearchSettingsWithHttpInfo(setWebSearchSettingsRequestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update web search settings
        /// </summary>
        /// <remarks>
        /// Configures the web search integration for AI chat sessions at the portal level.  Allows enabling or disabling web search, selecting the search engine type, and providing the API key for the chosen engine.  Only portal administrators can modify these settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setWebSearchSettingsRequestBody">The web search configuration parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-web-search-settings/">REST API Reference for SetWebSearchSettings Operation</seealso>
        /// <returns>ApiResponse of WebSearchSettingsWrapper</returns>
        public ApiResponse<WebSearchSettingsWrapper> SetWebSearchSettingsWithHttpInfo(SetWebSearchSettingsRequestBody setWebSearchSettingsRequestBody)
        {
            // verify the required parameter 'setWebSearchSettingsRequestBody' is set
            if (setWebSearchSettingsRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'setWebSearchSettingsRequestBody' when calling SettingsApi->SetWebSearchSettings");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (setWebSearchSettingsRequestBody != null) localVarRequestOptions.Data = setWebSearchSettingsRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<WebSearchSettingsWrapper>("/api/2.0/ai/config/web-search", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetWebSearchSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update web search settings
        /// </summary>
        /// <remarks>
        /// Configures the web search integration for AI chat sessions at the portal level.  Allows enabling or disabling web search, selecting the search engine type, and providing the API key for the chosen engine.  Only portal administrators can modify these settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setWebSearchSettingsRequestBody">The web search configuration parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-web-search-settings/">REST API Reference for SetWebSearchSettings Operation</seealso>
        /// <returns>Task of WebSearchSettingsWrapper</returns>
        public async Task<WebSearchSettingsWrapper> SetWebSearchSettingsAsync(SetWebSearchSettingsRequestBody setWebSearchSettingsRequestBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetWebSearchSettingsWithHttpInfoAsync(setWebSearchSettingsRequestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update web search settings
        /// </summary>
        /// <remarks>
        /// Configures the web search integration for AI chat sessions at the portal level.  Allows enabling or disabling web search, selecting the search engine type, and providing the API key for the chosen engine.  Only portal administrators can modify these settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setWebSearchSettingsRequestBody">The web search configuration parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-web-search-settings/">REST API Reference for SetWebSearchSettings Operation</seealso>
        /// <returns>Task of ApiResponse (WebSearchSettingsWrapper)</returns>
        public async Task<ApiResponse<WebSearchSettingsWrapper>> SetWebSearchSettingsWithHttpInfoAsync(SetWebSearchSettingsRequestBody setWebSearchSettingsRequestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'setWebSearchSettingsRequestBody' is set
            if (setWebSearchSettingsRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'setWebSearchSettingsRequestBody' when calling SettingsApi->SetWebSearchSettings");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (setWebSearchSettingsRequestBody != null) localVarRequestOptions.Data = setWebSearchSettingsRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<WebSearchSettingsWrapper>("/api/2.0/ai/config/web-search", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetWebSearchSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
