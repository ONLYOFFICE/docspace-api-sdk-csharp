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
    public interface IPreferencesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Clear deep mode
        /// </summary>
        /// <remarks>
        /// Drops the persisted deep-mode toggle of the scope, so later reads fall back to the configured default.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-clear-deep-mode/">REST API Reference for AiPreferencesClearDeepMode Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiPreferencesClearDeepMode(string body);

        /// <summary>
        /// Clear deep mode
        /// </summary>
        /// <remarks>
        /// Drops the persisted deep-mode toggle of the scope, so later reads fall back to the configured default.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-clear-deep-mode/">REST API Reference for AiPreferencesClearDeepMode Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiPreferencesClearDeepModeWithHttpInfo(string body);
        /// <summary>
        /// Get deep mode
        /// </summary>
        /// <remarks>
        /// Returns the deep-mode toggle of the scope, falling back to the configured default when nothing has been persisted.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-get-deep-mode/">REST API Reference for AiPreferencesGetDeepMode Operation</seealso>
        /// <returns>bool</returns>
        bool AiPreferencesGetDeepMode(string? entityId = default);

        /// <summary>
        /// Get deep mode
        /// </summary>
        /// <remarks>
        /// Returns the deep-mode toggle of the scope, falling back to the configured default when nothing has been persisted.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-get-deep-mode/">REST API Reference for AiPreferencesGetDeepMode Operation</seealso>
        /// <returns>ApiResponse of bool</returns>
        ApiResponse<bool> AiPreferencesGetDeepModeWithHttpInfo(string? entityId = default);
        /// <summary>
        /// Is deep mode set
        /// </summary>
        /// <remarks>
        /// Tells whether the scope has an explicitly persisted deep-mode value, whichever way that value is set.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-is-deep-mode-set/">REST API Reference for AiPreferencesIsDeepModeSet Operation</seealso>
        /// <returns>bool</returns>
        bool AiPreferencesIsDeepModeSet(string? entityId = default);

        /// <summary>
        /// Is deep mode set
        /// </summary>
        /// <remarks>
        /// Tells whether the scope has an explicitly persisted deep-mode value, whichever way that value is set.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-is-deep-mode-set/">REST API Reference for AiPreferencesIsDeepModeSet Operation</seealso>
        /// <returns>ApiResponse of bool</returns>
        ApiResponse<bool> AiPreferencesIsDeepModeSetWithHttpInfo(string? entityId = default);
        /// <summary>
        /// Set deep mode
        /// </summary>
        /// <remarks>
        /// Persists the deep-mode toggle of the scope. Idempotent - there is no need to check whether a value already exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPreferencesSetDeepModeRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-set-deep-mode/">REST API Reference for AiPreferencesSetDeepMode Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiPreferencesSetDeepMode(AiPreferencesSetDeepModeRequest aiPreferencesSetDeepModeRequest);

        /// <summary>
        /// Set deep mode
        /// </summary>
        /// <remarks>
        /// Persists the deep-mode toggle of the scope. Idempotent - there is no need to check whether a value already exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPreferencesSetDeepModeRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-set-deep-mode/">REST API Reference for AiPreferencesSetDeepMode Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiPreferencesSetDeepModeWithHttpInfo(AiPreferencesSetDeepModeRequest aiPreferencesSetDeepModeRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPreferencesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Clear deep mode
        /// </summary>
        /// <remarks>
        /// Drops the persisted deep-mode toggle of the scope, so later reads fall back to the configured default.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-clear-deep-mode/">REST API Reference for AiPreferencesClearDeepMode Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiPreferencesClearDeepModeAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Clear deep mode
        /// </summary>
        /// <remarks>
        /// Drops the persisted deep-mode toggle of the scope, so later reads fall back to the configured default.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-clear-deep-mode/">REST API Reference for AiPreferencesClearDeepMode Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiPreferencesClearDeepModeWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get deep mode
        /// </summary>
        /// <remarks>
        /// Returns the deep-mode toggle of the scope, falling back to the configured default when nothing has been persisted.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-get-deep-mode/">REST API Reference for AiPreferencesGetDeepMode Operation</seealso>
        /// <returns>Task of bool</returns>
        Task<bool> AiPreferencesGetDeepModeAsync(string? entityId = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get deep mode
        /// </summary>
        /// <remarks>
        /// Returns the deep-mode toggle of the scope, falling back to the configured default when nothing has been persisted.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-get-deep-mode/">REST API Reference for AiPreferencesGetDeepMode Operation</seealso>
        /// <returns>Task of ApiResponse (bool)</returns>
        Task<ApiResponse<bool>> AiPreferencesGetDeepModeWithHttpInfoAsync(string? entityId = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Is deep mode set
        /// </summary>
        /// <remarks>
        /// Tells whether the scope has an explicitly persisted deep-mode value, whichever way that value is set.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-is-deep-mode-set/">REST API Reference for AiPreferencesIsDeepModeSet Operation</seealso>
        /// <returns>Task of bool</returns>
        Task<bool> AiPreferencesIsDeepModeSetAsync(string? entityId = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Is deep mode set
        /// </summary>
        /// <remarks>
        /// Tells whether the scope has an explicitly persisted deep-mode value, whichever way that value is set.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-is-deep-mode-set/">REST API Reference for AiPreferencesIsDeepModeSet Operation</seealso>
        /// <returns>Task of ApiResponse (bool)</returns>
        Task<ApiResponse<bool>> AiPreferencesIsDeepModeSetWithHttpInfoAsync(string? entityId = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set deep mode
        /// </summary>
        /// <remarks>
        /// Persists the deep-mode toggle of the scope. Idempotent - there is no need to check whether a value already exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPreferencesSetDeepModeRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-set-deep-mode/">REST API Reference for AiPreferencesSetDeepMode Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiPreferencesSetDeepModeAsync(AiPreferencesSetDeepModeRequest aiPreferencesSetDeepModeRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set deep mode
        /// </summary>
        /// <remarks>
        /// Persists the deep-mode toggle of the scope. Idempotent - there is no need to check whether a value already exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPreferencesSetDeepModeRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-set-deep-mode/">REST API Reference for AiPreferencesSetDeepMode Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiPreferencesSetDeepModeWithHttpInfoAsync(AiPreferencesSetDeepModeRequest aiPreferencesSetDeepModeRequest, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPreferencesApi : IPreferencesApiSync, IPreferencesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PreferencesApi : IDisposable, IPreferencesApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PreferencesApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public PreferencesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreferencesApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public PreferencesApi(string basePath)
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
        /// Initializes a new instance of the <see cref="PreferencesApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public PreferencesApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="PreferencesApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public PreferencesApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreferencesApi"/> class.
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
        public PreferencesApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="PreferencesApi"/> class using a Configuration object.
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
        public PreferencesApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="PreferencesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public PreferencesApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Clear deep mode
        /// </summary>
        /// <remarks>
        /// Drops the persisted deep-mode toggle of the scope, so later reads fall back to the configured default.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-clear-deep-mode/">REST API Reference for AiPreferencesClearDeepMode Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiPreferencesClearDeepMode(string body)
        {
            var localVarResponse = AiPreferencesClearDeepModeWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Clear deep mode
        /// </summary>
        /// <remarks>
        /// Drops the persisted deep-mode toggle of the scope, so later reads fall back to the configured default.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-clear-deep-mode/">REST API Reference for AiPreferencesClearDeepMode Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiPreferencesClearDeepModeWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PreferencesApi->AiPreferencesClearDeepMode");

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
            var localVarResponse = Client.Delete<AiSuccessResponse>("/api/2.0/ai/preferences/clear-deep-mode", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPreferencesClearDeepMode", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Clear deep mode
        /// </summary>
        /// <remarks>
        /// Drops the persisted deep-mode toggle of the scope, so later reads fall back to the configured default.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-clear-deep-mode/">REST API Reference for AiPreferencesClearDeepMode Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiPreferencesClearDeepModeAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiPreferencesClearDeepModeWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Clear deep mode
        /// </summary>
        /// <remarks>
        /// Drops the persisted deep-mode toggle of the scope, so later reads fall back to the configured default.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-clear-deep-mode/">REST API Reference for AiPreferencesClearDeepMode Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiPreferencesClearDeepModeWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PreferencesApi->AiPreferencesClearDeepMode");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<AiSuccessResponse>("/api/2.0/ai/preferences/clear-deep-mode", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPreferencesClearDeepMode", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get deep mode
        /// </summary>
        /// <remarks>
        /// Returns the deep-mode toggle of the scope, falling back to the configured default when nothing has been persisted.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-get-deep-mode/">REST API Reference for AiPreferencesGetDeepMode Operation</seealso>
        /// <returns>bool</returns>
        public bool AiPreferencesGetDeepMode(string? entityId = default)
        {
            var localVarResponse = AiPreferencesGetDeepModeWithHttpInfo(entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get deep mode
        /// </summary>
        /// <remarks>
        /// Returns the deep-mode toggle of the scope, falling back to the configured default when nothing has been persisted.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-get-deep-mode/">REST API Reference for AiPreferencesGetDeepMode Operation</seealso>
        /// <returns>ApiResponse of bool</returns>
        public ApiResponse<bool> AiPreferencesGetDeepModeWithHttpInfo(string? entityId = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (entityId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<bool>("/api/2.0/ai/preferences/get-deep-mode", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPreferencesGetDeepMode", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get deep mode
        /// </summary>
        /// <remarks>
        /// Returns the deep-mode toggle of the scope, falling back to the configured default when nothing has been persisted.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-get-deep-mode/">REST API Reference for AiPreferencesGetDeepMode Operation</seealso>
        /// <returns>Task of bool</returns>
        public async Task<bool> AiPreferencesGetDeepModeAsync(string? entityId = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiPreferencesGetDeepModeWithHttpInfoAsync(entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get deep mode
        /// </summary>
        /// <remarks>
        /// Returns the deep-mode toggle of the scope, falling back to the configured default when nothing has been persisted.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-get-deep-mode/">REST API Reference for AiPreferencesGetDeepMode Operation</seealso>
        /// <returns>Task of ApiResponse (bool)</returns>
        public async Task<ApiResponse<bool>> AiPreferencesGetDeepModeWithHttpInfoAsync(string? entityId = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (entityId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<bool>("/api/2.0/ai/preferences/get-deep-mode", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPreferencesGetDeepMode", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Is deep mode set
        /// </summary>
        /// <remarks>
        /// Tells whether the scope has an explicitly persisted deep-mode value, whichever way that value is set.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-is-deep-mode-set/">REST API Reference for AiPreferencesIsDeepModeSet Operation</seealso>
        /// <returns>bool</returns>
        public bool AiPreferencesIsDeepModeSet(string? entityId = default)
        {
            var localVarResponse = AiPreferencesIsDeepModeSetWithHttpInfo(entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Is deep mode set
        /// </summary>
        /// <remarks>
        /// Tells whether the scope has an explicitly persisted deep-mode value, whichever way that value is set.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-is-deep-mode-set/">REST API Reference for AiPreferencesIsDeepModeSet Operation</seealso>
        /// <returns>ApiResponse of bool</returns>
        public ApiResponse<bool> AiPreferencesIsDeepModeSetWithHttpInfo(string? entityId = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (entityId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<bool>("/api/2.0/ai/preferences/is-deep-mode-set", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPreferencesIsDeepModeSet", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Is deep mode set
        /// </summary>
        /// <remarks>
        /// Tells whether the scope has an explicitly persisted deep-mode value, whichever way that value is set.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-is-deep-mode-set/">REST API Reference for AiPreferencesIsDeepModeSet Operation</seealso>
        /// <returns>Task of bool</returns>
        public async Task<bool> AiPreferencesIsDeepModeSetAsync(string? entityId = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiPreferencesIsDeepModeSetWithHttpInfoAsync(entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Is deep mode set
        /// </summary>
        /// <remarks>
        /// Tells whether the scope has an explicitly persisted deep-mode value, whichever way that value is set.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-is-deep-mode-set/">REST API Reference for AiPreferencesIsDeepModeSet Operation</seealso>
        /// <returns>Task of ApiResponse (bool)</returns>
        public async Task<ApiResponse<bool>> AiPreferencesIsDeepModeSetWithHttpInfoAsync(string? entityId = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (entityId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<bool>("/api/2.0/ai/preferences/is-deep-mode-set", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPreferencesIsDeepModeSet", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set deep mode
        /// </summary>
        /// <remarks>
        /// Persists the deep-mode toggle of the scope. Idempotent - there is no need to check whether a value already exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPreferencesSetDeepModeRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-set-deep-mode/">REST API Reference for AiPreferencesSetDeepMode Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiPreferencesSetDeepMode(AiPreferencesSetDeepModeRequest aiPreferencesSetDeepModeRequest)
        {
            var localVarResponse = AiPreferencesSetDeepModeWithHttpInfo(aiPreferencesSetDeepModeRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set deep mode
        /// </summary>
        /// <remarks>
        /// Persists the deep-mode toggle of the scope. Idempotent - there is no need to check whether a value already exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPreferencesSetDeepModeRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-set-deep-mode/">REST API Reference for AiPreferencesSetDeepMode Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiPreferencesSetDeepModeWithHttpInfo(AiPreferencesSetDeepModeRequest aiPreferencesSetDeepModeRequest)
        {
            // verify the required parameter 'aiPreferencesSetDeepModeRequest' is set
            if (aiPreferencesSetDeepModeRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiPreferencesSetDeepModeRequest' when calling PreferencesApi->AiPreferencesSetDeepMode");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiPreferencesSetDeepModeRequest != null) localVarRequestOptions.Data = aiPreferencesSetDeepModeRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<AiSuccessResponse>("/api/2.0/ai/preferences/set-deep-mode", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPreferencesSetDeepMode", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set deep mode
        /// </summary>
        /// <remarks>
        /// Persists the deep-mode toggle of the scope. Idempotent - there is no need to check whether a value already exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPreferencesSetDeepModeRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-set-deep-mode/">REST API Reference for AiPreferencesSetDeepMode Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiPreferencesSetDeepModeAsync(AiPreferencesSetDeepModeRequest aiPreferencesSetDeepModeRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiPreferencesSetDeepModeWithHttpInfoAsync(aiPreferencesSetDeepModeRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set deep mode
        /// </summary>
        /// <remarks>
        /// Persists the deep-mode toggle of the scope. Idempotent - there is no need to check whether a value already exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPreferencesSetDeepModeRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-set-deep-mode/">REST API Reference for AiPreferencesSetDeepMode Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiPreferencesSetDeepModeWithHttpInfoAsync(AiPreferencesSetDeepModeRequest aiPreferencesSetDeepModeRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiPreferencesSetDeepModeRequest' is set
            if (aiPreferencesSetDeepModeRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiPreferencesSetDeepModeRequest' when calling PreferencesApi->AiPreferencesSetDeepMode");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiPreferencesSetDeepModeRequest != null) localVarRequestOptions.Data = aiPreferencesSetDeepModeRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<AiSuccessResponse>("/api/2.0/ai/preferences/set-deep-mode", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPreferencesSetDeepMode", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
