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
namespace DocSpace.API.SDK.Api.Files
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-access-to-thirdparty/">REST API Reference for ChangeAccessToThirdparty Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper ChangeAccessToThirdparty(SettingsRequestDto? settingsRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-access-to-thirdparty/">REST API Reference for ChangeAccessToThirdparty Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> ChangeAccessToThirdpartyWithHttpInfo(SettingsRequestDto? settingsRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autoCleanupRequestDto">The auto-clearing request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-automatically-clean-up/">REST API Reference for ChangeAutomaticallyCleanUp Operation</seealso>
        /// <returns>AutoCleanUpDataWrapper</returns>
        AutoCleanUpDataWrapper ChangeAutomaticallyCleanUp(AutoCleanupRequestDto? autoCleanupRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autoCleanupRequestDto">The auto-clearing request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-automatically-clean-up/">REST API Reference for ChangeAutomaticallyCleanUp Operation</seealso>
        /// <returns>ApiResponse of AutoCleanUpDataWrapper</returns>
        ApiResponse<AutoCleanUpDataWrapper> ChangeAutomaticallyCleanUpWithHttpInfo(AutoCleanupRequestDto? autoCleanupRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">Sharing rights (None, ReadWrite, Read, Restrict, Varies, Review, Comment, FillForms, CustomFilter, RoomAdmin, Editing, Collaborator). (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-default-access-rights/">REST API Reference for ChangeDefaultAccessRights Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        FileShareArrayWrapper ChangeDefaultAccessRights(List<int>? requestBody = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">Sharing rights (None, ReadWrite, Read, Restrict, Varies, Review, Comment, FillForms, CustomFilter, RoomAdmin, Editing, Collaborator). (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-default-access-rights/">REST API Reference for ChangeDefaultAccessRights Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        ApiResponse<FileShareArrayWrapper> ChangeDefaultAccessRightsWithHttpInfo(List<int>? requestBody = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-delete-confirm/">REST API Reference for ChangeDeleteConfirm Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper ChangeDeleteConfirm(SettingsRequestDto? settingsRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-delete-confirm/">REST API Reference for ChangeDeleteConfirm Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> ChangeDeleteConfirmWithHttpInfo(SettingsRequestDto? settingsRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-download-zip-from-body/">REST API Reference for ChangeDownloadZipFromBody Operation</seealso>
        /// <returns>ICompressWrapper</returns>
        ICompressWrapper ChangeDownloadZipFromBody(DisplayRequestDto? displayRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-download-zip-from-body/">REST API Reference for ChangeDownloadZipFromBody Operation</seealso>
        /// <returns>ApiResponse of ICompressWrapper</returns>
        ApiResponse<ICompressWrapper> ChangeDownloadZipFromBodyWithHttpInfo(DisplayRequestDto? displayRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="checkDocServiceUrlRequestDto">The request parameters for checking the document service location. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-doc-service-url/">REST API Reference for CheckDocServiceUrl Operation</seealso>
        /// <returns>DocServiceUrlWrapper</returns>
        DocServiceUrlWrapper CheckDocServiceUrl(CheckDocServiceUrlRequestDto? checkDocServiceUrlRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="checkDocServiceUrlRequestDto">The request parameters for checking the document service location. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-doc-service-url/">REST API Reference for CheckDocServiceUrl Operation</seealso>
        /// <returns>ApiResponse of DocServiceUrlWrapper</returns>
        ApiResponse<DocServiceUrlWrapper> CheckDocServiceUrlWithHttpInfo(CheckDocServiceUrlRequestDto? checkDocServiceUrlRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/display-file-extension/">REST API Reference for DisplayFileExtension Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper DisplayFileExtension(SettingsRequestDto? settingsRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/display-file-extension/">REST API Reference for DisplayFileExtension Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> DisplayFileExtensionWithHttpInfo(SettingsRequestDto? settingsRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share/">REST API Reference for ExternalShare Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper ExternalShare(DisplayRequestDto? displayRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share/">REST API Reference for ExternalShare Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> ExternalShareWithHttpInfo(DisplayRequestDto? displayRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share-social-media/">REST API Reference for ExternalShareSocialMedia Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper ExternalShareSocialMedia(DisplayRequestDto? displayRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share-social-media/">REST API Reference for ExternalShareSocialMedia Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> ExternalShareSocialMediaWithHttpInfo(DisplayRequestDto? displayRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/forcesave/">REST API Reference for Forcesave Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper Forcesave();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/forcesave/">REST API Reference for Forcesave Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> ForcesaveWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-automatically-clean-up/">REST API Reference for GetAutomaticallyCleanUp Operation</seealso>
        /// <returns>AutoCleanUpDataWrapper</returns>
        AutoCleanUpDataWrapper GetAutomaticallyCleanUp();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-automatically-clean-up/">REST API Reference for GetAutomaticallyCleanUp Operation</seealso>
        /// <returns>ApiResponse of AutoCleanUpDataWrapper</returns>
        ApiResponse<AutoCleanUpDataWrapper> GetAutomaticallyCleanUpWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Specifies whether to return the editor version or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-doc-service-url/">REST API Reference for GetDocServiceUrl Operation</seealso>
        /// <returns>DocServiceUrlWrapper</returns>
        DocServiceUrlWrapper GetDocServiceUrl(bool? version = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Specifies whether to return the editor version or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-doc-service-url/">REST API Reference for GetDocServiceUrl Operation</seealso>
        /// <returns>ApiResponse of DocServiceUrlWrapper</returns>
        ApiResponse<DocServiceUrlWrapper> GetDocServiceUrlWithHttpInfo(bool? version = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-module/">REST API Reference for GetFilesModule Operation</seealso>
        /// <returns>ModuleWrapper</returns>
        ModuleWrapper GetFilesModule();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-module/">REST API Reference for GetFilesModule Operation</seealso>
        /// <returns>ApiResponse of ModuleWrapper</returns>
        ApiResponse<ModuleWrapper> GetFilesModuleWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-settings/">REST API Reference for GetFilesSettings Operation</seealso>
        /// <returns>FilesSettingsWrapper</returns>
        FilesSettingsWrapper GetFilesSettings();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-settings/">REST API Reference for GetFilesSettings Operation</seealso>
        /// <returns>ApiResponse of FilesSettingsWrapper</returns>
        ApiResponse<FilesSettingsWrapper> GetFilesSettingsWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-cancel-operation/">REST API Reference for HideConfirmCancelOperation Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper HideConfirmCancelOperation(SettingsRequestDto? settingsRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-cancel-operation/">REST API Reference for HideConfirmCancelOperation Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> HideConfirmCancelOperationWithHttpInfo(SettingsRequestDto? settingsRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hideConfirmConvertRequestDto">The request parameters for hiding the confirmation dialog when converting. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-convert/">REST API Reference for HideConfirmConvert Operation</seealso>
        /// <returns>ModuleWrapper</returns>
        ModuleWrapper HideConfirmConvert(HideConfirmConvertRequestDto? hideConfirmConvertRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hideConfirmConvertRequestDto">The request parameters for hiding the confirmation dialog when converting. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-convert/">REST API Reference for HideConfirmConvert Operation</seealso>
        /// <returns>ApiResponse of ModuleWrapper</returns>
        ApiResponse<ModuleWrapper> HideConfirmConvertWithHttpInfo(HideConfirmConvertRequestDto? hideConfirmConvertRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-room-lifetime/">REST API Reference for HideConfirmRoomLifetime Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper HideConfirmRoomLifetime(SettingsRequestDto? settingsRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-room-lifetime/">REST API Reference for HideConfirmRoomLifetime Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> HideConfirmRoomLifetimeWithHttpInfo(SettingsRequestDto? settingsRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-available-privacy-room-settings/">REST API Reference for IsAvailablePrivacyRoomSettings Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper IsAvailablePrivacyRoomSettings();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-available-privacy-room-settings/">REST API Reference for IsAvailablePrivacyRoomSettings Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> IsAvailablePrivacyRoomSettingsWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/keep-new-file-name/">REST API Reference for KeepNewFileName Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper KeepNewFileName(SettingsRequestDto? settingsRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/keep-new-file-name/">REST API Reference for KeepNewFileName Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> KeepNewFileNameWithHttpInfo(SettingsRequestDto? settingsRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-open-editor-in-same-tab/">REST API Reference for SetOpenEditorInSameTab Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper SetOpenEditorInSameTab(SettingsRequestDto? settingsRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-open-editor-in-same-tab/">REST API Reference for SetOpenEditorInSameTab Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> SetOpenEditorInSameTabWithHttpInfo(SettingsRequestDto? settingsRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-forcesave/">REST API Reference for StoreForcesave Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper StoreForcesave();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-forcesave/">REST API Reference for StoreForcesave Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> StoreForcesaveWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-original/">REST API Reference for StoreOriginal Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper StoreOriginal(SettingsRequestDto? settingsRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-original/">REST API Reference for StoreOriginal Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> StoreOriginalWithHttpInfo(SettingsRequestDto? settingsRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-if-exist/">REST API Reference for UpdateFileIfExist Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper UpdateFileIfExist(SettingsRequestDto? settingsRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-if-exist/">REST API Reference for UpdateFileIfExist Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> UpdateFileIfExistWithHttpInfo(SettingsRequestDto? settingsRequestDto = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-access-to-thirdparty/">REST API Reference for ChangeAccessToThirdparty Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> ChangeAccessToThirdpartyAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-access-to-thirdparty/">REST API Reference for ChangeAccessToThirdparty Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> ChangeAccessToThirdpartyWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autoCleanupRequestDto">The auto-clearing request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-automatically-clean-up/">REST API Reference for ChangeAutomaticallyCleanUp Operation</seealso>
        /// <returns>Task of AutoCleanUpDataWrapper</returns>
        Task<AutoCleanUpDataWrapper> ChangeAutomaticallyCleanUpAsync(AutoCleanupRequestDto? autoCleanupRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autoCleanupRequestDto">The auto-clearing request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-automatically-clean-up/">REST API Reference for ChangeAutomaticallyCleanUp Operation</seealso>
        /// <returns>Task of ApiResponse (AutoCleanUpDataWrapper)</returns>
        Task<ApiResponse<AutoCleanUpDataWrapper>> ChangeAutomaticallyCleanUpWithHttpInfoAsync(AutoCleanupRequestDto? autoCleanupRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">Sharing rights (None, ReadWrite, Read, Restrict, Varies, Review, Comment, FillForms, CustomFilter, RoomAdmin, Editing, Collaborator). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-default-access-rights/">REST API Reference for ChangeDefaultAccessRights Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        Task<FileShareArrayWrapper> ChangeDefaultAccessRightsAsync(List<int>? requestBody = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">Sharing rights (None, ReadWrite, Read, Restrict, Varies, Review, Comment, FillForms, CustomFilter, RoomAdmin, Editing, Collaborator). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-default-access-rights/">REST API Reference for ChangeDefaultAccessRights Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        Task<ApiResponse<FileShareArrayWrapper>> ChangeDefaultAccessRightsWithHttpInfoAsync(List<int>? requestBody = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-delete-confirm/">REST API Reference for ChangeDeleteConfirm Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> ChangeDeleteConfirmAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-delete-confirm/">REST API Reference for ChangeDeleteConfirm Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> ChangeDeleteConfirmWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-download-zip-from-body/">REST API Reference for ChangeDownloadZipFromBody Operation</seealso>
        /// <returns>Task of ICompressWrapper</returns>
        Task<ICompressWrapper> ChangeDownloadZipFromBodyAsync(DisplayRequestDto? displayRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-download-zip-from-body/">REST API Reference for ChangeDownloadZipFromBody Operation</seealso>
        /// <returns>Task of ApiResponse (ICompressWrapper)</returns>
        Task<ApiResponse<ICompressWrapper>> ChangeDownloadZipFromBodyWithHttpInfoAsync(DisplayRequestDto? displayRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="checkDocServiceUrlRequestDto">The request parameters for checking the document service location. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-doc-service-url/">REST API Reference for CheckDocServiceUrl Operation</seealso>
        /// <returns>Task of DocServiceUrlWrapper</returns>
        Task<DocServiceUrlWrapper> CheckDocServiceUrlAsync(CheckDocServiceUrlRequestDto? checkDocServiceUrlRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="checkDocServiceUrlRequestDto">The request parameters for checking the document service location. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-doc-service-url/">REST API Reference for CheckDocServiceUrl Operation</seealso>
        /// <returns>Task of ApiResponse (DocServiceUrlWrapper)</returns>
        Task<ApiResponse<DocServiceUrlWrapper>> CheckDocServiceUrlWithHttpInfoAsync(CheckDocServiceUrlRequestDto? checkDocServiceUrlRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/display-file-extension/">REST API Reference for DisplayFileExtension Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> DisplayFileExtensionAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/display-file-extension/">REST API Reference for DisplayFileExtension Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> DisplayFileExtensionWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share/">REST API Reference for ExternalShare Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> ExternalShareAsync(DisplayRequestDto? displayRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share/">REST API Reference for ExternalShare Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> ExternalShareWithHttpInfoAsync(DisplayRequestDto? displayRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share-social-media/">REST API Reference for ExternalShareSocialMedia Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> ExternalShareSocialMediaAsync(DisplayRequestDto? displayRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share-social-media/">REST API Reference for ExternalShareSocialMedia Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> ExternalShareSocialMediaWithHttpInfoAsync(DisplayRequestDto? displayRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/forcesave/">REST API Reference for Forcesave Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> ForcesaveAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/forcesave/">REST API Reference for Forcesave Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> ForcesaveWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-automatically-clean-up/">REST API Reference for GetAutomaticallyCleanUp Operation</seealso>
        /// <returns>Task of AutoCleanUpDataWrapper</returns>
        Task<AutoCleanUpDataWrapper> GetAutomaticallyCleanUpAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-automatically-clean-up/">REST API Reference for GetAutomaticallyCleanUp Operation</seealso>
        /// <returns>Task of ApiResponse (AutoCleanUpDataWrapper)</returns>
        Task<ApiResponse<AutoCleanUpDataWrapper>> GetAutomaticallyCleanUpWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Specifies whether to return the editor version or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-doc-service-url/">REST API Reference for GetDocServiceUrl Operation</seealso>
        /// <returns>Task of DocServiceUrlWrapper</returns>
        Task<DocServiceUrlWrapper> GetDocServiceUrlAsync(bool? version = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Specifies whether to return the editor version or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-doc-service-url/">REST API Reference for GetDocServiceUrl Operation</seealso>
        /// <returns>Task of ApiResponse (DocServiceUrlWrapper)</returns>
        Task<ApiResponse<DocServiceUrlWrapper>> GetDocServiceUrlWithHttpInfoAsync(bool? version = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-module/">REST API Reference for GetFilesModule Operation</seealso>
        /// <returns>Task of ModuleWrapper</returns>
        Task<ModuleWrapper> GetFilesModuleAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-module/">REST API Reference for GetFilesModule Operation</seealso>
        /// <returns>Task of ApiResponse (ModuleWrapper)</returns>
        Task<ApiResponse<ModuleWrapper>> GetFilesModuleWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-settings/">REST API Reference for GetFilesSettings Operation</seealso>
        /// <returns>Task of FilesSettingsWrapper</returns>
        Task<FilesSettingsWrapper> GetFilesSettingsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-settings/">REST API Reference for GetFilesSettings Operation</seealso>
        /// <returns>Task of ApiResponse (FilesSettingsWrapper)</returns>
        Task<ApiResponse<FilesSettingsWrapper>> GetFilesSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-cancel-operation/">REST API Reference for HideConfirmCancelOperation Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> HideConfirmCancelOperationAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-cancel-operation/">REST API Reference for HideConfirmCancelOperation Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> HideConfirmCancelOperationWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hideConfirmConvertRequestDto">The request parameters for hiding the confirmation dialog when converting. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-convert/">REST API Reference for HideConfirmConvert Operation</seealso>
        /// <returns>Task of ModuleWrapper</returns>
        Task<ModuleWrapper> HideConfirmConvertAsync(HideConfirmConvertRequestDto? hideConfirmConvertRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hideConfirmConvertRequestDto">The request parameters for hiding the confirmation dialog when converting. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-convert/">REST API Reference for HideConfirmConvert Operation</seealso>
        /// <returns>Task of ApiResponse (ModuleWrapper)</returns>
        Task<ApiResponse<ModuleWrapper>> HideConfirmConvertWithHttpInfoAsync(HideConfirmConvertRequestDto? hideConfirmConvertRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-room-lifetime/">REST API Reference for HideConfirmRoomLifetime Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> HideConfirmRoomLifetimeAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-room-lifetime/">REST API Reference for HideConfirmRoomLifetime Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> HideConfirmRoomLifetimeWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-available-privacy-room-settings/">REST API Reference for IsAvailablePrivacyRoomSettings Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> IsAvailablePrivacyRoomSettingsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-available-privacy-room-settings/">REST API Reference for IsAvailablePrivacyRoomSettings Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> IsAvailablePrivacyRoomSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/keep-new-file-name/">REST API Reference for KeepNewFileName Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> KeepNewFileNameAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/keep-new-file-name/">REST API Reference for KeepNewFileName Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> KeepNewFileNameWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-open-editor-in-same-tab/">REST API Reference for SetOpenEditorInSameTab Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> SetOpenEditorInSameTabAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-open-editor-in-same-tab/">REST API Reference for SetOpenEditorInSameTab Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> SetOpenEditorInSameTabWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-forcesave/">REST API Reference for StoreForcesave Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> StoreForcesaveAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-forcesave/">REST API Reference for StoreForcesave Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> StoreForcesaveWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-original/">REST API Reference for StoreOriginal Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> StoreOriginalAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-original/">REST API Reference for StoreOriginal Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> StoreOriginalWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-if-exist/">REST API Reference for UpdateFileIfExist Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> UpdateFileIfExistAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-if-exist/">REST API Reference for UpdateFileIfExist Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> UpdateFileIfExistWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsApi : ISettingsApiSync, ISettingsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SettingsApi : IDisposable, ISettingsApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public SettingsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public SettingsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="SettingsApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public SettingsApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="SettingsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public SettingsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsApi"/> class.
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
        public SettingsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="SettingsApi"/> class using a Configuration object.
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
        public SettingsApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="SettingsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SettingsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-access-to-thirdparty/">REST API Reference for ChangeAccessToThirdparty Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper ChangeAccessToThirdparty(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarResponse = ChangeAccessToThirdpartyWithHttpInfo(settingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-access-to-thirdparty/">REST API Reference for ChangeAccessToThirdparty Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> ChangeAccessToThirdpartyWithHttpInfo(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<BooleanWrapper>("/api/2.0/files/thirdparty", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangeAccessToThirdparty", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-access-to-thirdparty/">REST API Reference for ChangeAccessToThirdparty Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> ChangeAccessToThirdpartyAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ChangeAccessToThirdpartyWithHttpInfoAsync(settingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-access-to-thirdparty/">REST API Reference for ChangeAccessToThirdparty Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> ChangeAccessToThirdpartyWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/thirdparty", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangeAccessToThirdparty", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autoCleanupRequestDto">The auto-clearing request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-automatically-clean-up/">REST API Reference for ChangeAutomaticallyCleanUp Operation</seealso>
        /// <returns>AutoCleanUpDataWrapper</returns>
        public AutoCleanUpDataWrapper ChangeAutomaticallyCleanUp(AutoCleanupRequestDto? autoCleanupRequestDto = default)
        {
            var localVarResponse = ChangeAutomaticallyCleanUpWithHttpInfo(autoCleanupRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autoCleanupRequestDto">The auto-clearing request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-automatically-clean-up/">REST API Reference for ChangeAutomaticallyCleanUp Operation</seealso>
        /// <returns>ApiResponse of AutoCleanUpDataWrapper</returns>
        public ApiResponse<AutoCleanUpDataWrapper> ChangeAutomaticallyCleanUpWithHttpInfo(AutoCleanupRequestDto? autoCleanupRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (autoCleanupRequestDto != null) localVarRequestOptions.Data = autoCleanupRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<AutoCleanUpDataWrapper>("/api/2.0/files/settings/autocleanup", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangeAutomaticallyCleanUp", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autoCleanupRequestDto">The auto-clearing request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-automatically-clean-up/">REST API Reference for ChangeAutomaticallyCleanUp Operation</seealso>
        /// <returns>Task of AutoCleanUpDataWrapper</returns>
        public async Task<AutoCleanUpDataWrapper> ChangeAutomaticallyCleanUpAsync(AutoCleanupRequestDto? autoCleanupRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ChangeAutomaticallyCleanUpWithHttpInfoAsync(autoCleanupRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autoCleanupRequestDto">The auto-clearing request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-automatically-clean-up/">REST API Reference for ChangeAutomaticallyCleanUp Operation</seealso>
        /// <returns>Task of ApiResponse (AutoCleanUpDataWrapper)</returns>
        public async Task<ApiResponse<AutoCleanUpDataWrapper>> ChangeAutomaticallyCleanUpWithHttpInfoAsync(AutoCleanupRequestDto? autoCleanupRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (autoCleanupRequestDto != null) localVarRequestOptions.Data = autoCleanupRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<AutoCleanUpDataWrapper>("/api/2.0/files/settings/autocleanup", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangeAutomaticallyCleanUp", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">Sharing rights (None, ReadWrite, Read, Restrict, Varies, Review, Comment, FillForms, CustomFilter, RoomAdmin, Editing, Collaborator). (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-default-access-rights/">REST API Reference for ChangeDefaultAccessRights Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        public FileShareArrayWrapper ChangeDefaultAccessRights(List<int>? requestBody = default)
        {
            var localVarResponse = ChangeDefaultAccessRightsWithHttpInfo(requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">Sharing rights (None, ReadWrite, Read, Restrict, Varies, Review, Comment, FillForms, CustomFilter, RoomAdmin, Editing, Collaborator). (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-default-access-rights/">REST API Reference for ChangeDefaultAccessRights Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        public ApiResponse<FileShareArrayWrapper> ChangeDefaultAccessRightsWithHttpInfo(List<int>? requestBody = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (requestBody != null) localVarRequestOptions.Data = requestBody;


            // make the HTTP request
            var localVarResponse = Client.Put<FileShareArrayWrapper>("/api/2.0/files/settings/dafaultaccessrights", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangeDefaultAccessRights", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">Sharing rights (None, ReadWrite, Read, Restrict, Varies, Review, Comment, FillForms, CustomFilter, RoomAdmin, Editing, Collaborator). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-default-access-rights/">REST API Reference for ChangeDefaultAccessRights Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        public async Task<FileShareArrayWrapper> ChangeDefaultAccessRightsAsync(List<int>? requestBody = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ChangeDefaultAccessRightsWithHttpInfoAsync(requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">Sharing rights (None, ReadWrite, Read, Restrict, Varies, Review, Comment, FillForms, CustomFilter, RoomAdmin, Editing, Collaborator). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-default-access-rights/">REST API Reference for ChangeDefaultAccessRights Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        public async Task<ApiResponse<FileShareArrayWrapper>> ChangeDefaultAccessRightsWithHttpInfoAsync(List<int>? requestBody = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (requestBody != null) localVarRequestOptions.Data = requestBody;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileShareArrayWrapper>("/api/2.0/files/settings/dafaultaccessrights", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangeDefaultAccessRights", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-delete-confirm/">REST API Reference for ChangeDeleteConfirm Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper ChangeDeleteConfirm(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarResponse = ChangeDeleteConfirmWithHttpInfo(settingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-delete-confirm/">REST API Reference for ChangeDeleteConfirm Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> ChangeDeleteConfirmWithHttpInfo(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<BooleanWrapper>("/api/2.0/files/changedeleteconfrim", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangeDeleteConfirm", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-delete-confirm/">REST API Reference for ChangeDeleteConfirm Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> ChangeDeleteConfirmAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ChangeDeleteConfirmWithHttpInfoAsync(settingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-delete-confirm/">REST API Reference for ChangeDeleteConfirm Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> ChangeDeleteConfirmWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/changedeleteconfrim", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangeDeleteConfirm", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-download-zip-from-body/">REST API Reference for ChangeDownloadZipFromBody Operation</seealso>
        /// <returns>ICompressWrapper</returns>
        public ICompressWrapper ChangeDownloadZipFromBody(DisplayRequestDto? displayRequestDto = default)
        {
            var localVarResponse = ChangeDownloadZipFromBodyWithHttpInfo(displayRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-download-zip-from-body/">REST API Reference for ChangeDownloadZipFromBody Operation</seealso>
        /// <returns>ApiResponse of ICompressWrapper</returns>
        public ApiResponse<ICompressWrapper> ChangeDownloadZipFromBodyWithHttpInfo(DisplayRequestDto? displayRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (displayRequestDto != null) localVarRequestOptions.Data = displayRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<ICompressWrapper>("/api/2.0/files/settings/downloadtargz", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangeDownloadZipFromBody", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-download-zip-from-body/">REST API Reference for ChangeDownloadZipFromBody Operation</seealso>
        /// <returns>Task of ICompressWrapper</returns>
        public async Task<ICompressWrapper> ChangeDownloadZipFromBodyAsync(DisplayRequestDto? displayRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ChangeDownloadZipFromBodyWithHttpInfoAsync(displayRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-download-zip-from-body/">REST API Reference for ChangeDownloadZipFromBody Operation</seealso>
        /// <returns>Task of ApiResponse (ICompressWrapper)</returns>
        public async Task<ApiResponse<ICompressWrapper>> ChangeDownloadZipFromBodyWithHttpInfoAsync(DisplayRequestDto? displayRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (displayRequestDto != null) localVarRequestOptions.Data = displayRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<ICompressWrapper>("/api/2.0/files/settings/downloadtargz", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangeDownloadZipFromBody", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="checkDocServiceUrlRequestDto">The request parameters for checking the document service location. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-doc-service-url/">REST API Reference for CheckDocServiceUrl Operation</seealso>
        /// <returns>DocServiceUrlWrapper</returns>
        public DocServiceUrlWrapper CheckDocServiceUrl(CheckDocServiceUrlRequestDto? checkDocServiceUrlRequestDto = default)
        {
            var localVarResponse = CheckDocServiceUrlWithHttpInfo(checkDocServiceUrlRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="checkDocServiceUrlRequestDto">The request parameters for checking the document service location. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-doc-service-url/">REST API Reference for CheckDocServiceUrl Operation</seealso>
        /// <returns>ApiResponse of DocServiceUrlWrapper</returns>
        public ApiResponse<DocServiceUrlWrapper> CheckDocServiceUrlWithHttpInfo(CheckDocServiceUrlRequestDto? checkDocServiceUrlRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (checkDocServiceUrlRequestDto != null) localVarRequestOptions.Data = checkDocServiceUrlRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<DocServiceUrlWrapper>("/api/2.0/files/docservice", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CheckDocServiceUrl", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="checkDocServiceUrlRequestDto">The request parameters for checking the document service location. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-doc-service-url/">REST API Reference for CheckDocServiceUrl Operation</seealso>
        /// <returns>Task of DocServiceUrlWrapper</returns>
        public async Task<DocServiceUrlWrapper> CheckDocServiceUrlAsync(CheckDocServiceUrlRequestDto? checkDocServiceUrlRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CheckDocServiceUrlWithHttpInfoAsync(checkDocServiceUrlRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="checkDocServiceUrlRequestDto">The request parameters for checking the document service location. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-doc-service-url/">REST API Reference for CheckDocServiceUrl Operation</seealso>
        /// <returns>Task of ApiResponse (DocServiceUrlWrapper)</returns>
        public async Task<ApiResponse<DocServiceUrlWrapper>> CheckDocServiceUrlWithHttpInfoAsync(CheckDocServiceUrlRequestDto? checkDocServiceUrlRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (checkDocServiceUrlRequestDto != null) localVarRequestOptions.Data = checkDocServiceUrlRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<DocServiceUrlWrapper>("/api/2.0/files/docservice", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CheckDocServiceUrl", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/display-file-extension/">REST API Reference for DisplayFileExtension Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper DisplayFileExtension(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarResponse = DisplayFileExtensionWithHttpInfo(settingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/display-file-extension/">REST API Reference for DisplayFileExtension Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> DisplayFileExtensionWithHttpInfo(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<BooleanWrapper>("/api/2.0/files/displayfileextension", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DisplayFileExtension", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/display-file-extension/">REST API Reference for DisplayFileExtension Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> DisplayFileExtensionAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DisplayFileExtensionWithHttpInfoAsync(settingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/display-file-extension/">REST API Reference for DisplayFileExtension Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> DisplayFileExtensionWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/displayfileextension", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DisplayFileExtension", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share/">REST API Reference for ExternalShare Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper ExternalShare(DisplayRequestDto? displayRequestDto = default)
        {
            var localVarResponse = ExternalShareWithHttpInfo(displayRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share/">REST API Reference for ExternalShare Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> ExternalShareWithHttpInfo(DisplayRequestDto? displayRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (displayRequestDto != null) localVarRequestOptions.Data = displayRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<BooleanWrapper>("/api/2.0/files/settings/external", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ExternalShare", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share/">REST API Reference for ExternalShare Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> ExternalShareAsync(DisplayRequestDto? displayRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ExternalShareWithHttpInfoAsync(displayRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share/">REST API Reference for ExternalShare Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> ExternalShareWithHttpInfoAsync(DisplayRequestDto? displayRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (displayRequestDto != null) localVarRequestOptions.Data = displayRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/settings/external", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ExternalShare", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share-social-media/">REST API Reference for ExternalShareSocialMedia Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper ExternalShareSocialMedia(DisplayRequestDto? displayRequestDto = default)
        {
            var localVarResponse = ExternalShareSocialMediaWithHttpInfo(displayRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share-social-media/">REST API Reference for ExternalShareSocialMedia Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> ExternalShareSocialMediaWithHttpInfo(DisplayRequestDto? displayRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (displayRequestDto != null) localVarRequestOptions.Data = displayRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<BooleanWrapper>("/api/2.0/files/settings/externalsocialmedia", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ExternalShareSocialMedia", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share-social-media/">REST API Reference for ExternalShareSocialMedia Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> ExternalShareSocialMediaAsync(DisplayRequestDto? displayRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ExternalShareSocialMediaWithHttpInfoAsync(displayRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share-social-media/">REST API Reference for ExternalShareSocialMedia Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> ExternalShareSocialMediaWithHttpInfoAsync(DisplayRequestDto? displayRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (displayRequestDto != null) localVarRequestOptions.Data = displayRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/settings/externalsocialmedia", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ExternalShareSocialMedia", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/forcesave/">REST API Reference for Forcesave Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper Forcesave()
        {
            var localVarResponse = ForcesaveWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/forcesave/">REST API Reference for Forcesave Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> ForcesaveWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = Client.Put<BooleanWrapper>("/api/2.0/files/forcesave", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("Forcesave", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/forcesave/">REST API Reference for Forcesave Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> ForcesaveAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ForcesaveWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/forcesave/">REST API Reference for Forcesave Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> ForcesaveWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/forcesave", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("Forcesave", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-automatically-clean-up/">REST API Reference for GetAutomaticallyCleanUp Operation</seealso>
        /// <returns>AutoCleanUpDataWrapper</returns>
        public AutoCleanUpDataWrapper GetAutomaticallyCleanUp()
        {
            var localVarResponse = GetAutomaticallyCleanUpWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-automatically-clean-up/">REST API Reference for GetAutomaticallyCleanUp Operation</seealso>
        /// <returns>ApiResponse of AutoCleanUpDataWrapper</returns>
        public ApiResponse<AutoCleanUpDataWrapper> GetAutomaticallyCleanUpWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = Client.Get<AutoCleanUpDataWrapper>("/api/2.0/files/settings/autocleanup", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAutomaticallyCleanUp", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-automatically-clean-up/">REST API Reference for GetAutomaticallyCleanUp Operation</seealso>
        /// <returns>Task of AutoCleanUpDataWrapper</returns>
        public async Task<AutoCleanUpDataWrapper> GetAutomaticallyCleanUpAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAutomaticallyCleanUpWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-automatically-clean-up/">REST API Reference for GetAutomaticallyCleanUp Operation</seealso>
        /// <returns>Task of ApiResponse (AutoCleanUpDataWrapper)</returns>
        public async Task<ApiResponse<AutoCleanUpDataWrapper>> GetAutomaticallyCleanUpWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<AutoCleanUpDataWrapper>("/api/2.0/files/settings/autocleanup", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAutomaticallyCleanUp", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Specifies whether to return the editor version or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-doc-service-url/">REST API Reference for GetDocServiceUrl Operation</seealso>
        /// <returns>DocServiceUrlWrapper</returns>
        public DocServiceUrlWrapper GetDocServiceUrl(bool? version = default)
        {
            var localVarResponse = GetDocServiceUrlWithHttpInfo(version);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Specifies whether to return the editor version or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-doc-service-url/">REST API Reference for GetDocServiceUrl Operation</seealso>
        /// <returns>ApiResponse of DocServiceUrlWrapper</returns>
        public ApiResponse<DocServiceUrlWrapper> GetDocServiceUrlWithHttpInfo(bool? version = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (version != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "version", version));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<DocServiceUrlWrapper>("/api/2.0/files/docservice", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetDocServiceUrl", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Specifies whether to return the editor version or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-doc-service-url/">REST API Reference for GetDocServiceUrl Operation</seealso>
        /// <returns>Task of DocServiceUrlWrapper</returns>
        public async Task<DocServiceUrlWrapper> GetDocServiceUrlAsync(bool? version = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetDocServiceUrlWithHttpInfoAsync(version, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Specifies whether to return the editor version or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-doc-service-url/">REST API Reference for GetDocServiceUrl Operation</seealso>
        /// <returns>Task of ApiResponse (DocServiceUrlWrapper)</returns>
        public async Task<ApiResponse<DocServiceUrlWrapper>> GetDocServiceUrlWithHttpInfoAsync(bool? version = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (version != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "version", version));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<DocServiceUrlWrapper>("/api/2.0/files/docservice", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetDocServiceUrl", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-module/">REST API Reference for GetFilesModule Operation</seealso>
        /// <returns>ModuleWrapper</returns>
        public ModuleWrapper GetFilesModule()
        {
            var localVarResponse = GetFilesModuleWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-module/">REST API Reference for GetFilesModule Operation</seealso>
        /// <returns>ApiResponse of ModuleWrapper</returns>
        public ApiResponse<ModuleWrapper> GetFilesModuleWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = Client.Get<ModuleWrapper>("/api/2.0/files/info", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFilesModule", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-module/">REST API Reference for GetFilesModule Operation</seealso>
        /// <returns>Task of ModuleWrapper</returns>
        public async Task<ModuleWrapper> GetFilesModuleAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetFilesModuleWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-module/">REST API Reference for GetFilesModule Operation</seealso>
        /// <returns>Task of ApiResponse (ModuleWrapper)</returns>
        public async Task<ApiResponse<ModuleWrapper>> GetFilesModuleWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<ModuleWrapper>("/api/2.0/files/info", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFilesModule", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-settings/">REST API Reference for GetFilesSettings Operation</seealso>
        /// <returns>FilesSettingsWrapper</returns>
        public FilesSettingsWrapper GetFilesSettings()
        {
            var localVarResponse = GetFilesSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-settings/">REST API Reference for GetFilesSettings Operation</seealso>
        /// <returns>ApiResponse of FilesSettingsWrapper</returns>
        public ApiResponse<FilesSettingsWrapper> GetFilesSettingsWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = Client.Get<FilesSettingsWrapper>("/api/2.0/files/settings", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFilesSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-settings/">REST API Reference for GetFilesSettings Operation</seealso>
        /// <returns>Task of FilesSettingsWrapper</returns>
        public async Task<FilesSettingsWrapper> GetFilesSettingsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetFilesSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-settings/">REST API Reference for GetFilesSettings Operation</seealso>
        /// <returns>Task of ApiResponse (FilesSettingsWrapper)</returns>
        public async Task<ApiResponse<FilesSettingsWrapper>> GetFilesSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<FilesSettingsWrapper>("/api/2.0/files/settings", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFilesSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-cancel-operation/">REST API Reference for HideConfirmCancelOperation Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper HideConfirmCancelOperation(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarResponse = HideConfirmCancelOperationWithHttpInfo(settingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-cancel-operation/">REST API Reference for HideConfirmCancelOperation Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> HideConfirmCancelOperationWithHttpInfo(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<BooleanWrapper>("/api/2.0/files/hideconfirmcanceloperation", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("HideConfirmCancelOperation", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-cancel-operation/">REST API Reference for HideConfirmCancelOperation Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> HideConfirmCancelOperationAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await HideConfirmCancelOperationWithHttpInfoAsync(settingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-cancel-operation/">REST API Reference for HideConfirmCancelOperation Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> HideConfirmCancelOperationWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/hideconfirmcanceloperation", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("HideConfirmCancelOperation", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hideConfirmConvertRequestDto">The request parameters for hiding the confirmation dialog when converting. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-convert/">REST API Reference for HideConfirmConvert Operation</seealso>
        /// <returns>ModuleWrapper</returns>
        public ModuleWrapper HideConfirmConvert(HideConfirmConvertRequestDto? hideConfirmConvertRequestDto = default)
        {
            var localVarResponse = HideConfirmConvertWithHttpInfo(hideConfirmConvertRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hideConfirmConvertRequestDto">The request parameters for hiding the confirmation dialog when converting. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-convert/">REST API Reference for HideConfirmConvert Operation</seealso>
        /// <returns>ApiResponse of ModuleWrapper</returns>
        public ApiResponse<ModuleWrapper> HideConfirmConvertWithHttpInfo(HideConfirmConvertRequestDto? hideConfirmConvertRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (hideConfirmConvertRequestDto != null) localVarRequestOptions.Data = hideConfirmConvertRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<ModuleWrapper>("/api/2.0/files/hideconfirmconvert", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("HideConfirmConvert", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hideConfirmConvertRequestDto">The request parameters for hiding the confirmation dialog when converting. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-convert/">REST API Reference for HideConfirmConvert Operation</seealso>
        /// <returns>Task of ModuleWrapper</returns>
        public async Task<ModuleWrapper> HideConfirmConvertAsync(HideConfirmConvertRequestDto? hideConfirmConvertRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await HideConfirmConvertWithHttpInfoAsync(hideConfirmConvertRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hideConfirmConvertRequestDto">The request parameters for hiding the confirmation dialog when converting. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-convert/">REST API Reference for HideConfirmConvert Operation</seealso>
        /// <returns>Task of ApiResponse (ModuleWrapper)</returns>
        public async Task<ApiResponse<ModuleWrapper>> HideConfirmConvertWithHttpInfoAsync(HideConfirmConvertRequestDto? hideConfirmConvertRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (hideConfirmConvertRequestDto != null) localVarRequestOptions.Data = hideConfirmConvertRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<ModuleWrapper>("/api/2.0/files/hideconfirmconvert", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("HideConfirmConvert", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-room-lifetime/">REST API Reference for HideConfirmRoomLifetime Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper HideConfirmRoomLifetime(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarResponse = HideConfirmRoomLifetimeWithHttpInfo(settingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-room-lifetime/">REST API Reference for HideConfirmRoomLifetime Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> HideConfirmRoomLifetimeWithHttpInfo(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<BooleanWrapper>("/api/2.0/files/hideconfirmroomlifetime", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("HideConfirmRoomLifetime", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-room-lifetime/">REST API Reference for HideConfirmRoomLifetime Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> HideConfirmRoomLifetimeAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await HideConfirmRoomLifetimeWithHttpInfoAsync(settingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-room-lifetime/">REST API Reference for HideConfirmRoomLifetime Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> HideConfirmRoomLifetimeWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/hideconfirmroomlifetime", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("HideConfirmRoomLifetime", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-available-privacy-room-settings/">REST API Reference for IsAvailablePrivacyRoomSettings Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper IsAvailablePrivacyRoomSettings()
        {
            var localVarResponse = IsAvailablePrivacyRoomSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-available-privacy-room-settings/">REST API Reference for IsAvailablePrivacyRoomSettings Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> IsAvailablePrivacyRoomSettingsWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = Client.Get<BooleanWrapper>("/api/2.0/files/@privacy/available", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("IsAvailablePrivacyRoomSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-available-privacy-room-settings/">REST API Reference for IsAvailablePrivacyRoomSettings Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> IsAvailablePrivacyRoomSettingsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await IsAvailablePrivacyRoomSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-available-privacy-room-settings/">REST API Reference for IsAvailablePrivacyRoomSettings Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> IsAvailablePrivacyRoomSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<BooleanWrapper>("/api/2.0/files/@privacy/available", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("IsAvailablePrivacyRoomSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/keep-new-file-name/">REST API Reference for KeepNewFileName Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper KeepNewFileName(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarResponse = KeepNewFileNameWithHttpInfo(settingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/keep-new-file-name/">REST API Reference for KeepNewFileName Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> KeepNewFileNameWithHttpInfo(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<BooleanWrapper>("/api/2.0/files/keepnewfilename", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("KeepNewFileName", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/keep-new-file-name/">REST API Reference for KeepNewFileName Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> KeepNewFileNameAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await KeepNewFileNameWithHttpInfoAsync(settingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/keep-new-file-name/">REST API Reference for KeepNewFileName Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> KeepNewFileNameWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/keepnewfilename", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("KeepNewFileName", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-open-editor-in-same-tab/">REST API Reference for SetOpenEditorInSameTab Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper SetOpenEditorInSameTab(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarResponse = SetOpenEditorInSameTabWithHttpInfo(settingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-open-editor-in-same-tab/">REST API Reference for SetOpenEditorInSameTab Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> SetOpenEditorInSameTabWithHttpInfo(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<BooleanWrapper>("/api/2.0/files/settings/openeditorinsametab", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetOpenEditorInSameTab", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-open-editor-in-same-tab/">REST API Reference for SetOpenEditorInSameTab Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> SetOpenEditorInSameTabAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetOpenEditorInSameTabWithHttpInfoAsync(settingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-open-editor-in-same-tab/">REST API Reference for SetOpenEditorInSameTab Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> SetOpenEditorInSameTabWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/settings/openeditorinsametab", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetOpenEditorInSameTab", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-forcesave/">REST API Reference for StoreForcesave Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper StoreForcesave()
        {
            var localVarResponse = StoreForcesaveWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-forcesave/">REST API Reference for StoreForcesave Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> StoreForcesaveWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = Client.Put<BooleanWrapper>("/api/2.0/files/storeforcesave", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("StoreForcesave", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-forcesave/">REST API Reference for StoreForcesave Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> StoreForcesaveAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await StoreForcesaveWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-forcesave/">REST API Reference for StoreForcesave Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> StoreForcesaveWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/storeforcesave", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("StoreForcesave", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-original/">REST API Reference for StoreOriginal Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper StoreOriginal(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarResponse = StoreOriginalWithHttpInfo(settingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-original/">REST API Reference for StoreOriginal Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> StoreOriginalWithHttpInfo(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<BooleanWrapper>("/api/2.0/files/storeoriginal", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("StoreOriginal", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-original/">REST API Reference for StoreOriginal Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> StoreOriginalAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await StoreOriginalWithHttpInfoAsync(settingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-original/">REST API Reference for StoreOriginal Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> StoreOriginalWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/storeoriginal", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("StoreOriginal", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-if-exist/">REST API Reference for UpdateFileIfExist Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper UpdateFileIfExist(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarResponse = UpdateFileIfExistWithHttpInfo(settingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-if-exist/">REST API Reference for UpdateFileIfExist Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> UpdateFileIfExistWithHttpInfo(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<BooleanWrapper>("/api/2.0/files/updateifexist", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateFileIfExist", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-if-exist/">REST API Reference for UpdateFileIfExist Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> UpdateFileIfExistAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateFileIfExistWithHttpInfoAsync(settingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-if-exist/">REST API Reference for UpdateFileIfExist Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> UpdateFileIfExistWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/updateifexist", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateFileIfExist", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
