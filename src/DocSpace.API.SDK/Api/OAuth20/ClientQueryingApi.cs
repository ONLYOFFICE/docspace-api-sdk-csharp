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
    public interface IClientQueryingApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get client details
        /// </summary>
        /// <remarks>
        /// Retrieves detailed information about a specific OAuth2 client including its name, description, redirect URIs, and scopes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client/">REST API Reference for GetClient Operation</seealso>
        /// <returns>ClientResponse</returns>
        ClientResponse GetClient(string clientId);

        /// <summary>
        /// Get client details
        /// </summary>
        /// <remarks>
        /// Retrieves detailed information about a specific OAuth2 client including its name, description, redirect URIs, and scopes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client/">REST API Reference for GetClient Operation</seealso>
        /// <returns>ApiResponse of ClientResponse</returns>
        ApiResponse<ClientResponse> GetClientWithHttpInfo(string clientId);
        /// <summary>
        /// Get detailed client information
        /// </summary>
        /// <remarks>
        /// Retrieves the detailed information for a client with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client-info/">REST API Reference for GetClientInfo Operation</seealso>
        /// <returns>ClientInfoResponse</returns>
        ClientInfoResponse GetClientInfo(string clientId);

        /// <summary>
        /// Get detailed client information
        /// </summary>
        /// <remarks>
        /// Retrieves the detailed information for a client with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client-info/">REST API Reference for GetClientInfo Operation</seealso>
        /// <returns>ApiResponse of ClientInfoResponse</returns>
        ApiResponse<ClientInfoResponse> GetClientInfoWithHttpInfo(string clientId);
        /// <summary>
        /// Get clients
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of OAuth2 clients. The results can be paginated using the &#39;limit&#39; parameter and the last seen client ID or creation date.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The ID of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients/">REST API Reference for GetClients Operation</seealso>
        /// <returns>PageableResponse</returns>
        PageableResponse GetClients(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default);

        /// <summary>
        /// Get clients
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of OAuth2 clients. The results can be paginated using the &#39;limit&#39; parameter and the last seen client ID or creation date.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The ID of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients/">REST API Reference for GetClients Operation</seealso>
        /// <returns>ApiResponse of PageableResponse</returns>
        ApiResponse<PageableResponse> GetClientsWithHttpInfo(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default);
        /// <summary>
        /// Get detailed information of clients
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of information for all clients.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The identifier of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients-info/">REST API Reference for GetClientsInfo Operation</seealso>
        /// <returns>PageableResponseClientInfoResponse</returns>
        PageableResponseClientInfoResponse GetClientsInfo(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default);

        /// <summary>
        /// Get detailed information of clients
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of information for all clients.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The identifier of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients-info/">REST API Reference for GetClientsInfo Operation</seealso>
        /// <returns>ApiResponse of PageableResponseClientInfoResponse</returns>
        ApiResponse<PageableResponseClientInfoResponse> GetClientsInfoWithHttpInfo(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default);
        /// <summary>
        /// Get user consents
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of user consents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastModifiedOn">The date when the user consent was last modified. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-consents/">REST API Reference for GetConsents Operation</seealso>
        /// <returns>PageableModificationResponse</returns>
        PageableModificationResponse GetConsents(int limit, DateTime? lastModifiedOn = default);

        /// <summary>
        /// Get user consents
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of user consents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastModifiedOn">The date when the user consent was last modified. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-consents/">REST API Reference for GetConsents Operation</seealso>
        /// <returns>ApiResponse of PageableModificationResponse</returns>
        ApiResponse<PageableModificationResponse> GetConsentsWithHttpInfo(int limit, DateTime? lastModifiedOn = default);
        /// <summary>
        /// Get public client information
        /// </summary>
        /// <remarks>
        /// Returns the public information for a client with the ID secified din the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-client-info/">REST API Reference for GetPublicClientInfo Operation</seealso>
        /// <returns>ClientInfoResponse</returns>
        ClientInfoResponse GetPublicClientInfo(string clientId);

        /// <summary>
        /// Get public client information
        /// </summary>
        /// <remarks>
        /// Returns the public information for a client with the ID secified din the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-client-info/">REST API Reference for GetPublicClientInfo Operation</seealso>
        /// <returns>ApiResponse of ClientInfoResponse</returns>
        ApiResponse<ClientInfoResponse> GetPublicClientInfoWithHttpInfo(string clientId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IClientQueryingApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get client details
        /// </summary>
        /// <remarks>
        /// Retrieves detailed information about a specific OAuth2 client including its name, description, redirect URIs, and scopes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client/">REST API Reference for GetClient Operation</seealso>
        /// <returns>Task of ClientResponse</returns>
        Task<ClientResponse> GetClientAsync(string clientId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get client details
        /// </summary>
        /// <remarks>
        /// Retrieves detailed information about a specific OAuth2 client including its name, description, redirect URIs, and scopes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client/">REST API Reference for GetClient Operation</seealso>
        /// <returns>Task of ApiResponse (ClientResponse)</returns>
        Task<ApiResponse<ClientResponse>> GetClientWithHttpInfoAsync(string clientId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get detailed client information
        /// </summary>
        /// <remarks>
        /// Retrieves the detailed information for a client with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client-info/">REST API Reference for GetClientInfo Operation</seealso>
        /// <returns>Task of ClientInfoResponse</returns>
        Task<ClientInfoResponse> GetClientInfoAsync(string clientId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get detailed client information
        /// </summary>
        /// <remarks>
        /// Retrieves the detailed information for a client with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client-info/">REST API Reference for GetClientInfo Operation</seealso>
        /// <returns>Task of ApiResponse (ClientInfoResponse)</returns>
        Task<ApiResponse<ClientInfoResponse>> GetClientInfoWithHttpInfoAsync(string clientId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get clients
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of OAuth2 clients. The results can be paginated using the &#39;limit&#39; parameter and the last seen client ID or creation date.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The ID of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients/">REST API Reference for GetClients Operation</seealso>
        /// <returns>Task of PageableResponse</returns>
        Task<PageableResponse> GetClientsAsync(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get clients
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of OAuth2 clients. The results can be paginated using the &#39;limit&#39; parameter and the last seen client ID or creation date.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The ID of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients/">REST API Reference for GetClients Operation</seealso>
        /// <returns>Task of ApiResponse (PageableResponse)</returns>
        Task<ApiResponse<PageableResponse>> GetClientsWithHttpInfoAsync(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get detailed information of clients
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of information for all clients.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The identifier of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients-info/">REST API Reference for GetClientsInfo Operation</seealso>
        /// <returns>Task of PageableResponseClientInfoResponse</returns>
        Task<PageableResponseClientInfoResponse> GetClientsInfoAsync(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get detailed information of clients
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of information for all clients.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The identifier of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients-info/">REST API Reference for GetClientsInfo Operation</seealso>
        /// <returns>Task of ApiResponse (PageableResponseClientInfoResponse)</returns>
        Task<ApiResponse<PageableResponseClientInfoResponse>> GetClientsInfoWithHttpInfoAsync(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user consents
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of user consents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastModifiedOn">The date when the user consent was last modified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-consents/">REST API Reference for GetConsents Operation</seealso>
        /// <returns>Task of PageableModificationResponse</returns>
        Task<PageableModificationResponse> GetConsentsAsync(int limit, DateTime? lastModifiedOn = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get user consents
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of user consents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastModifiedOn">The date when the user consent was last modified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-consents/">REST API Reference for GetConsents Operation</seealso>
        /// <returns>Task of ApiResponse (PageableModificationResponse)</returns>
        Task<ApiResponse<PageableModificationResponse>> GetConsentsWithHttpInfoAsync(int limit, DateTime? lastModifiedOn = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get public client information
        /// </summary>
        /// <remarks>
        /// Returns the public information for a client with the ID secified din the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-client-info/">REST API Reference for GetPublicClientInfo Operation</seealso>
        /// <returns>Task of ClientInfoResponse</returns>
        Task<ClientInfoResponse> GetPublicClientInfoAsync(string clientId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get public client information
        /// </summary>
        /// <remarks>
        /// Returns the public information for a client with the ID secified din the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-client-info/">REST API Reference for GetPublicClientInfo Operation</seealso>
        /// <returns>Task of ApiResponse (ClientInfoResponse)</returns>
        Task<ApiResponse<ClientInfoResponse>> GetPublicClientInfoWithHttpInfoAsync(string clientId, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IClientQueryingApi : IClientQueryingApiSync, IClientQueryingApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ClientQueryingApi : IDisposable, IClientQueryingApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientQueryingApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public ClientQueryingApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientQueryingApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public ClientQueryingApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ClientQueryingApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public ClientQueryingApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ClientQueryingApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public ClientQueryingApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientQueryingApi"/> class.
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
        public ClientQueryingApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="ClientQueryingApi"/> class using a Configuration object.
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
        public ClientQueryingApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="ClientQueryingApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ClientQueryingApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Get client details
        /// </summary>
        /// <remarks>
        /// Retrieves detailed information about a specific OAuth2 client including its name, description, redirect URIs, and scopes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client/">REST API Reference for GetClient Operation</seealso>
        /// <returns>ClientResponse</returns>
        public ClientResponse GetClient(string clientId)
        {
            var localVarResponse = GetClientWithHttpInfo(clientId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get client details
        /// </summary>
        /// <remarks>
        /// Retrieves detailed information about a specific OAuth2 client including its name, description, redirect URIs, and scopes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client/">REST API Reference for GetClient Operation</seealso>
        /// <returns>ApiResponse of ClientResponse</returns>
        public ApiResponse<ClientResponse> GetClientWithHttpInfo(string clientId)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling ClientQueryingApi->GetClient");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("clientId", ClientUtils.ParameterToString(clientId)); // path parameter

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request
            var localVarResponse = Client.Get<ClientResponse>("/api/2.0/clients/{clientId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetClient", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get client details
        /// </summary>
        /// <remarks>
        /// Retrieves detailed information about a specific OAuth2 client including its name, description, redirect URIs, and scopes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client/">REST API Reference for GetClient Operation</seealso>
        /// <returns>Task of ClientResponse</returns>
        public async Task<ClientResponse> GetClientAsync(string clientId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetClientWithHttpInfoAsync(clientId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get client details
        /// </summary>
        /// <remarks>
        /// Retrieves detailed information about a specific OAuth2 client including its name, description, redirect URIs, and scopes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client/">REST API Reference for GetClient Operation</seealso>
        /// <returns>Task of ApiResponse (ClientResponse)</returns>
        public async Task<ApiResponse<ClientResponse>> GetClientWithHttpInfoAsync(string clientId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling ClientQueryingApi->GetClient");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("clientId", ClientUtils.ParameterToString(clientId)); // path parameter

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<ClientResponse>("/api/2.0/clients/{clientId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetClient", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get detailed client information
        /// </summary>
        /// <remarks>
        /// Retrieves the detailed information for a client with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client-info/">REST API Reference for GetClientInfo Operation</seealso>
        /// <returns>ClientInfoResponse</returns>
        public ClientInfoResponse GetClientInfo(string clientId)
        {
            var localVarResponse = GetClientInfoWithHttpInfo(clientId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get detailed client information
        /// </summary>
        /// <remarks>
        /// Retrieves the detailed information for a client with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client-info/">REST API Reference for GetClientInfo Operation</seealso>
        /// <returns>ApiResponse of ClientInfoResponse</returns>
        public ApiResponse<ClientInfoResponse> GetClientInfoWithHttpInfo(string clientId)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling ClientQueryingApi->GetClientInfo");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("clientId", ClientUtils.ParameterToString(clientId)); // path parameter

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request
            var localVarResponse = Client.Get<ClientInfoResponse>("/api/2.0/clients/{clientId}/info", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetClientInfo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get detailed client information
        /// </summary>
        /// <remarks>
        /// Retrieves the detailed information for a client with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client-info/">REST API Reference for GetClientInfo Operation</seealso>
        /// <returns>Task of ClientInfoResponse</returns>
        public async Task<ClientInfoResponse> GetClientInfoAsync(string clientId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetClientInfoWithHttpInfoAsync(clientId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get detailed client information
        /// </summary>
        /// <remarks>
        /// Retrieves the detailed information for a client with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client-info/">REST API Reference for GetClientInfo Operation</seealso>
        /// <returns>Task of ApiResponse (ClientInfoResponse)</returns>
        public async Task<ApiResponse<ClientInfoResponse>> GetClientInfoWithHttpInfoAsync(string clientId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling ClientQueryingApi->GetClientInfo");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("clientId", ClientUtils.ParameterToString(clientId)); // path parameter

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<ClientInfoResponse>("/api/2.0/clients/{clientId}/info", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetClientInfo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get clients
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of OAuth2 clients. The results can be paginated using the &#39;limit&#39; parameter and the last seen client ID or creation date.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The ID of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients/">REST API Reference for GetClients Operation</seealso>
        /// <returns>PageableResponse</returns>
        public PageableResponse GetClients(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default)
        {
            var localVarResponse = GetClientsWithHttpInfo(limit, lastClientId, lastCreatedOn);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get clients
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of OAuth2 clients. The results can be paginated using the &#39;limit&#39; parameter and the last seen client ID or creation date.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The ID of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients/">REST API Reference for GetClients Operation</seealso>
        /// <returns>ApiResponse of PageableResponse</returns>
        public ApiResponse<PageableResponse> GetClientsWithHttpInfo(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "limit", limit));
            if (lastClientId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "last_client_id", lastClientId));
            }
            if (lastCreatedOn != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "last_created_on", lastCreatedOn));
            }

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request
            var localVarResponse = Client.Get<PageableResponse>("/api/2.0/clients", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetClients", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get clients
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of OAuth2 clients. The results can be paginated using the &#39;limit&#39; parameter and the last seen client ID or creation date.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The ID of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients/">REST API Reference for GetClients Operation</seealso>
        /// <returns>Task of PageableResponse</returns>
        public async Task<PageableResponse> GetClientsAsync(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetClientsWithHttpInfoAsync(limit, lastClientId, lastCreatedOn, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get clients
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of OAuth2 clients. The results can be paginated using the &#39;limit&#39; parameter and the last seen client ID or creation date.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The ID of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients/">REST API Reference for GetClients Operation</seealso>
        /// <returns>Task of ApiResponse (PageableResponse)</returns>
        public async Task<ApiResponse<PageableResponse>> GetClientsWithHttpInfoAsync(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "limit", limit));
            if (lastClientId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "last_client_id", lastClientId));
            }
            if (lastCreatedOn != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "last_created_on", lastCreatedOn));
            }

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<PageableResponse>("/api/2.0/clients", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetClients", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get detailed information of clients
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of information for all clients.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The identifier of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients-info/">REST API Reference for GetClientsInfo Operation</seealso>
        /// <returns>PageableResponseClientInfoResponse</returns>
        public PageableResponseClientInfoResponse GetClientsInfo(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default)
        {
            var localVarResponse = GetClientsInfoWithHttpInfo(limit, lastClientId, lastCreatedOn);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get detailed information of clients
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of information for all clients.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The identifier of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients-info/">REST API Reference for GetClientsInfo Operation</seealso>
        /// <returns>ApiResponse of PageableResponseClientInfoResponse</returns>
        public ApiResponse<PageableResponseClientInfoResponse> GetClientsInfoWithHttpInfo(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "limit", limit));
            if (lastClientId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "last_client_id", lastClientId));
            }
            if (lastCreatedOn != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "last_created_on", lastCreatedOn));
            }

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request
            var localVarResponse = Client.Get<PageableResponseClientInfoResponse>("/api/2.0/clients/info", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetClientsInfo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get detailed information of clients
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of information for all clients.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The identifier of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients-info/">REST API Reference for GetClientsInfo Operation</seealso>
        /// <returns>Task of PageableResponseClientInfoResponse</returns>
        public async Task<PageableResponseClientInfoResponse> GetClientsInfoAsync(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetClientsInfoWithHttpInfoAsync(limit, lastClientId, lastCreatedOn, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get detailed information of clients
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of information for all clients.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The identifier of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients-info/">REST API Reference for GetClientsInfo Operation</seealso>
        /// <returns>Task of ApiResponse (PageableResponseClientInfoResponse)</returns>
        public async Task<ApiResponse<PageableResponseClientInfoResponse>> GetClientsInfoWithHttpInfoAsync(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "limit", limit));
            if (lastClientId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "last_client_id", lastClientId));
            }
            if (lastCreatedOn != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "last_created_on", lastCreatedOn));
            }

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<PageableResponseClientInfoResponse>("/api/2.0/clients/info", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetClientsInfo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get user consents
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of user consents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastModifiedOn">The date when the user consent was last modified. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-consents/">REST API Reference for GetConsents Operation</seealso>
        /// <returns>PageableModificationResponse</returns>
        public PageableModificationResponse GetConsents(int limit, DateTime? lastModifiedOn = default)
        {
            var localVarResponse = GetConsentsWithHttpInfo(limit, lastModifiedOn);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user consents
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of user consents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastModifiedOn">The date when the user consent was last modified. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-consents/">REST API Reference for GetConsents Operation</seealso>
        /// <returns>ApiResponse of PageableModificationResponse</returns>
        public ApiResponse<PageableModificationResponse> GetConsentsWithHttpInfo(int limit, DateTime? lastModifiedOn = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "limit", limit));
            if (lastModifiedOn != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "last_modified_on", lastModifiedOn));
            }

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request
            var localVarResponse = Client.Get<PageableModificationResponse>("/api/2.0/clients/consents", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetConsents", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get user consents
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of user consents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastModifiedOn">The date when the user consent was last modified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-consents/">REST API Reference for GetConsents Operation</seealso>
        /// <returns>Task of PageableModificationResponse</returns>
        public async Task<PageableModificationResponse> GetConsentsAsync(int limit, DateTime? lastModifiedOn = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetConsentsWithHttpInfoAsync(limit, lastModifiedOn, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user consents
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of user consents.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastModifiedOn">The date when the user consent was last modified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-consents/">REST API Reference for GetConsents Operation</seealso>
        /// <returns>Task of ApiResponse (PageableModificationResponse)</returns>
        public async Task<ApiResponse<PageableModificationResponse>> GetConsentsWithHttpInfoAsync(int limit, DateTime? lastModifiedOn = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "limit", limit));
            if (lastModifiedOn != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "last_modified_on", lastModifiedOn));
            }

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<PageableModificationResponse>("/api/2.0/clients/consents", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetConsents", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get public client information
        /// </summary>
        /// <remarks>
        /// Returns the public information for a client with the ID secified din the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-client-info/">REST API Reference for GetPublicClientInfo Operation</seealso>
        /// <returns>ClientInfoResponse</returns>
        public ClientInfoResponse GetPublicClientInfo(string clientId)
        {
            var localVarResponse = GetPublicClientInfoWithHttpInfo(clientId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get public client information
        /// </summary>
        /// <remarks>
        /// Returns the public information for a client with the ID secified din the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-client-info/">REST API Reference for GetPublicClientInfo Operation</seealso>
        /// <returns>ApiResponse of ClientInfoResponse</returns>
        public ApiResponse<ClientInfoResponse> GetPublicClientInfoWithHttpInfo(string clientId)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling ClientQueryingApi->GetPublicClientInfo");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("clientId", ClientUtils.ParameterToString(clientId)); // path parameter


            // make the HTTP request
            var localVarResponse = Client.Get<ClientInfoResponse>("/api/2.0/clients/{clientId}/public/info", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPublicClientInfo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get public client information
        /// </summary>
        /// <remarks>
        /// Returns the public information for a client with the ID secified din the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-client-info/">REST API Reference for GetPublicClientInfo Operation</seealso>
        /// <returns>Task of ClientInfoResponse</returns>
        public async Task<ClientInfoResponse> GetPublicClientInfoAsync(string clientId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetPublicClientInfoWithHttpInfoAsync(clientId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get public client information
        /// </summary>
        /// <remarks>
        /// Returns the public information for a client with the ID secified din the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-client-info/">REST API Reference for GetPublicClientInfo Operation</seealso>
        /// <returns>Task of ApiResponse (ClientInfoResponse)</returns>
        public async Task<ApiResponse<ClientInfoResponse>> GetPublicClientInfoWithHttpInfoAsync(string clientId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling ClientQueryingApi->GetPublicClientInfo");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("clientId", ClientUtils.ParameterToString(clientId)); // path parameter


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<ClientInfoResponse>("/api/2.0/clients/{clientId}/public/info", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPublicClientInfo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
