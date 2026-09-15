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
namespace DocSpace.API.SDK.Api.Migration
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMigrationApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Cancel migration
        /// </summary>
        /// <remarks>
        /// Stops the parse pass queued for this portal and deletes the backup uploaded for it - the way back from a wrong  archive or a wrong migrator name. Nothing has to be called first and a DocSpace administrator is required; the  request is only queued, so the parse ends shortly after the call returns and  `GET api/2.0/migration/status` stops reporting it. The call is destructive for the uploaded data: the whole  upload folder is removed and the backup has to be sent to `migrationFileUpload.ashx` again before a new parse.  It is idempotent - cancelling when nothing is running still answers 200 - and it undoes nothing that was  already written to the portal. Only the parse stage is stopped, the job whose `parseResult.operation` is  `parse`: an import started by `POST api/2.0/migration/migrate` keeps running, and a finished import is  discarded with `POST api/2.0/migration/clear` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/cancel-migration/">REST API Reference for CancelMigration Operation</seealso>
        /// <returns></returns>
        void CancelMigration();

        /// <summary>
        /// Cancel migration
        /// </summary>
        /// <remarks>
        /// Stops the parse pass queued for this portal and deletes the backup uploaded for it - the way back from a wrong  archive or a wrong migrator name. Nothing has to be called first and a DocSpace administrator is required; the  request is only queued, so the parse ends shortly after the call returns and  `GET api/2.0/migration/status` stops reporting it. The call is destructive for the uploaded data: the whole  upload folder is removed and the backup has to be sent to `migrationFileUpload.ashx` again before a new parse.  It is idempotent - cancelling when nothing is running still answers 200 - and it undoes nothing that was  already written to the portal. Only the parse stage is stopped, the job whose `parseResult.operation` is  `parse`: an import started by `POST api/2.0/migration/migrate` keeps running, and a finished import is  discarded with `POST api/2.0/migration/clear` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/cancel-migration/">REST API Reference for CancelMigration Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CancelMigrationWithHttpInfo();
        /// <summary>
        /// Clear migration
        /// </summary>
        /// <remarks>
        /// Discards a finished import and deletes the data uploaded for it, freeing the portal for the next one. Call it  once `GET api/2.0/migration/status` reports `isCompleted` for a job whose `parseResult.operation` is  `migration`; a DocSpace administrator is required. Only the queued job and the temporary upload folder go -  the users, groups and files already imported stay in the portal - so the call destroys migration data alone,  and it is idempotent: clearing twice, or with nothing to clear, still answers 200. Like the other write  operations here it is only queued, and once it has run `GET api/2.0/migration/status` returns an empty result  and `GET api/2.0/migration/logs` answers 404, so download the log before calling it. A parse that is still  running is not affected - stop that with `POST api/2.0/migration/cancel` - and  `POST api/2.0/migration/finish` performs the same clean-up itself, which makes this call unnecessary after it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/clear-migration/">REST API Reference for ClearMigration Operation</seealso>
        /// <returns></returns>
        void ClearMigration();

        /// <summary>
        /// Clear migration
        /// </summary>
        /// <remarks>
        /// Discards a finished import and deletes the data uploaded for it, freeing the portal for the next one. Call it  once `GET api/2.0/migration/status` reports `isCompleted` for a job whose `parseResult.operation` is  `migration`; a DocSpace administrator is required. Only the queued job and the temporary upload folder go -  the users, groups and files already imported stay in the portal - so the call destroys migration data alone,  and it is idempotent: clearing twice, or with nothing to clear, still answers 200. Like the other write  operations here it is only queued, and once it has run `GET api/2.0/migration/status` returns an empty result  and `GET api/2.0/migration/logs` answers 404, so download the log before calling it. A parse that is still  running is not affected - stop that with `POST api/2.0/migration/cancel` - and  `POST api/2.0/migration/finish` performs the same clean-up itself, which makes this call unnecessary after it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/clear-migration/">REST API Reference for ClearMigration Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ClearMigrationWithHttpInfo();
        /// <summary>
        /// Finish migration
        /// </summary>
        /// <remarks>
        /// Closes a completed import: it can send every user the import created the activation email they need before  they can sign in, and it then discards the job and the data uploaded for it. Call it once  `GET api/2.0/migration/status` reports `isCompleted` for the import; a DocSpace administrator is required, and  with `isSendWelcomeEmail` set to true the job must still be in the queue, so do not clear it first. That flag  decides what happens to the imported people: true mails the activation link to each of them who has not  activated their account yet and skips the ones that are already active, false ends the import quietly and  leaves inviting them for later. The call writes to the portal and is not idempotent - the emails go out again  on every call - while its second half repeats what `POST api/2.0/migration/clear` does, removing the finished  job and the uploaded backup and leaving everything already imported in place. It answers with an empty body,  after which `GET api/2.0/migration/status` returns an empty result and `GET api/2.0/migration/logs` answers  404, so download the log first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="finishDto">Whether the finished import mails the imported people their activation links before it is cleared away. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/finish-migration/">REST API Reference for FinishMigration Operation</seealso>
        /// <returns></returns>
        void FinishMigration(FinishDto? finishDto = default);

        /// <summary>
        /// Finish migration
        /// </summary>
        /// <remarks>
        /// Closes a completed import: it can send every user the import created the activation email they need before  they can sign in, and it then discards the job and the data uploaded for it. Call it once  `GET api/2.0/migration/status` reports `isCompleted` for the import; a DocSpace administrator is required, and  with `isSendWelcomeEmail` set to true the job must still be in the queue, so do not clear it first. That flag  decides what happens to the imported people: true mails the activation link to each of them who has not  activated their account yet and skips the ones that are already active, false ends the import quietly and  leaves inviting them for later. The call writes to the portal and is not idempotent - the emails go out again  on every call - while its second half repeats what `POST api/2.0/migration/clear` does, removing the finished  job and the uploaded backup and leaving everything already imported in place. It answers with an empty body,  after which `GET api/2.0/migration/status` returns an empty result and `GET api/2.0/migration/logs` answers  404, so download the log first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="finishDto">Whether the finished import mails the imported people their activation links before it is cleared away. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/finish-migration/">REST API Reference for FinishMigration Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> FinishMigrationWithHttpInfo(FinishDto? finishDto = default);
        /// <summary>
        /// Get migration logs
        /// </summary>
        /// <remarks>
        /// Downloads the log of the parse or import the portal currently holds - the step-by-step record behind the  numbers and the single error message of `GET api/2.0/migration/status`, and the place where the reason for a  skipped user or file is written. The portal has to hold such a job, started by  `POST api/2.0/migration/init/{migratorName}` or `POST api/2.0/migration/migrate` and not yet removed by  `POST api/2.0/migration/clear` or `POST api/2.0/migration/finish`, otherwise the call answers 404; a DocSpace  administrator is required and the call is read-only and idempotent. The body is not JSON: it is  `text/plain; charset=UTF-8` sent as an attachment named `migration.log`, one line per step with the progress  it reported. Each job writes its own log, so this always returns the log of the job that  `GET api/2.0/migration/status` describes, and while that job runs the file keeps growing - a call made early  returns only the part written so far and may be repeated later for the rest.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-migration-logs/">REST API Reference for GetMigrationLogs Operation</seealso>
        /// <returns></returns>
        void GetMigrationLogs();

        /// <summary>
        /// Get migration logs
        /// </summary>
        /// <remarks>
        /// Downloads the log of the parse or import the portal currently holds - the step-by-step record behind the  numbers and the single error message of `GET api/2.0/migration/status`, and the place where the reason for a  skipped user or file is written. The portal has to hold such a job, started by  `POST api/2.0/migration/init/{migratorName}` or `POST api/2.0/migration/migrate` and not yet removed by  `POST api/2.0/migration/clear` or `POST api/2.0/migration/finish`, otherwise the call answers 404; a DocSpace  administrator is required and the call is read-only and idempotent. The body is not JSON: it is  `text/plain; charset=UTF-8` sent as an attachment named `migration.log`, one line per step with the progress  it reported. Each job writes its own log, so this always returns the log of the job that  `GET api/2.0/migration/status` describes, and while that job runs the file keeps growing - a call made early  returns only the part written so far and may be repeated later for the rest.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-migration-logs/">REST API Reference for GetMigrationLogs Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetMigrationLogsWithHttpInfo();
        /// <summary>
        /// Get migration status
        /// </summary>
        /// <remarks>
        /// Returns how far the parse or the import queued for this portal has got and, once it stopped, what it produced  - the one place where every other operation in this group reports what it did. Any of them may be polled from  here as soon as it returns; a DocSpace administrator is required and the call is read-only and idempotent.  `progress` is the share of the job that is done, from 0 to 100, and `isCompleted` turns true when the job  stopped whether it succeeded or not, so read `error` as well: it stays empty while nothing went wrong and  otherwise holds the message that ended the job. `parseResult` carries what the migrator has read so far -  after a parse pass the users, groups and unreadable archives to edit and post to  `POST api/2.0/migration/migrate`, and during an import also `successedUsers` and `failedUsers` - and its  `operation` field, `parse` or `migration`, tells the two stages apart. The result is empty with status 200  when the portal has no job at all, because none was ever started or because  `POST api/2.0/migration/clear` or `POST api/2.0/migration/finish` has removed the last one; an empty answer is  therefore not an error. Line-by-line detail behind the numbers is in `GET api/2.0/migration/logs`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-migration-status/">REST API Reference for GetMigrationStatus Operation</seealso>
        /// <returns>MigrationStatusWrapper</returns>
        MigrationStatusWrapper GetMigrationStatus();

        /// <summary>
        /// Get migration status
        /// </summary>
        /// <remarks>
        /// Returns how far the parse or the import queued for this portal has got and, once it stopped, what it produced  - the one place where every other operation in this group reports what it did. Any of them may be polled from  here as soon as it returns; a DocSpace administrator is required and the call is read-only and idempotent.  `progress` is the share of the job that is done, from 0 to 100, and `isCompleted` turns true when the job  stopped whether it succeeded or not, so read `error` as well: it stays empty while nothing went wrong and  otherwise holds the message that ended the job. `parseResult` carries what the migrator has read so far -  after a parse pass the users, groups and unreadable archives to edit and post to  `POST api/2.0/migration/migrate`, and during an import also `successedUsers` and `failedUsers` - and its  `operation` field, `parse` or `migration`, tells the two stages apart. The result is empty with status 200  when the portal has no job at all, because none was ever started or because  `POST api/2.0/migration/clear` or `POST api/2.0/migration/finish` has removed the last one; an empty answer is  therefore not an error. Line-by-line detail behind the numbers is in `GET api/2.0/migration/logs`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-migration-status/">REST API Reference for GetMigrationStatus Operation</seealso>
        /// <returns>ApiResponse of MigrationStatusWrapper</returns>
        ApiResponse<MigrationStatusWrapper> GetMigrationStatusWithHttpInfo();
        /// <summary>
        /// Get available migrators
        /// </summary>
        /// <remarks>
        /// Lists the source products this installation can import a portal from, as the migrator names every other  operation in this group expects. Nothing has to be called first, a DocSpace administrator is required as  everywhere here, and the call is read-only and idempotent. The answer is a plain list of names such as  `GoogleWorkspace`, `Nextcloud` or `Workspace`, never localized and ordered as the migrators are registered;  pass one of them as `migratorName` to `POST api/2.0/migration/init/{migratorName}`, where the match ignores  case. The list depends on the installation rather than on the portal, so it does not change while the portal  runs, and a name that is not in it is not rejected by the operation that takes it - the queued job ends with  the failure reported in `error` of `GET api/2.0/migration/status`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/list-migrations/">REST API Reference for ListMigrations Operation</seealso>
        /// <returns>STRINGArrayWrapper</returns>
        STRINGArrayWrapper ListMigrations();

        /// <summary>
        /// Get available migrators
        /// </summary>
        /// <remarks>
        /// Lists the source products this installation can import a portal from, as the migrator names every other  operation in this group expects. Nothing has to be called first, a DocSpace administrator is required as  everywhere here, and the call is read-only and idempotent. The answer is a plain list of names such as  `GoogleWorkspace`, `Nextcloud` or `Workspace`, never localized and ordered as the migrators are registered;  pass one of them as `migratorName` to `POST api/2.0/migration/init/{migratorName}`, where the match ignores  case. The list depends on the installation rather than on the portal, so it does not change while the portal  runs, and a name that is not in it is not rejected by the operation that takes it - the queued job ends with  the failure reported in `error` of `GET api/2.0/migration/status`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/list-migrations/">REST API Reference for ListMigrations Operation</seealso>
        /// <returns>ApiResponse of STRINGArrayWrapper</returns>
        ApiResponse<STRINGArrayWrapper> ListMigrationsWithHttpInfo();
        /// <summary>
        /// Start migration
        /// </summary>
        /// <remarks>
        /// Starts the import itself: the users, the groups and the files selected in the request body are created on this  portal from the backup that the parse pass has read. Run `POST api/2.0/migration/init/{migratorName}` first  and wait for `isCompleted` in `GET api/2.0/migration/status`, then send `parseResult` from that answer back  here with `shouldImport` set on the users and groups to take and the `import...Files` flags set for the  content to copy. A DocSpace administrator is required, and importing a user as `DocSpaceAdmin` additionally  requires the caller to be the portal owner unless a user with that email is an administrator of this portal  already, otherwise the whole call is rejected with 403 before anything is imported. The job is queued and the  call answers with an empty body at once: watch `progress`, `successedUsers`, `failedUsers` and `error` in  `GET api/2.0/migration/status` and read what each step did from `GET api/2.0/migration/logs`. The import  writes to the portal and cannot be undone, and a repeat is no help: a call made while the job runs is ignored,  and once the job has ended the uploaded backup is deleted, so a new call has nothing to read until the archive  is uploaded and parsed again. When the import is done, close it with `POST api/2.0/migration/finish`, which can  also mail the imported users their activation link.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="migrationApiInfo">The migration API information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-migration/">REST API Reference for StartMigration Operation</seealso>
        /// <returns></returns>
        void StartMigration(MigrationApiInfo? migrationApiInfo = default);

        /// <summary>
        /// Start migration
        /// </summary>
        /// <remarks>
        /// Starts the import itself: the users, the groups and the files selected in the request body are created on this  portal from the backup that the parse pass has read. Run `POST api/2.0/migration/init/{migratorName}` first  and wait for `isCompleted` in `GET api/2.0/migration/status`, then send `parseResult` from that answer back  here with `shouldImport` set on the users and groups to take and the `import...Files` flags set for the  content to copy. A DocSpace administrator is required, and importing a user as `DocSpaceAdmin` additionally  requires the caller to be the portal owner unless a user with that email is an administrator of this portal  already, otherwise the whole call is rejected with 403 before anything is imported. The job is queued and the  call answers with an empty body at once: watch `progress`, `successedUsers`, `failedUsers` and `error` in  `GET api/2.0/migration/status` and read what each step did from `GET api/2.0/migration/logs`. The import  writes to the portal and cannot be undone, and a repeat is no help: a call made while the job runs is ignored,  and once the job has ended the uploaded backup is deleted, so a new call has nothing to read until the archive  is uploaded and parsed again. When the import is done, close it with `POST api/2.0/migration/finish`, which can  also mail the imported users their activation link.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="migrationApiInfo">The migration API information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-migration/">REST API Reference for StartMigration Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> StartMigrationWithHttpInfo(MigrationApiInfo? migrationApiInfo = default);
        /// <summary>
        /// Parse migration archive
        /// </summary>
        /// <remarks>
        /// Queues a pass that reads the backup already uploaded for this portal with the migrator named in the path and  reports what it holds - the users, the users that carry no email address, the users that exist on this portal  already, the groups and the archives it could not open - so that the caller can choose what to import. Upload  the backup first: `migrationFileUpload.ashx?Init=true` opens a new upload folder and drops the previous one,  then every part of the archive is posted to the same handler with `Name` set to its file name; take  `migratorName` from `GET api/2.0/migration/list`. A DocSpace administrator is required. The call only queues  the job and answers at once with an empty body: poll `GET api/2.0/migration/status` until `isCompleted` is  true, then read what was found from `parseResult` and any failure from `error`. Nothing is imported here and  the portal is not changed - the parse result is the body to edit and send to  `POST api/2.0/migration/migrate`. A portal runs one job at a time, so a call made while another parse or  import is still running is ignored instead of reported, and a backup bigger than the portal's total storage  quota ends the job with an error rather than failing this call.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="migratorName">The migrator that knows the format of the uploaded backup. It has to be one of the names  `GET api/2.0/migration/list` reports for this installation, spelled exactly as listed.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-and-initialize-migration/">REST API Reference for UploadAndInitializeMigration Operation</seealso>
        /// <returns></returns>
        void UploadAndInitializeMigration(string migratorName);

        /// <summary>
        /// Parse migration archive
        /// </summary>
        /// <remarks>
        /// Queues a pass that reads the backup already uploaded for this portal with the migrator named in the path and  reports what it holds - the users, the users that carry no email address, the users that exist on this portal  already, the groups and the archives it could not open - so that the caller can choose what to import. Upload  the backup first: `migrationFileUpload.ashx?Init=true` opens a new upload folder and drops the previous one,  then every part of the archive is posted to the same handler with `Name` set to its file name; take  `migratorName` from `GET api/2.0/migration/list`. A DocSpace administrator is required. The call only queues  the job and answers at once with an empty body: poll `GET api/2.0/migration/status` until `isCompleted` is  true, then read what was found from `parseResult` and any failure from `error`. Nothing is imported here and  the portal is not changed - the parse result is the body to edit and send to  `POST api/2.0/migration/migrate`. A portal runs one job at a time, so a call made while another parse or  import is still running is ignored instead of reported, and a backup bigger than the portal's total storage  quota ends the job with an error rather than failing this call.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="migratorName">The migrator that knows the format of the uploaded backup. It has to be one of the names  `GET api/2.0/migration/list` reports for this installation, spelled exactly as listed.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-and-initialize-migration/">REST API Reference for UploadAndInitializeMigration Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UploadAndInitializeMigrationWithHttpInfo(string migratorName);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMigrationApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Cancel migration
        /// </summary>
        /// <remarks>
        /// Stops the parse pass queued for this portal and deletes the backup uploaded for it - the way back from a wrong  archive or a wrong migrator name. Nothing has to be called first and a DocSpace administrator is required; the  request is only queued, so the parse ends shortly after the call returns and  `GET api/2.0/migration/status` stops reporting it. The call is destructive for the uploaded data: the whole  upload folder is removed and the backup has to be sent to `migrationFileUpload.ashx` again before a new parse.  It is idempotent - cancelling when nothing is running still answers 200 - and it undoes nothing that was  already written to the portal. Only the parse stage is stopped, the job whose `parseResult.operation` is  `parse`: an import started by `POST api/2.0/migration/migrate` keeps running, and a finished import is  discarded with `POST api/2.0/migration/clear` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/cancel-migration/">REST API Reference for CancelMigration Operation</seealso>
        /// <returns>Task of void</returns>
        Task CancelMigrationAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Cancel migration
        /// </summary>
        /// <remarks>
        /// Stops the parse pass queued for this portal and deletes the backup uploaded for it - the way back from a wrong  archive or a wrong migrator name. Nothing has to be called first and a DocSpace administrator is required; the  request is only queued, so the parse ends shortly after the call returns and  `GET api/2.0/migration/status` stops reporting it. The call is destructive for the uploaded data: the whole  upload folder is removed and the backup has to be sent to `migrationFileUpload.ashx` again before a new parse.  It is idempotent - cancelling when nothing is running still answers 200 - and it undoes nothing that was  already written to the portal. Only the parse stage is stopped, the job whose `parseResult.operation` is  `parse`: an import started by `POST api/2.0/migration/migrate` keeps running, and a finished import is  discarded with `POST api/2.0/migration/clear` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/cancel-migration/">REST API Reference for CancelMigration Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> CancelMigrationWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Clear migration
        /// </summary>
        /// <remarks>
        /// Discards a finished import and deletes the data uploaded for it, freeing the portal for the next one. Call it  once `GET api/2.0/migration/status` reports `isCompleted` for a job whose `parseResult.operation` is  `migration`; a DocSpace administrator is required. Only the queued job and the temporary upload folder go -  the users, groups and files already imported stay in the portal - so the call destroys migration data alone,  and it is idempotent: clearing twice, or with nothing to clear, still answers 200. Like the other write  operations here it is only queued, and once it has run `GET api/2.0/migration/status` returns an empty result  and `GET api/2.0/migration/logs` answers 404, so download the log before calling it. A parse that is still  running is not affected - stop that with `POST api/2.0/migration/cancel` - and  `POST api/2.0/migration/finish` performs the same clean-up itself, which makes this call unnecessary after it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/clear-migration/">REST API Reference for ClearMigration Operation</seealso>
        /// <returns>Task of void</returns>
        Task ClearMigrationAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Clear migration
        /// </summary>
        /// <remarks>
        /// Discards a finished import and deletes the data uploaded for it, freeing the portal for the next one. Call it  once `GET api/2.0/migration/status` reports `isCompleted` for a job whose `parseResult.operation` is  `migration`; a DocSpace administrator is required. Only the queued job and the temporary upload folder go -  the users, groups and files already imported stay in the portal - so the call destroys migration data alone,  and it is idempotent: clearing twice, or with nothing to clear, still answers 200. Like the other write  operations here it is only queued, and once it has run `GET api/2.0/migration/status` returns an empty result  and `GET api/2.0/migration/logs` answers 404, so download the log before calling it. A parse that is still  running is not affected - stop that with `POST api/2.0/migration/cancel` - and  `POST api/2.0/migration/finish` performs the same clean-up itself, which makes this call unnecessary after it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/clear-migration/">REST API Reference for ClearMigration Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> ClearMigrationWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Finish migration
        /// </summary>
        /// <remarks>
        /// Closes a completed import: it can send every user the import created the activation email they need before  they can sign in, and it then discards the job and the data uploaded for it. Call it once  `GET api/2.0/migration/status` reports `isCompleted` for the import; a DocSpace administrator is required, and  with `isSendWelcomeEmail` set to true the job must still be in the queue, so do not clear it first. That flag  decides what happens to the imported people: true mails the activation link to each of them who has not  activated their account yet and skips the ones that are already active, false ends the import quietly and  leaves inviting them for later. The call writes to the portal and is not idempotent - the emails go out again  on every call - while its second half repeats what `POST api/2.0/migration/clear` does, removing the finished  job and the uploaded backup and leaving everything already imported in place. It answers with an empty body,  after which `GET api/2.0/migration/status` returns an empty result and `GET api/2.0/migration/logs` answers  404, so download the log first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="finishDto">Whether the finished import mails the imported people their activation links before it is cleared away. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/finish-migration/">REST API Reference for FinishMigration Operation</seealso>
        /// <returns>Task of void</returns>
        Task FinishMigrationAsync(FinishDto? finishDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Finish migration
        /// </summary>
        /// <remarks>
        /// Closes a completed import: it can send every user the import created the activation email they need before  they can sign in, and it then discards the job and the data uploaded for it. Call it once  `GET api/2.0/migration/status` reports `isCompleted` for the import; a DocSpace administrator is required, and  with `isSendWelcomeEmail` set to true the job must still be in the queue, so do not clear it first. That flag  decides what happens to the imported people: true mails the activation link to each of them who has not  activated their account yet and skips the ones that are already active, false ends the import quietly and  leaves inviting them for later. The call writes to the portal and is not idempotent - the emails go out again  on every call - while its second half repeats what `POST api/2.0/migration/clear` does, removing the finished  job and the uploaded backup and leaving everything already imported in place. It answers with an empty body,  after which `GET api/2.0/migration/status` returns an empty result and `GET api/2.0/migration/logs` answers  404, so download the log first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="finishDto">Whether the finished import mails the imported people their activation links before it is cleared away. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/finish-migration/">REST API Reference for FinishMigration Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> FinishMigrationWithHttpInfoAsync(FinishDto? finishDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get migration logs
        /// </summary>
        /// <remarks>
        /// Downloads the log of the parse or import the portal currently holds - the step-by-step record behind the  numbers and the single error message of `GET api/2.0/migration/status`, and the place where the reason for a  skipped user or file is written. The portal has to hold such a job, started by  `POST api/2.0/migration/init/{migratorName}` or `POST api/2.0/migration/migrate` and not yet removed by  `POST api/2.0/migration/clear` or `POST api/2.0/migration/finish`, otherwise the call answers 404; a DocSpace  administrator is required and the call is read-only and idempotent. The body is not JSON: it is  `text/plain; charset=UTF-8` sent as an attachment named `migration.log`, one line per step with the progress  it reported. Each job writes its own log, so this always returns the log of the job that  `GET api/2.0/migration/status` describes, and while that job runs the file keeps growing - a call made early  returns only the part written so far and may be repeated later for the rest.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-migration-logs/">REST API Reference for GetMigrationLogs Operation</seealso>
        /// <returns>Task of void</returns>
        Task GetMigrationLogsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get migration logs
        /// </summary>
        /// <remarks>
        /// Downloads the log of the parse or import the portal currently holds - the step-by-step record behind the  numbers and the single error message of `GET api/2.0/migration/status`, and the place where the reason for a  skipped user or file is written. The portal has to hold such a job, started by  `POST api/2.0/migration/init/{migratorName}` or `POST api/2.0/migration/migrate` and not yet removed by  `POST api/2.0/migration/clear` or `POST api/2.0/migration/finish`, otherwise the call answers 404; a DocSpace  administrator is required and the call is read-only and idempotent. The body is not JSON: it is  `text/plain; charset=UTF-8` sent as an attachment named `migration.log`, one line per step with the progress  it reported. Each job writes its own log, so this always returns the log of the job that  `GET api/2.0/migration/status` describes, and while that job runs the file keeps growing - a call made early  returns only the part written so far and may be repeated later for the rest.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-migration-logs/">REST API Reference for GetMigrationLogs Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> GetMigrationLogsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get migration status
        /// </summary>
        /// <remarks>
        /// Returns how far the parse or the import queued for this portal has got and, once it stopped, what it produced  - the one place where every other operation in this group reports what it did. Any of them may be polled from  here as soon as it returns; a DocSpace administrator is required and the call is read-only and idempotent.  `progress` is the share of the job that is done, from 0 to 100, and `isCompleted` turns true when the job  stopped whether it succeeded or not, so read `error` as well: it stays empty while nothing went wrong and  otherwise holds the message that ended the job. `parseResult` carries what the migrator has read so far -  after a parse pass the users, groups and unreadable archives to edit and post to  `POST api/2.0/migration/migrate`, and during an import also `successedUsers` and `failedUsers` - and its  `operation` field, `parse` or `migration`, tells the two stages apart. The result is empty with status 200  when the portal has no job at all, because none was ever started or because  `POST api/2.0/migration/clear` or `POST api/2.0/migration/finish` has removed the last one; an empty answer is  therefore not an error. Line-by-line detail behind the numbers is in `GET api/2.0/migration/logs`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-migration-status/">REST API Reference for GetMigrationStatus Operation</seealso>
        /// <returns>Task of MigrationStatusWrapper</returns>
        Task<MigrationStatusWrapper> GetMigrationStatusAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get migration status
        /// </summary>
        /// <remarks>
        /// Returns how far the parse or the import queued for this portal has got and, once it stopped, what it produced  - the one place where every other operation in this group reports what it did. Any of them may be polled from  here as soon as it returns; a DocSpace administrator is required and the call is read-only and idempotent.  `progress` is the share of the job that is done, from 0 to 100, and `isCompleted` turns true when the job  stopped whether it succeeded or not, so read `error` as well: it stays empty while nothing went wrong and  otherwise holds the message that ended the job. `parseResult` carries what the migrator has read so far -  after a parse pass the users, groups and unreadable archives to edit and post to  `POST api/2.0/migration/migrate`, and during an import also `successedUsers` and `failedUsers` - and its  `operation` field, `parse` or `migration`, tells the two stages apart. The result is empty with status 200  when the portal has no job at all, because none was ever started or because  `POST api/2.0/migration/clear` or `POST api/2.0/migration/finish` has removed the last one; an empty answer is  therefore not an error. Line-by-line detail behind the numbers is in `GET api/2.0/migration/logs`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-migration-status/">REST API Reference for GetMigrationStatus Operation</seealso>
        /// <returns>Task of ApiResponse (MigrationStatusWrapper)</returns>
        Task<ApiResponse<MigrationStatusWrapper>> GetMigrationStatusWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get available migrators
        /// </summary>
        /// <remarks>
        /// Lists the source products this installation can import a portal from, as the migrator names every other  operation in this group expects. Nothing has to be called first, a DocSpace administrator is required as  everywhere here, and the call is read-only and idempotent. The answer is a plain list of names such as  `GoogleWorkspace`, `Nextcloud` or `Workspace`, never localized and ordered as the migrators are registered;  pass one of them as `migratorName` to `POST api/2.0/migration/init/{migratorName}`, where the match ignores  case. The list depends on the installation rather than on the portal, so it does not change while the portal  runs, and a name that is not in it is not rejected by the operation that takes it - the queued job ends with  the failure reported in `error` of `GET api/2.0/migration/status`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/list-migrations/">REST API Reference for ListMigrations Operation</seealso>
        /// <returns>Task of STRINGArrayWrapper</returns>
        Task<STRINGArrayWrapper> ListMigrationsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get available migrators
        /// </summary>
        /// <remarks>
        /// Lists the source products this installation can import a portal from, as the migrator names every other  operation in this group expects. Nothing has to be called first, a DocSpace administrator is required as  everywhere here, and the call is read-only and idempotent. The answer is a plain list of names such as  `GoogleWorkspace`, `Nextcloud` or `Workspace`, never localized and ordered as the migrators are registered;  pass one of them as `migratorName` to `POST api/2.0/migration/init/{migratorName}`, where the match ignores  case. The list depends on the installation rather than on the portal, so it does not change while the portal  runs, and a name that is not in it is not rejected by the operation that takes it - the queued job ends with  the failure reported in `error` of `GET api/2.0/migration/status`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/list-migrations/">REST API Reference for ListMigrations Operation</seealso>
        /// <returns>Task of ApiResponse (STRINGArrayWrapper)</returns>
        Task<ApiResponse<STRINGArrayWrapper>> ListMigrationsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Start migration
        /// </summary>
        /// <remarks>
        /// Starts the import itself: the users, the groups and the files selected in the request body are created on this  portal from the backup that the parse pass has read. Run `POST api/2.0/migration/init/{migratorName}` first  and wait for `isCompleted` in `GET api/2.0/migration/status`, then send `parseResult` from that answer back  here with `shouldImport` set on the users and groups to take and the `import...Files` flags set for the  content to copy. A DocSpace administrator is required, and importing a user as `DocSpaceAdmin` additionally  requires the caller to be the portal owner unless a user with that email is an administrator of this portal  already, otherwise the whole call is rejected with 403 before anything is imported. The job is queued and the  call answers with an empty body at once: watch `progress`, `successedUsers`, `failedUsers` and `error` in  `GET api/2.0/migration/status` and read what each step did from `GET api/2.0/migration/logs`. The import  writes to the portal and cannot be undone, and a repeat is no help: a call made while the job runs is ignored,  and once the job has ended the uploaded backup is deleted, so a new call has nothing to read until the archive  is uploaded and parsed again. When the import is done, close it with `POST api/2.0/migration/finish`, which can  also mail the imported users their activation link.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="migrationApiInfo">The migration API information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-migration/">REST API Reference for StartMigration Operation</seealso>
        /// <returns>Task of void</returns>
        Task StartMigrationAsync(MigrationApiInfo? migrationApiInfo = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Start migration
        /// </summary>
        /// <remarks>
        /// Starts the import itself: the users, the groups and the files selected in the request body are created on this  portal from the backup that the parse pass has read. Run `POST api/2.0/migration/init/{migratorName}` first  and wait for `isCompleted` in `GET api/2.0/migration/status`, then send `parseResult` from that answer back  here with `shouldImport` set on the users and groups to take and the `import...Files` flags set for the  content to copy. A DocSpace administrator is required, and importing a user as `DocSpaceAdmin` additionally  requires the caller to be the portal owner unless a user with that email is an administrator of this portal  already, otherwise the whole call is rejected with 403 before anything is imported. The job is queued and the  call answers with an empty body at once: watch `progress`, `successedUsers`, `failedUsers` and `error` in  `GET api/2.0/migration/status` and read what each step did from `GET api/2.0/migration/logs`. The import  writes to the portal and cannot be undone, and a repeat is no help: a call made while the job runs is ignored,  and once the job has ended the uploaded backup is deleted, so a new call has nothing to read until the archive  is uploaded and parsed again. When the import is done, close it with `POST api/2.0/migration/finish`, which can  also mail the imported users their activation link.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="migrationApiInfo">The migration API information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-migration/">REST API Reference for StartMigration Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> StartMigrationWithHttpInfoAsync(MigrationApiInfo? migrationApiInfo = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Parse migration archive
        /// </summary>
        /// <remarks>
        /// Queues a pass that reads the backup already uploaded for this portal with the migrator named in the path and  reports what it holds - the users, the users that carry no email address, the users that exist on this portal  already, the groups and the archives it could not open - so that the caller can choose what to import. Upload  the backup first: `migrationFileUpload.ashx?Init=true` opens a new upload folder and drops the previous one,  then every part of the archive is posted to the same handler with `Name` set to its file name; take  `migratorName` from `GET api/2.0/migration/list`. A DocSpace administrator is required. The call only queues  the job and answers at once with an empty body: poll `GET api/2.0/migration/status` until `isCompleted` is  true, then read what was found from `parseResult` and any failure from `error`. Nothing is imported here and  the portal is not changed - the parse result is the body to edit and send to  `POST api/2.0/migration/migrate`. A portal runs one job at a time, so a call made while another parse or  import is still running is ignored instead of reported, and a backup bigger than the portal's total storage  quota ends the job with an error rather than failing this call.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="migratorName">The migrator that knows the format of the uploaded backup. It has to be one of the names  `GET api/2.0/migration/list` reports for this installation, spelled exactly as listed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-and-initialize-migration/">REST API Reference for UploadAndInitializeMigration Operation</seealso>
        /// <returns>Task of void</returns>
        Task UploadAndInitializeMigrationAsync(string migratorName, CancellationToken cancellationToken = default);

        /// <summary>
        /// Parse migration archive
        /// </summary>
        /// <remarks>
        /// Queues a pass that reads the backup already uploaded for this portal with the migrator named in the path and  reports what it holds - the users, the users that carry no email address, the users that exist on this portal  already, the groups and the archives it could not open - so that the caller can choose what to import. Upload  the backup first: `migrationFileUpload.ashx?Init=true` opens a new upload folder and drops the previous one,  then every part of the archive is posted to the same handler with `Name` set to its file name; take  `migratorName` from `GET api/2.0/migration/list`. A DocSpace administrator is required. The call only queues  the job and answers at once with an empty body: poll `GET api/2.0/migration/status` until `isCompleted` is  true, then read what was found from `parseResult` and any failure from `error`. Nothing is imported here and  the portal is not changed - the parse result is the body to edit and send to  `POST api/2.0/migration/migrate`. A portal runs one job at a time, so a call made while another parse or  import is still running is ignored instead of reported, and a backup bigger than the portal's total storage  quota ends the job with an error rather than failing this call.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="migratorName">The migrator that knows the format of the uploaded backup. It has to be one of the names  `GET api/2.0/migration/list` reports for this installation, spelled exactly as listed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-and-initialize-migration/">REST API Reference for UploadAndInitializeMigration Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> UploadAndInitializeMigrationWithHttpInfoAsync(string migratorName, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMigrationApi : IMigrationApiSync, IMigrationApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MigrationApi : IDisposable, IMigrationApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public MigrationApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public MigrationApi(string basePath)
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
        /// Initializes a new instance of the <see cref="MigrationApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public MigrationApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="MigrationApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public MigrationApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationApi"/> class.
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
        public MigrationApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="MigrationApi"/> class using a Configuration object.
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
        public MigrationApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="MigrationApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public MigrationApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Cancel migration
        /// </summary>
        /// <remarks>
        /// Stops the parse pass queued for this portal and deletes the backup uploaded for it - the way back from a wrong  archive or a wrong migrator name. Nothing has to be called first and a DocSpace administrator is required; the  request is only queued, so the parse ends shortly after the call returns and  `GET api/2.0/migration/status` stops reporting it. The call is destructive for the uploaded data: the whole  upload folder is removed and the backup has to be sent to `migrationFileUpload.ashx` again before a new parse.  It is idempotent - cancelling when nothing is running still answers 200 - and it undoes nothing that was  already written to the portal. Only the parse stage is stopped, the job whose `parseResult.operation` is  `parse`: an import started by `POST api/2.0/migration/migrate` keeps running, and a finished import is  discarded with `POST api/2.0/migration/clear` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/cancel-migration/">REST API Reference for CancelMigration Operation</seealso>
        /// <returns></returns>
        public void CancelMigration()
        {
            CancelMigrationWithHttpInfo();
        }

        /// <summary>
        /// Cancel migration
        /// </summary>
        /// <remarks>
        /// Stops the parse pass queued for this portal and deletes the backup uploaded for it - the way back from a wrong  archive or a wrong migrator name. Nothing has to be called first and a DocSpace administrator is required; the  request is only queued, so the parse ends shortly after the call returns and  `GET api/2.0/migration/status` stops reporting it. The call is destructive for the uploaded data: the whole  upload folder is removed and the backup has to be sent to `migrationFileUpload.ashx` again before a new parse.  It is idempotent - cancelling when nothing is running still answers 200 - and it undoes nothing that was  already written to the portal. Only the parse stage is stopped, the job whose `parseResult.operation` is  `parse`: an import started by `POST api/2.0/migration/migrate` keeps running, and a finished import is  discarded with `POST api/2.0/migration/clear` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/cancel-migration/">REST API Reference for CancelMigration Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CancelMigrationWithHttpInfo()
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
            var localVarResponse = Client.Post<Object>("/api/2.0/migration/cancel", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CancelMigration", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Cancel migration
        /// </summary>
        /// <remarks>
        /// Stops the parse pass queued for this portal and deletes the backup uploaded for it - the way back from a wrong  archive or a wrong migrator name. Nothing has to be called first and a DocSpace administrator is required; the  request is only queued, so the parse ends shortly after the call returns and  `GET api/2.0/migration/status` stops reporting it. The call is destructive for the uploaded data: the whole  upload folder is removed and the backup has to be sent to `migrationFileUpload.ashx` again before a new parse.  It is idempotent - cancelling when nothing is running still answers 200 - and it undoes nothing that was  already written to the portal. Only the parse stage is stopped, the job whose `parseResult.operation` is  `parse`: an import started by `POST api/2.0/migration/migrate` keeps running, and a finished import is  discarded with `POST api/2.0/migration/clear` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/cancel-migration/">REST API Reference for CancelMigration Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task CancelMigrationAsync(CancellationToken cancellationToken = default)
        {
            await CancelMigrationWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Cancel migration
        /// </summary>
        /// <remarks>
        /// Stops the parse pass queued for this portal and deletes the backup uploaded for it - the way back from a wrong  archive or a wrong migrator name. Nothing has to be called first and a DocSpace administrator is required; the  request is only queued, so the parse ends shortly after the call returns and  `GET api/2.0/migration/status` stops reporting it. The call is destructive for the uploaded data: the whole  upload folder is removed and the backup has to be sent to `migrationFileUpload.ashx` again before a new parse.  It is idempotent - cancelling when nothing is running still answers 200 - and it undoes nothing that was  already written to the portal. Only the parse stage is stopped, the job whose `parseResult.operation` is  `parse`: an import started by `POST api/2.0/migration/migrate` keeps running, and a finished import is  discarded with `POST api/2.0/migration/clear` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/cancel-migration/">REST API Reference for CancelMigration Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> CancelMigrationWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.PostAsync<Object>("/api/2.0/migration/cancel", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CancelMigration", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Clear migration
        /// </summary>
        /// <remarks>
        /// Discards a finished import and deletes the data uploaded for it, freeing the portal for the next one. Call it  once `GET api/2.0/migration/status` reports `isCompleted` for a job whose `parseResult.operation` is  `migration`; a DocSpace administrator is required. Only the queued job and the temporary upload folder go -  the users, groups and files already imported stay in the portal - so the call destroys migration data alone,  and it is idempotent: clearing twice, or with nothing to clear, still answers 200. Like the other write  operations here it is only queued, and once it has run `GET api/2.0/migration/status` returns an empty result  and `GET api/2.0/migration/logs` answers 404, so download the log before calling it. A parse that is still  running is not affected - stop that with `POST api/2.0/migration/cancel` - and  `POST api/2.0/migration/finish` performs the same clean-up itself, which makes this call unnecessary after it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/clear-migration/">REST API Reference for ClearMigration Operation</seealso>
        /// <returns></returns>
        public void ClearMigration()
        {
            ClearMigrationWithHttpInfo();
        }

        /// <summary>
        /// Clear migration
        /// </summary>
        /// <remarks>
        /// Discards a finished import and deletes the data uploaded for it, freeing the portal for the next one. Call it  once `GET api/2.0/migration/status` reports `isCompleted` for a job whose `parseResult.operation` is  `migration`; a DocSpace administrator is required. Only the queued job and the temporary upload folder go -  the users, groups and files already imported stay in the portal - so the call destroys migration data alone,  and it is idempotent: clearing twice, or with nothing to clear, still answers 200. Like the other write  operations here it is only queued, and once it has run `GET api/2.0/migration/status` returns an empty result  and `GET api/2.0/migration/logs` answers 404, so download the log before calling it. A parse that is still  running is not affected - stop that with `POST api/2.0/migration/cancel` - and  `POST api/2.0/migration/finish` performs the same clean-up itself, which makes this call unnecessary after it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/clear-migration/">REST API Reference for ClearMigration Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ClearMigrationWithHttpInfo()
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
            var localVarResponse = Client.Post<Object>("/api/2.0/migration/clear", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ClearMigration", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Clear migration
        /// </summary>
        /// <remarks>
        /// Discards a finished import and deletes the data uploaded for it, freeing the portal for the next one. Call it  once `GET api/2.0/migration/status` reports `isCompleted` for a job whose `parseResult.operation` is  `migration`; a DocSpace administrator is required. Only the queued job and the temporary upload folder go -  the users, groups and files already imported stay in the portal - so the call destroys migration data alone,  and it is idempotent: clearing twice, or with nothing to clear, still answers 200. Like the other write  operations here it is only queued, and once it has run `GET api/2.0/migration/status` returns an empty result  and `GET api/2.0/migration/logs` answers 404, so download the log before calling it. A parse that is still  running is not affected - stop that with `POST api/2.0/migration/cancel` - and  `POST api/2.0/migration/finish` performs the same clean-up itself, which makes this call unnecessary after it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/clear-migration/">REST API Reference for ClearMigration Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task ClearMigrationAsync(CancellationToken cancellationToken = default)
        {
            await ClearMigrationWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Clear migration
        /// </summary>
        /// <remarks>
        /// Discards a finished import and deletes the data uploaded for it, freeing the portal for the next one. Call it  once `GET api/2.0/migration/status` reports `isCompleted` for a job whose `parseResult.operation` is  `migration`; a DocSpace administrator is required. Only the queued job and the temporary upload folder go -  the users, groups and files already imported stay in the portal - so the call destroys migration data alone,  and it is idempotent: clearing twice, or with nothing to clear, still answers 200. Like the other write  operations here it is only queued, and once it has run `GET api/2.0/migration/status` returns an empty result  and `GET api/2.0/migration/logs` answers 404, so download the log before calling it. A parse that is still  running is not affected - stop that with `POST api/2.0/migration/cancel` - and  `POST api/2.0/migration/finish` performs the same clean-up itself, which makes this call unnecessary after it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/clear-migration/">REST API Reference for ClearMigration Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> ClearMigrationWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.PostAsync<Object>("/api/2.0/migration/clear", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ClearMigration", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Finish migration
        /// </summary>
        /// <remarks>
        /// Closes a completed import: it can send every user the import created the activation email they need before  they can sign in, and it then discards the job and the data uploaded for it. Call it once  `GET api/2.0/migration/status` reports `isCompleted` for the import; a DocSpace administrator is required, and  with `isSendWelcomeEmail` set to true the job must still be in the queue, so do not clear it first. That flag  decides what happens to the imported people: true mails the activation link to each of them who has not  activated their account yet and skips the ones that are already active, false ends the import quietly and  leaves inviting them for later. The call writes to the portal and is not idempotent - the emails go out again  on every call - while its second half repeats what `POST api/2.0/migration/clear` does, removing the finished  job and the uploaded backup and leaving everything already imported in place. It answers with an empty body,  after which `GET api/2.0/migration/status` returns an empty result and `GET api/2.0/migration/logs` answers  404, so download the log first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="finishDto">Whether the finished import mails the imported people their activation links before it is cleared away. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/finish-migration/">REST API Reference for FinishMigration Operation</seealso>
        /// <returns></returns>
        public void FinishMigration(FinishDto? finishDto = default)
        {
            FinishMigrationWithHttpInfo(finishDto);
        }

        /// <summary>
        /// Finish migration
        /// </summary>
        /// <remarks>
        /// Closes a completed import: it can send every user the import created the activation email they need before  they can sign in, and it then discards the job and the data uploaded for it. Call it once  `GET api/2.0/migration/status` reports `isCompleted` for the import; a DocSpace administrator is required, and  with `isSendWelcomeEmail` set to true the job must still be in the queue, so do not clear it first. That flag  decides what happens to the imported people: true mails the activation link to each of them who has not  activated their account yet and skips the ones that are already active, false ends the import quietly and  leaves inviting them for later. The call writes to the portal and is not idempotent - the emails go out again  on every call - while its second half repeats what `POST api/2.0/migration/clear` does, removing the finished  job and the uploaded backup and leaving everything already imported in place. It answers with an empty body,  after which `GET api/2.0/migration/status` returns an empty result and `GET api/2.0/migration/logs` answers  404, so download the log first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="finishDto">Whether the finished import mails the imported people their activation links before it is cleared away. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/finish-migration/">REST API Reference for FinishMigration Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> FinishMigrationWithHttpInfo(FinishDto? finishDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (finishDto != null) localVarRequestOptions.Data = finishDto;

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
            var localVarResponse = Client.Post<Object>("/api/2.0/migration/finish", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("FinishMigration", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Finish migration
        /// </summary>
        /// <remarks>
        /// Closes a completed import: it can send every user the import created the activation email they need before  they can sign in, and it then discards the job and the data uploaded for it. Call it once  `GET api/2.0/migration/status` reports `isCompleted` for the import; a DocSpace administrator is required, and  with `isSendWelcomeEmail` set to true the job must still be in the queue, so do not clear it first. That flag  decides what happens to the imported people: true mails the activation link to each of them who has not  activated their account yet and skips the ones that are already active, false ends the import quietly and  leaves inviting them for later. The call writes to the portal and is not idempotent - the emails go out again  on every call - while its second half repeats what `POST api/2.0/migration/clear` does, removing the finished  job and the uploaded backup and leaving everything already imported in place. It answers with an empty body,  after which `GET api/2.0/migration/status` returns an empty result and `GET api/2.0/migration/logs` answers  404, so download the log first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="finishDto">Whether the finished import mails the imported people their activation links before it is cleared away. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/finish-migration/">REST API Reference for FinishMigration Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task FinishMigrationAsync(FinishDto? finishDto = default, CancellationToken cancellationToken = default)
        {
            await FinishMigrationWithHttpInfoAsync(finishDto, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Finish migration
        /// </summary>
        /// <remarks>
        /// Closes a completed import: it can send every user the import created the activation email they need before  they can sign in, and it then discards the job and the data uploaded for it. Call it once  `GET api/2.0/migration/status` reports `isCompleted` for the import; a DocSpace administrator is required, and  with `isSendWelcomeEmail` set to true the job must still be in the queue, so do not clear it first. That flag  decides what happens to the imported people: true mails the activation link to each of them who has not  activated their account yet and skips the ones that are already active, false ends the import quietly and  leaves inviting them for later. The call writes to the portal and is not idempotent - the emails go out again  on every call - while its second half repeats what `POST api/2.0/migration/clear` does, removing the finished  job and the uploaded backup and leaving everything already imported in place. It answers with an empty body,  after which `GET api/2.0/migration/status` returns an empty result and `GET api/2.0/migration/logs` answers  404, so download the log first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="finishDto">Whether the finished import mails the imported people their activation links before it is cleared away. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/finish-migration/">REST API Reference for FinishMigration Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> FinishMigrationWithHttpInfoAsync(FinishDto? finishDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (finishDto != null) localVarRequestOptions.Data = finishDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<Object>("/api/2.0/migration/finish", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("FinishMigration", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get migration logs
        /// </summary>
        /// <remarks>
        /// Downloads the log of the parse or import the portal currently holds - the step-by-step record behind the  numbers and the single error message of `GET api/2.0/migration/status`, and the place where the reason for a  skipped user or file is written. The portal has to hold such a job, started by  `POST api/2.0/migration/init/{migratorName}` or `POST api/2.0/migration/migrate` and not yet removed by  `POST api/2.0/migration/clear` or `POST api/2.0/migration/finish`, otherwise the call answers 404; a DocSpace  administrator is required and the call is read-only and idempotent. The body is not JSON: it is  `text/plain; charset=UTF-8` sent as an attachment named `migration.log`, one line per step with the progress  it reported. Each job writes its own log, so this always returns the log of the job that  `GET api/2.0/migration/status` describes, and while that job runs the file keeps growing - a call made early  returns only the part written so far and may be repeated later for the rest.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-migration-logs/">REST API Reference for GetMigrationLogs Operation</seealso>
        /// <returns></returns>
        public void GetMigrationLogs()
        {
            GetMigrationLogsWithHttpInfo();
        }

        /// <summary>
        /// Get migration logs
        /// </summary>
        /// <remarks>
        /// Downloads the log of the parse or import the portal currently holds - the step-by-step record behind the  numbers and the single error message of `GET api/2.0/migration/status`, and the place where the reason for a  skipped user or file is written. The portal has to hold such a job, started by  `POST api/2.0/migration/init/{migratorName}` or `POST api/2.0/migration/migrate` and not yet removed by  `POST api/2.0/migration/clear` or `POST api/2.0/migration/finish`, otherwise the call answers 404; a DocSpace  administrator is required and the call is read-only and idempotent. The body is not JSON: it is  `text/plain; charset=UTF-8` sent as an attachment named `migration.log`, one line per step with the progress  it reported. Each job writes its own log, so this always returns the log of the job that  `GET api/2.0/migration/status` describes, and while that job runs the file keeps growing - a call made early  returns only the part written so far and may be repeated later for the rest.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-migration-logs/">REST API Reference for GetMigrationLogs Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetMigrationLogsWithHttpInfo()
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
            var localVarResponse = Client.Get<Object>("/api/2.0/migration/logs", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetMigrationLogs", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get migration logs
        /// </summary>
        /// <remarks>
        /// Downloads the log of the parse or import the portal currently holds - the step-by-step record behind the  numbers and the single error message of `GET api/2.0/migration/status`, and the place where the reason for a  skipped user or file is written. The portal has to hold such a job, started by  `POST api/2.0/migration/init/{migratorName}` or `POST api/2.0/migration/migrate` and not yet removed by  `POST api/2.0/migration/clear` or `POST api/2.0/migration/finish`, otherwise the call answers 404; a DocSpace  administrator is required and the call is read-only and idempotent. The body is not JSON: it is  `text/plain; charset=UTF-8` sent as an attachment named `migration.log`, one line per step with the progress  it reported. Each job writes its own log, so this always returns the log of the job that  `GET api/2.0/migration/status` describes, and while that job runs the file keeps growing - a call made early  returns only the part written so far and may be repeated later for the rest.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-migration-logs/">REST API Reference for GetMigrationLogs Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task GetMigrationLogsAsync(CancellationToken cancellationToken = default)
        {
            await GetMigrationLogsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get migration logs
        /// </summary>
        /// <remarks>
        /// Downloads the log of the parse or import the portal currently holds - the step-by-step record behind the  numbers and the single error message of `GET api/2.0/migration/status`, and the place where the reason for a  skipped user or file is written. The portal has to hold such a job, started by  `POST api/2.0/migration/init/{migratorName}` or `POST api/2.0/migration/migrate` and not yet removed by  `POST api/2.0/migration/clear` or `POST api/2.0/migration/finish`, otherwise the call answers 404; a DocSpace  administrator is required and the call is read-only and idempotent. The body is not JSON: it is  `text/plain; charset=UTF-8` sent as an attachment named `migration.log`, one line per step with the progress  it reported. Each job writes its own log, so this always returns the log of the job that  `GET api/2.0/migration/status` describes, and while that job runs the file keeps growing - a call made early  returns only the part written so far and may be repeated later for the rest.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-migration-logs/">REST API Reference for GetMigrationLogs Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> GetMigrationLogsWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<Object>("/api/2.0/migration/logs", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetMigrationLogs", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get migration status
        /// </summary>
        /// <remarks>
        /// Returns how far the parse or the import queued for this portal has got and, once it stopped, what it produced  - the one place where every other operation in this group reports what it did. Any of them may be polled from  here as soon as it returns; a DocSpace administrator is required and the call is read-only and idempotent.  `progress` is the share of the job that is done, from 0 to 100, and `isCompleted` turns true when the job  stopped whether it succeeded or not, so read `error` as well: it stays empty while nothing went wrong and  otherwise holds the message that ended the job. `parseResult` carries what the migrator has read so far -  after a parse pass the users, groups and unreadable archives to edit and post to  `POST api/2.0/migration/migrate`, and during an import also `successedUsers` and `failedUsers` - and its  `operation` field, `parse` or `migration`, tells the two stages apart. The result is empty with status 200  when the portal has no job at all, because none was ever started or because  `POST api/2.0/migration/clear` or `POST api/2.0/migration/finish` has removed the last one; an empty answer is  therefore not an error. Line-by-line detail behind the numbers is in `GET api/2.0/migration/logs`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-migration-status/">REST API Reference for GetMigrationStatus Operation</seealso>
        /// <returns>MigrationStatusWrapper</returns>
        public MigrationStatusWrapper GetMigrationStatus()
        {
            var localVarResponse = GetMigrationStatusWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get migration status
        /// </summary>
        /// <remarks>
        /// Returns how far the parse or the import queued for this portal has got and, once it stopped, what it produced  - the one place where every other operation in this group reports what it did. Any of them may be polled from  here as soon as it returns; a DocSpace administrator is required and the call is read-only and idempotent.  `progress` is the share of the job that is done, from 0 to 100, and `isCompleted` turns true when the job  stopped whether it succeeded or not, so read `error` as well: it stays empty while nothing went wrong and  otherwise holds the message that ended the job. `parseResult` carries what the migrator has read so far -  after a parse pass the users, groups and unreadable archives to edit and post to  `POST api/2.0/migration/migrate`, and during an import also `successedUsers` and `failedUsers` - and its  `operation` field, `parse` or `migration`, tells the two stages apart. The result is empty with status 200  when the portal has no job at all, because none was ever started or because  `POST api/2.0/migration/clear` or `POST api/2.0/migration/finish` has removed the last one; an empty answer is  therefore not an error. Line-by-line detail behind the numbers is in `GET api/2.0/migration/logs`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-migration-status/">REST API Reference for GetMigrationStatus Operation</seealso>
        /// <returns>ApiResponse of MigrationStatusWrapper</returns>
        public ApiResponse<MigrationStatusWrapper> GetMigrationStatusWithHttpInfo()
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
            var localVarResponse = Client.Get<MigrationStatusWrapper>("/api/2.0/migration/status", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetMigrationStatus", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get migration status
        /// </summary>
        /// <remarks>
        /// Returns how far the parse or the import queued for this portal has got and, once it stopped, what it produced  - the one place where every other operation in this group reports what it did. Any of them may be polled from  here as soon as it returns; a DocSpace administrator is required and the call is read-only and idempotent.  `progress` is the share of the job that is done, from 0 to 100, and `isCompleted` turns true when the job  stopped whether it succeeded or not, so read `error` as well: it stays empty while nothing went wrong and  otherwise holds the message that ended the job. `parseResult` carries what the migrator has read so far -  after a parse pass the users, groups and unreadable archives to edit and post to  `POST api/2.0/migration/migrate`, and during an import also `successedUsers` and `failedUsers` - and its  `operation` field, `parse` or `migration`, tells the two stages apart. The result is empty with status 200  when the portal has no job at all, because none was ever started or because  `POST api/2.0/migration/clear` or `POST api/2.0/migration/finish` has removed the last one; an empty answer is  therefore not an error. Line-by-line detail behind the numbers is in `GET api/2.0/migration/logs`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-migration-status/">REST API Reference for GetMigrationStatus Operation</seealso>
        /// <returns>Task of MigrationStatusWrapper</returns>
        public async Task<MigrationStatusWrapper> GetMigrationStatusAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetMigrationStatusWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get migration status
        /// </summary>
        /// <remarks>
        /// Returns how far the parse or the import queued for this portal has got and, once it stopped, what it produced  - the one place where every other operation in this group reports what it did. Any of them may be polled from  here as soon as it returns; a DocSpace administrator is required and the call is read-only and idempotent.  `progress` is the share of the job that is done, from 0 to 100, and `isCompleted` turns true when the job  stopped whether it succeeded or not, so read `error` as well: it stays empty while nothing went wrong and  otherwise holds the message that ended the job. `parseResult` carries what the migrator has read so far -  after a parse pass the users, groups and unreadable archives to edit and post to  `POST api/2.0/migration/migrate`, and during an import also `successedUsers` and `failedUsers` - and its  `operation` field, `parse` or `migration`, tells the two stages apart. The result is empty with status 200  when the portal has no job at all, because none was ever started or because  `POST api/2.0/migration/clear` or `POST api/2.0/migration/finish` has removed the last one; an empty answer is  therefore not an error. Line-by-line detail behind the numbers is in `GET api/2.0/migration/logs`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-migration-status/">REST API Reference for GetMigrationStatus Operation</seealso>
        /// <returns>Task of ApiResponse (MigrationStatusWrapper)</returns>
        public async Task<ApiResponse<MigrationStatusWrapper>> GetMigrationStatusWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<MigrationStatusWrapper>("/api/2.0/migration/status", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetMigrationStatus", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get available migrators
        /// </summary>
        /// <remarks>
        /// Lists the source products this installation can import a portal from, as the migrator names every other  operation in this group expects. Nothing has to be called first, a DocSpace administrator is required as  everywhere here, and the call is read-only and idempotent. The answer is a plain list of names such as  `GoogleWorkspace`, `Nextcloud` or `Workspace`, never localized and ordered as the migrators are registered;  pass one of them as `migratorName` to `POST api/2.0/migration/init/{migratorName}`, where the match ignores  case. The list depends on the installation rather than on the portal, so it does not change while the portal  runs, and a name that is not in it is not rejected by the operation that takes it - the queued job ends with  the failure reported in `error` of `GET api/2.0/migration/status`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/list-migrations/">REST API Reference for ListMigrations Operation</seealso>
        /// <returns>STRINGArrayWrapper</returns>
        public STRINGArrayWrapper ListMigrations()
        {
            var localVarResponse = ListMigrationsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get available migrators
        /// </summary>
        /// <remarks>
        /// Lists the source products this installation can import a portal from, as the migrator names every other  operation in this group expects. Nothing has to be called first, a DocSpace administrator is required as  everywhere here, and the call is read-only and idempotent. The answer is a plain list of names such as  `GoogleWorkspace`, `Nextcloud` or `Workspace`, never localized and ordered as the migrators are registered;  pass one of them as `migratorName` to `POST api/2.0/migration/init/{migratorName}`, where the match ignores  case. The list depends on the installation rather than on the portal, so it does not change while the portal  runs, and a name that is not in it is not rejected by the operation that takes it - the queued job ends with  the failure reported in `error` of `GET api/2.0/migration/status`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/list-migrations/">REST API Reference for ListMigrations Operation</seealso>
        /// <returns>ApiResponse of STRINGArrayWrapper</returns>
        public ApiResponse<STRINGArrayWrapper> ListMigrationsWithHttpInfo()
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
            var localVarResponse = Client.Get<STRINGArrayWrapper>("/api/2.0/migration/list", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ListMigrations", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get available migrators
        /// </summary>
        /// <remarks>
        /// Lists the source products this installation can import a portal from, as the migrator names every other  operation in this group expects. Nothing has to be called first, a DocSpace administrator is required as  everywhere here, and the call is read-only and idempotent. The answer is a plain list of names such as  `GoogleWorkspace`, `Nextcloud` or `Workspace`, never localized and ordered as the migrators are registered;  pass one of them as `migratorName` to `POST api/2.0/migration/init/{migratorName}`, where the match ignores  case. The list depends on the installation rather than on the portal, so it does not change while the portal  runs, and a name that is not in it is not rejected by the operation that takes it - the queued job ends with  the failure reported in `error` of `GET api/2.0/migration/status`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/list-migrations/">REST API Reference for ListMigrations Operation</seealso>
        /// <returns>Task of STRINGArrayWrapper</returns>
        public async Task<STRINGArrayWrapper> ListMigrationsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ListMigrationsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get available migrators
        /// </summary>
        /// <remarks>
        /// Lists the source products this installation can import a portal from, as the migrator names every other  operation in this group expects. Nothing has to be called first, a DocSpace administrator is required as  everywhere here, and the call is read-only and idempotent. The answer is a plain list of names such as  `GoogleWorkspace`, `Nextcloud` or `Workspace`, never localized and ordered as the migrators are registered;  pass one of them as `migratorName` to `POST api/2.0/migration/init/{migratorName}`, where the match ignores  case. The list depends on the installation rather than on the portal, so it does not change while the portal  runs, and a name that is not in it is not rejected by the operation that takes it - the queued job ends with  the failure reported in `error` of `GET api/2.0/migration/status`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/list-migrations/">REST API Reference for ListMigrations Operation</seealso>
        /// <returns>Task of ApiResponse (STRINGArrayWrapper)</returns>
        public async Task<ApiResponse<STRINGArrayWrapper>> ListMigrationsWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<STRINGArrayWrapper>("/api/2.0/migration/list", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ListMigrations", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start migration
        /// </summary>
        /// <remarks>
        /// Starts the import itself: the users, the groups and the files selected in the request body are created on this  portal from the backup that the parse pass has read. Run `POST api/2.0/migration/init/{migratorName}` first  and wait for `isCompleted` in `GET api/2.0/migration/status`, then send `parseResult` from that answer back  here with `shouldImport` set on the users and groups to take and the `import...Files` flags set for the  content to copy. A DocSpace administrator is required, and importing a user as `DocSpaceAdmin` additionally  requires the caller to be the portal owner unless a user with that email is an administrator of this portal  already, otherwise the whole call is rejected with 403 before anything is imported. The job is queued and the  call answers with an empty body at once: watch `progress`, `successedUsers`, `failedUsers` and `error` in  `GET api/2.0/migration/status` and read what each step did from `GET api/2.0/migration/logs`. The import  writes to the portal and cannot be undone, and a repeat is no help: a call made while the job runs is ignored,  and once the job has ended the uploaded backup is deleted, so a new call has nothing to read until the archive  is uploaded and parsed again. When the import is done, close it with `POST api/2.0/migration/finish`, which can  also mail the imported users their activation link.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="migrationApiInfo">The migration API information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-migration/">REST API Reference for StartMigration Operation</seealso>
        /// <returns></returns>
        public void StartMigration(MigrationApiInfo? migrationApiInfo = default)
        {
            StartMigrationWithHttpInfo(migrationApiInfo);
        }

        /// <summary>
        /// Start migration
        /// </summary>
        /// <remarks>
        /// Starts the import itself: the users, the groups and the files selected in the request body are created on this  portal from the backup that the parse pass has read. Run `POST api/2.0/migration/init/{migratorName}` first  and wait for `isCompleted` in `GET api/2.0/migration/status`, then send `parseResult` from that answer back  here with `shouldImport` set on the users and groups to take and the `import...Files` flags set for the  content to copy. A DocSpace administrator is required, and importing a user as `DocSpaceAdmin` additionally  requires the caller to be the portal owner unless a user with that email is an administrator of this portal  already, otherwise the whole call is rejected with 403 before anything is imported. The job is queued and the  call answers with an empty body at once: watch `progress`, `successedUsers`, `failedUsers` and `error` in  `GET api/2.0/migration/status` and read what each step did from `GET api/2.0/migration/logs`. The import  writes to the portal and cannot be undone, and a repeat is no help: a call made while the job runs is ignored,  and once the job has ended the uploaded backup is deleted, so a new call has nothing to read until the archive  is uploaded and parsed again. When the import is done, close it with `POST api/2.0/migration/finish`, which can  also mail the imported users their activation link.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="migrationApiInfo">The migration API information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-migration/">REST API Reference for StartMigration Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> StartMigrationWithHttpInfo(MigrationApiInfo? migrationApiInfo = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (migrationApiInfo != null) localVarRequestOptions.Data = migrationApiInfo;

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
            var localVarResponse = Client.Post<Object>("/api/2.0/migration/migrate", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("StartMigration", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start migration
        /// </summary>
        /// <remarks>
        /// Starts the import itself: the users, the groups and the files selected in the request body are created on this  portal from the backup that the parse pass has read. Run `POST api/2.0/migration/init/{migratorName}` first  and wait for `isCompleted` in `GET api/2.0/migration/status`, then send `parseResult` from that answer back  here with `shouldImport` set on the users and groups to take and the `import...Files` flags set for the  content to copy. A DocSpace administrator is required, and importing a user as `DocSpaceAdmin` additionally  requires the caller to be the portal owner unless a user with that email is an administrator of this portal  already, otherwise the whole call is rejected with 403 before anything is imported. The job is queued and the  call answers with an empty body at once: watch `progress`, `successedUsers`, `failedUsers` and `error` in  `GET api/2.0/migration/status` and read what each step did from `GET api/2.0/migration/logs`. The import  writes to the portal and cannot be undone, and a repeat is no help: a call made while the job runs is ignored,  and once the job has ended the uploaded backup is deleted, so a new call has nothing to read until the archive  is uploaded and parsed again. When the import is done, close it with `POST api/2.0/migration/finish`, which can  also mail the imported users their activation link.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="migrationApiInfo">The migration API information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-migration/">REST API Reference for StartMigration Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task StartMigrationAsync(MigrationApiInfo? migrationApiInfo = default, CancellationToken cancellationToken = default)
        {
            await StartMigrationWithHttpInfoAsync(migrationApiInfo, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Start migration
        /// </summary>
        /// <remarks>
        /// Starts the import itself: the users, the groups and the files selected in the request body are created on this  portal from the backup that the parse pass has read. Run `POST api/2.0/migration/init/{migratorName}` first  and wait for `isCompleted` in `GET api/2.0/migration/status`, then send `parseResult` from that answer back  here with `shouldImport` set on the users and groups to take and the `import...Files` flags set for the  content to copy. A DocSpace administrator is required, and importing a user as `DocSpaceAdmin` additionally  requires the caller to be the portal owner unless a user with that email is an administrator of this portal  already, otherwise the whole call is rejected with 403 before anything is imported. The job is queued and the  call answers with an empty body at once: watch `progress`, `successedUsers`, `failedUsers` and `error` in  `GET api/2.0/migration/status` and read what each step did from `GET api/2.0/migration/logs`. The import  writes to the portal and cannot be undone, and a repeat is no help: a call made while the job runs is ignored,  and once the job has ended the uploaded backup is deleted, so a new call has nothing to read until the archive  is uploaded and parsed again. When the import is done, close it with `POST api/2.0/migration/finish`, which can  also mail the imported users their activation link.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="migrationApiInfo">The migration API information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-migration/">REST API Reference for StartMigration Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> StartMigrationWithHttpInfoAsync(MigrationApiInfo? migrationApiInfo = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (migrationApiInfo != null) localVarRequestOptions.Data = migrationApiInfo;

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

            var localVarResponse = await AsynchronousClient.PostAsync<Object>("/api/2.0/migration/migrate", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("StartMigration", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Parse migration archive
        /// </summary>
        /// <remarks>
        /// Queues a pass that reads the backup already uploaded for this portal with the migrator named in the path and  reports what it holds - the users, the users that carry no email address, the users that exist on this portal  already, the groups and the archives it could not open - so that the caller can choose what to import. Upload  the backup first: `migrationFileUpload.ashx?Init=true` opens a new upload folder and drops the previous one,  then every part of the archive is posted to the same handler with `Name` set to its file name; take  `migratorName` from `GET api/2.0/migration/list`. A DocSpace administrator is required. The call only queues  the job and answers at once with an empty body: poll `GET api/2.0/migration/status` until `isCompleted` is  true, then read what was found from `parseResult` and any failure from `error`. Nothing is imported here and  the portal is not changed - the parse result is the body to edit and send to  `POST api/2.0/migration/migrate`. A portal runs one job at a time, so a call made while another parse or  import is still running is ignored instead of reported, and a backup bigger than the portal's total storage  quota ends the job with an error rather than failing this call.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="migratorName">The migrator that knows the format of the uploaded backup. It has to be one of the names  `GET api/2.0/migration/list` reports for this installation, spelled exactly as listed.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-and-initialize-migration/">REST API Reference for UploadAndInitializeMigration Operation</seealso>
        /// <returns></returns>
        public void UploadAndInitializeMigration(string migratorName)
        {
            UploadAndInitializeMigrationWithHttpInfo(migratorName);
        }

        /// <summary>
        /// Parse migration archive
        /// </summary>
        /// <remarks>
        /// Queues a pass that reads the backup already uploaded for this portal with the migrator named in the path and  reports what it holds - the users, the users that carry no email address, the users that exist on this portal  already, the groups and the archives it could not open - so that the caller can choose what to import. Upload  the backup first: `migrationFileUpload.ashx?Init=true` opens a new upload folder and drops the previous one,  then every part of the archive is posted to the same handler with `Name` set to its file name; take  `migratorName` from `GET api/2.0/migration/list`. A DocSpace administrator is required. The call only queues  the job and answers at once with an empty body: poll `GET api/2.0/migration/status` until `isCompleted` is  true, then read what was found from `parseResult` and any failure from `error`. Nothing is imported here and  the portal is not changed - the parse result is the body to edit and send to  `POST api/2.0/migration/migrate`. A portal runs one job at a time, so a call made while another parse or  import is still running is ignored instead of reported, and a backup bigger than the portal's total storage  quota ends the job with an error rather than failing this call.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="migratorName">The migrator that knows the format of the uploaded backup. It has to be one of the names  `GET api/2.0/migration/list` reports for this installation, spelled exactly as listed.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-and-initialize-migration/">REST API Reference for UploadAndInitializeMigration Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UploadAndInitializeMigrationWithHttpInfo(string migratorName)
        {
            // verify the required parameter 'migratorName' is set
            if (migratorName == null)
                throw new ApiException(400, "Missing required parameter 'migratorName' when calling MigrationApi->UploadAndInitializeMigration");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("migratorName", ClientUtils.ParameterToString(migratorName)); // path parameter

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
            var localVarResponse = Client.Post<Object>("/api/2.0/migration/init/{migratorName}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UploadAndInitializeMigration", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Parse migration archive
        /// </summary>
        /// <remarks>
        /// Queues a pass that reads the backup already uploaded for this portal with the migrator named in the path and  reports what it holds - the users, the users that carry no email address, the users that exist on this portal  already, the groups and the archives it could not open - so that the caller can choose what to import. Upload  the backup first: `migrationFileUpload.ashx?Init=true` opens a new upload folder and drops the previous one,  then every part of the archive is posted to the same handler with `Name` set to its file name; take  `migratorName` from `GET api/2.0/migration/list`. A DocSpace administrator is required. The call only queues  the job and answers at once with an empty body: poll `GET api/2.0/migration/status` until `isCompleted` is  true, then read what was found from `parseResult` and any failure from `error`. Nothing is imported here and  the portal is not changed - the parse result is the body to edit and send to  `POST api/2.0/migration/migrate`. A portal runs one job at a time, so a call made while another parse or  import is still running is ignored instead of reported, and a backup bigger than the portal's total storage  quota ends the job with an error rather than failing this call.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="migratorName">The migrator that knows the format of the uploaded backup. It has to be one of the names  `GET api/2.0/migration/list` reports for this installation, spelled exactly as listed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-and-initialize-migration/">REST API Reference for UploadAndInitializeMigration Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task UploadAndInitializeMigrationAsync(string migratorName, CancellationToken cancellationToken = default)
        {
            await UploadAndInitializeMigrationWithHttpInfoAsync(migratorName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Parse migration archive
        /// </summary>
        /// <remarks>
        /// Queues a pass that reads the backup already uploaded for this portal with the migrator named in the path and  reports what it holds - the users, the users that carry no email address, the users that exist on this portal  already, the groups and the archives it could not open - so that the caller can choose what to import. Upload  the backup first: `migrationFileUpload.ashx?Init=true` opens a new upload folder and drops the previous one,  then every part of the archive is posted to the same handler with `Name` set to its file name; take  `migratorName` from `GET api/2.0/migration/list`. A DocSpace administrator is required. The call only queues  the job and answers at once with an empty body: poll `GET api/2.0/migration/status` until `isCompleted` is  true, then read what was found from `parseResult` and any failure from `error`. Nothing is imported here and  the portal is not changed - the parse result is the body to edit and send to  `POST api/2.0/migration/migrate`. A portal runs one job at a time, so a call made while another parse or  import is still running is ignored instead of reported, and a backup bigger than the portal's total storage  quota ends the job with an error rather than failing this call.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="migratorName">The migrator that knows the format of the uploaded backup. It has to be one of the names  `GET api/2.0/migration/list` reports for this installation, spelled exactly as listed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-and-initialize-migration/">REST API Reference for UploadAndInitializeMigration Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> UploadAndInitializeMigrationWithHttpInfoAsync(string migratorName, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'migratorName' is set
            if (migratorName == null)
                throw new ApiException(400, "Missing required parameter 'migratorName' when calling MigrationApi->UploadAndInitializeMigration");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("migratorName", ClientUtils.ParameterToString(migratorName)); // path parameter

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

            var localVarResponse = await AsynchronousClient.PostAsync<Object>("/api/2.0/migration/init/{migratorName}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UploadAndInitializeMigration", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
