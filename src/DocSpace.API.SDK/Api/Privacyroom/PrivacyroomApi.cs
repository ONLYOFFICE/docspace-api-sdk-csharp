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
namespace DocSpace.API.SDK.Api.Privacyroom
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPrivacyroomApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Deletes an encryption key and removes it from the system.
        /// </summary>
        /// <remarks>
        /// Deletes an encryption key and removes it from the system based on the provided key identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The unique identifier of the encryption key to be deleted.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-keys/">REST API Reference for DeleteKeys Operation</seealso>
        /// <returns>EncryptionKeyArrayWrapper</returns>
        EncryptionKeyArrayWrapper DeleteKeys(Guid id);

        /// <summary>
        /// Deletes an encryption key and removes it from the system.
        /// </summary>
        /// <remarks>
        /// Deletes an encryption key and removes it from the system based on the provided key identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The unique identifier of the encryption key to be deleted.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-keys/">REST API Reference for DeleteKeys Operation</seealso>
        /// <returns>ApiResponse of EncryptionKeyArrayWrapper</returns>
        ApiResponse<EncryptionKeyArrayWrapper> DeleteKeysWithHttpInfo(Guid id);
        /// <summary>
        /// Retrieves the current settings for the Privacy Room functionality.
        /// </summary>
        /// <remarks>
        /// Retrieves the current settings for the Privacy Room functionality.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-privacy-room-settings/">REST API Reference for GetPrivacyRoomSettings Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper GetPrivacyRoomSettings();

        /// <summary>
        /// Retrieves the current settings for the Privacy Room functionality.
        /// </summary>
        /// <remarks>
        /// Retrieves the current settings for the Privacy Room functionality.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-privacy-room-settings/">REST API Reference for GetPrivacyRoomSettings Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> GetPrivacyRoomSettingsWithHttpInfo();
        /// <summary>
        /// Retrieves encryption keys associated with the current user.
        /// </summary>
        /// <remarks>
        /// Retrieves encryption keys associated with the current user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys/">REST API Reference for GetUserKeys Operation</seealso>
        /// <returns>EncryptionKeyArrayWrapper</returns>
        EncryptionKeyArrayWrapper GetUserKeys();

        /// <summary>
        /// Retrieves encryption keys associated with the current user.
        /// </summary>
        /// <remarks>
        /// Retrieves encryption keys associated with the current user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys/">REST API Reference for GetUserKeys Operation</seealso>
        /// <returns>ApiResponse of EncryptionKeyArrayWrapper</returns>
        ApiResponse<EncryptionKeyArrayWrapper> GetUserKeysWithHttpInfo();
        /// <summary>
        /// Retrieves a specific user encryption key based on the provided filter conditions.
        /// </summary>
        /// <remarks>
        /// Retrieves a specific user encryption key based on the provided filter conditions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The optional identifier of the encryption key to filter by. (optional)</param>
        /// <param name="type">The optional type of the encryption key to filter by. (optional)</param>
        /// <param name="publicKey">The optional public key to filter by. (optional)</param>
        /// <param name="privateKeyEnc">The optional encrypted private key to filter by. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys-by-filter/">REST API Reference for GetUserKeysByFilter Operation</seealso>
        /// <returns>EncryptionKeyWrapper</returns>
        EncryptionKeyWrapper GetUserKeysByFilter(Guid? id = default, EncryptionKeyType? type = default, string? publicKey = default, string? privateKeyEnc = default);

        /// <summary>
        /// Retrieves a specific user encryption key based on the provided filter conditions.
        /// </summary>
        /// <remarks>
        /// Retrieves a specific user encryption key based on the provided filter conditions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The optional identifier of the encryption key to filter by. (optional)</param>
        /// <param name="type">The optional type of the encryption key to filter by. (optional)</param>
        /// <param name="publicKey">The optional public key to filter by. (optional)</param>
        /// <param name="privateKeyEnc">The optional encrypted private key to filter by. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys-by-filter/">REST API Reference for GetUserKeysByFilter Operation</seealso>
        /// <returns>ApiResponse of EncryptionKeyWrapper</returns>
        ApiResponse<EncryptionKeyWrapper> GetUserKeysByFilterWithHttpInfo(Guid? id = default, EncryptionKeyType? type = default, string? publicKey = default, string? privateKeyEnc = default);
        /// <summary>
        /// Retrieves the encryption keys associated with a specific privacy room.
        /// </summary>
        /// <remarks>
        /// Retrieves the encryption keys associated with a specific privacy room.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the privacy room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys-for-room/">REST API Reference for GetUserKeysForRoom Operation</seealso>
        /// <returns>EncryptionKeyArrayWrapper</returns>
        EncryptionKeyArrayWrapper GetUserKeysForRoom(int roomId);

        /// <summary>
        /// Retrieves the encryption keys associated with a specific privacy room.
        /// </summary>
        /// <remarks>
        /// Retrieves the encryption keys associated with a specific privacy room.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the privacy room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys-for-room/">REST API Reference for GetUserKeysForRoom Operation</seealso>
        /// <returns>ApiResponse of EncryptionKeyArrayWrapper</returns>
        ApiResponse<EncryptionKeyArrayWrapper> GetUserKeysForRoomWithHttpInfo(int roomId);
        /// <summary>
        /// Replaces an existing encryption key with a new one for the user.
        /// </summary>
        /// <remarks>
        /// Replaces an existing encryption key with a new one for the user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The request object containing the public and private key information to replace the existing key. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/replace-key/">REST API Reference for ReplaceKey Operation</seealso>
        /// <returns>EncryptionKeyArrayWrapper</returns>
        EncryptionKeyArrayWrapper ReplaceKey(EncryptionKeyRequestDto? encryptionKeyRequestDto = default);

        /// <summary>
        /// Replaces an existing encryption key with a new one for the user.
        /// </summary>
        /// <remarks>
        /// Replaces an existing encryption key with a new one for the user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The request object containing the public and private key information to replace the existing key. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/replace-key/">REST API Reference for ReplaceKey Operation</seealso>
        /// <returns>ApiResponse of EncryptionKeyArrayWrapper</returns>
        ApiResponse<EncryptionKeyArrayWrapper> ReplaceKeyWithHttpInfo(EncryptionKeyRequestDto? encryptionKeyRequestDto = default);
        /// <summary>
        /// Creates and sets encryption keys for the user.
        /// </summary>
        /// <remarks>
        /// Creates and sets encryption keys for the user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The request object containing public and private key information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-keys/">REST API Reference for SetKeys Operation</seealso>
        /// <returns>EncryptionKeyArrayWrapper</returns>
        EncryptionKeyArrayWrapper SetKeys(EncryptionKeyRequestDto? encryptionKeyRequestDto = default);

        /// <summary>
        /// Creates and sets encryption keys for the user.
        /// </summary>
        /// <remarks>
        /// Creates and sets encryption keys for the user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The request object containing public and private key information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-keys/">REST API Reference for SetKeys Operation</seealso>
        /// <returns>ApiResponse of EncryptionKeyArrayWrapper</returns>
        ApiResponse<EncryptionKeyArrayWrapper> SetKeysWithHttpInfo(EncryptionKeyRequestDto? encryptionKeyRequestDto = default);
        /// <summary>
        /// Configures the privacy room settings for the portal.
        /// </summary>
        /// <remarks>
        /// Configures the privacy room settings for the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="privacyRoomEnableRequestDto">The request object containing the privacy room enable or disable flag. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-privacy-room-settings/">REST API Reference for SetPrivacyRoomSettings Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper SetPrivacyRoomSettings(PrivacyRoomEnableRequestDto? privacyRoomEnableRequestDto = default);

        /// <summary>
        /// Configures the privacy room settings for the portal.
        /// </summary>
        /// <remarks>
        /// Configures the privacy room settings for the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="privacyRoomEnableRequestDto">The request object containing the privacy room enable or disable flag. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-privacy-room-settings/">REST API Reference for SetPrivacyRoomSettings Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> SetPrivacyRoomSettingsWithHttpInfo(PrivacyRoomEnableRequestDto? privacyRoomEnableRequestDto = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPrivacyroomApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Deletes an encryption key and removes it from the system.
        /// </summary>
        /// <remarks>
        /// Deletes an encryption key and removes it from the system based on the provided key identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The unique identifier of the encryption key to be deleted.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-keys/">REST API Reference for DeleteKeys Operation</seealso>
        /// <returns>Task of EncryptionKeyArrayWrapper</returns>
        Task<EncryptionKeyArrayWrapper> DeleteKeysAsync(Guid id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes an encryption key and removes it from the system.
        /// </summary>
        /// <remarks>
        /// Deletes an encryption key and removes it from the system based on the provided key identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The unique identifier of the encryption key to be deleted.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-keys/">REST API Reference for DeleteKeys Operation</seealso>
        /// <returns>Task of ApiResponse (EncryptionKeyArrayWrapper)</returns>
        Task<ApiResponse<EncryptionKeyArrayWrapper>> DeleteKeysWithHttpInfoAsync(Guid id, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves the current settings for the Privacy Room functionality.
        /// </summary>
        /// <remarks>
        /// Retrieves the current settings for the Privacy Room functionality.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-privacy-room-settings/">REST API Reference for GetPrivacyRoomSettings Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> GetPrivacyRoomSettingsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the current settings for the Privacy Room functionality.
        /// </summary>
        /// <remarks>
        /// Retrieves the current settings for the Privacy Room functionality.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-privacy-room-settings/">REST API Reference for GetPrivacyRoomSettings Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> GetPrivacyRoomSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves encryption keys associated with the current user.
        /// </summary>
        /// <remarks>
        /// Retrieves encryption keys associated with the current user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys/">REST API Reference for GetUserKeys Operation</seealso>
        /// <returns>Task of EncryptionKeyArrayWrapper</returns>
        Task<EncryptionKeyArrayWrapper> GetUserKeysAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves encryption keys associated with the current user.
        /// </summary>
        /// <remarks>
        /// Retrieves encryption keys associated with the current user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys/">REST API Reference for GetUserKeys Operation</seealso>
        /// <returns>Task of ApiResponse (EncryptionKeyArrayWrapper)</returns>
        Task<ApiResponse<EncryptionKeyArrayWrapper>> GetUserKeysWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves a specific user encryption key based on the provided filter conditions.
        /// </summary>
        /// <remarks>
        /// Retrieves a specific user encryption key based on the provided filter conditions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The optional identifier of the encryption key to filter by. (optional)</param>
        /// <param name="type">The optional type of the encryption key to filter by. (optional)</param>
        /// <param name="publicKey">The optional public key to filter by. (optional)</param>
        /// <param name="privateKeyEnc">The optional encrypted private key to filter by. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys-by-filter/">REST API Reference for GetUserKeysByFilter Operation</seealso>
        /// <returns>Task of EncryptionKeyWrapper</returns>
        Task<EncryptionKeyWrapper> GetUserKeysByFilterAsync(Guid? id = default, EncryptionKeyType? type = default, string? publicKey = default, string? privateKeyEnc = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a specific user encryption key based on the provided filter conditions.
        /// </summary>
        /// <remarks>
        /// Retrieves a specific user encryption key based on the provided filter conditions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The optional identifier of the encryption key to filter by. (optional)</param>
        /// <param name="type">The optional type of the encryption key to filter by. (optional)</param>
        /// <param name="publicKey">The optional public key to filter by. (optional)</param>
        /// <param name="privateKeyEnc">The optional encrypted private key to filter by. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys-by-filter/">REST API Reference for GetUserKeysByFilter Operation</seealso>
        /// <returns>Task of ApiResponse (EncryptionKeyWrapper)</returns>
        Task<ApiResponse<EncryptionKeyWrapper>> GetUserKeysByFilterWithHttpInfoAsync(Guid? id = default, EncryptionKeyType? type = default, string? publicKey = default, string? privateKeyEnc = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves the encryption keys associated with a specific privacy room.
        /// </summary>
        /// <remarks>
        /// Retrieves the encryption keys associated with a specific privacy room.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the privacy room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys-for-room/">REST API Reference for GetUserKeysForRoom Operation</seealso>
        /// <returns>Task of EncryptionKeyArrayWrapper</returns>
        Task<EncryptionKeyArrayWrapper> GetUserKeysForRoomAsync(int roomId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the encryption keys associated with a specific privacy room.
        /// </summary>
        /// <remarks>
        /// Retrieves the encryption keys associated with a specific privacy room.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the privacy room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys-for-room/">REST API Reference for GetUserKeysForRoom Operation</seealso>
        /// <returns>Task of ApiResponse (EncryptionKeyArrayWrapper)</returns>
        Task<ApiResponse<EncryptionKeyArrayWrapper>> GetUserKeysForRoomWithHttpInfoAsync(int roomId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Replaces an existing encryption key with a new one for the user.
        /// </summary>
        /// <remarks>
        /// Replaces an existing encryption key with a new one for the user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The request object containing the public and private key information to replace the existing key. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/replace-key/">REST API Reference for ReplaceKey Operation</seealso>
        /// <returns>Task of EncryptionKeyArrayWrapper</returns>
        Task<EncryptionKeyArrayWrapper> ReplaceKeyAsync(EncryptionKeyRequestDto? encryptionKeyRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Replaces an existing encryption key with a new one for the user.
        /// </summary>
        /// <remarks>
        /// Replaces an existing encryption key with a new one for the user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The request object containing the public and private key information to replace the existing key. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/replace-key/">REST API Reference for ReplaceKey Operation</seealso>
        /// <returns>Task of ApiResponse (EncryptionKeyArrayWrapper)</returns>
        Task<ApiResponse<EncryptionKeyArrayWrapper>> ReplaceKeyWithHttpInfoAsync(EncryptionKeyRequestDto? encryptionKeyRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates and sets encryption keys for the user.
        /// </summary>
        /// <remarks>
        /// Creates and sets encryption keys for the user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The request object containing public and private key information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-keys/">REST API Reference for SetKeys Operation</seealso>
        /// <returns>Task of EncryptionKeyArrayWrapper</returns>
        Task<EncryptionKeyArrayWrapper> SetKeysAsync(EncryptionKeyRequestDto? encryptionKeyRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates and sets encryption keys for the user.
        /// </summary>
        /// <remarks>
        /// Creates and sets encryption keys for the user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The request object containing public and private key information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-keys/">REST API Reference for SetKeys Operation</seealso>
        /// <returns>Task of ApiResponse (EncryptionKeyArrayWrapper)</returns>
        Task<ApiResponse<EncryptionKeyArrayWrapper>> SetKeysWithHttpInfoAsync(EncryptionKeyRequestDto? encryptionKeyRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Configures the privacy room settings for the portal.
        /// </summary>
        /// <remarks>
        /// Configures the privacy room settings for the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="privacyRoomEnableRequestDto">The request object containing the privacy room enable or disable flag. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-privacy-room-settings/">REST API Reference for SetPrivacyRoomSettings Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> SetPrivacyRoomSettingsAsync(PrivacyRoomEnableRequestDto? privacyRoomEnableRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Configures the privacy room settings for the portal.
        /// </summary>
        /// <remarks>
        /// Configures the privacy room settings for the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="privacyRoomEnableRequestDto">The request object containing the privacy room enable or disable flag. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-privacy-room-settings/">REST API Reference for SetPrivacyRoomSettings Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> SetPrivacyRoomSettingsWithHttpInfoAsync(PrivacyRoomEnableRequestDto? privacyRoomEnableRequestDto = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPrivacyroomApi : IPrivacyroomApiSync, IPrivacyroomApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PrivacyroomApi : IDisposable, IPrivacyroomApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivacyroomApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public PrivacyroomApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivacyroomApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public PrivacyroomApi(string basePath)
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
        /// Initializes a new instance of the <see cref="PrivacyroomApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public PrivacyroomApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="PrivacyroomApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public PrivacyroomApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivacyroomApi"/> class.
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
        public PrivacyroomApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="PrivacyroomApi"/> class using a Configuration object.
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
        public PrivacyroomApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="PrivacyroomApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public PrivacyroomApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Deletes an encryption key and removes it from the system.
        /// </summary>
        /// <remarks>
        /// Deletes an encryption key and removes it from the system based on the provided key identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The unique identifier of the encryption key to be deleted.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-keys/">REST API Reference for DeleteKeys Operation</seealso>
        /// <returns>EncryptionKeyArrayWrapper</returns>
        public EncryptionKeyArrayWrapper DeleteKeys(Guid id)
        {
            var localVarResponse = DeleteKeysWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Deletes an encryption key and removes it from the system.
        /// </summary>
        /// <remarks>
        /// Deletes an encryption key and removes it from the system based on the provided key identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The unique identifier of the encryption key to be deleted.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-keys/">REST API Reference for DeleteKeys Operation</seealso>
        /// <returns>ApiResponse of EncryptionKeyArrayWrapper</returns>
        public ApiResponse<EncryptionKeyArrayWrapper> DeleteKeysWithHttpInfo(Guid id)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

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
            var localVarResponse = Client.Delete<EncryptionKeyArrayWrapper>("/api/2.0/privacyroom/keys/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteKeys", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Deletes an encryption key and removes it from the system.
        /// </summary>
        /// <remarks>
        /// Deletes an encryption key and removes it from the system based on the provided key identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The unique identifier of the encryption key to be deleted.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-keys/">REST API Reference for DeleteKeys Operation</seealso>
        /// <returns>Task of EncryptionKeyArrayWrapper</returns>
        public async Task<EncryptionKeyArrayWrapper> DeleteKeysAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeleteKeysWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Deletes an encryption key and removes it from the system.
        /// </summary>
        /// <remarks>
        /// Deletes an encryption key and removes it from the system based on the provided key identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The unique identifier of the encryption key to be deleted.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-keys/">REST API Reference for DeleteKeys Operation</seealso>
        /// <returns>Task of ApiResponse (EncryptionKeyArrayWrapper)</returns>
        public async Task<ApiResponse<EncryptionKeyArrayWrapper>> DeleteKeysWithHttpInfoAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<EncryptionKeyArrayWrapper>("/api/2.0/privacyroom/keys/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteKeys", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves the current settings for the Privacy Room functionality.
        /// </summary>
        /// <remarks>
        /// Retrieves the current settings for the Privacy Room functionality.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-privacy-room-settings/">REST API Reference for GetPrivacyRoomSettings Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper GetPrivacyRoomSettings()
        {
            var localVarResponse = GetPrivacyRoomSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the current settings for the Privacy Room functionality.
        /// </summary>
        /// <remarks>
        /// Retrieves the current settings for the Privacy Room functionality.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-privacy-room-settings/">REST API Reference for GetPrivacyRoomSettings Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> GetPrivacyRoomSettingsWithHttpInfo()
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
            var localVarResponse = Client.Get<BooleanWrapper>("/api/2.0/privacyroom", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPrivacyRoomSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves the current settings for the Privacy Room functionality.
        /// </summary>
        /// <remarks>
        /// Retrieves the current settings for the Privacy Room functionality.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-privacy-room-settings/">REST API Reference for GetPrivacyRoomSettings Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> GetPrivacyRoomSettingsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetPrivacyRoomSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the current settings for the Privacy Room functionality.
        /// </summary>
        /// <remarks>
        /// Retrieves the current settings for the Privacy Room functionality.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-privacy-room-settings/">REST API Reference for GetPrivacyRoomSettings Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> GetPrivacyRoomSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<BooleanWrapper>("/api/2.0/privacyroom", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPrivacyRoomSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves encryption keys associated with the current user.
        /// </summary>
        /// <remarks>
        /// Retrieves encryption keys associated with the current user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys/">REST API Reference for GetUserKeys Operation</seealso>
        /// <returns>EncryptionKeyArrayWrapper</returns>
        public EncryptionKeyArrayWrapper GetUserKeys()
        {
            var localVarResponse = GetUserKeysWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves encryption keys associated with the current user.
        /// </summary>
        /// <remarks>
        /// Retrieves encryption keys associated with the current user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys/">REST API Reference for GetUserKeys Operation</seealso>
        /// <returns>ApiResponse of EncryptionKeyArrayWrapper</returns>
        public ApiResponse<EncryptionKeyArrayWrapper> GetUserKeysWithHttpInfo()
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
            var localVarResponse = Client.Get<EncryptionKeyArrayWrapper>("/api/2.0/privacyroom/keys", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetUserKeys", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves encryption keys associated with the current user.
        /// </summary>
        /// <remarks>
        /// Retrieves encryption keys associated with the current user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys/">REST API Reference for GetUserKeys Operation</seealso>
        /// <returns>Task of EncryptionKeyArrayWrapper</returns>
        public async Task<EncryptionKeyArrayWrapper> GetUserKeysAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetUserKeysWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves encryption keys associated with the current user.
        /// </summary>
        /// <remarks>
        /// Retrieves encryption keys associated with the current user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys/">REST API Reference for GetUserKeys Operation</seealso>
        /// <returns>Task of ApiResponse (EncryptionKeyArrayWrapper)</returns>
        public async Task<ApiResponse<EncryptionKeyArrayWrapper>> GetUserKeysWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<EncryptionKeyArrayWrapper>("/api/2.0/privacyroom/keys", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetUserKeys", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves a specific user encryption key based on the provided filter conditions.
        /// </summary>
        /// <remarks>
        /// Retrieves a specific user encryption key based on the provided filter conditions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The optional identifier of the encryption key to filter by. (optional)</param>
        /// <param name="type">The optional type of the encryption key to filter by. (optional)</param>
        /// <param name="publicKey">The optional public key to filter by. (optional)</param>
        /// <param name="privateKeyEnc">The optional encrypted private key to filter by. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys-by-filter/">REST API Reference for GetUserKeysByFilter Operation</seealso>
        /// <returns>EncryptionKeyWrapper</returns>
        public EncryptionKeyWrapper GetUserKeysByFilter(Guid? id = default, EncryptionKeyType? type = default, string? publicKey = default, string? privateKeyEnc = default)
        {
            var localVarResponse = GetUserKeysByFilterWithHttpInfo(id, type, publicKey, privateKeyEnc);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves a specific user encryption key based on the provided filter conditions.
        /// </summary>
        /// <remarks>
        /// Retrieves a specific user encryption key based on the provided filter conditions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The optional identifier of the encryption key to filter by. (optional)</param>
        /// <param name="type">The optional type of the encryption key to filter by. (optional)</param>
        /// <param name="publicKey">The optional public key to filter by. (optional)</param>
        /// <param name="privateKeyEnc">The optional encrypted private key to filter by. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys-by-filter/">REST API Reference for GetUserKeysByFilter Operation</seealso>
        /// <returns>ApiResponse of EncryptionKeyWrapper</returns>
        public ApiResponse<EncryptionKeyWrapper> GetUserKeysByFilterWithHttpInfo(Guid? id = default, EncryptionKeyType? type = default, string? publicKey = default, string? privateKeyEnc = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "id", id));
            }
            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "type", type));
            }
            if (publicKey != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "publicKey", publicKey));
            }
            if (privateKeyEnc != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "privateKeyEnc", privateKeyEnc));
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
            var localVarResponse = Client.Get<EncryptionKeyWrapper>("/api/2.0/privacyroom/keys/filter", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetUserKeysByFilter", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves a specific user encryption key based on the provided filter conditions.
        /// </summary>
        /// <remarks>
        /// Retrieves a specific user encryption key based on the provided filter conditions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The optional identifier of the encryption key to filter by. (optional)</param>
        /// <param name="type">The optional type of the encryption key to filter by. (optional)</param>
        /// <param name="publicKey">The optional public key to filter by. (optional)</param>
        /// <param name="privateKeyEnc">The optional encrypted private key to filter by. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys-by-filter/">REST API Reference for GetUserKeysByFilter Operation</seealso>
        /// <returns>Task of EncryptionKeyWrapper</returns>
        public async Task<EncryptionKeyWrapper> GetUserKeysByFilterAsync(Guid? id = default, EncryptionKeyType? type = default, string? publicKey = default, string? privateKeyEnc = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetUserKeysByFilterWithHttpInfoAsync(id, type, publicKey, privateKeyEnc, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves a specific user encryption key based on the provided filter conditions.
        /// </summary>
        /// <remarks>
        /// Retrieves a specific user encryption key based on the provided filter conditions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The optional identifier of the encryption key to filter by. (optional)</param>
        /// <param name="type">The optional type of the encryption key to filter by. (optional)</param>
        /// <param name="publicKey">The optional public key to filter by. (optional)</param>
        /// <param name="privateKeyEnc">The optional encrypted private key to filter by. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys-by-filter/">REST API Reference for GetUserKeysByFilter Operation</seealso>
        /// <returns>Task of ApiResponse (EncryptionKeyWrapper)</returns>
        public async Task<ApiResponse<EncryptionKeyWrapper>> GetUserKeysByFilterWithHttpInfoAsync(Guid? id = default, EncryptionKeyType? type = default, string? publicKey = default, string? privateKeyEnc = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "id", id));
            }
            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "type", type));
            }
            if (publicKey != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "publicKey", publicKey));
            }
            if (privateKeyEnc != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "privateKeyEnc", privateKeyEnc));
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

            var localVarResponse = await AsynchronousClient.GetAsync<EncryptionKeyWrapper>("/api/2.0/privacyroom/keys/filter", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetUserKeysByFilter", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves the encryption keys associated with a specific privacy room.
        /// </summary>
        /// <remarks>
        /// Retrieves the encryption keys associated with a specific privacy room.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the privacy room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys-for-room/">REST API Reference for GetUserKeysForRoom Operation</seealso>
        /// <returns>EncryptionKeyArrayWrapper</returns>
        public EncryptionKeyArrayWrapper GetUserKeysForRoom(int roomId)
        {
            var localVarResponse = GetUserKeysForRoomWithHttpInfo(roomId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the encryption keys associated with a specific privacy room.
        /// </summary>
        /// <remarks>
        /// Retrieves the encryption keys associated with a specific privacy room.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the privacy room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys-for-room/">REST API Reference for GetUserKeysForRoom Operation</seealso>
        /// <returns>ApiResponse of EncryptionKeyArrayWrapper</returns>
        public ApiResponse<EncryptionKeyArrayWrapper> GetUserKeysForRoomWithHttpInfo(int roomId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter

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
            var localVarResponse = Client.Get<EncryptionKeyArrayWrapper>("/api/2.0/privacyroom/{roomId}/access", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetUserKeysForRoom", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves the encryption keys associated with a specific privacy room.
        /// </summary>
        /// <remarks>
        /// Retrieves the encryption keys associated with a specific privacy room.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the privacy room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys-for-room/">REST API Reference for GetUserKeysForRoom Operation</seealso>
        /// <returns>Task of EncryptionKeyArrayWrapper</returns>
        public async Task<EncryptionKeyArrayWrapper> GetUserKeysForRoomAsync(int roomId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetUserKeysForRoomWithHttpInfoAsync(roomId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the encryption keys associated with a specific privacy room.
        /// </summary>
        /// <remarks>
        /// Retrieves the encryption keys associated with a specific privacy room.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the privacy room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys-for-room/">REST API Reference for GetUserKeysForRoom Operation</seealso>
        /// <returns>Task of ApiResponse (EncryptionKeyArrayWrapper)</returns>
        public async Task<ApiResponse<EncryptionKeyArrayWrapper>> GetUserKeysForRoomWithHttpInfoAsync(int roomId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter

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

            var localVarResponse = await AsynchronousClient.GetAsync<EncryptionKeyArrayWrapper>("/api/2.0/privacyroom/{roomId}/access", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetUserKeysForRoom", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Replaces an existing encryption key with a new one for the user.
        /// </summary>
        /// <remarks>
        /// Replaces an existing encryption key with a new one for the user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The request object containing the public and private key information to replace the existing key. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/replace-key/">REST API Reference for ReplaceKey Operation</seealso>
        /// <returns>EncryptionKeyArrayWrapper</returns>
        public EncryptionKeyArrayWrapper ReplaceKey(EncryptionKeyRequestDto? encryptionKeyRequestDto = default)
        {
            var localVarResponse = ReplaceKeyWithHttpInfo(encryptionKeyRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Replaces an existing encryption key with a new one for the user.
        /// </summary>
        /// <remarks>
        /// Replaces an existing encryption key with a new one for the user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The request object containing the public and private key information to replace the existing key. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/replace-key/">REST API Reference for ReplaceKey Operation</seealso>
        /// <returns>ApiResponse of EncryptionKeyArrayWrapper</returns>
        public ApiResponse<EncryptionKeyArrayWrapper> ReplaceKeyWithHttpInfo(EncryptionKeyRequestDto? encryptionKeyRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (encryptionKeyRequestDto != null) localVarRequestOptions.Data = encryptionKeyRequestDto;

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
            var localVarResponse = Client.Put<EncryptionKeyArrayWrapper>("/api/2.0/privacyroom/keys", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ReplaceKey", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Replaces an existing encryption key with a new one for the user.
        /// </summary>
        /// <remarks>
        /// Replaces an existing encryption key with a new one for the user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The request object containing the public and private key information to replace the existing key. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/replace-key/">REST API Reference for ReplaceKey Operation</seealso>
        /// <returns>Task of EncryptionKeyArrayWrapper</returns>
        public async Task<EncryptionKeyArrayWrapper> ReplaceKeyAsync(EncryptionKeyRequestDto? encryptionKeyRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ReplaceKeyWithHttpInfoAsync(encryptionKeyRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Replaces an existing encryption key with a new one for the user.
        /// </summary>
        /// <remarks>
        /// Replaces an existing encryption key with a new one for the user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The request object containing the public and private key information to replace the existing key. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/replace-key/">REST API Reference for ReplaceKey Operation</seealso>
        /// <returns>Task of ApiResponse (EncryptionKeyArrayWrapper)</returns>
        public async Task<ApiResponse<EncryptionKeyArrayWrapper>> ReplaceKeyWithHttpInfoAsync(EncryptionKeyRequestDto? encryptionKeyRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (encryptionKeyRequestDto != null) localVarRequestOptions.Data = encryptionKeyRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<EncryptionKeyArrayWrapper>("/api/2.0/privacyroom/keys", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ReplaceKey", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Creates and sets encryption keys for the user.
        /// </summary>
        /// <remarks>
        /// Creates and sets encryption keys for the user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The request object containing public and private key information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-keys/">REST API Reference for SetKeys Operation</seealso>
        /// <returns>EncryptionKeyArrayWrapper</returns>
        public EncryptionKeyArrayWrapper SetKeys(EncryptionKeyRequestDto? encryptionKeyRequestDto = default)
        {
            var localVarResponse = SetKeysWithHttpInfo(encryptionKeyRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Creates and sets encryption keys for the user.
        /// </summary>
        /// <remarks>
        /// Creates and sets encryption keys for the user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The request object containing public and private key information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-keys/">REST API Reference for SetKeys Operation</seealso>
        /// <returns>ApiResponse of EncryptionKeyArrayWrapper</returns>
        public ApiResponse<EncryptionKeyArrayWrapper> SetKeysWithHttpInfo(EncryptionKeyRequestDto? encryptionKeyRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (encryptionKeyRequestDto != null) localVarRequestOptions.Data = encryptionKeyRequestDto;

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
            var localVarResponse = Client.Post<EncryptionKeyArrayWrapper>("/api/2.0/privacyroom/keys", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetKeys", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Creates and sets encryption keys for the user.
        /// </summary>
        /// <remarks>
        /// Creates and sets encryption keys for the user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The request object containing public and private key information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-keys/">REST API Reference for SetKeys Operation</seealso>
        /// <returns>Task of EncryptionKeyArrayWrapper</returns>
        public async Task<EncryptionKeyArrayWrapper> SetKeysAsync(EncryptionKeyRequestDto? encryptionKeyRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetKeysWithHttpInfoAsync(encryptionKeyRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Creates and sets encryption keys for the user.
        /// </summary>
        /// <remarks>
        /// Creates and sets encryption keys for the user.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The request object containing public and private key information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-keys/">REST API Reference for SetKeys Operation</seealso>
        /// <returns>Task of ApiResponse (EncryptionKeyArrayWrapper)</returns>
        public async Task<ApiResponse<EncryptionKeyArrayWrapper>> SetKeysWithHttpInfoAsync(EncryptionKeyRequestDto? encryptionKeyRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (encryptionKeyRequestDto != null) localVarRequestOptions.Data = encryptionKeyRequestDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<EncryptionKeyArrayWrapper>("/api/2.0/privacyroom/keys", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetKeys", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Configures the privacy room settings for the portal.
        /// </summary>
        /// <remarks>
        /// Configures the privacy room settings for the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="privacyRoomEnableRequestDto">The request object containing the privacy room enable or disable flag. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-privacy-room-settings/">REST API Reference for SetPrivacyRoomSettings Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper SetPrivacyRoomSettings(PrivacyRoomEnableRequestDto? privacyRoomEnableRequestDto = default)
        {
            var localVarResponse = SetPrivacyRoomSettingsWithHttpInfo(privacyRoomEnableRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Configures the privacy room settings for the portal.
        /// </summary>
        /// <remarks>
        /// Configures the privacy room settings for the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="privacyRoomEnableRequestDto">The request object containing the privacy room enable or disable flag. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-privacy-room-settings/">REST API Reference for SetPrivacyRoomSettings Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> SetPrivacyRoomSettingsWithHttpInfo(PrivacyRoomEnableRequestDto? privacyRoomEnableRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (privacyRoomEnableRequestDto != null) localVarRequestOptions.Data = privacyRoomEnableRequestDto;

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
            var localVarResponse = Client.Put<BooleanWrapper>("/api/2.0/privacyroom", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetPrivacyRoomSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Configures the privacy room settings for the portal.
        /// </summary>
        /// <remarks>
        /// Configures the privacy room settings for the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="privacyRoomEnableRequestDto">The request object containing the privacy room enable or disable flag. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-privacy-room-settings/">REST API Reference for SetPrivacyRoomSettings Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> SetPrivacyRoomSettingsAsync(PrivacyRoomEnableRequestDto? privacyRoomEnableRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetPrivacyRoomSettingsWithHttpInfoAsync(privacyRoomEnableRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Configures the privacy room settings for the portal.
        /// </summary>
        /// <remarks>
        /// Configures the privacy room settings for the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="privacyRoomEnableRequestDto">The request object containing the privacy room enable or disable flag. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-privacy-room-settings/">REST API Reference for SetPrivacyRoomSettings Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> SetPrivacyRoomSettingsWithHttpInfoAsync(PrivacyRoomEnableRequestDto? privacyRoomEnableRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (privacyRoomEnableRequestDto != null) localVarRequestOptions.Data = privacyRoomEnableRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/privacyroom", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetPrivacyRoomSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
