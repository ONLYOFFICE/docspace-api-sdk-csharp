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
    public interface IStorageApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the backup storages
        /// </summary>
        /// <remarks>
        /// Returns the storages that can hold portal backups, with the one the saved backup schedule writes to marked as  `current` and its parameters filled in from that schedule; when no schedule is saved, or when the schedule  stores backups somewhere else than a third-party provider, none of the entries is current. Each entry has the  same shape as in `GET api/2.0/settings/storage`: identifier, title, the authentication keys the provider  expects, and `isSet` telling whether those keys are filled in on the server. Pass `dump=true` to read the  schedule of the whole server instead of the one of the current portal, which only makes sense on a server  installation. The caller needs the permission to edit portal settings, which in practice means the portal  owner or a DocSpace admin, and on an installation that is not a server one the call is also refused unless  backup is available there. Nothing is written and the call is safe to repeat. This operation says nothing  about where the portal data itself lives; the backup schedule is configured through the backup API, and the  storage of the documents through `PUT api/2.0/settings/storage`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dump">Whether the schedule of the whole server is read instead of the one of the current portal. It only changes  which schedule marks an entry as `current`; the list of storages itself is the same either way, and the flag  makes sense only on a self-hosted installation. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-backup-storages/">REST API Reference for GetAllBackupStorages Operation</seealso>
        /// <returns>StorageArrayWrapper</returns>
        StorageArrayWrapper GetAllBackupStorages(bool? dump = default);

        /// <summary>
        /// Get the backup storages
        /// </summary>
        /// <remarks>
        /// Returns the storages that can hold portal backups, with the one the saved backup schedule writes to marked as  `current` and its parameters filled in from that schedule; when no schedule is saved, or when the schedule  stores backups somewhere else than a third-party provider, none of the entries is current. Each entry has the  same shape as in `GET api/2.0/settings/storage`: identifier, title, the authentication keys the provider  expects, and `isSet` telling whether those keys are filled in on the server. Pass `dump=true` to read the  schedule of the whole server instead of the one of the current portal, which only makes sense on a server  installation. The caller needs the permission to edit portal settings, which in practice means the portal  owner or a DocSpace admin, and on an installation that is not a server one the call is also refused unless  backup is available there. Nothing is written and the call is safe to repeat. This operation says nothing  about where the portal data itself lives; the backup schedule is configured through the backup API, and the  storage of the documents through `PUT api/2.0/settings/storage`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dump">Whether the schedule of the whole server is read instead of the one of the current portal. It only changes  which schedule marks an entry as `current`; the list of storages itself is the same either way, and the flag  makes sense only on a self-hosted installation. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-backup-storages/">REST API Reference for GetAllBackupStorages Operation</seealso>
        /// <returns>ApiResponse of StorageArrayWrapper</returns>
        ApiResponse<StorageArrayWrapper> GetAllBackupStoragesWithHttpInfo(bool? dump = default);
        /// <summary>
        /// Get the CDN storages
        /// </summary>
        /// <remarks>
        /// Returns the storages that can serve the static content of the portal through a content delivery network, which  is the subset of the providers of `GET api/2.0/settings/storage` that offer a CDN of their own. The entries  have the same shape as in the storage listing: identifier and title, the authentication keys the provider  expects, `isSet` telling whether those keys are filled in on the server, and `current` marking the CDN the  portal uses now. Keys of the current entry come from the saved CDN settings and keys of the others from the  provider configuration. An empty list means the build ships no CDN-capable provider, and a list where nothing  is current means the portal serves its static content itself. The caller needs the permission to edit portal  settings, which in practice means the portal owner or a DocSpace admin, on a server installation with an  unrestricted access space. Nothing is written and the call is safe to repeat. Use  `PUT api/2.0/settings/storage/cdn` to select a CDN and `DELETE api/2.0/settings/storage/cdn` to stop using  one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-cdn-storages/">REST API Reference for GetAllCdnStorages Operation</seealso>
        /// <returns>StorageArrayWrapper</returns>
        StorageArrayWrapper GetAllCdnStorages();

        /// <summary>
        /// Get the CDN storages
        /// </summary>
        /// <remarks>
        /// Returns the storages that can serve the static content of the portal through a content delivery network, which  is the subset of the providers of `GET api/2.0/settings/storage` that offer a CDN of their own. The entries  have the same shape as in the storage listing: identifier and title, the authentication keys the provider  expects, `isSet` telling whether those keys are filled in on the server, and `current` marking the CDN the  portal uses now. Keys of the current entry come from the saved CDN settings and keys of the others from the  provider configuration. An empty list means the build ships no CDN-capable provider, and a list where nothing  is current means the portal serves its static content itself. The caller needs the permission to edit portal  settings, which in practice means the portal owner or a DocSpace admin, on a server installation with an  unrestricted access space. Nothing is written and the call is safe to repeat. Use  `PUT api/2.0/settings/storage/cdn` to select a CDN and `DELETE api/2.0/settings/storage/cdn` to stop using  one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-cdn-storages/">REST API Reference for GetAllCdnStorages Operation</seealso>
        /// <returns>ApiResponse of StorageArrayWrapper</returns>
        ApiResponse<StorageArrayWrapper> GetAllCdnStoragesWithHttpInfo();
        /// <summary>
        /// Get the portal storages
        /// </summary>
        /// <remarks>
        /// Returns the third-party storages the installation can keep portal data in, the providers the build ships with,  such as Amazon S3, Google Cloud Storage or Rackspace. The built-in local storage is not among them: when none  of the entries is `current`, the portal data sits in the local storage. Each entry carries the storage  identifier and title, the authentication keys the provider expects, `isSet` telling whether those keys are  already filled in on the server, and `current` marking the one the portal uses right now. Keys of the current  storage are read from the saved settings, keys of the others from the provider configuration, so a value that  was never configured comes back empty. The caller needs the permission to edit portal settings, which in  practice means the portal owner or a DocSpace admin, and the installation has to be a server one whose access  space is not restricted; otherwise the call is refused with 403. Nothing is written and the call is safe to  repeat. Use `PUT api/2.0/settings/storage` to switch the storage, `DELETE api/2.0/settings/storage` to go back  to the local one, and `GET api/2.0/settings/storage/cdn` or `GET api/2.0/settings/storage/backup` for the CDN  and backup targets.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-storages/">REST API Reference for GetAllStorages Operation</seealso>
        /// <returns>StorageArrayWrapper</returns>
        StorageArrayWrapper GetAllStorages();

        /// <summary>
        /// Get the portal storages
        /// </summary>
        /// <remarks>
        /// Returns the third-party storages the installation can keep portal data in, the providers the build ships with,  such as Amazon S3, Google Cloud Storage or Rackspace. The built-in local storage is not among them: when none  of the entries is `current`, the portal data sits in the local storage. Each entry carries the storage  identifier and title, the authentication keys the provider expects, `isSet` telling whether those keys are  already filled in on the server, and `current` marking the one the portal uses right now. Keys of the current  storage are read from the saved settings, keys of the others from the provider configuration, so a value that  was never configured comes back empty. The caller needs the permission to edit portal settings, which in  practice means the portal owner or a DocSpace admin, and the installation has to be a server one whose access  space is not restricted; otherwise the call is refused with 403. Nothing is written and the call is safe to  repeat. Use `PUT api/2.0/settings/storage` to switch the storage, `DELETE api/2.0/settings/storage` to go back  to the local one, and `GET api/2.0/settings/storage/cdn` or `GET api/2.0/settings/storage/backup` for the CDN  and backup targets.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-storages/">REST API Reference for GetAllStorages Operation</seealso>
        /// <returns>ApiResponse of StorageArrayWrapper</returns>
        ApiResponse<StorageArrayWrapper> GetAllStoragesWithHttpInfo();
        /// <summary>
        /// Get the Amazon S3 regions
        /// </summary>
        /// <remarks>
        /// Returns the Amazon regions the server knows about, each with its system name such as `eu-central-1`, the  display name to show a user, and the partition details the region belongs to: partition name, DNS suffix, the  pattern its region names match and the template its host names are built from. This is static reference data  compiled into the server rather than portal configuration: nothing is read from the settings, nothing is  written, the answer is the same for every portal and changes only when the server is updated, so it can be  cached by the caller. Use the system name of an entry as the region value in `props` when configuring an  Amazon S3 storage with `PUT api/2.0/settings/storage`, `PUT api/2.0/settings/storage/cdn` or a backup  schedule, and prefer picking a value from here over typing one, because a region the server does not know  cannot be reached. Any authenticated caller may read the list, no portal-settings permission is asked for, and  the result is neither paginated nor filtered.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-amazon-s3regions/">REST API Reference for GetAmazonS3Regions Operation</seealso>
        /// <returns>AmazonS3RegionArrayWrapper</returns>
        AmazonS3RegionArrayWrapper GetAmazonS3Regions();

        /// <summary>
        /// Get the Amazon S3 regions
        /// </summary>
        /// <remarks>
        /// Returns the Amazon regions the server knows about, each with its system name such as `eu-central-1`, the  display name to show a user, and the partition details the region belongs to: partition name, DNS suffix, the  pattern its region names match and the template its host names are built from. This is static reference data  compiled into the server rather than portal configuration: nothing is read from the settings, nothing is  written, the answer is the same for every portal and changes only when the server is updated, so it can be  cached by the caller. Use the system name of an entry as the region value in `props` when configuring an  Amazon S3 storage with `PUT api/2.0/settings/storage`, `PUT api/2.0/settings/storage/cdn` or a backup  schedule, and prefer picking a value from here over typing one, because a region the server does not know  cannot be reached. Any authenticated caller may read the list, no portal-settings permission is asked for, and  the result is neither paginated nor filtered.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-amazon-s3regions/">REST API Reference for GetAmazonS3Regions Operation</seealso>
        /// <returns>ApiResponse of AmazonS3RegionArrayWrapper</returns>
        ApiResponse<AmazonS3RegionArrayWrapper> GetAmazonS3RegionsWithHttpInfo();
        /// <summary>
        /// Get the storage migration progress
        /// </summary>
        /// <remarks>
        /// Returns how far the current portal has got in moving its data to another storage, as a percentage from 0 to  100. The migration itself is started by `PUT api/2.0/settings/storage` or `DELETE api/2.0/settings/storage`,  which put the portal into the migrating state; poll this operation until the value reaches 100, then the  portal is served from the new storage. A value of -1 means storage migration is not offered on this  installation, which is the case for every portal that is not a server one. Ask for the progress only once a  migration has actually been started: for a portal whose migration the server does not remember, the call fails  instead of answering with a zero. The response carries the percentage only, without the error flag the  migration service reports internally, so a value that stops advancing is a reason to check the portal state  with `GET api/2.0/portal` rather than proof of progress. The caller needs the permission to edit portal  settings, which in practice means the portal owner or a DocSpace admin, and the call is accepted even when the  portal payment has lapsed. Nothing is written and the call is safe to repeat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-progress/">REST API Reference for GetStorageProgress Operation</seealso>
        /// <returns>DoubleWrapper</returns>
        DoubleWrapper GetStorageProgress();

        /// <summary>
        /// Get the storage migration progress
        /// </summary>
        /// <remarks>
        /// Returns how far the current portal has got in moving its data to another storage, as a percentage from 0 to  100. The migration itself is started by `PUT api/2.0/settings/storage` or `DELETE api/2.0/settings/storage`,  which put the portal into the migrating state; poll this operation until the value reaches 100, then the  portal is served from the new storage. A value of -1 means storage migration is not offered on this  installation, which is the case for every portal that is not a server one. Ask for the progress only once a  migration has actually been started: for a portal whose migration the server does not remember, the call fails  instead of answering with a zero. The response carries the percentage only, without the error flag the  migration service reports internally, so a value that stops advancing is a reason to check the portal state  with `GET api/2.0/portal` rather than proof of progress. The caller needs the permission to edit portal  settings, which in practice means the portal owner or a DocSpace admin, and the call is accepted even when the  portal payment has lapsed. Nothing is written and the call is safe to repeat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-progress/">REST API Reference for GetStorageProgress Operation</seealso>
        /// <returns>ApiResponse of DoubleWrapper</returns>
        ApiResponse<DoubleWrapper> GetStorageProgressWithHttpInfo();
        /// <summary>
        /// Reset the CDN storage settings
        /// </summary>
        /// <remarks>
        /// Drops the CDN configuration of the current portal, module and saved credentials alike, so that the static  content is served by the portal itself again. Nothing is uploaded or migrated, no state change is queued and  the call gives back no body: only the settings are cleared, and files already copied to the content delivery  network are left where they are, to be removed in the provider's own console if that is wanted. The change  takes effect for links built after it, so a page that is already open may keep pointing at the CDN until it is  reloaded. Repeating the call is harmless, because clearing an empty configuration does nothing. The caller  needs the permission to edit portal settings, which in practice means the portal owner or a DocSpace admin, on  a server installation with an unrestricted access space. Use `GET api/2.0/settings/storage/cdn` to see what is  configured now and `PUT api/2.0/settings/storage/cdn` to select a CDN again; the portal storage of the  documents is untouched by this operation and is reset with `DELETE api/2.0/settings/storage` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-cdn-to-default/">REST API Reference for ResetCdnToDefault Operation</seealso>
        /// <returns></returns>
        void ResetCdnToDefault();

        /// <summary>
        /// Reset the CDN storage settings
        /// </summary>
        /// <remarks>
        /// Drops the CDN configuration of the current portal, module and saved credentials alike, so that the static  content is served by the portal itself again. Nothing is uploaded or migrated, no state change is queued and  the call gives back no body: only the settings are cleared, and files already copied to the content delivery  network are left where they are, to be removed in the provider's own console if that is wanted. The change  takes effect for links built after it, so a page that is already open may keep pointing at the CDN until it is  reloaded. Repeating the call is harmless, because clearing an empty configuration does nothing. The caller  needs the permission to edit portal settings, which in practice means the portal owner or a DocSpace admin, on  a server installation with an unrestricted access space. Use `GET api/2.0/settings/storage/cdn` to see what is  configured now and `PUT api/2.0/settings/storage/cdn` to select a CDN again; the portal storage of the  documents is untouched by this operation and is reset with `DELETE api/2.0/settings/storage` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-cdn-to-default/">REST API Reference for ResetCdnToDefault Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ResetCdnToDefaultWithHttpInfo();
        /// <summary>
        /// Reset the storage settings
        /// </summary>
        /// <remarks>
        /// Drops the third-party storage configuration of the current portal, module and saved credentials alike, and  starts an asynchronous migration of the portal data back into the built-in local storage. The portal moves  into the migrating state and stays unavailable until the transfer ends, so follow it with  `GET api/2.0/settings/storage/progress`; the call itself returns as soon as the migration has been handed to  the storage service and gives back no body. The caller needs the permission to edit portal settings, which in  practice means the portal owner or a DocSpace admin, on a server installation with an unrestricted access  space. This is a mutating and slow operation rather than a destructive one: documents are copied back rather  than deleted, but the credentials of the previous storage are gone from the settings and have to be sent again  with `PUT api/2.0/settings/storage` to switch back. Repeating the call while a migration is running starts  another one, so poll instead. Resetting the storage is also the step that makes  `POST api/2.0/settings/encryption/start` possible, since encryption only covers the local storage.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-storage-to-default/">REST API Reference for ResetStorageToDefault Operation</seealso>
        /// <returns></returns>
        void ResetStorageToDefault();

        /// <summary>
        /// Reset the storage settings
        /// </summary>
        /// <remarks>
        /// Drops the third-party storage configuration of the current portal, module and saved credentials alike, and  starts an asynchronous migration of the portal data back into the built-in local storage. The portal moves  into the migrating state and stays unavailable until the transfer ends, so follow it with  `GET api/2.0/settings/storage/progress`; the call itself returns as soon as the migration has been handed to  the storage service and gives back no body. The caller needs the permission to edit portal settings, which in  practice means the portal owner or a DocSpace admin, on a server installation with an unrestricted access  space. This is a mutating and slow operation rather than a destructive one: documents are copied back rather  than deleted, but the credentials of the previous storage are gone from the settings and have to be sent again  with `PUT api/2.0/settings/storage` to switch back. Repeating the call while a migration is running starts  another one, so poll instead. Resetting the storage is also the step that makes  `POST api/2.0/settings/encryption/start` possible, since encryption only covers the local storage.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-storage-to-default/">REST API Reference for ResetStorageToDefault Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ResetStorageToDefaultWithHttpInfo();
        /// <summary>
        /// Update the CDN storage
        /// </summary>
        /// <remarks>
        /// Selects the content delivery network that serves the static content of the portal and saves the credentials it  needs: `module` is the identifier of one of the entries of `GET api/2.0/settings/storage/cdn`, and `props`  carries that provider's authentication keys as name and value pairs. The provider has to be available on the  server, which the `isSet` flag of the listing tells, otherwise the request is rejected as invalid. Sending the  module the portal already uses changes nothing and returns the saved settings as they are. Any other module is  saved and the upload of the static content is handed to the storage service; the settings come back only when  that hand-over succeeds, a failure being reported as a server error. Unlike the portal storage this has no  progress operation, so there is nothing to poll: the content appears on the CDN once the service has copied  it. Only static content is affected here, never documents; for those use `PUT api/2.0/settings/storage`. The  caller needs the permission to edit portal settings, which in practice means the portal owner or a DocSpace  admin, on a server installation with an unrestricted access space. The response is the stored CDN  configuration.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageRequestsDto">Which storage provider the portal is pointed at, and the credentials it needs. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-cdn-storage/">REST API Reference for UpdateCdnStorage Operation</seealso>
        /// <returns>CdnStorageSettingsWrapper</returns>
        CdnStorageSettingsWrapper UpdateCdnStorage(StorageRequestsDto? storageRequestsDto = default);

        /// <summary>
        /// Update the CDN storage
        /// </summary>
        /// <remarks>
        /// Selects the content delivery network that serves the static content of the portal and saves the credentials it  needs: `module` is the identifier of one of the entries of `GET api/2.0/settings/storage/cdn`, and `props`  carries that provider's authentication keys as name and value pairs. The provider has to be available on the  server, which the `isSet` flag of the listing tells, otherwise the request is rejected as invalid. Sending the  module the portal already uses changes nothing and returns the saved settings as they are. Any other module is  saved and the upload of the static content is handed to the storage service; the settings come back only when  that hand-over succeeds, a failure being reported as a server error. Unlike the portal storage this has no  progress operation, so there is nothing to poll: the content appears on the CDN once the service has copied  it. Only static content is affected here, never documents; for those use `PUT api/2.0/settings/storage`. The  caller needs the permission to edit portal settings, which in practice means the portal owner or a DocSpace  admin, on a server installation with an unrestricted access space. The response is the stored CDN  configuration.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageRequestsDto">Which storage provider the portal is pointed at, and the credentials it needs. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-cdn-storage/">REST API Reference for UpdateCdnStorage Operation</seealso>
        /// <returns>ApiResponse of CdnStorageSettingsWrapper</returns>
        ApiResponse<CdnStorageSettingsWrapper> UpdateCdnStorageWithHttpInfo(StorageRequestsDto? storageRequestsDto = default);
        /// <summary>
        /// Switch the portal storage
        /// </summary>
        /// <remarks>
        /// Points the current portal at another storage and saves the credentials it needs: `module` is the identifier of  one of the storages listed by `GET api/2.0/settings/storage`, and `props` carries that provider's  authentication keys as name and value pairs, for example the bucket, region and access key of an Amazon S3  storage. The provider has to be available on the server, which the `isSet` flag of the listing tells,  otherwise the request is rejected as invalid. Sending the module the portal already uses changes nothing and  returns the saved settings as they are. Any other module starts an asynchronous migration of the portal data:  the portal moves into the migrating state and stays unavailable until the transfer ends, so follow it with  `GET api/2.0/settings/storage/progress` and do not send a second switch while it runs. The caller needs the  permission to edit portal settings, which in practice means the portal owner or a DocSpace admin, on a server  installation with an unrestricted access space. The response is the stored configuration, module and  properties, not the state of the migration. To return to the built-in local storage call  `DELETE api/2.0/settings/storage`, and for the CDN use `PUT api/2.0/settings/storage/cdn`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageRequestsDto">Which storage provider the portal is pointed at, and the credentials it needs. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-storage/">REST API Reference for UpdateStorage Operation</seealso>
        /// <returns>StorageSettingsWrapper</returns>
        StorageSettingsWrapper UpdateStorage(StorageRequestsDto? storageRequestsDto = default);

        /// <summary>
        /// Switch the portal storage
        /// </summary>
        /// <remarks>
        /// Points the current portal at another storage and saves the credentials it needs: `module` is the identifier of  one of the storages listed by `GET api/2.0/settings/storage`, and `props` carries that provider's  authentication keys as name and value pairs, for example the bucket, region and access key of an Amazon S3  storage. The provider has to be available on the server, which the `isSet` flag of the listing tells,  otherwise the request is rejected as invalid. Sending the module the portal already uses changes nothing and  returns the saved settings as they are. Any other module starts an asynchronous migration of the portal data:  the portal moves into the migrating state and stays unavailable until the transfer ends, so follow it with  `GET api/2.0/settings/storage/progress` and do not send a second switch while it runs. The caller needs the  permission to edit portal settings, which in practice means the portal owner or a DocSpace admin, on a server  installation with an unrestricted access space. The response is the stored configuration, module and  properties, not the state of the migration. To return to the built-in local storage call  `DELETE api/2.0/settings/storage`, and for the CDN use `PUT api/2.0/settings/storage/cdn`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageRequestsDto">Which storage provider the portal is pointed at, and the credentials it needs. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-storage/">REST API Reference for UpdateStorage Operation</seealso>
        /// <returns>ApiResponse of StorageSettingsWrapper</returns>
        ApiResponse<StorageSettingsWrapper> UpdateStorageWithHttpInfo(StorageRequestsDto? storageRequestsDto = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStorageApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get the backup storages
        /// </summary>
        /// <remarks>
        /// Returns the storages that can hold portal backups, with the one the saved backup schedule writes to marked as  `current` and its parameters filled in from that schedule; when no schedule is saved, or when the schedule  stores backups somewhere else than a third-party provider, none of the entries is current. Each entry has the  same shape as in `GET api/2.0/settings/storage`: identifier, title, the authentication keys the provider  expects, and `isSet` telling whether those keys are filled in on the server. Pass `dump=true` to read the  schedule of the whole server instead of the one of the current portal, which only makes sense on a server  installation. The caller needs the permission to edit portal settings, which in practice means the portal  owner or a DocSpace admin, and on an installation that is not a server one the call is also refused unless  backup is available there. Nothing is written and the call is safe to repeat. This operation says nothing  about where the portal data itself lives; the backup schedule is configured through the backup API, and the  storage of the documents through `PUT api/2.0/settings/storage`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dump">Whether the schedule of the whole server is read instead of the one of the current portal. It only changes  which schedule marks an entry as `current`; the list of storages itself is the same either way, and the flag  makes sense only on a self-hosted installation. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-backup-storages/">REST API Reference for GetAllBackupStorages Operation</seealso>
        /// <returns>Task of StorageArrayWrapper</returns>
        Task<StorageArrayWrapper> GetAllBackupStoragesAsync(bool? dump = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the backup storages
        /// </summary>
        /// <remarks>
        /// Returns the storages that can hold portal backups, with the one the saved backup schedule writes to marked as  `current` and its parameters filled in from that schedule; when no schedule is saved, or when the schedule  stores backups somewhere else than a third-party provider, none of the entries is current. Each entry has the  same shape as in `GET api/2.0/settings/storage`: identifier, title, the authentication keys the provider  expects, and `isSet` telling whether those keys are filled in on the server. Pass `dump=true` to read the  schedule of the whole server instead of the one of the current portal, which only makes sense on a server  installation. The caller needs the permission to edit portal settings, which in practice means the portal  owner or a DocSpace admin, and on an installation that is not a server one the call is also refused unless  backup is available there. Nothing is written and the call is safe to repeat. This operation says nothing  about where the portal data itself lives; the backup schedule is configured through the backup API, and the  storage of the documents through `PUT api/2.0/settings/storage`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dump">Whether the schedule of the whole server is read instead of the one of the current portal. It only changes  which schedule marks an entry as `current`; the list of storages itself is the same either way, and the flag  makes sense only on a self-hosted installation. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-backup-storages/">REST API Reference for GetAllBackupStorages Operation</seealso>
        /// <returns>Task of ApiResponse (StorageArrayWrapper)</returns>
        Task<ApiResponse<StorageArrayWrapper>> GetAllBackupStoragesWithHttpInfoAsync(bool? dump = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the CDN storages
        /// </summary>
        /// <remarks>
        /// Returns the storages that can serve the static content of the portal through a content delivery network, which  is the subset of the providers of `GET api/2.0/settings/storage` that offer a CDN of their own. The entries  have the same shape as in the storage listing: identifier and title, the authentication keys the provider  expects, `isSet` telling whether those keys are filled in on the server, and `current` marking the CDN the  portal uses now. Keys of the current entry come from the saved CDN settings and keys of the others from the  provider configuration. An empty list means the build ships no CDN-capable provider, and a list where nothing  is current means the portal serves its static content itself. The caller needs the permission to edit portal  settings, which in practice means the portal owner or a DocSpace admin, on a server installation with an  unrestricted access space. Nothing is written and the call is safe to repeat. Use  `PUT api/2.0/settings/storage/cdn` to select a CDN and `DELETE api/2.0/settings/storage/cdn` to stop using  one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-cdn-storages/">REST API Reference for GetAllCdnStorages Operation</seealso>
        /// <returns>Task of StorageArrayWrapper</returns>
        Task<StorageArrayWrapper> GetAllCdnStoragesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the CDN storages
        /// </summary>
        /// <remarks>
        /// Returns the storages that can serve the static content of the portal through a content delivery network, which  is the subset of the providers of `GET api/2.0/settings/storage` that offer a CDN of their own. The entries  have the same shape as in the storage listing: identifier and title, the authentication keys the provider  expects, `isSet` telling whether those keys are filled in on the server, and `current` marking the CDN the  portal uses now. Keys of the current entry come from the saved CDN settings and keys of the others from the  provider configuration. An empty list means the build ships no CDN-capable provider, and a list where nothing  is current means the portal serves its static content itself. The caller needs the permission to edit portal  settings, which in practice means the portal owner or a DocSpace admin, on a server installation with an  unrestricted access space. Nothing is written and the call is safe to repeat. Use  `PUT api/2.0/settings/storage/cdn` to select a CDN and `DELETE api/2.0/settings/storage/cdn` to stop using  one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-cdn-storages/">REST API Reference for GetAllCdnStorages Operation</seealso>
        /// <returns>Task of ApiResponse (StorageArrayWrapper)</returns>
        Task<ApiResponse<StorageArrayWrapper>> GetAllCdnStoragesWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the portal storages
        /// </summary>
        /// <remarks>
        /// Returns the third-party storages the installation can keep portal data in, the providers the build ships with,  such as Amazon S3, Google Cloud Storage or Rackspace. The built-in local storage is not among them: when none  of the entries is `current`, the portal data sits in the local storage. Each entry carries the storage  identifier and title, the authentication keys the provider expects, `isSet` telling whether those keys are  already filled in on the server, and `current` marking the one the portal uses right now. Keys of the current  storage are read from the saved settings, keys of the others from the provider configuration, so a value that  was never configured comes back empty. The caller needs the permission to edit portal settings, which in  practice means the portal owner or a DocSpace admin, and the installation has to be a server one whose access  space is not restricted; otherwise the call is refused with 403. Nothing is written and the call is safe to  repeat. Use `PUT api/2.0/settings/storage` to switch the storage, `DELETE api/2.0/settings/storage` to go back  to the local one, and `GET api/2.0/settings/storage/cdn` or `GET api/2.0/settings/storage/backup` for the CDN  and backup targets.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-storages/">REST API Reference for GetAllStorages Operation</seealso>
        /// <returns>Task of StorageArrayWrapper</returns>
        Task<StorageArrayWrapper> GetAllStoragesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the portal storages
        /// </summary>
        /// <remarks>
        /// Returns the third-party storages the installation can keep portal data in, the providers the build ships with,  such as Amazon S3, Google Cloud Storage or Rackspace. The built-in local storage is not among them: when none  of the entries is `current`, the portal data sits in the local storage. Each entry carries the storage  identifier and title, the authentication keys the provider expects, `isSet` telling whether those keys are  already filled in on the server, and `current` marking the one the portal uses right now. Keys of the current  storage are read from the saved settings, keys of the others from the provider configuration, so a value that  was never configured comes back empty. The caller needs the permission to edit portal settings, which in  practice means the portal owner or a DocSpace admin, and the installation has to be a server one whose access  space is not restricted; otherwise the call is refused with 403. Nothing is written and the call is safe to  repeat. Use `PUT api/2.0/settings/storage` to switch the storage, `DELETE api/2.0/settings/storage` to go back  to the local one, and `GET api/2.0/settings/storage/cdn` or `GET api/2.0/settings/storage/backup` for the CDN  and backup targets.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-storages/">REST API Reference for GetAllStorages Operation</seealso>
        /// <returns>Task of ApiResponse (StorageArrayWrapper)</returns>
        Task<ApiResponse<StorageArrayWrapper>> GetAllStoragesWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the Amazon S3 regions
        /// </summary>
        /// <remarks>
        /// Returns the Amazon regions the server knows about, each with its system name such as `eu-central-1`, the  display name to show a user, and the partition details the region belongs to: partition name, DNS suffix, the  pattern its region names match and the template its host names are built from. This is static reference data  compiled into the server rather than portal configuration: nothing is read from the settings, nothing is  written, the answer is the same for every portal and changes only when the server is updated, so it can be  cached by the caller. Use the system name of an entry as the region value in `props` when configuring an  Amazon S3 storage with `PUT api/2.0/settings/storage`, `PUT api/2.0/settings/storage/cdn` or a backup  schedule, and prefer picking a value from here over typing one, because a region the server does not know  cannot be reached. Any authenticated caller may read the list, no portal-settings permission is asked for, and  the result is neither paginated nor filtered.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-amazon-s3regions/">REST API Reference for GetAmazonS3Regions Operation</seealso>
        /// <returns>Task of AmazonS3RegionArrayWrapper</returns>
        Task<AmazonS3RegionArrayWrapper> GetAmazonS3RegionsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the Amazon S3 regions
        /// </summary>
        /// <remarks>
        /// Returns the Amazon regions the server knows about, each with its system name such as `eu-central-1`, the  display name to show a user, and the partition details the region belongs to: partition name, DNS suffix, the  pattern its region names match and the template its host names are built from. This is static reference data  compiled into the server rather than portal configuration: nothing is read from the settings, nothing is  written, the answer is the same for every portal and changes only when the server is updated, so it can be  cached by the caller. Use the system name of an entry as the region value in `props` when configuring an  Amazon S3 storage with `PUT api/2.0/settings/storage`, `PUT api/2.0/settings/storage/cdn` or a backup  schedule, and prefer picking a value from here over typing one, because a region the server does not know  cannot be reached. Any authenticated caller may read the list, no portal-settings permission is asked for, and  the result is neither paginated nor filtered.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-amazon-s3regions/">REST API Reference for GetAmazonS3Regions Operation</seealso>
        /// <returns>Task of ApiResponse (AmazonS3RegionArrayWrapper)</returns>
        Task<ApiResponse<AmazonS3RegionArrayWrapper>> GetAmazonS3RegionsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the storage migration progress
        /// </summary>
        /// <remarks>
        /// Returns how far the current portal has got in moving its data to another storage, as a percentage from 0 to  100. The migration itself is started by `PUT api/2.0/settings/storage` or `DELETE api/2.0/settings/storage`,  which put the portal into the migrating state; poll this operation until the value reaches 100, then the  portal is served from the new storage. A value of -1 means storage migration is not offered on this  installation, which is the case for every portal that is not a server one. Ask for the progress only once a  migration has actually been started: for a portal whose migration the server does not remember, the call fails  instead of answering with a zero. The response carries the percentage only, without the error flag the  migration service reports internally, so a value that stops advancing is a reason to check the portal state  with `GET api/2.0/portal` rather than proof of progress. The caller needs the permission to edit portal  settings, which in practice means the portal owner or a DocSpace admin, and the call is accepted even when the  portal payment has lapsed. Nothing is written and the call is safe to repeat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-progress/">REST API Reference for GetStorageProgress Operation</seealso>
        /// <returns>Task of DoubleWrapper</returns>
        Task<DoubleWrapper> GetStorageProgressAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the storage migration progress
        /// </summary>
        /// <remarks>
        /// Returns how far the current portal has got in moving its data to another storage, as a percentage from 0 to  100. The migration itself is started by `PUT api/2.0/settings/storage` or `DELETE api/2.0/settings/storage`,  which put the portal into the migrating state; poll this operation until the value reaches 100, then the  portal is served from the new storage. A value of -1 means storage migration is not offered on this  installation, which is the case for every portal that is not a server one. Ask for the progress only once a  migration has actually been started: for a portal whose migration the server does not remember, the call fails  instead of answering with a zero. The response carries the percentage only, without the error flag the  migration service reports internally, so a value that stops advancing is a reason to check the portal state  with `GET api/2.0/portal` rather than proof of progress. The caller needs the permission to edit portal  settings, which in practice means the portal owner or a DocSpace admin, and the call is accepted even when the  portal payment has lapsed. Nothing is written and the call is safe to repeat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-progress/">REST API Reference for GetStorageProgress Operation</seealso>
        /// <returns>Task of ApiResponse (DoubleWrapper)</returns>
        Task<ApiResponse<DoubleWrapper>> GetStorageProgressWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Reset the CDN storage settings
        /// </summary>
        /// <remarks>
        /// Drops the CDN configuration of the current portal, module and saved credentials alike, so that the static  content is served by the portal itself again. Nothing is uploaded or migrated, no state change is queued and  the call gives back no body: only the settings are cleared, and files already copied to the content delivery  network are left where they are, to be removed in the provider's own console if that is wanted. The change  takes effect for links built after it, so a page that is already open may keep pointing at the CDN until it is  reloaded. Repeating the call is harmless, because clearing an empty configuration does nothing. The caller  needs the permission to edit portal settings, which in practice means the portal owner or a DocSpace admin, on  a server installation with an unrestricted access space. Use `GET api/2.0/settings/storage/cdn` to see what is  configured now and `PUT api/2.0/settings/storage/cdn` to select a CDN again; the portal storage of the  documents is untouched by this operation and is reset with `DELETE api/2.0/settings/storage` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-cdn-to-default/">REST API Reference for ResetCdnToDefault Operation</seealso>
        /// <returns>Task of void</returns>
        Task ResetCdnToDefaultAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Reset the CDN storage settings
        /// </summary>
        /// <remarks>
        /// Drops the CDN configuration of the current portal, module and saved credentials alike, so that the static  content is served by the portal itself again. Nothing is uploaded or migrated, no state change is queued and  the call gives back no body: only the settings are cleared, and files already copied to the content delivery  network are left where they are, to be removed in the provider's own console if that is wanted. The change  takes effect for links built after it, so a page that is already open may keep pointing at the CDN until it is  reloaded. Repeating the call is harmless, because clearing an empty configuration does nothing. The caller  needs the permission to edit portal settings, which in practice means the portal owner or a DocSpace admin, on  a server installation with an unrestricted access space. Use `GET api/2.0/settings/storage/cdn` to see what is  configured now and `PUT api/2.0/settings/storage/cdn` to select a CDN again; the portal storage of the  documents is untouched by this operation and is reset with `DELETE api/2.0/settings/storage` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-cdn-to-default/">REST API Reference for ResetCdnToDefault Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> ResetCdnToDefaultWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Reset the storage settings
        /// </summary>
        /// <remarks>
        /// Drops the third-party storage configuration of the current portal, module and saved credentials alike, and  starts an asynchronous migration of the portal data back into the built-in local storage. The portal moves  into the migrating state and stays unavailable until the transfer ends, so follow it with  `GET api/2.0/settings/storage/progress`; the call itself returns as soon as the migration has been handed to  the storage service and gives back no body. The caller needs the permission to edit portal settings, which in  practice means the portal owner or a DocSpace admin, on a server installation with an unrestricted access  space. This is a mutating and slow operation rather than a destructive one: documents are copied back rather  than deleted, but the credentials of the previous storage are gone from the settings and have to be sent again  with `PUT api/2.0/settings/storage` to switch back. Repeating the call while a migration is running starts  another one, so poll instead. Resetting the storage is also the step that makes  `POST api/2.0/settings/encryption/start` possible, since encryption only covers the local storage.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-storage-to-default/">REST API Reference for ResetStorageToDefault Operation</seealso>
        /// <returns>Task of void</returns>
        Task ResetStorageToDefaultAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Reset the storage settings
        /// </summary>
        /// <remarks>
        /// Drops the third-party storage configuration of the current portal, module and saved credentials alike, and  starts an asynchronous migration of the portal data back into the built-in local storage. The portal moves  into the migrating state and stays unavailable until the transfer ends, so follow it with  `GET api/2.0/settings/storage/progress`; the call itself returns as soon as the migration has been handed to  the storage service and gives back no body. The caller needs the permission to edit portal settings, which in  practice means the portal owner or a DocSpace admin, on a server installation with an unrestricted access  space. This is a mutating and slow operation rather than a destructive one: documents are copied back rather  than deleted, but the credentials of the previous storage are gone from the settings and have to be sent again  with `PUT api/2.0/settings/storage` to switch back. Repeating the call while a migration is running starts  another one, so poll instead. Resetting the storage is also the step that makes  `POST api/2.0/settings/encryption/start` possible, since encryption only covers the local storage.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-storage-to-default/">REST API Reference for ResetStorageToDefault Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> ResetStorageToDefaultWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the CDN storage
        /// </summary>
        /// <remarks>
        /// Selects the content delivery network that serves the static content of the portal and saves the credentials it  needs: `module` is the identifier of one of the entries of `GET api/2.0/settings/storage/cdn`, and `props`  carries that provider's authentication keys as name and value pairs. The provider has to be available on the  server, which the `isSet` flag of the listing tells, otherwise the request is rejected as invalid. Sending the  module the portal already uses changes nothing and returns the saved settings as they are. Any other module is  saved and the upload of the static content is handed to the storage service; the settings come back only when  that hand-over succeeds, a failure being reported as a server error. Unlike the portal storage this has no  progress operation, so there is nothing to poll: the content appears on the CDN once the service has copied  it. Only static content is affected here, never documents; for those use `PUT api/2.0/settings/storage`. The  caller needs the permission to edit portal settings, which in practice means the portal owner or a DocSpace  admin, on a server installation with an unrestricted access space. The response is the stored CDN  configuration.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageRequestsDto">Which storage provider the portal is pointed at, and the credentials it needs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-cdn-storage/">REST API Reference for UpdateCdnStorage Operation</seealso>
        /// <returns>Task of CdnStorageSettingsWrapper</returns>
        Task<CdnStorageSettingsWrapper> UpdateCdnStorageAsync(StorageRequestsDto? storageRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update the CDN storage
        /// </summary>
        /// <remarks>
        /// Selects the content delivery network that serves the static content of the portal and saves the credentials it  needs: `module` is the identifier of one of the entries of `GET api/2.0/settings/storage/cdn`, and `props`  carries that provider's authentication keys as name and value pairs. The provider has to be available on the  server, which the `isSet` flag of the listing tells, otherwise the request is rejected as invalid. Sending the  module the portal already uses changes nothing and returns the saved settings as they are. Any other module is  saved and the upload of the static content is handed to the storage service; the settings come back only when  that hand-over succeeds, a failure being reported as a server error. Unlike the portal storage this has no  progress operation, so there is nothing to poll: the content appears on the CDN once the service has copied  it. Only static content is affected here, never documents; for those use `PUT api/2.0/settings/storage`. The  caller needs the permission to edit portal settings, which in practice means the portal owner or a DocSpace  admin, on a server installation with an unrestricted access space. The response is the stored CDN  configuration.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageRequestsDto">Which storage provider the portal is pointed at, and the credentials it needs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-cdn-storage/">REST API Reference for UpdateCdnStorage Operation</seealso>
        /// <returns>Task of ApiResponse (CdnStorageSettingsWrapper)</returns>
        Task<ApiResponse<CdnStorageSettingsWrapper>> UpdateCdnStorageWithHttpInfoAsync(StorageRequestsDto? storageRequestsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Switch the portal storage
        /// </summary>
        /// <remarks>
        /// Points the current portal at another storage and saves the credentials it needs: `module` is the identifier of  one of the storages listed by `GET api/2.0/settings/storage`, and `props` carries that provider's  authentication keys as name and value pairs, for example the bucket, region and access key of an Amazon S3  storage. The provider has to be available on the server, which the `isSet` flag of the listing tells,  otherwise the request is rejected as invalid. Sending the module the portal already uses changes nothing and  returns the saved settings as they are. Any other module starts an asynchronous migration of the portal data:  the portal moves into the migrating state and stays unavailable until the transfer ends, so follow it with  `GET api/2.0/settings/storage/progress` and do not send a second switch while it runs. The caller needs the  permission to edit portal settings, which in practice means the portal owner or a DocSpace admin, on a server  installation with an unrestricted access space. The response is the stored configuration, module and  properties, not the state of the migration. To return to the built-in local storage call  `DELETE api/2.0/settings/storage`, and for the CDN use `PUT api/2.0/settings/storage/cdn`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageRequestsDto">Which storage provider the portal is pointed at, and the credentials it needs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-storage/">REST API Reference for UpdateStorage Operation</seealso>
        /// <returns>Task of StorageSettingsWrapper</returns>
        Task<StorageSettingsWrapper> UpdateStorageAsync(StorageRequestsDto? storageRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Switch the portal storage
        /// </summary>
        /// <remarks>
        /// Points the current portal at another storage and saves the credentials it needs: `module` is the identifier of  one of the storages listed by `GET api/2.0/settings/storage`, and `props` carries that provider's  authentication keys as name and value pairs, for example the bucket, region and access key of an Amazon S3  storage. The provider has to be available on the server, which the `isSet` flag of the listing tells,  otherwise the request is rejected as invalid. Sending the module the portal already uses changes nothing and  returns the saved settings as they are. Any other module starts an asynchronous migration of the portal data:  the portal moves into the migrating state and stays unavailable until the transfer ends, so follow it with  `GET api/2.0/settings/storage/progress` and do not send a second switch while it runs. The caller needs the  permission to edit portal settings, which in practice means the portal owner or a DocSpace admin, on a server  installation with an unrestricted access space. The response is the stored configuration, module and  properties, not the state of the migration. To return to the built-in local storage call  `DELETE api/2.0/settings/storage`, and for the CDN use `PUT api/2.0/settings/storage/cdn`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageRequestsDto">Which storage provider the portal is pointed at, and the credentials it needs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-storage/">REST API Reference for UpdateStorage Operation</seealso>
        /// <returns>Task of ApiResponse (StorageSettingsWrapper)</returns>
        Task<ApiResponse<StorageSettingsWrapper>> UpdateStorageWithHttpInfoAsync(StorageRequestsDto? storageRequestsDto = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStorageApi : IStorageApiSync, IStorageApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StorageApi : IDisposable, IStorageApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public StorageApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public StorageApi(string basePath)
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
        /// Initializes a new instance of the <see cref="StorageApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public StorageApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="StorageApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public StorageApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageApi"/> class.
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
        public StorageApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="StorageApi"/> class using a Configuration object.
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
        public StorageApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="StorageApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public StorageApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Get the backup storages
        /// </summary>
        /// <remarks>
        /// Returns the storages that can hold portal backups, with the one the saved backup schedule writes to marked as  `current` and its parameters filled in from that schedule; when no schedule is saved, or when the schedule  stores backups somewhere else than a third-party provider, none of the entries is current. Each entry has the  same shape as in `GET api/2.0/settings/storage`: identifier, title, the authentication keys the provider  expects, and `isSet` telling whether those keys are filled in on the server. Pass `dump=true` to read the  schedule of the whole server instead of the one of the current portal, which only makes sense on a server  installation. The caller needs the permission to edit portal settings, which in practice means the portal  owner or a DocSpace admin, and on an installation that is not a server one the call is also refused unless  backup is available there. Nothing is written and the call is safe to repeat. This operation says nothing  about where the portal data itself lives; the backup schedule is configured through the backup API, and the  storage of the documents through `PUT api/2.0/settings/storage`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dump">Whether the schedule of the whole server is read instead of the one of the current portal. It only changes  which schedule marks an entry as `current`; the list of storages itself is the same either way, and the flag  makes sense only on a self-hosted installation. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-backup-storages/">REST API Reference for GetAllBackupStorages Operation</seealso>
        /// <returns>StorageArrayWrapper</returns>
        public StorageArrayWrapper GetAllBackupStorages(bool? dump = default)
        {
            var localVarResponse = GetAllBackupStoragesWithHttpInfo(dump);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the backup storages
        /// </summary>
        /// <remarks>
        /// Returns the storages that can hold portal backups, with the one the saved backup schedule writes to marked as  `current` and its parameters filled in from that schedule; when no schedule is saved, or when the schedule  stores backups somewhere else than a third-party provider, none of the entries is current. Each entry has the  same shape as in `GET api/2.0/settings/storage`: identifier, title, the authentication keys the provider  expects, and `isSet` telling whether those keys are filled in on the server. Pass `dump=true` to read the  schedule of the whole server instead of the one of the current portal, which only makes sense on a server  installation. The caller needs the permission to edit portal settings, which in practice means the portal  owner or a DocSpace admin, and on an installation that is not a server one the call is also refused unless  backup is available there. Nothing is written and the call is safe to repeat. This operation says nothing  about where the portal data itself lives; the backup schedule is configured through the backup API, and the  storage of the documents through `PUT api/2.0/settings/storage`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dump">Whether the schedule of the whole server is read instead of the one of the current portal. It only changes  which schedule marks an entry as `current`; the list of storages itself is the same either way, and the flag  makes sense only on a self-hosted installation. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-backup-storages/">REST API Reference for GetAllBackupStorages Operation</seealso>
        /// <returns>ApiResponse of StorageArrayWrapper</returns>
        public ApiResponse<StorageArrayWrapper> GetAllBackupStoragesWithHttpInfo(bool? dump = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (dump != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Dump", dump));
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
            var localVarResponse = Client.Get<StorageArrayWrapper>("/api/2.0/settings/storage/backup", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAllBackupStorages", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the backup storages
        /// </summary>
        /// <remarks>
        /// Returns the storages that can hold portal backups, with the one the saved backup schedule writes to marked as  `current` and its parameters filled in from that schedule; when no schedule is saved, or when the schedule  stores backups somewhere else than a third-party provider, none of the entries is current. Each entry has the  same shape as in `GET api/2.0/settings/storage`: identifier, title, the authentication keys the provider  expects, and `isSet` telling whether those keys are filled in on the server. Pass `dump=true` to read the  schedule of the whole server instead of the one of the current portal, which only makes sense on a server  installation. The caller needs the permission to edit portal settings, which in practice means the portal  owner or a DocSpace admin, and on an installation that is not a server one the call is also refused unless  backup is available there. Nothing is written and the call is safe to repeat. This operation says nothing  about where the portal data itself lives; the backup schedule is configured through the backup API, and the  storage of the documents through `PUT api/2.0/settings/storage`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dump">Whether the schedule of the whole server is read instead of the one of the current portal. It only changes  which schedule marks an entry as `current`; the list of storages itself is the same either way, and the flag  makes sense only on a self-hosted installation. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-backup-storages/">REST API Reference for GetAllBackupStorages Operation</seealso>
        /// <returns>Task of StorageArrayWrapper</returns>
        public async Task<StorageArrayWrapper> GetAllBackupStoragesAsync(bool? dump = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAllBackupStoragesWithHttpInfoAsync(dump, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the backup storages
        /// </summary>
        /// <remarks>
        /// Returns the storages that can hold portal backups, with the one the saved backup schedule writes to marked as  `current` and its parameters filled in from that schedule; when no schedule is saved, or when the schedule  stores backups somewhere else than a third-party provider, none of the entries is current. Each entry has the  same shape as in `GET api/2.0/settings/storage`: identifier, title, the authentication keys the provider  expects, and `isSet` telling whether those keys are filled in on the server. Pass `dump=true` to read the  schedule of the whole server instead of the one of the current portal, which only makes sense on a server  installation. The caller needs the permission to edit portal settings, which in practice means the portal  owner or a DocSpace admin, and on an installation that is not a server one the call is also refused unless  backup is available there. Nothing is written and the call is safe to repeat. This operation says nothing  about where the portal data itself lives; the backup schedule is configured through the backup API, and the  storage of the documents through `PUT api/2.0/settings/storage`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dump">Whether the schedule of the whole server is read instead of the one of the current portal. It only changes  which schedule marks an entry as `current`; the list of storages itself is the same either way, and the flag  makes sense only on a self-hosted installation. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-backup-storages/">REST API Reference for GetAllBackupStorages Operation</seealso>
        /// <returns>Task of ApiResponse (StorageArrayWrapper)</returns>
        public async Task<ApiResponse<StorageArrayWrapper>> GetAllBackupStoragesWithHttpInfoAsync(bool? dump = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (dump != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Dump", dump));
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

            var localVarResponse = await AsynchronousClient.GetAsync<StorageArrayWrapper>("/api/2.0/settings/storage/backup", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAllBackupStorages", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the CDN storages
        /// </summary>
        /// <remarks>
        /// Returns the storages that can serve the static content of the portal through a content delivery network, which  is the subset of the providers of `GET api/2.0/settings/storage` that offer a CDN of their own. The entries  have the same shape as in the storage listing: identifier and title, the authentication keys the provider  expects, `isSet` telling whether those keys are filled in on the server, and `current` marking the CDN the  portal uses now. Keys of the current entry come from the saved CDN settings and keys of the others from the  provider configuration. An empty list means the build ships no CDN-capable provider, and a list where nothing  is current means the portal serves its static content itself. The caller needs the permission to edit portal  settings, which in practice means the portal owner or a DocSpace admin, on a server installation with an  unrestricted access space. Nothing is written and the call is safe to repeat. Use  `PUT api/2.0/settings/storage/cdn` to select a CDN and `DELETE api/2.0/settings/storage/cdn` to stop using  one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-cdn-storages/">REST API Reference for GetAllCdnStorages Operation</seealso>
        /// <returns>StorageArrayWrapper</returns>
        public StorageArrayWrapper GetAllCdnStorages()
        {
            var localVarResponse = GetAllCdnStoragesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the CDN storages
        /// </summary>
        /// <remarks>
        /// Returns the storages that can serve the static content of the portal through a content delivery network, which  is the subset of the providers of `GET api/2.0/settings/storage` that offer a CDN of their own. The entries  have the same shape as in the storage listing: identifier and title, the authentication keys the provider  expects, `isSet` telling whether those keys are filled in on the server, and `current` marking the CDN the  portal uses now. Keys of the current entry come from the saved CDN settings and keys of the others from the  provider configuration. An empty list means the build ships no CDN-capable provider, and a list where nothing  is current means the portal serves its static content itself. The caller needs the permission to edit portal  settings, which in practice means the portal owner or a DocSpace admin, on a server installation with an  unrestricted access space. Nothing is written and the call is safe to repeat. Use  `PUT api/2.0/settings/storage/cdn` to select a CDN and `DELETE api/2.0/settings/storage/cdn` to stop using  one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-cdn-storages/">REST API Reference for GetAllCdnStorages Operation</seealso>
        /// <returns>ApiResponse of StorageArrayWrapper</returns>
        public ApiResponse<StorageArrayWrapper> GetAllCdnStoragesWithHttpInfo()
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
            var localVarResponse = Client.Get<StorageArrayWrapper>("/api/2.0/settings/storage/cdn", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAllCdnStorages", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the CDN storages
        /// </summary>
        /// <remarks>
        /// Returns the storages that can serve the static content of the portal through a content delivery network, which  is the subset of the providers of `GET api/2.0/settings/storage` that offer a CDN of their own. The entries  have the same shape as in the storage listing: identifier and title, the authentication keys the provider  expects, `isSet` telling whether those keys are filled in on the server, and `current` marking the CDN the  portal uses now. Keys of the current entry come from the saved CDN settings and keys of the others from the  provider configuration. An empty list means the build ships no CDN-capable provider, and a list where nothing  is current means the portal serves its static content itself. The caller needs the permission to edit portal  settings, which in practice means the portal owner or a DocSpace admin, on a server installation with an  unrestricted access space. Nothing is written and the call is safe to repeat. Use  `PUT api/2.0/settings/storage/cdn` to select a CDN and `DELETE api/2.0/settings/storage/cdn` to stop using  one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-cdn-storages/">REST API Reference for GetAllCdnStorages Operation</seealso>
        /// <returns>Task of StorageArrayWrapper</returns>
        public async Task<StorageArrayWrapper> GetAllCdnStoragesAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAllCdnStoragesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the CDN storages
        /// </summary>
        /// <remarks>
        /// Returns the storages that can serve the static content of the portal through a content delivery network, which  is the subset of the providers of `GET api/2.0/settings/storage` that offer a CDN of their own. The entries  have the same shape as in the storage listing: identifier and title, the authentication keys the provider  expects, `isSet` telling whether those keys are filled in on the server, and `current` marking the CDN the  portal uses now. Keys of the current entry come from the saved CDN settings and keys of the others from the  provider configuration. An empty list means the build ships no CDN-capable provider, and a list where nothing  is current means the portal serves its static content itself. The caller needs the permission to edit portal  settings, which in practice means the portal owner or a DocSpace admin, on a server installation with an  unrestricted access space. Nothing is written and the call is safe to repeat. Use  `PUT api/2.0/settings/storage/cdn` to select a CDN and `DELETE api/2.0/settings/storage/cdn` to stop using  one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-cdn-storages/">REST API Reference for GetAllCdnStorages Operation</seealso>
        /// <returns>Task of ApiResponse (StorageArrayWrapper)</returns>
        public async Task<ApiResponse<StorageArrayWrapper>> GetAllCdnStoragesWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<StorageArrayWrapper>("/api/2.0/settings/storage/cdn", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAllCdnStorages", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the portal storages
        /// </summary>
        /// <remarks>
        /// Returns the third-party storages the installation can keep portal data in, the providers the build ships with,  such as Amazon S3, Google Cloud Storage or Rackspace. The built-in local storage is not among them: when none  of the entries is `current`, the portal data sits in the local storage. Each entry carries the storage  identifier and title, the authentication keys the provider expects, `isSet` telling whether those keys are  already filled in on the server, and `current` marking the one the portal uses right now. Keys of the current  storage are read from the saved settings, keys of the others from the provider configuration, so a value that  was never configured comes back empty. The caller needs the permission to edit portal settings, which in  practice means the portal owner or a DocSpace admin, and the installation has to be a server one whose access  space is not restricted; otherwise the call is refused with 403. Nothing is written and the call is safe to  repeat. Use `PUT api/2.0/settings/storage` to switch the storage, `DELETE api/2.0/settings/storage` to go back  to the local one, and `GET api/2.0/settings/storage/cdn` or `GET api/2.0/settings/storage/backup` for the CDN  and backup targets.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-storages/">REST API Reference for GetAllStorages Operation</seealso>
        /// <returns>StorageArrayWrapper</returns>
        public StorageArrayWrapper GetAllStorages()
        {
            var localVarResponse = GetAllStoragesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the portal storages
        /// </summary>
        /// <remarks>
        /// Returns the third-party storages the installation can keep portal data in, the providers the build ships with,  such as Amazon S3, Google Cloud Storage or Rackspace. The built-in local storage is not among them: when none  of the entries is `current`, the portal data sits in the local storage. Each entry carries the storage  identifier and title, the authentication keys the provider expects, `isSet` telling whether those keys are  already filled in on the server, and `current` marking the one the portal uses right now. Keys of the current  storage are read from the saved settings, keys of the others from the provider configuration, so a value that  was never configured comes back empty. The caller needs the permission to edit portal settings, which in  practice means the portal owner or a DocSpace admin, and the installation has to be a server one whose access  space is not restricted; otherwise the call is refused with 403. Nothing is written and the call is safe to  repeat. Use `PUT api/2.0/settings/storage` to switch the storage, `DELETE api/2.0/settings/storage` to go back  to the local one, and `GET api/2.0/settings/storage/cdn` or `GET api/2.0/settings/storage/backup` for the CDN  and backup targets.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-storages/">REST API Reference for GetAllStorages Operation</seealso>
        /// <returns>ApiResponse of StorageArrayWrapper</returns>
        public ApiResponse<StorageArrayWrapper> GetAllStoragesWithHttpInfo()
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
            var localVarResponse = Client.Get<StorageArrayWrapper>("/api/2.0/settings/storage", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAllStorages", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the portal storages
        /// </summary>
        /// <remarks>
        /// Returns the third-party storages the installation can keep portal data in, the providers the build ships with,  such as Amazon S3, Google Cloud Storage or Rackspace. The built-in local storage is not among them: when none  of the entries is `current`, the portal data sits in the local storage. Each entry carries the storage  identifier and title, the authentication keys the provider expects, `isSet` telling whether those keys are  already filled in on the server, and `current` marking the one the portal uses right now. Keys of the current  storage are read from the saved settings, keys of the others from the provider configuration, so a value that  was never configured comes back empty. The caller needs the permission to edit portal settings, which in  practice means the portal owner or a DocSpace admin, and the installation has to be a server one whose access  space is not restricted; otherwise the call is refused with 403. Nothing is written and the call is safe to  repeat. Use `PUT api/2.0/settings/storage` to switch the storage, `DELETE api/2.0/settings/storage` to go back  to the local one, and `GET api/2.0/settings/storage/cdn` or `GET api/2.0/settings/storage/backup` for the CDN  and backup targets.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-storages/">REST API Reference for GetAllStorages Operation</seealso>
        /// <returns>Task of StorageArrayWrapper</returns>
        public async Task<StorageArrayWrapper> GetAllStoragesAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAllStoragesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the portal storages
        /// </summary>
        /// <remarks>
        /// Returns the third-party storages the installation can keep portal data in, the providers the build ships with,  such as Amazon S3, Google Cloud Storage or Rackspace. The built-in local storage is not among them: when none  of the entries is `current`, the portal data sits in the local storage. Each entry carries the storage  identifier and title, the authentication keys the provider expects, `isSet` telling whether those keys are  already filled in on the server, and `current` marking the one the portal uses right now. Keys of the current  storage are read from the saved settings, keys of the others from the provider configuration, so a value that  was never configured comes back empty. The caller needs the permission to edit portal settings, which in  practice means the portal owner or a DocSpace admin, and the installation has to be a server one whose access  space is not restricted; otherwise the call is refused with 403. Nothing is written and the call is safe to  repeat. Use `PUT api/2.0/settings/storage` to switch the storage, `DELETE api/2.0/settings/storage` to go back  to the local one, and `GET api/2.0/settings/storage/cdn` or `GET api/2.0/settings/storage/backup` for the CDN  and backup targets.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-storages/">REST API Reference for GetAllStorages Operation</seealso>
        /// <returns>Task of ApiResponse (StorageArrayWrapper)</returns>
        public async Task<ApiResponse<StorageArrayWrapper>> GetAllStoragesWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<StorageArrayWrapper>("/api/2.0/settings/storage", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAllStorages", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the Amazon S3 regions
        /// </summary>
        /// <remarks>
        /// Returns the Amazon regions the server knows about, each with its system name such as `eu-central-1`, the  display name to show a user, and the partition details the region belongs to: partition name, DNS suffix, the  pattern its region names match and the template its host names are built from. This is static reference data  compiled into the server rather than portal configuration: nothing is read from the settings, nothing is  written, the answer is the same for every portal and changes only when the server is updated, so it can be  cached by the caller. Use the system name of an entry as the region value in `props` when configuring an  Amazon S3 storage with `PUT api/2.0/settings/storage`, `PUT api/2.0/settings/storage/cdn` or a backup  schedule, and prefer picking a value from here over typing one, because a region the server does not know  cannot be reached. Any authenticated caller may read the list, no portal-settings permission is asked for, and  the result is neither paginated nor filtered.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-amazon-s3regions/">REST API Reference for GetAmazonS3Regions Operation</seealso>
        /// <returns>AmazonS3RegionArrayWrapper</returns>
        public AmazonS3RegionArrayWrapper GetAmazonS3Regions()
        {
            var localVarResponse = GetAmazonS3RegionsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Amazon S3 regions
        /// </summary>
        /// <remarks>
        /// Returns the Amazon regions the server knows about, each with its system name such as `eu-central-1`, the  display name to show a user, and the partition details the region belongs to: partition name, DNS suffix, the  pattern its region names match and the template its host names are built from. This is static reference data  compiled into the server rather than portal configuration: nothing is read from the settings, nothing is  written, the answer is the same for every portal and changes only when the server is updated, so it can be  cached by the caller. Use the system name of an entry as the region value in `props` when configuring an  Amazon S3 storage with `PUT api/2.0/settings/storage`, `PUT api/2.0/settings/storage/cdn` or a backup  schedule, and prefer picking a value from here over typing one, because a region the server does not know  cannot be reached. Any authenticated caller may read the list, no portal-settings permission is asked for, and  the result is neither paginated nor filtered.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-amazon-s3regions/">REST API Reference for GetAmazonS3Regions Operation</seealso>
        /// <returns>ApiResponse of AmazonS3RegionArrayWrapper</returns>
        public ApiResponse<AmazonS3RegionArrayWrapper> GetAmazonS3RegionsWithHttpInfo()
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
            var localVarResponse = Client.Get<AmazonS3RegionArrayWrapper>("/api/2.0/settings/storage/s3/regions", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAmazonS3Regions", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the Amazon S3 regions
        /// </summary>
        /// <remarks>
        /// Returns the Amazon regions the server knows about, each with its system name such as `eu-central-1`, the  display name to show a user, and the partition details the region belongs to: partition name, DNS suffix, the  pattern its region names match and the template its host names are built from. This is static reference data  compiled into the server rather than portal configuration: nothing is read from the settings, nothing is  written, the answer is the same for every portal and changes only when the server is updated, so it can be  cached by the caller. Use the system name of an entry as the region value in `props` when configuring an  Amazon S3 storage with `PUT api/2.0/settings/storage`, `PUT api/2.0/settings/storage/cdn` or a backup  schedule, and prefer picking a value from here over typing one, because a region the server does not know  cannot be reached. Any authenticated caller may read the list, no portal-settings permission is asked for, and  the result is neither paginated nor filtered.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-amazon-s3regions/">REST API Reference for GetAmazonS3Regions Operation</seealso>
        /// <returns>Task of AmazonS3RegionArrayWrapper</returns>
        public async Task<AmazonS3RegionArrayWrapper> GetAmazonS3RegionsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAmazonS3RegionsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Amazon S3 regions
        /// </summary>
        /// <remarks>
        /// Returns the Amazon regions the server knows about, each with its system name such as `eu-central-1`, the  display name to show a user, and the partition details the region belongs to: partition name, DNS suffix, the  pattern its region names match and the template its host names are built from. This is static reference data  compiled into the server rather than portal configuration: nothing is read from the settings, nothing is  written, the answer is the same for every portal and changes only when the server is updated, so it can be  cached by the caller. Use the system name of an entry as the region value in `props` when configuring an  Amazon S3 storage with `PUT api/2.0/settings/storage`, `PUT api/2.0/settings/storage/cdn` or a backup  schedule, and prefer picking a value from here over typing one, because a region the server does not know  cannot be reached. Any authenticated caller may read the list, no portal-settings permission is asked for, and  the result is neither paginated nor filtered.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-amazon-s3regions/">REST API Reference for GetAmazonS3Regions Operation</seealso>
        /// <returns>Task of ApiResponse (AmazonS3RegionArrayWrapper)</returns>
        public async Task<ApiResponse<AmazonS3RegionArrayWrapper>> GetAmazonS3RegionsWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<AmazonS3RegionArrayWrapper>("/api/2.0/settings/storage/s3/regions", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAmazonS3Regions", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the storage migration progress
        /// </summary>
        /// <remarks>
        /// Returns how far the current portal has got in moving its data to another storage, as a percentage from 0 to  100. The migration itself is started by `PUT api/2.0/settings/storage` or `DELETE api/2.0/settings/storage`,  which put the portal into the migrating state; poll this operation until the value reaches 100, then the  portal is served from the new storage. A value of -1 means storage migration is not offered on this  installation, which is the case for every portal that is not a server one. Ask for the progress only once a  migration has actually been started: for a portal whose migration the server does not remember, the call fails  instead of answering with a zero. The response carries the percentage only, without the error flag the  migration service reports internally, so a value that stops advancing is a reason to check the portal state  with `GET api/2.0/portal` rather than proof of progress. The caller needs the permission to edit portal  settings, which in practice means the portal owner or a DocSpace admin, and the call is accepted even when the  portal payment has lapsed. Nothing is written and the call is safe to repeat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-progress/">REST API Reference for GetStorageProgress Operation</seealso>
        /// <returns>DoubleWrapper</returns>
        public DoubleWrapper GetStorageProgress()
        {
            var localVarResponse = GetStorageProgressWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the storage migration progress
        /// </summary>
        /// <remarks>
        /// Returns how far the current portal has got in moving its data to another storage, as a percentage from 0 to  100. The migration itself is started by `PUT api/2.0/settings/storage` or `DELETE api/2.0/settings/storage`,  which put the portal into the migrating state; poll this operation until the value reaches 100, then the  portal is served from the new storage. A value of -1 means storage migration is not offered on this  installation, which is the case for every portal that is not a server one. Ask for the progress only once a  migration has actually been started: for a portal whose migration the server does not remember, the call fails  instead of answering with a zero. The response carries the percentage only, without the error flag the  migration service reports internally, so a value that stops advancing is a reason to check the portal state  with `GET api/2.0/portal` rather than proof of progress. The caller needs the permission to edit portal  settings, which in practice means the portal owner or a DocSpace admin, and the call is accepted even when the  portal payment has lapsed. Nothing is written and the call is safe to repeat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-progress/">REST API Reference for GetStorageProgress Operation</seealso>
        /// <returns>ApiResponse of DoubleWrapper</returns>
        public ApiResponse<DoubleWrapper> GetStorageProgressWithHttpInfo()
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
            var localVarResponse = Client.Get<DoubleWrapper>("/api/2.0/settings/storage/progress", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetStorageProgress", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the storage migration progress
        /// </summary>
        /// <remarks>
        /// Returns how far the current portal has got in moving its data to another storage, as a percentage from 0 to  100. The migration itself is started by `PUT api/2.0/settings/storage` or `DELETE api/2.0/settings/storage`,  which put the portal into the migrating state; poll this operation until the value reaches 100, then the  portal is served from the new storage. A value of -1 means storage migration is not offered on this  installation, which is the case for every portal that is not a server one. Ask for the progress only once a  migration has actually been started: for a portal whose migration the server does not remember, the call fails  instead of answering with a zero. The response carries the percentage only, without the error flag the  migration service reports internally, so a value that stops advancing is a reason to check the portal state  with `GET api/2.0/portal` rather than proof of progress. The caller needs the permission to edit portal  settings, which in practice means the portal owner or a DocSpace admin, and the call is accepted even when the  portal payment has lapsed. Nothing is written and the call is safe to repeat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-progress/">REST API Reference for GetStorageProgress Operation</seealso>
        /// <returns>Task of DoubleWrapper</returns>
        public async Task<DoubleWrapper> GetStorageProgressAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetStorageProgressWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the storage migration progress
        /// </summary>
        /// <remarks>
        /// Returns how far the current portal has got in moving its data to another storage, as a percentage from 0 to  100. The migration itself is started by `PUT api/2.0/settings/storage` or `DELETE api/2.0/settings/storage`,  which put the portal into the migrating state; poll this operation until the value reaches 100, then the  portal is served from the new storage. A value of -1 means storage migration is not offered on this  installation, which is the case for every portal that is not a server one. Ask for the progress only once a  migration has actually been started: for a portal whose migration the server does not remember, the call fails  instead of answering with a zero. The response carries the percentage only, without the error flag the  migration service reports internally, so a value that stops advancing is a reason to check the portal state  with `GET api/2.0/portal` rather than proof of progress. The caller needs the permission to edit portal  settings, which in practice means the portal owner or a DocSpace admin, and the call is accepted even when the  portal payment has lapsed. Nothing is written and the call is safe to repeat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-storage-progress/">REST API Reference for GetStorageProgress Operation</seealso>
        /// <returns>Task of ApiResponse (DoubleWrapper)</returns>
        public async Task<ApiResponse<DoubleWrapper>> GetStorageProgressWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<DoubleWrapper>("/api/2.0/settings/storage/progress", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetStorageProgress", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Reset the CDN storage settings
        /// </summary>
        /// <remarks>
        /// Drops the CDN configuration of the current portal, module and saved credentials alike, so that the static  content is served by the portal itself again. Nothing is uploaded or migrated, no state change is queued and  the call gives back no body: only the settings are cleared, and files already copied to the content delivery  network are left where they are, to be removed in the provider's own console if that is wanted. The change  takes effect for links built after it, so a page that is already open may keep pointing at the CDN until it is  reloaded. Repeating the call is harmless, because clearing an empty configuration does nothing. The caller  needs the permission to edit portal settings, which in practice means the portal owner or a DocSpace admin, on  a server installation with an unrestricted access space. Use `GET api/2.0/settings/storage/cdn` to see what is  configured now and `PUT api/2.0/settings/storage/cdn` to select a CDN again; the portal storage of the  documents is untouched by this operation and is reset with `DELETE api/2.0/settings/storage` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-cdn-to-default/">REST API Reference for ResetCdnToDefault Operation</seealso>
        /// <returns></returns>
        public void ResetCdnToDefault()
        {
            ResetCdnToDefaultWithHttpInfo();
        }

        /// <summary>
        /// Reset the CDN storage settings
        /// </summary>
        /// <remarks>
        /// Drops the CDN configuration of the current portal, module and saved credentials alike, so that the static  content is served by the portal itself again. Nothing is uploaded or migrated, no state change is queued and  the call gives back no body: only the settings are cleared, and files already copied to the content delivery  network are left where they are, to be removed in the provider's own console if that is wanted. The change  takes effect for links built after it, so a page that is already open may keep pointing at the CDN until it is  reloaded. Repeating the call is harmless, because clearing an empty configuration does nothing. The caller  needs the permission to edit portal settings, which in practice means the portal owner or a DocSpace admin, on  a server installation with an unrestricted access space. Use `GET api/2.0/settings/storage/cdn` to see what is  configured now and `PUT api/2.0/settings/storage/cdn` to select a CDN again; the portal storage of the  documents is untouched by this operation and is reset with `DELETE api/2.0/settings/storage` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-cdn-to-default/">REST API Reference for ResetCdnToDefault Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ResetCdnToDefaultWithHttpInfo()
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
            var localVarResponse = Client.Delete<Object>("/api/2.0/settings/storage/cdn", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ResetCdnToDefault", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Reset the CDN storage settings
        /// </summary>
        /// <remarks>
        /// Drops the CDN configuration of the current portal, module and saved credentials alike, so that the static  content is served by the portal itself again. Nothing is uploaded or migrated, no state change is queued and  the call gives back no body: only the settings are cleared, and files already copied to the content delivery  network are left where they are, to be removed in the provider's own console if that is wanted. The change  takes effect for links built after it, so a page that is already open may keep pointing at the CDN until it is  reloaded. Repeating the call is harmless, because clearing an empty configuration does nothing. The caller  needs the permission to edit portal settings, which in practice means the portal owner or a DocSpace admin, on  a server installation with an unrestricted access space. Use `GET api/2.0/settings/storage/cdn` to see what is  configured now and `PUT api/2.0/settings/storage/cdn` to select a CDN again; the portal storage of the  documents is untouched by this operation and is reset with `DELETE api/2.0/settings/storage` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-cdn-to-default/">REST API Reference for ResetCdnToDefault Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task ResetCdnToDefaultAsync(CancellationToken cancellationToken = default)
        {
            await ResetCdnToDefaultWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Reset the CDN storage settings
        /// </summary>
        /// <remarks>
        /// Drops the CDN configuration of the current portal, module and saved credentials alike, so that the static  content is served by the portal itself again. Nothing is uploaded or migrated, no state change is queued and  the call gives back no body: only the settings are cleared, and files already copied to the content delivery  network are left where they are, to be removed in the provider's own console if that is wanted. The change  takes effect for links built after it, so a page that is already open may keep pointing at the CDN until it is  reloaded. Repeating the call is harmless, because clearing an empty configuration does nothing. The caller  needs the permission to edit portal settings, which in practice means the portal owner or a DocSpace admin, on  a server installation with an unrestricted access space. Use `GET api/2.0/settings/storage/cdn` to see what is  configured now and `PUT api/2.0/settings/storage/cdn` to select a CDN again; the portal storage of the  documents is untouched by this operation and is reset with `DELETE api/2.0/settings/storage` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-cdn-to-default/">REST API Reference for ResetCdnToDefault Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> ResetCdnToDefaultWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.DeleteAsync<Object>("/api/2.0/settings/storage/cdn", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ResetCdnToDefault", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Reset the storage settings
        /// </summary>
        /// <remarks>
        /// Drops the third-party storage configuration of the current portal, module and saved credentials alike, and  starts an asynchronous migration of the portal data back into the built-in local storage. The portal moves  into the migrating state and stays unavailable until the transfer ends, so follow it with  `GET api/2.0/settings/storage/progress`; the call itself returns as soon as the migration has been handed to  the storage service and gives back no body. The caller needs the permission to edit portal settings, which in  practice means the portal owner or a DocSpace admin, on a server installation with an unrestricted access  space. This is a mutating and slow operation rather than a destructive one: documents are copied back rather  than deleted, but the credentials of the previous storage are gone from the settings and have to be sent again  with `PUT api/2.0/settings/storage` to switch back. Repeating the call while a migration is running starts  another one, so poll instead. Resetting the storage is also the step that makes  `POST api/2.0/settings/encryption/start` possible, since encryption only covers the local storage.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-storage-to-default/">REST API Reference for ResetStorageToDefault Operation</seealso>
        /// <returns></returns>
        public void ResetStorageToDefault()
        {
            ResetStorageToDefaultWithHttpInfo();
        }

        /// <summary>
        /// Reset the storage settings
        /// </summary>
        /// <remarks>
        /// Drops the third-party storage configuration of the current portal, module and saved credentials alike, and  starts an asynchronous migration of the portal data back into the built-in local storage. The portal moves  into the migrating state and stays unavailable until the transfer ends, so follow it with  `GET api/2.0/settings/storage/progress`; the call itself returns as soon as the migration has been handed to  the storage service and gives back no body. The caller needs the permission to edit portal settings, which in  practice means the portal owner or a DocSpace admin, on a server installation with an unrestricted access  space. This is a mutating and slow operation rather than a destructive one: documents are copied back rather  than deleted, but the credentials of the previous storage are gone from the settings and have to be sent again  with `PUT api/2.0/settings/storage` to switch back. Repeating the call while a migration is running starts  another one, so poll instead. Resetting the storage is also the step that makes  `POST api/2.0/settings/encryption/start` possible, since encryption only covers the local storage.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-storage-to-default/">REST API Reference for ResetStorageToDefault Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ResetStorageToDefaultWithHttpInfo()
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
            var localVarResponse = Client.Delete<Object>("/api/2.0/settings/storage", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ResetStorageToDefault", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Reset the storage settings
        /// </summary>
        /// <remarks>
        /// Drops the third-party storage configuration of the current portal, module and saved credentials alike, and  starts an asynchronous migration of the portal data back into the built-in local storage. The portal moves  into the migrating state and stays unavailable until the transfer ends, so follow it with  `GET api/2.0/settings/storage/progress`; the call itself returns as soon as the migration has been handed to  the storage service and gives back no body. The caller needs the permission to edit portal settings, which in  practice means the portal owner or a DocSpace admin, on a server installation with an unrestricted access  space. This is a mutating and slow operation rather than a destructive one: documents are copied back rather  than deleted, but the credentials of the previous storage are gone from the settings and have to be sent again  with `PUT api/2.0/settings/storage` to switch back. Repeating the call while a migration is running starts  another one, so poll instead. Resetting the storage is also the step that makes  `POST api/2.0/settings/encryption/start` possible, since encryption only covers the local storage.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-storage-to-default/">REST API Reference for ResetStorageToDefault Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task ResetStorageToDefaultAsync(CancellationToken cancellationToken = default)
        {
            await ResetStorageToDefaultWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Reset the storage settings
        /// </summary>
        /// <remarks>
        /// Drops the third-party storage configuration of the current portal, module and saved credentials alike, and  starts an asynchronous migration of the portal data back into the built-in local storage. The portal moves  into the migrating state and stays unavailable until the transfer ends, so follow it with  `GET api/2.0/settings/storage/progress`; the call itself returns as soon as the migration has been handed to  the storage service and gives back no body. The caller needs the permission to edit portal settings, which in  practice means the portal owner or a DocSpace admin, on a server installation with an unrestricted access  space. This is a mutating and slow operation rather than a destructive one: documents are copied back rather  than deleted, but the credentials of the previous storage are gone from the settings and have to be sent again  with `PUT api/2.0/settings/storage` to switch back. Repeating the call while a migration is running starts  another one, so poll instead. Resetting the storage is also the step that makes  `POST api/2.0/settings/encryption/start` possible, since encryption only covers the local storage.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-storage-to-default/">REST API Reference for ResetStorageToDefault Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> ResetStorageToDefaultWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.DeleteAsync<Object>("/api/2.0/settings/storage", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ResetStorageToDefault", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the CDN storage
        /// </summary>
        /// <remarks>
        /// Selects the content delivery network that serves the static content of the portal and saves the credentials it  needs: `module` is the identifier of one of the entries of `GET api/2.0/settings/storage/cdn`, and `props`  carries that provider's authentication keys as name and value pairs. The provider has to be available on the  server, which the `isSet` flag of the listing tells, otherwise the request is rejected as invalid. Sending the  module the portal already uses changes nothing and returns the saved settings as they are. Any other module is  saved and the upload of the static content is handed to the storage service; the settings come back only when  that hand-over succeeds, a failure being reported as a server error. Unlike the portal storage this has no  progress operation, so there is nothing to poll: the content appears on the CDN once the service has copied  it. Only static content is affected here, never documents; for those use `PUT api/2.0/settings/storage`. The  caller needs the permission to edit portal settings, which in practice means the portal owner or a DocSpace  admin, on a server installation with an unrestricted access space. The response is the stored CDN  configuration.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageRequestsDto">Which storage provider the portal is pointed at, and the credentials it needs. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-cdn-storage/">REST API Reference for UpdateCdnStorage Operation</seealso>
        /// <returns>CdnStorageSettingsWrapper</returns>
        public CdnStorageSettingsWrapper UpdateCdnStorage(StorageRequestsDto? storageRequestsDto = default)
        {
            var localVarResponse = UpdateCdnStorageWithHttpInfo(storageRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update the CDN storage
        /// </summary>
        /// <remarks>
        /// Selects the content delivery network that serves the static content of the portal and saves the credentials it  needs: `module` is the identifier of one of the entries of `GET api/2.0/settings/storage/cdn`, and `props`  carries that provider's authentication keys as name and value pairs. The provider has to be available on the  server, which the `isSet` flag of the listing tells, otherwise the request is rejected as invalid. Sending the  module the portal already uses changes nothing and returns the saved settings as they are. Any other module is  saved and the upload of the static content is handed to the storage service; the settings come back only when  that hand-over succeeds, a failure being reported as a server error. Unlike the portal storage this has no  progress operation, so there is nothing to poll: the content appears on the CDN once the service has copied  it. Only static content is affected here, never documents; for those use `PUT api/2.0/settings/storage`. The  caller needs the permission to edit portal settings, which in practice means the portal owner or a DocSpace  admin, on a server installation with an unrestricted access space. The response is the stored CDN  configuration.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageRequestsDto">Which storage provider the portal is pointed at, and the credentials it needs. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-cdn-storage/">REST API Reference for UpdateCdnStorage Operation</seealso>
        /// <returns>ApiResponse of CdnStorageSettingsWrapper</returns>
        public ApiResponse<CdnStorageSettingsWrapper> UpdateCdnStorageWithHttpInfo(StorageRequestsDto? storageRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (storageRequestsDto != null) localVarRequestOptions.Data = storageRequestsDto;

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
            var localVarResponse = Client.Put<CdnStorageSettingsWrapper>("/api/2.0/settings/storage/cdn", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateCdnStorage", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the CDN storage
        /// </summary>
        /// <remarks>
        /// Selects the content delivery network that serves the static content of the portal and saves the credentials it  needs: `module` is the identifier of one of the entries of `GET api/2.0/settings/storage/cdn`, and `props`  carries that provider's authentication keys as name and value pairs. The provider has to be available on the  server, which the `isSet` flag of the listing tells, otherwise the request is rejected as invalid. Sending the  module the portal already uses changes nothing and returns the saved settings as they are. Any other module is  saved and the upload of the static content is handed to the storage service; the settings come back only when  that hand-over succeeds, a failure being reported as a server error. Unlike the portal storage this has no  progress operation, so there is nothing to poll: the content appears on the CDN once the service has copied  it. Only static content is affected here, never documents; for those use `PUT api/2.0/settings/storage`. The  caller needs the permission to edit portal settings, which in practice means the portal owner or a DocSpace  admin, on a server installation with an unrestricted access space. The response is the stored CDN  configuration.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageRequestsDto">Which storage provider the portal is pointed at, and the credentials it needs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-cdn-storage/">REST API Reference for UpdateCdnStorage Operation</seealso>
        /// <returns>Task of CdnStorageSettingsWrapper</returns>
        public async Task<CdnStorageSettingsWrapper> UpdateCdnStorageAsync(StorageRequestsDto? storageRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateCdnStorageWithHttpInfoAsync(storageRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update the CDN storage
        /// </summary>
        /// <remarks>
        /// Selects the content delivery network that serves the static content of the portal and saves the credentials it  needs: `module` is the identifier of one of the entries of `GET api/2.0/settings/storage/cdn`, and `props`  carries that provider's authentication keys as name and value pairs. The provider has to be available on the  server, which the `isSet` flag of the listing tells, otherwise the request is rejected as invalid. Sending the  module the portal already uses changes nothing and returns the saved settings as they are. Any other module is  saved and the upload of the static content is handed to the storage service; the settings come back only when  that hand-over succeeds, a failure being reported as a server error. Unlike the portal storage this has no  progress operation, so there is nothing to poll: the content appears on the CDN once the service has copied  it. Only static content is affected here, never documents; for those use `PUT api/2.0/settings/storage`. The  caller needs the permission to edit portal settings, which in practice means the portal owner or a DocSpace  admin, on a server installation with an unrestricted access space. The response is the stored CDN  configuration.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageRequestsDto">Which storage provider the portal is pointed at, and the credentials it needs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-cdn-storage/">REST API Reference for UpdateCdnStorage Operation</seealso>
        /// <returns>Task of ApiResponse (CdnStorageSettingsWrapper)</returns>
        public async Task<ApiResponse<CdnStorageSettingsWrapper>> UpdateCdnStorageWithHttpInfoAsync(StorageRequestsDto? storageRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (storageRequestsDto != null) localVarRequestOptions.Data = storageRequestsDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<CdnStorageSettingsWrapper>("/api/2.0/settings/storage/cdn", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateCdnStorage", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Switch the portal storage
        /// </summary>
        /// <remarks>
        /// Points the current portal at another storage and saves the credentials it needs: `module` is the identifier of  one of the storages listed by `GET api/2.0/settings/storage`, and `props` carries that provider's  authentication keys as name and value pairs, for example the bucket, region and access key of an Amazon S3  storage. The provider has to be available on the server, which the `isSet` flag of the listing tells,  otherwise the request is rejected as invalid. Sending the module the portal already uses changes nothing and  returns the saved settings as they are. Any other module starts an asynchronous migration of the portal data:  the portal moves into the migrating state and stays unavailable until the transfer ends, so follow it with  `GET api/2.0/settings/storage/progress` and do not send a second switch while it runs. The caller needs the  permission to edit portal settings, which in practice means the portal owner or a DocSpace admin, on a server  installation with an unrestricted access space. The response is the stored configuration, module and  properties, not the state of the migration. To return to the built-in local storage call  `DELETE api/2.0/settings/storage`, and for the CDN use `PUT api/2.0/settings/storage/cdn`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageRequestsDto">Which storage provider the portal is pointed at, and the credentials it needs. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-storage/">REST API Reference for UpdateStorage Operation</seealso>
        /// <returns>StorageSettingsWrapper</returns>
        public StorageSettingsWrapper UpdateStorage(StorageRequestsDto? storageRequestsDto = default)
        {
            var localVarResponse = UpdateStorageWithHttpInfo(storageRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Switch the portal storage
        /// </summary>
        /// <remarks>
        /// Points the current portal at another storage and saves the credentials it needs: `module` is the identifier of  one of the storages listed by `GET api/2.0/settings/storage`, and `props` carries that provider's  authentication keys as name and value pairs, for example the bucket, region and access key of an Amazon S3  storage. The provider has to be available on the server, which the `isSet` flag of the listing tells,  otherwise the request is rejected as invalid. Sending the module the portal already uses changes nothing and  returns the saved settings as they are. Any other module starts an asynchronous migration of the portal data:  the portal moves into the migrating state and stays unavailable until the transfer ends, so follow it with  `GET api/2.0/settings/storage/progress` and do not send a second switch while it runs. The caller needs the  permission to edit portal settings, which in practice means the portal owner or a DocSpace admin, on a server  installation with an unrestricted access space. The response is the stored configuration, module and  properties, not the state of the migration. To return to the built-in local storage call  `DELETE api/2.0/settings/storage`, and for the CDN use `PUT api/2.0/settings/storage/cdn`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageRequestsDto">Which storage provider the portal is pointed at, and the credentials it needs. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-storage/">REST API Reference for UpdateStorage Operation</seealso>
        /// <returns>ApiResponse of StorageSettingsWrapper</returns>
        public ApiResponse<StorageSettingsWrapper> UpdateStorageWithHttpInfo(StorageRequestsDto? storageRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (storageRequestsDto != null) localVarRequestOptions.Data = storageRequestsDto;

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
            var localVarResponse = Client.Put<StorageSettingsWrapper>("/api/2.0/settings/storage", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateStorage", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Switch the portal storage
        /// </summary>
        /// <remarks>
        /// Points the current portal at another storage and saves the credentials it needs: `module` is the identifier of  one of the storages listed by `GET api/2.0/settings/storage`, and `props` carries that provider's  authentication keys as name and value pairs, for example the bucket, region and access key of an Amazon S3  storage. The provider has to be available on the server, which the `isSet` flag of the listing tells,  otherwise the request is rejected as invalid. Sending the module the portal already uses changes nothing and  returns the saved settings as they are. Any other module starts an asynchronous migration of the portal data:  the portal moves into the migrating state and stays unavailable until the transfer ends, so follow it with  `GET api/2.0/settings/storage/progress` and do not send a second switch while it runs. The caller needs the  permission to edit portal settings, which in practice means the portal owner or a DocSpace admin, on a server  installation with an unrestricted access space. The response is the stored configuration, module and  properties, not the state of the migration. To return to the built-in local storage call  `DELETE api/2.0/settings/storage`, and for the CDN use `PUT api/2.0/settings/storage/cdn`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageRequestsDto">Which storage provider the portal is pointed at, and the credentials it needs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-storage/">REST API Reference for UpdateStorage Operation</seealso>
        /// <returns>Task of StorageSettingsWrapper</returns>
        public async Task<StorageSettingsWrapper> UpdateStorageAsync(StorageRequestsDto? storageRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateStorageWithHttpInfoAsync(storageRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Switch the portal storage
        /// </summary>
        /// <remarks>
        /// Points the current portal at another storage and saves the credentials it needs: `module` is the identifier of  one of the storages listed by `GET api/2.0/settings/storage`, and `props` carries that provider's  authentication keys as name and value pairs, for example the bucket, region and access key of an Amazon S3  storage. The provider has to be available on the server, which the `isSet` flag of the listing tells,  otherwise the request is rejected as invalid. Sending the module the portal already uses changes nothing and  returns the saved settings as they are. Any other module starts an asynchronous migration of the portal data:  the portal moves into the migrating state and stays unavailable until the transfer ends, so follow it with  `GET api/2.0/settings/storage/progress` and do not send a second switch while it runs. The caller needs the  permission to edit portal settings, which in practice means the portal owner or a DocSpace admin, on a server  installation with an unrestricted access space. The response is the stored configuration, module and  properties, not the state of the migration. To return to the built-in local storage call  `DELETE api/2.0/settings/storage`, and for the CDN use `PUT api/2.0/settings/storage/cdn`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="storageRequestsDto">Which storage provider the portal is pointed at, and the credentials it needs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-storage/">REST API Reference for UpdateStorage Operation</seealso>
        /// <returns>Task of ApiResponse (StorageSettingsWrapper)</returns>
        public async Task<ApiResponse<StorageSettingsWrapper>> UpdateStorageWithHttpInfoAsync(StorageRequestsDto? storageRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (storageRequestsDto != null) localVarRequestOptions.Data = storageRequestsDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<StorageSettingsWrapper>("/api/2.0/settings/storage", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateStorage", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
