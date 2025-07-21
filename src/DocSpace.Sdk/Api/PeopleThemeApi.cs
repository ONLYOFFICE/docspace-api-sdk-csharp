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
    public interface IPeopleThemeApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Change the portal theme
        /// </summary>
        /// <remarks>
        /// Changes the current portal theme.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="darkThemeSettingsRequestDto">The theme settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-portal-theme/">REST API Reference for ChangePortalTheme Operation</seealso>
        /// <returns>DarkThemeSettingsWrapper</returns>
        DarkThemeSettingsWrapper ChangePortalTheme(DarkThemeSettingsRequestDto? darkThemeSettingsRequestDto = default);

        /// <summary>
        /// Change the portal theme
        /// </summary>
        /// <remarks>
        /// Changes the current portal theme.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="darkThemeSettingsRequestDto">The theme settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-portal-theme/">REST API Reference for ChangePortalTheme Operation</seealso>
        /// <returns>ApiResponse of DarkThemeSettingsWrapper</returns>
        ApiResponse<DarkThemeSettingsWrapper> ChangePortalThemeWithHttpInfo(DarkThemeSettingsRequestDto? darkThemeSettingsRequestDto = default);
        /// <summary>
        /// Get the portal theme
        /// </summary>
        /// <remarks>
        /// Returns a theme which is set to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-theme/">REST API Reference for GetPortalTheme Operation</seealso>
        /// <returns>DarkThemeSettingsWrapper</returns>
        DarkThemeSettingsWrapper GetPortalTheme();

        /// <summary>
        /// Get the portal theme
        /// </summary>
        /// <remarks>
        /// Returns a theme which is set to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-theme/">REST API Reference for GetPortalTheme Operation</seealso>
        /// <returns>ApiResponse of DarkThemeSettingsWrapper</returns>
        ApiResponse<DarkThemeSettingsWrapper> GetPortalThemeWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPeopleThemeApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Change the portal theme
        /// </summary>
        /// <remarks>
        /// Changes the current portal theme.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="darkThemeSettingsRequestDto">The theme settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-portal-theme/">REST API Reference for ChangePortalTheme Operation</seealso>
        /// <returns>Task of DarkThemeSettingsWrapper</returns>
        Task<DarkThemeSettingsWrapper> ChangePortalThemeAsync(DarkThemeSettingsRequestDto? darkThemeSettingsRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Change the portal theme
        /// </summary>
        /// <remarks>
        /// Changes the current portal theme.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="darkThemeSettingsRequestDto">The theme settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-portal-theme/">REST API Reference for ChangePortalTheme Operation</seealso>
        /// <returns>Task of ApiResponse (DarkThemeSettingsWrapper)</returns>
        Task<ApiResponse<DarkThemeSettingsWrapper>> ChangePortalThemeWithHttpInfoAsync(DarkThemeSettingsRequestDto? darkThemeSettingsRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the portal theme
        /// </summary>
        /// <remarks>
        /// Returns a theme which is set to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-theme/">REST API Reference for GetPortalTheme Operation</seealso>
        /// <returns>Task of DarkThemeSettingsWrapper</returns>
        Task<DarkThemeSettingsWrapper> GetPortalThemeAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the portal theme
        /// </summary>
        /// <remarks>
        /// Returns a theme which is set to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-theme/">REST API Reference for GetPortalTheme Operation</seealso>
        /// <returns>Task of ApiResponse (DarkThemeSettingsWrapper)</returns>
        Task<ApiResponse<DarkThemeSettingsWrapper>> GetPortalThemeWithHttpInfoAsync(CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPeopleThemeApi : IPeopleThemeApiSync, IPeopleThemeApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PeopleThemeApi : IDisposable, IPeopleThemeApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleThemeApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public PeopleThemeApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleThemeApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public PeopleThemeApi(string basePath)
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
        /// Initializes a new instance of the <see cref="PeopleThemeApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public PeopleThemeApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="PeopleThemeApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public PeopleThemeApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleThemeApi"/> class.
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
        public PeopleThemeApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="PeopleThemeApi"/> class using a Configuration object.
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
        public PeopleThemeApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="PeopleThemeApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public PeopleThemeApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Change the portal theme
        /// </summary>
        /// <remarks>
        /// Changes the current portal theme.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="darkThemeSettingsRequestDto">The theme settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-portal-theme/">REST API Reference for ChangePortalTheme Operation</seealso>
        /// <returns>DarkThemeSettingsWrapper</returns>
        public DarkThemeSettingsWrapper ChangePortalTheme(DarkThemeSettingsRequestDto? darkThemeSettingsRequestDto = default)
        {
            var localVarResponse = ChangePortalThemeWithHttpInfo(darkThemeSettingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the portal theme
        /// </summary>
        /// <remarks>
        /// Changes the current portal theme.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="darkThemeSettingsRequestDto">The theme settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-portal-theme/">REST API Reference for ChangePortalTheme Operation</seealso>
        /// <returns>ApiResponse of DarkThemeSettingsWrapper</returns>
        public ApiResponse<DarkThemeSettingsWrapper> ChangePortalThemeWithHttpInfo(DarkThemeSettingsRequestDto? darkThemeSettingsRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (darkThemeSettingsRequestDto != null) localVarRequestOptions.Data = darkThemeSettingsRequestDto;

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
            var localVarResponse = Client.Put<DarkThemeSettingsWrapper>("/api/2.0/people/theme", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangePortalTheme", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the portal theme
        /// </summary>
        /// <remarks>
        /// Changes the current portal theme.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="darkThemeSettingsRequestDto">The theme settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-portal-theme/">REST API Reference for ChangePortalTheme Operation</seealso>
        /// <returns>Task of DarkThemeSettingsWrapper</returns>
        public async Task<DarkThemeSettingsWrapper> ChangePortalThemeAsync(DarkThemeSettingsRequestDto? darkThemeSettingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ChangePortalThemeWithHttpInfoAsync(darkThemeSettingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the portal theme
        /// </summary>
        /// <remarks>
        /// Changes the current portal theme.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="darkThemeSettingsRequestDto">The theme settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-portal-theme/">REST API Reference for ChangePortalTheme Operation</seealso>
        /// <returns>Task of ApiResponse (DarkThemeSettingsWrapper)</returns>
        public async Task<ApiResponse<DarkThemeSettingsWrapper>> ChangePortalThemeWithHttpInfoAsync(DarkThemeSettingsRequestDto? darkThemeSettingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (darkThemeSettingsRequestDto != null) localVarRequestOptions.Data = darkThemeSettingsRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<DarkThemeSettingsWrapper>("/api/2.0/people/theme", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangePortalTheme", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the portal theme
        /// </summary>
        /// <remarks>
        /// Returns a theme which is set to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-theme/">REST API Reference for GetPortalTheme Operation</seealso>
        /// <returns>DarkThemeSettingsWrapper</returns>
        public DarkThemeSettingsWrapper GetPortalTheme()
        {
            var localVarResponse = GetPortalThemeWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the portal theme
        /// </summary>
        /// <remarks>
        /// Returns a theme which is set to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-theme/">REST API Reference for GetPortalTheme Operation</seealso>
        /// <returns>ApiResponse of DarkThemeSettingsWrapper</returns>
        public ApiResponse<DarkThemeSettingsWrapper> GetPortalThemeWithHttpInfo()
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
            var localVarResponse = Client.Get<DarkThemeSettingsWrapper>("/api/2.0/people/theme", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPortalTheme", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the portal theme
        /// </summary>
        /// <remarks>
        /// Returns a theme which is set to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-theme/">REST API Reference for GetPortalTheme Operation</seealso>
        /// <returns>Task of DarkThemeSettingsWrapper</returns>
        public async Task<DarkThemeSettingsWrapper> GetPortalThemeAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetPortalThemeWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the portal theme
        /// </summary>
        /// <remarks>
        /// Returns a theme which is set to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-theme/">REST API Reference for GetPortalTheme Operation</seealso>
        /// <returns>Task of ApiResponse (DarkThemeSettingsWrapper)</returns>
        public async Task<ApiResponse<DarkThemeSettingsWrapper>> GetPortalThemeWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<DarkThemeSettingsWrapper>("/api/2.0/people/theme", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPortalTheme", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
