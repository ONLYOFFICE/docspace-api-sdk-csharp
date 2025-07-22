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

namespace DocSpace.API.SDK.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsNotificationsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Check notification availability
        /// </summary>
        /// <remarks>
        /// Checks if the notification type specified in the request is enabled or not.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The type of notification to query, specified in the route.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-notification-settings/">REST API Reference for GetNotificationSettings Operation</seealso>
        /// <returns>NotificationSettingsWrapper</returns>
        NotificationSettingsWrapper GetNotificationSettings(NotificationType type);

        /// <summary>
        /// Check notification availability
        /// </summary>
        /// <remarks>
        /// Checks if the notification type specified in the request is enabled or not.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The type of notification to query, specified in the route.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-notification-settings/">REST API Reference for GetNotificationSettings Operation</seealso>
        /// <returns>ApiResponse of NotificationSettingsWrapper</returns>
        ApiResponse<NotificationSettingsWrapper> GetNotificationSettingsWithHttpInfo(NotificationType type);
        /// <summary>
        /// Get room notification settings
        /// </summary>
        /// <remarks>
        /// Returns a list of rooms with the disabled notifications.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-notification-settings/">REST API Reference for GetRoomsNotificationSettings Operation</seealso>
        /// <returns>RoomsNotificationSettingsWrapper</returns>
        RoomsNotificationSettingsWrapper GetRoomsNotificationSettings();

        /// <summary>
        /// Get room notification settings
        /// </summary>
        /// <remarks>
        /// Returns a list of rooms with the disabled notifications.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-notification-settings/">REST API Reference for GetRoomsNotificationSettings Operation</seealso>
        /// <returns>ApiResponse of RoomsNotificationSettingsWrapper</returns>
        ApiResponse<RoomsNotificationSettingsWrapper> GetRoomsNotificationSettingsWithHttpInfo();
        /// <summary>
        /// Enable notifications
        /// </summary>
        /// <remarks>
        /// Enables the notification type specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationSettingsRequestsDto">The request parameters for configuring notification settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-notification-settings/">REST API Reference for SetNotificationSettings Operation</seealso>
        /// <returns>NotificationSettingsWrapper</returns>
        NotificationSettingsWrapper SetNotificationSettings(NotificationSettingsRequestsDto? notificationSettingsRequestsDto = default);

        /// <summary>
        /// Enable notifications
        /// </summary>
        /// <remarks>
        /// Enables the notification type specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationSettingsRequestsDto">The request parameters for configuring notification settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-notification-settings/">REST API Reference for SetNotificationSettings Operation</seealso>
        /// <returns>ApiResponse of NotificationSettingsWrapper</returns>
        ApiResponse<NotificationSettingsWrapper> SetNotificationSettingsWithHttpInfo(NotificationSettingsRequestsDto? notificationSettingsRequestsDto = default);
        /// <summary>
        /// Set room notification status
        /// </summary>
        /// <remarks>
        /// Sets a notification status for a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomsNotificationsSettingsRequestDto">The request parameters for configuring notification settings for the chat or collaboration rooms. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-rooms-notification-status/">REST API Reference for SetRoomsNotificationStatus Operation</seealso>
        /// <returns>RoomsNotificationSettingsWrapper</returns>
        RoomsNotificationSettingsWrapper SetRoomsNotificationStatus(RoomsNotificationsSettingsRequestDto? roomsNotificationsSettingsRequestDto = default);

        /// <summary>
        /// Set room notification status
        /// </summary>
        /// <remarks>
        /// Sets a notification status for a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomsNotificationsSettingsRequestDto">The request parameters for configuring notification settings for the chat or collaboration rooms. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-rooms-notification-status/">REST API Reference for SetRoomsNotificationStatus Operation</seealso>
        /// <returns>ApiResponse of RoomsNotificationSettingsWrapper</returns>
        ApiResponse<RoomsNotificationSettingsWrapper> SetRoomsNotificationStatusWithHttpInfo(RoomsNotificationsSettingsRequestDto? roomsNotificationsSettingsRequestDto = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsNotificationsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Check notification availability
        /// </summary>
        /// <remarks>
        /// Checks if the notification type specified in the request is enabled or not.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The type of notification to query, specified in the route.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-notification-settings/">REST API Reference for GetNotificationSettings Operation</seealso>
        /// <returns>Task of NotificationSettingsWrapper</returns>
        Task<NotificationSettingsWrapper> GetNotificationSettingsAsync(NotificationType type, CancellationToken cancellationToken = default);

        /// <summary>
        /// Check notification availability
        /// </summary>
        /// <remarks>
        /// Checks if the notification type specified in the request is enabled or not.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The type of notification to query, specified in the route.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-notification-settings/">REST API Reference for GetNotificationSettings Operation</seealso>
        /// <returns>Task of ApiResponse (NotificationSettingsWrapper)</returns>
        Task<ApiResponse<NotificationSettingsWrapper>> GetNotificationSettingsWithHttpInfoAsync(NotificationType type, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get room notification settings
        /// </summary>
        /// <remarks>
        /// Returns a list of rooms with the disabled notifications.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-notification-settings/">REST API Reference for GetRoomsNotificationSettings Operation</seealso>
        /// <returns>Task of RoomsNotificationSettingsWrapper</returns>
        Task<RoomsNotificationSettingsWrapper> GetRoomsNotificationSettingsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get room notification settings
        /// </summary>
        /// <remarks>
        /// Returns a list of rooms with the disabled notifications.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-notification-settings/">REST API Reference for GetRoomsNotificationSettings Operation</seealso>
        /// <returns>Task of ApiResponse (RoomsNotificationSettingsWrapper)</returns>
        Task<ApiResponse<RoomsNotificationSettingsWrapper>> GetRoomsNotificationSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Enable notifications
        /// </summary>
        /// <remarks>
        /// Enables the notification type specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationSettingsRequestsDto">The request parameters for configuring notification settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-notification-settings/">REST API Reference for SetNotificationSettings Operation</seealso>
        /// <returns>Task of NotificationSettingsWrapper</returns>
        Task<NotificationSettingsWrapper> SetNotificationSettingsAsync(NotificationSettingsRequestsDto? notificationSettingsRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Enable notifications
        /// </summary>
        /// <remarks>
        /// Enables the notification type specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationSettingsRequestsDto">The request parameters for configuring notification settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-notification-settings/">REST API Reference for SetNotificationSettings Operation</seealso>
        /// <returns>Task of ApiResponse (NotificationSettingsWrapper)</returns>
        Task<ApiResponse<NotificationSettingsWrapper>> SetNotificationSettingsWithHttpInfoAsync(NotificationSettingsRequestsDto? notificationSettingsRequestsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set room notification status
        /// </summary>
        /// <remarks>
        /// Sets a notification status for a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomsNotificationsSettingsRequestDto">The request parameters for configuring notification settings for the chat or collaboration rooms. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-rooms-notification-status/">REST API Reference for SetRoomsNotificationStatus Operation</seealso>
        /// <returns>Task of RoomsNotificationSettingsWrapper</returns>
        Task<RoomsNotificationSettingsWrapper> SetRoomsNotificationStatusAsync(RoomsNotificationsSettingsRequestDto? roomsNotificationsSettingsRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set room notification status
        /// </summary>
        /// <remarks>
        /// Sets a notification status for a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomsNotificationsSettingsRequestDto">The request parameters for configuring notification settings for the chat or collaboration rooms. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-rooms-notification-status/">REST API Reference for SetRoomsNotificationStatus Operation</seealso>
        /// <returns>Task of ApiResponse (RoomsNotificationSettingsWrapper)</returns>
        Task<ApiResponse<RoomsNotificationSettingsWrapper>> SetRoomsNotificationStatusWithHttpInfoAsync(RoomsNotificationsSettingsRequestDto? roomsNotificationsSettingsRequestDto = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsNotificationsApi : ISettingsNotificationsApiSync, ISettingsNotificationsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SettingsNotificationsApi : IDisposable, ISettingsNotificationsApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsNotificationsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public SettingsNotificationsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsNotificationsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public SettingsNotificationsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="SettingsNotificationsApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public SettingsNotificationsApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="SettingsNotificationsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public SettingsNotificationsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsNotificationsApi"/> class.
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
        public SettingsNotificationsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="SettingsNotificationsApi"/> class using a Configuration object.
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
        public SettingsNotificationsApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="SettingsNotificationsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SettingsNotificationsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Check notification availability
        /// </summary>
        /// <remarks>
        /// Checks if the notification type specified in the request is enabled or not.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The type of notification to query, specified in the route.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-notification-settings/">REST API Reference for GetNotificationSettings Operation</seealso>
        /// <returns>NotificationSettingsWrapper</returns>
        public NotificationSettingsWrapper GetNotificationSettings(NotificationType type)
        {
            var localVarResponse = GetNotificationSettingsWithHttpInfo(type);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check notification availability
        /// </summary>
        /// <remarks>
        /// Checks if the notification type specified in the request is enabled or not.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The type of notification to query, specified in the route.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-notification-settings/">REST API Reference for GetNotificationSettings Operation</seealso>
        /// <returns>ApiResponse of NotificationSettingsWrapper</returns>
        public ApiResponse<NotificationSettingsWrapper> GetNotificationSettingsWithHttpInfo(NotificationType type)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("type", ClientUtils.ParameterToString(type)); // path parameter

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
            var localVarResponse = Client.Get<NotificationSettingsWrapper>("/api/2.0/settings/notification/{type}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetNotificationSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check notification availability
        /// </summary>
        /// <remarks>
        /// Checks if the notification type specified in the request is enabled or not.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The type of notification to query, specified in the route.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-notification-settings/">REST API Reference for GetNotificationSettings Operation</seealso>
        /// <returns>Task of NotificationSettingsWrapper</returns>
        public async Task<NotificationSettingsWrapper> GetNotificationSettingsAsync(NotificationType type, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetNotificationSettingsWithHttpInfoAsync(type, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check notification availability
        /// </summary>
        /// <remarks>
        /// Checks if the notification type specified in the request is enabled or not.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The type of notification to query, specified in the route.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-notification-settings/">REST API Reference for GetNotificationSettings Operation</seealso>
        /// <returns>Task of ApiResponse (NotificationSettingsWrapper)</returns>
        public async Task<ApiResponse<NotificationSettingsWrapper>> GetNotificationSettingsWithHttpInfoAsync(NotificationType type, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("type", ClientUtils.ParameterToString(type)); // path parameter

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

            var localVarResponse = await AsynchronousClient.GetAsync<NotificationSettingsWrapper>("/api/2.0/settings/notification/{type}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetNotificationSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get room notification settings
        /// </summary>
        /// <remarks>
        /// Returns a list of rooms with the disabled notifications.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-notification-settings/">REST API Reference for GetRoomsNotificationSettings Operation</seealso>
        /// <returns>RoomsNotificationSettingsWrapper</returns>
        public RoomsNotificationSettingsWrapper GetRoomsNotificationSettings()
        {
            var localVarResponse = GetRoomsNotificationSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get room notification settings
        /// </summary>
        /// <remarks>
        /// Returns a list of rooms with the disabled notifications.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-notification-settings/">REST API Reference for GetRoomsNotificationSettings Operation</seealso>
        /// <returns>ApiResponse of RoomsNotificationSettingsWrapper</returns>
        public ApiResponse<RoomsNotificationSettingsWrapper> GetRoomsNotificationSettingsWithHttpInfo()
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
            var localVarResponse = Client.Get<RoomsNotificationSettingsWrapper>("/api/2.0/settings/notification/rooms", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomsNotificationSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get room notification settings
        /// </summary>
        /// <remarks>
        /// Returns a list of rooms with the disabled notifications.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-notification-settings/">REST API Reference for GetRoomsNotificationSettings Operation</seealso>
        /// <returns>Task of RoomsNotificationSettingsWrapper</returns>
        public async Task<RoomsNotificationSettingsWrapper> GetRoomsNotificationSettingsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetRoomsNotificationSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get room notification settings
        /// </summary>
        /// <remarks>
        /// Returns a list of rooms with the disabled notifications.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-notification-settings/">REST API Reference for GetRoomsNotificationSettings Operation</seealso>
        /// <returns>Task of ApiResponse (RoomsNotificationSettingsWrapper)</returns>
        public async Task<ApiResponse<RoomsNotificationSettingsWrapper>> GetRoomsNotificationSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


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

            var localVarResponse = await AsynchronousClient.GetAsync<RoomsNotificationSettingsWrapper>("/api/2.0/settings/notification/rooms", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomsNotificationSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Enable notifications
        /// </summary>
        /// <remarks>
        /// Enables the notification type specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationSettingsRequestsDto">The request parameters for configuring notification settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-notification-settings/">REST API Reference for SetNotificationSettings Operation</seealso>
        /// <returns>NotificationSettingsWrapper</returns>
        public NotificationSettingsWrapper SetNotificationSettings(NotificationSettingsRequestsDto? notificationSettingsRequestsDto = default)
        {
            var localVarResponse = SetNotificationSettingsWithHttpInfo(notificationSettingsRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Enable notifications
        /// </summary>
        /// <remarks>
        /// Enables the notification type specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationSettingsRequestsDto">The request parameters for configuring notification settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-notification-settings/">REST API Reference for SetNotificationSettings Operation</seealso>
        /// <returns>ApiResponse of NotificationSettingsWrapper</returns>
        public ApiResponse<NotificationSettingsWrapper> SetNotificationSettingsWithHttpInfo(NotificationSettingsRequestsDto? notificationSettingsRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (notificationSettingsRequestsDto != null) localVarRequestOptions.Data = notificationSettingsRequestsDto;

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
            var localVarResponse = Client.Post<NotificationSettingsWrapper>("/api/2.0/settings/notification", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetNotificationSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Enable notifications
        /// </summary>
        /// <remarks>
        /// Enables the notification type specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationSettingsRequestsDto">The request parameters for configuring notification settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-notification-settings/">REST API Reference for SetNotificationSettings Operation</seealso>
        /// <returns>Task of NotificationSettingsWrapper</returns>
        public async Task<NotificationSettingsWrapper> SetNotificationSettingsAsync(NotificationSettingsRequestsDto? notificationSettingsRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetNotificationSettingsWithHttpInfoAsync(notificationSettingsRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Enable notifications
        /// </summary>
        /// <remarks>
        /// Enables the notification type specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationSettingsRequestsDto">The request parameters for configuring notification settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-notification-settings/">REST API Reference for SetNotificationSettings Operation</seealso>
        /// <returns>Task of ApiResponse (NotificationSettingsWrapper)</returns>
        public async Task<ApiResponse<NotificationSettingsWrapper>> SetNotificationSettingsWithHttpInfoAsync(NotificationSettingsRequestsDto? notificationSettingsRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (notificationSettingsRequestsDto != null) localVarRequestOptions.Data = notificationSettingsRequestsDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<NotificationSettingsWrapper>("/api/2.0/settings/notification", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetNotificationSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set room notification status
        /// </summary>
        /// <remarks>
        /// Sets a notification status for a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomsNotificationsSettingsRequestDto">The request parameters for configuring notification settings for the chat or collaboration rooms. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-rooms-notification-status/">REST API Reference for SetRoomsNotificationStatus Operation</seealso>
        /// <returns>RoomsNotificationSettingsWrapper</returns>
        public RoomsNotificationSettingsWrapper SetRoomsNotificationStatus(RoomsNotificationsSettingsRequestDto? roomsNotificationsSettingsRequestDto = default)
        {
            var localVarResponse = SetRoomsNotificationStatusWithHttpInfo(roomsNotificationsSettingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set room notification status
        /// </summary>
        /// <remarks>
        /// Sets a notification status for a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomsNotificationsSettingsRequestDto">The request parameters for configuring notification settings for the chat or collaboration rooms. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-rooms-notification-status/">REST API Reference for SetRoomsNotificationStatus Operation</seealso>
        /// <returns>ApiResponse of RoomsNotificationSettingsWrapper</returns>
        public ApiResponse<RoomsNotificationSettingsWrapper> SetRoomsNotificationStatusWithHttpInfo(RoomsNotificationsSettingsRequestDto? roomsNotificationsSettingsRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (roomsNotificationsSettingsRequestDto != null) localVarRequestOptions.Data = roomsNotificationsSettingsRequestDto;

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
            var localVarResponse = Client.Post<RoomsNotificationSettingsWrapper>("/api/2.0/settings/notification/rooms", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetRoomsNotificationStatus", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set room notification status
        /// </summary>
        /// <remarks>
        /// Sets a notification status for a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomsNotificationsSettingsRequestDto">The request parameters for configuring notification settings for the chat or collaboration rooms. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-rooms-notification-status/">REST API Reference for SetRoomsNotificationStatus Operation</seealso>
        /// <returns>Task of RoomsNotificationSettingsWrapper</returns>
        public async Task<RoomsNotificationSettingsWrapper> SetRoomsNotificationStatusAsync(RoomsNotificationsSettingsRequestDto? roomsNotificationsSettingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetRoomsNotificationStatusWithHttpInfoAsync(roomsNotificationsSettingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set room notification status
        /// </summary>
        /// <remarks>
        /// Sets a notification status for a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomsNotificationsSettingsRequestDto">The request parameters for configuring notification settings for the chat or collaboration rooms. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-rooms-notification-status/">REST API Reference for SetRoomsNotificationStatus Operation</seealso>
        /// <returns>Task of ApiResponse (RoomsNotificationSettingsWrapper)</returns>
        public async Task<ApiResponse<RoomsNotificationSettingsWrapper>> SetRoomsNotificationStatusWithHttpInfoAsync(RoomsNotificationsSettingsRequestDto? roomsNotificationsSettingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (roomsNotificationsSettingsRequestDto != null) localVarRequestOptions.Data = roomsNotificationsSettingsRequestDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<RoomsNotificationSettingsWrapper>("/api/2.0/settings/notification/rooms", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetRoomsNotificationStatus", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
