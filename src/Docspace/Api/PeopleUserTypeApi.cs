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
    public interface IPeopleUserTypeApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the progress of updating user type
        /// </summary>
        /// <remarks>
        /// Returns the progress of updating the user type.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startUpdateUserTypeDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/star-user-typet-update/">REST API Reference for StarUserTypetUpdate Operation</seealso>
        /// <returns>TaskProgressResponseWrapper</returns>
        TaskProgressResponseWrapper StarUserTypetUpdate(StartUpdateUserTypeDto? startUpdateUserTypeDto = default);

        /// <summary>
        /// Update user type
        /// </summary>
        /// <remarks>
        /// Starts updating the type of the user or guest when reassigning rooms and shared files.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startUpdateUserTypeDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/star-user-typet-update/">REST API Reference for StarUserTypetUpdate Operation</seealso>
        /// <returns>ApiResponse of TaskProgressResponseWrapper</returns>
        ApiResponse<TaskProgressResponseWrapper> StarUserTypetUpdateWithHttpInfo(StartUpdateUserTypeDto? startUpdateUserTypeDto = default);
        /// <summary>
        /// Terminate update user type
        /// </summary>
        /// <remarks>
        /// Terminates the process of updating the type of the user or guest.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminateRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-user-type-update/">REST API Reference for TerminateUserTypeUpdate Operation</seealso>
        /// <returns>TaskProgressResponseWrapper</returns>
        TaskProgressResponseWrapper TerminateUserTypeUpdate(TerminateRequestDto? terminateRequestDto = default);

        /// <summary>
        /// Terminate update user type
        /// </summary>
        /// <remarks>
        /// Terminates the process of updating the type of the user or guest.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminateRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-user-type-update/">REST API Reference for TerminateUserTypeUpdate Operation</seealso>
        /// <returns>ApiResponse of TaskProgressResponseWrapper</returns>
        ApiResponse<TaskProgressResponseWrapper> TerminateUserTypeUpdateWithHttpInfo(TerminateRequestDto? terminateRequestDto = default);
        /// <summary>
        /// Change a user type
        /// </summary>
        /// <remarks>
        /// Changes a type of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-type-update-progress/">REST API Reference for GetUserTypeUpdateProgress Operation</seealso>
        /// <returns>Task of TaskProgressResponseWrapper</returns>
        System.Threading.Tasks.Task<TaskProgressResponseWrapper> GetUserTypeUpdateProgressAsync(Guid userid, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the progress of updating user type
        /// </summary>
        /// <remarks>
        /// Returns the progress of updating the user type.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-type-update-progress/">REST API Reference for GetUserTypeUpdateProgress Operation</seealso>
        /// <returns>Task of ApiResponse (TaskProgressResponseWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<TaskProgressResponseWrapper>> GetUserTypeUpdateProgressWithHttpInfoAsync(Guid userid, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update user type
        /// </summary>
        /// <remarks>
        /// Starts updating the type of the user or guest when reassigning rooms and shared files.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startUpdateUserTypeDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/star-user-typet-update/">REST API Reference for StarUserTypetUpdate Operation</seealso>
        /// <returns>Task of TaskProgressResponseWrapper</returns>
        System.Threading.Tasks.Task<TaskProgressResponseWrapper> StarUserTypetUpdateAsync(StartUpdateUserTypeDto? startUpdateUserTypeDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update user type
        /// </summary>
        /// <remarks>
        /// Starts updating the type of the user or guest when reassigning rooms and shared files.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startUpdateUserTypeDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/star-user-typet-update/">REST API Reference for StarUserTypetUpdate Operation</seealso>
        /// <returns>Task of ApiResponse (TaskProgressResponseWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<TaskProgressResponseWrapper>> StarUserTypetUpdateWithHttpInfoAsync(StartUpdateUserTypeDto? startUpdateUserTypeDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Terminate update user type
        /// </summary>
        /// <remarks>
        /// Terminates the process of updating the type of the user or guest.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminateRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-user-type-update/">REST API Reference for TerminateUserTypeUpdate Operation</seealso>
        /// <returns>Task of TaskProgressResponseWrapper</returns>
        System.Threading.Tasks.Task<TaskProgressResponseWrapper> TerminateUserTypeUpdateAsync(TerminateRequestDto? terminateRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Terminate update user type
        /// </summary>
        /// <remarks>
        /// Terminates the process of updating the type of the user or guest.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminateRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-user-type-update/">REST API Reference for TerminateUserTypeUpdate Operation</seealso>
        /// <returns>Task of ApiResponse (TaskProgressResponseWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<TaskProgressResponseWrapper>> TerminateUserTypeUpdateWithHttpInfoAsync(TerminateRequestDto? terminateRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change a user type
        /// </summary>
        /// <remarks>
        /// Changes a type of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The new user type.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-type/">REST API Reference for UpdateUserType Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        System.Threading.Tasks.Task<EmployeeFullArrayWrapper> UpdateUserTypeAsync(EmployeeType type, UpdateMembersRequestDto? updateMembersRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Change a user type
        /// </summary>
        /// <remarks>
        /// Changes a type of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The new user type.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-type/">REST API Reference for UpdateUserType Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmployeeFullArrayWrapper>> UpdateUserTypeWithHttpInfoAsync(EmployeeType type, UpdateMembersRequestDto? updateMembersRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
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
        /// Get the progress of updating user type Returns the progress of updating the user type.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-type-update-progress/">REST API Reference for GetUserTypeUpdateProgress Operation</seealso>
        /// <returns>TaskProgressResponseWrapper</returns>
        public TaskProgressResponseWrapper GetUserTypeUpdateProgress(Guid userid)
        {
            var localVarResponse = GetUserTypeUpdateProgressWithHttpInfo(userid);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the progress of updating user type Returns the progress of updating the user type.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
            var localVarResponse = this.Client.Get<TaskProgressResponseWrapper>("/api/2.0/people/type/progress/{userid}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetUserTypeUpdateProgress", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the progress of updating user type Returns the progress of updating the user type.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-type-update-progress/">REST API Reference for GetUserTypeUpdateProgress Operation</seealso>
        /// <returns>Task of TaskProgressResponseWrapper</returns>
        public async System.Threading.Tasks.Task<TaskProgressResponseWrapper> GetUserTypeUpdateProgressAsync(Guid userid, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<TaskProgressResponseWrapper> localVarResponse = await GetUserTypeUpdateProgressWithHttpInfoAsync(userid, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the progress of updating user type Returns the progress of updating the user type.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-type-update-progress/">REST API Reference for GetUserTypeUpdateProgress Operation</seealso>
        /// <returns>Task of ApiResponse (TaskProgressResponseWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TaskProgressResponseWrapper>> GetUserTypeUpdateProgressWithHttpInfoAsync(Guid userid, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<TaskProgressResponseWrapper>("/api/2.0/people/type/progress/{userid}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetUserTypeUpdateProgress", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update user type Starts updating the type of the user or guest when reassigning rooms and shared files.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startUpdateUserTypeDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/star-user-typet-update/">REST API Reference for StarUserTypetUpdate Operation</seealso>
        /// <returns>TaskProgressResponseWrapper</returns>
        public TaskProgressResponseWrapper StarUserTypetUpdate(StartUpdateUserTypeDto? startUpdateUserTypeDto = default)
        {
            var localVarResponse = StarUserTypetUpdateWithHttpInfo(startUpdateUserTypeDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update user type Starts updating the type of the user or guest when reassigning rooms and shared files.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startUpdateUserTypeDto"> (optional)</param>
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
            var localVarResponse = this.Client.Post<TaskProgressResponseWrapper>("/api/2.0/people/type", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("StarUserTypetUpdate", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update user type Starts updating the type of the user or guest when reassigning rooms and shared files.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startUpdateUserTypeDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/star-user-typet-update/">REST API Reference for StarUserTypetUpdate Operation</seealso>
        /// <returns>Task of TaskProgressResponseWrapper</returns>
        public async System.Threading.Tasks.Task<TaskProgressResponseWrapper> StarUserTypetUpdateAsync(StartUpdateUserTypeDto? startUpdateUserTypeDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<TaskProgressResponseWrapper> localVarResponse = await StarUserTypetUpdateWithHttpInfoAsync(startUpdateUserTypeDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update user type Starts updating the type of the user or guest when reassigning rooms and shared files.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startUpdateUserTypeDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/star-user-typet-update/">REST API Reference for StarUserTypetUpdate Operation</seealso>
        /// <returns>Task of ApiResponse (TaskProgressResponseWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TaskProgressResponseWrapper>> StarUserTypetUpdateWithHttpInfoAsync(StartUpdateUserTypeDto? startUpdateUserTypeDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (startUpdateUserTypeDto != null) localVarRequestOptions.Data = startUpdateUserTypeDto;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<TaskProgressResponseWrapper>("/api/2.0/people/type", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("StarUserTypetUpdate", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Terminate update user type Terminates the process of updating the type of the user or guest.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminateRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-user-type-update/">REST API Reference for TerminateUserTypeUpdate Operation</seealso>
        /// <returns>TaskProgressResponseWrapper</returns>
        public TaskProgressResponseWrapper TerminateUserTypeUpdate(TerminateRequestDto? terminateRequestDto = default)
        {
            var localVarResponse = TerminateUserTypeUpdateWithHttpInfo(terminateRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Terminate update user type Terminates the process of updating the type of the user or guest.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminateRequestDto"> (optional)</param>
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
            var localVarResponse = this.Client.Put<TaskProgressResponseWrapper>("/api/2.0/people/type/terminate", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("TerminateUserTypeUpdate", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Terminate update user type Terminates the process of updating the type of the user or guest.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminateRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-user-type-update/">REST API Reference for TerminateUserTypeUpdate Operation</seealso>
        /// <returns>Task of TaskProgressResponseWrapper</returns>
        public async System.Threading.Tasks.Task<TaskProgressResponseWrapper> TerminateUserTypeUpdateAsync(TerminateRequestDto? terminateRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<TaskProgressResponseWrapper> localVarResponse = await TerminateUserTypeUpdateWithHttpInfoAsync(terminateRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Terminate update user type Terminates the process of updating the type of the user or guest.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="terminateRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-user-type-update/">REST API Reference for TerminateUserTypeUpdate Operation</seealso>
        /// <returns>Task of ApiResponse (TaskProgressResponseWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TaskProgressResponseWrapper>> TerminateUserTypeUpdateWithHttpInfoAsync(TerminateRequestDto? terminateRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (terminateRequestDto != null) localVarRequestOptions.Data = terminateRequestDto;

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

            var localVarResponse = await this.AsynchronousClient.PutAsync<TaskProgressResponseWrapper>("/api/2.0/people/type/terminate", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("TerminateUserTypeUpdate", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change a user type Changes a type of the users with the IDs specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// Change a user type Changes a type of the users with the IDs specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
            var localVarResponse = this.Client.Put<EmployeeFullArrayWrapper>("/api/2.0/people/type/{type}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("UpdateUserType", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change a user type Changes a type of the users with the IDs specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The new user type.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-type/">REST API Reference for UpdateUserType Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        public async System.Threading.Tasks.Task<EmployeeFullArrayWrapper> UpdateUserTypeAsync(EmployeeType type, UpdateMembersRequestDto? updateMembersRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<EmployeeFullArrayWrapper> localVarResponse = await UpdateUserTypeWithHttpInfoAsync(type, updateMembersRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change a user type Changes a type of the users with the IDs specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The new user type.</param>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-user-type/">REST API Reference for UpdateUserType Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmployeeFullArrayWrapper>> UpdateUserTypeWithHttpInfoAsync(EmployeeType type, UpdateMembersRequestDto? updateMembersRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("type", ClientUtils.ParameterToString(type)); // path parameter
            if (updateMembersRequestDto != null) localVarRequestOptions.Data = updateMembersRequestDto;

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

            var localVarResponse = await this.AsynchronousClient.PutAsync<EmployeeFullArrayWrapper>("/api/2.0/people/type/{type}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("UpdateUserType", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

    }
}
