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
    public interface ISettingsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get AI settings
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get/">REST API Reference for NewAiSettingsGet Operation</seealso>
        /// <returns>NewAiAiSettingsWrapper</returns>
        NewAiAiSettingsWrapper NewAiSettingsGet();

        /// <summary>
        /// Get AI settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get/">REST API Reference for NewAiSettingsGet Operation</seealso>
        /// <returns>ApiResponse of NewAiAiSettingsWrapper</returns>
        ApiResponse<NewAiAiSettingsWrapper> NewAiSettingsGetWithHttpInfo();
        /// <summary>
        /// Get user AI settings
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get-user/">REST API Reference for NewAiSettingsGetUser Operation</seealso>
        /// <returns>NewAiAiUserSettingsWrapper</returns>
        NewAiAiUserSettingsWrapper NewAiSettingsGetUser();

        /// <summary>
        /// Get user AI settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get-user/">REST API Reference for NewAiSettingsGetUser Operation</seealso>
        /// <returns>ApiResponse of NewAiAiUserSettingsWrapper</returns>
        ApiResponse<NewAiAiUserSettingsWrapper> NewAiSettingsGetUserWithHttpInfo();
        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get-vectorization/">REST API Reference for NewAiSettingsGetVectorization Operation</seealso>
        /// <returns>NewAiVectorizationSettingsWrapper</returns>
        NewAiVectorizationSettingsWrapper NewAiSettingsGetVectorization();

        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get-vectorization/">REST API Reference for NewAiSettingsGetVectorization Operation</seealso>
        /// <returns>ApiResponse of NewAiVectorizationSettingsWrapper</returns>
        ApiResponse<NewAiVectorizationSettingsWrapper> NewAiSettingsGetVectorizationWithHttpInfo();
        /// <summary>
        /// Update user AI settings
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-set-user/">REST API Reference for NewAiSettingsSetUser Operation</seealso>
        /// <returns>NewAiAiUserSettingsWrapper</returns>
        NewAiAiUserSettingsWrapper NewAiSettingsSetUser(Dictionary<string, Object> requestBody);

        /// <summary>
        /// Update user AI settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-set-user/">REST API Reference for NewAiSettingsSetUser Operation</seealso>
        /// <returns>ApiResponse of NewAiAiUserSettingsWrapper</returns>
        ApiResponse<NewAiAiUserSettingsWrapper> NewAiSettingsSetUserWithHttpInfo(Dictionary<string, Object> requestBody);
        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-set-vectorization/">REST API Reference for NewAiSettingsSetVectorization Operation</seealso>
        /// <returns>NewAiVectorizationSettingsWrapper</returns>
        NewAiVectorizationSettingsWrapper NewAiSettingsSetVectorization(Dictionary<string, Object> requestBody);

        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-set-vectorization/">REST API Reference for NewAiSettingsSetVectorization Operation</seealso>
        /// <returns>ApiResponse of NewAiVectorizationSettingsWrapper</returns>
        ApiResponse<NewAiVectorizationSettingsWrapper> NewAiSettingsSetVectorizationWithHttpInfo(Dictionary<string, Object> requestBody);
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
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get/">REST API Reference for NewAiSettingsGet Operation</seealso>
        /// <returns>Task of NewAiAiSettingsWrapper</returns>
        Task<NewAiAiSettingsWrapper> NewAiSettingsGetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get AI settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get/">REST API Reference for NewAiSettingsGet Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiAiSettingsWrapper)</returns>
        Task<ApiResponse<NewAiAiSettingsWrapper>> NewAiSettingsGetWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user AI settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get-user/">REST API Reference for NewAiSettingsGetUser Operation</seealso>
        /// <returns>Task of NewAiAiUserSettingsWrapper</returns>
        Task<NewAiAiUserSettingsWrapper> NewAiSettingsGetUserAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get user AI settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get-user/">REST API Reference for NewAiSettingsGetUser Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiAiUserSettingsWrapper)</returns>
        Task<ApiResponse<NewAiAiUserSettingsWrapper>> NewAiSettingsGetUserWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get-vectorization/">REST API Reference for NewAiSettingsGetVectorization Operation</seealso>
        /// <returns>Task of NewAiVectorizationSettingsWrapper</returns>
        Task<NewAiVectorizationSettingsWrapper> NewAiSettingsGetVectorizationAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get-vectorization/">REST API Reference for NewAiSettingsGetVectorization Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiVectorizationSettingsWrapper)</returns>
        Task<ApiResponse<NewAiVectorizationSettingsWrapper>> NewAiSettingsGetVectorizationWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Update user AI settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-set-user/">REST API Reference for NewAiSettingsSetUser Operation</seealso>
        /// <returns>Task of NewAiAiUserSettingsWrapper</returns>
        Task<NewAiAiUserSettingsWrapper> NewAiSettingsSetUserAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update user AI settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-set-user/">REST API Reference for NewAiSettingsSetUser Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiAiUserSettingsWrapper)</returns>
        Task<ApiResponse<NewAiAiUserSettingsWrapper>> NewAiSettingsSetUserWithHttpInfoAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-set-vectorization/">REST API Reference for NewAiSettingsSetVectorization Operation</seealso>
        /// <returns>Task of NewAiVectorizationSettingsWrapper</returns>
        Task<NewAiVectorizationSettingsWrapper> NewAiSettingsSetVectorizationAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-set-vectorization/">REST API Reference for NewAiSettingsSetVectorization Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiVectorizationSettingsWrapper)</returns>
        Task<ApiResponse<NewAiVectorizationSettingsWrapper>> NewAiSettingsSetVectorizationWithHttpInfoAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get/">REST API Reference for NewAiSettingsGet Operation</seealso>
        /// <returns>NewAiAiSettingsWrapper</returns>
        public NewAiAiSettingsWrapper NewAiSettingsGet()
        {
            var localVarResponse = NewAiSettingsGetWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get AI settings
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get/">REST API Reference for NewAiSettingsGet Operation</seealso>
        /// <returns>ApiResponse of NewAiAiSettingsWrapper</returns>
        public ApiResponse<NewAiAiSettingsWrapper> NewAiSettingsGetWithHttpInfo()
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
            var localVarResponse = Client.Get<NewAiAiSettingsWrapper>("/api/2.0/ai/config", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiSettingsGet", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get/">REST API Reference for NewAiSettingsGet Operation</seealso>
        /// <returns>Task of NewAiAiSettingsWrapper</returns>
        public async Task<NewAiAiSettingsWrapper> NewAiSettingsGetAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiSettingsGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get AI settings
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get/">REST API Reference for NewAiSettingsGet Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiAiSettingsWrapper)</returns>
        public async Task<ApiResponse<NewAiAiSettingsWrapper>> NewAiSettingsGetWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<NewAiAiSettingsWrapper>("/api/2.0/ai/config", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiSettingsGet", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get-user/">REST API Reference for NewAiSettingsGetUser Operation</seealso>
        /// <returns>NewAiAiUserSettingsWrapper</returns>
        public NewAiAiUserSettingsWrapper NewAiSettingsGetUser()
        {
            var localVarResponse = NewAiSettingsGetUserWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user AI settings
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get-user/">REST API Reference for NewAiSettingsGetUser Operation</seealso>
        /// <returns>ApiResponse of NewAiAiUserSettingsWrapper</returns>
        public ApiResponse<NewAiAiUserSettingsWrapper> NewAiSettingsGetUserWithHttpInfo()
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
            var localVarResponse = Client.Get<NewAiAiUserSettingsWrapper>("/api/2.0/ai/config/user", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiSettingsGetUser", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get-user/">REST API Reference for NewAiSettingsGetUser Operation</seealso>
        /// <returns>Task of NewAiAiUserSettingsWrapper</returns>
        public async Task<NewAiAiUserSettingsWrapper> NewAiSettingsGetUserAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiSettingsGetUserWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user AI settings
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get-user/">REST API Reference for NewAiSettingsGetUser Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiAiUserSettingsWrapper)</returns>
        public async Task<ApiResponse<NewAiAiUserSettingsWrapper>> NewAiSettingsGetUserWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<NewAiAiUserSettingsWrapper>("/api/2.0/ai/config/user", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiSettingsGetUser", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get-vectorization/">REST API Reference for NewAiSettingsGetVectorization Operation</seealso>
        /// <returns>NewAiVectorizationSettingsWrapper</returns>
        public NewAiVectorizationSettingsWrapper NewAiSettingsGetVectorization()
        {
            var localVarResponse = NewAiSettingsGetVectorizationWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get-vectorization/">REST API Reference for NewAiSettingsGetVectorization Operation</seealso>
        /// <returns>ApiResponse of NewAiVectorizationSettingsWrapper</returns>
        public ApiResponse<NewAiVectorizationSettingsWrapper> NewAiSettingsGetVectorizationWithHttpInfo()
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
            var localVarResponse = Client.Get<NewAiVectorizationSettingsWrapper>("/api/2.0/ai/config/vectorization", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiSettingsGetVectorization", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get-vectorization/">REST API Reference for NewAiSettingsGetVectorization Operation</seealso>
        /// <returns>Task of NewAiVectorizationSettingsWrapper</returns>
        public async Task<NewAiVectorizationSettingsWrapper> NewAiSettingsGetVectorizationAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiSettingsGetVectorizationWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-get-vectorization/">REST API Reference for NewAiSettingsGetVectorization Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiVectorizationSettingsWrapper)</returns>
        public async Task<ApiResponse<NewAiVectorizationSettingsWrapper>> NewAiSettingsGetVectorizationWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<NewAiVectorizationSettingsWrapper>("/api/2.0/ai/config/vectorization", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiSettingsGetVectorization", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-set-user/">REST API Reference for NewAiSettingsSetUser Operation</seealso>
        /// <returns>NewAiAiUserSettingsWrapper</returns>
        public NewAiAiUserSettingsWrapper NewAiSettingsSetUser(Dictionary<string, Object> requestBody)
        {
            var localVarResponse = NewAiSettingsSetUserWithHttpInfo(requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update user AI settings
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-set-user/">REST API Reference for NewAiSettingsSetUser Operation</seealso>
        /// <returns>ApiResponse of NewAiAiUserSettingsWrapper</returns>
        public ApiResponse<NewAiAiUserSettingsWrapper> NewAiSettingsSetUserWithHttpInfo(Dictionary<string, Object> requestBody)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling SettingsApi->NewAiSettingsSetUser");

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
            var localVarResponse = Client.Put<NewAiAiUserSettingsWrapper>("/api/2.0/ai/config/user", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiSettingsSetUser", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-set-user/">REST API Reference for NewAiSettingsSetUser Operation</seealso>
        /// <returns>Task of NewAiAiUserSettingsWrapper</returns>
        public async Task<NewAiAiUserSettingsWrapper> NewAiSettingsSetUserAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiSettingsSetUserWithHttpInfoAsync(requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update user AI settings
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-set-user/">REST API Reference for NewAiSettingsSetUser Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiAiUserSettingsWrapper)</returns>
        public async Task<ApiResponse<NewAiAiUserSettingsWrapper>> NewAiSettingsSetUserWithHttpInfoAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling SettingsApi->NewAiSettingsSetUser");

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

            var localVarResponse = await AsynchronousClient.PutAsync<NewAiAiUserSettingsWrapper>("/api/2.0/ai/config/user", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiSettingsSetUser", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-set-vectorization/">REST API Reference for NewAiSettingsSetVectorization Operation</seealso>
        /// <returns>NewAiVectorizationSettingsWrapper</returns>
        public NewAiVectorizationSettingsWrapper NewAiSettingsSetVectorization(Dictionary<string, Object> requestBody)
        {
            var localVarResponse = NewAiSettingsSetVectorizationWithHttpInfo(requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-set-vectorization/">REST API Reference for NewAiSettingsSetVectorization Operation</seealso>
        /// <returns>ApiResponse of NewAiVectorizationSettingsWrapper</returns>
        public ApiResponse<NewAiVectorizationSettingsWrapper> NewAiSettingsSetVectorizationWithHttpInfo(Dictionary<string, Object> requestBody)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling SettingsApi->NewAiSettingsSetVectorization");

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
            var localVarResponse = Client.Put<NewAiVectorizationSettingsWrapper>("/api/2.0/ai/config/vectorization", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiSettingsSetVectorization", localVarResponse);
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-set-vectorization/">REST API Reference for NewAiSettingsSetVectorization Operation</seealso>
        /// <returns>Task of NewAiVectorizationSettingsWrapper</returns>
        public async Task<NewAiVectorizationSettingsWrapper> NewAiSettingsSetVectorizationAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiSettingsSetVectorizationWithHttpInfoAsync(requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-settings-set-vectorization/">REST API Reference for NewAiSettingsSetVectorization Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiVectorizationSettingsWrapper)</returns>
        public async Task<ApiResponse<NewAiVectorizationSettingsWrapper>> NewAiSettingsSetVectorizationWithHttpInfoAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling SettingsApi->NewAiSettingsSetVectorization");

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

            var localVarResponse = await AsynchronousClient.PutAsync<NewAiVectorizationSettingsWrapper>("/api/2.0/ai/config/vectorization", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiSettingsSetVectorization", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
