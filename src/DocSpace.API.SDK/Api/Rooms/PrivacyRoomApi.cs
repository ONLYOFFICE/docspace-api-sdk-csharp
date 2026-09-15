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
namespace DocSpace.API.SDK.Api.Rooms
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPrivacyRoomApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete an encryption key
        /// </summary>
        /// <remarks>
        /// Removes one encryption key pair from the calling user's own key set and answers 204 with no body. The pair is  named by the `id` of an entry of `GET api/2.0/privacyroom/keys`; the caller's other pairs stay as they are.  The call is destructive and cannot be repeated: the key material is gone for good, a second delete of the same  `id`, like an `id` that was never stored, is answered with 404, and there is no parameter for another user's  keys, so an authenticated member only ever deletes their own while a guest is refused. Deleting the last key  the caller holds locks them out of the private rooms they belong to, their own rooms included: the rooms and  their content survive untouched and stay listed as private, but `GET api/2.0/privacyroom/{roomId}/access` then  refuses the caller until a new key is stored with `POST api/2.0/privacyroom/keys`. Before DocSpace 4.0 the  call answered 200 with the caller's remaining keys, so a client that read that list has to call  `GET api/2.0/privacyroom/keys` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The pair to delete, taken from the `id` of an entry of `GET api/2.0/privacyroom/keys`. Only the caller's own  pairs can be named here.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-keys/">REST API Reference for DeleteKeys Operation</seealso>
        /// <returns></returns>
        void DeleteKeys(Guid id);

        /// <summary>
        /// Delete an encryption key
        /// </summary>
        /// <remarks>
        /// Removes one encryption key pair from the calling user's own key set and answers 204 with no body. The pair is  named by the `id` of an entry of `GET api/2.0/privacyroom/keys`; the caller's other pairs stay as they are.  The call is destructive and cannot be repeated: the key material is gone for good, a second delete of the same  `id`, like an `id` that was never stored, is answered with 404, and there is no parameter for another user's  keys, so an authenticated member only ever deletes their own while a guest is refused. Deleting the last key  the caller holds locks them out of the private rooms they belong to, their own rooms included: the rooms and  their content survive untouched and stay listed as private, but `GET api/2.0/privacyroom/{roomId}/access` then  refuses the caller until a new key is stored with `POST api/2.0/privacyroom/keys`. Before DocSpace 4.0 the  call answered 200 with the caller's remaining keys, so a client that read that list has to call  `GET api/2.0/privacyroom/keys` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The pair to delete, taken from the `id` of an entry of `GET api/2.0/privacyroom/keys`. Only the caller's own  pairs can be named here.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-keys/">REST API Reference for DeleteKeys Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteKeysWithHttpInfo(Guid id);
        /// <summary>
        /// Get own encryption keys
        /// </summary>
        /// <remarks>
        /// Returns every encryption key pair the calling user holds, the encrypted private half included, which is the  material a client needs in order to decrypt content in a private room. The set is personal and there is no  parameter for another user's keys: an authenticated caller reads only their own, and a guest, who cannot own  key material at all, always reads an empty set. The call is read-only. An empty answer, whether an empty list  or none at all, means no key has been created yet, and until `POST api/2.0/privacyroom/keys` creates one the  user cannot be invited to a private room. Each entry carries the pair's `id`, its owner in `userId`, the  moment the material was stored in `date`, the public half, the private half encrypted with the user's  password, and the portal-wide crypto engine in `cryptoEngineId`. For the keys that open a whole private room  use `GET api/2.0/privacyroom/{roomId}/access`, and for the keys a single file is shared with use  `GET api/2.0/files/file/{fileId}/publickeys`; this operation is about the caller alone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys/">REST API Reference for GetUserKeys Operation</seealso>
        /// <returns>EncryptionKeyArrayWrapper</returns>
        EncryptionKeyArrayWrapper GetUserKeys();

        /// <summary>
        /// Get own encryption keys
        /// </summary>
        /// <remarks>
        /// Returns every encryption key pair the calling user holds, the encrypted private half included, which is the  material a client needs in order to decrypt content in a private room. The set is personal and there is no  parameter for another user's keys: an authenticated caller reads only their own, and a guest, who cannot own  key material at all, always reads an empty set. The call is read-only. An empty answer, whether an empty list  or none at all, means no key has been created yet, and until `POST api/2.0/privacyroom/keys` creates one the  user cannot be invited to a private room. Each entry carries the pair's `id`, its owner in `userId`, the  moment the material was stored in `date`, the public half, the private half encrypted with the user's  password, and the portal-wide crypto engine in `cryptoEngineId`. For the keys that open a whole private room  use `GET api/2.0/privacyroom/{roomId}/access`, and for the keys a single file is shared with use  `GET api/2.0/files/file/{fileId}/publickeys`; this operation is about the caller alone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys/">REST API Reference for GetUserKeys Operation</seealso>
        /// <returns>ApiResponse of EncryptionKeyArrayWrapper</returns>
        ApiResponse<EncryptionKeyArrayWrapper> GetUserKeysWithHttpInfo();
        /// <summary>
        /// Get private room access keys
        /// </summary>
        /// <remarks>
        /// Returns the encryption keys that give access to a private room: one entry per key held by each of its members,  which is what a client needs in order to encrypt a file key for everyone allowed to open the room's content.  Only the caller's own entries carry `privateKeyEnc`; another member's entry carries the public half alone, and  an entry with no public half is not reported as access at all. The room has to be a private one, a room  created without private mode holds no access keys and the call is refused, and it has to still exist: an  unknown room, or one already moved to Trash, is reported as missing, while an archived private room still  answers. Access follows room membership and not portal role: any member from read access upwards receives the  full set, whereas a DocSpace administrator who is not a member is refused, and so is a caller holding no key  of their own, the room creator included once they delete their last key. The call is read-only. For the keys  of a single file use `GET api/2.0/files/file/{fileId}/publickeys`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The private room whose access keys are read. Take it from the `id` of the room returned by  `POST api/2.0/files/rooms` or listed by `GET api/2.0/files/rooms`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys-for-room/">REST API Reference for GetUserKeysForRoom Operation</seealso>
        /// <returns>EncryptionKeyArrayWrapper</returns>
        EncryptionKeyArrayWrapper GetUserKeysForRoom(int roomId);

        /// <summary>
        /// Get private room access keys
        /// </summary>
        /// <remarks>
        /// Returns the encryption keys that give access to a private room: one entry per key held by each of its members,  which is what a client needs in order to encrypt a file key for everyone allowed to open the room's content.  Only the caller's own entries carry `privateKeyEnc`; another member's entry carries the public half alone, and  an entry with no public half is not reported as access at all. The room has to be a private one, a room  created without private mode holds no access keys and the call is refused, and it has to still exist: an  unknown room, or one already moved to Trash, is reported as missing, while an archived private room still  answers. Access follows room membership and not portal role: any member from read access upwards receives the  full set, whereas a DocSpace administrator who is not a member is refused, and so is a caller holding no key  of their own, the room creator included once they delete their last key. The call is read-only. For the keys  of a single file use `GET api/2.0/files/file/{fileId}/publickeys`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The private room whose access keys are read. Take it from the `id` of the room returned by  `POST api/2.0/files/rooms` or listed by `GET api/2.0/files/rooms`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys-for-room/">REST API Reference for GetUserKeysForRoom Operation</seealso>
        /// <returns>ApiResponse of EncryptionKeyArrayWrapper</returns>
        ApiResponse<EncryptionKeyArrayWrapper> GetUserKeysForRoomWithHttpInfo(int roomId);
        /// <summary>
        /// Rotate an encryption key
        /// </summary>
        /// <remarks>
        /// Rotates one encryption key pair of the calling user: the entry whose `id` matches is overwritten with the  submitted `publicKey` and `privateKeyEnc`, and the caller's other pairs are left untouched. The pair has to  exist already, an `id` that is not in the caller's set is answered with 404, and a first key is created with  `POST api/2.0/privacyroom/keys`. This is a full replacement rather than a merge: both halves are mandatory,  and a request that omits or blanks one of them is rejected as invalid with the stored pair surviving  unchanged, so a rotation that means to keep the private half has to send it again. Omitting `id` targets the  all-zero pair, the one a client that never sets an id keeps rotating. Every authenticated member rotates their  own keys and only their own, and a guest is refused. The call is mutating, and repeating it with the same body  leaves the same state. It answers with every key the caller holds afterwards, and from then on  `GET api/2.0/privacyroom/{roomId}/access` reports the new public half for this member.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The two halves of an encryption key pair to store for the calling user, plus the identifier the pair is kept  under. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/replace-key/">REST API Reference for ReplaceKey Operation</seealso>
        /// <returns>EncryptionKeyArrayWrapper</returns>
        EncryptionKeyArrayWrapper ReplaceKey(EncryptionKeyRequestDto? encryptionKeyRequestDto = default);

        /// <summary>
        /// Rotate an encryption key
        /// </summary>
        /// <remarks>
        /// Rotates one encryption key pair of the calling user: the entry whose `id` matches is overwritten with the  submitted `publicKey` and `privateKeyEnc`, and the caller's other pairs are left untouched. The pair has to  exist already, an `id` that is not in the caller's set is answered with 404, and a first key is created with  `POST api/2.0/privacyroom/keys`. This is a full replacement rather than a merge: both halves are mandatory,  and a request that omits or blanks one of them is rejected as invalid with the stored pair surviving  unchanged, so a rotation that means to keep the private half has to send it again. Omitting `id` targets the  all-zero pair, the one a client that never sets an id keeps rotating. Every authenticated member rotates their  own keys and only their own, and a guest is refused. The call is mutating, and repeating it with the same body  leaves the same state. It answers with every key the caller holds afterwards, and from then on  `GET api/2.0/privacyroom/{roomId}/access` reports the new public half for this member.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The two halves of an encryption key pair to store for the calling user, plus the identifier the pair is kept  under. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/replace-key/">REST API Reference for ReplaceKey Operation</seealso>
        /// <returns>ApiResponse of EncryptionKeyArrayWrapper</returns>
        ApiResponse<EncryptionKeyArrayWrapper> ReplaceKeyWithHttpInfo(EncryptionKeyRequestDto? encryptionKeyRequestDto = default);
        /// <summary>
        /// Create an encryption key
        /// </summary>
        /// <remarks>
        /// Stores a new encryption key pair for the calling user and answers with that user's whole key set. The material  is end-to-end: `publicKey` is the half other members use to encrypt file keys for this user, while  `privateKeyEnc` arrives already encrypted with the user's own password, so the portal keeps it as opaque text.  A member must hold at least one key before they can be invited to a private room, which makes this the first  call of the private-room flow. Every authenticated member manages their own keys and only their own, there is  no parameter for somebody else's, and a guest is refused, which is also why a guest cannot become a member of  a private room. The call is mutating and is not safe to repeat: `id` names the pair inside the caller's set  and an `id` that is already stored is answered with 409, while a request that omits or blanks either half is  rejected as invalid and stores nothing. A successful call answers 201 with every key the caller now holds. To  change the material of an existing pair use `PUT api/2.0/privacyroom/keys`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The two halves of an encryption key pair to store for the calling user, plus the identifier the pair is kept  under. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-keys/">REST API Reference for SetKeys Operation</seealso>
        /// <returns>EncryptionKeyArrayWrapper</returns>
        EncryptionKeyArrayWrapper SetKeys(EncryptionKeyRequestDto? encryptionKeyRequestDto = default);

        /// <summary>
        /// Create an encryption key
        /// </summary>
        /// <remarks>
        /// Stores a new encryption key pair for the calling user and answers with that user's whole key set. The material  is end-to-end: `publicKey` is the half other members use to encrypt file keys for this user, while  `privateKeyEnc` arrives already encrypted with the user's own password, so the portal keeps it as opaque text.  A member must hold at least one key before they can be invited to a private room, which makes this the first  call of the private-room flow. Every authenticated member manages their own keys and only their own, there is  no parameter for somebody else's, and a guest is refused, which is also why a guest cannot become a member of  a private room. The call is mutating and is not safe to repeat: `id` names the pair inside the caller's set  and an `id` that is already stored is answered with 409, while a request that omits or blanks either half is  rejected as invalid and stores nothing. A successful call answers 201 with every key the caller now holds. To  change the material of an existing pair use `PUT api/2.0/privacyroom/keys`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The two halves of an encryption key pair to store for the calling user, plus the identifier the pair is kept  under. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-keys/">REST API Reference for SetKeys Operation</seealso>
        /// <returns>ApiResponse of EncryptionKeyArrayWrapper</returns>
        ApiResponse<EncryptionKeyArrayWrapper> SetKeysWithHttpInfo(EncryptionKeyRequestDto? encryptionKeyRequestDto = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPrivacyRoomApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Delete an encryption key
        /// </summary>
        /// <remarks>
        /// Removes one encryption key pair from the calling user's own key set and answers 204 with no body. The pair is  named by the `id` of an entry of `GET api/2.0/privacyroom/keys`; the caller's other pairs stay as they are.  The call is destructive and cannot be repeated: the key material is gone for good, a second delete of the same  `id`, like an `id` that was never stored, is answered with 404, and there is no parameter for another user's  keys, so an authenticated member only ever deletes their own while a guest is refused. Deleting the last key  the caller holds locks them out of the private rooms they belong to, their own rooms included: the rooms and  their content survive untouched and stay listed as private, but `GET api/2.0/privacyroom/{roomId}/access` then  refuses the caller until a new key is stored with `POST api/2.0/privacyroom/keys`. Before DocSpace 4.0 the  call answered 200 with the caller's remaining keys, so a client that read that list has to call  `GET api/2.0/privacyroom/keys` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The pair to delete, taken from the `id` of an entry of `GET api/2.0/privacyroom/keys`. Only the caller's own  pairs can be named here.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-keys/">REST API Reference for DeleteKeys Operation</seealso>
        /// <returns>Task of void</returns>
        Task DeleteKeysAsync(Guid id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete an encryption key
        /// </summary>
        /// <remarks>
        /// Removes one encryption key pair from the calling user's own key set and answers 204 with no body. The pair is  named by the `id` of an entry of `GET api/2.0/privacyroom/keys`; the caller's other pairs stay as they are.  The call is destructive and cannot be repeated: the key material is gone for good, a second delete of the same  `id`, like an `id` that was never stored, is answered with 404, and there is no parameter for another user's  keys, so an authenticated member only ever deletes their own while a guest is refused. Deleting the last key  the caller holds locks them out of the private rooms they belong to, their own rooms included: the rooms and  their content survive untouched and stay listed as private, but `GET api/2.0/privacyroom/{roomId}/access` then  refuses the caller until a new key is stored with `POST api/2.0/privacyroom/keys`. Before DocSpace 4.0 the  call answered 200 with the caller's remaining keys, so a client that read that list has to call  `GET api/2.0/privacyroom/keys` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The pair to delete, taken from the `id` of an entry of `GET api/2.0/privacyroom/keys`. Only the caller's own  pairs can be named here.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-keys/">REST API Reference for DeleteKeys Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> DeleteKeysWithHttpInfoAsync(Guid id, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get own encryption keys
        /// </summary>
        /// <remarks>
        /// Returns every encryption key pair the calling user holds, the encrypted private half included, which is the  material a client needs in order to decrypt content in a private room. The set is personal and there is no  parameter for another user's keys: an authenticated caller reads only their own, and a guest, who cannot own  key material at all, always reads an empty set. The call is read-only. An empty answer, whether an empty list  or none at all, means no key has been created yet, and until `POST api/2.0/privacyroom/keys` creates one the  user cannot be invited to a private room. Each entry carries the pair's `id`, its owner in `userId`, the  moment the material was stored in `date`, the public half, the private half encrypted with the user's  password, and the portal-wide crypto engine in `cryptoEngineId`. For the keys that open a whole private room  use `GET api/2.0/privacyroom/{roomId}/access`, and for the keys a single file is shared with use  `GET api/2.0/files/file/{fileId}/publickeys`; this operation is about the caller alone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys/">REST API Reference for GetUserKeys Operation</seealso>
        /// <returns>Task of EncryptionKeyArrayWrapper</returns>
        Task<EncryptionKeyArrayWrapper> GetUserKeysAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get own encryption keys
        /// </summary>
        /// <remarks>
        /// Returns every encryption key pair the calling user holds, the encrypted private half included, which is the  material a client needs in order to decrypt content in a private room. The set is personal and there is no  parameter for another user's keys: an authenticated caller reads only their own, and a guest, who cannot own  key material at all, always reads an empty set. The call is read-only. An empty answer, whether an empty list  or none at all, means no key has been created yet, and until `POST api/2.0/privacyroom/keys` creates one the  user cannot be invited to a private room. Each entry carries the pair's `id`, its owner in `userId`, the  moment the material was stored in `date`, the public half, the private half encrypted with the user's  password, and the portal-wide crypto engine in `cryptoEngineId`. For the keys that open a whole private room  use `GET api/2.0/privacyroom/{roomId}/access`, and for the keys a single file is shared with use  `GET api/2.0/files/file/{fileId}/publickeys`; this operation is about the caller alone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys/">REST API Reference for GetUserKeys Operation</seealso>
        /// <returns>Task of ApiResponse (EncryptionKeyArrayWrapper)</returns>
        Task<ApiResponse<EncryptionKeyArrayWrapper>> GetUserKeysWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get private room access keys
        /// </summary>
        /// <remarks>
        /// Returns the encryption keys that give access to a private room: one entry per key held by each of its members,  which is what a client needs in order to encrypt a file key for everyone allowed to open the room's content.  Only the caller's own entries carry `privateKeyEnc`; another member's entry carries the public half alone, and  an entry with no public half is not reported as access at all. The room has to be a private one, a room  created without private mode holds no access keys and the call is refused, and it has to still exist: an  unknown room, or one already moved to Trash, is reported as missing, while an archived private room still  answers. Access follows room membership and not portal role: any member from read access upwards receives the  full set, whereas a DocSpace administrator who is not a member is refused, and so is a caller holding no key  of their own, the room creator included once they delete their last key. The call is read-only. For the keys  of a single file use `GET api/2.0/files/file/{fileId}/publickeys`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The private room whose access keys are read. Take it from the `id` of the room returned by  `POST api/2.0/files/rooms` or listed by `GET api/2.0/files/rooms`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys-for-room/">REST API Reference for GetUserKeysForRoom Operation</seealso>
        /// <returns>Task of EncryptionKeyArrayWrapper</returns>
        Task<EncryptionKeyArrayWrapper> GetUserKeysForRoomAsync(int roomId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get private room access keys
        /// </summary>
        /// <remarks>
        /// Returns the encryption keys that give access to a private room: one entry per key held by each of its members,  which is what a client needs in order to encrypt a file key for everyone allowed to open the room's content.  Only the caller's own entries carry `privateKeyEnc`; another member's entry carries the public half alone, and  an entry with no public half is not reported as access at all. The room has to be a private one, a room  created without private mode holds no access keys and the call is refused, and it has to still exist: an  unknown room, or one already moved to Trash, is reported as missing, while an archived private room still  answers. Access follows room membership and not portal role: any member from read access upwards receives the  full set, whereas a DocSpace administrator who is not a member is refused, and so is a caller holding no key  of their own, the room creator included once they delete their last key. The call is read-only. For the keys  of a single file use `GET api/2.0/files/file/{fileId}/publickeys`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The private room whose access keys are read. Take it from the `id` of the room returned by  `POST api/2.0/files/rooms` or listed by `GET api/2.0/files/rooms`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys-for-room/">REST API Reference for GetUserKeysForRoom Operation</seealso>
        /// <returns>Task of ApiResponse (EncryptionKeyArrayWrapper)</returns>
        Task<ApiResponse<EncryptionKeyArrayWrapper>> GetUserKeysForRoomWithHttpInfoAsync(int roomId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate an encryption key
        /// </summary>
        /// <remarks>
        /// Rotates one encryption key pair of the calling user: the entry whose `id` matches is overwritten with the  submitted `publicKey` and `privateKeyEnc`, and the caller's other pairs are left untouched. The pair has to  exist already, an `id` that is not in the caller's set is answered with 404, and a first key is created with  `POST api/2.0/privacyroom/keys`. This is a full replacement rather than a merge: both halves are mandatory,  and a request that omits or blanks one of them is rejected as invalid with the stored pair surviving  unchanged, so a rotation that means to keep the private half has to send it again. Omitting `id` targets the  all-zero pair, the one a client that never sets an id keeps rotating. Every authenticated member rotates their  own keys and only their own, and a guest is refused. The call is mutating, and repeating it with the same body  leaves the same state. It answers with every key the caller holds afterwards, and from then on  `GET api/2.0/privacyroom/{roomId}/access` reports the new public half for this member.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The two halves of an encryption key pair to store for the calling user, plus the identifier the pair is kept  under. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/replace-key/">REST API Reference for ReplaceKey Operation</seealso>
        /// <returns>Task of EncryptionKeyArrayWrapper</returns>
        Task<EncryptionKeyArrayWrapper> ReplaceKeyAsync(EncryptionKeyRequestDto? encryptionKeyRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Rotate an encryption key
        /// </summary>
        /// <remarks>
        /// Rotates one encryption key pair of the calling user: the entry whose `id` matches is overwritten with the  submitted `publicKey` and `privateKeyEnc`, and the caller's other pairs are left untouched. The pair has to  exist already, an `id` that is not in the caller's set is answered with 404, and a first key is created with  `POST api/2.0/privacyroom/keys`. This is a full replacement rather than a merge: both halves are mandatory,  and a request that omits or blanks one of them is rejected as invalid with the stored pair surviving  unchanged, so a rotation that means to keep the private half has to send it again. Omitting `id` targets the  all-zero pair, the one a client that never sets an id keeps rotating. Every authenticated member rotates their  own keys and only their own, and a guest is refused. The call is mutating, and repeating it with the same body  leaves the same state. It answers with every key the caller holds afterwards, and from then on  `GET api/2.0/privacyroom/{roomId}/access` reports the new public half for this member.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The two halves of an encryption key pair to store for the calling user, plus the identifier the pair is kept  under. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/replace-key/">REST API Reference for ReplaceKey Operation</seealso>
        /// <returns>Task of ApiResponse (EncryptionKeyArrayWrapper)</returns>
        Task<ApiResponse<EncryptionKeyArrayWrapper>> ReplaceKeyWithHttpInfoAsync(EncryptionKeyRequestDto? encryptionKeyRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an encryption key
        /// </summary>
        /// <remarks>
        /// Stores a new encryption key pair for the calling user and answers with that user's whole key set. The material  is end-to-end: `publicKey` is the half other members use to encrypt file keys for this user, while  `privateKeyEnc` arrives already encrypted with the user's own password, so the portal keeps it as opaque text.  A member must hold at least one key before they can be invited to a private room, which makes this the first  call of the private-room flow. Every authenticated member manages their own keys and only their own, there is  no parameter for somebody else's, and a guest is refused, which is also why a guest cannot become a member of  a private room. The call is mutating and is not safe to repeat: `id` names the pair inside the caller's set  and an `id` that is already stored is answered with 409, while a request that omits or blanks either half is  rejected as invalid and stores nothing. A successful call answers 201 with every key the caller now holds. To  change the material of an existing pair use `PUT api/2.0/privacyroom/keys`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The two halves of an encryption key pair to store for the calling user, plus the identifier the pair is kept  under. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-keys/">REST API Reference for SetKeys Operation</seealso>
        /// <returns>Task of EncryptionKeyArrayWrapper</returns>
        Task<EncryptionKeyArrayWrapper> SetKeysAsync(EncryptionKeyRequestDto? encryptionKeyRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an encryption key
        /// </summary>
        /// <remarks>
        /// Stores a new encryption key pair for the calling user and answers with that user's whole key set. The material  is end-to-end: `publicKey` is the half other members use to encrypt file keys for this user, while  `privateKeyEnc` arrives already encrypted with the user's own password, so the portal keeps it as opaque text.  A member must hold at least one key before they can be invited to a private room, which makes this the first  call of the private-room flow. Every authenticated member manages their own keys and only their own, there is  no parameter for somebody else's, and a guest is refused, which is also why a guest cannot become a member of  a private room. The call is mutating and is not safe to repeat: `id` names the pair inside the caller's set  and an `id` that is already stored is answered with 409, while a request that omits or blanks either half is  rejected as invalid and stores nothing. A successful call answers 201 with every key the caller now holds. To  change the material of an existing pair use `PUT api/2.0/privacyroom/keys`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The two halves of an encryption key pair to store for the calling user, plus the identifier the pair is kept  under. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-keys/">REST API Reference for SetKeys Operation</seealso>
        /// <returns>Task of ApiResponse (EncryptionKeyArrayWrapper)</returns>
        Task<ApiResponse<EncryptionKeyArrayWrapper>> SetKeysWithHttpInfoAsync(EncryptionKeyRequestDto? encryptionKeyRequestDto = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPrivacyRoomApi : IPrivacyRoomApiSync, IPrivacyRoomApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PrivacyRoomApi : IDisposable, IPrivacyRoomApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivacyRoomApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public PrivacyRoomApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivacyRoomApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public PrivacyRoomApi(string basePath)
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
        /// Initializes a new instance of the <see cref="PrivacyRoomApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public PrivacyRoomApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="PrivacyRoomApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public PrivacyRoomApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivacyRoomApi"/> class.
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
        public PrivacyRoomApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="PrivacyRoomApi"/> class using a Configuration object.
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
        public PrivacyRoomApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="PrivacyRoomApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public PrivacyRoomApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Delete an encryption key
        /// </summary>
        /// <remarks>
        /// Removes one encryption key pair from the calling user's own key set and answers 204 with no body. The pair is  named by the `id` of an entry of `GET api/2.0/privacyroom/keys`; the caller's other pairs stay as they are.  The call is destructive and cannot be repeated: the key material is gone for good, a second delete of the same  `id`, like an `id` that was never stored, is answered with 404, and there is no parameter for another user's  keys, so an authenticated member only ever deletes their own while a guest is refused. Deleting the last key  the caller holds locks them out of the private rooms they belong to, their own rooms included: the rooms and  their content survive untouched and stay listed as private, but `GET api/2.0/privacyroom/{roomId}/access` then  refuses the caller until a new key is stored with `POST api/2.0/privacyroom/keys`. Before DocSpace 4.0 the  call answered 200 with the caller's remaining keys, so a client that read that list has to call  `GET api/2.0/privacyroom/keys` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The pair to delete, taken from the `id` of an entry of `GET api/2.0/privacyroom/keys`. Only the caller's own  pairs can be named here.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-keys/">REST API Reference for DeleteKeys Operation</seealso>
        /// <returns></returns>
        public void DeleteKeys(Guid id)
        {
            DeleteKeysWithHttpInfo(id);
        }

        /// <summary>
        /// Delete an encryption key
        /// </summary>
        /// <remarks>
        /// Removes one encryption key pair from the calling user's own key set and answers 204 with no body. The pair is  named by the `id` of an entry of `GET api/2.0/privacyroom/keys`; the caller's other pairs stay as they are.  The call is destructive and cannot be repeated: the key material is gone for good, a second delete of the same  `id`, like an `id` that was never stored, is answered with 404, and there is no parameter for another user's  keys, so an authenticated member only ever deletes their own while a guest is refused. Deleting the last key  the caller holds locks them out of the private rooms they belong to, their own rooms included: the rooms and  their content survive untouched and stay listed as private, but `GET api/2.0/privacyroom/{roomId}/access` then  refuses the caller until a new key is stored with `POST api/2.0/privacyroom/keys`. Before DocSpace 4.0 the  call answered 200 with the caller's remaining keys, so a client that read that list has to call  `GET api/2.0/privacyroom/keys` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The pair to delete, taken from the `id` of an entry of `GET api/2.0/privacyroom/keys`. Only the caller's own  pairs can be named here.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-keys/">REST API Reference for DeleteKeys Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteKeysWithHttpInfo(Guid id)
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
            var localVarResponse = Client.Delete<Object>("/api/2.0/privacyroom/keys/{id}", localVarRequestOptions, Configuration);

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
        /// Delete an encryption key
        /// </summary>
        /// <remarks>
        /// Removes one encryption key pair from the calling user's own key set and answers 204 with no body. The pair is  named by the `id` of an entry of `GET api/2.0/privacyroom/keys`; the caller's other pairs stay as they are.  The call is destructive and cannot be repeated: the key material is gone for good, a second delete of the same  `id`, like an `id` that was never stored, is answered with 404, and there is no parameter for another user's  keys, so an authenticated member only ever deletes their own while a guest is refused. Deleting the last key  the caller holds locks them out of the private rooms they belong to, their own rooms included: the rooms and  their content survive untouched and stay listed as private, but `GET api/2.0/privacyroom/{roomId}/access` then  refuses the caller until a new key is stored with `POST api/2.0/privacyroom/keys`. Before DocSpace 4.0 the  call answered 200 with the caller's remaining keys, so a client that read that list has to call  `GET api/2.0/privacyroom/keys` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The pair to delete, taken from the `id` of an entry of `GET api/2.0/privacyroom/keys`. Only the caller's own  pairs can be named here.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-keys/">REST API Reference for DeleteKeys Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task DeleteKeysAsync(Guid id, CancellationToken cancellationToken = default)
        {
            await DeleteKeysWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete an encryption key
        /// </summary>
        /// <remarks>
        /// Removes one encryption key pair from the calling user's own key set and answers 204 with no body. The pair is  named by the `id` of an entry of `GET api/2.0/privacyroom/keys`; the caller's other pairs stay as they are.  The call is destructive and cannot be repeated: the key material is gone for good, a second delete of the same  `id`, like an `id` that was never stored, is answered with 404, and there is no parameter for another user's  keys, so an authenticated member only ever deletes their own while a guest is refused. Deleting the last key  the caller holds locks them out of the private rooms they belong to, their own rooms included: the rooms and  their content survive untouched and stay listed as private, but `GET api/2.0/privacyroom/{roomId}/access` then  refuses the caller until a new key is stored with `POST api/2.0/privacyroom/keys`. Before DocSpace 4.0 the  call answered 200 with the caller's remaining keys, so a client that read that list has to call  `GET api/2.0/privacyroom/keys` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The pair to delete, taken from the `id` of an entry of `GET api/2.0/privacyroom/keys`. Only the caller's own  pairs can be named here.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-keys/">REST API Reference for DeleteKeys Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> DeleteKeysWithHttpInfoAsync(Guid id, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.DeleteAsync<Object>("/api/2.0/privacyroom/keys/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

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
        /// Get own encryption keys
        /// </summary>
        /// <remarks>
        /// Returns every encryption key pair the calling user holds, the encrypted private half included, which is the  material a client needs in order to decrypt content in a private room. The set is personal and there is no  parameter for another user's keys: an authenticated caller reads only their own, and a guest, who cannot own  key material at all, always reads an empty set. The call is read-only. An empty answer, whether an empty list  or none at all, means no key has been created yet, and until `POST api/2.0/privacyroom/keys` creates one the  user cannot be invited to a private room. Each entry carries the pair's `id`, its owner in `userId`, the  moment the material was stored in `date`, the public half, the private half encrypted with the user's  password, and the portal-wide crypto engine in `cryptoEngineId`. For the keys that open a whole private room  use `GET api/2.0/privacyroom/{roomId}/access`, and for the keys a single file is shared with use  `GET api/2.0/files/file/{fileId}/publickeys`; this operation is about the caller alone.
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
        /// Get own encryption keys
        /// </summary>
        /// <remarks>
        /// Returns every encryption key pair the calling user holds, the encrypted private half included, which is the  material a client needs in order to decrypt content in a private room. The set is personal and there is no  parameter for another user's keys: an authenticated caller reads only their own, and a guest, who cannot own  key material at all, always reads an empty set. The call is read-only. An empty answer, whether an empty list  or none at all, means no key has been created yet, and until `POST api/2.0/privacyroom/keys` creates one the  user cannot be invited to a private room. Each entry carries the pair's `id`, its owner in `userId`, the  moment the material was stored in `date`, the public half, the private half encrypted with the user's  password, and the portal-wide crypto engine in `cryptoEngineId`. For the keys that open a whole private room  use `GET api/2.0/privacyroom/{roomId}/access`, and for the keys a single file is shared with use  `GET api/2.0/files/file/{fileId}/publickeys`; this operation is about the caller alone.
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
        /// Get own encryption keys
        /// </summary>
        /// <remarks>
        /// Returns every encryption key pair the calling user holds, the encrypted private half included, which is the  material a client needs in order to decrypt content in a private room. The set is personal and there is no  parameter for another user's keys: an authenticated caller reads only their own, and a guest, who cannot own  key material at all, always reads an empty set. The call is read-only. An empty answer, whether an empty list  or none at all, means no key has been created yet, and until `POST api/2.0/privacyroom/keys` creates one the  user cannot be invited to a private room. Each entry carries the pair's `id`, its owner in `userId`, the  moment the material was stored in `date`, the public half, the private half encrypted with the user's  password, and the portal-wide crypto engine in `cryptoEngineId`. For the keys that open a whole private room  use `GET api/2.0/privacyroom/{roomId}/access`, and for the keys a single file is shared with use  `GET api/2.0/files/file/{fileId}/publickeys`; this operation is about the caller alone.
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
        /// Get own encryption keys
        /// </summary>
        /// <remarks>
        /// Returns every encryption key pair the calling user holds, the encrypted private half included, which is the  material a client needs in order to decrypt content in a private room. The set is personal and there is no  parameter for another user's keys: an authenticated caller reads only their own, and a guest, who cannot own  key material at all, always reads an empty set. The call is read-only. An empty answer, whether an empty list  or none at all, means no key has been created yet, and until `POST api/2.0/privacyroom/keys` creates one the  user cannot be invited to a private room. Each entry carries the pair's `id`, its owner in `userId`, the  moment the material was stored in `date`, the public half, the private half encrypted with the user's  password, and the portal-wide crypto engine in `cryptoEngineId`. For the keys that open a whole private room  use `GET api/2.0/privacyroom/{roomId}/access`, and for the keys a single file is shared with use  `GET api/2.0/files/file/{fileId}/publickeys`; this operation is about the caller alone.
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
        /// Get private room access keys
        /// </summary>
        /// <remarks>
        /// Returns the encryption keys that give access to a private room: one entry per key held by each of its members,  which is what a client needs in order to encrypt a file key for everyone allowed to open the room's content.  Only the caller's own entries carry `privateKeyEnc`; another member's entry carries the public half alone, and  an entry with no public half is not reported as access at all. The room has to be a private one, a room  created without private mode holds no access keys and the call is refused, and it has to still exist: an  unknown room, or one already moved to Trash, is reported as missing, while an archived private room still  answers. Access follows room membership and not portal role: any member from read access upwards receives the  full set, whereas a DocSpace administrator who is not a member is refused, and so is a caller holding no key  of their own, the room creator included once they delete their last key. The call is read-only. For the keys  of a single file use `GET api/2.0/files/file/{fileId}/publickeys`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The private room whose access keys are read. Take it from the `id` of the room returned by  `POST api/2.0/files/rooms` or listed by `GET api/2.0/files/rooms`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys-for-room/">REST API Reference for GetUserKeysForRoom Operation</seealso>
        /// <returns>EncryptionKeyArrayWrapper</returns>
        public EncryptionKeyArrayWrapper GetUserKeysForRoom(int roomId)
        {
            var localVarResponse = GetUserKeysForRoomWithHttpInfo(roomId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get private room access keys
        /// </summary>
        /// <remarks>
        /// Returns the encryption keys that give access to a private room: one entry per key held by each of its members,  which is what a client needs in order to encrypt a file key for everyone allowed to open the room's content.  Only the caller's own entries carry `privateKeyEnc`; another member's entry carries the public half alone, and  an entry with no public half is not reported as access at all. The room has to be a private one, a room  created without private mode holds no access keys and the call is refused, and it has to still exist: an  unknown room, or one already moved to Trash, is reported as missing, while an archived private room still  answers. Access follows room membership and not portal role: any member from read access upwards receives the  full set, whereas a DocSpace administrator who is not a member is refused, and so is a caller holding no key  of their own, the room creator included once they delete their last key. The call is read-only. For the keys  of a single file use `GET api/2.0/files/file/{fileId}/publickeys`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The private room whose access keys are read. Take it from the `id` of the room returned by  `POST api/2.0/files/rooms` or listed by `GET api/2.0/files/rooms`.</param>
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
        /// Get private room access keys
        /// </summary>
        /// <remarks>
        /// Returns the encryption keys that give access to a private room: one entry per key held by each of its members,  which is what a client needs in order to encrypt a file key for everyone allowed to open the room's content.  Only the caller's own entries carry `privateKeyEnc`; another member's entry carries the public half alone, and  an entry with no public half is not reported as access at all. The room has to be a private one, a room  created without private mode holds no access keys and the call is refused, and it has to still exist: an  unknown room, or one already moved to Trash, is reported as missing, while an archived private room still  answers. Access follows room membership and not portal role: any member from read access upwards receives the  full set, whereas a DocSpace administrator who is not a member is refused, and so is a caller holding no key  of their own, the room creator included once they delete their last key. The call is read-only. For the keys  of a single file use `GET api/2.0/files/file/{fileId}/publickeys`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The private room whose access keys are read. Take it from the `id` of the room returned by  `POST api/2.0/files/rooms` or listed by `GET api/2.0/files/rooms`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-keys-for-room/">REST API Reference for GetUserKeysForRoom Operation</seealso>
        /// <returns>Task of EncryptionKeyArrayWrapper</returns>
        public async Task<EncryptionKeyArrayWrapper> GetUserKeysForRoomAsync(int roomId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetUserKeysForRoomWithHttpInfoAsync(roomId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get private room access keys
        /// </summary>
        /// <remarks>
        /// Returns the encryption keys that give access to a private room: one entry per key held by each of its members,  which is what a client needs in order to encrypt a file key for everyone allowed to open the room's content.  Only the caller's own entries carry `privateKeyEnc`; another member's entry carries the public half alone, and  an entry with no public half is not reported as access at all. The room has to be a private one, a room  created without private mode holds no access keys and the call is refused, and it has to still exist: an  unknown room, or one already moved to Trash, is reported as missing, while an archived private room still  answers. Access follows room membership and not portal role: any member from read access upwards receives the  full set, whereas a DocSpace administrator who is not a member is refused, and so is a caller holding no key  of their own, the room creator included once they delete their last key. The call is read-only. For the keys  of a single file use `GET api/2.0/files/file/{fileId}/publickeys`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The private room whose access keys are read. Take it from the `id` of the room returned by  `POST api/2.0/files/rooms` or listed by `GET api/2.0/files/rooms`.</param>
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
        /// Rotate an encryption key
        /// </summary>
        /// <remarks>
        /// Rotates one encryption key pair of the calling user: the entry whose `id` matches is overwritten with the  submitted `publicKey` and `privateKeyEnc`, and the caller's other pairs are left untouched. The pair has to  exist already, an `id` that is not in the caller's set is answered with 404, and a first key is created with  `POST api/2.0/privacyroom/keys`. This is a full replacement rather than a merge: both halves are mandatory,  and a request that omits or blanks one of them is rejected as invalid with the stored pair surviving  unchanged, so a rotation that means to keep the private half has to send it again. Omitting `id` targets the  all-zero pair, the one a client that never sets an id keeps rotating. Every authenticated member rotates their  own keys and only their own, and a guest is refused. The call is mutating, and repeating it with the same body  leaves the same state. It answers with every key the caller holds afterwards, and from then on  `GET api/2.0/privacyroom/{roomId}/access` reports the new public half for this member.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The two halves of an encryption key pair to store for the calling user, plus the identifier the pair is kept  under. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/replace-key/">REST API Reference for ReplaceKey Operation</seealso>
        /// <returns>EncryptionKeyArrayWrapper</returns>
        public EncryptionKeyArrayWrapper ReplaceKey(EncryptionKeyRequestDto? encryptionKeyRequestDto = default)
        {
            var localVarResponse = ReplaceKeyWithHttpInfo(encryptionKeyRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Rotate an encryption key
        /// </summary>
        /// <remarks>
        /// Rotates one encryption key pair of the calling user: the entry whose `id` matches is overwritten with the  submitted `publicKey` and `privateKeyEnc`, and the caller's other pairs are left untouched. The pair has to  exist already, an `id` that is not in the caller's set is answered with 404, and a first key is created with  `POST api/2.0/privacyroom/keys`. This is a full replacement rather than a merge: both halves are mandatory,  and a request that omits or blanks one of them is rejected as invalid with the stored pair surviving  unchanged, so a rotation that means to keep the private half has to send it again. Omitting `id` targets the  all-zero pair, the one a client that never sets an id keeps rotating. Every authenticated member rotates their  own keys and only their own, and a guest is refused. The call is mutating, and repeating it with the same body  leaves the same state. It answers with every key the caller holds afterwards, and from then on  `GET api/2.0/privacyroom/{roomId}/access` reports the new public half for this member.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The two halves of an encryption key pair to store for the calling user, plus the identifier the pair is kept  under. (optional)</param>
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
        /// Rotate an encryption key
        /// </summary>
        /// <remarks>
        /// Rotates one encryption key pair of the calling user: the entry whose `id` matches is overwritten with the  submitted `publicKey` and `privateKeyEnc`, and the caller's other pairs are left untouched. The pair has to  exist already, an `id` that is not in the caller's set is answered with 404, and a first key is created with  `POST api/2.0/privacyroom/keys`. This is a full replacement rather than a merge: both halves are mandatory,  and a request that omits or blanks one of them is rejected as invalid with the stored pair surviving  unchanged, so a rotation that means to keep the private half has to send it again. Omitting `id` targets the  all-zero pair, the one a client that never sets an id keeps rotating. Every authenticated member rotates their  own keys and only their own, and a guest is refused. The call is mutating, and repeating it with the same body  leaves the same state. It answers with every key the caller holds afterwards, and from then on  `GET api/2.0/privacyroom/{roomId}/access` reports the new public half for this member.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The two halves of an encryption key pair to store for the calling user, plus the identifier the pair is kept  under. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/replace-key/">REST API Reference for ReplaceKey Operation</seealso>
        /// <returns>Task of EncryptionKeyArrayWrapper</returns>
        public async Task<EncryptionKeyArrayWrapper> ReplaceKeyAsync(EncryptionKeyRequestDto? encryptionKeyRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ReplaceKeyWithHttpInfoAsync(encryptionKeyRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Rotate an encryption key
        /// </summary>
        /// <remarks>
        /// Rotates one encryption key pair of the calling user: the entry whose `id` matches is overwritten with the  submitted `publicKey` and `privateKeyEnc`, and the caller's other pairs are left untouched. The pair has to  exist already, an `id` that is not in the caller's set is answered with 404, and a first key is created with  `POST api/2.0/privacyroom/keys`. This is a full replacement rather than a merge: both halves are mandatory,  and a request that omits or blanks one of them is rejected as invalid with the stored pair surviving  unchanged, so a rotation that means to keep the private half has to send it again. Omitting `id` targets the  all-zero pair, the one a client that never sets an id keeps rotating. Every authenticated member rotates their  own keys and only their own, and a guest is refused. The call is mutating, and repeating it with the same body  leaves the same state. It answers with every key the caller holds afterwards, and from then on  `GET api/2.0/privacyroom/{roomId}/access` reports the new public half for this member.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The two halves of an encryption key pair to store for the calling user, plus the identifier the pair is kept  under. (optional)</param>
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
        /// Create an encryption key
        /// </summary>
        /// <remarks>
        /// Stores a new encryption key pair for the calling user and answers with that user's whole key set. The material  is end-to-end: `publicKey` is the half other members use to encrypt file keys for this user, while  `privateKeyEnc` arrives already encrypted with the user's own password, so the portal keeps it as opaque text.  A member must hold at least one key before they can be invited to a private room, which makes this the first  call of the private-room flow. Every authenticated member manages their own keys and only their own, there is  no parameter for somebody else's, and a guest is refused, which is also why a guest cannot become a member of  a private room. The call is mutating and is not safe to repeat: `id` names the pair inside the caller's set  and an `id` that is already stored is answered with 409, while a request that omits or blanks either half is  rejected as invalid and stores nothing. A successful call answers 201 with every key the caller now holds. To  change the material of an existing pair use `PUT api/2.0/privacyroom/keys`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The two halves of an encryption key pair to store for the calling user, plus the identifier the pair is kept  under. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-keys/">REST API Reference for SetKeys Operation</seealso>
        /// <returns>EncryptionKeyArrayWrapper</returns>
        public EncryptionKeyArrayWrapper SetKeys(EncryptionKeyRequestDto? encryptionKeyRequestDto = default)
        {
            var localVarResponse = SetKeysWithHttpInfo(encryptionKeyRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an encryption key
        /// </summary>
        /// <remarks>
        /// Stores a new encryption key pair for the calling user and answers with that user's whole key set. The material  is end-to-end: `publicKey` is the half other members use to encrypt file keys for this user, while  `privateKeyEnc` arrives already encrypted with the user's own password, so the portal keeps it as opaque text.  A member must hold at least one key before they can be invited to a private room, which makes this the first  call of the private-room flow. Every authenticated member manages their own keys and only their own, there is  no parameter for somebody else's, and a guest is refused, which is also why a guest cannot become a member of  a private room. The call is mutating and is not safe to repeat: `id` names the pair inside the caller's set  and an `id` that is already stored is answered with 409, while a request that omits or blanks either half is  rejected as invalid and stores nothing. A successful call answers 201 with every key the caller now holds. To  change the material of an existing pair use `PUT api/2.0/privacyroom/keys`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The two halves of an encryption key pair to store for the calling user, plus the identifier the pair is kept  under. (optional)</param>
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
        /// Create an encryption key
        /// </summary>
        /// <remarks>
        /// Stores a new encryption key pair for the calling user and answers with that user's whole key set. The material  is end-to-end: `publicKey` is the half other members use to encrypt file keys for this user, while  `privateKeyEnc` arrives already encrypted with the user's own password, so the portal keeps it as opaque text.  A member must hold at least one key before they can be invited to a private room, which makes this the first  call of the private-room flow. Every authenticated member manages their own keys and only their own, there is  no parameter for somebody else's, and a guest is refused, which is also why a guest cannot become a member of  a private room. The call is mutating and is not safe to repeat: `id` names the pair inside the caller's set  and an `id` that is already stored is answered with 409, while a request that omits or blanks either half is  rejected as invalid and stores nothing. A successful call answers 201 with every key the caller now holds. To  change the material of an existing pair use `PUT api/2.0/privacyroom/keys`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The two halves of an encryption key pair to store for the calling user, plus the identifier the pair is kept  under. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-keys/">REST API Reference for SetKeys Operation</seealso>
        /// <returns>Task of EncryptionKeyArrayWrapper</returns>
        public async Task<EncryptionKeyArrayWrapper> SetKeysAsync(EncryptionKeyRequestDto? encryptionKeyRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetKeysWithHttpInfoAsync(encryptionKeyRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an encryption key
        /// </summary>
        /// <remarks>
        /// Stores a new encryption key pair for the calling user and answers with that user's whole key set. The material  is end-to-end: `publicKey` is the half other members use to encrypt file keys for this user, while  `privateKeyEnc` arrives already encrypted with the user's own password, so the portal keeps it as opaque text.  A member must hold at least one key before they can be invited to a private room, which makes this the first  call of the private-room flow. Every authenticated member manages their own keys and only their own, there is  no parameter for somebody else's, and a guest is refused, which is also why a guest cannot become a member of  a private room. The call is mutating and is not safe to repeat: `id` names the pair inside the caller's set  and an `id` that is already stored is answered with 409, while a request that omits or blanks either half is  rejected as invalid and stores nothing. A successful call answers 201 with every key the caller now holds. To  change the material of an existing pair use `PUT api/2.0/privacyroom/keys`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyRequestDto">The two halves of an encryption key pair to store for the calling user, plus the identifier the pair is kept  under. (optional)</param>
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

    }
}
