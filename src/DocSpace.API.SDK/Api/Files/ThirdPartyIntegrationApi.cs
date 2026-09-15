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
namespace DocSpace.API.SDK.Api.Files
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IThirdPartyIntegrationApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Remove a third-party account
        /// </summary>
        /// <remarks>
        /// Disconnects a third-party storage account from the portal and returns the ID of the folder that stood for it,  in the `provider-accountId` form the Files operations use for third-party entries. Take `providerId` from  `GET api/2.0/files/thirdparty`: it is the numeric account ID, not that composed folder ID. The member who  connected the account can remove it; another member's request is refused unless they hold delete rights on the  folder it stands for. Nothing is deleted at the storage service: the files stay with the provider, and what  goes away is the portal's link to them together with the stored credentials, the sharing records and the tags  kept for its entries. A room that was created on this account stops being available. When the account being  removed is the one connected for backups by `POST api/2.0/files/thirdparty/backup`, its backup schedule is  deleted as well. The removal cannot be repeated: once the account is gone the same ID is refused rather than  confirmed, so treat the first successful answer as the record of it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="providerId">The ID of the connected third-party storage account, as `providerId` of `GET api/2.0/files/thirdparty`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-third-party/">REST API Reference for DeleteThirdParty Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper DeleteThirdParty(int providerId);

        /// <summary>
        /// Remove a third-party account
        /// </summary>
        /// <remarks>
        /// Disconnects a third-party storage account from the portal and returns the ID of the folder that stood for it,  in the `provider-accountId` form the Files operations use for third-party entries. Take `providerId` from  `GET api/2.0/files/thirdparty`: it is the numeric account ID, not that composed folder ID. The member who  connected the account can remove it; another member's request is refused unless they hold delete rights on the  folder it stands for. Nothing is deleted at the storage service: the files stay with the provider, and what  goes away is the portal's link to them together with the stored credentials, the sharing records and the tags  kept for its entries. A room that was created on this account stops being available. When the account being  removed is the one connected for backups by `POST api/2.0/files/thirdparty/backup`, its backup schedule is  deleted as well. The removal cannot be repeated: once the account is gone the same ID is refused rather than  confirmed, so treat the first successful answer as the record of it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="providerId">The ID of the connected third-party storage account, as `providerId` of `GET api/2.0/files/thirdparty`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-third-party/">REST API Reference for DeleteThirdParty Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> DeleteThirdPartyWithHttpInfo(int providerId);
        /// <summary>
        /// Get all third-party providers
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage services this portal can connect, with everything a connection form needs: the  display name, the key to send as `providerKey`, whether the service authenticates through OAuth 2.0, the OAuth  client ID and redirect URL where it does, and whether the caller has to supply the server address. Several  WebDAV presets share the key `WebDav` and are told apart by their names, so keep the name the caller chose  next to the key when building the request. Pass `excludewebdav=true` to drop the whole WebDAV family,  including the kDrive and Yandex presets, and keep only the OAuth services. The call is read-only. An empty  array is a normal answer: it is what a guest gets, and what everyone gets while the portal-wide third-party  switch is off (`PUT api/2.0/files/thirdparty`). The `connected` flag of an element says the service is  available on this portal, not that an account of it exists - the caller's own accounts are listed by  `GET api/2.0/files/thirdparty`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="excludewebdav">Set to true to leave out the whole WebDAV family, the kDrive and Yandex presets included, and keep only the  services that authenticate through OAuth 2.0; false lists all of them. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-providers/">REST API Reference for GetAllProviders Operation</seealso>
        /// <returns>ProviderArrayWrapper</returns>
        ProviderArrayWrapper GetAllProviders(bool? excludewebdav = default);

        /// <summary>
        /// Get all third-party providers
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage services this portal can connect, with everything a connection form needs: the  display name, the key to send as `providerKey`, whether the service authenticates through OAuth 2.0, the OAuth  client ID and redirect URL where it does, and whether the caller has to supply the server address. Several  WebDAV presets share the key `WebDav` and are told apart by their names, so keep the name the caller chose  next to the key when building the request. Pass `excludewebdav=true` to drop the whole WebDAV family,  including the kDrive and Yandex presets, and keep only the OAuth services. The call is read-only. An empty  array is a normal answer: it is what a guest gets, and what everyone gets while the portal-wide third-party  switch is off (`PUT api/2.0/files/thirdparty`). The `connected` flag of an element says the service is  available on this portal, not that an account of it exists - the caller's own accounts are listed by  `GET api/2.0/files/thirdparty`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="excludewebdav">Set to true to leave out the whole WebDAV family, the kDrive and Yandex presets included, and keep only the  services that authenticate through OAuth 2.0; false lists all of them. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-providers/">REST API Reference for GetAllProviders Operation</seealso>
        /// <returns>ApiResponse of ProviderArrayWrapper</returns>
        ApiResponse<ProviderArrayWrapper> GetAllProvidersWithHttpInfo(bool? excludewebdav = default);
        /// <summary>
        /// Get the third-party backup folder
        /// </summary>
        /// <remarks>
        /// Returns the folder of the third-party storage account the portal keeps for backups, so a caller can check  where scheduled and manual backups are written. There is at most one such account per portal, connected by an  administrator through `POST api/2.0/files/thirdparty/backup`, and it is deliberately kept out of the personal  list of `GET api/2.0/files/thirdparty`. Any authenticated member may ask, and the call is read-only. The body  is `null`, with a successful status, in two situations the answer does not distinguish: no backup account has  been connected, and the caller has no read access to the folder of the one that is. When a folder does come  back, its `id` is the string ID of a third-party folder and can be used with the folder operations that accept  one, and its `title` is the title the account was saved under. Connecting a different account through the  backup operation replaces this one rather than adding a second, and  `DELETE api/2.0/files/thirdparty/{providerId}` removes it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-backup-third-party-account/">REST API Reference for GetBackupThirdPartyAccount Operation</seealso>
        /// <returns>FolderStringWrapper</returns>
        FolderStringWrapper GetBackupThirdPartyAccount();

        /// <summary>
        /// Get the third-party backup folder
        /// </summary>
        /// <remarks>
        /// Returns the folder of the third-party storage account the portal keeps for backups, so a caller can check  where scheduled and manual backups are written. There is at most one such account per portal, connected by an  administrator through `POST api/2.0/files/thirdparty/backup`, and it is deliberately kept out of the personal  list of `GET api/2.0/files/thirdparty`. Any authenticated member may ask, and the call is read-only. The body  is `null`, with a successful status, in two situations the answer does not distinguish: no backup account has  been connected, and the caller has no read access to the folder of the one that is. When a folder does come  back, its `id` is the string ID of a third-party folder and can be used with the folder operations that accept  one, and its `title` is the title the account was saved under. Connecting a different account through the  backup operation replaces this one rather than adding a second, and  `DELETE api/2.0/files/thirdparty/{providerId}` removes it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-backup-third-party-account/">REST API Reference for GetBackupThirdPartyAccount Operation</seealso>
        /// <returns>ApiResponse of FolderStringWrapper</returns>
        ApiResponse<FolderStringWrapper> GetBackupThirdPartyAccountWithHttpInfo();
        /// <summary>
        /// Get third-party provider capabilities
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage services this portal is able to connect, in the compact form a connection dialog  needs. Every element is itself an array whose first item is the provider key accepted as `providerKey` by  `POST api/2.0/files/thirdparty`. For the services that authenticate through OAuth 2.0 (`Box`, `DropboxV2`,  `GoogleDrive`, `OneDrive`) the second and third items are the OAuth client ID and the redirect URL this portal  is registered with, so the caller can build the consent screen URL itself; the services that authenticate by  login and password (`SharePoint`, `WebDav`, `kDrive`, `Yandex`) contribute a single-item array. Only the  services enabled in the portal configuration are listed, and an OAuth service whose application is not  configured is left out. The call is read-only. An empty array is a normal answer rather than a failure: it is  what a guest gets, and what everyone gets while the portal-wide third-party switch is off  (`PUT api/2.0/files/thirdparty`). For display names, the WebDAV presets and the flags a connection form needs,  use `GET api/2.0/files/thirdparty/providers` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-capabilities/">REST API Reference for GetCapabilities Operation</seealso>
        /// <returns>ArrayArrayWrapper</returns>
        ArrayArrayWrapper GetCapabilities();

        /// <summary>
        /// Get third-party provider capabilities
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage services this portal is able to connect, in the compact form a connection dialog  needs. Every element is itself an array whose first item is the provider key accepted as `providerKey` by  `POST api/2.0/files/thirdparty`. For the services that authenticate through OAuth 2.0 (`Box`, `DropboxV2`,  `GoogleDrive`, `OneDrive`) the second and third items are the OAuth client ID and the redirect URL this portal  is registered with, so the caller can build the consent screen URL itself; the services that authenticate by  login and password (`SharePoint`, `WebDav`, `kDrive`, `Yandex`) contribute a single-item array. Only the  services enabled in the portal configuration are listed, and an OAuth service whose application is not  configured is left out. The call is read-only. An empty array is a normal answer rather than a failure: it is  what a guest gets, and what everyone gets while the portal-wide third-party switch is off  (`PUT api/2.0/files/thirdparty`). For display names, the WebDAV presets and the flags a connection form needs,  use `GET api/2.0/files/thirdparty/providers` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-capabilities/">REST API Reference for GetCapabilities Operation</seealso>
        /// <returns>ApiResponse of ArrayArrayWrapper</returns>
        ApiResponse<ArrayArrayWrapper> GetCapabilitiesWithHttpInfo();
        /// <summary>
        /// Get common third-party folders
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage accounts attached to the legacy Common section, as folder entries that can be  browsed with the usual folder operations. Each entry stands for a whole connected account: its title is the  account title, and `providerId` and `providerKey` identify the account behind it. Only accounts whose owner  the caller may read are included, so the answer differs from one member to another. The call is read-only and  returns a plain array with no paging. An empty array is the expected answer in most portals and does not mean  an error: accounts connected by `POST api/2.0/files/thirdparty` are attached to the Rooms section, not to  Common, so only accounts inherited from an older portal appear here. The list is also empty while the  portal-wide third-party switch is off (`PUT api/2.0/files/thirdparty`) and when no storage service is  configured. For the accounts the caller owns, regardless of where they are attached, use  `GET api/2.0/files/thirdparty`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-common-third-party-folders/">REST API Reference for GetCommonThirdPartyFolders Operation</seealso>
        /// <returns>FolderStringArrayWrapper</returns>
        FolderStringArrayWrapper GetCommonThirdPartyFolders();

        /// <summary>
        /// Get common third-party folders
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage accounts attached to the legacy Common section, as folder entries that can be  browsed with the usual folder operations. Each entry stands for a whole connected account: its title is the  account title, and `providerId` and `providerKey` identify the account behind it. Only accounts whose owner  the caller may read are included, so the answer differs from one member to another. The call is read-only and  returns a plain array with no paging. An empty array is the expected answer in most portals and does not mean  an error: accounts connected by `POST api/2.0/files/thirdparty` are attached to the Rooms section, not to  Common, so only accounts inherited from an older portal appear here. The list is also empty while the  portal-wide third-party switch is off (`PUT api/2.0/files/thirdparty`) and when no storage service is  configured. For the accounts the caller owns, regardless of where they are attached, use  `GET api/2.0/files/thirdparty`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-common-third-party-folders/">REST API Reference for GetCommonThirdPartyFolders Operation</seealso>
        /// <returns>ApiResponse of FolderStringArrayWrapper</returns>
        ApiResponse<FolderStringArrayWrapper> GetCommonThirdPartyFoldersWithHttpInfo();
        /// <summary>
        /// Get the third-party accounts
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage accounts the caller has connected, one element per account, with the title it  was saved under, the storage service behind it and the portal section it is attached to. Accounts connected by  other members are not included, and neither is the portal backup account of  `GET api/2.0/files/thirdparty/backup`, even for an administrator. The `providerId` of an element is the value  to send to `DELETE api/2.0/files/thirdparty/{providerId}` and, as `providerId` in  `POST api/2.0/files/thirdparty`, the way to re-authenticate that same account instead of connecting a new one.  Credentials are never disclosed: `auth_data` comes back empty for every element. An element with  `roomsStorage` set is available as storage for a room, while `corporate` marks an account inherited from the  legacy Common section. The call is read-only, returns a plain array with no paging and no contractual  ordering, and answers with an empty array when the caller has connected nothing. To browse the content of an  account, take the folder ID from the answer of the operation that connected it or from  `GET api/2.0/files/@root`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-third-party-accounts/">REST API Reference for GetThirdPartyAccounts Operation</seealso>
        /// <returns>ThirdPartyParamsArrayWrapper</returns>
        ThirdPartyParamsArrayWrapper GetThirdPartyAccounts();

        /// <summary>
        /// Get the third-party accounts
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage accounts the caller has connected, one element per account, with the title it  was saved under, the storage service behind it and the portal section it is attached to. Accounts connected by  other members are not included, and neither is the portal backup account of  `GET api/2.0/files/thirdparty/backup`, even for an administrator. The `providerId` of an element is the value  to send to `DELETE api/2.0/files/thirdparty/{providerId}` and, as `providerId` in  `POST api/2.0/files/thirdparty`, the way to re-authenticate that same account instead of connecting a new one.  Credentials are never disclosed: `auth_data` comes back empty for every element. An element with  `roomsStorage` set is available as storage for a room, while `corporate` marks an account inherited from the  legacy Common section. The call is read-only, returns a plain array with no paging and no contractual  ordering, and answers with an empty array when the caller has connected nothing. To browse the content of an  account, take the folder ID from the answer of the operation that connected it or from  `GET api/2.0/files/@root`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-third-party-accounts/">REST API Reference for GetThirdPartyAccounts Operation</seealso>
        /// <returns>ApiResponse of ThirdPartyParamsArrayWrapper</returns>
        ApiResponse<ThirdPartyParamsArrayWrapper> GetThirdPartyAccountsWithHttpInfo();
        /// <summary>
        /// Connect a third-party account
        /// </summary>
        /// <remarks>
        /// Connects an account at a third-party storage service to the portal, or re-authenticates one that is already  connected, and returns the folder that now stands for its root. Send `providerId` to update an existing  account and omit it to connect a new one; the accepted `providerKey` values come from  `GET api/2.0/files/thirdparty/providers`. The credentials to send depend on the service: the OAuth services  take `token`, which is the authorization code from their consent screen and not an access token, while the  WebDAV family and SharePoint take `login` with `password`, plus `url` where the server address is not fixed.  Credentials are verified against the service before anything is stored, so a wrong password is refused and  nothing is saved. The caller needs the rights to create rooms, and the portal-wide third-party switch has to  be on, otherwise the call is refused. A new account is attached to the Rooms section and becomes available as  room storage for `POST api/2.0/files/rooms/thirdparty/{id}`. Connecting twice with the same title creates two  separate accounts.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyRequestDto">The credentials and the title of a third-party storage account to connect or to re-authenticate. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-third-party/">REST API Reference for SaveThirdParty Operation</seealso>
        /// <returns>FolderStringWrapper</returns>
        FolderStringWrapper SaveThirdParty(ThirdPartyRequestDto? thirdPartyRequestDto = default);

        /// <summary>
        /// Connect a third-party account
        /// </summary>
        /// <remarks>
        /// Connects an account at a third-party storage service to the portal, or re-authenticates one that is already  connected, and returns the folder that now stands for its root. Send `providerId` to update an existing  account and omit it to connect a new one; the accepted `providerKey` values come from  `GET api/2.0/files/thirdparty/providers`. The credentials to send depend on the service: the OAuth services  take `token`, which is the authorization code from their consent screen and not an access token, while the  WebDAV family and SharePoint take `login` with `password`, plus `url` where the server address is not fixed.  Credentials are verified against the service before anything is stored, so a wrong password is refused and  nothing is saved. The caller needs the rights to create rooms, and the portal-wide third-party switch has to  be on, otherwise the call is refused. A new account is attached to the Rooms section and becomes available as  room storage for `POST api/2.0/files/rooms/thirdparty/{id}`. Connecting twice with the same title creates two  separate accounts.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyRequestDto">The credentials and the title of a third-party storage account to connect or to re-authenticate. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-third-party/">REST API Reference for SaveThirdParty Operation</seealso>
        /// <returns>ApiResponse of FolderStringWrapper</returns>
        ApiResponse<FolderStringWrapper> SaveThirdPartyWithHttpInfo(ThirdPartyRequestDto? thirdPartyRequestDto = default);
        /// <summary>
        /// Connect the third-party backup storage
        /// </summary>
        /// <remarks>
        /// Connects the third-party storage account the portal writes its backups to, and returns the folder that stands  for its root. Only a portal administrator may call it, and the portal-wide third-party switch has to be on;  other callers are refused. The account is portal-wide and single: a second call does not add another one but  re-authenticates and retitles the existing one, which makes the operation safe to repeat with the same body.  The credentials follow the same rules as in `POST api/2.0/files/thirdparty` - an authorization code in `token`  for the OAuth services, `login` with `password` and, where the server address is not fixed, `url` for the  WebDAV family and SharePoint - and are verified against the service before anything is stored, so a wrong  password leaves the previous account untouched. The account is deliberately absent from  `GET api/2.0/files/thirdparty`; read it back with `GET api/2.0/files/thirdparty/backup` and remove it with  `DELETE api/2.0/files/thirdparty/{providerId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyBackupRequestDto">The credentials and the title of the third-party storage account the portal writes its backups to. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-third-party-backup/">REST API Reference for SaveThirdPartyBackup Operation</seealso>
        /// <returns>FolderStringWrapper</returns>
        FolderStringWrapper SaveThirdPartyBackup(ThirdPartyBackupRequestDto? thirdPartyBackupRequestDto = default);

        /// <summary>
        /// Connect the third-party backup storage
        /// </summary>
        /// <remarks>
        /// Connects the third-party storage account the portal writes its backups to, and returns the folder that stands  for its root. Only a portal administrator may call it, and the portal-wide third-party switch has to be on;  other callers are refused. The account is portal-wide and single: a second call does not add another one but  re-authenticates and retitles the existing one, which makes the operation safe to repeat with the same body.  The credentials follow the same rules as in `POST api/2.0/files/thirdparty` - an authorization code in `token`  for the OAuth services, `login` with `password` and, where the server address is not fixed, `url` for the  WebDAV family and SharePoint - and are verified against the service before anything is stored, so a wrong  password leaves the previous account untouched. The account is deliberately absent from  `GET api/2.0/files/thirdparty`; read it back with `GET api/2.0/files/thirdparty/backup` and remove it with  `DELETE api/2.0/files/thirdparty/{providerId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyBackupRequestDto">The credentials and the title of the third-party storage account the portal writes its backups to. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-third-party-backup/">REST API Reference for SaveThirdPartyBackup Operation</seealso>
        /// <returns>ApiResponse of FolderStringWrapper</returns>
        ApiResponse<FolderStringWrapper> SaveThirdPartyBackupWithHttpInfo(ThirdPartyBackupRequestDto? thirdPartyBackupRequestDto = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IThirdPartyIntegrationApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Remove a third-party account
        /// </summary>
        /// <remarks>
        /// Disconnects a third-party storage account from the portal and returns the ID of the folder that stood for it,  in the `provider-accountId` form the Files operations use for third-party entries. Take `providerId` from  `GET api/2.0/files/thirdparty`: it is the numeric account ID, not that composed folder ID. The member who  connected the account can remove it; another member's request is refused unless they hold delete rights on the  folder it stands for. Nothing is deleted at the storage service: the files stay with the provider, and what  goes away is the portal's link to them together with the stored credentials, the sharing records and the tags  kept for its entries. A room that was created on this account stops being available. When the account being  removed is the one connected for backups by `POST api/2.0/files/thirdparty/backup`, its backup schedule is  deleted as well. The removal cannot be repeated: once the account is gone the same ID is refused rather than  confirmed, so treat the first successful answer as the record of it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="providerId">The ID of the connected third-party storage account, as `providerId` of `GET api/2.0/files/thirdparty`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-third-party/">REST API Reference for DeleteThirdParty Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> DeleteThirdPartyAsync(int providerId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove a third-party account
        /// </summary>
        /// <remarks>
        /// Disconnects a third-party storage account from the portal and returns the ID of the folder that stood for it,  in the `provider-accountId` form the Files operations use for third-party entries. Take `providerId` from  `GET api/2.0/files/thirdparty`: it is the numeric account ID, not that composed folder ID. The member who  connected the account can remove it; another member's request is refused unless they hold delete rights on the  folder it stands for. Nothing is deleted at the storage service: the files stay with the provider, and what  goes away is the portal's link to them together with the stored credentials, the sharing records and the tags  kept for its entries. A room that was created on this account stops being available. When the account being  removed is the one connected for backups by `POST api/2.0/files/thirdparty/backup`, its backup schedule is  deleted as well. The removal cannot be repeated: once the account is gone the same ID is refused rather than  confirmed, so treat the first successful answer as the record of it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="providerId">The ID of the connected third-party storage account, as `providerId` of `GET api/2.0/files/thirdparty`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-third-party/">REST API Reference for DeleteThirdParty Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> DeleteThirdPartyWithHttpInfoAsync(int providerId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get all third-party providers
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage services this portal can connect, with everything a connection form needs: the  display name, the key to send as `providerKey`, whether the service authenticates through OAuth 2.0, the OAuth  client ID and redirect URL where it does, and whether the caller has to supply the server address. Several  WebDAV presets share the key `WebDav` and are told apart by their names, so keep the name the caller chose  next to the key when building the request. Pass `excludewebdav=true` to drop the whole WebDAV family,  including the kDrive and Yandex presets, and keep only the OAuth services. The call is read-only. An empty  array is a normal answer: it is what a guest gets, and what everyone gets while the portal-wide third-party  switch is off (`PUT api/2.0/files/thirdparty`). The `connected` flag of an element says the service is  available on this portal, not that an account of it exists - the caller's own accounts are listed by  `GET api/2.0/files/thirdparty`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="excludewebdav">Set to true to leave out the whole WebDAV family, the kDrive and Yandex presets included, and keep only the  services that authenticate through OAuth 2.0; false lists all of them. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-providers/">REST API Reference for GetAllProviders Operation</seealso>
        /// <returns>Task of ProviderArrayWrapper</returns>
        Task<ProviderArrayWrapper> GetAllProvidersAsync(bool? excludewebdav = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get all third-party providers
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage services this portal can connect, with everything a connection form needs: the  display name, the key to send as `providerKey`, whether the service authenticates through OAuth 2.0, the OAuth  client ID and redirect URL where it does, and whether the caller has to supply the server address. Several  WebDAV presets share the key `WebDav` and are told apart by their names, so keep the name the caller chose  next to the key when building the request. Pass `excludewebdav=true` to drop the whole WebDAV family,  including the kDrive and Yandex presets, and keep only the OAuth services. The call is read-only. An empty  array is a normal answer: it is what a guest gets, and what everyone gets while the portal-wide third-party  switch is off (`PUT api/2.0/files/thirdparty`). The `connected` flag of an element says the service is  available on this portal, not that an account of it exists - the caller's own accounts are listed by  `GET api/2.0/files/thirdparty`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="excludewebdav">Set to true to leave out the whole WebDAV family, the kDrive and Yandex presets included, and keep only the  services that authenticate through OAuth 2.0; false lists all of them. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-providers/">REST API Reference for GetAllProviders Operation</seealso>
        /// <returns>Task of ApiResponse (ProviderArrayWrapper)</returns>
        Task<ApiResponse<ProviderArrayWrapper>> GetAllProvidersWithHttpInfoAsync(bool? excludewebdav = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the third-party backup folder
        /// </summary>
        /// <remarks>
        /// Returns the folder of the third-party storage account the portal keeps for backups, so a caller can check  where scheduled and manual backups are written. There is at most one such account per portal, connected by an  administrator through `POST api/2.0/files/thirdparty/backup`, and it is deliberately kept out of the personal  list of `GET api/2.0/files/thirdparty`. Any authenticated member may ask, and the call is read-only. The body  is `null`, with a successful status, in two situations the answer does not distinguish: no backup account has  been connected, and the caller has no read access to the folder of the one that is. When a folder does come  back, its `id` is the string ID of a third-party folder and can be used with the folder operations that accept  one, and its `title` is the title the account was saved under. Connecting a different account through the  backup operation replaces this one rather than adding a second, and  `DELETE api/2.0/files/thirdparty/{providerId}` removes it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-backup-third-party-account/">REST API Reference for GetBackupThirdPartyAccount Operation</seealso>
        /// <returns>Task of FolderStringWrapper</returns>
        Task<FolderStringWrapper> GetBackupThirdPartyAccountAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the third-party backup folder
        /// </summary>
        /// <remarks>
        /// Returns the folder of the third-party storage account the portal keeps for backups, so a caller can check  where scheduled and manual backups are written. There is at most one such account per portal, connected by an  administrator through `POST api/2.0/files/thirdparty/backup`, and it is deliberately kept out of the personal  list of `GET api/2.0/files/thirdparty`. Any authenticated member may ask, and the call is read-only. The body  is `null`, with a successful status, in two situations the answer does not distinguish: no backup account has  been connected, and the caller has no read access to the folder of the one that is. When a folder does come  back, its `id` is the string ID of a third-party folder and can be used with the folder operations that accept  one, and its `title` is the title the account was saved under. Connecting a different account through the  backup operation replaces this one rather than adding a second, and  `DELETE api/2.0/files/thirdparty/{providerId}` removes it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-backup-third-party-account/">REST API Reference for GetBackupThirdPartyAccount Operation</seealso>
        /// <returns>Task of ApiResponse (FolderStringWrapper)</returns>
        Task<ApiResponse<FolderStringWrapper>> GetBackupThirdPartyAccountWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get third-party provider capabilities
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage services this portal is able to connect, in the compact form a connection dialog  needs. Every element is itself an array whose first item is the provider key accepted as `providerKey` by  `POST api/2.0/files/thirdparty`. For the services that authenticate through OAuth 2.0 (`Box`, `DropboxV2`,  `GoogleDrive`, `OneDrive`) the second and third items are the OAuth client ID and the redirect URL this portal  is registered with, so the caller can build the consent screen URL itself; the services that authenticate by  login and password (`SharePoint`, `WebDav`, `kDrive`, `Yandex`) contribute a single-item array. Only the  services enabled in the portal configuration are listed, and an OAuth service whose application is not  configured is left out. The call is read-only. An empty array is a normal answer rather than a failure: it is  what a guest gets, and what everyone gets while the portal-wide third-party switch is off  (`PUT api/2.0/files/thirdparty`). For display names, the WebDAV presets and the flags a connection form needs,  use `GET api/2.0/files/thirdparty/providers` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-capabilities/">REST API Reference for GetCapabilities Operation</seealso>
        /// <returns>Task of ArrayArrayWrapper</returns>
        Task<ArrayArrayWrapper> GetCapabilitiesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get third-party provider capabilities
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage services this portal is able to connect, in the compact form a connection dialog  needs. Every element is itself an array whose first item is the provider key accepted as `providerKey` by  `POST api/2.0/files/thirdparty`. For the services that authenticate through OAuth 2.0 (`Box`, `DropboxV2`,  `GoogleDrive`, `OneDrive`) the second and third items are the OAuth client ID and the redirect URL this portal  is registered with, so the caller can build the consent screen URL itself; the services that authenticate by  login and password (`SharePoint`, `WebDav`, `kDrive`, `Yandex`) contribute a single-item array. Only the  services enabled in the portal configuration are listed, and an OAuth service whose application is not  configured is left out. The call is read-only. An empty array is a normal answer rather than a failure: it is  what a guest gets, and what everyone gets while the portal-wide third-party switch is off  (`PUT api/2.0/files/thirdparty`). For display names, the WebDAV presets and the flags a connection form needs,  use `GET api/2.0/files/thirdparty/providers` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-capabilities/">REST API Reference for GetCapabilities Operation</seealso>
        /// <returns>Task of ApiResponse (ArrayArrayWrapper)</returns>
        Task<ApiResponse<ArrayArrayWrapper>> GetCapabilitiesWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get common third-party folders
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage accounts attached to the legacy Common section, as folder entries that can be  browsed with the usual folder operations. Each entry stands for a whole connected account: its title is the  account title, and `providerId` and `providerKey` identify the account behind it. Only accounts whose owner  the caller may read are included, so the answer differs from one member to another. The call is read-only and  returns a plain array with no paging. An empty array is the expected answer in most portals and does not mean  an error: accounts connected by `POST api/2.0/files/thirdparty` are attached to the Rooms section, not to  Common, so only accounts inherited from an older portal appear here. The list is also empty while the  portal-wide third-party switch is off (`PUT api/2.0/files/thirdparty`) and when no storage service is  configured. For the accounts the caller owns, regardless of where they are attached, use  `GET api/2.0/files/thirdparty`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-common-third-party-folders/">REST API Reference for GetCommonThirdPartyFolders Operation</seealso>
        /// <returns>Task of FolderStringArrayWrapper</returns>
        Task<FolderStringArrayWrapper> GetCommonThirdPartyFoldersAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get common third-party folders
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage accounts attached to the legacy Common section, as folder entries that can be  browsed with the usual folder operations. Each entry stands for a whole connected account: its title is the  account title, and `providerId` and `providerKey` identify the account behind it. Only accounts whose owner  the caller may read are included, so the answer differs from one member to another. The call is read-only and  returns a plain array with no paging. An empty array is the expected answer in most portals and does not mean  an error: accounts connected by `POST api/2.0/files/thirdparty` are attached to the Rooms section, not to  Common, so only accounts inherited from an older portal appear here. The list is also empty while the  portal-wide third-party switch is off (`PUT api/2.0/files/thirdparty`) and when no storage service is  configured. For the accounts the caller owns, regardless of where they are attached, use  `GET api/2.0/files/thirdparty`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-common-third-party-folders/">REST API Reference for GetCommonThirdPartyFolders Operation</seealso>
        /// <returns>Task of ApiResponse (FolderStringArrayWrapper)</returns>
        Task<ApiResponse<FolderStringArrayWrapper>> GetCommonThirdPartyFoldersWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the third-party accounts
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage accounts the caller has connected, one element per account, with the title it  was saved under, the storage service behind it and the portal section it is attached to. Accounts connected by  other members are not included, and neither is the portal backup account of  `GET api/2.0/files/thirdparty/backup`, even for an administrator. The `providerId` of an element is the value  to send to `DELETE api/2.0/files/thirdparty/{providerId}` and, as `providerId` in  `POST api/2.0/files/thirdparty`, the way to re-authenticate that same account instead of connecting a new one.  Credentials are never disclosed: `auth_data` comes back empty for every element. An element with  `roomsStorage` set is available as storage for a room, while `corporate` marks an account inherited from the  legacy Common section. The call is read-only, returns a plain array with no paging and no contractual  ordering, and answers with an empty array when the caller has connected nothing. To browse the content of an  account, take the folder ID from the answer of the operation that connected it or from  `GET api/2.0/files/@root`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-third-party-accounts/">REST API Reference for GetThirdPartyAccounts Operation</seealso>
        /// <returns>Task of ThirdPartyParamsArrayWrapper</returns>
        Task<ThirdPartyParamsArrayWrapper> GetThirdPartyAccountsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the third-party accounts
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage accounts the caller has connected, one element per account, with the title it  was saved under, the storage service behind it and the portal section it is attached to. Accounts connected by  other members are not included, and neither is the portal backup account of  `GET api/2.0/files/thirdparty/backup`, even for an administrator. The `providerId` of an element is the value  to send to `DELETE api/2.0/files/thirdparty/{providerId}` and, as `providerId` in  `POST api/2.0/files/thirdparty`, the way to re-authenticate that same account instead of connecting a new one.  Credentials are never disclosed: `auth_data` comes back empty for every element. An element with  `roomsStorage` set is available as storage for a room, while `corporate` marks an account inherited from the  legacy Common section. The call is read-only, returns a plain array with no paging and no contractual  ordering, and answers with an empty array when the caller has connected nothing. To browse the content of an  account, take the folder ID from the answer of the operation that connected it or from  `GET api/2.0/files/@root`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-third-party-accounts/">REST API Reference for GetThirdPartyAccounts Operation</seealso>
        /// <returns>Task of ApiResponse (ThirdPartyParamsArrayWrapper)</returns>
        Task<ApiResponse<ThirdPartyParamsArrayWrapper>> GetThirdPartyAccountsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Connect a third-party account
        /// </summary>
        /// <remarks>
        /// Connects an account at a third-party storage service to the portal, or re-authenticates one that is already  connected, and returns the folder that now stands for its root. Send `providerId` to update an existing  account and omit it to connect a new one; the accepted `providerKey` values come from  `GET api/2.0/files/thirdparty/providers`. The credentials to send depend on the service: the OAuth services  take `token`, which is the authorization code from their consent screen and not an access token, while the  WebDAV family and SharePoint take `login` with `password`, plus `url` where the server address is not fixed.  Credentials are verified against the service before anything is stored, so a wrong password is refused and  nothing is saved. The caller needs the rights to create rooms, and the portal-wide third-party switch has to  be on, otherwise the call is refused. A new account is attached to the Rooms section and becomes available as  room storage for `POST api/2.0/files/rooms/thirdparty/{id}`. Connecting twice with the same title creates two  separate accounts.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyRequestDto">The credentials and the title of a third-party storage account to connect or to re-authenticate. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-third-party/">REST API Reference for SaveThirdParty Operation</seealso>
        /// <returns>Task of FolderStringWrapper</returns>
        Task<FolderStringWrapper> SaveThirdPartyAsync(ThirdPartyRequestDto? thirdPartyRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Connect a third-party account
        /// </summary>
        /// <remarks>
        /// Connects an account at a third-party storage service to the portal, or re-authenticates one that is already  connected, and returns the folder that now stands for its root. Send `providerId` to update an existing  account and omit it to connect a new one; the accepted `providerKey` values come from  `GET api/2.0/files/thirdparty/providers`. The credentials to send depend on the service: the OAuth services  take `token`, which is the authorization code from their consent screen and not an access token, while the  WebDAV family and SharePoint take `login` with `password`, plus `url` where the server address is not fixed.  Credentials are verified against the service before anything is stored, so a wrong password is refused and  nothing is saved. The caller needs the rights to create rooms, and the portal-wide third-party switch has to  be on, otherwise the call is refused. A new account is attached to the Rooms section and becomes available as  room storage for `POST api/2.0/files/rooms/thirdparty/{id}`. Connecting twice with the same title creates two  separate accounts.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyRequestDto">The credentials and the title of a third-party storage account to connect or to re-authenticate. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-third-party/">REST API Reference for SaveThirdParty Operation</seealso>
        /// <returns>Task of ApiResponse (FolderStringWrapper)</returns>
        Task<ApiResponse<FolderStringWrapper>> SaveThirdPartyWithHttpInfoAsync(ThirdPartyRequestDto? thirdPartyRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Connect the third-party backup storage
        /// </summary>
        /// <remarks>
        /// Connects the third-party storage account the portal writes its backups to, and returns the folder that stands  for its root. Only a portal administrator may call it, and the portal-wide third-party switch has to be on;  other callers are refused. The account is portal-wide and single: a second call does not add another one but  re-authenticates and retitles the existing one, which makes the operation safe to repeat with the same body.  The credentials follow the same rules as in `POST api/2.0/files/thirdparty` - an authorization code in `token`  for the OAuth services, `login` with `password` and, where the server address is not fixed, `url` for the  WebDAV family and SharePoint - and are verified against the service before anything is stored, so a wrong  password leaves the previous account untouched. The account is deliberately absent from  `GET api/2.0/files/thirdparty`; read it back with `GET api/2.0/files/thirdparty/backup` and remove it with  `DELETE api/2.0/files/thirdparty/{providerId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyBackupRequestDto">The credentials and the title of the third-party storage account the portal writes its backups to. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-third-party-backup/">REST API Reference for SaveThirdPartyBackup Operation</seealso>
        /// <returns>Task of FolderStringWrapper</returns>
        Task<FolderStringWrapper> SaveThirdPartyBackupAsync(ThirdPartyBackupRequestDto? thirdPartyBackupRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Connect the third-party backup storage
        /// </summary>
        /// <remarks>
        /// Connects the third-party storage account the portal writes its backups to, and returns the folder that stands  for its root. Only a portal administrator may call it, and the portal-wide third-party switch has to be on;  other callers are refused. The account is portal-wide and single: a second call does not add another one but  re-authenticates and retitles the existing one, which makes the operation safe to repeat with the same body.  The credentials follow the same rules as in `POST api/2.0/files/thirdparty` - an authorization code in `token`  for the OAuth services, `login` with `password` and, where the server address is not fixed, `url` for the  WebDAV family and SharePoint - and are verified against the service before anything is stored, so a wrong  password leaves the previous account untouched. The account is deliberately absent from  `GET api/2.0/files/thirdparty`; read it back with `GET api/2.0/files/thirdparty/backup` and remove it with  `DELETE api/2.0/files/thirdparty/{providerId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyBackupRequestDto">The credentials and the title of the third-party storage account the portal writes its backups to. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-third-party-backup/">REST API Reference for SaveThirdPartyBackup Operation</seealso>
        /// <returns>Task of ApiResponse (FolderStringWrapper)</returns>
        Task<ApiResponse<FolderStringWrapper>> SaveThirdPartyBackupWithHttpInfoAsync(ThirdPartyBackupRequestDto? thirdPartyBackupRequestDto = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IThirdPartyIntegrationApi : IThirdPartyIntegrationApiSync, IThirdPartyIntegrationApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ThirdPartyIntegrationApi : IDisposable, IThirdPartyIntegrationApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyIntegrationApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public ThirdPartyIntegrationApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyIntegrationApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public ThirdPartyIntegrationApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ThirdPartyIntegrationApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public ThirdPartyIntegrationApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ThirdPartyIntegrationApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public ThirdPartyIntegrationApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyIntegrationApi"/> class.
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
        public ThirdPartyIntegrationApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="ThirdPartyIntegrationApi"/> class using a Configuration object.
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
        public ThirdPartyIntegrationApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="ThirdPartyIntegrationApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ThirdPartyIntegrationApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Remove a third-party account
        /// </summary>
        /// <remarks>
        /// Disconnects a third-party storage account from the portal and returns the ID of the folder that stood for it,  in the `provider-accountId` form the Files operations use for third-party entries. Take `providerId` from  `GET api/2.0/files/thirdparty`: it is the numeric account ID, not that composed folder ID. The member who  connected the account can remove it; another member's request is refused unless they hold delete rights on the  folder it stands for. Nothing is deleted at the storage service: the files stay with the provider, and what  goes away is the portal's link to them together with the stored credentials, the sharing records and the tags  kept for its entries. A room that was created on this account stops being available. When the account being  removed is the one connected for backups by `POST api/2.0/files/thirdparty/backup`, its backup schedule is  deleted as well. The removal cannot be repeated: once the account is gone the same ID is refused rather than  confirmed, so treat the first successful answer as the record of it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="providerId">The ID of the connected third-party storage account, as `providerId` of `GET api/2.0/files/thirdparty`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-third-party/">REST API Reference for DeleteThirdParty Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper DeleteThirdParty(int providerId)
        {
            var localVarResponse = DeleteThirdPartyWithHttpInfo(providerId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove a third-party account
        /// </summary>
        /// <remarks>
        /// Disconnects a third-party storage account from the portal and returns the ID of the folder that stood for it,  in the `provider-accountId` form the Files operations use for third-party entries. Take `providerId` from  `GET api/2.0/files/thirdparty`: it is the numeric account ID, not that composed folder ID. The member who  connected the account can remove it; another member's request is refused unless they hold delete rights on the  folder it stands for. Nothing is deleted at the storage service: the files stay with the provider, and what  goes away is the portal's link to them together with the stored credentials, the sharing records and the tags  kept for its entries. A room that was created on this account stops being available. When the account being  removed is the one connected for backups by `POST api/2.0/files/thirdparty/backup`, its backup schedule is  deleted as well. The removal cannot be repeated: once the account is gone the same ID is refused rather than  confirmed, so treat the first successful answer as the record of it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="providerId">The ID of the connected third-party storage account, as `providerId` of `GET api/2.0/files/thirdparty`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-third-party/">REST API Reference for DeleteThirdParty Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> DeleteThirdPartyWithHttpInfo(int providerId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("providerId", ClientUtils.ParameterToString(providerId)); // path parameter

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
            var localVarResponse = Client.Delete<StringWrapper>("/api/2.0/files/thirdparty/{providerId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteThirdParty", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove a third-party account
        /// </summary>
        /// <remarks>
        /// Disconnects a third-party storage account from the portal and returns the ID of the folder that stood for it,  in the `provider-accountId` form the Files operations use for third-party entries. Take `providerId` from  `GET api/2.0/files/thirdparty`: it is the numeric account ID, not that composed folder ID. The member who  connected the account can remove it; another member's request is refused unless they hold delete rights on the  folder it stands for. Nothing is deleted at the storage service: the files stay with the provider, and what  goes away is the portal's link to them together with the stored credentials, the sharing records and the tags  kept for its entries. A room that was created on this account stops being available. When the account being  removed is the one connected for backups by `POST api/2.0/files/thirdparty/backup`, its backup schedule is  deleted as well. The removal cannot be repeated: once the account is gone the same ID is refused rather than  confirmed, so treat the first successful answer as the record of it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="providerId">The ID of the connected third-party storage account, as `providerId` of `GET api/2.0/files/thirdparty`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-third-party/">REST API Reference for DeleteThirdParty Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> DeleteThirdPartyAsync(int providerId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeleteThirdPartyWithHttpInfoAsync(providerId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove a third-party account
        /// </summary>
        /// <remarks>
        /// Disconnects a third-party storage account from the portal and returns the ID of the folder that stood for it,  in the `provider-accountId` form the Files operations use for third-party entries. Take `providerId` from  `GET api/2.0/files/thirdparty`: it is the numeric account ID, not that composed folder ID. The member who  connected the account can remove it; another member's request is refused unless they hold delete rights on the  folder it stands for. Nothing is deleted at the storage service: the files stay with the provider, and what  goes away is the portal's link to them together with the stored credentials, the sharing records and the tags  kept for its entries. A room that was created on this account stops being available. When the account being  removed is the one connected for backups by `POST api/2.0/files/thirdparty/backup`, its backup schedule is  deleted as well. The removal cannot be repeated: once the account is gone the same ID is refused rather than  confirmed, so treat the first successful answer as the record of it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="providerId">The ID of the connected third-party storage account, as `providerId` of `GET api/2.0/files/thirdparty`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-third-party/">REST API Reference for DeleteThirdParty Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async Task<ApiResponse<StringWrapper>> DeleteThirdPartyWithHttpInfoAsync(int providerId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("providerId", ClientUtils.ParameterToString(providerId)); // path parameter

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<StringWrapper>("/api/2.0/files/thirdparty/{providerId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteThirdParty", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all third-party providers
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage services this portal can connect, with everything a connection form needs: the  display name, the key to send as `providerKey`, whether the service authenticates through OAuth 2.0, the OAuth  client ID and redirect URL where it does, and whether the caller has to supply the server address. Several  WebDAV presets share the key `WebDav` and are told apart by their names, so keep the name the caller chose  next to the key when building the request. Pass `excludewebdav=true` to drop the whole WebDAV family,  including the kDrive and Yandex presets, and keep only the OAuth services. The call is read-only. An empty  array is a normal answer: it is what a guest gets, and what everyone gets while the portal-wide third-party  switch is off (`PUT api/2.0/files/thirdparty`). The `connected` flag of an element says the service is  available on this portal, not that an account of it exists - the caller's own accounts are listed by  `GET api/2.0/files/thirdparty`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="excludewebdav">Set to true to leave out the whole WebDAV family, the kDrive and Yandex presets included, and keep only the  services that authenticate through OAuth 2.0; false lists all of them. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-providers/">REST API Reference for GetAllProviders Operation</seealso>
        /// <returns>ProviderArrayWrapper</returns>
        public ProviderArrayWrapper GetAllProviders(bool? excludewebdav = default)
        {
            var localVarResponse = GetAllProvidersWithHttpInfo(excludewebdav);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all third-party providers
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage services this portal can connect, with everything a connection form needs: the  display name, the key to send as `providerKey`, whether the service authenticates through OAuth 2.0, the OAuth  client ID and redirect URL where it does, and whether the caller has to supply the server address. Several  WebDAV presets share the key `WebDav` and are told apart by their names, so keep the name the caller chose  next to the key when building the request. Pass `excludewebdav=true` to drop the whole WebDAV family,  including the kDrive and Yandex presets, and keep only the OAuth services. The call is read-only. An empty  array is a normal answer: it is what a guest gets, and what everyone gets while the portal-wide third-party  switch is off (`PUT api/2.0/files/thirdparty`). The `connected` flag of an element says the service is  available on this portal, not that an account of it exists - the caller's own accounts are listed by  `GET api/2.0/files/thirdparty`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="excludewebdav">Set to true to leave out the whole WebDAV family, the kDrive and Yandex presets included, and keep only the  services that authenticate through OAuth 2.0; false lists all of them. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-providers/">REST API Reference for GetAllProviders Operation</seealso>
        /// <returns>ApiResponse of ProviderArrayWrapper</returns>
        public ApiResponse<ProviderArrayWrapper> GetAllProvidersWithHttpInfo(bool? excludewebdav = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (excludewebdav != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludewebdav", excludewebdav));
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
            var localVarResponse = Client.Get<ProviderArrayWrapper>("/api/2.0/files/thirdparty/providers", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAllProviders", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all third-party providers
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage services this portal can connect, with everything a connection form needs: the  display name, the key to send as `providerKey`, whether the service authenticates through OAuth 2.0, the OAuth  client ID and redirect URL where it does, and whether the caller has to supply the server address. Several  WebDAV presets share the key `WebDav` and are told apart by their names, so keep the name the caller chose  next to the key when building the request. Pass `excludewebdav=true` to drop the whole WebDAV family,  including the kDrive and Yandex presets, and keep only the OAuth services. The call is read-only. An empty  array is a normal answer: it is what a guest gets, and what everyone gets while the portal-wide third-party  switch is off (`PUT api/2.0/files/thirdparty`). The `connected` flag of an element says the service is  available on this portal, not that an account of it exists - the caller's own accounts are listed by  `GET api/2.0/files/thirdparty`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="excludewebdav">Set to true to leave out the whole WebDAV family, the kDrive and Yandex presets included, and keep only the  services that authenticate through OAuth 2.0; false lists all of them. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-providers/">REST API Reference for GetAllProviders Operation</seealso>
        /// <returns>Task of ProviderArrayWrapper</returns>
        public async Task<ProviderArrayWrapper> GetAllProvidersAsync(bool? excludewebdav = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAllProvidersWithHttpInfoAsync(excludewebdav, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all third-party providers
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage services this portal can connect, with everything a connection form needs: the  display name, the key to send as `providerKey`, whether the service authenticates through OAuth 2.0, the OAuth  client ID and redirect URL where it does, and whether the caller has to supply the server address. Several  WebDAV presets share the key `WebDav` and are told apart by their names, so keep the name the caller chose  next to the key when building the request. Pass `excludewebdav=true` to drop the whole WebDAV family,  including the kDrive and Yandex presets, and keep only the OAuth services. The call is read-only. An empty  array is a normal answer: it is what a guest gets, and what everyone gets while the portal-wide third-party  switch is off (`PUT api/2.0/files/thirdparty`). The `connected` flag of an element says the service is  available on this portal, not that an account of it exists - the caller's own accounts are listed by  `GET api/2.0/files/thirdparty`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="excludewebdav">Set to true to leave out the whole WebDAV family, the kDrive and Yandex presets included, and keep only the  services that authenticate through OAuth 2.0; false lists all of them. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-providers/">REST API Reference for GetAllProviders Operation</seealso>
        /// <returns>Task of ApiResponse (ProviderArrayWrapper)</returns>
        public async Task<ApiResponse<ProviderArrayWrapper>> GetAllProvidersWithHttpInfoAsync(bool? excludewebdav = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (excludewebdav != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludewebdav", excludewebdav));
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

            var localVarResponse = await AsynchronousClient.GetAsync<ProviderArrayWrapper>("/api/2.0/files/thirdparty/providers", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAllProviders", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the third-party backup folder
        /// </summary>
        /// <remarks>
        /// Returns the folder of the third-party storage account the portal keeps for backups, so a caller can check  where scheduled and manual backups are written. There is at most one such account per portal, connected by an  administrator through `POST api/2.0/files/thirdparty/backup`, and it is deliberately kept out of the personal  list of `GET api/2.0/files/thirdparty`. Any authenticated member may ask, and the call is read-only. The body  is `null`, with a successful status, in two situations the answer does not distinguish: no backup account has  been connected, and the caller has no read access to the folder of the one that is. When a folder does come  back, its `id` is the string ID of a third-party folder and can be used with the folder operations that accept  one, and its `title` is the title the account was saved under. Connecting a different account through the  backup operation replaces this one rather than adding a second, and  `DELETE api/2.0/files/thirdparty/{providerId}` removes it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-backup-third-party-account/">REST API Reference for GetBackupThirdPartyAccount Operation</seealso>
        /// <returns>FolderStringWrapper</returns>
        public FolderStringWrapper GetBackupThirdPartyAccount()
        {
            var localVarResponse = GetBackupThirdPartyAccountWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the third-party backup folder
        /// </summary>
        /// <remarks>
        /// Returns the folder of the third-party storage account the portal keeps for backups, so a caller can check  where scheduled and manual backups are written. There is at most one such account per portal, connected by an  administrator through `POST api/2.0/files/thirdparty/backup`, and it is deliberately kept out of the personal  list of `GET api/2.0/files/thirdparty`. Any authenticated member may ask, and the call is read-only. The body  is `null`, with a successful status, in two situations the answer does not distinguish: no backup account has  been connected, and the caller has no read access to the folder of the one that is. When a folder does come  back, its `id` is the string ID of a third-party folder and can be used with the folder operations that accept  one, and its `title` is the title the account was saved under. Connecting a different account through the  backup operation replaces this one rather than adding a second, and  `DELETE api/2.0/files/thirdparty/{providerId}` removes it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-backup-third-party-account/">REST API Reference for GetBackupThirdPartyAccount Operation</seealso>
        /// <returns>ApiResponse of FolderStringWrapper</returns>
        public ApiResponse<FolderStringWrapper> GetBackupThirdPartyAccountWithHttpInfo()
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
            var localVarResponse = Client.Get<FolderStringWrapper>("/api/2.0/files/thirdparty/backup", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetBackupThirdPartyAccount", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the third-party backup folder
        /// </summary>
        /// <remarks>
        /// Returns the folder of the third-party storage account the portal keeps for backups, so a caller can check  where scheduled and manual backups are written. There is at most one such account per portal, connected by an  administrator through `POST api/2.0/files/thirdparty/backup`, and it is deliberately kept out of the personal  list of `GET api/2.0/files/thirdparty`. Any authenticated member may ask, and the call is read-only. The body  is `null`, with a successful status, in two situations the answer does not distinguish: no backup account has  been connected, and the caller has no read access to the folder of the one that is. When a folder does come  back, its `id` is the string ID of a third-party folder and can be used with the folder operations that accept  one, and its `title` is the title the account was saved under. Connecting a different account through the  backup operation replaces this one rather than adding a second, and  `DELETE api/2.0/files/thirdparty/{providerId}` removes it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-backup-third-party-account/">REST API Reference for GetBackupThirdPartyAccount Operation</seealso>
        /// <returns>Task of FolderStringWrapper</returns>
        public async Task<FolderStringWrapper> GetBackupThirdPartyAccountAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetBackupThirdPartyAccountWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the third-party backup folder
        /// </summary>
        /// <remarks>
        /// Returns the folder of the third-party storage account the portal keeps for backups, so a caller can check  where scheduled and manual backups are written. There is at most one such account per portal, connected by an  administrator through `POST api/2.0/files/thirdparty/backup`, and it is deliberately kept out of the personal  list of `GET api/2.0/files/thirdparty`. Any authenticated member may ask, and the call is read-only. The body  is `null`, with a successful status, in two situations the answer does not distinguish: no backup account has  been connected, and the caller has no read access to the folder of the one that is. When a folder does come  back, its `id` is the string ID of a third-party folder and can be used with the folder operations that accept  one, and its `title` is the title the account was saved under. Connecting a different account through the  backup operation replaces this one rather than adding a second, and  `DELETE api/2.0/files/thirdparty/{providerId}` removes it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-backup-third-party-account/">REST API Reference for GetBackupThirdPartyAccount Operation</seealso>
        /// <returns>Task of ApiResponse (FolderStringWrapper)</returns>
        public async Task<ApiResponse<FolderStringWrapper>> GetBackupThirdPartyAccountWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<FolderStringWrapper>("/api/2.0/files/thirdparty/backup", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetBackupThirdPartyAccount", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get third-party provider capabilities
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage services this portal is able to connect, in the compact form a connection dialog  needs. Every element is itself an array whose first item is the provider key accepted as `providerKey` by  `POST api/2.0/files/thirdparty`. For the services that authenticate through OAuth 2.0 (`Box`, `DropboxV2`,  `GoogleDrive`, `OneDrive`) the second and third items are the OAuth client ID and the redirect URL this portal  is registered with, so the caller can build the consent screen URL itself; the services that authenticate by  login and password (`SharePoint`, `WebDav`, `kDrive`, `Yandex`) contribute a single-item array. Only the  services enabled in the portal configuration are listed, and an OAuth service whose application is not  configured is left out. The call is read-only. An empty array is a normal answer rather than a failure: it is  what a guest gets, and what everyone gets while the portal-wide third-party switch is off  (`PUT api/2.0/files/thirdparty`). For display names, the WebDAV presets and the flags a connection form needs,  use `GET api/2.0/files/thirdparty/providers` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-capabilities/">REST API Reference for GetCapabilities Operation</seealso>
        /// <returns>ArrayArrayWrapper</returns>
        public ArrayArrayWrapper GetCapabilities()
        {
            var localVarResponse = GetCapabilitiesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get third-party provider capabilities
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage services this portal is able to connect, in the compact form a connection dialog  needs. Every element is itself an array whose first item is the provider key accepted as `providerKey` by  `POST api/2.0/files/thirdparty`. For the services that authenticate through OAuth 2.0 (`Box`, `DropboxV2`,  `GoogleDrive`, `OneDrive`) the second and third items are the OAuth client ID and the redirect URL this portal  is registered with, so the caller can build the consent screen URL itself; the services that authenticate by  login and password (`SharePoint`, `WebDav`, `kDrive`, `Yandex`) contribute a single-item array. Only the  services enabled in the portal configuration are listed, and an OAuth service whose application is not  configured is left out. The call is read-only. An empty array is a normal answer rather than a failure: it is  what a guest gets, and what everyone gets while the portal-wide third-party switch is off  (`PUT api/2.0/files/thirdparty`). For display names, the WebDAV presets and the flags a connection form needs,  use `GET api/2.0/files/thirdparty/providers` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-capabilities/">REST API Reference for GetCapabilities Operation</seealso>
        /// <returns>ApiResponse of ArrayArrayWrapper</returns>
        public ApiResponse<ArrayArrayWrapper> GetCapabilitiesWithHttpInfo()
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
            var localVarResponse = Client.Get<ArrayArrayWrapper>("/api/2.0/files/thirdparty/capabilities", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCapabilities", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get third-party provider capabilities
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage services this portal is able to connect, in the compact form a connection dialog  needs. Every element is itself an array whose first item is the provider key accepted as `providerKey` by  `POST api/2.0/files/thirdparty`. For the services that authenticate through OAuth 2.0 (`Box`, `DropboxV2`,  `GoogleDrive`, `OneDrive`) the second and third items are the OAuth client ID and the redirect URL this portal  is registered with, so the caller can build the consent screen URL itself; the services that authenticate by  login and password (`SharePoint`, `WebDav`, `kDrive`, `Yandex`) contribute a single-item array. Only the  services enabled in the portal configuration are listed, and an OAuth service whose application is not  configured is left out. The call is read-only. An empty array is a normal answer rather than a failure: it is  what a guest gets, and what everyone gets while the portal-wide third-party switch is off  (`PUT api/2.0/files/thirdparty`). For display names, the WebDAV presets and the flags a connection form needs,  use `GET api/2.0/files/thirdparty/providers` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-capabilities/">REST API Reference for GetCapabilities Operation</seealso>
        /// <returns>Task of ArrayArrayWrapper</returns>
        public async Task<ArrayArrayWrapper> GetCapabilitiesAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetCapabilitiesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get third-party provider capabilities
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage services this portal is able to connect, in the compact form a connection dialog  needs. Every element is itself an array whose first item is the provider key accepted as `providerKey` by  `POST api/2.0/files/thirdparty`. For the services that authenticate through OAuth 2.0 (`Box`, `DropboxV2`,  `GoogleDrive`, `OneDrive`) the second and third items are the OAuth client ID and the redirect URL this portal  is registered with, so the caller can build the consent screen URL itself; the services that authenticate by  login and password (`SharePoint`, `WebDav`, `kDrive`, `Yandex`) contribute a single-item array. Only the  services enabled in the portal configuration are listed, and an OAuth service whose application is not  configured is left out. The call is read-only. An empty array is a normal answer rather than a failure: it is  what a guest gets, and what everyone gets while the portal-wide third-party switch is off  (`PUT api/2.0/files/thirdparty`). For display names, the WebDAV presets and the flags a connection form needs,  use `GET api/2.0/files/thirdparty/providers` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-capabilities/">REST API Reference for GetCapabilities Operation</seealso>
        /// <returns>Task of ApiResponse (ArrayArrayWrapper)</returns>
        public async Task<ApiResponse<ArrayArrayWrapper>> GetCapabilitiesWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<ArrayArrayWrapper>("/api/2.0/files/thirdparty/capabilities", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCapabilities", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get common third-party folders
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage accounts attached to the legacy Common section, as folder entries that can be  browsed with the usual folder operations. Each entry stands for a whole connected account: its title is the  account title, and `providerId` and `providerKey` identify the account behind it. Only accounts whose owner  the caller may read are included, so the answer differs from one member to another. The call is read-only and  returns a plain array with no paging. An empty array is the expected answer in most portals and does not mean  an error: accounts connected by `POST api/2.0/files/thirdparty` are attached to the Rooms section, not to  Common, so only accounts inherited from an older portal appear here. The list is also empty while the  portal-wide third-party switch is off (`PUT api/2.0/files/thirdparty`) and when no storage service is  configured. For the accounts the caller owns, regardless of where they are attached, use  `GET api/2.0/files/thirdparty`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-common-third-party-folders/">REST API Reference for GetCommonThirdPartyFolders Operation</seealso>
        /// <returns>FolderStringArrayWrapper</returns>
        public FolderStringArrayWrapper GetCommonThirdPartyFolders()
        {
            var localVarResponse = GetCommonThirdPartyFoldersWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get common third-party folders
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage accounts attached to the legacy Common section, as folder entries that can be  browsed with the usual folder operations. Each entry stands for a whole connected account: its title is the  account title, and `providerId` and `providerKey` identify the account behind it. Only accounts whose owner  the caller may read are included, so the answer differs from one member to another. The call is read-only and  returns a plain array with no paging. An empty array is the expected answer in most portals and does not mean  an error: accounts connected by `POST api/2.0/files/thirdparty` are attached to the Rooms section, not to  Common, so only accounts inherited from an older portal appear here. The list is also empty while the  portal-wide third-party switch is off (`PUT api/2.0/files/thirdparty`) and when no storage service is  configured. For the accounts the caller owns, regardless of where they are attached, use  `GET api/2.0/files/thirdparty`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-common-third-party-folders/">REST API Reference for GetCommonThirdPartyFolders Operation</seealso>
        /// <returns>ApiResponse of FolderStringArrayWrapper</returns>
        public ApiResponse<FolderStringArrayWrapper> GetCommonThirdPartyFoldersWithHttpInfo()
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
            var localVarResponse = Client.Get<FolderStringArrayWrapper>("/api/2.0/files/thirdparty/common", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCommonThirdPartyFolders", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get common third-party folders
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage accounts attached to the legacy Common section, as folder entries that can be  browsed with the usual folder operations. Each entry stands for a whole connected account: its title is the  account title, and `providerId` and `providerKey` identify the account behind it. Only accounts whose owner  the caller may read are included, so the answer differs from one member to another. The call is read-only and  returns a plain array with no paging. An empty array is the expected answer in most portals and does not mean  an error: accounts connected by `POST api/2.0/files/thirdparty` are attached to the Rooms section, not to  Common, so only accounts inherited from an older portal appear here. The list is also empty while the  portal-wide third-party switch is off (`PUT api/2.0/files/thirdparty`) and when no storage service is  configured. For the accounts the caller owns, regardless of where they are attached, use  `GET api/2.0/files/thirdparty`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-common-third-party-folders/">REST API Reference for GetCommonThirdPartyFolders Operation</seealso>
        /// <returns>Task of FolderStringArrayWrapper</returns>
        public async Task<FolderStringArrayWrapper> GetCommonThirdPartyFoldersAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetCommonThirdPartyFoldersWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get common third-party folders
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage accounts attached to the legacy Common section, as folder entries that can be  browsed with the usual folder operations. Each entry stands for a whole connected account: its title is the  account title, and `providerId` and `providerKey` identify the account behind it. Only accounts whose owner  the caller may read are included, so the answer differs from one member to another. The call is read-only and  returns a plain array with no paging. An empty array is the expected answer in most portals and does not mean  an error: accounts connected by `POST api/2.0/files/thirdparty` are attached to the Rooms section, not to  Common, so only accounts inherited from an older portal appear here. The list is also empty while the  portal-wide third-party switch is off (`PUT api/2.0/files/thirdparty`) and when no storage service is  configured. For the accounts the caller owns, regardless of where they are attached, use  `GET api/2.0/files/thirdparty`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-common-third-party-folders/">REST API Reference for GetCommonThirdPartyFolders Operation</seealso>
        /// <returns>Task of ApiResponse (FolderStringArrayWrapper)</returns>
        public async Task<ApiResponse<FolderStringArrayWrapper>> GetCommonThirdPartyFoldersWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<FolderStringArrayWrapper>("/api/2.0/files/thirdparty/common", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetCommonThirdPartyFolders", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the third-party accounts
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage accounts the caller has connected, one element per account, with the title it  was saved under, the storage service behind it and the portal section it is attached to. Accounts connected by  other members are not included, and neither is the portal backup account of  `GET api/2.0/files/thirdparty/backup`, even for an administrator. The `providerId` of an element is the value  to send to `DELETE api/2.0/files/thirdparty/{providerId}` and, as `providerId` in  `POST api/2.0/files/thirdparty`, the way to re-authenticate that same account instead of connecting a new one.  Credentials are never disclosed: `auth_data` comes back empty for every element. An element with  `roomsStorage` set is available as storage for a room, while `corporate` marks an account inherited from the  legacy Common section. The call is read-only, returns a plain array with no paging and no contractual  ordering, and answers with an empty array when the caller has connected nothing. To browse the content of an  account, take the folder ID from the answer of the operation that connected it or from  `GET api/2.0/files/@root`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-third-party-accounts/">REST API Reference for GetThirdPartyAccounts Operation</seealso>
        /// <returns>ThirdPartyParamsArrayWrapper</returns>
        public ThirdPartyParamsArrayWrapper GetThirdPartyAccounts()
        {
            var localVarResponse = GetThirdPartyAccountsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the third-party accounts
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage accounts the caller has connected, one element per account, with the title it  was saved under, the storage service behind it and the portal section it is attached to. Accounts connected by  other members are not included, and neither is the portal backup account of  `GET api/2.0/files/thirdparty/backup`, even for an administrator. The `providerId` of an element is the value  to send to `DELETE api/2.0/files/thirdparty/{providerId}` and, as `providerId` in  `POST api/2.0/files/thirdparty`, the way to re-authenticate that same account instead of connecting a new one.  Credentials are never disclosed: `auth_data` comes back empty for every element. An element with  `roomsStorage` set is available as storage for a room, while `corporate` marks an account inherited from the  legacy Common section. The call is read-only, returns a plain array with no paging and no contractual  ordering, and answers with an empty array when the caller has connected nothing. To browse the content of an  account, take the folder ID from the answer of the operation that connected it or from  `GET api/2.0/files/@root`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-third-party-accounts/">REST API Reference for GetThirdPartyAccounts Operation</seealso>
        /// <returns>ApiResponse of ThirdPartyParamsArrayWrapper</returns>
        public ApiResponse<ThirdPartyParamsArrayWrapper> GetThirdPartyAccountsWithHttpInfo()
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
            var localVarResponse = Client.Get<ThirdPartyParamsArrayWrapper>("/api/2.0/files/thirdparty", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetThirdPartyAccounts", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the third-party accounts
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage accounts the caller has connected, one element per account, with the title it  was saved under, the storage service behind it and the portal section it is attached to. Accounts connected by  other members are not included, and neither is the portal backup account of  `GET api/2.0/files/thirdparty/backup`, even for an administrator. The `providerId` of an element is the value  to send to `DELETE api/2.0/files/thirdparty/{providerId}` and, as `providerId` in  `POST api/2.0/files/thirdparty`, the way to re-authenticate that same account instead of connecting a new one.  Credentials are never disclosed: `auth_data` comes back empty for every element. An element with  `roomsStorage` set is available as storage for a room, while `corporate` marks an account inherited from the  legacy Common section. The call is read-only, returns a plain array with no paging and no contractual  ordering, and answers with an empty array when the caller has connected nothing. To browse the content of an  account, take the folder ID from the answer of the operation that connected it or from  `GET api/2.0/files/@root`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-third-party-accounts/">REST API Reference for GetThirdPartyAccounts Operation</seealso>
        /// <returns>Task of ThirdPartyParamsArrayWrapper</returns>
        public async Task<ThirdPartyParamsArrayWrapper> GetThirdPartyAccountsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetThirdPartyAccountsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the third-party accounts
        /// </summary>
        /// <remarks>
        /// Lists the third-party storage accounts the caller has connected, one element per account, with the title it  was saved under, the storage service behind it and the portal section it is attached to. Accounts connected by  other members are not included, and neither is the portal backup account of  `GET api/2.0/files/thirdparty/backup`, even for an administrator. The `providerId` of an element is the value  to send to `DELETE api/2.0/files/thirdparty/{providerId}` and, as `providerId` in  `POST api/2.0/files/thirdparty`, the way to re-authenticate that same account instead of connecting a new one.  Credentials are never disclosed: `auth_data` comes back empty for every element. An element with  `roomsStorage` set is available as storage for a room, while `corporate` marks an account inherited from the  legacy Common section. The call is read-only, returns a plain array with no paging and no contractual  ordering, and answers with an empty array when the caller has connected nothing. To browse the content of an  account, take the folder ID from the answer of the operation that connected it or from  `GET api/2.0/files/@root`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-third-party-accounts/">REST API Reference for GetThirdPartyAccounts Operation</seealso>
        /// <returns>Task of ApiResponse (ThirdPartyParamsArrayWrapper)</returns>
        public async Task<ApiResponse<ThirdPartyParamsArrayWrapper>> GetThirdPartyAccountsWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<ThirdPartyParamsArrayWrapper>("/api/2.0/files/thirdparty", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetThirdPartyAccounts", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Connect a third-party account
        /// </summary>
        /// <remarks>
        /// Connects an account at a third-party storage service to the portal, or re-authenticates one that is already  connected, and returns the folder that now stands for its root. Send `providerId` to update an existing  account and omit it to connect a new one; the accepted `providerKey` values come from  `GET api/2.0/files/thirdparty/providers`. The credentials to send depend on the service: the OAuth services  take `token`, which is the authorization code from their consent screen and not an access token, while the  WebDAV family and SharePoint take `login` with `password`, plus `url` where the server address is not fixed.  Credentials are verified against the service before anything is stored, so a wrong password is refused and  nothing is saved. The caller needs the rights to create rooms, and the portal-wide third-party switch has to  be on, otherwise the call is refused. A new account is attached to the Rooms section and becomes available as  room storage for `POST api/2.0/files/rooms/thirdparty/{id}`. Connecting twice with the same title creates two  separate accounts.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyRequestDto">The credentials and the title of a third-party storage account to connect or to re-authenticate. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-third-party/">REST API Reference for SaveThirdParty Operation</seealso>
        /// <returns>FolderStringWrapper</returns>
        public FolderStringWrapper SaveThirdParty(ThirdPartyRequestDto? thirdPartyRequestDto = default)
        {
            var localVarResponse = SaveThirdPartyWithHttpInfo(thirdPartyRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Connect a third-party account
        /// </summary>
        /// <remarks>
        /// Connects an account at a third-party storage service to the portal, or re-authenticates one that is already  connected, and returns the folder that now stands for its root. Send `providerId` to update an existing  account and omit it to connect a new one; the accepted `providerKey` values come from  `GET api/2.0/files/thirdparty/providers`. The credentials to send depend on the service: the OAuth services  take `token`, which is the authorization code from their consent screen and not an access token, while the  WebDAV family and SharePoint take `login` with `password`, plus `url` where the server address is not fixed.  Credentials are verified against the service before anything is stored, so a wrong password is refused and  nothing is saved. The caller needs the rights to create rooms, and the portal-wide third-party switch has to  be on, otherwise the call is refused. A new account is attached to the Rooms section and becomes available as  room storage for `POST api/2.0/files/rooms/thirdparty/{id}`. Connecting twice with the same title creates two  separate accounts.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyRequestDto">The credentials and the title of a third-party storage account to connect or to re-authenticate. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-third-party/">REST API Reference for SaveThirdParty Operation</seealso>
        /// <returns>ApiResponse of FolderStringWrapper</returns>
        public ApiResponse<FolderStringWrapper> SaveThirdPartyWithHttpInfo(ThirdPartyRequestDto? thirdPartyRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (thirdPartyRequestDto != null) localVarRequestOptions.Data = thirdPartyRequestDto;

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
            var localVarResponse = Client.Post<FolderStringWrapper>("/api/2.0/files/thirdparty", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SaveThirdParty", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Connect a third-party account
        /// </summary>
        /// <remarks>
        /// Connects an account at a third-party storage service to the portal, or re-authenticates one that is already  connected, and returns the folder that now stands for its root. Send `providerId` to update an existing  account and omit it to connect a new one; the accepted `providerKey` values come from  `GET api/2.0/files/thirdparty/providers`. The credentials to send depend on the service: the OAuth services  take `token`, which is the authorization code from their consent screen and not an access token, while the  WebDAV family and SharePoint take `login` with `password`, plus `url` where the server address is not fixed.  Credentials are verified against the service before anything is stored, so a wrong password is refused and  nothing is saved. The caller needs the rights to create rooms, and the portal-wide third-party switch has to  be on, otherwise the call is refused. A new account is attached to the Rooms section and becomes available as  room storage for `POST api/2.0/files/rooms/thirdparty/{id}`. Connecting twice with the same title creates two  separate accounts.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyRequestDto">The credentials and the title of a third-party storage account to connect or to re-authenticate. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-third-party/">REST API Reference for SaveThirdParty Operation</seealso>
        /// <returns>Task of FolderStringWrapper</returns>
        public async Task<FolderStringWrapper> SaveThirdPartyAsync(ThirdPartyRequestDto? thirdPartyRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SaveThirdPartyWithHttpInfoAsync(thirdPartyRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Connect a third-party account
        /// </summary>
        /// <remarks>
        /// Connects an account at a third-party storage service to the portal, or re-authenticates one that is already  connected, and returns the folder that now stands for its root. Send `providerId` to update an existing  account and omit it to connect a new one; the accepted `providerKey` values come from  `GET api/2.0/files/thirdparty/providers`. The credentials to send depend on the service: the OAuth services  take `token`, which is the authorization code from their consent screen and not an access token, while the  WebDAV family and SharePoint take `login` with `password`, plus `url` where the server address is not fixed.  Credentials are verified against the service before anything is stored, so a wrong password is refused and  nothing is saved. The caller needs the rights to create rooms, and the portal-wide third-party switch has to  be on, otherwise the call is refused. A new account is attached to the Rooms section and becomes available as  room storage for `POST api/2.0/files/rooms/thirdparty/{id}`. Connecting twice with the same title creates two  separate accounts.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyRequestDto">The credentials and the title of a third-party storage account to connect or to re-authenticate. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-third-party/">REST API Reference for SaveThirdParty Operation</seealso>
        /// <returns>Task of ApiResponse (FolderStringWrapper)</returns>
        public async Task<ApiResponse<FolderStringWrapper>> SaveThirdPartyWithHttpInfoAsync(ThirdPartyRequestDto? thirdPartyRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (thirdPartyRequestDto != null) localVarRequestOptions.Data = thirdPartyRequestDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<FolderStringWrapper>("/api/2.0/files/thirdparty", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SaveThirdParty", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Connect the third-party backup storage
        /// </summary>
        /// <remarks>
        /// Connects the third-party storage account the portal writes its backups to, and returns the folder that stands  for its root. Only a portal administrator may call it, and the portal-wide third-party switch has to be on;  other callers are refused. The account is portal-wide and single: a second call does not add another one but  re-authenticates and retitles the existing one, which makes the operation safe to repeat with the same body.  The credentials follow the same rules as in `POST api/2.0/files/thirdparty` - an authorization code in `token`  for the OAuth services, `login` with `password` and, where the server address is not fixed, `url` for the  WebDAV family and SharePoint - and are verified against the service before anything is stored, so a wrong  password leaves the previous account untouched. The account is deliberately absent from  `GET api/2.0/files/thirdparty`; read it back with `GET api/2.0/files/thirdparty/backup` and remove it with  `DELETE api/2.0/files/thirdparty/{providerId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyBackupRequestDto">The credentials and the title of the third-party storage account the portal writes its backups to. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-third-party-backup/">REST API Reference for SaveThirdPartyBackup Operation</seealso>
        /// <returns>FolderStringWrapper</returns>
        public FolderStringWrapper SaveThirdPartyBackup(ThirdPartyBackupRequestDto? thirdPartyBackupRequestDto = default)
        {
            var localVarResponse = SaveThirdPartyBackupWithHttpInfo(thirdPartyBackupRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Connect the third-party backup storage
        /// </summary>
        /// <remarks>
        /// Connects the third-party storage account the portal writes its backups to, and returns the folder that stands  for its root. Only a portal administrator may call it, and the portal-wide third-party switch has to be on;  other callers are refused. The account is portal-wide and single: a second call does not add another one but  re-authenticates and retitles the existing one, which makes the operation safe to repeat with the same body.  The credentials follow the same rules as in `POST api/2.0/files/thirdparty` - an authorization code in `token`  for the OAuth services, `login` with `password` and, where the server address is not fixed, `url` for the  WebDAV family and SharePoint - and are verified against the service before anything is stored, so a wrong  password leaves the previous account untouched. The account is deliberately absent from  `GET api/2.0/files/thirdparty`; read it back with `GET api/2.0/files/thirdparty/backup` and remove it with  `DELETE api/2.0/files/thirdparty/{providerId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyBackupRequestDto">The credentials and the title of the third-party storage account the portal writes its backups to. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-third-party-backup/">REST API Reference for SaveThirdPartyBackup Operation</seealso>
        /// <returns>ApiResponse of FolderStringWrapper</returns>
        public ApiResponse<FolderStringWrapper> SaveThirdPartyBackupWithHttpInfo(ThirdPartyBackupRequestDto? thirdPartyBackupRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (thirdPartyBackupRequestDto != null) localVarRequestOptions.Data = thirdPartyBackupRequestDto;

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
            var localVarResponse = Client.Post<FolderStringWrapper>("/api/2.0/files/thirdparty/backup", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SaveThirdPartyBackup", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Connect the third-party backup storage
        /// </summary>
        /// <remarks>
        /// Connects the third-party storage account the portal writes its backups to, and returns the folder that stands  for its root. Only a portal administrator may call it, and the portal-wide third-party switch has to be on;  other callers are refused. The account is portal-wide and single: a second call does not add another one but  re-authenticates and retitles the existing one, which makes the operation safe to repeat with the same body.  The credentials follow the same rules as in `POST api/2.0/files/thirdparty` - an authorization code in `token`  for the OAuth services, `login` with `password` and, where the server address is not fixed, `url` for the  WebDAV family and SharePoint - and are verified against the service before anything is stored, so a wrong  password leaves the previous account untouched. The account is deliberately absent from  `GET api/2.0/files/thirdparty`; read it back with `GET api/2.0/files/thirdparty/backup` and remove it with  `DELETE api/2.0/files/thirdparty/{providerId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyBackupRequestDto">The credentials and the title of the third-party storage account the portal writes its backups to. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-third-party-backup/">REST API Reference for SaveThirdPartyBackup Operation</seealso>
        /// <returns>Task of FolderStringWrapper</returns>
        public async Task<FolderStringWrapper> SaveThirdPartyBackupAsync(ThirdPartyBackupRequestDto? thirdPartyBackupRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SaveThirdPartyBackupWithHttpInfoAsync(thirdPartyBackupRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Connect the third-party backup storage
        /// </summary>
        /// <remarks>
        /// Connects the third-party storage account the portal writes its backups to, and returns the folder that stands  for its root. Only a portal administrator may call it, and the portal-wide third-party switch has to be on;  other callers are refused. The account is portal-wide and single: a second call does not add another one but  re-authenticates and retitles the existing one, which makes the operation safe to repeat with the same body.  The credentials follow the same rules as in `POST api/2.0/files/thirdparty` - an authorization code in `token`  for the OAuth services, `login` with `password` and, where the server address is not fixed, `url` for the  WebDAV family and SharePoint - and are verified against the service before anything is stored, so a wrong  password leaves the previous account untouched. The account is deliberately absent from  `GET api/2.0/files/thirdparty`; read it back with `GET api/2.0/files/thirdparty/backup` and remove it with  `DELETE api/2.0/files/thirdparty/{providerId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyBackupRequestDto">The credentials and the title of the third-party storage account the portal writes its backups to. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-third-party-backup/">REST API Reference for SaveThirdPartyBackup Operation</seealso>
        /// <returns>Task of ApiResponse (FolderStringWrapper)</returns>
        public async Task<ApiResponse<FolderStringWrapper>> SaveThirdPartyBackupWithHttpInfoAsync(ThirdPartyBackupRequestDto? thirdPartyBackupRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (thirdPartyBackupRequestDto != null) localVarRequestOptions.Data = thirdPartyBackupRequestDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<FolderStringWrapper>("/api/2.0/files/thirdparty/backup", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SaveThirdPartyBackup", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
