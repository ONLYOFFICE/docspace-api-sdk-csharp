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
    public interface ISettingsIPRestrictionsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the IP portal restrictions
        /// </summary>
        /// <remarks>
        /// Returns the IP portal restrictions.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ip-restrictions/">REST API Reference for GetIpRestrictions Operation</seealso>
        /// <returns>IPRestrictionArrayWrapper</returns>
        IPRestrictionArrayWrapper GetIpRestrictions();

        /// <summary>
        /// Get the IP portal restrictions
        /// </summary>
        /// <remarks>
        /// Returns the IP portal restrictions.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ip-restrictions/">REST API Reference for GetIpRestrictions Operation</seealso>
        /// <returns>ApiResponse of IPRestrictionArrayWrapper</returns>
        ApiResponse<IPRestrictionArrayWrapper> GetIpRestrictionsWithHttpInfo();
        /// <summary>
        /// Get the IP restriction settings
        /// </summary>
        /// <remarks>
        /// Returns the IP restriction settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/read-ip-restrictions-settings/">REST API Reference for ReadIpRestrictionsSettings Operation</seealso>
        /// <returns>IPRestrictionsSettingsWrapper</returns>
        IPRestrictionsSettingsWrapper ReadIpRestrictionsSettings();

        /// <summary>
        /// Get the IP restriction settings
        /// </summary>
        /// <remarks>
        /// Returns the IP restriction settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/read-ip-restrictions-settings/">REST API Reference for ReadIpRestrictionsSettings Operation</seealso>
        /// <returns>ApiResponse of IPRestrictionsSettingsWrapper</returns>
        ApiResponse<IPRestrictionsSettingsWrapper> ReadIpRestrictionsSettingsWithHttpInfo();
        /// <summary>
        /// Update the IP restrictions
        /// </summary>
        /// <remarks>
        /// Updates the IP restrictions with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipRestrictionsDto">The parameters for configuring new IP restriction settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-ip-restrictions/">REST API Reference for SaveIpRestrictions Operation</seealso>
        /// <returns>IpRestrictionsWrapper</returns>
        IpRestrictionsWrapper SaveIpRestrictions(IpRestrictionsDto? ipRestrictionsDto = default);

        /// <summary>
        /// Update the IP restrictions
        /// </summary>
        /// <remarks>
        /// Updates the IP restrictions with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipRestrictionsDto">The parameters for configuring new IP restriction settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-ip-restrictions/">REST API Reference for SaveIpRestrictions Operation</seealso>
        /// <returns>ApiResponse of IpRestrictionsWrapper</returns>
        ApiResponse<IpRestrictionsWrapper> SaveIpRestrictionsWithHttpInfo(IpRestrictionsDto? ipRestrictionsDto = default);
        /// <summary>
        /// Update the IP restriction settings
        /// </summary>
        /// <remarks>
        /// Updates the IP restriction settings with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipRestrictionsDto">The parameters for configuring new IP restriction settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-ip-restrictions-settings/">REST API Reference for UpdateIpRestrictionsSettings Operation</seealso>
        /// <returns>IpRestrictionsWrapper</returns>
        IpRestrictionsWrapper UpdateIpRestrictionsSettings(IpRestrictionsDto? ipRestrictionsDto = default);

        /// <summary>
        /// Update the IP restriction settings
        /// </summary>
        /// <remarks>
        /// Updates the IP restriction settings with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipRestrictionsDto">The parameters for configuring new IP restriction settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-ip-restrictions-settings/">REST API Reference for UpdateIpRestrictionsSettings Operation</seealso>
        /// <returns>ApiResponse of IpRestrictionsWrapper</returns>
        ApiResponse<IpRestrictionsWrapper> UpdateIpRestrictionsSettingsWithHttpInfo(IpRestrictionsDto? ipRestrictionsDto = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsIPRestrictionsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get the IP portal restrictions
        /// </summary>
        /// <remarks>
        /// Returns the IP portal restrictions.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ip-restrictions/">REST API Reference for GetIpRestrictions Operation</seealso>
        /// <returns>Task of IPRestrictionArrayWrapper</returns>
        Task<IPRestrictionArrayWrapper> GetIpRestrictionsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the IP portal restrictions
        /// </summary>
        /// <remarks>
        /// Returns the IP portal restrictions.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ip-restrictions/">REST API Reference for GetIpRestrictions Operation</seealso>
        /// <returns>Task of ApiResponse (IPRestrictionArrayWrapper)</returns>
        Task<ApiResponse<IPRestrictionArrayWrapper>> GetIpRestrictionsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the IP restriction settings
        /// </summary>
        /// <remarks>
        /// Returns the IP restriction settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/read-ip-restrictions-settings/">REST API Reference for ReadIpRestrictionsSettings Operation</seealso>
        /// <returns>Task of IPRestrictionsSettingsWrapper</returns>
        Task<IPRestrictionsSettingsWrapper> ReadIpRestrictionsSettingsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the IP restriction settings
        /// </summary>
        /// <remarks>
        /// Returns the IP restriction settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/read-ip-restrictions-settings/">REST API Reference for ReadIpRestrictionsSettings Operation</seealso>
        /// <returns>Task of ApiResponse (IPRestrictionsSettingsWrapper)</returns>
        Task<ApiResponse<IPRestrictionsSettingsWrapper>> ReadIpRestrictionsSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the IP restrictions
        /// </summary>
        /// <remarks>
        /// Updates the IP restrictions with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipRestrictionsDto">The parameters for configuring new IP restriction settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-ip-restrictions/">REST API Reference for SaveIpRestrictions Operation</seealso>
        /// <returns>Task of IpRestrictionsWrapper</returns>
        Task<IpRestrictionsWrapper> SaveIpRestrictionsAsync(IpRestrictionsDto? ipRestrictionsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update the IP restrictions
        /// </summary>
        /// <remarks>
        /// Updates the IP restrictions with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipRestrictionsDto">The parameters for configuring new IP restriction settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-ip-restrictions/">REST API Reference for SaveIpRestrictions Operation</seealso>
        /// <returns>Task of ApiResponse (IpRestrictionsWrapper)</returns>
        Task<ApiResponse<IpRestrictionsWrapper>> SaveIpRestrictionsWithHttpInfoAsync(IpRestrictionsDto? ipRestrictionsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the IP restriction settings
        /// </summary>
        /// <remarks>
        /// Updates the IP restriction settings with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipRestrictionsDto">The parameters for configuring new IP restriction settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-ip-restrictions-settings/">REST API Reference for UpdateIpRestrictionsSettings Operation</seealso>
        /// <returns>Task of IpRestrictionsWrapper</returns>
        Task<IpRestrictionsWrapper> UpdateIpRestrictionsSettingsAsync(IpRestrictionsDto? ipRestrictionsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update the IP restriction settings
        /// </summary>
        /// <remarks>
        /// Updates the IP restriction settings with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipRestrictionsDto">The parameters for configuring new IP restriction settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-ip-restrictions-settings/">REST API Reference for UpdateIpRestrictionsSettings Operation</seealso>
        /// <returns>Task of ApiResponse (IpRestrictionsWrapper)</returns>
        Task<ApiResponse<IpRestrictionsWrapper>> UpdateIpRestrictionsSettingsWithHttpInfoAsync(IpRestrictionsDto? ipRestrictionsDto = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsIPRestrictionsApi : ISettingsIPRestrictionsApiSync, ISettingsIPRestrictionsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SettingsIPRestrictionsApi : IDisposable, ISettingsIPRestrictionsApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsIPRestrictionsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public SettingsIPRestrictionsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsIPRestrictionsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public SettingsIPRestrictionsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="SettingsIPRestrictionsApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public SettingsIPRestrictionsApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="SettingsIPRestrictionsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public SettingsIPRestrictionsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsIPRestrictionsApi"/> class.
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
        public SettingsIPRestrictionsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="SettingsIPRestrictionsApi"/> class using a Configuration object.
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
        public SettingsIPRestrictionsApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="SettingsIPRestrictionsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SettingsIPRestrictionsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Get the IP portal restrictions
        /// </summary>
        /// <remarks>
        /// Returns the IP portal restrictions.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ip-restrictions/">REST API Reference for GetIpRestrictions Operation</seealso>
        /// <returns>IPRestrictionArrayWrapper</returns>
        public IPRestrictionArrayWrapper GetIpRestrictions()
        {
            var localVarResponse = GetIpRestrictionsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the IP portal restrictions
        /// </summary>
        /// <remarks>
        /// Returns the IP portal restrictions.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ip-restrictions/">REST API Reference for GetIpRestrictions Operation</seealso>
        /// <returns>ApiResponse of IPRestrictionArrayWrapper</returns>
        public ApiResponse<IPRestrictionArrayWrapper> GetIpRestrictionsWithHttpInfo()
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
            var localVarResponse = Client.Get<IPRestrictionArrayWrapper>("/api/2.0/settings/iprestrictions", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetIpRestrictions", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the IP portal restrictions
        /// </summary>
        /// <remarks>
        /// Returns the IP portal restrictions.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ip-restrictions/">REST API Reference for GetIpRestrictions Operation</seealso>
        /// <returns>Task of IPRestrictionArrayWrapper</returns>
        public async Task<IPRestrictionArrayWrapper> GetIpRestrictionsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetIpRestrictionsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the IP portal restrictions
        /// </summary>
        /// <remarks>
        /// Returns the IP portal restrictions.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-ip-restrictions/">REST API Reference for GetIpRestrictions Operation</seealso>
        /// <returns>Task of ApiResponse (IPRestrictionArrayWrapper)</returns>
        public async Task<ApiResponse<IPRestrictionArrayWrapper>> GetIpRestrictionsWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<IPRestrictionArrayWrapper>("/api/2.0/settings/iprestrictions", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetIpRestrictions", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the IP restriction settings
        /// </summary>
        /// <remarks>
        /// Returns the IP restriction settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/read-ip-restrictions-settings/">REST API Reference for ReadIpRestrictionsSettings Operation</seealso>
        /// <returns>IPRestrictionsSettingsWrapper</returns>
        public IPRestrictionsSettingsWrapper ReadIpRestrictionsSettings()
        {
            var localVarResponse = ReadIpRestrictionsSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the IP restriction settings
        /// </summary>
        /// <remarks>
        /// Returns the IP restriction settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/read-ip-restrictions-settings/">REST API Reference for ReadIpRestrictionsSettings Operation</seealso>
        /// <returns>ApiResponse of IPRestrictionsSettingsWrapper</returns>
        public ApiResponse<IPRestrictionsSettingsWrapper> ReadIpRestrictionsSettingsWithHttpInfo()
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
            var localVarResponse = Client.Get<IPRestrictionsSettingsWrapper>("/api/2.0/settings/iprestrictions/settings", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ReadIpRestrictionsSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the IP restriction settings
        /// </summary>
        /// <remarks>
        /// Returns the IP restriction settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/read-ip-restrictions-settings/">REST API Reference for ReadIpRestrictionsSettings Operation</seealso>
        /// <returns>Task of IPRestrictionsSettingsWrapper</returns>
        public async Task<IPRestrictionsSettingsWrapper> ReadIpRestrictionsSettingsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ReadIpRestrictionsSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the IP restriction settings
        /// </summary>
        /// <remarks>
        /// Returns the IP restriction settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/read-ip-restrictions-settings/">REST API Reference for ReadIpRestrictionsSettings Operation</seealso>
        /// <returns>Task of ApiResponse (IPRestrictionsSettingsWrapper)</returns>
        public async Task<ApiResponse<IPRestrictionsSettingsWrapper>> ReadIpRestrictionsSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<IPRestrictionsSettingsWrapper>("/api/2.0/settings/iprestrictions/settings", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ReadIpRestrictionsSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the IP restrictions
        /// </summary>
        /// <remarks>
        /// Updates the IP restrictions with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipRestrictionsDto">The parameters for configuring new IP restriction settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-ip-restrictions/">REST API Reference for SaveIpRestrictions Operation</seealso>
        /// <returns>IpRestrictionsWrapper</returns>
        public IpRestrictionsWrapper SaveIpRestrictions(IpRestrictionsDto? ipRestrictionsDto = default)
        {
            var localVarResponse = SaveIpRestrictionsWithHttpInfo(ipRestrictionsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update the IP restrictions
        /// </summary>
        /// <remarks>
        /// Updates the IP restrictions with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipRestrictionsDto">The parameters for configuring new IP restriction settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-ip-restrictions/">REST API Reference for SaveIpRestrictions Operation</seealso>
        /// <returns>ApiResponse of IpRestrictionsWrapper</returns>
        public ApiResponse<IpRestrictionsWrapper> SaveIpRestrictionsWithHttpInfo(IpRestrictionsDto? ipRestrictionsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (ipRestrictionsDto != null) localVarRequestOptions.Data = ipRestrictionsDto;

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
            var localVarResponse = Client.Put<IpRestrictionsWrapper>("/api/2.0/settings/iprestrictions", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SaveIpRestrictions", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the IP restrictions
        /// </summary>
        /// <remarks>
        /// Updates the IP restrictions with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipRestrictionsDto">The parameters for configuring new IP restriction settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-ip-restrictions/">REST API Reference for SaveIpRestrictions Operation</seealso>
        /// <returns>Task of IpRestrictionsWrapper</returns>
        public async Task<IpRestrictionsWrapper> SaveIpRestrictionsAsync(IpRestrictionsDto? ipRestrictionsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SaveIpRestrictionsWithHttpInfoAsync(ipRestrictionsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update the IP restrictions
        /// </summary>
        /// <remarks>
        /// Updates the IP restrictions with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipRestrictionsDto">The parameters for configuring new IP restriction settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-ip-restrictions/">REST API Reference for SaveIpRestrictions Operation</seealso>
        /// <returns>Task of ApiResponse (IpRestrictionsWrapper)</returns>
        public async Task<ApiResponse<IpRestrictionsWrapper>> SaveIpRestrictionsWithHttpInfoAsync(IpRestrictionsDto? ipRestrictionsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (ipRestrictionsDto != null) localVarRequestOptions.Data = ipRestrictionsDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<IpRestrictionsWrapper>("/api/2.0/settings/iprestrictions", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SaveIpRestrictions", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the IP restriction settings
        /// </summary>
        /// <remarks>
        /// Updates the IP restriction settings with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipRestrictionsDto">The parameters for configuring new IP restriction settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-ip-restrictions-settings/">REST API Reference for UpdateIpRestrictionsSettings Operation</seealso>
        /// <returns>IpRestrictionsWrapper</returns>
        public IpRestrictionsWrapper UpdateIpRestrictionsSettings(IpRestrictionsDto? ipRestrictionsDto = default)
        {
            var localVarResponse = UpdateIpRestrictionsSettingsWithHttpInfo(ipRestrictionsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update the IP restriction settings
        /// </summary>
        /// <remarks>
        /// Updates the IP restriction settings with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipRestrictionsDto">The parameters for configuring new IP restriction settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-ip-restrictions-settings/">REST API Reference for UpdateIpRestrictionsSettings Operation</seealso>
        /// <returns>ApiResponse of IpRestrictionsWrapper</returns>
        public ApiResponse<IpRestrictionsWrapper> UpdateIpRestrictionsSettingsWithHttpInfo(IpRestrictionsDto? ipRestrictionsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (ipRestrictionsDto != null) localVarRequestOptions.Data = ipRestrictionsDto;

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
            var localVarResponse = Client.Put<IpRestrictionsWrapper>("/api/2.0/settings/iprestrictions/settings", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateIpRestrictionsSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the IP restriction settings
        /// </summary>
        /// <remarks>
        /// Updates the IP restriction settings with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipRestrictionsDto">The parameters for configuring new IP restriction settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-ip-restrictions-settings/">REST API Reference for UpdateIpRestrictionsSettings Operation</seealso>
        /// <returns>Task of IpRestrictionsWrapper</returns>
        public async Task<IpRestrictionsWrapper> UpdateIpRestrictionsSettingsAsync(IpRestrictionsDto? ipRestrictionsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateIpRestrictionsSettingsWithHttpInfoAsync(ipRestrictionsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update the IP restriction settings
        /// </summary>
        /// <remarks>
        /// Updates the IP restriction settings with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ipRestrictionsDto">The parameters for configuring new IP restriction settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-ip-restrictions-settings/">REST API Reference for UpdateIpRestrictionsSettings Operation</seealso>
        /// <returns>Task of ApiResponse (IpRestrictionsWrapper)</returns>
        public async Task<ApiResponse<IpRestrictionsWrapper>> UpdateIpRestrictionsSettingsWithHttpInfoAsync(IpRestrictionsDto? ipRestrictionsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (ipRestrictionsDto != null) localVarRequestOptions.Data = ipRestrictionsDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<IpRestrictionsWrapper>("/api/2.0/settings/iprestrictions/settings", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateIpRestrictionsSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
