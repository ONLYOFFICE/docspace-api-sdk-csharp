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
namespace DocSpace.API.SDK.Api.OAuth20
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthorizationApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// OAuth2 authorization endpoint
        /// </summary>
        /// <remarks>
        /// Initiates the OAuth2 authorization flow.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseType">The OAuth 2.0 response type, must be &#39;code&#39; for authorization code flow.</param>
        /// <param name="clientId">The client identifier issued to the client during registration.</param>
        /// <param name="redirectUri">The URL to redirect to after authorization is complete.</param>
        /// <param name="scope">The space-separated list of requested scope permissions.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authorize-o-auth/">REST API Reference for AuthorizeOAuth Operation</seealso>
        /// <returns></returns>
        void AuthorizeOAuth(string responseType, string clientId, string redirectUri, string scope);

        /// <summary>
        /// OAuth2 authorization endpoint
        /// </summary>
        /// <remarks>
        /// Initiates the OAuth2 authorization flow.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseType">The OAuth 2.0 response type, must be &#39;code&#39; for authorization code flow.</param>
        /// <param name="clientId">The client identifier issued to the client during registration.</param>
        /// <param name="redirectUri">The URL to redirect to after authorization is complete.</param>
        /// <param name="scope">The space-separated list of requested scope permissions.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authorize-o-auth/">REST API Reference for AuthorizeOAuth Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AuthorizeOAuthWithHttpInfo(string responseType, string clientId, string redirectUri, string scope);
        /// <summary>
        /// OAuth2 token endpoint
        /// </summary>
        /// <remarks>
        /// Exchanges an authorization code specified in the request for the access token.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">The OAuth2 grant type, must be &#39;authorization_code&#39; for the authorization code flow. (optional)</param>
        /// <param name="code">A temporary authorization code that is sent to the client to be exchanged for a token. (optional)</param>
        /// <param name="redirectUri">The URL where the user will be redirected after successful or unsuccessful authentication. (optional)</param>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="clientSecret">The client secret issued to the client during registration. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/exchange-token/">REST API Reference for ExchangeToken Operation</seealso>
        /// <returns>ExchangeToken200Response</returns>
        ExchangeToken200Response ExchangeToken(string? grantType = default, string? code = default, string? redirectUri = default, string? clientId = default, string? clientSecret = default);

        /// <summary>
        /// OAuth2 token endpoint
        /// </summary>
        /// <remarks>
        /// Exchanges an authorization code specified in the request for the access token.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">The OAuth2 grant type, must be &#39;authorization_code&#39; for the authorization code flow. (optional)</param>
        /// <param name="code">A temporary authorization code that is sent to the client to be exchanged for a token. (optional)</param>
        /// <param name="redirectUri">The URL where the user will be redirected after successful or unsuccessful authentication. (optional)</param>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="clientSecret">The client secret issued to the client during registration. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/exchange-token/">REST API Reference for ExchangeToken Operation</seealso>
        /// <returns>ApiResponse of ExchangeToken200Response</returns>
        ApiResponse<ExchangeToken200Response> ExchangeTokenWithHttpInfo(string? grantType = default, string? code = default, string? redirectUri = default, string? clientId = default, string? clientSecret = default);
        /// <summary>
        /// OAuth2 consent endpoint
        /// </summary>
        /// <remarks>
        /// Sends a consent request with the specified parameters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="state">The random string used to solve the CSRF vulnerability problem. (optional)</param>
        /// <param name="scope">The space-separated list of requested scope permissions. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/submit-consent/">REST API Reference for SubmitConsent Operation</seealso>
        /// <returns></returns>
        void SubmitConsent(string? clientId = default, string? state = default, string? scope = default);

        /// <summary>
        /// OAuth2 consent endpoint
        /// </summary>
        /// <remarks>
        /// Sends a consent request with the specified parameters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="state">The random string used to solve the CSRF vulnerability problem. (optional)</param>
        /// <param name="scope">The space-separated list of requested scope permissions. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/submit-consent/">REST API Reference for SubmitConsent Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SubmitConsentWithHttpInfo(string? clientId = default, string? state = default, string? scope = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthorizationApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// OAuth2 authorization endpoint
        /// </summary>
        /// <remarks>
        /// Initiates the OAuth2 authorization flow.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseType">The OAuth 2.0 response type, must be &#39;code&#39; for authorization code flow.</param>
        /// <param name="clientId">The client identifier issued to the client during registration.</param>
        /// <param name="redirectUri">The URL to redirect to after authorization is complete.</param>
        /// <param name="scope">The space-separated list of requested scope permissions.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authorize-o-auth/">REST API Reference for AuthorizeOAuth Operation</seealso>
        /// <returns>Task of void</returns>
        Task AuthorizeOAuthAsync(string responseType, string clientId, string redirectUri, string scope, CancellationToken cancellationToken = default);

        /// <summary>
        /// OAuth2 authorization endpoint
        /// </summary>
        /// <remarks>
        /// Initiates the OAuth2 authorization flow.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseType">The OAuth 2.0 response type, must be &#39;code&#39; for authorization code flow.</param>
        /// <param name="clientId">The client identifier issued to the client during registration.</param>
        /// <param name="redirectUri">The URL to redirect to after authorization is complete.</param>
        /// <param name="scope">The space-separated list of requested scope permissions.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authorize-o-auth/">REST API Reference for AuthorizeOAuth Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> AuthorizeOAuthWithHttpInfoAsync(string responseType, string clientId, string redirectUri, string scope, CancellationToken cancellationToken = default);
        /// <summary>
        /// OAuth2 token endpoint
        /// </summary>
        /// <remarks>
        /// Exchanges an authorization code specified in the request for the access token.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">The OAuth2 grant type, must be &#39;authorization_code&#39; for the authorization code flow. (optional)</param>
        /// <param name="code">A temporary authorization code that is sent to the client to be exchanged for a token. (optional)</param>
        /// <param name="redirectUri">The URL where the user will be redirected after successful or unsuccessful authentication. (optional)</param>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="clientSecret">The client secret issued to the client during registration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/exchange-token/">REST API Reference for ExchangeToken Operation</seealso>
        /// <returns>Task of ExchangeToken200Response</returns>
        Task<ExchangeToken200Response> ExchangeTokenAsync(string? grantType = default, string? code = default, string? redirectUri = default, string? clientId = default, string? clientSecret = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// OAuth2 token endpoint
        /// </summary>
        /// <remarks>
        /// Exchanges an authorization code specified in the request for the access token.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">The OAuth2 grant type, must be &#39;authorization_code&#39; for the authorization code flow. (optional)</param>
        /// <param name="code">A temporary authorization code that is sent to the client to be exchanged for a token. (optional)</param>
        /// <param name="redirectUri">The URL where the user will be redirected after successful or unsuccessful authentication. (optional)</param>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="clientSecret">The client secret issued to the client during registration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/exchange-token/">REST API Reference for ExchangeToken Operation</seealso>
        /// <returns>Task of ApiResponse (ExchangeToken200Response)</returns>
        Task<ApiResponse<ExchangeToken200Response>> ExchangeTokenWithHttpInfoAsync(string? grantType = default, string? code = default, string? redirectUri = default, string? clientId = default, string? clientSecret = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// OAuth2 consent endpoint
        /// </summary>
        /// <remarks>
        /// Sends a consent request with the specified parameters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="state">The random string used to solve the CSRF vulnerability problem. (optional)</param>
        /// <param name="scope">The space-separated list of requested scope permissions. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/submit-consent/">REST API Reference for SubmitConsent Operation</seealso>
        /// <returns>Task of void</returns>
        Task SubmitConsentAsync(string? clientId = default, string? state = default, string? scope = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// OAuth2 consent endpoint
        /// </summary>
        /// <remarks>
        /// Sends a consent request with the specified parameters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="state">The random string used to solve the CSRF vulnerability problem. (optional)</param>
        /// <param name="scope">The space-separated list of requested scope permissions. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/submit-consent/">REST API Reference for SubmitConsent Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> SubmitConsentWithHttpInfoAsync(string? clientId = default, string? state = default, string? scope = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthorizationApi : IAuthorizationApiSync, IAuthorizationApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuthorizationApi : IDisposable, IAuthorizationApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public AuthorizationApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public AuthorizationApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AuthorizationApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public AuthorizationApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AuthorizationApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public AuthorizationApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationApi"/> class.
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
        public AuthorizationApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="AuthorizationApi"/> class using a Configuration object.
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
        public AuthorizationApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="AuthorizationApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public AuthorizationApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// OAuth2 authorization endpoint
        /// </summary>
        /// <remarks>
        /// Initiates the OAuth2 authorization flow.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseType">The OAuth 2.0 response type, must be &#39;code&#39; for authorization code flow.</param>
        /// <param name="clientId">The client identifier issued to the client during registration.</param>
        /// <param name="redirectUri">The URL to redirect to after authorization is complete.</param>
        /// <param name="scope">The space-separated list of requested scope permissions.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authorize-o-auth/">REST API Reference for AuthorizeOAuth Operation</seealso>
        /// <returns></returns>
        public void AuthorizeOAuth(string responseType, string clientId, string redirectUri, string scope)
        {
            AuthorizeOAuthWithHttpInfo(responseType, clientId, redirectUri, scope);
        }

        /// <summary>
        /// OAuth2 authorization endpoint
        /// </summary>
        /// <remarks>
        /// Initiates the OAuth2 authorization flow.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseType">The OAuth 2.0 response type, must be &#39;code&#39; for authorization code flow.</param>
        /// <param name="clientId">The client identifier issued to the client during registration.</param>
        /// <param name="redirectUri">The URL to redirect to after authorization is complete.</param>
        /// <param name="scope">The space-separated list of requested scope permissions.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authorize-o-auth/">REST API Reference for AuthorizeOAuth Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AuthorizeOAuthWithHttpInfo(string responseType, string clientId, string redirectUri, string scope)
        {
            // verify the required parameter 'responseType' is set
            if (responseType == null)
                throw new ApiException(400, "Missing required parameter 'responseType' when calling AuthorizationApi->AuthorizeOAuth");

            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling AuthorizationApi->AuthorizeOAuth");

            // verify the required parameter 'redirectUri' is set
            if (redirectUri == null)
                throw new ApiException(400, "Missing required parameter 'redirectUri' when calling AuthorizationApi->AuthorizeOAuth");

            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling AuthorizationApi->AuthorizeOAuth");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "response_type", responseType));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "client_id", clientId));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "redirect_uri", redirectUri));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "scope", scope));

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request
            var localVarResponse = Client.Get<Object>("/oauth2/authorize", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AuthorizeOAuth", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// OAuth2 authorization endpoint
        /// </summary>
        /// <remarks>
        /// Initiates the OAuth2 authorization flow.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseType">The OAuth 2.0 response type, must be &#39;code&#39; for authorization code flow.</param>
        /// <param name="clientId">The client identifier issued to the client during registration.</param>
        /// <param name="redirectUri">The URL to redirect to after authorization is complete.</param>
        /// <param name="scope">The space-separated list of requested scope permissions.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authorize-o-auth/">REST API Reference for AuthorizeOAuth Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task AuthorizeOAuthAsync(string responseType, string clientId, string redirectUri, string scope, CancellationToken cancellationToken = default)
        {
            await AuthorizeOAuthWithHttpInfoAsync(responseType, clientId, redirectUri, scope, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// OAuth2 authorization endpoint
        /// </summary>
        /// <remarks>
        /// Initiates the OAuth2 authorization flow.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseType">The OAuth 2.0 response type, must be &#39;code&#39; for authorization code flow.</param>
        /// <param name="clientId">The client identifier issued to the client during registration.</param>
        /// <param name="redirectUri">The URL to redirect to after authorization is complete.</param>
        /// <param name="scope">The space-separated list of requested scope permissions.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authorize-o-auth/">REST API Reference for AuthorizeOAuth Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> AuthorizeOAuthWithHttpInfoAsync(string responseType, string clientId, string redirectUri, string scope, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'responseType' is set
            if (responseType == null)
                throw new ApiException(400, "Missing required parameter 'responseType' when calling AuthorizationApi->AuthorizeOAuth");

            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling AuthorizationApi->AuthorizeOAuth");

            // verify the required parameter 'redirectUri' is set
            if (redirectUri == null)
                throw new ApiException(400, "Missing required parameter 'redirectUri' when calling AuthorizationApi->AuthorizeOAuth");

            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling AuthorizationApi->AuthorizeOAuth");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "response_type", responseType));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "client_id", clientId));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "redirect_uri", redirectUri));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "scope", scope));

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<Object>("/oauth2/authorize", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AuthorizeOAuth", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// OAuth2 token endpoint
        /// </summary>
        /// <remarks>
        /// Exchanges an authorization code specified in the request for the access token.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">The OAuth2 grant type, must be &#39;authorization_code&#39; for the authorization code flow. (optional)</param>
        /// <param name="code">A temporary authorization code that is sent to the client to be exchanged for a token. (optional)</param>
        /// <param name="redirectUri">The URL where the user will be redirected after successful or unsuccessful authentication. (optional)</param>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="clientSecret">The client secret issued to the client during registration. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/exchange-token/">REST API Reference for ExchangeToken Operation</seealso>
        /// <returns>ExchangeToken200Response</returns>
        public ExchangeToken200Response ExchangeToken(string? grantType = default, string? code = default, string? redirectUri = default, string? clientId = default, string? clientSecret = default)
        {
            var localVarResponse = ExchangeTokenWithHttpInfo(grantType, code, redirectUri, clientId, clientSecret);
            return localVarResponse.Data;
        }

        /// <summary>
        /// OAuth2 token endpoint
        /// </summary>
        /// <remarks>
        /// Exchanges an authorization code specified in the request for the access token.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">The OAuth2 grant type, must be &#39;authorization_code&#39; for the authorization code flow. (optional)</param>
        /// <param name="code">A temporary authorization code that is sent to the client to be exchanged for a token. (optional)</param>
        /// <param name="redirectUri">The URL where the user will be redirected after successful or unsuccessful authentication. (optional)</param>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="clientSecret">The client secret issued to the client during registration. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/exchange-token/">REST API Reference for ExchangeToken Operation</seealso>
        /// <returns>ApiResponse of ExchangeToken200Response</returns>
        public ApiResponse<ExchangeToken200Response> ExchangeTokenWithHttpInfo(string? grantType = default, string? code = default, string? redirectUri = default, string? clientId = default, string? clientSecret = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/x-www-form-urlencoded"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (grantType != null)
            {
                localVarRequestOptions.FormParameters.Add("grant_type",ClientUtils.ParameterToString(grantType)); // form parameter
            }
            if (code != null)
            {
                localVarRequestOptions.FormParameters.Add("code",ClientUtils.ParameterToString(code)); // form parameter
            }
            if (redirectUri != null)
            {
                localVarRequestOptions.FormParameters.Add("redirect_uri",ClientUtils.ParameterToString(redirectUri)); // form parameter
            }
            if (clientId != null)
            {
                localVarRequestOptions.FormParameters.Add("client_id",ClientUtils.ParameterToString(clientId)); // form parameter
            }
            if (clientSecret != null)
            {
                localVarRequestOptions.FormParameters.Add("client_secret",ClientUtils.ParameterToString(clientSecret)); // form parameter
            }


            // make the HTTP request
            var localVarResponse = Client.Post<ExchangeToken200Response>("/oauth2/token", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ExchangeToken", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// OAuth2 token endpoint
        /// </summary>
        /// <remarks>
        /// Exchanges an authorization code specified in the request for the access token.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">The OAuth2 grant type, must be &#39;authorization_code&#39; for the authorization code flow. (optional)</param>
        /// <param name="code">A temporary authorization code that is sent to the client to be exchanged for a token. (optional)</param>
        /// <param name="redirectUri">The URL where the user will be redirected after successful or unsuccessful authentication. (optional)</param>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="clientSecret">The client secret issued to the client during registration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/exchange-token/">REST API Reference for ExchangeToken Operation</seealso>
        /// <returns>Task of ExchangeToken200Response</returns>
        public async Task<ExchangeToken200Response> ExchangeTokenAsync(string? grantType = default, string? code = default, string? redirectUri = default, string? clientId = default, string? clientSecret = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ExchangeTokenWithHttpInfoAsync(grantType, code, redirectUri, clientId, clientSecret, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// OAuth2 token endpoint
        /// </summary>
        /// <remarks>
        /// Exchanges an authorization code specified in the request for the access token.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">The OAuth2 grant type, must be &#39;authorization_code&#39; for the authorization code flow. (optional)</param>
        /// <param name="code">A temporary authorization code that is sent to the client to be exchanged for a token. (optional)</param>
        /// <param name="redirectUri">The URL where the user will be redirected after successful or unsuccessful authentication. (optional)</param>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="clientSecret">The client secret issued to the client during registration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/exchange-token/">REST API Reference for ExchangeToken Operation</seealso>
        /// <returns>Task of ApiResponse (ExchangeToken200Response)</returns>
        public async Task<ApiResponse<ExchangeToken200Response>> ExchangeTokenWithHttpInfoAsync(string? grantType = default, string? code = default, string? redirectUri = default, string? clientId = default, string? clientSecret = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/x-www-form-urlencoded"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (grantType != null)
            {
                localVarRequestOptions.FormParameters.Add("grant_type", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(grantType)); // form parameter
            }
            if (code != null)
            {
                localVarRequestOptions.FormParameters.Add("code", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(code)); // form parameter
            }
            if (redirectUri != null)
            {
                localVarRequestOptions.FormParameters.Add("redirect_uri", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(redirectUri)); // form parameter
            }
            if (clientId != null)
            {
                localVarRequestOptions.FormParameters.Add("client_id", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(clientId)); // form parameter
            }
            if (clientSecret != null)
            {
                localVarRequestOptions.FormParameters.Add("client_secret", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(clientSecret)); // form parameter
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<ExchangeToken200Response>("/oauth2/token", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ExchangeToken", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// OAuth2 consent endpoint
        /// </summary>
        /// <remarks>
        /// Sends a consent request with the specified parameters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="state">The random string used to solve the CSRF vulnerability problem. (optional)</param>
        /// <param name="scope">The space-separated list of requested scope permissions. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/submit-consent/">REST API Reference for SubmitConsent Operation</seealso>
        /// <returns></returns>
        public void SubmitConsent(string? clientId = default, string? state = default, string? scope = default)
        {
            SubmitConsentWithHttpInfo(clientId, state, scope);
        }

        /// <summary>
        /// OAuth2 consent endpoint
        /// </summary>
        /// <remarks>
        /// Sends a consent request with the specified parameters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="state">The random string used to solve the CSRF vulnerability problem. (optional)</param>
        /// <param name="scope">The space-separated list of requested scope permissions. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/submit-consent/">REST API Reference for SubmitConsent Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> SubmitConsentWithHttpInfo(string? clientId = default, string? state = default, string? scope = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = [];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (clientId != null)
            {
                localVarRequestOptions.FormParameters.Add("client_id",ClientUtils.ParameterToString(clientId)); // form parameter
            }
            if (state != null)
            {
                localVarRequestOptions.FormParameters.Add("state",ClientUtils.ParameterToString(state)); // form parameter
            }
            if (scope != null)
            {
                localVarRequestOptions.FormParameters.Add("scope",ClientUtils.ParameterToString(scope)); // form parameter
            }

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request
            var localVarResponse = Client.Post<Object>("/oauth2/authorize", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SubmitConsent", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// OAuth2 consent endpoint
        /// </summary>
        /// <remarks>
        /// Sends a consent request with the specified parameters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="state">The random string used to solve the CSRF vulnerability problem. (optional)</param>
        /// <param name="scope">The space-separated list of requested scope permissions. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/submit-consent/">REST API Reference for SubmitConsent Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task SubmitConsentAsync(string? clientId = default, string? state = default, string? scope = default, CancellationToken cancellationToken = default)
        {
            await SubmitConsentWithHttpInfoAsync(clientId, state, scope, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// OAuth2 consent endpoint
        /// </summary>
        /// <remarks>
        /// Sends a consent request with the specified parameters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="state">The random string used to solve the CSRF vulnerability problem. (optional)</param>
        /// <param name="scope">The space-separated list of requested scope permissions. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/submit-consent/">REST API Reference for SubmitConsent Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> SubmitConsentWithHttpInfoAsync(string? clientId = default, string? state = default, string? scope = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = [];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (clientId != null)
            {
                localVarRequestOptions.FormParameters.Add("client_id", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(clientId)); // form parameter
            }
            if (state != null)
            {
                localVarRequestOptions.FormParameters.Add("state", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(state)); // form parameter
            }
            if (scope != null)
            {
                localVarRequestOptions.FormParameters.Add("scope", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(scope)); // form parameter
            }

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<Object>("/oauth2/authorize", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SubmitConsent", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
