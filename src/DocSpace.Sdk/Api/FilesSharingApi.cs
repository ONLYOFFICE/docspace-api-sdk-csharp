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
    public interface IFilesSharingApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Apply external data password
        /// </summary>
        /// <remarks>
        /// Applies a password specified in the request to get the external data.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique document identifier.</param>
        /// <param name="externalShareRequestParam">The external data share request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/apply-external-share-password/">REST API Reference for ApplyExternalSharePassword Operation</seealso>
        /// <returns>ExternalShareWrapper</returns>
        ExternalShareWrapper ApplyExternalSharePassword(string key, ExternalShareRequestParam? externalShareRequestParam = default);

        /// <summary>
        /// Apply external data password
        /// </summary>
        /// <remarks>
        /// Applies a password specified in the request to get the external data.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique document identifier.</param>
        /// <param name="externalShareRequestParam">The external data share request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/apply-external-share-password/">REST API Reference for ApplyExternalSharePassword Operation</seealso>
        /// <returns>ApiResponse of ExternalShareWrapper</returns>
        ApiResponse<ExternalShareWrapper> ApplyExternalSharePasswordWithHttpInfo(string key, ExternalShareRequestParam? externalShareRequestParam = default);
        /// <summary>
        /// Change the file owner
        /// </summary>
        /// <remarks>
        /// Changes the owner of the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeOwnerRequestDto">The request parameters for changing the file owner. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-file-owner/">REST API Reference for ChangeFileOwner Operation</seealso>
        /// <returns>FileEntryArrayWrapper</returns>
        FileEntryArrayWrapper ChangeFileOwner(ChangeOwnerRequestDto? changeOwnerRequestDto = default);

        /// <summary>
        /// Change the file owner
        /// </summary>
        /// <remarks>
        /// Changes the owner of the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeOwnerRequestDto">The request parameters for changing the file owner. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-file-owner/">REST API Reference for ChangeFileOwner Operation</seealso>
        /// <returns>ApiResponse of FileEntryArrayWrapper</returns>
        ApiResponse<FileEntryArrayWrapper> ChangeFileOwnerWithHttpInfo(ChangeOwnerRequestDto? changeOwnerRequestDto = default);
        /// <summary>
        /// Get the external data
        /// </summary>
        /// <remarks>
        /// Returns the external data by the key specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique key of the external shared data.</param>
        /// <param name="fileId">The unique document identifier. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-external-share-data/">REST API Reference for GetExternalShareData Operation</seealso>
        /// <returns>ExternalShareWrapper</returns>
        ExternalShareWrapper GetExternalShareData(string key, string? fileId = default);

        /// <summary>
        /// Get the external data
        /// </summary>
        /// <remarks>
        /// Returns the external data by the key specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique key of the external shared data.</param>
        /// <param name="fileId">The unique document identifier. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-external-share-data/">REST API Reference for GetExternalShareData Operation</seealso>
        /// <returns>ApiResponse of ExternalShareWrapper</returns>
        ApiResponse<ExternalShareWrapper> GetExternalShareDataWithHttpInfo(string key, string? fileId = default);
        /// <summary>
        /// Get user access rights by file ID
        /// </summary>
        /// <remarks>
        /// Returns a list of users with their access rights to the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-shared-users/">REST API Reference for GetSharedUsers Operation</seealso>
        /// <returns>MentionWrapperArrayWrapper</returns>
        MentionWrapperArrayWrapper GetSharedUsers(int fileId);

        /// <summary>
        /// Get user access rights by file ID
        /// </summary>
        /// <remarks>
        /// Returns a list of users with their access rights to the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-shared-users/">REST API Reference for GetSharedUsers Operation</seealso>
        /// <returns>ApiResponse of MentionWrapperArrayWrapper</returns>
        ApiResponse<MentionWrapperArrayWrapper> GetSharedUsersWithHttpInfo(int fileId);
        /// <summary>
        /// Send the mention message
        /// </summary>
        /// <remarks>
        /// Sends a message to the users who are mentioned in the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the mention message.</param>
        /// <param name="mentionMessageWrapper">The mention message. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-editor-notify/">REST API Reference for SendEditorNotify Operation</seealso>
        /// <returns>AceShortWrapperArrayWrapper</returns>
        AceShortWrapperArrayWrapper SendEditorNotify(int fileId, MentionMessageWrapper? mentionMessageWrapper = default);

        /// <summary>
        /// Send the mention message
        /// </summary>
        /// <remarks>
        /// Sends a message to the users who are mentioned in the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the mention message.</param>
        /// <param name="mentionMessageWrapper">The mention message. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-editor-notify/">REST API Reference for SendEditorNotify Operation</seealso>
        /// <returns>ApiResponse of AceShortWrapperArrayWrapper</returns>
        ApiResponse<AceShortWrapperArrayWrapper> SendEditorNotifyWithHttpInfo(int fileId, MentionMessageWrapper? mentionMessageWrapper = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFilesSharingApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Apply external data password
        /// </summary>
        /// <remarks>
        /// Applies a password specified in the request to get the external data.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique document identifier.</param>
        /// <param name="externalShareRequestParam">The external data share request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/apply-external-share-password/">REST API Reference for ApplyExternalSharePassword Operation</seealso>
        /// <returns>Task of ExternalShareWrapper</returns>
        Task<ExternalShareWrapper> ApplyExternalSharePasswordAsync(string key, ExternalShareRequestParam? externalShareRequestParam = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Apply external data password
        /// </summary>
        /// <remarks>
        /// Applies a password specified in the request to get the external data.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique document identifier.</param>
        /// <param name="externalShareRequestParam">The external data share request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/apply-external-share-password/">REST API Reference for ApplyExternalSharePassword Operation</seealso>
        /// <returns>Task of ApiResponse (ExternalShareWrapper)</returns>
        Task<ApiResponse<ExternalShareWrapper>> ApplyExternalSharePasswordWithHttpInfoAsync(string key, ExternalShareRequestParam? externalShareRequestParam = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Change the file owner
        /// </summary>
        /// <remarks>
        /// Changes the owner of the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeOwnerRequestDto">The request parameters for changing the file owner. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-file-owner/">REST API Reference for ChangeFileOwner Operation</seealso>
        /// <returns>Task of FileEntryArrayWrapper</returns>
        Task<FileEntryArrayWrapper> ChangeFileOwnerAsync(ChangeOwnerRequestDto? changeOwnerRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Change the file owner
        /// </summary>
        /// <remarks>
        /// Changes the owner of the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeOwnerRequestDto">The request parameters for changing the file owner. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-file-owner/">REST API Reference for ChangeFileOwner Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryArrayWrapper)</returns>
        Task<ApiResponse<FileEntryArrayWrapper>> ChangeFileOwnerWithHttpInfoAsync(ChangeOwnerRequestDto? changeOwnerRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the external data
        /// </summary>
        /// <remarks>
        /// Returns the external data by the key specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique key of the external shared data.</param>
        /// <param name="fileId">The unique document identifier. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-external-share-data/">REST API Reference for GetExternalShareData Operation</seealso>
        /// <returns>Task of ExternalShareWrapper</returns>
        Task<ExternalShareWrapper> GetExternalShareDataAsync(string key, string? fileId = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the external data
        /// </summary>
        /// <remarks>
        /// Returns the external data by the key specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique key of the external shared data.</param>
        /// <param name="fileId">The unique document identifier. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-external-share-data/">REST API Reference for GetExternalShareData Operation</seealso>
        /// <returns>Task of ApiResponse (ExternalShareWrapper)</returns>
        Task<ApiResponse<ExternalShareWrapper>> GetExternalShareDataWithHttpInfoAsync(string key, string? fileId = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user access rights by file ID
        /// </summary>
        /// <remarks>
        /// Returns a list of users with their access rights to the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-shared-users/">REST API Reference for GetSharedUsers Operation</seealso>
        /// <returns>Task of MentionWrapperArrayWrapper</returns>
        Task<MentionWrapperArrayWrapper> GetSharedUsersAsync(int fileId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get user access rights by file ID
        /// </summary>
        /// <remarks>
        /// Returns a list of users with their access rights to the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-shared-users/">REST API Reference for GetSharedUsers Operation</seealso>
        /// <returns>Task of ApiResponse (MentionWrapperArrayWrapper)</returns>
        Task<ApiResponse<MentionWrapperArrayWrapper>> GetSharedUsersWithHttpInfoAsync(int fileId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Send the mention message
        /// </summary>
        /// <remarks>
        /// Sends a message to the users who are mentioned in the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the mention message.</param>
        /// <param name="mentionMessageWrapper">The mention message. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-editor-notify/">REST API Reference for SendEditorNotify Operation</seealso>
        /// <returns>Task of AceShortWrapperArrayWrapper</returns>
        Task<AceShortWrapperArrayWrapper> SendEditorNotifyAsync(int fileId, MentionMessageWrapper? mentionMessageWrapper = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Send the mention message
        /// </summary>
        /// <remarks>
        /// Sends a message to the users who are mentioned in the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the mention message.</param>
        /// <param name="mentionMessageWrapper">The mention message. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-editor-notify/">REST API Reference for SendEditorNotify Operation</seealso>
        /// <returns>Task of ApiResponse (AceShortWrapperArrayWrapper)</returns>
        Task<ApiResponse<AceShortWrapperArrayWrapper>> SendEditorNotifyWithHttpInfoAsync(int fileId, MentionMessageWrapper? mentionMessageWrapper = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFilesSharingApi : IFilesSharingApiSync, IFilesSharingApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FilesSharingApi : IDisposable, IFilesSharingApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesSharingApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public FilesSharingApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesSharingApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public FilesSharingApi(string basePath)
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
        /// Initializes a new instance of the <see cref="FilesSharingApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public FilesSharingApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="FilesSharingApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public FilesSharingApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesSharingApi"/> class.
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
        public FilesSharingApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="FilesSharingApi"/> class using a Configuration object.
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
        public FilesSharingApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="FilesSharingApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public FilesSharingApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Apply external data password
        /// </summary>
        /// <remarks>
        /// Applies a password specified in the request to get the external data.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique document identifier.</param>
        /// <param name="externalShareRequestParam">The external data share request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/apply-external-share-password/">REST API Reference for ApplyExternalSharePassword Operation</seealso>
        /// <returns>ExternalShareWrapper</returns>
        public ExternalShareWrapper ApplyExternalSharePassword(string key, ExternalShareRequestParam? externalShareRequestParam = default)
        {
            var localVarResponse = ApplyExternalSharePasswordWithHttpInfo(key, externalShareRequestParam);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Apply external data password
        /// </summary>
        /// <remarks>
        /// Applies a password specified in the request to get the external data.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique document identifier.</param>
        /// <param name="externalShareRequestParam">The external data share request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/apply-external-share-password/">REST API Reference for ApplyExternalSharePassword Operation</seealso>
        /// <returns>ApiResponse of ExternalShareWrapper</returns>
        public ApiResponse<ExternalShareWrapper> ApplyExternalSharePasswordWithHttpInfo(string key, ExternalShareRequestParam? externalShareRequestParam = default)
        {
            // verify the required parameter 'key' is set
            if (key == null)
                throw new ApiException(400, "Missing required parameter 'key' when calling FilesSharingApi->ApplyExternalSharePassword");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("key", ClientUtils.ParameterToString(key)); // path parameter
            if (externalShareRequestParam != null) localVarRequestOptions.Data = externalShareRequestParam;


            // make the HTTP request
            var localVarResponse = Client.Post<ExternalShareWrapper>("/api/2.0/files/share/{key}/password", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ApplyExternalSharePassword", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Apply external data password
        /// </summary>
        /// <remarks>
        /// Applies a password specified in the request to get the external data.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique document identifier.</param>
        /// <param name="externalShareRequestParam">The external data share request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/apply-external-share-password/">REST API Reference for ApplyExternalSharePassword Operation</seealso>
        /// <returns>Task of ExternalShareWrapper</returns>
        public async Task<ExternalShareWrapper> ApplyExternalSharePasswordAsync(string key, ExternalShareRequestParam? externalShareRequestParam = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ApplyExternalSharePasswordWithHttpInfoAsync(key, externalShareRequestParam, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Apply external data password
        /// </summary>
        /// <remarks>
        /// Applies a password specified in the request to get the external data.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique document identifier.</param>
        /// <param name="externalShareRequestParam">The external data share request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/apply-external-share-password/">REST API Reference for ApplyExternalSharePassword Operation</seealso>
        /// <returns>Task of ApiResponse (ExternalShareWrapper)</returns>
        public async Task<ApiResponse<ExternalShareWrapper>> ApplyExternalSharePasswordWithHttpInfoAsync(string key, ExternalShareRequestParam? externalShareRequestParam = default, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'key' is set
            if (key == null)
                throw new ApiException(400, "Missing required parameter 'key' when calling FilesSharingApi->ApplyExternalSharePassword");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("key", ClientUtils.ParameterToString(key)); // path parameter
            if (externalShareRequestParam != null) localVarRequestOptions.Data = externalShareRequestParam;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<ExternalShareWrapper>("/api/2.0/files/share/{key}/password", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ApplyExternalSharePassword", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the file owner
        /// </summary>
        /// <remarks>
        /// Changes the owner of the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeOwnerRequestDto">The request parameters for changing the file owner. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-file-owner/">REST API Reference for ChangeFileOwner Operation</seealso>
        /// <returns>FileEntryArrayWrapper</returns>
        public FileEntryArrayWrapper ChangeFileOwner(ChangeOwnerRequestDto? changeOwnerRequestDto = default)
        {
            var localVarResponse = ChangeFileOwnerWithHttpInfo(changeOwnerRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the file owner
        /// </summary>
        /// <remarks>
        /// Changes the owner of the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeOwnerRequestDto">The request parameters for changing the file owner. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-file-owner/">REST API Reference for ChangeFileOwner Operation</seealso>
        /// <returns>ApiResponse of FileEntryArrayWrapper</returns>
        public ApiResponse<FileEntryArrayWrapper> ChangeFileOwnerWithHttpInfo(ChangeOwnerRequestDto? changeOwnerRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (changeOwnerRequestDto != null) localVarRequestOptions.Data = changeOwnerRequestDto;

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
            var localVarResponse = Client.Post<FileEntryArrayWrapper>("/api/2.0/files/owner", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangeFileOwner", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the file owner
        /// </summary>
        /// <remarks>
        /// Changes the owner of the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeOwnerRequestDto">The request parameters for changing the file owner. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-file-owner/">REST API Reference for ChangeFileOwner Operation</seealso>
        /// <returns>Task of FileEntryArrayWrapper</returns>
        public async Task<FileEntryArrayWrapper> ChangeFileOwnerAsync(ChangeOwnerRequestDto? changeOwnerRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ChangeFileOwnerWithHttpInfoAsync(changeOwnerRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the file owner
        /// </summary>
        /// <remarks>
        /// Changes the owner of the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeOwnerRequestDto">The request parameters for changing the file owner. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-file-owner/">REST API Reference for ChangeFileOwner Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryArrayWrapper)</returns>
        public async Task<ApiResponse<FileEntryArrayWrapper>> ChangeFileOwnerWithHttpInfoAsync(ChangeOwnerRequestDto? changeOwnerRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (changeOwnerRequestDto != null) localVarRequestOptions.Data = changeOwnerRequestDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<FileEntryArrayWrapper>("/api/2.0/files/owner", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangeFileOwner", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the external data
        /// </summary>
        /// <remarks>
        /// Returns the external data by the key specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique key of the external shared data.</param>
        /// <param name="fileId">The unique document identifier. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-external-share-data/">REST API Reference for GetExternalShareData Operation</seealso>
        /// <returns>ExternalShareWrapper</returns>
        public ExternalShareWrapper GetExternalShareData(string key, string? fileId = default)
        {
            var localVarResponse = GetExternalShareDataWithHttpInfo(key, fileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the external data
        /// </summary>
        /// <remarks>
        /// Returns the external data by the key specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique key of the external shared data.</param>
        /// <param name="fileId">The unique document identifier. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-external-share-data/">REST API Reference for GetExternalShareData Operation</seealso>
        /// <returns>ApiResponse of ExternalShareWrapper</returns>
        public ApiResponse<ExternalShareWrapper> GetExternalShareDataWithHttpInfo(string key, string? fileId = default)
        {
            // verify the required parameter 'key' is set
            if (key == null)
                throw new ApiException(400, "Missing required parameter 'key' when calling FilesSharingApi->GetExternalShareData");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("key", ClientUtils.ParameterToString(key)); // path parameter
            if (fileId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "fileId", fileId));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<ExternalShareWrapper>("/api/2.0/files/share/{key}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetExternalShareData", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the external data
        /// </summary>
        /// <remarks>
        /// Returns the external data by the key specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique key of the external shared data.</param>
        /// <param name="fileId">The unique document identifier. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-external-share-data/">REST API Reference for GetExternalShareData Operation</seealso>
        /// <returns>Task of ExternalShareWrapper</returns>
        public async Task<ExternalShareWrapper> GetExternalShareDataAsync(string key, string? fileId = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetExternalShareDataWithHttpInfoAsync(key, fileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the external data
        /// </summary>
        /// <remarks>
        /// Returns the external data by the key specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique key of the external shared data.</param>
        /// <param name="fileId">The unique document identifier. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-external-share-data/">REST API Reference for GetExternalShareData Operation</seealso>
        /// <returns>Task of ApiResponse (ExternalShareWrapper)</returns>
        public async Task<ApiResponse<ExternalShareWrapper>> GetExternalShareDataWithHttpInfoAsync(string key, string? fileId = default, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'key' is set
            if (key == null)
                throw new ApiException(400, "Missing required parameter 'key' when calling FilesSharingApi->GetExternalShareData");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("key", ClientUtils.ParameterToString(key)); // path parameter
            if (fileId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "fileId", fileId));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<ExternalShareWrapper>("/api/2.0/files/share/{key}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetExternalShareData", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get user access rights by file ID
        /// </summary>
        /// <remarks>
        /// Returns a list of users with their access rights to the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-shared-users/">REST API Reference for GetSharedUsers Operation</seealso>
        /// <returns>MentionWrapperArrayWrapper</returns>
        public MentionWrapperArrayWrapper GetSharedUsers(int fileId)
        {
            var localVarResponse = GetSharedUsersWithHttpInfo(fileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user access rights by file ID
        /// </summary>
        /// <remarks>
        /// Returns a list of users with their access rights to the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-shared-users/">REST API Reference for GetSharedUsers Operation</seealso>
        /// <returns>ApiResponse of MentionWrapperArrayWrapper</returns>
        public ApiResponse<MentionWrapperArrayWrapper> GetSharedUsersWithHttpInfo(int fileId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter

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
            var localVarResponse = Client.Get<MentionWrapperArrayWrapper>("/api/2.0/files/file/{fileId}/sharedusers", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetSharedUsers", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get user access rights by file ID
        /// </summary>
        /// <remarks>
        /// Returns a list of users with their access rights to the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-shared-users/">REST API Reference for GetSharedUsers Operation</seealso>
        /// <returns>Task of MentionWrapperArrayWrapper</returns>
        public async Task<MentionWrapperArrayWrapper> GetSharedUsersAsync(int fileId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetSharedUsersWithHttpInfoAsync(fileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user access rights by file ID
        /// </summary>
        /// <remarks>
        /// Returns a list of users with their access rights to the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-shared-users/">REST API Reference for GetSharedUsers Operation</seealso>
        /// <returns>Task of ApiResponse (MentionWrapperArrayWrapper)</returns>
        public async Task<ApiResponse<MentionWrapperArrayWrapper>> GetSharedUsersWithHttpInfoAsync(int fileId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter

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

            var localVarResponse = await AsynchronousClient.GetAsync<MentionWrapperArrayWrapper>("/api/2.0/files/file/{fileId}/sharedusers", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetSharedUsers", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send the mention message
        /// </summary>
        /// <remarks>
        /// Sends a message to the users who are mentioned in the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the mention message.</param>
        /// <param name="mentionMessageWrapper">The mention message. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-editor-notify/">REST API Reference for SendEditorNotify Operation</seealso>
        /// <returns>AceShortWrapperArrayWrapper</returns>
        public AceShortWrapperArrayWrapper SendEditorNotify(int fileId, MentionMessageWrapper? mentionMessageWrapper = default)
        {
            var localVarResponse = SendEditorNotifyWithHttpInfo(fileId, mentionMessageWrapper);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send the mention message
        /// </summary>
        /// <remarks>
        /// Sends a message to the users who are mentioned in the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the mention message.</param>
        /// <param name="mentionMessageWrapper">The mention message. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-editor-notify/">REST API Reference for SendEditorNotify Operation</seealso>
        /// <returns>ApiResponse of AceShortWrapperArrayWrapper</returns>
        public ApiResponse<AceShortWrapperArrayWrapper> SendEditorNotifyWithHttpInfo(int fileId, MentionMessageWrapper? mentionMessageWrapper = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (mentionMessageWrapper != null) localVarRequestOptions.Data = mentionMessageWrapper;

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
            var localVarResponse = Client.Post<AceShortWrapperArrayWrapper>("/api/2.0/files/file/{fileId}/sendeditornotify", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SendEditorNotify", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send the mention message
        /// </summary>
        /// <remarks>
        /// Sends a message to the users who are mentioned in the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the mention message.</param>
        /// <param name="mentionMessageWrapper">The mention message. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-editor-notify/">REST API Reference for SendEditorNotify Operation</seealso>
        /// <returns>Task of AceShortWrapperArrayWrapper</returns>
        public async Task<AceShortWrapperArrayWrapper> SendEditorNotifyAsync(int fileId, MentionMessageWrapper? mentionMessageWrapper = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SendEditorNotifyWithHttpInfoAsync(fileId, mentionMessageWrapper, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send the mention message
        /// </summary>
        /// <remarks>
        /// Sends a message to the users who are mentioned in the file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the mention message.</param>
        /// <param name="mentionMessageWrapper">The mention message. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-editor-notify/">REST API Reference for SendEditorNotify Operation</seealso>
        /// <returns>Task of ApiResponse (AceShortWrapperArrayWrapper)</returns>
        public async Task<ApiResponse<AceShortWrapperArrayWrapper>> SendEditorNotifyWithHttpInfoAsync(int fileId, MentionMessageWrapper? mentionMessageWrapper = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (mentionMessageWrapper != null) localVarRequestOptions.Data = mentionMessageWrapper;

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

            var localVarResponse = await AsynchronousClient.PostAsync<AceShortWrapperArrayWrapper>("/api/2.0/files/file/{fileId}/sendeditornotify", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SendEditorNotify", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
