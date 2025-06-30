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
using DocSpace.Client;
using DocSpace.Model;

namespace DocSpace.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPeopleThirdPartyAccountsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get third-party accounts
        /// </summary>
        /// <remarks>
        /// Returns a list of the available third-party accounts.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signupAccountRequestDto">The request parameters for creating a third-party account. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/signup-third-party-account/">REST API Reference for SignupThirdPartyAccount Operation</seealso>
        /// <returns></returns>
        void SignupThirdPartyAccount(SignupAccountRequestDto? signupAccountRequestDto = default);

        /// <summary>
        /// Create a third-pary account
        /// </summary>
        /// <remarks>
        /// Creates a third-party account with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signupAccountRequestDto">The request parameters for creating a third-party account. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/signup-third-party-account/">REST API Reference for SignupThirdPartyAccount Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SignupThirdPartyAccountWithHttpInfo(SignupAccountRequestDto? signupAccountRequestDto = default);
        /// <summary>
        /// Unlink a third-pary account
        /// </summary>
        /// <remarks>
        /// Unlinks a third-party account specified in the request from the user profile.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">The provider name. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-third-party-account/">REST API Reference for UnlinkThirdPartyAccount Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UnlinkThirdPartyAccountWithHttpInfo(string? provider = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPeopleThirdPartyAccountsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get third-party accounts
        /// </summary>
        /// <remarks>
        /// Returns a list of the available third-party accounts.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteView">Specifies whether to return providers that are available for invitation links, i.e. the user can login or register through these providers. (optional)</param>
        /// <param name="settingsView">Specifies whether to display the provider settings in a pop-up window (true) or redirect them to the desktop application (false). (optional)</param>
        /// <param name="clientCallback">The method that is called after authentication. (optional)</param>
        /// <param name="fromOnly">The provider name if a response is required only from this provider. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-third-party-auth-providers/">REST API Reference for GetThirdPartyAuthProviders Operation</seealso>
        /// <returns>Task of AccountInfoArrayWrapper</returns>
        System.Threading.Tasks.Task<AccountInfoArrayWrapper> GetThirdPartyAuthProvidersAsync(bool? inviteView = default, bool? settingsView = default, string? clientCallback = default, string? fromOnly = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get third-party accounts
        /// </summary>
        /// <remarks>
        /// Returns a list of the available third-party accounts.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteView">Specifies whether to return providers that are available for invitation links, i.e. the user can login or register through these providers. (optional)</param>
        /// <param name="settingsView">Specifies whether to display the provider settings in a pop-up window (true) or redirect them to the desktop application (false). (optional)</param>
        /// <param name="clientCallback">The method that is called after authentication. (optional)</param>
        /// <param name="fromOnly">The provider name if a response is required only from this provider. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-third-party-auth-providers/">REST API Reference for GetThirdPartyAuthProviders Operation</seealso>
        /// <returns>Task of ApiResponse (AccountInfoArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountInfoArrayWrapper>> GetThirdPartyAuthProvidersWithHttpInfoAsync(bool? inviteView = default, bool? settingsView = default, string? clientCallback = default, string? fromOnly = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Link a third-pary account
        /// </summary>
        /// <remarks>
        /// Links a third-party account specified in the request to the user profile.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linkAccountRequestDto">The request parameters for linking accounts. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/link-third-party-account/">REST API Reference for LinkThirdPartyAccount Operation</seealso>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task LinkThirdPartyAccountAsync(LinkAccountRequestDto? linkAccountRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Link a third-pary account
        /// </summary>
        /// <remarks>
        /// Links a third-party account specified in the request to the user profile.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linkAccountRequestDto">The request parameters for linking accounts. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/link-third-party-account/">REST API Reference for LinkThirdPartyAccount Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> LinkThirdPartyAccountWithHttpInfoAsync(LinkAccountRequestDto? linkAccountRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a third-pary account
        /// </summary>
        /// <remarks>
        /// Creates a third-party account with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signupAccountRequestDto">The request parameters for creating a third-party account. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/signup-third-party-account/">REST API Reference for SignupThirdPartyAccount Operation</seealso>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SignupThirdPartyAccountAsync(SignupAccountRequestDto? signupAccountRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a third-pary account
        /// </summary>
        /// <remarks>
        /// Creates a third-party account with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signupAccountRequestDto">The request parameters for creating a third-party account. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/signup-third-party-account/">REST API Reference for SignupThirdPartyAccount Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SignupThirdPartyAccountWithHttpInfoAsync(SignupAccountRequestDto? signupAccountRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unlink a third-pary account
        /// </summary>
        /// <remarks>
        /// Unlinks a third-party account specified in the request from the user profile.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">The provider name. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-third-party-account/">REST API Reference for UnlinkThirdPartyAccount Operation</seealso>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UnlinkThirdPartyAccountAsync(string? provider = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Unlink a third-pary account
        /// </summary>
        /// <remarks>
        /// Unlinks a third-party account specified in the request from the user profile.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">The provider name. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-third-party-account/">REST API Reference for UnlinkThirdPartyAccount Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UnlinkThirdPartyAccountWithHttpInfoAsync(string? provider = default, System.Threading.CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPeopleThirdPartyAccountsApi : IPeopleThirdPartyAccountsApiSync, IPeopleThirdPartyAccountsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PeopleThirdPartyAccountsApi : IDisposable, IPeopleThirdPartyAccountsApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleThirdPartyAccountsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public PeopleThirdPartyAccountsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleThirdPartyAccountsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public PeopleThirdPartyAccountsApi(string basePath)
        {
            this.Configuration = DocSpace.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            this.ApiClient = new ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = DocSpace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleThirdPartyAccountsApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public PeopleThirdPartyAccountsApi(Configuration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);

            this.Configuration = DocSpace.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = DocSpace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleThirdPartyAccountsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public PeopleThirdPartyAccountsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleThirdPartyAccountsApi"/> class.
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
        public PeopleThirdPartyAccountsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(client);

            this.Configuration = DocSpace.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            this.ApiClient = new ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = DocSpace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleThirdPartyAccountsApi"/> class using a Configuration object.
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
        public PeopleThirdPartyAccountsApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            ArgumentNullException.ThrowIfNull(client);

            this.Configuration = DocSpace.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = DocSpace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleThirdPartyAccountsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public PeopleThirdPartyAccountsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(client);
            ArgumentNullException.ThrowIfNull(asyncClient);
            ArgumentNullException.ThrowIfNull(configuration);

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = DocSpace.Client.Configuration.DefaultExceptionFactory;
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
        /// Get third-party accounts Returns a list of the available third-party accounts.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// Get third-party accounts Returns a list of the available third-party accounts.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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
            var localVarResponse = this.Client.Get<AccountInfoArrayWrapper>("/api/2.0/people/thirdparty/providers", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetThirdPartyAuthProviders", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get third-party accounts Returns a list of the available third-party accounts.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteView">Specifies whether to return providers that are available for invitation links, i.e. the user can login or register through these providers. (optional)</param>
        /// <param name="settingsView">Specifies whether to display the provider settings in a pop-up window (true) or redirect them to the desktop application (false). (optional)</param>
        /// <param name="clientCallback">The method that is called after authentication. (optional)</param>
        /// <param name="fromOnly">The provider name if a response is required only from this provider. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-third-party-auth-providers/">REST API Reference for GetThirdPartyAuthProviders Operation</seealso>
        /// <returns>Task of AccountInfoArrayWrapper</returns>
        public async System.Threading.Tasks.Task<AccountInfoArrayWrapper> GetThirdPartyAuthProvidersAsync(bool? inviteView = default, bool? settingsView = default, string? clientCallback = default, string? fromOnly = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AccountInfoArrayWrapper> localVarResponse = await GetThirdPartyAuthProvidersWithHttpInfoAsync(inviteView, settingsView, clientCallback, fromOnly, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get third-party accounts Returns a list of the available third-party accounts.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteView">Specifies whether to return providers that are available for invitation links, i.e. the user can login or register through these providers. (optional)</param>
        /// <param name="settingsView">Specifies whether to display the provider settings in a pop-up window (true) or redirect them to the desktop application (false). (optional)</param>
        /// <param name="clientCallback">The method that is called after authentication. (optional)</param>
        /// <param name="fromOnly">The provider name if a response is required only from this provider. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-third-party-auth-providers/">REST API Reference for GetThirdPartyAuthProviders Operation</seealso>
        /// <returns>Task of ApiResponse (AccountInfoArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountInfoArrayWrapper>> GetThirdPartyAuthProvidersWithHttpInfoAsync(bool? inviteView = default, bool? settingsView = default, string? clientCallback = default, string? fromOnly = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<AccountInfoArrayWrapper>("/api/2.0/people/thirdparty/providers", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetThirdPartyAuthProviders", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Link a third-pary account Links a third-party account specified in the request to the user profile.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linkAccountRequestDto">The request parameters for linking accounts. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/link-third-party-account/">REST API Reference for LinkThirdPartyAccount Operation</seealso>
        /// <returns></returns>
        public void LinkThirdPartyAccount(LinkAccountRequestDto? linkAccountRequestDto = default)
        {
            LinkThirdPartyAccountWithHttpInfo(linkAccountRequestDto);
        }

        /// <summary>
        /// Link a third-pary account Links a third-party account specified in the request to the user profile.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<Object>("/api/2.0/people/thirdparty/linkaccount", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("LinkThirdPartyAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Link a third-pary account Links a third-party account specified in the request to the user profile.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linkAccountRequestDto">The request parameters for linking accounts. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/link-third-party-account/">REST API Reference for LinkThirdPartyAccount Operation</seealso>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task LinkThirdPartyAccountAsync(LinkAccountRequestDto? linkAccountRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            await LinkThirdPartyAccountWithHttpInfoAsync(linkAccountRequestDto, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Link a third-pary account Links a third-party account specified in the request to the user profile.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linkAccountRequestDto">The request parameters for linking accounts. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/link-third-party-account/">REST API Reference for LinkThirdPartyAccount Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> LinkThirdPartyAccountWithHttpInfoAsync(LinkAccountRequestDto? linkAccountRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

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
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<Object>("/api/2.0/people/thirdparty/linkaccount", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("LinkThirdPartyAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a third-pary account Creates a third-party account with the parameters specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signupAccountRequestDto">The request parameters for creating a third-party account. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/signup-third-party-account/">REST API Reference for SignupThirdPartyAccount Operation</seealso>
        /// <returns></returns>
        public void SignupThirdPartyAccount(SignupAccountRequestDto? signupAccountRequestDto = default)
        {
            SignupThirdPartyAccountWithHttpInfo(signupAccountRequestDto);
        }

        /// <summary>
        /// Create a third-pary account Creates a third-party account with the parameters specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signupAccountRequestDto">The request parameters for creating a third-party account. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/signup-third-party-account/">REST API Reference for SignupThirdPartyAccount Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> SignupThirdPartyAccountWithHttpInfo(SignupAccountRequestDto? signupAccountRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (signupAccountRequestDto != null) localVarRequestOptions.Data = signupAccountRequestDto;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/api/2.0/people/thirdparty/signup", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SignupThirdPartyAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a third-pary account Creates a third-party account with the parameters specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signupAccountRequestDto">The request parameters for creating a third-party account. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/signup-third-party-account/">REST API Reference for SignupThirdPartyAccount Operation</seealso>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SignupThirdPartyAccountAsync(SignupAccountRequestDto? signupAccountRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            await SignupThirdPartyAccountWithHttpInfoAsync(signupAccountRequestDto, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Create a third-pary account Creates a third-party account with the parameters specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="signupAccountRequestDto">The request parameters for creating a third-party account. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/signup-third-party-account/">REST API Reference for SignupThirdPartyAccount Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SignupThirdPartyAccountWithHttpInfoAsync(SignupAccountRequestDto? signupAccountRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (signupAccountRequestDto != null) localVarRequestOptions.Data = signupAccountRequestDto;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/api/2.0/people/thirdparty/signup", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SignupThirdPartyAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Unlink a third-pary account Unlinks a third-party account specified in the request from the user profile.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">The provider name. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-third-party-account/">REST API Reference for UnlinkThirdPartyAccount Operation</seealso>
        /// <returns></returns>
        public void UnlinkThirdPartyAccount(string? provider = default)
        {
            UnlinkThirdPartyAccountWithHttpInfo(provider);
        }

        /// <summary>
        /// Unlink a third-pary account Unlinks a third-party account specified in the request from the user profile.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/api/2.0/people/thirdparty/unlinkaccount", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("UnlinkThirdPartyAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Unlink a third-pary account Unlinks a third-party account specified in the request from the user profile.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">The provider name. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-third-party-account/">REST API Reference for UnlinkThirdPartyAccount Operation</seealso>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UnlinkThirdPartyAccountAsync(string? provider = default, System.Threading.CancellationToken cancellationToken = default)
        {
            await UnlinkThirdPartyAccountWithHttpInfoAsync(provider, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Unlink a third-pary account Unlinks a third-party account specified in the request from the user profile.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">The provider name. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-third-party-account/">REST API Reference for UnlinkThirdPartyAccount Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UnlinkThirdPartyAccountWithHttpInfoAsync(string? provider = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

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
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/api/2.0/people/thirdparty/unlinkaccount", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("UnlinkThirdPartyAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

    }
}
