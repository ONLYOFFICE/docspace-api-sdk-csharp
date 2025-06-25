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
    public interface ISettingsEncryptionApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the storage encryption progress
        /// </summary>
        /// <remarks>
        /// Returns the storage encryption progress.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-progress/">REST API Reference for GetStorageEncryptionProgress Operation</seealso>
        /// <returns>DoubleWrapper</returns>
        DoubleWrapper GetStorageEncryptionProgress();

        /// <summary>
        /// Get the storage encryption progress
        /// </summary>
        /// <remarks>
        /// Returns the storage encryption progress.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-progress/">REST API Reference for GetStorageEncryptionProgress Operation</seealso>
        /// <returns>ApiResponse of DoubleWrapper</returns>
        ApiResponse<DoubleWrapper> GetStorageEncryptionProgressWithHttpInfo();
        /// <summary>
        /// Get the storage encryption settings
        /// </summary>
        /// <remarks>
        /// Returns the storage encryption settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-settings/">REST API Reference for GetStorageEncryptionSettings Operation</seealso>
        /// <returns>EncryptionSettingsWrapper</returns>
        EncryptionSettingsWrapper GetStorageEncryptionSettings();

        /// <summary>
        /// Get the storage encryption settings
        /// </summary>
        /// <remarks>
        /// Returns the storage encryption settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-settings/">REST API Reference for GetStorageEncryptionSettings Operation</seealso>
        /// <returns>ApiResponse of EncryptionSettingsWrapper</returns>
        ApiResponse<EncryptionSettingsWrapper> GetStorageEncryptionSettingsWithHttpInfo();
        /// <summary>
        /// Start the storage encryption process
        /// </summary>
        /// <remarks>
        /// Starts the storage encryption process.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageEncryptionRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-storage-encryption/">REST API Reference for StartStorageEncryption Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper StartStorageEncryption(StorageEncryptionRequestsDto? storageEncryptionRequestsDto = default);

        /// <summary>
        /// Start the storage encryption process
        /// </summary>
        /// <remarks>
        /// Starts the storage encryption process.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageEncryptionRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-storage-encryption/">REST API Reference for StartStorageEncryption Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> StartStorageEncryptionWithHttpInfo(StorageEncryptionRequestsDto? storageEncryptionRequestsDto = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsEncryptionApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get the storage encryption progress
        /// </summary>
        /// <remarks>
        /// Returns the storage encryption progress.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-progress/">REST API Reference for GetStorageEncryptionProgress Operation</seealso>
        /// <returns>Task of DoubleWrapper</returns>
        System.Threading.Tasks.Task<DoubleWrapper> GetStorageEncryptionProgressAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the storage encryption progress
        /// </summary>
        /// <remarks>
        /// Returns the storage encryption progress.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-progress/">REST API Reference for GetStorageEncryptionProgress Operation</seealso>
        /// <returns>Task of ApiResponse (DoubleWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<DoubleWrapper>> GetStorageEncryptionProgressWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the storage encryption settings
        /// </summary>
        /// <remarks>
        /// Returns the storage encryption settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-settings/">REST API Reference for GetStorageEncryptionSettings Operation</seealso>
        /// <returns>Task of EncryptionSettingsWrapper</returns>
        System.Threading.Tasks.Task<EncryptionSettingsWrapper> GetStorageEncryptionSettingsAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the storage encryption settings
        /// </summary>
        /// <remarks>
        /// Returns the storage encryption settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-settings/">REST API Reference for GetStorageEncryptionSettings Operation</seealso>
        /// <returns>Task of ApiResponse (EncryptionSettingsWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<EncryptionSettingsWrapper>> GetStorageEncryptionSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start the storage encryption process
        /// </summary>
        /// <remarks>
        /// Starts the storage encryption process.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageEncryptionRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-storage-encryption/">REST API Reference for StartStorageEncryption Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> StartStorageEncryptionAsync(StorageEncryptionRequestsDto? storageEncryptionRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Start the storage encryption process
        /// </summary>
        /// <remarks>
        /// Starts the storage encryption process.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageEncryptionRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-storage-encryption/">REST API Reference for StartStorageEncryption Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> StartStorageEncryptionWithHttpInfoAsync(StorageEncryptionRequestsDto? storageEncryptionRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsEncryptionApi : ISettingsEncryptionApiSync, ISettingsEncryptionApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SettingsEncryptionApi : IDisposable, ISettingsEncryptionApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsEncryptionApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public SettingsEncryptionApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsEncryptionApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public SettingsEncryptionApi(string basePath)
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
        /// Initializes a new instance of the <see cref="SettingsEncryptionApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public SettingsEncryptionApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="SettingsEncryptionApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public SettingsEncryptionApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsEncryptionApi"/> class.
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
        public SettingsEncryptionApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="SettingsEncryptionApi"/> class using a Configuration object.
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
        public SettingsEncryptionApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="SettingsEncryptionApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SettingsEncryptionApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Get the storage encryption progress Returns the storage encryption progress.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-progress/">REST API Reference for GetStorageEncryptionProgress Operation</seealso>
        /// <returns>DoubleWrapper</returns>
        public DoubleWrapper GetStorageEncryptionProgress()
        {
            var localVarResponse = GetStorageEncryptionProgressWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the storage encryption progress Returns the storage encryption progress.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-progress/">REST API Reference for GetStorageEncryptionProgress Operation</seealso>
        /// <returns>ApiResponse of DoubleWrapper</returns>
        public ApiResponse<DoubleWrapper> GetStorageEncryptionProgressWithHttpInfo()
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
            var localVarResponse = this.Client.Get<DoubleWrapper>("/api/2.0/settings/encryption/progress", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetStorageEncryptionProgress", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the storage encryption progress Returns the storage encryption progress.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-progress/">REST API Reference for GetStorageEncryptionProgress Operation</seealso>
        /// <returns>Task of DoubleWrapper</returns>
        public async System.Threading.Tasks.Task<DoubleWrapper> GetStorageEncryptionProgressAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<DoubleWrapper> localVarResponse = await GetStorageEncryptionProgressWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the storage encryption progress Returns the storage encryption progress.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-progress/">REST API Reference for GetStorageEncryptionProgress Operation</seealso>
        /// <returns>Task of ApiResponse (DoubleWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DoubleWrapper>> GetStorageEncryptionProgressWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<DoubleWrapper>("/api/2.0/settings/encryption/progress", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetStorageEncryptionProgress", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the storage encryption settings Returns the storage encryption settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-settings/">REST API Reference for GetStorageEncryptionSettings Operation</seealso>
        /// <returns>EncryptionSettingsWrapper</returns>
        public EncryptionSettingsWrapper GetStorageEncryptionSettings()
        {
            var localVarResponse = GetStorageEncryptionSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the storage encryption settings Returns the storage encryption settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-settings/">REST API Reference for GetStorageEncryptionSettings Operation</seealso>
        /// <returns>ApiResponse of EncryptionSettingsWrapper</returns>
        public ApiResponse<EncryptionSettingsWrapper> GetStorageEncryptionSettingsWithHttpInfo()
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
            var localVarResponse = this.Client.Get<EncryptionSettingsWrapper>("/api/2.0/settings/encryption/settings", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetStorageEncryptionSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the storage encryption settings Returns the storage encryption settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-settings/">REST API Reference for GetStorageEncryptionSettings Operation</seealso>
        /// <returns>Task of EncryptionSettingsWrapper</returns>
        public async System.Threading.Tasks.Task<EncryptionSettingsWrapper> GetStorageEncryptionSettingsAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<EncryptionSettingsWrapper> localVarResponse = await GetStorageEncryptionSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the storage encryption settings Returns the storage encryption settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-settings/">REST API Reference for GetStorageEncryptionSettings Operation</seealso>
        /// <returns>Task of ApiResponse (EncryptionSettingsWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EncryptionSettingsWrapper>> GetStorageEncryptionSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<EncryptionSettingsWrapper>("/api/2.0/settings/encryption/settings", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetStorageEncryptionSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start the storage encryption process Starts the storage encryption process.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageEncryptionRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-storage-encryption/">REST API Reference for StartStorageEncryption Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper StartStorageEncryption(StorageEncryptionRequestsDto? storageEncryptionRequestsDto = default)
        {
            var localVarResponse = StartStorageEncryptionWithHttpInfo(storageEncryptionRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start the storage encryption process Starts the storage encryption process.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageEncryptionRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-storage-encryption/">REST API Reference for StartStorageEncryption Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> StartStorageEncryptionWithHttpInfo(StorageEncryptionRequestsDto? storageEncryptionRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (storageEncryptionRequestsDto != null) localVarRequestOptions.Data = storageEncryptionRequestsDto;

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
            var localVarResponse = this.Client.Post<BooleanWrapper>("/api/2.0/settings/encryption/start", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("StartStorageEncryption", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start the storage encryption process Starts the storage encryption process.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageEncryptionRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-storage-encryption/">REST API Reference for StartStorageEncryption Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> StartStorageEncryptionAsync(StorageEncryptionRequestsDto? storageEncryptionRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await StartStorageEncryptionWithHttpInfoAsync(storageEncryptionRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start the storage encryption process Starts the storage encryption process.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageEncryptionRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-storage-encryption/">REST API Reference for StartStorageEncryption Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> StartStorageEncryptionWithHttpInfoAsync(StorageEncryptionRequestsDto? storageEncryptionRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (storageEncryptionRequestsDto != null) localVarRequestOptions.Data = storageEncryptionRequestsDto;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<BooleanWrapper>("/api/2.0/settings/encryption/start", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("StartStorageEncryption", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

    }
}
