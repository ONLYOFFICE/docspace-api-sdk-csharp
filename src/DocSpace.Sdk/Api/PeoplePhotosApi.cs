/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */


using DocSpace.Sdk.Client;
using DocSpace.Sdk.Model;

namespace DocSpace.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPeoplePhotosApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create photo thumbnails
        /// </summary>
        /// <remarks>
        /// Creates the user photo thumbnails by coordinates of the original image specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="thumbnailsRequest">The thumbnail request. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-member-photo-thumbnails/">REST API Reference for CreateMemberPhotoThumbnails Operation</seealso>
        /// <returns>ThumbnailsDataWrapper</returns>
        ThumbnailsDataWrapper CreateMemberPhotoThumbnails(string userid, ThumbnailsRequest? thumbnailsRequest = default);

        /// <summary>
        /// Create photo thumbnails
        /// </summary>
        /// <remarks>
        /// Creates the user photo thumbnails by coordinates of the original image specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="thumbnailsRequest">The thumbnail request. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-member-photo-thumbnails/">REST API Reference for CreateMemberPhotoThumbnails Operation</seealso>
        /// <returns>ApiResponse of ThumbnailsDataWrapper</returns>
        ApiResponse<ThumbnailsDataWrapper> CreateMemberPhotoThumbnailsWithHttpInfo(string userid, ThumbnailsRequest? thumbnailsRequest = default);
        /// <summary>
        /// Delete a user photo
        /// </summary>
        /// <remarks>
        /// Deletes a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member-photo/">REST API Reference for DeleteMemberPhoto Operation</seealso>
        /// <returns>ThumbnailsDataWrapper</returns>
        ThumbnailsDataWrapper DeleteMemberPhoto(string userid);

        /// <summary>
        /// Delete a user photo
        /// </summary>
        /// <remarks>
        /// Deletes a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member-photo/">REST API Reference for DeleteMemberPhoto Operation</seealso>
        /// <returns>ApiResponse of ThumbnailsDataWrapper</returns>
        ApiResponse<ThumbnailsDataWrapper> DeleteMemberPhotoWithHttpInfo(string userid);
        /// <summary>
        /// Get a user photo
        /// </summary>
        /// <remarks>
        /// Returns a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-member-photo/">REST API Reference for GetMemberPhoto Operation</seealso>
        /// <returns>ThumbnailsDataWrapper</returns>
        ThumbnailsDataWrapper GetMemberPhoto(string userid);

        /// <summary>
        /// Get a user photo
        /// </summary>
        /// <remarks>
        /// Returns a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-member-photo/">REST API Reference for GetMemberPhoto Operation</seealso>
        /// <returns>ApiResponse of ThumbnailsDataWrapper</returns>
        ApiResponse<ThumbnailsDataWrapper> GetMemberPhotoWithHttpInfo(string userid);
        /// <summary>
        /// Update a user photo
        /// </summary>
        /// <remarks>
        /// Updates a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updatePhotoMemberRequest">The request parameters for updating a photo. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-photo/">REST API Reference for UpdateMemberPhoto Operation</seealso>
        /// <returns>ThumbnailsDataWrapper</returns>
        ThumbnailsDataWrapper UpdateMemberPhoto(string userid, UpdatePhotoMemberRequest? updatePhotoMemberRequest = default);

        /// <summary>
        /// Update a user photo
        /// </summary>
        /// <remarks>
        /// Updates a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updatePhotoMemberRequest">The request parameters for updating a photo. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-photo/">REST API Reference for UpdateMemberPhoto Operation</seealso>
        /// <returns>ApiResponse of ThumbnailsDataWrapper</returns>
        ApiResponse<ThumbnailsDataWrapper> UpdateMemberPhotoWithHttpInfo(string userid, UpdatePhotoMemberRequest? updatePhotoMemberRequest = default);
        /// <summary>
        /// Upload a user photo
        /// </summary>
        /// <remarks>
        /// Uploads a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="formCollection">The image data.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-member-photo/">REST API Reference for UploadMemberPhoto Operation</seealso>
        /// <returns>FileUploadResultWrapper</returns>
        FileUploadResultWrapper UploadMemberPhoto(string userid, List<KeyValuePairStringStringValues> formCollection);

        /// <summary>
        /// Upload a user photo
        /// </summary>
        /// <remarks>
        /// Uploads a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="formCollection">The image data.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-member-photo/">REST API Reference for UploadMemberPhoto Operation</seealso>
        /// <returns>ApiResponse of FileUploadResultWrapper</returns>
        ApiResponse<FileUploadResultWrapper> UploadMemberPhotoWithHttpInfo(string userid, List<KeyValuePairStringStringValues> formCollection);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPeoplePhotosApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create photo thumbnails
        /// </summary>
        /// <remarks>
        /// Creates the user photo thumbnails by coordinates of the original image specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="thumbnailsRequest">The thumbnail request. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-member-photo-thumbnails/">REST API Reference for CreateMemberPhotoThumbnails Operation</seealso>
        /// <returns>Task of ThumbnailsDataWrapper</returns>
        Task<ThumbnailsDataWrapper> CreateMemberPhotoThumbnailsAsync(string userid, ThumbnailsRequest? thumbnailsRequest = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create photo thumbnails
        /// </summary>
        /// <remarks>
        /// Creates the user photo thumbnails by coordinates of the original image specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="thumbnailsRequest">The thumbnail request. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-member-photo-thumbnails/">REST API Reference for CreateMemberPhotoThumbnails Operation</seealso>
        /// <returns>Task of ApiResponse (ThumbnailsDataWrapper)</returns>
        Task<ApiResponse<ThumbnailsDataWrapper>> CreateMemberPhotoThumbnailsWithHttpInfoAsync(string userid, ThumbnailsRequest? thumbnailsRequest = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a user photo
        /// </summary>
        /// <remarks>
        /// Deletes a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member-photo/">REST API Reference for DeleteMemberPhoto Operation</seealso>
        /// <returns>Task of ThumbnailsDataWrapper</returns>
        Task<ThumbnailsDataWrapper> DeleteMemberPhotoAsync(string userid, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a user photo
        /// </summary>
        /// <remarks>
        /// Deletes a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member-photo/">REST API Reference for DeleteMemberPhoto Operation</seealso>
        /// <returns>Task of ApiResponse (ThumbnailsDataWrapper)</returns>
        Task<ApiResponse<ThumbnailsDataWrapper>> DeleteMemberPhotoWithHttpInfoAsync(string userid, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a user photo
        /// </summary>
        /// <remarks>
        /// Returns a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-member-photo/">REST API Reference for GetMemberPhoto Operation</seealso>
        /// <returns>Task of ThumbnailsDataWrapper</returns>
        Task<ThumbnailsDataWrapper> GetMemberPhotoAsync(string userid, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a user photo
        /// </summary>
        /// <remarks>
        /// Returns a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-member-photo/">REST API Reference for GetMemberPhoto Operation</seealso>
        /// <returns>Task of ApiResponse (ThumbnailsDataWrapper)</returns>
        Task<ApiResponse<ThumbnailsDataWrapper>> GetMemberPhotoWithHttpInfoAsync(string userid, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a user photo
        /// </summary>
        /// <remarks>
        /// Updates a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updatePhotoMemberRequest">The request parameters for updating a photo. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-photo/">REST API Reference for UpdateMemberPhoto Operation</seealso>
        /// <returns>Task of ThumbnailsDataWrapper</returns>
        Task<ThumbnailsDataWrapper> UpdateMemberPhotoAsync(string userid, UpdatePhotoMemberRequest? updatePhotoMemberRequest = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a user photo
        /// </summary>
        /// <remarks>
        /// Updates a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updatePhotoMemberRequest">The request parameters for updating a photo. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-photo/">REST API Reference for UpdateMemberPhoto Operation</seealso>
        /// <returns>Task of ApiResponse (ThumbnailsDataWrapper)</returns>
        Task<ApiResponse<ThumbnailsDataWrapper>> UpdateMemberPhotoWithHttpInfoAsync(string userid, UpdatePhotoMemberRequest? updatePhotoMemberRequest = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a user photo
        /// </summary>
        /// <remarks>
        /// Uploads a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="formCollection">The image data.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-member-photo/">REST API Reference for UploadMemberPhoto Operation</seealso>
        /// <returns>Task of FileUploadResultWrapper</returns>
        Task<FileUploadResultWrapper> UploadMemberPhotoAsync(string userid, List<KeyValuePairStringStringValues> formCollection, CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a user photo
        /// </summary>
        /// <remarks>
        /// Uploads a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="formCollection">The image data.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-member-photo/">REST API Reference for UploadMemberPhoto Operation</seealso>
        /// <returns>Task of ApiResponse (FileUploadResultWrapper)</returns>
        Task<ApiResponse<FileUploadResultWrapper>> UploadMemberPhotoWithHttpInfoAsync(string userid, List<KeyValuePairStringStringValues> formCollection, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPeoplePhotosApi : IPeoplePhotosApiSync, IPeoplePhotosApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PeoplePhotosApi : IDisposable, IPeoplePhotosApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PeoplePhotosApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public PeoplePhotosApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeoplePhotosApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public PeoplePhotosApi(string basePath)
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
        /// Initializes a new instance of the <see cref="PeoplePhotosApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public PeoplePhotosApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="PeoplePhotosApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public PeoplePhotosApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeoplePhotosApi"/> class.
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
        public PeoplePhotosApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="PeoplePhotosApi"/> class using a Configuration object.
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
        public PeoplePhotosApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="PeoplePhotosApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public PeoplePhotosApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Create photo thumbnails
        /// </summary>
        /// <remarks>
        /// Creates the user photo thumbnails by coordinates of the original image specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="thumbnailsRequest">The thumbnail request. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-member-photo-thumbnails/">REST API Reference for CreateMemberPhotoThumbnails Operation</seealso>
        /// <returns>ThumbnailsDataWrapper</returns>
        public ThumbnailsDataWrapper CreateMemberPhotoThumbnails(string userid, ThumbnailsRequest? thumbnailsRequest = default)
        {
            var localVarResponse = CreateMemberPhotoThumbnailsWithHttpInfo(userid, thumbnailsRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create photo thumbnails
        /// </summary>
        /// <remarks>
        /// Creates the user photo thumbnails by coordinates of the original image specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="thumbnailsRequest">The thumbnail request. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-member-photo-thumbnails/">REST API Reference for CreateMemberPhotoThumbnails Operation</seealso>
        /// <returns>ApiResponse of ThumbnailsDataWrapper</returns>
        public ApiResponse<ThumbnailsDataWrapper> CreateMemberPhotoThumbnailsWithHttpInfo(string userid, ThumbnailsRequest? thumbnailsRequest = default)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling PeoplePhotosApi->CreateMemberPhotoThumbnails");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter
            if (thumbnailsRequest != null) localVarRequestOptions.Data = thumbnailsRequest;

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
            var localVarResponse = Client.Post<ThumbnailsDataWrapper>("/api/2.0/people/{userid}/photo/thumbnails", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateMemberPhotoThumbnails", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create photo thumbnails
        /// </summary>
        /// <remarks>
        /// Creates the user photo thumbnails by coordinates of the original image specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="thumbnailsRequest">The thumbnail request. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-member-photo-thumbnails/">REST API Reference for CreateMemberPhotoThumbnails Operation</seealso>
        /// <returns>Task of ThumbnailsDataWrapper</returns>
        public async Task<ThumbnailsDataWrapper> CreateMemberPhotoThumbnailsAsync(string userid, ThumbnailsRequest? thumbnailsRequest = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateMemberPhotoThumbnailsWithHttpInfoAsync(userid, thumbnailsRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create photo thumbnails
        /// </summary>
        /// <remarks>
        /// Creates the user photo thumbnails by coordinates of the original image specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="thumbnailsRequest">The thumbnail request. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-member-photo-thumbnails/">REST API Reference for CreateMemberPhotoThumbnails Operation</seealso>
        /// <returns>Task of ApiResponse (ThumbnailsDataWrapper)</returns>
        public async Task<ApiResponse<ThumbnailsDataWrapper>> CreateMemberPhotoThumbnailsWithHttpInfoAsync(string userid, ThumbnailsRequest? thumbnailsRequest = default, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling PeoplePhotosApi->CreateMemberPhotoThumbnails");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter
            if (thumbnailsRequest != null) localVarRequestOptions.Data = thumbnailsRequest;

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

            var localVarResponse = await AsynchronousClient.PostAsync<ThumbnailsDataWrapper>("/api/2.0/people/{userid}/photo/thumbnails", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateMemberPhotoThumbnails", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a user photo
        /// </summary>
        /// <remarks>
        /// Deletes a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member-photo/">REST API Reference for DeleteMemberPhoto Operation</seealso>
        /// <returns>ThumbnailsDataWrapper</returns>
        public ThumbnailsDataWrapper DeleteMemberPhoto(string userid)
        {
            var localVarResponse = DeleteMemberPhotoWithHttpInfo(userid);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a user photo
        /// </summary>
        /// <remarks>
        /// Deletes a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member-photo/">REST API Reference for DeleteMemberPhoto Operation</seealso>
        /// <returns>ApiResponse of ThumbnailsDataWrapper</returns>
        public ApiResponse<ThumbnailsDataWrapper> DeleteMemberPhotoWithHttpInfo(string userid)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling PeoplePhotosApi->DeleteMemberPhoto");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter

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
            var localVarResponse = Client.Delete<ThumbnailsDataWrapper>("/api/2.0/people/{userid}/photo", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteMemberPhoto", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a user photo
        /// </summary>
        /// <remarks>
        /// Deletes a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member-photo/">REST API Reference for DeleteMemberPhoto Operation</seealso>
        /// <returns>Task of ThumbnailsDataWrapper</returns>
        public async Task<ThumbnailsDataWrapper> DeleteMemberPhotoAsync(string userid, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeleteMemberPhotoWithHttpInfoAsync(userid, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a user photo
        /// </summary>
        /// <remarks>
        /// Deletes a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member-photo/">REST API Reference for DeleteMemberPhoto Operation</seealso>
        /// <returns>Task of ApiResponse (ThumbnailsDataWrapper)</returns>
        public async Task<ApiResponse<ThumbnailsDataWrapper>> DeleteMemberPhotoWithHttpInfoAsync(string userid, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling PeoplePhotosApi->DeleteMemberPhoto");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<ThumbnailsDataWrapper>("/api/2.0/people/{userid}/photo", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteMemberPhoto", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a user photo
        /// </summary>
        /// <remarks>
        /// Returns a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-member-photo/">REST API Reference for GetMemberPhoto Operation</seealso>
        /// <returns>ThumbnailsDataWrapper</returns>
        public ThumbnailsDataWrapper GetMemberPhoto(string userid)
        {
            var localVarResponse = GetMemberPhotoWithHttpInfo(userid);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a user photo
        /// </summary>
        /// <remarks>
        /// Returns a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-member-photo/">REST API Reference for GetMemberPhoto Operation</seealso>
        /// <returns>ApiResponse of ThumbnailsDataWrapper</returns>
        public ApiResponse<ThumbnailsDataWrapper> GetMemberPhotoWithHttpInfo(string userid)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling PeoplePhotosApi->GetMemberPhoto");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter

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
            var localVarResponse = Client.Get<ThumbnailsDataWrapper>("/api/2.0/people/{userid}/photo", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetMemberPhoto", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a user photo
        /// </summary>
        /// <remarks>
        /// Returns a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-member-photo/">REST API Reference for GetMemberPhoto Operation</seealso>
        /// <returns>Task of ThumbnailsDataWrapper</returns>
        public async Task<ThumbnailsDataWrapper> GetMemberPhotoAsync(string userid, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetMemberPhotoWithHttpInfoAsync(userid, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a user photo
        /// </summary>
        /// <remarks>
        /// Returns a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-member-photo/">REST API Reference for GetMemberPhoto Operation</seealso>
        /// <returns>Task of ApiResponse (ThumbnailsDataWrapper)</returns>
        public async Task<ApiResponse<ThumbnailsDataWrapper>> GetMemberPhotoWithHttpInfoAsync(string userid, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling PeoplePhotosApi->GetMemberPhoto");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter

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

            var localVarResponse = await AsynchronousClient.GetAsync<ThumbnailsDataWrapper>("/api/2.0/people/{userid}/photo", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetMemberPhoto", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a user photo
        /// </summary>
        /// <remarks>
        /// Updates a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updatePhotoMemberRequest">The request parameters for updating a photo. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-photo/">REST API Reference for UpdateMemberPhoto Operation</seealso>
        /// <returns>ThumbnailsDataWrapper</returns>
        public ThumbnailsDataWrapper UpdateMemberPhoto(string userid, UpdatePhotoMemberRequest? updatePhotoMemberRequest = default)
        {
            var localVarResponse = UpdateMemberPhotoWithHttpInfo(userid, updatePhotoMemberRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a user photo
        /// </summary>
        /// <remarks>
        /// Updates a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updatePhotoMemberRequest">The request parameters for updating a photo. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-photo/">REST API Reference for UpdateMemberPhoto Operation</seealso>
        /// <returns>ApiResponse of ThumbnailsDataWrapper</returns>
        public ApiResponse<ThumbnailsDataWrapper> UpdateMemberPhotoWithHttpInfo(string userid, UpdatePhotoMemberRequest? updatePhotoMemberRequest = default)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling PeoplePhotosApi->UpdateMemberPhoto");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter
            if (updatePhotoMemberRequest != null) localVarRequestOptions.Data = updatePhotoMemberRequest;

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
            var localVarResponse = Client.Put<ThumbnailsDataWrapper>("/api/2.0/people/{userid}/photo", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateMemberPhoto", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a user photo
        /// </summary>
        /// <remarks>
        /// Updates a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updatePhotoMemberRequest">The request parameters for updating a photo. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-photo/">REST API Reference for UpdateMemberPhoto Operation</seealso>
        /// <returns>Task of ThumbnailsDataWrapper</returns>
        public async Task<ThumbnailsDataWrapper> UpdateMemberPhotoAsync(string userid, UpdatePhotoMemberRequest? updatePhotoMemberRequest = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateMemberPhotoWithHttpInfoAsync(userid, updatePhotoMemberRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a user photo
        /// </summary>
        /// <remarks>
        /// Updates a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updatePhotoMemberRequest">The request parameters for updating a photo. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-photo/">REST API Reference for UpdateMemberPhoto Operation</seealso>
        /// <returns>Task of ApiResponse (ThumbnailsDataWrapper)</returns>
        public async Task<ApiResponse<ThumbnailsDataWrapper>> UpdateMemberPhotoWithHttpInfoAsync(string userid, UpdatePhotoMemberRequest? updatePhotoMemberRequest = default, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling PeoplePhotosApi->UpdateMemberPhoto");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter
            if (updatePhotoMemberRequest != null) localVarRequestOptions.Data = updatePhotoMemberRequest;

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

            var localVarResponse = await AsynchronousClient.PutAsync<ThumbnailsDataWrapper>("/api/2.0/people/{userid}/photo", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateMemberPhoto", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Upload a user photo
        /// </summary>
        /// <remarks>
        /// Uploads a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="formCollection">The image data.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-member-photo/">REST API Reference for UploadMemberPhoto Operation</seealso>
        /// <returns>FileUploadResultWrapper</returns>
        public FileUploadResultWrapper UploadMemberPhoto(string userid, List<KeyValuePairStringStringValues> formCollection)
        {
            var localVarResponse = UploadMemberPhotoWithHttpInfo(userid, formCollection);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Upload a user photo
        /// </summary>
        /// <remarks>
        /// Uploads a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="formCollection">The image data.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-member-photo/">REST API Reference for UploadMemberPhoto Operation</seealso>
        /// <returns>ApiResponse of FileUploadResultWrapper</returns>
        public ApiResponse<FileUploadResultWrapper> UploadMemberPhotoWithHttpInfo(string userid, List<KeyValuePairStringStringValues> formCollection)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling PeoplePhotosApi->UploadMemberPhoto");

            // verify the required parameter 'formCollection' is set
            if (formCollection == null)
                throw new ApiException(400, "Missing required parameter 'formCollection' when calling PeoplePhotosApi->UploadMemberPhoto");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter
            localVarRequestOptions.FormParameters.Add("formCollection", ClientUtils.ParameterToString(formCollection)); // form parameter

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
            var localVarResponse = Client.Post<FileUploadResultWrapper>("/api/2.0/people/{userid}/photo", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UploadMemberPhoto", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Upload a user photo
        /// </summary>
        /// <remarks>
        /// Uploads a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="formCollection">The image data.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-member-photo/">REST API Reference for UploadMemberPhoto Operation</seealso>
        /// <returns>Task of FileUploadResultWrapper</returns>
        public async Task<FileUploadResultWrapper> UploadMemberPhotoAsync(string userid, List<KeyValuePairStringStringValues> formCollection, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UploadMemberPhotoWithHttpInfoAsync(userid, formCollection, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Upload a user photo
        /// </summary>
        /// <remarks>
        /// Uploads a photo of the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="formCollection">The image data.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-member-photo/">REST API Reference for UploadMemberPhoto Operation</seealso>
        /// <returns>Task of ApiResponse (FileUploadResultWrapper)</returns>
        public async Task<ApiResponse<FileUploadResultWrapper>> UploadMemberPhotoWithHttpInfoAsync(string userid, List<KeyValuePairStringStringValues> formCollection, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling PeoplePhotosApi->UploadMemberPhoto");

            // verify the required parameter 'formCollection' is set
            if (formCollection == null)
                throw new ApiException(400, "Missing required parameter 'formCollection' when calling PeoplePhotosApi->UploadMemberPhoto");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter
            localVarRequestOptions.FormParameters.Add("formCollection", DocSpace.Sdk.Client.ClientUtils.ParameterToString(formCollection)); // form parameter

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

            var localVarResponse = await AsynchronousClient.PostAsync<FileUploadResultWrapper>("/api/2.0/people/{userid}/photo", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UploadMemberPhoto", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
