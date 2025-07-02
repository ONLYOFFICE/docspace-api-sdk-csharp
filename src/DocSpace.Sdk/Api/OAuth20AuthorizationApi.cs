// (c) Copyright Ascensio System SIA 2009-2025
// 
// This program is a free software product.
// You can redistribute it and/or modify it under the terms
// of the GNU Affero General Public License (AGPL) version 3 as published by the Free Software
// Foundation. In accordance with Section 7(a) of the GNU AGPL its Section 15 shall be amended
// to the effect that Ascensio System SIA expressly excludes the warranty of non-infringement of
// any third-party rights.
// 
// This program is distributed WITHOUT ANY WARRANTY, without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR  PURPOSE. For details, see
// the GNU AGPL at: http://www.gnu.org/licenses/agpl-3.0.html
// 
// You can contact Ascensio System SIA at Lubanas st. 125a-25, Riga, Latvia, EU, LV-1021.
// 
// The  interactive user interfaces in modified source and object code versions of the Program must
// display Appropriate Legal Notices, as required under Section 5 of the GNU AGPL version 3.
// 
// Pursuant to Section 7(b) of the License you must retain the original Product logo when
// distributing the program. Pursuant to Section 7(e) we decline to grant you any rights under
// trademark law for use of our trademarks.
// 
// All the Product's GUI elements, including illustrations and icon sets, as well as technical writing
// content are licensed under the terms of the Creative Commons Attribution-ShareAlike 4.0
// International. See the License terms at http://creativecommons.org/licenses/by-sa/4.0/legalcode


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using DocSpace.Sdk.Client;
using DocSpace.Sdk.Model;

