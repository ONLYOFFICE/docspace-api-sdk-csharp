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


using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Model;
namespace DocSpace.API.SDK.Api.People
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserStatusApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get profiles by status
        /// </summary>
        /// <remarks>
        /// Returns a list of profiles filtered by the user status.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The user status.</param>
        /// <param name="filterBy">Specifies the criteria used to filter the profiles in the request. (optional)</param>
        /// <param name="count">The maximum number of user profiles to retrieve. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving data in a paginated request. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split multiple filter criteria in a query string. (optional)</param>
        /// <param name="filterValue">A string value representing additional filter criteria used in query parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-by-status/">REST API Reference for GetByStatus Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        EmployeeFullArrayWrapper GetByStatus(EmployeeStatus status, string? filterBy = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default);

        /// <summary>
        /// Get profiles by status
        /// </summary>
        /// <remarks>
        /// Returns a list of profiles filtered by the user status.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The user status.</param>
        /// <param name="filterBy">Specifies the criteria used to filter the profiles in the request. (optional)</param>
        /// <param name="count">The maximum number of user profiles to retrieve. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving data in a paginated request. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split multiple filter criteria in a query string. (optional)</param>
        /// <param name="filterValue">A string value representing additional filter criteria used in query parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-by-status/">REST API Reference for GetByStatus Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        ApiResponse<EmployeeFullArrayWrapper> GetByStatusWithHttpInfo(EmployeeStatus status, string? filterBy = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default);
        /// <summary>
        /// Set an activation status to the users
        /// </summary>
        /// <remarks>
        /// Sets the required activation status to the list of users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activationstatus">The new user activation status.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-activation-status/">REST API Reference for UpdateUserActivationStatus Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        EmployeeFullArrayWrapper UpdateUserActivationStatus(EmployeeActivationStatus activationstatus, UpdateMembersRequestDto updateMembersRequestDto);

        /// <summary>
        /// Set an activation status to the users
        /// </summary>
        /// <remarks>
        /// Sets the required activation status to the list of users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activationstatus">The new user activation status.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-activation-status/">REST API Reference for UpdateUserActivationStatus Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        ApiResponse<EmployeeFullArrayWrapper> UpdateUserActivationStatusWithHttpInfo(EmployeeActivationStatus activationstatus, UpdateMembersRequestDto updateMembersRequestDto);
        /// <summary>
        /// Change a user status
        /// </summary>
        /// <remarks>
        /// Changes a status of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The new user status.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-status/">REST API Reference for UpdateUserStatus Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        EmployeeFullArrayWrapper UpdateUserStatus(EmployeeStatus status, UpdateMembersRequestDto updateMembersRequestDto);

        /// <summary>
        /// Change a user status
        /// </summary>
        /// <remarks>
        /// Changes a status of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The new user status.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-status/">REST API Reference for UpdateUserStatus Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        ApiResponse<EmployeeFullArrayWrapper> UpdateUserStatusWithHttpInfo(EmployeeStatus status, UpdateMembersRequestDto updateMembersRequestDto);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserStatusApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get profiles by status
        /// </summary>
        /// <remarks>
        /// Returns a list of profiles filtered by the user status.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The user status.</param>
        /// <param name="filterBy">Specifies the criteria used to filter the profiles in the request. (optional)</param>
        /// <param name="count">The maximum number of user profiles to retrieve. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving data in a paginated request. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split multiple filter criteria in a query string. (optional)</param>
        /// <param name="filterValue">A string value representing additional filter criteria used in query parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-by-status/">REST API Reference for GetByStatus Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        Task<EmployeeFullArrayWrapper> GetByStatusAsync(EmployeeStatus status, string? filterBy = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get profiles by status
        /// </summary>
        /// <remarks>
        /// Returns a list of profiles filtered by the user status.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The user status.</param>
        /// <param name="filterBy">Specifies the criteria used to filter the profiles in the request. (optional)</param>
        /// <param name="count">The maximum number of user profiles to retrieve. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving data in a paginated request. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split multiple filter criteria in a query string. (optional)</param>
        /// <param name="filterValue">A string value representing additional filter criteria used in query parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-by-status/">REST API Reference for GetByStatus Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        Task<ApiResponse<EmployeeFullArrayWrapper>> GetByStatusWithHttpInfoAsync(EmployeeStatus status, string? filterBy = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set an activation status to the users
        /// </summary>
        /// <remarks>
        /// Sets the required activation status to the list of users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activationstatus">The new user activation status.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-activation-status/">REST API Reference for UpdateUserActivationStatus Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        Task<EmployeeFullArrayWrapper> UpdateUserActivationStatusAsync(EmployeeActivationStatus activationstatus, UpdateMembersRequestDto updateMembersRequestDto, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set an activation status to the users
        /// </summary>
        /// <remarks>
        /// Sets the required activation status to the list of users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activationstatus">The new user activation status.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-activation-status/">REST API Reference for UpdateUserActivationStatus Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        Task<ApiResponse<EmployeeFullArrayWrapper>> UpdateUserActivationStatusWithHttpInfoAsync(EmployeeActivationStatus activationstatus, UpdateMembersRequestDto updateMembersRequestDto, CancellationToken cancellationToken = default);
        /// <summary>
        /// Change a user status
        /// </summary>
        /// <remarks>
        /// Changes a status of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The new user status.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-status/">REST API Reference for UpdateUserStatus Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        Task<EmployeeFullArrayWrapper> UpdateUserStatusAsync(EmployeeStatus status, UpdateMembersRequestDto updateMembersRequestDto, CancellationToken cancellationToken = default);

        /// <summary>
        /// Change a user status
        /// </summary>
        /// <remarks>
        /// Changes a status of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The new user status.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-status/">REST API Reference for UpdateUserStatus Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        Task<ApiResponse<EmployeeFullArrayWrapper>> UpdateUserStatusWithHttpInfoAsync(EmployeeStatus status, UpdateMembersRequestDto updateMembersRequestDto, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserStatusApi : IUserStatusApiSync, IUserStatusApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserStatusApi : IDisposable, IUserStatusApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserStatusApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public UserStatusApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserStatusApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public UserStatusApi(string basePath)
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
        /// Initializes a new instance of the <see cref="UserStatusApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public UserStatusApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="UserStatusApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public UserStatusApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserStatusApi"/> class.
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
        public UserStatusApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="UserStatusApi"/> class using a Configuration object.
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
        public UserStatusApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="UserStatusApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public UserStatusApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Get profiles by status
        /// </summary>
        /// <remarks>
        /// Returns a list of profiles filtered by the user status.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The user status.</param>
        /// <param name="filterBy">Specifies the criteria used to filter the profiles in the request. (optional)</param>
        /// <param name="count">The maximum number of user profiles to retrieve. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving data in a paginated request. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split multiple filter criteria in a query string. (optional)</param>
        /// <param name="filterValue">A string value representing additional filter criteria used in query parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-by-status/">REST API Reference for GetByStatus Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        public EmployeeFullArrayWrapper GetByStatus(EmployeeStatus status, string? filterBy = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default)
        {
            var localVarResponse = GetByStatusWithHttpInfo(status, filterBy, count, startIndex, sortBy, sortOrder, filterSeparator, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get profiles by status
        /// </summary>
        /// <remarks>
        /// Returns a list of profiles filtered by the user status.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The user status.</param>
        /// <param name="filterBy">Specifies the criteria used to filter the profiles in the request. (optional)</param>
        /// <param name="count">The maximum number of user profiles to retrieve. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving data in a paginated request. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split multiple filter criteria in a query string. (optional)</param>
        /// <param name="filterValue">A string value representing additional filter criteria used in query parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-by-status/">REST API Reference for GetByStatus Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        public ApiResponse<EmployeeFullArrayWrapper> GetByStatusWithHttpInfo(EmployeeStatus status, string? filterBy = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("status", ClientUtils.ParameterToString(status)); // path parameter
            if (filterBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterBy", filterBy));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (sortBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortBy", sortBy));
            }
            if (sortOrder != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortOrder", sortOrder));
            }
            if (filterSeparator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterSeparator", filterSeparator));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }

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
            var localVarResponse = Client.Get<EmployeeFullArrayWrapper>("/api/2.0/people/status/{status}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetByStatus", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get profiles by status
        /// </summary>
        /// <remarks>
        /// Returns a list of profiles filtered by the user status.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The user status.</param>
        /// <param name="filterBy">Specifies the criteria used to filter the profiles in the request. (optional)</param>
        /// <param name="count">The maximum number of user profiles to retrieve. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving data in a paginated request. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split multiple filter criteria in a query string. (optional)</param>
        /// <param name="filterValue">A string value representing additional filter criteria used in query parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-by-status/">REST API Reference for GetByStatus Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        public async Task<EmployeeFullArrayWrapper> GetByStatusAsync(EmployeeStatus status, string? filterBy = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetByStatusWithHttpInfoAsync(status, filterBy, count, startIndex, sortBy, sortOrder, filterSeparator, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get profiles by status
        /// </summary>
        /// <remarks>
        /// Returns a list of profiles filtered by the user status.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The user status.</param>
        /// <param name="filterBy">Specifies the criteria used to filter the profiles in the request. (optional)</param>
        /// <param name="count">The maximum number of user profiles to retrieve. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving data in a paginated request. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split multiple filter criteria in a query string. (optional)</param>
        /// <param name="filterValue">A string value representing additional filter criteria used in query parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-by-status/">REST API Reference for GetByStatus Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullArrayWrapper>> GetByStatusWithHttpInfoAsync(EmployeeStatus status, string? filterBy = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("status", ClientUtils.ParameterToString(status)); // path parameter
            if (filterBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterBy", filterBy));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (sortBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortBy", sortBy));
            }
            if (sortOrder != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortOrder", sortOrder));
            }
            if (filterSeparator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterSeparator", filterSeparator));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }

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

            var localVarResponse = await AsynchronousClient.GetAsync<EmployeeFullArrayWrapper>("/api/2.0/people/status/{status}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetByStatus", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set an activation status to the users
        /// </summary>
        /// <remarks>
        /// Sets the required activation status to the list of users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activationstatus">The new user activation status.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-activation-status/">REST API Reference for UpdateUserActivationStatus Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        public EmployeeFullArrayWrapper UpdateUserActivationStatus(EmployeeActivationStatus activationstatus, UpdateMembersRequestDto updateMembersRequestDto)
        {
            var localVarResponse = UpdateUserActivationStatusWithHttpInfo(activationstatus, updateMembersRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set an activation status to the users
        /// </summary>
        /// <remarks>
        /// Sets the required activation status to the list of users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activationstatus">The new user activation status.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-activation-status/">REST API Reference for UpdateUserActivationStatus Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        public ApiResponse<EmployeeFullArrayWrapper> UpdateUserActivationStatusWithHttpInfo(EmployeeActivationStatus activationstatus, UpdateMembersRequestDto updateMembersRequestDto)
        {
            // verify the required parameter 'updateMembersRequestDto' is set
            if (updateMembersRequestDto == null)
                throw new ApiException(400, "Missing required parameter 'updateMembersRequestDto' when calling UserStatusApi->UpdateUserActivationStatus");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("activationstatus", ClientUtils.ParameterToString(activationstatus)); // path parameter
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
            var localVarResponse = Client.Put<EmployeeFullArrayWrapper>("/api/2.0/people/activationstatus/{activationstatus}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateUserActivationStatus", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set an activation status to the users
        /// </summary>
        /// <remarks>
        /// Sets the required activation status to the list of users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activationstatus">The new user activation status.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-activation-status/">REST API Reference for UpdateUserActivationStatus Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        public async Task<EmployeeFullArrayWrapper> UpdateUserActivationStatusAsync(EmployeeActivationStatus activationstatus, UpdateMembersRequestDto updateMembersRequestDto, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateUserActivationStatusWithHttpInfoAsync(activationstatus, updateMembersRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set an activation status to the users
        /// </summary>
        /// <remarks>
        /// Sets the required activation status to the list of users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activationstatus">The new user activation status.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-activation-status/">REST API Reference for UpdateUserActivationStatus Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullArrayWrapper>> UpdateUserActivationStatusWithHttpInfoAsync(EmployeeActivationStatus activationstatus, UpdateMembersRequestDto updateMembersRequestDto, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'updateMembersRequestDto' is set
            if (updateMembersRequestDto == null)
                throw new ApiException(400, "Missing required parameter 'updateMembersRequestDto' when calling UserStatusApi->UpdateUserActivationStatus");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("activationstatus", ClientUtils.ParameterToString(activationstatus)); // path parameter
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

            var localVarResponse = await AsynchronousClient.PutAsync<EmployeeFullArrayWrapper>("/api/2.0/people/activationstatus/{activationstatus}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateUserActivationStatus", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change a user status
        /// </summary>
        /// <remarks>
        /// Changes a status of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The new user status.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-status/">REST API Reference for UpdateUserStatus Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        public EmployeeFullArrayWrapper UpdateUserStatus(EmployeeStatus status, UpdateMembersRequestDto updateMembersRequestDto)
        {
            var localVarResponse = UpdateUserStatusWithHttpInfo(status, updateMembersRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change a user status
        /// </summary>
        /// <remarks>
        /// Changes a status of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The new user status.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-status/">REST API Reference for UpdateUserStatus Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        public ApiResponse<EmployeeFullArrayWrapper> UpdateUserStatusWithHttpInfo(EmployeeStatus status, UpdateMembersRequestDto updateMembersRequestDto)
        {
            // verify the required parameter 'updateMembersRequestDto' is set
            if (updateMembersRequestDto == null)
                throw new ApiException(400, "Missing required parameter 'updateMembersRequestDto' when calling UserStatusApi->UpdateUserStatus");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("status", ClientUtils.ParameterToString(status)); // path parameter
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
            var localVarResponse = Client.Put<EmployeeFullArrayWrapper>("/api/2.0/people/status/{status}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateUserStatus", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change a user status
        /// </summary>
        /// <remarks>
        /// Changes a status of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The new user status.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-status/">REST API Reference for UpdateUserStatus Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        public async Task<EmployeeFullArrayWrapper> UpdateUserStatusAsync(EmployeeStatus status, UpdateMembersRequestDto updateMembersRequestDto, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateUserStatusWithHttpInfoAsync(status, updateMembersRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change a user status
        /// </summary>
        /// <remarks>
        /// Changes a status of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The new user status.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-status/">REST API Reference for UpdateUserStatus Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullArrayWrapper>> UpdateUserStatusWithHttpInfoAsync(EmployeeStatus status, UpdateMembersRequestDto updateMembersRequestDto, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'updateMembersRequestDto' is set
            if (updateMembersRequestDto == null)
                throw new ApiException(400, "Missing required parameter 'updateMembersRequestDto' when calling UserStatusApi->UpdateUserStatus");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("status", ClientUtils.ParameterToString(status)); // path parameter
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

            var localVarResponse = await AsynchronousClient.PutAsync<EmployeeFullArrayWrapper>("/api/2.0/people/status/{status}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateUserStatus", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
