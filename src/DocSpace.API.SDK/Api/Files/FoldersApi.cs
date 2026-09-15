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
    public interface IFoldersApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Check for upload conflicts
        /// </summary>
        /// <remarks>
        /// Reports which of the submitted titles already belong to a file in the folder, so an upload can decide in  advance whether to overwrite or to ask for another name. Only the clashing titles come back, unordered and  without repetitions, and an empty array means every name is free. Matching is by title and ignores case, so a  name that differs only in capitalisation is still reported; an existing file that is encrypted is left out,  because an upload cannot take it over. The call changes nothing. It needs the same right as the upload itself,  the right to add content to the folder, which room managers and content creators have and readers, editors and  guests do not; an archived room, a section root and a folder the caller cannot write to are all refused, while  an unknown folder is answered as missing. A request without `filesTitle` is rejected as an invalid request, an  empty list is accepted and answers with an empty array.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose contents the names are tested against; take the id from a listing such as  `GET api/2.0/files/@root`.</param>
        /// <param name="checkUploadRequest">The names to test against the files the folder already holds.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-upload/">REST API Reference for CheckUpload Operation</seealso>
        /// <returns>STRINGArrayWrapper</returns>
        STRINGArrayWrapper CheckUpload(int folderId, CheckUploadRequest checkUploadRequest);

        /// <summary>
        /// Check for upload conflicts
        /// </summary>
        /// <remarks>
        /// Reports which of the submitted titles already belong to a file in the folder, so an upload can decide in  advance whether to overwrite or to ask for another name. Only the clashing titles come back, unordered and  without repetitions, and an empty array means every name is free. Matching is by title and ignores case, so a  name that differs only in capitalisation is still reported; an existing file that is encrypted is left out,  because an upload cannot take it over. The call changes nothing. It needs the same right as the upload itself,  the right to add content to the folder, which room managers and content creators have and readers, editors and  guests do not; an archived room, a section root and a folder the caller cannot write to are all refused, while  an unknown folder is answered as missing. A request without `filesTitle` is rejected as an invalid request, an  empty list is accepted and answers with an empty array.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose contents the names are tested against; take the id from a listing such as  `GET api/2.0/files/@root`.</param>
        /// <param name="checkUploadRequest">The names to test against the files the folder already holds.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-upload/">REST API Reference for CheckUpload Operation</seealso>
        /// <returns>ApiResponse of STRINGArrayWrapper</returns>
        ApiResponse<STRINGArrayWrapper> CheckUploadWithHttpInfo(int folderId, CheckUploadRequest checkUploadRequest);
        /// <summary>
        /// Create a folder
        /// </summary>
        /// <remarks>
        /// Creates a folder inside the folder named in the path and answers with the folder as it was stored. The title  is trimmed, may not be blank and is refused when it is longer than the limit the schema prints; titles are not  required to be unique, so creating the same title twice leaves two folders side by side, which makes the call  mutating and not idempotent. The caller needs the right to create content in the parent, which the room  manager, a content creator and the owner of a personal section have; a member without that right, an archived  parent, and a section root that only holds rooms - Rooms, Forms and AI agents - are all refused, as is a  parent that does not exist. Rooms are not created here: use `POST api/2.0/files/rooms` for those, and this  operation for ordinary folders within them. Members of the room are notified of the new folder. Read the  identifier of the new folder from `id` and fill it with `POST api/2.0/files/{folderId}/upload`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the request is addressed to: when a folder is created it is the parent that receives the new  folder, and when a folder is renamed it is the folder that gets the new title.</param>
        /// <param name="createFolder">The title carried by the request body.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder/">REST API Reference for CreateFolder Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper CreateFolder(int folderId, CreateFolder createFolder);

        /// <summary>
        /// Create a folder
        /// </summary>
        /// <remarks>
        /// Creates a folder inside the folder named in the path and answers with the folder as it was stored. The title  is trimmed, may not be blank and is refused when it is longer than the limit the schema prints; titles are not  required to be unique, so creating the same title twice leaves two folders side by side, which makes the call  mutating and not idempotent. The caller needs the right to create content in the parent, which the room  manager, a content creator and the owner of a personal section have; a member without that right, an archived  parent, and a section root that only holds rooms - Rooms, Forms and AI agents - are all refused, as is a  parent that does not exist. Rooms are not created here: use `POST api/2.0/files/rooms` for those, and this  operation for ordinary folders within them. Members of the room are notified of the new folder. Read the  identifier of the new folder from `id` and fill it with `POST api/2.0/files/{folderId}/upload`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the request is addressed to: when a folder is created it is the parent that receives the new  folder, and when a folder is renamed it is the folder that gets the new title.</param>
        /// <param name="createFolder">The title carried by the request body.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder/">REST API Reference for CreateFolder Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> CreateFolderWithHttpInfo(int folderId, CreateFolder createFolder);
        /// <summary>
        /// Create the folder primary external link
        /// </summary>
        /// <remarks>
        /// Answers with the primary external link of a folder or a room, creating it on the first call and returning the  one that already exists afterwards, so the operation is idempotent in effect: a second call with other  parameters does not reconfigure the existing link, and changing one is the business of  `PUT api/2.0/files/folder/{id}/links`. The parameters therefore only shape the link at the moment it is born -  `access` its rights, `title` its name, `expirationDate` its lifetime, which is unlimited here unless one is  given, `internal` whether only signed-in members may follow it, `denyDownload` whether the contents may only  be viewed, and `password` a secret to be asked for. Sending `access` with the value that grants nothing  creates no link and answers with nothing. The caller needs the right to manage the links of the room the  folder belongs to, which its manager and a portal administrator acting as room manager have, and a member with  content-creator or read access is refused with 403; an unknown folder is answered with 404. Read the address  from `sharedTo.shareLink`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the link belongs to.</param>
        /// <param name="folderLinkRequest">The link and the way it is to be shaped.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder-primary-external-link/">REST API Reference for CreateFolderPrimaryExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        FileShareWrapper CreateFolderPrimaryExternalLink(int id, FolderLinkRequest folderLinkRequest);

        /// <summary>
        /// Create the folder primary external link
        /// </summary>
        /// <remarks>
        /// Answers with the primary external link of a folder or a room, creating it on the first call and returning the  one that already exists afterwards, so the operation is idempotent in effect: a second call with other  parameters does not reconfigure the existing link, and changing one is the business of  `PUT api/2.0/files/folder/{id}/links`. The parameters therefore only shape the link at the moment it is born -  `access` its rights, `title` its name, `expirationDate` its lifetime, which is unlimited here unless one is  given, `internal` whether only signed-in members may follow it, `denyDownload` whether the contents may only  be viewed, and `password` a secret to be asked for. Sending `access` with the value that grants nothing  creates no link and answers with nothing. The caller needs the right to manage the links of the room the  folder belongs to, which its manager and a portal administrator acting as room manager have, and a member with  content-creator or read access is refused with 403; an unknown folder is answered with 404. Read the address  from `sharedTo.shareLink`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the link belongs to.</param>
        /// <param name="folderLinkRequest">The link and the way it is to be shaped.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder-primary-external-link/">REST API Reference for CreateFolderPrimaryExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        ApiResponse<FileShareWrapper> CreateFolderPrimaryExternalLinkWithHttpInfo(int id, FolderLinkRequest folderLinkRequest);
        /// <summary>
        /// Start the folder history report generation
        /// </summary>
        /// <remarks>
        /// Queues a background job that renders the history of a folder into a spreadsheet, or into a CSV file when  `format` asks for one, and saves the result in the caller's My documents. The answer is the queued task, not  the report: poll `GET api/2.0/files/folder/{folderId}/log/report` until `isCompleted` is true, then take the  file from `resultFileId`, `resultFileName` and `resultFileUrl`, of which a CSV report fills only the last two.  `from` and `to` limit the exported period; leaving both out exports the whole history. While a report for the  same folder and caller is still running, this call joins it and answers with the running task instead of  starting a second one, so retrying is safe. The caller needs read access to the folder and may not be a guest,  and the portal plan has to include the audit feature - otherwise the call is refused, with 403 for the access  rule and 404 for a folder that does not exist. Only a portal administrator gets the address, browser and  platform columns. Give up a running report with `DELETE api/2.0/files/folder/{folderId}/log/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose history is exported; the report covers the folder itself and the entries inside it.</param>
        /// <param name="format">The shape the report is written in: `Xlsx` produces a spreadsheet that is saved as a file of the portal, while  `Csv` produces a comma-separated text file that is uploaded to My documents without being reported back with  a file identifier. (optional)</param>
        /// <param name="from">The earliest moment an exported entry may have, read in the time zone of the portal; left out, the report  starts at the oldest entry the portal still keeps. (optional)</param>
        /// <param name="to">The latest moment an exported entry may have, read in the time zone of the portal; left out, the report ends  at the newest entry. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-report-folder-history/">REST API Reference for CreateReportFolderHistory Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        DocumentBuilderTaskWrapper CreateReportFolderHistory(int folderId, AuditReportFormat? format = default, DateTime? from = default, DateTime? to = default);

        /// <summary>
        /// Start the folder history report generation
        /// </summary>
        /// <remarks>
        /// Queues a background job that renders the history of a folder into a spreadsheet, or into a CSV file when  `format` asks for one, and saves the result in the caller's My documents. The answer is the queued task, not  the report: poll `GET api/2.0/files/folder/{folderId}/log/report` until `isCompleted` is true, then take the  file from `resultFileId`, `resultFileName` and `resultFileUrl`, of which a CSV report fills only the last two.  `from` and `to` limit the exported period; leaving both out exports the whole history. While a report for the  same folder and caller is still running, this call joins it and answers with the running task instead of  starting a second one, so retrying is safe. The caller needs read access to the folder and may not be a guest,  and the portal plan has to include the audit feature - otherwise the call is refused, with 403 for the access  rule and 404 for a folder that does not exist. Only a portal administrator gets the address, browser and  platform columns. Give up a running report with `DELETE api/2.0/files/folder/{folderId}/log/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose history is exported; the report covers the folder itself and the entries inside it.</param>
        /// <param name="format">The shape the report is written in: `Xlsx` produces a spreadsheet that is saved as a file of the portal, while  `Csv` produces a comma-separated text file that is uploaded to My documents without being reported back with  a file identifier. (optional)</param>
        /// <param name="from">The earliest moment an exported entry may have, read in the time zone of the portal; left out, the report  starts at the oldest entry the portal still keeps. (optional)</param>
        /// <param name="to">The latest moment an exported entry may have, read in the time zone of the portal; left out, the report ends  at the newest entry. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-report-folder-history/">REST API Reference for CreateReportFolderHistory Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        ApiResponse<DocumentBuilderTaskWrapper> CreateReportFolderHistoryWithHttpInfo(int folderId, AuditReportFormat? format = default, DateTime? from = default, DateTime? to = default);
        /// <summary>
        /// Delete a folder
        /// </summary>
        /// <remarks>
        /// Queues the deletion of one folder together with everything inside it, and answers with the file operations of  the caller, the one just created among them. The folder is not gone when the response arrives: poll  `GET api/2.0/files/fileops` until the operation reports `finished`, and read its `error` to learn whether the  deletion succeeded. By default the folder is moved to the Trash section, from where it can be restored;  `immediately=true` discards it for good instead, and inside a room, where there is no Trash, deletion is  always final. `deleteAfter=true` postpones the deletion until the editing sessions on the contents have ended,  so files somebody is working on are not pulled away. The caller needs the right to delete the folder, which  the room manager, a portal administrator acting as room manager and a content creator acting on a folder of  their own have; editing access alone, read access and a guest are refused. The call is destructive. To delete  several items at once use `PUT api/2.0/files/fileops/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder to delete, together with everything it holds.</param>
        /// <param name="deleteFolder">How the deletion is to be carried out.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-folder/">REST API Reference for DeleteFolder Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper DeleteFolder(int folderId, DeleteFolder deleteFolder);

        /// <summary>
        /// Delete a folder
        /// </summary>
        /// <remarks>
        /// Queues the deletion of one folder together with everything inside it, and answers with the file operations of  the caller, the one just created among them. The folder is not gone when the response arrives: poll  `GET api/2.0/files/fileops` until the operation reports `finished`, and read its `error` to learn whether the  deletion succeeded. By default the folder is moved to the Trash section, from where it can be restored;  `immediately=true` discards it for good instead, and inside a room, where there is no Trash, deletion is  always final. `deleteAfter=true` postpones the deletion until the editing sessions on the contents have ended,  so files somebody is working on are not pulled away. The caller needs the right to delete the folder, which  the room manager, a portal administrator acting as room manager and a content creator acting on a folder of  their own have; editing access alone, read access and a guest are refused. The call is destructive. To delete  several items at once use `PUT api/2.0/files/fileops/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder to delete, together with everything it holds.</param>
        /// <param name="deleteFolder">How the deletion is to be carried out.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-folder/">REST API Reference for DeleteFolder Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> DeleteFolderWithHttpInfo(int folderId, DeleteFolder deleteFolder);
        /// <summary>
        /// Generate XLSX report by folder
        /// </summary>
        /// <remarks>
        /// Rebuilds the spreadsheet that gathers the answers submitted to a form, starting from the Complete folder  that holds the filled copies. The answer names the original form the results belong to, says in `isNewFile`  whether the spreadsheet is being created or an existing one rewritten in place, and carries the queued job in  `task`; the file itself is not ready yet, so poll `GET api/2.0/files/file/{fileId}/xlsx` with the identifier  of the form until the task reports completion. The folder has to be the Complete folder of a form-filling  room and has to hold at least one submitted copy whose original form still exists, and the caller needs the  right to maintain that form, which the room manager has. A folder that does not exist, or one that holds  nothing to report on, is answered with 404, and a folder of the wrong kind or a caller without those rights  with 403. The call is mutating: it writes the results file of the form.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/generate-xlsx-by-folder/">REST API Reference for GenerateXlsxByFolder Operation</seealso>
        /// <returns>XlsxReportResponseWrapper</returns>
        XlsxReportResponseWrapper GenerateXlsxByFolder(int folderId);

        /// <summary>
        /// Generate XLSX report by folder
        /// </summary>
        /// <remarks>
        /// Rebuilds the spreadsheet that gathers the answers submitted to a form, starting from the Complete folder  that holds the filled copies. The answer names the original form the results belong to, says in `isNewFile`  whether the spreadsheet is being created or an existing one rewritten in place, and carries the queued job in  `task`; the file itself is not ready yet, so poll `GET api/2.0/files/file/{fileId}/xlsx` with the identifier  of the form until the task reports completion. The folder has to be the Complete folder of a form-filling  room and has to hold at least one submitted copy whose original form still exists, and the caller needs the  right to maintain that form, which the room manager has. A folder that does not exist, or one that holds  nothing to report on, is answered with 404, and a folder of the wrong kind or a caller without those rights  with 403. The call is mutating: it writes the results file of the form.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/generate-xlsx-by-folder/">REST API Reference for GenerateXlsxByFolder Operation</seealso>
        /// <returns>ApiResponse of XlsxReportResponseWrapper</returns>
        ApiResponse<XlsxReportResponseWrapper> GenerateXlsxByFolderWithHttpInfo(int folderId);
        /// <summary>
        /// Get the Favorites section
        /// </summary>
        /// <remarks>
        /// Returns the caller's own Favorites section: the files and folders this account has marked as favorite,  together with the section folder itself. Favorites are per-account, so the entries another member marked are  not listed here, and a guest sees only their own, usually empty, list. Mark a single file with  `GET api/2.0/files/favorites/{fileId}`, or add and remove batches of files and folders with  `POST api/2.0/files/favorites` and `DELETE api/2.0/files/favorites`. Nothing in the section is modified,  though passing `sortBy` saves the requested order as the default order for this account. Entries the caller  can no longer read, and entries that have been moved to the Trash section, drop out of the listing even  though their favorite mark stays, so the section can shrink without an explicit unmark. `folders` and `files`  hold one page of the section, `total` counts the entries matching the request before `count` and `startIndex`  are applied, and `current` describes the section folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the section unfiltered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-favorites-folder/">REST API Reference for GetFavoritesFolder Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        FolderContentIntegerWrapper GetFavoritesFolder(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);

        /// <summary>
        /// Get the Favorites section
        /// </summary>
        /// <remarks>
        /// Returns the caller's own Favorites section: the files and folders this account has marked as favorite,  together with the section folder itself. Favorites are per-account, so the entries another member marked are  not listed here, and a guest sees only their own, usually empty, list. Mark a single file with  `GET api/2.0/files/favorites/{fileId}`, or add and remove batches of files and folders with  `POST api/2.0/files/favorites` and `DELETE api/2.0/files/favorites`. Nothing in the section is modified,  though passing `sortBy` saves the requested order as the default order for this account. Entries the caller  can no longer read, and entries that have been moved to the Trash section, drop out of the listing even  though their favorite mark stays, so the section can shrink without an explicit unmark. `folders` and `files`  hold one page of the section, `total` counts the entries matching the request before `count` and `startIndex`  are applied, and `current` describes the section folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the section unfiltered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-favorites-folder/">REST API Reference for GetFavoritesFolder Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        ApiResponse<FolderContentIntegerWrapper> GetFavoritesFolderWithHttpInfo(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);
        /// <summary>
        /// Get used space of files
        /// </summary>
        /// <remarks>
        /// Reports how much storage the portal spends on documents, split by section - My documents, Trash, Rooms,  Archive and, where the feature is on, AI agents - each entry naming the section and the space it takes in  bytes. The figures cover the whole portal rather than the calling account, and moving an entry between  sections moves its space with it, which is why deleting a file to the Trash does not free anything until the  Trash is emptied. Only a caller who may change portal settings, that is the owner and the portal  administrators, is allowed here; a room administrator, an ordinary member and a guest are all refused. The  call is read-only, takes no parameters and answers with the sections in a fixed order. The quota of the portal  as a whole, storage outside documents included, is not part of this answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-used-space/">REST API Reference for GetFilesUsedSpace Operation</seealso>
        /// <returns>FilesStatisticsResultWrapper</returns>
        FilesStatisticsResultWrapper GetFilesUsedSpace();

        /// <summary>
        /// Get used space of files
        /// </summary>
        /// <remarks>
        /// Reports how much storage the portal spends on documents, split by section - My documents, Trash, Rooms,  Archive and, where the feature is on, AI agents - each entry naming the section and the space it takes in  bytes. The figures cover the whole portal rather than the calling account, and moving an entry between  sections moves its space with it, which is why deleting a file to the Trash does not free anything until the  Trash is emptied. Only a caller who may change portal settings, that is the owner and the portal  administrators, is allowed here; a room administrator, an ordinary member and a guest are all refused. The  call is read-only, takes no parameters and answers with the sections in a fixed order. The quota of the portal  as a whole, storage outside documents included, is not part of this answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-used-space/">REST API Reference for GetFilesUsedSpace Operation</seealso>
        /// <returns>ApiResponse of FilesStatisticsResultWrapper</returns>
        ApiResponse<FilesStatisticsResultWrapper> GetFilesUsedSpaceWithHttpInfo();
        /// <summary>
        /// Get folder form filter
        /// </summary>
        /// <remarks>
        /// Lists the fields the completed forms of a form-filling room carry, each of them a key and the kind of value  behind it, so that a client can offer them as filters. Feed a pair from this list back as `formsItemKey` and  `formsItemType` of `GET api/2.0/files/{folderId}` to keep only the completed forms whose field of that name  holds a value. The fields are read from the search index of one of the forms already gathered, so they appear  once indexing has caught up with the first submission. Only the Complete folder of a form-filling room  carries such fields: for any other folder, for a folder that does not exist and for one that has been deleted  the answer is an empty list rather than a refusal, and the same holds while nothing has been submitted yet.  The operation reads the index alone, changes nothing and needs no authorization.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder/">REST API Reference for GetFolder Operation</seealso>
        /// <returns>FormsItemArrayWrapper</returns>
        FormsItemArrayWrapper GetFolder(int folderId);

        /// <summary>
        /// Get folder form filter
        /// </summary>
        /// <remarks>
        /// Lists the fields the completed forms of a form-filling room carry, each of them a key and the kind of value  behind it, so that a client can offer them as filters. Feed a pair from this list back as `formsItemKey` and  `formsItemType` of `GET api/2.0/files/{folderId}` to keep only the completed forms whose field of that name  holds a value. The fields are read from the search index of one of the forms already gathered, so they appear  once indexing has caught up with the first submission. Only the Complete folder of a form-filling room  carries such fields: for any other folder, for a folder that does not exist and for one that has been deleted  the answer is an empty list rather than a refusal, and the same holds while nothing has been submitted yet.  The operation reads the index alone, changes nothing and needs no authorization.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder/">REST API Reference for GetFolder Operation</seealso>
        /// <returns>ApiResponse of FormsItemArrayWrapper</returns>
        ApiResponse<FormsItemArrayWrapper> GetFolderWithHttpInfo(int folderId);
        /// <summary>
        /// Get a folder by ID
        /// </summary>
        /// <remarks>
        /// Returns one page of the contents of a folder - its subfolders in `folders`, its files in `files`, the folder  itself in `current` and the chain of parents in `pathParts` - and is the operation a client browses the file  tree with. `filterType`, `filterValue`, `extension`, `userIdOrGroupId`, `sharedBy` and `folderType` narrow  what is listed, `applyFilterOption` decides whether those filters bite on the files, on the folders or on  both, and `withSubFolders`, which is on unless it is switched off, lets a narrowed request descend through the  whole subtree instead of the top level alone. `filterValue` is matched against titles and against indexed  document content, and indexing is asynchronous, so a file uploaded a moment ago can be missing from a search  for a short while. `count` and `startIndex` page through the result while `total` counts everything that  matches, and `sortBy` with `sortOrder` both order the page and are saved as the default order of the account.  Reading a room or an ordinary folder clears its new-item marks for the caller. A caller who may not read the  folder is answered with 403, and a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose contents are listed. Each section root has an operation of its own, such as  `GET api/2.0/files/@my`, and every other folder is opened by the identifier a listing gave for it.</param>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="sharedBy">Restricts the listing to the entries this member shared, which narrows a shared listing down to what one  person handed out. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, spreadsheets, images or one type of room.  Omit it to list every kind the folder holds. (optional)</param>
        /// <param name="roomId">Keeps only the entries that lie in this room, which matters when the listing being read gathers entries from  more than one of them. (optional)</param>
        /// <param name="folderType">Keeps only the folders of these kinds, each given as the number of a folder type; it is how a listing is  narrowed down to, say, the form-filling folders of a room. (optional)</param>
        /// <param name="excludeSubject">Turns `userIdOrGroupId` around: with true the entries of that member or group are the ones left out, with  false they are the only ones kept. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="withSubFolders">Whether a narrowed request reaches into the subfolders: with true, which is what an omitted parameter means,  matching entries are gathered from the whole subtree, with false only the top level is read. It makes a  difference only once `filterType`, `userIdOrGroupId` or `filterValue` narrows the request, because an  unfiltered listing always shows the top level alone. (optional)</param>
        /// <param name="extension">Keeps only the files carrying one of these extensions, several of them separated by commas; the leading dot is  optional. (optional)</param>
        /// <param name="searchArea">Which area a listing that spans several of them is taken from - the active rooms, the archive, the room  templates or the form-filling rooms. A folder that belongs to one area only settles the area itself and  ignores the parameter. (optional)</param>
        /// <param name="formsItemKey">Keeps only the completed forms whose form field of this name holds a value. Take the name from  `GET api/2.0/files/{folderId}/formfilter`, and use it in the folder that gathers the completed copies of a  form-filling room. (optional)</param>
        /// <param name="formsItemType">The kind of the form field named by `formsItemKey`, taken from the same list; the two are sent together. (optional)</param>
        /// <param name="count">The size of one page of the listing. Pair it with `startIndex` to walk through the result, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the listing is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the folder unfiltered. (optional)</param>
        /// <param name="location">Where the entries of a tag-based listing have to live to be kept: `Room` keeps what lies in a room,  `Documents` what lies in a personal section, and `Link` what was reached through an external link that is  still valid. It shapes the Favorites and Recent listings and does nothing in an ordinary folder. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-by-folder-id/">REST API Reference for GetFolderByFolderId Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        FolderContentIntegerWrapper GetFolderByFolderId(int folderId, Guid? userIdOrGroupId = default, Guid? sharedBy = default, FilterType? filterType = default, int? roomId = default, List<int>? folderType = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, bool? withSubFolders = default, string? extension = default, SearchArea? searchArea = default, string? formsItemKey = default, string? formsItemType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, Location? location = default);

        /// <summary>
        /// Get a folder by ID
        /// </summary>
        /// <remarks>
        /// Returns one page of the contents of a folder - its subfolders in `folders`, its files in `files`, the folder  itself in `current` and the chain of parents in `pathParts` - and is the operation a client browses the file  tree with. `filterType`, `filterValue`, `extension`, `userIdOrGroupId`, `sharedBy` and `folderType` narrow  what is listed, `applyFilterOption` decides whether those filters bite on the files, on the folders or on  both, and `withSubFolders`, which is on unless it is switched off, lets a narrowed request descend through the  whole subtree instead of the top level alone. `filterValue` is matched against titles and against indexed  document content, and indexing is asynchronous, so a file uploaded a moment ago can be missing from a search  for a short while. `count` and `startIndex` page through the result while `total` counts everything that  matches, and `sortBy` with `sortOrder` both order the page and are saved as the default order of the account.  Reading a room or an ordinary folder clears its new-item marks for the caller. A caller who may not read the  folder is answered with 403, and a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose contents are listed. Each section root has an operation of its own, such as  `GET api/2.0/files/@my`, and every other folder is opened by the identifier a listing gave for it.</param>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="sharedBy">Restricts the listing to the entries this member shared, which narrows a shared listing down to what one  person handed out. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, spreadsheets, images or one type of room.  Omit it to list every kind the folder holds. (optional)</param>
        /// <param name="roomId">Keeps only the entries that lie in this room, which matters when the listing being read gathers entries from  more than one of them. (optional)</param>
        /// <param name="folderType">Keeps only the folders of these kinds, each given as the number of a folder type; it is how a listing is  narrowed down to, say, the form-filling folders of a room. (optional)</param>
        /// <param name="excludeSubject">Turns `userIdOrGroupId` around: with true the entries of that member or group are the ones left out, with  false they are the only ones kept. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="withSubFolders">Whether a narrowed request reaches into the subfolders: with true, which is what an omitted parameter means,  matching entries are gathered from the whole subtree, with false only the top level is read. It makes a  difference only once `filterType`, `userIdOrGroupId` or `filterValue` narrows the request, because an  unfiltered listing always shows the top level alone. (optional)</param>
        /// <param name="extension">Keeps only the files carrying one of these extensions, several of them separated by commas; the leading dot is  optional. (optional)</param>
        /// <param name="searchArea">Which area a listing that spans several of them is taken from - the active rooms, the archive, the room  templates or the form-filling rooms. A folder that belongs to one area only settles the area itself and  ignores the parameter. (optional)</param>
        /// <param name="formsItemKey">Keeps only the completed forms whose form field of this name holds a value. Take the name from  `GET api/2.0/files/{folderId}/formfilter`, and use it in the folder that gathers the completed copies of a  form-filling room. (optional)</param>
        /// <param name="formsItemType">The kind of the form field named by `formsItemKey`, taken from the same list; the two are sent together. (optional)</param>
        /// <param name="count">The size of one page of the listing. Pair it with `startIndex` to walk through the result, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the listing is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the folder unfiltered. (optional)</param>
        /// <param name="location">Where the entries of a tag-based listing have to live to be kept: `Room` keeps what lies in a room,  `Documents` what lies in a personal section, and `Link` what was reached through an external link that is  still valid. It shapes the Favorites and Recent listings and does nothing in an ordinary folder. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-by-folder-id/">REST API Reference for GetFolderByFolderId Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        ApiResponse<FolderContentIntegerWrapper> GetFolderByFolderIdWithHttpInfo(int folderId, Guid? userIdOrGroupId = default, Guid? sharedBy = default, FilterType? filterType = default, int? roomId = default, List<int>? folderType = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, bool? withSubFolders = default, string? extension = default, SearchArea? searchArea = default, string? formsItemKey = default, string? formsItemType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, Location? location = default);
        /// <summary>
        /// Get folder history
        /// </summary>
        /// <remarks>
        /// Lists what has happened to a folder and to the entries inside it - creations, renames, uploads, moves,  deletions and changes of access - each record naming the action, the moment it happened and the member behind  it. Records that belong to one action are grouped, so a batch arrives as a single entry carrying the rest of  itself in `related`, and the list runs from the most recent record backwards. `fromDate` and `toDate` narrow  the period, `startIndex` and `count` page through the result, and the number of records matching the request  is reported in the response headers rather than in the body. Any member who can read the folder may read its  history; a caller without access is answered with 403 and a folder that does not exist with 404. When the  folder is a form-filling folder the caller reached through a filling invitation, the history is narrowed to  what that caller may see. The call is read-only. To take the same history away as a spreadsheet, start a  report with `POST api/2.0/files/folder/{folderId}/log/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose activity log is read; the log covers the folder itself and the entries inside it.</param>
        /// <param name="fromDate">The earliest moment an entry may have, read in the time zone of the portal; left out, the log starts at the  oldest entry the portal still keeps. (optional)</param>
        /// <param name="toDate">The latest moment an entry may have, read in the time zone of the portal; left out, the log ends at the newest  entry. (optional)</param>
        /// <param name="count">How many entries one page holds. The number of entries that match the query is reported in the response  headers, not in the body. (optional)</param>
        /// <param name="startIndex">How many entries to skip before the page begins, counted from the newest one, so pages are taken by adding the  page size to it. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-history/">REST API Reference for GetFolderHistory Operation</seealso>
        /// <returns>HistoryArrayWrapper</returns>
        HistoryArrayWrapper GetFolderHistory(int folderId, DateTime? fromDate = default, DateTime? toDate = default, int? count = default, int? startIndex = default);

        /// <summary>
        /// Get folder history
        /// </summary>
        /// <remarks>
        /// Lists what has happened to a folder and to the entries inside it - creations, renames, uploads, moves,  deletions and changes of access - each record naming the action, the moment it happened and the member behind  it. Records that belong to one action are grouped, so a batch arrives as a single entry carrying the rest of  itself in `related`, and the list runs from the most recent record backwards. `fromDate` and `toDate` narrow  the period, `startIndex` and `count` page through the result, and the number of records matching the request  is reported in the response headers rather than in the body. Any member who can read the folder may read its  history; a caller without access is answered with 403 and a folder that does not exist with 404. When the  folder is a form-filling folder the caller reached through a filling invitation, the history is narrowed to  what that caller may see. The call is read-only. To take the same history away as a spreadsheet, start a  report with `POST api/2.0/files/folder/{folderId}/log/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose activity log is read; the log covers the folder itself and the entries inside it.</param>
        /// <param name="fromDate">The earliest moment an entry may have, read in the time zone of the portal; left out, the log starts at the  oldest entry the portal still keeps. (optional)</param>
        /// <param name="toDate">The latest moment an entry may have, read in the time zone of the portal; left out, the log ends at the newest  entry. (optional)</param>
        /// <param name="count">How many entries one page holds. The number of entries that match the query is reported in the response  headers, not in the body. (optional)</param>
        /// <param name="startIndex">How many entries to skip before the page begins, counted from the newest one, so pages are taken by adding the  page size to it. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-history/">REST API Reference for GetFolderHistory Operation</seealso>
        /// <returns>ApiResponse of HistoryArrayWrapper</returns>
        ApiResponse<HistoryArrayWrapper> GetFolderHistoryWithHttpInfo(int folderId, DateTime? fromDate = default, DateTime? toDate = default, int? count = default, int? startIndex = default);
        /// <summary>
        /// Get folder information
        /// </summary>
        /// <remarks>
        /// Returns one folder as an object - its title, its parent, the moments it was created and last changed, the  access the caller has to it, the number of items that are new for them, and the room settings when the folder  is a room - without listing anything inside it. Use it to resolve a folder identifier into something  displayable, and `GET api/2.0/files/{folderId}` when the contents are what is wanted; unlike that operation,  this one leaves the new-item marks of the folder alone. Any member who can read the folder may call it, and an  anonymous caller only through an external link that grants access, everybody else being refused; a folder that  does not exist is answered as not found. The call is read-only. The chain of parents above the folder is not  part of the answer and is read with `GET api/2.0/files/folder/{folderId}/path`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-info/">REST API Reference for GetFolderInfo Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper GetFolderInfo(int folderId);

        /// <summary>
        /// Get folder information
        /// </summary>
        /// <remarks>
        /// Returns one folder as an object - its title, its parent, the moments it was created and last changed, the  access the caller has to it, the number of items that are new for them, and the room settings when the folder  is a room - without listing anything inside it. Use it to resolve a folder identifier into something  displayable, and `GET api/2.0/files/{folderId}` when the contents are what is wanted; unlike that operation,  this one leaves the new-item marks of the folder alone. Any member who can read the folder may call it, and an  anonymous caller only through an external link that grants access, everybody else being refused; a folder that  does not exist is answered as not found. The call is read-only. The chain of parents above the folder is not  part of the answer and is read with `GET api/2.0/files/folder/{folderId}/path`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-info/">REST API Reference for GetFolderInfo Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> GetFolderInfoWithHttpInfo(int folderId);
        /// <summary>
        /// Get folder external links
        /// </summary>
        /// <remarks>
        /// Lists the external links of a folder or a room, each with its identifier, title, address, rights, expiration  date, password flag and download restriction, the primary link among them once it exists. At most the first  hundred links are answered and the number returned is reported in the response headers; there are no paging  parameters here. A folder that has never been shared by link answers with an empty list, and so does a member  who may read the folder but not manage its links - the empty answer therefore means nothing to show you  rather than no links exist. A member without access to the room is refused, an anonymous caller is rejected,  and a folder that does not exist is answered as not found. The call is read-only. Take an identifier from here  to `PUT api/2.0/files/folder/{id}/links` to change or remove that link, and read the primary one alone with  `GET api/2.0/files/folder/{id}/link`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room whose external links are listed.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-links/">REST API Reference for GetFolderLinks Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        FileShareArrayWrapper GetFolderLinks(int id);

        /// <summary>
        /// Get folder external links
        /// </summary>
        /// <remarks>
        /// Lists the external links of a folder or a room, each with its identifier, title, address, rights, expiration  date, password flag and download restriction, the primary link among them once it exists. At most the first  hundred links are answered and the number returned is reported in the response headers; there are no paging  parameters here. A folder that has never been shared by link answers with an empty list, and so does a member  who may read the folder but not manage its links - the empty answer therefore means nothing to show you  rather than no links exist. A member without access to the room is refused, an anonymous caller is rejected,  and a folder that does not exist is answered as not found. The call is read-only. Take an identifier from here  to `PUT api/2.0/files/folder/{id}/links` to change or remove that link, and read the primary one alone with  `GET api/2.0/files/folder/{id}/link`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room whose external links are listed.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-links/">REST API Reference for GetFolderLinks Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        ApiResponse<FileShareArrayWrapper> GetFolderLinksWithHttpInfo(int id);
        /// <summary>
        /// Get the folder path
        /// </summary>
        /// <remarks>
        /// Returns the chain of folders that leads to the folder named in the path, ordered from the section root down to  the folder itself, which is the last entry. It is what a breadcrumb trail is built from, and it also tells a  client which section - a room, the personal section, the archive - a bare folder identifier belongs to. Only  the folders the caller may see are part of the chain, so a member who was given access to a folder deep inside  a room gets a shorter path than the room manager does. The caller needs read access to the folder and is  otherwise answered with 403, while a folder that does not exist is answered as not found. The call is  read-only and takes no paging parameters. To go the other way, from a folder down into its contents, call  `GET api/2.0/files/{folderId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-path/">REST API Reference for GetFolderPath Operation</seealso>
        /// <returns>FileEntryBaseArrayWrapper</returns>
        FileEntryBaseArrayWrapper GetFolderPath(int folderId);

        /// <summary>
        /// Get the folder path
        /// </summary>
        /// <remarks>
        /// Returns the chain of folders that leads to the folder named in the path, ordered from the section root down to  the folder itself, which is the last entry. It is what a breadcrumb trail is built from, and it also tells a  client which section - a room, the personal section, the archive - a bare folder identifier belongs to. Only  the folders the caller may see are part of the chain, so a member who was given access to a folder deep inside  a room gets a shorter path than the room manager does. The caller needs read access to the folder and is  otherwise answered with 403, while a folder that does not exist is answered as not found. The call is  read-only and takes no paging parameters. To go the other way, from a folder down into its contents, call  `GET api/2.0/files/{folderId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-path/">REST API Reference for GetFolderPath Operation</seealso>
        /// <returns>ApiResponse of FileEntryBaseArrayWrapper</returns>
        ApiResponse<FileEntryBaseArrayWrapper> GetFolderPathWithHttpInfo(int folderId);
        /// <summary>
        /// Get the folder primary external link
        /// </summary>
        /// <remarks>
        /// Answers with the primary external link of a folder or a room - the one the Copy link action of a client  hands out - with its address in `sharedTo.shareLink`, its rights in `access`, and its title, expiration date,  password flag and download restriction beside them. The link is created on the first read if the folder has  none, with read rights, no password and no expiry, so this operation mutates on that first call and is a plain  read afterwards; repeated calls answer with the same link identifier. The caller needs the right to manage the  links of the room the folder belongs to, which its manager and a portal administrator acting as room manager  have; a member with read access alone is refused with 403 and an anonymous caller is rejected, while a link  that was deliberately revoked is answered with 404 rather than being recreated. The paging parameters are  accepted for compatibility and leave the single link answered here unchanged. Every external link of the same  folder is listed by `GET api/2.0/files/folder/{id}/links`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the operation addresses. A folder stored on the portal is numbered, while a folder in a  connected third-party account is named by an opaque string.</param>
        /// <param name="count">How many entries at most to answer with, in the operations of this folder that return a list; an operation  that answers with a single object is not affected by it. (optional)</param>
        /// <param name="startIndex">How many entries of such a list to skip before answering, used together with `count` to walk through it page  by page. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-primary-external-link/">REST API Reference for GetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        FileShareWrapper GetFolderPrimaryExternalLink(int id, int? count = default, int? startIndex = default);

        /// <summary>
        /// Get the folder primary external link
        /// </summary>
        /// <remarks>
        /// Answers with the primary external link of a folder or a room - the one the Copy link action of a client  hands out - with its address in `sharedTo.shareLink`, its rights in `access`, and its title, expiration date,  password flag and download restriction beside them. The link is created on the first read if the folder has  none, with read rights, no password and no expiry, so this operation mutates on that first call and is a plain  read afterwards; repeated calls answer with the same link identifier. The caller needs the right to manage the  links of the room the folder belongs to, which its manager and a portal administrator acting as room manager  have; a member with read access alone is refused with 403 and an anonymous caller is rejected, while a link  that was deliberately revoked is answered with 404 rather than being recreated. The paging parameters are  accepted for compatibility and leave the single link answered here unchanged. Every external link of the same  folder is listed by `GET api/2.0/files/folder/{id}/links`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the operation addresses. A folder stored on the portal is numbered, while a folder in a  connected third-party account is named by an opaque string.</param>
        /// <param name="count">How many entries at most to answer with, in the operations of this folder that return a list; an operation  that answers with a single object is not affected by it. (optional)</param>
        /// <param name="startIndex">How many entries of such a list to skip before answering, used together with `count` to walk through it page  by page. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-primary-external-link/">REST API Reference for GetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        ApiResponse<FileShareWrapper> GetFolderPrimaryExternalLinkWithHttpInfo(int id, int? count = default, int? startIndex = default);
        /// <summary>
        /// Get subfolders
        /// </summary>
        /// <remarks>
        /// Lists the folders that sit directly inside the folder named in the path, ordered by title, without their own  contents and without the files that lie beside them. The whole list arrives at once - there are no paging or  filtering parameters here - so for a large folder, or when the files are wanted as well, use  `GET api/2.0/files/{folderId}`, which pages and filters. A folder that holds no subfolders answers with an  empty list. The caller needs read access to the folder, and only the subfolders they may see are listed, so a  member of a room can get fewer entries than its manager; a caller without access is answered with 403, and a  folder that does not exist, or one that has been deleted for good, is answered as not found. The call is  read-only and leaves the new-item marks of the folder alone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folders/">REST API Reference for GetFolders Operation</seealso>
        /// <returns>FileEntryBaseArrayWrapper</returns>
        FileEntryBaseArrayWrapper GetFolders(int folderId);

        /// <summary>
        /// Get subfolders
        /// </summary>
        /// <remarks>
        /// Lists the folders that sit directly inside the folder named in the path, ordered by title, without their own  contents and without the files that lie beside them. The whole list arrives at once - there are no paging or  filtering parameters here - so for a large folder, or when the files are wanted as well, use  `GET api/2.0/files/{folderId}`, which pages and filters. A folder that holds no subfolders answers with an  empty list. The caller needs read access to the folder, and only the subfolders they may see are listed, so a  member of a room can get fewer entries than its manager; a caller without access is answered with 403, and a  folder that does not exist, or one that has been deleted for good, is answered as not found. The call is  read-only and leaves the new-item marks of the folder alone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folders/">REST API Reference for GetFolders Operation</seealso>
        /// <returns>ApiResponse of FileEntryBaseArrayWrapper</returns>
        ApiResponse<FileEntryBaseArrayWrapper> GetFoldersWithHttpInfo(int folderId);
        /// <summary>
        /// Get the Forms section
        /// </summary>
        /// <remarks>
        /// Returns the Forms section: the flat list of form-filling rooms the caller may read. Such rooms are stored  under the Rooms tree but are surfaced only here, so `GET api/2.0/files/rooms` leaves them out of the active  area and lists them when `searchArea` names the forms area instead. The section is not expanded into room  content, so `folders` carries the rooms while `files` comes back empty; to read what is inside one of them,  call `GET api/2.0/files/{folderId}` with the room identifier. Nothing is modified, though passing `sortBy`  saves the requested order as the default order for this account. `filterType`, `filterValue`,  `userIdOrGroupId` and the sorting parameters narrow and order the room list, `count` and `startIndex` page  through it, `total` reports how many rooms match the request in full, and `current` describes the section  folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the section unfiltered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-forms-folder/">REST API Reference for GetFormsFolder Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        FolderContentIntegerWrapper GetFormsFolder(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);

        /// <summary>
        /// Get the Forms section
        /// </summary>
        /// <remarks>
        /// Returns the Forms section: the flat list of form-filling rooms the caller may read. Such rooms are stored  under the Rooms tree but are surfaced only here, so `GET api/2.0/files/rooms` leaves them out of the active  area and lists them when `searchArea` names the forms area instead. The section is not expanded into room  content, so `folders` carries the rooms while `files` comes back empty; to read what is inside one of them,  call `GET api/2.0/files/{folderId}` with the room identifier. Nothing is modified, though passing `sortBy`  saves the requested order as the default order for this account. `filterType`, `filterValue`,  `userIdOrGroupId` and the sorting parameters narrow and order the room list, `count` and `startIndex` page  through it, `total` reports how many rooms match the request in full, and `current` describes the section  folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the section unfiltered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-forms-folder/">REST API Reference for GetFormsFolder Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        ApiResponse<FolderContentIntegerWrapper> GetFormsFolderWithHttpInfo(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);
        /// <summary>
        /// Get the My documents section
        /// </summary>
        /// <remarks>
        /// Returns the contents of the caller's My documents section, the personal storage that belongs to this account  alone and stays invisible to other members until something in it is shared explicitly. Any authenticated  member that has a personal section can read it; guest accounts are not given one, and the call then answers  404. Nothing in the section is modified, though passing `sortBy` saves the requested order as the default  order for this account. Without a filter only the top level of the section is listed; as soon as `filterType`,  `userIdOrGroupId` or `filterValue` narrows the request, the search descends through the whole subtree.  `filterValue` is matched against titles and against indexed document content, and the index is written  asynchronously, so a file uploaded a moment ago can be missing from a search for a short while. `folders` and  `files` hold one page of the result, `total` counts everything that matches before `count` and `startIndex`  are applied, and `current` describes the section folder. To open a folder inside the section, call  `GET api/2.0/files/{folderId}` with its identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by, matched as a substring of entry titles. Omit it to list the  section unfiltered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-my-folder/">REST API Reference for GetMyFolder Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        FolderContentIntegerWrapper GetMyFolder(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);

        /// <summary>
        /// Get the My documents section
        /// </summary>
        /// <remarks>
        /// Returns the contents of the caller's My documents section, the personal storage that belongs to this account  alone and stays invisible to other members until something in it is shared explicitly. Any authenticated  member that has a personal section can read it; guest accounts are not given one, and the call then answers  404. Nothing in the section is modified, though passing `sortBy` saves the requested order as the default  order for this account. Without a filter only the top level of the section is listed; as soon as `filterType`,  `userIdOrGroupId` or `filterValue` narrows the request, the search descends through the whole subtree.  `filterValue` is matched against titles and against indexed document content, and the index is written  asynchronously, so a file uploaded a moment ago can be missing from a search for a short while. `folders` and  `files` hold one page of the result, `total` counts everything that matches before `count` and `startIndex`  are applied, and `current` describes the section folder. To open a folder inside the section, call  `GET api/2.0/files/{folderId}` with its identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by, matched as a substring of entry titles. Omit it to list the  section unfiltered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-my-folder/">REST API Reference for GetMyFolder Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        ApiResponse<FolderContentIntegerWrapper> GetMyFolderWithHttpInfo(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);
        /// <summary>
        /// Get new folder items
        /// </summary>
        /// <remarks>
        /// Lists the entries of a folder that are new for the calling member - the files and folders created or changed  there since they last opened it - ordered from the most recently changed backwards. It is what the badge of a  room is filled from, and it is personal: two members of the same room get different answers. Reading this list  does not clear the marks, so the same entries come back until the folder itself is opened with  `GET api/2.0/files/{folderId}`, which does clear them. A folder with nothing new answers with an empty list,  and marks disappear on their own when the entry behind them is deleted or moved out of reach. The caller needs  read access to the folder and is otherwise answered with 403. The whole list arrives at once, without paging  or filtering, and the call is read-only.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-folder-items/">REST API Reference for GetNewFolderItems Operation</seealso>
        /// <returns>FileEntryBaseArrayWrapper</returns>
        FileEntryBaseArrayWrapper GetNewFolderItems(int folderId);

        /// <summary>
        /// Get new folder items
        /// </summary>
        /// <remarks>
        /// Lists the entries of a folder that are new for the calling member - the files and folders created or changed  there since they last opened it - ordered from the most recently changed backwards. It is what the badge of a  room is filled from, and it is personal: two members of the same room get different answers. Reading this list  does not clear the marks, so the same entries come back until the folder itself is opened with  `GET api/2.0/files/{folderId}`, which does clear them. A folder with nothing new answers with an empty list,  and marks disappear on their own when the entry behind them is deleted or moved out of reach. The caller needs  read access to the folder and is otherwise answered with 403. The whole list arrives at once, without paging  or filtering, and the call is read-only.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-folder-items/">REST API Reference for GetNewFolderItems Operation</seealso>
        /// <returns>ApiResponse of FileEntryBaseArrayWrapper</returns>
        ApiResponse<FileEntryBaseArrayWrapper> GetNewFolderItemsWithHttpInfo(int folderId);
        /// <summary>
        /// Get the Recent section
        /// </summary>
        /// <remarks>
        /// Returns the Recent section: the files the calling account has opened lately. The section holds files only,  so `folders` comes back empty, and it is personal, so another member's history is not visible here. A file is  added when it is opened and can also be added explicitly with `POST api/2.0/files/file/{fileId}/recent`;  `DELETE api/2.0/files/recent` clears the whole history, and `PUT api/2.0/files/displayrecent` switches the  section on and off for the account, which also decides whether `GET api/2.0/files/@root` includes it. Nothing  in the section is modified, though passing `sortBy` saves the requested order as the default order for this  account. The listing is ordered by the moment the caller last opened each file, newest first, and `sortBy` and  `sortOrder` do not change that order. `files` holds one page, `total` counts the files matching the request  before `count` and `startIndex` are applied, and `current` describes the section folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the files authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list the whole history. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of file, such as documents, spreadsheets or images. Omit it to list every  kind the history holds. (optional)</param>
        /// <param name="excludeSubject">Inverts `userIdOrGroupId`: with `true` the files of that member or group are the ones left out of the listing  instead of the only ones kept. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of a listing `filterType` and `filterValue` are applied to. The Recent section holds  files only, so the value does not change what comes back. (optional)</param>
        /// <param name="searchArea">The area a listing is taken from. The Recent section is assembled from the caller's own open history rather  than from an area, so the value does not change which files are returned. (optional)</param>
        /// <param name="extension">The file extensions the listing is limited to, matched against the end of the file name. The leading dot is  optional, and the parameter is repeated once per extension. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. The Recent section keeps its own newest-first order, so the value does not  reorder this listing. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. The Recent section keeps its own newest-first order, so the value does not reorder this  listing. (optional)</param>
        /// <param name="filterValue">The search string the history is filtered by: it is matched as a substring of file titles and against the  indexed document content as well. Omit it to list the whole history. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-recent-folder/">REST API Reference for GetRecentFolder Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        FolderContentIntegerWrapper GetRecentFolder(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, SearchArea? searchArea = default, List<string>? extension = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);

        /// <summary>
        /// Get the Recent section
        /// </summary>
        /// <remarks>
        /// Returns the Recent section: the files the calling account has opened lately. The section holds files only,  so `folders` comes back empty, and it is personal, so another member's history is not visible here. A file is  added when it is opened and can also be added explicitly with `POST api/2.0/files/file/{fileId}/recent`;  `DELETE api/2.0/files/recent` clears the whole history, and `PUT api/2.0/files/displayrecent` switches the  section on and off for the account, which also decides whether `GET api/2.0/files/@root` includes it. Nothing  in the section is modified, though passing `sortBy` saves the requested order as the default order for this  account. The listing is ordered by the moment the caller last opened each file, newest first, and `sortBy` and  `sortOrder` do not change that order. `files` holds one page, `total` counts the files matching the request  before `count` and `startIndex` are applied, and `current` describes the section folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the files authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list the whole history. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of file, such as documents, spreadsheets or images. Omit it to list every  kind the history holds. (optional)</param>
        /// <param name="excludeSubject">Inverts `userIdOrGroupId`: with `true` the files of that member or group are the ones left out of the listing  instead of the only ones kept. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of a listing `filterType` and `filterValue` are applied to. The Recent section holds  files only, so the value does not change what comes back. (optional)</param>
        /// <param name="searchArea">The area a listing is taken from. The Recent section is assembled from the caller's own open history rather  than from an area, so the value does not change which files are returned. (optional)</param>
        /// <param name="extension">The file extensions the listing is limited to, matched against the end of the file name. The leading dot is  optional, and the parameter is repeated once per extension. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. The Recent section keeps its own newest-first order, so the value does not  reorder this listing. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. The Recent section keeps its own newest-first order, so the value does not reorder this  listing. (optional)</param>
        /// <param name="filterValue">The search string the history is filtered by: it is matched as a substring of file titles and against the  indexed document content as well. Omit it to list the whole history. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-recent-folder/">REST API Reference for GetRecentFolder Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        ApiResponse<FolderContentIntegerWrapper> GetRecentFolderWithHttpInfo(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, SearchArea? searchArea = default, List<string>? extension = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);
        /// <summary>
        /// Get the folder history report generation status
        /// </summary>
        /// <remarks>
        /// Reports how far the history report of a folder has got, and is the operation to poll after  `POST api/2.0/files/folder/{folderId}/log/report` has queued one. `percentage` climbs to 100, `isCompleted`  turns true when the job is over however it ended, `error` carries the reason when it failed, and  `resultFileId`, `resultFileName` and `resultFileUrl` name the file that was saved in the caller's My  documents - a CSV report leaving the identifier empty. An empty answer means there is no report for this  folder and caller, either because none was started or because a finished one has already been picked up by an  earlier poll. The caller needs read access to the folder and may not be a guest, and the portal plan has to  include the audit feature; a caller who fails the access rule is answered with 403 and a folder that does not  exist with 404. The call is read-only, and each caller sees only their own report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose history report is being polled. It is the folder that was              passed to the operation that started the report.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-report-folder-history/">REST API Reference for GetReportFolderHistory Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        DocumentBuilderTaskWrapper GetReportFolderHistory(int folderId);

        /// <summary>
        /// Get the folder history report generation status
        /// </summary>
        /// <remarks>
        /// Reports how far the history report of a folder has got, and is the operation to poll after  `POST api/2.0/files/folder/{folderId}/log/report` has queued one. `percentage` climbs to 100, `isCompleted`  turns true when the job is over however it ended, `error` carries the reason when it failed, and  `resultFileId`, `resultFileName` and `resultFileUrl` name the file that was saved in the caller's My  documents - a CSV report leaving the identifier empty. An empty answer means there is no report for this  folder and caller, either because none was started or because a finished one has already been picked up by an  earlier poll. The caller needs read access to the folder and may not be a guest, and the portal plan has to  include the audit feature; a caller who fails the access rule is answered with 403 and a folder that does not  exist with 404. The call is read-only, and each caller sees only their own report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose history report is being polled. It is the folder that was              passed to the operation that started the report.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-report-folder-history/">REST API Reference for GetReportFolderHistory Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        ApiResponse<DocumentBuilderTaskWrapper> GetReportFolderHistoryWithHttpInfo(int folderId);
        /// <summary>
        /// Get filtered sections
        /// </summary>
        /// <remarks>
        /// Returns every top-level section the calling account can see in one response, each of them a full section  object carrying its own first page of content: Favorites, Recent, Shared with me, My documents,  Trash, Rooms, Forms, Archive and, while AI access is enabled for the portal, AI agents. A section is  left out when the account has none of it, which is why a guest gets no personal section, and Recent is  listed only while it is switched on with `PUT api/2.0/files/displayrecent`. Pass `withoutTrash=true` to drop  the Trash section. The filters, `count` and `startIndex` are applied to each section separately, so  `count=1` returns one entry per section and every section reports its own `total`. Because it builds the  content of all of them, this is the most expensive listing in the module: when a single section is enough,  read it directly, for example with `GET api/2.0/files/@my`. The call modifies nothing in the sections and  leaves their new-item badges untouched, though passing `sortBy` saves the requested order as the default order  for this account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the content listed inside every returned section to a single kind of entry, such as documents, images  or one type of room. Omit it to list every kind the sections hold. (optional)</param>
        /// <param name="withoutTrash">Set it to `true` to leave the Trash section out of the returned set of sections; with `false`, or when the  parameter is omitted, the section is returned whenever the account has one of its own. (optional)</param>
        /// <param name="count">The size of the content page returned for each section separately, so a value of 1 yields one entry per  section rather than one entry in total. (optional)</param>
        /// <param name="startIndex">The number of matching entries skipped in each section before its page begins; add `count` to it to ask for  the next page of every section. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the content of every section is filtered by: it is matched as a substring of entry titles  and, for files, against the indexed document content as well. Omit it to list the sections unfiltered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-root-folders/">REST API Reference for GetRootFolders Operation</seealso>
        /// <returns>FolderContentIntegerArrayWrapper</returns>
        FolderContentIntegerArrayWrapper GetRootFolders(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? withoutTrash = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);

        /// <summary>
        /// Get filtered sections
        /// </summary>
        /// <remarks>
        /// Returns every top-level section the calling account can see in one response, each of them a full section  object carrying its own first page of content: Favorites, Recent, Shared with me, My documents,  Trash, Rooms, Forms, Archive and, while AI access is enabled for the portal, AI agents. A section is  left out when the account has none of it, which is why a guest gets no personal section, and Recent is  listed only while it is switched on with `PUT api/2.0/files/displayrecent`. Pass `withoutTrash=true` to drop  the Trash section. The filters, `count` and `startIndex` are applied to each section separately, so  `count=1` returns one entry per section and every section reports its own `total`. Because it builds the  content of all of them, this is the most expensive listing in the module: when a single section is enough,  read it directly, for example with `GET api/2.0/files/@my`. The call modifies nothing in the sections and  leaves their new-item badges untouched, though passing `sortBy` saves the requested order as the default order  for this account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the content listed inside every returned section to a single kind of entry, such as documents, images  or one type of room. Omit it to list every kind the sections hold. (optional)</param>
        /// <param name="withoutTrash">Set it to `true` to leave the Trash section out of the returned set of sections; with `false`, or when the  parameter is omitted, the section is returned whenever the account has one of its own. (optional)</param>
        /// <param name="count">The size of the content page returned for each section separately, so a value of 1 yields one entry per  section rather than one entry in total. (optional)</param>
        /// <param name="startIndex">The number of matching entries skipped in each section before its page begins; add `count` to it to ask for  the next page of every section. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the content of every section is filtered by: it is matched as a substring of entry titles  and, for files, against the indexed document content as well. Omit it to list the sections unfiltered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-root-folders/">REST API Reference for GetRootFolders Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerArrayWrapper</returns>
        ApiResponse<FolderContentIntegerArrayWrapper> GetRootFoldersWithHttpInfo(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? withoutTrash = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);
        /// <summary>
        /// Get the Trash section
        /// </summary>
        /// <remarks>
        /// Returns the caller's Trash section: the files and folders this account has deleted, kept there until they  are restored or discarded. Each member has a Trash of their own and sees only what they deleted themselves.  Restore an entry by moving it back with `PUT api/2.0/files/fileops/move`, or discard the whole section with  `PUT api/2.0/files/fileops/emptytrash`; both start a background operation that is polled through  `GET api/2.0/files/fileops`. This call itself modifies nothing, though passing `sortBy` saves the requested  order as the default order for this account. Only the top level of the section is listed, so the contents of a  deleted folder are not expanded into it, and `filterValue` is matched against titles alone here rather than  against document content. `folders` and `files` hold one page of the result, `total` counts everything that  matches before `count` and `startIndex` are applied, and `current` describes the section folder. An account  that is given no Trash of its own, an outsider for instance, receives 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by, matched as a substring of entry titles. Omit it to list the  section unfiltered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-trash-folder/">REST API Reference for GetTrashFolder Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        FolderContentIntegerWrapper GetTrashFolder(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);

        /// <summary>
        /// Get the Trash section
        /// </summary>
        /// <remarks>
        /// Returns the caller's Trash section: the files and folders this account has deleted, kept there until they  are restored or discarded. Each member has a Trash of their own and sees only what they deleted themselves.  Restore an entry by moving it back with `PUT api/2.0/files/fileops/move`, or discard the whole section with  `PUT api/2.0/files/fileops/emptytrash`; both start a background operation that is polled through  `GET api/2.0/files/fileops`. This call itself modifies nothing, though passing `sortBy` saves the requested  order as the default order for this account. Only the top level of the section is listed, so the contents of a  deleted folder are not expanded into it, and `filterValue` is matched against titles alone here rather than  against document content. `folders` and `files` hold one page of the result, `total` counts everything that  matches before `count` and `startIndex` are applied, and `current` describes the section folder. An account  that is given no Trash of its own, an outsider for instance, receives 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by, matched as a substring of entry titles. Omit it to list the  section unfiltered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-trash-folder/">REST API Reference for GetTrashFolder Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        ApiResponse<FolderContentIntegerWrapper> GetTrashFolderWithHttpInfo(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);
        /// <summary>
        /// Insert a file
        /// </summary>
        /// <remarks>
        /// Stores a file in the folder named by the path in a single request, taking its name from `title` rather than  from the uploaded part, which is what separates it from `POST api/2.0/files/{folderId}/upload`. The content  may arrive either as a multipart part or as the raw request body. The name is stripped of characters a title  cannot hold and truncated, and `createNewIfExist` settles the clash: false adds a new version to the file that  already carries the name, true keeps both by giving the new one a numeric suffix. The caller needs the right  to add content to the folder, so a reader, an editor and a guest get 403, a section root and an archived room  are refused as well, and an unknown folder gives 404. Formats the portal converts are converted afterwards in  the background; pass `keepConvertStatus` to keep the outcome readable through  `GET api/2.0/files/file/{fileId}/checkconversion`. The answer is the stored file. A large payload belongs in a  chunked session instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="insertFileFile">The content to store, sent as a `multipart/form-data` part. The same content may instead be sent as the raw  request body, which is what a client that cannot build a form does; when both are present the form part wins. (optional)</param>
        /// <param name="insertFileTitle">The name to store the file under, extension included. It wins over the name of the uploaded part, which is the  reason to choose this operation over the plain upload, and it is the only name available when the content  arrives as a raw body. Characters a title cannot hold are replaced with underscores and the name is cut to 170  characters before the file is stored. (optional)</param>
        /// <param name="insertFileCreateNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="insertFileKeepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="insertFileStreamCanRead"> (optional)</param>
        /// <param name="insertFileStreamCanWrite"> (optional)</param>
        /// <param name="insertFileStreamCanSeek"> (optional)</param>
        /// <param name="insertFileStreamCanTimeout"> (optional)</param>
        /// <param name="insertFileStreamLength"> (optional)</param>
        /// <param name="insertFileStreamPosition"> (optional)</param>
        /// <param name="insertFileStreamReadTimeout"> (optional)</param>
        /// <param name="insertFileStreamWriteTimeout"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file/">REST API Reference for InsertFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper InsertFile(int folderId, FileParameter? insertFileFile = default, string? insertFileTitle = default, bool? insertFileCreateNewIfExist = default, bool? insertFileKeepConvertStatus = default, bool? insertFileStreamCanRead = default, bool? insertFileStreamCanWrite = default, bool? insertFileStreamCanSeek = default, bool? insertFileStreamCanTimeout = default, long? insertFileStreamLength = default, long? insertFileStreamPosition = default, int? insertFileStreamReadTimeout = default, int? insertFileStreamWriteTimeout = default);

        /// <summary>
        /// Insert a file
        /// </summary>
        /// <remarks>
        /// Stores a file in the folder named by the path in a single request, taking its name from `title` rather than  from the uploaded part, which is what separates it from `POST api/2.0/files/{folderId}/upload`. The content  may arrive either as a multipart part or as the raw request body. The name is stripped of characters a title  cannot hold and truncated, and `createNewIfExist` settles the clash: false adds a new version to the file that  already carries the name, true keeps both by giving the new one a numeric suffix. The caller needs the right  to add content to the folder, so a reader, an editor and a guest get 403, a section root and an archived room  are refused as well, and an unknown folder gives 404. Formats the portal converts are converted afterwards in  the background; pass `keepConvertStatus` to keep the outcome readable through  `GET api/2.0/files/file/{fileId}/checkconversion`. The answer is the stored file. A large payload belongs in a  chunked session instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="insertFileFile">The content to store, sent as a `multipart/form-data` part. The same content may instead be sent as the raw  request body, which is what a client that cannot build a form does; when both are present the form part wins. (optional)</param>
        /// <param name="insertFileTitle">The name to store the file under, extension included. It wins over the name of the uploaded part, which is the  reason to choose this operation over the plain upload, and it is the only name available when the content  arrives as a raw body. Characters a title cannot hold are replaced with underscores and the name is cut to 170  characters before the file is stored. (optional)</param>
        /// <param name="insertFileCreateNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="insertFileKeepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="insertFileStreamCanRead"> (optional)</param>
        /// <param name="insertFileStreamCanWrite"> (optional)</param>
        /// <param name="insertFileStreamCanSeek"> (optional)</param>
        /// <param name="insertFileStreamCanTimeout"> (optional)</param>
        /// <param name="insertFileStreamLength"> (optional)</param>
        /// <param name="insertFileStreamPosition"> (optional)</param>
        /// <param name="insertFileStreamReadTimeout"> (optional)</param>
        /// <param name="insertFileStreamWriteTimeout"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file/">REST API Reference for InsertFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> InsertFileWithHttpInfo(int folderId, FileParameter? insertFileFile = default, string? insertFileTitle = default, bool? insertFileCreateNewIfExist = default, bool? insertFileKeepConvertStatus = default, bool? insertFileStreamCanRead = default, bool? insertFileStreamCanWrite = default, bool? insertFileStreamCanSeek = default, bool? insertFileStreamCanTimeout = default, long? insertFileStreamLength = default, long? insertFileStreamPosition = default, int? insertFileStreamReadTimeout = default, int? insertFileStreamWriteTimeout = default);
        /// <summary>
        /// Insert a file into My documents
        /// </summary>
        /// <remarks>
        /// Stores one file in the caller's own My documents section, the personal storage every portal member has, and  returns the stored file. The destination takes no identifier: it is resolved from the calling account and  created on first use, while a guest account has none and is answered as missing (404). Send the content as a  `multipart/form-data` part or as the raw request body, and name it with `title`, which wins over the name of  the uploaded part and has invalid characters replaced before storing. The call is not idempotent: by default a  file of the same title is overwritten as a new version, while `createNewIfExist=true` stores a separate copy  under a title made unique with a numeric suffix; a title held by a file that is locked or open in the editor  cannot be overwritten either, and a second file appears under the same title. Formats listed in  `extsMustConvert` of `GET api/2.0/files/settings` are converted after the response is sent;  `keepConvertStatus=true` keeps that result readable through `GET api/2.0/files/file/{fileId}/checkconversion`,  which otherwise drops it. Files over the single-request size limit or the account's storage quota are refused:  send those through `POST api/2.0/files/{folderId}/upload/create_session`, and use  `POST api/2.0/files/{folderId}/insert` for any other destination.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part. The same content may instead be sent as the raw  request body, which is what a client that cannot build a form does; when both are present the form part wins. (optional)</param>
        /// <param name="title">The name to store the file under, extension included. It wins over the name of the uploaded part, which is the  reason to choose this operation over the plain upload, and it is the only name available when the content  arrives as a raw body. Characters a title cannot hold are replaced with underscores and the name is cut to 170  characters before the file is stored. (optional)</param>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="streamCanRead"> (optional)</param>
        /// <param name="streamCanWrite"> (optional)</param>
        /// <param name="streamCanSeek"> (optional)</param>
        /// <param name="streamCanTimeout"> (optional)</param>
        /// <param name="streamLength"> (optional)</param>
        /// <param name="streamPosition"> (optional)</param>
        /// <param name="streamReadTimeout"> (optional)</param>
        /// <param name="streamWriteTimeout"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file-to-my-from-body/">REST API Reference for InsertFileToMyFromBody Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper InsertFileToMyFromBody(FileParameter? file = default, string? title = default, bool? createNewIfExist = default, bool? keepConvertStatus = default, bool? streamCanRead = default, bool? streamCanWrite = default, bool? streamCanSeek = default, bool? streamCanTimeout = default, long? streamLength = default, long? streamPosition = default, int? streamReadTimeout = default, int? streamWriteTimeout = default);

        /// <summary>
        /// Insert a file into My documents
        /// </summary>
        /// <remarks>
        /// Stores one file in the caller's own My documents section, the personal storage every portal member has, and  returns the stored file. The destination takes no identifier: it is resolved from the calling account and  created on first use, while a guest account has none and is answered as missing (404). Send the content as a  `multipart/form-data` part or as the raw request body, and name it with `title`, which wins over the name of  the uploaded part and has invalid characters replaced before storing. The call is not idempotent: by default a  file of the same title is overwritten as a new version, while `createNewIfExist=true` stores a separate copy  under a title made unique with a numeric suffix; a title held by a file that is locked or open in the editor  cannot be overwritten either, and a second file appears under the same title. Formats listed in  `extsMustConvert` of `GET api/2.0/files/settings` are converted after the response is sent;  `keepConvertStatus=true` keeps that result readable through `GET api/2.0/files/file/{fileId}/checkconversion`,  which otherwise drops it. Files over the single-request size limit or the account's storage quota are refused:  send those through `POST api/2.0/files/{folderId}/upload/create_session`, and use  `POST api/2.0/files/{folderId}/insert` for any other destination.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part. The same content may instead be sent as the raw  request body, which is what a client that cannot build a form does; when both are present the form part wins. (optional)</param>
        /// <param name="title">The name to store the file under, extension included. It wins over the name of the uploaded part, which is the  reason to choose this operation over the plain upload, and it is the only name available when the content  arrives as a raw body. Characters a title cannot hold are replaced with underscores and the name is cut to 170  characters before the file is stored. (optional)</param>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="streamCanRead"> (optional)</param>
        /// <param name="streamCanWrite"> (optional)</param>
        /// <param name="streamCanSeek"> (optional)</param>
        /// <param name="streamCanTimeout"> (optional)</param>
        /// <param name="streamLength"> (optional)</param>
        /// <param name="streamPosition"> (optional)</param>
        /// <param name="streamReadTimeout"> (optional)</param>
        /// <param name="streamWriteTimeout"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file-to-my-from-body/">REST API Reference for InsertFileToMyFromBody Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> InsertFileToMyFromBodyWithHttpInfo(FileParameter? file = default, string? title = default, bool? createNewIfExist = default, bool? keepConvertStatus = default, bool? streamCanRead = default, bool? streamCanWrite = default, bool? streamCanSeek = default, bool? streamCanTimeout = default, long? streamLength = default, long? streamPosition = default, int? streamReadTimeout = default, int? streamWriteTimeout = default);
        /// <summary>
        /// Rename a folder
        /// </summary>
        /// <remarks>
        /// Gives a folder a new title and answers with the folder as it now stands. The title is trimmed, may not be  blank and is refused when it is longer than the limit the schema prints; a title that matches the current one  leaves the folder untouched, and titles need not be unique among the neighbours. The caller needs the right to  rename the folder, which the room manager, a content creator acting on a folder of their own and the owner of  a personal section have, while a guest is refused with 403 whatever their access; a folder in the Trash  section or in an archived room cannot be renamed either, and a folder that does not exist is answered as  not found. A room may be renamed here as well, in which case the caller needs the right to edit the  room, and `PUT api/2.0/files/rooms/{id}` is the operation that changes its other settings. The call is  mutating and idempotent; on a folder stored in a connected third-party account the identifier of the folder  may change with the title.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the request is addressed to: when a folder is created it is the parent that receives the new  folder, and when a folder is renamed it is the folder that gets the new title.</param>
        /// <param name="createFolder">The title carried by the request body.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-folder/">REST API Reference for RenameFolder Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper RenameFolder(int folderId, CreateFolder createFolder);

        /// <summary>
        /// Rename a folder
        /// </summary>
        /// <remarks>
        /// Gives a folder a new title and answers with the folder as it now stands. The title is trimmed, may not be  blank and is refused when it is longer than the limit the schema prints; a title that matches the current one  leaves the folder untouched, and titles need not be unique among the neighbours. The caller needs the right to  rename the folder, which the room manager, a content creator acting on a folder of their own and the owner of  a personal section have, while a guest is refused with 403 whatever their access; a folder in the Trash  section or in an archived room cannot be renamed either, and a folder that does not exist is answered as  not found. A room may be renamed here as well, in which case the caller needs the right to edit the  room, and `PUT api/2.0/files/rooms/{id}` is the operation that changes its other settings. The call is  mutating and idempotent; on a folder stored in a connected third-party account the identifier of the folder  may change with the title.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the request is addressed to: when a folder is created it is the parent that receives the new  folder, and when a folder is renamed it is the folder that gets the new title.</param>
        /// <param name="createFolder">The title carried by the request body.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-folder/">REST API Reference for RenameFolder Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> RenameFolderWithHttpInfo(int folderId, CreateFolder createFolder);
        /// <summary>
        /// Set folder order
        /// </summary>
        /// <remarks>
        /// Puts a folder at a given position among the entries of its parent and answers with the folder, its `order`  reporting where it now stands. Positions count from 1, and the entry that held the wanted position, together  with everything after it, is shifted to make room, so the numbering of the parent stays without gaps; a  position beyond the end places the folder last. The value may also be sent as a dotted path, as in 1.2.3, in  which case only its last segment is read. Ordering is what the manual arrangement of a room is built on, and  it only means something in rooms whose contents are indexed - elsewhere the value is stored and ignored. The  caller needs edit access to the folder, which room managers and content creators have, and a member without it  is refused, while a folder that does not exist is answered as not found. The call is mutating and idempotent.  To move several entries in one go use `PUT api/2.0/files/order`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder to move.</param>
        /// <param name="orderRequestDto">The position the folder is to take. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-order/">REST API Reference for SetFolderOrder Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper SetFolderOrder(int folderId, OrderRequestDto? orderRequestDto = default);

        /// <summary>
        /// Set folder order
        /// </summary>
        /// <remarks>
        /// Puts a folder at a given position among the entries of its parent and answers with the folder, its `order`  reporting where it now stands. Positions count from 1, and the entry that held the wanted position, together  with everything after it, is shifted to make room, so the numbering of the parent stays without gaps; a  position beyond the end places the folder last. The value may also be sent as a dotted path, as in 1.2.3, in  which case only its last segment is read. Ordering is what the manual arrangement of a room is built on, and  it only means something in rooms whose contents are indexed - elsewhere the value is stored and ignored. The  caller needs edit access to the folder, which room managers and content creators have, and a member without it  is refused, while a folder that does not exist is answered as not found. The call is mutating and idempotent.  To move several entries in one go use `PUT api/2.0/files/order`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder to move.</param>
        /// <param name="orderRequestDto">The position the folder is to take. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-order/">REST API Reference for SetFolderOrder Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> SetFolderOrderWithHttpInfo(int folderId, OrderRequestDto? orderRequestDto = default);
        /// <summary>
        /// Set the folder external link
        /// </summary>
        /// <remarks>
        /// Creates an external link to a folder or a room, or changes or revokes an existing one, and answers with the  link as it now stands. `linkId` decides which: an identifier that is not yet in use, the empty one included,  creates a link, while the identifier of an existing link rewrites it, so the whole set of parameters is  applied every time and a field left out is reset rather than kept. `access` carries the rights the link  grants, and `access` set to the value that denies everything revokes the link instead - the answer is then  empty, and a revoked primary link is not recreated by a later read. `title` names the link for the people who  manage it, `expirationDate` limits its lifetime and is ignored when it lies in the past, `password` asks  visitors for a secret, `denyDownload` leaves them with viewing only, `internal` admits signed-in members  alone, and `primary=true` makes it the primary link of the folder. The caller needs the right to manage the  links of the room, which its manager and a portal administrator acting as room manager have; anyone else is  refused and an unknown folder is answered as not found. The call is mutating.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the link belongs to.</param>
        /// <param name="folderLinkRequest">The link and the way it is to be shaped.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-primary-external-link/">REST API Reference for SetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        FileShareWrapper SetFolderPrimaryExternalLink(int id, FolderLinkRequest folderLinkRequest);

        /// <summary>
        /// Set the folder external link
        /// </summary>
        /// <remarks>
        /// Creates an external link to a folder or a room, or changes or revokes an existing one, and answers with the  link as it now stands. `linkId` decides which: an identifier that is not yet in use, the empty one included,  creates a link, while the identifier of an existing link rewrites it, so the whole set of parameters is  applied every time and a field left out is reset rather than kept. `access` carries the rights the link  grants, and `access` set to the value that denies everything revokes the link instead - the answer is then  empty, and a revoked primary link is not recreated by a later read. `title` names the link for the people who  manage it, `expirationDate` limits its lifetime and is ignored when it lies in the past, `password` asks  visitors for a secret, `denyDownload` leaves them with viewing only, `internal` admits signed-in members  alone, and `primary=true` makes it the primary link of the folder. The caller needs the right to manage the  links of the room, which its manager and a portal administrator acting as room manager have; anyone else is  refused and an unknown folder is answered as not found. The call is mutating.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the link belongs to.</param>
        /// <param name="folderLinkRequest">The link and the way it is to be shaped.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-primary-external-link/">REST API Reference for SetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        ApiResponse<FileShareWrapper> SetFolderPrimaryExternalLinkWithHttpInfo(int id, FolderLinkRequest folderLinkRequest);
        /// <summary>
        /// Terminate the folder history report generation
        /// </summary>
        /// <remarks>
        /// Gives up the history report the caller has started for a folder with  `POST api/2.0/files/folder/{folderId}/log/report`. The request only asks the background worker to stop, and  the answer carries no body, so a following `GET api/2.0/files/folder/{folderId}/log/report` is what shows the  task ending as cancelled. Asking to terminate when nothing is running is accepted and changes nothing, which  makes the call safe to repeat. A report that has already finished is not undone by this call and its file  stays in My documents. The caller needs read access to the folder and may not be a guest, and the portal  plan has to include the audit feature; a caller who fails the access rule is answered with 403 and a folder  that does not exist with 404. Each caller can only terminate their own report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose running history report is to be given up. It is the folder that              was passed to the operation that started the report.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-report-folder-history/">REST API Reference for TerminateReportFolderHistory Operation</seealso>
        /// <returns></returns>
        void TerminateReportFolderHistory(int folderId);

        /// <summary>
        /// Terminate the folder history report generation
        /// </summary>
        /// <remarks>
        /// Gives up the history report the caller has started for a folder with  `POST api/2.0/files/folder/{folderId}/log/report`. The request only asks the background worker to stop, and  the answer carries no body, so a following `GET api/2.0/files/folder/{folderId}/log/report` is what shows the  task ending as cancelled. Asking to terminate when nothing is running is accepted and changes nothing, which  makes the call safe to repeat. A report that has already finished is not undone by this call and its file  stays in My documents. The caller needs read access to the folder and may not be a guest, and the portal  plan has to include the audit feature; a caller who fails the access rule is answered with 403 and a folder  that does not exist with 404. Each caller can only terminate their own report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose running history report is to be given up. It is the folder that              was passed to the operation that started the report.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-report-folder-history/">REST API Reference for TerminateReportFolderHistory Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TerminateReportFolderHistoryWithHttpInfo(int folderId);
        /// <summary>
        /// Upload a file
        /// </summary>
        /// <remarks>
        /// Stores a file in the folder named by the path in a single multipart request, taking its name from the uploaded  part; use `POST api/2.0/files/{folderId}/insert` when the name has to be given separately or the content is  sent as a raw body. The answer is a list that always holds exactly one file. `createNewIfExist` settles the  clash: false adds a new version to the file that already carries the name, true keeps both by giving the new  one a numeric suffix. `storeOriginalFile` reaches further than this call, because it saves the setting on the  calling account, the same one `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later  uploads. The caller needs the right to add content to the folder, so a reader, an editor and a guest get 403,  a section root and an archived room are refused as well, and an unknown folder gives 404. A request without a  file is rejected as invalid, and a payload above the portal upload limit is refused.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="storeOriginalFile">Reaches further than this request: it writes a setting on the calling account, the same one  `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later uploads. True keeps both the  uploaded file and the copy the portal converts it into, false replaces the uploaded file with the converted  one, and leaving it out keeps whatever the account already has. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part; the name of that part becomes the title of the  stored file, with characters a title cannot hold replaced and the name cut to 170 characters. A request  without it is rejected as invalid. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file/">REST API Reference for UploadFile Operation</seealso>
        /// <returns>FileIntegerArrayWrapper</returns>
        FileIntegerArrayWrapper UploadFile(int folderId, bool? createNewIfExist = default, bool? storeOriginalFile = default, bool? keepConvertStatus = default, FileParameter? file = default);

        /// <summary>
        /// Upload a file
        /// </summary>
        /// <remarks>
        /// Stores a file in the folder named by the path in a single multipart request, taking its name from the uploaded  part; use `POST api/2.0/files/{folderId}/insert` when the name has to be given separately or the content is  sent as a raw body. The answer is a list that always holds exactly one file. `createNewIfExist` settles the  clash: false adds a new version to the file that already carries the name, true keeps both by giving the new  one a numeric suffix. `storeOriginalFile` reaches further than this call, because it saves the setting on the  calling account, the same one `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later  uploads. The caller needs the right to add content to the folder, so a reader, an editor and a guest get 403,  a section root and an archived room are refused as well, and an unknown folder gives 404. A request without a  file is rejected as invalid, and a payload above the portal upload limit is refused.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="storeOriginalFile">Reaches further than this request: it writes a setting on the calling account, the same one  `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later uploads. True keeps both the  uploaded file and the copy the portal converts it into, false replaces the uploaded file with the converted  one, and leaving it out keeps whatever the account already has. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part; the name of that part becomes the title of the  stored file, with characters a title cannot hold replaced and the name cut to 170 characters. A request  without it is rejected as invalid. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file/">REST API Reference for UploadFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerArrayWrapper</returns>
        ApiResponse<FileIntegerArrayWrapper> UploadFileWithHttpInfo(int folderId, bool? createNewIfExist = default, bool? storeOriginalFile = default, bool? keepConvertStatus = default, FileParameter? file = default);
        /// <summary>
        /// Upload a file to My documents
        /// </summary>
        /// <remarks>
        /// Uploads one file into the caller's own My documents section and returns it inside a single-element array; one  request stores exactly one file. The destination takes no identifier: it is resolved from the calling account  and created on first use, while a guest account has none and is answered as missing (404). The body has to be  `multipart/form-data` carrying the file part; a request without it is rejected as invalid, and the stored name  comes from that part, since unlike `POST api/2.0/files/@my/insert` there is no separate title. The call is not  idempotent: by default a file of the same title is overwritten as a new version, while `createNewIfExist=true`  stores a separate copy under a title made unique with a numeric suffix. `storeOriginalFile` is not a  per-request switch: it writes the same account setting as `PUT api/2.0/files/storeoriginal`, which decides  what happens to the formats listed in `extsMustConvert` of `GET api/2.0/files/settings` when they are  converted after the response - false replaces the uploaded file with the converted one, true keeps both;  `keepConvertStatus=true` keeps that conversion result readable through  `GET api/2.0/files/file/{fileId}/checkconversion`. Files over the single-request size limit or the account's  storage quota are refused; send those through `POST api/2.0/files/{folderId}/upload/create_session`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="storeOriginalFile">Reaches further than this request: it writes a setting on the calling account, the same one  `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later uploads. True keeps both the  uploaded file and the copy the portal converts it into, false replaces the uploaded file with the converted  one, and leaving it out keeps whatever the account already has. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part; the name of that part becomes the title of the  stored file, with characters a title cannot hold replaced and the name cut to 170 characters. A request  without it is rejected as invalid. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file-to-my/">REST API Reference for UploadFileToMy Operation</seealso>
        /// <returns>FileIntegerArrayWrapper</returns>
        FileIntegerArrayWrapper UploadFileToMy(bool? createNewIfExist = default, bool? storeOriginalFile = default, bool? keepConvertStatus = default, FileParameter? file = default);

        /// <summary>
        /// Upload a file to My documents
        /// </summary>
        /// <remarks>
        /// Uploads one file into the caller's own My documents section and returns it inside a single-element array; one  request stores exactly one file. The destination takes no identifier: it is resolved from the calling account  and created on first use, while a guest account has none and is answered as missing (404). The body has to be  `multipart/form-data` carrying the file part; a request without it is rejected as invalid, and the stored name  comes from that part, since unlike `POST api/2.0/files/@my/insert` there is no separate title. The call is not  idempotent: by default a file of the same title is overwritten as a new version, while `createNewIfExist=true`  stores a separate copy under a title made unique with a numeric suffix. `storeOriginalFile` is not a  per-request switch: it writes the same account setting as `PUT api/2.0/files/storeoriginal`, which decides  what happens to the formats listed in `extsMustConvert` of `GET api/2.0/files/settings` when they are  converted after the response - false replaces the uploaded file with the converted one, true keeps both;  `keepConvertStatus=true` keeps that conversion result readable through  `GET api/2.0/files/file/{fileId}/checkconversion`. Files over the single-request size limit or the account's  storage quota are refused; send those through `POST api/2.0/files/{folderId}/upload/create_session`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="storeOriginalFile">Reaches further than this request: it writes a setting on the calling account, the same one  `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later uploads. True keeps both the  uploaded file and the copy the portal converts it into, false replaces the uploaded file with the converted  one, and leaving it out keeps whatever the account already has. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part; the name of that part becomes the title of the  stored file, with characters a title cannot hold replaced and the name cut to 170 characters. A request  without it is rejected as invalid. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file-to-my/">REST API Reference for UploadFileToMy Operation</seealso>
        /// <returns>ApiResponse of FileIntegerArrayWrapper</returns>
        ApiResponse<FileIntegerArrayWrapper> UploadFileToMyWithHttpInfo(bool? createNewIfExist = default, bool? storeOriginalFile = default, bool? keepConvertStatus = default, FileParameter? file = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFoldersApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Check for upload conflicts
        /// </summary>
        /// <remarks>
        /// Reports which of the submitted titles already belong to a file in the folder, so an upload can decide in  advance whether to overwrite or to ask for another name. Only the clashing titles come back, unordered and  without repetitions, and an empty array means every name is free. Matching is by title and ignores case, so a  name that differs only in capitalisation is still reported; an existing file that is encrypted is left out,  because an upload cannot take it over. The call changes nothing. It needs the same right as the upload itself,  the right to add content to the folder, which room managers and content creators have and readers, editors and  guests do not; an archived room, a section root and a folder the caller cannot write to are all refused, while  an unknown folder is answered as missing. A request without `filesTitle` is rejected as an invalid request, an  empty list is accepted and answers with an empty array.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose contents the names are tested against; take the id from a listing such as  `GET api/2.0/files/@root`.</param>
        /// <param name="checkUploadRequest">The names to test against the files the folder already holds.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-upload/">REST API Reference for CheckUpload Operation</seealso>
        /// <returns>Task of STRINGArrayWrapper</returns>
        Task<STRINGArrayWrapper> CheckUploadAsync(int folderId, CheckUploadRequest checkUploadRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Check for upload conflicts
        /// </summary>
        /// <remarks>
        /// Reports which of the submitted titles already belong to a file in the folder, so an upload can decide in  advance whether to overwrite or to ask for another name. Only the clashing titles come back, unordered and  without repetitions, and an empty array means every name is free. Matching is by title and ignores case, so a  name that differs only in capitalisation is still reported; an existing file that is encrypted is left out,  because an upload cannot take it over. The call changes nothing. It needs the same right as the upload itself,  the right to add content to the folder, which room managers and content creators have and readers, editors and  guests do not; an archived room, a section root and a folder the caller cannot write to are all refused, while  an unknown folder is answered as missing. A request without `filesTitle` is rejected as an invalid request, an  empty list is accepted and answers with an empty array.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose contents the names are tested against; take the id from a listing such as  `GET api/2.0/files/@root`.</param>
        /// <param name="checkUploadRequest">The names to test against the files the folder already holds.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-upload/">REST API Reference for CheckUpload Operation</seealso>
        /// <returns>Task of ApiResponse (STRINGArrayWrapper)</returns>
        Task<ApiResponse<STRINGArrayWrapper>> CheckUploadWithHttpInfoAsync(int folderId, CheckUploadRequest checkUploadRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a folder
        /// </summary>
        /// <remarks>
        /// Creates a folder inside the folder named in the path and answers with the folder as it was stored. The title  is trimmed, may not be blank and is refused when it is longer than the limit the schema prints; titles are not  required to be unique, so creating the same title twice leaves two folders side by side, which makes the call  mutating and not idempotent. The caller needs the right to create content in the parent, which the room  manager, a content creator and the owner of a personal section have; a member without that right, an archived  parent, and a section root that only holds rooms - Rooms, Forms and AI agents - are all refused, as is a  parent that does not exist. Rooms are not created here: use `POST api/2.0/files/rooms` for those, and this  operation for ordinary folders within them. Members of the room are notified of the new folder. Read the  identifier of the new folder from `id` and fill it with `POST api/2.0/files/{folderId}/upload`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the request is addressed to: when a folder is created it is the parent that receives the new  folder, and when a folder is renamed it is the folder that gets the new title.</param>
        /// <param name="createFolder">The title carried by the request body.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder/">REST API Reference for CreateFolder Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        Task<FolderIntegerWrapper> CreateFolderAsync(int folderId, CreateFolder createFolder, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a folder
        /// </summary>
        /// <remarks>
        /// Creates a folder inside the folder named in the path and answers with the folder as it was stored. The title  is trimmed, may not be blank and is refused when it is longer than the limit the schema prints; titles are not  required to be unique, so creating the same title twice leaves two folders side by side, which makes the call  mutating and not idempotent. The caller needs the right to create content in the parent, which the room  manager, a content creator and the owner of a personal section have; a member without that right, an archived  parent, and a section root that only holds rooms - Rooms, Forms and AI agents - are all refused, as is a  parent that does not exist. Rooms are not created here: use `POST api/2.0/files/rooms` for those, and this  operation for ordinary folders within them. Members of the room are notified of the new folder. Read the  identifier of the new folder from `id` and fill it with `POST api/2.0/files/{folderId}/upload`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the request is addressed to: when a folder is created it is the parent that receives the new  folder, and when a folder is renamed it is the folder that gets the new title.</param>
        /// <param name="createFolder">The title carried by the request body.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder/">REST API Reference for CreateFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        Task<ApiResponse<FolderIntegerWrapper>> CreateFolderWithHttpInfoAsync(int folderId, CreateFolder createFolder, CancellationToken cancellationToken = default);
        /// <summary>
        /// Create the folder primary external link
        /// </summary>
        /// <remarks>
        /// Answers with the primary external link of a folder or a room, creating it on the first call and returning the  one that already exists afterwards, so the operation is idempotent in effect: a second call with other  parameters does not reconfigure the existing link, and changing one is the business of  `PUT api/2.0/files/folder/{id}/links`. The parameters therefore only shape the link at the moment it is born -  `access` its rights, `title` its name, `expirationDate` its lifetime, which is unlimited here unless one is  given, `internal` whether only signed-in members may follow it, `denyDownload` whether the contents may only  be viewed, and `password` a secret to be asked for. Sending `access` with the value that grants nothing  creates no link and answers with nothing. The caller needs the right to manage the links of the room the  folder belongs to, which its manager and a portal administrator acting as room manager have, and a member with  content-creator or read access is refused with 403; an unknown folder is answered with 404. Read the address  from `sharedTo.shareLink`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the link belongs to.</param>
        /// <param name="folderLinkRequest">The link and the way it is to be shaped.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder-primary-external-link/">REST API Reference for CreateFolderPrimaryExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        Task<FileShareWrapper> CreateFolderPrimaryExternalLinkAsync(int id, FolderLinkRequest folderLinkRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create the folder primary external link
        /// </summary>
        /// <remarks>
        /// Answers with the primary external link of a folder or a room, creating it on the first call and returning the  one that already exists afterwards, so the operation is idempotent in effect: a second call with other  parameters does not reconfigure the existing link, and changing one is the business of  `PUT api/2.0/files/folder/{id}/links`. The parameters therefore only shape the link at the moment it is born -  `access` its rights, `title` its name, `expirationDate` its lifetime, which is unlimited here unless one is  given, `internal` whether only signed-in members may follow it, `denyDownload` whether the contents may only  be viewed, and `password` a secret to be asked for. Sending `access` with the value that grants nothing  creates no link and answers with nothing. The caller needs the right to manage the links of the room the  folder belongs to, which its manager and a portal administrator acting as room manager have, and a member with  content-creator or read access is refused with 403; an unknown folder is answered with 404. Read the address  from `sharedTo.shareLink`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the link belongs to.</param>
        /// <param name="folderLinkRequest">The link and the way it is to be shaped.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder-primary-external-link/">REST API Reference for CreateFolderPrimaryExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        Task<ApiResponse<FileShareWrapper>> CreateFolderPrimaryExternalLinkWithHttpInfoAsync(int id, FolderLinkRequest folderLinkRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Start the folder history report generation
        /// </summary>
        /// <remarks>
        /// Queues a background job that renders the history of a folder into a spreadsheet, or into a CSV file when  `format` asks for one, and saves the result in the caller's My documents. The answer is the queued task, not  the report: poll `GET api/2.0/files/folder/{folderId}/log/report` until `isCompleted` is true, then take the  file from `resultFileId`, `resultFileName` and `resultFileUrl`, of which a CSV report fills only the last two.  `from` and `to` limit the exported period; leaving both out exports the whole history. While a report for the  same folder and caller is still running, this call joins it and answers with the running task instead of  starting a second one, so retrying is safe. The caller needs read access to the folder and may not be a guest,  and the portal plan has to include the audit feature - otherwise the call is refused, with 403 for the access  rule and 404 for a folder that does not exist. Only a portal administrator gets the address, browser and  platform columns. Give up a running report with `DELETE api/2.0/files/folder/{folderId}/log/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose history is exported; the report covers the folder itself and the entries inside it.</param>
        /// <param name="format">The shape the report is written in: `Xlsx` produces a spreadsheet that is saved as a file of the portal, while  `Csv` produces a comma-separated text file that is uploaded to My documents without being reported back with  a file identifier. (optional)</param>
        /// <param name="from">The earliest moment an exported entry may have, read in the time zone of the portal; left out, the report  starts at the oldest entry the portal still keeps. (optional)</param>
        /// <param name="to">The latest moment an exported entry may have, read in the time zone of the portal; left out, the report ends  at the newest entry. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-report-folder-history/">REST API Reference for CreateReportFolderHistory Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        Task<DocumentBuilderTaskWrapper> CreateReportFolderHistoryAsync(int folderId, AuditReportFormat? format = default, DateTime? from = default, DateTime? to = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Start the folder history report generation
        /// </summary>
        /// <remarks>
        /// Queues a background job that renders the history of a folder into a spreadsheet, or into a CSV file when  `format` asks for one, and saves the result in the caller's My documents. The answer is the queued task, not  the report: poll `GET api/2.0/files/folder/{folderId}/log/report` until `isCompleted` is true, then take the  file from `resultFileId`, `resultFileName` and `resultFileUrl`, of which a CSV report fills only the last two.  `from` and `to` limit the exported period; leaving both out exports the whole history. While a report for the  same folder and caller is still running, this call joins it and answers with the running task instead of  starting a second one, so retrying is safe. The caller needs read access to the folder and may not be a guest,  and the portal plan has to include the audit feature - otherwise the call is refused, with 403 for the access  rule and 404 for a folder that does not exist. Only a portal administrator gets the address, browser and  platform columns. Give up a running report with `DELETE api/2.0/files/folder/{folderId}/log/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose history is exported; the report covers the folder itself and the entries inside it.</param>
        /// <param name="format">The shape the report is written in: `Xlsx` produces a spreadsheet that is saved as a file of the portal, while  `Csv` produces a comma-separated text file that is uploaded to My documents without being reported back with  a file identifier. (optional)</param>
        /// <param name="from">The earliest moment an exported entry may have, read in the time zone of the portal; left out, the report  starts at the oldest entry the portal still keeps. (optional)</param>
        /// <param name="to">The latest moment an exported entry may have, read in the time zone of the portal; left out, the report ends  at the newest entry. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-report-folder-history/">REST API Reference for CreateReportFolderHistory Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        Task<ApiResponse<DocumentBuilderTaskWrapper>> CreateReportFolderHistoryWithHttpInfoAsync(int folderId, AuditReportFormat? format = default, DateTime? from = default, DateTime? to = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a folder
        /// </summary>
        /// <remarks>
        /// Queues the deletion of one folder together with everything inside it, and answers with the file operations of  the caller, the one just created among them. The folder is not gone when the response arrives: poll  `GET api/2.0/files/fileops` until the operation reports `finished`, and read its `error` to learn whether the  deletion succeeded. By default the folder is moved to the Trash section, from where it can be restored;  `immediately=true` discards it for good instead, and inside a room, where there is no Trash, deletion is  always final. `deleteAfter=true` postpones the deletion until the editing sessions on the contents have ended,  so files somebody is working on are not pulled away. The caller needs the right to delete the folder, which  the room manager, a portal administrator acting as room manager and a content creator acting on a folder of  their own have; editing access alone, read access and a guest are refused. The call is destructive. To delete  several items at once use `PUT api/2.0/files/fileops/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder to delete, together with everything it holds.</param>
        /// <param name="deleteFolder">How the deletion is to be carried out.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-folder/">REST API Reference for DeleteFolder Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        Task<FileOperationArrayWrapper> DeleteFolderAsync(int folderId, DeleteFolder deleteFolder, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a folder
        /// </summary>
        /// <remarks>
        /// Queues the deletion of one folder together with everything inside it, and answers with the file operations of  the caller, the one just created among them. The folder is not gone when the response arrives: poll  `GET api/2.0/files/fileops` until the operation reports `finished`, and read its `error` to learn whether the  deletion succeeded. By default the folder is moved to the Trash section, from where it can be restored;  `immediately=true` discards it for good instead, and inside a room, where there is no Trash, deletion is  always final. `deleteAfter=true` postpones the deletion until the editing sessions on the contents have ended,  so files somebody is working on are not pulled away. The caller needs the right to delete the folder, which  the room manager, a portal administrator acting as room manager and a content creator acting on a folder of  their own have; editing access alone, read access and a guest are refused. The call is destructive. To delete  several items at once use `PUT api/2.0/files/fileops/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder to delete, together with everything it holds.</param>
        /// <param name="deleteFolder">How the deletion is to be carried out.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-folder/">REST API Reference for DeleteFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        Task<ApiResponse<FileOperationArrayWrapper>> DeleteFolderWithHttpInfoAsync(int folderId, DeleteFolder deleteFolder, CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate XLSX report by folder
        /// </summary>
        /// <remarks>
        /// Rebuilds the spreadsheet that gathers the answers submitted to a form, starting from the Complete folder  that holds the filled copies. The answer names the original form the results belong to, says in `isNewFile`  whether the spreadsheet is being created or an existing one rewritten in place, and carries the queued job in  `task`; the file itself is not ready yet, so poll `GET api/2.0/files/file/{fileId}/xlsx` with the identifier  of the form until the task reports completion. The folder has to be the Complete folder of a form-filling  room and has to hold at least one submitted copy whose original form still exists, and the caller needs the  right to maintain that form, which the room manager has. A folder that does not exist, or one that holds  nothing to report on, is answered with 404, and a folder of the wrong kind or a caller without those rights  with 403. The call is mutating: it writes the results file of the form.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/generate-xlsx-by-folder/">REST API Reference for GenerateXlsxByFolder Operation</seealso>
        /// <returns>Task of XlsxReportResponseWrapper</returns>
        Task<XlsxReportResponseWrapper> GenerateXlsxByFolderAsync(int folderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate XLSX report by folder
        /// </summary>
        /// <remarks>
        /// Rebuilds the spreadsheet that gathers the answers submitted to a form, starting from the Complete folder  that holds the filled copies. The answer names the original form the results belong to, says in `isNewFile`  whether the spreadsheet is being created or an existing one rewritten in place, and carries the queued job in  `task`; the file itself is not ready yet, so poll `GET api/2.0/files/file/{fileId}/xlsx` with the identifier  of the form until the task reports completion. The folder has to be the Complete folder of a form-filling  room and has to hold at least one submitted copy whose original form still exists, and the caller needs the  right to maintain that form, which the room manager has. A folder that does not exist, or one that holds  nothing to report on, is answered with 404, and a folder of the wrong kind or a caller without those rights  with 403. The call is mutating: it writes the results file of the form.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/generate-xlsx-by-folder/">REST API Reference for GenerateXlsxByFolder Operation</seealso>
        /// <returns>Task of ApiResponse (XlsxReportResponseWrapper)</returns>
        Task<ApiResponse<XlsxReportResponseWrapper>> GenerateXlsxByFolderWithHttpInfoAsync(int folderId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the Favorites section
        /// </summary>
        /// <remarks>
        /// Returns the caller's own Favorites section: the files and folders this account has marked as favorite,  together with the section folder itself. Favorites are per-account, so the entries another member marked are  not listed here, and a guest sees only their own, usually empty, list. Mark a single file with  `GET api/2.0/files/favorites/{fileId}`, or add and remove batches of files and folders with  `POST api/2.0/files/favorites` and `DELETE api/2.0/files/favorites`. Nothing in the section is modified,  though passing `sortBy` saves the requested order as the default order for this account. Entries the caller  can no longer read, and entries that have been moved to the Trash section, drop out of the listing even  though their favorite mark stays, so the section can shrink without an explicit unmark. `folders` and `files`  hold one page of the section, `total` counts the entries matching the request before `count` and `startIndex`  are applied, and `current` describes the section folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the section unfiltered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-favorites-folder/">REST API Reference for GetFavoritesFolder Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        Task<FolderContentIntegerWrapper> GetFavoritesFolderAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the Favorites section
        /// </summary>
        /// <remarks>
        /// Returns the caller's own Favorites section: the files and folders this account has marked as favorite,  together with the section folder itself. Favorites are per-account, so the entries another member marked are  not listed here, and a guest sees only their own, usually empty, list. Mark a single file with  `GET api/2.0/files/favorites/{fileId}`, or add and remove batches of files and folders with  `POST api/2.0/files/favorites` and `DELETE api/2.0/files/favorites`. Nothing in the section is modified,  though passing `sortBy` saves the requested order as the default order for this account. Entries the caller  can no longer read, and entries that have been moved to the Trash section, drop out of the listing even  though their favorite mark stays, so the section can shrink without an explicit unmark. `folders` and `files`  hold one page of the section, `total` counts the entries matching the request before `count` and `startIndex`  are applied, and `current` describes the section folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the section unfiltered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-favorites-folder/">REST API Reference for GetFavoritesFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        Task<ApiResponse<FolderContentIntegerWrapper>> GetFavoritesFolderWithHttpInfoAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get used space of files
        /// </summary>
        /// <remarks>
        /// Reports how much storage the portal spends on documents, split by section - My documents, Trash, Rooms,  Archive and, where the feature is on, AI agents - each entry naming the section and the space it takes in  bytes. The figures cover the whole portal rather than the calling account, and moving an entry between  sections moves its space with it, which is why deleting a file to the Trash does not free anything until the  Trash is emptied. Only a caller who may change portal settings, that is the owner and the portal  administrators, is allowed here; a room administrator, an ordinary member and a guest are all refused. The  call is read-only, takes no parameters and answers with the sections in a fixed order. The quota of the portal  as a whole, storage outside documents included, is not part of this answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-used-space/">REST API Reference for GetFilesUsedSpace Operation</seealso>
        /// <returns>Task of FilesStatisticsResultWrapper</returns>
        Task<FilesStatisticsResultWrapper> GetFilesUsedSpaceAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get used space of files
        /// </summary>
        /// <remarks>
        /// Reports how much storage the portal spends on documents, split by section - My documents, Trash, Rooms,  Archive and, where the feature is on, AI agents - each entry naming the section and the space it takes in  bytes. The figures cover the whole portal rather than the calling account, and moving an entry between  sections moves its space with it, which is why deleting a file to the Trash does not free anything until the  Trash is emptied. Only a caller who may change portal settings, that is the owner and the portal  administrators, is allowed here; a room administrator, an ordinary member and a guest are all refused. The  call is read-only, takes no parameters and answers with the sections in a fixed order. The quota of the portal  as a whole, storage outside documents included, is not part of this answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-used-space/">REST API Reference for GetFilesUsedSpace Operation</seealso>
        /// <returns>Task of ApiResponse (FilesStatisticsResultWrapper)</returns>
        Task<ApiResponse<FilesStatisticsResultWrapper>> GetFilesUsedSpaceWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get folder form filter
        /// </summary>
        /// <remarks>
        /// Lists the fields the completed forms of a form-filling room carry, each of them a key and the kind of value  behind it, so that a client can offer them as filters. Feed a pair from this list back as `formsItemKey` and  `formsItemType` of `GET api/2.0/files/{folderId}` to keep only the completed forms whose field of that name  holds a value. The fields are read from the search index of one of the forms already gathered, so they appear  once indexing has caught up with the first submission. Only the Complete folder of a form-filling room  carries such fields: for any other folder, for a folder that does not exist and for one that has been deleted  the answer is an empty list rather than a refusal, and the same holds while nothing has been submitted yet.  The operation reads the index alone, changes nothing and needs no authorization.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder/">REST API Reference for GetFolder Operation</seealso>
        /// <returns>Task of FormsItemArrayWrapper</returns>
        Task<FormsItemArrayWrapper> GetFolderAsync(int folderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get folder form filter
        /// </summary>
        /// <remarks>
        /// Lists the fields the completed forms of a form-filling room carry, each of them a key and the kind of value  behind it, so that a client can offer them as filters. Feed a pair from this list back as `formsItemKey` and  `formsItemType` of `GET api/2.0/files/{folderId}` to keep only the completed forms whose field of that name  holds a value. The fields are read from the search index of one of the forms already gathered, so they appear  once indexing has caught up with the first submission. Only the Complete folder of a form-filling room  carries such fields: for any other folder, for a folder that does not exist and for one that has been deleted  the answer is an empty list rather than a refusal, and the same holds while nothing has been submitted yet.  The operation reads the index alone, changes nothing and needs no authorization.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder/">REST API Reference for GetFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FormsItemArrayWrapper)</returns>
        Task<ApiResponse<FormsItemArrayWrapper>> GetFolderWithHttpInfoAsync(int folderId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a folder by ID
        /// </summary>
        /// <remarks>
        /// Returns one page of the contents of a folder - its subfolders in `folders`, its files in `files`, the folder  itself in `current` and the chain of parents in `pathParts` - and is the operation a client browses the file  tree with. `filterType`, `filterValue`, `extension`, `userIdOrGroupId`, `sharedBy` and `folderType` narrow  what is listed, `applyFilterOption` decides whether those filters bite on the files, on the folders or on  both, and `withSubFolders`, which is on unless it is switched off, lets a narrowed request descend through the  whole subtree instead of the top level alone. `filterValue` is matched against titles and against indexed  document content, and indexing is asynchronous, so a file uploaded a moment ago can be missing from a search  for a short while. `count` and `startIndex` page through the result while `total` counts everything that  matches, and `sortBy` with `sortOrder` both order the page and are saved as the default order of the account.  Reading a room or an ordinary folder clears its new-item marks for the caller. A caller who may not read the  folder is answered with 403, and a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose contents are listed. Each section root has an operation of its own, such as  `GET api/2.0/files/@my`, and every other folder is opened by the identifier a listing gave for it.</param>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="sharedBy">Restricts the listing to the entries this member shared, which narrows a shared listing down to what one  person handed out. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, spreadsheets, images or one type of room.  Omit it to list every kind the folder holds. (optional)</param>
        /// <param name="roomId">Keeps only the entries that lie in this room, which matters when the listing being read gathers entries from  more than one of them. (optional)</param>
        /// <param name="folderType">Keeps only the folders of these kinds, each given as the number of a folder type; it is how a listing is  narrowed down to, say, the form-filling folders of a room. (optional)</param>
        /// <param name="excludeSubject">Turns `userIdOrGroupId` around: with true the entries of that member or group are the ones left out, with  false they are the only ones kept. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="withSubFolders">Whether a narrowed request reaches into the subfolders: with true, which is what an omitted parameter means,  matching entries are gathered from the whole subtree, with false only the top level is read. It makes a  difference only once `filterType`, `userIdOrGroupId` or `filterValue` narrows the request, because an  unfiltered listing always shows the top level alone. (optional)</param>
        /// <param name="extension">Keeps only the files carrying one of these extensions, several of them separated by commas; the leading dot is  optional. (optional)</param>
        /// <param name="searchArea">Which area a listing that spans several of them is taken from - the active rooms, the archive, the room  templates or the form-filling rooms. A folder that belongs to one area only settles the area itself and  ignores the parameter. (optional)</param>
        /// <param name="formsItemKey">Keeps only the completed forms whose form field of this name holds a value. Take the name from  `GET api/2.0/files/{folderId}/formfilter`, and use it in the folder that gathers the completed copies of a  form-filling room. (optional)</param>
        /// <param name="formsItemType">The kind of the form field named by `formsItemKey`, taken from the same list; the two are sent together. (optional)</param>
        /// <param name="count">The size of one page of the listing. Pair it with `startIndex` to walk through the result, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the listing is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the folder unfiltered. (optional)</param>
        /// <param name="location">Where the entries of a tag-based listing have to live to be kept: `Room` keeps what lies in a room,  `Documents` what lies in a personal section, and `Link` what was reached through an external link that is  still valid. It shapes the Favorites and Recent listings and does nothing in an ordinary folder. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-by-folder-id/">REST API Reference for GetFolderByFolderId Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        Task<FolderContentIntegerWrapper> GetFolderByFolderIdAsync(int folderId, Guid? userIdOrGroupId = default, Guid? sharedBy = default, FilterType? filterType = default, int? roomId = default, List<int>? folderType = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, bool? withSubFolders = default, string? extension = default, SearchArea? searchArea = default, string? formsItemKey = default, string? formsItemType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, Location? location = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a folder by ID
        /// </summary>
        /// <remarks>
        /// Returns one page of the contents of a folder - its subfolders in `folders`, its files in `files`, the folder  itself in `current` and the chain of parents in `pathParts` - and is the operation a client browses the file  tree with. `filterType`, `filterValue`, `extension`, `userIdOrGroupId`, `sharedBy` and `folderType` narrow  what is listed, `applyFilterOption` decides whether those filters bite on the files, on the folders or on  both, and `withSubFolders`, which is on unless it is switched off, lets a narrowed request descend through the  whole subtree instead of the top level alone. `filterValue` is matched against titles and against indexed  document content, and indexing is asynchronous, so a file uploaded a moment ago can be missing from a search  for a short while. `count` and `startIndex` page through the result while `total` counts everything that  matches, and `sortBy` with `sortOrder` both order the page and are saved as the default order of the account.  Reading a room or an ordinary folder clears its new-item marks for the caller. A caller who may not read the  folder is answered with 403, and a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose contents are listed. Each section root has an operation of its own, such as  `GET api/2.0/files/@my`, and every other folder is opened by the identifier a listing gave for it.</param>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="sharedBy">Restricts the listing to the entries this member shared, which narrows a shared listing down to what one  person handed out. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, spreadsheets, images or one type of room.  Omit it to list every kind the folder holds. (optional)</param>
        /// <param name="roomId">Keeps only the entries that lie in this room, which matters when the listing being read gathers entries from  more than one of them. (optional)</param>
        /// <param name="folderType">Keeps only the folders of these kinds, each given as the number of a folder type; it is how a listing is  narrowed down to, say, the form-filling folders of a room. (optional)</param>
        /// <param name="excludeSubject">Turns `userIdOrGroupId` around: with true the entries of that member or group are the ones left out, with  false they are the only ones kept. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="withSubFolders">Whether a narrowed request reaches into the subfolders: with true, which is what an omitted parameter means,  matching entries are gathered from the whole subtree, with false only the top level is read. It makes a  difference only once `filterType`, `userIdOrGroupId` or `filterValue` narrows the request, because an  unfiltered listing always shows the top level alone. (optional)</param>
        /// <param name="extension">Keeps only the files carrying one of these extensions, several of them separated by commas; the leading dot is  optional. (optional)</param>
        /// <param name="searchArea">Which area a listing that spans several of them is taken from - the active rooms, the archive, the room  templates or the form-filling rooms. A folder that belongs to one area only settles the area itself and  ignores the parameter. (optional)</param>
        /// <param name="formsItemKey">Keeps only the completed forms whose form field of this name holds a value. Take the name from  `GET api/2.0/files/{folderId}/formfilter`, and use it in the folder that gathers the completed copies of a  form-filling room. (optional)</param>
        /// <param name="formsItemType">The kind of the form field named by `formsItemKey`, taken from the same list; the two are sent together. (optional)</param>
        /// <param name="count">The size of one page of the listing. Pair it with `startIndex` to walk through the result, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the listing is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the folder unfiltered. (optional)</param>
        /// <param name="location">Where the entries of a tag-based listing have to live to be kept: `Room` keeps what lies in a room,  `Documents` what lies in a personal section, and `Link` what was reached through an external link that is  still valid. It shapes the Favorites and Recent listings and does nothing in an ordinary folder. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-by-folder-id/">REST API Reference for GetFolderByFolderId Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        Task<ApiResponse<FolderContentIntegerWrapper>> GetFolderByFolderIdWithHttpInfoAsync(int folderId, Guid? userIdOrGroupId = default, Guid? sharedBy = default, FilterType? filterType = default, int? roomId = default, List<int>? folderType = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, bool? withSubFolders = default, string? extension = default, SearchArea? searchArea = default, string? formsItemKey = default, string? formsItemType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, Location? location = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get folder history
        /// </summary>
        /// <remarks>
        /// Lists what has happened to a folder and to the entries inside it - creations, renames, uploads, moves,  deletions and changes of access - each record naming the action, the moment it happened and the member behind  it. Records that belong to one action are grouped, so a batch arrives as a single entry carrying the rest of  itself in `related`, and the list runs from the most recent record backwards. `fromDate` and `toDate` narrow  the period, `startIndex` and `count` page through the result, and the number of records matching the request  is reported in the response headers rather than in the body. Any member who can read the folder may read its  history; a caller without access is answered with 403 and a folder that does not exist with 404. When the  folder is a form-filling folder the caller reached through a filling invitation, the history is narrowed to  what that caller may see. The call is read-only. To take the same history away as a spreadsheet, start a  report with `POST api/2.0/files/folder/{folderId}/log/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose activity log is read; the log covers the folder itself and the entries inside it.</param>
        /// <param name="fromDate">The earliest moment an entry may have, read in the time zone of the portal; left out, the log starts at the  oldest entry the portal still keeps. (optional)</param>
        /// <param name="toDate">The latest moment an entry may have, read in the time zone of the portal; left out, the log ends at the newest  entry. (optional)</param>
        /// <param name="count">How many entries one page holds. The number of entries that match the query is reported in the response  headers, not in the body. (optional)</param>
        /// <param name="startIndex">How many entries to skip before the page begins, counted from the newest one, so pages are taken by adding the  page size to it. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-history/">REST API Reference for GetFolderHistory Operation</seealso>
        /// <returns>Task of HistoryArrayWrapper</returns>
        Task<HistoryArrayWrapper> GetFolderHistoryAsync(int folderId, DateTime? fromDate = default, DateTime? toDate = default, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get folder history
        /// </summary>
        /// <remarks>
        /// Lists what has happened to a folder and to the entries inside it - creations, renames, uploads, moves,  deletions and changes of access - each record naming the action, the moment it happened and the member behind  it. Records that belong to one action are grouped, so a batch arrives as a single entry carrying the rest of  itself in `related`, and the list runs from the most recent record backwards. `fromDate` and `toDate` narrow  the period, `startIndex` and `count` page through the result, and the number of records matching the request  is reported in the response headers rather than in the body. Any member who can read the folder may read its  history; a caller without access is answered with 403 and a folder that does not exist with 404. When the  folder is a form-filling folder the caller reached through a filling invitation, the history is narrowed to  what that caller may see. The call is read-only. To take the same history away as a spreadsheet, start a  report with `POST api/2.0/files/folder/{folderId}/log/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose activity log is read; the log covers the folder itself and the entries inside it.</param>
        /// <param name="fromDate">The earliest moment an entry may have, read in the time zone of the portal; left out, the log starts at the  oldest entry the portal still keeps. (optional)</param>
        /// <param name="toDate">The latest moment an entry may have, read in the time zone of the portal; left out, the log ends at the newest  entry. (optional)</param>
        /// <param name="count">How many entries one page holds. The number of entries that match the query is reported in the response  headers, not in the body. (optional)</param>
        /// <param name="startIndex">How many entries to skip before the page begins, counted from the newest one, so pages are taken by adding the  page size to it. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-history/">REST API Reference for GetFolderHistory Operation</seealso>
        /// <returns>Task of ApiResponse (HistoryArrayWrapper)</returns>
        Task<ApiResponse<HistoryArrayWrapper>> GetFolderHistoryWithHttpInfoAsync(int folderId, DateTime? fromDate = default, DateTime? toDate = default, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get folder information
        /// </summary>
        /// <remarks>
        /// Returns one folder as an object - its title, its parent, the moments it was created and last changed, the  access the caller has to it, the number of items that are new for them, and the room settings when the folder  is a room - without listing anything inside it. Use it to resolve a folder identifier into something  displayable, and `GET api/2.0/files/{folderId}` when the contents are what is wanted; unlike that operation,  this one leaves the new-item marks of the folder alone. Any member who can read the folder may call it, and an  anonymous caller only through an external link that grants access, everybody else being refused; a folder that  does not exist is answered as not found. The call is read-only. The chain of parents above the folder is not  part of the answer and is read with `GET api/2.0/files/folder/{folderId}/path`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-info/">REST API Reference for GetFolderInfo Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        Task<FolderIntegerWrapper> GetFolderInfoAsync(int folderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get folder information
        /// </summary>
        /// <remarks>
        /// Returns one folder as an object - its title, its parent, the moments it was created and last changed, the  access the caller has to it, the number of items that are new for them, and the room settings when the folder  is a room - without listing anything inside it. Use it to resolve a folder identifier into something  displayable, and `GET api/2.0/files/{folderId}` when the contents are what is wanted; unlike that operation,  this one leaves the new-item marks of the folder alone. Any member who can read the folder may call it, and an  anonymous caller only through an external link that grants access, everybody else being refused; a folder that  does not exist is answered as not found. The call is read-only. The chain of parents above the folder is not  part of the answer and is read with `GET api/2.0/files/folder/{folderId}/path`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-info/">REST API Reference for GetFolderInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        Task<ApiResponse<FolderIntegerWrapper>> GetFolderInfoWithHttpInfoAsync(int folderId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get folder external links
        /// </summary>
        /// <remarks>
        /// Lists the external links of a folder or a room, each with its identifier, title, address, rights, expiration  date, password flag and download restriction, the primary link among them once it exists. At most the first  hundred links are answered and the number returned is reported in the response headers; there are no paging  parameters here. A folder that has never been shared by link answers with an empty list, and so does a member  who may read the folder but not manage its links - the empty answer therefore means nothing to show you  rather than no links exist. A member without access to the room is refused, an anonymous caller is rejected,  and a folder that does not exist is answered as not found. The call is read-only. Take an identifier from here  to `PUT api/2.0/files/folder/{id}/links` to change or remove that link, and read the primary one alone with  `GET api/2.0/files/folder/{id}/link`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room whose external links are listed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-links/">REST API Reference for GetFolderLinks Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        Task<FileShareArrayWrapper> GetFolderLinksAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get folder external links
        /// </summary>
        /// <remarks>
        /// Lists the external links of a folder or a room, each with its identifier, title, address, rights, expiration  date, password flag and download restriction, the primary link among them once it exists. At most the first  hundred links are answered and the number returned is reported in the response headers; there are no paging  parameters here. A folder that has never been shared by link answers with an empty list, and so does a member  who may read the folder but not manage its links - the empty answer therefore means nothing to show you  rather than no links exist. A member without access to the room is refused, an anonymous caller is rejected,  and a folder that does not exist is answered as not found. The call is read-only. Take an identifier from here  to `PUT api/2.0/files/folder/{id}/links` to change or remove that link, and read the primary one alone with  `GET api/2.0/files/folder/{id}/link`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room whose external links are listed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-links/">REST API Reference for GetFolderLinks Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        Task<ApiResponse<FileShareArrayWrapper>> GetFolderLinksWithHttpInfoAsync(int id, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the folder path
        /// </summary>
        /// <remarks>
        /// Returns the chain of folders that leads to the folder named in the path, ordered from the section root down to  the folder itself, which is the last entry. It is what a breadcrumb trail is built from, and it also tells a  client which section - a room, the personal section, the archive - a bare folder identifier belongs to. Only  the folders the caller may see are part of the chain, so a member who was given access to a folder deep inside  a room gets a shorter path than the room manager does. The caller needs read access to the folder and is  otherwise answered with 403, while a folder that does not exist is answered as not found. The call is  read-only and takes no paging parameters. To go the other way, from a folder down into its contents, call  `GET api/2.0/files/{folderId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-path/">REST API Reference for GetFolderPath Operation</seealso>
        /// <returns>Task of FileEntryBaseArrayWrapper</returns>
        Task<FileEntryBaseArrayWrapper> GetFolderPathAsync(int folderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the folder path
        /// </summary>
        /// <remarks>
        /// Returns the chain of folders that leads to the folder named in the path, ordered from the section root down to  the folder itself, which is the last entry. It is what a breadcrumb trail is built from, and it also tells a  client which section - a room, the personal section, the archive - a bare folder identifier belongs to. Only  the folders the caller may see are part of the chain, so a member who was given access to a folder deep inside  a room gets a shorter path than the room manager does. The caller needs read access to the folder and is  otherwise answered with 403, while a folder that does not exist is answered as not found. The call is  read-only and takes no paging parameters. To go the other way, from a folder down into its contents, call  `GET api/2.0/files/{folderId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-path/">REST API Reference for GetFolderPath Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryBaseArrayWrapper)</returns>
        Task<ApiResponse<FileEntryBaseArrayWrapper>> GetFolderPathWithHttpInfoAsync(int folderId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the folder primary external link
        /// </summary>
        /// <remarks>
        /// Answers with the primary external link of a folder or a room - the one the Copy link action of a client  hands out - with its address in `sharedTo.shareLink`, its rights in `access`, and its title, expiration date,  password flag and download restriction beside them. The link is created on the first read if the folder has  none, with read rights, no password and no expiry, so this operation mutates on that first call and is a plain  read afterwards; repeated calls answer with the same link identifier. The caller needs the right to manage the  links of the room the folder belongs to, which its manager and a portal administrator acting as room manager  have; a member with read access alone is refused with 403 and an anonymous caller is rejected, while a link  that was deliberately revoked is answered with 404 rather than being recreated. The paging parameters are  accepted for compatibility and leave the single link answered here unchanged. Every external link of the same  folder is listed by `GET api/2.0/files/folder/{id}/links`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the operation addresses. A folder stored on the portal is numbered, while a folder in a  connected third-party account is named by an opaque string.</param>
        /// <param name="count">How many entries at most to answer with, in the operations of this folder that return a list; an operation  that answers with a single object is not affected by it. (optional)</param>
        /// <param name="startIndex">How many entries of such a list to skip before answering, used together with `count` to walk through it page  by page. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-primary-external-link/">REST API Reference for GetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        Task<FileShareWrapper> GetFolderPrimaryExternalLinkAsync(int id, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the folder primary external link
        /// </summary>
        /// <remarks>
        /// Answers with the primary external link of a folder or a room - the one the Copy link action of a client  hands out - with its address in `sharedTo.shareLink`, its rights in `access`, and its title, expiration date,  password flag and download restriction beside them. The link is created on the first read if the folder has  none, with read rights, no password and no expiry, so this operation mutates on that first call and is a plain  read afterwards; repeated calls answer with the same link identifier. The caller needs the right to manage the  links of the room the folder belongs to, which its manager and a portal administrator acting as room manager  have; a member with read access alone is refused with 403 and an anonymous caller is rejected, while a link  that was deliberately revoked is answered with 404 rather than being recreated. The paging parameters are  accepted for compatibility and leave the single link answered here unchanged. Every external link of the same  folder is listed by `GET api/2.0/files/folder/{id}/links`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the operation addresses. A folder stored on the portal is numbered, while a folder in a  connected third-party account is named by an opaque string.</param>
        /// <param name="count">How many entries at most to answer with, in the operations of this folder that return a list; an operation  that answers with a single object is not affected by it. (optional)</param>
        /// <param name="startIndex">How many entries of such a list to skip before answering, used together with `count` to walk through it page  by page. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-primary-external-link/">REST API Reference for GetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        Task<ApiResponse<FileShareWrapper>> GetFolderPrimaryExternalLinkWithHttpInfoAsync(int id, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get subfolders
        /// </summary>
        /// <remarks>
        /// Lists the folders that sit directly inside the folder named in the path, ordered by title, without their own  contents and without the files that lie beside them. The whole list arrives at once - there are no paging or  filtering parameters here - so for a large folder, or when the files are wanted as well, use  `GET api/2.0/files/{folderId}`, which pages and filters. A folder that holds no subfolders answers with an  empty list. The caller needs read access to the folder, and only the subfolders they may see are listed, so a  member of a room can get fewer entries than its manager; a caller without access is answered with 403, and a  folder that does not exist, or one that has been deleted for good, is answered as not found. The call is  read-only and leaves the new-item marks of the folder alone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folders/">REST API Reference for GetFolders Operation</seealso>
        /// <returns>Task of FileEntryBaseArrayWrapper</returns>
        Task<FileEntryBaseArrayWrapper> GetFoldersAsync(int folderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get subfolders
        /// </summary>
        /// <remarks>
        /// Lists the folders that sit directly inside the folder named in the path, ordered by title, without their own  contents and without the files that lie beside them. The whole list arrives at once - there are no paging or  filtering parameters here - so for a large folder, or when the files are wanted as well, use  `GET api/2.0/files/{folderId}`, which pages and filters. A folder that holds no subfolders answers with an  empty list. The caller needs read access to the folder, and only the subfolders they may see are listed, so a  member of a room can get fewer entries than its manager; a caller without access is answered with 403, and a  folder that does not exist, or one that has been deleted for good, is answered as not found. The call is  read-only and leaves the new-item marks of the folder alone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folders/">REST API Reference for GetFolders Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryBaseArrayWrapper)</returns>
        Task<ApiResponse<FileEntryBaseArrayWrapper>> GetFoldersWithHttpInfoAsync(int folderId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the Forms section
        /// </summary>
        /// <remarks>
        /// Returns the Forms section: the flat list of form-filling rooms the caller may read. Such rooms are stored  under the Rooms tree but are surfaced only here, so `GET api/2.0/files/rooms` leaves them out of the active  area and lists them when `searchArea` names the forms area instead. The section is not expanded into room  content, so `folders` carries the rooms while `files` comes back empty; to read what is inside one of them,  call `GET api/2.0/files/{folderId}` with the room identifier. Nothing is modified, though passing `sortBy`  saves the requested order as the default order for this account. `filterType`, `filterValue`,  `userIdOrGroupId` and the sorting parameters narrow and order the room list, `count` and `startIndex` page  through it, `total` reports how many rooms match the request in full, and `current` describes the section  folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the section unfiltered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-forms-folder/">REST API Reference for GetFormsFolder Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        Task<FolderContentIntegerWrapper> GetFormsFolderAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the Forms section
        /// </summary>
        /// <remarks>
        /// Returns the Forms section: the flat list of form-filling rooms the caller may read. Such rooms are stored  under the Rooms tree but are surfaced only here, so `GET api/2.0/files/rooms` leaves them out of the active  area and lists them when `searchArea` names the forms area instead. The section is not expanded into room  content, so `folders` carries the rooms while `files` comes back empty; to read what is inside one of them,  call `GET api/2.0/files/{folderId}` with the room identifier. Nothing is modified, though passing `sortBy`  saves the requested order as the default order for this account. `filterType`, `filterValue`,  `userIdOrGroupId` and the sorting parameters narrow and order the room list, `count` and `startIndex` page  through it, `total` reports how many rooms match the request in full, and `current` describes the section  folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the section unfiltered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-forms-folder/">REST API Reference for GetFormsFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        Task<ApiResponse<FolderContentIntegerWrapper>> GetFormsFolderWithHttpInfoAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the My documents section
        /// </summary>
        /// <remarks>
        /// Returns the contents of the caller's My documents section, the personal storage that belongs to this account  alone and stays invisible to other members until something in it is shared explicitly. Any authenticated  member that has a personal section can read it; guest accounts are not given one, and the call then answers  404. Nothing in the section is modified, though passing `sortBy` saves the requested order as the default  order for this account. Without a filter only the top level of the section is listed; as soon as `filterType`,  `userIdOrGroupId` or `filterValue` narrows the request, the search descends through the whole subtree.  `filterValue` is matched against titles and against indexed document content, and the index is written  asynchronously, so a file uploaded a moment ago can be missing from a search for a short while. `folders` and  `files` hold one page of the result, `total` counts everything that matches before `count` and `startIndex`  are applied, and `current` describes the section folder. To open a folder inside the section, call  `GET api/2.0/files/{folderId}` with its identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by, matched as a substring of entry titles. Omit it to list the  section unfiltered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-my-folder/">REST API Reference for GetMyFolder Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        Task<FolderContentIntegerWrapper> GetMyFolderAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the My documents section
        /// </summary>
        /// <remarks>
        /// Returns the contents of the caller's My documents section, the personal storage that belongs to this account  alone and stays invisible to other members until something in it is shared explicitly. Any authenticated  member that has a personal section can read it; guest accounts are not given one, and the call then answers  404. Nothing in the section is modified, though passing `sortBy` saves the requested order as the default  order for this account. Without a filter only the top level of the section is listed; as soon as `filterType`,  `userIdOrGroupId` or `filterValue` narrows the request, the search descends through the whole subtree.  `filterValue` is matched against titles and against indexed document content, and the index is written  asynchronously, so a file uploaded a moment ago can be missing from a search for a short while. `folders` and  `files` hold one page of the result, `total` counts everything that matches before `count` and `startIndex`  are applied, and `current` describes the section folder. To open a folder inside the section, call  `GET api/2.0/files/{folderId}` with its identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by, matched as a substring of entry titles. Omit it to list the  section unfiltered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-my-folder/">REST API Reference for GetMyFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        Task<ApiResponse<FolderContentIntegerWrapper>> GetMyFolderWithHttpInfoAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get new folder items
        /// </summary>
        /// <remarks>
        /// Lists the entries of a folder that are new for the calling member - the files and folders created or changed  there since they last opened it - ordered from the most recently changed backwards. It is what the badge of a  room is filled from, and it is personal: two members of the same room get different answers. Reading this list  does not clear the marks, so the same entries come back until the folder itself is opened with  `GET api/2.0/files/{folderId}`, which does clear them. A folder with nothing new answers with an empty list,  and marks disappear on their own when the entry behind them is deleted or moved out of reach. The caller needs  read access to the folder and is otherwise answered with 403. The whole list arrives at once, without paging  or filtering, and the call is read-only.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-folder-items/">REST API Reference for GetNewFolderItems Operation</seealso>
        /// <returns>Task of FileEntryBaseArrayWrapper</returns>
        Task<FileEntryBaseArrayWrapper> GetNewFolderItemsAsync(int folderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get new folder items
        /// </summary>
        /// <remarks>
        /// Lists the entries of a folder that are new for the calling member - the files and folders created or changed  there since they last opened it - ordered from the most recently changed backwards. It is what the badge of a  room is filled from, and it is personal: two members of the same room get different answers. Reading this list  does not clear the marks, so the same entries come back until the folder itself is opened with  `GET api/2.0/files/{folderId}`, which does clear them. A folder with nothing new answers with an empty list,  and marks disappear on their own when the entry behind them is deleted or moved out of reach. The caller needs  read access to the folder and is otherwise answered with 403. The whole list arrives at once, without paging  or filtering, and the call is read-only.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-folder-items/">REST API Reference for GetNewFolderItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryBaseArrayWrapper)</returns>
        Task<ApiResponse<FileEntryBaseArrayWrapper>> GetNewFolderItemsWithHttpInfoAsync(int folderId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the Recent section
        /// </summary>
        /// <remarks>
        /// Returns the Recent section: the files the calling account has opened lately. The section holds files only,  so `folders` comes back empty, and it is personal, so another member's history is not visible here. A file is  added when it is opened and can also be added explicitly with `POST api/2.0/files/file/{fileId}/recent`;  `DELETE api/2.0/files/recent` clears the whole history, and `PUT api/2.0/files/displayrecent` switches the  section on and off for the account, which also decides whether `GET api/2.0/files/@root` includes it. Nothing  in the section is modified, though passing `sortBy` saves the requested order as the default order for this  account. The listing is ordered by the moment the caller last opened each file, newest first, and `sortBy` and  `sortOrder` do not change that order. `files` holds one page, `total` counts the files matching the request  before `count` and `startIndex` are applied, and `current` describes the section folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the files authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list the whole history. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of file, such as documents, spreadsheets or images. Omit it to list every  kind the history holds. (optional)</param>
        /// <param name="excludeSubject">Inverts `userIdOrGroupId`: with `true` the files of that member or group are the ones left out of the listing  instead of the only ones kept. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of a listing `filterType` and `filterValue` are applied to. The Recent section holds  files only, so the value does not change what comes back. (optional)</param>
        /// <param name="searchArea">The area a listing is taken from. The Recent section is assembled from the caller's own open history rather  than from an area, so the value does not change which files are returned. (optional)</param>
        /// <param name="extension">The file extensions the listing is limited to, matched against the end of the file name. The leading dot is  optional, and the parameter is repeated once per extension. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. The Recent section keeps its own newest-first order, so the value does not  reorder this listing. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. The Recent section keeps its own newest-first order, so the value does not reorder this  listing. (optional)</param>
        /// <param name="filterValue">The search string the history is filtered by: it is matched as a substring of file titles and against the  indexed document content as well. Omit it to list the whole history. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-recent-folder/">REST API Reference for GetRecentFolder Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        Task<FolderContentIntegerWrapper> GetRecentFolderAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, SearchArea? searchArea = default, List<string>? extension = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the Recent section
        /// </summary>
        /// <remarks>
        /// Returns the Recent section: the files the calling account has opened lately. The section holds files only,  so `folders` comes back empty, and it is personal, so another member's history is not visible here. A file is  added when it is opened and can also be added explicitly with `POST api/2.0/files/file/{fileId}/recent`;  `DELETE api/2.0/files/recent` clears the whole history, and `PUT api/2.0/files/displayrecent` switches the  section on and off for the account, which also decides whether `GET api/2.0/files/@root` includes it. Nothing  in the section is modified, though passing `sortBy` saves the requested order as the default order for this  account. The listing is ordered by the moment the caller last opened each file, newest first, and `sortBy` and  `sortOrder` do not change that order. `files` holds one page, `total` counts the files matching the request  before `count` and `startIndex` are applied, and `current` describes the section folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the files authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list the whole history. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of file, such as documents, spreadsheets or images. Omit it to list every  kind the history holds. (optional)</param>
        /// <param name="excludeSubject">Inverts `userIdOrGroupId`: with `true` the files of that member or group are the ones left out of the listing  instead of the only ones kept. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of a listing `filterType` and `filterValue` are applied to. The Recent section holds  files only, so the value does not change what comes back. (optional)</param>
        /// <param name="searchArea">The area a listing is taken from. The Recent section is assembled from the caller's own open history rather  than from an area, so the value does not change which files are returned. (optional)</param>
        /// <param name="extension">The file extensions the listing is limited to, matched against the end of the file name. The leading dot is  optional, and the parameter is repeated once per extension. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. The Recent section keeps its own newest-first order, so the value does not  reorder this listing. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. The Recent section keeps its own newest-first order, so the value does not reorder this  listing. (optional)</param>
        /// <param name="filterValue">The search string the history is filtered by: it is matched as a substring of file titles and against the  indexed document content as well. Omit it to list the whole history. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-recent-folder/">REST API Reference for GetRecentFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        Task<ApiResponse<FolderContentIntegerWrapper>> GetRecentFolderWithHttpInfoAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, SearchArea? searchArea = default, List<string>? extension = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the folder history report generation status
        /// </summary>
        /// <remarks>
        /// Reports how far the history report of a folder has got, and is the operation to poll after  `POST api/2.0/files/folder/{folderId}/log/report` has queued one. `percentage` climbs to 100, `isCompleted`  turns true when the job is over however it ended, `error` carries the reason when it failed, and  `resultFileId`, `resultFileName` and `resultFileUrl` name the file that was saved in the caller's My  documents - a CSV report leaving the identifier empty. An empty answer means there is no report for this  folder and caller, either because none was started or because a finished one has already been picked up by an  earlier poll. The caller needs read access to the folder and may not be a guest, and the portal plan has to  include the audit feature; a caller who fails the access rule is answered with 403 and a folder that does not  exist with 404. The call is read-only, and each caller sees only their own report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose history report is being polled. It is the folder that was              passed to the operation that started the report.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-report-folder-history/">REST API Reference for GetReportFolderHistory Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        Task<DocumentBuilderTaskWrapper> GetReportFolderHistoryAsync(int folderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the folder history report generation status
        /// </summary>
        /// <remarks>
        /// Reports how far the history report of a folder has got, and is the operation to poll after  `POST api/2.0/files/folder/{folderId}/log/report` has queued one. `percentage` climbs to 100, `isCompleted`  turns true when the job is over however it ended, `error` carries the reason when it failed, and  `resultFileId`, `resultFileName` and `resultFileUrl` name the file that was saved in the caller's My  documents - a CSV report leaving the identifier empty. An empty answer means there is no report for this  folder and caller, either because none was started or because a finished one has already been picked up by an  earlier poll. The caller needs read access to the folder and may not be a guest, and the portal plan has to  include the audit feature; a caller who fails the access rule is answered with 403 and a folder that does not  exist with 404. The call is read-only, and each caller sees only their own report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose history report is being polled. It is the folder that was              passed to the operation that started the report.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-report-folder-history/">REST API Reference for GetReportFolderHistory Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        Task<ApiResponse<DocumentBuilderTaskWrapper>> GetReportFolderHistoryWithHttpInfoAsync(int folderId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get filtered sections
        /// </summary>
        /// <remarks>
        /// Returns every top-level section the calling account can see in one response, each of them a full section  object carrying its own first page of content: Favorites, Recent, Shared with me, My documents,  Trash, Rooms, Forms, Archive and, while AI access is enabled for the portal, AI agents. A section is  left out when the account has none of it, which is why a guest gets no personal section, and Recent is  listed only while it is switched on with `PUT api/2.0/files/displayrecent`. Pass `withoutTrash=true` to drop  the Trash section. The filters, `count` and `startIndex` are applied to each section separately, so  `count=1` returns one entry per section and every section reports its own `total`. Because it builds the  content of all of them, this is the most expensive listing in the module: when a single section is enough,  read it directly, for example with `GET api/2.0/files/@my`. The call modifies nothing in the sections and  leaves their new-item badges untouched, though passing `sortBy` saves the requested order as the default order  for this account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the content listed inside every returned section to a single kind of entry, such as documents, images  or one type of room. Omit it to list every kind the sections hold. (optional)</param>
        /// <param name="withoutTrash">Set it to `true` to leave the Trash section out of the returned set of sections; with `false`, or when the  parameter is omitted, the section is returned whenever the account has one of its own. (optional)</param>
        /// <param name="count">The size of the content page returned for each section separately, so a value of 1 yields one entry per  section rather than one entry in total. (optional)</param>
        /// <param name="startIndex">The number of matching entries skipped in each section before its page begins; add `count` to it to ask for  the next page of every section. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the content of every section is filtered by: it is matched as a substring of entry titles  and, for files, against the indexed document content as well. Omit it to list the sections unfiltered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-root-folders/">REST API Reference for GetRootFolders Operation</seealso>
        /// <returns>Task of FolderContentIntegerArrayWrapper</returns>
        Task<FolderContentIntegerArrayWrapper> GetRootFoldersAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? withoutTrash = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get filtered sections
        /// </summary>
        /// <remarks>
        /// Returns every top-level section the calling account can see in one response, each of them a full section  object carrying its own first page of content: Favorites, Recent, Shared with me, My documents,  Trash, Rooms, Forms, Archive and, while AI access is enabled for the portal, AI agents. A section is  left out when the account has none of it, which is why a guest gets no personal section, and Recent is  listed only while it is switched on with `PUT api/2.0/files/displayrecent`. Pass `withoutTrash=true` to drop  the Trash section. The filters, `count` and `startIndex` are applied to each section separately, so  `count=1` returns one entry per section and every section reports its own `total`. Because it builds the  content of all of them, this is the most expensive listing in the module: when a single section is enough,  read it directly, for example with `GET api/2.0/files/@my`. The call modifies nothing in the sections and  leaves their new-item badges untouched, though passing `sortBy` saves the requested order as the default order  for this account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the content listed inside every returned section to a single kind of entry, such as documents, images  or one type of room. Omit it to list every kind the sections hold. (optional)</param>
        /// <param name="withoutTrash">Set it to `true` to leave the Trash section out of the returned set of sections; with `false`, or when the  parameter is omitted, the section is returned whenever the account has one of its own. (optional)</param>
        /// <param name="count">The size of the content page returned for each section separately, so a value of 1 yields one entry per  section rather than one entry in total. (optional)</param>
        /// <param name="startIndex">The number of matching entries skipped in each section before its page begins; add `count` to it to ask for  the next page of every section. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the content of every section is filtered by: it is matched as a substring of entry titles  and, for files, against the indexed document content as well. Omit it to list the sections unfiltered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-root-folders/">REST API Reference for GetRootFolders Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerArrayWrapper)</returns>
        Task<ApiResponse<FolderContentIntegerArrayWrapper>> GetRootFoldersWithHttpInfoAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? withoutTrash = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the Trash section
        /// </summary>
        /// <remarks>
        /// Returns the caller's Trash section: the files and folders this account has deleted, kept there until they  are restored or discarded. Each member has a Trash of their own and sees only what they deleted themselves.  Restore an entry by moving it back with `PUT api/2.0/files/fileops/move`, or discard the whole section with  `PUT api/2.0/files/fileops/emptytrash`; both start a background operation that is polled through  `GET api/2.0/files/fileops`. This call itself modifies nothing, though passing `sortBy` saves the requested  order as the default order for this account. Only the top level of the section is listed, so the contents of a  deleted folder are not expanded into it, and `filterValue` is matched against titles alone here rather than  against document content. `folders` and `files` hold one page of the result, `total` counts everything that  matches before `count` and `startIndex` are applied, and `current` describes the section folder. An account  that is given no Trash of its own, an outsider for instance, receives 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by, matched as a substring of entry titles. Omit it to list the  section unfiltered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-trash-folder/">REST API Reference for GetTrashFolder Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        Task<FolderContentIntegerWrapper> GetTrashFolderAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the Trash section
        /// </summary>
        /// <remarks>
        /// Returns the caller's Trash section: the files and folders this account has deleted, kept there until they  are restored or discarded. Each member has a Trash of their own and sees only what they deleted themselves.  Restore an entry by moving it back with `PUT api/2.0/files/fileops/move`, or discard the whole section with  `PUT api/2.0/files/fileops/emptytrash`; both start a background operation that is polled through  `GET api/2.0/files/fileops`. This call itself modifies nothing, though passing `sortBy` saves the requested  order as the default order for this account. Only the top level of the section is listed, so the contents of a  deleted folder are not expanded into it, and `filterValue` is matched against titles alone here rather than  against document content. `folders` and `files` hold one page of the result, `total` counts everything that  matches before `count` and `startIndex` are applied, and `current` describes the section folder. An account  that is given no Trash of its own, an outsider for instance, receives 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by, matched as a substring of entry titles. Omit it to list the  section unfiltered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-trash-folder/">REST API Reference for GetTrashFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        Task<ApiResponse<FolderContentIntegerWrapper>> GetTrashFolderWithHttpInfoAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Insert a file
        /// </summary>
        /// <remarks>
        /// Stores a file in the folder named by the path in a single request, taking its name from `title` rather than  from the uploaded part, which is what separates it from `POST api/2.0/files/{folderId}/upload`. The content  may arrive either as a multipart part or as the raw request body. The name is stripped of characters a title  cannot hold and truncated, and `createNewIfExist` settles the clash: false adds a new version to the file that  already carries the name, true keeps both by giving the new one a numeric suffix. The caller needs the right  to add content to the folder, so a reader, an editor and a guest get 403, a section root and an archived room  are refused as well, and an unknown folder gives 404. Formats the portal converts are converted afterwards in  the background; pass `keepConvertStatus` to keep the outcome readable through  `GET api/2.0/files/file/{fileId}/checkconversion`. The answer is the stored file. A large payload belongs in a  chunked session instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="insertFileFile">The content to store, sent as a `multipart/form-data` part. The same content may instead be sent as the raw  request body, which is what a client that cannot build a form does; when both are present the form part wins. (optional)</param>
        /// <param name="insertFileTitle">The name to store the file under, extension included. It wins over the name of the uploaded part, which is the  reason to choose this operation over the plain upload, and it is the only name available when the content  arrives as a raw body. Characters a title cannot hold are replaced with underscores and the name is cut to 170  characters before the file is stored. (optional)</param>
        /// <param name="insertFileCreateNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="insertFileKeepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="insertFileStreamCanRead"> (optional)</param>
        /// <param name="insertFileStreamCanWrite"> (optional)</param>
        /// <param name="insertFileStreamCanSeek"> (optional)</param>
        /// <param name="insertFileStreamCanTimeout"> (optional)</param>
        /// <param name="insertFileStreamLength"> (optional)</param>
        /// <param name="insertFileStreamPosition"> (optional)</param>
        /// <param name="insertFileStreamReadTimeout"> (optional)</param>
        /// <param name="insertFileStreamWriteTimeout"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file/">REST API Reference for InsertFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        Task<FileIntegerWrapper> InsertFileAsync(int folderId, FileParameter? insertFileFile = default, string? insertFileTitle = default, bool? insertFileCreateNewIfExist = default, bool? insertFileKeepConvertStatus = default, bool? insertFileStreamCanRead = default, bool? insertFileStreamCanWrite = default, bool? insertFileStreamCanSeek = default, bool? insertFileStreamCanTimeout = default, long? insertFileStreamLength = default, long? insertFileStreamPosition = default, int? insertFileStreamReadTimeout = default, int? insertFileStreamWriteTimeout = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Insert a file
        /// </summary>
        /// <remarks>
        /// Stores a file in the folder named by the path in a single request, taking its name from `title` rather than  from the uploaded part, which is what separates it from `POST api/2.0/files/{folderId}/upload`. The content  may arrive either as a multipart part or as the raw request body. The name is stripped of characters a title  cannot hold and truncated, and `createNewIfExist` settles the clash: false adds a new version to the file that  already carries the name, true keeps both by giving the new one a numeric suffix. The caller needs the right  to add content to the folder, so a reader, an editor and a guest get 403, a section root and an archived room  are refused as well, and an unknown folder gives 404. Formats the portal converts are converted afterwards in  the background; pass `keepConvertStatus` to keep the outcome readable through  `GET api/2.0/files/file/{fileId}/checkconversion`. The answer is the stored file. A large payload belongs in a  chunked session instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="insertFileFile">The content to store, sent as a `multipart/form-data` part. The same content may instead be sent as the raw  request body, which is what a client that cannot build a form does; when both are present the form part wins. (optional)</param>
        /// <param name="insertFileTitle">The name to store the file under, extension included. It wins over the name of the uploaded part, which is the  reason to choose this operation over the plain upload, and it is the only name available when the content  arrives as a raw body. Characters a title cannot hold are replaced with underscores and the name is cut to 170  characters before the file is stored. (optional)</param>
        /// <param name="insertFileCreateNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="insertFileKeepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="insertFileStreamCanRead"> (optional)</param>
        /// <param name="insertFileStreamCanWrite"> (optional)</param>
        /// <param name="insertFileStreamCanSeek"> (optional)</param>
        /// <param name="insertFileStreamCanTimeout"> (optional)</param>
        /// <param name="insertFileStreamLength"> (optional)</param>
        /// <param name="insertFileStreamPosition"> (optional)</param>
        /// <param name="insertFileStreamReadTimeout"> (optional)</param>
        /// <param name="insertFileStreamWriteTimeout"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file/">REST API Reference for InsertFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        Task<ApiResponse<FileIntegerWrapper>> InsertFileWithHttpInfoAsync(int folderId, FileParameter? insertFileFile = default, string? insertFileTitle = default, bool? insertFileCreateNewIfExist = default, bool? insertFileKeepConvertStatus = default, bool? insertFileStreamCanRead = default, bool? insertFileStreamCanWrite = default, bool? insertFileStreamCanSeek = default, bool? insertFileStreamCanTimeout = default, long? insertFileStreamLength = default, long? insertFileStreamPosition = default, int? insertFileStreamReadTimeout = default, int? insertFileStreamWriteTimeout = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Insert a file into My documents
        /// </summary>
        /// <remarks>
        /// Stores one file in the caller's own My documents section, the personal storage every portal member has, and  returns the stored file. The destination takes no identifier: it is resolved from the calling account and  created on first use, while a guest account has none and is answered as missing (404). Send the content as a  `multipart/form-data` part or as the raw request body, and name it with `title`, which wins over the name of  the uploaded part and has invalid characters replaced before storing. The call is not idempotent: by default a  file of the same title is overwritten as a new version, while `createNewIfExist=true` stores a separate copy  under a title made unique with a numeric suffix; a title held by a file that is locked or open in the editor  cannot be overwritten either, and a second file appears under the same title. Formats listed in  `extsMustConvert` of `GET api/2.0/files/settings` are converted after the response is sent;  `keepConvertStatus=true` keeps that result readable through `GET api/2.0/files/file/{fileId}/checkconversion`,  which otherwise drops it. Files over the single-request size limit or the account's storage quota are refused:  send those through `POST api/2.0/files/{folderId}/upload/create_session`, and use  `POST api/2.0/files/{folderId}/insert` for any other destination.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part. The same content may instead be sent as the raw  request body, which is what a client that cannot build a form does; when both are present the form part wins. (optional)</param>
        /// <param name="title">The name to store the file under, extension included. It wins over the name of the uploaded part, which is the  reason to choose this operation over the plain upload, and it is the only name available when the content  arrives as a raw body. Characters a title cannot hold are replaced with underscores and the name is cut to 170  characters before the file is stored. (optional)</param>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="streamCanRead"> (optional)</param>
        /// <param name="streamCanWrite"> (optional)</param>
        /// <param name="streamCanSeek"> (optional)</param>
        /// <param name="streamCanTimeout"> (optional)</param>
        /// <param name="streamLength"> (optional)</param>
        /// <param name="streamPosition"> (optional)</param>
        /// <param name="streamReadTimeout"> (optional)</param>
        /// <param name="streamWriteTimeout"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file-to-my-from-body/">REST API Reference for InsertFileToMyFromBody Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        Task<FileIntegerWrapper> InsertFileToMyFromBodyAsync(FileParameter? file = default, string? title = default, bool? createNewIfExist = default, bool? keepConvertStatus = default, bool? streamCanRead = default, bool? streamCanWrite = default, bool? streamCanSeek = default, bool? streamCanTimeout = default, long? streamLength = default, long? streamPosition = default, int? streamReadTimeout = default, int? streamWriteTimeout = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Insert a file into My documents
        /// </summary>
        /// <remarks>
        /// Stores one file in the caller's own My documents section, the personal storage every portal member has, and  returns the stored file. The destination takes no identifier: it is resolved from the calling account and  created on first use, while a guest account has none and is answered as missing (404). Send the content as a  `multipart/form-data` part or as the raw request body, and name it with `title`, which wins over the name of  the uploaded part and has invalid characters replaced before storing. The call is not idempotent: by default a  file of the same title is overwritten as a new version, while `createNewIfExist=true` stores a separate copy  under a title made unique with a numeric suffix; a title held by a file that is locked or open in the editor  cannot be overwritten either, and a second file appears under the same title. Formats listed in  `extsMustConvert` of `GET api/2.0/files/settings` are converted after the response is sent;  `keepConvertStatus=true` keeps that result readable through `GET api/2.0/files/file/{fileId}/checkconversion`,  which otherwise drops it. Files over the single-request size limit or the account's storage quota are refused:  send those through `POST api/2.0/files/{folderId}/upload/create_session`, and use  `POST api/2.0/files/{folderId}/insert` for any other destination.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part. The same content may instead be sent as the raw  request body, which is what a client that cannot build a form does; when both are present the form part wins. (optional)</param>
        /// <param name="title">The name to store the file under, extension included. It wins over the name of the uploaded part, which is the  reason to choose this operation over the plain upload, and it is the only name available when the content  arrives as a raw body. Characters a title cannot hold are replaced with underscores and the name is cut to 170  characters before the file is stored. (optional)</param>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="streamCanRead"> (optional)</param>
        /// <param name="streamCanWrite"> (optional)</param>
        /// <param name="streamCanSeek"> (optional)</param>
        /// <param name="streamCanTimeout"> (optional)</param>
        /// <param name="streamLength"> (optional)</param>
        /// <param name="streamPosition"> (optional)</param>
        /// <param name="streamReadTimeout"> (optional)</param>
        /// <param name="streamWriteTimeout"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file-to-my-from-body/">REST API Reference for InsertFileToMyFromBody Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        Task<ApiResponse<FileIntegerWrapper>> InsertFileToMyFromBodyWithHttpInfoAsync(FileParameter? file = default, string? title = default, bool? createNewIfExist = default, bool? keepConvertStatus = default, bool? streamCanRead = default, bool? streamCanWrite = default, bool? streamCanSeek = default, bool? streamCanTimeout = default, long? streamLength = default, long? streamPosition = default, int? streamReadTimeout = default, int? streamWriteTimeout = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Rename a folder
        /// </summary>
        /// <remarks>
        /// Gives a folder a new title and answers with the folder as it now stands. The title is trimmed, may not be  blank and is refused when it is longer than the limit the schema prints; a title that matches the current one  leaves the folder untouched, and titles need not be unique among the neighbours. The caller needs the right to  rename the folder, which the room manager, a content creator acting on a folder of their own and the owner of  a personal section have, while a guest is refused with 403 whatever their access; a folder in the Trash  section or in an archived room cannot be renamed either, and a folder that does not exist is answered as  not found. A room may be renamed here as well, in which case the caller needs the right to edit the  room, and `PUT api/2.0/files/rooms/{id}` is the operation that changes its other settings. The call is  mutating and idempotent; on a folder stored in a connected third-party account the identifier of the folder  may change with the title.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the request is addressed to: when a folder is created it is the parent that receives the new  folder, and when a folder is renamed it is the folder that gets the new title.</param>
        /// <param name="createFolder">The title carried by the request body.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-folder/">REST API Reference for RenameFolder Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        Task<FolderIntegerWrapper> RenameFolderAsync(int folderId, CreateFolder createFolder, CancellationToken cancellationToken = default);

        /// <summary>
        /// Rename a folder
        /// </summary>
        /// <remarks>
        /// Gives a folder a new title and answers with the folder as it now stands. The title is trimmed, may not be  blank and is refused when it is longer than the limit the schema prints; a title that matches the current one  leaves the folder untouched, and titles need not be unique among the neighbours. The caller needs the right to  rename the folder, which the room manager, a content creator acting on a folder of their own and the owner of  a personal section have, while a guest is refused with 403 whatever their access; a folder in the Trash  section or in an archived room cannot be renamed either, and a folder that does not exist is answered as  not found. A room may be renamed here as well, in which case the caller needs the right to edit the  room, and `PUT api/2.0/files/rooms/{id}` is the operation that changes its other settings. The call is  mutating and idempotent; on a folder stored in a connected third-party account the identifier of the folder  may change with the title.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the request is addressed to: when a folder is created it is the parent that receives the new  folder, and when a folder is renamed it is the folder that gets the new title.</param>
        /// <param name="createFolder">The title carried by the request body.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-folder/">REST API Reference for RenameFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        Task<ApiResponse<FolderIntegerWrapper>> RenameFolderWithHttpInfoAsync(int folderId, CreateFolder createFolder, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set folder order
        /// </summary>
        /// <remarks>
        /// Puts a folder at a given position among the entries of its parent and answers with the folder, its `order`  reporting where it now stands. Positions count from 1, and the entry that held the wanted position, together  with everything after it, is shifted to make room, so the numbering of the parent stays without gaps; a  position beyond the end places the folder last. The value may also be sent as a dotted path, as in 1.2.3, in  which case only its last segment is read. Ordering is what the manual arrangement of a room is built on, and  it only means something in rooms whose contents are indexed - elsewhere the value is stored and ignored. The  caller needs edit access to the folder, which room managers and content creators have, and a member without it  is refused, while a folder that does not exist is answered as not found. The call is mutating and idempotent.  To move several entries in one go use `PUT api/2.0/files/order`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder to move.</param>
        /// <param name="orderRequestDto">The position the folder is to take. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-order/">REST API Reference for SetFolderOrder Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        Task<FolderIntegerWrapper> SetFolderOrderAsync(int folderId, OrderRequestDto? orderRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set folder order
        /// </summary>
        /// <remarks>
        /// Puts a folder at a given position among the entries of its parent and answers with the folder, its `order`  reporting where it now stands. Positions count from 1, and the entry that held the wanted position, together  with everything after it, is shifted to make room, so the numbering of the parent stays without gaps; a  position beyond the end places the folder last. The value may also be sent as a dotted path, as in 1.2.3, in  which case only its last segment is read. Ordering is what the manual arrangement of a room is built on, and  it only means something in rooms whose contents are indexed - elsewhere the value is stored and ignored. The  caller needs edit access to the folder, which room managers and content creators have, and a member without it  is refused, while a folder that does not exist is answered as not found. The call is mutating and idempotent.  To move several entries in one go use `PUT api/2.0/files/order`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder to move.</param>
        /// <param name="orderRequestDto">The position the folder is to take. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-order/">REST API Reference for SetFolderOrder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        Task<ApiResponse<FolderIntegerWrapper>> SetFolderOrderWithHttpInfoAsync(int folderId, OrderRequestDto? orderRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the folder external link
        /// </summary>
        /// <remarks>
        /// Creates an external link to a folder or a room, or changes or revokes an existing one, and answers with the  link as it now stands. `linkId` decides which: an identifier that is not yet in use, the empty one included,  creates a link, while the identifier of an existing link rewrites it, so the whole set of parameters is  applied every time and a field left out is reset rather than kept. `access` carries the rights the link  grants, and `access` set to the value that denies everything revokes the link instead - the answer is then  empty, and a revoked primary link is not recreated by a later read. `title` names the link for the people who  manage it, `expirationDate` limits its lifetime and is ignored when it lies in the past, `password` asks  visitors for a secret, `denyDownload` leaves them with viewing only, `internal` admits signed-in members  alone, and `primary=true` makes it the primary link of the folder. The caller needs the right to manage the  links of the room, which its manager and a portal administrator acting as room manager have; anyone else is  refused and an unknown folder is answered as not found. The call is mutating.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the link belongs to.</param>
        /// <param name="folderLinkRequest">The link and the way it is to be shaped.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-primary-external-link/">REST API Reference for SetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        Task<FileShareWrapper> SetFolderPrimaryExternalLinkAsync(int id, FolderLinkRequest folderLinkRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set the folder external link
        /// </summary>
        /// <remarks>
        /// Creates an external link to a folder or a room, or changes or revokes an existing one, and answers with the  link as it now stands. `linkId` decides which: an identifier that is not yet in use, the empty one included,  creates a link, while the identifier of an existing link rewrites it, so the whole set of parameters is  applied every time and a field left out is reset rather than kept. `access` carries the rights the link  grants, and `access` set to the value that denies everything revokes the link instead - the answer is then  empty, and a revoked primary link is not recreated by a later read. `title` names the link for the people who  manage it, `expirationDate` limits its lifetime and is ignored when it lies in the past, `password` asks  visitors for a secret, `denyDownload` leaves them with viewing only, `internal` admits signed-in members  alone, and `primary=true` makes it the primary link of the folder. The caller needs the right to manage the  links of the room, which its manager and a portal administrator acting as room manager have; anyone else is  refused and an unknown folder is answered as not found. The call is mutating.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the link belongs to.</param>
        /// <param name="folderLinkRequest">The link and the way it is to be shaped.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-primary-external-link/">REST API Reference for SetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        Task<ApiResponse<FileShareWrapper>> SetFolderPrimaryExternalLinkWithHttpInfoAsync(int id, FolderLinkRequest folderLinkRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Terminate the folder history report generation
        /// </summary>
        /// <remarks>
        /// Gives up the history report the caller has started for a folder with  `POST api/2.0/files/folder/{folderId}/log/report`. The request only asks the background worker to stop, and  the answer carries no body, so a following `GET api/2.0/files/folder/{folderId}/log/report` is what shows the  task ending as cancelled. Asking to terminate when nothing is running is accepted and changes nothing, which  makes the call safe to repeat. A report that has already finished is not undone by this call and its file  stays in My documents. The caller needs read access to the folder and may not be a guest, and the portal  plan has to include the audit feature; a caller who fails the access rule is answered with 403 and a folder  that does not exist with 404. Each caller can only terminate their own report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose running history report is to be given up. It is the folder that              was passed to the operation that started the report.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-report-folder-history/">REST API Reference for TerminateReportFolderHistory Operation</seealso>
        /// <returns>Task of void</returns>
        Task TerminateReportFolderHistoryAsync(int folderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Terminate the folder history report generation
        /// </summary>
        /// <remarks>
        /// Gives up the history report the caller has started for a folder with  `POST api/2.0/files/folder/{folderId}/log/report`. The request only asks the background worker to stop, and  the answer carries no body, so a following `GET api/2.0/files/folder/{folderId}/log/report` is what shows the  task ending as cancelled. Asking to terminate when nothing is running is accepted and changes nothing, which  makes the call safe to repeat. A report that has already finished is not undone by this call and its file  stays in My documents. The caller needs read access to the folder and may not be a guest, and the portal  plan has to include the audit feature; a caller who fails the access rule is answered with 403 and a folder  that does not exist with 404. Each caller can only terminate their own report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose running history report is to be given up. It is the folder that              was passed to the operation that started the report.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-report-folder-history/">REST API Reference for TerminateReportFolderHistory Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> TerminateReportFolderHistoryWithHttpInfoAsync(int folderId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file
        /// </summary>
        /// <remarks>
        /// Stores a file in the folder named by the path in a single multipart request, taking its name from the uploaded  part; use `POST api/2.0/files/{folderId}/insert` when the name has to be given separately or the content is  sent as a raw body. The answer is a list that always holds exactly one file. `createNewIfExist` settles the  clash: false adds a new version to the file that already carries the name, true keeps both by giving the new  one a numeric suffix. `storeOriginalFile` reaches further than this call, because it saves the setting on the  calling account, the same one `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later  uploads. The caller needs the right to add content to the folder, so a reader, an editor and a guest get 403,  a section root and an archived room are refused as well, and an unknown folder gives 404. A request without a  file is rejected as invalid, and a payload above the portal upload limit is refused.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="storeOriginalFile">Reaches further than this request: it writes a setting on the calling account, the same one  `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later uploads. True keeps both the  uploaded file and the copy the portal converts it into, false replaces the uploaded file with the converted  one, and leaving it out keeps whatever the account already has. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part; the name of that part becomes the title of the  stored file, with characters a title cannot hold replaced and the name cut to 170 characters. A request  without it is rejected as invalid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file/">REST API Reference for UploadFile Operation</seealso>
        /// <returns>Task of FileIntegerArrayWrapper</returns>
        Task<FileIntegerArrayWrapper> UploadFileAsync(int folderId, bool? createNewIfExist = default, bool? storeOriginalFile = default, bool? keepConvertStatus = default, FileParameter? file = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a file
        /// </summary>
        /// <remarks>
        /// Stores a file in the folder named by the path in a single multipart request, taking its name from the uploaded  part; use `POST api/2.0/files/{folderId}/insert` when the name has to be given separately or the content is  sent as a raw body. The answer is a list that always holds exactly one file. `createNewIfExist` settles the  clash: false adds a new version to the file that already carries the name, true keeps both by giving the new  one a numeric suffix. `storeOriginalFile` reaches further than this call, because it saves the setting on the  calling account, the same one `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later  uploads. The caller needs the right to add content to the folder, so a reader, an editor and a guest get 403,  a section root and an archived room are refused as well, and an unknown folder gives 404. A request without a  file is rejected as invalid, and a payload above the portal upload limit is refused.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="storeOriginalFile">Reaches further than this request: it writes a setting on the calling account, the same one  `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later uploads. True keeps both the  uploaded file and the copy the portal converts it into, false replaces the uploaded file with the converted  one, and leaving it out keeps whatever the account already has. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part; the name of that part becomes the title of the  stored file, with characters a title cannot hold replaced and the name cut to 170 characters. A request  without it is rejected as invalid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file/">REST API Reference for UploadFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerArrayWrapper)</returns>
        Task<ApiResponse<FileIntegerArrayWrapper>> UploadFileWithHttpInfoAsync(int folderId, bool? createNewIfExist = default, bool? storeOriginalFile = default, bool? keepConvertStatus = default, FileParameter? file = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file to My documents
        /// </summary>
        /// <remarks>
        /// Uploads one file into the caller's own My documents section and returns it inside a single-element array; one  request stores exactly one file. The destination takes no identifier: it is resolved from the calling account  and created on first use, while a guest account has none and is answered as missing (404). The body has to be  `multipart/form-data` carrying the file part; a request without it is rejected as invalid, and the stored name  comes from that part, since unlike `POST api/2.0/files/@my/insert` there is no separate title. The call is not  idempotent: by default a file of the same title is overwritten as a new version, while `createNewIfExist=true`  stores a separate copy under a title made unique with a numeric suffix. `storeOriginalFile` is not a  per-request switch: it writes the same account setting as `PUT api/2.0/files/storeoriginal`, which decides  what happens to the formats listed in `extsMustConvert` of `GET api/2.0/files/settings` when they are  converted after the response - false replaces the uploaded file with the converted one, true keeps both;  `keepConvertStatus=true` keeps that conversion result readable through  `GET api/2.0/files/file/{fileId}/checkconversion`. Files over the single-request size limit or the account's  storage quota are refused; send those through `POST api/2.0/files/{folderId}/upload/create_session`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="storeOriginalFile">Reaches further than this request: it writes a setting on the calling account, the same one  `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later uploads. True keeps both the  uploaded file and the copy the portal converts it into, false replaces the uploaded file with the converted  one, and leaving it out keeps whatever the account already has. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part; the name of that part becomes the title of the  stored file, with characters a title cannot hold replaced and the name cut to 170 characters. A request  without it is rejected as invalid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file-to-my/">REST API Reference for UploadFileToMy Operation</seealso>
        /// <returns>Task of FileIntegerArrayWrapper</returns>
        Task<FileIntegerArrayWrapper> UploadFileToMyAsync(bool? createNewIfExist = default, bool? storeOriginalFile = default, bool? keepConvertStatus = default, FileParameter? file = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a file to My documents
        /// </summary>
        /// <remarks>
        /// Uploads one file into the caller's own My documents section and returns it inside a single-element array; one  request stores exactly one file. The destination takes no identifier: it is resolved from the calling account  and created on first use, while a guest account has none and is answered as missing (404). The body has to be  `multipart/form-data` carrying the file part; a request without it is rejected as invalid, and the stored name  comes from that part, since unlike `POST api/2.0/files/@my/insert` there is no separate title. The call is not  idempotent: by default a file of the same title is overwritten as a new version, while `createNewIfExist=true`  stores a separate copy under a title made unique with a numeric suffix. `storeOriginalFile` is not a  per-request switch: it writes the same account setting as `PUT api/2.0/files/storeoriginal`, which decides  what happens to the formats listed in `extsMustConvert` of `GET api/2.0/files/settings` when they are  converted after the response - false replaces the uploaded file with the converted one, true keeps both;  `keepConvertStatus=true` keeps that conversion result readable through  `GET api/2.0/files/file/{fileId}/checkconversion`. Files over the single-request size limit or the account's  storage quota are refused; send those through `POST api/2.0/files/{folderId}/upload/create_session`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="storeOriginalFile">Reaches further than this request: it writes a setting on the calling account, the same one  `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later uploads. True keeps both the  uploaded file and the copy the portal converts it into, false replaces the uploaded file with the converted  one, and leaving it out keeps whatever the account already has. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part; the name of that part becomes the title of the  stored file, with characters a title cannot hold replaced and the name cut to 170 characters. A request  without it is rejected as invalid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file-to-my/">REST API Reference for UploadFileToMy Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerArrayWrapper)</returns>
        Task<ApiResponse<FileIntegerArrayWrapper>> UploadFileToMyWithHttpInfoAsync(bool? createNewIfExist = default, bool? storeOriginalFile = default, bool? keepConvertStatus = default, FileParameter? file = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFoldersApi : IFoldersApiSync, IFoldersApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FoldersApi : IDisposable, IFoldersApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FoldersApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public FoldersApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FoldersApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public FoldersApi(string basePath)
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
        /// Initializes a new instance of the <see cref="FoldersApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public FoldersApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="FoldersApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public FoldersApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FoldersApi"/> class.
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
        public FoldersApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="FoldersApi"/> class using a Configuration object.
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
        public FoldersApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="FoldersApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public FoldersApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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

        private string? _fields;

        /// <summary>
        /// Specifies which fields should be included in the API response.
        /// </summary>
        /// <param name="fields">A comma-separated list of field paths to include in the response</param>
        /// <returns></returns>

        public FoldersApi WithFields(string fields)
        {
            _fields = fields;
            return this;
        }

        private bool _useAtRecent ;

        /// <summary>
        /// Enables the "@" address prefix so the request targets the current user's recent items.
        /// </summary>
        /// <returns></returns>
        public FoldersApi WithFields()
        {
            _useAtRecent = true;
            return this;
        }

        /// <summary>
        /// Check for upload conflicts
        /// </summary>
        /// <remarks>
        /// Reports which of the submitted titles already belong to a file in the folder, so an upload can decide in  advance whether to overwrite or to ask for another name. Only the clashing titles come back, unordered and  without repetitions, and an empty array means every name is free. Matching is by title and ignores case, so a  name that differs only in capitalisation is still reported; an existing file that is encrypted is left out,  because an upload cannot take it over. The call changes nothing. It needs the same right as the upload itself,  the right to add content to the folder, which room managers and content creators have and readers, editors and  guests do not; an archived room, a section root and a folder the caller cannot write to are all refused, while  an unknown folder is answered as missing. A request without `filesTitle` is rejected as an invalid request, an  empty list is accepted and answers with an empty array.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose contents the names are tested against; take the id from a listing such as  `GET api/2.0/files/@root`.</param>
        /// <param name="checkUploadRequest">The names to test against the files the folder already holds.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-upload/">REST API Reference for CheckUpload Operation</seealso>
        /// <returns>STRINGArrayWrapper</returns>
        public STRINGArrayWrapper CheckUpload(int folderId, CheckUploadRequest checkUploadRequest)
        {
            var localVarResponse = CheckUploadWithHttpInfo(folderId, checkUploadRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check for upload conflicts
        /// </summary>
        /// <remarks>
        /// Reports which of the submitted titles already belong to a file in the folder, so an upload can decide in  advance whether to overwrite or to ask for another name. Only the clashing titles come back, unordered and  without repetitions, and an empty array means every name is free. Matching is by title and ignores case, so a  name that differs only in capitalisation is still reported; an existing file that is encrypted is left out,  because an upload cannot take it over. The call changes nothing. It needs the same right as the upload itself,  the right to add content to the folder, which room managers and content creators have and readers, editors and  guests do not; an archived room, a section root and a folder the caller cannot write to are all refused, while  an unknown folder is answered as missing. A request without `filesTitle` is rejected as an invalid request, an  empty list is accepted and answers with an empty array.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose contents the names are tested against; take the id from a listing such as  `GET api/2.0/files/@root`.</param>
        /// <param name="checkUploadRequest">The names to test against the files the folder already holds.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-upload/">REST API Reference for CheckUpload Operation</seealso>
        /// <returns>ApiResponse of STRINGArrayWrapper</returns>
        public ApiResponse<STRINGArrayWrapper> CheckUploadWithHttpInfo(int folderId, CheckUploadRequest checkUploadRequest)
        {
            // verify the required parameter 'checkUploadRequest' is set
            if (checkUploadRequest == null)
                throw new ApiException(400, "Missing required parameter 'checkUploadRequest' when calling FoldersApi->CheckUpload");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (checkUploadRequest != null) localVarRequestOptions.Data = checkUploadRequest;

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
            var localVarResponse = Client.Post<STRINGArrayWrapper>("/api/2.0/files/{folderId}/upload/check", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CheckUpload", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check for upload conflicts
        /// </summary>
        /// <remarks>
        /// Reports which of the submitted titles already belong to a file in the folder, so an upload can decide in  advance whether to overwrite or to ask for another name. Only the clashing titles come back, unordered and  without repetitions, and an empty array means every name is free. Matching is by title and ignores case, so a  name that differs only in capitalisation is still reported; an existing file that is encrypted is left out,  because an upload cannot take it over. The call changes nothing. It needs the same right as the upload itself,  the right to add content to the folder, which room managers and content creators have and readers, editors and  guests do not; an archived room, a section root and a folder the caller cannot write to are all refused, while  an unknown folder is answered as missing. A request without `filesTitle` is rejected as an invalid request, an  empty list is accepted and answers with an empty array.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose contents the names are tested against; take the id from a listing such as  `GET api/2.0/files/@root`.</param>
        /// <param name="checkUploadRequest">The names to test against the files the folder already holds.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-upload/">REST API Reference for CheckUpload Operation</seealso>
        /// <returns>Task of STRINGArrayWrapper</returns>
        public async Task<STRINGArrayWrapper> CheckUploadAsync(int folderId, CheckUploadRequest checkUploadRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CheckUploadWithHttpInfoAsync(folderId, checkUploadRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check for upload conflicts
        /// </summary>
        /// <remarks>
        /// Reports which of the submitted titles already belong to a file in the folder, so an upload can decide in  advance whether to overwrite or to ask for another name. Only the clashing titles come back, unordered and  without repetitions, and an empty array means every name is free. Matching is by title and ignores case, so a  name that differs only in capitalisation is still reported; an existing file that is encrypted is left out,  because an upload cannot take it over. The call changes nothing. It needs the same right as the upload itself,  the right to add content to the folder, which room managers and content creators have and readers, editors and  guests do not; an archived room, a section root and a folder the caller cannot write to are all refused, while  an unknown folder is answered as missing. A request without `filesTitle` is rejected as an invalid request, an  empty list is accepted and answers with an empty array.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose contents the names are tested against; take the id from a listing such as  `GET api/2.0/files/@root`.</param>
        /// <param name="checkUploadRequest">The names to test against the files the folder already holds.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-upload/">REST API Reference for CheckUpload Operation</seealso>
        /// <returns>Task of ApiResponse (STRINGArrayWrapper)</returns>
        public async Task<ApiResponse<STRINGArrayWrapper>> CheckUploadWithHttpInfoAsync(int folderId, CheckUploadRequest checkUploadRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'checkUploadRequest' is set
            if (checkUploadRequest == null)
                throw new ApiException(400, "Missing required parameter 'checkUploadRequest' when calling FoldersApi->CheckUpload");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (checkUploadRequest != null) localVarRequestOptions.Data = checkUploadRequest;

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

            var localVarResponse = await AsynchronousClient.PostAsync<STRINGArrayWrapper>("/api/2.0/files/{folderId}/upload/check", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CheckUpload", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a folder
        /// </summary>
        /// <remarks>
        /// Creates a folder inside the folder named in the path and answers with the folder as it was stored. The title  is trimmed, may not be blank and is refused when it is longer than the limit the schema prints; titles are not  required to be unique, so creating the same title twice leaves two folders side by side, which makes the call  mutating and not idempotent. The caller needs the right to create content in the parent, which the room  manager, a content creator and the owner of a personal section have; a member without that right, an archived  parent, and a section root that only holds rooms - Rooms, Forms and AI agents - are all refused, as is a  parent that does not exist. Rooms are not created here: use `POST api/2.0/files/rooms` for those, and this  operation for ordinary folders within them. Members of the room are notified of the new folder. Read the  identifier of the new folder from `id` and fill it with `POST api/2.0/files/{folderId}/upload`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the request is addressed to: when a folder is created it is the parent that receives the new  folder, and when a folder is renamed it is the folder that gets the new title.</param>
        /// <param name="createFolder">The title carried by the request body.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder/">REST API Reference for CreateFolder Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper CreateFolder(int folderId, CreateFolder createFolder)
        {
            var localVarResponse = CreateFolderWithHttpInfo(folderId, createFolder);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a folder
        /// </summary>
        /// <remarks>
        /// Creates a folder inside the folder named in the path and answers with the folder as it was stored. The title  is trimmed, may not be blank and is refused when it is longer than the limit the schema prints; titles are not  required to be unique, so creating the same title twice leaves two folders side by side, which makes the call  mutating and not idempotent. The caller needs the right to create content in the parent, which the room  manager, a content creator and the owner of a personal section have; a member without that right, an archived  parent, and a section root that only holds rooms - Rooms, Forms and AI agents - are all refused, as is a  parent that does not exist. Rooms are not created here: use `POST api/2.0/files/rooms` for those, and this  operation for ordinary folders within them. Members of the room are notified of the new folder. Read the  identifier of the new folder from `id` and fill it with `POST api/2.0/files/{folderId}/upload`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the request is addressed to: when a folder is created it is the parent that receives the new  folder, and when a folder is renamed it is the folder that gets the new title.</param>
        /// <param name="createFolder">The title carried by the request body.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder/">REST API Reference for CreateFolder Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public ApiResponse<FolderIntegerWrapper> CreateFolderWithHttpInfo(int folderId, CreateFolder createFolder)
        {
            // verify the required parameter 'createFolder' is set
            if (createFolder == null)
                throw new ApiException(400, "Missing required parameter 'createFolder' when calling FoldersApi->CreateFolder");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (createFolder != null) localVarRequestOptions.Data = createFolder;

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
            var localVarResponse = Client.Post<FolderIntegerWrapper>("/api/2.0/files/folder/{folderId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateFolder", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a folder
        /// </summary>
        /// <remarks>
        /// Creates a folder inside the folder named in the path and answers with the folder as it was stored. The title  is trimmed, may not be blank and is refused when it is longer than the limit the schema prints; titles are not  required to be unique, so creating the same title twice leaves two folders side by side, which makes the call  mutating and not idempotent. The caller needs the right to create content in the parent, which the room  manager, a content creator and the owner of a personal section have; a member without that right, an archived  parent, and a section root that only holds rooms - Rooms, Forms and AI agents - are all refused, as is a  parent that does not exist. Rooms are not created here: use `POST api/2.0/files/rooms` for those, and this  operation for ordinary folders within them. Members of the room are notified of the new folder. Read the  identifier of the new folder from `id` and fill it with `POST api/2.0/files/{folderId}/upload`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the request is addressed to: when a folder is created it is the parent that receives the new  folder, and when a folder is renamed it is the folder that gets the new title.</param>
        /// <param name="createFolder">The title carried by the request body.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder/">REST API Reference for CreateFolder Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async Task<FolderIntegerWrapper> CreateFolderAsync(int folderId, CreateFolder createFolder, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateFolderWithHttpInfoAsync(folderId, createFolder, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a folder
        /// </summary>
        /// <remarks>
        /// Creates a folder inside the folder named in the path and answers with the folder as it was stored. The title  is trimmed, may not be blank and is refused when it is longer than the limit the schema prints; titles are not  required to be unique, so creating the same title twice leaves two folders side by side, which makes the call  mutating and not idempotent. The caller needs the right to create content in the parent, which the room  manager, a content creator and the owner of a personal section have; a member without that right, an archived  parent, and a section root that only holds rooms - Rooms, Forms and AI agents - are all refused, as is a  parent that does not exist. Rooms are not created here: use `POST api/2.0/files/rooms` for those, and this  operation for ordinary folders within them. Members of the room are notified of the new folder. Read the  identifier of the new folder from `id` and fill it with `POST api/2.0/files/{folderId}/upload`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the request is addressed to: when a folder is created it is the parent that receives the new  folder, and when a folder is renamed it is the folder that gets the new title.</param>
        /// <param name="createFolder">The title carried by the request body.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder/">REST API Reference for CreateFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderIntegerWrapper>> CreateFolderWithHttpInfoAsync(int folderId, CreateFolder createFolder, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'createFolder' is set
            if (createFolder == null)
                throw new ApiException(400, "Missing required parameter 'createFolder' when calling FoldersApi->CreateFolder");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (createFolder != null) localVarRequestOptions.Data = createFolder;

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

            var localVarResponse = await AsynchronousClient.PostAsync<FolderIntegerWrapper>("/api/2.0/files/folder/{folderId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateFolder", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create the folder primary external link
        /// </summary>
        /// <remarks>
        /// Answers with the primary external link of a folder or a room, creating it on the first call and returning the  one that already exists afterwards, so the operation is idempotent in effect: a second call with other  parameters does not reconfigure the existing link, and changing one is the business of  `PUT api/2.0/files/folder/{id}/links`. The parameters therefore only shape the link at the moment it is born -  `access` its rights, `title` its name, `expirationDate` its lifetime, which is unlimited here unless one is  given, `internal` whether only signed-in members may follow it, `denyDownload` whether the contents may only  be viewed, and `password` a secret to be asked for. Sending `access` with the value that grants nothing  creates no link and answers with nothing. The caller needs the right to manage the links of the room the  folder belongs to, which its manager and a portal administrator acting as room manager have, and a member with  content-creator or read access is refused with 403; an unknown folder is answered with 404. Read the address  from `sharedTo.shareLink`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the link belongs to.</param>
        /// <param name="folderLinkRequest">The link and the way it is to be shaped.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder-primary-external-link/">REST API Reference for CreateFolderPrimaryExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        public FileShareWrapper CreateFolderPrimaryExternalLink(int id, FolderLinkRequest folderLinkRequest)
        {
            var localVarResponse = CreateFolderPrimaryExternalLinkWithHttpInfo(id, folderLinkRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create the folder primary external link
        /// </summary>
        /// <remarks>
        /// Answers with the primary external link of a folder or a room, creating it on the first call and returning the  one that already exists afterwards, so the operation is idempotent in effect: a second call with other  parameters does not reconfigure the existing link, and changing one is the business of  `PUT api/2.0/files/folder/{id}/links`. The parameters therefore only shape the link at the moment it is born -  `access` its rights, `title` its name, `expirationDate` its lifetime, which is unlimited here unless one is  given, `internal` whether only signed-in members may follow it, `denyDownload` whether the contents may only  be viewed, and `password` a secret to be asked for. Sending `access` with the value that grants nothing  creates no link and answers with nothing. The caller needs the right to manage the links of the room the  folder belongs to, which its manager and a portal administrator acting as room manager have, and a member with  content-creator or read access is refused with 403; an unknown folder is answered with 404. Read the address  from `sharedTo.shareLink`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the link belongs to.</param>
        /// <param name="folderLinkRequest">The link and the way it is to be shaped.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder-primary-external-link/">REST API Reference for CreateFolderPrimaryExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        public ApiResponse<FileShareWrapper> CreateFolderPrimaryExternalLinkWithHttpInfo(int id, FolderLinkRequest folderLinkRequest)
        {
            // verify the required parameter 'folderLinkRequest' is set
            if (folderLinkRequest == null)
                throw new ApiException(400, "Missing required parameter 'folderLinkRequest' when calling FoldersApi->CreateFolderPrimaryExternalLink");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (folderLinkRequest != null) localVarRequestOptions.Data = folderLinkRequest;

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
            var localVarResponse = Client.Post<FileShareWrapper>("/api/2.0/files/folder/{id}/link", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateFolderPrimaryExternalLink", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create the folder primary external link
        /// </summary>
        /// <remarks>
        /// Answers with the primary external link of a folder or a room, creating it on the first call and returning the  one that already exists afterwards, so the operation is idempotent in effect: a second call with other  parameters does not reconfigure the existing link, and changing one is the business of  `PUT api/2.0/files/folder/{id}/links`. The parameters therefore only shape the link at the moment it is born -  `access` its rights, `title` its name, `expirationDate` its lifetime, which is unlimited here unless one is  given, `internal` whether only signed-in members may follow it, `denyDownload` whether the contents may only  be viewed, and `password` a secret to be asked for. Sending `access` with the value that grants nothing  creates no link and answers with nothing. The caller needs the right to manage the links of the room the  folder belongs to, which its manager and a portal administrator acting as room manager have, and a member with  content-creator or read access is refused with 403; an unknown folder is answered with 404. Read the address  from `sharedTo.shareLink`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the link belongs to.</param>
        /// <param name="folderLinkRequest">The link and the way it is to be shaped.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder-primary-external-link/">REST API Reference for CreateFolderPrimaryExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        public async Task<FileShareWrapper> CreateFolderPrimaryExternalLinkAsync(int id, FolderLinkRequest folderLinkRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateFolderPrimaryExternalLinkWithHttpInfoAsync(id, folderLinkRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create the folder primary external link
        /// </summary>
        /// <remarks>
        /// Answers with the primary external link of a folder or a room, creating it on the first call and returning the  one that already exists afterwards, so the operation is idempotent in effect: a second call with other  parameters does not reconfigure the existing link, and changing one is the business of  `PUT api/2.0/files/folder/{id}/links`. The parameters therefore only shape the link at the moment it is born -  `access` its rights, `title` its name, `expirationDate` its lifetime, which is unlimited here unless one is  given, `internal` whether only signed-in members may follow it, `denyDownload` whether the contents may only  be viewed, and `password` a secret to be asked for. Sending `access` with the value that grants nothing  creates no link and answers with nothing. The caller needs the right to manage the links of the room the  folder belongs to, which its manager and a portal administrator acting as room manager have, and a member with  content-creator or read access is refused with 403; an unknown folder is answered with 404. Read the address  from `sharedTo.shareLink`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the link belongs to.</param>
        /// <param name="folderLinkRequest">The link and the way it is to be shaped.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder-primary-external-link/">REST API Reference for CreateFolderPrimaryExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        public async Task<ApiResponse<FileShareWrapper>> CreateFolderPrimaryExternalLinkWithHttpInfoAsync(int id, FolderLinkRequest folderLinkRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'folderLinkRequest' is set
            if (folderLinkRequest == null)
                throw new ApiException(400, "Missing required parameter 'folderLinkRequest' when calling FoldersApi->CreateFolderPrimaryExternalLink");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (folderLinkRequest != null) localVarRequestOptions.Data = folderLinkRequest;

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

            var localVarResponse = await AsynchronousClient.PostAsync<FileShareWrapper>("/api/2.0/files/folder/{id}/link", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateFolderPrimaryExternalLink", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start the folder history report generation
        /// </summary>
        /// <remarks>
        /// Queues a background job that renders the history of a folder into a spreadsheet, or into a CSV file when  `format` asks for one, and saves the result in the caller's My documents. The answer is the queued task, not  the report: poll `GET api/2.0/files/folder/{folderId}/log/report` until `isCompleted` is true, then take the  file from `resultFileId`, `resultFileName` and `resultFileUrl`, of which a CSV report fills only the last two.  `from` and `to` limit the exported period; leaving both out exports the whole history. While a report for the  same folder and caller is still running, this call joins it and answers with the running task instead of  starting a second one, so retrying is safe. The caller needs read access to the folder and may not be a guest,  and the portal plan has to include the audit feature - otherwise the call is refused, with 403 for the access  rule and 404 for a folder that does not exist. Only a portal administrator gets the address, browser and  platform columns. Give up a running report with `DELETE api/2.0/files/folder/{folderId}/log/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose history is exported; the report covers the folder itself and the entries inside it.</param>
        /// <param name="format">The shape the report is written in: `Xlsx` produces a spreadsheet that is saved as a file of the portal, while  `Csv` produces a comma-separated text file that is uploaded to My documents without being reported back with  a file identifier. (optional)</param>
        /// <param name="from">The earliest moment an exported entry may have, read in the time zone of the portal; left out, the report  starts at the oldest entry the portal still keeps. (optional)</param>
        /// <param name="to">The latest moment an exported entry may have, read in the time zone of the portal; left out, the report ends  at the newest entry. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-report-folder-history/">REST API Reference for CreateReportFolderHistory Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        public DocumentBuilderTaskWrapper CreateReportFolderHistory(int folderId, AuditReportFormat? format = default, DateTime? from = default, DateTime? to = default)
        {
            var localVarResponse = CreateReportFolderHistoryWithHttpInfo(folderId, format, from, to);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start the folder history report generation
        /// </summary>
        /// <remarks>
        /// Queues a background job that renders the history of a folder into a spreadsheet, or into a CSV file when  `format` asks for one, and saves the result in the caller's My documents. The answer is the queued task, not  the report: poll `GET api/2.0/files/folder/{folderId}/log/report` until `isCompleted` is true, then take the  file from `resultFileId`, `resultFileName` and `resultFileUrl`, of which a CSV report fills only the last two.  `from` and `to` limit the exported period; leaving both out exports the whole history. While a report for the  same folder and caller is still running, this call joins it and answers with the running task instead of  starting a second one, so retrying is safe. The caller needs read access to the folder and may not be a guest,  and the portal plan has to include the audit feature - otherwise the call is refused, with 403 for the access  rule and 404 for a folder that does not exist. Only a portal administrator gets the address, browser and  platform columns. Give up a running report with `DELETE api/2.0/files/folder/{folderId}/log/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose history is exported; the report covers the folder itself and the entries inside it.</param>
        /// <param name="format">The shape the report is written in: `Xlsx` produces a spreadsheet that is saved as a file of the portal, while  `Csv` produces a comma-separated text file that is uploaded to My documents without being reported back with  a file identifier. (optional)</param>
        /// <param name="from">The earliest moment an exported entry may have, read in the time zone of the portal; left out, the report  starts at the oldest entry the portal still keeps. (optional)</param>
        /// <param name="to">The latest moment an exported entry may have, read in the time zone of the portal; left out, the report ends  at the newest entry. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-report-folder-history/">REST API Reference for CreateReportFolderHistory Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        public ApiResponse<DocumentBuilderTaskWrapper> CreateReportFolderHistoryWithHttpInfo(int folderId, AuditReportFormat? format = default, DateTime? from = default, DateTime? to = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (format != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "format", format));
            }
            if (from != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "from", from));
            }
            if (to != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "to", to));
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
            var localVarResponse = Client.Post<DocumentBuilderTaskWrapper>("/api/2.0/files/folder/{folderId}/log/report", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateReportFolderHistory", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start the folder history report generation
        /// </summary>
        /// <remarks>
        /// Queues a background job that renders the history of a folder into a spreadsheet, or into a CSV file when  `format` asks for one, and saves the result in the caller's My documents. The answer is the queued task, not  the report: poll `GET api/2.0/files/folder/{folderId}/log/report` until `isCompleted` is true, then take the  file from `resultFileId`, `resultFileName` and `resultFileUrl`, of which a CSV report fills only the last two.  `from` and `to` limit the exported period; leaving both out exports the whole history. While a report for the  same folder and caller is still running, this call joins it and answers with the running task instead of  starting a second one, so retrying is safe. The caller needs read access to the folder and may not be a guest,  and the portal plan has to include the audit feature - otherwise the call is refused, with 403 for the access  rule and 404 for a folder that does not exist. Only a portal administrator gets the address, browser and  platform columns. Give up a running report with `DELETE api/2.0/files/folder/{folderId}/log/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose history is exported; the report covers the folder itself and the entries inside it.</param>
        /// <param name="format">The shape the report is written in: `Xlsx` produces a spreadsheet that is saved as a file of the portal, while  `Csv` produces a comma-separated text file that is uploaded to My documents without being reported back with  a file identifier. (optional)</param>
        /// <param name="from">The earliest moment an exported entry may have, read in the time zone of the portal; left out, the report  starts at the oldest entry the portal still keeps. (optional)</param>
        /// <param name="to">The latest moment an exported entry may have, read in the time zone of the portal; left out, the report ends  at the newest entry. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-report-folder-history/">REST API Reference for CreateReportFolderHistory Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        public async Task<DocumentBuilderTaskWrapper> CreateReportFolderHistoryAsync(int folderId, AuditReportFormat? format = default, DateTime? from = default, DateTime? to = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateReportFolderHistoryWithHttpInfoAsync(folderId, format, from, to, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start the folder history report generation
        /// </summary>
        /// <remarks>
        /// Queues a background job that renders the history of a folder into a spreadsheet, or into a CSV file when  `format` asks for one, and saves the result in the caller's My documents. The answer is the queued task, not  the report: poll `GET api/2.0/files/folder/{folderId}/log/report` until `isCompleted` is true, then take the  file from `resultFileId`, `resultFileName` and `resultFileUrl`, of which a CSV report fills only the last two.  `from` and `to` limit the exported period; leaving both out exports the whole history. While a report for the  same folder and caller is still running, this call joins it and answers with the running task instead of  starting a second one, so retrying is safe. The caller needs read access to the folder and may not be a guest,  and the portal plan has to include the audit feature - otherwise the call is refused, with 403 for the access  rule and 404 for a folder that does not exist. Only a portal administrator gets the address, browser and  platform columns. Give up a running report with `DELETE api/2.0/files/folder/{folderId}/log/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose history is exported; the report covers the folder itself and the entries inside it.</param>
        /// <param name="format">The shape the report is written in: `Xlsx` produces a spreadsheet that is saved as a file of the portal, while  `Csv` produces a comma-separated text file that is uploaded to My documents without being reported back with  a file identifier. (optional)</param>
        /// <param name="from">The earliest moment an exported entry may have, read in the time zone of the portal; left out, the report  starts at the oldest entry the portal still keeps. (optional)</param>
        /// <param name="to">The latest moment an exported entry may have, read in the time zone of the portal; left out, the report ends  at the newest entry. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-report-folder-history/">REST API Reference for CreateReportFolderHistory Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        public async Task<ApiResponse<DocumentBuilderTaskWrapper>> CreateReportFolderHistoryWithHttpInfoAsync(int folderId, AuditReportFormat? format = default, DateTime? from = default, DateTime? to = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (format != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "format", format));
            }
            if (from != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "from", from));
            }
            if (to != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "to", to));
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

            var localVarResponse = await AsynchronousClient.PostAsync<DocumentBuilderTaskWrapper>("/api/2.0/files/folder/{folderId}/log/report", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateReportFolderHistory", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a folder
        /// </summary>
        /// <remarks>
        /// Queues the deletion of one folder together with everything inside it, and answers with the file operations of  the caller, the one just created among them. The folder is not gone when the response arrives: poll  `GET api/2.0/files/fileops` until the operation reports `finished`, and read its `error` to learn whether the  deletion succeeded. By default the folder is moved to the Trash section, from where it can be restored;  `immediately=true` discards it for good instead, and inside a room, where there is no Trash, deletion is  always final. `deleteAfter=true` postpones the deletion until the editing sessions on the contents have ended,  so files somebody is working on are not pulled away. The caller needs the right to delete the folder, which  the room manager, a portal administrator acting as room manager and a content creator acting on a folder of  their own have; editing access alone, read access and a guest are refused. The call is destructive. To delete  several items at once use `PUT api/2.0/files/fileops/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder to delete, together with everything it holds.</param>
        /// <param name="deleteFolder">How the deletion is to be carried out.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-folder/">REST API Reference for DeleteFolder Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper DeleteFolder(int folderId, DeleteFolder deleteFolder)
        {
            var localVarResponse = DeleteFolderWithHttpInfo(folderId, deleteFolder);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a folder
        /// </summary>
        /// <remarks>
        /// Queues the deletion of one folder together with everything inside it, and answers with the file operations of  the caller, the one just created among them. The folder is not gone when the response arrives: poll  `GET api/2.0/files/fileops` until the operation reports `finished`, and read its `error` to learn whether the  deletion succeeded. By default the folder is moved to the Trash section, from where it can be restored;  `immediately=true` discards it for good instead, and inside a room, where there is no Trash, deletion is  always final. `deleteAfter=true` postpones the deletion until the editing sessions on the contents have ended,  so files somebody is working on are not pulled away. The caller needs the right to delete the folder, which  the room manager, a portal administrator acting as room manager and a content creator acting on a folder of  their own have; editing access alone, read access and a guest are refused. The call is destructive. To delete  several items at once use `PUT api/2.0/files/fileops/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder to delete, together with everything it holds.</param>
        /// <param name="deleteFolder">How the deletion is to be carried out.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-folder/">REST API Reference for DeleteFolder Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> DeleteFolderWithHttpInfo(int folderId, DeleteFolder deleteFolder)
        {
            // verify the required parameter 'deleteFolder' is set
            if (deleteFolder == null)
                throw new ApiException(400, "Missing required parameter 'deleteFolder' when calling FoldersApi->DeleteFolder");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (deleteFolder != null) localVarRequestOptions.Data = deleteFolder;

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
            var localVarResponse = Client.Delete<FileOperationArrayWrapper>("/api/2.0/files/folder/{folderId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteFolder", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a folder
        /// </summary>
        /// <remarks>
        /// Queues the deletion of one folder together with everything inside it, and answers with the file operations of  the caller, the one just created among them. The folder is not gone when the response arrives: poll  `GET api/2.0/files/fileops` until the operation reports `finished`, and read its `error` to learn whether the  deletion succeeded. By default the folder is moved to the Trash section, from where it can be restored;  `immediately=true` discards it for good instead, and inside a room, where there is no Trash, deletion is  always final. `deleteAfter=true` postpones the deletion until the editing sessions on the contents have ended,  so files somebody is working on are not pulled away. The caller needs the right to delete the folder, which  the room manager, a portal administrator acting as room manager and a content creator acting on a folder of  their own have; editing access alone, read access and a guest are refused. The call is destructive. To delete  several items at once use `PUT api/2.0/files/fileops/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder to delete, together with everything it holds.</param>
        /// <param name="deleteFolder">How the deletion is to be carried out.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-folder/">REST API Reference for DeleteFolder Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async Task<FileOperationArrayWrapper> DeleteFolderAsync(int folderId, DeleteFolder deleteFolder, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeleteFolderWithHttpInfoAsync(folderId, deleteFolder, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a folder
        /// </summary>
        /// <remarks>
        /// Queues the deletion of one folder together with everything inside it, and answers with the file operations of  the caller, the one just created among them. The folder is not gone when the response arrives: poll  `GET api/2.0/files/fileops` until the operation reports `finished`, and read its `error` to learn whether the  deletion succeeded. By default the folder is moved to the Trash section, from where it can be restored;  `immediately=true` discards it for good instead, and inside a room, where there is no Trash, deletion is  always final. `deleteAfter=true` postpones the deletion until the editing sessions on the contents have ended,  so files somebody is working on are not pulled away. The caller needs the right to delete the folder, which  the room manager, a portal administrator acting as room manager and a content creator acting on a folder of  their own have; editing access alone, read access and a guest are refused. The call is destructive. To delete  several items at once use `PUT api/2.0/files/fileops/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder to delete, together with everything it holds.</param>
        /// <param name="deleteFolder">How the deletion is to be carried out.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-folder/">REST API Reference for DeleteFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async Task<ApiResponse<FileOperationArrayWrapper>> DeleteFolderWithHttpInfoAsync(int folderId, DeleteFolder deleteFolder, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'deleteFolder' is set
            if (deleteFolder == null)
                throw new ApiException(400, "Missing required parameter 'deleteFolder' when calling FoldersApi->DeleteFolder");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (deleteFolder != null) localVarRequestOptions.Data = deleteFolder;

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<FileOperationArrayWrapper>("/api/2.0/files/folder/{folderId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteFolder", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Generate XLSX report by folder
        /// </summary>
        /// <remarks>
        /// Rebuilds the spreadsheet that gathers the answers submitted to a form, starting from the Complete folder  that holds the filled copies. The answer names the original form the results belong to, says in `isNewFile`  whether the spreadsheet is being created or an existing one rewritten in place, and carries the queued job in  `task`; the file itself is not ready yet, so poll `GET api/2.0/files/file/{fileId}/xlsx` with the identifier  of the form until the task reports completion. The folder has to be the Complete folder of a form-filling  room and has to hold at least one submitted copy whose original form still exists, and the caller needs the  right to maintain that form, which the room manager has. A folder that does not exist, or one that holds  nothing to report on, is answered with 404, and a folder of the wrong kind or a caller without those rights  with 403. The call is mutating: it writes the results file of the form.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/generate-xlsx-by-folder/">REST API Reference for GenerateXlsxByFolder Operation</seealso>
        /// <returns>XlsxReportResponseWrapper</returns>
        public XlsxReportResponseWrapper GenerateXlsxByFolder(int folderId)
        {
            var localVarResponse = GenerateXlsxByFolderWithHttpInfo(folderId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Generate XLSX report by folder
        /// </summary>
        /// <remarks>
        /// Rebuilds the spreadsheet that gathers the answers submitted to a form, starting from the Complete folder  that holds the filled copies. The answer names the original form the results belong to, says in `isNewFile`  whether the spreadsheet is being created or an existing one rewritten in place, and carries the queued job in  `task`; the file itself is not ready yet, so poll `GET api/2.0/files/file/{fileId}/xlsx` with the identifier  of the form until the task reports completion. The folder has to be the Complete folder of a form-filling  room and has to hold at least one submitted copy whose original form still exists, and the caller needs the  right to maintain that form, which the room manager has. A folder that does not exist, or one that holds  nothing to report on, is answered with 404, and a folder of the wrong kind or a caller without those rights  with 403. The call is mutating: it writes the results file of the form.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/generate-xlsx-by-folder/">REST API Reference for GenerateXlsxByFolder Operation</seealso>
        /// <returns>ApiResponse of XlsxReportResponseWrapper</returns>
        public ApiResponse<XlsxReportResponseWrapper> GenerateXlsxByFolderWithHttpInfo(int folderId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter

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
            var localVarResponse = Client.Post<XlsxReportResponseWrapper>("/api/2.0/files/folder/{folderId}/xlsx", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GenerateXlsxByFolder", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Generate XLSX report by folder
        /// </summary>
        /// <remarks>
        /// Rebuilds the spreadsheet that gathers the answers submitted to a form, starting from the Complete folder  that holds the filled copies. The answer names the original form the results belong to, says in `isNewFile`  whether the spreadsheet is being created or an existing one rewritten in place, and carries the queued job in  `task`; the file itself is not ready yet, so poll `GET api/2.0/files/file/{fileId}/xlsx` with the identifier  of the form until the task reports completion. The folder has to be the Complete folder of a form-filling  room and has to hold at least one submitted copy whose original form still exists, and the caller needs the  right to maintain that form, which the room manager has. A folder that does not exist, or one that holds  nothing to report on, is answered with 404, and a folder of the wrong kind or a caller without those rights  with 403. The call is mutating: it writes the results file of the form.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/generate-xlsx-by-folder/">REST API Reference for GenerateXlsxByFolder Operation</seealso>
        /// <returns>Task of XlsxReportResponseWrapper</returns>
        public async Task<XlsxReportResponseWrapper> GenerateXlsxByFolderAsync(int folderId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GenerateXlsxByFolderWithHttpInfoAsync(folderId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Generate XLSX report by folder
        /// </summary>
        /// <remarks>
        /// Rebuilds the spreadsheet that gathers the answers submitted to a form, starting from the Complete folder  that holds the filled copies. The answer names the original form the results belong to, says in `isNewFile`  whether the spreadsheet is being created or an existing one rewritten in place, and carries the queued job in  `task`; the file itself is not ready yet, so poll `GET api/2.0/files/file/{fileId}/xlsx` with the identifier  of the form until the task reports completion. The folder has to be the Complete folder of a form-filling  room and has to hold at least one submitted copy whose original form still exists, and the caller needs the  right to maintain that form, which the room manager has. A folder that does not exist, or one that holds  nothing to report on, is answered with 404, and a folder of the wrong kind or a caller without those rights  with 403. The call is mutating: it writes the results file of the form.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/generate-xlsx-by-folder/">REST API Reference for GenerateXlsxByFolder Operation</seealso>
        /// <returns>Task of ApiResponse (XlsxReportResponseWrapper)</returns>
        public async Task<ApiResponse<XlsxReportResponseWrapper>> GenerateXlsxByFolderWithHttpInfoAsync(int folderId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter

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

            var localVarResponse = await AsynchronousClient.PostAsync<XlsxReportResponseWrapper>("/api/2.0/files/folder/{folderId}/xlsx", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GenerateXlsxByFolder", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the Favorites section
        /// </summary>
        /// <remarks>
        /// Returns the caller's own Favorites section: the files and folders this account has marked as favorite,  together with the section folder itself. Favorites are per-account, so the entries another member marked are  not listed here, and a guest sees only their own, usually empty, list. Mark a single file with  `GET api/2.0/files/favorites/{fileId}`, or add and remove batches of files and folders with  `POST api/2.0/files/favorites` and `DELETE api/2.0/files/favorites`. Nothing in the section is modified,  though passing `sortBy` saves the requested order as the default order for this account. Entries the caller  can no longer read, and entries that have been moved to the Trash section, drop out of the listing even  though their favorite mark stays, so the section can shrink without an explicit unmark. `folders` and `files`  hold one page of the section, `total` counts the entries matching the request before `count` and `startIndex`  are applied, and `current` describes the section folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the section unfiltered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-favorites-folder/">REST API Reference for GetFavoritesFolder Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        public FolderContentIntegerWrapper GetFavoritesFolder(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarResponse = GetFavoritesFolderWithHttpInfo(userIdOrGroupId, filterType, count, startIndex, sortBy, sortOrder, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Favorites section
        /// </summary>
        /// <remarks>
        /// Returns the caller's own Favorites section: the files and folders this account has marked as favorite,  together with the section folder itself. Favorites are per-account, so the entries another member marked are  not listed here, and a guest sees only their own, usually empty, list. Mark a single file with  `GET api/2.0/files/favorites/{fileId}`, or add and remove batches of files and folders with  `POST api/2.0/files/favorites` and `DELETE api/2.0/files/favorites`. Nothing in the section is modified,  though passing `sortBy` saves the requested order as the default order for this account. Entries the caller  can no longer read, and entries that have been moved to the Trash section, drop out of the listing even  though their favorite mark stays, so the section can shrink without an explicit unmark. `folders` and `files`  hold one page of the section, `total` counts the entries matching the request before `count` and `startIndex`  are applied, and `current` describes the section folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the section unfiltered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-favorites-folder/">REST API Reference for GetFavoritesFolder Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        public ApiResponse<FolderContentIntegerWrapper> GetFavoritesFolderWithHttpInfo(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
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
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }
            if (_fields != null)
            {
                localVarRequestOptions.HeaderParameters.Add("fields", _fields); // header parameter
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
            var localVarResponse = Client.Get<FolderContentIntegerWrapper>("/api/2.0/files/@favorites", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFavoritesFolder", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the Favorites section
        /// </summary>
        /// <remarks>
        /// Returns the caller's own Favorites section: the files and folders this account has marked as favorite,  together with the section folder itself. Favorites are per-account, so the entries another member marked are  not listed here, and a guest sees only their own, usually empty, list. Mark a single file with  `GET api/2.0/files/favorites/{fileId}`, or add and remove batches of files and folders with  `POST api/2.0/files/favorites` and `DELETE api/2.0/files/favorites`. Nothing in the section is modified,  though passing `sortBy` saves the requested order as the default order for this account. Entries the caller  can no longer read, and entries that have been moved to the Trash section, drop out of the listing even  though their favorite mark stays, so the section can shrink without an explicit unmark. `folders` and `files`  hold one page of the section, `total` counts the entries matching the request before `count` and `startIndex`  are applied, and `current` describes the section folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the section unfiltered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-favorites-folder/">REST API Reference for GetFavoritesFolder Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        public async Task<FolderContentIntegerWrapper> GetFavoritesFolderAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetFavoritesFolderWithHttpInfoAsync(userIdOrGroupId, filterType, count, startIndex, sortBy, sortOrder, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Favorites section
        /// </summary>
        /// <remarks>
        /// Returns the caller's own Favorites section: the files and folders this account has marked as favorite,  together with the section folder itself. Favorites are per-account, so the entries another member marked are  not listed here, and a guest sees only their own, usually empty, list. Mark a single file with  `GET api/2.0/files/favorites/{fileId}`, or add and remove batches of files and folders with  `POST api/2.0/files/favorites` and `DELETE api/2.0/files/favorites`. Nothing in the section is modified,  though passing `sortBy` saves the requested order as the default order for this account. Entries the caller  can no longer read, and entries that have been moved to the Trash section, drop out of the listing even  though their favorite mark stays, so the section can shrink without an explicit unmark. `folders` and `files`  hold one page of the section, `total` counts the entries matching the request before `count` and `startIndex`  are applied, and `current` describes the section folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the section unfiltered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-favorites-folder/">REST API Reference for GetFavoritesFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderContentIntegerWrapper>> GetFavoritesFolderWithHttpInfoAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
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

            var localVarResponse = await AsynchronousClient.GetAsync<FolderContentIntegerWrapper>("/api/2.0/files/@favorites", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFavoritesFolder", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get used space of files
        /// </summary>
        /// <remarks>
        /// Reports how much storage the portal spends on documents, split by section - My documents, Trash, Rooms,  Archive and, where the feature is on, AI agents - each entry naming the section and the space it takes in  bytes. The figures cover the whole portal rather than the calling account, and moving an entry between  sections moves its space with it, which is why deleting a file to the Trash does not free anything until the  Trash is emptied. Only a caller who may change portal settings, that is the owner and the portal  administrators, is allowed here; a room administrator, an ordinary member and a guest are all refused. The  call is read-only, takes no parameters and answers with the sections in a fixed order. The quota of the portal  as a whole, storage outside documents included, is not part of this answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-used-space/">REST API Reference for GetFilesUsedSpace Operation</seealso>
        /// <returns>FilesStatisticsResultWrapper</returns>
        public FilesStatisticsResultWrapper GetFilesUsedSpace()
        {
            var localVarResponse = GetFilesUsedSpaceWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get used space of files
        /// </summary>
        /// <remarks>
        /// Reports how much storage the portal spends on documents, split by section - My documents, Trash, Rooms,  Archive and, where the feature is on, AI agents - each entry naming the section and the space it takes in  bytes. The figures cover the whole portal rather than the calling account, and moving an entry between  sections moves its space with it, which is why deleting a file to the Trash does not free anything until the  Trash is emptied. Only a caller who may change portal settings, that is the owner and the portal  administrators, is allowed here; a room administrator, an ordinary member and a guest are all refused. The  call is read-only, takes no parameters and answers with the sections in a fixed order. The quota of the portal  as a whole, storage outside documents included, is not part of this answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-used-space/">REST API Reference for GetFilesUsedSpace Operation</seealso>
        /// <returns>ApiResponse of FilesStatisticsResultWrapper</returns>
        public ApiResponse<FilesStatisticsResultWrapper> GetFilesUsedSpaceWithHttpInfo()
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
            var localVarResponse = Client.Get<FilesStatisticsResultWrapper>("/api/2.0/files/filesusedspace", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFilesUsedSpace", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get used space of files
        /// </summary>
        /// <remarks>
        /// Reports how much storage the portal spends on documents, split by section - My documents, Trash, Rooms,  Archive and, where the feature is on, AI agents - each entry naming the section and the space it takes in  bytes. The figures cover the whole portal rather than the calling account, and moving an entry between  sections moves its space with it, which is why deleting a file to the Trash does not free anything until the  Trash is emptied. Only a caller who may change portal settings, that is the owner and the portal  administrators, is allowed here; a room administrator, an ordinary member and a guest are all refused. The  call is read-only, takes no parameters and answers with the sections in a fixed order. The quota of the portal  as a whole, storage outside documents included, is not part of this answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-used-space/">REST API Reference for GetFilesUsedSpace Operation</seealso>
        /// <returns>Task of FilesStatisticsResultWrapper</returns>
        public async Task<FilesStatisticsResultWrapper> GetFilesUsedSpaceAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetFilesUsedSpaceWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get used space of files
        /// </summary>
        /// <remarks>
        /// Reports how much storage the portal spends on documents, split by section - My documents, Trash, Rooms,  Archive and, where the feature is on, AI agents - each entry naming the section and the space it takes in  bytes. The figures cover the whole portal rather than the calling account, and moving an entry between  sections moves its space with it, which is why deleting a file to the Trash does not free anything until the  Trash is emptied. Only a caller who may change portal settings, that is the owner and the portal  administrators, is allowed here; a room administrator, an ordinary member and a guest are all refused. The  call is read-only, takes no parameters and answers with the sections in a fixed order. The quota of the portal  as a whole, storage outside documents included, is not part of this answer.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-used-space/">REST API Reference for GetFilesUsedSpace Operation</seealso>
        /// <returns>Task of ApiResponse (FilesStatisticsResultWrapper)</returns>
        public async Task<ApiResponse<FilesStatisticsResultWrapper>> GetFilesUsedSpaceWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<FilesStatisticsResultWrapper>("/api/2.0/files/filesusedspace", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFilesUsedSpace", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get folder form filter
        /// </summary>
        /// <remarks>
        /// Lists the fields the completed forms of a form-filling room carry, each of them a key and the kind of value  behind it, so that a client can offer them as filters. Feed a pair from this list back as `formsItemKey` and  `formsItemType` of `GET api/2.0/files/{folderId}` to keep only the completed forms whose field of that name  holds a value. The fields are read from the search index of one of the forms already gathered, so they appear  once indexing has caught up with the first submission. Only the Complete folder of a form-filling room  carries such fields: for any other folder, for a folder that does not exist and for one that has been deleted  the answer is an empty list rather than a refusal, and the same holds while nothing has been submitted yet.  The operation reads the index alone, changes nothing and needs no authorization.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder/">REST API Reference for GetFolder Operation</seealso>
        /// <returns>FormsItemArrayWrapper</returns>
        public FormsItemArrayWrapper GetFolder(int folderId)
        {
            var localVarResponse = GetFolderWithHttpInfo(folderId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get folder form filter
        /// </summary>
        /// <remarks>
        /// Lists the fields the completed forms of a form-filling room carry, each of them a key and the kind of value  behind it, so that a client can offer them as filters. Feed a pair from this list back as `formsItemKey` and  `formsItemType` of `GET api/2.0/files/{folderId}` to keep only the completed forms whose field of that name  holds a value. The fields are read from the search index of one of the forms already gathered, so they appear  once indexing has caught up with the first submission. Only the Complete folder of a form-filling room  carries such fields: for any other folder, for a folder that does not exist and for one that has been deleted  the answer is an empty list rather than a refusal, and the same holds while nothing has been submitted yet.  The operation reads the index alone, changes nothing and needs no authorization.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder/">REST API Reference for GetFolder Operation</seealso>
        /// <returns>ApiResponse of FormsItemArrayWrapper</returns>
        public ApiResponse<FormsItemArrayWrapper> GetFolderWithHttpInfo(int folderId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter


            // make the HTTP request
            var localVarResponse = Client.Get<FormsItemArrayWrapper>("/api/2.0/files/{folderId}/formfilter", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFolder", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get folder form filter
        /// </summary>
        /// <remarks>
        /// Lists the fields the completed forms of a form-filling room carry, each of them a key and the kind of value  behind it, so that a client can offer them as filters. Feed a pair from this list back as `formsItemKey` and  `formsItemType` of `GET api/2.0/files/{folderId}` to keep only the completed forms whose field of that name  holds a value. The fields are read from the search index of one of the forms already gathered, so they appear  once indexing has caught up with the first submission. Only the Complete folder of a form-filling room  carries such fields: for any other folder, for a folder that does not exist and for one that has been deleted  the answer is an empty list rather than a refusal, and the same holds while nothing has been submitted yet.  The operation reads the index alone, changes nothing and needs no authorization.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder/">REST API Reference for GetFolder Operation</seealso>
        /// <returns>Task of FormsItemArrayWrapper</returns>
        public async Task<FormsItemArrayWrapper> GetFolderAsync(int folderId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetFolderWithHttpInfoAsync(folderId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get folder form filter
        /// </summary>
        /// <remarks>
        /// Lists the fields the completed forms of a form-filling room carry, each of them a key and the kind of value  behind it, so that a client can offer them as filters. Feed a pair from this list back as `formsItemKey` and  `formsItemType` of `GET api/2.0/files/{folderId}` to keep only the completed forms whose field of that name  holds a value. The fields are read from the search index of one of the forms already gathered, so they appear  once indexing has caught up with the first submission. Only the Complete folder of a form-filling room  carries such fields: for any other folder, for a folder that does not exist and for one that has been deleted  the answer is an empty list rather than a refusal, and the same holds while nothing has been submitted yet.  The operation reads the index alone, changes nothing and needs no authorization.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder/">REST API Reference for GetFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FormsItemArrayWrapper)</returns>
        public async Task<ApiResponse<FormsItemArrayWrapper>> GetFolderWithHttpInfoAsync(int folderId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<FormsItemArrayWrapper>("/api/2.0/files/{folderId}/formfilter", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFolder", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a folder by ID
        /// </summary>
        /// <remarks>
        /// Returns one page of the contents of a folder - its subfolders in `folders`, its files in `files`, the folder  itself in `current` and the chain of parents in `pathParts` - and is the operation a client browses the file  tree with. `filterType`, `filterValue`, `extension`, `userIdOrGroupId`, `sharedBy` and `folderType` narrow  what is listed, `applyFilterOption` decides whether those filters bite on the files, on the folders or on  both, and `withSubFolders`, which is on unless it is switched off, lets a narrowed request descend through the  whole subtree instead of the top level alone. `filterValue` is matched against titles and against indexed  document content, and indexing is asynchronous, so a file uploaded a moment ago can be missing from a search  for a short while. `count` and `startIndex` page through the result while `total` counts everything that  matches, and `sortBy` with `sortOrder` both order the page and are saved as the default order of the account.  Reading a room or an ordinary folder clears its new-item marks for the caller. A caller who may not read the  folder is answered with 403, and a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose contents are listed. Each section root has an operation of its own, such as  `GET api/2.0/files/@my`, and every other folder is opened by the identifier a listing gave for it.</param>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="sharedBy">Restricts the listing to the entries this member shared, which narrows a shared listing down to what one  person handed out. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, spreadsheets, images or one type of room.  Omit it to list every kind the folder holds. (optional)</param>
        /// <param name="roomId">Keeps only the entries that lie in this room, which matters when the listing being read gathers entries from  more than one of them. (optional)</param>
        /// <param name="folderType">Keeps only the folders of these kinds, each given as the number of a folder type; it is how a listing is  narrowed down to, say, the form-filling folders of a room. (optional)</param>
        /// <param name="excludeSubject">Turns `userIdOrGroupId` around: with true the entries of that member or group are the ones left out, with  false they are the only ones kept. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="withSubFolders">Whether a narrowed request reaches into the subfolders: with true, which is what an omitted parameter means,  matching entries are gathered from the whole subtree, with false only the top level is read. It makes a  difference only once `filterType`, `userIdOrGroupId` or `filterValue` narrows the request, because an  unfiltered listing always shows the top level alone. (optional)</param>
        /// <param name="extension">Keeps only the files carrying one of these extensions, several of them separated by commas; the leading dot is  optional. (optional)</param>
        /// <param name="searchArea">Which area a listing that spans several of them is taken from - the active rooms, the archive, the room  templates or the form-filling rooms. A folder that belongs to one area only settles the area itself and  ignores the parameter. (optional)</param>
        /// <param name="formsItemKey">Keeps only the completed forms whose form field of this name holds a value. Take the name from  `GET api/2.0/files/{folderId}/formfilter`, and use it in the folder that gathers the completed copies of a  form-filling room. (optional)</param>
        /// <param name="formsItemType">The kind of the form field named by `formsItemKey`, taken from the same list; the two are sent together. (optional)</param>
        /// <param name="count">The size of one page of the listing. Pair it with `startIndex` to walk through the result, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the listing is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the folder unfiltered. (optional)</param>
        /// <param name="location">Where the entries of a tag-based listing have to live to be kept: `Room` keeps what lies in a room,  `Documents` what lies in a personal section, and `Link` what was reached through an external link that is  still valid. It shapes the Favorites and Recent listings and does nothing in an ordinary folder. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-by-folder-id/">REST API Reference for GetFolderByFolderId Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        public FolderContentIntegerWrapper GetFolderByFolderId(int folderId, Guid? userIdOrGroupId = default, Guid? sharedBy = default, FilterType? filterType = default, int? roomId = default, List<int>? folderType = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, bool? withSubFolders = default, string? extension = default, SearchArea? searchArea = default, string? formsItemKey = default, string? formsItemType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, Location? location = default)
        {
            var localVarResponse = GetFolderByFolderIdWithHttpInfo(folderId, userIdOrGroupId, sharedBy, filterType, roomId, folderType, excludeSubject, applyFilterOption, withSubFolders, extension, searchArea, formsItemKey, formsItemType, count, startIndex, sortBy, sortOrder, filterValue, location);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a folder by ID
        /// </summary>
        /// <remarks>
        /// Returns one page of the contents of a folder - its subfolders in `folders`, its files in `files`, the folder  itself in `current` and the chain of parents in `pathParts` - and is the operation a client browses the file  tree with. `filterType`, `filterValue`, `extension`, `userIdOrGroupId`, `sharedBy` and `folderType` narrow  what is listed, `applyFilterOption` decides whether those filters bite on the files, on the folders or on  both, and `withSubFolders`, which is on unless it is switched off, lets a narrowed request descend through the  whole subtree instead of the top level alone. `filterValue` is matched against titles and against indexed  document content, and indexing is asynchronous, so a file uploaded a moment ago can be missing from a search  for a short while. `count` and `startIndex` page through the result while `total` counts everything that  matches, and `sortBy` with `sortOrder` both order the page and are saved as the default order of the account.  Reading a room or an ordinary folder clears its new-item marks for the caller. A caller who may not read the  folder is answered with 403, and a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose contents are listed. Each section root has an operation of its own, such as  `GET api/2.0/files/@my`, and every other folder is opened by the identifier a listing gave for it.</param>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="sharedBy">Restricts the listing to the entries this member shared, which narrows a shared listing down to what one  person handed out. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, spreadsheets, images or one type of room.  Omit it to list every kind the folder holds. (optional)</param>
        /// <param name="roomId">Keeps only the entries that lie in this room, which matters when the listing being read gathers entries from  more than one of them. (optional)</param>
        /// <param name="folderType">Keeps only the folders of these kinds, each given as the number of a folder type; it is how a listing is  narrowed down to, say, the form-filling folders of a room. (optional)</param>
        /// <param name="excludeSubject">Turns `userIdOrGroupId` around: with true the entries of that member or group are the ones left out, with  false they are the only ones kept. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="withSubFolders">Whether a narrowed request reaches into the subfolders: with true, which is what an omitted parameter means,  matching entries are gathered from the whole subtree, with false only the top level is read. It makes a  difference only once `filterType`, `userIdOrGroupId` or `filterValue` narrows the request, because an  unfiltered listing always shows the top level alone. (optional)</param>
        /// <param name="extension">Keeps only the files carrying one of these extensions, several of them separated by commas; the leading dot is  optional. (optional)</param>
        /// <param name="searchArea">Which area a listing that spans several of them is taken from - the active rooms, the archive, the room  templates or the form-filling rooms. A folder that belongs to one area only settles the area itself and  ignores the parameter. (optional)</param>
        /// <param name="formsItemKey">Keeps only the completed forms whose form field of this name holds a value. Take the name from  `GET api/2.0/files/{folderId}/formfilter`, and use it in the folder that gathers the completed copies of a  form-filling room. (optional)</param>
        /// <param name="formsItemType">The kind of the form field named by `formsItemKey`, taken from the same list; the two are sent together. (optional)</param>
        /// <param name="count">The size of one page of the listing. Pair it with `startIndex` to walk through the result, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the listing is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the folder unfiltered. (optional)</param>
        /// <param name="location">Where the entries of a tag-based listing have to live to be kept: `Room` keeps what lies in a room,  `Documents` what lies in a personal section, and `Link` what was reached through an external link that is  still valid. It shapes the Favorites and Recent listings and does nothing in an ordinary folder. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-by-folder-id/">REST API Reference for GetFolderByFolderId Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        public ApiResponse<FolderContentIntegerWrapper> GetFolderByFolderIdWithHttpInfo(int folderId, Guid? userIdOrGroupId = default, Guid? sharedBy = default, FilterType? filterType = default, int? roomId = default, List<int>? folderType = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, bool? withSubFolders = default, string? extension = default, SearchArea? searchArea = default, string? formsItemKey = default, string? formsItemType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, Location? location = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (sharedBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sharedBy", sharedBy));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
            }
            if (roomId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "roomId", roomId));
            }
            if (folderType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("multi", "folderType", folderType));
            }
            if (excludeSubject != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeSubject", excludeSubject));
            }
            if (applyFilterOption != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "applyFilterOption", applyFilterOption));
            }
            if (withSubFolders != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "withSubFolders", withSubFolders));
            }
            if (extension != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "extension", extension));
            }
            if (searchArea != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "searchArea", searchArea));
            }
            if (formsItemKey != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "formsItemKey", formsItemKey));
            }
            if (formsItemType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "formsItemType", formsItemType));
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
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }
            if (location != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Location", location));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<FolderContentIntegerWrapper>("/api/2.0/files/{folderId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFolderByFolderId", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a folder by ID
        /// </summary>
        /// <remarks>
        /// Returns one page of the contents of a folder - its subfolders in `folders`, its files in `files`, the folder  itself in `current` and the chain of parents in `pathParts` - and is the operation a client browses the file  tree with. `filterType`, `filterValue`, `extension`, `userIdOrGroupId`, `sharedBy` and `folderType` narrow  what is listed, `applyFilterOption` decides whether those filters bite on the files, on the folders or on  both, and `withSubFolders`, which is on unless it is switched off, lets a narrowed request descend through the  whole subtree instead of the top level alone. `filterValue` is matched against titles and against indexed  document content, and indexing is asynchronous, so a file uploaded a moment ago can be missing from a search  for a short while. `count` and `startIndex` page through the result while `total` counts everything that  matches, and `sortBy` with `sortOrder` both order the page and are saved as the default order of the account.  Reading a room or an ordinary folder clears its new-item marks for the caller. A caller who may not read the  folder is answered with 403, and a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose contents are listed. Each section root has an operation of its own, such as  `GET api/2.0/files/@my`, and every other folder is opened by the identifier a listing gave for it.</param>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="sharedBy">Restricts the listing to the entries this member shared, which narrows a shared listing down to what one  person handed out. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, spreadsheets, images or one type of room.  Omit it to list every kind the folder holds. (optional)</param>
        /// <param name="roomId">Keeps only the entries that lie in this room, which matters when the listing being read gathers entries from  more than one of them. (optional)</param>
        /// <param name="folderType">Keeps only the folders of these kinds, each given as the number of a folder type; it is how a listing is  narrowed down to, say, the form-filling folders of a room. (optional)</param>
        /// <param name="excludeSubject">Turns `userIdOrGroupId` around: with true the entries of that member or group are the ones left out, with  false they are the only ones kept. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="withSubFolders">Whether a narrowed request reaches into the subfolders: with true, which is what an omitted parameter means,  matching entries are gathered from the whole subtree, with false only the top level is read. It makes a  difference only once `filterType`, `userIdOrGroupId` or `filterValue` narrows the request, because an  unfiltered listing always shows the top level alone. (optional)</param>
        /// <param name="extension">Keeps only the files carrying one of these extensions, several of them separated by commas; the leading dot is  optional. (optional)</param>
        /// <param name="searchArea">Which area a listing that spans several of them is taken from - the active rooms, the archive, the room  templates or the form-filling rooms. A folder that belongs to one area only settles the area itself and  ignores the parameter. (optional)</param>
        /// <param name="formsItemKey">Keeps only the completed forms whose form field of this name holds a value. Take the name from  `GET api/2.0/files/{folderId}/formfilter`, and use it in the folder that gathers the completed copies of a  form-filling room. (optional)</param>
        /// <param name="formsItemType">The kind of the form field named by `formsItemKey`, taken from the same list; the two are sent together. (optional)</param>
        /// <param name="count">The size of one page of the listing. Pair it with `startIndex` to walk through the result, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the listing is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the folder unfiltered. (optional)</param>
        /// <param name="location">Where the entries of a tag-based listing have to live to be kept: `Room` keeps what lies in a room,  `Documents` what lies in a personal section, and `Link` what was reached through an external link that is  still valid. It shapes the Favorites and Recent listings and does nothing in an ordinary folder. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-by-folder-id/">REST API Reference for GetFolderByFolderId Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        public async Task<FolderContentIntegerWrapper> GetFolderByFolderIdAsync(int folderId, Guid? userIdOrGroupId = default, Guid? sharedBy = default, FilterType? filterType = default, int? roomId = default, List<int>? folderType = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, bool? withSubFolders = default, string? extension = default, SearchArea? searchArea = default, string? formsItemKey = default, string? formsItemType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, Location? location = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetFolderByFolderIdWithHttpInfoAsync(folderId, userIdOrGroupId, sharedBy, filterType, roomId, folderType, excludeSubject, applyFilterOption, withSubFolders, extension, searchArea, formsItemKey, formsItemType, count, startIndex, sortBy, sortOrder, filterValue, location, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a folder by ID
        /// </summary>
        /// <remarks>
        /// Returns one page of the contents of a folder - its subfolders in `folders`, its files in `files`, the folder  itself in `current` and the chain of parents in `pathParts` - and is the operation a client browses the file  tree with. `filterType`, `filterValue`, `extension`, `userIdOrGroupId`, `sharedBy` and `folderType` narrow  what is listed, `applyFilterOption` decides whether those filters bite on the files, on the folders or on  both, and `withSubFolders`, which is on unless it is switched off, lets a narrowed request descend through the  whole subtree instead of the top level alone. `filterValue` is matched against titles and against indexed  document content, and indexing is asynchronous, so a file uploaded a moment ago can be missing from a search  for a short while. `count` and `startIndex` page through the result while `total` counts everything that  matches, and `sortBy` with `sortOrder` both order the page and are saved as the default order of the account.  Reading a room or an ordinary folder clears its new-item marks for the caller. A caller who may not read the  folder is answered with 403, and a folder that does not exist with 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose contents are listed. Each section root has an operation of its own, such as  `GET api/2.0/files/@my`, and every other folder is opened by the identifier a listing gave for it.</param>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="sharedBy">Restricts the listing to the entries this member shared, which narrows a shared listing down to what one  person handed out. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, spreadsheets, images or one type of room.  Omit it to list every kind the folder holds. (optional)</param>
        /// <param name="roomId">Keeps only the entries that lie in this room, which matters when the listing being read gathers entries from  more than one of them. (optional)</param>
        /// <param name="folderType">Keeps only the folders of these kinds, each given as the number of a folder type; it is how a listing is  narrowed down to, say, the form-filling folders of a room. (optional)</param>
        /// <param name="excludeSubject">Turns `userIdOrGroupId` around: with true the entries of that member or group are the ones left out, with  false they are the only ones kept. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="withSubFolders">Whether a narrowed request reaches into the subfolders: with true, which is what an omitted parameter means,  matching entries are gathered from the whole subtree, with false only the top level is read. It makes a  difference only once `filterType`, `userIdOrGroupId` or `filterValue` narrows the request, because an  unfiltered listing always shows the top level alone. (optional)</param>
        /// <param name="extension">Keeps only the files carrying one of these extensions, several of them separated by commas; the leading dot is  optional. (optional)</param>
        /// <param name="searchArea">Which area a listing that spans several of them is taken from - the active rooms, the archive, the room  templates or the form-filling rooms. A folder that belongs to one area only settles the area itself and  ignores the parameter. (optional)</param>
        /// <param name="formsItemKey">Keeps only the completed forms whose form field of this name holds a value. Take the name from  `GET api/2.0/files/{folderId}/formfilter`, and use it in the folder that gathers the completed copies of a  form-filling room. (optional)</param>
        /// <param name="formsItemType">The kind of the form field named by `formsItemKey`, taken from the same list; the two are sent together. (optional)</param>
        /// <param name="count">The size of one page of the listing. Pair it with `startIndex` to walk through the result, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the listing is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the folder unfiltered. (optional)</param>
        /// <param name="location">Where the entries of a tag-based listing have to live to be kept: `Room` keeps what lies in a room,  `Documents` what lies in a personal section, and `Link` what was reached through an external link that is  still valid. It shapes the Favorites and Recent listings and does nothing in an ordinary folder. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-by-folder-id/">REST API Reference for GetFolderByFolderId Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderContentIntegerWrapper>> GetFolderByFolderIdWithHttpInfoAsync(int folderId, Guid? userIdOrGroupId = default, Guid? sharedBy = default, FilterType? filterType = default, int? roomId = default, List<int>? folderType = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, bool? withSubFolders = default, string? extension = default, SearchArea? searchArea = default, string? formsItemKey = default, string? formsItemType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, Location? location = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (sharedBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sharedBy", sharedBy));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
            }
            if (roomId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "roomId", roomId));
            }
            if (folderType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("multi", "folderType", folderType));
            }
            if (excludeSubject != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeSubject", excludeSubject));
            }
            if (applyFilterOption != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "applyFilterOption", applyFilterOption));
            }
            if (withSubFolders != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "withSubFolders", withSubFolders));
            }
            if (extension != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "extension", extension));
            }
            if (searchArea != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "searchArea", searchArea));
            }
            if (formsItemKey != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "formsItemKey", formsItemKey));
            }
            if (formsItemType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "formsItemType", formsItemType));
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
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }
            if (location != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Location", location));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<FolderContentIntegerWrapper>("/api/2.0/files/{folderId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFolderByFolderId", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get folder history
        /// </summary>
        /// <remarks>
        /// Lists what has happened to a folder and to the entries inside it - creations, renames, uploads, moves,  deletions and changes of access - each record naming the action, the moment it happened and the member behind  it. Records that belong to one action are grouped, so a batch arrives as a single entry carrying the rest of  itself in `related`, and the list runs from the most recent record backwards. `fromDate` and `toDate` narrow  the period, `startIndex` and `count` page through the result, and the number of records matching the request  is reported in the response headers rather than in the body. Any member who can read the folder may read its  history; a caller without access is answered with 403 and a folder that does not exist with 404. When the  folder is a form-filling folder the caller reached through a filling invitation, the history is narrowed to  what that caller may see. The call is read-only. To take the same history away as a spreadsheet, start a  report with `POST api/2.0/files/folder/{folderId}/log/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose activity log is read; the log covers the folder itself and the entries inside it.</param>
        /// <param name="fromDate">The earliest moment an entry may have, read in the time zone of the portal; left out, the log starts at the  oldest entry the portal still keeps. (optional)</param>
        /// <param name="toDate">The latest moment an entry may have, read in the time zone of the portal; left out, the log ends at the newest  entry. (optional)</param>
        /// <param name="count">How many entries one page holds. The number of entries that match the query is reported in the response  headers, not in the body. (optional)</param>
        /// <param name="startIndex">How many entries to skip before the page begins, counted from the newest one, so pages are taken by adding the  page size to it. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-history/">REST API Reference for GetFolderHistory Operation</seealso>
        /// <returns>HistoryArrayWrapper</returns>
        public HistoryArrayWrapper GetFolderHistory(int folderId, DateTime? fromDate = default, DateTime? toDate = default, int? count = default, int? startIndex = default)
        {
            var localVarResponse = GetFolderHistoryWithHttpInfo(folderId, fromDate, toDate, count, startIndex);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get folder history
        /// </summary>
        /// <remarks>
        /// Lists what has happened to a folder and to the entries inside it - creations, renames, uploads, moves,  deletions and changes of access - each record naming the action, the moment it happened and the member behind  it. Records that belong to one action are grouped, so a batch arrives as a single entry carrying the rest of  itself in `related`, and the list runs from the most recent record backwards. `fromDate` and `toDate` narrow  the period, `startIndex` and `count` page through the result, and the number of records matching the request  is reported in the response headers rather than in the body. Any member who can read the folder may read its  history; a caller without access is answered with 403 and a folder that does not exist with 404. When the  folder is a form-filling folder the caller reached through a filling invitation, the history is narrowed to  what that caller may see. The call is read-only. To take the same history away as a spreadsheet, start a  report with `POST api/2.0/files/folder/{folderId}/log/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose activity log is read; the log covers the folder itself and the entries inside it.</param>
        /// <param name="fromDate">The earliest moment an entry may have, read in the time zone of the portal; left out, the log starts at the  oldest entry the portal still keeps. (optional)</param>
        /// <param name="toDate">The latest moment an entry may have, read in the time zone of the portal; left out, the log ends at the newest  entry. (optional)</param>
        /// <param name="count">How many entries one page holds. The number of entries that match the query is reported in the response  headers, not in the body. (optional)</param>
        /// <param name="startIndex">How many entries to skip before the page begins, counted from the newest one, so pages are taken by adding the  page size to it. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-history/">REST API Reference for GetFolderHistory Operation</seealso>
        /// <returns>ApiResponse of HistoryArrayWrapper</returns>
        public ApiResponse<HistoryArrayWrapper> GetFolderHistoryWithHttpInfo(int folderId, DateTime? fromDate = default, DateTime? toDate = default, int? count = default, int? startIndex = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (fromDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "fromDate", fromDate));
            }
            if (toDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "toDate", toDate));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
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
            var localVarResponse = Client.Get<HistoryArrayWrapper>("/api/2.0/files/folder/{folderId}/log", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFolderHistory", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get folder history
        /// </summary>
        /// <remarks>
        /// Lists what has happened to a folder and to the entries inside it - creations, renames, uploads, moves,  deletions and changes of access - each record naming the action, the moment it happened and the member behind  it. Records that belong to one action are grouped, so a batch arrives as a single entry carrying the rest of  itself in `related`, and the list runs from the most recent record backwards. `fromDate` and `toDate` narrow  the period, `startIndex` and `count` page through the result, and the number of records matching the request  is reported in the response headers rather than in the body. Any member who can read the folder may read its  history; a caller without access is answered with 403 and a folder that does not exist with 404. When the  folder is a form-filling folder the caller reached through a filling invitation, the history is narrowed to  what that caller may see. The call is read-only. To take the same history away as a spreadsheet, start a  report with `POST api/2.0/files/folder/{folderId}/log/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose activity log is read; the log covers the folder itself and the entries inside it.</param>
        /// <param name="fromDate">The earliest moment an entry may have, read in the time zone of the portal; left out, the log starts at the  oldest entry the portal still keeps. (optional)</param>
        /// <param name="toDate">The latest moment an entry may have, read in the time zone of the portal; left out, the log ends at the newest  entry. (optional)</param>
        /// <param name="count">How many entries one page holds. The number of entries that match the query is reported in the response  headers, not in the body. (optional)</param>
        /// <param name="startIndex">How many entries to skip before the page begins, counted from the newest one, so pages are taken by adding the  page size to it. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-history/">REST API Reference for GetFolderHistory Operation</seealso>
        /// <returns>Task of HistoryArrayWrapper</returns>
        public async Task<HistoryArrayWrapper> GetFolderHistoryAsync(int folderId, DateTime? fromDate = default, DateTime? toDate = default, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetFolderHistoryWithHttpInfoAsync(folderId, fromDate, toDate, count, startIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get folder history
        /// </summary>
        /// <remarks>
        /// Lists what has happened to a folder and to the entries inside it - creations, renames, uploads, moves,  deletions and changes of access - each record naming the action, the moment it happened and the member behind  it. Records that belong to one action are grouped, so a batch arrives as a single entry carrying the rest of  itself in `related`, and the list runs from the most recent record backwards. `fromDate` and `toDate` narrow  the period, `startIndex` and `count` page through the result, and the number of records matching the request  is reported in the response headers rather than in the body. Any member who can read the folder may read its  history; a caller without access is answered with 403 and a folder that does not exist with 404. When the  folder is a form-filling folder the caller reached through a filling invitation, the history is narrowed to  what that caller may see. The call is read-only. To take the same history away as a spreadsheet, start a  report with `POST api/2.0/files/folder/{folderId}/log/report`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose activity log is read; the log covers the folder itself and the entries inside it.</param>
        /// <param name="fromDate">The earliest moment an entry may have, read in the time zone of the portal; left out, the log starts at the  oldest entry the portal still keeps. (optional)</param>
        /// <param name="toDate">The latest moment an entry may have, read in the time zone of the portal; left out, the log ends at the newest  entry. (optional)</param>
        /// <param name="count">How many entries one page holds. The number of entries that match the query is reported in the response  headers, not in the body. (optional)</param>
        /// <param name="startIndex">How many entries to skip before the page begins, counted from the newest one, so pages are taken by adding the  page size to it. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-history/">REST API Reference for GetFolderHistory Operation</seealso>
        /// <returns>Task of ApiResponse (HistoryArrayWrapper)</returns>
        public async Task<ApiResponse<HistoryArrayWrapper>> GetFolderHistoryWithHttpInfoAsync(int folderId, DateTime? fromDate = default, DateTime? toDate = default, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (fromDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "fromDate", fromDate));
            }
            if (toDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "toDate", toDate));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
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

            var localVarResponse = await AsynchronousClient.GetAsync<HistoryArrayWrapper>("/api/2.0/files/folder/{folderId}/log", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFolderHistory", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get folder information
        /// </summary>
        /// <remarks>
        /// Returns one folder as an object - its title, its parent, the moments it was created and last changed, the  access the caller has to it, the number of items that are new for them, and the room settings when the folder  is a room - without listing anything inside it. Use it to resolve a folder identifier into something  displayable, and `GET api/2.0/files/{folderId}` when the contents are what is wanted; unlike that operation,  this one leaves the new-item marks of the folder alone. Any member who can read the folder may call it, and an  anonymous caller only through an external link that grants access, everybody else being refused; a folder that  does not exist is answered as not found. The call is read-only. The chain of parents above the folder is not  part of the answer and is read with `GET api/2.0/files/folder/{folderId}/path`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-info/">REST API Reference for GetFolderInfo Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper GetFolderInfo(int folderId)
        {
            var localVarResponse = GetFolderInfoWithHttpInfo(folderId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get folder information
        /// </summary>
        /// <remarks>
        /// Returns one folder as an object - its title, its parent, the moments it was created and last changed, the  access the caller has to it, the number of items that are new for them, and the room settings when the folder  is a room - without listing anything inside it. Use it to resolve a folder identifier into something  displayable, and `GET api/2.0/files/{folderId}` when the contents are what is wanted; unlike that operation,  this one leaves the new-item marks of the folder alone. Any member who can read the folder may call it, and an  anonymous caller only through an external link that grants access, everybody else being refused; a folder that  does not exist is answered as not found. The call is read-only. The chain of parents above the folder is not  part of the answer and is read with `GET api/2.0/files/folder/{folderId}/path`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-info/">REST API Reference for GetFolderInfo Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public ApiResponse<FolderIntegerWrapper> GetFolderInfoWithHttpInfo(int folderId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter


            // make the HTTP request
            var localVarResponse = Client.Get<FolderIntegerWrapper>("/api/2.0/files/folder/{folderId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFolderInfo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get folder information
        /// </summary>
        /// <remarks>
        /// Returns one folder as an object - its title, its parent, the moments it was created and last changed, the  access the caller has to it, the number of items that are new for them, and the room settings when the folder  is a room - without listing anything inside it. Use it to resolve a folder identifier into something  displayable, and `GET api/2.0/files/{folderId}` when the contents are what is wanted; unlike that operation,  this one leaves the new-item marks of the folder alone. Any member who can read the folder may call it, and an  anonymous caller only through an external link that grants access, everybody else being refused; a folder that  does not exist is answered as not found. The call is read-only. The chain of parents above the folder is not  part of the answer and is read with `GET api/2.0/files/folder/{folderId}/path`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-info/">REST API Reference for GetFolderInfo Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async Task<FolderIntegerWrapper> GetFolderInfoAsync(int folderId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetFolderInfoWithHttpInfoAsync(folderId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get folder information
        /// </summary>
        /// <remarks>
        /// Returns one folder as an object - its title, its parent, the moments it was created and last changed, the  access the caller has to it, the number of items that are new for them, and the room settings when the folder  is a room - without listing anything inside it. Use it to resolve a folder identifier into something  displayable, and `GET api/2.0/files/{folderId}` when the contents are what is wanted; unlike that operation,  this one leaves the new-item marks of the folder alone. Any member who can read the folder may call it, and an  anonymous caller only through an external link that grants access, everybody else being refused; a folder that  does not exist is answered as not found. The call is read-only. The chain of parents above the folder is not  part of the answer and is read with `GET api/2.0/files/folder/{folderId}/path`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-info/">REST API Reference for GetFolderInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderIntegerWrapper>> GetFolderInfoWithHttpInfoAsync(int folderId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<FolderIntegerWrapper>("/api/2.0/files/folder/{folderId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFolderInfo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get folder external links
        /// </summary>
        /// <remarks>
        /// Lists the external links of a folder or a room, each with its identifier, title, address, rights, expiration  date, password flag and download restriction, the primary link among them once it exists. At most the first  hundred links are answered and the number returned is reported in the response headers; there are no paging  parameters here. A folder that has never been shared by link answers with an empty list, and so does a member  who may read the folder but not manage its links - the empty answer therefore means nothing to show you  rather than no links exist. A member without access to the room is refused, an anonymous caller is rejected,  and a folder that does not exist is answered as not found. The call is read-only. Take an identifier from here  to `PUT api/2.0/files/folder/{id}/links` to change or remove that link, and read the primary one alone with  `GET api/2.0/files/folder/{id}/link`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room whose external links are listed.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-links/">REST API Reference for GetFolderLinks Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        public FileShareArrayWrapper GetFolderLinks(int id)
        {
            var localVarResponse = GetFolderLinksWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get folder external links
        /// </summary>
        /// <remarks>
        /// Lists the external links of a folder or a room, each with its identifier, title, address, rights, expiration  date, password flag and download restriction, the primary link among them once it exists. At most the first  hundred links are answered and the number returned is reported in the response headers; there are no paging  parameters here. A folder that has never been shared by link answers with an empty list, and so does a member  who may read the folder but not manage its links - the empty answer therefore means nothing to show you  rather than no links exist. A member without access to the room is refused, an anonymous caller is rejected,  and a folder that does not exist is answered as not found. The call is read-only. Take an identifier from here  to `PUT api/2.0/files/folder/{id}/links` to change or remove that link, and read the primary one alone with  `GET api/2.0/files/folder/{id}/link`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room whose external links are listed.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-links/">REST API Reference for GetFolderLinks Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        public ApiResponse<FileShareArrayWrapper> GetFolderLinksWithHttpInfo(int id)
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
            var localVarResponse = Client.Get<FileShareArrayWrapper>("/api/2.0/files/folder/{id}/links", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFolderLinks", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get folder external links
        /// </summary>
        /// <remarks>
        /// Lists the external links of a folder or a room, each with its identifier, title, address, rights, expiration  date, password flag and download restriction, the primary link among them once it exists. At most the first  hundred links are answered and the number returned is reported in the response headers; there are no paging  parameters here. A folder that has never been shared by link answers with an empty list, and so does a member  who may read the folder but not manage its links - the empty answer therefore means nothing to show you  rather than no links exist. A member without access to the room is refused, an anonymous caller is rejected,  and a folder that does not exist is answered as not found. The call is read-only. Take an identifier from here  to `PUT api/2.0/files/folder/{id}/links` to change or remove that link, and read the primary one alone with  `GET api/2.0/files/folder/{id}/link`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room whose external links are listed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-links/">REST API Reference for GetFolderLinks Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        public async Task<FileShareArrayWrapper> GetFolderLinksAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetFolderLinksWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get folder external links
        /// </summary>
        /// <remarks>
        /// Lists the external links of a folder or a room, each with its identifier, title, address, rights, expiration  date, password flag and download restriction, the primary link among them once it exists. At most the first  hundred links are answered and the number returned is reported in the response headers; there are no paging  parameters here. A folder that has never been shared by link answers with an empty list, and so does a member  who may read the folder but not manage its links - the empty answer therefore means nothing to show you  rather than no links exist. A member without access to the room is refused, an anonymous caller is rejected,  and a folder that does not exist is answered as not found. The call is read-only. Take an identifier from here  to `PUT api/2.0/files/folder/{id}/links` to change or remove that link, and read the primary one alone with  `GET api/2.0/files/folder/{id}/link`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room whose external links are listed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-links/">REST API Reference for GetFolderLinks Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        public async Task<ApiResponse<FileShareArrayWrapper>> GetFolderLinksWithHttpInfoAsync(int id, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<FileShareArrayWrapper>("/api/2.0/files/folder/{id}/links", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFolderLinks", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the folder path
        /// </summary>
        /// <remarks>
        /// Returns the chain of folders that leads to the folder named in the path, ordered from the section root down to  the folder itself, which is the last entry. It is what a breadcrumb trail is built from, and it also tells a  client which section - a room, the personal section, the archive - a bare folder identifier belongs to. Only  the folders the caller may see are part of the chain, so a member who was given access to a folder deep inside  a room gets a shorter path than the room manager does. The caller needs read access to the folder and is  otherwise answered with 403, while a folder that does not exist is answered as not found. The call is  read-only and takes no paging parameters. To go the other way, from a folder down into its contents, call  `GET api/2.0/files/{folderId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-path/">REST API Reference for GetFolderPath Operation</seealso>
        /// <returns>FileEntryBaseArrayWrapper</returns>
        public FileEntryBaseArrayWrapper GetFolderPath(int folderId)
        {
            var localVarResponse = GetFolderPathWithHttpInfo(folderId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the folder path
        /// </summary>
        /// <remarks>
        /// Returns the chain of folders that leads to the folder named in the path, ordered from the section root down to  the folder itself, which is the last entry. It is what a breadcrumb trail is built from, and it also tells a  client which section - a room, the personal section, the archive - a bare folder identifier belongs to. Only  the folders the caller may see are part of the chain, so a member who was given access to a folder deep inside  a room gets a shorter path than the room manager does. The caller needs read access to the folder and is  otherwise answered with 403, while a folder that does not exist is answered as not found. The call is  read-only and takes no paging parameters. To go the other way, from a folder down into its contents, call  `GET api/2.0/files/{folderId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-path/">REST API Reference for GetFolderPath Operation</seealso>
        /// <returns>ApiResponse of FileEntryBaseArrayWrapper</returns>
        public ApiResponse<FileEntryBaseArrayWrapper> GetFolderPathWithHttpInfo(int folderId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter

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
            var localVarResponse = Client.Get<FileEntryBaseArrayWrapper>("/api/2.0/files/folder/{folderId}/path", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFolderPath", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the folder path
        /// </summary>
        /// <remarks>
        /// Returns the chain of folders that leads to the folder named in the path, ordered from the section root down to  the folder itself, which is the last entry. It is what a breadcrumb trail is built from, and it also tells a  client which section - a room, the personal section, the archive - a bare folder identifier belongs to. Only  the folders the caller may see are part of the chain, so a member who was given access to a folder deep inside  a room gets a shorter path than the room manager does. The caller needs read access to the folder and is  otherwise answered with 403, while a folder that does not exist is answered as not found. The call is  read-only and takes no paging parameters. To go the other way, from a folder down into its contents, call  `GET api/2.0/files/{folderId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-path/">REST API Reference for GetFolderPath Operation</seealso>
        /// <returns>Task of FileEntryBaseArrayWrapper</returns>
        public async Task<FileEntryBaseArrayWrapper> GetFolderPathAsync(int folderId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetFolderPathWithHttpInfoAsync(folderId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the folder path
        /// </summary>
        /// <remarks>
        /// Returns the chain of folders that leads to the folder named in the path, ordered from the section root down to  the folder itself, which is the last entry. It is what a breadcrumb trail is built from, and it also tells a  client which section - a room, the personal section, the archive - a bare folder identifier belongs to. Only  the folders the caller may see are part of the chain, so a member who was given access to a folder deep inside  a room gets a shorter path than the room manager does. The caller needs read access to the folder and is  otherwise answered with 403, while a folder that does not exist is answered as not found. The call is  read-only and takes no paging parameters. To go the other way, from a folder down into its contents, call  `GET api/2.0/files/{folderId}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-path/">REST API Reference for GetFolderPath Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryBaseArrayWrapper)</returns>
        public async Task<ApiResponse<FileEntryBaseArrayWrapper>> GetFolderPathWithHttpInfoAsync(int folderId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter

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

            var localVarResponse = await AsynchronousClient.GetAsync<FileEntryBaseArrayWrapper>("/api/2.0/files/folder/{folderId}/path", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFolderPath", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the folder primary external link
        /// </summary>
        /// <remarks>
        /// Answers with the primary external link of a folder or a room - the one the Copy link action of a client  hands out - with its address in `sharedTo.shareLink`, its rights in `access`, and its title, expiration date,  password flag and download restriction beside them. The link is created on the first read if the folder has  none, with read rights, no password and no expiry, so this operation mutates on that first call and is a plain  read afterwards; repeated calls answer with the same link identifier. The caller needs the right to manage the  links of the room the folder belongs to, which its manager and a portal administrator acting as room manager  have; a member with read access alone is refused with 403 and an anonymous caller is rejected, while a link  that was deliberately revoked is answered with 404 rather than being recreated. The paging parameters are  accepted for compatibility and leave the single link answered here unchanged. Every external link of the same  folder is listed by `GET api/2.0/files/folder/{id}/links`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the operation addresses. A folder stored on the portal is numbered, while a folder in a  connected third-party account is named by an opaque string.</param>
        /// <param name="count">How many entries at most to answer with, in the operations of this folder that return a list; an operation  that answers with a single object is not affected by it. (optional)</param>
        /// <param name="startIndex">How many entries of such a list to skip before answering, used together with `count` to walk through it page  by page. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-primary-external-link/">REST API Reference for GetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        public FileShareWrapper GetFolderPrimaryExternalLink(int id, int? count = default, int? startIndex = default)
        {
            var localVarResponse = GetFolderPrimaryExternalLinkWithHttpInfo(id, count, startIndex);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the folder primary external link
        /// </summary>
        /// <remarks>
        /// Answers with the primary external link of a folder or a room - the one the Copy link action of a client  hands out - with its address in `sharedTo.shareLink`, its rights in `access`, and its title, expiration date,  password flag and download restriction beside them. The link is created on the first read if the folder has  none, with read rights, no password and no expiry, so this operation mutates on that first call and is a plain  read afterwards; repeated calls answer with the same link identifier. The caller needs the right to manage the  links of the room the folder belongs to, which its manager and a portal administrator acting as room manager  have; a member with read access alone is refused with 403 and an anonymous caller is rejected, while a link  that was deliberately revoked is answered with 404 rather than being recreated. The paging parameters are  accepted for compatibility and leave the single link answered here unchanged. Every external link of the same  folder is listed by `GET api/2.0/files/folder/{id}/links`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the operation addresses. A folder stored on the portal is numbered, while a folder in a  connected third-party account is named by an opaque string.</param>
        /// <param name="count">How many entries at most to answer with, in the operations of this folder that return a list; an operation  that answers with a single object is not affected by it. (optional)</param>
        /// <param name="startIndex">How many entries of such a list to skip before answering, used together with `count` to walk through it page  by page. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-primary-external-link/">REST API Reference for GetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        public ApiResponse<FileShareWrapper> GetFolderPrimaryExternalLinkWithHttpInfo(int id, int? count = default, int? startIndex = default)
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
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<FileShareWrapper>("/api/2.0/files/folder/{id}/link", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFolderPrimaryExternalLink", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the folder primary external link
        /// </summary>
        /// <remarks>
        /// Answers with the primary external link of a folder or a room - the one the Copy link action of a client  hands out - with its address in `sharedTo.shareLink`, its rights in `access`, and its title, expiration date,  password flag and download restriction beside them. The link is created on the first read if the folder has  none, with read rights, no password and no expiry, so this operation mutates on that first call and is a plain  read afterwards; repeated calls answer with the same link identifier. The caller needs the right to manage the  links of the room the folder belongs to, which its manager and a portal administrator acting as room manager  have; a member with read access alone is refused with 403 and an anonymous caller is rejected, while a link  that was deliberately revoked is answered with 404 rather than being recreated. The paging parameters are  accepted for compatibility and leave the single link answered here unchanged. Every external link of the same  folder is listed by `GET api/2.0/files/folder/{id}/links`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the operation addresses. A folder stored on the portal is numbered, while a folder in a  connected third-party account is named by an opaque string.</param>
        /// <param name="count">How many entries at most to answer with, in the operations of this folder that return a list; an operation  that answers with a single object is not affected by it. (optional)</param>
        /// <param name="startIndex">How many entries of such a list to skip before answering, used together with `count` to walk through it page  by page. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-primary-external-link/">REST API Reference for GetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        public async Task<FileShareWrapper> GetFolderPrimaryExternalLinkAsync(int id, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetFolderPrimaryExternalLinkWithHttpInfoAsync(id, count, startIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the folder primary external link
        /// </summary>
        /// <remarks>
        /// Answers with the primary external link of a folder or a room - the one the Copy link action of a client  hands out - with its address in `sharedTo.shareLink`, its rights in `access`, and its title, expiration date,  password flag and download restriction beside them. The link is created on the first read if the folder has  none, with read rights, no password and no expiry, so this operation mutates on that first call and is a plain  read afterwards; repeated calls answer with the same link identifier. The caller needs the right to manage the  links of the room the folder belongs to, which its manager and a portal administrator acting as room manager  have; a member with read access alone is refused with 403 and an anonymous caller is rejected, while a link  that was deliberately revoked is answered with 404 rather than being recreated. The paging parameters are  accepted for compatibility and leave the single link answered here unchanged. Every external link of the same  folder is listed by `GET api/2.0/files/folder/{id}/links`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the operation addresses. A folder stored on the portal is numbered, while a folder in a  connected third-party account is named by an opaque string.</param>
        /// <param name="count">How many entries at most to answer with, in the operations of this folder that return a list; an operation  that answers with a single object is not affected by it. (optional)</param>
        /// <param name="startIndex">How many entries of such a list to skip before answering, used together with `count` to walk through it page  by page. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-primary-external-link/">REST API Reference for GetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        public async Task<ApiResponse<FileShareWrapper>> GetFolderPrimaryExternalLinkWithHttpInfoAsync(int id, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default)
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
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<FileShareWrapper>("/api/2.0/files/folder/{id}/link", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFolderPrimaryExternalLink", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get subfolders
        /// </summary>
        /// <remarks>
        /// Lists the folders that sit directly inside the folder named in the path, ordered by title, without their own  contents and without the files that lie beside them. The whole list arrives at once - there are no paging or  filtering parameters here - so for a large folder, or when the files are wanted as well, use  `GET api/2.0/files/{folderId}`, which pages and filters. A folder that holds no subfolders answers with an  empty list. The caller needs read access to the folder, and only the subfolders they may see are listed, so a  member of a room can get fewer entries than its manager; a caller without access is answered with 403, and a  folder that does not exist, or one that has been deleted for good, is answered as not found. The call is  read-only and leaves the new-item marks of the folder alone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folders/">REST API Reference for GetFolders Operation</seealso>
        /// <returns>FileEntryBaseArrayWrapper</returns>
        public FileEntryBaseArrayWrapper GetFolders(int folderId)
        {
            var localVarResponse = GetFoldersWithHttpInfo(folderId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get subfolders
        /// </summary>
        /// <remarks>
        /// Lists the folders that sit directly inside the folder named in the path, ordered by title, without their own  contents and without the files that lie beside them. The whole list arrives at once - there are no paging or  filtering parameters here - so for a large folder, or when the files are wanted as well, use  `GET api/2.0/files/{folderId}`, which pages and filters. A folder that holds no subfolders answers with an  empty list. The caller needs read access to the folder, and only the subfolders they may see are listed, so a  member of a room can get fewer entries than its manager; a caller without access is answered with 403, and a  folder that does not exist, or one that has been deleted for good, is answered as not found. The call is  read-only and leaves the new-item marks of the folder alone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folders/">REST API Reference for GetFolders Operation</seealso>
        /// <returns>ApiResponse of FileEntryBaseArrayWrapper</returns>
        public ApiResponse<FileEntryBaseArrayWrapper> GetFoldersWithHttpInfo(int folderId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter

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
            var localVarResponse = Client.Get<FileEntryBaseArrayWrapper>("/api/2.0/files/{folderId}/subfolders", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFolders", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get subfolders
        /// </summary>
        /// <remarks>
        /// Lists the folders that sit directly inside the folder named in the path, ordered by title, without their own  contents and without the files that lie beside them. The whole list arrives at once - there are no paging or  filtering parameters here - so for a large folder, or when the files are wanted as well, use  `GET api/2.0/files/{folderId}`, which pages and filters. A folder that holds no subfolders answers with an  empty list. The caller needs read access to the folder, and only the subfolders they may see are listed, so a  member of a room can get fewer entries than its manager; a caller without access is answered with 403, and a  folder that does not exist, or one that has been deleted for good, is answered as not found. The call is  read-only and leaves the new-item marks of the folder alone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folders/">REST API Reference for GetFolders Operation</seealso>
        /// <returns>Task of FileEntryBaseArrayWrapper</returns>
        public async Task<FileEntryBaseArrayWrapper> GetFoldersAsync(int folderId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetFoldersWithHttpInfoAsync(folderId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get subfolders
        /// </summary>
        /// <remarks>
        /// Lists the folders that sit directly inside the folder named in the path, ordered by title, without their own  contents and without the files that lie beside them. The whole list arrives at once - there are no paging or  filtering parameters here - so for a large folder, or when the files are wanted as well, use  `GET api/2.0/files/{folderId}`, which pages and filters. A folder that holds no subfolders answers with an  empty list. The caller needs read access to the folder, and only the subfolders they may see are listed, so a  member of a room can get fewer entries than its manager; a caller without access is answered with 403, and a  folder that does not exist, or one that has been deleted for good, is answered as not found. The call is  read-only and leaves the new-item marks of the folder alone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folders/">REST API Reference for GetFolders Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryBaseArrayWrapper)</returns>
        public async Task<ApiResponse<FileEntryBaseArrayWrapper>> GetFoldersWithHttpInfoAsync(int folderId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter

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

            var localVarResponse = await AsynchronousClient.GetAsync<FileEntryBaseArrayWrapper>("/api/2.0/files/{folderId}/subfolders", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFolders", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the Forms section
        /// </summary>
        /// <remarks>
        /// Returns the Forms section: the flat list of form-filling rooms the caller may read. Such rooms are stored  under the Rooms tree but are surfaced only here, so `GET api/2.0/files/rooms` leaves them out of the active  area and lists them when `searchArea` names the forms area instead. The section is not expanded into room  content, so `folders` carries the rooms while `files` comes back empty; to read what is inside one of them,  call `GET api/2.0/files/{folderId}` with the room identifier. Nothing is modified, though passing `sortBy`  saves the requested order as the default order for this account. `filterType`, `filterValue`,  `userIdOrGroupId` and the sorting parameters narrow and order the room list, `count` and `startIndex` page  through it, `total` reports how many rooms match the request in full, and `current` describes the section  folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the section unfiltered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-forms-folder/">REST API Reference for GetFormsFolder Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        public FolderContentIntegerWrapper GetFormsFolder(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarResponse = GetFormsFolderWithHttpInfo(userIdOrGroupId, filterType, count, startIndex, sortBy, sortOrder, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Forms section
        /// </summary>
        /// <remarks>
        /// Returns the Forms section: the flat list of form-filling rooms the caller may read. Such rooms are stored  under the Rooms tree but are surfaced only here, so `GET api/2.0/files/rooms` leaves them out of the active  area and lists them when `searchArea` names the forms area instead. The section is not expanded into room  content, so `folders` carries the rooms while `files` comes back empty; to read what is inside one of them,  call `GET api/2.0/files/{folderId}` with the room identifier. Nothing is modified, though passing `sortBy`  saves the requested order as the default order for this account. `filterType`, `filterValue`,  `userIdOrGroupId` and the sorting parameters narrow and order the room list, `count` and `startIndex` page  through it, `total` reports how many rooms match the request in full, and `current` describes the section  folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the section unfiltered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-forms-folder/">REST API Reference for GetFormsFolder Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        public ApiResponse<FolderContentIntegerWrapper> GetFormsFolderWithHttpInfo(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
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
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }
            if (_fields != null)
            {
                localVarRequestOptions.HeaderParameters.Add("fields", _fields); // header parameter
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
            var localVarResponse = Client.Get<FolderContentIntegerWrapper>("/api/2.0/files/@forms", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFormsFolder", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the Forms section
        /// </summary>
        /// <remarks>
        /// Returns the Forms section: the flat list of form-filling rooms the caller may read. Such rooms are stored  under the Rooms tree but are surfaced only here, so `GET api/2.0/files/rooms` leaves them out of the active  area and lists them when `searchArea` names the forms area instead. The section is not expanded into room  content, so `folders` carries the rooms while `files` comes back empty; to read what is inside one of them,  call `GET api/2.0/files/{folderId}` with the room identifier. Nothing is modified, though passing `sortBy`  saves the requested order as the default order for this account. `filterType`, `filterValue`,  `userIdOrGroupId` and the sorting parameters narrow and order the room list, `count` and `startIndex` page  through it, `total` reports how many rooms match the request in full, and `current` describes the section  folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the section unfiltered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-forms-folder/">REST API Reference for GetFormsFolder Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        public async Task<FolderContentIntegerWrapper> GetFormsFolderAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetFormsFolderWithHttpInfoAsync(userIdOrGroupId, filterType, count, startIndex, sortBy, sortOrder, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Forms section
        /// </summary>
        /// <remarks>
        /// Returns the Forms section: the flat list of form-filling rooms the caller may read. Such rooms are stored  under the Rooms tree but are surfaced only here, so `GET api/2.0/files/rooms` leaves them out of the active  area and lists them when `searchArea` names the forms area instead. The section is not expanded into room  content, so `folders` carries the rooms while `files` comes back empty; to read what is inside one of them,  call `GET api/2.0/files/{folderId}` with the room identifier. Nothing is modified, though passing `sortBy`  saves the requested order as the default order for this account. `filterType`, `filterValue`,  `userIdOrGroupId` and the sorting parameters narrow and order the room list, `count` and `startIndex` page  through it, `total` reports how many rooms match the request in full, and `current` describes the section  folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by: it is matched as a substring of entry titles and, for files,  against the indexed document content as well. Omit it to list the section unfiltered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-forms-folder/">REST API Reference for GetFormsFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderContentIntegerWrapper>> GetFormsFolderWithHttpInfoAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
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

            var localVarResponse = await AsynchronousClient.GetAsync<FolderContentIntegerWrapper>("/api/2.0/files/@forms", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFormsFolder", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the My documents section
        /// </summary>
        /// <remarks>
        /// Returns the contents of the caller's My documents section, the personal storage that belongs to this account  alone and stays invisible to other members until something in it is shared explicitly. Any authenticated  member that has a personal section can read it; guest accounts are not given one, and the call then answers  404. Nothing in the section is modified, though passing `sortBy` saves the requested order as the default  order for this account. Without a filter only the top level of the section is listed; as soon as `filterType`,  `userIdOrGroupId` or `filterValue` narrows the request, the search descends through the whole subtree.  `filterValue` is matched against titles and against indexed document content, and the index is written  asynchronously, so a file uploaded a moment ago can be missing from a search for a short while. `folders` and  `files` hold one page of the result, `total` counts everything that matches before `count` and `startIndex`  are applied, and `current` describes the section folder. To open a folder inside the section, call  `GET api/2.0/files/{folderId}` with its identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by, matched as a substring of entry titles. Omit it to list the  section unfiltered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-my-folder/">REST API Reference for GetMyFolder Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        public FolderContentIntegerWrapper GetMyFolder(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarResponse = GetMyFolderWithHttpInfo(userIdOrGroupId, filterType, applyFilterOption, count, startIndex, sortBy, sortOrder, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the My documents section
        /// </summary>
        /// <remarks>
        /// Returns the contents of the caller's My documents section, the personal storage that belongs to this account  alone and stays invisible to other members until something in it is shared explicitly. Any authenticated  member that has a personal section can read it; guest accounts are not given one, and the call then answers  404. Nothing in the section is modified, though passing `sortBy` saves the requested order as the default  order for this account. Without a filter only the top level of the section is listed; as soon as `filterType`,  `userIdOrGroupId` or `filterValue` narrows the request, the search descends through the whole subtree.  `filterValue` is matched against titles and against indexed document content, and the index is written  asynchronously, so a file uploaded a moment ago can be missing from a search for a short while. `folders` and  `files` hold one page of the result, `total` counts everything that matches before `count` and `startIndex`  are applied, and `current` describes the section folder. To open a folder inside the section, call  `GET api/2.0/files/{folderId}` with its identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by, matched as a substring of entry titles. Omit it to list the  section unfiltered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-my-folder/">REST API Reference for GetMyFolder Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        public ApiResponse<FolderContentIntegerWrapper> GetMyFolderWithHttpInfo(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
            }
            if (applyFilterOption != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "applyFilterOption", applyFilterOption));
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
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }
            if (_fields != null)
            {
                localVarRequestOptions.HeaderParameters.Add("fields", _fields); // header parameter
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
            var localVarResponse = Client.Get<FolderContentIntegerWrapper>("/api/2.0/files/@my", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetMyFolder", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the My documents section
        /// </summary>
        /// <remarks>
        /// Returns the contents of the caller's My documents section, the personal storage that belongs to this account  alone and stays invisible to other members until something in it is shared explicitly. Any authenticated  member that has a personal section can read it; guest accounts are not given one, and the call then answers  404. Nothing in the section is modified, though passing `sortBy` saves the requested order as the default  order for this account. Without a filter only the top level of the section is listed; as soon as `filterType`,  `userIdOrGroupId` or `filterValue` narrows the request, the search descends through the whole subtree.  `filterValue` is matched against titles and against indexed document content, and the index is written  asynchronously, so a file uploaded a moment ago can be missing from a search for a short while. `folders` and  `files` hold one page of the result, `total` counts everything that matches before `count` and `startIndex`  are applied, and `current` describes the section folder. To open a folder inside the section, call  `GET api/2.0/files/{folderId}` with its identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by, matched as a substring of entry titles. Omit it to list the  section unfiltered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-my-folder/">REST API Reference for GetMyFolder Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        public async Task<FolderContentIntegerWrapper> GetMyFolderAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetMyFolderWithHttpInfoAsync(userIdOrGroupId, filterType, applyFilterOption, count, startIndex, sortBy, sortOrder, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the My documents section
        /// </summary>
        /// <remarks>
        /// Returns the contents of the caller's My documents section, the personal storage that belongs to this account  alone and stays invisible to other members until something in it is shared explicitly. Any authenticated  member that has a personal section can read it; guest accounts are not given one, and the call then answers  404. Nothing in the section is modified, though passing `sortBy` saves the requested order as the default  order for this account. Without a filter only the top level of the section is listed; as soon as `filterType`,  `userIdOrGroupId` or `filterValue` narrows the request, the search descends through the whole subtree.  `filterValue` is matched against titles and against indexed document content, and the index is written  asynchronously, so a file uploaded a moment ago can be missing from a search for a short while. `folders` and  `files` hold one page of the result, `total` counts everything that matches before `count` and `startIndex`  are applied, and `current` describes the section folder. To open a folder inside the section, call  `GET api/2.0/files/{folderId}` with its identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by, matched as a substring of entry titles. Omit it to list the  section unfiltered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-my-folder/">REST API Reference for GetMyFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderContentIntegerWrapper>> GetMyFolderWithHttpInfoAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
            }
            if (applyFilterOption != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "applyFilterOption", applyFilterOption));
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

            var localVarResponse = await AsynchronousClient.GetAsync<FolderContentIntegerWrapper>("/api/2.0/files/@my", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetMyFolder", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get new folder items
        /// </summary>
        /// <remarks>
        /// Lists the entries of a folder that are new for the calling member - the files and folders created or changed  there since they last opened it - ordered from the most recently changed backwards. It is what the badge of a  room is filled from, and it is personal: two members of the same room get different answers. Reading this list  does not clear the marks, so the same entries come back until the folder itself is opened with  `GET api/2.0/files/{folderId}`, which does clear them. A folder with nothing new answers with an empty list,  and marks disappear on their own when the entry behind them is deleted or moved out of reach. The caller needs  read access to the folder and is otherwise answered with 403. The whole list arrives at once, without paging  or filtering, and the call is read-only.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-folder-items/">REST API Reference for GetNewFolderItems Operation</seealso>
        /// <returns>FileEntryBaseArrayWrapper</returns>
        public FileEntryBaseArrayWrapper GetNewFolderItems(int folderId)
        {
            var localVarResponse = GetNewFolderItemsWithHttpInfo(folderId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get new folder items
        /// </summary>
        /// <remarks>
        /// Lists the entries of a folder that are new for the calling member - the files and folders created or changed  there since they last opened it - ordered from the most recently changed backwards. It is what the badge of a  room is filled from, and it is personal: two members of the same room get different answers. Reading this list  does not clear the marks, so the same entries come back until the folder itself is opened with  `GET api/2.0/files/{folderId}`, which does clear them. A folder with nothing new answers with an empty list,  and marks disappear on their own when the entry behind them is deleted or moved out of reach. The caller needs  read access to the folder and is otherwise answered with 403. The whole list arrives at once, without paging  or filtering, and the call is read-only.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-folder-items/">REST API Reference for GetNewFolderItems Operation</seealso>
        /// <returns>ApiResponse of FileEntryBaseArrayWrapper</returns>
        public ApiResponse<FileEntryBaseArrayWrapper> GetNewFolderItemsWithHttpInfo(int folderId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter

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
            var localVarResponse = Client.Get<FileEntryBaseArrayWrapper>("/api/2.0/files/{folderId}/news", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetNewFolderItems", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get new folder items
        /// </summary>
        /// <remarks>
        /// Lists the entries of a folder that are new for the calling member - the files and folders created or changed  there since they last opened it - ordered from the most recently changed backwards. It is what the badge of a  room is filled from, and it is personal: two members of the same room get different answers. Reading this list  does not clear the marks, so the same entries come back until the folder itself is opened with  `GET api/2.0/files/{folderId}`, which does clear them. A folder with nothing new answers with an empty list,  and marks disappear on their own when the entry behind them is deleted or moved out of reach. The caller needs  read access to the folder and is otherwise answered with 403. The whole list arrives at once, without paging  or filtering, and the call is read-only.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-folder-items/">REST API Reference for GetNewFolderItems Operation</seealso>
        /// <returns>Task of FileEntryBaseArrayWrapper</returns>
        public async Task<FileEntryBaseArrayWrapper> GetNewFolderItemsAsync(int folderId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetNewFolderItemsWithHttpInfoAsync(folderId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get new folder items
        /// </summary>
        /// <remarks>
        /// Lists the entries of a folder that are new for the calling member - the files and folders created or changed  there since they last opened it - ordered from the most recently changed backwards. It is what the badge of a  room is filled from, and it is personal: two members of the same room get different answers. Reading this list  does not clear the marks, so the same entries come back until the folder itself is opened with  `GET api/2.0/files/{folderId}`, which does clear them. A folder with nothing new answers with an empty list,  and marks disappear on their own when the entry behind them is deleted or moved out of reach. The caller needs  read access to the folder and is otherwise answered with 403. The whole list arrives at once, without paging  or filtering, and the call is read-only.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the operation acts on. Take the identifier from a listing such as `GET api/2.0/files/@root` or  `GET api/2.0/files/{folderId}`: a folder stored in the portal is numbered, while a folder in a connected  third-party account is named by an opaque string.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-folder-items/">REST API Reference for GetNewFolderItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryBaseArrayWrapper)</returns>
        public async Task<ApiResponse<FileEntryBaseArrayWrapper>> GetNewFolderItemsWithHttpInfoAsync(int folderId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter

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

            var localVarResponse = await AsynchronousClient.GetAsync<FileEntryBaseArrayWrapper>("/api/2.0/files/{folderId}/news", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetNewFolderItems", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the Recent section
        /// </summary>
        /// <remarks>
        /// Returns the Recent section: the files the calling account has opened lately. The section holds files only,  so `folders` comes back empty, and it is personal, so another member's history is not visible here. A file is  added when it is opened and can also be added explicitly with `POST api/2.0/files/file/{fileId}/recent`;  `DELETE api/2.0/files/recent` clears the whole history, and `PUT api/2.0/files/displayrecent` switches the  section on and off for the account, which also decides whether `GET api/2.0/files/@root` includes it. Nothing  in the section is modified, though passing `sortBy` saves the requested order as the default order for this  account. The listing is ordered by the moment the caller last opened each file, newest first, and `sortBy` and  `sortOrder` do not change that order. `files` holds one page, `total` counts the files matching the request  before `count` and `startIndex` are applied, and `current` describes the section folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the files authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list the whole history. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of file, such as documents, spreadsheets or images. Omit it to list every  kind the history holds. (optional)</param>
        /// <param name="excludeSubject">Inverts `userIdOrGroupId`: with `true` the files of that member or group are the ones left out of the listing  instead of the only ones kept. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of a listing `filterType` and `filterValue` are applied to. The Recent section holds  files only, so the value does not change what comes back. (optional)</param>
        /// <param name="searchArea">The area a listing is taken from. The Recent section is assembled from the caller's own open history rather  than from an area, so the value does not change which files are returned. (optional)</param>
        /// <param name="extension">The file extensions the listing is limited to, matched against the end of the file name. The leading dot is  optional, and the parameter is repeated once per extension. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. The Recent section keeps its own newest-first order, so the value does not  reorder this listing. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. The Recent section keeps its own newest-first order, so the value does not reorder this  listing. (optional)</param>
        /// <param name="filterValue">The search string the history is filtered by: it is matched as a substring of file titles and against the  indexed document content as well. Omit it to list the whole history. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-recent-folder/">REST API Reference for GetRecentFolder Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        public FolderContentIntegerWrapper GetRecentFolder(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, SearchArea? searchArea = default, List<string>? extension = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarResponse = GetRecentFolderWithHttpInfo(userIdOrGroupId, filterType, excludeSubject, applyFilterOption, searchArea, extension, count, startIndex, sortBy, sortOrder, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Recent section
        /// </summary>
        /// <remarks>
        /// Returns the Recent section: the files the calling account has opened lately. The section holds files only,  so `folders` comes back empty, and it is personal, so another member's history is not visible here. A file is  added when it is opened and can also be added explicitly with `POST api/2.0/files/file/{fileId}/recent`;  `DELETE api/2.0/files/recent` clears the whole history, and `PUT api/2.0/files/displayrecent` switches the  section on and off for the account, which also decides whether `GET api/2.0/files/@root` includes it. Nothing  in the section is modified, though passing `sortBy` saves the requested order as the default order for this  account. The listing is ordered by the moment the caller last opened each file, newest first, and `sortBy` and  `sortOrder` do not change that order. `files` holds one page, `total` counts the files matching the request  before `count` and `startIndex` are applied, and `current` describes the section folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the files authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list the whole history. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of file, such as documents, spreadsheets or images. Omit it to list every  kind the history holds. (optional)</param>
        /// <param name="excludeSubject">Inverts `userIdOrGroupId`: with `true` the files of that member or group are the ones left out of the listing  instead of the only ones kept. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of a listing `filterType` and `filterValue` are applied to. The Recent section holds  files only, so the value does not change what comes back. (optional)</param>
        /// <param name="searchArea">The area a listing is taken from. The Recent section is assembled from the caller's own open history rather  than from an area, so the value does not change which files are returned. (optional)</param>
        /// <param name="extension">The file extensions the listing is limited to, matched against the end of the file name. The leading dot is  optional, and the parameter is repeated once per extension. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. The Recent section keeps its own newest-first order, so the value does not  reorder this listing. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. The Recent section keeps its own newest-first order, so the value does not reorder this  listing. (optional)</param>
        /// <param name="filterValue">The search string the history is filtered by: it is matched as a substring of file titles and against the  indexed document content as well. Omit it to list the whole history. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-recent-folder/">REST API Reference for GetRecentFolder Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        public ApiResponse<FolderContentIntegerWrapper> GetRecentFolderWithHttpInfo(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, SearchArea? searchArea = default, List<string>? extension = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
            }
            if (excludeSubject != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeSubject", excludeSubject));
            }
            if (applyFilterOption != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "applyFilterOption", applyFilterOption));
            }
            if (searchArea != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "searchArea", searchArea));
            }
            if (extension != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("multi", "extension", extension));
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
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }
            if (_fields != null)
            {
                localVarRequestOptions.HeaderParameters.Add("fields", _fields); // header parameter
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
            var recentPrefix = _useAtRecent ? "@" : "";
            var localVarResponse = Client.Get<FolderContentIntegerWrapper>(
                $"/api/2.0/files/{recentPrefix}recent",
                localVarRequestOptions,
                Configuration
            );
            _useAtRecent = false;

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRecentFolder", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the Recent section
        /// </summary>
        /// <remarks>
        /// Returns the Recent section: the files the calling account has opened lately. The section holds files only,  so `folders` comes back empty, and it is personal, so another member's history is not visible here. A file is  added when it is opened and can also be added explicitly with `POST api/2.0/files/file/{fileId}/recent`;  `DELETE api/2.0/files/recent` clears the whole history, and `PUT api/2.0/files/displayrecent` switches the  section on and off for the account, which also decides whether `GET api/2.0/files/@root` includes it. Nothing  in the section is modified, though passing `sortBy` saves the requested order as the default order for this  account. The listing is ordered by the moment the caller last opened each file, newest first, and `sortBy` and  `sortOrder` do not change that order. `files` holds one page, `total` counts the files matching the request  before `count` and `startIndex` are applied, and `current` describes the section folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the files authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list the whole history. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of file, such as documents, spreadsheets or images. Omit it to list every  kind the history holds. (optional)</param>
        /// <param name="excludeSubject">Inverts `userIdOrGroupId`: with `true` the files of that member or group are the ones left out of the listing  instead of the only ones kept. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of a listing `filterType` and `filterValue` are applied to. The Recent section holds  files only, so the value does not change what comes back. (optional)</param>
        /// <param name="searchArea">The area a listing is taken from. The Recent section is assembled from the caller's own open history rather  than from an area, so the value does not change which files are returned. (optional)</param>
        /// <param name="extension">The file extensions the listing is limited to, matched against the end of the file name. The leading dot is  optional, and the parameter is repeated once per extension. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. The Recent section keeps its own newest-first order, so the value does not  reorder this listing. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. The Recent section keeps its own newest-first order, so the value does not reorder this  listing. (optional)</param>
        /// <param name="filterValue">The search string the history is filtered by: it is matched as a substring of file titles and against the  indexed document content as well. Omit it to list the whole history. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-recent-folder/">REST API Reference for GetRecentFolder Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        public async Task<FolderContentIntegerWrapper> GetRecentFolderAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, SearchArea? searchArea = default, List<string>? extension = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetRecentFolderWithHttpInfoAsync(userIdOrGroupId, filterType, excludeSubject, applyFilterOption, searchArea, extension, count, startIndex, sortBy, sortOrder, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Recent section
        /// </summary>
        /// <remarks>
        /// Returns the Recent section: the files the calling account has opened lately. The section holds files only,  so `folders` comes back empty, and it is personal, so another member's history is not visible here. A file is  added when it is opened and can also be added explicitly with `POST api/2.0/files/file/{fileId}/recent`;  `DELETE api/2.0/files/recent` clears the whole history, and `PUT api/2.0/files/displayrecent` switches the  section on and off for the account, which also decides whether `GET api/2.0/files/@root` includes it. Nothing  in the section is modified, though passing `sortBy` saves the requested order as the default order for this  account. The listing is ordered by the moment the caller last opened each file, newest first, and `sortBy` and  `sortOrder` do not change that order. `files` holds one page, `total` counts the files matching the request  before `count` and `startIndex` are applied, and `current` describes the section folder itself.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the files authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list the whole history. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of file, such as documents, spreadsheets or images. Omit it to list every  kind the history holds. (optional)</param>
        /// <param name="excludeSubject">Inverts `userIdOrGroupId`: with `true` the files of that member or group are the ones left out of the listing  instead of the only ones kept. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of a listing `filterType` and `filterValue` are applied to. The Recent section holds  files only, so the value does not change what comes back. (optional)</param>
        /// <param name="searchArea">The area a listing is taken from. The Recent section is assembled from the caller's own open history rather  than from an area, so the value does not change which files are returned. (optional)</param>
        /// <param name="extension">The file extensions the listing is limited to, matched against the end of the file name. The leading dot is  optional, and the parameter is repeated once per extension. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. The Recent section keeps its own newest-first order, so the value does not  reorder this listing. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. The Recent section keeps its own newest-first order, so the value does not reorder this  listing. (optional)</param>
        /// <param name="filterValue">The search string the history is filtered by: it is matched as a substring of file titles and against the  indexed document content as well. Omit it to list the whole history. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-recent-folder/">REST API Reference for GetRecentFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderContentIntegerWrapper>> GetRecentFolderWithHttpInfoAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, SearchArea? searchArea = default, List<string>? extension = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
            }
            if (excludeSubject != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeSubject", excludeSubject));
            }
            if (applyFilterOption != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "applyFilterOption", applyFilterOption));
            }
            if (searchArea != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "searchArea", searchArea));
            }
            if (extension != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("multi", "extension", extension));
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

            var localVarResponse = await AsynchronousClient.GetAsync<FolderContentIntegerWrapper>("/api/2.0/files/recent", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRecentFolder", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the folder history report generation status
        /// </summary>
        /// <remarks>
        /// Reports how far the history report of a folder has got, and is the operation to poll after  `POST api/2.0/files/folder/{folderId}/log/report` has queued one. `percentage` climbs to 100, `isCompleted`  turns true when the job is over however it ended, `error` carries the reason when it failed, and  `resultFileId`, `resultFileName` and `resultFileUrl` name the file that was saved in the caller's My  documents - a CSV report leaving the identifier empty. An empty answer means there is no report for this  folder and caller, either because none was started or because a finished one has already been picked up by an  earlier poll. The caller needs read access to the folder and may not be a guest, and the portal plan has to  include the audit feature; a caller who fails the access rule is answered with 403 and a folder that does not  exist with 404. The call is read-only, and each caller sees only their own report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose history report is being polled. It is the folder that was              passed to the operation that started the report.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-report-folder-history/">REST API Reference for GetReportFolderHistory Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        public DocumentBuilderTaskWrapper GetReportFolderHistory(int folderId)
        {
            var localVarResponse = GetReportFolderHistoryWithHttpInfo(folderId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the folder history report generation status
        /// </summary>
        /// <remarks>
        /// Reports how far the history report of a folder has got, and is the operation to poll after  `POST api/2.0/files/folder/{folderId}/log/report` has queued one. `percentage` climbs to 100, `isCompleted`  turns true when the job is over however it ended, `error` carries the reason when it failed, and  `resultFileId`, `resultFileName` and `resultFileUrl` name the file that was saved in the caller's My  documents - a CSV report leaving the identifier empty. An empty answer means there is no report for this  folder and caller, either because none was started or because a finished one has already been picked up by an  earlier poll. The caller needs read access to the folder and may not be a guest, and the portal plan has to  include the audit feature; a caller who fails the access rule is answered with 403 and a folder that does not  exist with 404. The call is read-only, and each caller sees only their own report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose history report is being polled. It is the folder that was              passed to the operation that started the report.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-report-folder-history/">REST API Reference for GetReportFolderHistory Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        public ApiResponse<DocumentBuilderTaskWrapper> GetReportFolderHistoryWithHttpInfo(int folderId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter

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
            var localVarResponse = Client.Get<DocumentBuilderTaskWrapper>("/api/2.0/files/folder/{folderId}/log/report", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetReportFolderHistory", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the folder history report generation status
        /// </summary>
        /// <remarks>
        /// Reports how far the history report of a folder has got, and is the operation to poll after  `POST api/2.0/files/folder/{folderId}/log/report` has queued one. `percentage` climbs to 100, `isCompleted`  turns true when the job is over however it ended, `error` carries the reason when it failed, and  `resultFileId`, `resultFileName` and `resultFileUrl` name the file that was saved in the caller's My  documents - a CSV report leaving the identifier empty. An empty answer means there is no report for this  folder and caller, either because none was started or because a finished one has already been picked up by an  earlier poll. The caller needs read access to the folder and may not be a guest, and the portal plan has to  include the audit feature; a caller who fails the access rule is answered with 403 and a folder that does not  exist with 404. The call is read-only, and each caller sees only their own report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose history report is being polled. It is the folder that was              passed to the operation that started the report.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-report-folder-history/">REST API Reference for GetReportFolderHistory Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        public async Task<DocumentBuilderTaskWrapper> GetReportFolderHistoryAsync(int folderId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetReportFolderHistoryWithHttpInfoAsync(folderId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the folder history report generation status
        /// </summary>
        /// <remarks>
        /// Reports how far the history report of a folder has got, and is the operation to poll after  `POST api/2.0/files/folder/{folderId}/log/report` has queued one. `percentage` climbs to 100, `isCompleted`  turns true when the job is over however it ended, `error` carries the reason when it failed, and  `resultFileId`, `resultFileName` and `resultFileUrl` name the file that was saved in the caller's My  documents - a CSV report leaving the identifier empty. An empty answer means there is no report for this  folder and caller, either because none was started or because a finished one has already been picked up by an  earlier poll. The caller needs read access to the folder and may not be a guest, and the portal plan has to  include the audit feature; a caller who fails the access rule is answered with 403 and a folder that does not  exist with 404. The call is read-only, and each caller sees only their own report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose history report is being polled. It is the folder that was              passed to the operation that started the report.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-report-folder-history/">REST API Reference for GetReportFolderHistory Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        public async Task<ApiResponse<DocumentBuilderTaskWrapper>> GetReportFolderHistoryWithHttpInfoAsync(int folderId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter

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

            var localVarResponse = await AsynchronousClient.GetAsync<DocumentBuilderTaskWrapper>("/api/2.0/files/folder/{folderId}/log/report", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetReportFolderHistory", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get filtered sections
        /// </summary>
        /// <remarks>
        /// Returns every top-level section the calling account can see in one response, each of them a full section  object carrying its own first page of content: Favorites, Recent, Shared with me, My documents,  Trash, Rooms, Forms, Archive and, while AI access is enabled for the portal, AI agents. A section is  left out when the account has none of it, which is why a guest gets no personal section, and Recent is  listed only while it is switched on with `PUT api/2.0/files/displayrecent`. Pass `withoutTrash=true` to drop  the Trash section. The filters, `count` and `startIndex` are applied to each section separately, so  `count=1` returns one entry per section and every section reports its own `total`. Because it builds the  content of all of them, this is the most expensive listing in the module: when a single section is enough,  read it directly, for example with `GET api/2.0/files/@my`. The call modifies nothing in the sections and  leaves their new-item badges untouched, though passing `sortBy` saves the requested order as the default order  for this account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the content listed inside every returned section to a single kind of entry, such as documents, images  or one type of room. Omit it to list every kind the sections hold. (optional)</param>
        /// <param name="withoutTrash">Set it to `true` to leave the Trash section out of the returned set of sections; with `false`, or when the  parameter is omitted, the section is returned whenever the account has one of its own. (optional)</param>
        /// <param name="count">The size of the content page returned for each section separately, so a value of 1 yields one entry per  section rather than one entry in total. (optional)</param>
        /// <param name="startIndex">The number of matching entries skipped in each section before its page begins; add `count` to it to ask for  the next page of every section. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the content of every section is filtered by: it is matched as a substring of entry titles  and, for files, against the indexed document content as well. Omit it to list the sections unfiltered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-root-folders/">REST API Reference for GetRootFolders Operation</seealso>
        /// <returns>FolderContentIntegerArrayWrapper</returns>
        public FolderContentIntegerArrayWrapper GetRootFolders(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? withoutTrash = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarResponse = GetRootFoldersWithHttpInfo(userIdOrGroupId, filterType, withoutTrash, count, startIndex, sortBy, sortOrder, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get filtered sections
        /// </summary>
        /// <remarks>
        /// Returns every top-level section the calling account can see in one response, each of them a full section  object carrying its own first page of content: Favorites, Recent, Shared with me, My documents,  Trash, Rooms, Forms, Archive and, while AI access is enabled for the portal, AI agents. A section is  left out when the account has none of it, which is why a guest gets no personal section, and Recent is  listed only while it is switched on with `PUT api/2.0/files/displayrecent`. Pass `withoutTrash=true` to drop  the Trash section. The filters, `count` and `startIndex` are applied to each section separately, so  `count=1` returns one entry per section and every section reports its own `total`. Because it builds the  content of all of them, this is the most expensive listing in the module: when a single section is enough,  read it directly, for example with `GET api/2.0/files/@my`. The call modifies nothing in the sections and  leaves their new-item badges untouched, though passing `sortBy` saves the requested order as the default order  for this account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the content listed inside every returned section to a single kind of entry, such as documents, images  or one type of room. Omit it to list every kind the sections hold. (optional)</param>
        /// <param name="withoutTrash">Set it to `true` to leave the Trash section out of the returned set of sections; with `false`, or when the  parameter is omitted, the section is returned whenever the account has one of its own. (optional)</param>
        /// <param name="count">The size of the content page returned for each section separately, so a value of 1 yields one entry per  section rather than one entry in total. (optional)</param>
        /// <param name="startIndex">The number of matching entries skipped in each section before its page begins; add `count` to it to ask for  the next page of every section. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the content of every section is filtered by: it is matched as a substring of entry titles  and, for files, against the indexed document content as well. Omit it to list the sections unfiltered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-root-folders/">REST API Reference for GetRootFolders Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerArrayWrapper</returns>
        public ApiResponse<FolderContentIntegerArrayWrapper> GetRootFoldersWithHttpInfo(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? withoutTrash = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
            }
            if (withoutTrash != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "withoutTrash", withoutTrash));
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
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }
            if (_fields != null)
            {
                localVarRequestOptions.HeaderParameters.Add("fields", _fields); // header parameter
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
            var localVarResponse = Client.Get<FolderContentIntegerArrayWrapper>("/api/2.0/files/@root", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRootFolders", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get filtered sections
        /// </summary>
        /// <remarks>
        /// Returns every top-level section the calling account can see in one response, each of them a full section  object carrying its own first page of content: Favorites, Recent, Shared with me, My documents,  Trash, Rooms, Forms, Archive and, while AI access is enabled for the portal, AI agents. A section is  left out when the account has none of it, which is why a guest gets no personal section, and Recent is  listed only while it is switched on with `PUT api/2.0/files/displayrecent`. Pass `withoutTrash=true` to drop  the Trash section. The filters, `count` and `startIndex` are applied to each section separately, so  `count=1` returns one entry per section and every section reports its own `total`. Because it builds the  content of all of them, this is the most expensive listing in the module: when a single section is enough,  read it directly, for example with `GET api/2.0/files/@my`. The call modifies nothing in the sections and  leaves their new-item badges untouched, though passing `sortBy` saves the requested order as the default order  for this account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the content listed inside every returned section to a single kind of entry, such as documents, images  or one type of room. Omit it to list every kind the sections hold. (optional)</param>
        /// <param name="withoutTrash">Set it to `true` to leave the Trash section out of the returned set of sections; with `false`, or when the  parameter is omitted, the section is returned whenever the account has one of its own. (optional)</param>
        /// <param name="count">The size of the content page returned for each section separately, so a value of 1 yields one entry per  section rather than one entry in total. (optional)</param>
        /// <param name="startIndex">The number of matching entries skipped in each section before its page begins; add `count` to it to ask for  the next page of every section. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the content of every section is filtered by: it is matched as a substring of entry titles  and, for files, against the indexed document content as well. Omit it to list the sections unfiltered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-root-folders/">REST API Reference for GetRootFolders Operation</seealso>
        /// <returns>Task of FolderContentIntegerArrayWrapper</returns>
        public async Task<FolderContentIntegerArrayWrapper> GetRootFoldersAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? withoutTrash = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetRootFoldersWithHttpInfoAsync(userIdOrGroupId, filterType, withoutTrash, count, startIndex, sortBy, sortOrder, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get filtered sections
        /// </summary>
        /// <remarks>
        /// Returns every top-level section the calling account can see in one response, each of them a full section  object carrying its own first page of content: Favorites, Recent, Shared with me, My documents,  Trash, Rooms, Forms, Archive and, while AI access is enabled for the portal, AI agents. A section is  left out when the account has none of it, which is why a guest gets no personal section, and Recent is  listed only while it is switched on with `PUT api/2.0/files/displayrecent`. Pass `withoutTrash=true` to drop  the Trash section. The filters, `count` and `startIndex` are applied to each section separately, so  `count=1` returns one entry per section and every section reports its own `total`. Because it builds the  content of all of them, this is the most expensive listing in the module: when a single section is enough,  read it directly, for example with `GET api/2.0/files/@my`. The call modifies nothing in the sections and  leaves their new-item badges untouched, though passing `sortBy` saves the requested order as the default order  for this account.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the content listed inside every returned section to a single kind of entry, such as documents, images  or one type of room. Omit it to list every kind the sections hold. (optional)</param>
        /// <param name="withoutTrash">Set it to `true` to leave the Trash section out of the returned set of sections; with `false`, or when the  parameter is omitted, the section is returned whenever the account has one of its own. (optional)</param>
        /// <param name="count">The size of the content page returned for each section separately, so a value of 1 yields one entry per  section rather than one entry in total. (optional)</param>
        /// <param name="startIndex">The number of matching entries skipped in each section before its page begins; add `count` to it to ask for  the next page of every section. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the content of every section is filtered by: it is matched as a substring of entry titles  and, for files, against the indexed document content as well. Omit it to list the sections unfiltered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-root-folders/">REST API Reference for GetRootFolders Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerArrayWrapper)</returns>
        public async Task<ApiResponse<FolderContentIntegerArrayWrapper>> GetRootFoldersWithHttpInfoAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? withoutTrash = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
            }
            if (withoutTrash != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "withoutTrash", withoutTrash));
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

            var localVarResponse = await AsynchronousClient.GetAsync<FolderContentIntegerArrayWrapper>("/api/2.0/files/@root", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRootFolders", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the Trash section
        /// </summary>
        /// <remarks>
        /// Returns the caller's Trash section: the files and folders this account has deleted, kept there until they  are restored or discarded. Each member has a Trash of their own and sees only what they deleted themselves.  Restore an entry by moving it back with `PUT api/2.0/files/fileops/move`, or discard the whole section with  `PUT api/2.0/files/fileops/emptytrash`; both start a background operation that is polled through  `GET api/2.0/files/fileops`. This call itself modifies nothing, though passing `sortBy` saves the requested  order as the default order for this account. Only the top level of the section is listed, so the contents of a  deleted folder are not expanded into it, and `filterValue` is matched against titles alone here rather than  against document content. `folders` and `files` hold one page of the result, `total` counts everything that  matches before `count` and `startIndex` are applied, and `current` describes the section folder. An account  that is given no Trash of its own, an outsider for instance, receives 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by, matched as a substring of entry titles. Omit it to list the  section unfiltered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-trash-folder/">REST API Reference for GetTrashFolder Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        public FolderContentIntegerWrapper GetTrashFolder(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarResponse = GetTrashFolderWithHttpInfo(userIdOrGroupId, filterType, applyFilterOption, count, startIndex, sortBy, sortOrder, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Trash section
        /// </summary>
        /// <remarks>
        /// Returns the caller's Trash section: the files and folders this account has deleted, kept there until they  are restored or discarded. Each member has a Trash of their own and sees only what they deleted themselves.  Restore an entry by moving it back with `PUT api/2.0/files/fileops/move`, or discard the whole section with  `PUT api/2.0/files/fileops/emptytrash`; both start a background operation that is polled through  `GET api/2.0/files/fileops`. This call itself modifies nothing, though passing `sortBy` saves the requested  order as the default order for this account. Only the top level of the section is listed, so the contents of a  deleted folder are not expanded into it, and `filterValue` is matched against titles alone here rather than  against document content. `folders` and `files` hold one page of the result, `total` counts everything that  matches before `count` and `startIndex` are applied, and `current` describes the section folder. An account  that is given no Trash of its own, an outsider for instance, receives 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by, matched as a substring of entry titles. Omit it to list the  section unfiltered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-trash-folder/">REST API Reference for GetTrashFolder Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        public ApiResponse<FolderContentIntegerWrapper> GetTrashFolderWithHttpInfo(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
            }
            if (applyFilterOption != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "applyFilterOption", applyFilterOption));
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
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }
            if (_fields != null)
            {
                localVarRequestOptions.HeaderParameters.Add("fields", _fields); // header parameter
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
            var localVarResponse = Client.Get<FolderContentIntegerWrapper>("/api/2.0/files/@trash", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetTrashFolder", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the Trash section
        /// </summary>
        /// <remarks>
        /// Returns the caller's Trash section: the files and folders this account has deleted, kept there until they  are restored or discarded. Each member has a Trash of their own and sees only what they deleted themselves.  Restore an entry by moving it back with `PUT api/2.0/files/fileops/move`, or discard the whole section with  `PUT api/2.0/files/fileops/emptytrash`; both start a background operation that is polled through  `GET api/2.0/files/fileops`. This call itself modifies nothing, though passing `sortBy` saves the requested  order as the default order for this account. Only the top level of the section is listed, so the contents of a  deleted folder are not expanded into it, and `filterValue` is matched against titles alone here rather than  against document content. `folders` and `files` hold one page of the result, `total` counts everything that  matches before `count` and `startIndex` are applied, and `current` describes the section folder. An account  that is given no Trash of its own, an outsider for instance, receives 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by, matched as a substring of entry titles. Omit it to list the  section unfiltered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-trash-folder/">REST API Reference for GetTrashFolder Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        public async Task<FolderContentIntegerWrapper> GetTrashFolderAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetTrashFolderWithHttpInfoAsync(userIdOrGroupId, filterType, applyFilterOption, count, startIndex, sortBy, sortOrder, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Trash section
        /// </summary>
        /// <remarks>
        /// Returns the caller's Trash section: the files and folders this account has deleted, kept there until they  are restored or discarded. Each member has a Trash of their own and sees only what they deleted themselves.  Restore an entry by moving it back with `PUT api/2.0/files/fileops/move`, or discard the whole section with  `PUT api/2.0/files/fileops/emptytrash`; both start a background operation that is polled through  `GET api/2.0/files/fileops`. This call itself modifies nothing, though passing `sortBy` saves the requested  order as the default order for this account. Only the top level of the section is listed, so the contents of a  deleted folder are not expanded into it, and `filterValue` is matched against titles alone here rather than  against document content. `folders` and `files` hold one page of the result, `total` counts everything that  matches before `count` and `startIndex` are applied, and `current` describes the section folder. An account  that is given no Trash of its own, an outsider for instance, receives 404.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">Restricts the listing to the entries authored by this portal member, or by the members of this group; the same  parameter accepts either kind of identifier. Omit it to list everything the caller can read. (optional)</param>
        /// <param name="filterType">Narrows the listing to a single kind of entry, such as documents, images or one type of room. Omit it to list  every kind the section holds. (optional)</param>
        /// <param name="applyFilterOption">Chooses which half of the listing `filterType` and `filterValue` are applied to: with `Files` the folders come  back unfiltered, with `Folders` the files do, and with `All` both halves are filtered. (optional)</param>
        /// <param name="count">The size of one page of section content. Pair it with `startIndex` to walk the listing, and compare the two  with `total` in the response to see when the last page has been read. (optional)</param>
        /// <param name="startIndex">The number of matching entries to skip before the returned page begins; add `count` to it to ask for the next  page. (optional)</param>
        /// <param name="sortBy">The name of the field the entries are ordered by, matched case-insensitively against the file sort fields:  `DateAndTime`, `AZ`, `Size`, `Author`, `Type`, `New`, `DateAndTimeCreation`, `RoomType`, `Tags`, `Room`,  `CustomOrder`, `LastOpened` and `UsedSpace`. A recognized value is also saved as the default order of the  account and reused by later listings that omit the parameter, while a value matching none of the fields leaves  that saved order in place. (optional)</param>
        /// <param name="sortOrder">The direction in which the `sortBy` field is ordered. It is saved together with `sortBy` as the default order  of the account. (optional)</param>
        /// <param name="filterValue">The search string the section is filtered by, matched as a substring of entry titles. Omit it to list the  section unfiltered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-trash-folder/">REST API Reference for GetTrashFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderContentIntegerWrapper>> GetTrashFolderWithHttpInfoAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
            }
            if (applyFilterOption != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "applyFilterOption", applyFilterOption));
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

            var localVarResponse = await AsynchronousClient.GetAsync<FolderContentIntegerWrapper>("/api/2.0/files/@trash", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetTrashFolder", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Insert a file
        /// </summary>
        /// <remarks>
        /// Stores a file in the folder named by the path in a single request, taking its name from `title` rather than  from the uploaded part, which is what separates it from `POST api/2.0/files/{folderId}/upload`. The content  may arrive either as a multipart part or as the raw request body. The name is stripped of characters a title  cannot hold and truncated, and `createNewIfExist` settles the clash: false adds a new version to the file that  already carries the name, true keeps both by giving the new one a numeric suffix. The caller needs the right  to add content to the folder, so a reader, an editor and a guest get 403, a section root and an archived room  are refused as well, and an unknown folder gives 404. Formats the portal converts are converted afterwards in  the background; pass `keepConvertStatus` to keep the outcome readable through  `GET api/2.0/files/file/{fileId}/checkconversion`. The answer is the stored file. A large payload belongs in a  chunked session instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="insertFileFile">The content to store, sent as a `multipart/form-data` part. The same content may instead be sent as the raw  request body, which is what a client that cannot build a form does; when both are present the form part wins. (optional)</param>
        /// <param name="insertFileTitle">The name to store the file under, extension included. It wins over the name of the uploaded part, which is the  reason to choose this operation over the plain upload, and it is the only name available when the content  arrives as a raw body. Characters a title cannot hold are replaced with underscores and the name is cut to 170  characters before the file is stored. (optional)</param>
        /// <param name="insertFileCreateNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="insertFileKeepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="insertFileStreamCanRead"> (optional)</param>
        /// <param name="insertFileStreamCanWrite"> (optional)</param>
        /// <param name="insertFileStreamCanSeek"> (optional)</param>
        /// <param name="insertFileStreamCanTimeout"> (optional)</param>
        /// <param name="insertFileStreamLength"> (optional)</param>
        /// <param name="insertFileStreamPosition"> (optional)</param>
        /// <param name="insertFileStreamReadTimeout"> (optional)</param>
        /// <param name="insertFileStreamWriteTimeout"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file/">REST API Reference for InsertFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper InsertFile(int folderId, FileParameter? insertFileFile = default, string? insertFileTitle = default, bool? insertFileCreateNewIfExist = default, bool? insertFileKeepConvertStatus = default, bool? insertFileStreamCanRead = default, bool? insertFileStreamCanWrite = default, bool? insertFileStreamCanSeek = default, bool? insertFileStreamCanTimeout = default, long? insertFileStreamLength = default, long? insertFileStreamPosition = default, int? insertFileStreamReadTimeout = default, int? insertFileStreamWriteTimeout = default)
        {
            var localVarResponse = InsertFileWithHttpInfo(folderId, insertFileFile, insertFileTitle, insertFileCreateNewIfExist, insertFileKeepConvertStatus, insertFileStreamCanRead, insertFileStreamCanWrite, insertFileStreamCanSeek, insertFileStreamCanTimeout, insertFileStreamLength, insertFileStreamPosition, insertFileStreamReadTimeout, insertFileStreamWriteTimeout);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Insert a file
        /// </summary>
        /// <remarks>
        /// Stores a file in the folder named by the path in a single request, taking its name from `title` rather than  from the uploaded part, which is what separates it from `POST api/2.0/files/{folderId}/upload`. The content  may arrive either as a multipart part or as the raw request body. The name is stripped of characters a title  cannot hold and truncated, and `createNewIfExist` settles the clash: false adds a new version to the file that  already carries the name, true keeps both by giving the new one a numeric suffix. The caller needs the right  to add content to the folder, so a reader, an editor and a guest get 403, a section root and an archived room  are refused as well, and an unknown folder gives 404. Formats the portal converts are converted afterwards in  the background; pass `keepConvertStatus` to keep the outcome readable through  `GET api/2.0/files/file/{fileId}/checkconversion`. The answer is the stored file. A large payload belongs in a  chunked session instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="insertFileFile">The content to store, sent as a `multipart/form-data` part. The same content may instead be sent as the raw  request body, which is what a client that cannot build a form does; when both are present the form part wins. (optional)</param>
        /// <param name="insertFileTitle">The name to store the file under, extension included. It wins over the name of the uploaded part, which is the  reason to choose this operation over the plain upload, and it is the only name available when the content  arrives as a raw body. Characters a title cannot hold are replaced with underscores and the name is cut to 170  characters before the file is stored. (optional)</param>
        /// <param name="insertFileCreateNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="insertFileKeepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="insertFileStreamCanRead"> (optional)</param>
        /// <param name="insertFileStreamCanWrite"> (optional)</param>
        /// <param name="insertFileStreamCanSeek"> (optional)</param>
        /// <param name="insertFileStreamCanTimeout"> (optional)</param>
        /// <param name="insertFileStreamLength"> (optional)</param>
        /// <param name="insertFileStreamPosition"> (optional)</param>
        /// <param name="insertFileStreamReadTimeout"> (optional)</param>
        /// <param name="insertFileStreamWriteTimeout"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file/">REST API Reference for InsertFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> InsertFileWithHttpInfo(int folderId, FileParameter? insertFileFile = default, string? insertFileTitle = default, bool? insertFileCreateNewIfExist = default, bool? insertFileKeepConvertStatus = default, bool? insertFileStreamCanRead = default, bool? insertFileStreamCanWrite = default, bool? insertFileStreamCanSeek = default, bool? insertFileStreamCanTimeout = default, long? insertFileStreamLength = default, long? insertFileStreamPosition = default, int? insertFileStreamReadTimeout = default, int? insertFileStreamWriteTimeout = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (insertFileFile != null)
            {
                localVarRequestOptions.FileParameters.Add("InsertFile.File", insertFileFile);
            }
            if (insertFileTitle != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Title",ClientUtils.ParameterToString(insertFileTitle)); // form parameter
            }
            if (insertFileCreateNewIfExist != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.CreateNewIfExist",ClientUtils.ParameterToString(insertFileCreateNewIfExist)); // form parameter
            }
            if (insertFileKeepConvertStatus != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.KeepConvertStatus",ClientUtils.ParameterToString(insertFileKeepConvertStatus)); // form parameter
            }
            if (insertFileStreamCanRead != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.CanRead",ClientUtils.ParameterToString(insertFileStreamCanRead)); // form parameter
            }
            if (insertFileStreamCanWrite != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.CanWrite",ClientUtils.ParameterToString(insertFileStreamCanWrite)); // form parameter
            }
            if (insertFileStreamCanSeek != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.CanSeek",ClientUtils.ParameterToString(insertFileStreamCanSeek)); // form parameter
            }
            if (insertFileStreamCanTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.CanTimeout",ClientUtils.ParameterToString(insertFileStreamCanTimeout)); // form parameter
            }
            if (insertFileStreamLength != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.Length",ClientUtils.ParameterToString(insertFileStreamLength)); // form parameter
            }
            if (insertFileStreamPosition != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.Position",ClientUtils.ParameterToString(insertFileStreamPosition)); // form parameter
            }
            if (insertFileStreamReadTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.ReadTimeout",ClientUtils.ParameterToString(insertFileStreamReadTimeout)); // form parameter
            }
            if (insertFileStreamWriteTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.WriteTimeout",ClientUtils.ParameterToString(insertFileStreamWriteTimeout)); // form parameter
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
            var localVarResponse = Client.Post<FileIntegerWrapper>("/api/2.0/files/{folderId}/insert", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("InsertFile", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Insert a file
        /// </summary>
        /// <remarks>
        /// Stores a file in the folder named by the path in a single request, taking its name from `title` rather than  from the uploaded part, which is what separates it from `POST api/2.0/files/{folderId}/upload`. The content  may arrive either as a multipart part or as the raw request body. The name is stripped of characters a title  cannot hold and truncated, and `createNewIfExist` settles the clash: false adds a new version to the file that  already carries the name, true keeps both by giving the new one a numeric suffix. The caller needs the right  to add content to the folder, so a reader, an editor and a guest get 403, a section root and an archived room  are refused as well, and an unknown folder gives 404. Formats the portal converts are converted afterwards in  the background; pass `keepConvertStatus` to keep the outcome readable through  `GET api/2.0/files/file/{fileId}/checkconversion`. The answer is the stored file. A large payload belongs in a  chunked session instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="insertFileFile">The content to store, sent as a `multipart/form-data` part. The same content may instead be sent as the raw  request body, which is what a client that cannot build a form does; when both are present the form part wins. (optional)</param>
        /// <param name="insertFileTitle">The name to store the file under, extension included. It wins over the name of the uploaded part, which is the  reason to choose this operation over the plain upload, and it is the only name available when the content  arrives as a raw body. Characters a title cannot hold are replaced with underscores and the name is cut to 170  characters before the file is stored. (optional)</param>
        /// <param name="insertFileCreateNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="insertFileKeepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="insertFileStreamCanRead"> (optional)</param>
        /// <param name="insertFileStreamCanWrite"> (optional)</param>
        /// <param name="insertFileStreamCanSeek"> (optional)</param>
        /// <param name="insertFileStreamCanTimeout"> (optional)</param>
        /// <param name="insertFileStreamLength"> (optional)</param>
        /// <param name="insertFileStreamPosition"> (optional)</param>
        /// <param name="insertFileStreamReadTimeout"> (optional)</param>
        /// <param name="insertFileStreamWriteTimeout"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file/">REST API Reference for InsertFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async Task<FileIntegerWrapper> InsertFileAsync(int folderId, FileParameter? insertFileFile = default, string? insertFileTitle = default, bool? insertFileCreateNewIfExist = default, bool? insertFileKeepConvertStatus = default, bool? insertFileStreamCanRead = default, bool? insertFileStreamCanWrite = default, bool? insertFileStreamCanSeek = default, bool? insertFileStreamCanTimeout = default, long? insertFileStreamLength = default, long? insertFileStreamPosition = default, int? insertFileStreamReadTimeout = default, int? insertFileStreamWriteTimeout = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await InsertFileWithHttpInfoAsync(folderId, insertFileFile, insertFileTitle, insertFileCreateNewIfExist, insertFileKeepConvertStatus, insertFileStreamCanRead, insertFileStreamCanWrite, insertFileStreamCanSeek, insertFileStreamCanTimeout, insertFileStreamLength, insertFileStreamPosition, insertFileStreamReadTimeout, insertFileStreamWriteTimeout, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Insert a file
        /// </summary>
        /// <remarks>
        /// Stores a file in the folder named by the path in a single request, taking its name from `title` rather than  from the uploaded part, which is what separates it from `POST api/2.0/files/{folderId}/upload`. The content  may arrive either as a multipart part or as the raw request body. The name is stripped of characters a title  cannot hold and truncated, and `createNewIfExist` settles the clash: false adds a new version to the file that  already carries the name, true keeps both by giving the new one a numeric suffix. The caller needs the right  to add content to the folder, so a reader, an editor and a guest get 403, a section root and an archived room  are refused as well, and an unknown folder gives 404. Formats the portal converts are converted afterwards in  the background; pass `keepConvertStatus` to keep the outcome readable through  `GET api/2.0/files/file/{fileId}/checkconversion`. The answer is the stored file. A large payload belongs in a  chunked session instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="insertFileFile">The content to store, sent as a `multipart/form-data` part. The same content may instead be sent as the raw  request body, which is what a client that cannot build a form does; when both are present the form part wins. (optional)</param>
        /// <param name="insertFileTitle">The name to store the file under, extension included. It wins over the name of the uploaded part, which is the  reason to choose this operation over the plain upload, and it is the only name available when the content  arrives as a raw body. Characters a title cannot hold are replaced with underscores and the name is cut to 170  characters before the file is stored. (optional)</param>
        /// <param name="insertFileCreateNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="insertFileKeepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="insertFileStreamCanRead"> (optional)</param>
        /// <param name="insertFileStreamCanWrite"> (optional)</param>
        /// <param name="insertFileStreamCanSeek"> (optional)</param>
        /// <param name="insertFileStreamCanTimeout"> (optional)</param>
        /// <param name="insertFileStreamLength"> (optional)</param>
        /// <param name="insertFileStreamPosition"> (optional)</param>
        /// <param name="insertFileStreamReadTimeout"> (optional)</param>
        /// <param name="insertFileStreamWriteTimeout"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file/">REST API Reference for InsertFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async Task<ApiResponse<FileIntegerWrapper>> InsertFileWithHttpInfoAsync(int folderId, FileParameter? insertFileFile = default, string? insertFileTitle = default, bool? insertFileCreateNewIfExist = default, bool? insertFileKeepConvertStatus = default, bool? insertFileStreamCanRead = default, bool? insertFileStreamCanWrite = default, bool? insertFileStreamCanSeek = default, bool? insertFileStreamCanTimeout = default, long? insertFileStreamLength = default, long? insertFileStreamPosition = default, int? insertFileStreamReadTimeout = default, int? insertFileStreamWriteTimeout = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (insertFileFile != null)
            {
                localVarRequestOptions.FileParameters.Add("InsertFile.File", insertFileFile);
            }
            if (insertFileTitle != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Title", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(insertFileTitle)); // form parameter
            }
            if (insertFileCreateNewIfExist != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.CreateNewIfExist", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(insertFileCreateNewIfExist)); // form parameter
            }
            if (insertFileKeepConvertStatus != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.KeepConvertStatus", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(insertFileKeepConvertStatus)); // form parameter
            }
            if (insertFileStreamCanRead != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.CanRead", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(insertFileStreamCanRead)); // form parameter
            }
            if (insertFileStreamCanWrite != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.CanWrite", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(insertFileStreamCanWrite)); // form parameter
            }
            if (insertFileStreamCanSeek != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.CanSeek", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(insertFileStreamCanSeek)); // form parameter
            }
            if (insertFileStreamCanTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.CanTimeout", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(insertFileStreamCanTimeout)); // form parameter
            }
            if (insertFileStreamLength != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.Length", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(insertFileStreamLength)); // form parameter
            }
            if (insertFileStreamPosition != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.Position", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(insertFileStreamPosition)); // form parameter
            }
            if (insertFileStreamReadTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.ReadTimeout", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(insertFileStreamReadTimeout)); // form parameter
            }
            if (insertFileStreamWriteTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.WriteTimeout", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(insertFileStreamWriteTimeout)); // form parameter
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

            var localVarResponse = await AsynchronousClient.PostAsync<FileIntegerWrapper>("/api/2.0/files/{folderId}/insert", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("InsertFile", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Insert a file into My documents
        /// </summary>
        /// <remarks>
        /// Stores one file in the caller's own My documents section, the personal storage every portal member has, and  returns the stored file. The destination takes no identifier: it is resolved from the calling account and  created on first use, while a guest account has none and is answered as missing (404). Send the content as a  `multipart/form-data` part or as the raw request body, and name it with `title`, which wins over the name of  the uploaded part and has invalid characters replaced before storing. The call is not idempotent: by default a  file of the same title is overwritten as a new version, while `createNewIfExist=true` stores a separate copy  under a title made unique with a numeric suffix; a title held by a file that is locked or open in the editor  cannot be overwritten either, and a second file appears under the same title. Formats listed in  `extsMustConvert` of `GET api/2.0/files/settings` are converted after the response is sent;  `keepConvertStatus=true` keeps that result readable through `GET api/2.0/files/file/{fileId}/checkconversion`,  which otherwise drops it. Files over the single-request size limit or the account's storage quota are refused:  send those through `POST api/2.0/files/{folderId}/upload/create_session`, and use  `POST api/2.0/files/{folderId}/insert` for any other destination.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part. The same content may instead be sent as the raw  request body, which is what a client that cannot build a form does; when both are present the form part wins. (optional)</param>
        /// <param name="title">The name to store the file under, extension included. It wins over the name of the uploaded part, which is the  reason to choose this operation over the plain upload, and it is the only name available when the content  arrives as a raw body. Characters a title cannot hold are replaced with underscores and the name is cut to 170  characters before the file is stored. (optional)</param>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="streamCanRead"> (optional)</param>
        /// <param name="streamCanWrite"> (optional)</param>
        /// <param name="streamCanSeek"> (optional)</param>
        /// <param name="streamCanTimeout"> (optional)</param>
        /// <param name="streamLength"> (optional)</param>
        /// <param name="streamPosition"> (optional)</param>
        /// <param name="streamReadTimeout"> (optional)</param>
        /// <param name="streamWriteTimeout"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file-to-my-from-body/">REST API Reference for InsertFileToMyFromBody Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper InsertFileToMyFromBody(FileParameter? file = default, string? title = default, bool? createNewIfExist = default, bool? keepConvertStatus = default, bool? streamCanRead = default, bool? streamCanWrite = default, bool? streamCanSeek = default, bool? streamCanTimeout = default, long? streamLength = default, long? streamPosition = default, int? streamReadTimeout = default, int? streamWriteTimeout = default)
        {
            var localVarResponse = InsertFileToMyFromBodyWithHttpInfo(file, title, createNewIfExist, keepConvertStatus, streamCanRead, streamCanWrite, streamCanSeek, streamCanTimeout, streamLength, streamPosition, streamReadTimeout, streamWriteTimeout);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Insert a file into My documents
        /// </summary>
        /// <remarks>
        /// Stores one file in the caller's own My documents section, the personal storage every portal member has, and  returns the stored file. The destination takes no identifier: it is resolved from the calling account and  created on first use, while a guest account has none and is answered as missing (404). Send the content as a  `multipart/form-data` part or as the raw request body, and name it with `title`, which wins over the name of  the uploaded part and has invalid characters replaced before storing. The call is not idempotent: by default a  file of the same title is overwritten as a new version, while `createNewIfExist=true` stores a separate copy  under a title made unique with a numeric suffix; a title held by a file that is locked or open in the editor  cannot be overwritten either, and a second file appears under the same title. Formats listed in  `extsMustConvert` of `GET api/2.0/files/settings` are converted after the response is sent;  `keepConvertStatus=true` keeps that result readable through `GET api/2.0/files/file/{fileId}/checkconversion`,  which otherwise drops it. Files over the single-request size limit or the account's storage quota are refused:  send those through `POST api/2.0/files/{folderId}/upload/create_session`, and use  `POST api/2.0/files/{folderId}/insert` for any other destination.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part. The same content may instead be sent as the raw  request body, which is what a client that cannot build a form does; when both are present the form part wins. (optional)</param>
        /// <param name="title">The name to store the file under, extension included. It wins over the name of the uploaded part, which is the  reason to choose this operation over the plain upload, and it is the only name available when the content  arrives as a raw body. Characters a title cannot hold are replaced with underscores and the name is cut to 170  characters before the file is stored. (optional)</param>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="streamCanRead"> (optional)</param>
        /// <param name="streamCanWrite"> (optional)</param>
        /// <param name="streamCanSeek"> (optional)</param>
        /// <param name="streamCanTimeout"> (optional)</param>
        /// <param name="streamLength"> (optional)</param>
        /// <param name="streamPosition"> (optional)</param>
        /// <param name="streamReadTimeout"> (optional)</param>
        /// <param name="streamWriteTimeout"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file-to-my-from-body/">REST API Reference for InsertFileToMyFromBody Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> InsertFileToMyFromBodyWithHttpInfo(FileParameter? file = default, string? title = default, bool? createNewIfExist = default, bool? keepConvertStatus = default, bool? streamCanRead = default, bool? streamCanWrite = default, bool? streamCanSeek = default, bool? streamCanTimeout = default, long? streamLength = default, long? streamPosition = default, int? streamReadTimeout = default, int? streamWriteTimeout = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (file != null)
            {
                localVarRequestOptions.FileParameters.Add("File", file);
            }
            if (title != null)
            {
                localVarRequestOptions.FormParameters.Add("Title",ClientUtils.ParameterToString(title)); // form parameter
            }
            if (createNewIfExist != null)
            {
                localVarRequestOptions.FormParameters.Add("CreateNewIfExist",ClientUtils.ParameterToString(createNewIfExist)); // form parameter
            }
            if (keepConvertStatus != null)
            {
                localVarRequestOptions.FormParameters.Add("KeepConvertStatus",ClientUtils.ParameterToString(keepConvertStatus)); // form parameter
            }
            if (streamCanRead != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.CanRead",ClientUtils.ParameterToString(streamCanRead)); // form parameter
            }
            if (streamCanWrite != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.CanWrite",ClientUtils.ParameterToString(streamCanWrite)); // form parameter
            }
            if (streamCanSeek != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.CanSeek",ClientUtils.ParameterToString(streamCanSeek)); // form parameter
            }
            if (streamCanTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.CanTimeout",ClientUtils.ParameterToString(streamCanTimeout)); // form parameter
            }
            if (streamLength != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.Length",ClientUtils.ParameterToString(streamLength)); // form parameter
            }
            if (streamPosition != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.Position",ClientUtils.ParameterToString(streamPosition)); // form parameter
            }
            if (streamReadTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.ReadTimeout",ClientUtils.ParameterToString(streamReadTimeout)); // form parameter
            }
            if (streamWriteTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.WriteTimeout",ClientUtils.ParameterToString(streamWriteTimeout)); // form parameter
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
            var localVarResponse = Client.Post<FileIntegerWrapper>("/api/2.0/files/@my/insert", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("InsertFileToMyFromBody", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Insert a file into My documents
        /// </summary>
        /// <remarks>
        /// Stores one file in the caller's own My documents section, the personal storage every portal member has, and  returns the stored file. The destination takes no identifier: it is resolved from the calling account and  created on first use, while a guest account has none and is answered as missing (404). Send the content as a  `multipart/form-data` part or as the raw request body, and name it with `title`, which wins over the name of  the uploaded part and has invalid characters replaced before storing. The call is not idempotent: by default a  file of the same title is overwritten as a new version, while `createNewIfExist=true` stores a separate copy  under a title made unique with a numeric suffix; a title held by a file that is locked or open in the editor  cannot be overwritten either, and a second file appears under the same title. Formats listed in  `extsMustConvert` of `GET api/2.0/files/settings` are converted after the response is sent;  `keepConvertStatus=true` keeps that result readable through `GET api/2.0/files/file/{fileId}/checkconversion`,  which otherwise drops it. Files over the single-request size limit or the account's storage quota are refused:  send those through `POST api/2.0/files/{folderId}/upload/create_session`, and use  `POST api/2.0/files/{folderId}/insert` for any other destination.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part. The same content may instead be sent as the raw  request body, which is what a client that cannot build a form does; when both are present the form part wins. (optional)</param>
        /// <param name="title">The name to store the file under, extension included. It wins over the name of the uploaded part, which is the  reason to choose this operation over the plain upload, and it is the only name available when the content  arrives as a raw body. Characters a title cannot hold are replaced with underscores and the name is cut to 170  characters before the file is stored. (optional)</param>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="streamCanRead"> (optional)</param>
        /// <param name="streamCanWrite"> (optional)</param>
        /// <param name="streamCanSeek"> (optional)</param>
        /// <param name="streamCanTimeout"> (optional)</param>
        /// <param name="streamLength"> (optional)</param>
        /// <param name="streamPosition"> (optional)</param>
        /// <param name="streamReadTimeout"> (optional)</param>
        /// <param name="streamWriteTimeout"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file-to-my-from-body/">REST API Reference for InsertFileToMyFromBody Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async Task<FileIntegerWrapper> InsertFileToMyFromBodyAsync(FileParameter? file = default, string? title = default, bool? createNewIfExist = default, bool? keepConvertStatus = default, bool? streamCanRead = default, bool? streamCanWrite = default, bool? streamCanSeek = default, bool? streamCanTimeout = default, long? streamLength = default, long? streamPosition = default, int? streamReadTimeout = default, int? streamWriteTimeout = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await InsertFileToMyFromBodyWithHttpInfoAsync(file, title, createNewIfExist, keepConvertStatus, streamCanRead, streamCanWrite, streamCanSeek, streamCanTimeout, streamLength, streamPosition, streamReadTimeout, streamWriteTimeout, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Insert a file into My documents
        /// </summary>
        /// <remarks>
        /// Stores one file in the caller's own My documents section, the personal storage every portal member has, and  returns the stored file. The destination takes no identifier: it is resolved from the calling account and  created on first use, while a guest account has none and is answered as missing (404). Send the content as a  `multipart/form-data` part or as the raw request body, and name it with `title`, which wins over the name of  the uploaded part and has invalid characters replaced before storing. The call is not idempotent: by default a  file of the same title is overwritten as a new version, while `createNewIfExist=true` stores a separate copy  under a title made unique with a numeric suffix; a title held by a file that is locked or open in the editor  cannot be overwritten either, and a second file appears under the same title. Formats listed in  `extsMustConvert` of `GET api/2.0/files/settings` are converted after the response is sent;  `keepConvertStatus=true` keeps that result readable through `GET api/2.0/files/file/{fileId}/checkconversion`,  which otherwise drops it. Files over the single-request size limit or the account's storage quota are refused:  send those through `POST api/2.0/files/{folderId}/upload/create_session`, and use  `POST api/2.0/files/{folderId}/insert` for any other destination.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part. The same content may instead be sent as the raw  request body, which is what a client that cannot build a form does; when both are present the form part wins. (optional)</param>
        /// <param name="title">The name to store the file under, extension included. It wins over the name of the uploaded part, which is the  reason to choose this operation over the plain upload, and it is the only name available when the content  arrives as a raw body. Characters a title cannot hold are replaced with underscores and the name is cut to 170  characters before the file is stored. (optional)</param>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="streamCanRead"> (optional)</param>
        /// <param name="streamCanWrite"> (optional)</param>
        /// <param name="streamCanSeek"> (optional)</param>
        /// <param name="streamCanTimeout"> (optional)</param>
        /// <param name="streamLength"> (optional)</param>
        /// <param name="streamPosition"> (optional)</param>
        /// <param name="streamReadTimeout"> (optional)</param>
        /// <param name="streamWriteTimeout"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file-to-my-from-body/">REST API Reference for InsertFileToMyFromBody Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async Task<ApiResponse<FileIntegerWrapper>> InsertFileToMyFromBodyWithHttpInfoAsync(FileParameter? file = default, string? title = default, bool? createNewIfExist = default, bool? keepConvertStatus = default, bool? streamCanRead = default, bool? streamCanWrite = default, bool? streamCanSeek = default, bool? streamCanTimeout = default, long? streamLength = default, long? streamPosition = default, int? streamReadTimeout = default, int? streamWriteTimeout = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (file != null)
            {
                localVarRequestOptions.FileParameters.Add("File", file);
            }
            if (title != null)
            {
                localVarRequestOptions.FormParameters.Add("Title", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(title)); // form parameter
            }
            if (createNewIfExist != null)
            {
                localVarRequestOptions.FormParameters.Add("CreateNewIfExist", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(createNewIfExist)); // form parameter
            }
            if (keepConvertStatus != null)
            {
                localVarRequestOptions.FormParameters.Add("KeepConvertStatus", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(keepConvertStatus)); // form parameter
            }
            if (streamCanRead != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.CanRead", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(streamCanRead)); // form parameter
            }
            if (streamCanWrite != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.CanWrite", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(streamCanWrite)); // form parameter
            }
            if (streamCanSeek != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.CanSeek", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(streamCanSeek)); // form parameter
            }
            if (streamCanTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.CanTimeout", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(streamCanTimeout)); // form parameter
            }
            if (streamLength != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.Length", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(streamLength)); // form parameter
            }
            if (streamPosition != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.Position", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(streamPosition)); // form parameter
            }
            if (streamReadTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.ReadTimeout", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(streamReadTimeout)); // form parameter
            }
            if (streamWriteTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.WriteTimeout", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(streamWriteTimeout)); // form parameter
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

            var localVarResponse = await AsynchronousClient.PostAsync<FileIntegerWrapper>("/api/2.0/files/@my/insert", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("InsertFileToMyFromBody", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Rename a folder
        /// </summary>
        /// <remarks>
        /// Gives a folder a new title and answers with the folder as it now stands. The title is trimmed, may not be  blank and is refused when it is longer than the limit the schema prints; a title that matches the current one  leaves the folder untouched, and titles need not be unique among the neighbours. The caller needs the right to  rename the folder, which the room manager, a content creator acting on a folder of their own and the owner of  a personal section have, while a guest is refused with 403 whatever their access; a folder in the Trash  section or in an archived room cannot be renamed either, and a folder that does not exist is answered as  not found. A room may be renamed here as well, in which case the caller needs the right to edit the  room, and `PUT api/2.0/files/rooms/{id}` is the operation that changes its other settings. The call is  mutating and idempotent; on a folder stored in a connected third-party account the identifier of the folder  may change with the title.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the request is addressed to: when a folder is created it is the parent that receives the new  folder, and when a folder is renamed it is the folder that gets the new title.</param>
        /// <param name="createFolder">The title carried by the request body.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-folder/">REST API Reference for RenameFolder Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper RenameFolder(int folderId, CreateFolder createFolder)
        {
            var localVarResponse = RenameFolderWithHttpInfo(folderId, createFolder);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Rename a folder
        /// </summary>
        /// <remarks>
        /// Gives a folder a new title and answers with the folder as it now stands. The title is trimmed, may not be  blank and is refused when it is longer than the limit the schema prints; a title that matches the current one  leaves the folder untouched, and titles need not be unique among the neighbours. The caller needs the right to  rename the folder, which the room manager, a content creator acting on a folder of their own and the owner of  a personal section have, while a guest is refused with 403 whatever their access; a folder in the Trash  section or in an archived room cannot be renamed either, and a folder that does not exist is answered as  not found. A room may be renamed here as well, in which case the caller needs the right to edit the  room, and `PUT api/2.0/files/rooms/{id}` is the operation that changes its other settings. The call is  mutating and idempotent; on a folder stored in a connected third-party account the identifier of the folder  may change with the title.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the request is addressed to: when a folder is created it is the parent that receives the new  folder, and when a folder is renamed it is the folder that gets the new title.</param>
        /// <param name="createFolder">The title carried by the request body.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-folder/">REST API Reference for RenameFolder Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public ApiResponse<FolderIntegerWrapper> RenameFolderWithHttpInfo(int folderId, CreateFolder createFolder)
        {
            // verify the required parameter 'createFolder' is set
            if (createFolder == null)
                throw new ApiException(400, "Missing required parameter 'createFolder' when calling FoldersApi->RenameFolder");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (createFolder != null) localVarRequestOptions.Data = createFolder;

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
            var localVarResponse = Client.Put<FolderIntegerWrapper>("/api/2.0/files/folder/{folderId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RenameFolder", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Rename a folder
        /// </summary>
        /// <remarks>
        /// Gives a folder a new title and answers with the folder as it now stands. The title is trimmed, may not be  blank and is refused when it is longer than the limit the schema prints; a title that matches the current one  leaves the folder untouched, and titles need not be unique among the neighbours. The caller needs the right to  rename the folder, which the room manager, a content creator acting on a folder of their own and the owner of  a personal section have, while a guest is refused with 403 whatever their access; a folder in the Trash  section or in an archived room cannot be renamed either, and a folder that does not exist is answered as  not found. A room may be renamed here as well, in which case the caller needs the right to edit the  room, and `PUT api/2.0/files/rooms/{id}` is the operation that changes its other settings. The call is  mutating and idempotent; on a folder stored in a connected third-party account the identifier of the folder  may change with the title.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the request is addressed to: when a folder is created it is the parent that receives the new  folder, and when a folder is renamed it is the folder that gets the new title.</param>
        /// <param name="createFolder">The title carried by the request body.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-folder/">REST API Reference for RenameFolder Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async Task<FolderIntegerWrapper> RenameFolderAsync(int folderId, CreateFolder createFolder, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await RenameFolderWithHttpInfoAsync(folderId, createFolder, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Rename a folder
        /// </summary>
        /// <remarks>
        /// Gives a folder a new title and answers with the folder as it now stands. The title is trimmed, may not be  blank and is refused when it is longer than the limit the schema prints; a title that matches the current one  leaves the folder untouched, and titles need not be unique among the neighbours. The caller needs the right to  rename the folder, which the room manager, a content creator acting on a folder of their own and the owner of  a personal section have, while a guest is refused with 403 whatever their access; a folder in the Trash  section or in an archived room cannot be renamed either, and a folder that does not exist is answered as  not found. A room may be renamed here as well, in which case the caller needs the right to edit the  room, and `PUT api/2.0/files/rooms/{id}` is the operation that changes its other settings. The call is  mutating and idempotent; on a folder stored in a connected third-party account the identifier of the folder  may change with the title.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the request is addressed to: when a folder is created it is the parent that receives the new  folder, and when a folder is renamed it is the folder that gets the new title.</param>
        /// <param name="createFolder">The title carried by the request body.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-folder/">REST API Reference for RenameFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderIntegerWrapper>> RenameFolderWithHttpInfoAsync(int folderId, CreateFolder createFolder, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'createFolder' is set
            if (createFolder == null)
                throw new ApiException(400, "Missing required parameter 'createFolder' when calling FoldersApi->RenameFolder");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (createFolder != null) localVarRequestOptions.Data = createFolder;

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

            var localVarResponse = await AsynchronousClient.PutAsync<FolderIntegerWrapper>("/api/2.0/files/folder/{folderId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RenameFolder", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set folder order
        /// </summary>
        /// <remarks>
        /// Puts a folder at a given position among the entries of its parent and answers with the folder, its `order`  reporting where it now stands. Positions count from 1, and the entry that held the wanted position, together  with everything after it, is shifted to make room, so the numbering of the parent stays without gaps; a  position beyond the end places the folder last. The value may also be sent as a dotted path, as in 1.2.3, in  which case only its last segment is read. Ordering is what the manual arrangement of a room is built on, and  it only means something in rooms whose contents are indexed - elsewhere the value is stored and ignored. The  caller needs edit access to the folder, which room managers and content creators have, and a member without it  is refused, while a folder that does not exist is answered as not found. The call is mutating and idempotent.  To move several entries in one go use `PUT api/2.0/files/order`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder to move.</param>
        /// <param name="orderRequestDto">The position the folder is to take. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-order/">REST API Reference for SetFolderOrder Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper SetFolderOrder(int folderId, OrderRequestDto? orderRequestDto = default)
        {
            var localVarResponse = SetFolderOrderWithHttpInfo(folderId, orderRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set folder order
        /// </summary>
        /// <remarks>
        /// Puts a folder at a given position among the entries of its parent and answers with the folder, its `order`  reporting where it now stands. Positions count from 1, and the entry that held the wanted position, together  with everything after it, is shifted to make room, so the numbering of the parent stays without gaps; a  position beyond the end places the folder last. The value may also be sent as a dotted path, as in 1.2.3, in  which case only its last segment is read. Ordering is what the manual arrangement of a room is built on, and  it only means something in rooms whose contents are indexed - elsewhere the value is stored and ignored. The  caller needs edit access to the folder, which room managers and content creators have, and a member without it  is refused, while a folder that does not exist is answered as not found. The call is mutating and idempotent.  To move several entries in one go use `PUT api/2.0/files/order`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder to move.</param>
        /// <param name="orderRequestDto">The position the folder is to take. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-order/">REST API Reference for SetFolderOrder Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public ApiResponse<FolderIntegerWrapper> SetFolderOrderWithHttpInfo(int folderId, OrderRequestDto? orderRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (orderRequestDto != null) localVarRequestOptions.Data = orderRequestDto;

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
            var localVarResponse = Client.Put<FolderIntegerWrapper>("/api/2.0/files/folder/{folderId}/order", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetFolderOrder", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set folder order
        /// </summary>
        /// <remarks>
        /// Puts a folder at a given position among the entries of its parent and answers with the folder, its `order`  reporting where it now stands. Positions count from 1, and the entry that held the wanted position, together  with everything after it, is shifted to make room, so the numbering of the parent stays without gaps; a  position beyond the end places the folder last. The value may also be sent as a dotted path, as in 1.2.3, in  which case only its last segment is read. Ordering is what the manual arrangement of a room is built on, and  it only means something in rooms whose contents are indexed - elsewhere the value is stored and ignored. The  caller needs edit access to the folder, which room managers and content creators have, and a member without it  is refused, while a folder that does not exist is answered as not found. The call is mutating and idempotent.  To move several entries in one go use `PUT api/2.0/files/order`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder to move.</param>
        /// <param name="orderRequestDto">The position the folder is to take. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-order/">REST API Reference for SetFolderOrder Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async Task<FolderIntegerWrapper> SetFolderOrderAsync(int folderId, OrderRequestDto? orderRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetFolderOrderWithHttpInfoAsync(folderId, orderRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set folder order
        /// </summary>
        /// <remarks>
        /// Puts a folder at a given position among the entries of its parent and answers with the folder, its `order`  reporting where it now stands. Positions count from 1, and the entry that held the wanted position, together  with everything after it, is shifted to make room, so the numbering of the parent stays without gaps; a  position beyond the end places the folder last. The value may also be sent as a dotted path, as in 1.2.3, in  which case only its last segment is read. Ordering is what the manual arrangement of a room is built on, and  it only means something in rooms whose contents are indexed - elsewhere the value is stored and ignored. The  caller needs edit access to the folder, which room managers and content creators have, and a member without it  is refused, while a folder that does not exist is answered as not found. The call is mutating and idempotent.  To move several entries in one go use `PUT api/2.0/files/order`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder to move.</param>
        /// <param name="orderRequestDto">The position the folder is to take. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-order/">REST API Reference for SetFolderOrder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderIntegerWrapper>> SetFolderOrderWithHttpInfoAsync(int folderId, OrderRequestDto? orderRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (orderRequestDto != null) localVarRequestOptions.Data = orderRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<FolderIntegerWrapper>("/api/2.0/files/folder/{folderId}/order", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetFolderOrder", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the folder external link
        /// </summary>
        /// <remarks>
        /// Creates an external link to a folder or a room, or changes or revokes an existing one, and answers with the  link as it now stands. `linkId` decides which: an identifier that is not yet in use, the empty one included,  creates a link, while the identifier of an existing link rewrites it, so the whole set of parameters is  applied every time and a field left out is reset rather than kept. `access` carries the rights the link  grants, and `access` set to the value that denies everything revokes the link instead - the answer is then  empty, and a revoked primary link is not recreated by a later read. `title` names the link for the people who  manage it, `expirationDate` limits its lifetime and is ignored when it lies in the past, `password` asks  visitors for a secret, `denyDownload` leaves them with viewing only, `internal` admits signed-in members  alone, and `primary=true` makes it the primary link of the folder. The caller needs the right to manage the  links of the room, which its manager and a portal administrator acting as room manager have; anyone else is  refused and an unknown folder is answered as not found. The call is mutating.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the link belongs to.</param>
        /// <param name="folderLinkRequest">The link and the way it is to be shaped.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-primary-external-link/">REST API Reference for SetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        public FileShareWrapper SetFolderPrimaryExternalLink(int id, FolderLinkRequest folderLinkRequest)
        {
            var localVarResponse = SetFolderPrimaryExternalLinkWithHttpInfo(id, folderLinkRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the folder external link
        /// </summary>
        /// <remarks>
        /// Creates an external link to a folder or a room, or changes or revokes an existing one, and answers with the  link as it now stands. `linkId` decides which: an identifier that is not yet in use, the empty one included,  creates a link, while the identifier of an existing link rewrites it, so the whole set of parameters is  applied every time and a field left out is reset rather than kept. `access` carries the rights the link  grants, and `access` set to the value that denies everything revokes the link instead - the answer is then  empty, and a revoked primary link is not recreated by a later read. `title` names the link for the people who  manage it, `expirationDate` limits its lifetime and is ignored when it lies in the past, `password` asks  visitors for a secret, `denyDownload` leaves them with viewing only, `internal` admits signed-in members  alone, and `primary=true` makes it the primary link of the folder. The caller needs the right to manage the  links of the room, which its manager and a portal administrator acting as room manager have; anyone else is  refused and an unknown folder is answered as not found. The call is mutating.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the link belongs to.</param>
        /// <param name="folderLinkRequest">The link and the way it is to be shaped.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-primary-external-link/">REST API Reference for SetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        public ApiResponse<FileShareWrapper> SetFolderPrimaryExternalLinkWithHttpInfo(int id, FolderLinkRequest folderLinkRequest)
        {
            // verify the required parameter 'folderLinkRequest' is set
            if (folderLinkRequest == null)
                throw new ApiException(400, "Missing required parameter 'folderLinkRequest' when calling FoldersApi->SetFolderPrimaryExternalLink");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (folderLinkRequest != null) localVarRequestOptions.Data = folderLinkRequest;

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
            var localVarResponse = Client.Put<FileShareWrapper>("/api/2.0/files/folder/{id}/links", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetFolderPrimaryExternalLink", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the folder external link
        /// </summary>
        /// <remarks>
        /// Creates an external link to a folder or a room, or changes or revokes an existing one, and answers with the  link as it now stands. `linkId` decides which: an identifier that is not yet in use, the empty one included,  creates a link, while the identifier of an existing link rewrites it, so the whole set of parameters is  applied every time and a field left out is reset rather than kept. `access` carries the rights the link  grants, and `access` set to the value that denies everything revokes the link instead - the answer is then  empty, and a revoked primary link is not recreated by a later read. `title` names the link for the people who  manage it, `expirationDate` limits its lifetime and is ignored when it lies in the past, `password` asks  visitors for a secret, `denyDownload` leaves them with viewing only, `internal` admits signed-in members  alone, and `primary=true` makes it the primary link of the folder. The caller needs the right to manage the  links of the room, which its manager and a portal administrator acting as room manager have; anyone else is  refused and an unknown folder is answered as not found. The call is mutating.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the link belongs to.</param>
        /// <param name="folderLinkRequest">The link and the way it is to be shaped.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-primary-external-link/">REST API Reference for SetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        public async Task<FileShareWrapper> SetFolderPrimaryExternalLinkAsync(int id, FolderLinkRequest folderLinkRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetFolderPrimaryExternalLinkWithHttpInfoAsync(id, folderLinkRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the folder external link
        /// </summary>
        /// <remarks>
        /// Creates an external link to a folder or a room, or changes or revokes an existing one, and answers with the  link as it now stands. `linkId` decides which: an identifier that is not yet in use, the empty one included,  creates a link, while the identifier of an existing link rewrites it, so the whole set of parameters is  applied every time and a field left out is reset rather than kept. `access` carries the rights the link  grants, and `access` set to the value that denies everything revokes the link instead - the answer is then  empty, and a revoked primary link is not recreated by a later read. `title` names the link for the people who  manage it, `expirationDate` limits its lifetime and is ignored when it lies in the past, `password` asks  visitors for a secret, `denyDownload` leaves them with viewing only, `internal` admits signed-in members  alone, and `primary=true` makes it the primary link of the folder. The caller needs the right to manage the  links of the room, which its manager and a portal administrator acting as room manager have; anyone else is  refused and an unknown folder is answered as not found. The call is mutating.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder or room the link belongs to.</param>
        /// <param name="folderLinkRequest">The link and the way it is to be shaped.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-primary-external-link/">REST API Reference for SetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        public async Task<ApiResponse<FileShareWrapper>> SetFolderPrimaryExternalLinkWithHttpInfoAsync(int id, FolderLinkRequest folderLinkRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'folderLinkRequest' is set
            if (folderLinkRequest == null)
                throw new ApiException(400, "Missing required parameter 'folderLinkRequest' when calling FoldersApi->SetFolderPrimaryExternalLink");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (folderLinkRequest != null) localVarRequestOptions.Data = folderLinkRequest;

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

            var localVarResponse = await AsynchronousClient.PutAsync<FileShareWrapper>("/api/2.0/files/folder/{id}/links", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetFolderPrimaryExternalLink", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Terminate the folder history report generation
        /// </summary>
        /// <remarks>
        /// Gives up the history report the caller has started for a folder with  `POST api/2.0/files/folder/{folderId}/log/report`. The request only asks the background worker to stop, and  the answer carries no body, so a following `GET api/2.0/files/folder/{folderId}/log/report` is what shows the  task ending as cancelled. Asking to terminate when nothing is running is accepted and changes nothing, which  makes the call safe to repeat. A report that has already finished is not undone by this call and its file  stays in My documents. The caller needs read access to the folder and may not be a guest, and the portal  plan has to include the audit feature; a caller who fails the access rule is answered with 403 and a folder  that does not exist with 404. Each caller can only terminate their own report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose running history report is to be given up. It is the folder that              was passed to the operation that started the report.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-report-folder-history/">REST API Reference for TerminateReportFolderHistory Operation</seealso>
        /// <returns></returns>
        public void TerminateReportFolderHistory(int folderId)
        {
            TerminateReportFolderHistoryWithHttpInfo(folderId);
        }

        /// <summary>
        /// Terminate the folder history report generation
        /// </summary>
        /// <remarks>
        /// Gives up the history report the caller has started for a folder with  `POST api/2.0/files/folder/{folderId}/log/report`. The request only asks the background worker to stop, and  the answer carries no body, so a following `GET api/2.0/files/folder/{folderId}/log/report` is what shows the  task ending as cancelled. Asking to terminate when nothing is running is accepted and changes nothing, which  makes the call safe to repeat. A report that has already finished is not undone by this call and its file  stays in My documents. The caller needs read access to the folder and may not be a guest, and the portal  plan has to include the audit feature; a caller who fails the access rule is answered with 403 and a folder  that does not exist with 404. Each caller can only terminate their own report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose running history report is to be given up. It is the folder that              was passed to the operation that started the report.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-report-folder-history/">REST API Reference for TerminateReportFolderHistory Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TerminateReportFolderHistoryWithHttpInfo(int folderId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter

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
            var localVarResponse = Client.Delete<Object>("/api/2.0/files/folder/{folderId}/log/report", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("TerminateReportFolderHistory", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Terminate the folder history report generation
        /// </summary>
        /// <remarks>
        /// Gives up the history report the caller has started for a folder with  `POST api/2.0/files/folder/{folderId}/log/report`. The request only asks the background worker to stop, and  the answer carries no body, so a following `GET api/2.0/files/folder/{folderId}/log/report` is what shows the  task ending as cancelled. Asking to terminate when nothing is running is accepted and changes nothing, which  makes the call safe to repeat. A report that has already finished is not undone by this call and its file  stays in My documents. The caller needs read access to the folder and may not be a guest, and the portal  plan has to include the audit feature; a caller who fails the access rule is answered with 403 and a folder  that does not exist with 404. Each caller can only terminate their own report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose running history report is to be given up. It is the folder that              was passed to the operation that started the report.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-report-folder-history/">REST API Reference for TerminateReportFolderHistory Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task TerminateReportFolderHistoryAsync(int folderId, CancellationToken cancellationToken = default)
        {
            await TerminateReportFolderHistoryWithHttpInfoAsync(folderId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Terminate the folder history report generation
        /// </summary>
        /// <remarks>
        /// Gives up the history report the caller has started for a folder with  `POST api/2.0/files/folder/{folderId}/log/report`. The request only asks the background worker to stop, and  the answer carries no body, so a following `GET api/2.0/files/folder/{folderId}/log/report` is what shows the  task ending as cancelled. Asking to terminate when nothing is running is accepted and changes nothing, which  makes the call safe to repeat. A report that has already finished is not undone by this call and its file  stays in My documents. The caller needs read access to the folder and may not be a guest, and the portal  plan has to include the audit feature; a caller who fails the access rule is answered with 403 and a folder  that does not exist with 404. Each caller can only terminate their own report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder whose running history report is to be given up. It is the folder that              was passed to the operation that started the report.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-report-folder-history/">REST API Reference for TerminateReportFolderHistory Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> TerminateReportFolderHistoryWithHttpInfoAsync(int folderId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<Object>("/api/2.0/files/folder/{folderId}/log/report", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("TerminateReportFolderHistory", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Upload a file
        /// </summary>
        /// <remarks>
        /// Stores a file in the folder named by the path in a single multipart request, taking its name from the uploaded  part; use `POST api/2.0/files/{folderId}/insert` when the name has to be given separately or the content is  sent as a raw body. The answer is a list that always holds exactly one file. `createNewIfExist` settles the  clash: false adds a new version to the file that already carries the name, true keeps both by giving the new  one a numeric suffix. `storeOriginalFile` reaches further than this call, because it saves the setting on the  calling account, the same one `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later  uploads. The caller needs the right to add content to the folder, so a reader, an editor and a guest get 403,  a section root and an archived room are refused as well, and an unknown folder gives 404. A request without a  file is rejected as invalid, and a payload above the portal upload limit is refused.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="storeOriginalFile">Reaches further than this request: it writes a setting on the calling account, the same one  `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later uploads. True keeps both the  uploaded file and the copy the portal converts it into, false replaces the uploaded file with the converted  one, and leaving it out keeps whatever the account already has. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part; the name of that part becomes the title of the  stored file, with characters a title cannot hold replaced and the name cut to 170 characters. A request  without it is rejected as invalid. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file/">REST API Reference for UploadFile Operation</seealso>
        /// <returns>FileIntegerArrayWrapper</returns>
        public FileIntegerArrayWrapper UploadFile(int folderId, bool? createNewIfExist = default, bool? storeOriginalFile = default, bool? keepConvertStatus = default, FileParameter? file = default)
        {
            var localVarResponse = UploadFileWithHttpInfo(folderId, createNewIfExist, storeOriginalFile, keepConvertStatus, file);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Upload a file
        /// </summary>
        /// <remarks>
        /// Stores a file in the folder named by the path in a single multipart request, taking its name from the uploaded  part; use `POST api/2.0/files/{folderId}/insert` when the name has to be given separately or the content is  sent as a raw body. The answer is a list that always holds exactly one file. `createNewIfExist` settles the  clash: false adds a new version to the file that already carries the name, true keeps both by giving the new  one a numeric suffix. `storeOriginalFile` reaches further than this call, because it saves the setting on the  calling account, the same one `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later  uploads. The caller needs the right to add content to the folder, so a reader, an editor and a guest get 403,  a section root and an archived room are refused as well, and an unknown folder gives 404. A request without a  file is rejected as invalid, and a payload above the portal upload limit is refused.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="storeOriginalFile">Reaches further than this request: it writes a setting on the calling account, the same one  `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later uploads. True keeps both the  uploaded file and the copy the portal converts it into, false replaces the uploaded file with the converted  one, and leaving it out keeps whatever the account already has. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part; the name of that part becomes the title of the  stored file, with characters a title cannot hold replaced and the name cut to 170 characters. A request  without it is rejected as invalid. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file/">REST API Reference for UploadFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerArrayWrapper</returns>
        public ApiResponse<FileIntegerArrayWrapper> UploadFileWithHttpInfo(int folderId, bool? createNewIfExist = default, bool? storeOriginalFile = default, bool? keepConvertStatus = default, FileParameter? file = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (createNewIfExist != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "createNewIfExist", createNewIfExist));
            }
            if (storeOriginalFile != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "storeOriginalFile", storeOriginalFile));
            }
            if (keepConvertStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "keepConvertStatus", keepConvertStatus));
            }
            if (file != null)
            {
                localVarRequestOptions.FileParameters.Add("File", file);
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
            var localVarResponse = Client.Post<FileIntegerArrayWrapper>("/api/2.0/files/{folderId}/upload", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UploadFile", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Upload a file
        /// </summary>
        /// <remarks>
        /// Stores a file in the folder named by the path in a single multipart request, taking its name from the uploaded  part; use `POST api/2.0/files/{folderId}/insert` when the name has to be given separately or the content is  sent as a raw body. The answer is a list that always holds exactly one file. `createNewIfExist` settles the  clash: false adds a new version to the file that already carries the name, true keeps both by giving the new  one a numeric suffix. `storeOriginalFile` reaches further than this call, because it saves the setting on the  calling account, the same one `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later  uploads. The caller needs the right to add content to the folder, so a reader, an editor and a guest get 403,  a section root and an archived room are refused as well, and an unknown folder gives 404. A request without a  file is rejected as invalid, and a payload above the portal upload limit is refused.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="storeOriginalFile">Reaches further than this request: it writes a setting on the calling account, the same one  `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later uploads. True keeps both the  uploaded file and the copy the portal converts it into, false replaces the uploaded file with the converted  one, and leaving it out keeps whatever the account already has. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part; the name of that part becomes the title of the  stored file, with characters a title cannot hold replaced and the name cut to 170 characters. A request  without it is rejected as invalid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file/">REST API Reference for UploadFile Operation</seealso>
        /// <returns>Task of FileIntegerArrayWrapper</returns>
        public async Task<FileIntegerArrayWrapper> UploadFileAsync(int folderId, bool? createNewIfExist = default, bool? storeOriginalFile = default, bool? keepConvertStatus = default, FileParameter? file = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UploadFileWithHttpInfoAsync(folderId, createNewIfExist, storeOriginalFile, keepConvertStatus, file, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Upload a file
        /// </summary>
        /// <remarks>
        /// Stores a file in the folder named by the path in a single multipart request, taking its name from the uploaded  part; use `POST api/2.0/files/{folderId}/insert` when the name has to be given separately or the content is  sent as a raw body. The answer is a list that always holds exactly one file. `createNewIfExist` settles the  clash: false adds a new version to the file that already carries the name, true keeps both by giving the new  one a numeric suffix. `storeOriginalFile` reaches further than this call, because it saves the setting on the  calling account, the same one `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later  uploads. The caller needs the right to add content to the folder, so a reader, an editor and a guest get 403,  a section root and an archived room are refused as well, and an unknown folder gives 404. A request without a  file is rejected as invalid, and a payload above the portal upload limit is refused.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="storeOriginalFile">Reaches further than this request: it writes a setting on the calling account, the same one  `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later uploads. True keeps both the  uploaded file and the copy the portal converts it into, false replaces the uploaded file with the converted  one, and leaving it out keeps whatever the account already has. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part; the name of that part becomes the title of the  stored file, with characters a title cannot hold replaced and the name cut to 170 characters. A request  without it is rejected as invalid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file/">REST API Reference for UploadFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerArrayWrapper)</returns>
        public async Task<ApiResponse<FileIntegerArrayWrapper>> UploadFileWithHttpInfoAsync(int folderId, bool? createNewIfExist = default, bool? storeOriginalFile = default, bool? keepConvertStatus = default, FileParameter? file = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (createNewIfExist != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "createNewIfExist", createNewIfExist));
            }
            if (storeOriginalFile != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "storeOriginalFile", storeOriginalFile));
            }
            if (keepConvertStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "keepConvertStatus", keepConvertStatus));
            }
            if (file != null)
            {
                localVarRequestOptions.FileParameters.Add("File", file);
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

            var localVarResponse = await AsynchronousClient.PostAsync<FileIntegerArrayWrapper>("/api/2.0/files/{folderId}/upload", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UploadFile", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Upload a file to My documents
        /// </summary>
        /// <remarks>
        /// Uploads one file into the caller's own My documents section and returns it inside a single-element array; one  request stores exactly one file. The destination takes no identifier: it is resolved from the calling account  and created on first use, while a guest account has none and is answered as missing (404). The body has to be  `multipart/form-data` carrying the file part; a request without it is rejected as invalid, and the stored name  comes from that part, since unlike `POST api/2.0/files/@my/insert` there is no separate title. The call is not  idempotent: by default a file of the same title is overwritten as a new version, while `createNewIfExist=true`  stores a separate copy under a title made unique with a numeric suffix. `storeOriginalFile` is not a  per-request switch: it writes the same account setting as `PUT api/2.0/files/storeoriginal`, which decides  what happens to the formats listed in `extsMustConvert` of `GET api/2.0/files/settings` when they are  converted after the response - false replaces the uploaded file with the converted one, true keeps both;  `keepConvertStatus=true` keeps that conversion result readable through  `GET api/2.0/files/file/{fileId}/checkconversion`. Files over the single-request size limit or the account's  storage quota are refused; send those through `POST api/2.0/files/{folderId}/upload/create_session`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="storeOriginalFile">Reaches further than this request: it writes a setting on the calling account, the same one  `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later uploads. True keeps both the  uploaded file and the copy the portal converts it into, false replaces the uploaded file with the converted  one, and leaving it out keeps whatever the account already has. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part; the name of that part becomes the title of the  stored file, with characters a title cannot hold replaced and the name cut to 170 characters. A request  without it is rejected as invalid. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file-to-my/">REST API Reference for UploadFileToMy Operation</seealso>
        /// <returns>FileIntegerArrayWrapper</returns>
        public FileIntegerArrayWrapper UploadFileToMy(bool? createNewIfExist = default, bool? storeOriginalFile = default, bool? keepConvertStatus = default, FileParameter? file = default)
        {
            var localVarResponse = UploadFileToMyWithHttpInfo(createNewIfExist, storeOriginalFile, keepConvertStatus, file);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Upload a file to My documents
        /// </summary>
        /// <remarks>
        /// Uploads one file into the caller's own My documents section and returns it inside a single-element array; one  request stores exactly one file. The destination takes no identifier: it is resolved from the calling account  and created on first use, while a guest account has none and is answered as missing (404). The body has to be  `multipart/form-data` carrying the file part; a request without it is rejected as invalid, and the stored name  comes from that part, since unlike `POST api/2.0/files/@my/insert` there is no separate title. The call is not  idempotent: by default a file of the same title is overwritten as a new version, while `createNewIfExist=true`  stores a separate copy under a title made unique with a numeric suffix. `storeOriginalFile` is not a  per-request switch: it writes the same account setting as `PUT api/2.0/files/storeoriginal`, which decides  what happens to the formats listed in `extsMustConvert` of `GET api/2.0/files/settings` when they are  converted after the response - false replaces the uploaded file with the converted one, true keeps both;  `keepConvertStatus=true` keeps that conversion result readable through  `GET api/2.0/files/file/{fileId}/checkconversion`. Files over the single-request size limit or the account's  storage quota are refused; send those through `POST api/2.0/files/{folderId}/upload/create_session`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="storeOriginalFile">Reaches further than this request: it writes a setting on the calling account, the same one  `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later uploads. True keeps both the  uploaded file and the copy the portal converts it into, false replaces the uploaded file with the converted  one, and leaving it out keeps whatever the account already has. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part; the name of that part becomes the title of the  stored file, with characters a title cannot hold replaced and the name cut to 170 characters. A request  without it is rejected as invalid. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file-to-my/">REST API Reference for UploadFileToMy Operation</seealso>
        /// <returns>ApiResponse of FileIntegerArrayWrapper</returns>
        public ApiResponse<FileIntegerArrayWrapper> UploadFileToMyWithHttpInfo(bool? createNewIfExist = default, bool? storeOriginalFile = default, bool? keepConvertStatus = default, FileParameter? file = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createNewIfExist != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "createNewIfExist", createNewIfExist));
            }
            if (storeOriginalFile != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "storeOriginalFile", storeOriginalFile));
            }
            if (keepConvertStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "keepConvertStatus", keepConvertStatus));
            }
            if (file != null)
            {
                localVarRequestOptions.FileParameters.Add("File", file);
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
            var localVarResponse = Client.Post<FileIntegerArrayWrapper>("/api/2.0/files/@my/upload", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UploadFileToMy", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Upload a file to My documents
        /// </summary>
        /// <remarks>
        /// Uploads one file into the caller's own My documents section and returns it inside a single-element array; one  request stores exactly one file. The destination takes no identifier: it is resolved from the calling account  and created on first use, while a guest account has none and is answered as missing (404). The body has to be  `multipart/form-data` carrying the file part; a request without it is rejected as invalid, and the stored name  comes from that part, since unlike `POST api/2.0/files/@my/insert` there is no separate title. The call is not  idempotent: by default a file of the same title is overwritten as a new version, while `createNewIfExist=true`  stores a separate copy under a title made unique with a numeric suffix. `storeOriginalFile` is not a  per-request switch: it writes the same account setting as `PUT api/2.0/files/storeoriginal`, which decides  what happens to the formats listed in `extsMustConvert` of `GET api/2.0/files/settings` when they are  converted after the response - false replaces the uploaded file with the converted one, true keeps both;  `keepConvertStatus=true` keeps that conversion result readable through  `GET api/2.0/files/file/{fileId}/checkconversion`. Files over the single-request size limit or the account's  storage quota are refused; send those through `POST api/2.0/files/{folderId}/upload/create_session`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="storeOriginalFile">Reaches further than this request: it writes a setting on the calling account, the same one  `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later uploads. True keeps both the  uploaded file and the copy the portal converts it into, false replaces the uploaded file with the converted  one, and leaving it out keeps whatever the account already has. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part; the name of that part becomes the title of the  stored file, with characters a title cannot hold replaced and the name cut to 170 characters. A request  without it is rejected as invalid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file-to-my/">REST API Reference for UploadFileToMy Operation</seealso>
        /// <returns>Task of FileIntegerArrayWrapper</returns>
        public async Task<FileIntegerArrayWrapper> UploadFileToMyAsync(bool? createNewIfExist = default, bool? storeOriginalFile = default, bool? keepConvertStatus = default, FileParameter? file = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UploadFileToMyWithHttpInfoAsync(createNewIfExist, storeOriginalFile, keepConvertStatus, file, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Upload a file to My documents
        /// </summary>
        /// <remarks>
        /// Uploads one file into the caller's own My documents section and returns it inside a single-element array; one  request stores exactly one file. The destination takes no identifier: it is resolved from the calling account  and created on first use, while a guest account has none and is answered as missing (404). The body has to be  `multipart/form-data` carrying the file part; a request without it is rejected as invalid, and the stored name  comes from that part, since unlike `POST api/2.0/files/@my/insert` there is no separate title. The call is not  idempotent: by default a file of the same title is overwritten as a new version, while `createNewIfExist=true`  stores a separate copy under a title made unique with a numeric suffix. `storeOriginalFile` is not a  per-request switch: it writes the same account setting as `PUT api/2.0/files/storeoriginal`, which decides  what happens to the formats listed in `extsMustConvert` of `GET api/2.0/files/settings` when they are  converted after the response - false replaces the uploaded file with the converted one, true keeps both;  `keepConvertStatus=true` keeps that conversion result readable through  `GET api/2.0/files/file/{fileId}/checkconversion`. Files over the single-request size limit or the account's  storage quota are refused; send those through `POST api/2.0/files/{folderId}/upload/create_session`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createNewIfExist">Settles the clash with a file already carrying that title: left out, the content is written as the next  version of that file; set to true, both survive and the new one gets a numeric suffix in its title. (optional)</param>
        /// <param name="storeOriginalFile">Reaches further than this request: it writes a setting on the calling account, the same one  `PUT api/2.0/files/storeoriginal` writes, and it stays in force for later uploads. True keeps both the  uploaded file and the copy the portal converts it into, false replaces the uploaded file with the converted  one, and leaving it out keeps whatever the account already has. (optional)</param>
        /// <param name="keepConvertStatus">Decides whether the outcome of the background conversion outlives the conversion itself. True keeps the queue  record, so `GET api/2.0/files/file/{fileId}/checkconversion` can still report the result or the error; left  out, the record is cleared the moment the conversion ends and that call finds nothing. (optional)</param>
        /// <param name="file">The content to store, sent as a `multipart/form-data` part; the name of that part becomes the title of the  stored file, with characters a title cannot hold replaced and the name cut to 170 characters. A request  without it is rejected as invalid. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file-to-my/">REST API Reference for UploadFileToMy Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerArrayWrapper)</returns>
        public async Task<ApiResponse<FileIntegerArrayWrapper>> UploadFileToMyWithHttpInfoAsync(bool? createNewIfExist = default, bool? storeOriginalFile = default, bool? keepConvertStatus = default, FileParameter? file = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createNewIfExist != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "createNewIfExist", createNewIfExist));
            }
            if (storeOriginalFile != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "storeOriginalFile", storeOriginalFile));
            }
            if (keepConvertStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "keepConvertStatus", keepConvertStatus));
            }
            if (file != null)
            {
                localVarRequestOptions.FileParameters.Add("File", file);
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

            var localVarResponse = await AsynchronousClient.PostAsync<FileIntegerArrayWrapper>("/api/2.0/files/@my/upload", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UploadFileToMy", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
