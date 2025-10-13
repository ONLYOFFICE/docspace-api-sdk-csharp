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
namespace DocSpace.API.SDK.Api.People
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IThirdPartyAccountsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get third-party accounts
        /// </summary>
        /// <remarks>
        /// Returns a list of the available third-party accounts.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteView">Specifies whether to return providers that are available for invitation links, i.e. the user can login or register through these providers. (optional)</param>
        /// <param name="settingsView">Specifies whether to display the provider settings in a pop-up window (true) or redirect them to the desktop application (false). (optional)</param>
        /// <param name="clientCallback">The method that is called after authentication. (optional)</param>
        /// <param name="fromOnly">The provider name if a response is required only from this provider. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-third-party-auth-providers/">REST API Reference for GetThirdPartyAuthProviders Operation</seealso>
        /// <returns>AccountInfoArrayWrapper</returns>
        AccountInfoArrayWrapper GetThirdPartyAuthProviders(bool? inviteView = default, bool? settingsView = default, string? clientCallback = default, string? fromOnly = default);

        /// <summary>
        /// Get third-party accounts
        /// </summary>
        /// <remarks>
        /// Returns a list of the available third-party accounts.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteView">Specifies whether to return providers that are available for invitation links, i.e. the user can login or register through these providers. (optional)</param>
        /// <param name="settingsView">Specifies whether to display the provider settings in a pop-up window (true) or redirect them to the desktop application (false). (optional)</param>
        /// <param name="clientCallback">The method that is called after authentication. (optional)</param>
        /// <param name="fromOnly">The provider name if a response is required only from this provider. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-third-party-auth-providers/">REST API Reference for GetThirdPartyAuthProviders Operation</seealso>
        /// <returns>ApiResponse of AccountInfoArrayWrapper</returns>
        ApiResponse<AccountInfoArrayWrapper> GetThirdPartyAuthProvidersWithHttpInfo(bool? inviteView = default, bool? settingsView = default, string? clientCallback = default, string? fromOnly = default);
        /// <summary>
        /// Link a third-pary account
        /// </summary>
        /// <remarks>
        /// Links a third-party account specified in the request to the user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linkAccountRequestDto">The request parameters for linking accounts. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/link-third-party-account/">REST API Reference for LinkThirdPartyAccount Operation</seealso>
        /// <returns></returns>
        void LinkThirdPartyAccount(LinkAccountRequestDto? linkAccountRequestDto = default);

        /// <summary>
        /// Link a third-pary account
        /// </summary>
        /// <remarks>
        /// Links a third-party account specified in the request to the user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linkAccountRequestDto">The request parameters for linking accounts. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/link-third-party-account/">REST API Reference for LinkThirdPartyAccount Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> LinkThirdPartyAccountWithHttpInfo(LinkAccountRequestDto? linkAccountRequestDto = default);
        /// <summary>
        /// Create a third-pary account
        /// </summary>
        /// <remarks>
        /// Creates a third-party account with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signupAccountRequestDto">The request parameters for creating a third-party account. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/signup-third-party-account/">REST API Reference for SignupThirdPartyAccount Operation</seealso>
        /// <returns>EmployeeWrapper</returns>
        EmployeeWrapper SignupThirdPartyAccount(SignupAccountRequestDto? signupAccountRequestDto = default);

        /// <summary>
        /// Create a third-pary account
        /// </summary>
        /// <remarks>
        /// Creates a third-party account with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signupAccountRequestDto">The request parameters for creating a third-party account. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/signup-third-party-account/">REST API Reference for SignupThirdPartyAccount Operation</seealso>
        /// <returns>ApiResponse of EmployeeWrapper</returns>
        ApiResponse<EmployeeWrapper> SignupThirdPartyAccountWithHttpInfo(SignupAccountRequestDto? signupAccountRequestDto = default);
        /// <summary>
        /// Unlink a third-pary account
        /// </summary>
        /// <remarks>
        /// Unlinks a third-party account specified in the request from the user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">The provider name. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-third-party-account/">REST API Reference for UnlinkThirdPartyAccount Operation</seealso>
        /// <returns></returns>
        void UnlinkThirdPartyAccount(string? provider = default);

        /// <summary>
        /// Unlink a third-pary account
        /// </summary>
        /// <remarks>
        /// Unlinks a third-party account specified in the request from the user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">The provider name. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-third-party-account/">REST API Reference for UnlinkThirdPartyAccount Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UnlinkThirdPartyAccountWithHttpInfo(string? provider = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IThirdPartyAccountsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get third-party accounts
        /// </summary>
        /// <remarks>
        /// Returns a list of the available third-party accounts.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteView">Specifies whether to return providers that are available for invitation links, i.e. the user can login or register through these providers. (optional)</param>
        /// <param name="settingsView">Specifies whether to display the provider settings in a pop-up window (true) or redirect them to the desktop application (false). (optional)</param>
        /// <param name="clientCallback">The method that is called after authentication. (optional)</param>
        /// <param name="fromOnly">The provider name if a response is required only from this provider. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-third-party-auth-providers/">REST API Reference for GetThirdPartyAuthProviders Operation</seealso>
        /// <returns>Task of AccountInfoArrayWrapper</returns>
        Task<AccountInfoArrayWrapper> GetThirdPartyAuthProvidersAsync(bool? inviteView = default, bool? settingsView = default, string? clientCallback = default, string? fromOnly = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get third-party accounts
        /// </summary>
        /// <remarks>
        /// Returns a list of the available third-party accounts.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteView">Specifies whether to return providers that are available for invitation links, i.e. the user can login or register through these providers. (optional)</param>
        /// <param name="settingsView">Specifies whether to display the provider settings in a pop-up window (true) or redirect them to the desktop application (false). (optional)</param>
        /// <param name="clientCallback">The method that is called after authentication. (optional)</param>
        /// <param name="fromOnly">The provider name if a response is required only from this provider. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-third-party-auth-providers/">REST API Reference for GetThirdPartyAuthProviders Operation</seealso>
        /// <returns>Task of ApiResponse (AccountInfoArrayWrapper)</returns>
        Task<ApiResponse<AccountInfoArrayWrapper>> GetThirdPartyAuthProvidersWithHttpInfoAsync(bool? inviteView = default, bool? settingsView = default, string? clientCallback = default, string? fromOnly = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Link a third-pary account
        /// </summary>
        /// <remarks>
        /// Links a third-party account specified in the request to the user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linkAccountRequestDto">The request parameters for linking accounts. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/link-third-party-account/">REST API Reference for LinkThirdPartyAccount Operation</seealso>
        /// <returns>Task of void</returns>
        Task LinkThirdPartyAccountAsync(LinkAccountRequestDto? linkAccountRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Link a third-pary account
        /// </summary>
        /// <remarks>
        /// Links a third-party account specified in the request to the user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linkAccountRequestDto">The request parameters for linking accounts. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/link-third-party-account/">REST API Reference for LinkThirdPartyAccount Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> LinkThirdPartyAccountWithHttpInfoAsync(LinkAccountRequestDto? linkAccountRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a third-pary account
        /// </summary>
        /// <remarks>
        /// Creates a third-party account with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signupAccountRequestDto">The request parameters for creating a third-party account. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/signup-third-party-account/">REST API Reference for SignupThirdPartyAccount Operation</seealso>
        /// <returns>Task of EmployeeWrapper</returns>
        Task<EmployeeWrapper> SignupThirdPartyAccountAsync(SignupAccountRequestDto? signupAccountRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a third-pary account
        /// </summary>
        /// <remarks>
        /// Creates a third-party account with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signupAccountRequestDto">The request parameters for creating a third-party account. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/signup-third-party-account/">REST API Reference for SignupThirdPartyAccount Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeWrapper)</returns>
        Task<ApiResponse<EmployeeWrapper>> SignupThirdPartyAccountWithHttpInfoAsync(SignupAccountRequestDto? signupAccountRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Unlink a third-pary account
        /// </summary>
        /// <remarks>
        /// Unlinks a third-party account specified in the request from the user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">The provider name. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-third-party-account/">REST API Reference for UnlinkThirdPartyAccount Operation</seealso>
        /// <returns>Task of void</returns>
        Task UnlinkThirdPartyAccountAsync(string? provider = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Unlink a third-pary account
        /// </summary>
        /// <remarks>
        /// Unlinks a third-party account specified in the request from the user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">The provider name. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-third-party-account/">REST API Reference for UnlinkThirdPartyAccount Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> UnlinkThirdPartyAccountWithHttpInfoAsync(string? provider = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IThirdPartyAccountsApi : IThirdPartyAccountsApiSync, IThirdPartyAccountsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ThirdPartyAccountsApi : IDisposable, IThirdPartyAccountsApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyAccountsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public ThirdPartyAccountsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyAccountsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public ThirdPartyAccountsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ThirdPartyAccountsApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public ThirdPartyAccountsApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ThirdPartyAccountsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public ThirdPartyAccountsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyAccountsApi"/> class.
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
        public ThirdPartyAccountsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="ThirdPartyAccountsApi"/> class using a Configuration object.
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
        public ThirdPartyAccountsApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="ThirdPartyAccountsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ThirdPartyAccountsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Get third-party accounts
        /// </summary>
        /// <remarks>
        /// Returns a list of the available third-party accounts.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteView">Specifies whether to return providers that are available for invitation links, i.e. the user can login or register through these providers. (optional)</param>
        /// <param name="settingsView">Specifies whether to display the provider settings in a pop-up window (true) or redirect them to the desktop application (false). (optional)</param>
        /// <param name="clientCallback">The method that is called after authentication. (optional)</param>
        /// <param name="fromOnly">The provider name if a response is required only from this provider. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-third-party-auth-providers/">REST API Reference for GetThirdPartyAuthProviders Operation</seealso>
        /// <returns>AccountInfoArrayWrapper</returns>
        public AccountInfoArrayWrapper GetThirdPartyAuthProviders(bool? inviteView = default, bool? settingsView = default, string? clientCallback = default, string? fromOnly = default)
        {
            var localVarResponse = GetThirdPartyAuthProvidersWithHttpInfo(inviteView, settingsView, clientCallback, fromOnly);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get third-party accounts
        /// </summary>
        /// <remarks>
        /// Returns a list of the available third-party accounts.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteView">Specifies whether to return providers that are available for invitation links, i.e. the user can login or register through these providers. (optional)</param>
        /// <param name="settingsView">Specifies whether to display the provider settings in a pop-up window (true) or redirect them to the desktop application (false). (optional)</param>
        /// <param name="clientCallback">The method that is called after authentication. (optional)</param>
        /// <param name="fromOnly">The provider name if a response is required only from this provider. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-third-party-auth-providers/">REST API Reference for GetThirdPartyAuthProviders Operation</seealso>
        /// <returns>ApiResponse of AccountInfoArrayWrapper</returns>
        public ApiResponse<AccountInfoArrayWrapper> GetThirdPartyAuthProvidersWithHttpInfo(bool? inviteView = default, bool? settingsView = default, string? clientCallback = default, string? fromOnly = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (inviteView != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inviteView", inviteView));
            }
            if (settingsView != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "settingsView", settingsView));
            }
            if (clientCallback != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "clientCallback", clientCallback));
            }
            if (fromOnly != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "fromOnly", fromOnly));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<AccountInfoArrayWrapper>("/api/2.0/people/thirdparty/providers", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetThirdPartyAuthProviders", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get third-party accounts
        /// </summary>
        /// <remarks>
        /// Returns a list of the available third-party accounts.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteView">Specifies whether to return providers that are available for invitation links, i.e. the user can login or register through these providers. (optional)</param>
        /// <param name="settingsView">Specifies whether to display the provider settings in a pop-up window (true) or redirect them to the desktop application (false). (optional)</param>
        /// <param name="clientCallback">The method that is called after authentication. (optional)</param>
        /// <param name="fromOnly">The provider name if a response is required only from this provider. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-third-party-auth-providers/">REST API Reference for GetThirdPartyAuthProviders Operation</seealso>
        /// <returns>Task of AccountInfoArrayWrapper</returns>
        public async Task<AccountInfoArrayWrapper> GetThirdPartyAuthProvidersAsync(bool? inviteView = default, bool? settingsView = default, string? clientCallback = default, string? fromOnly = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetThirdPartyAuthProvidersWithHttpInfoAsync(inviteView, settingsView, clientCallback, fromOnly, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get third-party accounts
        /// </summary>
        /// <remarks>
        /// Returns a list of the available third-party accounts.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteView">Specifies whether to return providers that are available for invitation links, i.e. the user can login or register through these providers. (optional)</param>
        /// <param name="settingsView">Specifies whether to display the provider settings in a pop-up window (true) or redirect them to the desktop application (false). (optional)</param>
        /// <param name="clientCallback">The method that is called after authentication. (optional)</param>
        /// <param name="fromOnly">The provider name if a response is required only from this provider. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-third-party-auth-providers/">REST API Reference for GetThirdPartyAuthProviders Operation</seealso>
        /// <returns>Task of ApiResponse (AccountInfoArrayWrapper)</returns>
        public async Task<ApiResponse<AccountInfoArrayWrapper>> GetThirdPartyAuthProvidersWithHttpInfoAsync(bool? inviteView = default, bool? settingsView = default, string? clientCallback = default, string? fromOnly = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (inviteView != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inviteView", inviteView));
            }
            if (settingsView != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "settingsView", settingsView));
            }
            if (clientCallback != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "clientCallback", clientCallback));
            }
            if (fromOnly != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "fromOnly", fromOnly));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<AccountInfoArrayWrapper>("/api/2.0/people/thirdparty/providers", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetThirdPartyAuthProviders", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Link a third-pary account
        /// </summary>
        /// <remarks>
        /// Links a third-party account specified in the request to the user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linkAccountRequestDto">The request parameters for linking accounts. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/link-third-party-account/">REST API Reference for LinkThirdPartyAccount Operation</seealso>
        /// <returns></returns>
        public void LinkThirdPartyAccount(LinkAccountRequestDto? linkAccountRequestDto = default)
        {
            LinkThirdPartyAccountWithHttpInfo(linkAccountRequestDto);
        }

        /// <summary>
        /// Link a third-pary account
        /// </summary>
        /// <remarks>
        /// Links a third-party account specified in the request to the user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linkAccountRequestDto">The request parameters for linking accounts. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/link-third-party-account/">REST API Reference for LinkThirdPartyAccount Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> LinkThirdPartyAccountWithHttpInfo(LinkAccountRequestDto? linkAccountRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (linkAccountRequestDto != null) localVarRequestOptions.Data = linkAccountRequestDto;

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
            var localVarResponse = Client.Put<Object>("/api/2.0/people/thirdparty/linkaccount", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("LinkThirdPartyAccount", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Link a third-pary account
        /// </summary>
        /// <remarks>
        /// Links a third-party account specified in the request to the user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linkAccountRequestDto">The request parameters for linking accounts. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/link-third-party-account/">REST API Reference for LinkThirdPartyAccount Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task LinkThirdPartyAccountAsync(LinkAccountRequestDto? linkAccountRequestDto = default, CancellationToken cancellationToken = default)
        {
            await LinkThirdPartyAccountWithHttpInfoAsync(linkAccountRequestDto, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Link a third-pary account
        /// </summary>
        /// <remarks>
        /// Links a third-party account specified in the request to the user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linkAccountRequestDto">The request parameters for linking accounts. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/link-third-party-account/">REST API Reference for LinkThirdPartyAccount Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> LinkThirdPartyAccountWithHttpInfoAsync(LinkAccountRequestDto? linkAccountRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (linkAccountRequestDto != null) localVarRequestOptions.Data = linkAccountRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<Object>("/api/2.0/people/thirdparty/linkaccount", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("LinkThirdPartyAccount", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a third-pary account
        /// </summary>
        /// <remarks>
        /// Creates a third-party account with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signupAccountRequestDto">The request parameters for creating a third-party account. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/signup-third-party-account/">REST API Reference for SignupThirdPartyAccount Operation</seealso>
        /// <returns>EmployeeWrapper</returns>
        public EmployeeWrapper SignupThirdPartyAccount(SignupAccountRequestDto? signupAccountRequestDto = default)
        {
            var localVarResponse = SignupThirdPartyAccountWithHttpInfo(signupAccountRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a third-pary account
        /// </summary>
        /// <remarks>
        /// Creates a third-party account with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signupAccountRequestDto">The request parameters for creating a third-party account. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/signup-third-party-account/">REST API Reference for SignupThirdPartyAccount Operation</seealso>
        /// <returns>ApiResponse of EmployeeWrapper</returns>
        public ApiResponse<EmployeeWrapper> SignupThirdPartyAccountWithHttpInfo(SignupAccountRequestDto? signupAccountRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (signupAccountRequestDto != null) localVarRequestOptions.Data = signupAccountRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Post<EmployeeWrapper>("/api/2.0/people/thirdparty/signup", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SignupThirdPartyAccount", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a third-pary account
        /// </summary>
        /// <remarks>
        /// Creates a third-party account with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signupAccountRequestDto">The request parameters for creating a third-party account. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/signup-third-party-account/">REST API Reference for SignupThirdPartyAccount Operation</seealso>
        /// <returns>Task of EmployeeWrapper</returns>
        public async Task<EmployeeWrapper> SignupThirdPartyAccountAsync(SignupAccountRequestDto? signupAccountRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SignupThirdPartyAccountWithHttpInfoAsync(signupAccountRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a third-pary account
        /// </summary>
        /// <remarks>
        /// Creates a third-party account with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signupAccountRequestDto">The request parameters for creating a third-party account. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/signup-third-party-account/">REST API Reference for SignupThirdPartyAccount Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeWrapper)</returns>
        public async Task<ApiResponse<EmployeeWrapper>> SignupThirdPartyAccountWithHttpInfoAsync(SignupAccountRequestDto? signupAccountRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (signupAccountRequestDto != null) localVarRequestOptions.Data = signupAccountRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<EmployeeWrapper>("/api/2.0/people/thirdparty/signup", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SignupThirdPartyAccount", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Unlink a third-pary account
        /// </summary>
        /// <remarks>
        /// Unlinks a third-party account specified in the request from the user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">The provider name. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-third-party-account/">REST API Reference for UnlinkThirdPartyAccount Operation</seealso>
        /// <returns></returns>
        public void UnlinkThirdPartyAccount(string? provider = default)
        {
            UnlinkThirdPartyAccountWithHttpInfo(provider);
        }

        /// <summary>
        /// Unlink a third-pary account
        /// </summary>
        /// <remarks>
        /// Unlinks a third-party account specified in the request from the user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">The provider name. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-third-party-account/">REST API Reference for UnlinkThirdPartyAccount Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UnlinkThirdPartyAccountWithHttpInfo(string? provider = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (provider != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "provider", provider));
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
            var localVarResponse = Client.Delete<Object>("/api/2.0/people/thirdparty/unlinkaccount", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UnlinkThirdPartyAccount", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Unlink a third-pary account
        /// </summary>
        /// <remarks>
        /// Unlinks a third-party account specified in the request from the user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">The provider name. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-third-party-account/">REST API Reference for UnlinkThirdPartyAccount Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task UnlinkThirdPartyAccountAsync(string? provider = default, CancellationToken cancellationToken = default)
        {
            await UnlinkThirdPartyAccountWithHttpInfoAsync(provider, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Unlink a third-pary account
        /// </summary>
        /// <remarks>
        /// Unlinks a third-party account specified in the request from the user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">The provider name. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-third-party-account/">REST API Reference for UnlinkThirdPartyAccount Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> UnlinkThirdPartyAccountWithHttpInfoAsync(string? provider = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (provider != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "provider", provider));
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

            var localVarResponse = await AsynchronousClient.DeleteAsync<Object>("/api/2.0/people/thirdparty/unlinkaccount", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UnlinkThirdPartyAccount", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
