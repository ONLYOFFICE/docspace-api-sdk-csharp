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
    public interface IOperationsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Abort an upload session
        /// </summary>
        /// <remarks>
        /// Cancels a chunked upload opened with `POST api/2.0/files/{folderId}/session` and discards the parts already  received, so nothing of it reaches the folder. The session is found by the id in the path alone: the folder  segment is not matched against it, and neither is the account that opened it, which makes the id the only  secret protecting the transfer. The call is destructive and is not safe to repeat, because the record is gone  afterwards: a second attempt, a session already closed by  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize` and a session that expired after twelve hours of  silence all fail rather than answer as missing. Finalizing removes the session too, so there is nothing left  to abort once the file exists. The answer carries no body. An upload that is simply abandoned needs no call at  all, since the session and its buffered parts are dropped when it expires.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session to cancel, as returned in `id` when it was created: a 32-character hexadecimal string that  identifies the session on its own.</param>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/abort-upload-session/">REST API Reference for AbortUploadSession Operation</seealso>
        /// <returns></returns>
        void AbortUploadSession(string sessionId, int folderId);

        /// <summary>
        /// Abort an upload session
        /// </summary>
        /// <remarks>
        /// Cancels a chunked upload opened with `POST api/2.0/files/{folderId}/session` and discards the parts already  received, so nothing of it reaches the folder. The session is found by the id in the path alone: the folder  segment is not matched against it, and neither is the account that opened it, which makes the id the only  secret protecting the transfer. The call is destructive and is not safe to repeat, because the record is gone  afterwards: a second attempt, a session already closed by  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize` and a session that expired after twelve hours of  silence all fail rather than answer as missing. Finalizing removes the session too, so there is nothing left  to abort once the file exists. The answer carries no body. An upload that is simply abandoned needs no call at  all, since the session and its buffered parts are dropped when it expires.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session to cancel, as returned in `id` when it was created: a 32-character hexadecimal string that  identifies the session on its own.</param>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/abort-upload-session/">REST API Reference for AbortUploadSession Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AbortUploadSessionWithHttpInfo(string sessionId, int folderId);
        /// <summary>
        /// Add favorite files and folders
        /// </summary>
        /// <remarks>
        /// Marks the listed files and folders as favorites for the calling account. The favorite list is personal:  nothing changes for other members, and the entries stay where they are stored. Read access to each item is  enough, so a room member with view-only rights and a guest may call it. Items the caller cannot read, ids that  do not exist and encrypted files of a private room are skipped without a word, and the answer is `true` even  when nothing was marked, so read the outcome back from `GET api/2.0/files/@favorites` instead of trusting it.  Numeric ids address entries stored in the portal itself, string ids entries on a connected third-party  account, and both kinds may be sent in one request. The call is mutating but safe to repeat: an item already  marked stays listed once. An entry moved to the Trash keeps its mark and is left out of the listing until it  is restored. `returnSingleOperation` arrives with the shared body and does nothing here. Use  `DELETE api/2.0/files/favorites` to undo, or `GET api/2.0/files/favorites/{fileId}` for a single file.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-favorites/">REST API Reference for AddFavorites Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper AddFavorites(BaseBatchRequestDto? baseBatchRequestDto = default);

        /// <summary>
        /// Add favorite files and folders
        /// </summary>
        /// <remarks>
        /// Marks the listed files and folders as favorites for the calling account. The favorite list is personal:  nothing changes for other members, and the entries stay where they are stored. Read access to each item is  enough, so a room member with view-only rights and a guest may call it. Items the caller cannot read, ids that  do not exist and encrypted files of a private room are skipped without a word, and the answer is `true` even  when nothing was marked, so read the outcome back from `GET api/2.0/files/@favorites` instead of trusting it.  Numeric ids address entries stored in the portal itself, string ids entries on a connected third-party  account, and both kinds may be sent in one request. The call is mutating but safe to repeat: an item already  marked stays listed once. An entry moved to the Trash keeps its mark and is left out of the listing until it  is restored. `returnSingleOperation` arrives with the shared body and does nothing here. Use  `DELETE api/2.0/files/favorites` to undo, or `GET api/2.0/files/favorites/{fileId}` for a single file.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-favorites/">REST API Reference for AddFavorites Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> AddFavoritesWithHttpInfo(BaseBatchRequestDto? baseBatchRequestDto = default);
        /// <summary>
        /// Bulk download
        /// </summary>
        /// <remarks>
        /// Queues a background job that packs the requested files and folders into a single archive, and answers with the  caller's download operations, including the one just started. The archive is not ready when the response  arrives: poll `GET api/2.0/files/fileops` until the operation reports `finished`, then take the address of the  archive from its `url`. Items listed in `fileConvertIds` are converted to the format named there before they  are packed, while the items of `fileIds` are packed as they are. Read access to every listed item is required:  an item the caller may not read fails the whole call with 403, and an id that resolves to nothing is answered  as missing, so filter the selection beforehand. Only one download at a time is allowed per caller, and a  second call made while the first is still running is refused with 403 as well. An empty selection queues  nothing and simply answers with the operations that are already there. An anonymous caller may use the call  for the items covered by the external link they hold.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadRequestDto">The files and folders to pack into one archive, together with the formats they are converted to. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/bulk-download/">REST API Reference for BulkDownload Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper BulkDownload(DownloadRequestDto? downloadRequestDto = default);

        /// <summary>
        /// Bulk download
        /// </summary>
        /// <remarks>
        /// Queues a background job that packs the requested files and folders into a single archive, and answers with the  caller's download operations, including the one just started. The archive is not ready when the response  arrives: poll `GET api/2.0/files/fileops` until the operation reports `finished`, then take the address of the  archive from its `url`. Items listed in `fileConvertIds` are converted to the format named there before they  are packed, while the items of `fileIds` are packed as they are. Read access to every listed item is required:  an item the caller may not read fails the whole call with 403, and an id that resolves to nothing is answered  as missing, so filter the selection beforehand. Only one download at a time is allowed per caller, and a  second call made while the first is still running is refused with 403 as well. An empty selection queues  nothing and simply answers with the operations that are already there. An anonymous caller may use the call  for the items covered by the external link they hold.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadRequestDto">The files and folders to pack into one archive, together with the formats they are converted to. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/bulk-download/">REST API Reference for BulkDownload Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> BulkDownloadWithHttpInfo(DownloadRequestDto? downloadRequestDto = default);
        /// <summary>
        /// Get conversion status
        /// </summary>
        /// <remarks>
        /// Reports how far the conversion of a file has got, as a list that holds one entry while the portal still knows  about that conversion and nothing once it is over. Read `progress`, which counts from 0 to 100, `error` for  the reason a conversion failed, and `file`, which carries the converted file as soon as it exists. Queue the  conversion with `PUT api/2.0/files/file/{fileId}/checkconversion` and poll this operation until the entry  reaches 100 or disappears: a finished entry is handed out once and then dropped, and an entry whose conversion  stopped is discarded a few minutes later, so an empty list means either already reported or never started  rather than an error. The same empty list is the answer for an identifier no file matches. Passing  `start=true` starts the conversion as well, with the format from the portal settings and no password, which  makes that one flag mutating; without it the operation is read-only. The caller needs read access to the file,  and anyone else is refused.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file whose conversion is asked about.</param>
        /// <param name="start">Whether to start the conversion as well: `true` queues it with the default output format and no password,  `false` only reports what the portal already knows. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-conversion-status/">REST API Reference for CheckConversionStatus Operation</seealso>
        /// <returns>ConversationResultArrayWrapper</returns>
        ConversationResultArrayWrapper CheckConversionStatus(int fileId, bool? start = default);

        /// <summary>
        /// Get conversion status
        /// </summary>
        /// <remarks>
        /// Reports how far the conversion of a file has got, as a list that holds one entry while the portal still knows  about that conversion and nothing once it is over. Read `progress`, which counts from 0 to 100, `error` for  the reason a conversion failed, and `file`, which carries the converted file as soon as it exists. Queue the  conversion with `PUT api/2.0/files/file/{fileId}/checkconversion` and poll this operation until the entry  reaches 100 or disappears: a finished entry is handed out once and then dropped, and an entry whose conversion  stopped is discarded a few minutes later, so an empty list means either already reported or never started  rather than an error. The same empty list is the answer for an identifier no file matches. Passing  `start=true` starts the conversion as well, with the format from the portal settings and no password, which  makes that one flag mutating; without it the operation is read-only. The caller needs read access to the file,  and anyone else is refused.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file whose conversion is asked about.</param>
        /// <param name="start">Whether to start the conversion as well: `true` queues it with the default output format and no password,  `false` only reports what the portal already knows. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-conversion-status/">REST API Reference for CheckConversionStatus Operation</seealso>
        /// <returns>ApiResponse of ConversationResultArrayWrapper</returns>
        ApiResponse<ConversationResultArrayWrapper> CheckConversionStatusWithHttpInfo(int fileId, bool? start = default);
        /// <summary>
        /// Check move or copy conflicts
        /// </summary>
        /// <remarks>
        /// Reports which of the requested files and folders already have a same-named entry in `destFolderId`, so that  the clash can be settled before the move or the copy is started. Nothing is moved, copied or changed by the  call, although the address is shared with `PUT api/2.0/files/fileops/move`: the answer is the part of the  request that clashes, and an empty array means the batch would go through without one. The  `conflictResolveType` of the request is not taken into account — clashing items are reported whatever it says  — and encrypted files are left out of the report. A source id that resolves to nothing is not an error and is  passed over. The caller needs create access to the destination: an archived room and a room the caller cannot  write to are refused with 403, a destination that does not exist is answered as missing, and a request without  `destFolderId` is rejected as an invalid request. To learn whether the destination accepts the files at all  use `GET api/2.0/files/fileops/checkdestfolder`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-batch-items/">REST API Reference for CheckMoveOrCopyBatchItems Operation</seealso>
        /// <returns>FileEntryBaseArrayWrapper</returns>
        FileEntryBaseArrayWrapper CheckMoveOrCopyBatchItems(BatchRequestDto? inDto = default);

        /// <summary>
        /// Check move or copy conflicts
        /// </summary>
        /// <remarks>
        /// Reports which of the requested files and folders already have a same-named entry in `destFolderId`, so that  the clash can be settled before the move or the copy is started. Nothing is moved, copied or changed by the  call, although the address is shared with `PUT api/2.0/files/fileops/move`: the answer is the part of the  request that clashes, and an empty array means the batch would go through without one. The  `conflictResolveType` of the request is not taken into account — clashing items are reported whatever it says  — and encrypted files are left out of the report. A source id that resolves to nothing is not an error and is  passed over. The caller needs create access to the destination: an archived room and a room the caller cannot  write to are refused with 403, a destination that does not exist is answered as missing, and a request without  `destFolderId` is rejected as an invalid request. To learn whether the destination accepts the files at all  use `GET api/2.0/files/fileops/checkdestfolder`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-batch-items/">REST API Reference for CheckMoveOrCopyBatchItems Operation</seealso>
        /// <returns>ApiResponse of FileEntryBaseArrayWrapper</returns>
        ApiResponse<FileEntryBaseArrayWrapper> CheckMoveOrCopyBatchItemsWithHttpInfo(BatchRequestDto? inDto = default);
        /// <summary>
        /// Check the destination folder
        /// </summary>
        /// <remarks>
        /// Reports whether the destination folder accepts the listed files, before a move or a copy is started. Only  `fileIds` and `destFolderId` are read from the request: `result` says whether all of the files are accepted,  only some of them or none, and `files` names the ones that are. The check is about what the destination allows  to be stored in it rather than about name clashes — everywhere except a form-filling room every file is  accepted, while a form-filling room accepts only PDF forms, so a text document offered to one comes back as  none accepted. The caller needs create access to the destination, so a room the caller cannot write to and an  archived room are refused with 403, a destination that does not exist is answered as missing, and a request  without `destFolderId` is rejected as an invalid request. Folder ids and the copying options of the request  play no part here. The call changes nothing; for same-named entries at the destination use  `GET api/2.0/files/fileops/move`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-dest-folder/">REST API Reference for CheckMoveOrCopyDestFolder Operation</seealso>
        /// <returns>CheckDestFolderWrapper</returns>
        CheckDestFolderWrapper CheckMoveOrCopyDestFolder(BatchRequestDto? inDto = default);

        /// <summary>
        /// Check the destination folder
        /// </summary>
        /// <remarks>
        /// Reports whether the destination folder accepts the listed files, before a move or a copy is started. Only  `fileIds` and `destFolderId` are read from the request: `result` says whether all of the files are accepted,  only some of them or none, and `files` names the ones that are. The check is about what the destination allows  to be stored in it rather than about name clashes — everywhere except a form-filling room every file is  accepted, while a form-filling room accepts only PDF forms, so a text document offered to one comes back as  none accepted. The caller needs create access to the destination, so a room the caller cannot write to and an  archived room are refused with 403, a destination that does not exist is answered as missing, and a request  without `destFolderId` is rejected as an invalid request. Folder ids and the copying options of the request  play no part here. The call changes nothing; for same-named entries at the destination use  `GET api/2.0/files/fileops/move`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-dest-folder/">REST API Reference for CheckMoveOrCopyDestFolder Operation</seealso>
        /// <returns>ApiResponse of CheckDestFolderWrapper</returns>
        ApiResponse<CheckDestFolderWrapper> CheckMoveOrCopyDestFolderWithHttpInfo(BatchRequestDto? inDto = default);
        /// <summary>
        /// Copy files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that copies the requested files and folders into `destFolderId`, leaving the originals  where they are, and answers with the caller's move and copy operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`; its `files` and `folders` then name what  was produced. Before starting, `GET api/2.0/files/fileops/move` reports which items already have a same-named  entry at the destination and `conflictResolveType` decides what happens to them, while  `GET api/2.0/files/fileops/checkdestfolder` reports whether the destination accepts the files at all. The  caller needs create access to the destination — room manager or content-creator rights inside a room — and  read access to every source item; anything less is refused with 403. With `content=true` each listed folder is  replaced by its own files and subfolders, so the folder itself is not recreated at the destination. An empty  selection queues nothing and answers with the operations that are already there. To remove the originals  instead use `PUT api/2.0/files/fileops/move`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-batch-items/">REST API Reference for CopyBatchItems Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper CopyBatchItems(BatchRequestDto? batchRequestDto = default);

        /// <summary>
        /// Copy files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that copies the requested files and folders into `destFolderId`, leaving the originals  where they are, and answers with the caller's move and copy operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`; its `files` and `folders` then name what  was produced. Before starting, `GET api/2.0/files/fileops/move` reports which items already have a same-named  entry at the destination and `conflictResolveType` decides what happens to them, while  `GET api/2.0/files/fileops/checkdestfolder` reports whether the destination accepts the files at all. The  caller needs create access to the destination — room manager or content-creator rights inside a room — and  read access to every source item; anything less is refused with 403. With `content=true` each listed folder is  replaced by its own files and subfolders, so the folder itself is not recreated at the destination. An empty  selection queues nothing and answers with the operations that are already there. To remove the originals  instead use `PUT api/2.0/files/fileops/move`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-batch-items/">REST API Reference for CopyBatchItems Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> CopyBatchItemsWithHttpInfo(BatchRequestDto? batchRequestDto = default);
        /// <summary>
        /// Chunked upload
        /// </summary>
        /// <remarks>
        /// Deprecated in favour of `POST api/2.0/files/{folderId}/session`, which opens the same session and returns it  without the success envelope used here; new callers should go there. Reserves a chunked upload of a file in  the folder named by the path: the title comes from `fileName`, the declared payload size from `fileSize`, and  the answer carries the session id every later call quotes, the address of the standalone chunk handler, the  moment an idle session is dropped and the reserved byte count. No content is stored yet. Send the payload as  multipart parts to `POST api/2.0/files/{folderId}/session/{sessionId}/upload`, keeping each part within  `chunkUploadSize` from `GET api/2.0/files/settings`, then close the session with  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. The caller needs the right to add content to the  target folder, which room managers and content creators have and readers, editors and guests do not: they get  403, as does a section root such as Rooms or Archive, while an unknown folder is answered as missing. A  payload above the portal limit for chunked uploads is refused before the session exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="sessionRequest">The file the session is opened for, and how a clash with an existing name is settled.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session/">REST API Reference for CreateUploadSession Operation</seealso>
        /// <returns>ChunkedUploadSessionResponseWrapperIntegerWrapper</returns>
        [Obsolete]
        ChunkedUploadSessionResponseWrapperIntegerWrapper CreateUploadSession(int folderId, SessionRequest sessionRequest);

        /// <summary>
        /// Chunked upload
        /// </summary>
        /// <remarks>
        /// Deprecated in favour of `POST api/2.0/files/{folderId}/session`, which opens the same session and returns it  without the success envelope used here; new callers should go there. Reserves a chunked upload of a file in  the folder named by the path: the title comes from `fileName`, the declared payload size from `fileSize`, and  the answer carries the session id every later call quotes, the address of the standalone chunk handler, the  moment an idle session is dropped and the reserved byte count. No content is stored yet. Send the payload as  multipart parts to `POST api/2.0/files/{folderId}/session/{sessionId}/upload`, keeping each part within  `chunkUploadSize` from `GET api/2.0/files/settings`, then close the session with  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. The caller needs the right to add content to the  target folder, which room managers and content creators have and readers, editors and guests do not: they get  403, as does a section root such as Rooms or Archive, while an unknown folder is answered as missing. A  payload above the portal limit for chunked uploads is refused before the session exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="sessionRequest">The file the session is opened for, and how a clash with an existing name is settled.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session/">REST API Reference for CreateUploadSession Operation</seealso>
        /// <returns>ApiResponse of ChunkedUploadSessionResponseWrapperIntegerWrapper</returns>
        [Obsolete]
        ApiResponse<ChunkedUploadSessionResponseWrapperIntegerWrapper> CreateUploadSessionWithHttpInfo(int folderId, SessionRequest sessionRequest);
        /// <summary>
        /// Create an upload session
        /// </summary>
        /// <remarks>
        /// Opens a chunked upload session for a file in the folder named by the path and returns the session itself,  which is the difference from the deprecated `POST api/2.0/files/{folderId}/upload/create_session` and its  success envelope. The answer gives `id`, quoted by every later call, `location` for the standalone chunk  handler used by clients that bypass this API, `expired`, and `bytes_total` echoing the reserved size. Whether  parts are really needed follows from `fileSize`: below `chunkUploadSize` from `GET api/2.0/files/settings` the  whole payload goes in one `POST api/2.0/files/{folderId}/session/{sessionId}`, which stores the file and  answers 201, and above it the parts go one by one to  `POST api/2.0/files/{folderId}/session/{sessionId}/upload` and the file appears only after  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. The caller must be allowed to add content to the  folder, so readers, editors and guests are refused, a section root is refused as well, and an unknown folder  is answered as missing. Nothing is written until the parts arrive, and an abandoned session disappears twelve  hours later.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="sessionRequest">The file the session is opened for, and how a clash with an existing name is settled.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session-in-folder/">REST API Reference for CreateUploadSessionInFolder Operation</seealso>
        /// <returns>ChunkedUploadSessionResponseIntegerWrapper</returns>
        ChunkedUploadSessionResponseIntegerWrapper CreateUploadSessionInFolder(int folderId, SessionRequest sessionRequest);

        /// <summary>
        /// Create an upload session
        /// </summary>
        /// <remarks>
        /// Opens a chunked upload session for a file in the folder named by the path and returns the session itself,  which is the difference from the deprecated `POST api/2.0/files/{folderId}/upload/create_session` and its  success envelope. The answer gives `id`, quoted by every later call, `location` for the standalone chunk  handler used by clients that bypass this API, `expired`, and `bytes_total` echoing the reserved size. Whether  parts are really needed follows from `fileSize`: below `chunkUploadSize` from `GET api/2.0/files/settings` the  whole payload goes in one `POST api/2.0/files/{folderId}/session/{sessionId}`, which stores the file and  answers 201, and above it the parts go one by one to  `POST api/2.0/files/{folderId}/session/{sessionId}/upload` and the file appears only after  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. The caller must be allowed to add content to the  folder, so readers, editors and guests are refused, a section root is refused as well, and an unknown folder  is answered as missing. Nothing is written until the parts arrive, and an abandoned session disappears twelve  hours later.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="sessionRequest">The file the session is opened for, and how a clash with an existing name is settled.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session-in-folder/">REST API Reference for CreateUploadSessionInFolder Operation</seealso>
        /// <returns>ApiResponse of ChunkedUploadSessionResponseIntegerWrapper</returns>
        ApiResponse<ChunkedUploadSessionResponseIntegerWrapper> CreateUploadSessionInFolderWithHttpInfo(int folderId, SessionRequest sessionRequest);
        /// <summary>
        /// Delete files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that deletes the requested files and folders, and answers with the caller's delete  operations, including the one just started. Poll `GET api/2.0/files/fileops` until the operation reports  `finished`, and read its `error`: a failure on a single item is reported there rather than as a status code.  With `immediately=false` the items are moved to the caller's Trash and can be restored from it, while  `immediately=true` removes them at once and for good; deleting a folder takes everything inside it either way.  The call is destructive and it is not a no-op on repetition — a second call with the same ids deletes whatever  has been restored in the meantime. Access is checked before the job is queued: deleting from a room requires  room manager or content-creator rights, editing or read rights are refused with 403, and an id that resolves  to nothing is answered as missing. An empty selection queues nothing and answers with the operations that are  already there. To clear the Trash itself use `PUT api/2.0/files/fileops/emptytrash`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteBatchRequestDto">The files and folders to delete, and how final the deletion is. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-batch-items/">REST API Reference for DeleteBatchItems Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper DeleteBatchItems(DeleteBatchRequestDto? deleteBatchRequestDto = default);

        /// <summary>
        /// Delete files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that deletes the requested files and folders, and answers with the caller's delete  operations, including the one just started. Poll `GET api/2.0/files/fileops` until the operation reports  `finished`, and read its `error`: a failure on a single item is reported there rather than as a status code.  With `immediately=false` the items are moved to the caller's Trash and can be restored from it, while  `immediately=true` removes them at once and for good; deleting a folder takes everything inside it either way.  The call is destructive and it is not a no-op on repetition — a second call with the same ids deletes whatever  has been restored in the meantime. Access is checked before the job is queued: deleting from a room requires  room manager or content-creator rights, editing or read rights are refused with 403, and an id that resolves  to nothing is answered as missing. An empty selection queues nothing and answers with the operations that are  already there. To clear the Trash itself use `PUT api/2.0/files/fileops/emptytrash`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteBatchRequestDto">The files and folders to delete, and how final the deletion is. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-batch-items/">REST API Reference for DeleteBatchItems Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> DeleteBatchItemsWithHttpInfo(DeleteBatchRequestDto? deleteBatchRequestDto = default);
        /// <summary>
        /// Delete favorite files and folders
        /// </summary>
        /// <remarks>
        /// Removes the favorite mark from the listed files and folders for the calling account. Nothing is deleted from  storage: the entries keep their place, their content and their sharing, and only disappear from  `GET api/2.0/files/@favorites`; to delete the entries themselves call `PUT api/2.0/files/fileops/delete`  instead. Marks of other members are untouched, and read access to each item is enough to call it. The ids go  into the JSON body documented here; the same route also accepts them as repeated `fileIds` and `folderIds`  query parameters, but only in a request that carries no JSON body at all. Numeric ids address entries stored  in the portal itself, string ids entries on a connected third-party account. The answer is `true` whenever the  request was understood, which an empty request, an id that does not exist and an item that was never marked  all achieve, so it does not report how many marks were dropped. `returnSingleOperation` arrives with the  shared body and does nothing here. Repeating the call is safe. Use `POST api/2.0/files/favorites` to mark  entries again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-favorites-from-body/">REST API Reference for DeleteFavoritesFromBody Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper DeleteFavoritesFromBody(BaseBatchRequestDto? baseBatchRequestDto = default);

        /// <summary>
        /// Delete favorite files and folders
        /// </summary>
        /// <remarks>
        /// Removes the favorite mark from the listed files and folders for the calling account. Nothing is deleted from  storage: the entries keep their place, their content and their sharing, and only disappear from  `GET api/2.0/files/@favorites`; to delete the entries themselves call `PUT api/2.0/files/fileops/delete`  instead. Marks of other members are untouched, and read access to each item is enough to call it. The ids go  into the JSON body documented here; the same route also accepts them as repeated `fileIds` and `folderIds`  query parameters, but only in a request that carries no JSON body at all. Numeric ids address entries stored  in the portal itself, string ids entries on a connected third-party account. The answer is `true` whenever the  request was understood, which an empty request, an id that does not exist and an item that was never marked  all achieve, so it does not report how many marks were dropped. `returnSingleOperation` arrives with the  shared body and does nothing here. Repeating the call is safe. Use `POST api/2.0/files/favorites` to mark  entries again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-favorites-from-body/">REST API Reference for DeleteFavoritesFromBody Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> DeleteFavoritesFromBodyWithHttpInfo(BaseBatchRequestDto? baseBatchRequestDto = default);
        /// <summary>
        /// Delete file versions
        /// </summary>
        /// <remarks>
        /// Queues a background job that removes the listed versions from the history of one file, and answers with the  caller's delete operations, including the one just started. Poll `GET api/2.0/files/fileops` until the  operation reports `finished`; a failure met while the job runs is reported in its `error` rather than as a  status code. Removal is permanent — deleted versions do not travel through Trash and cannot be restored, while  the file itself stays in place with the versions that are left. Send the numbers that  `GET api/2.0/files/file/{fileId}/history` reports, and send at least one: an empty list is not an empty  request, it deletes the whole file instead. The number of the current version is refused before anything is  queued, while numbers that no longer exist are passed over without a complaint. The caller needs the rights  that deleting the file itself would need, so a member with read-only rights is refused, as are a file in an  archived room and a file that is already in Trash, and a file that does not exist is answered as missing. To  delete the file itself use `PUT api/2.0/files/fileops/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteVersionBatchRequestDto">The file whose versions are deleted, and the versions to delete. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file-versions/">REST API Reference for DeleteFileVersions Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper DeleteFileVersions(DeleteVersionBatchRequestDto? deleteVersionBatchRequestDto = default);

        /// <summary>
        /// Delete file versions
        /// </summary>
        /// <remarks>
        /// Queues a background job that removes the listed versions from the history of one file, and answers with the  caller's delete operations, including the one just started. Poll `GET api/2.0/files/fileops` until the  operation reports `finished`; a failure met while the job runs is reported in its `error` rather than as a  status code. Removal is permanent — deleted versions do not travel through Trash and cannot be restored, while  the file itself stays in place with the versions that are left. Send the numbers that  `GET api/2.0/files/file/{fileId}/history` reports, and send at least one: an empty list is not an empty  request, it deletes the whole file instead. The number of the current version is refused before anything is  queued, while numbers that no longer exist are passed over without a complaint. The caller needs the rights  that deleting the file itself would need, so a member with read-only rights is refused, as are a file in an  archived room and a file that is already in Trash, and a file that does not exist is answered as missing. To  delete the file itself use `PUT api/2.0/files/fileops/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteVersionBatchRequestDto">The file whose versions are deleted, and the versions to delete. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file-versions/">REST API Reference for DeleteFileVersions Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> DeleteFileVersionsWithHttpInfo(DeleteVersionBatchRequestDto? deleteVersionBatchRequestDto = default);
        /// <summary>
        /// Duplicate files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that copies each requested file and folder next to itself, into the folder where it  already is, and answers with the caller's duplicate operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. The copies keep the name of the original  with a numeric suffix, so nothing is overwritten and every repetition adds one more copy; duplicating a folder  duplicates its content as well. No destination is taken — to place a copy somewhere else use  `PUT api/2.0/files/fileops/copy`. The caller needs the rights that creating an item in that folder would need,  which inside a room means room manager or content-creator rights: read or editing rights, and an item the  caller has no access to at all, are refused with 403. An empty selection queues nothing and answers with the  operations that are already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="duplicateRequestDto">The files and folders to duplicate. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/duplicate-batch-items/">REST API Reference for DuplicateBatchItems Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper DuplicateBatchItems(DuplicateRequestDto? duplicateRequestDto = default);

        /// <summary>
        /// Duplicate files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that copies each requested file and folder next to itself, into the folder where it  already is, and answers with the caller's duplicate operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. The copies keep the name of the original  with a numeric suffix, so nothing is overwritten and every repetition adds one more copy; duplicating a folder  duplicates its content as well. No destination is taken — to place a copy somewhere else use  `PUT api/2.0/files/fileops/copy`. The caller needs the rights that creating an item in that folder would need,  which inside a room means room manager or content-creator rights: read or editing rights, and an item the  caller has no access to at all, are refused with 403. An empty selection queues nothing and answers with the  operations that are already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="duplicateRequestDto">The files and folders to duplicate. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/duplicate-batch-items/">REST API Reference for DuplicateBatchItems Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> DuplicateBatchItemsWithHttpInfo(DuplicateRequestDto? duplicateRequestDto = default);
        /// <summary>
        /// Empty the Trash folder
        /// </summary>
        /// <remarks>
        /// Queues a background job that permanently removes the content of the caller's own Trash, and answers with the  caller's delete operations, including the one just started. Poll `GET api/2.0/files/fileops` until the  operation reports `finished`. Every authenticated account may empty its own Trash and only its own: no  per-item access check takes place because nothing outside the caller's Trash is touched. With `folderType` the  sweep is narrowed to the items that were originally stored in sections and rooms of the named types, so  clearing what came from personal documents leaves what came from rooms untouched; without the parameter the  whole Trash is emptied. What is removed here cannot be restored afterwards, which is the difference from  `PUT api/2.0/files/fileops/delete`, where `immediately=false` puts items into Trash in the first place.  Calling it on an already empty Trash queues nothing and answers with the operations that are already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="single">Which operations the answer carries: `true` returns the operation this call started and nothing else, `false`  returns every delete operation that the caller has running or unread. (optional)</param>
        /// <param name="folderType">Limits the sweep to the items whose original location was inside a section or a room of one of the named  types, leaving the rest of the Trash untouched; without the parameter the whole Trash is emptied. `5` covers  what was deleted from personal documents, `14` what was deleted from rooms. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/empty-trash/">REST API Reference for EmptyTrash Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper EmptyTrash(bool? single = default, List<int>? folderType = default);

        /// <summary>
        /// Empty the Trash folder
        /// </summary>
        /// <remarks>
        /// Queues a background job that permanently removes the content of the caller's own Trash, and answers with the  caller's delete operations, including the one just started. Poll `GET api/2.0/files/fileops` until the  operation reports `finished`. Every authenticated account may empty its own Trash and only its own: no  per-item access check takes place because nothing outside the caller's Trash is touched. With `folderType` the  sweep is narrowed to the items that were originally stored in sections and rooms of the named types, so  clearing what came from personal documents leaves what came from rooms untouched; without the parameter the  whole Trash is emptied. What is removed here cannot be restored afterwards, which is the difference from  `PUT api/2.0/files/fileops/delete`, where `immediately=false` puts items into Trash in the first place.  Calling it on an already empty Trash queues nothing and answers with the operations that are already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="single">Which operations the answer carries: `true` returns the operation this call started and nothing else, `false`  returns every delete operation that the caller has running or unread. (optional)</param>
        /// <param name="folderType">Limits the sweep to the items whose original location was inside a section or a room of one of the named  types, leaving the rest of the Trash untouched; without the parameter the whole Trash is emptied. `5` covers  what was deleted from personal documents, `14` what was deleted from rooms. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/empty-trash/">REST API Reference for EmptyTrash Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> EmptyTrashWithHttpInfo(bool? single = default, List<int>? folderType = default);
        /// <summary>
        /// Finalize an upload session
        /// </summary>
        /// <remarks>
        /// Assembles the parts received so far into the file the session was opened for and closes the session. What  comes out depends on how the session started: one opened against an existing file through  `POST api/2.0/files/file/{fileId}/edit_session` replaces that content in place and keeps the version number,  while one opened against a folder either creates the file or, when a file of the same name was taken over,  stores the content as its next version. A form loses its filling state on the way in. The answer arrives with  201 and carries the identifiers of the file together with the file itself. The call ends the session: the  record and the buffered parts are removed, so it cannot be repeated and there is nothing left to abort  afterwards. Running it before all the declared bytes have arrived assembles whatever is there, so read the  progress from the chunk calls first. An unknown, already closed or expired session id fails instead of  answering as missing.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session to assemble, as returned in `id` when it was created: a 32-character hexadecimal string that  identifies the session on its own.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/finalize-session/">REST API Reference for FinalizeSession Operation</seealso>
        /// <returns>UploadSessionResponseIntegerWrapper</returns>
        UploadSessionResponseIntegerWrapper FinalizeSession(int folderId, string sessionId);

        /// <summary>
        /// Finalize an upload session
        /// </summary>
        /// <remarks>
        /// Assembles the parts received so far into the file the session was opened for and closes the session. What  comes out depends on how the session started: one opened against an existing file through  `POST api/2.0/files/file/{fileId}/edit_session` replaces that content in place and keeps the version number,  while one opened against a folder either creates the file or, when a file of the same name was taken over,  stores the content as its next version. A form loses its filling state on the way in. The answer arrives with  201 and carries the identifiers of the file together with the file itself. The call ends the session: the  record and the buffered parts are removed, so it cannot be repeated and there is nothing left to abort  afterwards. Running it before all the declared bytes have arrived assembles whatever is there, so read the  progress from the chunk calls first. An unknown, already closed or expired session id fails instead of  answering as missing.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session to assemble, as returned in `id` when it was created: a 32-character hexadecimal string that  identifies the session on its own.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/finalize-session/">REST API Reference for FinalizeSession Operation</seealso>
        /// <returns>ApiResponse of UploadSessionResponseIntegerWrapper</returns>
        ApiResponse<UploadSessionResponseIntegerWrapper> FinalizeSessionWithHttpInfo(int folderId, string sessionId);
        /// <summary>
        /// Get active file operations
        /// </summary>
        /// <remarks>
        /// Returns the background file operations of the caller that are still running or whose finished result has not  been read yet, grouped by kind: duplications first, then moves and copies, deletions, downloads and  mark-as-read. This is the polling target for every operation in this section — an operation appears here as  soon as it is queued and carries `progress` from 0 to 100, `finished`, the `error` of a failed item and, for a  download, the address of the archive in `url`. A record is dropped once its finished state has been handed  out, so a completed operation is reported once and an empty array means there is nothing left to report rather  than that the work failed. Pass `id` to follow a single operation; an id that is not among the caller's  operations gives an empty array. Operations are private to the account that started them, an anonymous caller  being scoped to the session of the external link. The call changes nothing. To follow one kind only use  `GET api/2.0/files/fileops/{operationType}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The operation to report on, as returned in `id` when it was started; without it every operation of the caller  is reported. An id that is not among the caller's operations gives an empty answer rather than an error. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses/">REST API Reference for GetOperationStatuses Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper GetOperationStatuses(string? id = default);

        /// <summary>
        /// Get active file operations
        /// </summary>
        /// <remarks>
        /// Returns the background file operations of the caller that are still running or whose finished result has not  been read yet, grouped by kind: duplications first, then moves and copies, deletions, downloads and  mark-as-read. This is the polling target for every operation in this section — an operation appears here as  soon as it is queued and carries `progress` from 0 to 100, `finished`, the `error` of a failed item and, for a  download, the address of the archive in `url`. A record is dropped once its finished state has been handed  out, so a completed operation is reported once and an empty array means there is nothing left to report rather  than that the work failed. Pass `id` to follow a single operation; an id that is not among the caller's  operations gives an empty array. Operations are private to the account that started them, an anonymous caller  being scoped to the session of the external link. The call changes nothing. To follow one kind only use  `GET api/2.0/files/fileops/{operationType}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The operation to report on, as returned in `id` when it was started; without it every operation of the caller  is reported. An id that is not among the caller's operations gives an empty answer rather than an error. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses/">REST API Reference for GetOperationStatuses Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> GetOperationStatusesWithHttpInfo(string? id = default);
        /// <summary>
        /// Get file operations by type
        /// </summary>
        /// <remarks>
        /// Returns the background file operations of the caller that are of one kind, named by the number in the route:  `1` for a copy, `2` for a deletion, `3` for a download, `4` for a mark-as-read and `7` for a duplication. The  answer carries the same records as `GET api/2.0/files/fileops`, with the same rule that a finished operation  is reported once and then dropped, and `id` narrows it further to a single operation. Moves, kind `0`, cannot  be read through this route: the address `api/2.0/files/fileops/move` belongs to another operation, so read  moves from `GET api/2.0/files/fileops` and pick the records whose `operation` is `0`. A kind that has no queue  of its own — `5` for an import, `6` for a conversion — is accepted and answers with an empty array, while a  number outside the operation type is rejected as an invalid request. The call changes nothing and never shows  another account's operations.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationType">The kind of operation the answer is limited to. Only the kinds that have a queue of their own ever carry  records — a copy, a deletion, a download, a mark-as-read and a duplication — and moves cannot be read through  this route at all, because its address belongs to another operation.</param>
        /// <param name="id">The operation to report on, as returned in `id` when it was started; without it every operation of the caller  is reported. An id that is not among the caller's operations gives an empty answer rather than an error. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses-by-type/">REST API Reference for GetOperationStatusesByType Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper GetOperationStatusesByType(FileOperationType operationType, string? id = default);

        /// <summary>
        /// Get file operations by type
        /// </summary>
        /// <remarks>
        /// Returns the background file operations of the caller that are of one kind, named by the number in the route:  `1` for a copy, `2` for a deletion, `3` for a download, `4` for a mark-as-read and `7` for a duplication. The  answer carries the same records as `GET api/2.0/files/fileops`, with the same rule that a finished operation  is reported once and then dropped, and `id` narrows it further to a single operation. Moves, kind `0`, cannot  be read through this route: the address `api/2.0/files/fileops/move` belongs to another operation, so read  moves from `GET api/2.0/files/fileops` and pick the records whose `operation` is `0`. A kind that has no queue  of its own — `5` for an import, `6` for a conversion — is accepted and answers with an empty array, while a  number outside the operation type is rejected as an invalid request. The call changes nothing and never shows  another account's operations.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationType">The kind of operation the answer is limited to. Only the kinds that have a queue of their own ever carry  records — a copy, a deletion, a download, a mark-as-read and a duplication — and moves cannot be read through  this route at all, because its address belongs to another operation.</param>
        /// <param name="id">The operation to report on, as returned in `id` when it was started; without it every operation of the caller  is reported. An id that is not among the caller's operations gives an empty answer rather than an error. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses-by-type/">REST API Reference for GetOperationStatusesByType Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> GetOperationStatusesByTypeWithHttpInfo(FileOperationType operationType, string? id = default);
        /// <summary>
        /// Mark files and folders as read
        /// </summary>
        /// <remarks>
        /// Queues a background job that clears the new-item badge from the requested files and folders for the calling  account, and answers with the caller's mark-as-read operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. Marking a folder clears the badges of  everything inside it as well. Items the caller cannot read are passed over in silence rather than refused, so  the call succeeds even when the whole selection is inaccessible, and an empty selection queues nothing and  answers with the operations that are already there. Repeating the call on items that are already read changes  nothing, and nothing is opened, moved or modified by it — only the caller's own badges are affected, while  other members keep theirs. To see what is currently marked as new use `GET api/2.0/files/{folderId}/news` for  one folder and `GET api/2.0/files/rooms/news` for the rooms of the caller.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-as-read/">REST API Reference for MarkAsRead Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper MarkAsRead(BaseBatchRequestDto? baseBatchRequestDto = default);

        /// <summary>
        /// Mark files and folders as read
        /// </summary>
        /// <remarks>
        /// Queues a background job that clears the new-item badge from the requested files and folders for the calling  account, and answers with the caller's mark-as-read operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. Marking a folder clears the badges of  everything inside it as well. Items the caller cannot read are passed over in silence rather than refused, so  the call succeeds even when the whole selection is inaccessible, and an empty selection queues nothing and  answers with the operations that are already there. Repeating the call on items that are already read changes  nothing, and nothing is opened, moved or modified by it — only the caller's own badges are affected, while  other members keep theirs. To see what is currently marked as new use `GET api/2.0/files/{folderId}/news` for  one folder and `GET api/2.0/files/rooms/news` for the rooms of the caller.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-as-read/">REST API Reference for MarkAsRead Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> MarkAsReadWithHttpInfo(BaseBatchRequestDto? baseBatchRequestDto = default);
        /// <summary>
        /// Move files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that moves the requested files and folders into `destFolderId`, removing them from  where they were, and answers with the caller's move and copy operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. Before starting,  `GET api/2.0/files/fileops/move` reports which items already have a same-named entry at the destination and  `conflictResolveType` decides what happens to them, while `GET api/2.0/files/fileops/checkdestfolder` reports  whether the destination accepts the files at all. The caller needs create access to the destination and the  right to take the items out of their source, which is why room members with editing or review rights are  refused with 403, and why content-creator rights inside a room allow copying an item out of it but not moving  it. A room cannot be moved this way — use `PUT api/2.0/files/rooms/{id}/archive` instead. To keep the  originals use `PUT api/2.0/files/fileops/copy`. An empty selection queues nothing.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-batch-items/">REST API Reference for MoveBatchItems Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper MoveBatchItems(BatchRequestDto? batchRequestDto = default);

        /// <summary>
        /// Move files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that moves the requested files and folders into `destFolderId`, removing them from  where they were, and answers with the caller's move and copy operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. Before starting,  `GET api/2.0/files/fileops/move` reports which items already have a same-named entry at the destination and  `conflictResolveType` decides what happens to them, while `GET api/2.0/files/fileops/checkdestfolder` reports  whether the destination accepts the files at all. The caller needs create access to the destination and the  right to take the items out of their source, which is why room members with editing or review rights are  refused with 403, and why content-creator rights inside a room allow copying an item out of it but not moving  it. A room cannot be moved this way — use `PUT api/2.0/files/rooms/{id}/archive` instead. To keep the  originals use `PUT api/2.0/files/fileops/copy`. An empty selection queues nothing.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-batch-items/">REST API Reference for MoveBatchItems Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> MoveBatchItemsWithHttpInfo(BatchRequestDto? batchRequestDto = default);
        /// <summary>
        /// Start file conversion
        /// </summary>
        /// <remarks>
        /// Queues the conversion of a file into the portal's own editable format and answers with the conversion entry  the caller is to poll. The whole body may be omitted, in which case the defaults apply. `outputType` names the  target format and, left empty, the portal's default for that kind of document is used; `password` unlocks a  protected source file; `version` converts an older version instead of the current one. `createNewIfExist`  decides where the result goes: with `true` a new file is created beside the source, while with `false`, the  default, the converted file that already exists is replaced. `sync=true` converts inside the request and  answers with the finished result instead of a queue entry, which is only sensible for small documents.  Otherwise poll `GET api/2.0/files/file/{fileId}/checkconversion` until `progress` reaches 100 and take the  converted file from `file`. Only formats the portal has to convert are accepted; anything already editable,  and anything it cannot convert, is answered without work being queued or rejected as an invalid request. The  caller needs read access to the file. The call is mutating and not idempotent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file to convert.</param>
        /// <param name="checkConversionRequestDtoInteger">The parameters of the conversion. The whole body may be omitted, in which case the defaults of the portal  apply. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-file-conversion/">REST API Reference for StartFileConversion Operation</seealso>
        /// <returns>ConversationResultArrayWrapper</returns>
        ConversationResultArrayWrapper StartFileConversion(int fileId, CheckConversionRequestDtoInteger? checkConversionRequestDtoInteger = default);

        /// <summary>
        /// Start file conversion
        /// </summary>
        /// <remarks>
        /// Queues the conversion of a file into the portal's own editable format and answers with the conversion entry  the caller is to poll. The whole body may be omitted, in which case the defaults apply. `outputType` names the  target format and, left empty, the portal's default for that kind of document is used; `password` unlocks a  protected source file; `version` converts an older version instead of the current one. `createNewIfExist`  decides where the result goes: with `true` a new file is created beside the source, while with `false`, the  default, the converted file that already exists is replaced. `sync=true` converts inside the request and  answers with the finished result instead of a queue entry, which is only sensible for small documents.  Otherwise poll `GET api/2.0/files/file/{fileId}/checkconversion` until `progress` reaches 100 and take the  converted file from `file`. Only formats the portal has to convert are accepted; anything already editable,  and anything it cannot convert, is answered without work being queued or rejected as an invalid request. The  caller needs read access to the file. The call is mutating and not idempotent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file to convert.</param>
        /// <param name="checkConversionRequestDtoInteger">The parameters of the conversion. The whole body may be omitted, in which case the defaults of the portal  apply. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-file-conversion/">REST API Reference for StartFileConversion Operation</seealso>
        /// <returns>ApiResponse of ConversationResultArrayWrapper</returns>
        ApiResponse<ConversationResultArrayWrapper> StartFileConversionWithHttpInfo(int fileId, CheckConversionRequestDtoInteger? checkConversionRequestDtoInteger = default);
        /// <summary>
        /// Cancel file operations
        /// </summary>
        /// <remarks>
        /// Cancels a background file operation of the caller and answers with the operations that are left. Pass the `id`  that was reported when the operation started to stop that one; a call that leaves the trailing route segment  out stops every operation the caller has running, of every kind. Cancelling stops the job where it stands and  does not undo it: what has already been copied, moved or deleted stays that way, so a cancelled batch can  leave part of itself at the destination and part of it at the source, and the result has to be read back  rather than assumed. The cancelled record is dropped from `GET api/2.0/files/fileops` at once, which is why  the answer here is usually empty. An id that is not among the caller's operations cancels nothing and is not  an error. Operations are private to the account that started them, an anonymous caller being scoped to the  session of the external link, so the call can never reach an operation of anyone else.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The operation to cancel, as returned in `id` when it was started. A call that leaves the route segment out  cancels every operation of the caller, and an id that is not among their operations cancels nothing without  being an error.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-tasks/">REST API Reference for TerminateTasks Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper TerminateTasks(string id);

        /// <summary>
        /// Cancel file operations
        /// </summary>
        /// <remarks>
        /// Cancels a background file operation of the caller and answers with the operations that are left. Pass the `id`  that was reported when the operation started to stop that one; a call that leaves the trailing route segment  out stops every operation the caller has running, of every kind. Cancelling stops the job where it stands and  does not undo it: what has already been copied, moved or deleted stays that way, so a cancelled batch can  leave part of itself at the destination and part of it at the source, and the result has to be read back  rather than assumed. The cancelled record is dropped from `GET api/2.0/files/fileops` at once, which is why  the answer here is usually empty. An id that is not among the caller's operations cancels nothing and is not  an error. Operations are private to the account that started them, an anonymous caller being scoped to the  session of the external link, so the call can never reach an operation of anyone else.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The operation to cancel, as returned in `id` when it was started. A call that leaves the route segment out  cancels every operation of the caller, and an id that is not among their operations cancels nothing without  being an error.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-tasks/">REST API Reference for TerminateTasks Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> TerminateTasksWithHttpInfo(string id);
        /// <summary>
        /// Update a comment
        /// </summary>
        /// <remarks>
        /// Replaces the comment stored on one version of a file - the note that explains what changed in it - and answers  with the comment as it was stored, which is the text cut to the length the portal keeps. `version` names the  version and has to be an existing one: a version that does not exist is rejected as an invalid request, while  a file that does not exist at all is answered as not found. Sending an empty comment clears the note. The  caller needs the right to edit the history of the file, which the room admin, a DocSpace admin acting as room  manager and a member with content-creator rights have; a member with editing access to somebody else's file,  read-only access, a guest and an anonymous caller are all refused. A file that is locked by somebody else or  lies in Trash is refused as well. The call is mutating and idempotent - repeating it with the same text leaves  the same comment. The comments of all versions come back with `GET api/2.0/files/file/{fileId}/edit/history`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file whose version comment is replaced.</param>
        /// <param name="updateComment">The version and the comment to store on it.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-comment/">REST API Reference for UpdateFileComment Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper UpdateFileComment(int fileId, UpdateComment updateComment);

        /// <summary>
        /// Update a comment
        /// </summary>
        /// <remarks>
        /// Replaces the comment stored on one version of a file - the note that explains what changed in it - and answers  with the comment as it was stored, which is the text cut to the length the portal keeps. `version` names the  version and has to be an existing one: a version that does not exist is rejected as an invalid request, while  a file that does not exist at all is answered as not found. Sending an empty comment clears the note. The  caller needs the right to edit the history of the file, which the room admin, a DocSpace admin acting as room  manager and a member with content-creator rights have; a member with editing access to somebody else's file,  read-only access, a guest and an anonymous caller are all refused. A file that is locked by somebody else or  lies in Trash is refused as well. The call is mutating and idempotent - repeating it with the same text leaves  the same comment. The comments of all versions come back with `GET api/2.0/files/file/{fileId}/edit/history`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file whose version comment is replaced.</param>
        /// <param name="updateComment">The version and the comment to store on it.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-comment/">REST API Reference for UpdateFileComment Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> UpdateFileCommentWithHttpInfo(int fileId, UpdateComment updateComment);
        /// <summary>
        /// Upload a numbered chunk
        /// </summary>
        /// <remarks>
        /// Stores one part of a file under the number given in `chunkNumber`, which is what the ordinary chunked flow  uses: parts are kept by their number rather than by arrival, so a part that failed can be resent under the  same number without restarting the session. Numbering starts at 1, and leaving the number out makes the server  count the parts itself. The answer is always the session, never the file, and this call never completes the  upload: the file appears only after `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. Use  `POST api/2.0/files/{folderId}/session/{sessionId}` instead when the parts go strictly in order and the upload  should complete by itself. A part bigger than `chunkUploadSize` from `GET api/2.0/files/settings` is refused,  so that value is also the size to split the payload by. The first part of a PDF is inspected, and a PDF that  is not a fillable form is refused when the session targets a form-filling room. The session is found by its id  alone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session this part belongs to, as returned in `id` when it was created; a 32-character hexadecimal string.</param>
        /// <param name="chunkNumber">The position of this part in the file, counted from 1. Sending the same number again replaces that part  instead of adding one, which is how a failed part is retried; leaving the number out makes the server count  the parts itself. (optional)</param>
        /// <param name="file">The part of the file to store, sent as the multipart field of the same name. It is kept under the number given  beside it, and a part larger than the portal chunk size is refused. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-async-session/">REST API Reference for UploadAsyncSession Operation</seealso>
        /// <returns>ChunkedUploadSessionResponseIntegerWrapper</returns>
        ChunkedUploadSessionResponseIntegerWrapper UploadAsyncSession(int folderId, string sessionId, int? chunkNumber = default, FileParameter? file = default);

        /// <summary>
        /// Upload a numbered chunk
        /// </summary>
        /// <remarks>
        /// Stores one part of a file under the number given in `chunkNumber`, which is what the ordinary chunked flow  uses: parts are kept by their number rather than by arrival, so a part that failed can be resent under the  same number without restarting the session. Numbering starts at 1, and leaving the number out makes the server  count the parts itself. The answer is always the session, never the file, and this call never completes the  upload: the file appears only after `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. Use  `POST api/2.0/files/{folderId}/session/{sessionId}` instead when the parts go strictly in order and the upload  should complete by itself. A part bigger than `chunkUploadSize` from `GET api/2.0/files/settings` is refused,  so that value is also the size to split the payload by. The first part of a PDF is inspected, and a PDF that  is not a fillable form is refused when the session targets a form-filling room. The session is found by its id  alone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session this part belongs to, as returned in `id` when it was created; a 32-character hexadecimal string.</param>
        /// <param name="chunkNumber">The position of this part in the file, counted from 1. Sending the same number again replaces that part  instead of adding one, which is how a failed part is retried; leaving the number out makes the server count  the parts itself. (optional)</param>
        /// <param name="file">The part of the file to store, sent as the multipart field of the same name. It is kept under the number given  beside it, and a part larger than the portal chunk size is refused. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-async-session/">REST API Reference for UploadAsyncSession Operation</seealso>
        /// <returns>ApiResponse of ChunkedUploadSessionResponseIntegerWrapper</returns>
        ApiResponse<ChunkedUploadSessionResponseIntegerWrapper> UploadAsyncSessionWithHttpInfo(int folderId, string sessionId, int? chunkNumber = default, FileParameter? file = default);
        /// <summary>
        /// Upload the next chunk
        /// </summary>
        /// <remarks>
        /// Sends the next part of a file into the session opened for it, as the multipart `File` field, and lets the  server keep count: parts are appended in the order they arrive, so two of these calls must never run in  parallel on one session. While bytes are still missing the answer describes the session and `uploaded` is  false; when the last part completes the declared size the file is written, its upload links are cleared, it is  marked as new for the room, and the answer comes back with 201, `uploaded` true and the whole file in `file`.  A session created for a payload smaller than `chunkUploadSize` from `GET api/2.0/files/settings` finishes on  the first such call and needs no separate finalize step. A part larger than that limit is refused. The first  part of a PDF is inspected, and a PDF that is not a fillable form is refused when the session targets a  form-filling room. The session is addressed by its id, and the folder in the path is not matched against it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session this part belongs to, as returned in `id` when it was created; the parts of one session must be  sent one after another, not in parallel.</param>
        /// <param name="file">The next part of the file, sent as the multipart field of the same name. Parts are appended in the order they  arrive, and a part larger than the portal chunk size is refused. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-session/">REST API Reference for UploadSession Operation</seealso>
        /// <returns>UploadSessionResponseIntegerWrapper</returns>
        UploadSessionResponseIntegerWrapper UploadSession(int folderId, string sessionId, FileParameter? file = default);

        /// <summary>
        /// Upload the next chunk
        /// </summary>
        /// <remarks>
        /// Sends the next part of a file into the session opened for it, as the multipart `File` field, and lets the  server keep count: parts are appended in the order they arrive, so two of these calls must never run in  parallel on one session. While bytes are still missing the answer describes the session and `uploaded` is  false; when the last part completes the declared size the file is written, its upload links are cleared, it is  marked as new for the room, and the answer comes back with 201, `uploaded` true and the whole file in `file`.  A session created for a payload smaller than `chunkUploadSize` from `GET api/2.0/files/settings` finishes on  the first such call and needs no separate finalize step. A part larger than that limit is refused. The first  part of a PDF is inspected, and a PDF that is not a fillable form is refused when the session targets a  form-filling room. The session is addressed by its id, and the folder in the path is not matched against it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session this part belongs to, as returned in `id` when it was created; the parts of one session must be  sent one after another, not in parallel.</param>
        /// <param name="file">The next part of the file, sent as the multipart field of the same name. Parts are appended in the order they  arrive, and a part larger than the portal chunk size is refused. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-session/">REST API Reference for UploadSession Operation</seealso>
        /// <returns>ApiResponse of UploadSessionResponseIntegerWrapper</returns>
        ApiResponse<UploadSessionResponseIntegerWrapper> UploadSessionWithHttpInfo(int folderId, string sessionId, FileParameter? file = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOperationsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Abort an upload session
        /// </summary>
        /// <remarks>
        /// Cancels a chunked upload opened with `POST api/2.0/files/{folderId}/session` and discards the parts already  received, so nothing of it reaches the folder. The session is found by the id in the path alone: the folder  segment is not matched against it, and neither is the account that opened it, which makes the id the only  secret protecting the transfer. The call is destructive and is not safe to repeat, because the record is gone  afterwards: a second attempt, a session already closed by  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize` and a session that expired after twelve hours of  silence all fail rather than answer as missing. Finalizing removes the session too, so there is nothing left  to abort once the file exists. The answer carries no body. An upload that is simply abandoned needs no call at  all, since the session and its buffered parts are dropped when it expires.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session to cancel, as returned in `id` when it was created: a 32-character hexadecimal string that  identifies the session on its own.</param>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/abort-upload-session/">REST API Reference for AbortUploadSession Operation</seealso>
        /// <returns>Task of void</returns>
        Task AbortUploadSessionAsync(string sessionId, int folderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Abort an upload session
        /// </summary>
        /// <remarks>
        /// Cancels a chunked upload opened with `POST api/2.0/files/{folderId}/session` and discards the parts already  received, so nothing of it reaches the folder. The session is found by the id in the path alone: the folder  segment is not matched against it, and neither is the account that opened it, which makes the id the only  secret protecting the transfer. The call is destructive and is not safe to repeat, because the record is gone  afterwards: a second attempt, a session already closed by  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize` and a session that expired after twelve hours of  silence all fail rather than answer as missing. Finalizing removes the session too, so there is nothing left  to abort once the file exists. The answer carries no body. An upload that is simply abandoned needs no call at  all, since the session and its buffered parts are dropped when it expires.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session to cancel, as returned in `id` when it was created: a 32-character hexadecimal string that  identifies the session on its own.</param>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/abort-upload-session/">REST API Reference for AbortUploadSession Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> AbortUploadSessionWithHttpInfoAsync(string sessionId, int folderId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Add favorite files and folders
        /// </summary>
        /// <remarks>
        /// Marks the listed files and folders as favorites for the calling account. The favorite list is personal:  nothing changes for other members, and the entries stay where they are stored. Read access to each item is  enough, so a room member with view-only rights and a guest may call it. Items the caller cannot read, ids that  do not exist and encrypted files of a private room are skipped without a word, and the answer is `true` even  when nothing was marked, so read the outcome back from `GET api/2.0/files/@favorites` instead of trusting it.  Numeric ids address entries stored in the portal itself, string ids entries on a connected third-party  account, and both kinds may be sent in one request. The call is mutating but safe to repeat: an item already  marked stays listed once. An entry moved to the Trash keeps its mark and is left out of the listing until it  is restored. `returnSingleOperation` arrives with the shared body and does nothing here. Use  `DELETE api/2.0/files/favorites` to undo, or `GET api/2.0/files/favorites/{fileId}` for a single file.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-favorites/">REST API Reference for AddFavorites Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> AddFavoritesAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Add favorite files and folders
        /// </summary>
        /// <remarks>
        /// Marks the listed files and folders as favorites for the calling account. The favorite list is personal:  nothing changes for other members, and the entries stay where they are stored. Read access to each item is  enough, so a room member with view-only rights and a guest may call it. Items the caller cannot read, ids that  do not exist and encrypted files of a private room are skipped without a word, and the answer is `true` even  when nothing was marked, so read the outcome back from `GET api/2.0/files/@favorites` instead of trusting it.  Numeric ids address entries stored in the portal itself, string ids entries on a connected third-party  account, and both kinds may be sent in one request. The call is mutating but safe to repeat: an item already  marked stays listed once. An entry moved to the Trash keeps its mark and is left out of the listing until it  is restored. `returnSingleOperation` arrives with the shared body and does nothing here. Use  `DELETE api/2.0/files/favorites` to undo, or `GET api/2.0/files/favorites/{fileId}` for a single file.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-favorites/">REST API Reference for AddFavorites Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> AddFavoritesWithHttpInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk download
        /// </summary>
        /// <remarks>
        /// Queues a background job that packs the requested files and folders into a single archive, and answers with the  caller's download operations, including the one just started. The archive is not ready when the response  arrives: poll `GET api/2.0/files/fileops` until the operation reports `finished`, then take the address of the  archive from its `url`. Items listed in `fileConvertIds` are converted to the format named there before they  are packed, while the items of `fileIds` are packed as they are. Read access to every listed item is required:  an item the caller may not read fails the whole call with 403, and an id that resolves to nothing is answered  as missing, so filter the selection beforehand. Only one download at a time is allowed per caller, and a  second call made while the first is still running is refused with 403 as well. An empty selection queues  nothing and simply answers with the operations that are already there. An anonymous caller may use the call  for the items covered by the external link they hold.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadRequestDto">The files and folders to pack into one archive, together with the formats they are converted to. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/bulk-download/">REST API Reference for BulkDownload Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        Task<FileOperationArrayWrapper> BulkDownloadAsync(DownloadRequestDto? downloadRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Bulk download
        /// </summary>
        /// <remarks>
        /// Queues a background job that packs the requested files and folders into a single archive, and answers with the  caller's download operations, including the one just started. The archive is not ready when the response  arrives: poll `GET api/2.0/files/fileops` until the operation reports `finished`, then take the address of the  archive from its `url`. Items listed in `fileConvertIds` are converted to the format named there before they  are packed, while the items of `fileIds` are packed as they are. Read access to every listed item is required:  an item the caller may not read fails the whole call with 403, and an id that resolves to nothing is answered  as missing, so filter the selection beforehand. Only one download at a time is allowed per caller, and a  second call made while the first is still running is refused with 403 as well. An empty selection queues  nothing and simply answers with the operations that are already there. An anonymous caller may use the call  for the items covered by the external link they hold.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadRequestDto">The files and folders to pack into one archive, together with the formats they are converted to. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/bulk-download/">REST API Reference for BulkDownload Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        Task<ApiResponse<FileOperationArrayWrapper>> BulkDownloadWithHttpInfoAsync(DownloadRequestDto? downloadRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get conversion status
        /// </summary>
        /// <remarks>
        /// Reports how far the conversion of a file has got, as a list that holds one entry while the portal still knows  about that conversion and nothing once it is over. Read `progress`, which counts from 0 to 100, `error` for  the reason a conversion failed, and `file`, which carries the converted file as soon as it exists. Queue the  conversion with `PUT api/2.0/files/file/{fileId}/checkconversion` and poll this operation until the entry  reaches 100 or disappears: a finished entry is handed out once and then dropped, and an entry whose conversion  stopped is discarded a few minutes later, so an empty list means either already reported or never started  rather than an error. The same empty list is the answer for an identifier no file matches. Passing  `start=true` starts the conversion as well, with the format from the portal settings and no password, which  makes that one flag mutating; without it the operation is read-only. The caller needs read access to the file,  and anyone else is refused.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file whose conversion is asked about.</param>
        /// <param name="start">Whether to start the conversion as well: `true` queues it with the default output format and no password,  `false` only reports what the portal already knows. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-conversion-status/">REST API Reference for CheckConversionStatus Operation</seealso>
        /// <returns>Task of ConversationResultArrayWrapper</returns>
        Task<ConversationResultArrayWrapper> CheckConversionStatusAsync(int fileId, bool? start = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get conversion status
        /// </summary>
        /// <remarks>
        /// Reports how far the conversion of a file has got, as a list that holds one entry while the portal still knows  about that conversion and nothing once it is over. Read `progress`, which counts from 0 to 100, `error` for  the reason a conversion failed, and `file`, which carries the converted file as soon as it exists. Queue the  conversion with `PUT api/2.0/files/file/{fileId}/checkconversion` and poll this operation until the entry  reaches 100 or disappears: a finished entry is handed out once and then dropped, and an entry whose conversion  stopped is discarded a few minutes later, so an empty list means either already reported or never started  rather than an error. The same empty list is the answer for an identifier no file matches. Passing  `start=true` starts the conversion as well, with the format from the portal settings and no password, which  makes that one flag mutating; without it the operation is read-only. The caller needs read access to the file,  and anyone else is refused.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file whose conversion is asked about.</param>
        /// <param name="start">Whether to start the conversion as well: `true` queues it with the default output format and no password,  `false` only reports what the portal already knows. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-conversion-status/">REST API Reference for CheckConversionStatus Operation</seealso>
        /// <returns>Task of ApiResponse (ConversationResultArrayWrapper)</returns>
        Task<ApiResponse<ConversationResultArrayWrapper>> CheckConversionStatusWithHttpInfoAsync(int fileId, bool? start = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Check move or copy conflicts
        /// </summary>
        /// <remarks>
        /// Reports which of the requested files and folders already have a same-named entry in `destFolderId`, so that  the clash can be settled before the move or the copy is started. Nothing is moved, copied or changed by the  call, although the address is shared with `PUT api/2.0/files/fileops/move`: the answer is the part of the  request that clashes, and an empty array means the batch would go through without one. The  `conflictResolveType` of the request is not taken into account — clashing items are reported whatever it says  — and encrypted files are left out of the report. A source id that resolves to nothing is not an error and is  passed over. The caller needs create access to the destination: an archived room and a room the caller cannot  write to are refused with 403, a destination that does not exist is answered as missing, and a request without  `destFolderId` is rejected as an invalid request. To learn whether the destination accepts the files at all  use `GET api/2.0/files/fileops/checkdestfolder`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-batch-items/">REST API Reference for CheckMoveOrCopyBatchItems Operation</seealso>
        /// <returns>Task of FileEntryBaseArrayWrapper</returns>
        Task<FileEntryBaseArrayWrapper> CheckMoveOrCopyBatchItemsAsync(BatchRequestDto? inDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Check move or copy conflicts
        /// </summary>
        /// <remarks>
        /// Reports which of the requested files and folders already have a same-named entry in `destFolderId`, so that  the clash can be settled before the move or the copy is started. Nothing is moved, copied or changed by the  call, although the address is shared with `PUT api/2.0/files/fileops/move`: the answer is the part of the  request that clashes, and an empty array means the batch would go through without one. The  `conflictResolveType` of the request is not taken into account — clashing items are reported whatever it says  — and encrypted files are left out of the report. A source id that resolves to nothing is not an error and is  passed over. The caller needs create access to the destination: an archived room and a room the caller cannot  write to are refused with 403, a destination that does not exist is answered as missing, and a request without  `destFolderId` is rejected as an invalid request. To learn whether the destination accepts the files at all  use `GET api/2.0/files/fileops/checkdestfolder`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-batch-items/">REST API Reference for CheckMoveOrCopyBatchItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryBaseArrayWrapper)</returns>
        Task<ApiResponse<FileEntryBaseArrayWrapper>> CheckMoveOrCopyBatchItemsWithHttpInfoAsync(BatchRequestDto? inDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Check the destination folder
        /// </summary>
        /// <remarks>
        /// Reports whether the destination folder accepts the listed files, before a move or a copy is started. Only  `fileIds` and `destFolderId` are read from the request: `result` says whether all of the files are accepted,  only some of them or none, and `files` names the ones that are. The check is about what the destination allows  to be stored in it rather than about name clashes — everywhere except a form-filling room every file is  accepted, while a form-filling room accepts only PDF forms, so a text document offered to one comes back as  none accepted. The caller needs create access to the destination, so a room the caller cannot write to and an  archived room are refused with 403, a destination that does not exist is answered as missing, and a request  without `destFolderId` is rejected as an invalid request. Folder ids and the copying options of the request  play no part here. The call changes nothing; for same-named entries at the destination use  `GET api/2.0/files/fileops/move`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-dest-folder/">REST API Reference for CheckMoveOrCopyDestFolder Operation</seealso>
        /// <returns>Task of CheckDestFolderWrapper</returns>
        Task<CheckDestFolderWrapper> CheckMoveOrCopyDestFolderAsync(BatchRequestDto? inDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Check the destination folder
        /// </summary>
        /// <remarks>
        /// Reports whether the destination folder accepts the listed files, before a move or a copy is started. Only  `fileIds` and `destFolderId` are read from the request: `result` says whether all of the files are accepted,  only some of them or none, and `files` names the ones that are. The check is about what the destination allows  to be stored in it rather than about name clashes — everywhere except a form-filling room every file is  accepted, while a form-filling room accepts only PDF forms, so a text document offered to one comes back as  none accepted. The caller needs create access to the destination, so a room the caller cannot write to and an  archived room are refused with 403, a destination that does not exist is answered as missing, and a request  without `destFolderId` is rejected as an invalid request. Folder ids and the copying options of the request  play no part here. The call changes nothing; for same-named entries at the destination use  `GET api/2.0/files/fileops/move`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-dest-folder/">REST API Reference for CheckMoveOrCopyDestFolder Operation</seealso>
        /// <returns>Task of ApiResponse (CheckDestFolderWrapper)</returns>
        Task<ApiResponse<CheckDestFolderWrapper>> CheckMoveOrCopyDestFolderWithHttpInfoAsync(BatchRequestDto? inDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Copy files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that copies the requested files and folders into `destFolderId`, leaving the originals  where they are, and answers with the caller's move and copy operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`; its `files` and `folders` then name what  was produced. Before starting, `GET api/2.0/files/fileops/move` reports which items already have a same-named  entry at the destination and `conflictResolveType` decides what happens to them, while  `GET api/2.0/files/fileops/checkdestfolder` reports whether the destination accepts the files at all. The  caller needs create access to the destination — room manager or content-creator rights inside a room — and  read access to every source item; anything less is refused with 403. With `content=true` each listed folder is  replaced by its own files and subfolders, so the folder itself is not recreated at the destination. An empty  selection queues nothing and answers with the operations that are already there. To remove the originals  instead use `PUT api/2.0/files/fileops/move`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-batch-items/">REST API Reference for CopyBatchItems Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        Task<FileOperationArrayWrapper> CopyBatchItemsAsync(BatchRequestDto? batchRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Copy files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that copies the requested files and folders into `destFolderId`, leaving the originals  where they are, and answers with the caller's move and copy operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`; its `files` and `folders` then name what  was produced. Before starting, `GET api/2.0/files/fileops/move` reports which items already have a same-named  entry at the destination and `conflictResolveType` decides what happens to them, while  `GET api/2.0/files/fileops/checkdestfolder` reports whether the destination accepts the files at all. The  caller needs create access to the destination — room manager or content-creator rights inside a room — and  read access to every source item; anything less is refused with 403. With `content=true` each listed folder is  replaced by its own files and subfolders, so the folder itself is not recreated at the destination. An empty  selection queues nothing and answers with the operations that are already there. To remove the originals  instead use `PUT api/2.0/files/fileops/move`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-batch-items/">REST API Reference for CopyBatchItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        Task<ApiResponse<FileOperationArrayWrapper>> CopyBatchItemsWithHttpInfoAsync(BatchRequestDto? batchRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Chunked upload
        /// </summary>
        /// <remarks>
        /// Deprecated in favour of `POST api/2.0/files/{folderId}/session`, which opens the same session and returns it  without the success envelope used here; new callers should go there. Reserves a chunked upload of a file in  the folder named by the path: the title comes from `fileName`, the declared payload size from `fileSize`, and  the answer carries the session id every later call quotes, the address of the standalone chunk handler, the  moment an idle session is dropped and the reserved byte count. No content is stored yet. Send the payload as  multipart parts to `POST api/2.0/files/{folderId}/session/{sessionId}/upload`, keeping each part within  `chunkUploadSize` from `GET api/2.0/files/settings`, then close the session with  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. The caller needs the right to add content to the  target folder, which room managers and content creators have and readers, editors and guests do not: they get  403, as does a section root such as Rooms or Archive, while an unknown folder is answered as missing. A  payload above the portal limit for chunked uploads is refused before the session exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="sessionRequest">The file the session is opened for, and how a clash with an existing name is settled.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session/">REST API Reference for CreateUploadSession Operation</seealso>
        /// <returns>Task of ChunkedUploadSessionResponseWrapperIntegerWrapper</returns>
        [Obsolete]
        Task<ChunkedUploadSessionResponseWrapperIntegerWrapper> CreateUploadSessionAsync(int folderId, SessionRequest sessionRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Chunked upload
        /// </summary>
        /// <remarks>
        /// Deprecated in favour of `POST api/2.0/files/{folderId}/session`, which opens the same session and returns it  without the success envelope used here; new callers should go there. Reserves a chunked upload of a file in  the folder named by the path: the title comes from `fileName`, the declared payload size from `fileSize`, and  the answer carries the session id every later call quotes, the address of the standalone chunk handler, the  moment an idle session is dropped and the reserved byte count. No content is stored yet. Send the payload as  multipart parts to `POST api/2.0/files/{folderId}/session/{sessionId}/upload`, keeping each part within  `chunkUploadSize` from `GET api/2.0/files/settings`, then close the session with  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. The caller needs the right to add content to the  target folder, which room managers and content creators have and readers, editors and guests do not: they get  403, as does a section root such as Rooms or Archive, while an unknown folder is answered as missing. A  payload above the portal limit for chunked uploads is refused before the session exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="sessionRequest">The file the session is opened for, and how a clash with an existing name is settled.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session/">REST API Reference for CreateUploadSession Operation</seealso>
        /// <returns>Task of ApiResponse (ChunkedUploadSessionResponseWrapperIntegerWrapper)</returns>
        [Obsolete]
        Task<ApiResponse<ChunkedUploadSessionResponseWrapperIntegerWrapper>> CreateUploadSessionWithHttpInfoAsync(int folderId, SessionRequest sessionRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an upload session
        /// </summary>
        /// <remarks>
        /// Opens a chunked upload session for a file in the folder named by the path and returns the session itself,  which is the difference from the deprecated `POST api/2.0/files/{folderId}/upload/create_session` and its  success envelope. The answer gives `id`, quoted by every later call, `location` for the standalone chunk  handler used by clients that bypass this API, `expired`, and `bytes_total` echoing the reserved size. Whether  parts are really needed follows from `fileSize`: below `chunkUploadSize` from `GET api/2.0/files/settings` the  whole payload goes in one `POST api/2.0/files/{folderId}/session/{sessionId}`, which stores the file and  answers 201, and above it the parts go one by one to  `POST api/2.0/files/{folderId}/session/{sessionId}/upload` and the file appears only after  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. The caller must be allowed to add content to the  folder, so readers, editors and guests are refused, a section root is refused as well, and an unknown folder  is answered as missing. Nothing is written until the parts arrive, and an abandoned session disappears twelve  hours later.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="sessionRequest">The file the session is opened for, and how a clash with an existing name is settled.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session-in-folder/">REST API Reference for CreateUploadSessionInFolder Operation</seealso>
        /// <returns>Task of ChunkedUploadSessionResponseIntegerWrapper</returns>
        Task<ChunkedUploadSessionResponseIntegerWrapper> CreateUploadSessionInFolderAsync(int folderId, SessionRequest sessionRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an upload session
        /// </summary>
        /// <remarks>
        /// Opens a chunked upload session for a file in the folder named by the path and returns the session itself,  which is the difference from the deprecated `POST api/2.0/files/{folderId}/upload/create_session` and its  success envelope. The answer gives `id`, quoted by every later call, `location` for the standalone chunk  handler used by clients that bypass this API, `expired`, and `bytes_total` echoing the reserved size. Whether  parts are really needed follows from `fileSize`: below `chunkUploadSize` from `GET api/2.0/files/settings` the  whole payload goes in one `POST api/2.0/files/{folderId}/session/{sessionId}`, which stores the file and  answers 201, and above it the parts go one by one to  `POST api/2.0/files/{folderId}/session/{sessionId}/upload` and the file appears only after  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. The caller must be allowed to add content to the  folder, so readers, editors and guests are refused, a section root is refused as well, and an unknown folder  is answered as missing. Nothing is written until the parts arrive, and an abandoned session disappears twelve  hours later.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="sessionRequest">The file the session is opened for, and how a clash with an existing name is settled.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session-in-folder/">REST API Reference for CreateUploadSessionInFolder Operation</seealso>
        /// <returns>Task of ApiResponse (ChunkedUploadSessionResponseIntegerWrapper)</returns>
        Task<ApiResponse<ChunkedUploadSessionResponseIntegerWrapper>> CreateUploadSessionInFolderWithHttpInfoAsync(int folderId, SessionRequest sessionRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that deletes the requested files and folders, and answers with the caller's delete  operations, including the one just started. Poll `GET api/2.0/files/fileops` until the operation reports  `finished`, and read its `error`: a failure on a single item is reported there rather than as a status code.  With `immediately=false` the items are moved to the caller's Trash and can be restored from it, while  `immediately=true` removes them at once and for good; deleting a folder takes everything inside it either way.  The call is destructive and it is not a no-op on repetition — a second call with the same ids deletes whatever  has been restored in the meantime. Access is checked before the job is queued: deleting from a room requires  room manager or content-creator rights, editing or read rights are refused with 403, and an id that resolves  to nothing is answered as missing. An empty selection queues nothing and answers with the operations that are  already there. To clear the Trash itself use `PUT api/2.0/files/fileops/emptytrash`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteBatchRequestDto">The files and folders to delete, and how final the deletion is. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-batch-items/">REST API Reference for DeleteBatchItems Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        Task<FileOperationArrayWrapper> DeleteBatchItemsAsync(DeleteBatchRequestDto? deleteBatchRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that deletes the requested files and folders, and answers with the caller's delete  operations, including the one just started. Poll `GET api/2.0/files/fileops` until the operation reports  `finished`, and read its `error`: a failure on a single item is reported there rather than as a status code.  With `immediately=false` the items are moved to the caller's Trash and can be restored from it, while  `immediately=true` removes them at once and for good; deleting a folder takes everything inside it either way.  The call is destructive and it is not a no-op on repetition — a second call with the same ids deletes whatever  has been restored in the meantime. Access is checked before the job is queued: deleting from a room requires  room manager or content-creator rights, editing or read rights are refused with 403, and an id that resolves  to nothing is answered as missing. An empty selection queues nothing and answers with the operations that are  already there. To clear the Trash itself use `PUT api/2.0/files/fileops/emptytrash`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteBatchRequestDto">The files and folders to delete, and how final the deletion is. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-batch-items/">REST API Reference for DeleteBatchItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        Task<ApiResponse<FileOperationArrayWrapper>> DeleteBatchItemsWithHttpInfoAsync(DeleteBatchRequestDto? deleteBatchRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete favorite files and folders
        /// </summary>
        /// <remarks>
        /// Removes the favorite mark from the listed files and folders for the calling account. Nothing is deleted from  storage: the entries keep their place, their content and their sharing, and only disappear from  `GET api/2.0/files/@favorites`; to delete the entries themselves call `PUT api/2.0/files/fileops/delete`  instead. Marks of other members are untouched, and read access to each item is enough to call it. The ids go  into the JSON body documented here; the same route also accepts them as repeated `fileIds` and `folderIds`  query parameters, but only in a request that carries no JSON body at all. Numeric ids address entries stored  in the portal itself, string ids entries on a connected third-party account. The answer is `true` whenever the  request was understood, which an empty request, an id that does not exist and an item that was never marked  all achieve, so it does not report how many marks were dropped. `returnSingleOperation` arrives with the  shared body and does nothing here. Repeating the call is safe. Use `POST api/2.0/files/favorites` to mark  entries again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-favorites-from-body/">REST API Reference for DeleteFavoritesFromBody Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> DeleteFavoritesFromBodyAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete favorite files and folders
        /// </summary>
        /// <remarks>
        /// Removes the favorite mark from the listed files and folders for the calling account. Nothing is deleted from  storage: the entries keep their place, their content and their sharing, and only disappear from  `GET api/2.0/files/@favorites`; to delete the entries themselves call `PUT api/2.0/files/fileops/delete`  instead. Marks of other members are untouched, and read access to each item is enough to call it. The ids go  into the JSON body documented here; the same route also accepts them as repeated `fileIds` and `folderIds`  query parameters, but only in a request that carries no JSON body at all. Numeric ids address entries stored  in the portal itself, string ids entries on a connected third-party account. The answer is `true` whenever the  request was understood, which an empty request, an id that does not exist and an item that was never marked  all achieve, so it does not report how many marks were dropped. `returnSingleOperation` arrives with the  shared body and does nothing here. Repeating the call is safe. Use `POST api/2.0/files/favorites` to mark  entries again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-favorites-from-body/">REST API Reference for DeleteFavoritesFromBody Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> DeleteFavoritesFromBodyWithHttpInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete file versions
        /// </summary>
        /// <remarks>
        /// Queues a background job that removes the listed versions from the history of one file, and answers with the  caller's delete operations, including the one just started. Poll `GET api/2.0/files/fileops` until the  operation reports `finished`; a failure met while the job runs is reported in its `error` rather than as a  status code. Removal is permanent — deleted versions do not travel through Trash and cannot be restored, while  the file itself stays in place with the versions that are left. Send the numbers that  `GET api/2.0/files/file/{fileId}/history` reports, and send at least one: an empty list is not an empty  request, it deletes the whole file instead. The number of the current version is refused before anything is  queued, while numbers that no longer exist are passed over without a complaint. The caller needs the rights  that deleting the file itself would need, so a member with read-only rights is refused, as are a file in an  archived room and a file that is already in Trash, and a file that does not exist is answered as missing. To  delete the file itself use `PUT api/2.0/files/fileops/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteVersionBatchRequestDto">The file whose versions are deleted, and the versions to delete. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file-versions/">REST API Reference for DeleteFileVersions Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        Task<FileOperationArrayWrapper> DeleteFileVersionsAsync(DeleteVersionBatchRequestDto? deleteVersionBatchRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete file versions
        /// </summary>
        /// <remarks>
        /// Queues a background job that removes the listed versions from the history of one file, and answers with the  caller's delete operations, including the one just started. Poll `GET api/2.0/files/fileops` until the  operation reports `finished`; a failure met while the job runs is reported in its `error` rather than as a  status code. Removal is permanent — deleted versions do not travel through Trash and cannot be restored, while  the file itself stays in place with the versions that are left. Send the numbers that  `GET api/2.0/files/file/{fileId}/history` reports, and send at least one: an empty list is not an empty  request, it deletes the whole file instead. The number of the current version is refused before anything is  queued, while numbers that no longer exist are passed over without a complaint. The caller needs the rights  that deleting the file itself would need, so a member with read-only rights is refused, as are a file in an  archived room and a file that is already in Trash, and a file that does not exist is answered as missing. To  delete the file itself use `PUT api/2.0/files/fileops/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteVersionBatchRequestDto">The file whose versions are deleted, and the versions to delete. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file-versions/">REST API Reference for DeleteFileVersions Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        Task<ApiResponse<FileOperationArrayWrapper>> DeleteFileVersionsWithHttpInfoAsync(DeleteVersionBatchRequestDto? deleteVersionBatchRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Duplicate files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that copies each requested file and folder next to itself, into the folder where it  already is, and answers with the caller's duplicate operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. The copies keep the name of the original  with a numeric suffix, so nothing is overwritten and every repetition adds one more copy; duplicating a folder  duplicates its content as well. No destination is taken — to place a copy somewhere else use  `PUT api/2.0/files/fileops/copy`. The caller needs the rights that creating an item in that folder would need,  which inside a room means room manager or content-creator rights: read or editing rights, and an item the  caller has no access to at all, are refused with 403. An empty selection queues nothing and answers with the  operations that are already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="duplicateRequestDto">The files and folders to duplicate. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/duplicate-batch-items/">REST API Reference for DuplicateBatchItems Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        Task<FileOperationArrayWrapper> DuplicateBatchItemsAsync(DuplicateRequestDto? duplicateRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Duplicate files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that copies each requested file and folder next to itself, into the folder where it  already is, and answers with the caller's duplicate operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. The copies keep the name of the original  with a numeric suffix, so nothing is overwritten and every repetition adds one more copy; duplicating a folder  duplicates its content as well. No destination is taken — to place a copy somewhere else use  `PUT api/2.0/files/fileops/copy`. The caller needs the rights that creating an item in that folder would need,  which inside a room means room manager or content-creator rights: read or editing rights, and an item the  caller has no access to at all, are refused with 403. An empty selection queues nothing and answers with the  operations that are already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="duplicateRequestDto">The files and folders to duplicate. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/duplicate-batch-items/">REST API Reference for DuplicateBatchItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        Task<ApiResponse<FileOperationArrayWrapper>> DuplicateBatchItemsWithHttpInfoAsync(DuplicateRequestDto? duplicateRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Empty the Trash folder
        /// </summary>
        /// <remarks>
        /// Queues a background job that permanently removes the content of the caller's own Trash, and answers with the  caller's delete operations, including the one just started. Poll `GET api/2.0/files/fileops` until the  operation reports `finished`. Every authenticated account may empty its own Trash and only its own: no  per-item access check takes place because nothing outside the caller's Trash is touched. With `folderType` the  sweep is narrowed to the items that were originally stored in sections and rooms of the named types, so  clearing what came from personal documents leaves what came from rooms untouched; without the parameter the  whole Trash is emptied. What is removed here cannot be restored afterwards, which is the difference from  `PUT api/2.0/files/fileops/delete`, where `immediately=false` puts items into Trash in the first place.  Calling it on an already empty Trash queues nothing and answers with the operations that are already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="single">Which operations the answer carries: `true` returns the operation this call started and nothing else, `false`  returns every delete operation that the caller has running or unread. (optional)</param>
        /// <param name="folderType">Limits the sweep to the items whose original location was inside a section or a room of one of the named  types, leaving the rest of the Trash untouched; without the parameter the whole Trash is emptied. `5` covers  what was deleted from personal documents, `14` what was deleted from rooms. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/empty-trash/">REST API Reference for EmptyTrash Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        Task<FileOperationArrayWrapper> EmptyTrashAsync(bool? single = default, List<int>? folderType = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Empty the Trash folder
        /// </summary>
        /// <remarks>
        /// Queues a background job that permanently removes the content of the caller's own Trash, and answers with the  caller's delete operations, including the one just started. Poll `GET api/2.0/files/fileops` until the  operation reports `finished`. Every authenticated account may empty its own Trash and only its own: no  per-item access check takes place because nothing outside the caller's Trash is touched. With `folderType` the  sweep is narrowed to the items that were originally stored in sections and rooms of the named types, so  clearing what came from personal documents leaves what came from rooms untouched; without the parameter the  whole Trash is emptied. What is removed here cannot be restored afterwards, which is the difference from  `PUT api/2.0/files/fileops/delete`, where `immediately=false` puts items into Trash in the first place.  Calling it on an already empty Trash queues nothing and answers with the operations that are already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="single">Which operations the answer carries: `true` returns the operation this call started and nothing else, `false`  returns every delete operation that the caller has running or unread. (optional)</param>
        /// <param name="folderType">Limits the sweep to the items whose original location was inside a section or a room of one of the named  types, leaving the rest of the Trash untouched; without the parameter the whole Trash is emptied. `5` covers  what was deleted from personal documents, `14` what was deleted from rooms. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/empty-trash/">REST API Reference for EmptyTrash Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        Task<ApiResponse<FileOperationArrayWrapper>> EmptyTrashWithHttpInfoAsync(bool? single = default, List<int>? folderType = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Finalize an upload session
        /// </summary>
        /// <remarks>
        /// Assembles the parts received so far into the file the session was opened for and closes the session. What  comes out depends on how the session started: one opened against an existing file through  `POST api/2.0/files/file/{fileId}/edit_session` replaces that content in place and keeps the version number,  while one opened against a folder either creates the file or, when a file of the same name was taken over,  stores the content as its next version. A form loses its filling state on the way in. The answer arrives with  201 and carries the identifiers of the file together with the file itself. The call ends the session: the  record and the buffered parts are removed, so it cannot be repeated and there is nothing left to abort  afterwards. Running it before all the declared bytes have arrived assembles whatever is there, so read the  progress from the chunk calls first. An unknown, already closed or expired session id fails instead of  answering as missing.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session to assemble, as returned in `id` when it was created: a 32-character hexadecimal string that  identifies the session on its own.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/finalize-session/">REST API Reference for FinalizeSession Operation</seealso>
        /// <returns>Task of UploadSessionResponseIntegerWrapper</returns>
        Task<UploadSessionResponseIntegerWrapper> FinalizeSessionAsync(int folderId, string sessionId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Finalize an upload session
        /// </summary>
        /// <remarks>
        /// Assembles the parts received so far into the file the session was opened for and closes the session. What  comes out depends on how the session started: one opened against an existing file through  `POST api/2.0/files/file/{fileId}/edit_session` replaces that content in place and keeps the version number,  while one opened against a folder either creates the file or, when a file of the same name was taken over,  stores the content as its next version. A form loses its filling state on the way in. The answer arrives with  201 and carries the identifiers of the file together with the file itself. The call ends the session: the  record and the buffered parts are removed, so it cannot be repeated and there is nothing left to abort  afterwards. Running it before all the declared bytes have arrived assembles whatever is there, so read the  progress from the chunk calls first. An unknown, already closed or expired session id fails instead of  answering as missing.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session to assemble, as returned in `id` when it was created: a 32-character hexadecimal string that  identifies the session on its own.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/finalize-session/">REST API Reference for FinalizeSession Operation</seealso>
        /// <returns>Task of ApiResponse (UploadSessionResponseIntegerWrapper)</returns>
        Task<ApiResponse<UploadSessionResponseIntegerWrapper>> FinalizeSessionWithHttpInfoAsync(int folderId, string sessionId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get active file operations
        /// </summary>
        /// <remarks>
        /// Returns the background file operations of the caller that are still running or whose finished result has not  been read yet, grouped by kind: duplications first, then moves and copies, deletions, downloads and  mark-as-read. This is the polling target for every operation in this section — an operation appears here as  soon as it is queued and carries `progress` from 0 to 100, `finished`, the `error` of a failed item and, for a  download, the address of the archive in `url`. A record is dropped once its finished state has been handed  out, so a completed operation is reported once and an empty array means there is nothing left to report rather  than that the work failed. Pass `id` to follow a single operation; an id that is not among the caller's  operations gives an empty array. Operations are private to the account that started them, an anonymous caller  being scoped to the session of the external link. The call changes nothing. To follow one kind only use  `GET api/2.0/files/fileops/{operationType}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The operation to report on, as returned in `id` when it was started; without it every operation of the caller  is reported. An id that is not among the caller's operations gives an empty answer rather than an error. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses/">REST API Reference for GetOperationStatuses Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        Task<FileOperationArrayWrapper> GetOperationStatusesAsync(string? id = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get active file operations
        /// </summary>
        /// <remarks>
        /// Returns the background file operations of the caller that are still running or whose finished result has not  been read yet, grouped by kind: duplications first, then moves and copies, deletions, downloads and  mark-as-read. This is the polling target for every operation in this section — an operation appears here as  soon as it is queued and carries `progress` from 0 to 100, `finished`, the `error` of a failed item and, for a  download, the address of the archive in `url`. A record is dropped once its finished state has been handed  out, so a completed operation is reported once and an empty array means there is nothing left to report rather  than that the work failed. Pass `id` to follow a single operation; an id that is not among the caller's  operations gives an empty array. Operations are private to the account that started them, an anonymous caller  being scoped to the session of the external link. The call changes nothing. To follow one kind only use  `GET api/2.0/files/fileops/{operationType}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The operation to report on, as returned in `id` when it was started; without it every operation of the caller  is reported. An id that is not among the caller's operations gives an empty answer rather than an error. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses/">REST API Reference for GetOperationStatuses Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        Task<ApiResponse<FileOperationArrayWrapper>> GetOperationStatusesWithHttpInfoAsync(string? id = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get file operations by type
        /// </summary>
        /// <remarks>
        /// Returns the background file operations of the caller that are of one kind, named by the number in the route:  `1` for a copy, `2` for a deletion, `3` for a download, `4` for a mark-as-read and `7` for a duplication. The  answer carries the same records as `GET api/2.0/files/fileops`, with the same rule that a finished operation  is reported once and then dropped, and `id` narrows it further to a single operation. Moves, kind `0`, cannot  be read through this route: the address `api/2.0/files/fileops/move` belongs to another operation, so read  moves from `GET api/2.0/files/fileops` and pick the records whose `operation` is `0`. A kind that has no queue  of its own — `5` for an import, `6` for a conversion — is accepted and answers with an empty array, while a  number outside the operation type is rejected as an invalid request. The call changes nothing and never shows  another account's operations.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationType">The kind of operation the answer is limited to. Only the kinds that have a queue of their own ever carry  records — a copy, a deletion, a download, a mark-as-read and a duplication — and moves cannot be read through  this route at all, because its address belongs to another operation.</param>
        /// <param name="id">The operation to report on, as returned in `id` when it was started; without it every operation of the caller  is reported. An id that is not among the caller's operations gives an empty answer rather than an error. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses-by-type/">REST API Reference for GetOperationStatusesByType Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        Task<FileOperationArrayWrapper> GetOperationStatusesByTypeAsync(FileOperationType operationType, string? id = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get file operations by type
        /// </summary>
        /// <remarks>
        /// Returns the background file operations of the caller that are of one kind, named by the number in the route:  `1` for a copy, `2` for a deletion, `3` for a download, `4` for a mark-as-read and `7` for a duplication. The  answer carries the same records as `GET api/2.0/files/fileops`, with the same rule that a finished operation  is reported once and then dropped, and `id` narrows it further to a single operation. Moves, kind `0`, cannot  be read through this route: the address `api/2.0/files/fileops/move` belongs to another operation, so read  moves from `GET api/2.0/files/fileops` and pick the records whose `operation` is `0`. A kind that has no queue  of its own — `5` for an import, `6` for a conversion — is accepted and answers with an empty array, while a  number outside the operation type is rejected as an invalid request. The call changes nothing and never shows  another account's operations.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationType">The kind of operation the answer is limited to. Only the kinds that have a queue of their own ever carry  records — a copy, a deletion, a download, a mark-as-read and a duplication — and moves cannot be read through  this route at all, because its address belongs to another operation.</param>
        /// <param name="id">The operation to report on, as returned in `id` when it was started; without it every operation of the caller  is reported. An id that is not among the caller's operations gives an empty answer rather than an error. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses-by-type/">REST API Reference for GetOperationStatusesByType Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        Task<ApiResponse<FileOperationArrayWrapper>> GetOperationStatusesByTypeWithHttpInfoAsync(FileOperationType operationType, string? id = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Mark files and folders as read
        /// </summary>
        /// <remarks>
        /// Queues a background job that clears the new-item badge from the requested files and folders for the calling  account, and answers with the caller's mark-as-read operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. Marking a folder clears the badges of  everything inside it as well. Items the caller cannot read are passed over in silence rather than refused, so  the call succeeds even when the whole selection is inaccessible, and an empty selection queues nothing and  answers with the operations that are already there. Repeating the call on items that are already read changes  nothing, and nothing is opened, moved or modified by it — only the caller's own badges are affected, while  other members keep theirs. To see what is currently marked as new use `GET api/2.0/files/{folderId}/news` for  one folder and `GET api/2.0/files/rooms/news` for the rooms of the caller.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-as-read/">REST API Reference for MarkAsRead Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        Task<FileOperationArrayWrapper> MarkAsReadAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Mark files and folders as read
        /// </summary>
        /// <remarks>
        /// Queues a background job that clears the new-item badge from the requested files and folders for the calling  account, and answers with the caller's mark-as-read operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. Marking a folder clears the badges of  everything inside it as well. Items the caller cannot read are passed over in silence rather than refused, so  the call succeeds even when the whole selection is inaccessible, and an empty selection queues nothing and  answers with the operations that are already there. Repeating the call on items that are already read changes  nothing, and nothing is opened, moved or modified by it — only the caller's own badges are affected, while  other members keep theirs. To see what is currently marked as new use `GET api/2.0/files/{folderId}/news` for  one folder and `GET api/2.0/files/rooms/news` for the rooms of the caller.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-as-read/">REST API Reference for MarkAsRead Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        Task<ApiResponse<FileOperationArrayWrapper>> MarkAsReadWithHttpInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Move files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that moves the requested files and folders into `destFolderId`, removing them from  where they were, and answers with the caller's move and copy operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. Before starting,  `GET api/2.0/files/fileops/move` reports which items already have a same-named entry at the destination and  `conflictResolveType` decides what happens to them, while `GET api/2.0/files/fileops/checkdestfolder` reports  whether the destination accepts the files at all. The caller needs create access to the destination and the  right to take the items out of their source, which is why room members with editing or review rights are  refused with 403, and why content-creator rights inside a room allow copying an item out of it but not moving  it. A room cannot be moved this way — use `PUT api/2.0/files/rooms/{id}/archive` instead. To keep the  originals use `PUT api/2.0/files/fileops/copy`. An empty selection queues nothing.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-batch-items/">REST API Reference for MoveBatchItems Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        Task<FileOperationArrayWrapper> MoveBatchItemsAsync(BatchRequestDto? batchRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Move files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that moves the requested files and folders into `destFolderId`, removing them from  where they were, and answers with the caller's move and copy operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. Before starting,  `GET api/2.0/files/fileops/move` reports which items already have a same-named entry at the destination and  `conflictResolveType` decides what happens to them, while `GET api/2.0/files/fileops/checkdestfolder` reports  whether the destination accepts the files at all. The caller needs create access to the destination and the  right to take the items out of their source, which is why room members with editing or review rights are  refused with 403, and why content-creator rights inside a room allow copying an item out of it but not moving  it. A room cannot be moved this way — use `PUT api/2.0/files/rooms/{id}/archive` instead. To keep the  originals use `PUT api/2.0/files/fileops/copy`. An empty selection queues nothing.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-batch-items/">REST API Reference for MoveBatchItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        Task<ApiResponse<FileOperationArrayWrapper>> MoveBatchItemsWithHttpInfoAsync(BatchRequestDto? batchRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Start file conversion
        /// </summary>
        /// <remarks>
        /// Queues the conversion of a file into the portal's own editable format and answers with the conversion entry  the caller is to poll. The whole body may be omitted, in which case the defaults apply. `outputType` names the  target format and, left empty, the portal's default for that kind of document is used; `password` unlocks a  protected source file; `version` converts an older version instead of the current one. `createNewIfExist`  decides where the result goes: with `true` a new file is created beside the source, while with `false`, the  default, the converted file that already exists is replaced. `sync=true` converts inside the request and  answers with the finished result instead of a queue entry, which is only sensible for small documents.  Otherwise poll `GET api/2.0/files/file/{fileId}/checkconversion` until `progress` reaches 100 and take the  converted file from `file`. Only formats the portal has to convert are accepted; anything already editable,  and anything it cannot convert, is answered without work being queued or rejected as an invalid request. The  caller needs read access to the file. The call is mutating and not idempotent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file to convert.</param>
        /// <param name="checkConversionRequestDtoInteger">The parameters of the conversion. The whole body may be omitted, in which case the defaults of the portal  apply. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-file-conversion/">REST API Reference for StartFileConversion Operation</seealso>
        /// <returns>Task of ConversationResultArrayWrapper</returns>
        Task<ConversationResultArrayWrapper> StartFileConversionAsync(int fileId, CheckConversionRequestDtoInteger? checkConversionRequestDtoInteger = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Start file conversion
        /// </summary>
        /// <remarks>
        /// Queues the conversion of a file into the portal's own editable format and answers with the conversion entry  the caller is to poll. The whole body may be omitted, in which case the defaults apply. `outputType` names the  target format and, left empty, the portal's default for that kind of document is used; `password` unlocks a  protected source file; `version` converts an older version instead of the current one. `createNewIfExist`  decides where the result goes: with `true` a new file is created beside the source, while with `false`, the  default, the converted file that already exists is replaced. `sync=true` converts inside the request and  answers with the finished result instead of a queue entry, which is only sensible for small documents.  Otherwise poll `GET api/2.0/files/file/{fileId}/checkconversion` until `progress` reaches 100 and take the  converted file from `file`. Only formats the portal has to convert are accepted; anything already editable,  and anything it cannot convert, is answered without work being queued or rejected as an invalid request. The  caller needs read access to the file. The call is mutating and not idempotent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file to convert.</param>
        /// <param name="checkConversionRequestDtoInteger">The parameters of the conversion. The whole body may be omitted, in which case the defaults of the portal  apply. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-file-conversion/">REST API Reference for StartFileConversion Operation</seealso>
        /// <returns>Task of ApiResponse (ConversationResultArrayWrapper)</returns>
        Task<ApiResponse<ConversationResultArrayWrapper>> StartFileConversionWithHttpInfoAsync(int fileId, CheckConversionRequestDtoInteger? checkConversionRequestDtoInteger = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel file operations
        /// </summary>
        /// <remarks>
        /// Cancels a background file operation of the caller and answers with the operations that are left. Pass the `id`  that was reported when the operation started to stop that one; a call that leaves the trailing route segment  out stops every operation the caller has running, of every kind. Cancelling stops the job where it stands and  does not undo it: what has already been copied, moved or deleted stays that way, so a cancelled batch can  leave part of itself at the destination and part of it at the source, and the result has to be read back  rather than assumed. The cancelled record is dropped from `GET api/2.0/files/fileops` at once, which is why  the answer here is usually empty. An id that is not among the caller's operations cancels nothing and is not  an error. Operations are private to the account that started them, an anonymous caller being scoped to the  session of the external link, so the call can never reach an operation of anyone else.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The operation to cancel, as returned in `id` when it was started. A call that leaves the route segment out  cancels every operation of the caller, and an id that is not among their operations cancels nothing without  being an error.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-tasks/">REST API Reference for TerminateTasks Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        Task<FileOperationArrayWrapper> TerminateTasksAsync(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Cancel file operations
        /// </summary>
        /// <remarks>
        /// Cancels a background file operation of the caller and answers with the operations that are left. Pass the `id`  that was reported when the operation started to stop that one; a call that leaves the trailing route segment  out stops every operation the caller has running, of every kind. Cancelling stops the job where it stands and  does not undo it: what has already been copied, moved or deleted stays that way, so a cancelled batch can  leave part of itself at the destination and part of it at the source, and the result has to be read back  rather than assumed. The cancelled record is dropped from `GET api/2.0/files/fileops` at once, which is why  the answer here is usually empty. An id that is not among the caller's operations cancels nothing and is not  an error. Operations are private to the account that started them, an anonymous caller being scoped to the  session of the external link, so the call can never reach an operation of anyone else.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The operation to cancel, as returned in `id` when it was started. A call that leaves the route segment out  cancels every operation of the caller, and an id that is not among their operations cancels nothing without  being an error.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-tasks/">REST API Reference for TerminateTasks Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        Task<ApiResponse<FileOperationArrayWrapper>> TerminateTasksWithHttpInfoAsync(string id, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a comment
        /// </summary>
        /// <remarks>
        /// Replaces the comment stored on one version of a file - the note that explains what changed in it - and answers  with the comment as it was stored, which is the text cut to the length the portal keeps. `version` names the  version and has to be an existing one: a version that does not exist is rejected as an invalid request, while  a file that does not exist at all is answered as not found. Sending an empty comment clears the note. The  caller needs the right to edit the history of the file, which the room admin, a DocSpace admin acting as room  manager and a member with content-creator rights have; a member with editing access to somebody else's file,  read-only access, a guest and an anonymous caller are all refused. A file that is locked by somebody else or  lies in Trash is refused as well. The call is mutating and idempotent - repeating it with the same text leaves  the same comment. The comments of all versions come back with `GET api/2.0/files/file/{fileId}/edit/history`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file whose version comment is replaced.</param>
        /// <param name="updateComment">The version and the comment to store on it.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-comment/">REST API Reference for UpdateFileComment Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> UpdateFileCommentAsync(int fileId, UpdateComment updateComment, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a comment
        /// </summary>
        /// <remarks>
        /// Replaces the comment stored on one version of a file - the note that explains what changed in it - and answers  with the comment as it was stored, which is the text cut to the length the portal keeps. `version` names the  version and has to be an existing one: a version that does not exist is rejected as an invalid request, while  a file that does not exist at all is answered as not found. Sending an empty comment clears the note. The  caller needs the right to edit the history of the file, which the room admin, a DocSpace admin acting as room  manager and a member with content-creator rights have; a member with editing access to somebody else's file,  read-only access, a guest and an anonymous caller are all refused. A file that is locked by somebody else or  lies in Trash is refused as well. The call is mutating and idempotent - repeating it with the same text leaves  the same comment. The comments of all versions come back with `GET api/2.0/files/file/{fileId}/edit/history`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file whose version comment is replaced.</param>
        /// <param name="updateComment">The version and the comment to store on it.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-comment/">REST API Reference for UpdateFileComment Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> UpdateFileCommentWithHttpInfoAsync(int fileId, UpdateComment updateComment, CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a numbered chunk
        /// </summary>
        /// <remarks>
        /// Stores one part of a file under the number given in `chunkNumber`, which is what the ordinary chunked flow  uses: parts are kept by their number rather than by arrival, so a part that failed can be resent under the  same number without restarting the session. Numbering starts at 1, and leaving the number out makes the server  count the parts itself. The answer is always the session, never the file, and this call never completes the  upload: the file appears only after `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. Use  `POST api/2.0/files/{folderId}/session/{sessionId}` instead when the parts go strictly in order and the upload  should complete by itself. A part bigger than `chunkUploadSize` from `GET api/2.0/files/settings` is refused,  so that value is also the size to split the payload by. The first part of a PDF is inspected, and a PDF that  is not a fillable form is refused when the session targets a form-filling room. The session is found by its id  alone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session this part belongs to, as returned in `id` when it was created; a 32-character hexadecimal string.</param>
        /// <param name="chunkNumber">The position of this part in the file, counted from 1. Sending the same number again replaces that part  instead of adding one, which is how a failed part is retried; leaving the number out makes the server count  the parts itself. (optional)</param>
        /// <param name="file">The part of the file to store, sent as the multipart field of the same name. It is kept under the number given  beside it, and a part larger than the portal chunk size is refused. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-async-session/">REST API Reference for UploadAsyncSession Operation</seealso>
        /// <returns>Task of ChunkedUploadSessionResponseIntegerWrapper</returns>
        Task<ChunkedUploadSessionResponseIntegerWrapper> UploadAsyncSessionAsync(int folderId, string sessionId, int? chunkNumber = default, FileParameter? file = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a numbered chunk
        /// </summary>
        /// <remarks>
        /// Stores one part of a file under the number given in `chunkNumber`, which is what the ordinary chunked flow  uses: parts are kept by their number rather than by arrival, so a part that failed can be resent under the  same number without restarting the session. Numbering starts at 1, and leaving the number out makes the server  count the parts itself. The answer is always the session, never the file, and this call never completes the  upload: the file appears only after `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. Use  `POST api/2.0/files/{folderId}/session/{sessionId}` instead when the parts go strictly in order and the upload  should complete by itself. A part bigger than `chunkUploadSize` from `GET api/2.0/files/settings` is refused,  so that value is also the size to split the payload by. The first part of a PDF is inspected, and a PDF that  is not a fillable form is refused when the session targets a form-filling room. The session is found by its id  alone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session this part belongs to, as returned in `id` when it was created; a 32-character hexadecimal string.</param>
        /// <param name="chunkNumber">The position of this part in the file, counted from 1. Sending the same number again replaces that part  instead of adding one, which is how a failed part is retried; leaving the number out makes the server count  the parts itself. (optional)</param>
        /// <param name="file">The part of the file to store, sent as the multipart field of the same name. It is kept under the number given  beside it, and a part larger than the portal chunk size is refused. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-async-session/">REST API Reference for UploadAsyncSession Operation</seealso>
        /// <returns>Task of ApiResponse (ChunkedUploadSessionResponseIntegerWrapper)</returns>
        Task<ApiResponse<ChunkedUploadSessionResponseIntegerWrapper>> UploadAsyncSessionWithHttpInfoAsync(int folderId, string sessionId, int? chunkNumber = default, FileParameter? file = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload the next chunk
        /// </summary>
        /// <remarks>
        /// Sends the next part of a file into the session opened for it, as the multipart `File` field, and lets the  server keep count: parts are appended in the order they arrive, so two of these calls must never run in  parallel on one session. While bytes are still missing the answer describes the session and `uploaded` is  false; when the last part completes the declared size the file is written, its upload links are cleared, it is  marked as new for the room, and the answer comes back with 201, `uploaded` true and the whole file in `file`.  A session created for a payload smaller than `chunkUploadSize` from `GET api/2.0/files/settings` finishes on  the first such call and needs no separate finalize step. A part larger than that limit is refused. The first  part of a PDF is inspected, and a PDF that is not a fillable form is refused when the session targets a  form-filling room. The session is addressed by its id, and the folder in the path is not matched against it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session this part belongs to, as returned in `id` when it was created; the parts of one session must be  sent one after another, not in parallel.</param>
        /// <param name="file">The next part of the file, sent as the multipart field of the same name. Parts are appended in the order they  arrive, and a part larger than the portal chunk size is refused. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-session/">REST API Reference for UploadSession Operation</seealso>
        /// <returns>Task of UploadSessionResponseIntegerWrapper</returns>
        Task<UploadSessionResponseIntegerWrapper> UploadSessionAsync(int folderId, string sessionId, FileParameter? file = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload the next chunk
        /// </summary>
        /// <remarks>
        /// Sends the next part of a file into the session opened for it, as the multipart `File` field, and lets the  server keep count: parts are appended in the order they arrive, so two of these calls must never run in  parallel on one session. While bytes are still missing the answer describes the session and `uploaded` is  false; when the last part completes the declared size the file is written, its upload links are cleared, it is  marked as new for the room, and the answer comes back with 201, `uploaded` true and the whole file in `file`.  A session created for a payload smaller than `chunkUploadSize` from `GET api/2.0/files/settings` finishes on  the first such call and needs no separate finalize step. A part larger than that limit is refused. The first  part of a PDF is inspected, and a PDF that is not a fillable form is refused when the session targets a  form-filling room. The session is addressed by its id, and the folder in the path is not matched against it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session this part belongs to, as returned in `id` when it was created; the parts of one session must be  sent one after another, not in parallel.</param>
        /// <param name="file">The next part of the file, sent as the multipart field of the same name. Parts are appended in the order they  arrive, and a part larger than the portal chunk size is refused. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-session/">REST API Reference for UploadSession Operation</seealso>
        /// <returns>Task of ApiResponse (UploadSessionResponseIntegerWrapper)</returns>
        Task<ApiResponse<UploadSessionResponseIntegerWrapper>> UploadSessionWithHttpInfoAsync(int folderId, string sessionId, FileParameter? file = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOperationsApi : IOperationsApiSync, IOperationsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OperationsApi : IDisposable, IOperationsApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public OperationsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public OperationsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="OperationsApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public OperationsApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="OperationsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public OperationsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationsApi"/> class.
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
        public OperationsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="OperationsApi"/> class using a Configuration object.
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
        public OperationsApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="OperationsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public OperationsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Abort an upload session
        /// </summary>
        /// <remarks>
        /// Cancels a chunked upload opened with `POST api/2.0/files/{folderId}/session` and discards the parts already  received, so nothing of it reaches the folder. The session is found by the id in the path alone: the folder  segment is not matched against it, and neither is the account that opened it, which makes the id the only  secret protecting the transfer. The call is destructive and is not safe to repeat, because the record is gone  afterwards: a second attempt, a session already closed by  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize` and a session that expired after twelve hours of  silence all fail rather than answer as missing. Finalizing removes the session too, so there is nothing left  to abort once the file exists. The answer carries no body. An upload that is simply abandoned needs no call at  all, since the session and its buffered parts are dropped when it expires.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session to cancel, as returned in `id` when it was created: a 32-character hexadecimal string that  identifies the session on its own.</param>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/abort-upload-session/">REST API Reference for AbortUploadSession Operation</seealso>
        /// <returns></returns>
        public void AbortUploadSession(string sessionId, int folderId)
        {
            AbortUploadSessionWithHttpInfo(sessionId, folderId);
        }

        /// <summary>
        /// Abort an upload session
        /// </summary>
        /// <remarks>
        /// Cancels a chunked upload opened with `POST api/2.0/files/{folderId}/session` and discards the parts already  received, so nothing of it reaches the folder. The session is found by the id in the path alone: the folder  segment is not matched against it, and neither is the account that opened it, which makes the id the only  secret protecting the transfer. The call is destructive and is not safe to repeat, because the record is gone  afterwards: a second attempt, a session already closed by  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize` and a session that expired after twelve hours of  silence all fail rather than answer as missing. Finalizing removes the session too, so there is nothing left  to abort once the file exists. The answer carries no body. An upload that is simply abandoned needs no call at  all, since the session and its buffered parts are dropped when it expires.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session to cancel, as returned in `id` when it was created: a 32-character hexadecimal string that  identifies the session on its own.</param>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/abort-upload-session/">REST API Reference for AbortUploadSession Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AbortUploadSessionWithHttpInfo(string sessionId, int folderId)
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling OperationsApi->AbortUploadSession");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("sessionId", ClientUtils.ParameterToString(sessionId)); // path parameter
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
            var localVarResponse = Client.Delete<Object>("/api/2.0/files/{folderId}/session/{sessionId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AbortUploadSession", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Abort an upload session
        /// </summary>
        /// <remarks>
        /// Cancels a chunked upload opened with `POST api/2.0/files/{folderId}/session` and discards the parts already  received, so nothing of it reaches the folder. The session is found by the id in the path alone: the folder  segment is not matched against it, and neither is the account that opened it, which makes the id the only  secret protecting the transfer. The call is destructive and is not safe to repeat, because the record is gone  afterwards: a second attempt, a session already closed by  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize` and a session that expired after twelve hours of  silence all fail rather than answer as missing. Finalizing removes the session too, so there is nothing left  to abort once the file exists. The answer carries no body. An upload that is simply abandoned needs no call at  all, since the session and its buffered parts are dropped when it expires.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session to cancel, as returned in `id` when it was created: a 32-character hexadecimal string that  identifies the session on its own.</param>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/abort-upload-session/">REST API Reference for AbortUploadSession Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task AbortUploadSessionAsync(string sessionId, int folderId, CancellationToken cancellationToken = default)
        {
            await AbortUploadSessionWithHttpInfoAsync(sessionId, folderId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Abort an upload session
        /// </summary>
        /// <remarks>
        /// Cancels a chunked upload opened with `POST api/2.0/files/{folderId}/session` and discards the parts already  received, so nothing of it reaches the folder. The session is found by the id in the path alone: the folder  segment is not matched against it, and neither is the account that opened it, which makes the id the only  secret protecting the transfer. The call is destructive and is not safe to repeat, because the record is gone  afterwards: a second attempt, a session already closed by  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize` and a session that expired after twelve hours of  silence all fail rather than answer as missing. Finalizing removes the session too, so there is nothing left  to abort once the file exists. The answer carries no body. An upload that is simply abandoned needs no call at  all, since the session and its buffered parts are dropped when it expires.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The session to cancel, as returned in `id` when it was created: a 32-character hexadecimal string that  identifies the session on its own.</param>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/abort-upload-session/">REST API Reference for AbortUploadSession Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> AbortUploadSessionWithHttpInfoAsync(string sessionId, int folderId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling OperationsApi->AbortUploadSession");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("sessionId", ClientUtils.ParameterToString(sessionId)); // path parameter
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

            var localVarResponse = await AsynchronousClient.DeleteAsync<Object>("/api/2.0/files/{folderId}/session/{sessionId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AbortUploadSession", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add favorite files and folders
        /// </summary>
        /// <remarks>
        /// Marks the listed files and folders as favorites for the calling account. The favorite list is personal:  nothing changes for other members, and the entries stay where they are stored. Read access to each item is  enough, so a room member with view-only rights and a guest may call it. Items the caller cannot read, ids that  do not exist and encrypted files of a private room are skipped without a word, and the answer is `true` even  when nothing was marked, so read the outcome back from `GET api/2.0/files/@favorites` instead of trusting it.  Numeric ids address entries stored in the portal itself, string ids entries on a connected third-party  account, and both kinds may be sent in one request. The call is mutating but safe to repeat: an item already  marked stays listed once. An entry moved to the Trash keeps its mark and is left out of the listing until it  is restored. `returnSingleOperation` arrives with the shared body and does nothing here. Use  `DELETE api/2.0/files/favorites` to undo, or `GET api/2.0/files/favorites/{fileId}` for a single file.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-favorites/">REST API Reference for AddFavorites Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper AddFavorites(BaseBatchRequestDto? baseBatchRequestDto = default)
        {
            var localVarResponse = AddFavoritesWithHttpInfo(baseBatchRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Add favorite files and folders
        /// </summary>
        /// <remarks>
        /// Marks the listed files and folders as favorites for the calling account. The favorite list is personal:  nothing changes for other members, and the entries stay where they are stored. Read access to each item is  enough, so a room member with view-only rights and a guest may call it. Items the caller cannot read, ids that  do not exist and encrypted files of a private room are skipped without a word, and the answer is `true` even  when nothing was marked, so read the outcome back from `GET api/2.0/files/@favorites` instead of trusting it.  Numeric ids address entries stored in the portal itself, string ids entries on a connected third-party  account, and both kinds may be sent in one request. The call is mutating but safe to repeat: an item already  marked stays listed once. An entry moved to the Trash keeps its mark and is left out of the listing until it  is restored. `returnSingleOperation` arrives with the shared body and does nothing here. Use  `DELETE api/2.0/files/favorites` to undo, or `GET api/2.0/files/favorites/{fileId}` for a single file.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-favorites/">REST API Reference for AddFavorites Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> AddFavoritesWithHttpInfo(BaseBatchRequestDto? baseBatchRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (baseBatchRequestDto != null) localVarRequestOptions.Data = baseBatchRequestDto;

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
            var localVarResponse = Client.Post<BooleanWrapper>("/api/2.0/files/favorites", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AddFavorites", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add favorite files and folders
        /// </summary>
        /// <remarks>
        /// Marks the listed files and folders as favorites for the calling account. The favorite list is personal:  nothing changes for other members, and the entries stay where they are stored. Read access to each item is  enough, so a room member with view-only rights and a guest may call it. Items the caller cannot read, ids that  do not exist and encrypted files of a private room are skipped without a word, and the answer is `true` even  when nothing was marked, so read the outcome back from `GET api/2.0/files/@favorites` instead of trusting it.  Numeric ids address entries stored in the portal itself, string ids entries on a connected third-party  account, and both kinds may be sent in one request. The call is mutating but safe to repeat: an item already  marked stays listed once. An entry moved to the Trash keeps its mark and is left out of the listing until it  is restored. `returnSingleOperation` arrives with the shared body and does nothing here. Use  `DELETE api/2.0/files/favorites` to undo, or `GET api/2.0/files/favorites/{fileId}` for a single file.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-favorites/">REST API Reference for AddFavorites Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> AddFavoritesAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AddFavoritesWithHttpInfoAsync(baseBatchRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Add favorite files and folders
        /// </summary>
        /// <remarks>
        /// Marks the listed files and folders as favorites for the calling account. The favorite list is personal:  nothing changes for other members, and the entries stay where they are stored. Read access to each item is  enough, so a room member with view-only rights and a guest may call it. Items the caller cannot read, ids that  do not exist and encrypted files of a private room are skipped without a word, and the answer is `true` even  when nothing was marked, so read the outcome back from `GET api/2.0/files/@favorites` instead of trusting it.  Numeric ids address entries stored in the portal itself, string ids entries on a connected third-party  account, and both kinds may be sent in one request. The call is mutating but safe to repeat: an item already  marked stays listed once. An entry moved to the Trash keeps its mark and is left out of the listing until it  is restored. `returnSingleOperation` arrives with the shared body and does nothing here. Use  `DELETE api/2.0/files/favorites` to undo, or `GET api/2.0/files/favorites/{fileId}` for a single file.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-favorites/">REST API Reference for AddFavorites Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> AddFavoritesWithHttpInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (baseBatchRequestDto != null) localVarRequestOptions.Data = baseBatchRequestDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<BooleanWrapper>("/api/2.0/files/favorites", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AddFavorites", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Bulk download
        /// </summary>
        /// <remarks>
        /// Queues a background job that packs the requested files and folders into a single archive, and answers with the  caller's download operations, including the one just started. The archive is not ready when the response  arrives: poll `GET api/2.0/files/fileops` until the operation reports `finished`, then take the address of the  archive from its `url`. Items listed in `fileConvertIds` are converted to the format named there before they  are packed, while the items of `fileIds` are packed as they are. Read access to every listed item is required:  an item the caller may not read fails the whole call with 403, and an id that resolves to nothing is answered  as missing, so filter the selection beforehand. Only one download at a time is allowed per caller, and a  second call made while the first is still running is refused with 403 as well. An empty selection queues  nothing and simply answers with the operations that are already there. An anonymous caller may use the call  for the items covered by the external link they hold.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadRequestDto">The files and folders to pack into one archive, together with the formats they are converted to. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/bulk-download/">REST API Reference for BulkDownload Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper BulkDownload(DownloadRequestDto? downloadRequestDto = default)
        {
            var localVarResponse = BulkDownloadWithHttpInfo(downloadRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk download
        /// </summary>
        /// <remarks>
        /// Queues a background job that packs the requested files and folders into a single archive, and answers with the  caller's download operations, including the one just started. The archive is not ready when the response  arrives: poll `GET api/2.0/files/fileops` until the operation reports `finished`, then take the address of the  archive from its `url`. Items listed in `fileConvertIds` are converted to the format named there before they  are packed, while the items of `fileIds` are packed as they are. Read access to every listed item is required:  an item the caller may not read fails the whole call with 403, and an id that resolves to nothing is answered  as missing, so filter the selection beforehand. Only one download at a time is allowed per caller, and a  second call made while the first is still running is refused with 403 as well. An empty selection queues  nothing and simply answers with the operations that are already there. An anonymous caller may use the call  for the items covered by the external link they hold.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadRequestDto">The files and folders to pack into one archive, together with the formats they are converted to. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/bulk-download/">REST API Reference for BulkDownload Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> BulkDownloadWithHttpInfo(DownloadRequestDto? downloadRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (downloadRequestDto != null) localVarRequestOptions.Data = downloadRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<FileOperationArrayWrapper>("/api/2.0/files/fileops/bulkdownload", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("BulkDownload", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Bulk download
        /// </summary>
        /// <remarks>
        /// Queues a background job that packs the requested files and folders into a single archive, and answers with the  caller's download operations, including the one just started. The archive is not ready when the response  arrives: poll `GET api/2.0/files/fileops` until the operation reports `finished`, then take the address of the  archive from its `url`. Items listed in `fileConvertIds` are converted to the format named there before they  are packed, while the items of `fileIds` are packed as they are. Read access to every listed item is required:  an item the caller may not read fails the whole call with 403, and an id that resolves to nothing is answered  as missing, so filter the selection beforehand. Only one download at a time is allowed per caller, and a  second call made while the first is still running is refused with 403 as well. An empty selection queues  nothing and simply answers with the operations that are already there. An anonymous caller may use the call  for the items covered by the external link they hold.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadRequestDto">The files and folders to pack into one archive, together with the formats they are converted to. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/bulk-download/">REST API Reference for BulkDownload Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async Task<FileOperationArrayWrapper> BulkDownloadAsync(DownloadRequestDto? downloadRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await BulkDownloadWithHttpInfoAsync(downloadRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk download
        /// </summary>
        /// <remarks>
        /// Queues a background job that packs the requested files and folders into a single archive, and answers with the  caller's download operations, including the one just started. The archive is not ready when the response  arrives: poll `GET api/2.0/files/fileops` until the operation reports `finished`, then take the address of the  archive from its `url`. Items listed in `fileConvertIds` are converted to the format named there before they  are packed, while the items of `fileIds` are packed as they are. Read access to every listed item is required:  an item the caller may not read fails the whole call with 403, and an id that resolves to nothing is answered  as missing, so filter the selection beforehand. Only one download at a time is allowed per caller, and a  second call made while the first is still running is refused with 403 as well. An empty selection queues  nothing and simply answers with the operations that are already there. An anonymous caller may use the call  for the items covered by the external link they hold.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadRequestDto">The files and folders to pack into one archive, together with the formats they are converted to. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/bulk-download/">REST API Reference for BulkDownload Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async Task<ApiResponse<FileOperationArrayWrapper>> BulkDownloadWithHttpInfoAsync(DownloadRequestDto? downloadRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (downloadRequestDto != null) localVarRequestOptions.Data = downloadRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileOperationArrayWrapper>("/api/2.0/files/fileops/bulkdownload", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("BulkDownload", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get conversion status
        /// </summary>
        /// <remarks>
        /// Reports how far the conversion of a file has got, as a list that holds one entry while the portal still knows  about that conversion and nothing once it is over. Read `progress`, which counts from 0 to 100, `error` for  the reason a conversion failed, and `file`, which carries the converted file as soon as it exists. Queue the  conversion with `PUT api/2.0/files/file/{fileId}/checkconversion` and poll this operation until the entry  reaches 100 or disappears: a finished entry is handed out once and then dropped, and an entry whose conversion  stopped is discarded a few minutes later, so an empty list means either already reported or never started  rather than an error. The same empty list is the answer for an identifier no file matches. Passing  `start=true` starts the conversion as well, with the format from the portal settings and no password, which  makes that one flag mutating; without it the operation is read-only. The caller needs read access to the file,  and anyone else is refused.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file whose conversion is asked about.</param>
        /// <param name="start">Whether to start the conversion as well: `true` queues it with the default output format and no password,  `false` only reports what the portal already knows. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-conversion-status/">REST API Reference for CheckConversionStatus Operation</seealso>
        /// <returns>ConversationResultArrayWrapper</returns>
        public ConversationResultArrayWrapper CheckConversionStatus(int fileId, bool? start = default)
        {
            var localVarResponse = CheckConversionStatusWithHttpInfo(fileId, start);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get conversion status
        /// </summary>
        /// <remarks>
        /// Reports how far the conversion of a file has got, as a list that holds one entry while the portal still knows  about that conversion and nothing once it is over. Read `progress`, which counts from 0 to 100, `error` for  the reason a conversion failed, and `file`, which carries the converted file as soon as it exists. Queue the  conversion with `PUT api/2.0/files/file/{fileId}/checkconversion` and poll this operation until the entry  reaches 100 or disappears: a finished entry is handed out once and then dropped, and an entry whose conversion  stopped is discarded a few minutes later, so an empty list means either already reported or never started  rather than an error. The same empty list is the answer for an identifier no file matches. Passing  `start=true` starts the conversion as well, with the format from the portal settings and no password, which  makes that one flag mutating; without it the operation is read-only. The caller needs read access to the file,  and anyone else is refused.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file whose conversion is asked about.</param>
        /// <param name="start">Whether to start the conversion as well: `true` queues it with the default output format and no password,  `false` only reports what the portal already knows. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-conversion-status/">REST API Reference for CheckConversionStatus Operation</seealso>
        /// <returns>ApiResponse of ConversationResultArrayWrapper</returns>
        public ApiResponse<ConversationResultArrayWrapper> CheckConversionStatusWithHttpInfo(int fileId, bool? start = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (start != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "start", start));
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
            var localVarResponse = Client.Get<ConversationResultArrayWrapper>("/api/2.0/files/file/{fileId}/checkconversion", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CheckConversionStatus", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get conversion status
        /// </summary>
        /// <remarks>
        /// Reports how far the conversion of a file has got, as a list that holds one entry while the portal still knows  about that conversion and nothing once it is over. Read `progress`, which counts from 0 to 100, `error` for  the reason a conversion failed, and `file`, which carries the converted file as soon as it exists. Queue the  conversion with `PUT api/2.0/files/file/{fileId}/checkconversion` and poll this operation until the entry  reaches 100 or disappears: a finished entry is handed out once and then dropped, and an entry whose conversion  stopped is discarded a few minutes later, so an empty list means either already reported or never started  rather than an error. The same empty list is the answer for an identifier no file matches. Passing  `start=true` starts the conversion as well, with the format from the portal settings and no password, which  makes that one flag mutating; without it the operation is read-only. The caller needs read access to the file,  and anyone else is refused.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file whose conversion is asked about.</param>
        /// <param name="start">Whether to start the conversion as well: `true` queues it with the default output format and no password,  `false` only reports what the portal already knows. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-conversion-status/">REST API Reference for CheckConversionStatus Operation</seealso>
        /// <returns>Task of ConversationResultArrayWrapper</returns>
        public async Task<ConversationResultArrayWrapper> CheckConversionStatusAsync(int fileId, bool? start = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CheckConversionStatusWithHttpInfoAsync(fileId, start, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get conversion status
        /// </summary>
        /// <remarks>
        /// Reports how far the conversion of a file has got, as a list that holds one entry while the portal still knows  about that conversion and nothing once it is over. Read `progress`, which counts from 0 to 100, `error` for  the reason a conversion failed, and `file`, which carries the converted file as soon as it exists. Queue the  conversion with `PUT api/2.0/files/file/{fileId}/checkconversion` and poll this operation until the entry  reaches 100 or disappears: a finished entry is handed out once and then dropped, and an entry whose conversion  stopped is discarded a few minutes later, so an empty list means either already reported or never started  rather than an error. The same empty list is the answer for an identifier no file matches. Passing  `start=true` starts the conversion as well, with the format from the portal settings and no password, which  makes that one flag mutating; without it the operation is read-only. The caller needs read access to the file,  and anyone else is refused.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file whose conversion is asked about.</param>
        /// <param name="start">Whether to start the conversion as well: `true` queues it with the default output format and no password,  `false` only reports what the portal already knows. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-conversion-status/">REST API Reference for CheckConversionStatus Operation</seealso>
        /// <returns>Task of ApiResponse (ConversationResultArrayWrapper)</returns>
        public async Task<ApiResponse<ConversationResultArrayWrapper>> CheckConversionStatusWithHttpInfoAsync(int fileId, bool? start = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (start != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "start", start));
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

            var localVarResponse = await AsynchronousClient.GetAsync<ConversationResultArrayWrapper>("/api/2.0/files/file/{fileId}/checkconversion", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CheckConversionStatus", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check move or copy conflicts
        /// </summary>
        /// <remarks>
        /// Reports which of the requested files and folders already have a same-named entry in `destFolderId`, so that  the clash can be settled before the move or the copy is started. Nothing is moved, copied or changed by the  call, although the address is shared with `PUT api/2.0/files/fileops/move`: the answer is the part of the  request that clashes, and an empty array means the batch would go through without one. The  `conflictResolveType` of the request is not taken into account — clashing items are reported whatever it says  — and encrypted files are left out of the report. A source id that resolves to nothing is not an error and is  passed over. The caller needs create access to the destination: an archived room and a room the caller cannot  write to are refused with 403, a destination that does not exist is answered as missing, and a request without  `destFolderId` is rejected as an invalid request. To learn whether the destination accepts the files at all  use `GET api/2.0/files/fileops/checkdestfolder`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-batch-items/">REST API Reference for CheckMoveOrCopyBatchItems Operation</seealso>
        /// <returns>FileEntryBaseArrayWrapper</returns>
        public FileEntryBaseArrayWrapper CheckMoveOrCopyBatchItems(BatchRequestDto? inDto = default)
        {
            var localVarResponse = CheckMoveOrCopyBatchItemsWithHttpInfo(inDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check move or copy conflicts
        /// </summary>
        /// <remarks>
        /// Reports which of the requested files and folders already have a same-named entry in `destFolderId`, so that  the clash can be settled before the move or the copy is started. Nothing is moved, copied or changed by the  call, although the address is shared with `PUT api/2.0/files/fileops/move`: the answer is the part of the  request that clashes, and an empty array means the batch would go through without one. The  `conflictResolveType` of the request is not taken into account — clashing items are reported whatever it says  — and encrypted files are left out of the report. A source id that resolves to nothing is not an error and is  passed over. The caller needs create access to the destination: an archived room and a room the caller cannot  write to are refused with 403, a destination that does not exist is answered as missing, and a request without  `destFolderId` is rejected as an invalid request. To learn whether the destination accepts the files at all  use `GET api/2.0/files/fileops/checkdestfolder`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-batch-items/">REST API Reference for CheckMoveOrCopyBatchItems Operation</seealso>
        /// <returns>ApiResponse of FileEntryBaseArrayWrapper</returns>
        public ApiResponse<FileEntryBaseArrayWrapper> CheckMoveOrCopyBatchItemsWithHttpInfo(BatchRequestDto? inDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (inDto != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inDto", inDto));
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
            var localVarResponse = Client.Get<FileEntryBaseArrayWrapper>("/api/2.0/files/fileops/move", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CheckMoveOrCopyBatchItems", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check move or copy conflicts
        /// </summary>
        /// <remarks>
        /// Reports which of the requested files and folders already have a same-named entry in `destFolderId`, so that  the clash can be settled before the move or the copy is started. Nothing is moved, copied or changed by the  call, although the address is shared with `PUT api/2.0/files/fileops/move`: the answer is the part of the  request that clashes, and an empty array means the batch would go through without one. The  `conflictResolveType` of the request is not taken into account — clashing items are reported whatever it says  — and encrypted files are left out of the report. A source id that resolves to nothing is not an error and is  passed over. The caller needs create access to the destination: an archived room and a room the caller cannot  write to are refused with 403, a destination that does not exist is answered as missing, and a request without  `destFolderId` is rejected as an invalid request. To learn whether the destination accepts the files at all  use `GET api/2.0/files/fileops/checkdestfolder`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-batch-items/">REST API Reference for CheckMoveOrCopyBatchItems Operation</seealso>
        /// <returns>Task of FileEntryBaseArrayWrapper</returns>
        public async Task<FileEntryBaseArrayWrapper> CheckMoveOrCopyBatchItemsAsync(BatchRequestDto? inDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CheckMoveOrCopyBatchItemsWithHttpInfoAsync(inDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check move or copy conflicts
        /// </summary>
        /// <remarks>
        /// Reports which of the requested files and folders already have a same-named entry in `destFolderId`, so that  the clash can be settled before the move or the copy is started. Nothing is moved, copied or changed by the  call, although the address is shared with `PUT api/2.0/files/fileops/move`: the answer is the part of the  request that clashes, and an empty array means the batch would go through without one. The  `conflictResolveType` of the request is not taken into account — clashing items are reported whatever it says  — and encrypted files are left out of the report. A source id that resolves to nothing is not an error and is  passed over. The caller needs create access to the destination: an archived room and a room the caller cannot  write to are refused with 403, a destination that does not exist is answered as missing, and a request without  `destFolderId` is rejected as an invalid request. To learn whether the destination accepts the files at all  use `GET api/2.0/files/fileops/checkdestfolder`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-batch-items/">REST API Reference for CheckMoveOrCopyBatchItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryBaseArrayWrapper)</returns>
        public async Task<ApiResponse<FileEntryBaseArrayWrapper>> CheckMoveOrCopyBatchItemsWithHttpInfoAsync(BatchRequestDto? inDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (inDto != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inDto", inDto));
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

            var localVarResponse = await AsynchronousClient.GetAsync<FileEntryBaseArrayWrapper>("/api/2.0/files/fileops/move", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CheckMoveOrCopyBatchItems", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check the destination folder
        /// </summary>
        /// <remarks>
        /// Reports whether the destination folder accepts the listed files, before a move or a copy is started. Only  `fileIds` and `destFolderId` are read from the request: `result` says whether all of the files are accepted,  only some of them or none, and `files` names the ones that are. The check is about what the destination allows  to be stored in it rather than about name clashes — everywhere except a form-filling room every file is  accepted, while a form-filling room accepts only PDF forms, so a text document offered to one comes back as  none accepted. The caller needs create access to the destination, so a room the caller cannot write to and an  archived room are refused with 403, a destination that does not exist is answered as missing, and a request  without `destFolderId` is rejected as an invalid request. Folder ids and the copying options of the request  play no part here. The call changes nothing; for same-named entries at the destination use  `GET api/2.0/files/fileops/move`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-dest-folder/">REST API Reference for CheckMoveOrCopyDestFolder Operation</seealso>
        /// <returns>CheckDestFolderWrapper</returns>
        public CheckDestFolderWrapper CheckMoveOrCopyDestFolder(BatchRequestDto? inDto = default)
        {
            var localVarResponse = CheckMoveOrCopyDestFolderWithHttpInfo(inDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check the destination folder
        /// </summary>
        /// <remarks>
        /// Reports whether the destination folder accepts the listed files, before a move or a copy is started. Only  `fileIds` and `destFolderId` are read from the request: `result` says whether all of the files are accepted,  only some of them or none, and `files` names the ones that are. The check is about what the destination allows  to be stored in it rather than about name clashes — everywhere except a form-filling room every file is  accepted, while a form-filling room accepts only PDF forms, so a text document offered to one comes back as  none accepted. The caller needs create access to the destination, so a room the caller cannot write to and an  archived room are refused with 403, a destination that does not exist is answered as missing, and a request  without `destFolderId` is rejected as an invalid request. Folder ids and the copying options of the request  play no part here. The call changes nothing; for same-named entries at the destination use  `GET api/2.0/files/fileops/move`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-dest-folder/">REST API Reference for CheckMoveOrCopyDestFolder Operation</seealso>
        /// <returns>ApiResponse of CheckDestFolderWrapper</returns>
        public ApiResponse<CheckDestFolderWrapper> CheckMoveOrCopyDestFolderWithHttpInfo(BatchRequestDto? inDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (inDto != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inDto", inDto));
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
            var localVarResponse = Client.Get<CheckDestFolderWrapper>("/api/2.0/files/fileops/checkdestfolder", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CheckMoveOrCopyDestFolder", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check the destination folder
        /// </summary>
        /// <remarks>
        /// Reports whether the destination folder accepts the listed files, before a move or a copy is started. Only  `fileIds` and `destFolderId` are read from the request: `result` says whether all of the files are accepted,  only some of them or none, and `files` names the ones that are. The check is about what the destination allows  to be stored in it rather than about name clashes — everywhere except a form-filling room every file is  accepted, while a form-filling room accepts only PDF forms, so a text document offered to one comes back as  none accepted. The caller needs create access to the destination, so a room the caller cannot write to and an  archived room are refused with 403, a destination that does not exist is answered as missing, and a request  without `destFolderId` is rejected as an invalid request. Folder ids and the copying options of the request  play no part here. The call changes nothing; for same-named entries at the destination use  `GET api/2.0/files/fileops/move`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-dest-folder/">REST API Reference for CheckMoveOrCopyDestFolder Operation</seealso>
        /// <returns>Task of CheckDestFolderWrapper</returns>
        public async Task<CheckDestFolderWrapper> CheckMoveOrCopyDestFolderAsync(BatchRequestDto? inDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CheckMoveOrCopyDestFolderWithHttpInfoAsync(inDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check the destination folder
        /// </summary>
        /// <remarks>
        /// Reports whether the destination folder accepts the listed files, before a move or a copy is started. Only  `fileIds` and `destFolderId` are read from the request: `result` says whether all of the files are accepted,  only some of them or none, and `files` names the ones that are. The check is about what the destination allows  to be stored in it rather than about name clashes — everywhere except a form-filling room every file is  accepted, while a form-filling room accepts only PDF forms, so a text document offered to one comes back as  none accepted. The caller needs create access to the destination, so a room the caller cannot write to and an  archived room are refused with 403, a destination that does not exist is answered as missing, and a request  without `destFolderId` is rejected as an invalid request. Folder ids and the copying options of the request  play no part here. The call changes nothing; for same-named entries at the destination use  `GET api/2.0/files/fileops/move`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-dest-folder/">REST API Reference for CheckMoveOrCopyDestFolder Operation</seealso>
        /// <returns>Task of ApiResponse (CheckDestFolderWrapper)</returns>
        public async Task<ApiResponse<CheckDestFolderWrapper>> CheckMoveOrCopyDestFolderWithHttpInfoAsync(BatchRequestDto? inDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (inDto != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inDto", inDto));
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

            var localVarResponse = await AsynchronousClient.GetAsync<CheckDestFolderWrapper>("/api/2.0/files/fileops/checkdestfolder", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CheckMoveOrCopyDestFolder", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Copy files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that copies the requested files and folders into `destFolderId`, leaving the originals  where they are, and answers with the caller's move and copy operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`; its `files` and `folders` then name what  was produced. Before starting, `GET api/2.0/files/fileops/move` reports which items already have a same-named  entry at the destination and `conflictResolveType` decides what happens to them, while  `GET api/2.0/files/fileops/checkdestfolder` reports whether the destination accepts the files at all. The  caller needs create access to the destination — room manager or content-creator rights inside a room — and  read access to every source item; anything less is refused with 403. With `content=true` each listed folder is  replaced by its own files and subfolders, so the folder itself is not recreated at the destination. An empty  selection queues nothing and answers with the operations that are already there. To remove the originals  instead use `PUT api/2.0/files/fileops/move`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-batch-items/">REST API Reference for CopyBatchItems Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper CopyBatchItems(BatchRequestDto? batchRequestDto = default)
        {
            var localVarResponse = CopyBatchItemsWithHttpInfo(batchRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Copy files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that copies the requested files and folders into `destFolderId`, leaving the originals  where they are, and answers with the caller's move and copy operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`; its `files` and `folders` then name what  was produced. Before starting, `GET api/2.0/files/fileops/move` reports which items already have a same-named  entry at the destination and `conflictResolveType` decides what happens to them, while  `GET api/2.0/files/fileops/checkdestfolder` reports whether the destination accepts the files at all. The  caller needs create access to the destination — room manager or content-creator rights inside a room — and  read access to every source item; anything less is refused with 403. With `content=true` each listed folder is  replaced by its own files and subfolders, so the folder itself is not recreated at the destination. An empty  selection queues nothing and answers with the operations that are already there. To remove the originals  instead use `PUT api/2.0/files/fileops/move`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-batch-items/">REST API Reference for CopyBatchItems Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> CopyBatchItemsWithHttpInfo(BatchRequestDto? batchRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (batchRequestDto != null) localVarRequestOptions.Data = batchRequestDto;

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
            var localVarResponse = Client.Put<FileOperationArrayWrapper>("/api/2.0/files/fileops/copy", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CopyBatchItems", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Copy files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that copies the requested files and folders into `destFolderId`, leaving the originals  where they are, and answers with the caller's move and copy operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`; its `files` and `folders` then name what  was produced. Before starting, `GET api/2.0/files/fileops/move` reports which items already have a same-named  entry at the destination and `conflictResolveType` decides what happens to them, while  `GET api/2.0/files/fileops/checkdestfolder` reports whether the destination accepts the files at all. The  caller needs create access to the destination — room manager or content-creator rights inside a room — and  read access to every source item; anything less is refused with 403. With `content=true` each listed folder is  replaced by its own files and subfolders, so the folder itself is not recreated at the destination. An empty  selection queues nothing and answers with the operations that are already there. To remove the originals  instead use `PUT api/2.0/files/fileops/move`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-batch-items/">REST API Reference for CopyBatchItems Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async Task<FileOperationArrayWrapper> CopyBatchItemsAsync(BatchRequestDto? batchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CopyBatchItemsWithHttpInfoAsync(batchRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Copy files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that copies the requested files and folders into `destFolderId`, leaving the originals  where they are, and answers with the caller's move and copy operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`; its `files` and `folders` then name what  was produced. Before starting, `GET api/2.0/files/fileops/move` reports which items already have a same-named  entry at the destination and `conflictResolveType` decides what happens to them, while  `GET api/2.0/files/fileops/checkdestfolder` reports whether the destination accepts the files at all. The  caller needs create access to the destination — room manager or content-creator rights inside a room — and  read access to every source item; anything less is refused with 403. With `content=true` each listed folder is  replaced by its own files and subfolders, so the folder itself is not recreated at the destination. An empty  selection queues nothing and answers with the operations that are already there. To remove the originals  instead use `PUT api/2.0/files/fileops/move`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-batch-items/">REST API Reference for CopyBatchItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async Task<ApiResponse<FileOperationArrayWrapper>> CopyBatchItemsWithHttpInfoAsync(BatchRequestDto? batchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (batchRequestDto != null) localVarRequestOptions.Data = batchRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<FileOperationArrayWrapper>("/api/2.0/files/fileops/copy", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CopyBatchItems", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Chunked upload
        /// </summary>
        /// <remarks>
        /// Deprecated in favour of `POST api/2.0/files/{folderId}/session`, which opens the same session and returns it  without the success envelope used here; new callers should go there. Reserves a chunked upload of a file in  the folder named by the path: the title comes from `fileName`, the declared payload size from `fileSize`, and  the answer carries the session id every later call quotes, the address of the standalone chunk handler, the  moment an idle session is dropped and the reserved byte count. No content is stored yet. Send the payload as  multipart parts to `POST api/2.0/files/{folderId}/session/{sessionId}/upload`, keeping each part within  `chunkUploadSize` from `GET api/2.0/files/settings`, then close the session with  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. The caller needs the right to add content to the  target folder, which room managers and content creators have and readers, editors and guests do not: they get  403, as does a section root such as Rooms or Archive, while an unknown folder is answered as missing. A  payload above the portal limit for chunked uploads is refused before the session exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="sessionRequest">The file the session is opened for, and how a clash with an existing name is settled.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session/">REST API Reference for CreateUploadSession Operation</seealso>
        /// <returns>ChunkedUploadSessionResponseWrapperIntegerWrapper</returns>
        [Obsolete]
        public ChunkedUploadSessionResponseWrapperIntegerWrapper CreateUploadSession(int folderId, SessionRequest sessionRequest)
        {
            var localVarResponse = CreateUploadSessionWithHttpInfo(folderId, sessionRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Chunked upload
        /// </summary>
        /// <remarks>
        /// Deprecated in favour of `POST api/2.0/files/{folderId}/session`, which opens the same session and returns it  without the success envelope used here; new callers should go there. Reserves a chunked upload of a file in  the folder named by the path: the title comes from `fileName`, the declared payload size from `fileSize`, and  the answer carries the session id every later call quotes, the address of the standalone chunk handler, the  moment an idle session is dropped and the reserved byte count. No content is stored yet. Send the payload as  multipart parts to `POST api/2.0/files/{folderId}/session/{sessionId}/upload`, keeping each part within  `chunkUploadSize` from `GET api/2.0/files/settings`, then close the session with  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. The caller needs the right to add content to the  target folder, which room managers and content creators have and readers, editors and guests do not: they get  403, as does a section root such as Rooms or Archive, while an unknown folder is answered as missing. A  payload above the portal limit for chunked uploads is refused before the session exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="sessionRequest">The file the session is opened for, and how a clash with an existing name is settled.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session/">REST API Reference for CreateUploadSession Operation</seealso>
        /// <returns>ApiResponse of ChunkedUploadSessionResponseWrapperIntegerWrapper</returns>
        [Obsolete]
        public ApiResponse<ChunkedUploadSessionResponseWrapperIntegerWrapper> CreateUploadSessionWithHttpInfo(int folderId, SessionRequest sessionRequest)
        {
            // verify the required parameter 'sessionRequest' is set
            if (sessionRequest == null)
                throw new ApiException(400, "Missing required parameter 'sessionRequest' when calling OperationsApi->CreateUploadSession");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (sessionRequest != null) localVarRequestOptions.Data = sessionRequest;

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
            var localVarResponse = Client.Post<ChunkedUploadSessionResponseWrapperIntegerWrapper>("/api/2.0/files/{folderId}/upload/create_session", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateUploadSession", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Chunked upload
        /// </summary>
        /// <remarks>
        /// Deprecated in favour of `POST api/2.0/files/{folderId}/session`, which opens the same session and returns it  without the success envelope used here; new callers should go there. Reserves a chunked upload of a file in  the folder named by the path: the title comes from `fileName`, the declared payload size from `fileSize`, and  the answer carries the session id every later call quotes, the address of the standalone chunk handler, the  moment an idle session is dropped and the reserved byte count. No content is stored yet. Send the payload as  multipart parts to `POST api/2.0/files/{folderId}/session/{sessionId}/upload`, keeping each part within  `chunkUploadSize` from `GET api/2.0/files/settings`, then close the session with  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. The caller needs the right to add content to the  target folder, which room managers and content creators have and readers, editors and guests do not: they get  403, as does a section root such as Rooms or Archive, while an unknown folder is answered as missing. A  payload above the portal limit for chunked uploads is refused before the session exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="sessionRequest">The file the session is opened for, and how a clash with an existing name is settled.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session/">REST API Reference for CreateUploadSession Operation</seealso>
        /// <returns>Task of ChunkedUploadSessionResponseWrapperIntegerWrapper</returns>
        [Obsolete]
        public async Task<ChunkedUploadSessionResponseWrapperIntegerWrapper> CreateUploadSessionAsync(int folderId, SessionRequest sessionRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateUploadSessionWithHttpInfoAsync(folderId, sessionRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Chunked upload
        /// </summary>
        /// <remarks>
        /// Deprecated in favour of `POST api/2.0/files/{folderId}/session`, which opens the same session and returns it  without the success envelope used here; new callers should go there. Reserves a chunked upload of a file in  the folder named by the path: the title comes from `fileName`, the declared payload size from `fileSize`, and  the answer carries the session id every later call quotes, the address of the standalone chunk handler, the  moment an idle session is dropped and the reserved byte count. No content is stored yet. Send the payload as  multipart parts to `POST api/2.0/files/{folderId}/session/{sessionId}/upload`, keeping each part within  `chunkUploadSize` from `GET api/2.0/files/settings`, then close the session with  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. The caller needs the right to add content to the  target folder, which room managers and content creators have and readers, editors and guests do not: they get  403, as does a section root such as Rooms or Archive, while an unknown folder is answered as missing. A  payload above the portal limit for chunked uploads is refused before the session exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="sessionRequest">The file the session is opened for, and how a clash with an existing name is settled.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session/">REST API Reference for CreateUploadSession Operation</seealso>
        /// <returns>Task of ApiResponse (ChunkedUploadSessionResponseWrapperIntegerWrapper)</returns>
        [Obsolete]
        public async Task<ApiResponse<ChunkedUploadSessionResponseWrapperIntegerWrapper>> CreateUploadSessionWithHttpInfoAsync(int folderId, SessionRequest sessionRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'sessionRequest' is set
            if (sessionRequest == null)
                throw new ApiException(400, "Missing required parameter 'sessionRequest' when calling OperationsApi->CreateUploadSession");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (sessionRequest != null) localVarRequestOptions.Data = sessionRequest;

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

            var localVarResponse = await AsynchronousClient.PostAsync<ChunkedUploadSessionResponseWrapperIntegerWrapper>("/api/2.0/files/{folderId}/upload/create_session", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateUploadSession", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create an upload session
        /// </summary>
        /// <remarks>
        /// Opens a chunked upload session for a file in the folder named by the path and returns the session itself,  which is the difference from the deprecated `POST api/2.0/files/{folderId}/upload/create_session` and its  success envelope. The answer gives `id`, quoted by every later call, `location` for the standalone chunk  handler used by clients that bypass this API, `expired`, and `bytes_total` echoing the reserved size. Whether  parts are really needed follows from `fileSize`: below `chunkUploadSize` from `GET api/2.0/files/settings` the  whole payload goes in one `POST api/2.0/files/{folderId}/session/{sessionId}`, which stores the file and  answers 201, and above it the parts go one by one to  `POST api/2.0/files/{folderId}/session/{sessionId}/upload` and the file appears only after  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. The caller must be allowed to add content to the  folder, so readers, editors and guests are refused, a section root is refused as well, and an unknown folder  is answered as missing. Nothing is written until the parts arrive, and an abandoned session disappears twelve  hours later.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="sessionRequest">The file the session is opened for, and how a clash with an existing name is settled.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session-in-folder/">REST API Reference for CreateUploadSessionInFolder Operation</seealso>
        /// <returns>ChunkedUploadSessionResponseIntegerWrapper</returns>
        public ChunkedUploadSessionResponseIntegerWrapper CreateUploadSessionInFolder(int folderId, SessionRequest sessionRequest)
        {
            var localVarResponse = CreateUploadSessionInFolderWithHttpInfo(folderId, sessionRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an upload session
        /// </summary>
        /// <remarks>
        /// Opens a chunked upload session for a file in the folder named by the path and returns the session itself,  which is the difference from the deprecated `POST api/2.0/files/{folderId}/upload/create_session` and its  success envelope. The answer gives `id`, quoted by every later call, `location` for the standalone chunk  handler used by clients that bypass this API, `expired`, and `bytes_total` echoing the reserved size. Whether  parts are really needed follows from `fileSize`: below `chunkUploadSize` from `GET api/2.0/files/settings` the  whole payload goes in one `POST api/2.0/files/{folderId}/session/{sessionId}`, which stores the file and  answers 201, and above it the parts go one by one to  `POST api/2.0/files/{folderId}/session/{sessionId}/upload` and the file appears only after  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. The caller must be allowed to add content to the  folder, so readers, editors and guests are refused, a section root is refused as well, and an unknown folder  is answered as missing. Nothing is written until the parts arrive, and an abandoned session disappears twelve  hours later.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="sessionRequest">The file the session is opened for, and how a clash with an existing name is settled.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session-in-folder/">REST API Reference for CreateUploadSessionInFolder Operation</seealso>
        /// <returns>ApiResponse of ChunkedUploadSessionResponseIntegerWrapper</returns>
        public ApiResponse<ChunkedUploadSessionResponseIntegerWrapper> CreateUploadSessionInFolderWithHttpInfo(int folderId, SessionRequest sessionRequest)
        {
            // verify the required parameter 'sessionRequest' is set
            if (sessionRequest == null)
                throw new ApiException(400, "Missing required parameter 'sessionRequest' when calling OperationsApi->CreateUploadSessionInFolder");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (sessionRequest != null) localVarRequestOptions.Data = sessionRequest;

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
            var localVarResponse = Client.Post<ChunkedUploadSessionResponseIntegerWrapper>("/api/2.0/files/{folderId}/session", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateUploadSessionInFolder", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create an upload session
        /// </summary>
        /// <remarks>
        /// Opens a chunked upload session for a file in the folder named by the path and returns the session itself,  which is the difference from the deprecated `POST api/2.0/files/{folderId}/upload/create_session` and its  success envelope. The answer gives `id`, quoted by every later call, `location` for the standalone chunk  handler used by clients that bypass this API, `expired`, and `bytes_total` echoing the reserved size. Whether  parts are really needed follows from `fileSize`: below `chunkUploadSize` from `GET api/2.0/files/settings` the  whole payload goes in one `POST api/2.0/files/{folderId}/session/{sessionId}`, which stores the file and  answers 201, and above it the parts go one by one to  `POST api/2.0/files/{folderId}/session/{sessionId}/upload` and the file appears only after  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. The caller must be allowed to add content to the  folder, so readers, editors and guests are refused, a section root is refused as well, and an unknown folder  is answered as missing. Nothing is written until the parts arrive, and an abandoned session disappears twelve  hours later.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="sessionRequest">The file the session is opened for, and how a clash with an existing name is settled.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session-in-folder/">REST API Reference for CreateUploadSessionInFolder Operation</seealso>
        /// <returns>Task of ChunkedUploadSessionResponseIntegerWrapper</returns>
        public async Task<ChunkedUploadSessionResponseIntegerWrapper> CreateUploadSessionInFolderAsync(int folderId, SessionRequest sessionRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateUploadSessionInFolderWithHttpInfoAsync(folderId, sessionRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an upload session
        /// </summary>
        /// <remarks>
        /// Opens a chunked upload session for a file in the folder named by the path and returns the session itself,  which is the difference from the deprecated `POST api/2.0/files/{folderId}/upload/create_session` and its  success envelope. The answer gives `id`, quoted by every later call, `location` for the standalone chunk  handler used by clients that bypass this API, `expired`, and `bytes_total` echoing the reserved size. Whether  parts are really needed follows from `fileSize`: below `chunkUploadSize` from `GET api/2.0/files/settings` the  whole payload goes in one `POST api/2.0/files/{folderId}/session/{sessionId}`, which stores the file and  answers 201, and above it the parts go one by one to  `POST api/2.0/files/{folderId}/session/{sessionId}/upload` and the file appears only after  `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. The caller must be allowed to add content to the  folder, so readers, editors and guests are refused, a section root is refused as well, and an unknown folder  is answered as missing. Nothing is written until the parts arrive, and an abandoned session disappears twelve  hours later.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder that receives the file; take the id from a listing such as `GET api/2.0/files/@root`. A room or an  ordinary folder inside one is accepted, a section root is not.</param>
        /// <param name="sessionRequest">The file the session is opened for, and how a clash with an existing name is settled.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session-in-folder/">REST API Reference for CreateUploadSessionInFolder Operation</seealso>
        /// <returns>Task of ApiResponse (ChunkedUploadSessionResponseIntegerWrapper)</returns>
        public async Task<ApiResponse<ChunkedUploadSessionResponseIntegerWrapper>> CreateUploadSessionInFolderWithHttpInfoAsync(int folderId, SessionRequest sessionRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'sessionRequest' is set
            if (sessionRequest == null)
                throw new ApiException(400, "Missing required parameter 'sessionRequest' when calling OperationsApi->CreateUploadSessionInFolder");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (sessionRequest != null) localVarRequestOptions.Data = sessionRequest;

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

            var localVarResponse = await AsynchronousClient.PostAsync<ChunkedUploadSessionResponseIntegerWrapper>("/api/2.0/files/{folderId}/session", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateUploadSessionInFolder", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that deletes the requested files and folders, and answers with the caller's delete  operations, including the one just started. Poll `GET api/2.0/files/fileops` until the operation reports  `finished`, and read its `error`: a failure on a single item is reported there rather than as a status code.  With `immediately=false` the items are moved to the caller's Trash and can be restored from it, while  `immediately=true` removes them at once and for good; deleting a folder takes everything inside it either way.  The call is destructive and it is not a no-op on repetition — a second call with the same ids deletes whatever  has been restored in the meantime. Access is checked before the job is queued: deleting from a room requires  room manager or content-creator rights, editing or read rights are refused with 403, and an id that resolves  to nothing is answered as missing. An empty selection queues nothing and answers with the operations that are  already there. To clear the Trash itself use `PUT api/2.0/files/fileops/emptytrash`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteBatchRequestDto">The files and folders to delete, and how final the deletion is. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-batch-items/">REST API Reference for DeleteBatchItems Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper DeleteBatchItems(DeleteBatchRequestDto? deleteBatchRequestDto = default)
        {
            var localVarResponse = DeleteBatchItemsWithHttpInfo(deleteBatchRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that deletes the requested files and folders, and answers with the caller's delete  operations, including the one just started. Poll `GET api/2.0/files/fileops` until the operation reports  `finished`, and read its `error`: a failure on a single item is reported there rather than as a status code.  With `immediately=false` the items are moved to the caller's Trash and can be restored from it, while  `immediately=true` removes them at once and for good; deleting a folder takes everything inside it either way.  The call is destructive and it is not a no-op on repetition — a second call with the same ids deletes whatever  has been restored in the meantime. Access is checked before the job is queued: deleting from a room requires  room manager or content-creator rights, editing or read rights are refused with 403, and an id that resolves  to nothing is answered as missing. An empty selection queues nothing and answers with the operations that are  already there. To clear the Trash itself use `PUT api/2.0/files/fileops/emptytrash`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteBatchRequestDto">The files and folders to delete, and how final the deletion is. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-batch-items/">REST API Reference for DeleteBatchItems Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> DeleteBatchItemsWithHttpInfo(DeleteBatchRequestDto? deleteBatchRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (deleteBatchRequestDto != null) localVarRequestOptions.Data = deleteBatchRequestDto;

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
            var localVarResponse = Client.Put<FileOperationArrayWrapper>("/api/2.0/files/fileops/delete", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteBatchItems", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that deletes the requested files and folders, and answers with the caller's delete  operations, including the one just started. Poll `GET api/2.0/files/fileops` until the operation reports  `finished`, and read its `error`: a failure on a single item is reported there rather than as a status code.  With `immediately=false` the items are moved to the caller's Trash and can be restored from it, while  `immediately=true` removes them at once and for good; deleting a folder takes everything inside it either way.  The call is destructive and it is not a no-op on repetition — a second call with the same ids deletes whatever  has been restored in the meantime. Access is checked before the job is queued: deleting from a room requires  room manager or content-creator rights, editing or read rights are refused with 403, and an id that resolves  to nothing is answered as missing. An empty selection queues nothing and answers with the operations that are  already there. To clear the Trash itself use `PUT api/2.0/files/fileops/emptytrash`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteBatchRequestDto">The files and folders to delete, and how final the deletion is. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-batch-items/">REST API Reference for DeleteBatchItems Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async Task<FileOperationArrayWrapper> DeleteBatchItemsAsync(DeleteBatchRequestDto? deleteBatchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeleteBatchItemsWithHttpInfoAsync(deleteBatchRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that deletes the requested files and folders, and answers with the caller's delete  operations, including the one just started. Poll `GET api/2.0/files/fileops` until the operation reports  `finished`, and read its `error`: a failure on a single item is reported there rather than as a status code.  With `immediately=false` the items are moved to the caller's Trash and can be restored from it, while  `immediately=true` removes them at once and for good; deleting a folder takes everything inside it either way.  The call is destructive and it is not a no-op on repetition — a second call with the same ids deletes whatever  has been restored in the meantime. Access is checked before the job is queued: deleting from a room requires  room manager or content-creator rights, editing or read rights are refused with 403, and an id that resolves  to nothing is answered as missing. An empty selection queues nothing and answers with the operations that are  already there. To clear the Trash itself use `PUT api/2.0/files/fileops/emptytrash`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteBatchRequestDto">The files and folders to delete, and how final the deletion is. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-batch-items/">REST API Reference for DeleteBatchItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async Task<ApiResponse<FileOperationArrayWrapper>> DeleteBatchItemsWithHttpInfoAsync(DeleteBatchRequestDto? deleteBatchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (deleteBatchRequestDto != null) localVarRequestOptions.Data = deleteBatchRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<FileOperationArrayWrapper>("/api/2.0/files/fileops/delete", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteBatchItems", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete favorite files and folders
        /// </summary>
        /// <remarks>
        /// Removes the favorite mark from the listed files and folders for the calling account. Nothing is deleted from  storage: the entries keep their place, their content and their sharing, and only disappear from  `GET api/2.0/files/@favorites`; to delete the entries themselves call `PUT api/2.0/files/fileops/delete`  instead. Marks of other members are untouched, and read access to each item is enough to call it. The ids go  into the JSON body documented here; the same route also accepts them as repeated `fileIds` and `folderIds`  query parameters, but only in a request that carries no JSON body at all. Numeric ids address entries stored  in the portal itself, string ids entries on a connected third-party account. The answer is `true` whenever the  request was understood, which an empty request, an id that does not exist and an item that was never marked  all achieve, so it does not report how many marks were dropped. `returnSingleOperation` arrives with the  shared body and does nothing here. Repeating the call is safe. Use `POST api/2.0/files/favorites` to mark  entries again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-favorites-from-body/">REST API Reference for DeleteFavoritesFromBody Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper DeleteFavoritesFromBody(BaseBatchRequestDto? baseBatchRequestDto = default)
        {
            var localVarResponse = DeleteFavoritesFromBodyWithHttpInfo(baseBatchRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete favorite files and folders
        /// </summary>
        /// <remarks>
        /// Removes the favorite mark from the listed files and folders for the calling account. Nothing is deleted from  storage: the entries keep their place, their content and their sharing, and only disappear from  `GET api/2.0/files/@favorites`; to delete the entries themselves call `PUT api/2.0/files/fileops/delete`  instead. Marks of other members are untouched, and read access to each item is enough to call it. The ids go  into the JSON body documented here; the same route also accepts them as repeated `fileIds` and `folderIds`  query parameters, but only in a request that carries no JSON body at all. Numeric ids address entries stored  in the portal itself, string ids entries on a connected third-party account. The answer is `true` whenever the  request was understood, which an empty request, an id that does not exist and an item that was never marked  all achieve, so it does not report how many marks were dropped. `returnSingleOperation` arrives with the  shared body and does nothing here. Repeating the call is safe. Use `POST api/2.0/files/favorites` to mark  entries again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-favorites-from-body/">REST API Reference for DeleteFavoritesFromBody Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> DeleteFavoritesFromBodyWithHttpInfo(BaseBatchRequestDto? baseBatchRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (baseBatchRequestDto != null) localVarRequestOptions.Data = baseBatchRequestDto;

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
            var localVarResponse = Client.Delete<BooleanWrapper>("/api/2.0/files/favorites", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteFavoritesFromBody", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete favorite files and folders
        /// </summary>
        /// <remarks>
        /// Removes the favorite mark from the listed files and folders for the calling account. Nothing is deleted from  storage: the entries keep their place, their content and their sharing, and only disappear from  `GET api/2.0/files/@favorites`; to delete the entries themselves call `PUT api/2.0/files/fileops/delete`  instead. Marks of other members are untouched, and read access to each item is enough to call it. The ids go  into the JSON body documented here; the same route also accepts them as repeated `fileIds` and `folderIds`  query parameters, but only in a request that carries no JSON body at all. Numeric ids address entries stored  in the portal itself, string ids entries on a connected third-party account. The answer is `true` whenever the  request was understood, which an empty request, an id that does not exist and an item that was never marked  all achieve, so it does not report how many marks were dropped. `returnSingleOperation` arrives with the  shared body and does nothing here. Repeating the call is safe. Use `POST api/2.0/files/favorites` to mark  entries again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-favorites-from-body/">REST API Reference for DeleteFavoritesFromBody Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> DeleteFavoritesFromBodyAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeleteFavoritesFromBodyWithHttpInfoAsync(baseBatchRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete favorite files and folders
        /// </summary>
        /// <remarks>
        /// Removes the favorite mark from the listed files and folders for the calling account. Nothing is deleted from  storage: the entries keep their place, their content and their sharing, and only disappear from  `GET api/2.0/files/@favorites`; to delete the entries themselves call `PUT api/2.0/files/fileops/delete`  instead. Marks of other members are untouched, and read access to each item is enough to call it. The ids go  into the JSON body documented here; the same route also accepts them as repeated `fileIds` and `folderIds`  query parameters, but only in a request that carries no JSON body at all. Numeric ids address entries stored  in the portal itself, string ids entries on a connected third-party account. The answer is `true` whenever the  request was understood, which an empty request, an id that does not exist and an item that was never marked  all achieve, so it does not report how many marks were dropped. `returnSingleOperation` arrives with the  shared body and does nothing here. Repeating the call is safe. Use `POST api/2.0/files/favorites` to mark  entries again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-favorites-from-body/">REST API Reference for DeleteFavoritesFromBody Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> DeleteFavoritesFromBodyWithHttpInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (baseBatchRequestDto != null) localVarRequestOptions.Data = baseBatchRequestDto;

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<BooleanWrapper>("/api/2.0/files/favorites", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteFavoritesFromBody", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete file versions
        /// </summary>
        /// <remarks>
        /// Queues a background job that removes the listed versions from the history of one file, and answers with the  caller's delete operations, including the one just started. Poll `GET api/2.0/files/fileops` until the  operation reports `finished`; a failure met while the job runs is reported in its `error` rather than as a  status code. Removal is permanent — deleted versions do not travel through Trash and cannot be restored, while  the file itself stays in place with the versions that are left. Send the numbers that  `GET api/2.0/files/file/{fileId}/history` reports, and send at least one: an empty list is not an empty  request, it deletes the whole file instead. The number of the current version is refused before anything is  queued, while numbers that no longer exist are passed over without a complaint. The caller needs the rights  that deleting the file itself would need, so a member with read-only rights is refused, as are a file in an  archived room and a file that is already in Trash, and a file that does not exist is answered as missing. To  delete the file itself use `PUT api/2.0/files/fileops/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteVersionBatchRequestDto">The file whose versions are deleted, and the versions to delete. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file-versions/">REST API Reference for DeleteFileVersions Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper DeleteFileVersions(DeleteVersionBatchRequestDto? deleteVersionBatchRequestDto = default)
        {
            var localVarResponse = DeleteFileVersionsWithHttpInfo(deleteVersionBatchRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete file versions
        /// </summary>
        /// <remarks>
        /// Queues a background job that removes the listed versions from the history of one file, and answers with the  caller's delete operations, including the one just started. Poll `GET api/2.0/files/fileops` until the  operation reports `finished`; a failure met while the job runs is reported in its `error` rather than as a  status code. Removal is permanent — deleted versions do not travel through Trash and cannot be restored, while  the file itself stays in place with the versions that are left. Send the numbers that  `GET api/2.0/files/file/{fileId}/history` reports, and send at least one: an empty list is not an empty  request, it deletes the whole file instead. The number of the current version is refused before anything is  queued, while numbers that no longer exist are passed over without a complaint. The caller needs the rights  that deleting the file itself would need, so a member with read-only rights is refused, as are a file in an  archived room and a file that is already in Trash, and a file that does not exist is answered as missing. To  delete the file itself use `PUT api/2.0/files/fileops/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteVersionBatchRequestDto">The file whose versions are deleted, and the versions to delete. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file-versions/">REST API Reference for DeleteFileVersions Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> DeleteFileVersionsWithHttpInfo(DeleteVersionBatchRequestDto? deleteVersionBatchRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (deleteVersionBatchRequestDto != null) localVarRequestOptions.Data = deleteVersionBatchRequestDto;

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
            var localVarResponse = Client.Put<FileOperationArrayWrapper>("/api/2.0/files/fileops/deleteversion", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteFileVersions", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete file versions
        /// </summary>
        /// <remarks>
        /// Queues a background job that removes the listed versions from the history of one file, and answers with the  caller's delete operations, including the one just started. Poll `GET api/2.0/files/fileops` until the  operation reports `finished`; a failure met while the job runs is reported in its `error` rather than as a  status code. Removal is permanent — deleted versions do not travel through Trash and cannot be restored, while  the file itself stays in place with the versions that are left. Send the numbers that  `GET api/2.0/files/file/{fileId}/history` reports, and send at least one: an empty list is not an empty  request, it deletes the whole file instead. The number of the current version is refused before anything is  queued, while numbers that no longer exist are passed over without a complaint. The caller needs the rights  that deleting the file itself would need, so a member with read-only rights is refused, as are a file in an  archived room and a file that is already in Trash, and a file that does not exist is answered as missing. To  delete the file itself use `PUT api/2.0/files/fileops/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteVersionBatchRequestDto">The file whose versions are deleted, and the versions to delete. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file-versions/">REST API Reference for DeleteFileVersions Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async Task<FileOperationArrayWrapper> DeleteFileVersionsAsync(DeleteVersionBatchRequestDto? deleteVersionBatchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeleteFileVersionsWithHttpInfoAsync(deleteVersionBatchRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete file versions
        /// </summary>
        /// <remarks>
        /// Queues a background job that removes the listed versions from the history of one file, and answers with the  caller's delete operations, including the one just started. Poll `GET api/2.0/files/fileops` until the  operation reports `finished`; a failure met while the job runs is reported in its `error` rather than as a  status code. Removal is permanent — deleted versions do not travel through Trash and cannot be restored, while  the file itself stays in place with the versions that are left. Send the numbers that  `GET api/2.0/files/file/{fileId}/history` reports, and send at least one: an empty list is not an empty  request, it deletes the whole file instead. The number of the current version is refused before anything is  queued, while numbers that no longer exist are passed over without a complaint. The caller needs the rights  that deleting the file itself would need, so a member with read-only rights is refused, as are a file in an  archived room and a file that is already in Trash, and a file that does not exist is answered as missing. To  delete the file itself use `PUT api/2.0/files/fileops/delete`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteVersionBatchRequestDto">The file whose versions are deleted, and the versions to delete. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file-versions/">REST API Reference for DeleteFileVersions Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async Task<ApiResponse<FileOperationArrayWrapper>> DeleteFileVersionsWithHttpInfoAsync(DeleteVersionBatchRequestDto? deleteVersionBatchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (deleteVersionBatchRequestDto != null) localVarRequestOptions.Data = deleteVersionBatchRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<FileOperationArrayWrapper>("/api/2.0/files/fileops/deleteversion", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteFileVersions", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Duplicate files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that copies each requested file and folder next to itself, into the folder where it  already is, and answers with the caller's duplicate operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. The copies keep the name of the original  with a numeric suffix, so nothing is overwritten and every repetition adds one more copy; duplicating a folder  duplicates its content as well. No destination is taken — to place a copy somewhere else use  `PUT api/2.0/files/fileops/copy`. The caller needs the rights that creating an item in that folder would need,  which inside a room means room manager or content-creator rights: read or editing rights, and an item the  caller has no access to at all, are refused with 403. An empty selection queues nothing and answers with the  operations that are already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="duplicateRequestDto">The files and folders to duplicate. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/duplicate-batch-items/">REST API Reference for DuplicateBatchItems Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper DuplicateBatchItems(DuplicateRequestDto? duplicateRequestDto = default)
        {
            var localVarResponse = DuplicateBatchItemsWithHttpInfo(duplicateRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Duplicate files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that copies each requested file and folder next to itself, into the folder where it  already is, and answers with the caller's duplicate operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. The copies keep the name of the original  with a numeric suffix, so nothing is overwritten and every repetition adds one more copy; duplicating a folder  duplicates its content as well. No destination is taken — to place a copy somewhere else use  `PUT api/2.0/files/fileops/copy`. The caller needs the rights that creating an item in that folder would need,  which inside a room means room manager or content-creator rights: read or editing rights, and an item the  caller has no access to at all, are refused with 403. An empty selection queues nothing and answers with the  operations that are already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="duplicateRequestDto">The files and folders to duplicate. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/duplicate-batch-items/">REST API Reference for DuplicateBatchItems Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> DuplicateBatchItemsWithHttpInfo(DuplicateRequestDto? duplicateRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (duplicateRequestDto != null) localVarRequestOptions.Data = duplicateRequestDto;

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
            var localVarResponse = Client.Put<FileOperationArrayWrapper>("/api/2.0/files/fileops/duplicate", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DuplicateBatchItems", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Duplicate files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that copies each requested file and folder next to itself, into the folder where it  already is, and answers with the caller's duplicate operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. The copies keep the name of the original  with a numeric suffix, so nothing is overwritten and every repetition adds one more copy; duplicating a folder  duplicates its content as well. No destination is taken — to place a copy somewhere else use  `PUT api/2.0/files/fileops/copy`. The caller needs the rights that creating an item in that folder would need,  which inside a room means room manager or content-creator rights: read or editing rights, and an item the  caller has no access to at all, are refused with 403. An empty selection queues nothing and answers with the  operations that are already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="duplicateRequestDto">The files and folders to duplicate. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/duplicate-batch-items/">REST API Reference for DuplicateBatchItems Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async Task<FileOperationArrayWrapper> DuplicateBatchItemsAsync(DuplicateRequestDto? duplicateRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DuplicateBatchItemsWithHttpInfoAsync(duplicateRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Duplicate files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that copies each requested file and folder next to itself, into the folder where it  already is, and answers with the caller's duplicate operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. The copies keep the name of the original  with a numeric suffix, so nothing is overwritten and every repetition adds one more copy; duplicating a folder  duplicates its content as well. No destination is taken — to place a copy somewhere else use  `PUT api/2.0/files/fileops/copy`. The caller needs the rights that creating an item in that folder would need,  which inside a room means room manager or content-creator rights: read or editing rights, and an item the  caller has no access to at all, are refused with 403. An empty selection queues nothing and answers with the  operations that are already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="duplicateRequestDto">The files and folders to duplicate. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/duplicate-batch-items/">REST API Reference for DuplicateBatchItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async Task<ApiResponse<FileOperationArrayWrapper>> DuplicateBatchItemsWithHttpInfoAsync(DuplicateRequestDto? duplicateRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (duplicateRequestDto != null) localVarRequestOptions.Data = duplicateRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<FileOperationArrayWrapper>("/api/2.0/files/fileops/duplicate", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DuplicateBatchItems", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Empty the Trash folder
        /// </summary>
        /// <remarks>
        /// Queues a background job that permanently removes the content of the caller's own Trash, and answers with the  caller's delete operations, including the one just started. Poll `GET api/2.0/files/fileops` until the  operation reports `finished`. Every authenticated account may empty its own Trash and only its own: no  per-item access check takes place because nothing outside the caller's Trash is touched. With `folderType` the  sweep is narrowed to the items that were originally stored in sections and rooms of the named types, so  clearing what came from personal documents leaves what came from rooms untouched; without the parameter the  whole Trash is emptied. What is removed here cannot be restored afterwards, which is the difference from  `PUT api/2.0/files/fileops/delete`, where `immediately=false` puts items into Trash in the first place.  Calling it on an already empty Trash queues nothing and answers with the operations that are already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="single">Which operations the answer carries: `true` returns the operation this call started and nothing else, `false`  returns every delete operation that the caller has running or unread. (optional)</param>
        /// <param name="folderType">Limits the sweep to the items whose original location was inside a section or a room of one of the named  types, leaving the rest of the Trash untouched; without the parameter the whole Trash is emptied. `5` covers  what was deleted from personal documents, `14` what was deleted from rooms. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/empty-trash/">REST API Reference for EmptyTrash Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper EmptyTrash(bool? single = default, List<int>? folderType = default)
        {
            var localVarResponse = EmptyTrashWithHttpInfo(single, folderType);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Empty the Trash folder
        /// </summary>
        /// <remarks>
        /// Queues a background job that permanently removes the content of the caller's own Trash, and answers with the  caller's delete operations, including the one just started. Poll `GET api/2.0/files/fileops` until the  operation reports `finished`. Every authenticated account may empty its own Trash and only its own: no  per-item access check takes place because nothing outside the caller's Trash is touched. With `folderType` the  sweep is narrowed to the items that were originally stored in sections and rooms of the named types, so  clearing what came from personal documents leaves what came from rooms untouched; without the parameter the  whole Trash is emptied. What is removed here cannot be restored afterwards, which is the difference from  `PUT api/2.0/files/fileops/delete`, where `immediately=false` puts items into Trash in the first place.  Calling it on an already empty Trash queues nothing and answers with the operations that are already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="single">Which operations the answer carries: `true` returns the operation this call started and nothing else, `false`  returns every delete operation that the caller has running or unread. (optional)</param>
        /// <param name="folderType">Limits the sweep to the items whose original location was inside a section or a room of one of the named  types, leaving the rest of the Trash untouched; without the parameter the whole Trash is emptied. `5` covers  what was deleted from personal documents, `14` what was deleted from rooms. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/empty-trash/">REST API Reference for EmptyTrash Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> EmptyTrashWithHttpInfo(bool? single = default, List<int>? folderType = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (single != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Single", single));
            }
            if (folderType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("multi", "folderType", folderType));
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
            var localVarResponse = Client.Put<FileOperationArrayWrapper>("/api/2.0/files/fileops/emptytrash", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("EmptyTrash", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Empty the Trash folder
        /// </summary>
        /// <remarks>
        /// Queues a background job that permanently removes the content of the caller's own Trash, and answers with the  caller's delete operations, including the one just started. Poll `GET api/2.0/files/fileops` until the  operation reports `finished`. Every authenticated account may empty its own Trash and only its own: no  per-item access check takes place because nothing outside the caller's Trash is touched. With `folderType` the  sweep is narrowed to the items that were originally stored in sections and rooms of the named types, so  clearing what came from personal documents leaves what came from rooms untouched; without the parameter the  whole Trash is emptied. What is removed here cannot be restored afterwards, which is the difference from  `PUT api/2.0/files/fileops/delete`, where `immediately=false` puts items into Trash in the first place.  Calling it on an already empty Trash queues nothing and answers with the operations that are already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="single">Which operations the answer carries: `true` returns the operation this call started and nothing else, `false`  returns every delete operation that the caller has running or unread. (optional)</param>
        /// <param name="folderType">Limits the sweep to the items whose original location was inside a section or a room of one of the named  types, leaving the rest of the Trash untouched; without the parameter the whole Trash is emptied. `5` covers  what was deleted from personal documents, `14` what was deleted from rooms. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/empty-trash/">REST API Reference for EmptyTrash Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async Task<FileOperationArrayWrapper> EmptyTrashAsync(bool? single = default, List<int>? folderType = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await EmptyTrashWithHttpInfoAsync(single, folderType, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Empty the Trash folder
        /// </summary>
        /// <remarks>
        /// Queues a background job that permanently removes the content of the caller's own Trash, and answers with the  caller's delete operations, including the one just started. Poll `GET api/2.0/files/fileops` until the  operation reports `finished`. Every authenticated account may empty its own Trash and only its own: no  per-item access check takes place because nothing outside the caller's Trash is touched. With `folderType` the  sweep is narrowed to the items that were originally stored in sections and rooms of the named types, so  clearing what came from personal documents leaves what came from rooms untouched; without the parameter the  whole Trash is emptied. What is removed here cannot be restored afterwards, which is the difference from  `PUT api/2.0/files/fileops/delete`, where `immediately=false` puts items into Trash in the first place.  Calling it on an already empty Trash queues nothing and answers with the operations that are already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="single">Which operations the answer carries: `true` returns the operation this call started and nothing else, `false`  returns every delete operation that the caller has running or unread. (optional)</param>
        /// <param name="folderType">Limits the sweep to the items whose original location was inside a section or a room of one of the named  types, leaving the rest of the Trash untouched; without the parameter the whole Trash is emptied. `5` covers  what was deleted from personal documents, `14` what was deleted from rooms. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/empty-trash/">REST API Reference for EmptyTrash Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async Task<ApiResponse<FileOperationArrayWrapper>> EmptyTrashWithHttpInfoAsync(bool? single = default, List<int>? folderType = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (single != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Single", single));
            }
            if (folderType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("multi", "folderType", folderType));
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

            var localVarResponse = await AsynchronousClient.PutAsync<FileOperationArrayWrapper>("/api/2.0/files/fileops/emptytrash", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("EmptyTrash", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Finalize an upload session
        /// </summary>
        /// <remarks>
        /// Assembles the parts received so far into the file the session was opened for and closes the session. What  comes out depends on how the session started: one opened against an existing file through  `POST api/2.0/files/file/{fileId}/edit_session` replaces that content in place and keeps the version number,  while one opened against a folder either creates the file or, when a file of the same name was taken over,  stores the content as its next version. A form loses its filling state on the way in. The answer arrives with  201 and carries the identifiers of the file together with the file itself. The call ends the session: the  record and the buffered parts are removed, so it cannot be repeated and there is nothing left to abort  afterwards. Running it before all the declared bytes have arrived assembles whatever is there, so read the  progress from the chunk calls first. An unknown, already closed or expired session id fails instead of  answering as missing.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session to assemble, as returned in `id` when it was created: a 32-character hexadecimal string that  identifies the session on its own.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/finalize-session/">REST API Reference for FinalizeSession Operation</seealso>
        /// <returns>UploadSessionResponseIntegerWrapper</returns>
        public UploadSessionResponseIntegerWrapper FinalizeSession(int folderId, string sessionId)
        {
            var localVarResponse = FinalizeSessionWithHttpInfo(folderId, sessionId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Finalize an upload session
        /// </summary>
        /// <remarks>
        /// Assembles the parts received so far into the file the session was opened for and closes the session. What  comes out depends on how the session started: one opened against an existing file through  `POST api/2.0/files/file/{fileId}/edit_session` replaces that content in place and keeps the version number,  while one opened against a folder either creates the file or, when a file of the same name was taken over,  stores the content as its next version. A form loses its filling state on the way in. The answer arrives with  201 and carries the identifiers of the file together with the file itself. The call ends the session: the  record and the buffered parts are removed, so it cannot be repeated and there is nothing left to abort  afterwards. Running it before all the declared bytes have arrived assembles whatever is there, so read the  progress from the chunk calls first. An unknown, already closed or expired session id fails instead of  answering as missing.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session to assemble, as returned in `id` when it was created: a 32-character hexadecimal string that  identifies the session on its own.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/finalize-session/">REST API Reference for FinalizeSession Operation</seealso>
        /// <returns>ApiResponse of UploadSessionResponseIntegerWrapper</returns>
        public ApiResponse<UploadSessionResponseIntegerWrapper> FinalizeSessionWithHttpInfo(int folderId, string sessionId)
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling OperationsApi->FinalizeSession");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            localVarRequestOptions.PathParameters.Add("sessionId", ClientUtils.ParameterToString(sessionId)); // path parameter

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
            var localVarResponse = Client.Put<UploadSessionResponseIntegerWrapper>("/api/2.0/files/{folderId}/session/{sessionId}/finalize", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("FinalizeSession", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Finalize an upload session
        /// </summary>
        /// <remarks>
        /// Assembles the parts received so far into the file the session was opened for and closes the session. What  comes out depends on how the session started: one opened against an existing file through  `POST api/2.0/files/file/{fileId}/edit_session` replaces that content in place and keeps the version number,  while one opened against a folder either creates the file or, when a file of the same name was taken over,  stores the content as its next version. A form loses its filling state on the way in. The answer arrives with  201 and carries the identifiers of the file together with the file itself. The call ends the session: the  record and the buffered parts are removed, so it cannot be repeated and there is nothing left to abort  afterwards. Running it before all the declared bytes have arrived assembles whatever is there, so read the  progress from the chunk calls first. An unknown, already closed or expired session id fails instead of  answering as missing.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session to assemble, as returned in `id` when it was created: a 32-character hexadecimal string that  identifies the session on its own.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/finalize-session/">REST API Reference for FinalizeSession Operation</seealso>
        /// <returns>Task of UploadSessionResponseIntegerWrapper</returns>
        public async Task<UploadSessionResponseIntegerWrapper> FinalizeSessionAsync(int folderId, string sessionId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await FinalizeSessionWithHttpInfoAsync(folderId, sessionId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Finalize an upload session
        /// </summary>
        /// <remarks>
        /// Assembles the parts received so far into the file the session was opened for and closes the session. What  comes out depends on how the session started: one opened against an existing file through  `POST api/2.0/files/file/{fileId}/edit_session` replaces that content in place and keeps the version number,  while one opened against a folder either creates the file or, when a file of the same name was taken over,  stores the content as its next version. A form loses its filling state on the way in. The answer arrives with  201 and carries the identifiers of the file together with the file itself. The call ends the session: the  record and the buffered parts are removed, so it cannot be repeated and there is nothing left to abort  afterwards. Running it before all the declared bytes have arrived assembles whatever is there, so read the  progress from the chunk calls first. An unknown, already closed or expired session id fails instead of  answering as missing.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session to assemble, as returned in `id` when it was created: a 32-character hexadecimal string that  identifies the session on its own.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/finalize-session/">REST API Reference for FinalizeSession Operation</seealso>
        /// <returns>Task of ApiResponse (UploadSessionResponseIntegerWrapper)</returns>
        public async Task<ApiResponse<UploadSessionResponseIntegerWrapper>> FinalizeSessionWithHttpInfoAsync(int folderId, string sessionId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling OperationsApi->FinalizeSession");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            localVarRequestOptions.PathParameters.Add("sessionId", ClientUtils.ParameterToString(sessionId)); // path parameter

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

            var localVarResponse = await AsynchronousClient.PutAsync<UploadSessionResponseIntegerWrapper>("/api/2.0/files/{folderId}/session/{sessionId}/finalize", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("FinalizeSession", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get active file operations
        /// </summary>
        /// <remarks>
        /// Returns the background file operations of the caller that are still running or whose finished result has not  been read yet, grouped by kind: duplications first, then moves and copies, deletions, downloads and  mark-as-read. This is the polling target for every operation in this section — an operation appears here as  soon as it is queued and carries `progress` from 0 to 100, `finished`, the `error` of a failed item and, for a  download, the address of the archive in `url`. A record is dropped once its finished state has been handed  out, so a completed operation is reported once and an empty array means there is nothing left to report rather  than that the work failed. Pass `id` to follow a single operation; an id that is not among the caller's  operations gives an empty array. Operations are private to the account that started them, an anonymous caller  being scoped to the session of the external link. The call changes nothing. To follow one kind only use  `GET api/2.0/files/fileops/{operationType}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The operation to report on, as returned in `id` when it was started; without it every operation of the caller  is reported. An id that is not among the caller's operations gives an empty answer rather than an error. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses/">REST API Reference for GetOperationStatuses Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper GetOperationStatuses(string? id = default)
        {
            var localVarResponse = GetOperationStatusesWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get active file operations
        /// </summary>
        /// <remarks>
        /// Returns the background file operations of the caller that are still running or whose finished result has not  been read yet, grouped by kind: duplications first, then moves and copies, deletions, downloads and  mark-as-read. This is the polling target for every operation in this section — an operation appears here as  soon as it is queued and carries `progress` from 0 to 100, `finished`, the `error` of a failed item and, for a  download, the address of the archive in `url`. A record is dropped once its finished state has been handed  out, so a completed operation is reported once and an empty array means there is nothing left to report rather  than that the work failed. Pass `id` to follow a single operation; an id that is not among the caller's  operations gives an empty array. Operations are private to the account that started them, an anonymous caller  being scoped to the session of the external link. The call changes nothing. To follow one kind only use  `GET api/2.0/files/fileops/{operationType}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The operation to report on, as returned in `id` when it was started; without it every operation of the caller  is reported. An id that is not among the caller's operations gives an empty answer rather than an error. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses/">REST API Reference for GetOperationStatuses Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> GetOperationStatusesWithHttpInfo(string? id = default)
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


            // make the HTTP request
            var localVarResponse = Client.Get<FileOperationArrayWrapper>("/api/2.0/files/fileops", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetOperationStatuses", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get active file operations
        /// </summary>
        /// <remarks>
        /// Returns the background file operations of the caller that are still running or whose finished result has not  been read yet, grouped by kind: duplications first, then moves and copies, deletions, downloads and  mark-as-read. This is the polling target for every operation in this section — an operation appears here as  soon as it is queued and carries `progress` from 0 to 100, `finished`, the `error` of a failed item and, for a  download, the address of the archive in `url`. A record is dropped once its finished state has been handed  out, so a completed operation is reported once and an empty array means there is nothing left to report rather  than that the work failed. Pass `id` to follow a single operation; an id that is not among the caller's  operations gives an empty array. Operations are private to the account that started them, an anonymous caller  being scoped to the session of the external link. The call changes nothing. To follow one kind only use  `GET api/2.0/files/fileops/{operationType}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The operation to report on, as returned in `id` when it was started; without it every operation of the caller  is reported. An id that is not among the caller's operations gives an empty answer rather than an error. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses/">REST API Reference for GetOperationStatuses Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async Task<FileOperationArrayWrapper> GetOperationStatusesAsync(string? id = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetOperationStatusesWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get active file operations
        /// </summary>
        /// <remarks>
        /// Returns the background file operations of the caller that are still running or whose finished result has not  been read yet, grouped by kind: duplications first, then moves and copies, deletions, downloads and  mark-as-read. This is the polling target for every operation in this section — an operation appears here as  soon as it is queued and carries `progress` from 0 to 100, `finished`, the `error` of a failed item and, for a  download, the address of the archive in `url`. A record is dropped once its finished state has been handed  out, so a completed operation is reported once and an empty array means there is nothing left to report rather  than that the work failed. Pass `id` to follow a single operation; an id that is not among the caller's  operations gives an empty array. Operations are private to the account that started them, an anonymous caller  being scoped to the session of the external link. The call changes nothing. To follow one kind only use  `GET api/2.0/files/fileops/{operationType}`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The operation to report on, as returned in `id` when it was started; without it every operation of the caller  is reported. An id that is not among the caller's operations gives an empty answer rather than an error. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses/">REST API Reference for GetOperationStatuses Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async Task<ApiResponse<FileOperationArrayWrapper>> GetOperationStatusesWithHttpInfoAsync(string? id = default, CancellationToken cancellationToken = default)
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


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<FileOperationArrayWrapper>("/api/2.0/files/fileops", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetOperationStatuses", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get file operations by type
        /// </summary>
        /// <remarks>
        /// Returns the background file operations of the caller that are of one kind, named by the number in the route:  `1` for a copy, `2` for a deletion, `3` for a download, `4` for a mark-as-read and `7` for a duplication. The  answer carries the same records as `GET api/2.0/files/fileops`, with the same rule that a finished operation  is reported once and then dropped, and `id` narrows it further to a single operation. Moves, kind `0`, cannot  be read through this route: the address `api/2.0/files/fileops/move` belongs to another operation, so read  moves from `GET api/2.0/files/fileops` and pick the records whose `operation` is `0`. A kind that has no queue  of its own — `5` for an import, `6` for a conversion — is accepted and answers with an empty array, while a  number outside the operation type is rejected as an invalid request. The call changes nothing and never shows  another account's operations.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationType">The kind of operation the answer is limited to. Only the kinds that have a queue of their own ever carry  records — a copy, a deletion, a download, a mark-as-read and a duplication — and moves cannot be read through  this route at all, because its address belongs to another operation.</param>
        /// <param name="id">The operation to report on, as returned in `id` when it was started; without it every operation of the caller  is reported. An id that is not among the caller's operations gives an empty answer rather than an error. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses-by-type/">REST API Reference for GetOperationStatusesByType Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper GetOperationStatusesByType(FileOperationType operationType, string? id = default)
        {
            var localVarResponse = GetOperationStatusesByTypeWithHttpInfo(operationType, id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get file operations by type
        /// </summary>
        /// <remarks>
        /// Returns the background file operations of the caller that are of one kind, named by the number in the route:  `1` for a copy, `2` for a deletion, `3` for a download, `4` for a mark-as-read and `7` for a duplication. The  answer carries the same records as `GET api/2.0/files/fileops`, with the same rule that a finished operation  is reported once and then dropped, and `id` narrows it further to a single operation. Moves, kind `0`, cannot  be read through this route: the address `api/2.0/files/fileops/move` belongs to another operation, so read  moves from `GET api/2.0/files/fileops` and pick the records whose `operation` is `0`. A kind that has no queue  of its own — `5` for an import, `6` for a conversion — is accepted and answers with an empty array, while a  number outside the operation type is rejected as an invalid request. The call changes nothing and never shows  another account's operations.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationType">The kind of operation the answer is limited to. Only the kinds that have a queue of their own ever carry  records — a copy, a deletion, a download, a mark-as-read and a duplication — and moves cannot be read through  this route at all, because its address belongs to another operation.</param>
        /// <param name="id">The operation to report on, as returned in `id` when it was started; without it every operation of the caller  is reported. An id that is not among the caller's operations gives an empty answer rather than an error. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses-by-type/">REST API Reference for GetOperationStatusesByType Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> GetOperationStatusesByTypeWithHttpInfo(FileOperationType operationType, string? id = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("operationType", ClientUtils.ParameterToString(operationType)); // path parameter
            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "id", id));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<FileOperationArrayWrapper>("/api/2.0/files/fileops/{operationType}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetOperationStatusesByType", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get file operations by type
        /// </summary>
        /// <remarks>
        /// Returns the background file operations of the caller that are of one kind, named by the number in the route:  `1` for a copy, `2` for a deletion, `3` for a download, `4` for a mark-as-read and `7` for a duplication. The  answer carries the same records as `GET api/2.0/files/fileops`, with the same rule that a finished operation  is reported once and then dropped, and `id` narrows it further to a single operation. Moves, kind `0`, cannot  be read through this route: the address `api/2.0/files/fileops/move` belongs to another operation, so read  moves from `GET api/2.0/files/fileops` and pick the records whose `operation` is `0`. A kind that has no queue  of its own — `5` for an import, `6` for a conversion — is accepted and answers with an empty array, while a  number outside the operation type is rejected as an invalid request. The call changes nothing and never shows  another account's operations.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationType">The kind of operation the answer is limited to. Only the kinds that have a queue of their own ever carry  records — a copy, a deletion, a download, a mark-as-read and a duplication — and moves cannot be read through  this route at all, because its address belongs to another operation.</param>
        /// <param name="id">The operation to report on, as returned in `id` when it was started; without it every operation of the caller  is reported. An id that is not among the caller's operations gives an empty answer rather than an error. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses-by-type/">REST API Reference for GetOperationStatusesByType Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async Task<FileOperationArrayWrapper> GetOperationStatusesByTypeAsync(FileOperationType operationType, string? id = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetOperationStatusesByTypeWithHttpInfoAsync(operationType, id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get file operations by type
        /// </summary>
        /// <remarks>
        /// Returns the background file operations of the caller that are of one kind, named by the number in the route:  `1` for a copy, `2` for a deletion, `3` for a download, `4` for a mark-as-read and `7` for a duplication. The  answer carries the same records as `GET api/2.0/files/fileops`, with the same rule that a finished operation  is reported once and then dropped, and `id` narrows it further to a single operation. Moves, kind `0`, cannot  be read through this route: the address `api/2.0/files/fileops/move` belongs to another operation, so read  moves from `GET api/2.0/files/fileops` and pick the records whose `operation` is `0`. A kind that has no queue  of its own — `5` for an import, `6` for a conversion — is accepted and answers with an empty array, while a  number outside the operation type is rejected as an invalid request. The call changes nothing and never shows  another account's operations.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationType">The kind of operation the answer is limited to. Only the kinds that have a queue of their own ever carry  records — a copy, a deletion, a download, a mark-as-read and a duplication — and moves cannot be read through  this route at all, because its address belongs to another operation.</param>
        /// <param name="id">The operation to report on, as returned in `id` when it was started; without it every operation of the caller  is reported. An id that is not among the caller's operations gives an empty answer rather than an error. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses-by-type/">REST API Reference for GetOperationStatusesByType Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async Task<ApiResponse<FileOperationArrayWrapper>> GetOperationStatusesByTypeWithHttpInfoAsync(FileOperationType operationType, string? id = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("operationType", ClientUtils.ParameterToString(operationType)); // path parameter
            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "id", id));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<FileOperationArrayWrapper>("/api/2.0/files/fileops/{operationType}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetOperationStatusesByType", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Mark files and folders as read
        /// </summary>
        /// <remarks>
        /// Queues a background job that clears the new-item badge from the requested files and folders for the calling  account, and answers with the caller's mark-as-read operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. Marking a folder clears the badges of  everything inside it as well. Items the caller cannot read are passed over in silence rather than refused, so  the call succeeds even when the whole selection is inaccessible, and an empty selection queues nothing and  answers with the operations that are already there. Repeating the call on items that are already read changes  nothing, and nothing is opened, moved or modified by it — only the caller's own badges are affected, while  other members keep theirs. To see what is currently marked as new use `GET api/2.0/files/{folderId}/news` for  one folder and `GET api/2.0/files/rooms/news` for the rooms of the caller.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-as-read/">REST API Reference for MarkAsRead Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper MarkAsRead(BaseBatchRequestDto? baseBatchRequestDto = default)
        {
            var localVarResponse = MarkAsReadWithHttpInfo(baseBatchRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Mark files and folders as read
        /// </summary>
        /// <remarks>
        /// Queues a background job that clears the new-item badge from the requested files and folders for the calling  account, and answers with the caller's mark-as-read operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. Marking a folder clears the badges of  everything inside it as well. Items the caller cannot read are passed over in silence rather than refused, so  the call succeeds even when the whole selection is inaccessible, and an empty selection queues nothing and  answers with the operations that are already there. Repeating the call on items that are already read changes  nothing, and nothing is opened, moved or modified by it — only the caller's own badges are affected, while  other members keep theirs. To see what is currently marked as new use `GET api/2.0/files/{folderId}/news` for  one folder and `GET api/2.0/files/rooms/news` for the rooms of the caller.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-as-read/">REST API Reference for MarkAsRead Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> MarkAsReadWithHttpInfo(BaseBatchRequestDto? baseBatchRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (baseBatchRequestDto != null) localVarRequestOptions.Data = baseBatchRequestDto;

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
            var localVarResponse = Client.Put<FileOperationArrayWrapper>("/api/2.0/files/fileops/markasread", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("MarkAsRead", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Mark files and folders as read
        /// </summary>
        /// <remarks>
        /// Queues a background job that clears the new-item badge from the requested files and folders for the calling  account, and answers with the caller's mark-as-read operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. Marking a folder clears the badges of  everything inside it as well. Items the caller cannot read are passed over in silence rather than refused, so  the call succeeds even when the whole selection is inaccessible, and an empty selection queues nothing and  answers with the operations that are already there. Repeating the call on items that are already read changes  nothing, and nothing is opened, moved or modified by it — only the caller's own badges are affected, while  other members keep theirs. To see what is currently marked as new use `GET api/2.0/files/{folderId}/news` for  one folder and `GET api/2.0/files/rooms/news` for the rooms of the caller.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-as-read/">REST API Reference for MarkAsRead Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async Task<FileOperationArrayWrapper> MarkAsReadAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await MarkAsReadWithHttpInfoAsync(baseBatchRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Mark files and folders as read
        /// </summary>
        /// <remarks>
        /// Queues a background job that clears the new-item badge from the requested files and folders for the calling  account, and answers with the caller's mark-as-read operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. Marking a folder clears the badges of  everything inside it as well. Items the caller cannot read are passed over in silence rather than refused, so  the call succeeds even when the whole selection is inaccessible, and an empty selection queues nothing and  answers with the operations that are already there. Repeating the call on items that are already read changes  nothing, and nothing is opened, moved or modified by it — only the caller's own badges are affected, while  other members keep theirs. To see what is currently marked as new use `GET api/2.0/files/{folderId}/news` for  one folder and `GET api/2.0/files/rooms/news` for the rooms of the caller.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The files and folders a background operation is applied to. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-as-read/">REST API Reference for MarkAsRead Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async Task<ApiResponse<FileOperationArrayWrapper>> MarkAsReadWithHttpInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (baseBatchRequestDto != null) localVarRequestOptions.Data = baseBatchRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<FileOperationArrayWrapper>("/api/2.0/files/fileops/markasread", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("MarkAsRead", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Move files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that moves the requested files and folders into `destFolderId`, removing them from  where they were, and answers with the caller's move and copy operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. Before starting,  `GET api/2.0/files/fileops/move` reports which items already have a same-named entry at the destination and  `conflictResolveType` decides what happens to them, while `GET api/2.0/files/fileops/checkdestfolder` reports  whether the destination accepts the files at all. The caller needs create access to the destination and the  right to take the items out of their source, which is why room members with editing or review rights are  refused with 403, and why content-creator rights inside a room allow copying an item out of it but not moving  it. A room cannot be moved this way — use `PUT api/2.0/files/rooms/{id}/archive` instead. To keep the  originals use `PUT api/2.0/files/fileops/copy`. An empty selection queues nothing.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-batch-items/">REST API Reference for MoveBatchItems Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper MoveBatchItems(BatchRequestDto? batchRequestDto = default)
        {
            var localVarResponse = MoveBatchItemsWithHttpInfo(batchRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Move files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that moves the requested files and folders into `destFolderId`, removing them from  where they were, and answers with the caller's move and copy operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. Before starting,  `GET api/2.0/files/fileops/move` reports which items already have a same-named entry at the destination and  `conflictResolveType` decides what happens to them, while `GET api/2.0/files/fileops/checkdestfolder` reports  whether the destination accepts the files at all. The caller needs create access to the destination and the  right to take the items out of their source, which is why room members with editing or review rights are  refused with 403, and why content-creator rights inside a room allow copying an item out of it but not moving  it. A room cannot be moved this way — use `PUT api/2.0/files/rooms/{id}/archive` instead. To keep the  originals use `PUT api/2.0/files/fileops/copy`. An empty selection queues nothing.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-batch-items/">REST API Reference for MoveBatchItems Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> MoveBatchItemsWithHttpInfo(BatchRequestDto? batchRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (batchRequestDto != null) localVarRequestOptions.Data = batchRequestDto;

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
            var localVarResponse = Client.Put<FileOperationArrayWrapper>("/api/2.0/files/fileops/move", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("MoveBatchItems", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Move files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that moves the requested files and folders into `destFolderId`, removing them from  where they were, and answers with the caller's move and copy operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. Before starting,  `GET api/2.0/files/fileops/move` reports which items already have a same-named entry at the destination and  `conflictResolveType` decides what happens to them, while `GET api/2.0/files/fileops/checkdestfolder` reports  whether the destination accepts the files at all. The caller needs create access to the destination and the  right to take the items out of their source, which is why room members with editing or review rights are  refused with 403, and why content-creator rights inside a room allow copying an item out of it but not moving  it. A room cannot be moved this way — use `PUT api/2.0/files/rooms/{id}/archive` instead. To keep the  originals use `PUT api/2.0/files/fileops/copy`. An empty selection queues nothing.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-batch-items/">REST API Reference for MoveBatchItems Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async Task<FileOperationArrayWrapper> MoveBatchItemsAsync(BatchRequestDto? batchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await MoveBatchItemsWithHttpInfoAsync(batchRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Move files and folders
        /// </summary>
        /// <remarks>
        /// Queues a background job that moves the requested files and folders into `destFolderId`, removing them from  where they were, and answers with the caller's move and copy operations, including the one just started. Poll  `GET api/2.0/files/fileops` until the operation reports `finished`. Before starting,  `GET api/2.0/files/fileops/move` reports which items already have a same-named entry at the destination and  `conflictResolveType` decides what happens to them, while `GET api/2.0/files/fileops/checkdestfolder` reports  whether the destination accepts the files at all. The caller needs create access to the destination and the  right to take the items out of their source, which is why room members with editing or review rights are  refused with 403, and why content-creator rights inside a room allow copying an item out of it but not moving  it. A room cannot be moved this way — use `PUT api/2.0/files/rooms/{id}/archive` instead. To keep the  originals use `PUT api/2.0/files/fileops/copy`. An empty selection queues nothing.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The files and folders to move or copy, the folder they go to, and the way name clashes are settled. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-batch-items/">REST API Reference for MoveBatchItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async Task<ApiResponse<FileOperationArrayWrapper>> MoveBatchItemsWithHttpInfoAsync(BatchRequestDto? batchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (batchRequestDto != null) localVarRequestOptions.Data = batchRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<FileOperationArrayWrapper>("/api/2.0/files/fileops/move", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("MoveBatchItems", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start file conversion
        /// </summary>
        /// <remarks>
        /// Queues the conversion of a file into the portal's own editable format and answers with the conversion entry  the caller is to poll. The whole body may be omitted, in which case the defaults apply. `outputType` names the  target format and, left empty, the portal's default for that kind of document is used; `password` unlocks a  protected source file; `version` converts an older version instead of the current one. `createNewIfExist`  decides where the result goes: with `true` a new file is created beside the source, while with `false`, the  default, the converted file that already exists is replaced. `sync=true` converts inside the request and  answers with the finished result instead of a queue entry, which is only sensible for small documents.  Otherwise poll `GET api/2.0/files/file/{fileId}/checkconversion` until `progress` reaches 100 and take the  converted file from `file`. Only formats the portal has to convert are accepted; anything already editable,  and anything it cannot convert, is answered without work being queued or rejected as an invalid request. The  caller needs read access to the file. The call is mutating and not idempotent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file to convert.</param>
        /// <param name="checkConversionRequestDtoInteger">The parameters of the conversion. The whole body may be omitted, in which case the defaults of the portal  apply. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-file-conversion/">REST API Reference for StartFileConversion Operation</seealso>
        /// <returns>ConversationResultArrayWrapper</returns>
        public ConversationResultArrayWrapper StartFileConversion(int fileId, CheckConversionRequestDtoInteger? checkConversionRequestDtoInteger = default)
        {
            var localVarResponse = StartFileConversionWithHttpInfo(fileId, checkConversionRequestDtoInteger);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start file conversion
        /// </summary>
        /// <remarks>
        /// Queues the conversion of a file into the portal's own editable format and answers with the conversion entry  the caller is to poll. The whole body may be omitted, in which case the defaults apply. `outputType` names the  target format and, left empty, the portal's default for that kind of document is used; `password` unlocks a  protected source file; `version` converts an older version instead of the current one. `createNewIfExist`  decides where the result goes: with `true` a new file is created beside the source, while with `false`, the  default, the converted file that already exists is replaced. `sync=true` converts inside the request and  answers with the finished result instead of a queue entry, which is only sensible for small documents.  Otherwise poll `GET api/2.0/files/file/{fileId}/checkconversion` until `progress` reaches 100 and take the  converted file from `file`. Only formats the portal has to convert are accepted; anything already editable,  and anything it cannot convert, is answered without work being queued or rejected as an invalid request. The  caller needs read access to the file. The call is mutating and not idempotent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file to convert.</param>
        /// <param name="checkConversionRequestDtoInteger">The parameters of the conversion. The whole body may be omitted, in which case the defaults of the portal  apply. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-file-conversion/">REST API Reference for StartFileConversion Operation</seealso>
        /// <returns>ApiResponse of ConversationResultArrayWrapper</returns>
        public ApiResponse<ConversationResultArrayWrapper> StartFileConversionWithHttpInfo(int fileId, CheckConversionRequestDtoInteger? checkConversionRequestDtoInteger = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (checkConversionRequestDtoInteger != null) localVarRequestOptions.Data = checkConversionRequestDtoInteger;

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
            var localVarResponse = Client.Put<ConversationResultArrayWrapper>("/api/2.0/files/file/{fileId}/checkconversion", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("StartFileConversion", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start file conversion
        /// </summary>
        /// <remarks>
        /// Queues the conversion of a file into the portal's own editable format and answers with the conversion entry  the caller is to poll. The whole body may be omitted, in which case the defaults apply. `outputType` names the  target format and, left empty, the portal's default for that kind of document is used; `password` unlocks a  protected source file; `version` converts an older version instead of the current one. `createNewIfExist`  decides where the result goes: with `true` a new file is created beside the source, while with `false`, the  default, the converted file that already exists is replaced. `sync=true` converts inside the request and  answers with the finished result instead of a queue entry, which is only sensible for small documents.  Otherwise poll `GET api/2.0/files/file/{fileId}/checkconversion` until `progress` reaches 100 and take the  converted file from `file`. Only formats the portal has to convert are accepted; anything already editable,  and anything it cannot convert, is answered without work being queued or rejected as an invalid request. The  caller needs read access to the file. The call is mutating and not idempotent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file to convert.</param>
        /// <param name="checkConversionRequestDtoInteger">The parameters of the conversion. The whole body may be omitted, in which case the defaults of the portal  apply. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-file-conversion/">REST API Reference for StartFileConversion Operation</seealso>
        /// <returns>Task of ConversationResultArrayWrapper</returns>
        public async Task<ConversationResultArrayWrapper> StartFileConversionAsync(int fileId, CheckConversionRequestDtoInteger? checkConversionRequestDtoInteger = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await StartFileConversionWithHttpInfoAsync(fileId, checkConversionRequestDtoInteger, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start file conversion
        /// </summary>
        /// <remarks>
        /// Queues the conversion of a file into the portal's own editable format and answers with the conversion entry  the caller is to poll. The whole body may be omitted, in which case the defaults apply. `outputType` names the  target format and, left empty, the portal's default for that kind of document is used; `password` unlocks a  protected source file; `version` converts an older version instead of the current one. `createNewIfExist`  decides where the result goes: with `true` a new file is created beside the source, while with `false`, the  default, the converted file that already exists is replaced. `sync=true` converts inside the request and  answers with the finished result instead of a queue entry, which is only sensible for small documents.  Otherwise poll `GET api/2.0/files/file/{fileId}/checkconversion` until `progress` reaches 100 and take the  converted file from `file`. Only formats the portal has to convert are accepted; anything already editable,  and anything it cannot convert, is answered without work being queued or rejected as an invalid request. The  caller needs read access to the file. The call is mutating and not idempotent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file to convert.</param>
        /// <param name="checkConversionRequestDtoInteger">The parameters of the conversion. The whole body may be omitted, in which case the defaults of the portal  apply. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-file-conversion/">REST API Reference for StartFileConversion Operation</seealso>
        /// <returns>Task of ApiResponse (ConversationResultArrayWrapper)</returns>
        public async Task<ApiResponse<ConversationResultArrayWrapper>> StartFileConversionWithHttpInfoAsync(int fileId, CheckConversionRequestDtoInteger? checkConversionRequestDtoInteger = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (checkConversionRequestDtoInteger != null) localVarRequestOptions.Data = checkConversionRequestDtoInteger;

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

            var localVarResponse = await AsynchronousClient.PutAsync<ConversationResultArrayWrapper>("/api/2.0/files/file/{fileId}/checkconversion", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("StartFileConversion", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Cancel file operations
        /// </summary>
        /// <remarks>
        /// Cancels a background file operation of the caller and answers with the operations that are left. Pass the `id`  that was reported when the operation started to stop that one; a call that leaves the trailing route segment  out stops every operation the caller has running, of every kind. Cancelling stops the job where it stands and  does not undo it: what has already been copied, moved or deleted stays that way, so a cancelled batch can  leave part of itself at the destination and part of it at the source, and the result has to be read back  rather than assumed. The cancelled record is dropped from `GET api/2.0/files/fileops` at once, which is why  the answer here is usually empty. An id that is not among the caller's operations cancels nothing and is not  an error. Operations are private to the account that started them, an anonymous caller being scoped to the  session of the external link, so the call can never reach an operation of anyone else.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The operation to cancel, as returned in `id` when it was started. A call that leaves the route segment out  cancels every operation of the caller, and an id that is not among their operations cancels nothing without  being an error.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-tasks/">REST API Reference for TerminateTasks Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper TerminateTasks(string id)
        {
            var localVarResponse = TerminateTasksWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Cancel file operations
        /// </summary>
        /// <remarks>
        /// Cancels a background file operation of the caller and answers with the operations that are left. Pass the `id`  that was reported when the operation started to stop that one; a call that leaves the trailing route segment  out stops every operation the caller has running, of every kind. Cancelling stops the job where it stands and  does not undo it: what has already been copied, moved or deleted stays that way, so a cancelled batch can  leave part of itself at the destination and part of it at the source, and the result has to be read back  rather than assumed. The cancelled record is dropped from `GET api/2.0/files/fileops` at once, which is why  the answer here is usually empty. An id that is not among the caller's operations cancels nothing and is not  an error. Operations are private to the account that started them, an anonymous caller being scoped to the  session of the external link, so the call can never reach an operation of anyone else.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The operation to cancel, as returned in `id` when it was started. A call that leaves the route segment out  cancels every operation of the caller, and an id that is not among their operations cancels nothing without  being an error.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-tasks/">REST API Reference for TerminateTasks Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> TerminateTasksWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OperationsApi->TerminateTasks");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request
            var localVarResponse = Client.Put<FileOperationArrayWrapper>("/api/2.0/files/fileops/terminate/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("TerminateTasks", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Cancel file operations
        /// </summary>
        /// <remarks>
        /// Cancels a background file operation of the caller and answers with the operations that are left. Pass the `id`  that was reported when the operation started to stop that one; a call that leaves the trailing route segment  out stops every operation the caller has running, of every kind. Cancelling stops the job where it stands and  does not undo it: what has already been copied, moved or deleted stays that way, so a cancelled batch can  leave part of itself at the destination and part of it at the source, and the result has to be read back  rather than assumed. The cancelled record is dropped from `GET api/2.0/files/fileops` at once, which is why  the answer here is usually empty. An id that is not among the caller's operations cancels nothing and is not  an error. Operations are private to the account that started them, an anonymous caller being scoped to the  session of the external link, so the call can never reach an operation of anyone else.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The operation to cancel, as returned in `id` when it was started. A call that leaves the route segment out  cancels every operation of the caller, and an id that is not among their operations cancels nothing without  being an error.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-tasks/">REST API Reference for TerminateTasks Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async Task<FileOperationArrayWrapper> TerminateTasksAsync(string id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await TerminateTasksWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Cancel file operations
        /// </summary>
        /// <remarks>
        /// Cancels a background file operation of the caller and answers with the operations that are left. Pass the `id`  that was reported when the operation started to stop that one; a call that leaves the trailing route segment  out stops every operation the caller has running, of every kind. Cancelling stops the job where it stands and  does not undo it: what has already been copied, moved or deleted stays that way, so a cancelled batch can  leave part of itself at the destination and part of it at the source, and the result has to be read back  rather than assumed. The cancelled record is dropped from `GET api/2.0/files/fileops` at once, which is why  the answer here is usually empty. An id that is not among the caller's operations cancels nothing and is not  an error. Operations are private to the account that started them, an anonymous caller being scoped to the  session of the external link, so the call can never reach an operation of anyone else.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The operation to cancel, as returned in `id` when it was started. A call that leaves the route segment out  cancels every operation of the caller, and an id that is not among their operations cancels nothing without  being an error.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-tasks/">REST API Reference for TerminateTasks Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async Task<ApiResponse<FileOperationArrayWrapper>> TerminateTasksWithHttpInfoAsync(string id, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OperationsApi->TerminateTasks");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileOperationArrayWrapper>("/api/2.0/files/fileops/terminate/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("TerminateTasks", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a comment
        /// </summary>
        /// <remarks>
        /// Replaces the comment stored on one version of a file - the note that explains what changed in it - and answers  with the comment as it was stored, which is the text cut to the length the portal keeps. `version` names the  version and has to be an existing one: a version that does not exist is rejected as an invalid request, while  a file that does not exist at all is answered as not found. Sending an empty comment clears the note. The  caller needs the right to edit the history of the file, which the room admin, a DocSpace admin acting as room  manager and a member with content-creator rights have; a member with editing access to somebody else's file,  read-only access, a guest and an anonymous caller are all refused. A file that is locked by somebody else or  lies in Trash is refused as well. The call is mutating and idempotent - repeating it with the same text leaves  the same comment. The comments of all versions come back with `GET api/2.0/files/file/{fileId}/edit/history`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file whose version comment is replaced.</param>
        /// <param name="updateComment">The version and the comment to store on it.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-comment/">REST API Reference for UpdateFileComment Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper UpdateFileComment(int fileId, UpdateComment updateComment)
        {
            var localVarResponse = UpdateFileCommentWithHttpInfo(fileId, updateComment);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a comment
        /// </summary>
        /// <remarks>
        /// Replaces the comment stored on one version of a file - the note that explains what changed in it - and answers  with the comment as it was stored, which is the text cut to the length the portal keeps. `version` names the  version and has to be an existing one: a version that does not exist is rejected as an invalid request, while  a file that does not exist at all is answered as not found. Sending an empty comment clears the note. The  caller needs the right to edit the history of the file, which the room admin, a DocSpace admin acting as room  manager and a member with content-creator rights have; a member with editing access to somebody else's file,  read-only access, a guest and an anonymous caller are all refused. A file that is locked by somebody else or  lies in Trash is refused as well. The call is mutating and idempotent - repeating it with the same text leaves  the same comment. The comments of all versions come back with `GET api/2.0/files/file/{fileId}/edit/history`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file whose version comment is replaced.</param>
        /// <param name="updateComment">The version and the comment to store on it.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-comment/">REST API Reference for UpdateFileComment Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> UpdateFileCommentWithHttpInfo(int fileId, UpdateComment updateComment)
        {
            // verify the required parameter 'updateComment' is set
            if (updateComment == null)
                throw new ApiException(400, "Missing required parameter 'updateComment' when calling OperationsApi->UpdateFileComment");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (updateComment != null) localVarRequestOptions.Data = updateComment;

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
            var localVarResponse = Client.Put<StringWrapper>("/api/2.0/files/file/{fileId}/comment", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateFileComment", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a comment
        /// </summary>
        /// <remarks>
        /// Replaces the comment stored on one version of a file - the note that explains what changed in it - and answers  with the comment as it was stored, which is the text cut to the length the portal keeps. `version` names the  version and has to be an existing one: a version that does not exist is rejected as an invalid request, while  a file that does not exist at all is answered as not found. Sending an empty comment clears the note. The  caller needs the right to edit the history of the file, which the room admin, a DocSpace admin acting as room  manager and a member with content-creator rights have; a member with editing access to somebody else's file,  read-only access, a guest and an anonymous caller are all refused. A file that is locked by somebody else or  lies in Trash is refused as well. The call is mutating and idempotent - repeating it with the same text leaves  the same comment. The comments of all versions come back with `GET api/2.0/files/file/{fileId}/edit/history`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file whose version comment is replaced.</param>
        /// <param name="updateComment">The version and the comment to store on it.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-comment/">REST API Reference for UpdateFileComment Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> UpdateFileCommentAsync(int fileId, UpdateComment updateComment, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateFileCommentWithHttpInfoAsync(fileId, updateComment, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a comment
        /// </summary>
        /// <remarks>
        /// Replaces the comment stored on one version of a file - the note that explains what changed in it - and answers  with the comment as it was stored, which is the text cut to the length the portal keeps. `version` names the  version and has to be an existing one: a version that does not exist is rejected as an invalid request, while  a file that does not exist at all is answered as not found. Sending an empty comment clears the note. The  caller needs the right to edit the history of the file, which the room admin, a DocSpace admin acting as room  manager and a member with content-creator rights have; a member with editing access to somebody else's file,  read-only access, a guest and an anonymous caller are all refused. A file that is locked by somebody else or  lies in Trash is refused as well. The call is mutating and idempotent - repeating it with the same text leaves  the same comment. The comments of all versions come back with `GET api/2.0/files/file/{fileId}/edit/history`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file whose version comment is replaced.</param>
        /// <param name="updateComment">The version and the comment to store on it.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-comment/">REST API Reference for UpdateFileComment Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async Task<ApiResponse<StringWrapper>> UpdateFileCommentWithHttpInfoAsync(int fileId, UpdateComment updateComment, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'updateComment' is set
            if (updateComment == null)
                throw new ApiException(400, "Missing required parameter 'updateComment' when calling OperationsApi->UpdateFileComment");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (updateComment != null) localVarRequestOptions.Data = updateComment;

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

            var localVarResponse = await AsynchronousClient.PutAsync<StringWrapper>("/api/2.0/files/file/{fileId}/comment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateFileComment", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Upload a numbered chunk
        /// </summary>
        /// <remarks>
        /// Stores one part of a file under the number given in `chunkNumber`, which is what the ordinary chunked flow  uses: parts are kept by their number rather than by arrival, so a part that failed can be resent under the  same number without restarting the session. Numbering starts at 1, and leaving the number out makes the server  count the parts itself. The answer is always the session, never the file, and this call never completes the  upload: the file appears only after `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. Use  `POST api/2.0/files/{folderId}/session/{sessionId}` instead when the parts go strictly in order and the upload  should complete by itself. A part bigger than `chunkUploadSize` from `GET api/2.0/files/settings` is refused,  so that value is also the size to split the payload by. The first part of a PDF is inspected, and a PDF that  is not a fillable form is refused when the session targets a form-filling room. The session is found by its id  alone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session this part belongs to, as returned in `id` when it was created; a 32-character hexadecimal string.</param>
        /// <param name="chunkNumber">The position of this part in the file, counted from 1. Sending the same number again replaces that part  instead of adding one, which is how a failed part is retried; leaving the number out makes the server count  the parts itself. (optional)</param>
        /// <param name="file">The part of the file to store, sent as the multipart field of the same name. It is kept under the number given  beside it, and a part larger than the portal chunk size is refused. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-async-session/">REST API Reference for UploadAsyncSession Operation</seealso>
        /// <returns>ChunkedUploadSessionResponseIntegerWrapper</returns>
        public ChunkedUploadSessionResponseIntegerWrapper UploadAsyncSession(int folderId, string sessionId, int? chunkNumber = default, FileParameter? file = default)
        {
            var localVarResponse = UploadAsyncSessionWithHttpInfo(folderId, sessionId, chunkNumber, file);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Upload a numbered chunk
        /// </summary>
        /// <remarks>
        /// Stores one part of a file under the number given in `chunkNumber`, which is what the ordinary chunked flow  uses: parts are kept by their number rather than by arrival, so a part that failed can be resent under the  same number without restarting the session. Numbering starts at 1, and leaving the number out makes the server  count the parts itself. The answer is always the session, never the file, and this call never completes the  upload: the file appears only after `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. Use  `POST api/2.0/files/{folderId}/session/{sessionId}` instead when the parts go strictly in order and the upload  should complete by itself. A part bigger than `chunkUploadSize` from `GET api/2.0/files/settings` is refused,  so that value is also the size to split the payload by. The first part of a PDF is inspected, and a PDF that  is not a fillable form is refused when the session targets a form-filling room. The session is found by its id  alone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session this part belongs to, as returned in `id` when it was created; a 32-character hexadecimal string.</param>
        /// <param name="chunkNumber">The position of this part in the file, counted from 1. Sending the same number again replaces that part  instead of adding one, which is how a failed part is retried; leaving the number out makes the server count  the parts itself. (optional)</param>
        /// <param name="file">The part of the file to store, sent as the multipart field of the same name. It is kept under the number given  beside it, and a part larger than the portal chunk size is refused. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-async-session/">REST API Reference for UploadAsyncSession Operation</seealso>
        /// <returns>ApiResponse of ChunkedUploadSessionResponseIntegerWrapper</returns>
        public ApiResponse<ChunkedUploadSessionResponseIntegerWrapper> UploadAsyncSessionWithHttpInfo(int folderId, string sessionId, int? chunkNumber = default, FileParameter? file = default)
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling OperationsApi->UploadAsyncSession");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            localVarRequestOptions.PathParameters.Add("sessionId", ClientUtils.ParameterToString(sessionId)); // path parameter
            if (chunkNumber != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "ChunkNumber", chunkNumber));
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
            var localVarResponse = Client.Post<ChunkedUploadSessionResponseIntegerWrapper>("/api/2.0/files/{folderId}/session/{sessionId}/upload", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UploadAsyncSession", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Upload a numbered chunk
        /// </summary>
        /// <remarks>
        /// Stores one part of a file under the number given in `chunkNumber`, which is what the ordinary chunked flow  uses: parts are kept by their number rather than by arrival, so a part that failed can be resent under the  same number without restarting the session. Numbering starts at 1, and leaving the number out makes the server  count the parts itself. The answer is always the session, never the file, and this call never completes the  upload: the file appears only after `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. Use  `POST api/2.0/files/{folderId}/session/{sessionId}` instead when the parts go strictly in order and the upload  should complete by itself. A part bigger than `chunkUploadSize` from `GET api/2.0/files/settings` is refused,  so that value is also the size to split the payload by. The first part of a PDF is inspected, and a PDF that  is not a fillable form is refused when the session targets a form-filling room. The session is found by its id  alone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session this part belongs to, as returned in `id` when it was created; a 32-character hexadecimal string.</param>
        /// <param name="chunkNumber">The position of this part in the file, counted from 1. Sending the same number again replaces that part  instead of adding one, which is how a failed part is retried; leaving the number out makes the server count  the parts itself. (optional)</param>
        /// <param name="file">The part of the file to store, sent as the multipart field of the same name. It is kept under the number given  beside it, and a part larger than the portal chunk size is refused. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-async-session/">REST API Reference for UploadAsyncSession Operation</seealso>
        /// <returns>Task of ChunkedUploadSessionResponseIntegerWrapper</returns>
        public async Task<ChunkedUploadSessionResponseIntegerWrapper> UploadAsyncSessionAsync(int folderId, string sessionId, int? chunkNumber = default, FileParameter? file = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UploadAsyncSessionWithHttpInfoAsync(folderId, sessionId, chunkNumber, file, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Upload a numbered chunk
        /// </summary>
        /// <remarks>
        /// Stores one part of a file under the number given in `chunkNumber`, which is what the ordinary chunked flow  uses: parts are kept by their number rather than by arrival, so a part that failed can be resent under the  same number without restarting the session. Numbering starts at 1, and leaving the number out makes the server  count the parts itself. The answer is always the session, never the file, and this call never completes the  upload: the file appears only after `PUT api/2.0/files/{folderId}/session/{sessionId}/finalize`. Use  `POST api/2.0/files/{folderId}/session/{sessionId}` instead when the parts go strictly in order and the upload  should complete by itself. A part bigger than `chunkUploadSize` from `GET api/2.0/files/settings` is refused,  so that value is also the size to split the payload by. The first part of a PDF is inspected, and a PDF that  is not a fillable form is refused when the session targets a form-filling room. The session is found by its id  alone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session this part belongs to, as returned in `id` when it was created; a 32-character hexadecimal string.</param>
        /// <param name="chunkNumber">The position of this part in the file, counted from 1. Sending the same number again replaces that part  instead of adding one, which is how a failed part is retried; leaving the number out makes the server count  the parts itself. (optional)</param>
        /// <param name="file">The part of the file to store, sent as the multipart field of the same name. It is kept under the number given  beside it, and a part larger than the portal chunk size is refused. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-async-session/">REST API Reference for UploadAsyncSession Operation</seealso>
        /// <returns>Task of ApiResponse (ChunkedUploadSessionResponseIntegerWrapper)</returns>
        public async Task<ApiResponse<ChunkedUploadSessionResponseIntegerWrapper>> UploadAsyncSessionWithHttpInfoAsync(int folderId, string sessionId, int? chunkNumber = default, FileParameter? file = default, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling OperationsApi->UploadAsyncSession");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            localVarRequestOptions.PathParameters.Add("sessionId", ClientUtils.ParameterToString(sessionId)); // path parameter
            if (chunkNumber != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "ChunkNumber", chunkNumber));
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

            var localVarResponse = await AsynchronousClient.PostAsync<ChunkedUploadSessionResponseIntegerWrapper>("/api/2.0/files/{folderId}/session/{sessionId}/upload", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UploadAsyncSession", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Upload the next chunk
        /// </summary>
        /// <remarks>
        /// Sends the next part of a file into the session opened for it, as the multipart `File` field, and lets the  server keep count: parts are appended in the order they arrive, so two of these calls must never run in  parallel on one session. While bytes are still missing the answer describes the session and `uploaded` is  false; when the last part completes the declared size the file is written, its upload links are cleared, it is  marked as new for the room, and the answer comes back with 201, `uploaded` true and the whole file in `file`.  A session created for a payload smaller than `chunkUploadSize` from `GET api/2.0/files/settings` finishes on  the first such call and needs no separate finalize step. A part larger than that limit is refused. The first  part of a PDF is inspected, and a PDF that is not a fillable form is refused when the session targets a  form-filling room. The session is addressed by its id, and the folder in the path is not matched against it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session this part belongs to, as returned in `id` when it was created; the parts of one session must be  sent one after another, not in parallel.</param>
        /// <param name="file">The next part of the file, sent as the multipart field of the same name. Parts are appended in the order they  arrive, and a part larger than the portal chunk size is refused. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-session/">REST API Reference for UploadSession Operation</seealso>
        /// <returns>UploadSessionResponseIntegerWrapper</returns>
        public UploadSessionResponseIntegerWrapper UploadSession(int folderId, string sessionId, FileParameter? file = default)
        {
            var localVarResponse = UploadSessionWithHttpInfo(folderId, sessionId, file);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Upload the next chunk
        /// </summary>
        /// <remarks>
        /// Sends the next part of a file into the session opened for it, as the multipart `File` field, and lets the  server keep count: parts are appended in the order they arrive, so two of these calls must never run in  parallel on one session. While bytes are still missing the answer describes the session and `uploaded` is  false; when the last part completes the declared size the file is written, its upload links are cleared, it is  marked as new for the room, and the answer comes back with 201, `uploaded` true and the whole file in `file`.  A session created for a payload smaller than `chunkUploadSize` from `GET api/2.0/files/settings` finishes on  the first such call and needs no separate finalize step. A part larger than that limit is refused. The first  part of a PDF is inspected, and a PDF that is not a fillable form is refused when the session targets a  form-filling room. The session is addressed by its id, and the folder in the path is not matched against it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session this part belongs to, as returned in `id` when it was created; the parts of one session must be  sent one after another, not in parallel.</param>
        /// <param name="file">The next part of the file, sent as the multipart field of the same name. Parts are appended in the order they  arrive, and a part larger than the portal chunk size is refused. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-session/">REST API Reference for UploadSession Operation</seealso>
        /// <returns>ApiResponse of UploadSessionResponseIntegerWrapper</returns>
        public ApiResponse<UploadSessionResponseIntegerWrapper> UploadSessionWithHttpInfo(int folderId, string sessionId, FileParameter? file = default)
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling OperationsApi->UploadSession");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            localVarRequestOptions.PathParameters.Add("sessionId", ClientUtils.ParameterToString(sessionId)); // path parameter
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
            var localVarResponse = Client.Post<UploadSessionResponseIntegerWrapper>("/api/2.0/files/{folderId}/session/{sessionId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UploadSession", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Upload the next chunk
        /// </summary>
        /// <remarks>
        /// Sends the next part of a file into the session opened for it, as the multipart `File` field, and lets the  server keep count: parts are appended in the order they arrive, so two of these calls must never run in  parallel on one session. While bytes are still missing the answer describes the session and `uploaded` is  false; when the last part completes the declared size the file is written, its upload links are cleared, it is  marked as new for the room, and the answer comes back with 201, `uploaded` true and the whole file in `file`.  A session created for a payload smaller than `chunkUploadSize` from `GET api/2.0/files/settings` finishes on  the first such call and needs no separate finalize step. A part larger than that limit is refused. The first  part of a PDF is inspected, and a PDF that is not a fillable form is refused when the session targets a  form-filling room. The session is addressed by its id, and the folder in the path is not matched against it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session this part belongs to, as returned in `id` when it was created; the parts of one session must be  sent one after another, not in parallel.</param>
        /// <param name="file">The next part of the file, sent as the multipart field of the same name. Parts are appended in the order they  arrive, and a part larger than the portal chunk size is refused. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-session/">REST API Reference for UploadSession Operation</seealso>
        /// <returns>Task of UploadSessionResponseIntegerWrapper</returns>
        public async Task<UploadSessionResponseIntegerWrapper> UploadSessionAsync(int folderId, string sessionId, FileParameter? file = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UploadSessionWithHttpInfoAsync(folderId, sessionId, file, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Upload the next chunk
        /// </summary>
        /// <remarks>
        /// Sends the next part of a file into the session opened for it, as the multipart `File` field, and lets the  server keep count: parts are appended in the order they arrive, so two of these calls must never run in  parallel on one session. While bytes are still missing the answer describes the session and `uploaded` is  false; when the last part completes the declared size the file is written, its upload links are cleared, it is  marked as new for the room, and the answer comes back with 201, `uploaded` true and the whole file in `file`.  A session created for a payload smaller than `chunkUploadSize` from `GET api/2.0/files/settings` finishes on  the first such call and needs no separate finalize step. A part larger than that limit is refused. The first  part of a PDF is inspected, and a PDF that is not a fillable form is refused when the session targets a  form-filling room. The session is addressed by its id, and the folder in the path is not matched against it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder the session was opened against. It is part of the route only and is not matched against the  session, which is found by its own id.</param>
        /// <param name="sessionId">The session this part belongs to, as returned in `id` when it was created; the parts of one session must be  sent one after another, not in parallel.</param>
        /// <param name="file">The next part of the file, sent as the multipart field of the same name. Parts are appended in the order they  arrive, and a part larger than the portal chunk size is refused. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-session/">REST API Reference for UploadSession Operation</seealso>
        /// <returns>Task of ApiResponse (UploadSessionResponseIntegerWrapper)</returns>
        public async Task<ApiResponse<UploadSessionResponseIntegerWrapper>> UploadSessionWithHttpInfoAsync(int folderId, string sessionId, FileParameter? file = default, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling OperationsApi->UploadSession");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            localVarRequestOptions.PathParameters.Add("sessionId", ClientUtils.ParameterToString(sessionId)); // path parameter
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

            var localVarResponse = await AsynchronousClient.PostAsync<UploadSessionResponseIntegerWrapper>("/api/2.0/files/{folderId}/session/{sessionId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UploadSession", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