namespace DocSpace.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOAuth20AuthorizationApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// OAuth2 authorization endpoint
        /// </summary>
        /// <remarks>
        /// Initiates the OAuth2 authorization flow.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
    public interface IOAuth20AuthorizationApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// OAuth2 authorization endpoint
        /// </summary>
        /// <remarks>
        /// Initiates the OAuth2 authorization flow.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseType">The OAuth 2.0 response type, must be &#39;code&#39; for authorization code flow.</param>
        /// <param name="clientId">The client identifier issued to the client during registration.</param>
        /// <param name="redirectUri">The URL to redirect to after authorization is complete.</param>
        /// <param name="scope">The space-separated list of requested scope permissions.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authorize-o-auth/">REST API Reference for AuthorizeOAuth Operation</seealso>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AuthorizeOAuthAsync(string responseType, string clientId, string redirectUri, string scope, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// OAuth2 authorization endpoint
        /// </summary>
        /// <remarks>
        /// Initiates the OAuth2 authorization flow.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseType">The OAuth 2.0 response type, must be &#39;code&#39; for authorization code flow.</param>
        /// <param name="clientId">The client identifier issued to the client during registration.</param>
        /// <param name="redirectUri">The URL to redirect to after authorization is complete.</param>
        /// <param name="scope">The space-separated list of requested scope permissions.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authorize-o-auth/">REST API Reference for AuthorizeOAuth Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AuthorizeOAuthWithHttpInfoAsync(string responseType, string clientId, string redirectUri, string scope, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// OAuth2 token endpoint
        /// </summary>
        /// <remarks>
        /// Exchanges an authorization code specified in the request for the access token.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">The OAuth2 grant type, must be &#39;authorization_code&#39; for the authorization code flow. (optional)</param>
        /// <param name="code">A temporary authorization code that is sent to the client to be exchanged for a token. (optional)</param>
        /// <param name="redirectUri">The URL where the user will be redirected after successful or unsuccessful authentication. (optional)</param>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="clientSecret">The client secret issued to the client during registration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/exchange-token/">REST API Reference for ExchangeToken Operation</seealso>
        /// <returns>Task of ExchangeToken200Response</returns>
        System.Threading.Tasks.Task<ExchangeToken200Response> ExchangeTokenAsync(string? grantType = default, string? code = default, string? redirectUri = default, string? clientId = default, string? clientSecret = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// OAuth2 token endpoint
        /// </summary>
        /// <remarks>
        /// Exchanges an authorization code specified in the request for the access token.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">The OAuth2 grant type, must be &#39;authorization_code&#39; for the authorization code flow. (optional)</param>
        /// <param name="code">A temporary authorization code that is sent to the client to be exchanged for a token. (optional)</param>
        /// <param name="redirectUri">The URL where the user will be redirected after successful or unsuccessful authentication. (optional)</param>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="clientSecret">The client secret issued to the client during registration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/exchange-token/">REST API Reference for ExchangeToken Operation</seealso>
        /// <returns>Task of ApiResponse (ExchangeToken200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExchangeToken200Response>> ExchangeTokenWithHttpInfoAsync(string? grantType = default, string? code = default, string? redirectUri = default, string? clientId = default, string? clientSecret = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// OAuth2 consent endpoint
        /// </summary>
        /// <remarks>
        /// Sends a consent request with the specified parameters.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="state">The random string used to solve the CSRF vulnerability problem. (optional)</param>
        /// <param name="scope">The space-separated list of requested scope permissions. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/submit-consent/">REST API Reference for SubmitConsent Operation</seealso>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SubmitConsentAsync(string? clientId = default, string? state = default, string? scope = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// OAuth2 consent endpoint
        /// </summary>
        /// <remarks>
        /// Sends a consent request with the specified parameters.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="state">The random string used to solve the CSRF vulnerability problem. (optional)</param>
        /// <param name="scope">The space-separated list of requested scope permissions. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/submit-consent/">REST API Reference for SubmitConsent Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SubmitConsentWithHttpInfoAsync(string? clientId = default, string? state = default, string? scope = default, System.Threading.CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOAuth20AuthorizationApi : IOAuth20AuthorizationApiSync, IOAuth20AuthorizationApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OAuth20AuthorizationApi : IDisposable, IOAuth20AuthorizationApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth20AuthorizationApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public OAuth20AuthorizationApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth20AuthorizationApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public OAuth20AuthorizationApi(string basePath)
        {
            this.Configuration = DocSpace.Sdk.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            this.ApiClient = new ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth20AuthorizationApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public OAuth20AuthorizationApi(Configuration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);

            this.Configuration = DocSpace.Sdk.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth20AuthorizationApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public OAuth20AuthorizationApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth20AuthorizationApi"/> class.
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
        public OAuth20AuthorizationApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(client);

            this.Configuration = DocSpace.Sdk.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            this.ApiClient = new ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth20AuthorizationApi"/> class using a Configuration object.
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
        public OAuth20AuthorizationApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            ArgumentNullException.ThrowIfNull(client);

            this.Configuration = DocSpace.Sdk.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth20AuthorizationApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public OAuth20AuthorizationApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(client);
            ArgumentNullException.ThrowIfNull(asyncClient);
            ArgumentNullException.ThrowIfNull(configuration);

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient.Dispose();
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
            return this.Configuration.BasePath;
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
        /// OAuth2 authorization endpoint Initiates the OAuth2 authorization flow.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// OAuth2 authorization endpoint Initiates the OAuth2 authorization flow.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
                throw new ApiException(400, "Missing required parameter 'responseType' when calling OAuth20AuthorizationApi->AuthorizeOAuth");

            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuth20AuthorizationApi->AuthorizeOAuth");

            // verify the required parameter 'redirectUri' is set
            if (redirectUri == null)
                throw new ApiException(400, "Missing required parameter 'redirectUri' when calling OAuth20AuthorizationApi->AuthorizeOAuth");

            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling OAuth20AuthorizationApi->AuthorizeOAuth");

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
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/oauth2/authorize", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("AuthorizeOAuth", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// OAuth2 authorization endpoint Initiates the OAuth2 authorization flow.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseType">The OAuth 2.0 response type, must be &#39;code&#39; for authorization code flow.</param>
        /// <param name="clientId">The client identifier issued to the client during registration.</param>
        /// <param name="redirectUri">The URL to redirect to after authorization is complete.</param>
        /// <param name="scope">The space-separated list of requested scope permissions.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authorize-o-auth/">REST API Reference for AuthorizeOAuth Operation</seealso>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AuthorizeOAuthAsync(string responseType, string clientId, string redirectUri, string scope, System.Threading.CancellationToken cancellationToken = default)
        {
            await AuthorizeOAuthWithHttpInfoAsync(responseType, clientId, redirectUri, scope, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// OAuth2 authorization endpoint Initiates the OAuth2 authorization flow.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseType">The OAuth 2.0 response type, must be &#39;code&#39; for authorization code flow.</param>
        /// <param name="clientId">The client identifier issued to the client during registration.</param>
        /// <param name="redirectUri">The URL to redirect to after authorization is complete.</param>
        /// <param name="scope">The space-separated list of requested scope permissions.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authorize-o-auth/">REST API Reference for AuthorizeOAuth Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AuthorizeOAuthWithHttpInfoAsync(string responseType, string clientId, string redirectUri, string scope, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'responseType' is set
            if (responseType == null)
                throw new ApiException(400, "Missing required parameter 'responseType' when calling OAuth20AuthorizationApi->AuthorizeOAuth");

            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuth20AuthorizationApi->AuthorizeOAuth");

            // verify the required parameter 'redirectUri' is set
            if (redirectUri == null)
                throw new ApiException(400, "Missing required parameter 'redirectUri' when calling OAuth20AuthorizationApi->AuthorizeOAuth");

            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling OAuth20AuthorizationApi->AuthorizeOAuth");


            RequestOptions localVarRequestOptions = new RequestOptions();

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
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/oauth2/authorize", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("AuthorizeOAuth", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// OAuth2 token endpoint Exchanges an authorization code specified in the request for the access token.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// OAuth2 token endpoint Exchanges an authorization code specified in the request for the access token.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
            var localVarResponse = this.Client.Post<ExchangeToken200Response>("/oauth2/token", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("ExchangeToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// OAuth2 token endpoint Exchanges an authorization code specified in the request for the access token.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">The OAuth2 grant type, must be &#39;authorization_code&#39; for the authorization code flow. (optional)</param>
        /// <param name="code">A temporary authorization code that is sent to the client to be exchanged for a token. (optional)</param>
        /// <param name="redirectUri">The URL where the user will be redirected after successful or unsuccessful authentication. (optional)</param>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="clientSecret">The client secret issued to the client during registration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/exchange-token/">REST API Reference for ExchangeToken Operation</seealso>
        /// <returns>Task of ExchangeToken200Response</returns>
        public async System.Threading.Tasks.Task<ExchangeToken200Response> ExchangeTokenAsync(string? grantType = default, string? code = default, string? redirectUri = default, string? clientId = default, string? clientSecret = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ExchangeToken200Response> localVarResponse = await ExchangeTokenWithHttpInfoAsync(grantType, code, redirectUri, clientId, clientSecret, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// OAuth2 token endpoint Exchanges an authorization code specified in the request for the access token.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">The OAuth2 grant type, must be &#39;authorization_code&#39; for the authorization code flow. (optional)</param>
        /// <param name="code">A temporary authorization code that is sent to the client to be exchanged for a token. (optional)</param>
        /// <param name="redirectUri">The URL where the user will be redirected after successful or unsuccessful authentication. (optional)</param>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="clientSecret">The client secret issued to the client during registration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/exchange-token/">REST API Reference for ExchangeToken Operation</seealso>
        /// <returns>Task of ApiResponse (ExchangeToken200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExchangeToken200Response>> ExchangeTokenWithHttpInfoAsync(string? grantType = default, string? code = default, string? redirectUri = default, string? clientId = default, string? clientSecret = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/x-www-form-urlencoded"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (grantType != null)
            {
                localVarRequestOptions.FormParameters.Add("grant_type", DocSpace.Sdk.Client.ClientUtils.ParameterToString(grantType)); // form parameter
            }
            if (code != null)
            {
                localVarRequestOptions.FormParameters.Add("code", DocSpace.Sdk.Client.ClientUtils.ParameterToString(code)); // form parameter
            }
            if (redirectUri != null)
            {
                localVarRequestOptions.FormParameters.Add("redirect_uri", DocSpace.Sdk.Client.ClientUtils.ParameterToString(redirectUri)); // form parameter
            }
            if (clientId != null)
            {
                localVarRequestOptions.FormParameters.Add("client_id", DocSpace.Sdk.Client.ClientUtils.ParameterToString(clientId)); // form parameter
            }
            if (clientSecret != null)
            {
                localVarRequestOptions.FormParameters.Add("client_secret", DocSpace.Sdk.Client.ClientUtils.ParameterToString(clientSecret)); // form parameter
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<ExchangeToken200Response>("/oauth2/token", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("ExchangeToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// OAuth2 consent endpoint Sends a consent request with the specified parameters.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// OAuth2 consent endpoint Sends a consent request with the specified parameters.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/oauth2/authorize", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SubmitConsent", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// OAuth2 consent endpoint Sends a consent request with the specified parameters.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="state">The random string used to solve the CSRF vulnerability problem. (optional)</param>
        /// <param name="scope">The space-separated list of requested scope permissions. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/submit-consent/">REST API Reference for SubmitConsent Operation</seealso>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SubmitConsentAsync(string? clientId = default, string? state = default, string? scope = default, System.Threading.CancellationToken cancellationToken = default)
        {
            await SubmitConsentWithHttpInfoAsync(clientId, state, scope, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// OAuth2 consent endpoint Sends a consent request with the specified parameters.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier issued to the client during registration. (optional)</param>
        /// <param name="state">The random string used to solve the CSRF vulnerability problem. (optional)</param>
        /// <param name="scope">The space-separated list of requested scope permissions. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/submit-consent/">REST API Reference for SubmitConsent Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SubmitConsentWithHttpInfoAsync(string? clientId = default, string? state = default, string? scope = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = [];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (clientId != null)
            {
                localVarRequestOptions.FormParameters.Add("client_id", DocSpace.Sdk.Client.ClientUtils.ParameterToString(clientId)); // form parameter
            }
            if (state != null)
            {
                localVarRequestOptions.FormParameters.Add("state", DocSpace.Sdk.Client.ClientUtils.ParameterToString(state)); // form parameter
            }
            if (scope != null)
            {
                localVarRequestOptions.FormParameters.Add("scope", DocSpace.Sdk.Client.ClientUtils.ParameterToString(scope)); // form parameter
            }

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/oauth2/authorize", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SubmitConsent", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

    }
}
