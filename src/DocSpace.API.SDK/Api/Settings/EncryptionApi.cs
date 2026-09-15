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
namespace DocSpace.API.SDK.Api.Settings
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEncryptionApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the storage encryption progress
        /// </summary>
        /// <remarks>
        /// Returns how far the running encryption or decryption of the installation storage has got, as a percentage from  0 to 100. It reports the run started by `POST api/2.0/settings/encryption/start`, whose direction, encryption  or decryption, is told by `GET api/2.0/settings/encryption/settings`. An empty response means no run is in  flight and no recent result is remembered: the value of a finished run is kept for one minute after it  completes and then dropped, so poll often enough not to miss the end of the operation. A value of -1 means the  build does not offer storage encryption at all, and on an installation that is not a server one the call is  refused rather than answered. Unlike the other encryption operations, this one asks for no portal-settings  permission: any authenticated member of the portal may read the progress, which is intentional, because the  portals are unavailable while the run is on and their users need to see when it ends. Nothing is written and  the call is safe to repeat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-progress/">REST API Reference for GetStorageEncryptionProgress Operation</seealso>
        /// <returns>DoubleNullableWrapper</returns>
        DoubleNullableWrapper GetStorageEncryptionProgress();

        /// <summary>
        /// Get the storage encryption progress
        /// </summary>
        /// <remarks>
        /// Returns how far the running encryption or decryption of the installation storage has got, as a percentage from  0 to 100. It reports the run started by `POST api/2.0/settings/encryption/start`, whose direction, encryption  or decryption, is told by `GET api/2.0/settings/encryption/settings`. An empty response means no run is in  flight and no recent result is remembered: the value of a finished run is kept for one minute after it  completes and then dropped, so poll often enough not to miss the end of the operation. A value of -1 means the  build does not offer storage encryption at all, and on an installation that is not a server one the call is  refused rather than answered. Unlike the other encryption operations, this one asks for no portal-settings  permission: any authenticated member of the portal may read the progress, which is intentional, because the  portals are unavailable while the run is on and their users need to see when it ends. Nothing is written and  the call is safe to repeat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-progress/">REST API Reference for GetStorageEncryptionProgress Operation</seealso>
        /// <returns>ApiResponse of DoubleNullableWrapper</returns>
        ApiResponse<DoubleNullableWrapper> GetStorageEncryptionProgressWithHttpInfo();
        /// <summary>
        /// Get the storage encryption settings
        /// </summary>
        /// <remarks>
        /// Returns the encryption state of the installation storage: the status, which is one of decrypted, encryption  started, encrypted or decryption started, and the flag saying whether users are mailed when an encryption run  begins. The password is deliberately blanked out, so the field always comes back empty even on an encrypted  installation. The caller is expected to have the permission to edit portal settings, which in practice means  the portal owner or a DocSpace admin, on a server installation with an unrestricted access space; on any other  installation, and whenever the check fails, the operation answers with an empty body instead of an error. An  empty answer is therefore not proof that encryption is off, only that the settings cannot be read in this  context. Nothing is written and the call is safe to repeat. Use `GET api/2.0/settings/encryption/progress` to  follow a run that is in flight, and `POST api/2.0/settings/encryption/start` to encrypt or decrypt the  storage.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-settings/">REST API Reference for GetStorageEncryptionSettings Operation</seealso>
        /// <returns>EncryptionSettingsWrapper</returns>
        EncryptionSettingsWrapper GetStorageEncryptionSettings();

        /// <summary>
        /// Get the storage encryption settings
        /// </summary>
        /// <remarks>
        /// Returns the encryption state of the installation storage: the status, which is one of decrypted, encryption  started, encrypted or decryption started, and the flag saying whether users are mailed when an encryption run  begins. The password is deliberately blanked out, so the field always comes back empty even on an encrypted  installation. The caller is expected to have the permission to edit portal settings, which in practice means  the portal owner or a DocSpace admin, on a server installation with an unrestricted access space; on any other  installation, and whenever the check fails, the operation answers with an empty body instead of an error. An  empty answer is therefore not proof that encryption is off, only that the settings cannot be read in this  context. Nothing is written and the call is safe to repeat. Use `GET api/2.0/settings/encryption/progress` to  follow a run that is in flight, and `POST api/2.0/settings/encryption/start` to encrypt or decrypt the  storage.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-settings/">REST API Reference for GetStorageEncryptionSettings Operation</seealso>
        /// <returns>ApiResponse of EncryptionSettingsWrapper</returns>
        ApiResponse<EncryptionSettingsWrapper> GetStorageEncryptionSettingsWithHttpInfo();
        /// <summary>
        /// Start the storage encryption
        /// </summary>
        /// <remarks>
        /// Queues encryption of everything the installation keeps in its local storage, or decryption of it when the data  is already encrypted: the saved encryption state decides the direction, so the same call encrypts a decrypted  installation and decrypts an encrypted one. It covers the whole server, not one portal, and only a server  installation with the feature switched on can run it, with neither the portal storage nor the CDN pointing at  a third-party provider: reset those first with `DELETE api/2.0/settings/storage` and  `DELETE api/2.0/settings/storage/cdn`. No backup may be running, and the backup schedules of all portals are  dropped as part of starting. The caller needs the permission to edit portal settings, that is the portal owner  or a DocSpace admin, and an unrestricted access space. This is a long, disruptive operation: every portal is  put into the encryption state and stays unavailable until it ends, so do not repeat the call while it runs,  and follow it with `GET api/2.0/settings/encryption/progress` instead. The password is generated on the server  and never returned by the API. Pass `notifyUsers=true` to mail every user before the portals go down. The  response is true once the job is queued, and false where encryption is switched off, nothing being started  then.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageEncryptionRequestsDto">Whether the users are warned before the portals go down for the storage encryption pass. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-storage-encryption/">REST API Reference for StartStorageEncryption Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper StartStorageEncryption(StorageEncryptionRequestsDto? storageEncryptionRequestsDto = default);

        /// <summary>
        /// Start the storage encryption
        /// </summary>
        /// <remarks>
        /// Queues encryption of everything the installation keeps in its local storage, or decryption of it when the data  is already encrypted: the saved encryption state decides the direction, so the same call encrypts a decrypted  installation and decrypts an encrypted one. It covers the whole server, not one portal, and only a server  installation with the feature switched on can run it, with neither the portal storage nor the CDN pointing at  a third-party provider: reset those first with `DELETE api/2.0/settings/storage` and  `DELETE api/2.0/settings/storage/cdn`. No backup may be running, and the backup schedules of all portals are  dropped as part of starting. The caller needs the permission to edit portal settings, that is the portal owner  or a DocSpace admin, and an unrestricted access space. This is a long, disruptive operation: every portal is  put into the encryption state and stays unavailable until it ends, so do not repeat the call while it runs,  and follow it with `GET api/2.0/settings/encryption/progress` instead. The password is generated on the server  and never returned by the API. Pass `notifyUsers=true` to mail every user before the portals go down. The  response is true once the job is queued, and false where encryption is switched off, nothing being started  then.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageEncryptionRequestsDto">Whether the users are warned before the portals go down for the storage encryption pass. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-storage-encryption/">REST API Reference for StartStorageEncryption Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> StartStorageEncryptionWithHttpInfo(StorageEncryptionRequestsDto? storageEncryptionRequestsDto = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEncryptionApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get the storage encryption progress
        /// </summary>
        /// <remarks>
        /// Returns how far the running encryption or decryption of the installation storage has got, as a percentage from  0 to 100. It reports the run started by `POST api/2.0/settings/encryption/start`, whose direction, encryption  or decryption, is told by `GET api/2.0/settings/encryption/settings`. An empty response means no run is in  flight and no recent result is remembered: the value of a finished run is kept for one minute after it  completes and then dropped, so poll often enough not to miss the end of the operation. A value of -1 means the  build does not offer storage encryption at all, and on an installation that is not a server one the call is  refused rather than answered. Unlike the other encryption operations, this one asks for no portal-settings  permission: any authenticated member of the portal may read the progress, which is intentional, because the  portals are unavailable while the run is on and their users need to see when it ends. Nothing is written and  the call is safe to repeat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-progress/">REST API Reference for GetStorageEncryptionProgress Operation</seealso>
        /// <returns>Task of DoubleNullableWrapper</returns>
        Task<DoubleNullableWrapper> GetStorageEncryptionProgressAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the storage encryption progress
        /// </summary>
        /// <remarks>
        /// Returns how far the running encryption or decryption of the installation storage has got, as a percentage from  0 to 100. It reports the run started by `POST api/2.0/settings/encryption/start`, whose direction, encryption  or decryption, is told by `GET api/2.0/settings/encryption/settings`. An empty response means no run is in  flight and no recent result is remembered: the value of a finished run is kept for one minute after it  completes and then dropped, so poll often enough not to miss the end of the operation. A value of -1 means the  build does not offer storage encryption at all, and on an installation that is not a server one the call is  refused rather than answered. Unlike the other encryption operations, this one asks for no portal-settings  permission: any authenticated member of the portal may read the progress, which is intentional, because the  portals are unavailable while the run is on and their users need to see when it ends. Nothing is written and  the call is safe to repeat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-progress/">REST API Reference for GetStorageEncryptionProgress Operation</seealso>
        /// <returns>Task of ApiResponse (DoubleNullableWrapper)</returns>
        Task<ApiResponse<DoubleNullableWrapper>> GetStorageEncryptionProgressWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the storage encryption settings
        /// </summary>
        /// <remarks>
        /// Returns the encryption state of the installation storage: the status, which is one of decrypted, encryption  started, encrypted or decryption started, and the flag saying whether users are mailed when an encryption run  begins. The password is deliberately blanked out, so the field always comes back empty even on an encrypted  installation. The caller is expected to have the permission to edit portal settings, which in practice means  the portal owner or a DocSpace admin, on a server installation with an unrestricted access space; on any other  installation, and whenever the check fails, the operation answers with an empty body instead of an error. An  empty answer is therefore not proof that encryption is off, only that the settings cannot be read in this  context. Nothing is written and the call is safe to repeat. Use `GET api/2.0/settings/encryption/progress` to  follow a run that is in flight, and `POST api/2.0/settings/encryption/start` to encrypt or decrypt the  storage.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-settings/">REST API Reference for GetStorageEncryptionSettings Operation</seealso>
        /// <returns>Task of EncryptionSettingsWrapper</returns>
        Task<EncryptionSettingsWrapper> GetStorageEncryptionSettingsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the storage encryption settings
        /// </summary>
        /// <remarks>
        /// Returns the encryption state of the installation storage: the status, which is one of decrypted, encryption  started, encrypted or decryption started, and the flag saying whether users are mailed when an encryption run  begins. The password is deliberately blanked out, so the field always comes back empty even on an encrypted  installation. The caller is expected to have the permission to edit portal settings, which in practice means  the portal owner or a DocSpace admin, on a server installation with an unrestricted access space; on any other  installation, and whenever the check fails, the operation answers with an empty body instead of an error. An  empty answer is therefore not proof that encryption is off, only that the settings cannot be read in this  context. Nothing is written and the call is safe to repeat. Use `GET api/2.0/settings/encryption/progress` to  follow a run that is in flight, and `POST api/2.0/settings/encryption/start` to encrypt or decrypt the  storage.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-settings/">REST API Reference for GetStorageEncryptionSettings Operation</seealso>
        /// <returns>Task of ApiResponse (EncryptionSettingsWrapper)</returns>
        Task<ApiResponse<EncryptionSettingsWrapper>> GetStorageEncryptionSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Start the storage encryption
        /// </summary>
        /// <remarks>
        /// Queues encryption of everything the installation keeps in its local storage, or decryption of it when the data  is already encrypted: the saved encryption state decides the direction, so the same call encrypts a decrypted  installation and decrypts an encrypted one. It covers the whole server, not one portal, and only a server  installation with the feature switched on can run it, with neither the portal storage nor the CDN pointing at  a third-party provider: reset those first with `DELETE api/2.0/settings/storage` and  `DELETE api/2.0/settings/storage/cdn`. No backup may be running, and the backup schedules of all portals are  dropped as part of starting. The caller needs the permission to edit portal settings, that is the portal owner  or a DocSpace admin, and an unrestricted access space. This is a long, disruptive operation: every portal is  put into the encryption state and stays unavailable until it ends, so do not repeat the call while it runs,  and follow it with `GET api/2.0/settings/encryption/progress` instead. The password is generated on the server  and never returned by the API. Pass `notifyUsers=true` to mail every user before the portals go down. The  response is true once the job is queued, and false where encryption is switched off, nothing being started  then.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageEncryptionRequestsDto">Whether the users are warned before the portals go down for the storage encryption pass. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-storage-encryption/">REST API Reference for StartStorageEncryption Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> StartStorageEncryptionAsync(StorageEncryptionRequestsDto? storageEncryptionRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Start the storage encryption
        /// </summary>
        /// <remarks>
        /// Queues encryption of everything the installation keeps in its local storage, or decryption of it when the data  is already encrypted: the saved encryption state decides the direction, so the same call encrypts a decrypted  installation and decrypts an encrypted one. It covers the whole server, not one portal, and only a server  installation with the feature switched on can run it, with neither the portal storage nor the CDN pointing at  a third-party provider: reset those first with `DELETE api/2.0/settings/storage` and  `DELETE api/2.0/settings/storage/cdn`. No backup may be running, and the backup schedules of all portals are  dropped as part of starting. The caller needs the permission to edit portal settings, that is the portal owner  or a DocSpace admin, and an unrestricted access space. This is a long, disruptive operation: every portal is  put into the encryption state and stays unavailable until it ends, so do not repeat the call while it runs,  and follow it with `GET api/2.0/settings/encryption/progress` instead. The password is generated on the server  and never returned by the API. Pass `notifyUsers=true` to mail every user before the portals go down. The  response is true once the job is queued, and false where encryption is switched off, nothing being started  then.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageEncryptionRequestsDto">Whether the users are warned before the portals go down for the storage encryption pass. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-storage-encryption/">REST API Reference for StartStorageEncryption Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> StartStorageEncryptionWithHttpInfoAsync(StorageEncryptionRequestsDto? storageEncryptionRequestsDto = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEncryptionApi : IEncryptionApiSync, IEncryptionApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EncryptionApi : IDisposable, IEncryptionApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptionApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public EncryptionApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptionApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public EncryptionApi(string basePath)
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
        /// Initializes a new instance of the <see cref="EncryptionApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public EncryptionApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="EncryptionApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public EncryptionApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptionApi"/> class.
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
        public EncryptionApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="EncryptionApi"/> class using a Configuration object.
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
        public EncryptionApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="EncryptionApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public EncryptionApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Get the storage encryption progress
        /// </summary>
        /// <remarks>
        /// Returns how far the running encryption or decryption of the installation storage has got, as a percentage from  0 to 100. It reports the run started by `POST api/2.0/settings/encryption/start`, whose direction, encryption  or decryption, is told by `GET api/2.0/settings/encryption/settings`. An empty response means no run is in  flight and no recent result is remembered: the value of a finished run is kept for one minute after it  completes and then dropped, so poll often enough not to miss the end of the operation. A value of -1 means the  build does not offer storage encryption at all, and on an installation that is not a server one the call is  refused rather than answered. Unlike the other encryption operations, this one asks for no portal-settings  permission: any authenticated member of the portal may read the progress, which is intentional, because the  portals are unavailable while the run is on and their users need to see when it ends. Nothing is written and  the call is safe to repeat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-progress/">REST API Reference for GetStorageEncryptionProgress Operation</seealso>
        /// <returns>DoubleNullableWrapper</returns>
        public DoubleNullableWrapper GetStorageEncryptionProgress()
        {
            var localVarResponse = GetStorageEncryptionProgressWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the storage encryption progress
        /// </summary>
        /// <remarks>
        /// Returns how far the running encryption or decryption of the installation storage has got, as a percentage from  0 to 100. It reports the run started by `POST api/2.0/settings/encryption/start`, whose direction, encryption  or decryption, is told by `GET api/2.0/settings/encryption/settings`. An empty response means no run is in  flight and no recent result is remembered: the value of a finished run is kept for one minute after it  completes and then dropped, so poll often enough not to miss the end of the operation. A value of -1 means the  build does not offer storage encryption at all, and on an installation that is not a server one the call is  refused rather than answered. Unlike the other encryption operations, this one asks for no portal-settings  permission: any authenticated member of the portal may read the progress, which is intentional, because the  portals are unavailable while the run is on and their users need to see when it ends. Nothing is written and  the call is safe to repeat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-progress/">REST API Reference for GetStorageEncryptionProgress Operation</seealso>
        /// <returns>ApiResponse of DoubleNullableWrapper</returns>
        public ApiResponse<DoubleNullableWrapper> GetStorageEncryptionProgressWithHttpInfo()
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
            var localVarResponse = Client.Get<DoubleNullableWrapper>("/api/2.0/settings/encryption/progress", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetStorageEncryptionProgress", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the storage encryption progress
        /// </summary>
        /// <remarks>
        /// Returns how far the running encryption or decryption of the installation storage has got, as a percentage from  0 to 100. It reports the run started by `POST api/2.0/settings/encryption/start`, whose direction, encryption  or decryption, is told by `GET api/2.0/settings/encryption/settings`. An empty response means no run is in  flight and no recent result is remembered: the value of a finished run is kept for one minute after it  completes and then dropped, so poll often enough not to miss the end of the operation. A value of -1 means the  build does not offer storage encryption at all, and on an installation that is not a server one the call is  refused rather than answered. Unlike the other encryption operations, this one asks for no portal-settings  permission: any authenticated member of the portal may read the progress, which is intentional, because the  portals are unavailable while the run is on and their users need to see when it ends. Nothing is written and  the call is safe to repeat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-progress/">REST API Reference for GetStorageEncryptionProgress Operation</seealso>
        /// <returns>Task of DoubleNullableWrapper</returns>
        public async Task<DoubleNullableWrapper> GetStorageEncryptionProgressAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetStorageEncryptionProgressWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the storage encryption progress
        /// </summary>
        /// <remarks>
        /// Returns how far the running encryption or decryption of the installation storage has got, as a percentage from  0 to 100. It reports the run started by `POST api/2.0/settings/encryption/start`, whose direction, encryption  or decryption, is told by `GET api/2.0/settings/encryption/settings`. An empty response means no run is in  flight and no recent result is remembered: the value of a finished run is kept for one minute after it  completes and then dropped, so poll often enough not to miss the end of the operation. A value of -1 means the  build does not offer storage encryption at all, and on an installation that is not a server one the call is  refused rather than answered. Unlike the other encryption operations, this one asks for no portal-settings  permission: any authenticated member of the portal may read the progress, which is intentional, because the  portals are unavailable while the run is on and their users need to see when it ends. Nothing is written and  the call is safe to repeat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-progress/">REST API Reference for GetStorageEncryptionProgress Operation</seealso>
        /// <returns>Task of ApiResponse (DoubleNullableWrapper)</returns>
        public async Task<ApiResponse<DoubleNullableWrapper>> GetStorageEncryptionProgressWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<DoubleNullableWrapper>("/api/2.0/settings/encryption/progress", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetStorageEncryptionProgress", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the storage encryption settings
        /// </summary>
        /// <remarks>
        /// Returns the encryption state of the installation storage: the status, which is one of decrypted, encryption  started, encrypted or decryption started, and the flag saying whether users are mailed when an encryption run  begins. The password is deliberately blanked out, so the field always comes back empty even on an encrypted  installation. The caller is expected to have the permission to edit portal settings, which in practice means  the portal owner or a DocSpace admin, on a server installation with an unrestricted access space; on any other  installation, and whenever the check fails, the operation answers with an empty body instead of an error. An  empty answer is therefore not proof that encryption is off, only that the settings cannot be read in this  context. Nothing is written and the call is safe to repeat. Use `GET api/2.0/settings/encryption/progress` to  follow a run that is in flight, and `POST api/2.0/settings/encryption/start` to encrypt or decrypt the  storage.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-settings/">REST API Reference for GetStorageEncryptionSettings Operation</seealso>
        /// <returns>EncryptionSettingsWrapper</returns>
        public EncryptionSettingsWrapper GetStorageEncryptionSettings()
        {
            var localVarResponse = GetStorageEncryptionSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the storage encryption settings
        /// </summary>
        /// <remarks>
        /// Returns the encryption state of the installation storage: the status, which is one of decrypted, encryption  started, encrypted or decryption started, and the flag saying whether users are mailed when an encryption run  begins. The password is deliberately blanked out, so the field always comes back empty even on an encrypted  installation. The caller is expected to have the permission to edit portal settings, which in practice means  the portal owner or a DocSpace admin, on a server installation with an unrestricted access space; on any other  installation, and whenever the check fails, the operation answers with an empty body instead of an error. An  empty answer is therefore not proof that encryption is off, only that the settings cannot be read in this  context. Nothing is written and the call is safe to repeat. Use `GET api/2.0/settings/encryption/progress` to  follow a run that is in flight, and `POST api/2.0/settings/encryption/start` to encrypt or decrypt the  storage.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
            var localVarResponse = Client.Get<EncryptionSettingsWrapper>("/api/2.0/settings/encryption/settings", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetStorageEncryptionSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the storage encryption settings
        /// </summary>
        /// <remarks>
        /// Returns the encryption state of the installation storage: the status, which is one of decrypted, encryption  started, encrypted or decryption started, and the flag saying whether users are mailed when an encryption run  begins. The password is deliberately blanked out, so the field always comes back empty even on an encrypted  installation. The caller is expected to have the permission to edit portal settings, which in practice means  the portal owner or a DocSpace admin, on a server installation with an unrestricted access space; on any other  installation, and whenever the check fails, the operation answers with an empty body instead of an error. An  empty answer is therefore not proof that encryption is off, only that the settings cannot be read in this  context. Nothing is written and the call is safe to repeat. Use `GET api/2.0/settings/encryption/progress` to  follow a run that is in flight, and `POST api/2.0/settings/encryption/start` to encrypt or decrypt the  storage.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-settings/">REST API Reference for GetStorageEncryptionSettings Operation</seealso>
        /// <returns>Task of EncryptionSettingsWrapper</returns>
        public async Task<EncryptionSettingsWrapper> GetStorageEncryptionSettingsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetStorageEncryptionSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the storage encryption settings
        /// </summary>
        /// <remarks>
        /// Returns the encryption state of the installation storage: the status, which is one of decrypted, encryption  started, encrypted or decryption started, and the flag saying whether users are mailed when an encryption run  begins. The password is deliberately blanked out, so the field always comes back empty even on an encrypted  installation. The caller is expected to have the permission to edit portal settings, which in practice means  the portal owner or a DocSpace admin, on a server installation with an unrestricted access space; on any other  installation, and whenever the check fails, the operation answers with an empty body instead of an error. An  empty answer is therefore not proof that encryption is off, only that the settings cannot be read in this  context. Nothing is written and the call is safe to repeat. Use `GET api/2.0/settings/encryption/progress` to  follow a run that is in flight, and `POST api/2.0/settings/encryption/start` to encrypt or decrypt the  storage.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-encryption-settings/">REST API Reference for GetStorageEncryptionSettings Operation</seealso>
        /// <returns>Task of ApiResponse (EncryptionSettingsWrapper)</returns>
        public async Task<ApiResponse<EncryptionSettingsWrapper>> GetStorageEncryptionSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<EncryptionSettingsWrapper>("/api/2.0/settings/encryption/settings", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetStorageEncryptionSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start the storage encryption
        /// </summary>
        /// <remarks>
        /// Queues encryption of everything the installation keeps in its local storage, or decryption of it when the data  is already encrypted: the saved encryption state decides the direction, so the same call encrypts a decrypted  installation and decrypts an encrypted one. It covers the whole server, not one portal, and only a server  installation with the feature switched on can run it, with neither the portal storage nor the CDN pointing at  a third-party provider: reset those first with `DELETE api/2.0/settings/storage` and  `DELETE api/2.0/settings/storage/cdn`. No backup may be running, and the backup schedules of all portals are  dropped as part of starting. The caller needs the permission to edit portal settings, that is the portal owner  or a DocSpace admin, and an unrestricted access space. This is a long, disruptive operation: every portal is  put into the encryption state and stays unavailable until it ends, so do not repeat the call while it runs,  and follow it with `GET api/2.0/settings/encryption/progress` instead. The password is generated on the server  and never returned by the API. Pass `notifyUsers=true` to mail every user before the portals go down. The  response is true once the job is queued, and false where encryption is switched off, nothing being started  then.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageEncryptionRequestsDto">Whether the users are warned before the portals go down for the storage encryption pass. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-storage-encryption/">REST API Reference for StartStorageEncryption Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper StartStorageEncryption(StorageEncryptionRequestsDto? storageEncryptionRequestsDto = default)
        {
            var localVarResponse = StartStorageEncryptionWithHttpInfo(storageEncryptionRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start the storage encryption
        /// </summary>
        /// <remarks>
        /// Queues encryption of everything the installation keeps in its local storage, or decryption of it when the data  is already encrypted: the saved encryption state decides the direction, so the same call encrypts a decrypted  installation and decrypts an encrypted one. It covers the whole server, not one portal, and only a server  installation with the feature switched on can run it, with neither the portal storage nor the CDN pointing at  a third-party provider: reset those first with `DELETE api/2.0/settings/storage` and  `DELETE api/2.0/settings/storage/cdn`. No backup may be running, and the backup schedules of all portals are  dropped as part of starting. The caller needs the permission to edit portal settings, that is the portal owner  or a DocSpace admin, and an unrestricted access space. This is a long, disruptive operation: every portal is  put into the encryption state and stays unavailable until it ends, so do not repeat the call while it runs,  and follow it with `GET api/2.0/settings/encryption/progress` instead. The password is generated on the server  and never returned by the API. Pass `notifyUsers=true` to mail every user before the portals go down. The  response is true once the job is queued, and false where encryption is switched off, nothing being started  then.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageEncryptionRequestsDto">Whether the users are warned before the portals go down for the storage encryption pass. (optional)</param>
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
            var localVarResponse = Client.Post<BooleanWrapper>("/api/2.0/settings/encryption/start", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("StartStorageEncryption", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start the storage encryption
        /// </summary>
        /// <remarks>
        /// Queues encryption of everything the installation keeps in its local storage, or decryption of it when the data  is already encrypted: the saved encryption state decides the direction, so the same call encrypts a decrypted  installation and decrypts an encrypted one. It covers the whole server, not one portal, and only a server  installation with the feature switched on can run it, with neither the portal storage nor the CDN pointing at  a third-party provider: reset those first with `DELETE api/2.0/settings/storage` and  `DELETE api/2.0/settings/storage/cdn`. No backup may be running, and the backup schedules of all portals are  dropped as part of starting. The caller needs the permission to edit portal settings, that is the portal owner  or a DocSpace admin, and an unrestricted access space. This is a long, disruptive operation: every portal is  put into the encryption state and stays unavailable until it ends, so do not repeat the call while it runs,  and follow it with `GET api/2.0/settings/encryption/progress` instead. The password is generated on the server  and never returned by the API. Pass `notifyUsers=true` to mail every user before the portals go down. The  response is true once the job is queued, and false where encryption is switched off, nothing being started  then.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageEncryptionRequestsDto">Whether the users are warned before the portals go down for the storage encryption pass. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-storage-encryption/">REST API Reference for StartStorageEncryption Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> StartStorageEncryptionAsync(StorageEncryptionRequestsDto? storageEncryptionRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await StartStorageEncryptionWithHttpInfoAsync(storageEncryptionRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start the storage encryption
        /// </summary>
        /// <remarks>
        /// Queues encryption of everything the installation keeps in its local storage, or decryption of it when the data  is already encrypted: the saved encryption state decides the direction, so the same call encrypts a decrypted  installation and decrypts an encrypted one. It covers the whole server, not one portal, and only a server  installation with the feature switched on can run it, with neither the portal storage nor the CDN pointing at  a third-party provider: reset those first with `DELETE api/2.0/settings/storage` and  `DELETE api/2.0/settings/storage/cdn`. No backup may be running, and the backup schedules of all portals are  dropped as part of starting. The caller needs the permission to edit portal settings, that is the portal owner  or a DocSpace admin, and an unrestricted access space. This is a long, disruptive operation: every portal is  put into the encryption state and stays unavailable until it ends, so do not repeat the call while it runs,  and follow it with `GET api/2.0/settings/encryption/progress` instead. The password is generated on the server  and never returned by the API. Pass `notifyUsers=true` to mail every user before the portals go down. The  response is true once the job is queued, and false where encryption is switched off, nothing being started  then.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageEncryptionRequestsDto">Whether the users are warned before the portals go down for the storage encryption pass. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-storage-encryption/">REST API Reference for StartStorageEncryption Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> StartStorageEncryptionWithHttpInfoAsync(StorageEncryptionRequestsDto? storageEncryptionRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (storageEncryptionRequestsDto != null) localVarRequestOptions.Data = storageEncryptionRequestsDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<BooleanWrapper>("/api/2.0/settings/encryption/start", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("StartStorageEncryption", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
