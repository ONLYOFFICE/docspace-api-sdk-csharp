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
using Docspace.Client;
using Docspace.Model;

namespace Docspace.Api
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
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="changeClientActivationRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-activation/">REST API Reference for ChangeActivation Operation</seealso>
        /// <returns>Object</returns>
        Object ChangeActivation(string clientId, ChangeClientActivationRequest changeClientActivationRequest);

        /// <summary>
        /// Change the client activation status
        /// </summary>
        /// <remarks>
        /// Activates or deactivates an OAuth2 client. When deactivated, the client cannot request new access tokens, but existing tokens will remain valid until they expire.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="changeClientActivationRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-activation/">REST API Reference for ChangeActivation Operation</seealso>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ChangeActivationWithHttpInfo(string clientId, ChangeClientActivationRequest changeClientActivationRequest);
        /// <summary>
        /// Create a new OAuth2 client
        /// </summary>
        /// <remarks>
        /// Creates a new OAuth2 client with the specified configuration. The client will be created with the provided scopes, redirect URIs, and other settings. Returns the created client details including the generated client ID.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createClientRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-client/">REST API Reference for CreateClient Operation</seealso>
        /// <returns>ClientResponse</returns>
        ClientResponse CreateClient(CreateClientRequest createClientRequest);

        /// <summary>
        /// Create a new OAuth2 client
        /// </summary>
        /// <remarks>
        /// Creates a new OAuth2 client with the specified configuration. The client will be created with the provided scopes, redirect URIs, and other settings. Returns the created client details including the generated client ID.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createClientRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-client/">REST API Reference for CreateClient Operation</seealso>
        /// <returns>ApiResponse of ClientResponse</returns>
        ApiResponse<ClientResponse> CreateClientWithHttpInfo(CreateClientRequest createClientRequest);
        /// <summary>
        /// Delete an OAuth2 client
        /// </summary>
        /// <remarks>
        /// Permanently deletes an OAuth2 client and all associated data. All access and refresh tokens issued to this client will be invalidated. This operation cannot be undone.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="updateClientRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-client/">REST API Reference for UpdateClient Operation</seealso>
        /// <returns>Object</returns>
        Object UpdateClient(string clientId, UpdateClientRequest updateClientRequest);

        /// <summary>
        /// Update an existing OAuth2 client
        /// </summary>
        /// <remarks>
        /// Updates the configuration of an existing OAuth2 client, allowing modifications to the client name, description, redirect URIs, and other settings. The client ID cannot be modified.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="updateClientRequest"></param>
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
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="changeClientActivationRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-activation/">REST API Reference for ChangeActivation Operation</seealso>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ChangeActivationAsync(string clientId, ChangeClientActivationRequest changeClientActivationRequest, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Change the client activation status
        /// </summary>
        /// <remarks>
        /// Activates or deactivates an OAuth2 client. When deactivated, the client cannot request new access tokens, but existing tokens will remain valid until they expire.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="changeClientActivationRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-activation/">REST API Reference for ChangeActivation Operation</seealso>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ChangeActivationWithHttpInfoAsync(string clientId, ChangeClientActivationRequest changeClientActivationRequest, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new OAuth2 client
        /// </summary>
        /// <remarks>
        /// Creates a new OAuth2 client with the specified configuration. The client will be created with the provided scopes, redirect URIs, and other settings. Returns the created client details including the generated client ID.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createClientRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-client/">REST API Reference for CreateClient Operation</seealso>
        /// <returns>Task of ClientResponse</returns>
        System.Threading.Tasks.Task<ClientResponse> CreateClientAsync(CreateClientRequest createClientRequest, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new OAuth2 client
        /// </summary>
        /// <remarks>
        /// Creates a new OAuth2 client with the specified configuration. The client will be created with the provided scopes, redirect URIs, and other settings. Returns the created client details including the generated client ID.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createClientRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-client/">REST API Reference for CreateClient Operation</seealso>
        /// <returns>Task of ApiResponse (ClientResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ClientResponse>> CreateClientWithHttpInfoAsync(CreateClientRequest createClientRequest, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an OAuth2 client
        /// </summary>
        /// <remarks>
        /// Permanently deletes an OAuth2 client and all associated data. All access and refresh tokens issued to this client will be invalidated. This operation cannot be undone.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-client/">REST API Reference for DeleteClient Operation</seealso>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DeleteClientAsync(string clientId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete an OAuth2 client
        /// </summary>
        /// <remarks>
        /// Permanently deletes an OAuth2 client and all associated data. All access and refresh tokens issued to this client will be invalidated. This operation cannot be undone.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-client/">REST API Reference for DeleteClient Operation</seealso>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteClientWithHttpInfoAsync(string clientId, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Regenerate the client secret
        /// </summary>
        /// <remarks>
        /// Generates a new client secret for the specified OAuth2 client. The old secret will be immediately invalidated. This operation should be used with caution as it requires updating the secret in all client applications.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/regenerate-secret/">REST API Reference for RegenerateSecret Operation</seealso>
        /// <returns>Task of ClientSecretResponse</returns>
        System.Threading.Tasks.Task<ClientSecretResponse> RegenerateSecretAsync(string clientId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Regenerate the client secret
        /// </summary>
        /// <remarks>
        /// Generates a new client secret for the specified OAuth2 client. The old secret will be immediately invalidated. This operation should be used with caution as it requires updating the secret in all client applications.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/regenerate-secret/">REST API Reference for RegenerateSecret Operation</seealso>
        /// <returns>Task of ApiResponse (ClientSecretResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ClientSecretResponse>> RegenerateSecretWithHttpInfoAsync(string clientId, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke client consent
        /// </summary>
        /// <remarks>
        /// Revokes all user consents for the specified OAuth2 client. This will invalidate all access tokens and refresh tokens issued to this client for the current user. The user will need to re-authorize the client to access their resources.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/revoke-user-client/">REST API Reference for RevokeUserClient Operation</seealso>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> RevokeUserClientAsync(string clientId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Revoke client consent
        /// </summary>
        /// <remarks>
        /// Revokes all user consents for the specified OAuth2 client. This will invalidate all access tokens and refresh tokens issued to this client for the current user. The user will need to re-authorize the client to access their resources.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/revoke-user-client/">REST API Reference for RevokeUserClient Operation</seealso>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RevokeUserClientWithHttpInfoAsync(string clientId, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing OAuth2 client
        /// </summary>
        /// <remarks>
        /// Updates the configuration of an existing OAuth2 client, allowing modifications to the client name, description, redirect URIs, and other settings. The client ID cannot be modified.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="updateClientRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-client/">REST API Reference for UpdateClient Operation</seealso>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> UpdateClientAsync(string clientId, UpdateClientRequest updateClientRequest, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an existing OAuth2 client
        /// </summary>
        /// <remarks>
        /// Updates the configuration of an existing OAuth2 client, allowing modifications to the client name, description, redirect URIs, and other settings. The client ID cannot be modified.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="updateClientRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-client/">REST API Reference for UpdateClient Operation</seealso>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateClientWithHttpInfoAsync(string clientId, UpdateClientRequest updateClientRequest, System.Threading.CancellationToken cancellationToken = default);
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
    public partial class OAuth20ClientManagementApi : IDisposable, IOAuth20ClientManagementApi
    {
        private Docspace.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

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
            this.Configuration = Docspace.Client.Configuration.MergeConfigurations(
                Docspace.Client.GlobalConfiguration.Instance,
                new Docspace.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new Docspace.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Docspace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth20ClientManagementApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public OAuth20ClientManagementApi(Docspace.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Docspace.Client.Configuration.MergeConfigurations(
                Docspace.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new Docspace.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Docspace.Client.Configuration.DefaultExceptionFactory;
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
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = Docspace.Client.Configuration.MergeConfigurations(
                Docspace.Client.GlobalConfiguration.Instance,
                new Docspace.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new Docspace.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Docspace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth20ClientManagementApi"/> class using Configuration object.
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
        public OAuth20ClientManagementApi(HttpClient client, Docspace.Client.Configuration configuration, HttpClientHandler handler = null)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = Docspace.Client.Configuration.MergeConfigurations(
                Docspace.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new Docspace.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Docspace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth20ClientManagementApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public OAuth20ClientManagementApi(Docspace.Client.ISynchronousClient client, Docspace.Client.IAsynchronousClient asyncClient, Docspace.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Docspace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient?.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public Docspace.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Docspace.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Docspace.Client.ISynchronousClient Client { get; set; }

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
        public Docspace.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Docspace.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Change the client activation status Activates or deactivates an OAuth2 client. When deactivated, the client cannot request new access tokens, but existing tokens will remain valid until they expire.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="changeClientActivationRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-activation/">REST API Reference for ChangeActivation Operation</seealso>
        /// <returns>Object</returns>
        public Object ChangeActivation(string clientId, ChangeClientActivationRequest changeClientActivationRequest)
        {
            Docspace.Client.ApiResponse<Object> localVarResponse = ChangeActivationWithHttpInfo(clientId, changeClientActivationRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the client activation status Activates or deactivates an OAuth2 client. When deactivated, the client cannot request new access tokens, but existing tokens will remain valid until they expire.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="changeClientActivationRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-activation/">REST API Reference for ChangeActivation Operation</seealso>
        /// <returns>ApiResponse of Object</returns>
        public Docspace.Client.ApiResponse<Object> ChangeActivationWithHttpInfo(string clientId, ChangeClientActivationRequest changeClientActivationRequest)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientManagementApi->ChangeActivation");

            // verify the required parameter 'changeClientActivationRequest' is set
            if (changeClientActivationRequest == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'changeClientActivationRequest' when calling OAuth20ClientManagementApi->ChangeActivation");

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("clientId", Docspace.Client.ClientUtils.ParameterToString(clientId)); // path parameter
            localVarRequestOptions.Data = changeClientActivationRequest;

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Patch<Object>("/api/2.0/clients/{clientId}/activation", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ChangeActivation", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the client activation status Activates or deactivates an OAuth2 client. When deactivated, the client cannot request new access tokens, but existing tokens will remain valid until they expire.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="changeClientActivationRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-activation/">REST API Reference for ChangeActivation Operation</seealso>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ChangeActivationAsync(string clientId, ChangeClientActivationRequest changeClientActivationRequest, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<Object> localVarResponse = await ChangeActivationWithHttpInfoAsync(clientId, changeClientActivationRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the client activation status Activates or deactivates an OAuth2 client. When deactivated, the client cannot request new access tokens, but existing tokens will remain valid until they expire.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="changeClientActivationRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-activation/">REST API Reference for ChangeActivation Operation</seealso>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<Object>> ChangeActivationWithHttpInfoAsync(string clientId, ChangeClientActivationRequest changeClientActivationRequest, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientManagementApi->ChangeActivation");

            // verify the required parameter 'changeClientActivationRequest' is set
            if (changeClientActivationRequest == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'changeClientActivationRequest' when calling OAuth20ClientManagementApi->ChangeActivation");


            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("clientId", Docspace.Client.ClientUtils.ParameterToString(clientId)); // path parameter
            localVarRequestOptions.Data = changeClientActivationRequest;

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PatchAsync<Object>("/api/2.0/clients/{clientId}/activation", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ChangeActivation", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a new OAuth2 client Creates a new OAuth2 client with the specified configuration. The client will be created with the provided scopes, redirect URIs, and other settings. Returns the created client details including the generated client ID.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createClientRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-client/">REST API Reference for CreateClient Operation</seealso>
        /// <returns>ClientResponse</returns>
        public ClientResponse CreateClient(CreateClientRequest createClientRequest)
        {
            Docspace.Client.ApiResponse<ClientResponse> localVarResponse = CreateClientWithHttpInfo(createClientRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new OAuth2 client Creates a new OAuth2 client with the specified configuration. The client will be created with the provided scopes, redirect URIs, and other settings. Returns the created client details including the generated client ID.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createClientRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-client/">REST API Reference for CreateClient Operation</seealso>
        /// <returns>ApiResponse of ClientResponse</returns>
        public Docspace.Client.ApiResponse<ClientResponse> CreateClientWithHttpInfo(CreateClientRequest createClientRequest)
        {
            // verify the required parameter 'createClientRequest' is set
            if (createClientRequest == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'createClientRequest' when calling OAuth20ClientManagementApi->CreateClient");

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = createClientRequest;

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<ClientResponse>("/api/2.0/clients", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateClient", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a new OAuth2 client Creates a new OAuth2 client with the specified configuration. The client will be created with the provided scopes, redirect URIs, and other settings. Returns the created client details including the generated client ID.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createClientRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-client/">REST API Reference for CreateClient Operation</seealso>
        /// <returns>Task of ClientResponse</returns>
        public async System.Threading.Tasks.Task<ClientResponse> CreateClientAsync(CreateClientRequest createClientRequest, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<ClientResponse> localVarResponse = await CreateClientWithHttpInfoAsync(createClientRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new OAuth2 client Creates a new OAuth2 client with the specified configuration. The client will be created with the provided scopes, redirect URIs, and other settings. Returns the created client details including the generated client ID.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createClientRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-client/">REST API Reference for CreateClient Operation</seealso>
        /// <returns>Task of ApiResponse (ClientResponse)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<ClientResponse>> CreateClientWithHttpInfoAsync(CreateClientRequest createClientRequest, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'createClientRequest' is set
            if (createClientRequest == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'createClientRequest' when calling OAuth20ClientManagementApi->CreateClient");


            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = createClientRequest;

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<ClientResponse>("/api/2.0/clients", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateClient", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete an OAuth2 client Permanently deletes an OAuth2 client and all associated data. All access and refresh tokens issued to this client will be invalidated. This operation cannot be undone.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-client/">REST API Reference for DeleteClient Operation</seealso>
        /// <returns>Object</returns>
        public Object DeleteClient(string clientId)
        {
            Docspace.Client.ApiResponse<Object> localVarResponse = DeleteClientWithHttpInfo(clientId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an OAuth2 client Permanently deletes an OAuth2 client and all associated data. All access and refresh tokens issued to this client will be invalidated. This operation cannot be undone.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-client/">REST API Reference for DeleteClient Operation</seealso>
        /// <returns>ApiResponse of Object</returns>
        public Docspace.Client.ApiResponse<Object> DeleteClientWithHttpInfo(string clientId)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientManagementApi->DeleteClient");

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("clientId", Docspace.Client.ClientUtils.ParameterToString(clientId)); // path parameter

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/api/2.0/clients/{clientId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteClient", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete an OAuth2 client Permanently deletes an OAuth2 client and all associated data. All access and refresh tokens issued to this client will be invalidated. This operation cannot be undone.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-client/">REST API Reference for DeleteClient Operation</seealso>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DeleteClientAsync(string clientId, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<Object> localVarResponse = await DeleteClientWithHttpInfoAsync(clientId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an OAuth2 client Permanently deletes an OAuth2 client and all associated data. All access and refresh tokens issued to this client will be invalidated. This operation cannot be undone.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-client/">REST API Reference for DeleteClient Operation</seealso>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<Object>> DeleteClientWithHttpInfoAsync(string clientId, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientManagementApi->DeleteClient");


            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("clientId", Docspace.Client.ClientUtils.ParameterToString(clientId)); // path parameter

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/api/2.0/clients/{clientId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteClient", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Regenerate the client secret Generates a new client secret for the specified OAuth2 client. The old secret will be immediately invalidated. This operation should be used with caution as it requires updating the secret in all client applications.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/regenerate-secret/">REST API Reference for RegenerateSecret Operation</seealso>
        /// <returns>ClientSecretResponse</returns>
        public ClientSecretResponse RegenerateSecret(string clientId)
        {
            Docspace.Client.ApiResponse<ClientSecretResponse> localVarResponse = RegenerateSecretWithHttpInfo(clientId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Regenerate the client secret Generates a new client secret for the specified OAuth2 client. The old secret will be immediately invalidated. This operation should be used with caution as it requires updating the secret in all client applications.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/regenerate-secret/">REST API Reference for RegenerateSecret Operation</seealso>
        /// <returns>ApiResponse of ClientSecretResponse</returns>
        public Docspace.Client.ApiResponse<ClientSecretResponse> RegenerateSecretWithHttpInfo(string clientId)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientManagementApi->RegenerateSecret");

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("clientId", Docspace.Client.ClientUtils.ParameterToString(clientId)); // path parameter

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Patch<ClientSecretResponse>("/api/2.0/clients/{clientId}/regenerate", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RegenerateSecret", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Regenerate the client secret Generates a new client secret for the specified OAuth2 client. The old secret will be immediately invalidated. This operation should be used with caution as it requires updating the secret in all client applications.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/regenerate-secret/">REST API Reference for RegenerateSecret Operation</seealso>
        /// <returns>Task of ClientSecretResponse</returns>
        public async System.Threading.Tasks.Task<ClientSecretResponse> RegenerateSecretAsync(string clientId, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<ClientSecretResponse> localVarResponse = await RegenerateSecretWithHttpInfoAsync(clientId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Regenerate the client secret Generates a new client secret for the specified OAuth2 client. The old secret will be immediately invalidated. This operation should be used with caution as it requires updating the secret in all client applications.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/regenerate-secret/">REST API Reference for RegenerateSecret Operation</seealso>
        /// <returns>Task of ApiResponse (ClientSecretResponse)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<ClientSecretResponse>> RegenerateSecretWithHttpInfoAsync(string clientId, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientManagementApi->RegenerateSecret");


            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("clientId", Docspace.Client.ClientUtils.ParameterToString(clientId)); // path parameter

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PatchAsync<ClientSecretResponse>("/api/2.0/clients/{clientId}/regenerate", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RegenerateSecret", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Revoke client consent Revokes all user consents for the specified OAuth2 client. This will invalidate all access tokens and refresh tokens issued to this client for the current user. The user will need to re-authorize the client to access their resources.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/revoke-user-client/">REST API Reference for RevokeUserClient Operation</seealso>
        /// <returns>Object</returns>
        public Object RevokeUserClient(string clientId)
        {
            Docspace.Client.ApiResponse<Object> localVarResponse = RevokeUserClientWithHttpInfo(clientId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Revoke client consent Revokes all user consents for the specified OAuth2 client. This will invalidate all access tokens and refresh tokens issued to this client for the current user. The user will need to re-authorize the client to access their resources.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/revoke-user-client/">REST API Reference for RevokeUserClient Operation</seealso>
        /// <returns>ApiResponse of Object</returns>
        public Docspace.Client.ApiResponse<Object> RevokeUserClientWithHttpInfo(string clientId)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientManagementApi->RevokeUserClient");

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("clientId", Docspace.Client.ClientUtils.ParameterToString(clientId)); // path parameter

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/api/2.0/clients/{clientId}/revoke", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RevokeUserClient", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Revoke client consent Revokes all user consents for the specified OAuth2 client. This will invalidate all access tokens and refresh tokens issued to this client for the current user. The user will need to re-authorize the client to access their resources.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/revoke-user-client/">REST API Reference for RevokeUserClient Operation</seealso>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> RevokeUserClientAsync(string clientId, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<Object> localVarResponse = await RevokeUserClientWithHttpInfoAsync(clientId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Revoke client consent Revokes all user consents for the specified OAuth2 client. This will invalidate all access tokens and refresh tokens issued to this client for the current user. The user will need to re-authorize the client to access their resources.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/revoke-user-client/">REST API Reference for RevokeUserClient Operation</seealso>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<Object>> RevokeUserClientWithHttpInfoAsync(string clientId, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientManagementApi->RevokeUserClient");


            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("clientId", Docspace.Client.ClientUtils.ParameterToString(clientId)); // path parameter

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/api/2.0/clients/{clientId}/revoke", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RevokeUserClient", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update an existing OAuth2 client Updates the configuration of an existing OAuth2 client, allowing modifications to the client name, description, redirect URIs, and other settings. The client ID cannot be modified.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="updateClientRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-client/">REST API Reference for UpdateClient Operation</seealso>
        /// <returns>Object</returns>
        public Object UpdateClient(string clientId, UpdateClientRequest updateClientRequest)
        {
            Docspace.Client.ApiResponse<Object> localVarResponse = UpdateClientWithHttpInfo(clientId, updateClientRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update an existing OAuth2 client Updates the configuration of an existing OAuth2 client, allowing modifications to the client name, description, redirect URIs, and other settings. The client ID cannot be modified.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="updateClientRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-client/">REST API Reference for UpdateClient Operation</seealso>
        /// <returns>ApiResponse of Object</returns>
        public Docspace.Client.ApiResponse<Object> UpdateClientWithHttpInfo(string clientId, UpdateClientRequest updateClientRequest)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientManagementApi->UpdateClient");

            // verify the required parameter 'updateClientRequest' is set
            if (updateClientRequest == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'updateClientRequest' when calling OAuth20ClientManagementApi->UpdateClient");

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("clientId", Docspace.Client.ClientUtils.ParameterToString(clientId)); // path parameter
            localVarRequestOptions.Data = updateClientRequest;

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<Object>("/api/2.0/clients/{clientId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateClient", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update an existing OAuth2 client Updates the configuration of an existing OAuth2 client, allowing modifications to the client name, description, redirect URIs, and other settings. The client ID cannot be modified.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="updateClientRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-client/">REST API Reference for UpdateClient Operation</seealso>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> UpdateClientAsync(string clientId, UpdateClientRequest updateClientRequest, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<Object> localVarResponse = await UpdateClientWithHttpInfoAsync(clientId, updateClientRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update an existing OAuth2 client Updates the configuration of an existing OAuth2 client, allowing modifications to the client name, description, redirect URIs, and other settings. The client ID cannot be modified.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="updateClientRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-client/">REST API Reference for UpdateClient Operation</seealso>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<Object>> UpdateClientWithHttpInfoAsync(string clientId, UpdateClientRequest updateClientRequest, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientManagementApi->UpdateClient");

            // verify the required parameter 'updateClientRequest' is set
            if (updateClientRequest == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'updateClientRequest' when calling OAuth20ClientManagementApi->UpdateClient");


            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("clientId", Docspace.Client.ClientUtils.ParameterToString(clientId)); // path parameter
            localVarRequestOptions.Data = updateClientRequest;

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<Object>("/api/2.0/clients/{clientId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateClient", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
