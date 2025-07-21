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
    public interface IPeopleUserTypeApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the progress of updating user type
        /// </summary>
        /// <remarks>
        /// Returns the progress of updating the user type.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-type-update-progress/">REST API Reference for GetUserTypeUpdateProgress Operation</seealso>
        /// <returns>TaskProgressResponseWrapper</returns>
        TaskProgressResponseWrapper GetUserTypeUpdateProgress(Guid userid);

        /// <summary>
        /// Get the progress of updating user type
        /// </summary>
        /// <remarks>
        /// Returns the progress of updating the user type.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-type-update-progress/">REST API Reference for GetUserTypeUpdateProgress Operation</seealso>
        /// <returns>ApiResponse of TaskProgressResponseWrapper</returns>
        ApiResponse<TaskProgressResponseWrapper> GetUserTypeUpdateProgressWithHttpInfo(Guid userid);
        /// <summary>
        /// Update user type
        /// </summary>
        /// <remarks>
        /// Starts updating the type of the user or guest when reassigning rooms and shared files.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startUpdateUserTypeDto">The parameters for updating the type of the user or guest when reassigning rooms and shared files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/star-user-typet-update/">REST API Reference for StarUserTypetUpdate Operation</seealso>
        /// <returns>TaskProgressResponseWrapper</returns>
        TaskProgressResponseWrapper StarUserTypetUpdate(StartUpdateUserTypeDto? startUpdateUserTypeDto = default);

        /// <summary>
        /// Update user type
        /// </summary>
        /// <remarks>
        /// Starts updating the type of the user or guest when reassigning rooms and shared files.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startUpdateUserTypeDto">The parameters for updating the type of the user or guest when reassigning rooms and shared files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/star-user-typet-update/">REST API Reference for StarUserTypetUpdate Operation</seealso>
        /// <returns>ApiResponse of TaskProgressResponseWrapper</returns>
        ApiResponse<TaskProgressResponseWrapper> StarUserTypetUpdateWithHttpInfo(StartUpdateUserTypeDto? startUpdateUserTypeDto = default);
        /// <summary>
        /// Terminate update user type
        /// </summary>
        /// <remarks>
        /// Terminates the process of updating the type of the user or guest.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminateRequestDto">The request parameters for terminating the reassignment/deletion process. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-user-type-update/">REST API Reference for TerminateUserTypeUpdate Operation</seealso>
        /// <returns>TaskProgressResponseWrapper</returns>
        TaskProgressResponseWrapper TerminateUserTypeUpdate(TerminateRequestDto? terminateRequestDto = default);

        /// <summary>
        /// Terminate update user type
        /// </summary>
        /// <remarks>
        /// Terminates the process of updating the type of the user or guest.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminateRequestDto">The request parameters for terminating the reassignment/deletion process. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-user-type-update/">REST API Reference for TerminateUserTypeUpdate Operation</seealso>
        /// <returns>ApiResponse of TaskProgressResponseWrapper</returns>
        ApiResponse<TaskProgressResponseWrapper> TerminateUserTypeUpdateWithHttpInfo(TerminateRequestDto? terminateRequestDto = default);
        /// <summary>
        /// Change a user type
        /// </summary>
        /// <remarks>
        /// Changes a type of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The new user type.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-type/">REST API Reference for UpdateUserType Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        EmployeeFullArrayWrapper UpdateUserType(EmployeeType type, UpdateMembersRequestDto? updateMembersRequestDto = default);

        /// <summary>
        /// Change a user type
        /// </summary>
        /// <remarks>
        /// Changes a type of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The new user type.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-type/">REST API Reference for UpdateUserType Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        ApiResponse<EmployeeFullArrayWrapper> UpdateUserTypeWithHttpInfo(EmployeeType type, UpdateMembersRequestDto? updateMembersRequestDto = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPeopleUserTypeApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get the progress of updating user type
        /// </summary>
        /// <remarks>
        /// Returns the progress of updating the user type.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-type-update-progress/">REST API Reference for GetUserTypeUpdateProgress Operation</seealso>
        /// <returns>Task of TaskProgressResponseWrapper</returns>
        Task<TaskProgressResponseWrapper> GetUserTypeUpdateProgressAsync(Guid userid, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the progress of updating user type
        /// </summary>
        /// <remarks>
        /// Returns the progress of updating the user type.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-type-update-progress/">REST API Reference for GetUserTypeUpdateProgress Operation</seealso>
        /// <returns>Task of ApiResponse (TaskProgressResponseWrapper)</returns>
        Task<ApiResponse<TaskProgressResponseWrapper>> GetUserTypeUpdateProgressWithHttpInfoAsync(Guid userid, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update user type
        /// </summary>
        /// <remarks>
        /// Starts updating the type of the user or guest when reassigning rooms and shared files.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startUpdateUserTypeDto">The parameters for updating the type of the user or guest when reassigning rooms and shared files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/star-user-typet-update/">REST API Reference for StarUserTypetUpdate Operation</seealso>
        /// <returns>Task of TaskProgressResponseWrapper</returns>
        Task<TaskProgressResponseWrapper> StarUserTypetUpdateAsync(StartUpdateUserTypeDto? startUpdateUserTypeDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update user type
        /// </summary>
        /// <remarks>
        /// Starts updating the type of the user or guest when reassigning rooms and shared files.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startUpdateUserTypeDto">The parameters for updating the type of the user or guest when reassigning rooms and shared files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/star-user-typet-update/">REST API Reference for StarUserTypetUpdate Operation</seealso>
        /// <returns>Task of ApiResponse (TaskProgressResponseWrapper)</returns>
        Task<ApiResponse<TaskProgressResponseWrapper>> StarUserTypetUpdateWithHttpInfoAsync(StartUpdateUserTypeDto? startUpdateUserTypeDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Terminate update user type
        /// </summary>
        /// <remarks>
        /// Terminates the process of updating the type of the user or guest.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminateRequestDto">The request parameters for terminating the reassignment/deletion process. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-user-type-update/">REST API Reference for TerminateUserTypeUpdate Operation</seealso>
        /// <returns>Task of TaskProgressResponseWrapper</returns>
        Task<TaskProgressResponseWrapper> TerminateUserTypeUpdateAsync(TerminateRequestDto? terminateRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Terminate update user type
        /// </summary>
        /// <remarks>
        /// Terminates the process of updating the type of the user or guest.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminateRequestDto">The request parameters for terminating the reassignment/deletion process. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-user-type-update/">REST API Reference for TerminateUserTypeUpdate Operation</seealso>
        /// <returns>Task of ApiResponse (TaskProgressResponseWrapper)</returns>
        Task<ApiResponse<TaskProgressResponseWrapper>> TerminateUserTypeUpdateWithHttpInfoAsync(TerminateRequestDto? terminateRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Change a user type
        /// </summary>
        /// <remarks>
        /// Changes a type of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The new user type.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-type/">REST API Reference for UpdateUserType Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        Task<EmployeeFullArrayWrapper> UpdateUserTypeAsync(EmployeeType type, UpdateMembersRequestDto? updateMembersRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Change a user type
        /// </summary>
        /// <remarks>
        /// Changes a type of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The new user type.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-type/">REST API Reference for UpdateUserType Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        Task<ApiResponse<EmployeeFullArrayWrapper>> UpdateUserTypeWithHttpInfoAsync(EmployeeType type, UpdateMembersRequestDto? updateMembersRequestDto = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPeopleUserTypeApi : IPeopleUserTypeApiSync, IPeopleUserTypeApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PeopleUserTypeApi : IDisposable, IPeopleUserTypeApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleUserTypeApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public PeopleUserTypeApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleUserTypeApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public PeopleUserTypeApi(string basePath)
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
        /// Initializes a new instance of the <see cref="PeopleUserTypeApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public PeopleUserTypeApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="PeopleUserTypeApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public PeopleUserTypeApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleUserTypeApi"/> class.
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
        public PeopleUserTypeApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="PeopleUserTypeApi"/> class using a Configuration object.
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
        public PeopleUserTypeApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="PeopleUserTypeApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public PeopleUserTypeApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Get the progress of updating user type
        /// </summary>
        /// <remarks>
        /// Returns the progress of updating the user type.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-type-update-progress/">REST API Reference for GetUserTypeUpdateProgress Operation</seealso>
        /// <returns>TaskProgressResponseWrapper</returns>
        public TaskProgressResponseWrapper GetUserTypeUpdateProgress(Guid userid)
        {
            var localVarResponse = GetUserTypeUpdateProgressWithHttpInfo(userid);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the progress of updating user type
        /// </summary>
        /// <remarks>
        /// Returns the progress of updating the user type.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-type-update-progress/">REST API Reference for GetUserTypeUpdateProgress Operation</seealso>
        /// <returns>ApiResponse of TaskProgressResponseWrapper</returns>
        public ApiResponse<TaskProgressResponseWrapper> GetUserTypeUpdateProgressWithHttpInfo(Guid userid)
        {
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
            var localVarResponse = Client.Get<TaskProgressResponseWrapper>("/api/2.0/people/type/progress/{userid}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetUserTypeUpdateProgress", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the progress of updating user type
        /// </summary>
        /// <remarks>
        /// Returns the progress of updating the user type.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-type-update-progress/">REST API Reference for GetUserTypeUpdateProgress Operation</seealso>
        /// <returns>Task of TaskProgressResponseWrapper</returns>
        public async Task<TaskProgressResponseWrapper> GetUserTypeUpdateProgressAsync(Guid userid, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetUserTypeUpdateProgressWithHttpInfoAsync(userid, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the progress of updating user type
        /// </summary>
        /// <remarks>
        /// Returns the progress of updating the user type.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-type-update-progress/">REST API Reference for GetUserTypeUpdateProgress Operation</seealso>
        /// <returns>Task of ApiResponse (TaskProgressResponseWrapper)</returns>
        public async Task<ApiResponse<TaskProgressResponseWrapper>> GetUserTypeUpdateProgressWithHttpInfoAsync(Guid userid, CancellationToken cancellationToken = default)
        {
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

            var localVarResponse = await AsynchronousClient.GetAsync<TaskProgressResponseWrapper>("/api/2.0/people/type/progress/{userid}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetUserTypeUpdateProgress", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update user type
        /// </summary>
        /// <remarks>
        /// Starts updating the type of the user or guest when reassigning rooms and shared files.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startUpdateUserTypeDto">The parameters for updating the type of the user or guest when reassigning rooms and shared files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/star-user-typet-update/">REST API Reference for StarUserTypetUpdate Operation</seealso>
        /// <returns>TaskProgressResponseWrapper</returns>
        public TaskProgressResponseWrapper StarUserTypetUpdate(StartUpdateUserTypeDto? startUpdateUserTypeDto = default)
        {
            var localVarResponse = StarUserTypetUpdateWithHttpInfo(startUpdateUserTypeDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update user type
        /// </summary>
        /// <remarks>
        /// Starts updating the type of the user or guest when reassigning rooms and shared files.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startUpdateUserTypeDto">The parameters for updating the type of the user or guest when reassigning rooms and shared files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/star-user-typet-update/">REST API Reference for StarUserTypetUpdate Operation</seealso>
        /// <returns>ApiResponse of TaskProgressResponseWrapper</returns>
        public ApiResponse<TaskProgressResponseWrapper> StarUserTypetUpdateWithHttpInfo(StartUpdateUserTypeDto? startUpdateUserTypeDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (startUpdateUserTypeDto != null) localVarRequestOptions.Data = startUpdateUserTypeDto;

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
            var localVarResponse = Client.Post<TaskProgressResponseWrapper>("/api/2.0/people/type", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("StarUserTypetUpdate", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update user type
        /// </summary>
        /// <remarks>
        /// Starts updating the type of the user or guest when reassigning rooms and shared files.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startUpdateUserTypeDto">The parameters for updating the type of the user or guest when reassigning rooms and shared files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/star-user-typet-update/">REST API Reference for StarUserTypetUpdate Operation</seealso>
        /// <returns>Task of TaskProgressResponseWrapper</returns>
        public async Task<TaskProgressResponseWrapper> StarUserTypetUpdateAsync(StartUpdateUserTypeDto? startUpdateUserTypeDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await StarUserTypetUpdateWithHttpInfoAsync(startUpdateUserTypeDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update user type
        /// </summary>
        /// <remarks>
        /// Starts updating the type of the user or guest when reassigning rooms and shared files.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startUpdateUserTypeDto">The parameters for updating the type of the user or guest when reassigning rooms and shared files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/star-user-typet-update/">REST API Reference for StarUserTypetUpdate Operation</seealso>
        /// <returns>Task of ApiResponse (TaskProgressResponseWrapper)</returns>
        public async Task<ApiResponse<TaskProgressResponseWrapper>> StarUserTypetUpdateWithHttpInfoAsync(StartUpdateUserTypeDto? startUpdateUserTypeDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (startUpdateUserTypeDto != null) localVarRequestOptions.Data = startUpdateUserTypeDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<TaskProgressResponseWrapper>("/api/2.0/people/type", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("StarUserTypetUpdate", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Terminate update user type
        /// </summary>
        /// <remarks>
        /// Terminates the process of updating the type of the user or guest.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminateRequestDto">The request parameters for terminating the reassignment/deletion process. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-user-type-update/">REST API Reference for TerminateUserTypeUpdate Operation</seealso>
        /// <returns>TaskProgressResponseWrapper</returns>
        public TaskProgressResponseWrapper TerminateUserTypeUpdate(TerminateRequestDto? terminateRequestDto = default)
        {
            var localVarResponse = TerminateUserTypeUpdateWithHttpInfo(terminateRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Terminate update user type
        /// </summary>
        /// <remarks>
        /// Terminates the process of updating the type of the user or guest.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminateRequestDto">The request parameters for terminating the reassignment/deletion process. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-user-type-update/">REST API Reference for TerminateUserTypeUpdate Operation</seealso>
        /// <returns>ApiResponse of TaskProgressResponseWrapper</returns>
        public ApiResponse<TaskProgressResponseWrapper> TerminateUserTypeUpdateWithHttpInfo(TerminateRequestDto? terminateRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (terminateRequestDto != null) localVarRequestOptions.Data = terminateRequestDto;

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
            var localVarResponse = Client.Put<TaskProgressResponseWrapper>("/api/2.0/people/type/terminate", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("TerminateUserTypeUpdate", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Terminate update user type
        /// </summary>
        /// <remarks>
        /// Terminates the process of updating the type of the user or guest.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminateRequestDto">The request parameters for terminating the reassignment/deletion process. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-user-type-update/">REST API Reference for TerminateUserTypeUpdate Operation</seealso>
        /// <returns>Task of TaskProgressResponseWrapper</returns>
        public async Task<TaskProgressResponseWrapper> TerminateUserTypeUpdateAsync(TerminateRequestDto? terminateRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await TerminateUserTypeUpdateWithHttpInfoAsync(terminateRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Terminate update user type
        /// </summary>
        /// <remarks>
        /// Terminates the process of updating the type of the user or guest.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminateRequestDto">The request parameters for terminating the reassignment/deletion process. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-user-type-update/">REST API Reference for TerminateUserTypeUpdate Operation</seealso>
        /// <returns>Task of ApiResponse (TaskProgressResponseWrapper)</returns>
        public async Task<ApiResponse<TaskProgressResponseWrapper>> TerminateUserTypeUpdateWithHttpInfoAsync(TerminateRequestDto? terminateRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (terminateRequestDto != null) localVarRequestOptions.Data = terminateRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<TaskProgressResponseWrapper>("/api/2.0/people/type/terminate", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("TerminateUserTypeUpdate", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change a user type
        /// </summary>
        /// <remarks>
        /// Changes a type of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The new user type.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-type/">REST API Reference for UpdateUserType Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        public EmployeeFullArrayWrapper UpdateUserType(EmployeeType type, UpdateMembersRequestDto? updateMembersRequestDto = default)
        {
            var localVarResponse = UpdateUserTypeWithHttpInfo(type, updateMembersRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change a user type
        /// </summary>
        /// <remarks>
        /// Changes a type of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The new user type.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-type/">REST API Reference for UpdateUserType Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        public ApiResponse<EmployeeFullArrayWrapper> UpdateUserTypeWithHttpInfo(EmployeeType type, UpdateMembersRequestDto? updateMembersRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("type", ClientUtils.ParameterToString(type)); // path parameter
            if (updateMembersRequestDto != null) localVarRequestOptions.Data = updateMembersRequestDto;

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
            var localVarResponse = Client.Put<EmployeeFullArrayWrapper>("/api/2.0/people/type/{type}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateUserType", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change a user type
        /// </summary>
        /// <remarks>
        /// Changes a type of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The new user type.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-type/">REST API Reference for UpdateUserType Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        public async Task<EmployeeFullArrayWrapper> UpdateUserTypeAsync(EmployeeType type, UpdateMembersRequestDto? updateMembersRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateUserTypeWithHttpInfoAsync(type, updateMembersRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change a user type
        /// </summary>
        /// <remarks>
        /// Changes a type of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The new user type.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-type/">REST API Reference for UpdateUserType Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullArrayWrapper>> UpdateUserTypeWithHttpInfoAsync(EmployeeType type, UpdateMembersRequestDto? updateMembersRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("type", ClientUtils.ParameterToString(type)); // path parameter
            if (updateMembersRequestDto != null) localVarRequestOptions.Data = updateMembersRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<EmployeeFullArrayWrapper>("/api/2.0/people/type/{type}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateUserType", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
