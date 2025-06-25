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
    public interface ISettingsOwnerApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Send the owner change instructions
        /// </summary>
        /// <remarks>
        /// Sends the instructions to change the DocSpace owner.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ownerIdSettingsRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-owner-change-instructions/">REST API Reference for SendOwnerChangeInstructions Operation</seealso>
        /// <returns>OwnerChangeInstructionsWrapper</returns>
        OwnerChangeInstructionsWrapper SendOwnerChangeInstructions(OwnerIdSettingsRequestDto? ownerIdSettingsRequestDto = default);

        /// <summary>
        /// Send the owner change instructions
        /// </summary>
        /// <remarks>
        /// Sends the instructions to change the DocSpace owner.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ownerIdSettingsRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-owner-change-instructions/">REST API Reference for SendOwnerChangeInstructions Operation</seealso>
        /// <returns>ApiResponse of OwnerChangeInstructionsWrapper</returns>
        ApiResponse<OwnerChangeInstructionsWrapper> SendOwnerChangeInstructionsWithHttpInfo(OwnerIdSettingsRequestDto? ownerIdSettingsRequestDto = default);
        /// <summary>
        /// Update the portal owner
        /// </summary>
        /// <remarks>
        /// Updates the current portal owner with a new one specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ownerIdSettingsRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-portal-owner/">REST API Reference for UpdatePortalOwner Operation</seealso>
        /// <returns></returns>
        void UpdatePortalOwner(OwnerIdSettingsRequestDto? ownerIdSettingsRequestDto = default);

        /// <summary>
        /// Update the portal owner
        /// </summary>
        /// <remarks>
        /// Updates the current portal owner with a new one specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ownerIdSettingsRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-portal-owner/">REST API Reference for UpdatePortalOwner Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdatePortalOwnerWithHttpInfo(OwnerIdSettingsRequestDto? ownerIdSettingsRequestDto = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsOwnerApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Send the owner change instructions
        /// </summary>
        /// <remarks>
        /// Sends the instructions to change the DocSpace owner.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ownerIdSettingsRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-owner-change-instructions/">REST API Reference for SendOwnerChangeInstructions Operation</seealso>
        /// <returns>Task of OwnerChangeInstructionsWrapper</returns>
        System.Threading.Tasks.Task<OwnerChangeInstructionsWrapper> SendOwnerChangeInstructionsAsync(OwnerIdSettingsRequestDto? ownerIdSettingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Send the owner change instructions
        /// </summary>
        /// <remarks>
        /// Sends the instructions to change the DocSpace owner.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ownerIdSettingsRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-owner-change-instructions/">REST API Reference for SendOwnerChangeInstructions Operation</seealso>
        /// <returns>Task of ApiResponse (OwnerChangeInstructionsWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<OwnerChangeInstructionsWrapper>> SendOwnerChangeInstructionsWithHttpInfoAsync(OwnerIdSettingsRequestDto? ownerIdSettingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the portal owner
        /// </summary>
        /// <remarks>
        /// Updates the current portal owner with a new one specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ownerIdSettingsRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-portal-owner/">REST API Reference for UpdatePortalOwner Operation</seealso>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdatePortalOwnerAsync(OwnerIdSettingsRequestDto? ownerIdSettingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update the portal owner
        /// </summary>
        /// <remarks>
        /// Updates the current portal owner with a new one specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ownerIdSettingsRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-portal-owner/">REST API Reference for UpdatePortalOwner Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdatePortalOwnerWithHttpInfoAsync(OwnerIdSettingsRequestDto? ownerIdSettingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsOwnerApi : ISettingsOwnerApiSync, ISettingsOwnerApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SettingsOwnerApi : IDisposable, ISettingsOwnerApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsOwnerApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public SettingsOwnerApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsOwnerApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public SettingsOwnerApi(string basePath)
        {
            this.Configuration = Docspace.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            this.ApiClient = new ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Docspace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsOwnerApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public SettingsOwnerApi(Configuration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);

            this.Configuration = Docspace.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Docspace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsOwnerApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public SettingsOwnerApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsOwnerApi"/> class.
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
        public SettingsOwnerApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(client);

            this.Configuration = Docspace.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            this.ApiClient = new ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Docspace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsOwnerApi"/> class using a Configuration object.
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
        public SettingsOwnerApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            ArgumentNullException.ThrowIfNull(client);

            this.Configuration = Docspace.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Docspace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsOwnerApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SettingsOwnerApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(client);
            ArgumentNullException.ThrowIfNull(asyncClient);
            ArgumentNullException.ThrowIfNull(configuration);

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
        /// Send the owner change instructions Sends the instructions to change the DocSpace owner.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ownerIdSettingsRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-owner-change-instructions/">REST API Reference for SendOwnerChangeInstructions Operation</seealso>
        /// <returns>OwnerChangeInstructionsWrapper</returns>
        public OwnerChangeInstructionsWrapper SendOwnerChangeInstructions(OwnerIdSettingsRequestDto? ownerIdSettingsRequestDto = default)
        {
            var localVarResponse = SendOwnerChangeInstructionsWithHttpInfo(ownerIdSettingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send the owner change instructions Sends the instructions to change the DocSpace owner.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ownerIdSettingsRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-owner-change-instructions/">REST API Reference for SendOwnerChangeInstructions Operation</seealso>
        /// <returns>ApiResponse of OwnerChangeInstructionsWrapper</returns>
        public ApiResponse<OwnerChangeInstructionsWrapper> SendOwnerChangeInstructionsWithHttpInfo(OwnerIdSettingsRequestDto? ownerIdSettingsRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (ownerIdSettingsRequestDto != null) localVarRequestOptions.Data = ownerIdSettingsRequestDto;

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
            var localVarResponse = this.Client.Post<OwnerChangeInstructionsWrapper>("/api/2.0/settings/owner", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SendOwnerChangeInstructions", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send the owner change instructions Sends the instructions to change the DocSpace owner.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ownerIdSettingsRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-owner-change-instructions/">REST API Reference for SendOwnerChangeInstructions Operation</seealso>
        /// <returns>Task of OwnerChangeInstructionsWrapper</returns>
        public async System.Threading.Tasks.Task<OwnerChangeInstructionsWrapper> SendOwnerChangeInstructionsAsync(OwnerIdSettingsRequestDto? ownerIdSettingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<OwnerChangeInstructionsWrapper> localVarResponse = await SendOwnerChangeInstructionsWithHttpInfoAsync(ownerIdSettingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send the owner change instructions Sends the instructions to change the DocSpace owner.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ownerIdSettingsRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-owner-change-instructions/">REST API Reference for SendOwnerChangeInstructions Operation</seealso>
        /// <returns>Task of ApiResponse (OwnerChangeInstructionsWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OwnerChangeInstructionsWrapper>> SendOwnerChangeInstructionsWithHttpInfoAsync(OwnerIdSettingsRequestDto? ownerIdSettingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (ownerIdSettingsRequestDto != null) localVarRequestOptions.Data = ownerIdSettingsRequestDto;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<OwnerChangeInstructionsWrapper>("/api/2.0/settings/owner", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SendOwnerChangeInstructions", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the portal owner Updates the current portal owner with a new one specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ownerIdSettingsRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-portal-owner/">REST API Reference for UpdatePortalOwner Operation</seealso>
        /// <returns></returns>
        public void UpdatePortalOwner(OwnerIdSettingsRequestDto? ownerIdSettingsRequestDto = default)
        {
            UpdatePortalOwnerWithHttpInfo(ownerIdSettingsRequestDto);
        }

        /// <summary>
        /// Update the portal owner Updates the current portal owner with a new one specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ownerIdSettingsRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-portal-owner/">REST API Reference for UpdatePortalOwner Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdatePortalOwnerWithHttpInfo(OwnerIdSettingsRequestDto? ownerIdSettingsRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (ownerIdSettingsRequestDto != null) localVarRequestOptions.Data = ownerIdSettingsRequestDto;

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
            var localVarResponse = this.Client.Put<Object>("/api/2.0/settings/owner", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("UpdatePortalOwner", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the portal owner Updates the current portal owner with a new one specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ownerIdSettingsRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-portal-owner/">REST API Reference for UpdatePortalOwner Operation</seealso>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdatePortalOwnerAsync(OwnerIdSettingsRequestDto? ownerIdSettingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            await UpdatePortalOwnerWithHttpInfoAsync(ownerIdSettingsRequestDto, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Update the portal owner Updates the current portal owner with a new one specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ownerIdSettingsRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-portal-owner/">REST API Reference for UpdatePortalOwner Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdatePortalOwnerWithHttpInfoAsync(OwnerIdSettingsRequestDto? ownerIdSettingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (ownerIdSettingsRequestDto != null) localVarRequestOptions.Data = ownerIdSettingsRequestDto;

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

            var localVarResponse = await this.AsynchronousClient.PutAsync<Object>("/api/2.0/settings/owner", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("UpdatePortalOwner", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

    }
}
