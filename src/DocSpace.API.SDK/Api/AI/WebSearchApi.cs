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
    public interface IWebSearchApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Clear
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-clear/">REST API Reference for AiWebSearchClear Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiWebSearchClear(string body);

        /// <summary>
        /// Clear
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-clear/">REST API Reference for AiWebSearchClear Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiWebSearchClearWithHttpInfo(string body);
        /// <summary>
        /// Configure
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-configure/">REST API Reference for AiWebSearchConfigure Operation</seealso>
        /// <returns>AiWebSearchMutationResult</returns>
        AiWebSearchMutationResult AiWebSearchConfigure(AiWebSearchConfigureRequest aiWebSearchConfigureRequest);

        /// <summary>
        /// Configure
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-configure/">REST API Reference for AiWebSearchConfigure Operation</seealso>
        /// <returns>ApiResponse of AiWebSearchMutationResult</returns>
        ApiResponse<AiWebSearchMutationResult> AiWebSearchConfigureWithHttpInfo(AiWebSearchConfigureRequest aiWebSearchConfigureRequest);
        /// <summary>
        /// Get active config
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-get-active-config/">REST API Reference for AiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>AiWebSearchConfig</returns>
        AiWebSearchConfig AiWebSearchGetActiveConfig(string entityId);

        /// <summary>
        /// Get active config
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-get-active-config/">REST API Reference for AiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>ApiResponse of AiWebSearchConfig</returns>
        ApiResponse<AiWebSearchConfig> AiWebSearchGetActiveConfigWithHttpInfo(string entityId);
        /// <summary>
        /// Is configured
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-is-configured/">REST API Reference for AiWebSearchIsConfigured Operation</seealso>
        /// <returns>bool</returns>
        bool AiWebSearchIsConfigured(string entityId);

        /// <summary>
        /// Is configured
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-is-configured/">REST API Reference for AiWebSearchIsConfigured Operation</seealso>
        /// <returns>ApiResponse of bool</returns>
        ApiResponse<bool> AiWebSearchIsConfiguredWithHttpInfo(string entityId);
        /// <summary>
        /// Set active config
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-set-active-config/">REST API Reference for AiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiWebSearchSetActiveConfig(AiWebSearchConfigureRequest aiWebSearchConfigureRequest);

        /// <summary>
        /// Set active config
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-set-active-config/">REST API Reference for AiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiWebSearchSetActiveConfigWithHttpInfo(AiWebSearchConfigureRequest aiWebSearchConfigureRequest);
        /// <summary>
        /// Test connection
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-test-connection/">REST API Reference for AiWebSearchTestConnection Operation</seealso>
        /// <returns>AiProfilesTestConnection200Response</returns>
        AiProfilesTestConnection200Response AiWebSearchTestConnection(AiWebSearchConfig aiWebSearchConfig);

        /// <summary>
        /// Test connection
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-test-connection/">REST API Reference for AiWebSearchTestConnection Operation</seealso>
        /// <returns>ApiResponse of AiProfilesTestConnection200Response</returns>
        ApiResponse<AiProfilesTestConnection200Response> AiWebSearchTestConnectionWithHttpInfo(AiWebSearchConfig aiWebSearchConfig);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-clear/">REST API Reference for AiWebSearchClear Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiWebSearchClearAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Clear
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-clear/">REST API Reference for AiWebSearchClear Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiWebSearchClearWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Configure
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-configure/">REST API Reference for AiWebSearchConfigure Operation</seealso>
        /// <returns>Task of AiWebSearchMutationResult</returns>
        Task<AiWebSearchMutationResult> AiWebSearchConfigureAsync(AiWebSearchConfigureRequest aiWebSearchConfigureRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Configure
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-configure/">REST API Reference for AiWebSearchConfigure Operation</seealso>
        /// <returns>Task of ApiResponse (AiWebSearchMutationResult)</returns>
        Task<ApiResponse<AiWebSearchMutationResult>> AiWebSearchConfigureWithHttpInfoAsync(AiWebSearchConfigureRequest aiWebSearchConfigureRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get active config
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-get-active-config/">REST API Reference for AiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>Task of AiWebSearchConfig</returns>
        Task<AiWebSearchConfig> AiWebSearchGetActiveConfigAsync(string entityId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get active config
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-get-active-config/">REST API Reference for AiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>Task of ApiResponse (AiWebSearchConfig)</returns>
        Task<ApiResponse<AiWebSearchConfig>> AiWebSearchGetActiveConfigWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Is configured
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-is-configured/">REST API Reference for AiWebSearchIsConfigured Operation</seealso>
        /// <returns>Task of bool</returns>
        Task<bool> AiWebSearchIsConfiguredAsync(string entityId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Is configured
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-is-configured/">REST API Reference for AiWebSearchIsConfigured Operation</seealso>
        /// <returns>Task of ApiResponse (bool)</returns>
        Task<ApiResponse<bool>> AiWebSearchIsConfiguredWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set active config
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-set-active-config/">REST API Reference for AiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiWebSearchSetActiveConfigAsync(AiWebSearchConfigureRequest aiWebSearchConfigureRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set active config
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-set-active-config/">REST API Reference for AiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiWebSearchSetActiveConfigWithHttpInfoAsync(AiWebSearchConfigureRequest aiWebSearchConfigureRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Test connection
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-test-connection/">REST API Reference for AiWebSearchTestConnection Operation</seealso>
        /// <returns>Task of AiProfilesTestConnection200Response</returns>
        Task<AiProfilesTestConnection200Response> AiWebSearchTestConnectionAsync(AiWebSearchConfig aiWebSearchConfig, CancellationToken cancellationToken = default);

        /// <summary>
        /// Test connection
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-test-connection/">REST API Reference for AiWebSearchTestConnection Operation</seealso>
        /// <returns>Task of ApiResponse (AiProfilesTestConnection200Response)</returns>
        Task<ApiResponse<AiProfilesTestConnection200Response>> AiWebSearchTestConnectionWithHttpInfoAsync(AiWebSearchConfig aiWebSearchConfig, CancellationToken cancellationToken = default);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-clear/">REST API Reference for AiWebSearchClear Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiWebSearchClear(string body)
        {
            var localVarResponse = AiWebSearchClearWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Clear
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-clear/">REST API Reference for AiWebSearchClear Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiWebSearchClearWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WebSearchApi->AiWebSearchClear");

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
            var localVarResponse = Client.Delete<AiSuccessResponse>("/api/2.0/ai/web-search/clear", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchClear", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-clear/">REST API Reference for AiWebSearchClear Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiWebSearchClearAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiWebSearchClearWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Clear
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-clear/">REST API Reference for AiWebSearchClear Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiWebSearchClearWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WebSearchApi->AiWebSearchClear");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<AiSuccessResponse>("/api/2.0/ai/web-search/clear", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchClear", localVarResponse);
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
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-configure/">REST API Reference for AiWebSearchConfigure Operation</seealso>
        /// <returns>AiWebSearchMutationResult</returns>
        public AiWebSearchMutationResult AiWebSearchConfigure(AiWebSearchConfigureRequest aiWebSearchConfigureRequest)
        {
            var localVarResponse = AiWebSearchConfigureWithHttpInfo(aiWebSearchConfigureRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Configure
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-configure/">REST API Reference for AiWebSearchConfigure Operation</seealso>
        /// <returns>ApiResponse of AiWebSearchMutationResult</returns>
        public ApiResponse<AiWebSearchMutationResult> AiWebSearchConfigureWithHttpInfo(AiWebSearchConfigureRequest aiWebSearchConfigureRequest)
        {
            // verify the required parameter 'aiWebSearchConfigureRequest' is set
            if (aiWebSearchConfigureRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiWebSearchConfigureRequest' when calling WebSearchApi->AiWebSearchConfigure");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiWebSearchConfigureRequest != null) localVarRequestOptions.Data = aiWebSearchConfigureRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<AiWebSearchMutationResult>("/api/2.0/ai/web-search/configure", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchConfigure", localVarResponse);
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
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-configure/">REST API Reference for AiWebSearchConfigure Operation</seealso>
        /// <returns>Task of AiWebSearchMutationResult</returns>
        public async Task<AiWebSearchMutationResult> AiWebSearchConfigureAsync(AiWebSearchConfigureRequest aiWebSearchConfigureRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiWebSearchConfigureWithHttpInfoAsync(aiWebSearchConfigureRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Configure
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-configure/">REST API Reference for AiWebSearchConfigure Operation</seealso>
        /// <returns>Task of ApiResponse (AiWebSearchMutationResult)</returns>
        public async Task<ApiResponse<AiWebSearchMutationResult>> AiWebSearchConfigureWithHttpInfoAsync(AiWebSearchConfigureRequest aiWebSearchConfigureRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiWebSearchConfigureRequest' is set
            if (aiWebSearchConfigureRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiWebSearchConfigureRequest' when calling WebSearchApi->AiWebSearchConfigure");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiWebSearchConfigureRequest != null) localVarRequestOptions.Data = aiWebSearchConfigureRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<AiWebSearchMutationResult>("/api/2.0/ai/web-search/configure", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchConfigure", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-get-active-config/">REST API Reference for AiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>AiWebSearchConfig</returns>
        public AiWebSearchConfig AiWebSearchGetActiveConfig(string entityId)
        {
            var localVarResponse = AiWebSearchGetActiveConfigWithHttpInfo(entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get active config
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-get-active-config/">REST API Reference for AiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>ApiResponse of AiWebSearchConfig</returns>
        public ApiResponse<AiWebSearchConfig> AiWebSearchGetActiveConfigWithHttpInfo(string entityId)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling WebSearchApi->AiWebSearchGetActiveConfig");

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
            var localVarResponse = Client.Get<AiWebSearchConfig>("/api/2.0/ai/web-search/get-active-config", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchGetActiveConfig", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-get-active-config/">REST API Reference for AiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>Task of AiWebSearchConfig</returns>
        public async Task<AiWebSearchConfig> AiWebSearchGetActiveConfigAsync(string entityId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiWebSearchGetActiveConfigWithHttpInfoAsync(entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get active config
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-get-active-config/">REST API Reference for AiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>Task of ApiResponse (AiWebSearchConfig)</returns>
        public async Task<ApiResponse<AiWebSearchConfig>> AiWebSearchGetActiveConfigWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling WebSearchApi->AiWebSearchGetActiveConfig");

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

            var localVarResponse = await AsynchronousClient.GetAsync<AiWebSearchConfig>("/api/2.0/ai/web-search/get-active-config", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchGetActiveConfig", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-is-configured/">REST API Reference for AiWebSearchIsConfigured Operation</seealso>
        /// <returns>bool</returns>
        public bool AiWebSearchIsConfigured(string entityId)
        {
            var localVarResponse = AiWebSearchIsConfiguredWithHttpInfo(entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Is configured
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-is-configured/">REST API Reference for AiWebSearchIsConfigured Operation</seealso>
        /// <returns>ApiResponse of bool</returns>
        public ApiResponse<bool> AiWebSearchIsConfiguredWithHttpInfo(string entityId)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling WebSearchApi->AiWebSearchIsConfigured");

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
                var exception = ExceptionFactory("AiWebSearchIsConfigured", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-is-configured/">REST API Reference for AiWebSearchIsConfigured Operation</seealso>
        /// <returns>Task of bool</returns>
        public async Task<bool> AiWebSearchIsConfiguredAsync(string entityId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiWebSearchIsConfiguredWithHttpInfoAsync(entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Is configured
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-is-configured/">REST API Reference for AiWebSearchIsConfigured Operation</seealso>
        /// <returns>Task of ApiResponse (bool)</returns>
        public async Task<ApiResponse<bool>> AiWebSearchIsConfiguredWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling WebSearchApi->AiWebSearchIsConfigured");

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
                var exception = ExceptionFactory("AiWebSearchIsConfigured", localVarResponse);
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
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-set-active-config/">REST API Reference for AiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiWebSearchSetActiveConfig(AiWebSearchConfigureRequest aiWebSearchConfigureRequest)
        {
            var localVarResponse = AiWebSearchSetActiveConfigWithHttpInfo(aiWebSearchConfigureRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set active config
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-set-active-config/">REST API Reference for AiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiWebSearchSetActiveConfigWithHttpInfo(AiWebSearchConfigureRequest aiWebSearchConfigureRequest)
        {
            // verify the required parameter 'aiWebSearchConfigureRequest' is set
            if (aiWebSearchConfigureRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiWebSearchConfigureRequest' when calling WebSearchApi->AiWebSearchSetActiveConfig");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiWebSearchConfigureRequest != null) localVarRequestOptions.Data = aiWebSearchConfigureRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<AiSuccessResponse>("/api/2.0/ai/web-search/set-active-config", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchSetActiveConfig", localVarResponse);
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
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-set-active-config/">REST API Reference for AiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiWebSearchSetActiveConfigAsync(AiWebSearchConfigureRequest aiWebSearchConfigureRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiWebSearchSetActiveConfigWithHttpInfoAsync(aiWebSearchConfigureRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set active config
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-set-active-config/">REST API Reference for AiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiWebSearchSetActiveConfigWithHttpInfoAsync(AiWebSearchConfigureRequest aiWebSearchConfigureRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiWebSearchConfigureRequest' is set
            if (aiWebSearchConfigureRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiWebSearchConfigureRequest' when calling WebSearchApi->AiWebSearchSetActiveConfig");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiWebSearchConfigureRequest != null) localVarRequestOptions.Data = aiWebSearchConfigureRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<AiSuccessResponse>("/api/2.0/ai/web-search/set-active-config", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchSetActiveConfig", localVarResponse);
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
        /// <param name="aiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-test-connection/">REST API Reference for AiWebSearchTestConnection Operation</seealso>
        /// <returns>AiProfilesTestConnection200Response</returns>
        public AiProfilesTestConnection200Response AiWebSearchTestConnection(AiWebSearchConfig aiWebSearchConfig)
        {
            var localVarResponse = AiWebSearchTestConnectionWithHttpInfo(aiWebSearchConfig);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Test connection
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-test-connection/">REST API Reference for AiWebSearchTestConnection Operation</seealso>
        /// <returns>ApiResponse of AiProfilesTestConnection200Response</returns>
        public ApiResponse<AiProfilesTestConnection200Response> AiWebSearchTestConnectionWithHttpInfo(AiWebSearchConfig aiWebSearchConfig)
        {
            // verify the required parameter 'aiWebSearchConfig' is set
            if (aiWebSearchConfig == null)
                throw new ApiException(400, "Missing required parameter 'aiWebSearchConfig' when calling WebSearchApi->AiWebSearchTestConnection");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiWebSearchConfig != null) localVarRequestOptions.Data = aiWebSearchConfig;


            // make the HTTP request
            var localVarResponse = Client.Post<AiProfilesTestConnection200Response>("/api/2.0/ai/web-search/test-connection", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchTestConnection", localVarResponse);
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
        /// <param name="aiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-test-connection/">REST API Reference for AiWebSearchTestConnection Operation</seealso>
        /// <returns>Task of AiProfilesTestConnection200Response</returns>
        public async Task<AiProfilesTestConnection200Response> AiWebSearchTestConnectionAsync(AiWebSearchConfig aiWebSearchConfig, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiWebSearchTestConnectionWithHttpInfoAsync(aiWebSearchConfig, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Test connection
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-test-connection/">REST API Reference for AiWebSearchTestConnection Operation</seealso>
        /// <returns>Task of ApiResponse (AiProfilesTestConnection200Response)</returns>
        public async Task<ApiResponse<AiProfilesTestConnection200Response>> AiWebSearchTestConnectionWithHttpInfoAsync(AiWebSearchConfig aiWebSearchConfig, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiWebSearchConfig' is set
            if (aiWebSearchConfig == null)
                throw new ApiException(400, "Missing required parameter 'aiWebSearchConfig' when calling WebSearchApi->AiWebSearchTestConnection");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiWebSearchConfig != null) localVarRequestOptions.Data = aiWebSearchConfig;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiProfilesTestConnection200Response>("/api/2.0/ai/web-search/test-connection", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchTestConnection", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
