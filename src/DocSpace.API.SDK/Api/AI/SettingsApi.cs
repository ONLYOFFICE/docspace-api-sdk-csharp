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
    public interface ISettingsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get AI settings
        /// </summary>
        /// <remarks>
        /// Reports the portal's combined AI configuration and readiness.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get/">REST API Reference for AiSettingsGet Operation</seealso>
        /// <returns>AiAiSettingsWrapper</returns>
        AiAiSettingsWrapper AiSettingsGet();

        /// <summary>
        /// Get AI settings
        /// </summary>
        /// <remarks>
        /// Reports the portal's combined AI configuration and readiness.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get/">REST API Reference for AiSettingsGet Operation</seealso>
        /// <returns>ApiResponse of AiAiSettingsWrapper</returns>
        ApiResponse<AiAiSettingsWrapper> AiSettingsGetWithHttpInfo();
        /// <summary>
        /// Get user AI settings
        /// </summary>
        /// <remarks>
        /// Returns the current user's AI settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-user/">REST API Reference for AiSettingsGetUser Operation</seealso>
        /// <returns>AiAiUserSettingsWrapper</returns>
        AiAiUserSettingsWrapper AiSettingsGetUser();

        /// <summary>
        /// Get user AI settings
        /// </summary>
        /// <remarks>
        /// Returns the current user's AI settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-user/">REST API Reference for AiSettingsGetUser Operation</seealso>
        /// <returns>ApiResponse of AiAiUserSettingsWrapper</returns>
        ApiResponse<AiAiUserSettingsWrapper> AiSettingsGetUserWithHttpInfo();
        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's vectorization settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-vectorization/">REST API Reference for AiSettingsGetVectorization Operation</seealso>
        /// <returns>AiVectorizationSettingsWrapper</returns>
        AiVectorizationSettingsWrapper AiSettingsGetVectorization();

        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's vectorization settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-vectorization/">REST API Reference for AiSettingsGetVectorization Operation</seealso>
        /// <returns>ApiResponse of AiVectorizationSettingsWrapper</returns>
        ApiResponse<AiVectorizationSettingsWrapper> AiSettingsGetVectorizationWithHttpInfo();
        /// <summary>
        /// Update user AI settings
        /// </summary>
        /// <remarks>
        /// Updates the current user's AI settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-user/">REST API Reference for AiSettingsSetUser Operation</seealso>
        /// <returns>AiAiUserSettingsWrapper</returns>
        AiAiUserSettingsWrapper AiSettingsSetUser(Dictionary<string, Object> requestBody);

        /// <summary>
        /// Update user AI settings
        /// </summary>
        /// <remarks>
        /// Updates the current user's AI settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-user/">REST API Reference for AiSettingsSetUser Operation</seealso>
        /// <returns>ApiResponse of AiAiUserSettingsWrapper</returns>
        ApiResponse<AiAiUserSettingsWrapper> AiSettingsSetUserWithHttpInfo(Dictionary<string, Object> requestBody);
        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <remarks>
        /// Updates the portal's vectorization settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-vectorization/">REST API Reference for AiSettingsSetVectorization Operation</seealso>
        /// <returns>AiVectorizationSettingsWrapper</returns>
        AiVectorizationSettingsWrapper AiSettingsSetVectorization(Dictionary<string, Object> requestBody);

        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <remarks>
        /// Updates the portal's vectorization settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-vectorization/">REST API Reference for AiSettingsSetVectorization Operation</seealso>
        /// <returns>ApiResponse of AiVectorizationSettingsWrapper</returns>
        ApiResponse<AiVectorizationSettingsWrapper> AiSettingsSetVectorizationWithHttpInfo(Dictionary<string, Object> requestBody);
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
        /// Reports the portal's combined AI configuration and readiness.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get/">REST API Reference for AiSettingsGet Operation</seealso>
        /// <returns>Task of AiAiSettingsWrapper</returns>
        Task<AiAiSettingsWrapper> AiSettingsGetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get AI settings
        /// </summary>
        /// <remarks>
        /// Reports the portal's combined AI configuration and readiness.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get/">REST API Reference for AiSettingsGet Operation</seealso>
        /// <returns>Task of ApiResponse (AiAiSettingsWrapper)</returns>
        Task<ApiResponse<AiAiSettingsWrapper>> AiSettingsGetWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user AI settings
        /// </summary>
        /// <remarks>
        /// Returns the current user's AI settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-user/">REST API Reference for AiSettingsGetUser Operation</seealso>
        /// <returns>Task of AiAiUserSettingsWrapper</returns>
        Task<AiAiUserSettingsWrapper> AiSettingsGetUserAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get user AI settings
        /// </summary>
        /// <remarks>
        /// Returns the current user's AI settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-user/">REST API Reference for AiSettingsGetUser Operation</seealso>
        /// <returns>Task of ApiResponse (AiAiUserSettingsWrapper)</returns>
        Task<ApiResponse<AiAiUserSettingsWrapper>> AiSettingsGetUserWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's vectorization settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-vectorization/">REST API Reference for AiSettingsGetVectorization Operation</seealso>
        /// <returns>Task of AiVectorizationSettingsWrapper</returns>
        Task<AiVectorizationSettingsWrapper> AiSettingsGetVectorizationAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's vectorization settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-vectorization/">REST API Reference for AiSettingsGetVectorization Operation</seealso>
        /// <returns>Task of ApiResponse (AiVectorizationSettingsWrapper)</returns>
        Task<ApiResponse<AiVectorizationSettingsWrapper>> AiSettingsGetVectorizationWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Update user AI settings
        /// </summary>
        /// <remarks>
        /// Updates the current user's AI settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-user/">REST API Reference for AiSettingsSetUser Operation</seealso>
        /// <returns>Task of AiAiUserSettingsWrapper</returns>
        Task<AiAiUserSettingsWrapper> AiSettingsSetUserAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update user AI settings
        /// </summary>
        /// <remarks>
        /// Updates the current user's AI settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-user/">REST API Reference for AiSettingsSetUser Operation</seealso>
        /// <returns>Task of ApiResponse (AiAiUserSettingsWrapper)</returns>
        Task<ApiResponse<AiAiUserSettingsWrapper>> AiSettingsSetUserWithHttpInfoAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <remarks>
        /// Updates the portal's vectorization settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-vectorization/">REST API Reference for AiSettingsSetVectorization Operation</seealso>
        /// <returns>Task of AiVectorizationSettingsWrapper</returns>
        Task<AiVectorizationSettingsWrapper> AiSettingsSetVectorizationAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <remarks>
        /// Updates the portal's vectorization settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-vectorization/">REST API Reference for AiSettingsSetVectorization Operation</seealso>
        /// <returns>Task of ApiResponse (AiVectorizationSettingsWrapper)</returns>
        Task<ApiResponse<AiVectorizationSettingsWrapper>> AiSettingsSetVectorizationWithHttpInfoAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default);
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
        /// Reports the portal's combined AI configuration and readiness.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get/">REST API Reference for AiSettingsGet Operation</seealso>
        /// <returns>AiAiSettingsWrapper</returns>
        public AiAiSettingsWrapper AiSettingsGet()
        {
            var localVarResponse = AiSettingsGetWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get AI settings
        /// </summary>
        /// <remarks>
        /// Reports the portal's combined AI configuration and readiness.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get/">REST API Reference for AiSettingsGet Operation</seealso>
        /// <returns>ApiResponse of AiAiSettingsWrapper</returns>
        public ApiResponse<AiAiSettingsWrapper> AiSettingsGetWithHttpInfo()
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
            var localVarResponse = Client.Get<AiAiSettingsWrapper>("/api/2.0/ai/config", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsGet", localVarResponse);
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
        /// Reports the portal's combined AI configuration and readiness.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get/">REST API Reference for AiSettingsGet Operation</seealso>
        /// <returns>Task of AiAiSettingsWrapper</returns>
        public async Task<AiAiSettingsWrapper> AiSettingsGetAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiSettingsGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get AI settings
        /// </summary>
        /// <remarks>
        /// Reports the portal's combined AI configuration and readiness.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get/">REST API Reference for AiSettingsGet Operation</seealso>
        /// <returns>Task of ApiResponse (AiAiSettingsWrapper)</returns>
        public async Task<ApiResponse<AiAiSettingsWrapper>> AiSettingsGetWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<AiAiSettingsWrapper>("/api/2.0/ai/config", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsGet", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get user AI settings
        /// </summary>
        /// <remarks>
        /// Returns the current user's AI settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-user/">REST API Reference for AiSettingsGetUser Operation</seealso>
        /// <returns>AiAiUserSettingsWrapper</returns>
        public AiAiUserSettingsWrapper AiSettingsGetUser()
        {
            var localVarResponse = AiSettingsGetUserWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user AI settings
        /// </summary>
        /// <remarks>
        /// Returns the current user's AI settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-user/">REST API Reference for AiSettingsGetUser Operation</seealso>
        /// <returns>ApiResponse of AiAiUserSettingsWrapper</returns>
        public ApiResponse<AiAiUserSettingsWrapper> AiSettingsGetUserWithHttpInfo()
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
            var localVarResponse = Client.Get<AiAiUserSettingsWrapper>("/api/2.0/ai/config/user", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsGetUser", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get user AI settings
        /// </summary>
        /// <remarks>
        /// Returns the current user's AI settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-user/">REST API Reference for AiSettingsGetUser Operation</seealso>
        /// <returns>Task of AiAiUserSettingsWrapper</returns>
        public async Task<AiAiUserSettingsWrapper> AiSettingsGetUserAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiSettingsGetUserWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user AI settings
        /// </summary>
        /// <remarks>
        /// Returns the current user's AI settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-user/">REST API Reference for AiSettingsGetUser Operation</seealso>
        /// <returns>Task of ApiResponse (AiAiUserSettingsWrapper)</returns>
        public async Task<ApiResponse<AiAiUserSettingsWrapper>> AiSettingsGetUserWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<AiAiUserSettingsWrapper>("/api/2.0/ai/config/user", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsGetUser", localVarResponse);
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
        /// Returns the portal's vectorization settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-vectorization/">REST API Reference for AiSettingsGetVectorization Operation</seealso>
        /// <returns>AiVectorizationSettingsWrapper</returns>
        public AiVectorizationSettingsWrapper AiSettingsGetVectorization()
        {
            var localVarResponse = AiSettingsGetVectorizationWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's vectorization settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-vectorization/">REST API Reference for AiSettingsGetVectorization Operation</seealso>
        /// <returns>ApiResponse of AiVectorizationSettingsWrapper</returns>
        public ApiResponse<AiVectorizationSettingsWrapper> AiSettingsGetVectorizationWithHttpInfo()
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
            var localVarResponse = Client.Get<AiVectorizationSettingsWrapper>("/api/2.0/ai/config/vectorization", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsGetVectorization", localVarResponse);
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
        /// Returns the portal's vectorization settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-vectorization/">REST API Reference for AiSettingsGetVectorization Operation</seealso>
        /// <returns>Task of AiVectorizationSettingsWrapper</returns>
        public async Task<AiVectorizationSettingsWrapper> AiSettingsGetVectorizationAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiSettingsGetVectorizationWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's vectorization settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-vectorization/">REST API Reference for AiSettingsGetVectorization Operation</seealso>
        /// <returns>Task of ApiResponse (AiVectorizationSettingsWrapper)</returns>
        public async Task<ApiResponse<AiVectorizationSettingsWrapper>> AiSettingsGetVectorizationWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<AiVectorizationSettingsWrapper>("/api/2.0/ai/config/vectorization", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsGetVectorization", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update user AI settings
        /// </summary>
        /// <remarks>
        /// Updates the current user's AI settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-user/">REST API Reference for AiSettingsSetUser Operation</seealso>
        /// <returns>AiAiUserSettingsWrapper</returns>
        public AiAiUserSettingsWrapper AiSettingsSetUser(Dictionary<string, Object> requestBody)
        {
            var localVarResponse = AiSettingsSetUserWithHttpInfo(requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update user AI settings
        /// </summary>
        /// <remarks>
        /// Updates the current user's AI settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-user/">REST API Reference for AiSettingsSetUser Operation</seealso>
        /// <returns>ApiResponse of AiAiUserSettingsWrapper</returns>
        public ApiResponse<AiAiUserSettingsWrapper> AiSettingsSetUserWithHttpInfo(Dictionary<string, Object> requestBody)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling SettingsApi->AiSettingsSetUser");

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
            var localVarResponse = Client.Put<AiAiUserSettingsWrapper>("/api/2.0/ai/config/user", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsSetUser", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update user AI settings
        /// </summary>
        /// <remarks>
        /// Updates the current user's AI settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-user/">REST API Reference for AiSettingsSetUser Operation</seealso>
        /// <returns>Task of AiAiUserSettingsWrapper</returns>
        public async Task<AiAiUserSettingsWrapper> AiSettingsSetUserAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiSettingsSetUserWithHttpInfoAsync(requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update user AI settings
        /// </summary>
        /// <remarks>
        /// Updates the current user's AI settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-user/">REST API Reference for AiSettingsSetUser Operation</seealso>
        /// <returns>Task of ApiResponse (AiAiUserSettingsWrapper)</returns>
        public async Task<ApiResponse<AiAiUserSettingsWrapper>> AiSettingsSetUserWithHttpInfoAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling SettingsApi->AiSettingsSetUser");

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

            var localVarResponse = await AsynchronousClient.PutAsync<AiAiUserSettingsWrapper>("/api/2.0/ai/config/user", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsSetUser", localVarResponse);
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
        /// Updates the portal's vectorization settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-vectorization/">REST API Reference for AiSettingsSetVectorization Operation</seealso>
        /// <returns>AiVectorizationSettingsWrapper</returns>
        public AiVectorizationSettingsWrapper AiSettingsSetVectorization(Dictionary<string, Object> requestBody)
        {
            var localVarResponse = AiSettingsSetVectorizationWithHttpInfo(requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <remarks>
        /// Updates the portal's vectorization settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-vectorization/">REST API Reference for AiSettingsSetVectorization Operation</seealso>
        /// <returns>ApiResponse of AiVectorizationSettingsWrapper</returns>
        public ApiResponse<AiVectorizationSettingsWrapper> AiSettingsSetVectorizationWithHttpInfo(Dictionary<string, Object> requestBody)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling SettingsApi->AiSettingsSetVectorization");

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
            var localVarResponse = Client.Put<AiVectorizationSettingsWrapper>("/api/2.0/ai/config/vectorization", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsSetVectorization", localVarResponse);
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
        /// Updates the portal's vectorization settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-vectorization/">REST API Reference for AiSettingsSetVectorization Operation</seealso>
        /// <returns>Task of AiVectorizationSettingsWrapper</returns>
        public async Task<AiVectorizationSettingsWrapper> AiSettingsSetVectorizationAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiSettingsSetVectorizationWithHttpInfoAsync(requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <remarks>
        /// Updates the portal's vectorization settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-vectorization/">REST API Reference for AiSettingsSetVectorization Operation</seealso>
        /// <returns>Task of ApiResponse (AiVectorizationSettingsWrapper)</returns>
        public async Task<ApiResponse<AiVectorizationSettingsWrapper>> AiSettingsSetVectorizationWithHttpInfoAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling SettingsApi->AiSettingsSetVectorization");

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

            var localVarResponse = await AsynchronousClient.PutAsync<AiVectorizationSettingsWrapper>("/api/2.0/ai/config/vectorization", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsSetVectorization", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
