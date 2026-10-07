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
namespace DocSpace.API.SDK.Api.AI
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IContextApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get context folders
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-context-folders/">REST API Reference for AiContextGetContextFolders Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiContextGetContextFolders();

        /// <summary>
        /// Get context folders
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-context-folders/">REST API Reference for AiContextGetContextFolders Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiContextGetContextFoldersWithHttpInfo();
        /// <summary>
        /// Get room skill
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloud"></param>
        /// <param name="roomId"></param>
        /// <param name="skillId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-room-skill/">REST API Reference for AiContextGetRoomSkill Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiContextGetRoomSkill(string cloud, string roomId, string skillId);

        /// <summary>
        /// Get room skill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloud"></param>
        /// <param name="roomId"></param>
        /// <param name="skillId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-room-skill/">REST API Reference for AiContextGetRoomSkill Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiContextGetRoomSkillWithHttpInfo(string cloud, string roomId, string skillId);
        /// <summary>
        /// Get room skills
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloud"></param>
        /// <param name="roomId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-room-skills/">REST API Reference for AiContextGetRoomSkills Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiContextGetRoomSkills(string cloud, string roomId);

        /// <summary>
        /// Get room skills
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloud"></param>
        /// <param name="roomId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-room-skills/">REST API Reference for AiContextGetRoomSkills Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiContextGetRoomSkillsWithHttpInfo(string cloud, string roomId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IContextApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get context folders
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-context-folders/">REST API Reference for AiContextGetContextFolders Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiContextGetContextFoldersAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get context folders
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-context-folders/">REST API Reference for AiContextGetContextFolders Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiContextGetContextFoldersWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get room skill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloud"></param>
        /// <param name="roomId"></param>
        /// <param name="skillId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-room-skill/">REST API Reference for AiContextGetRoomSkill Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiContextGetRoomSkillAsync(string cloud, string roomId, string skillId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get room skill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloud"></param>
        /// <param name="roomId"></param>
        /// <param name="skillId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-room-skill/">REST API Reference for AiContextGetRoomSkill Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiContextGetRoomSkillWithHttpInfoAsync(string cloud, string roomId, string skillId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get room skills
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloud"></param>
        /// <param name="roomId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-room-skills/">REST API Reference for AiContextGetRoomSkills Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiContextGetRoomSkillsAsync(string cloud, string roomId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get room skills
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloud"></param>
        /// <param name="roomId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-room-skills/">REST API Reference for AiContextGetRoomSkills Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiContextGetRoomSkillsWithHttpInfoAsync(string cloud, string roomId, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IContextApi : IContextApiSync, IContextApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ContextApi : IDisposable, IContextApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public ContextApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public ContextApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ContextApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public ContextApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ContextApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public ContextApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextApi"/> class.
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
        public ContextApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="ContextApi"/> class using a Configuration object.
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
        public ContextApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="ContextApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ContextApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Get context folders
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-context-folders/">REST API Reference for AiContextGetContextFolders Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiContextGetContextFolders()
        {
            var localVarResponse = AiContextGetContextFoldersWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get context folders
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-context-folders/">REST API Reference for AiContextGetContextFolders Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiContextGetContextFoldersWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


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
            var localVarResponse = Client.Get<AiSuccessResponse>("/api/2.0/ai/context/get-context-folders", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiContextGetContextFolders", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get context folders
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-context-folders/">REST API Reference for AiContextGetContextFolders Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiContextGetContextFoldersAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiContextGetContextFoldersWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get context folders
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-context-folders/">REST API Reference for AiContextGetContextFolders Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiContextGetContextFoldersWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


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

            var localVarResponse = await AsynchronousClient.GetAsync<AiSuccessResponse>("/api/2.0/ai/context/get-context-folders", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiContextGetContextFolders", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get room skill
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloud"></param>
        /// <param name="roomId"></param>
        /// <param name="skillId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-room-skill/">REST API Reference for AiContextGetRoomSkill Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiContextGetRoomSkill(string cloud, string roomId, string skillId)
        {
            var localVarResponse = AiContextGetRoomSkillWithHttpInfo(cloud, roomId, skillId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get room skill
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloud"></param>
        /// <param name="roomId"></param>
        /// <param name="skillId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-room-skill/">REST API Reference for AiContextGetRoomSkill Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiContextGetRoomSkillWithHttpInfo(string cloud, string roomId, string skillId)
        {
            // verify the required parameter 'cloud' is set
            if (cloud == null)
                throw new ApiException(400, "Missing required parameter 'cloud' when calling ContextApi->AiContextGetRoomSkill");

            // verify the required parameter 'roomId' is set
            if (roomId == null)
                throw new ApiException(400, "Missing required parameter 'roomId' when calling ContextApi->AiContextGetRoomSkill");

            // verify the required parameter 'skillId' is set
            if (skillId == null)
                throw new ApiException(400, "Missing required parameter 'skillId' when calling ContextApi->AiContextGetRoomSkill");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "cloud", cloud));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "roomId", roomId));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "skillId", skillId));

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
            var localVarResponse = Client.Get<AiSuccessResponse>("/api/2.0/ai/context/get-room-skill", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiContextGetRoomSkill", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get room skill
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloud"></param>
        /// <param name="roomId"></param>
        /// <param name="skillId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-room-skill/">REST API Reference for AiContextGetRoomSkill Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiContextGetRoomSkillAsync(string cloud, string roomId, string skillId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiContextGetRoomSkillWithHttpInfoAsync(cloud, roomId, skillId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get room skill
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloud"></param>
        /// <param name="roomId"></param>
        /// <param name="skillId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-room-skill/">REST API Reference for AiContextGetRoomSkill Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiContextGetRoomSkillWithHttpInfoAsync(string cloud, string roomId, string skillId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'cloud' is set
            if (cloud == null)
                throw new ApiException(400, "Missing required parameter 'cloud' when calling ContextApi->AiContextGetRoomSkill");

            // verify the required parameter 'roomId' is set
            if (roomId == null)
                throw new ApiException(400, "Missing required parameter 'roomId' when calling ContextApi->AiContextGetRoomSkill");

            // verify the required parameter 'skillId' is set
            if (skillId == null)
                throw new ApiException(400, "Missing required parameter 'skillId' when calling ContextApi->AiContextGetRoomSkill");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "cloud", cloud));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "roomId", roomId));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "skillId", skillId));

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

            var localVarResponse = await AsynchronousClient.GetAsync<AiSuccessResponse>("/api/2.0/ai/context/get-room-skill", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiContextGetRoomSkill", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get room skills
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloud"></param>
        /// <param name="roomId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-room-skills/">REST API Reference for AiContextGetRoomSkills Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiContextGetRoomSkills(string cloud, string roomId)
        {
            var localVarResponse = AiContextGetRoomSkillsWithHttpInfo(cloud, roomId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get room skills
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloud"></param>
        /// <param name="roomId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-room-skills/">REST API Reference for AiContextGetRoomSkills Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiContextGetRoomSkillsWithHttpInfo(string cloud, string roomId)
        {
            // verify the required parameter 'cloud' is set
            if (cloud == null)
                throw new ApiException(400, "Missing required parameter 'cloud' when calling ContextApi->AiContextGetRoomSkills");

            // verify the required parameter 'roomId' is set
            if (roomId == null)
                throw new ApiException(400, "Missing required parameter 'roomId' when calling ContextApi->AiContextGetRoomSkills");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "cloud", cloud));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "roomId", roomId));

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
            var localVarResponse = Client.Get<AiSuccessResponse>("/api/2.0/ai/context/get-room-skills", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiContextGetRoomSkills", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get room skills
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloud"></param>
        /// <param name="roomId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-room-skills/">REST API Reference for AiContextGetRoomSkills Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiContextGetRoomSkillsAsync(string cloud, string roomId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiContextGetRoomSkillsWithHttpInfoAsync(cloud, roomId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get room skills
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloud"></param>
        /// <param name="roomId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-context-get-room-skills/">REST API Reference for AiContextGetRoomSkills Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiContextGetRoomSkillsWithHttpInfoAsync(string cloud, string roomId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'cloud' is set
            if (cloud == null)
                throw new ApiException(400, "Missing required parameter 'cloud' when calling ContextApi->AiContextGetRoomSkills");

            // verify the required parameter 'roomId' is set
            if (roomId == null)
                throw new ApiException(400, "Missing required parameter 'roomId' when calling ContextApi->AiContextGetRoomSkills");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "cloud", cloud));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "roomId", roomId));

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

            var localVarResponse = await AsynchronousClient.GetAsync<AiSuccessResponse>("/api/2.0/ai/context/get-room-skills", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiContextGetRoomSkills", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
