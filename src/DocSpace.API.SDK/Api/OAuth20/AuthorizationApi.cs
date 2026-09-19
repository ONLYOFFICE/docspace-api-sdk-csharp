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
namespace DocSpace.API.SDK.Api.OAuth20
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthorizationApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Start the authorization flow
        /// </summary>
        /// <remarks>
        /// Starts the OAuth2 authorization code flow for the client named by client_id. The caller has to present the portal signature cookie, and a request without a valid one is not refused with 401 or 403 but redirected to the portal login page, carrying the client ID so the flow can resume after signing in. When the user has not yet consented to the requested scopes the browser is redirected to the consent page; once the consent exists the browser is redirected to the client's redirect URI with the authorization code and, when one was sent, the original state. A caller that cannot follow redirects may send the X-Disable-Redirect header, and then the response is 200 with an empty body and the target URL in the X-Redirect-URI header. The code returned here is exchanged for tokens at the token endpoint.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseType">The OAuth 2.0 response type. Only code is supported: this server issues an authorization code, never a token, from this endpoint.</param>
        /// <param name="clientId">The identifier the client was given when it was registered. It selects both the client shown on the consent screen and the set of redirect URIs the request is checked against.</param>
        /// <param name="redirectUri">Where to send the user once authorization is complete. It has to be one of the redirect URIs registered for the client, otherwise the request is refused.</param>
        /// <param name="scope">The permissions being asked for, as a space-separated list. Every scope has to be one the client is registered for, and the consent screen lists exactly these.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authorize-o-auth/">REST API Reference for AuthorizeOAuth Operation</seealso>
        /// <returns></returns>
        void AuthorizeOAuth(string responseType, string clientId, string redirectUri, string scope);

        /// <summary>
        /// Start the authorization flow
        /// </summary>
        /// <remarks>
        /// Starts the OAuth2 authorization code flow for the client named by client_id. The caller has to present the portal signature cookie, and a request without a valid one is not refused with 401 or 403 but redirected to the portal login page, carrying the client ID so the flow can resume after signing in. When the user has not yet consented to the requested scopes the browser is redirected to the consent page; once the consent exists the browser is redirected to the client's redirect URI with the authorization code and, when one was sent, the original state. A caller that cannot follow redirects may send the X-Disable-Redirect header, and then the response is 200 with an empty body and the target URL in the X-Redirect-URI header. The code returned here is exchanged for tokens at the token endpoint.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseType">The OAuth 2.0 response type. Only code is supported: this server issues an authorization code, never a token, from this endpoint.</param>
        /// <param name="clientId">The identifier the client was given when it was registered. It selects both the client shown on the consent screen and the set of redirect URIs the request is checked against.</param>
        /// <param name="redirectUri">Where to send the user once authorization is complete. It has to be one of the redirect URIs registered for the client, otherwise the request is refused.</param>
        /// <param name="scope">The permissions being asked for, as a space-separated list. Every scope has to be one the client is registered for, and the consent screen lists exactly these.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authorize-o-auth/">REST API Reference for AuthorizeOAuth Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AuthorizeOAuthWithHttpInfo(string responseType, string clientId, string redirectUri, string scope);
        /// <summary>
        /// Exchange the authorization code
        /// </summary>
        /// <remarks>
        /// Exchanges an authorization code for an access token. The request is form-encoded and has to carry the grant type, the code, the same redirect URI that was used to obtain the code, and the client credentials: the client authenticates itself here rather than through the portal signature cookie the authorization endpoint uses. The response carries the access token, its type and its lifetime in seconds, plus a refresh token when the client is configured for the refresh token grant. Client authentication that fails is answered with 401, while a malformed, unknown or expired code is answered with 400. The code is single use, so replaying it fails.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Which exchange is being performed: authorization_code to redeem a code, refresh_token to renew an access token. (optional)</param>
        /// <param name="code">The authorization code returned by the authorization endpoint. It may be redeemed once. (optional)</param>
        /// <param name="redirectUri">The same redirect URI that was used to obtain the code. The exchange fails when it differs. (optional)</param>
        /// <param name="clientId">The identifier of the client redeeming the code. (optional)</param>
        /// <param name="clientSecret">The secret of the client redeeming the code. It is omitted by a public client, which proves itself with a PKCE code verifier instead. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/exchange-token/">REST API Reference for ExchangeToken Operation</seealso>
        /// <returns>ExchangeToken200Response</returns>
        ExchangeToken200Response ExchangeToken(string? grantType = default, string? code = default, string? redirectUri = default, string? clientId = default, string? clientSecret = default);

        /// <summary>
        /// Exchange the authorization code
        /// </summary>
        /// <remarks>
        /// Exchanges an authorization code for an access token. The request is form-encoded and has to carry the grant type, the code, the same redirect URI that was used to obtain the code, and the client credentials: the client authenticates itself here rather than through the portal signature cookie the authorization endpoint uses. The response carries the access token, its type and its lifetime in seconds, plus a refresh token when the client is configured for the refresh token grant. Client authentication that fails is answered with 401, while a malformed, unknown or expired code is answered with 400. The code is single use, so replaying it fails.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Which exchange is being performed: authorization_code to redeem a code, refresh_token to renew an access token. (optional)</param>
        /// <param name="code">The authorization code returned by the authorization endpoint. It may be redeemed once. (optional)</param>
        /// <param name="redirectUri">The same redirect URI that was used to obtain the code. The exchange fails when it differs. (optional)</param>
        /// <param name="clientId">The identifier of the client redeeming the code. (optional)</param>
        /// <param name="clientSecret">The secret of the client redeeming the code. It is omitted by a public client, which proves itself with a PKCE code verifier instead. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/exchange-token/">REST API Reference for ExchangeToken Operation</seealso>
        /// <returns>ApiResponse of ExchangeToken200Response</returns>
        ApiResponse<ExchangeToken200Response> ExchangeTokenWithHttpInfo(string? grantType = default, string? code = default, string? redirectUri = default, string? clientId = default, string? clientSecret = default);
        /// <summary>
        /// Submit the consent decision
        /// </summary>
        /// <remarks>
        /// Submits the user's consent decision for the scopes an authorization request asked for. It is the form post the consent page makes, so it carries the client ID, the state and the agreed scopes as multipart form data, along with the same portal signature cookie the authorization request needed. On success the browser is redirected to the client's redirect URI with an authorization code, or, when the request carries the X-Disable-Redirect header, answered 200 with that URL in the X-Redirect-URI header. The consent is stored per user and client, so a later authorization request for the same scopes no longer stops at the consent page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client the consent is being given to. It has to be the same client the authorization request named. (optional)</param>
        /// <param name="state">The opaque value carried through from the authorization request, returned unchanged on the redirect so the client can match the answer to its request. (optional)</param>
        /// <param name="scope">The scopes the user agreed to, as a space-separated list. Anything the user declined is left out, so this may be narrower than what was requested. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/submit-consent/">REST API Reference for SubmitConsent Operation</seealso>
        /// <returns></returns>
        void SubmitConsent(string? clientId = default, string? state = default, string? scope = default);

        /// <summary>
        /// Submit the consent decision
        /// </summary>
        /// <remarks>
        /// Submits the user's consent decision for the scopes an authorization request asked for. It is the form post the consent page makes, so it carries the client ID, the state and the agreed scopes as multipart form data, along with the same portal signature cookie the authorization request needed. On success the browser is redirected to the client's redirect URI with an authorization code, or, when the request carries the X-Disable-Redirect header, answered 200 with that URL in the X-Redirect-URI header. The consent is stored per user and client, so a later authorization request for the same scopes no longer stops at the consent page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client the consent is being given to. It has to be the same client the authorization request named. (optional)</param>
        /// <param name="state">The opaque value carried through from the authorization request, returned unchanged on the redirect so the client can match the answer to its request. (optional)</param>
        /// <param name="scope">The scopes the user agreed to, as a space-separated list. Anything the user declined is left out, so this may be narrower than what was requested. (optional)</param>
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
        /// Start the authorization flow
        /// </summary>
        /// <remarks>
        /// Starts the OAuth2 authorization code flow for the client named by client_id. The caller has to present the portal signature cookie, and a request without a valid one is not refused with 401 or 403 but redirected to the portal login page, carrying the client ID so the flow can resume after signing in. When the user has not yet consented to the requested scopes the browser is redirected to the consent page; once the consent exists the browser is redirected to the client's redirect URI with the authorization code and, when one was sent, the original state. A caller that cannot follow redirects may send the X-Disable-Redirect header, and then the response is 200 with an empty body and the target URL in the X-Redirect-URI header. The code returned here is exchanged for tokens at the token endpoint.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseType">The OAuth 2.0 response type. Only code is supported: this server issues an authorization code, never a token, from this endpoint.</param>
        /// <param name="clientId">The identifier the client was given when it was registered. It selects both the client shown on the consent screen and the set of redirect URIs the request is checked against.</param>
        /// <param name="redirectUri">Where to send the user once authorization is complete. It has to be one of the redirect URIs registered for the client, otherwise the request is refused.</param>
        /// <param name="scope">The permissions being asked for, as a space-separated list. Every scope has to be one the client is registered for, and the consent screen lists exactly these.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authorize-o-auth/">REST API Reference for AuthorizeOAuth Operation</seealso>
        /// <returns>Task of void</returns>
        Task AuthorizeOAuthAsync(string responseType, string clientId, string redirectUri, string scope, CancellationToken cancellationToken = default);

        /// <summary>
        /// Start the authorization flow
        /// </summary>
        /// <remarks>
        /// Starts the OAuth2 authorization code flow for the client named by client_id. The caller has to present the portal signature cookie, and a request without a valid one is not refused with 401 or 403 but redirected to the portal login page, carrying the client ID so the flow can resume after signing in. When the user has not yet consented to the requested scopes the browser is redirected to the consent page; once the consent exists the browser is redirected to the client's redirect URI with the authorization code and, when one was sent, the original state. A caller that cannot follow redirects may send the X-Disable-Redirect header, and then the response is 200 with an empty body and the target URL in the X-Redirect-URI header. The code returned here is exchanged for tokens at the token endpoint.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseType">The OAuth 2.0 response type. Only code is supported: this server issues an authorization code, never a token, from this endpoint.</param>
        /// <param name="clientId">The identifier the client was given when it was registered. It selects both the client shown on the consent screen and the set of redirect URIs the request is checked against.</param>
        /// <param name="redirectUri">Where to send the user once authorization is complete. It has to be one of the redirect URIs registered for the client, otherwise the request is refused.</param>
        /// <param name="scope">The permissions being asked for, as a space-separated list. Every scope has to be one the client is registered for, and the consent screen lists exactly these.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authorize-o-auth/">REST API Reference for AuthorizeOAuth Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> AuthorizeOAuthWithHttpInfoAsync(string responseType, string clientId, string redirectUri, string scope, CancellationToken cancellationToken = default);
        /// <summary>
        /// Exchange the authorization code
        /// </summary>
        /// <remarks>
        /// Exchanges an authorization code for an access token. The request is form-encoded and has to carry the grant type, the code, the same redirect URI that was used to obtain the code, and the client credentials: the client authenticates itself here rather than through the portal signature cookie the authorization endpoint uses. The response carries the access token, its type and its lifetime in seconds, plus a refresh token when the client is configured for the refresh token grant. Client authentication that fails is answered with 401, while a malformed, unknown or expired code is answered with 400. The code is single use, so replaying it fails.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Which exchange is being performed: authorization_code to redeem a code, refresh_token to renew an access token. (optional)</param>
        /// <param name="code">The authorization code returned by the authorization endpoint. It may be redeemed once. (optional)</param>
        /// <param name="redirectUri">The same redirect URI that was used to obtain the code. The exchange fails when it differs. (optional)</param>
        /// <param name="clientId">The identifier of the client redeeming the code. (optional)</param>
        /// <param name="clientSecret">The secret of the client redeeming the code. It is omitted by a public client, which proves itself with a PKCE code verifier instead. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/exchange-token/">REST API Reference for ExchangeToken Operation</seealso>
        /// <returns>Task of ExchangeToken200Response</returns>
        Task<ExchangeToken200Response> ExchangeTokenAsync(string? grantType = default, string? code = default, string? redirectUri = default, string? clientId = default, string? clientSecret = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Exchange the authorization code
        /// </summary>
        /// <remarks>
        /// Exchanges an authorization code for an access token. The request is form-encoded and has to carry the grant type, the code, the same redirect URI that was used to obtain the code, and the client credentials: the client authenticates itself here rather than through the portal signature cookie the authorization endpoint uses. The response carries the access token, its type and its lifetime in seconds, plus a refresh token when the client is configured for the refresh token grant. Client authentication that fails is answered with 401, while a malformed, unknown or expired code is answered with 400. The code is single use, so replaying it fails.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Which exchange is being performed: authorization_code to redeem a code, refresh_token to renew an access token. (optional)</param>
        /// <param name="code">The authorization code returned by the authorization endpoint. It may be redeemed once. (optional)</param>
        /// <param name="redirectUri">The same redirect URI that was used to obtain the code. The exchange fails when it differs. (optional)</param>
        /// <param name="clientId">The identifier of the client redeeming the code. (optional)</param>
        /// <param name="clientSecret">The secret of the client redeeming the code. It is omitted by a public client, which proves itself with a PKCE code verifier instead. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/exchange-token/">REST API Reference for ExchangeToken Operation</seealso>
        /// <returns>Task of ApiResponse (ExchangeToken200Response)</returns>
        Task<ApiResponse<ExchangeToken200Response>> ExchangeTokenWithHttpInfoAsync(string? grantType = default, string? code = default, string? redirectUri = default, string? clientId = default, string? clientSecret = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit the consent decision
        /// </summary>
        /// <remarks>
        /// Submits the user's consent decision for the scopes an authorization request asked for. It is the form post the consent page makes, so it carries the client ID, the state and the agreed scopes as multipart form data, along with the same portal signature cookie the authorization request needed. On success the browser is redirected to the client's redirect URI with an authorization code, or, when the request carries the X-Disable-Redirect header, answered 200 with that URL in the X-Redirect-URI header. The consent is stored per user and client, so a later authorization request for the same scopes no longer stops at the consent page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client the consent is being given to. It has to be the same client the authorization request named. (optional)</param>
        /// <param name="state">The opaque value carried through from the authorization request, returned unchanged on the redirect so the client can match the answer to its request. (optional)</param>
        /// <param name="scope">The scopes the user agreed to, as a space-separated list. Anything the user declined is left out, so this may be narrower than what was requested. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/submit-consent/">REST API Reference for SubmitConsent Operation</seealso>
        /// <returns>Task of void</returns>
        Task SubmitConsentAsync(string? clientId = default, string? state = default, string? scope = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Submit the consent decision
        /// </summary>
        /// <remarks>
        /// Submits the user's consent decision for the scopes an authorization request asked for. It is the form post the consent page makes, so it carries the client ID, the state and the agreed scopes as multipart form data, along with the same portal signature cookie the authorization request needed. On success the browser is redirected to the client's redirect URI with an authorization code, or, when the request carries the X-Disable-Redirect header, answered 200 with that URL in the X-Redirect-URI header. The consent is stored per user and client, so a later authorization request for the same scopes no longer stops at the consent page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client the consent is being given to. It has to be the same client the authorization request named. (optional)</param>
        /// <param name="state">The opaque value carried through from the authorization request, returned unchanged on the redirect so the client can match the answer to its request. (optional)</param>
        /// <param name="scope">The scopes the user agreed to, as a space-separated list. Anything the user declined is left out, so this may be narrower than what was requested. (optional)</param>
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
        /// Start the authorization flow
        /// </summary>
        /// <remarks>
        /// Starts the OAuth2 authorization code flow for the client named by client_id. The caller has to present the portal signature cookie, and a request without a valid one is not refused with 401 or 403 but redirected to the portal login page, carrying the client ID so the flow can resume after signing in. When the user has not yet consented to the requested scopes the browser is redirected to the consent page; once the consent exists the browser is redirected to the client's redirect URI with the authorization code and, when one was sent, the original state. A caller that cannot follow redirects may send the X-Disable-Redirect header, and then the response is 200 with an empty body and the target URL in the X-Redirect-URI header. The code returned here is exchanged for tokens at the token endpoint.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseType">The OAuth 2.0 response type. Only code is supported: this server issues an authorization code, never a token, from this endpoint.</param>
        /// <param name="clientId">The identifier the client was given when it was registered. It selects both the client shown on the consent screen and the set of redirect URIs the request is checked against.</param>
        /// <param name="redirectUri">Where to send the user once authorization is complete. It has to be one of the redirect URIs registered for the client, otherwise the request is refused.</param>
        /// <param name="scope">The permissions being asked for, as a space-separated list. Every scope has to be one the client is registered for, and the consent screen lists exactly these.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authorize-o-auth/">REST API Reference for AuthorizeOAuth Operation</seealso>
        /// <returns></returns>
        public void AuthorizeOAuth(string responseType, string clientId, string redirectUri, string scope)
        {
            AuthorizeOAuthWithHttpInfo(responseType, clientId, redirectUri, scope);
        }

        /// <summary>
        /// Start the authorization flow
        /// </summary>
        /// <remarks>
        /// Starts the OAuth2 authorization code flow for the client named by client_id. The caller has to present the portal signature cookie, and a request without a valid one is not refused with 401 or 403 but redirected to the portal login page, carrying the client ID so the flow can resume after signing in. When the user has not yet consented to the requested scopes the browser is redirected to the consent page; once the consent exists the browser is redirected to the client's redirect URI with the authorization code and, when one was sent, the original state. A caller that cannot follow redirects may send the X-Disable-Redirect header, and then the response is 200 with an empty body and the target URL in the X-Redirect-URI header. The code returned here is exchanged for tokens at the token endpoint.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseType">The OAuth 2.0 response type. Only code is supported: this server issues an authorization code, never a token, from this endpoint.</param>
        /// <param name="clientId">The identifier the client was given when it was registered. It selects both the client shown on the consent screen and the set of redirect URIs the request is checked against.</param>
        /// <param name="redirectUri">Where to send the user once authorization is complete. It has to be one of the redirect URIs registered for the client, otherwise the request is refused.</param>
        /// <param name="scope">The permissions being asked for, as a space-separated list. Every scope has to be one the client is registered for, and the consent screen lists exactly these.</param>
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

            // authentication (x-signature) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("x-signature")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("x-signature", Configuration.GetApiKeyWithPrefix("x-signature")));
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
        /// Start the authorization flow
        /// </summary>
        /// <remarks>
        /// Starts the OAuth2 authorization code flow for the client named by client_id. The caller has to present the portal signature cookie, and a request without a valid one is not refused with 401 or 403 but redirected to the portal login page, carrying the client ID so the flow can resume after signing in. When the user has not yet consented to the requested scopes the browser is redirected to the consent page; once the consent exists the browser is redirected to the client's redirect URI with the authorization code and, when one was sent, the original state. A caller that cannot follow redirects may send the X-Disable-Redirect header, and then the response is 200 with an empty body and the target URL in the X-Redirect-URI header. The code returned here is exchanged for tokens at the token endpoint.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseType">The OAuth 2.0 response type. Only code is supported: this server issues an authorization code, never a token, from this endpoint.</param>
        /// <param name="clientId">The identifier the client was given when it was registered. It selects both the client shown on the consent screen and the set of redirect URIs the request is checked against.</param>
        /// <param name="redirectUri">Where to send the user once authorization is complete. It has to be one of the redirect URIs registered for the client, otherwise the request is refused.</param>
        /// <param name="scope">The permissions being asked for, as a space-separated list. Every scope has to be one the client is registered for, and the consent screen lists exactly these.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/authorize-o-auth/">REST API Reference for AuthorizeOAuth Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task AuthorizeOAuthAsync(string responseType, string clientId, string redirectUri, string scope, CancellationToken cancellationToken = default)
        {
            await AuthorizeOAuthWithHttpInfoAsync(responseType, clientId, redirectUri, scope, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Start the authorization flow
        /// </summary>
        /// <remarks>
        /// Starts the OAuth2 authorization code flow for the client named by client_id. The caller has to present the portal signature cookie, and a request without a valid one is not refused with 401 or 403 but redirected to the portal login page, carrying the client ID so the flow can resume after signing in. When the user has not yet consented to the requested scopes the browser is redirected to the consent page; once the consent exists the browser is redirected to the client's redirect URI with the authorization code and, when one was sent, the original state. A caller that cannot follow redirects may send the X-Disable-Redirect header, and then the response is 200 with an empty body and the target URL in the X-Redirect-URI header. The code returned here is exchanged for tokens at the token endpoint.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="responseType">The OAuth 2.0 response type. Only code is supported: this server issues an authorization code, never a token, from this endpoint.</param>
        /// <param name="clientId">The identifier the client was given when it was registered. It selects both the client shown on the consent screen and the set of redirect URIs the request is checked against.</param>
        /// <param name="redirectUri">Where to send the user once authorization is complete. It has to be one of the redirect URIs registered for the client, otherwise the request is refused.</param>
        /// <param name="scope">The permissions being asked for, as a space-separated list. Every scope has to be one the client is registered for, and the consent screen lists exactly these.</param>
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

            // authentication (x-signature) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("x-signature")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("x-signature", Configuration.GetApiKeyWithPrefix("x-signature")));
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
        /// Exchange the authorization code
        /// </summary>
        /// <remarks>
        /// Exchanges an authorization code for an access token. The request is form-encoded and has to carry the grant type, the code, the same redirect URI that was used to obtain the code, and the client credentials: the client authenticates itself here rather than through the portal signature cookie the authorization endpoint uses. The response carries the access token, its type and its lifetime in seconds, plus a refresh token when the client is configured for the refresh token grant. Client authentication that fails is answered with 401, while a malformed, unknown or expired code is answered with 400. The code is single use, so replaying it fails.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Which exchange is being performed: authorization_code to redeem a code, refresh_token to renew an access token. (optional)</param>
        /// <param name="code">The authorization code returned by the authorization endpoint. It may be redeemed once. (optional)</param>
        /// <param name="redirectUri">The same redirect URI that was used to obtain the code. The exchange fails when it differs. (optional)</param>
        /// <param name="clientId">The identifier of the client redeeming the code. (optional)</param>
        /// <param name="clientSecret">The secret of the client redeeming the code. It is omitted by a public client, which proves itself with a PKCE code verifier instead. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/exchange-token/">REST API Reference for ExchangeToken Operation</seealso>
        /// <returns>ExchangeToken200Response</returns>
        public ExchangeToken200Response ExchangeToken(string? grantType = default, string? code = default, string? redirectUri = default, string? clientId = default, string? clientSecret = default)
        {
            var localVarResponse = ExchangeTokenWithHttpInfo(grantType, code, redirectUri, clientId, clientSecret);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Exchange the authorization code
        /// </summary>
        /// <remarks>
        /// Exchanges an authorization code for an access token. The request is form-encoded and has to carry the grant type, the code, the same redirect URI that was used to obtain the code, and the client credentials: the client authenticates itself here rather than through the portal signature cookie the authorization endpoint uses. The response carries the access token, its type and its lifetime in seconds, plus a refresh token when the client is configured for the refresh token grant. Client authentication that fails is answered with 401, while a malformed, unknown or expired code is answered with 400. The code is single use, so replaying it fails.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Which exchange is being performed: authorization_code to redeem a code, refresh_token to renew an access token. (optional)</param>
        /// <param name="code">The authorization code returned by the authorization endpoint. It may be redeemed once. (optional)</param>
        /// <param name="redirectUri">The same redirect URI that was used to obtain the code. The exchange fails when it differs. (optional)</param>
        /// <param name="clientId">The identifier of the client redeeming the code. (optional)</param>
        /// <param name="clientSecret">The secret of the client redeeming the code. It is omitted by a public client, which proves itself with a PKCE code verifier instead. (optional)</param>
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

            // authentication (cookieAuth) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
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
        /// Exchange the authorization code
        /// </summary>
        /// <remarks>
        /// Exchanges an authorization code for an access token. The request is form-encoded and has to carry the grant type, the code, the same redirect URI that was used to obtain the code, and the client credentials: the client authenticates itself here rather than through the portal signature cookie the authorization endpoint uses. The response carries the access token, its type and its lifetime in seconds, plus a refresh token when the client is configured for the refresh token grant. Client authentication that fails is answered with 401, while a malformed, unknown or expired code is answered with 400. The code is single use, so replaying it fails.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Which exchange is being performed: authorization_code to redeem a code, refresh_token to renew an access token. (optional)</param>
        /// <param name="code">The authorization code returned by the authorization endpoint. It may be redeemed once. (optional)</param>
        /// <param name="redirectUri">The same redirect URI that was used to obtain the code. The exchange fails when it differs. (optional)</param>
        /// <param name="clientId">The identifier of the client redeeming the code. (optional)</param>
        /// <param name="clientSecret">The secret of the client redeeming the code. It is omitted by a public client, which proves itself with a PKCE code verifier instead. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/exchange-token/">REST API Reference for ExchangeToken Operation</seealso>
        /// <returns>Task of ExchangeToken200Response</returns>
        public async Task<ExchangeToken200Response> ExchangeTokenAsync(string? grantType = default, string? code = default, string? redirectUri = default, string? clientId = default, string? clientSecret = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ExchangeTokenWithHttpInfoAsync(grantType, code, redirectUri, clientId, clientSecret, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Exchange the authorization code
        /// </summary>
        /// <remarks>
        /// Exchanges an authorization code for an access token. The request is form-encoded and has to carry the grant type, the code, the same redirect URI that was used to obtain the code, and the client credentials: the client authenticates itself here rather than through the portal signature cookie the authorization endpoint uses. The response carries the access token, its type and its lifetime in seconds, plus a refresh token when the client is configured for the refresh token grant. Client authentication that fails is answered with 401, while a malformed, unknown or expired code is answered with 400. The code is single use, so replaying it fails.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">Which exchange is being performed: authorization_code to redeem a code, refresh_token to renew an access token. (optional)</param>
        /// <param name="code">The authorization code returned by the authorization endpoint. It may be redeemed once. (optional)</param>
        /// <param name="redirectUri">The same redirect URI that was used to obtain the code. The exchange fails when it differs. (optional)</param>
        /// <param name="clientId">The identifier of the client redeeming the code. (optional)</param>
        /// <param name="clientSecret">The secret of the client redeeming the code. It is omitted by a public client, which proves itself with a PKCE code verifier instead. (optional)</param>
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

            // authentication (cookieAuth) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
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
        /// Submit the consent decision
        /// </summary>
        /// <remarks>
        /// Submits the user's consent decision for the scopes an authorization request asked for. It is the form post the consent page makes, so it carries the client ID, the state and the agreed scopes as multipart form data, along with the same portal signature cookie the authorization request needed. On success the browser is redirected to the client's redirect URI with an authorization code, or, when the request carries the X-Disable-Redirect header, answered 200 with that URL in the X-Redirect-URI header. The consent is stored per user and client, so a later authorization request for the same scopes no longer stops at the consent page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client the consent is being given to. It has to be the same client the authorization request named. (optional)</param>
        /// <param name="state">The opaque value carried through from the authorization request, returned unchanged on the redirect so the client can match the answer to its request. (optional)</param>
        /// <param name="scope">The scopes the user agreed to, as a space-separated list. Anything the user declined is left out, so this may be narrower than what was requested. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/submit-consent/">REST API Reference for SubmitConsent Operation</seealso>
        /// <returns></returns>
        public void SubmitConsent(string? clientId = default, string? state = default, string? scope = default)
        {
            SubmitConsentWithHttpInfo(clientId, state, scope);
        }

        /// <summary>
        /// Submit the consent decision
        /// </summary>
        /// <remarks>
        /// Submits the user's consent decision for the scopes an authorization request asked for. It is the form post the consent page makes, so it carries the client ID, the state and the agreed scopes as multipart form data, along with the same portal signature cookie the authorization request needed. On success the browser is redirected to the client's redirect URI with an authorization code, or, when the request carries the X-Disable-Redirect header, answered 200 with that URL in the X-Redirect-URI header. The consent is stored per user and client, so a later authorization request for the same scopes no longer stops at the consent page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client the consent is being given to. It has to be the same client the authorization request named. (optional)</param>
        /// <param name="state">The opaque value carried through from the authorization request, returned unchanged on the redirect so the client can match the answer to its request. (optional)</param>
        /// <param name="scope">The scopes the user agreed to, as a space-separated list. Anything the user declined is left out, so this may be narrower than what was requested. (optional)</param>
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

            // authentication (x-signature) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("x-signature")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("x-signature", Configuration.GetApiKeyWithPrefix("x-signature")));
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
        /// Submit the consent decision
        /// </summary>
        /// <remarks>
        /// Submits the user's consent decision for the scopes an authorization request asked for. It is the form post the consent page makes, so it carries the client ID, the state and the agreed scopes as multipart form data, along with the same portal signature cookie the authorization request needed. On success the browser is redirected to the client's redirect URI with an authorization code, or, when the request carries the X-Disable-Redirect header, answered 200 with that URL in the X-Redirect-URI header. The consent is stored per user and client, so a later authorization request for the same scopes no longer stops at the consent page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client the consent is being given to. It has to be the same client the authorization request named. (optional)</param>
        /// <param name="state">The opaque value carried through from the authorization request, returned unchanged on the redirect so the client can match the answer to its request. (optional)</param>
        /// <param name="scope">The scopes the user agreed to, as a space-separated list. Anything the user declined is left out, so this may be narrower than what was requested. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/submit-consent/">REST API Reference for SubmitConsent Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task SubmitConsentAsync(string? clientId = default, string? state = default, string? scope = default, CancellationToken cancellationToken = default)
        {
            await SubmitConsentWithHttpInfoAsync(clientId, state, scope, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Submit the consent decision
        /// </summary>
        /// <remarks>
        /// Submits the user's consent decision for the scopes an authorization request asked for. It is the form post the consent page makes, so it carries the client ID, the state and the agreed scopes as multipart form data, along with the same portal signature cookie the authorization request needed. On success the browser is redirected to the client's redirect URI with an authorization code, or, when the request carries the X-Disable-Redirect header, answered 200 with that URL in the X-Redirect-URI header. The consent is stored per user and client, so a later authorization request for the same scopes no longer stops at the consent page.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client the consent is being given to. It has to be the same client the authorization request named. (optional)</param>
        /// <param name="state">The opaque value carried through from the authorization request, returned unchanged on the redirect so the client can match the answer to its request. (optional)</param>
        /// <param name="scope">The scopes the user agreed to, as a space-separated list. Anything the user declined is left out, so this may be narrower than what was requested. (optional)</param>
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

            // authentication (x-signature) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("x-signature")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("x-signature", Configuration.GetApiKeyWithPrefix("x-signature")));
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
