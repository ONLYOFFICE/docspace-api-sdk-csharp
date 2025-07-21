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



using DocSpace.Sdk.Client;
using DocSpace.Sdk.Model;

namespace DocSpace.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISecurityLoginHistoryApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Generate the login history report
        /// </summary>
        /// <remarks>
        /// Generates the login history report.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-login-history-report/">REST API Reference for CreateLoginHistoryReport Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper CreateLoginHistoryReport();

        /// <summary>
        /// Generate the login history report
        /// </summary>
        /// <remarks>
        /// Generates the login history report.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-login-history-report/">REST API Reference for CreateLoginHistoryReport Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> CreateLoginHistoryReportWithHttpInfo();
        /// <summary>
        /// Get login history
        /// </summary>
        /// <remarks>
        /// Returns all the latest user login activity, including successful logins and error logs.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-last-login-events/">REST API Reference for GetLastLoginEvents Operation</seealso>
        /// <returns>LoginEventArrayWrapper</returns>
        LoginEventArrayWrapper GetLastLoginEvents();

        /// <summary>
        /// Get login history
        /// </summary>
        /// <remarks>
        /// Returns all the latest user login activity, including successful logins and error logs.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-last-login-events/">REST API Reference for GetLastLoginEvents Operation</seealso>
        /// <returns>ApiResponse of LoginEventArrayWrapper</returns>
        ApiResponse<LoginEventArrayWrapper> GetLastLoginEventsWithHttpInfo();
        /// <summary>
        /// Get filtered login events
        /// </summary>
        /// <remarks>
        /// Returns a list of the login events by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user whose login events are being queried. (optional)</param>
        /// <param name="action">The login-related action to filter events by. (optional)</param>
        /// <param name="from">The starting date and time for filtering login events. (optional)</param>
        /// <param name="to">The ending date and time for filtering login events. (optional)</param>
        /// <param name="count">The number of login events to retrieve in the query. (optional)</param>
        /// <param name="startIndex">The starting index for fetching a subset of login events from the query results. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-login-events-by-filter/">REST API Reference for GetLoginEventsByFilter Operation</seealso>
        /// <returns>LoginEventArrayWrapper</returns>
        LoginEventArrayWrapper GetLoginEventsByFilter(Guid? userId = default, MessageAction? action = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default, string fields = default);

        /// <summary>
        /// Get filtered login events
        /// </summary>
        /// <remarks>
        /// Returns a list of the login events by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user whose login events are being queried. (optional)</param>
        /// <param name="action">The login-related action to filter events by. (optional)</param>
        /// <param name="from">The starting date and time for filtering login events. (optional)</param>
        /// <param name="to">The ending date and time for filtering login events. (optional)</param>
        /// <param name="count">The number of login events to retrieve in the query. (optional)</param>
        /// <param name="startIndex">The starting index for fetching a subset of login events from the query results. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-login-events-by-filter/">REST API Reference for GetLoginEventsByFilter Operation</seealso>
        /// <returns>ApiResponse of LoginEventArrayWrapper</returns>
        ApiResponse<LoginEventArrayWrapper> GetLoginEventsByFilterWithHttpInfo(Guid? userId = default, MessageAction? action = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default, string fields = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISecurityLoginHistoryApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Generate the login history report
        /// </summary>
        /// <remarks>
        /// Generates the login history report.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-login-history-report/">REST API Reference for CreateLoginHistoryReport Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> CreateLoginHistoryReportAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate the login history report
        /// </summary>
        /// <remarks>
        /// Generates the login history report.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-login-history-report/">REST API Reference for CreateLoginHistoryReport Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> CreateLoginHistoryReportWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get login history
        /// </summary>
        /// <remarks>
        /// Returns all the latest user login activity, including successful logins and error logs.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-last-login-events/">REST API Reference for GetLastLoginEvents Operation</seealso>
        /// <returns>Task of LoginEventArrayWrapper</returns>
        Task<LoginEventArrayWrapper> GetLastLoginEventsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get login history
        /// </summary>
        /// <remarks>
        /// Returns all the latest user login activity, including successful logins and error logs.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-last-login-events/">REST API Reference for GetLastLoginEvents Operation</seealso>
        /// <returns>Task of ApiResponse (LoginEventArrayWrapper)</returns>
        Task<ApiResponse<LoginEventArrayWrapper>> GetLastLoginEventsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get filtered login events
        /// </summary>
        /// <remarks>
        /// Returns a list of the login events by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user whose login events are being queried. (optional)</param>
        /// <param name="action">The login-related action to filter events by. (optional)</param>
        /// <param name="from">The starting date and time for filtering login events. (optional)</param>
        /// <param name="to">The ending date and time for filtering login events. (optional)</param>
        /// <param name="count">The number of login events to retrieve in the query. (optional)</param>
        /// <param name="startIndex">The starting index for fetching a subset of login events from the query results. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-login-events-by-filter/">REST API Reference for GetLoginEventsByFilter Operation</seealso>
        /// <returns>Task of LoginEventArrayWrapper</returns>
        Task<LoginEventArrayWrapper> GetLoginEventsByFilterAsync(Guid? userId = default, MessageAction? action = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default, string fields = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get filtered login events
        /// </summary>
        /// <remarks>
        /// Returns a list of the login events by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user whose login events are being queried. (optional)</param>
        /// <param name="action">The login-related action to filter events by. (optional)</param>
        /// <param name="from">The starting date and time for filtering login events. (optional)</param>
        /// <param name="to">The ending date and time for filtering login events. (optional)</param>
        /// <param name="count">The number of login events to retrieve in the query. (optional)</param>
        /// <param name="startIndex">The starting index for fetching a subset of login events from the query results. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-login-events-by-filter/">REST API Reference for GetLoginEventsByFilter Operation</seealso>
        /// <returns>Task of ApiResponse (LoginEventArrayWrapper)</returns>
        Task<ApiResponse<LoginEventArrayWrapper>> GetLoginEventsByFilterWithHttpInfoAsync(Guid? userId = default, MessageAction? action = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default, string fields = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISecurityLoginHistoryApi : ISecurityLoginHistoryApiSync, ISecurityLoginHistoryApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SecurityLoginHistoryApi : IDisposable, ISecurityLoginHistoryApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityLoginHistoryApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public SecurityLoginHistoryApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityLoginHistoryApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public SecurityLoginHistoryApi(string basePath)
        {
            Configuration = DocSpace.Sdk.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            ApiClient = new ApiClient(Configuration.BasePath);
            Client =  ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityLoginHistoryApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public SecurityLoginHistoryApi(Configuration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);

            Configuration = DocSpace.Sdk.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            ApiClient = new ApiClient(Configuration.BasePath);
            Client = ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityLoginHistoryApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public SecurityLoginHistoryApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityLoginHistoryApi"/> class.
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
        public SecurityLoginHistoryApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(client);

            Configuration = DocSpace.Sdk.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            ApiClient = new ApiClient(client, Configuration.BasePath, handler);
            Client =  ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityLoginHistoryApi"/> class using a Configuration object.
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
        public SecurityLoginHistoryApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            ArgumentNullException.ThrowIfNull(client);

            Configuration = DocSpace.Sdk.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            ApiClient = new ApiClient(client, Configuration.BasePath, handler);
            Client = ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityLoginHistoryApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SecurityLoginHistoryApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(client);
            ArgumentNullException.ThrowIfNull(asyncClient);
            ArgumentNullException.ThrowIfNull(configuration);

            Client = client;
            AsynchronousClient = asyncClient;
            Configuration = configuration;
            ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
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
        /// Generate the login history report
        /// </summary>
        /// <remarks>
        /// Generates the login history report.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-login-history-report/">REST API Reference for CreateLoginHistoryReport Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper CreateLoginHistoryReport()
        {
            var localVarResponse = CreateLoginHistoryReportWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Generate the login history report
        /// </summary>
        /// <remarks>
        /// Generates the login history report.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-login-history-report/">REST API Reference for CreateLoginHistoryReport Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> CreateLoginHistoryReportWithHttpInfo()
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
            var localVarResponse = Client.Post<StringWrapper>("/api/2.0/security/audit/login/report", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateLoginHistoryReport", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Generate the login history report
        /// </summary>
        /// <remarks>
        /// Generates the login history report.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-login-history-report/">REST API Reference for CreateLoginHistoryReport Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> CreateLoginHistoryReportAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateLoginHistoryReportWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Generate the login history report
        /// </summary>
        /// <remarks>
        /// Generates the login history report.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-login-history-report/">REST API Reference for CreateLoginHistoryReport Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async Task<ApiResponse<StringWrapper>> CreateLoginHistoryReportWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.PostAsync<StringWrapper>("/api/2.0/security/audit/login/report", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateLoginHistoryReport", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get login history
        /// </summary>
        /// <remarks>
        /// Returns all the latest user login activity, including successful logins and error logs.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-last-login-events/">REST API Reference for GetLastLoginEvents Operation</seealso>
        /// <returns>LoginEventArrayWrapper</returns>
        public LoginEventArrayWrapper GetLastLoginEvents()
        {
            var localVarResponse = GetLastLoginEventsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get login history
        /// </summary>
        /// <remarks>
        /// Returns all the latest user login activity, including successful logins and error logs.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-last-login-events/">REST API Reference for GetLastLoginEvents Operation</seealso>
        /// <returns>ApiResponse of LoginEventArrayWrapper</returns>
        public ApiResponse<LoginEventArrayWrapper> GetLastLoginEventsWithHttpInfo()
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
            var localVarResponse = Client.Get<LoginEventArrayWrapper>("/api/2.0/security/audit/login/last", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetLastLoginEvents", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get login history
        /// </summary>
        /// <remarks>
        /// Returns all the latest user login activity, including successful logins and error logs.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-last-login-events/">REST API Reference for GetLastLoginEvents Operation</seealso>
        /// <returns>Task of LoginEventArrayWrapper</returns>
        public async Task<LoginEventArrayWrapper> GetLastLoginEventsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetLastLoginEventsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get login history
        /// </summary>
        /// <remarks>
        /// Returns all the latest user login activity, including successful logins and error logs.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-last-login-events/">REST API Reference for GetLastLoginEvents Operation</seealso>
        /// <returns>Task of ApiResponse (LoginEventArrayWrapper)</returns>
        public async Task<ApiResponse<LoginEventArrayWrapper>> GetLastLoginEventsWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<LoginEventArrayWrapper>("/api/2.0/security/audit/login/last", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetLastLoginEvents", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get filtered login events
        /// </summary>
        /// <remarks>
        /// Returns a list of the login events by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user whose login events are being queried. (optional)</param>
        /// <param name="action">The login-related action to filter events by. (optional)</param>
        /// <param name="from">The starting date and time for filtering login events. (optional)</param>
        /// <param name="to">The ending date and time for filtering login events. (optional)</param>
        /// <param name="count">The number of login events to retrieve in the query. (optional)</param>
        /// <param name="startIndex">The starting index for fetching a subset of login events from the query results. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-login-events-by-filter/">REST API Reference for GetLoginEventsByFilter Operation</seealso>
        /// <returns>LoginEventArrayWrapper</returns>
        public LoginEventArrayWrapper GetLoginEventsByFilter(Guid? userId = default, MessageAction? action = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default, string fields = default)
        {
            var localVarResponse = GetLoginEventsByFilterWithHttpInfo(userId, action, from, to, count, startIndex, fields);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get filtered login events
        /// </summary>
        /// <remarks>
        /// Returns a list of the login events by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user whose login events are being queried. (optional)</param>
        /// <param name="action">The login-related action to filter events by. (optional)</param>
        /// <param name="from">The starting date and time for filtering login events. (optional)</param>
        /// <param name="to">The ending date and time for filtering login events. (optional)</param>
        /// <param name="count">The number of login events to retrieve in the query. (optional)</param>
        /// <param name="startIndex">The starting index for fetching a subset of login events from the query results. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-login-events-by-filter/">REST API Reference for GetLoginEventsByFilter Operation</seealso>
        /// <returns>ApiResponse of LoginEventArrayWrapper</returns>
        public ApiResponse<LoginEventArrayWrapper> GetLoginEventsByFilterWithHttpInfo(Guid? userId = default, MessageAction? action = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default, string fields = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userId", userId));
            }
            if (action != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "action", action));
            }
            if (from != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "from", from));
            }
            if (to != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "to", to));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (fields != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("csv", "fields", fields));
            }

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
            var localVarResponse = Client.Get<LoginEventArrayWrapper>("/api/2.0/security/audit/login/filter", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetLoginEventsByFilter", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get filtered login events
        /// </summary>
        /// <remarks>
        /// Returns a list of the login events by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user whose login events are being queried. (optional)</param>
        /// <param name="action">The login-related action to filter events by. (optional)</param>
        /// <param name="from">The starting date and time for filtering login events. (optional)</param>
        /// <param name="to">The ending date and time for filtering login events. (optional)</param>
        /// <param name="count">The number of login events to retrieve in the query. (optional)</param>
        /// <param name="startIndex">The starting index for fetching a subset of login events from the query results. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-login-events-by-filter/">REST API Reference for GetLoginEventsByFilter Operation</seealso>
        /// <returns>Task of LoginEventArrayWrapper</returns>
        public async Task<LoginEventArrayWrapper> GetLoginEventsByFilterAsync(Guid? userId = default, MessageAction? action = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default, string fields = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetLoginEventsByFilterWithHttpInfoAsync(userId, action, from, to, count, startIndex, fields, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get filtered login events
        /// </summary>
        /// <remarks>
        /// Returns a list of the login events by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user whose login events are being queried. (optional)</param>
        /// <param name="action">The login-related action to filter events by. (optional)</param>
        /// <param name="from">The starting date and time for filtering login events. (optional)</param>
        /// <param name="to">The ending date and time for filtering login events. (optional)</param>
        /// <param name="count">The number of login events to retrieve in the query. (optional)</param>
        /// <param name="startIndex">The starting index for fetching a subset of login events from the query results. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-login-events-by-filter/">REST API Reference for GetLoginEventsByFilter Operation</seealso>
        /// <returns>Task of ApiResponse (LoginEventArrayWrapper)</returns>
        public async Task<ApiResponse<LoginEventArrayWrapper>> GetLoginEventsByFilterWithHttpInfoAsync(Guid? userId = default, MessageAction? action = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default, string fields = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userId", userId));
            }
            if (action != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "action", action));
            }
            if (from != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "from", from));
            }
            if (to != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "to", to));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (fields != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("csv", "fields", fields));
            }

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

            var localVarResponse = await AsynchronousClient.GetAsync<LoginEventArrayWrapper>("/api/2.0/security/audit/login/filter", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetLoginEventsByFilter", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
