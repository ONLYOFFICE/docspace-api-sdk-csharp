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
    public interface IClientQueryingApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get client details
        /// </summary>
        /// <remarks>
        /// Returns the whole stored record of one client: its name and description, its secret, scopes, redirect URIs, allowed origins, logout redirect URIs and audit fields. An administrator sees any client of the tenant, a plain user only the clients they created, and a guest none of them. Whatever the caller may not see is reported as 404 rather than 403, so absence and lack of access are deliberately indistinguishable, and an identifier that is not a valid client ID is reported the same way. The response is a single object, not a collection.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client/">REST API Reference for GetClient Operation</seealso>
        /// <returns>ClientResponse</returns>
        ClientResponse GetClient(string clientId);

        /// <summary>
        /// Get client details
        /// </summary>
        /// <remarks>
        /// Returns the whole stored record of one client: its name and description, its secret, scopes, redirect URIs, allowed origins, logout redirect URIs and audit fields. An administrator sees any client of the tenant, a plain user only the clients they created, and a guest none of them. Whatever the caller may not see is reported as 404 rather than 403, so absence and lack of access are deliberately indistinguishable, and an identifier that is not a valid client ID is reported the same way. The response is a single object, not a collection.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client/">REST API Reference for GetClient Operation</seealso>
        /// <returns>ApiResponse of ClientResponse</returns>
        ApiResponse<ClientResponse> GetClientWithHttpInfo(string clientId);
        /// <summary>
        /// Get client info
        /// </summary>
        /// <remarks>
        /// Retrieves the detailed information for a client with the ID specified in the request. It returns the consent-facing subset of the client - name, description, logo, the website, terms and policy URLs, authentication methods and scopes - and deliberately omits the secret, the redirect URIs and the allowed origins, which is what makes it safe to render on a consent screen. An administrator sees any client of the tenant, a plain user only the clients they created, and a guest none of them. A client the caller may not see is reported as 404, exactly like an unknown one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client-info/">REST API Reference for GetClientInfo Operation</seealso>
        /// <returns>ClientInfoResponse</returns>
        ClientInfoResponse GetClientInfo(string clientId);

        /// <summary>
        /// Get client info
        /// </summary>
        /// <remarks>
        /// Retrieves the detailed information for a client with the ID specified in the request. It returns the consent-facing subset of the client - name, description, logo, the website, terms and policy URLs, authentication methods and scopes - and deliberately omits the secret, the redirect URIs and the allowed origins, which is what makes it safe to render on a consent screen. An administrator sees any client of the tenant, a plain user only the clients they created, and a guest none of them. A client the caller may not see is reported as 404, exactly like an unknown one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client-info/">REST API Reference for GetClientInfo Operation</seealso>
        /// <returns>ApiResponse of ClientInfoResponse</returns>
        ApiResponse<ClientInfoResponse> GetClientInfoWithHttpInfo(string clientId);
        /// <summary>
        /// List clients
        /// </summary>
        /// <remarks>
        /// Returns one page of the tenant's clients, newest first, each in the same full form as the single-client read. An administrator sees every client of the tenant, a plain user only the clients they created. Paging is keyset-based rather than offset-based: limit sets the page size, and last_client_id and last_created_on are carried over from the previous page to ask for the next one. The limit defaults to 30 and has to lie between 1 and 50; a value outside that range, or a last_created_on that cannot be parsed as a date, is rejected with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. Defaults to 30 when omitted. (optional, default to 30)</param>
        /// <param name="lastClientId">ID of the last retrieved client (optional)</param>
        /// <param name="lastCreatedOn">Date of the last retrieved client (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients/">REST API Reference for GetClients Operation</seealso>
        /// <returns>PageableClientResponse</returns>
        PageableClientResponse GetClients(int? limit = default, string? lastClientId = default, DateTime? lastCreatedOn = default);

        /// <summary>
        /// List clients
        /// </summary>
        /// <remarks>
        /// Returns one page of the tenant's clients, newest first, each in the same full form as the single-client read. An administrator sees every client of the tenant, a plain user only the clients they created. Paging is keyset-based rather than offset-based: limit sets the page size, and last_client_id and last_created_on are carried over from the previous page to ask for the next one. The limit defaults to 30 and has to lie between 1 and 50; a value outside that range, or a last_created_on that cannot be parsed as a date, is rejected with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. Defaults to 30 when omitted. (optional, default to 30)</param>
        /// <param name="lastClientId">ID of the last retrieved client (optional)</param>
        /// <param name="lastCreatedOn">Date of the last retrieved client (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients/">REST API Reference for GetClients Operation</seealso>
        /// <returns>ApiResponse of PageableClientResponse</returns>
        ApiResponse<PageableClientResponse> GetClientsWithHttpInfo(int? limit = default, string? lastClientId = default, DateTime? lastCreatedOn = default);
        /// <summary>
        /// List client info
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of information for all clients, each in the same consent-facing form as the single-client info read. An administrator sees every client of the tenant, a plain user only the clients they created. Paging is keyset-based: limit sets the page size, and last_client_id and last_created_on are carried over from the previous page. Unlike the full client listing, limit has no default here - it has to be supplied on every call and has to lie between 1 and 50, and a missing or out-of-range value is rejected with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. It has no default and has to be sent on every call.</param>
        /// <param name="lastClientId">ID of the last retrieved client (optional)</param>
        /// <param name="lastCreatedOn">Date of the last retrieved client (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients-info/">REST API Reference for GetClientsInfo Operation</seealso>
        /// <returns>PageableClientInfoResponse</returns>
        PageableClientInfoResponse GetClientsInfo(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default);

        /// <summary>
        /// List client info
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of information for all clients, each in the same consent-facing form as the single-client info read. An administrator sees every client of the tenant, a plain user only the clients they created. Paging is keyset-based: limit sets the page size, and last_client_id and last_created_on are carried over from the previous page. Unlike the full client listing, limit has no default here - it has to be supplied on every call and has to lie between 1 and 50, and a missing or out-of-range value is rejected with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. It has no default and has to be sent on every call.</param>
        /// <param name="lastClientId">ID of the last retrieved client (optional)</param>
        /// <param name="lastCreatedOn">Date of the last retrieved client (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients-info/">REST API Reference for GetClientsInfo Operation</seealso>
        /// <returns>ApiResponse of PageableClientInfoResponse</returns>
        ApiResponse<PageableClientInfoResponse> GetClientsInfoWithHttpInfo(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default);
        /// <summary>
        /// List user consents
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of user consents: the clients the calling user has authorized, each with the scopes granted, the moment the consent was last changed and the client's consent-facing details. It always reports the caller's own consents and nothing else - there is no role check on this endpoint, so guests may call it too, and no parameter widens it to another user. The consents are read from the authorization service over gRPC, so an authorization service that cannot be reached surfaces as 503. Paging is keyset-based on last_modified_on, and limit has no default: it has to be supplied on every call and has to lie between 1 and 50.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. It has no default and has to be sent on every call.</param>
        /// <param name="lastModifiedOn">Date of the last retrieved consent (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-consents/">REST API Reference for GetConsents Operation</seealso>
        /// <returns>PageableModificationResponse</returns>
        PageableModificationResponse GetConsents(int limit, DateTime? lastModifiedOn = default);

        /// <summary>
        /// List user consents
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of user consents: the clients the calling user has authorized, each with the scopes granted, the moment the consent was last changed and the client's consent-facing details. It always reports the caller's own consents and nothing else - there is no role check on this endpoint, so guests may call it too, and no parameter widens it to another user. The consents are read from the authorization service over gRPC, so an authorization service that cannot be reached surfaces as 503. Paging is keyset-based on last_modified_on, and limit has no default: it has to be supplied on every call and has to lie between 1 and 50.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. It has no default and has to be sent on every call.</param>
        /// <param name="lastModifiedOn">Date of the last retrieved consent (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-consents/">REST API Reference for GetConsents Operation</seealso>
        /// <returns>ApiResponse of PageableModificationResponse</returns>
        ApiResponse<PageableModificationResponse> GetConsentsWithHttpInfo(int limit, DateTime? lastModifiedOn = default);
        /// <summary>
        /// Get public client info
        /// </summary>
        /// <remarks>
        /// Returns the same consent-facing client information as the signed read, but without requiring a portal signature. It is meant for a login or consent page that has to render the client before the user is known, so it resolves the client by ID alone: there is no authentication, no tenant scoping and no creator check, and any caller who knows a client ID can read that client's public details. It still exposes no secret, no redirect URIs and no allowed origins. Being unauthenticated it is rate-limited on a separate, tighter budget than the signed endpoints. An unknown client ID, and an identifier that is not a client ID at all, are both reported as 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-client-info/">REST API Reference for GetPublicClientInfo Operation</seealso>
        /// <returns>ClientInfoResponse</returns>
        ClientInfoResponse GetPublicClientInfo(string clientId);

        /// <summary>
        /// Get public client info
        /// </summary>
        /// <remarks>
        /// Returns the same consent-facing client information as the signed read, but without requiring a portal signature. It is meant for a login or consent page that has to render the client before the user is known, so it resolves the client by ID alone: there is no authentication, no tenant scoping and no creator check, and any caller who knows a client ID can read that client's public details. It still exposes no secret, no redirect URIs and no allowed origins. Being unauthenticated it is rate-limited on a separate, tighter budget than the signed endpoints. An unknown client ID, and an identifier that is not a client ID at all, are both reported as 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
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
        /// Returns the whole stored record of one client: its name and description, its secret, scopes, redirect URIs, allowed origins, logout redirect URIs and audit fields. An administrator sees any client of the tenant, a plain user only the clients they created, and a guest none of them. Whatever the caller may not see is reported as 404 rather than 403, so absence and lack of access are deliberately indistinguishable, and an identifier that is not a valid client ID is reported the same way. The response is a single object, not a collection.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client/">REST API Reference for GetClient Operation</seealso>
        /// <returns>Task of ClientResponse</returns>
        Task<ClientResponse> GetClientAsync(string clientId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get client details
        /// </summary>
        /// <remarks>
        /// Returns the whole stored record of one client: its name and description, its secret, scopes, redirect URIs, allowed origins, logout redirect URIs and audit fields. An administrator sees any client of the tenant, a plain user only the clients they created, and a guest none of them. Whatever the caller may not see is reported as 404 rather than 403, so absence and lack of access are deliberately indistinguishable, and an identifier that is not a valid client ID is reported the same way. The response is a single object, not a collection.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client/">REST API Reference for GetClient Operation</seealso>
        /// <returns>Task of ApiResponse (ClientResponse)</returns>
        Task<ApiResponse<ClientResponse>> GetClientWithHttpInfoAsync(string clientId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get client info
        /// </summary>
        /// <remarks>
        /// Retrieves the detailed information for a client with the ID specified in the request. It returns the consent-facing subset of the client - name, description, logo, the website, terms and policy URLs, authentication methods and scopes - and deliberately omits the secret, the redirect URIs and the allowed origins, which is what makes it safe to render on a consent screen. An administrator sees any client of the tenant, a plain user only the clients they created, and a guest none of them. A client the caller may not see is reported as 404, exactly like an unknown one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client-info/">REST API Reference for GetClientInfo Operation</seealso>
        /// <returns>Task of ClientInfoResponse</returns>
        Task<ClientInfoResponse> GetClientInfoAsync(string clientId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get client info
        /// </summary>
        /// <remarks>
        /// Retrieves the detailed information for a client with the ID specified in the request. It returns the consent-facing subset of the client - name, description, logo, the website, terms and policy URLs, authentication methods and scopes - and deliberately omits the secret, the redirect URIs and the allowed origins, which is what makes it safe to render on a consent screen. An administrator sees any client of the tenant, a plain user only the clients they created, and a guest none of them. A client the caller may not see is reported as 404, exactly like an unknown one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client-info/">REST API Reference for GetClientInfo Operation</seealso>
        /// <returns>Task of ApiResponse (ClientInfoResponse)</returns>
        Task<ApiResponse<ClientInfoResponse>> GetClientInfoWithHttpInfoAsync(string clientId, CancellationToken cancellationToken = default);
        /// <summary>
        /// List clients
        /// </summary>
        /// <remarks>
        /// Returns one page of the tenant's clients, newest first, each in the same full form as the single-client read. An administrator sees every client of the tenant, a plain user only the clients they created. Paging is keyset-based rather than offset-based: limit sets the page size, and last_client_id and last_created_on are carried over from the previous page to ask for the next one. The limit defaults to 30 and has to lie between 1 and 50; a value outside that range, or a last_created_on that cannot be parsed as a date, is rejected with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. Defaults to 30 when omitted. (optional, default to 30)</param>
        /// <param name="lastClientId">ID of the last retrieved client (optional)</param>
        /// <param name="lastCreatedOn">Date of the last retrieved client (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients/">REST API Reference for GetClients Operation</seealso>
        /// <returns>Task of PageableClientResponse</returns>
        Task<PageableClientResponse> GetClientsAsync(int? limit = default, string? lastClientId = default, DateTime? lastCreatedOn = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// List clients
        /// </summary>
        /// <remarks>
        /// Returns one page of the tenant's clients, newest first, each in the same full form as the single-client read. An administrator sees every client of the tenant, a plain user only the clients they created. Paging is keyset-based rather than offset-based: limit sets the page size, and last_client_id and last_created_on are carried over from the previous page to ask for the next one. The limit defaults to 30 and has to lie between 1 and 50; a value outside that range, or a last_created_on that cannot be parsed as a date, is rejected with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. Defaults to 30 when omitted. (optional, default to 30)</param>
        /// <param name="lastClientId">ID of the last retrieved client (optional)</param>
        /// <param name="lastCreatedOn">Date of the last retrieved client (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients/">REST API Reference for GetClients Operation</seealso>
        /// <returns>Task of ApiResponse (PageableClientResponse)</returns>
        Task<ApiResponse<PageableClientResponse>> GetClientsWithHttpInfoAsync(int? limit = default, string? lastClientId = default, DateTime? lastCreatedOn = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// List client info
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of information for all clients, each in the same consent-facing form as the single-client info read. An administrator sees every client of the tenant, a plain user only the clients they created. Paging is keyset-based: limit sets the page size, and last_client_id and last_created_on are carried over from the previous page. Unlike the full client listing, limit has no default here - it has to be supplied on every call and has to lie between 1 and 50, and a missing or out-of-range value is rejected with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. It has no default and has to be sent on every call.</param>
        /// <param name="lastClientId">ID of the last retrieved client (optional)</param>
        /// <param name="lastCreatedOn">Date of the last retrieved client (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients-info/">REST API Reference for GetClientsInfo Operation</seealso>
        /// <returns>Task of PageableClientInfoResponse</returns>
        Task<PageableClientInfoResponse> GetClientsInfoAsync(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// List client info
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of information for all clients, each in the same consent-facing form as the single-client info read. An administrator sees every client of the tenant, a plain user only the clients they created. Paging is keyset-based: limit sets the page size, and last_client_id and last_created_on are carried over from the previous page. Unlike the full client listing, limit has no default here - it has to be supplied on every call and has to lie between 1 and 50, and a missing or out-of-range value is rejected with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. It has no default and has to be sent on every call.</param>
        /// <param name="lastClientId">ID of the last retrieved client (optional)</param>
        /// <param name="lastCreatedOn">Date of the last retrieved client (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients-info/">REST API Reference for GetClientsInfo Operation</seealso>
        /// <returns>Task of ApiResponse (PageableClientInfoResponse)</returns>
        Task<ApiResponse<PageableClientInfoResponse>> GetClientsInfoWithHttpInfoAsync(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// List user consents
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of user consents: the clients the calling user has authorized, each with the scopes granted, the moment the consent was last changed and the client's consent-facing details. It always reports the caller's own consents and nothing else - there is no role check on this endpoint, so guests may call it too, and no parameter widens it to another user. The consents are read from the authorization service over gRPC, so an authorization service that cannot be reached surfaces as 503. Paging is keyset-based on last_modified_on, and limit has no default: it has to be supplied on every call and has to lie between 1 and 50.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. It has no default and has to be sent on every call.</param>
        /// <param name="lastModifiedOn">Date of the last retrieved consent (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-consents/">REST API Reference for GetConsents Operation</seealso>
        /// <returns>Task of PageableModificationResponse</returns>
        Task<PageableModificationResponse> GetConsentsAsync(int limit, DateTime? lastModifiedOn = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// List user consents
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of user consents: the clients the calling user has authorized, each with the scopes granted, the moment the consent was last changed and the client's consent-facing details. It always reports the caller's own consents and nothing else - there is no role check on this endpoint, so guests may call it too, and no parameter widens it to another user. The consents are read from the authorization service over gRPC, so an authorization service that cannot be reached surfaces as 503. Paging is keyset-based on last_modified_on, and limit has no default: it has to be supplied on every call and has to lie between 1 and 50.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. It has no default and has to be sent on every call.</param>
        /// <param name="lastModifiedOn">Date of the last retrieved consent (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-consents/">REST API Reference for GetConsents Operation</seealso>
        /// <returns>Task of ApiResponse (PageableModificationResponse)</returns>
        Task<ApiResponse<PageableModificationResponse>> GetConsentsWithHttpInfoAsync(int limit, DateTime? lastModifiedOn = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get public client info
        /// </summary>
        /// <remarks>
        /// Returns the same consent-facing client information as the signed read, but without requiring a portal signature. It is meant for a login or consent page that has to render the client before the user is known, so it resolves the client by ID alone: there is no authentication, no tenant scoping and no creator check, and any caller who knows a client ID can read that client's public details. It still exposes no secret, no redirect URIs and no allowed origins. Being unauthenticated it is rate-limited on a separate, tighter budget than the signed endpoints. An unknown client ID, and an identifier that is not a client ID at all, are both reported as 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-client-info/">REST API Reference for GetPublicClientInfo Operation</seealso>
        /// <returns>Task of ClientInfoResponse</returns>
        Task<ClientInfoResponse> GetPublicClientInfoAsync(string clientId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get public client info
        /// </summary>
        /// <remarks>
        /// Returns the same consent-facing client information as the signed read, but without requiring a portal signature. It is meant for a login or consent page that has to render the client before the user is known, so it resolves the client by ID alone: there is no authentication, no tenant scoping and no creator check, and any caller who knows a client ID can read that client's public details. It still exposes no secret, no redirect URIs and no allowed origins. Being unauthenticated it is rate-limited on a separate, tighter budget than the signed endpoints. An unknown client ID, and an identifier that is not a client ID at all, are both reported as 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
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
        /// Returns the whole stored record of one client: its name and description, its secret, scopes, redirect URIs, allowed origins, logout redirect URIs and audit fields. An administrator sees any client of the tenant, a plain user only the clients they created, and a guest none of them. Whatever the caller may not see is reported as 404 rather than 403, so absence and lack of access are deliberately indistinguishable, and an identifier that is not a valid client ID is reported the same way. The response is a single object, not a collection.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
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
        /// Returns the whole stored record of one client: its name and description, its secret, scopes, redirect URIs, allowed origins, logout redirect URIs and audit fields. An administrator sees any client of the tenant, a plain user only the clients they created, and a guest none of them. Whatever the caller may not see is reported as 404 rather than 403, so absence and lack of access are deliberately indistinguishable, and an identifier that is not a valid client ID is reported the same way. The response is a single object, not a collection.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
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

            // authentication (x-signature) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("x-signature")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("x-signature", Configuration.GetApiKeyWithPrefix("x-signature")));
            }

            // make the HTTP request
            var localVarResponse = Client.Get<ClientResponse>("/api/2.0/oauth2/clients/{clientId}", localVarRequestOptions, Configuration);

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
        /// Returns the whole stored record of one client: its name and description, its secret, scopes, redirect URIs, allowed origins, logout redirect URIs and audit fields. An administrator sees any client of the tenant, a plain user only the clients they created, and a guest none of them. Whatever the caller may not see is reported as 404 rather than 403, so absence and lack of access are deliberately indistinguishable, and an identifier that is not a valid client ID is reported the same way. The response is a single object, not a collection.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
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
        /// Returns the whole stored record of one client: its name and description, its secret, scopes, redirect URIs, allowed origins, logout redirect URIs and audit fields. An administrator sees any client of the tenant, a plain user only the clients they created, and a guest none of them. Whatever the caller may not see is reported as 404 rather than 403, so absence and lack of access are deliberately indistinguishable, and an identifier that is not a valid client ID is reported the same way. The response is a single object, not a collection.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
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

            // authentication (x-signature) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("x-signature")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("x-signature", Configuration.GetApiKeyWithPrefix("x-signature")));
            }

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<ClientResponse>("/api/2.0/oauth2/clients/{clientId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

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
        /// Get client info
        /// </summary>
        /// <remarks>
        /// Retrieves the detailed information for a client with the ID specified in the request. It returns the consent-facing subset of the client - name, description, logo, the website, terms and policy URLs, authentication methods and scopes - and deliberately omits the secret, the redirect URIs and the allowed origins, which is what makes it safe to render on a consent screen. An administrator sees any client of the tenant, a plain user only the clients they created, and a guest none of them. A client the caller may not see is reported as 404, exactly like an unknown one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client-info/">REST API Reference for GetClientInfo Operation</seealso>
        /// <returns>ClientInfoResponse</returns>
        public ClientInfoResponse GetClientInfo(string clientId)
        {
            var localVarResponse = GetClientInfoWithHttpInfo(clientId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get client info
        /// </summary>
        /// <remarks>
        /// Retrieves the detailed information for a client with the ID specified in the request. It returns the consent-facing subset of the client - name, description, logo, the website, terms and policy URLs, authentication methods and scopes - and deliberately omits the secret, the redirect URIs and the allowed origins, which is what makes it safe to render on a consent screen. An administrator sees any client of the tenant, a plain user only the clients they created, and a guest none of them. A client the caller may not see is reported as 404, exactly like an unknown one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
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

            // authentication (x-signature) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("x-signature")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("x-signature", Configuration.GetApiKeyWithPrefix("x-signature")));
            }

            // make the HTTP request
            var localVarResponse = Client.Get<ClientInfoResponse>("/api/2.0/oauth2/clients/{clientId}/info", localVarRequestOptions, Configuration);

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
        /// Get client info
        /// </summary>
        /// <remarks>
        /// Retrieves the detailed information for a client with the ID specified in the request. It returns the consent-facing subset of the client - name, description, logo, the website, terms and policy URLs, authentication methods and scopes - and deliberately omits the secret, the redirect URIs and the allowed origins, which is what makes it safe to render on a consent screen. An administrator sees any client of the tenant, a plain user only the clients they created, and a guest none of them. A client the caller may not see is reported as 404, exactly like an unknown one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-client-info/">REST API Reference for GetClientInfo Operation</seealso>
        /// <returns>Task of ClientInfoResponse</returns>
        public async Task<ClientInfoResponse> GetClientInfoAsync(string clientId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetClientInfoWithHttpInfoAsync(clientId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get client info
        /// </summary>
        /// <remarks>
        /// Retrieves the detailed information for a client with the ID specified in the request. It returns the consent-facing subset of the client - name, description, logo, the website, terms and policy URLs, authentication methods and scopes - and deliberately omits the secret, the redirect URIs and the allowed origins, which is what makes it safe to render on a consent screen. An administrator sees any client of the tenant, a plain user only the clients they created, and a guest none of them. A client the caller may not see is reported as 404, exactly like an unknown one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
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

            // authentication (x-signature) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("x-signature")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("x-signature", Configuration.GetApiKeyWithPrefix("x-signature")));
            }

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<ClientInfoResponse>("/api/2.0/oauth2/clients/{clientId}/info", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

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
        /// List clients
        /// </summary>
        /// <remarks>
        /// Returns one page of the tenant's clients, newest first, each in the same full form as the single-client read. An administrator sees every client of the tenant, a plain user only the clients they created. Paging is keyset-based rather than offset-based: limit sets the page size, and last_client_id and last_created_on are carried over from the previous page to ask for the next one. The limit defaults to 30 and has to lie between 1 and 50; a value outside that range, or a last_created_on that cannot be parsed as a date, is rejected with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. Defaults to 30 when omitted. (optional, default to 30)</param>
        /// <param name="lastClientId">ID of the last retrieved client (optional)</param>
        /// <param name="lastCreatedOn">Date of the last retrieved client (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients/">REST API Reference for GetClients Operation</seealso>
        /// <returns>PageableClientResponse</returns>
        public PageableClientResponse GetClients(int? limit = default, string? lastClientId = default, DateTime? lastCreatedOn = default)
        {
            var localVarResponse = GetClientsWithHttpInfo(limit, lastClientId, lastCreatedOn);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List clients
        /// </summary>
        /// <remarks>
        /// Returns one page of the tenant's clients, newest first, each in the same full form as the single-client read. An administrator sees every client of the tenant, a plain user only the clients they created. Paging is keyset-based rather than offset-based: limit sets the page size, and last_client_id and last_created_on are carried over from the previous page to ask for the next one. The limit defaults to 30 and has to lie between 1 and 50; a value outside that range, or a last_created_on that cannot be parsed as a date, is rejected with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. Defaults to 30 when omitted. (optional, default to 30)</param>
        /// <param name="lastClientId">ID of the last retrieved client (optional)</param>
        /// <param name="lastCreatedOn">Date of the last retrieved client (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients/">REST API Reference for GetClients Operation</seealso>
        /// <returns>ApiResponse of PageableClientResponse</returns>
        public ApiResponse<PageableClientResponse> GetClientsWithHttpInfo(int? limit = default, string? lastClientId = default, DateTime? lastCreatedOn = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (lastClientId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "last_client_id", lastClientId));
            }
            if (lastCreatedOn != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "last_created_on", lastCreatedOn));
            }

            // authentication (x-signature) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("x-signature")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("x-signature", Configuration.GetApiKeyWithPrefix("x-signature")));
            }

            // make the HTTP request
            var localVarResponse = Client.Get<PageableClientResponse>("/api/2.0/oauth2/clients", localVarRequestOptions, Configuration);

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
        /// List clients
        /// </summary>
        /// <remarks>
        /// Returns one page of the tenant's clients, newest first, each in the same full form as the single-client read. An administrator sees every client of the tenant, a plain user only the clients they created. Paging is keyset-based rather than offset-based: limit sets the page size, and last_client_id and last_created_on are carried over from the previous page to ask for the next one. The limit defaults to 30 and has to lie between 1 and 50; a value outside that range, or a last_created_on that cannot be parsed as a date, is rejected with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. Defaults to 30 when omitted. (optional, default to 30)</param>
        /// <param name="lastClientId">ID of the last retrieved client (optional)</param>
        /// <param name="lastCreatedOn">Date of the last retrieved client (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients/">REST API Reference for GetClients Operation</seealso>
        /// <returns>Task of PageableClientResponse</returns>
        public async Task<PageableClientResponse> GetClientsAsync(int? limit = default, string? lastClientId = default, DateTime? lastCreatedOn = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetClientsWithHttpInfoAsync(limit, lastClientId, lastCreatedOn, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List clients
        /// </summary>
        /// <remarks>
        /// Returns one page of the tenant's clients, newest first, each in the same full form as the single-client read. An administrator sees every client of the tenant, a plain user only the clients they created. Paging is keyset-based rather than offset-based: limit sets the page size, and last_client_id and last_created_on are carried over from the previous page to ask for the next one. The limit defaults to 30 and has to lie between 1 and 50; a value outside that range, or a last_created_on that cannot be parsed as a date, is rejected with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. Defaults to 30 when omitted. (optional, default to 30)</param>
        /// <param name="lastClientId">ID of the last retrieved client (optional)</param>
        /// <param name="lastCreatedOn">Date of the last retrieved client (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients/">REST API Reference for GetClients Operation</seealso>
        /// <returns>Task of ApiResponse (PageableClientResponse)</returns>
        public async Task<ApiResponse<PageableClientResponse>> GetClientsWithHttpInfoAsync(int? limit = default, string? lastClientId = default, DateTime? lastCreatedOn = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (lastClientId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "last_client_id", lastClientId));
            }
            if (lastCreatedOn != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "last_created_on", lastCreatedOn));
            }

            // authentication (x-signature) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("x-signature")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("x-signature", Configuration.GetApiKeyWithPrefix("x-signature")));
            }

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<PageableClientResponse>("/api/2.0/oauth2/clients", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

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
        /// List client info
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of information for all clients, each in the same consent-facing form as the single-client info read. An administrator sees every client of the tenant, a plain user only the clients they created. Paging is keyset-based: limit sets the page size, and last_client_id and last_created_on are carried over from the previous page. Unlike the full client listing, limit has no default here - it has to be supplied on every call and has to lie between 1 and 50, and a missing or out-of-range value is rejected with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. It has no default and has to be sent on every call.</param>
        /// <param name="lastClientId">ID of the last retrieved client (optional)</param>
        /// <param name="lastCreatedOn">Date of the last retrieved client (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients-info/">REST API Reference for GetClientsInfo Operation</seealso>
        /// <returns>PageableClientInfoResponse</returns>
        public PageableClientInfoResponse GetClientsInfo(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default)
        {
            var localVarResponse = GetClientsInfoWithHttpInfo(limit, lastClientId, lastCreatedOn);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List client info
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of information for all clients, each in the same consent-facing form as the single-client info read. An administrator sees every client of the tenant, a plain user only the clients they created. Paging is keyset-based: limit sets the page size, and last_client_id and last_created_on are carried over from the previous page. Unlike the full client listing, limit has no default here - it has to be supplied on every call and has to lie between 1 and 50, and a missing or out-of-range value is rejected with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. It has no default and has to be sent on every call.</param>
        /// <param name="lastClientId">ID of the last retrieved client (optional)</param>
        /// <param name="lastCreatedOn">Date of the last retrieved client (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients-info/">REST API Reference for GetClientsInfo Operation</seealso>
        /// <returns>ApiResponse of PageableClientInfoResponse</returns>
        public ApiResponse<PageableClientInfoResponse> GetClientsInfoWithHttpInfo(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default)
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

            // authentication (x-signature) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("x-signature")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("x-signature", Configuration.GetApiKeyWithPrefix("x-signature")));
            }

            // make the HTTP request
            var localVarResponse = Client.Get<PageableClientInfoResponse>("/api/2.0/oauth2/clients/info", localVarRequestOptions, Configuration);

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
        /// List client info
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of information for all clients, each in the same consent-facing form as the single-client info read. An administrator sees every client of the tenant, a plain user only the clients they created. Paging is keyset-based: limit sets the page size, and last_client_id and last_created_on are carried over from the previous page. Unlike the full client listing, limit has no default here - it has to be supplied on every call and has to lie between 1 and 50, and a missing or out-of-range value is rejected with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. It has no default and has to be sent on every call.</param>
        /// <param name="lastClientId">ID of the last retrieved client (optional)</param>
        /// <param name="lastCreatedOn">Date of the last retrieved client (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients-info/">REST API Reference for GetClientsInfo Operation</seealso>
        /// <returns>Task of PageableClientInfoResponse</returns>
        public async Task<PageableClientInfoResponse> GetClientsInfoAsync(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetClientsInfoWithHttpInfoAsync(limit, lastClientId, lastCreatedOn, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List client info
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of information for all clients, each in the same consent-facing form as the single-client info read. An administrator sees every client of the tenant, a plain user only the clients they created. Paging is keyset-based: limit sets the page size, and last_client_id and last_created_on are carried over from the previous page. Unlike the full client listing, limit has no default here - it has to be supplied on every call and has to lie between 1 and 50, and a missing or out-of-range value is rejected with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. It has no default and has to be sent on every call.</param>
        /// <param name="lastClientId">ID of the last retrieved client (optional)</param>
        /// <param name="lastCreatedOn">Date of the last retrieved client (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-clients-info/">REST API Reference for GetClientsInfo Operation</seealso>
        /// <returns>Task of ApiResponse (PageableClientInfoResponse)</returns>
        public async Task<ApiResponse<PageableClientInfoResponse>> GetClientsInfoWithHttpInfoAsync(int limit, string? lastClientId = default, DateTime? lastCreatedOn = default, CancellationToken cancellationToken = default)
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

            // authentication (x-signature) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("x-signature")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("x-signature", Configuration.GetApiKeyWithPrefix("x-signature")));
            }

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<PageableClientInfoResponse>("/api/2.0/oauth2/clients/info", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

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
        /// List user consents
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of user consents: the clients the calling user has authorized, each with the scopes granted, the moment the consent was last changed and the client's consent-facing details. It always reports the caller's own consents and nothing else - there is no role check on this endpoint, so guests may call it too, and no parameter widens it to another user. The consents are read from the authorization service over gRPC, so an authorization service that cannot be reached surfaces as 503. Paging is keyset-based on last_modified_on, and limit has no default: it has to be supplied on every call and has to lie between 1 and 50.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. It has no default and has to be sent on every call.</param>
        /// <param name="lastModifiedOn">Date of the last retrieved consent (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-consents/">REST API Reference for GetConsents Operation</seealso>
        /// <returns>PageableModificationResponse</returns>
        public PageableModificationResponse GetConsents(int limit, DateTime? lastModifiedOn = default)
        {
            var localVarResponse = GetConsentsWithHttpInfo(limit, lastModifiedOn);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List user consents
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of user consents: the clients the calling user has authorized, each with the scopes granted, the moment the consent was last changed and the client's consent-facing details. It always reports the caller's own consents and nothing else - there is no role check on this endpoint, so guests may call it too, and no parameter widens it to another user. The consents are read from the authorization service over gRPC, so an authorization service that cannot be reached surfaces as 503. Paging is keyset-based on last_modified_on, and limit has no default: it has to be supplied on every call and has to lie between 1 and 50.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. It has no default and has to be sent on every call.</param>
        /// <param name="lastModifiedOn">Date of the last retrieved consent (optional)</param>
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

            // authentication (x-signature) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("x-signature")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("x-signature", Configuration.GetApiKeyWithPrefix("x-signature")));
            }

            // make the HTTP request
            var localVarResponse = Client.Get<PageableModificationResponse>("/api/2.0/oauth2/clients/consents", localVarRequestOptions, Configuration);

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
        /// List user consents
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of user consents: the clients the calling user has authorized, each with the scopes granted, the moment the consent was last changed and the client's consent-facing details. It always reports the caller's own consents and nothing else - there is no role check on this endpoint, so guests may call it too, and no parameter widens it to another user. The consents are read from the authorization service over gRPC, so an authorization service that cannot be reached surfaces as 503. Paging is keyset-based on last_modified_on, and limit has no default: it has to be supplied on every call and has to lie between 1 and 50.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. It has no default and has to be sent on every call.</param>
        /// <param name="lastModifiedOn">Date of the last retrieved consent (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-consents/">REST API Reference for GetConsents Operation</seealso>
        /// <returns>Task of PageableModificationResponse</returns>
        public async Task<PageableModificationResponse> GetConsentsAsync(int limit, DateTime? lastModifiedOn = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetConsentsWithHttpInfoAsync(limit, lastModifiedOn, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List user consents
        /// </summary>
        /// <remarks>
        /// Retrieves a paginated list of user consents: the clients the calling user has authorized, each with the scopes granted, the moment the consent was last changed and the client's consent-facing details. It always reports the caller's own consents and nothing else - there is no role check on this endpoint, so guests may call it too, and no parameter widens it to another user. The consents are read from the authorization service over gRPC, so an authorization service that cannot be reached surfaces as 503. Paging is keyset-based on last_modified_on, and limit has no default: it has to be supplied on every call and has to lie between 1 and 50.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many entries to return, between 1 and 50. It has no default and has to be sent on every call.</param>
        /// <param name="lastModifiedOn">Date of the last retrieved consent (optional)</param>
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

            // authentication (x-signature) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("x-signature")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("x-signature", Configuration.GetApiKeyWithPrefix("x-signature")));
            }

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<PageableModificationResponse>("/api/2.0/oauth2/clients/consents", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

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
        /// Get public client info
        /// </summary>
        /// <remarks>
        /// Returns the same consent-facing client information as the signed read, but without requiring a portal signature. It is meant for a login or consent page that has to render the client before the user is known, so it resolves the client by ID alone: there is no authentication, no tenant scoping and no creator check, and any caller who knows a client ID can read that client's public details. It still exposes no secret, no redirect URIs and no allowed origins. Being unauthenticated it is rate-limited on a separate, tighter budget than the signed endpoints. An unknown client ID, and an identifier that is not a client ID at all, are both reported as 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-client-info/">REST API Reference for GetPublicClientInfo Operation</seealso>
        /// <returns>ClientInfoResponse</returns>
        public ClientInfoResponse GetPublicClientInfo(string clientId)
        {
            var localVarResponse = GetPublicClientInfoWithHttpInfo(clientId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get public client info
        /// </summary>
        /// <remarks>
        /// Returns the same consent-facing client information as the signed read, but without requiring a portal signature. It is meant for a login or consent page that has to render the client before the user is known, so it resolves the client by ID alone: there is no authentication, no tenant scoping and no creator check, and any caller who knows a client ID can read that client's public details. It still exposes no secret, no redirect URIs and no allowed origins. Being unauthenticated it is rate-limited on a separate, tighter budget than the signed endpoints. An unknown client ID, and an identifier that is not a client ID at all, are both reported as 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
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
            var localVarResponse = Client.Get<ClientInfoResponse>("/api/2.0/oauth2/clients/{clientId}/public/info", localVarRequestOptions, Configuration);

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
        /// Get public client info
        /// </summary>
        /// <remarks>
        /// Returns the same consent-facing client information as the signed read, but without requiring a portal signature. It is meant for a login or consent page that has to render the client before the user is known, so it resolves the client by ID alone: there is no authentication, no tenant scoping and no creator check, and any caller who knows a client ID can read that client's public details. It still exposes no secret, no redirect URIs and no allowed origins. Being unauthenticated it is rate-limited on a separate, tighter budget than the signed endpoints. An unknown client ID, and an identifier that is not a client ID at all, are both reported as 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-client-info/">REST API Reference for GetPublicClientInfo Operation</seealso>
        /// <returns>Task of ClientInfoResponse</returns>
        public async Task<ClientInfoResponse> GetPublicClientInfoAsync(string clientId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetPublicClientInfoWithHttpInfoAsync(clientId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get public client info
        /// </summary>
        /// <remarks>
        /// Returns the same consent-facing client information as the signed read, but without requiring a portal signature. It is meant for a login or consent page that has to render the client before the user is known, so it resolves the client by ID alone: there is no authentication, no tenant scoping and no creator check, and any caller who knows a client ID can read that client's public details. It still exposes no secret, no redirect URIs and no allowed origins. Being unauthenticated it is rate-limited on a separate, tighter budget than the signed endpoints. An unknown client ID, and an identifier that is not a client ID at all, are both reported as 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">ID of the client to retrieve</param>
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

            var localVarResponse = await AsynchronousClient.GetAsync<ClientInfoResponse>("/api/2.0/oauth2/clients/{clientId}/public/info", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

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
