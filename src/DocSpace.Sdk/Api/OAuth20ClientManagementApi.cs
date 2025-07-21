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
    public interface IOAuth20ClientManagementApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Change the client activation status
        /// </summary>
        /// <remarks>
        /// Activates or deactivates an OAuth2 client. When deactivated, the client cannot request new access tokens, but existing tokens will remain valid until they expire.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="changeClientActivationRequest">The request parameters for changing the client activation status.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-activation/">REST API Reference for ChangeActivation Operation</seealso>
        /// <returns>Object</returns>
        Object ChangeActivation(string clientId, ChangeClientActivationRequest changeClientActivationRequest);

        /// <summary>
        /// Change the client activation status
        /// </summary>
        /// <remarks>
        /// Activates or deactivates an OAuth2 client. When deactivated, the client cannot request new access tokens, but existing tokens will remain valid until they expire.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="changeClientActivationRequest">The request parameters for changing the client activation status.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-activation/">REST API Reference for ChangeActivation Operation</seealso>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ChangeActivationWithHttpInfo(string clientId, ChangeClientActivationRequest changeClientActivationRequest);
        /// <summary>
        /// Create a new OAuth2 client
        /// </summary>
        /// <remarks>
        /// Creates a new OAuth2 client with the specified configuration. The client will be created with the provided scopes, redirect URIs, and other settings. Returns the created client details including the generated client ID.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createClientRequest">The request parameters for creating a client.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-client/">REST API Reference for CreateClient Operation</seealso>
        /// <returns>ClientResponse</returns>
        ClientResponse CreateClient(CreateClientRequest createClientRequest);

        /// <summary>
        /// Create a new OAuth2 client
        /// </summary>
        /// <remarks>
        /// Creates a new OAuth2 client with the specified configuration. The client will be created with the provided scopes, redirect URIs, and other settings. Returns the created client details including the generated client ID.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createClientRequest">The request parameters for creating a client.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-client/">REST API Reference for CreateClient Operation</seealso>
        /// <returns>ApiResponse of ClientResponse</returns>
        ApiResponse<ClientResponse> CreateClientWithHttpInfo(CreateClientRequest createClientRequest);
        /// <summary>
        /// Delete an OAuth2 client
        /// </summary>
        /// <remarks>
        /// Permanently deletes an OAuth2 client and all associated data. All access and refresh tokens issued to this client will be invalidated. This operation cannot be undone.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-client/">REST API Reference for DeleteClient Operation</seealso>
        /// <returns>Object</returns>
        Object DeleteClient(string clientId);

        /// <summary>
        /// Delete an OAuth2 client
        /// </summary>
        /// <remarks>
        /// Permanently deletes an OAuth2 client and all associated data. All access and refresh tokens issued to this client will be invalidated. This operation cannot be undone.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-client/">REST API Reference for DeleteClient Operation</seealso>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DeleteClientWithHttpInfo(string clientId);
        /// <summary>
        /// Regenerate the client secret
        /// </summary>
        /// <remarks>
        /// Generates a new client secret for the specified OAuth2 client. The old secret will be immediately invalidated. This operation should be used with caution as it requires updating the secret in all client applications.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/regenerate-secret/">REST API Reference for RegenerateSecret Operation</seealso>
        /// <returns>ClientSecretResponse</returns>
        ClientSecretResponse RegenerateSecret(string clientId);

        /// <summary>
        /// Regenerate the client secret
        /// </summary>
        /// <remarks>
        /// Generates a new client secret for the specified OAuth2 client. The old secret will be immediately invalidated. This operation should be used with caution as it requires updating the secret in all client applications.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/regenerate-secret/">REST API Reference for RegenerateSecret Operation</seealso>
        /// <returns>ApiResponse of ClientSecretResponse</returns>
        ApiResponse<ClientSecretResponse> RegenerateSecretWithHttpInfo(string clientId);
        /// <summary>
        /// Revoke client consent
        /// </summary>
        /// <remarks>
        /// Revokes all user consents for the specified OAuth2 client. This will invalidate all access tokens and refresh tokens issued to this client for the current user. The user will need to re-authorize the client to access their resources.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/revoke-user-client/">REST API Reference for RevokeUserClient Operation</seealso>
        /// <returns>Object</returns>
        Object RevokeUserClient(string clientId);

        /// <summary>
        /// Revoke client consent
        /// </summary>
        /// <remarks>
        /// Revokes all user consents for the specified OAuth2 client. This will invalidate all access tokens and refresh tokens issued to this client for the current user. The user will need to re-authorize the client to access their resources.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/revoke-user-client/">REST API Reference for RevokeUserClient Operation</seealso>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> RevokeUserClientWithHttpInfo(string clientId);
        /// <summary>
        /// Update an existing OAuth2 client
        /// </summary>
        /// <remarks>
        /// Updates the configuration of an existing OAuth2 client, allowing modifications to the client name, description, redirect URIs, and other settings. The client ID cannot be modified.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="updateClientRequest">The request for updating client details.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-client/">REST API Reference for UpdateClient Operation</seealso>
        /// <returns>Object</returns>
        Object UpdateClient(string clientId, UpdateClientRequest updateClientRequest);

        /// <summary>
        /// Update an existing OAuth2 client
        /// </summary>
        /// <remarks>
        /// Updates the configuration of an existing OAuth2 client, allowing modifications to the client name, description, redirect URIs, and other settings. The client ID cannot be modified.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="updateClientRequest">The request for updating client details.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-client/">REST API Reference for UpdateClient Operation</seealso>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> UpdateClientWithHttpInfo(string clientId, UpdateClientRequest updateClientRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOAuth20ClientManagementApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Change the client activation status
        /// </summary>
        /// <remarks>
        /// Activates or deactivates an OAuth2 client. When deactivated, the client cannot request new access tokens, but existing tokens will remain valid until they expire.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="changeClientActivationRequest">The request parameters for changing the client activation status.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-activation/">REST API Reference for ChangeActivation Operation</seealso>
        /// <returns>Task of Object</returns>
        Task<Object> ChangeActivationAsync(string clientId, ChangeClientActivationRequest changeClientActivationRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Change the client activation status
        /// </summary>
        /// <remarks>
        /// Activates or deactivates an OAuth2 client. When deactivated, the client cannot request new access tokens, but existing tokens will remain valid until they expire.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="changeClientActivationRequest">The request parameters for changing the client activation status.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-activation/">REST API Reference for ChangeActivation Operation</seealso>
        /// <returns>Task of ApiResponse (Object)</returns>
        Task<ApiResponse<Object>> ChangeActivationWithHttpInfoAsync(string clientId, ChangeClientActivationRequest changeClientActivationRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new OAuth2 client
        /// </summary>
        /// <remarks>
        /// Creates a new OAuth2 client with the specified configuration. The client will be created with the provided scopes, redirect URIs, and other settings. Returns the created client details including the generated client ID.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createClientRequest">The request parameters for creating a client.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-client/">REST API Reference for CreateClient Operation</seealso>
        /// <returns>Task of ClientResponse</returns>
        Task<ClientResponse> CreateClientAsync(CreateClientRequest createClientRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new OAuth2 client
        /// </summary>
        /// <remarks>
        /// Creates a new OAuth2 client with the specified configuration. The client will be created with the provided scopes, redirect URIs, and other settings. Returns the created client details including the generated client ID.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createClientRequest">The request parameters for creating a client.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-client/">REST API Reference for CreateClient Operation</seealso>
        /// <returns>Task of ApiResponse (ClientResponse)</returns>
        Task<ApiResponse<ClientResponse>> CreateClientWithHttpInfoAsync(CreateClientRequest createClientRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an OAuth2 client
        /// </summary>
        /// <remarks>
        /// Permanently deletes an OAuth2 client and all associated data. All access and refresh tokens issued to this client will be invalidated. This operation cannot be undone.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-client/">REST API Reference for DeleteClient Operation</seealso>
        /// <returns>Task of Object</returns>
        Task<Object> DeleteClientAsync(string clientId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete an OAuth2 client
        /// </summary>
        /// <remarks>
        /// Permanently deletes an OAuth2 client and all associated data. All access and refresh tokens issued to this client will be invalidated. This operation cannot be undone.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-client/">REST API Reference for DeleteClient Operation</seealso>
        /// <returns>Task of ApiResponse (Object)</returns>
        Task<ApiResponse<Object>> DeleteClientWithHttpInfoAsync(string clientId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Regenerate the client secret
        /// </summary>
        /// <remarks>
        /// Generates a new client secret for the specified OAuth2 client. The old secret will be immediately invalidated. This operation should be used with caution as it requires updating the secret in all client applications.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/regenerate-secret/">REST API Reference for RegenerateSecret Operation</seealso>
        /// <returns>Task of ClientSecretResponse</returns>
        Task<ClientSecretResponse> RegenerateSecretAsync(string clientId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Regenerate the client secret
        /// </summary>
        /// <remarks>
        /// Generates a new client secret for the specified OAuth2 client. The old secret will be immediately invalidated. This operation should be used with caution as it requires updating the secret in all client applications.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/regenerate-secret/">REST API Reference for RegenerateSecret Operation</seealso>
        /// <returns>Task of ApiResponse (ClientSecretResponse)</returns>
        Task<ApiResponse<ClientSecretResponse>> RegenerateSecretWithHttpInfoAsync(string clientId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke client consent
        /// </summary>
        /// <remarks>
        /// Revokes all user consents for the specified OAuth2 client. This will invalidate all access tokens and refresh tokens issued to this client for the current user. The user will need to re-authorize the client to access their resources.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/revoke-user-client/">REST API Reference for RevokeUserClient Operation</seealso>
        /// <returns>Task of Object</returns>
        Task<Object> RevokeUserClientAsync(string clientId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Revoke client consent
        /// </summary>
        /// <remarks>
        /// Revokes all user consents for the specified OAuth2 client. This will invalidate all access tokens and refresh tokens issued to this client for the current user. The user will need to re-authorize the client to access their resources.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/revoke-user-client/">REST API Reference for RevokeUserClient Operation</seealso>
        /// <returns>Task of ApiResponse (Object)</returns>
        Task<ApiResponse<Object>> RevokeUserClientWithHttpInfoAsync(string clientId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing OAuth2 client
        /// </summary>
        /// <remarks>
        /// Updates the configuration of an existing OAuth2 client, allowing modifications to the client name, description, redirect URIs, and other settings. The client ID cannot be modified.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="updateClientRequest">The request for updating client details.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-client/">REST API Reference for UpdateClient Operation</seealso>
        /// <returns>Task of Object</returns>
        Task<Object> UpdateClientAsync(string clientId, UpdateClientRequest updateClientRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an existing OAuth2 client
        /// </summary>
        /// <remarks>
        /// Updates the configuration of an existing OAuth2 client, allowing modifications to the client name, description, redirect URIs, and other settings. The client ID cannot be modified.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="updateClientRequest">The request for updating client details.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-client/">REST API Reference for UpdateClient Operation</seealso>
        /// <returns>Task of ApiResponse (Object)</returns>
        Task<ApiResponse<Object>> UpdateClientWithHttpInfoAsync(string clientId, UpdateClientRequest updateClientRequest, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOAuth20ClientManagementApi : IOAuth20ClientManagementApiSync, IOAuth20ClientManagementApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OAuth20ClientManagementApi : IDisposable, IOAuth20ClientManagementApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth20ClientManagementApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public OAuth20ClientManagementApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth20ClientManagementApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public OAuth20ClientManagementApi(string basePath)
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
        /// Initializes a new instance of the <see cref="OAuth20ClientManagementApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public OAuth20ClientManagementApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="OAuth20ClientManagementApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public OAuth20ClientManagementApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth20ClientManagementApi"/> class.
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
        public OAuth20ClientManagementApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="OAuth20ClientManagementApi"/> class using a Configuration object.
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
        public OAuth20ClientManagementApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="OAuth20ClientManagementApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public OAuth20ClientManagementApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Change the client activation status
        /// </summary>
        /// <remarks>
        /// Activates or deactivates an OAuth2 client. When deactivated, the client cannot request new access tokens, but existing tokens will remain valid until they expire.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="changeClientActivationRequest">The request parameters for changing the client activation status.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-activation/">REST API Reference for ChangeActivation Operation</seealso>
        /// <returns>Object</returns>
        public Object ChangeActivation(string clientId, ChangeClientActivationRequest changeClientActivationRequest)
        {
            var localVarResponse = ChangeActivationWithHttpInfo(clientId, changeClientActivationRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the client activation status
        /// </summary>
        /// <remarks>
        /// Activates or deactivates an OAuth2 client. When deactivated, the client cannot request new access tokens, but existing tokens will remain valid until they expire.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="changeClientActivationRequest">The request parameters for changing the client activation status.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-activation/">REST API Reference for ChangeActivation Operation</seealso>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse<Object> ChangeActivationWithHttpInfo(string clientId, ChangeClientActivationRequest changeClientActivationRequest)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientManagementApi->ChangeActivation");

            // verify the required parameter 'changeClientActivationRequest' is set
            if (changeClientActivationRequest == null)
                throw new ApiException(400, "Missing required parameter 'changeClientActivationRequest' when calling OAuth20ClientManagementApi->ChangeActivation");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("clientId", ClientUtils.ParameterToString(clientId)); // path parameter
            if (changeClientActivationRequest != null) localVarRequestOptions.Data = changeClientActivationRequest;

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request
            var localVarResponse = Client.Patch<Object>("/api/2.0/clients/{clientId}/activation", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangeActivation", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the client activation status
        /// </summary>
        /// <remarks>
        /// Activates or deactivates an OAuth2 client. When deactivated, the client cannot request new access tokens, but existing tokens will remain valid until they expire.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="changeClientActivationRequest">The request parameters for changing the client activation status.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-activation/">REST API Reference for ChangeActivation Operation</seealso>
        /// <returns>Task of Object</returns>
        public async Task<Object> ChangeActivationAsync(string clientId, ChangeClientActivationRequest changeClientActivationRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ChangeActivationWithHttpInfoAsync(clientId, changeClientActivationRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the client activation status
        /// </summary>
        /// <remarks>
        /// Activates or deactivates an OAuth2 client. When deactivated, the client cannot request new access tokens, but existing tokens will remain valid until they expire.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="changeClientActivationRequest">The request parameters for changing the client activation status.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-activation/">REST API Reference for ChangeActivation Operation</seealso>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async Task<ApiResponse<Object>> ChangeActivationWithHttpInfoAsync(string clientId, ChangeClientActivationRequest changeClientActivationRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientManagementApi->ChangeActivation");

            // verify the required parameter 'changeClientActivationRequest' is set
            if (changeClientActivationRequest == null)
                throw new ApiException(400, "Missing required parameter 'changeClientActivationRequest' when calling OAuth20ClientManagementApi->ChangeActivation");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("clientId", ClientUtils.ParameterToString(clientId)); // path parameter
            if (changeClientActivationRequest != null) localVarRequestOptions.Data = changeClientActivationRequest;

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PatchAsync<Object>("/api/2.0/clients/{clientId}/activation", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangeActivation", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a new OAuth2 client
        /// </summary>
        /// <remarks>
        /// Creates a new OAuth2 client with the specified configuration. The client will be created with the provided scopes, redirect URIs, and other settings. Returns the created client details including the generated client ID.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createClientRequest">The request parameters for creating a client.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-client/">REST API Reference for CreateClient Operation</seealso>
        /// <returns>ClientResponse</returns>
        public ClientResponse CreateClient(CreateClientRequest createClientRequest)
        {
            var localVarResponse = CreateClientWithHttpInfo(createClientRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new OAuth2 client
        /// </summary>
        /// <remarks>
        /// Creates a new OAuth2 client with the specified configuration. The client will be created with the provided scopes, redirect URIs, and other settings. Returns the created client details including the generated client ID.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createClientRequest">The request parameters for creating a client.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-client/">REST API Reference for CreateClient Operation</seealso>
        /// <returns>ApiResponse of ClientResponse</returns>
        public ApiResponse<ClientResponse> CreateClientWithHttpInfo(CreateClientRequest createClientRequest)
        {
            // verify the required parameter 'createClientRequest' is set
            if (createClientRequest == null)
                throw new ApiException(400, "Missing required parameter 'createClientRequest' when calling OAuth20ClientManagementApi->CreateClient");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createClientRequest != null) localVarRequestOptions.Data = createClientRequest;

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request
            var localVarResponse = Client.Post<ClientResponse>("/api/2.0/clients", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateClient", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a new OAuth2 client
        /// </summary>
        /// <remarks>
        /// Creates a new OAuth2 client with the specified configuration. The client will be created with the provided scopes, redirect URIs, and other settings. Returns the created client details including the generated client ID.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createClientRequest">The request parameters for creating a client.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-client/">REST API Reference for CreateClient Operation</seealso>
        /// <returns>Task of ClientResponse</returns>
        public async Task<ClientResponse> CreateClientAsync(CreateClientRequest createClientRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateClientWithHttpInfoAsync(createClientRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new OAuth2 client
        /// </summary>
        /// <remarks>
        /// Creates a new OAuth2 client with the specified configuration. The client will be created with the provided scopes, redirect URIs, and other settings. Returns the created client details including the generated client ID.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createClientRequest">The request parameters for creating a client.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-client/">REST API Reference for CreateClient Operation</seealso>
        /// <returns>Task of ApiResponse (ClientResponse)</returns>
        public async Task<ApiResponse<ClientResponse>> CreateClientWithHttpInfoAsync(CreateClientRequest createClientRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'createClientRequest' is set
            if (createClientRequest == null)
                throw new ApiException(400, "Missing required parameter 'createClientRequest' when calling OAuth20ClientManagementApi->CreateClient");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createClientRequest != null) localVarRequestOptions.Data = createClientRequest;

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<ClientResponse>("/api/2.0/clients", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateClient", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete an OAuth2 client
        /// </summary>
        /// <remarks>
        /// Permanently deletes an OAuth2 client and all associated data. All access and refresh tokens issued to this client will be invalidated. This operation cannot be undone.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-client/">REST API Reference for DeleteClient Operation</seealso>
        /// <returns>Object</returns>
        public Object DeleteClient(string clientId)
        {
            var localVarResponse = DeleteClientWithHttpInfo(clientId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an OAuth2 client
        /// </summary>
        /// <remarks>
        /// Permanently deletes an OAuth2 client and all associated data. All access and refresh tokens issued to this client will be invalidated. This operation cannot be undone.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-client/">REST API Reference for DeleteClient Operation</seealso>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse<Object> DeleteClientWithHttpInfo(string clientId)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientManagementApi->DeleteClient");

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
            var localVarResponse = Client.Delete<Object>("/api/2.0/clients/{clientId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteClient", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete an OAuth2 client
        /// </summary>
        /// <remarks>
        /// Permanently deletes an OAuth2 client and all associated data. All access and refresh tokens issued to this client will be invalidated. This operation cannot be undone.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-client/">REST API Reference for DeleteClient Operation</seealso>
        /// <returns>Task of Object</returns>
        public async Task<Object> DeleteClientAsync(string clientId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeleteClientWithHttpInfoAsync(clientId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an OAuth2 client
        /// </summary>
        /// <remarks>
        /// Permanently deletes an OAuth2 client and all associated data. All access and refresh tokens issued to this client will be invalidated. This operation cannot be undone.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-client/">REST API Reference for DeleteClient Operation</seealso>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async Task<ApiResponse<Object>> DeleteClientWithHttpInfoAsync(string clientId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientManagementApi->DeleteClient");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<Object>("/api/2.0/clients/{clientId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteClient", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Regenerate the client secret
        /// </summary>
        /// <remarks>
        /// Generates a new client secret for the specified OAuth2 client. The old secret will be immediately invalidated. This operation should be used with caution as it requires updating the secret in all client applications.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/regenerate-secret/">REST API Reference for RegenerateSecret Operation</seealso>
        /// <returns>ClientSecretResponse</returns>
        public ClientSecretResponse RegenerateSecret(string clientId)
        {
            var localVarResponse = RegenerateSecretWithHttpInfo(clientId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Regenerate the client secret
        /// </summary>
        /// <remarks>
        /// Generates a new client secret for the specified OAuth2 client. The old secret will be immediately invalidated. This operation should be used with caution as it requires updating the secret in all client applications.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/regenerate-secret/">REST API Reference for RegenerateSecret Operation</seealso>
        /// <returns>ApiResponse of ClientSecretResponse</returns>
        public ApiResponse<ClientSecretResponse> RegenerateSecretWithHttpInfo(string clientId)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientManagementApi->RegenerateSecret");

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
            var localVarResponse = Client.Patch<ClientSecretResponse>("/api/2.0/clients/{clientId}/regenerate", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RegenerateSecret", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Regenerate the client secret
        /// </summary>
        /// <remarks>
        /// Generates a new client secret for the specified OAuth2 client. The old secret will be immediately invalidated. This operation should be used with caution as it requires updating the secret in all client applications.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/regenerate-secret/">REST API Reference for RegenerateSecret Operation</seealso>
        /// <returns>Task of ClientSecretResponse</returns>
        public async Task<ClientSecretResponse> RegenerateSecretAsync(string clientId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await RegenerateSecretWithHttpInfoAsync(clientId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Regenerate the client secret
        /// </summary>
        /// <remarks>
        /// Generates a new client secret for the specified OAuth2 client. The old secret will be immediately invalidated. This operation should be used with caution as it requires updating the secret in all client applications.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/regenerate-secret/">REST API Reference for RegenerateSecret Operation</seealso>
        /// <returns>Task of ApiResponse (ClientSecretResponse)</returns>
        public async Task<ApiResponse<ClientSecretResponse>> RegenerateSecretWithHttpInfoAsync(string clientId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientManagementApi->RegenerateSecret");

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

            var localVarResponse = await AsynchronousClient.PatchAsync<ClientSecretResponse>("/api/2.0/clients/{clientId}/regenerate", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RegenerateSecret", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Revoke client consent
        /// </summary>
        /// <remarks>
        /// Revokes all user consents for the specified OAuth2 client. This will invalidate all access tokens and refresh tokens issued to this client for the current user. The user will need to re-authorize the client to access their resources.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/revoke-user-client/">REST API Reference for RevokeUserClient Operation</seealso>
        /// <returns>Object</returns>
        public Object RevokeUserClient(string clientId)
        {
            var localVarResponse = RevokeUserClientWithHttpInfo(clientId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Revoke client consent
        /// </summary>
        /// <remarks>
        /// Revokes all user consents for the specified OAuth2 client. This will invalidate all access tokens and refresh tokens issued to this client for the current user. The user will need to re-authorize the client to access their resources.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/revoke-user-client/">REST API Reference for RevokeUserClient Operation</seealso>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse<Object> RevokeUserClientWithHttpInfo(string clientId)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientManagementApi->RevokeUserClient");

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
            var localVarResponse = Client.Delete<Object>("/api/2.0/clients/{clientId}/revoke", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RevokeUserClient", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Revoke client consent
        /// </summary>
        /// <remarks>
        /// Revokes all user consents for the specified OAuth2 client. This will invalidate all access tokens and refresh tokens issued to this client for the current user. The user will need to re-authorize the client to access their resources.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/revoke-user-client/">REST API Reference for RevokeUserClient Operation</seealso>
        /// <returns>Task of Object</returns>
        public async Task<Object> RevokeUserClientAsync(string clientId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await RevokeUserClientWithHttpInfoAsync(clientId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Revoke client consent
        /// </summary>
        /// <remarks>
        /// Revokes all user consents for the specified OAuth2 client. This will invalidate all access tokens and refresh tokens issued to this client for the current user. The user will need to re-authorize the client to access their resources.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/revoke-user-client/">REST API Reference for RevokeUserClient Operation</seealso>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async Task<ApiResponse<Object>> RevokeUserClientWithHttpInfoAsync(string clientId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientManagementApi->RevokeUserClient");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<Object>("/api/2.0/clients/{clientId}/revoke", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RevokeUserClient", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update an existing OAuth2 client
        /// </summary>
        /// <remarks>
        /// Updates the configuration of an existing OAuth2 client, allowing modifications to the client name, description, redirect URIs, and other settings. The client ID cannot be modified.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="updateClientRequest">The request for updating client details.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-client/">REST API Reference for UpdateClient Operation</seealso>
        /// <returns>Object</returns>
        public Object UpdateClient(string clientId, UpdateClientRequest updateClientRequest)
        {
            var localVarResponse = UpdateClientWithHttpInfo(clientId, updateClientRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update an existing OAuth2 client
        /// </summary>
        /// <remarks>
        /// Updates the configuration of an existing OAuth2 client, allowing modifications to the client name, description, redirect URIs, and other settings. The client ID cannot be modified.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="updateClientRequest">The request for updating client details.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-client/">REST API Reference for UpdateClient Operation</seealso>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse<Object> UpdateClientWithHttpInfo(string clientId, UpdateClientRequest updateClientRequest)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientManagementApi->UpdateClient");

            // verify the required parameter 'updateClientRequest' is set
            if (updateClientRequest == null)
                throw new ApiException(400, "Missing required parameter 'updateClientRequest' when calling OAuth20ClientManagementApi->UpdateClient");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("clientId", ClientUtils.ParameterToString(clientId)); // path parameter
            if (updateClientRequest != null) localVarRequestOptions.Data = updateClientRequest;

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request
            var localVarResponse = Client.Put<Object>("/api/2.0/clients/{clientId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateClient", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update an existing OAuth2 client
        /// </summary>
        /// <remarks>
        /// Updates the configuration of an existing OAuth2 client, allowing modifications to the client name, description, redirect URIs, and other settings. The client ID cannot be modified.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="updateClientRequest">The request for updating client details.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-client/">REST API Reference for UpdateClient Operation</seealso>
        /// <returns>Task of Object</returns>
        public async Task<Object> UpdateClientAsync(string clientId, UpdateClientRequest updateClientRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateClientWithHttpInfoAsync(clientId, updateClientRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update an existing OAuth2 client
        /// </summary>
        /// <remarks>
        /// Updates the configuration of an existing OAuth2 client, allowing modifications to the client name, description, redirect URIs, and other settings. The client ID cannot be modified.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="updateClientRequest">The request for updating client details.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-client/">REST API Reference for UpdateClient Operation</seealso>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async Task<ApiResponse<Object>> UpdateClientWithHttpInfoAsync(string clientId, UpdateClientRequest updateClientRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientManagementApi->UpdateClient");

            // verify the required parameter 'updateClientRequest' is set
            if (updateClientRequest == null)
                throw new ApiException(400, "Missing required parameter 'updateClientRequest' when calling OAuth20ClientManagementApi->UpdateClient");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("clientId", ClientUtils.ParameterToString(clientId)); // path parameter
            if (updateClientRequest != null) localVarRequestOptions.Data = updateClientRequest;

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<Object>("/api/2.0/clients/{clientId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateClient", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
