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
namespace DocSpace.API.SDK.Api.Security
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFirebaseApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Register a push device
        /// </summary>
        /// <remarks>
        /// Registers one mobile device of the calling user for the push notifications of the Documents application, by  storing the Firebase token that device was issued together with the initial `isSubscribed` state. The token is  handed out by Firebase to the mobile client, so obtain it there before calling: nothing here checks it, and it  is kept as an opaque string of up to 255 characters. Every signed-in member registers its own devices,  whatever its role - owner, administrator, user or guest - and a registration is bound to the caller and the  current portal, so another member's devices cannot be touched. The call is safe to repeat, but it is not an  update: a token already registered comes back as it stands and `isSubscribed` from the request is ignored, so  switch an existing registration on or off with `PUT api/2.0/settings/push/docsubscribe` instead. What comes  back is the stored registration, with `application` always `doc` and `isSubscribed` as stored. Only a  subscribed device is sent the room activity messages, such as an invitation to a room, a role change, an  archived room or a new document in a room, and only while the installation itself is configured with Firebase  credentials.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firebaseRequestsDto">Which mobile device receives the Documents push notifications, and whether it is subscribed. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/doc-register-pusn-notification-device/">REST API Reference for DocRegisterPusnNotificationDevice Operation</seealso>
        /// <returns>FireBaseUserWrapper</returns>
        FireBaseUserWrapper DocRegisterPusnNotificationDevice(FirebaseRequestsDto? firebaseRequestsDto = default);

        /// <summary>
        /// Register a push device
        /// </summary>
        /// <remarks>
        /// Registers one mobile device of the calling user for the push notifications of the Documents application, by  storing the Firebase token that device was issued together with the initial `isSubscribed` state. The token is  handed out by Firebase to the mobile client, so obtain it there before calling: nothing here checks it, and it  is kept as an opaque string of up to 255 characters. Every signed-in member registers its own devices,  whatever its role - owner, administrator, user or guest - and a registration is bound to the caller and the  current portal, so another member's devices cannot be touched. The call is safe to repeat, but it is not an  update: a token already registered comes back as it stands and `isSubscribed` from the request is ignored, so  switch an existing registration on or off with `PUT api/2.0/settings/push/docsubscribe` instead. What comes  back is the stored registration, with `application` always `doc` and `isSubscribed` as stored. Only a  subscribed device is sent the room activity messages, such as an invitation to a room, a role change, an  archived room or a new document in a room, and only while the installation itself is configured with Firebase  credentials.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firebaseRequestsDto">Which mobile device receives the Documents push notifications, and whether it is subscribed. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/doc-register-pusn-notification-device/">REST API Reference for DocRegisterPusnNotificationDevice Operation</seealso>
        /// <returns>ApiResponse of FireBaseUserWrapper</returns>
        ApiResponse<FireBaseUserWrapper> DocRegisterPusnNotificationDeviceWithHttpInfo(FirebaseRequestsDto? firebaseRequestsDto = default);
        /// <summary>
        /// Set push subscription
        /// </summary>
        /// <remarks>
        /// Switches the push notifications of the Documents application on or off for one already registered device of  the calling user: send that device's Firebase token together with `isSubscribed` true to let the messages  through or false to stop them. The device has to be registered first with  `POST api/2.0/settings/push/docregisterdevice`, and only the subscription state is written - the token is  matched, never changed. Every signed-in member manages its own devices, whatever its role - owner,  administrator, user or guest - and a token that belongs to another member or to another portal is not matched  at all, so nothing of theirs can be switched. Repeating the call with the same pair leaves the registration as  it is. What comes back is the updated registration, while an empty response means no registration of the  caller carries that token and nothing was stored - register the device and call again. A device switched off  keeps its token stored but is left out of the delivery, and the other devices of the same member are  unaffected. Which kinds of notification the account receives at all is a separate setting, read with  `GET api/2.0/settings/notification/{type}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firebaseRequestsDto">Which mobile device receives the Documents push notifications, and whether it is subscribed. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/subscribe-documents-push-notification/">REST API Reference for SubscribeDocumentsPushNotification Operation</seealso>
        /// <returns>FireBaseUserWrapper</returns>
        FireBaseUserWrapper SubscribeDocumentsPushNotification(FirebaseRequestsDto? firebaseRequestsDto = default);

        /// <summary>
        /// Set push subscription
        /// </summary>
        /// <remarks>
        /// Switches the push notifications of the Documents application on or off for one already registered device of  the calling user: send that device's Firebase token together with `isSubscribed` true to let the messages  through or false to stop them. The device has to be registered first with  `POST api/2.0/settings/push/docregisterdevice`, and only the subscription state is written - the token is  matched, never changed. Every signed-in member manages its own devices, whatever its role - owner,  administrator, user or guest - and a token that belongs to another member or to another portal is not matched  at all, so nothing of theirs can be switched. Repeating the call with the same pair leaves the registration as  it is. What comes back is the updated registration, while an empty response means no registration of the  caller carries that token and nothing was stored - register the device and call again. A device switched off  keeps its token stored but is left out of the delivery, and the other devices of the same member are  unaffected. Which kinds of notification the account receives at all is a separate setting, read with  `GET api/2.0/settings/notification/{type}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firebaseRequestsDto">Which mobile device receives the Documents push notifications, and whether it is subscribed. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/subscribe-documents-push-notification/">REST API Reference for SubscribeDocumentsPushNotification Operation</seealso>
        /// <returns>ApiResponse of FireBaseUserWrapper</returns>
        ApiResponse<FireBaseUserWrapper> SubscribeDocumentsPushNotificationWithHttpInfo(FirebaseRequestsDto? firebaseRequestsDto = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFirebaseApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Register a push device
        /// </summary>
        /// <remarks>
        /// Registers one mobile device of the calling user for the push notifications of the Documents application, by  storing the Firebase token that device was issued together with the initial `isSubscribed` state. The token is  handed out by Firebase to the mobile client, so obtain it there before calling: nothing here checks it, and it  is kept as an opaque string of up to 255 characters. Every signed-in member registers its own devices,  whatever its role - owner, administrator, user or guest - and a registration is bound to the caller and the  current portal, so another member's devices cannot be touched. The call is safe to repeat, but it is not an  update: a token already registered comes back as it stands and `isSubscribed` from the request is ignored, so  switch an existing registration on or off with `PUT api/2.0/settings/push/docsubscribe` instead. What comes  back is the stored registration, with `application` always `doc` and `isSubscribed` as stored. Only a  subscribed device is sent the room activity messages, such as an invitation to a room, a role change, an  archived room or a new document in a room, and only while the installation itself is configured with Firebase  credentials.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firebaseRequestsDto">Which mobile device receives the Documents push notifications, and whether it is subscribed. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/doc-register-pusn-notification-device/">REST API Reference for DocRegisterPusnNotificationDevice Operation</seealso>
        /// <returns>Task of FireBaseUserWrapper</returns>
        Task<FireBaseUserWrapper> DocRegisterPusnNotificationDeviceAsync(FirebaseRequestsDto? firebaseRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Register a push device
        /// </summary>
        /// <remarks>
        /// Registers one mobile device of the calling user for the push notifications of the Documents application, by  storing the Firebase token that device was issued together with the initial `isSubscribed` state. The token is  handed out by Firebase to the mobile client, so obtain it there before calling: nothing here checks it, and it  is kept as an opaque string of up to 255 characters. Every signed-in member registers its own devices,  whatever its role - owner, administrator, user or guest - and a registration is bound to the caller and the  current portal, so another member's devices cannot be touched. The call is safe to repeat, but it is not an  update: a token already registered comes back as it stands and `isSubscribed` from the request is ignored, so  switch an existing registration on or off with `PUT api/2.0/settings/push/docsubscribe` instead. What comes  back is the stored registration, with `application` always `doc` and `isSubscribed` as stored. Only a  subscribed device is sent the room activity messages, such as an invitation to a room, a role change, an  archived room or a new document in a room, and only while the installation itself is configured with Firebase  credentials.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firebaseRequestsDto">Which mobile device receives the Documents push notifications, and whether it is subscribed. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/doc-register-pusn-notification-device/">REST API Reference for DocRegisterPusnNotificationDevice Operation</seealso>
        /// <returns>Task of ApiResponse (FireBaseUserWrapper)</returns>
        Task<ApiResponse<FireBaseUserWrapper>> DocRegisterPusnNotificationDeviceWithHttpInfoAsync(FirebaseRequestsDto? firebaseRequestsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set push subscription
        /// </summary>
        /// <remarks>
        /// Switches the push notifications of the Documents application on or off for one already registered device of  the calling user: send that device's Firebase token together with `isSubscribed` true to let the messages  through or false to stop them. The device has to be registered first with  `POST api/2.0/settings/push/docregisterdevice`, and only the subscription state is written - the token is  matched, never changed. Every signed-in member manages its own devices, whatever its role - owner,  administrator, user or guest - and a token that belongs to another member or to another portal is not matched  at all, so nothing of theirs can be switched. Repeating the call with the same pair leaves the registration as  it is. What comes back is the updated registration, while an empty response means no registration of the  caller carries that token and nothing was stored - register the device and call again. A device switched off  keeps its token stored but is left out of the delivery, and the other devices of the same member are  unaffected. Which kinds of notification the account receives at all is a separate setting, read with  `GET api/2.0/settings/notification/{type}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firebaseRequestsDto">Which mobile device receives the Documents push notifications, and whether it is subscribed. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/subscribe-documents-push-notification/">REST API Reference for SubscribeDocumentsPushNotification Operation</seealso>
        /// <returns>Task of FireBaseUserWrapper</returns>
        Task<FireBaseUserWrapper> SubscribeDocumentsPushNotificationAsync(FirebaseRequestsDto? firebaseRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set push subscription
        /// </summary>
        /// <remarks>
        /// Switches the push notifications of the Documents application on or off for one already registered device of  the calling user: send that device's Firebase token together with `isSubscribed` true to let the messages  through or false to stop them. The device has to be registered first with  `POST api/2.0/settings/push/docregisterdevice`, and only the subscription state is written - the token is  matched, never changed. Every signed-in member manages its own devices, whatever its role - owner,  administrator, user or guest - and a token that belongs to another member or to another portal is not matched  at all, so nothing of theirs can be switched. Repeating the call with the same pair leaves the registration as  it is. What comes back is the updated registration, while an empty response means no registration of the  caller carries that token and nothing was stored - register the device and call again. A device switched off  keeps its token stored but is left out of the delivery, and the other devices of the same member are  unaffected. Which kinds of notification the account receives at all is a separate setting, read with  `GET api/2.0/settings/notification/{type}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firebaseRequestsDto">Which mobile device receives the Documents push notifications, and whether it is subscribed. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/subscribe-documents-push-notification/">REST API Reference for SubscribeDocumentsPushNotification Operation</seealso>
        /// <returns>Task of ApiResponse (FireBaseUserWrapper)</returns>
        Task<ApiResponse<FireBaseUserWrapper>> SubscribeDocumentsPushNotificationWithHttpInfoAsync(FirebaseRequestsDto? firebaseRequestsDto = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFirebaseApi : IFirebaseApiSync, IFirebaseApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FirebaseApi : IDisposable, IFirebaseApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FirebaseApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public FirebaseApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FirebaseApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public FirebaseApi(string basePath)
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
        /// Initializes a new instance of the <see cref="FirebaseApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public FirebaseApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="FirebaseApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public FirebaseApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FirebaseApi"/> class.
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
        public FirebaseApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="FirebaseApi"/> class using a Configuration object.
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
        public FirebaseApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="FirebaseApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public FirebaseApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Register a push device
        /// </summary>
        /// <remarks>
        /// Registers one mobile device of the calling user for the push notifications of the Documents application, by  storing the Firebase token that device was issued together with the initial `isSubscribed` state. The token is  handed out by Firebase to the mobile client, so obtain it there before calling: nothing here checks it, and it  is kept as an opaque string of up to 255 characters. Every signed-in member registers its own devices,  whatever its role - owner, administrator, user or guest - and a registration is bound to the caller and the  current portal, so another member's devices cannot be touched. The call is safe to repeat, but it is not an  update: a token already registered comes back as it stands and `isSubscribed` from the request is ignored, so  switch an existing registration on or off with `PUT api/2.0/settings/push/docsubscribe` instead. What comes  back is the stored registration, with `application` always `doc` and `isSubscribed` as stored. Only a  subscribed device is sent the room activity messages, such as an invitation to a room, a role change, an  archived room or a new document in a room, and only while the installation itself is configured with Firebase  credentials.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firebaseRequestsDto">Which mobile device receives the Documents push notifications, and whether it is subscribed. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/doc-register-pusn-notification-device/">REST API Reference for DocRegisterPusnNotificationDevice Operation</seealso>
        /// <returns>FireBaseUserWrapper</returns>
        public FireBaseUserWrapper DocRegisterPusnNotificationDevice(FirebaseRequestsDto? firebaseRequestsDto = default)
        {
            var localVarResponse = DocRegisterPusnNotificationDeviceWithHttpInfo(firebaseRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Register a push device
        /// </summary>
        /// <remarks>
        /// Registers one mobile device of the calling user for the push notifications of the Documents application, by  storing the Firebase token that device was issued together with the initial `isSubscribed` state. The token is  handed out by Firebase to the mobile client, so obtain it there before calling: nothing here checks it, and it  is kept as an opaque string of up to 255 characters. Every signed-in member registers its own devices,  whatever its role - owner, administrator, user or guest - and a registration is bound to the caller and the  current portal, so another member's devices cannot be touched. The call is safe to repeat, but it is not an  update: a token already registered comes back as it stands and `isSubscribed` from the request is ignored, so  switch an existing registration on or off with `PUT api/2.0/settings/push/docsubscribe` instead. What comes  back is the stored registration, with `application` always `doc` and `isSubscribed` as stored. Only a  subscribed device is sent the room activity messages, such as an invitation to a room, a role change, an  archived room or a new document in a room, and only while the installation itself is configured with Firebase  credentials.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firebaseRequestsDto">Which mobile device receives the Documents push notifications, and whether it is subscribed. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/doc-register-pusn-notification-device/">REST API Reference for DocRegisterPusnNotificationDevice Operation</seealso>
        /// <returns>ApiResponse of FireBaseUserWrapper</returns>
        public ApiResponse<FireBaseUserWrapper> DocRegisterPusnNotificationDeviceWithHttpInfo(FirebaseRequestsDto? firebaseRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (firebaseRequestsDto != null) localVarRequestOptions.Data = firebaseRequestsDto;

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
            var localVarResponse = Client.Post<FireBaseUserWrapper>("/api/2.0/settings/push/docregisterdevice", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DocRegisterPusnNotificationDevice", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Register a push device
        /// </summary>
        /// <remarks>
        /// Registers one mobile device of the calling user for the push notifications of the Documents application, by  storing the Firebase token that device was issued together with the initial `isSubscribed` state. The token is  handed out by Firebase to the mobile client, so obtain it there before calling: nothing here checks it, and it  is kept as an opaque string of up to 255 characters. Every signed-in member registers its own devices,  whatever its role - owner, administrator, user or guest - and a registration is bound to the caller and the  current portal, so another member's devices cannot be touched. The call is safe to repeat, but it is not an  update: a token already registered comes back as it stands and `isSubscribed` from the request is ignored, so  switch an existing registration on or off with `PUT api/2.0/settings/push/docsubscribe` instead. What comes  back is the stored registration, with `application` always `doc` and `isSubscribed` as stored. Only a  subscribed device is sent the room activity messages, such as an invitation to a room, a role change, an  archived room or a new document in a room, and only while the installation itself is configured with Firebase  credentials.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firebaseRequestsDto">Which mobile device receives the Documents push notifications, and whether it is subscribed. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/doc-register-pusn-notification-device/">REST API Reference for DocRegisterPusnNotificationDevice Operation</seealso>
        /// <returns>Task of FireBaseUserWrapper</returns>
        public async Task<FireBaseUserWrapper> DocRegisterPusnNotificationDeviceAsync(FirebaseRequestsDto? firebaseRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DocRegisterPusnNotificationDeviceWithHttpInfoAsync(firebaseRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Register a push device
        /// </summary>
        /// <remarks>
        /// Registers one mobile device of the calling user for the push notifications of the Documents application, by  storing the Firebase token that device was issued together with the initial `isSubscribed` state. The token is  handed out by Firebase to the mobile client, so obtain it there before calling: nothing here checks it, and it  is kept as an opaque string of up to 255 characters. Every signed-in member registers its own devices,  whatever its role - owner, administrator, user or guest - and a registration is bound to the caller and the  current portal, so another member's devices cannot be touched. The call is safe to repeat, but it is not an  update: a token already registered comes back as it stands and `isSubscribed` from the request is ignored, so  switch an existing registration on or off with `PUT api/2.0/settings/push/docsubscribe` instead. What comes  back is the stored registration, with `application` always `doc` and `isSubscribed` as stored. Only a  subscribed device is sent the room activity messages, such as an invitation to a room, a role change, an  archived room or a new document in a room, and only while the installation itself is configured with Firebase  credentials.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firebaseRequestsDto">Which mobile device receives the Documents push notifications, and whether it is subscribed. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/doc-register-pusn-notification-device/">REST API Reference for DocRegisterPusnNotificationDevice Operation</seealso>
        /// <returns>Task of ApiResponse (FireBaseUserWrapper)</returns>
        public async Task<ApiResponse<FireBaseUserWrapper>> DocRegisterPusnNotificationDeviceWithHttpInfoAsync(FirebaseRequestsDto? firebaseRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (firebaseRequestsDto != null) localVarRequestOptions.Data = firebaseRequestsDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<FireBaseUserWrapper>("/api/2.0/settings/push/docregisterdevice", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DocRegisterPusnNotificationDevice", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set push subscription
        /// </summary>
        /// <remarks>
        /// Switches the push notifications of the Documents application on or off for one already registered device of  the calling user: send that device's Firebase token together with `isSubscribed` true to let the messages  through or false to stop them. The device has to be registered first with  `POST api/2.0/settings/push/docregisterdevice`, and only the subscription state is written - the token is  matched, never changed. Every signed-in member manages its own devices, whatever its role - owner,  administrator, user or guest - and a token that belongs to another member or to another portal is not matched  at all, so nothing of theirs can be switched. Repeating the call with the same pair leaves the registration as  it is. What comes back is the updated registration, while an empty response means no registration of the  caller carries that token and nothing was stored - register the device and call again. A device switched off  keeps its token stored but is left out of the delivery, and the other devices of the same member are  unaffected. Which kinds of notification the account receives at all is a separate setting, read with  `GET api/2.0/settings/notification/{type}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firebaseRequestsDto">Which mobile device receives the Documents push notifications, and whether it is subscribed. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/subscribe-documents-push-notification/">REST API Reference for SubscribeDocumentsPushNotification Operation</seealso>
        /// <returns>FireBaseUserWrapper</returns>
        public FireBaseUserWrapper SubscribeDocumentsPushNotification(FirebaseRequestsDto? firebaseRequestsDto = default)
        {
            var localVarResponse = SubscribeDocumentsPushNotificationWithHttpInfo(firebaseRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set push subscription
        /// </summary>
        /// <remarks>
        /// Switches the push notifications of the Documents application on or off for one already registered device of  the calling user: send that device's Firebase token together with `isSubscribed` true to let the messages  through or false to stop them. The device has to be registered first with  `POST api/2.0/settings/push/docregisterdevice`, and only the subscription state is written - the token is  matched, never changed. Every signed-in member manages its own devices, whatever its role - owner,  administrator, user or guest - and a token that belongs to another member or to another portal is not matched  at all, so nothing of theirs can be switched. Repeating the call with the same pair leaves the registration as  it is. What comes back is the updated registration, while an empty response means no registration of the  caller carries that token and nothing was stored - register the device and call again. A device switched off  keeps its token stored but is left out of the delivery, and the other devices of the same member are  unaffected. Which kinds of notification the account receives at all is a separate setting, read with  `GET api/2.0/settings/notification/{type}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firebaseRequestsDto">Which mobile device receives the Documents push notifications, and whether it is subscribed. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/subscribe-documents-push-notification/">REST API Reference for SubscribeDocumentsPushNotification Operation</seealso>
        /// <returns>ApiResponse of FireBaseUserWrapper</returns>
        public ApiResponse<FireBaseUserWrapper> SubscribeDocumentsPushNotificationWithHttpInfo(FirebaseRequestsDto? firebaseRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (firebaseRequestsDto != null) localVarRequestOptions.Data = firebaseRequestsDto;

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
            var localVarResponse = Client.Put<FireBaseUserWrapper>("/api/2.0/settings/push/docsubscribe", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SubscribeDocumentsPushNotification", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set push subscription
        /// </summary>
        /// <remarks>
        /// Switches the push notifications of the Documents application on or off for one already registered device of  the calling user: send that device's Firebase token together with `isSubscribed` true to let the messages  through or false to stop them. The device has to be registered first with  `POST api/2.0/settings/push/docregisterdevice`, and only the subscription state is written - the token is  matched, never changed. Every signed-in member manages its own devices, whatever its role - owner,  administrator, user or guest - and a token that belongs to another member or to another portal is not matched  at all, so nothing of theirs can be switched. Repeating the call with the same pair leaves the registration as  it is. What comes back is the updated registration, while an empty response means no registration of the  caller carries that token and nothing was stored - register the device and call again. A device switched off  keeps its token stored but is left out of the delivery, and the other devices of the same member are  unaffected. Which kinds of notification the account receives at all is a separate setting, read with  `GET api/2.0/settings/notification/{type}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firebaseRequestsDto">Which mobile device receives the Documents push notifications, and whether it is subscribed. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/subscribe-documents-push-notification/">REST API Reference for SubscribeDocumentsPushNotification Operation</seealso>
        /// <returns>Task of FireBaseUserWrapper</returns>
        public async Task<FireBaseUserWrapper> SubscribeDocumentsPushNotificationAsync(FirebaseRequestsDto? firebaseRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SubscribeDocumentsPushNotificationWithHttpInfoAsync(firebaseRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set push subscription
        /// </summary>
        /// <remarks>
        /// Switches the push notifications of the Documents application on or off for one already registered device of  the calling user: send that device's Firebase token together with `isSubscribed` true to let the messages  through or false to stop them. The device has to be registered first with  `POST api/2.0/settings/push/docregisterdevice`, and only the subscription state is written - the token is  matched, never changed. Every signed-in member manages its own devices, whatever its role - owner,  administrator, user or guest - and a token that belongs to another member or to another portal is not matched  at all, so nothing of theirs can be switched. Repeating the call with the same pair leaves the registration as  it is. What comes back is the updated registration, while an empty response means no registration of the  caller carries that token and nothing was stored - register the device and call again. A device switched off  keeps its token stored but is left out of the delivery, and the other devices of the same member are  unaffected. Which kinds of notification the account receives at all is a separate setting, read with  `GET api/2.0/settings/notification/{type}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="firebaseRequestsDto">Which mobile device receives the Documents push notifications, and whether it is subscribed. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/subscribe-documents-push-notification/">REST API Reference for SubscribeDocumentsPushNotification Operation</seealso>
        /// <returns>Task of ApiResponse (FireBaseUserWrapper)</returns>
        public async Task<ApiResponse<FireBaseUserWrapper>> SubscribeDocumentsPushNotificationWithHttpInfoAsync(FirebaseRequestsDto? firebaseRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (firebaseRequestsDto != null) localVarRequestOptions.Data = firebaseRequestsDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<FireBaseUserWrapper>("/api/2.0/settings/push/docsubscribe", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SubscribeDocumentsPushNotification", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
