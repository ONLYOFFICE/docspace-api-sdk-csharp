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
    public interface IOAuth20ClientQueryingApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get client details
        /// </summary>
        /// <remarks>
        /// Retrieves detailed information about a specific OAuth2 client including its name, description, redirect URIs, and scopes.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-client-info/">REST API Reference for GetPublicClientInfo Operation</seealso>
        /// <returns>ApiResponse of ClientInfoResponse</returns>
        ApiResponse<ClientInfoResponse> GetPublicClientInfoWithHttpInfo(string clientId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOAuth20ClientQueryingApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get client details
        /// </summary>
        /// <remarks>
        /// Retrieves detailed information about a specific OAuth2 client including its name, description, redirect URIs, and scopes.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client/">REST API Reference for GetClient Operation</seealso>
        /// <returns>Task of ClientResponse</returns>
        System.Threading.Tasks.Task<ClientResponse> GetClientAsync(string clientId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get client details
        /// </summary>
        /// <remarks>
        /// Retrieves detailed information about a specific OAuth2 client including its name, description, redirect URIs, and scopes.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client/">REST API Reference for GetClient Operation</seealso>
        /// <returns>Task of ApiResponse (ClientResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ClientResponse>> GetClientWithHttpInfoAsync(string clientId, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get detailed client information
        /// </summary>
        /// <remarks>
        /// Retrieves the detailed information for a client with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client-info/">REST API Reference for GetClientInfo Operation</seealso>
        /// <returns>Task of ClientInfoResponse</returns>
        System.Threading.Tasks.Task<ClientInfoResponse> GetClientInfoAsync(string clientId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get detailed client information
        /// </summary>
        /// <remarks>
        /// Retrieves the detailed information for a client with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client-info/">REST API Reference for GetClientInfo Operation</seealso>
        /// <returns>Task of ApiResponse (ClientInfoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ClientInfoResponse>> GetClientInfoWithHttpInfoAsync(string clientId, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get clients
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of OAuth2 clients. The results can be paginated using the &#39;limit&#39; parameter and the last seen client ID or creation date.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The ID of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients/">REST API Reference for GetClients Operation</seealso>
        /// <returns>Task of PageableResponse</returns>
        System.Threading.Tasks.Task<PageableResponse> GetClientsAsync(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get clients
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of OAuth2 clients. The results can be paginated using the &#39;limit&#39; parameter and the last seen client ID or creation date.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The ID of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients/">REST API Reference for GetClients Operation</seealso>
        /// <returns>Task of ApiResponse (PageableResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageableResponse>> GetClientsWithHttpInfoAsync(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get detailed information of clients
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of information for all clients.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The identifier of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients-info/">REST API Reference for GetClientsInfo Operation</seealso>
        /// <returns>Task of PageableResponseClientInfoResponse</returns>
        System.Threading.Tasks.Task<PageableResponseClientInfoResponse> GetClientsInfoAsync(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get detailed information of clients
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of information for all clients.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The identifier of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients-info/">REST API Reference for GetClientsInfo Operation</seealso>
        /// <returns>Task of ApiResponse (PageableResponseClientInfoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageableResponseClientInfoResponse>> GetClientsInfoWithHttpInfoAsync(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user consents
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of user consents.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastModifiedOn">The date when the user consent was last modified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-consents/">REST API Reference for GetConsents Operation</seealso>
        /// <returns>Task of PageableModificationResponse</returns>
        System.Threading.Tasks.Task<PageableModificationResponse> GetConsentsAsync(int limit, DateTime? lastModifiedOn = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get user consents
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of user consents.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastModifiedOn">The date when the user consent was last modified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-consents/">REST API Reference for GetConsents Operation</seealso>
        /// <returns>Task of ApiResponse (PageableModificationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageableModificationResponse>> GetConsentsWithHttpInfoAsync(int limit, DateTime? lastModifiedOn = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get public client information
        /// </summary>
        /// <remarks>
        /// Returns the public information for a client with the ID secified din the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-client-info/">REST API Reference for GetPublicClientInfo Operation</seealso>
        /// <returns>Task of ClientInfoResponse</returns>
        System.Threading.Tasks.Task<ClientInfoResponse> GetPublicClientInfoAsync(string clientId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get public client information
        /// </summary>
        /// <remarks>
        /// Returns the public information for a client with the ID secified din the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-client-info/">REST API Reference for GetPublicClientInfo Operation</seealso>
        /// <returns>Task of ApiResponse (ClientInfoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ClientInfoResponse>> GetPublicClientInfoWithHttpInfoAsync(string clientId, System.Threading.CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOAuth20ClientQueryingApi : IOAuth20ClientQueryingApiSync, IOAuth20ClientQueryingApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OAuth20ClientQueryingApi : IDisposable, IOAuth20ClientQueryingApi
    {
        private Docspace.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth20ClientQueryingApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public OAuth20ClientQueryingApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth20ClientQueryingApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public OAuth20ClientQueryingApi(string basePath)
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
        /// Initializes a new instance of the <see cref="OAuth20ClientQueryingApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public OAuth20ClientQueryingApi(Docspace.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="OAuth20ClientQueryingApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public OAuth20ClientQueryingApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth20ClientQueryingApi"/> class.
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
        public OAuth20ClientQueryingApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="OAuth20ClientQueryingApi"/> class using Configuration object.
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
        public OAuth20ClientQueryingApi(HttpClient client, Docspace.Client.Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="OAuth20ClientQueryingApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public OAuth20ClientQueryingApi(Docspace.Client.ISynchronousClient client, Docspace.Client.IAsynchronousClient asyncClient, Docspace.Client.IReadableConfiguration configuration)
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
        /// Get client details Retrieves detailed information about a specific OAuth2 client including its name, description, redirect URIs, and scopes.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client/">REST API Reference for GetClient Operation</seealso>
        /// <returns>ClientResponse</returns>
        public ClientResponse GetClient(string clientId)
        {
            Docspace.Client.ApiResponse<ClientResponse> localVarResponse = GetClientWithHttpInfo(clientId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get client details Retrieves detailed information about a specific OAuth2 client including its name, description, redirect URIs, and scopes.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client/">REST API Reference for GetClient Operation</seealso>
        /// <returns>ApiResponse of ClientResponse</returns>
        public Docspace.Client.ApiResponse<ClientResponse> GetClientWithHttpInfo(string clientId)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientQueryingApi->GetClient");

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
            var localVarResponse = this.Client.Get<ClientResponse>("/api/2.0/clients/{clientId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetClient", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get client details Retrieves detailed information about a specific OAuth2 client including its name, description, redirect URIs, and scopes.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client/">REST API Reference for GetClient Operation</seealso>
        /// <returns>Task of ClientResponse</returns>
        public async System.Threading.Tasks.Task<ClientResponse> GetClientAsync(string clientId, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<ClientResponse> localVarResponse = await GetClientWithHttpInfoAsync(clientId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get client details Retrieves detailed information about a specific OAuth2 client including its name, description, redirect URIs, and scopes.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client/">REST API Reference for GetClient Operation</seealso>
        /// <returns>Task of ApiResponse (ClientResponse)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<ClientResponse>> GetClientWithHttpInfoAsync(string clientId, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientQueryingApi->GetClient");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<ClientResponse>("/api/2.0/clients/{clientId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetClient", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get detailed client information Retrieves the detailed information for a client with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client-info/">REST API Reference for GetClientInfo Operation</seealso>
        /// <returns>ClientInfoResponse</returns>
        public ClientInfoResponse GetClientInfo(string clientId)
        {
            Docspace.Client.ApiResponse<ClientInfoResponse> localVarResponse = GetClientInfoWithHttpInfo(clientId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get detailed client information Retrieves the detailed information for a client with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client-info/">REST API Reference for GetClientInfo Operation</seealso>
        /// <returns>ApiResponse of ClientInfoResponse</returns>
        public Docspace.Client.ApiResponse<ClientInfoResponse> GetClientInfoWithHttpInfo(string clientId)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientQueryingApi->GetClientInfo");

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
            var localVarResponse = this.Client.Get<ClientInfoResponse>("/api/2.0/clients/{clientId}/info", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetClientInfo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get detailed client information Retrieves the detailed information for a client with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client-info/">REST API Reference for GetClientInfo Operation</seealso>
        /// <returns>Task of ClientInfoResponse</returns>
        public async System.Threading.Tasks.Task<ClientInfoResponse> GetClientInfoAsync(string clientId, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<ClientInfoResponse> localVarResponse = await GetClientInfoWithHttpInfoAsync(clientId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get detailed client information Retrieves the detailed information for a client with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client-info/">REST API Reference for GetClientInfo Operation</seealso>
        /// <returns>Task of ApiResponse (ClientInfoResponse)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<ClientInfoResponse>> GetClientInfoWithHttpInfoAsync(string clientId, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientQueryingApi->GetClientInfo");


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<ClientInfoResponse>("/api/2.0/clients/{clientId}/info", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetClientInfo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get clients Retrieves a paginated list of OAuth2 clients. The results can be paginated using the &#39;limit&#39; parameter and the last seen client ID or creation date.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The ID of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients/">REST API Reference for GetClients Operation</seealso>
        /// <returns>PageableResponse</returns>
        public PageableResponse GetClients(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default)
        {
            Docspace.Client.ApiResponse<PageableResponse> localVarResponse = GetClientsWithHttpInfo(limit, lastClientId, lastCreatedOn);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get clients Retrieves a paginated list of OAuth2 clients. The results can be paginated using the &#39;limit&#39; parameter and the last seen client ID or creation date.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The ID of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients/">REST API Reference for GetClients Operation</seealso>
        /// <returns>ApiResponse of PageableResponse</returns>
        public Docspace.Client.ApiResponse<PageableResponse> GetClientsWithHttpInfo(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default)
        {
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

            localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            if (lastClientId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "last_client_id", lastClientId));
            }
            if (lastCreatedOn != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "last_created_on", lastCreatedOn));
            }

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<PageableResponse>("/api/2.0/clients", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetClients", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get clients Retrieves a paginated list of OAuth2 clients. The results can be paginated using the &#39;limit&#39; parameter and the last seen client ID or creation date.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The ID of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients/">REST API Reference for GetClients Operation</seealso>
        /// <returns>Task of PageableResponse</returns>
        public async System.Threading.Tasks.Task<PageableResponse> GetClientsAsync(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<PageableResponse> localVarResponse = await GetClientsWithHttpInfoAsync(limit, lastClientId, lastCreatedOn, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get clients Retrieves a paginated list of OAuth2 clients. The results can be paginated using the &#39;limit&#39; parameter and the last seen client ID or creation date.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The ID of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients/">REST API Reference for GetClients Operation</seealso>
        /// <returns>Task of ApiResponse (PageableResponse)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<PageableResponse>> GetClientsWithHttpInfoAsync(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default, System.Threading.CancellationToken cancellationToken = default)
        {

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

            localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            if (lastClientId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "last_client_id", lastClientId));
            }
            if (lastCreatedOn != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "last_created_on", lastCreatedOn));
            }

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<PageableResponse>("/api/2.0/clients", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetClients", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get detailed information of clients Retrieves a paginated list of information for all clients.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The identifier of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients-info/">REST API Reference for GetClientsInfo Operation</seealso>
        /// <returns>PageableResponseClientInfoResponse</returns>
        public PageableResponseClientInfoResponse GetClientsInfo(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default)
        {
            Docspace.Client.ApiResponse<PageableResponseClientInfoResponse> localVarResponse = GetClientsInfoWithHttpInfo(limit, lastClientId, lastCreatedOn);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get detailed information of clients Retrieves a paginated list of information for all clients.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The identifier of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients-info/">REST API Reference for GetClientsInfo Operation</seealso>
        /// <returns>ApiResponse of PageableResponseClientInfoResponse</returns>
        public Docspace.Client.ApiResponse<PageableResponseClientInfoResponse> GetClientsInfoWithHttpInfo(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default)
        {
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

            localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            if (lastClientId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "last_client_id", lastClientId));
            }
            if (lastCreatedOn != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "last_created_on", lastCreatedOn));
            }

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<PageableResponseClientInfoResponse>("/api/2.0/clients/info", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetClientsInfo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get detailed information of clients Retrieves a paginated list of information for all clients.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The identifier of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients-info/">REST API Reference for GetClientsInfo Operation</seealso>
        /// <returns>Task of PageableResponseClientInfoResponse</returns>
        public async System.Threading.Tasks.Task<PageableResponseClientInfoResponse> GetClientsInfoAsync(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<PageableResponseClientInfoResponse> localVarResponse = await GetClientsInfoWithHttpInfoAsync(limit, lastClientId, lastCreatedOn, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get detailed information of clients Retrieves a paginated list of information for all clients.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastClientId">The identifier of the last retrieved client. (optional)</param>
        /// <param name="lastCreatedOn">The creation date of the last retrieved client. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients-info/">REST API Reference for GetClientsInfo Operation</seealso>
        /// <returns>Task of ApiResponse (PageableResponseClientInfoResponse)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<PageableResponseClientInfoResponse>> GetClientsInfoWithHttpInfoAsync(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default, System.Threading.CancellationToken cancellationToken = default)
        {

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

            localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            if (lastClientId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "last_client_id", lastClientId));
            }
            if (lastCreatedOn != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "last_created_on", lastCreatedOn));
            }

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<PageableResponseClientInfoResponse>("/api/2.0/clients/info", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetClientsInfo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get user consents Retrieves a paginated list of user consents.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastModifiedOn">The date when the user consent was last modified. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-consents/">REST API Reference for GetConsents Operation</seealso>
        /// <returns>PageableModificationResponse</returns>
        public PageableModificationResponse GetConsents(int limit, DateTime? lastModifiedOn = default)
        {
            Docspace.Client.ApiResponse<PageableModificationResponse> localVarResponse = GetConsentsWithHttpInfo(limit, lastModifiedOn);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user consents Retrieves a paginated list of user consents.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastModifiedOn">The date when the user consent was last modified. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-consents/">REST API Reference for GetConsents Operation</seealso>
        /// <returns>ApiResponse of PageableModificationResponse</returns>
        public Docspace.Client.ApiResponse<PageableModificationResponse> GetConsentsWithHttpInfo(int limit, DateTime? lastModifiedOn = default)
        {
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

            localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            if (lastModifiedOn != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "last_modified_on", lastModifiedOn));
            }

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<PageableModificationResponse>("/api/2.0/clients/consents", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetConsents", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get user consents Retrieves a paginated list of user consents.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastModifiedOn">The date when the user consent was last modified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-consents/">REST API Reference for GetConsents Operation</seealso>
        /// <returns>Task of PageableModificationResponse</returns>
        public async System.Threading.Tasks.Task<PageableModificationResponse> GetConsentsAsync(int limit, DateTime? lastModifiedOn = default, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<PageableModificationResponse> localVarResponse = await GetConsentsWithHttpInfoAsync(limit, lastModifiedOn, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user consents Retrieves a paginated list of user consents.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">The maximum number of results returned per page.</param>
        /// <param name="lastModifiedOn">The date when the user consent was last modified. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-consents/">REST API Reference for GetConsents Operation</seealso>
        /// <returns>Task of ApiResponse (PageableModificationResponse)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<PageableModificationResponse>> GetConsentsWithHttpInfoAsync(int limit, DateTime? lastModifiedOn = default, System.Threading.CancellationToken cancellationToken = default)
        {

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

            localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            if (lastModifiedOn != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "last_modified_on", lastModifiedOn));
            }

            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<PageableModificationResponse>("/api/2.0/clients/consents", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetConsents", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get public client information Returns the public information for a client with the ID secified din the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-client-info/">REST API Reference for GetPublicClientInfo Operation</seealso>
        /// <returns>ClientInfoResponse</returns>
        public ClientInfoResponse GetPublicClientInfo(string clientId)
        {
            Docspace.Client.ApiResponse<ClientInfoResponse> localVarResponse = GetPublicClientInfoWithHttpInfo(clientId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get public client information Returns the public information for a client with the ID secified din the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-client-info/">REST API Reference for GetPublicClientInfo Operation</seealso>
        /// <returns>ApiResponse of ClientInfoResponse</returns>
        public Docspace.Client.ApiResponse<ClientInfoResponse> GetPublicClientInfoWithHttpInfo(string clientId)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientQueryingApi->GetPublicClientInfo");

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


            // make the HTTP request
            var localVarResponse = this.Client.Get<ClientInfoResponse>("/api/2.0/clients/{clientId}/public/info", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPublicClientInfo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get public client information Returns the public information for a client with the ID secified din the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-client-info/">REST API Reference for GetPublicClientInfo Operation</seealso>
        /// <returns>Task of ClientInfoResponse</returns>
        public async System.Threading.Tasks.Task<ClientInfoResponse> GetPublicClientInfoAsync(string clientId, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<ClientInfoResponse> localVarResponse = await GetPublicClientInfoWithHttpInfoAsync(clientId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get public client information Returns the public information for a client with the ID secified din the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-client-info/">REST API Reference for GetPublicClientInfo Operation</seealso>
        /// <returns>Task of ApiResponse (ClientInfoResponse)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<ClientInfoResponse>> GetPublicClientInfoWithHttpInfoAsync(string clientId, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'clientId' when calling OAuth20ClientQueryingApi->GetPublicClientInfo");


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


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ClientInfoResponse>("/api/2.0/clients/{clientId}/public/info", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPublicClientInfo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
