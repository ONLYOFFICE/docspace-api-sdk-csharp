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
    public interface IWebSearchApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Clear
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-clear/">REST API Reference for NewAiWebSearchClear Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        NewAiSuccessResponse NewAiWebSearchClear(string body);

        /// <summary>
        /// Clear
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-clear/">REST API Reference for NewAiWebSearchClear Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        ApiResponse<NewAiSuccessResponse> NewAiWebSearchClearWithHttpInfo(string body);
        /// <summary>
        /// Configure
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-configure/">REST API Reference for NewAiWebSearchConfigure Operation</seealso>
        /// <returns>NewAiWebSearchMutationResult</returns>
        NewAiWebSearchMutationResult NewAiWebSearchConfigure(NewAiWebSearchConfigureRequest newAiWebSearchConfigureRequest);

        /// <summary>
        /// Configure
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-configure/">REST API Reference for NewAiWebSearchConfigure Operation</seealso>
        /// <returns>ApiResponse of NewAiWebSearchMutationResult</returns>
        ApiResponse<NewAiWebSearchMutationResult> NewAiWebSearchConfigureWithHttpInfo(NewAiWebSearchConfigureRequest newAiWebSearchConfigureRequest);
        /// <summary>
        /// Get active config
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-get-active-config/">REST API Reference for NewAiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>NewAiWebSearchConfig</returns>
        NewAiWebSearchConfig NewAiWebSearchGetActiveConfig(string entityId);

        /// <summary>
        /// Get active config
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-get-active-config/">REST API Reference for NewAiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>ApiResponse of NewAiWebSearchConfig</returns>
        ApiResponse<NewAiWebSearchConfig> NewAiWebSearchGetActiveConfigWithHttpInfo(string entityId);
        /// <summary>
        /// Is configured
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-is-configured/">REST API Reference for NewAiWebSearchIsConfigured Operation</seealso>
        /// <returns>bool</returns>
        bool NewAiWebSearchIsConfigured(string entityId);

        /// <summary>
        /// Is configured
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-is-configured/">REST API Reference for NewAiWebSearchIsConfigured Operation</seealso>
        /// <returns>ApiResponse of bool</returns>
        ApiResponse<bool> NewAiWebSearchIsConfiguredWithHttpInfo(string entityId);
        /// <summary>
        /// Set active config
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-set-active-config/">REST API Reference for NewAiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        NewAiSuccessResponse NewAiWebSearchSetActiveConfig(NewAiWebSearchConfigureRequest newAiWebSearchConfigureRequest);

        /// <summary>
        /// Set active config
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-set-active-config/">REST API Reference for NewAiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        ApiResponse<NewAiSuccessResponse> NewAiWebSearchSetActiveConfigWithHttpInfo(NewAiWebSearchConfigureRequest newAiWebSearchConfigureRequest);
        /// <summary>
        /// Test connection
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-test-connection/">REST API Reference for NewAiWebSearchTestConnection Operation</seealso>
        /// <returns>NewAiProfilesTestConnection200Response</returns>
        NewAiProfilesTestConnection200Response NewAiWebSearchTestConnection(NewAiWebSearchConfig newAiWebSearchConfig);

        /// <summary>
        /// Test connection
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-test-connection/">REST API Reference for NewAiWebSearchTestConnection Operation</seealso>
        /// <returns>ApiResponse of NewAiProfilesTestConnection200Response</returns>
        ApiResponse<NewAiProfilesTestConnection200Response> NewAiWebSearchTestConnectionWithHttpInfo(NewAiWebSearchConfig newAiWebSearchConfig);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWebSearchApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Clear
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-clear/">REST API Reference for NewAiWebSearchClear Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        Task<NewAiSuccessResponse> NewAiWebSearchClearAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Clear
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-clear/">REST API Reference for NewAiWebSearchClear Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        Task<ApiResponse<NewAiSuccessResponse>> NewAiWebSearchClearWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Configure
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-configure/">REST API Reference for NewAiWebSearchConfigure Operation</seealso>
        /// <returns>Task of NewAiWebSearchMutationResult</returns>
        Task<NewAiWebSearchMutationResult> NewAiWebSearchConfigureAsync(NewAiWebSearchConfigureRequest newAiWebSearchConfigureRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Configure
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-configure/">REST API Reference for NewAiWebSearchConfigure Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiWebSearchMutationResult)</returns>
        Task<ApiResponse<NewAiWebSearchMutationResult>> NewAiWebSearchConfigureWithHttpInfoAsync(NewAiWebSearchConfigureRequest newAiWebSearchConfigureRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get active config
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-get-active-config/">REST API Reference for NewAiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>Task of NewAiWebSearchConfig</returns>
        Task<NewAiWebSearchConfig> NewAiWebSearchGetActiveConfigAsync(string entityId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get active config
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-get-active-config/">REST API Reference for NewAiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiWebSearchConfig)</returns>
        Task<ApiResponse<NewAiWebSearchConfig>> NewAiWebSearchGetActiveConfigWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Is configured
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-is-configured/">REST API Reference for NewAiWebSearchIsConfigured Operation</seealso>
        /// <returns>Task of bool</returns>
        Task<bool> NewAiWebSearchIsConfiguredAsync(string entityId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Is configured
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-is-configured/">REST API Reference for NewAiWebSearchIsConfigured Operation</seealso>
        /// <returns>Task of ApiResponse (bool)</returns>
        Task<ApiResponse<bool>> NewAiWebSearchIsConfiguredWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set active config
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-set-active-config/">REST API Reference for NewAiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        Task<NewAiSuccessResponse> NewAiWebSearchSetActiveConfigAsync(NewAiWebSearchConfigureRequest newAiWebSearchConfigureRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set active config
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-set-active-config/">REST API Reference for NewAiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        Task<ApiResponse<NewAiSuccessResponse>> NewAiWebSearchSetActiveConfigWithHttpInfoAsync(NewAiWebSearchConfigureRequest newAiWebSearchConfigureRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Test connection
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-test-connection/">REST API Reference for NewAiWebSearchTestConnection Operation</seealso>
        /// <returns>Task of NewAiProfilesTestConnection200Response</returns>
        Task<NewAiProfilesTestConnection200Response> NewAiWebSearchTestConnectionAsync(NewAiWebSearchConfig newAiWebSearchConfig, CancellationToken cancellationToken = default);

        /// <summary>
        /// Test connection
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-test-connection/">REST API Reference for NewAiWebSearchTestConnection Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiProfilesTestConnection200Response)</returns>
        Task<ApiResponse<NewAiProfilesTestConnection200Response>> NewAiWebSearchTestConnectionWithHttpInfoAsync(NewAiWebSearchConfig newAiWebSearchConfig, CancellationToken cancellationToken = default);
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
        /// Clear
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-clear/">REST API Reference for NewAiWebSearchClear Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        public NewAiSuccessResponse NewAiWebSearchClear(string body)
        {
            var localVarResponse = NewAiWebSearchClearWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Clear
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-clear/">REST API Reference for NewAiWebSearchClear Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        public ApiResponse<NewAiSuccessResponse> NewAiWebSearchClearWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WebSearchApi->NewAiWebSearchClear");

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
            var localVarResponse = Client.Delete<NewAiSuccessResponse>("/api/2.0/ai/web-search/clear", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiWebSearchClear", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Clear
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-clear/">REST API Reference for NewAiWebSearchClear Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        public async Task<NewAiSuccessResponse> NewAiWebSearchClearAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiWebSearchClearWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Clear
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-clear/">REST API Reference for NewAiWebSearchClear Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        public async Task<ApiResponse<NewAiSuccessResponse>> NewAiWebSearchClearWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WebSearchApi->NewAiWebSearchClear");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<NewAiSuccessResponse>("/api/2.0/ai/web-search/clear", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiWebSearchClear", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Configure
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-configure/">REST API Reference for NewAiWebSearchConfigure Operation</seealso>
        /// <returns>NewAiWebSearchMutationResult</returns>
        public NewAiWebSearchMutationResult NewAiWebSearchConfigure(NewAiWebSearchConfigureRequest newAiWebSearchConfigureRequest)
        {
            var localVarResponse = NewAiWebSearchConfigureWithHttpInfo(newAiWebSearchConfigureRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Configure
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-configure/">REST API Reference for NewAiWebSearchConfigure Operation</seealso>
        /// <returns>ApiResponse of NewAiWebSearchMutationResult</returns>
        public ApiResponse<NewAiWebSearchMutationResult> NewAiWebSearchConfigureWithHttpInfo(NewAiWebSearchConfigureRequest newAiWebSearchConfigureRequest)
        {
            // verify the required parameter 'newAiWebSearchConfigureRequest' is set
            if (newAiWebSearchConfigureRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiWebSearchConfigureRequest' when calling WebSearchApi->NewAiWebSearchConfigure");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiWebSearchConfigureRequest != null) localVarRequestOptions.Data = newAiWebSearchConfigureRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<NewAiWebSearchMutationResult>("/api/2.0/ai/web-search/configure", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiWebSearchConfigure", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Configure
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-configure/">REST API Reference for NewAiWebSearchConfigure Operation</seealso>
        /// <returns>Task of NewAiWebSearchMutationResult</returns>
        public async Task<NewAiWebSearchMutationResult> NewAiWebSearchConfigureAsync(NewAiWebSearchConfigureRequest newAiWebSearchConfigureRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiWebSearchConfigureWithHttpInfoAsync(newAiWebSearchConfigureRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Configure
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-configure/">REST API Reference for NewAiWebSearchConfigure Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiWebSearchMutationResult)</returns>
        public async Task<ApiResponse<NewAiWebSearchMutationResult>> NewAiWebSearchConfigureWithHttpInfoAsync(NewAiWebSearchConfigureRequest newAiWebSearchConfigureRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiWebSearchConfigureRequest' is set
            if (newAiWebSearchConfigureRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiWebSearchConfigureRequest' when calling WebSearchApi->NewAiWebSearchConfigure");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiWebSearchConfigureRequest != null) localVarRequestOptions.Data = newAiWebSearchConfigureRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<NewAiWebSearchMutationResult>("/api/2.0/ai/web-search/configure", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiWebSearchConfigure", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-get-active-config/">REST API Reference for NewAiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>NewAiWebSearchConfig</returns>
        public NewAiWebSearchConfig NewAiWebSearchGetActiveConfig(string entityId)
        {
            var localVarResponse = NewAiWebSearchGetActiveConfigWithHttpInfo(entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get active config
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-get-active-config/">REST API Reference for NewAiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>ApiResponse of NewAiWebSearchConfig</returns>
        public ApiResponse<NewAiWebSearchConfig> NewAiWebSearchGetActiveConfigWithHttpInfo(string entityId)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling WebSearchApi->NewAiWebSearchGetActiveConfig");

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
            var localVarResponse = Client.Get<NewAiWebSearchConfig>("/api/2.0/ai/web-search/get-active-config", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiWebSearchGetActiveConfig", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-get-active-config/">REST API Reference for NewAiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>Task of NewAiWebSearchConfig</returns>
        public async Task<NewAiWebSearchConfig> NewAiWebSearchGetActiveConfigAsync(string entityId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiWebSearchGetActiveConfigWithHttpInfoAsync(entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get active config
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-get-active-config/">REST API Reference for NewAiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiWebSearchConfig)</returns>
        public async Task<ApiResponse<NewAiWebSearchConfig>> NewAiWebSearchGetActiveConfigWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling WebSearchApi->NewAiWebSearchGetActiveConfig");

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

            var localVarResponse = await AsynchronousClient.GetAsync<NewAiWebSearchConfig>("/api/2.0/ai/web-search/get-active-config", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiWebSearchGetActiveConfig", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-is-configured/">REST API Reference for NewAiWebSearchIsConfigured Operation</seealso>
        /// <returns>bool</returns>
        public bool NewAiWebSearchIsConfigured(string entityId)
        {
            var localVarResponse = NewAiWebSearchIsConfiguredWithHttpInfo(entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Is configured
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-is-configured/">REST API Reference for NewAiWebSearchIsConfigured Operation</seealso>
        /// <returns>ApiResponse of bool</returns>
        public ApiResponse<bool> NewAiWebSearchIsConfiguredWithHttpInfo(string entityId)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling WebSearchApi->NewAiWebSearchIsConfigured");

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
            var localVarResponse = Client.Get<bool>("/api/2.0/ai/web-search/is-configured", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiWebSearchIsConfigured", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-is-configured/">REST API Reference for NewAiWebSearchIsConfigured Operation</seealso>
        /// <returns>Task of bool</returns>
        public async Task<bool> NewAiWebSearchIsConfiguredAsync(string entityId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiWebSearchIsConfiguredWithHttpInfoAsync(entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Is configured
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-is-configured/">REST API Reference for NewAiWebSearchIsConfigured Operation</seealso>
        /// <returns>Task of ApiResponse (bool)</returns>
        public async Task<ApiResponse<bool>> NewAiWebSearchIsConfiguredWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling WebSearchApi->NewAiWebSearchIsConfigured");

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

            var localVarResponse = await AsynchronousClient.GetAsync<bool>("/api/2.0/ai/web-search/is-configured", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiWebSearchIsConfigured", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-set-active-config/">REST API Reference for NewAiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        public NewAiSuccessResponse NewAiWebSearchSetActiveConfig(NewAiWebSearchConfigureRequest newAiWebSearchConfigureRequest)
        {
            var localVarResponse = NewAiWebSearchSetActiveConfigWithHttpInfo(newAiWebSearchConfigureRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set active config
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-set-active-config/">REST API Reference for NewAiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        public ApiResponse<NewAiSuccessResponse> NewAiWebSearchSetActiveConfigWithHttpInfo(NewAiWebSearchConfigureRequest newAiWebSearchConfigureRequest)
        {
            // verify the required parameter 'newAiWebSearchConfigureRequest' is set
            if (newAiWebSearchConfigureRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiWebSearchConfigureRequest' when calling WebSearchApi->NewAiWebSearchSetActiveConfig");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiWebSearchConfigureRequest != null) localVarRequestOptions.Data = newAiWebSearchConfigureRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<NewAiSuccessResponse>("/api/2.0/ai/web-search/set-active-config", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiWebSearchSetActiveConfig", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-set-active-config/">REST API Reference for NewAiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        public async Task<NewAiSuccessResponse> NewAiWebSearchSetActiveConfigAsync(NewAiWebSearchConfigureRequest newAiWebSearchConfigureRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiWebSearchSetActiveConfigWithHttpInfoAsync(newAiWebSearchConfigureRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set active config
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-set-active-config/">REST API Reference for NewAiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        public async Task<ApiResponse<NewAiSuccessResponse>> NewAiWebSearchSetActiveConfigWithHttpInfoAsync(NewAiWebSearchConfigureRequest newAiWebSearchConfigureRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiWebSearchConfigureRequest' is set
            if (newAiWebSearchConfigureRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiWebSearchConfigureRequest' when calling WebSearchApi->NewAiWebSearchSetActiveConfig");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiWebSearchConfigureRequest != null) localVarRequestOptions.Data = newAiWebSearchConfigureRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<NewAiSuccessResponse>("/api/2.0/ai/web-search/set-active-config", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiWebSearchSetActiveConfig", localVarResponse);
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
        /// <param name="newAiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-test-connection/">REST API Reference for NewAiWebSearchTestConnection Operation</seealso>
        /// <returns>NewAiProfilesTestConnection200Response</returns>
        public NewAiProfilesTestConnection200Response NewAiWebSearchTestConnection(NewAiWebSearchConfig newAiWebSearchConfig)
        {
            var localVarResponse = NewAiWebSearchTestConnectionWithHttpInfo(newAiWebSearchConfig);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Test connection
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-test-connection/">REST API Reference for NewAiWebSearchTestConnection Operation</seealso>
        /// <returns>ApiResponse of NewAiProfilesTestConnection200Response</returns>
        public ApiResponse<NewAiProfilesTestConnection200Response> NewAiWebSearchTestConnectionWithHttpInfo(NewAiWebSearchConfig newAiWebSearchConfig)
        {
            // verify the required parameter 'newAiWebSearchConfig' is set
            if (newAiWebSearchConfig == null)
                throw new ApiException(400, "Missing required parameter 'newAiWebSearchConfig' when calling WebSearchApi->NewAiWebSearchTestConnection");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiWebSearchConfig != null) localVarRequestOptions.Data = newAiWebSearchConfig;


            // make the HTTP request
            var localVarResponse = Client.Post<NewAiProfilesTestConnection200Response>("/api/2.0/ai/web-search/test-connection", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiWebSearchTestConnection", localVarResponse);
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
        /// <param name="newAiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-test-connection/">REST API Reference for NewAiWebSearchTestConnection Operation</seealso>
        /// <returns>Task of NewAiProfilesTestConnection200Response</returns>
        public async Task<NewAiProfilesTestConnection200Response> NewAiWebSearchTestConnectionAsync(NewAiWebSearchConfig newAiWebSearchConfig, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiWebSearchTestConnectionWithHttpInfoAsync(newAiWebSearchConfig, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Test connection
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-web-search-test-connection/">REST API Reference for NewAiWebSearchTestConnection Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiProfilesTestConnection200Response)</returns>
        public async Task<ApiResponse<NewAiProfilesTestConnection200Response>> NewAiWebSearchTestConnectionWithHttpInfoAsync(NewAiWebSearchConfig newAiWebSearchConfig, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiWebSearchConfig' is set
            if (newAiWebSearchConfig == null)
                throw new ApiException(400, "Missing required parameter 'newAiWebSearchConfig' when calling WebSearchApi->NewAiWebSearchTestConnection");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiWebSearchConfig != null) localVarRequestOptions.Data = newAiWebSearchConfig;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<NewAiProfilesTestConnection200Response>("/api/2.0/ai/web-search/test-connection", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiWebSearchTestConnection", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
