// (c) Copyright Ascensio System SIA 2009-2025
// 
// This program is a free software product.
// You can redistribute it and/or modify it under the terms
// of the GNU Affero General Public License (AGPL) version 3 as published by the Free Software
// Foundation. In accordance with Section 7(a) of the GNU AGPL its Section 15 shall be amended
// to the effect that Ascensio System SIA expressly excludes the warranty of non-infringement of
// any third-party rights.
// 
// This program is distributed WITHOUT ANY WARRANTY, without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR  PURPOSE. For details, see
// the GNU AGPL at: http://www.gnu.org/licenses/agpl-3.0.html
// 
// You can contact Ascensio System SIA at Lubanas st. 125a-25, Riga, Latvia, EU, LV-1021.
// 
// The  interactive user interfaces in modified source and object code versions of the Program must
// display Appropriate Legal Notices, as required under Section 5 of the GNU AGPL version 3.
// 
// Pursuant to Section 7(b) of the License you must retain the original Product logo when
// distributing the program. Pursuant to Section 7(e) we decline to grant you any rights under
// trademark law for use of our trademarks.
// 
// All the Product's GUI elements, including illustrations and icon sets, as well as technical writing
// content are licensed under the terms of the Creative Commons Attribution-ShareAlike 4.0
// International. See the License terms at http://creativecommons.org/licenses/by-sa/4.0/legalcode


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using DocSpace.Client;
using DocSpace.Model;

namespace DocSpace.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFilesSettingsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Change the third-party settings access
        /// </summary>
        /// <remarks>
        /// Changes the access to the third-party settings.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-access-to-thirdparty/">REST API Reference for ChangeAccessToThirdparty Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper ChangeAccessToThirdparty(SettingsRequestDto? settingsRequestDto = default);

        /// <summary>
        /// Change the third-party settings access
        /// </summary>
        /// <remarks>
        /// Changes the access to the third-party settings.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-access-to-thirdparty/">REST API Reference for ChangeAccessToThirdparty Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> ChangeAccessToThirdpartyWithHttpInfo(SettingsRequestDto? settingsRequestDto = default);
        /// <summary>
        /// Update the trash bin auto-clearing setting
        /// </summary>
        /// <remarks>
        /// Updates the trash bin auto-clearing setting.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autoCleanupRequestDto">The auto-clearing request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-automatically-clean-up/">REST API Reference for ChangeAutomaticallyCleanUp Operation</seealso>
        /// <returns>AutoCleanUpDataWrapper</returns>
        AutoCleanUpDataWrapper ChangeAutomaticallyCleanUp(AutoCleanupRequestDto? autoCleanupRequestDto = default);

        /// <summary>
        /// Update the trash bin auto-clearing setting
        /// </summary>
        /// <remarks>
        /// Updates the trash bin auto-clearing setting.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autoCleanupRequestDto">The auto-clearing request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-automatically-clean-up/">REST API Reference for ChangeAutomaticallyCleanUp Operation</seealso>
        /// <returns>ApiResponse of AutoCleanUpDataWrapper</returns>
        ApiResponse<AutoCleanUpDataWrapper> ChangeAutomaticallyCleanUpWithHttpInfo(AutoCleanupRequestDto? autoCleanupRequestDto = default);
        /// <summary>
        /// Change the default access rights
        /// </summary>
        /// <remarks>
        /// Changes the default access rights in the sharing settings.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">Sharing rights (None, ReadWrite, Read, Restrict, Varies, Review, Comment, FillForms, CustomFilter, RoomAdmin, Editing, Collaborator). (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-default-access-rights/">REST API Reference for ChangeDefaultAccessRights Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        FileShareArrayWrapper ChangeDefaultAccessRights(List<int>? requestBody = default);

        /// <summary>
        /// Change the default access rights
        /// </summary>
        /// <remarks>
        /// Changes the default access rights in the sharing settings.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">Sharing rights (None, ReadWrite, Read, Restrict, Varies, Review, Comment, FillForms, CustomFilter, RoomAdmin, Editing, Collaborator). (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-default-access-rights/">REST API Reference for ChangeDefaultAccessRights Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        ApiResponse<FileShareArrayWrapper> ChangeDefaultAccessRightsWithHttpInfo(List<int>? requestBody = default);
        /// <summary>
        /// Confirm the file deletion
        /// </summary>
        /// <remarks>
        /// Specifies whether to confirm the file deletion or not.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-delete-confirm/">REST API Reference for ChangeDeleteConfirm Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper ChangeDeleteConfirm(SettingsRequestDto? settingsRequestDto = default);

        /// <summary>
        /// Confirm the file deletion
        /// </summary>
        /// <remarks>
        /// Specifies whether to confirm the file deletion or not.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-delete-confirm/">REST API Reference for ChangeDeleteConfirm Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> ChangeDeleteConfirmWithHttpInfo(SettingsRequestDto? settingsRequestDto = default);
        /// <summary>
        /// Change the archive format (using body parameters)
        /// </summary>
        /// <remarks>
        /// Changes the format of the downloaded archive from .zip to .tar.gz. This method uses the body parameters.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-download-zip-from-body/">REST API Reference for ChangeDownloadZipFromBody Operation</seealso>
        /// <returns>ICompressWrapper</returns>
        ICompressWrapper ChangeDownloadZipFromBody(DisplayRequestDto? displayRequestDto = default);

        /// <summary>
        /// Change the archive format (using body parameters)
        /// </summary>
        /// <remarks>
        /// Changes the format of the downloaded archive from .zip to .tar.gz. This method uses the body parameters.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-download-zip-from-body/">REST API Reference for ChangeDownloadZipFromBody Operation</seealso>
        /// <returns>ApiResponse of ICompressWrapper</returns>
        ApiResponse<ICompressWrapper> ChangeDownloadZipFromBodyWithHttpInfo(DisplayRequestDto? displayRequestDto = default);
        /// <summary>
        /// Check the document service URL
        /// </summary>
        /// <remarks>
        /// Checks the document service location URL.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="checkDocServiceUrlRequestDto">The request parameters for checking the document service location. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-doc-service-url/">REST API Reference for CheckDocServiceUrl Operation</seealso>
        /// <returns>DocServiceUrlWrapper</returns>
        DocServiceUrlWrapper CheckDocServiceUrl(CheckDocServiceUrlRequestDto? checkDocServiceUrlRequestDto = default);

        /// <summary>
        /// Check the document service URL
        /// </summary>
        /// <remarks>
        /// Checks the document service location URL.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="checkDocServiceUrlRequestDto">The request parameters for checking the document service location. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-doc-service-url/">REST API Reference for CheckDocServiceUrl Operation</seealso>
        /// <returns>ApiResponse of DocServiceUrlWrapper</returns>
        ApiResponse<DocServiceUrlWrapper> CheckDocServiceUrlWithHttpInfo(CheckDocServiceUrlRequestDto? checkDocServiceUrlRequestDto = default);
        /// <summary>
        /// Display a file extension
        /// </summary>
        /// <remarks>
        /// Specifies whether to display a file extension or not.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/display-file-extension/">REST API Reference for DisplayFileExtension Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper DisplayFileExtension(SettingsRequestDto? settingsRequestDto = default);

        /// <summary>
        /// Display a file extension
        /// </summary>
        /// <remarks>
        /// Specifies whether to display a file extension or not.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/display-file-extension/">REST API Reference for DisplayFileExtension Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> DisplayFileExtensionWithHttpInfo(SettingsRequestDto? settingsRequestDto = default);
        /// <summary>
        /// Change the external sharing ability
        /// </summary>
        /// <remarks>
        /// Changes the ability to share a file externally.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share/">REST API Reference for ExternalShare Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper ExternalShare(DisplayRequestDto? displayRequestDto = default);

        /// <summary>
        /// Change the external sharing ability
        /// </summary>
        /// <remarks>
        /// Changes the ability to share a file externally.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share/">REST API Reference for ExternalShare Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> ExternalShareWithHttpInfo(DisplayRequestDto? displayRequestDto = default);
        /// <summary>
        /// Change the external sharing ability on social networks
        /// </summary>
        /// <remarks>
        /// Changes the ability to share a file externally on social networks.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share-social-media/">REST API Reference for ExternalShareSocialMedia Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper ExternalShareSocialMedia(DisplayRequestDto? displayRequestDto = default);

        /// <summary>
        /// Change the external sharing ability on social networks
        /// </summary>
        /// <remarks>
        /// Changes the ability to share a file externally on social networks.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share-social-media/">REST API Reference for ExternalShareSocialMedia Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> ExternalShareSocialMediaWithHttpInfo(DisplayRequestDto? displayRequestDto = default);
        /// <summary>
        /// Change the forcesaving ability
        /// </summary>
        /// <remarks>
        /// Specifies if the file forcesaving is enabled or not.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/forcesave/">REST API Reference for Forcesave Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper Forcesave();

        /// <summary>
        /// Change the forcesaving ability
        /// </summary>
        /// <remarks>
        /// Specifies if the file forcesaving is enabled or not.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/forcesave/">REST API Reference for Forcesave Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> ForcesaveWithHttpInfo();
        /// <summary>
        /// Get the trash bin auto-clearing setting
        /// </summary>
        /// <remarks>
        /// Returns the trash bin auto-clearing setting.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-automatically-clean-up/">REST API Reference for GetAutomaticallyCleanUp Operation</seealso>
        /// <returns>AutoCleanUpDataWrapper</returns>
        AutoCleanUpDataWrapper GetAutomaticallyCleanUp();

        /// <summary>
        /// Get the trash bin auto-clearing setting
        /// </summary>
        /// <remarks>
        /// Returns the trash bin auto-clearing setting.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-automatically-clean-up/">REST API Reference for GetAutomaticallyCleanUp Operation</seealso>
        /// <returns>ApiResponse of AutoCleanUpDataWrapper</returns>
        ApiResponse<AutoCleanUpDataWrapper> GetAutomaticallyCleanUpWithHttpInfo();
        /// <summary>
        /// Get the document service URL
        /// </summary>
        /// <remarks>
        /// Returns the URL address of the connected editors.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Specifies whether to return the editor version or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-doc-service-url/">REST API Reference for GetDocServiceUrl Operation</seealso>
        /// <returns>DocServiceUrlWrapper</returns>
        DocServiceUrlWrapper GetDocServiceUrl(bool? version = default);

        /// <summary>
        /// Get the document service URL
        /// </summary>
        /// <remarks>
        /// Returns the URL address of the connected editors.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Specifies whether to return the editor version or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-doc-service-url/">REST API Reference for GetDocServiceUrl Operation</seealso>
        /// <returns>ApiResponse of DocServiceUrlWrapper</returns>
        ApiResponse<DocServiceUrlWrapper> GetDocServiceUrlWithHttpInfo(bool? version = default);
        /// <summary>
        /// Get the \&quot;Documents\&quot; information
        /// </summary>
        /// <remarks>
        /// Returns the information about the \&quot;Documents\&quot; module.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-module/">REST API Reference for GetFilesModule Operation</seealso>
        /// <returns>ModuleWrapper</returns>
        ModuleWrapper GetFilesModule();

        /// <summary>
        /// Get the \&quot;Documents\&quot; information
        /// </summary>
        /// <remarks>
        /// Returns the information about the \&quot;Documents\&quot; module.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-module/">REST API Reference for GetFilesModule Operation</seealso>
        /// <returns>ApiResponse of ModuleWrapper</returns>
        ApiResponse<ModuleWrapper> GetFilesModuleWithHttpInfo();
        /// <summary>
        /// Get file settings
        /// </summary>
        /// <remarks>
        /// Returns all the file settings.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-settings/">REST API Reference for GetFilesSettings Operation</seealso>
        /// <returns>FilesSettingsWrapper</returns>
        FilesSettingsWrapper GetFilesSettings();

        /// <summary>
        /// Get file settings
        /// </summary>
        /// <remarks>
        /// Returns all the file settings.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-settings/">REST API Reference for GetFilesSettings Operation</seealso>
        /// <returns>ApiResponse of FilesSettingsWrapper</returns>
        ApiResponse<FilesSettingsWrapper> GetFilesSettingsWithHttpInfo();
        /// <summary>
        /// Hide confirmation dialog when canceling operations
        /// </summary>
        /// <remarks>
        /// Hides the confirmation dialog when canceling operations.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-cancel-operation/">REST API Reference for HideConfirmCancelOperation Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper HideConfirmCancelOperation(SettingsRequestDto? settingsRequestDto = default);

        /// <summary>
        /// Hide confirmation dialog when canceling operations
        /// </summary>
        /// <remarks>
        /// Hides the confirmation dialog when canceling operations.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-cancel-operation/">REST API Reference for HideConfirmCancelOperation Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> HideConfirmCancelOperationWithHttpInfo(SettingsRequestDto? settingsRequestDto = default);
        /// <summary>
        /// Hide the confirmation dialog when converting
        /// </summary>
        /// <remarks>
        /// Hides the confirmation dialog for saving the file copy in the original format when converting a file.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hideConfirmConvertRequestDto">The request parameters for hiding the confirmation dialog when converting. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-convert/">REST API Reference for HideConfirmConvert Operation</seealso>
        /// <returns>ModuleWrapper</returns>
        ModuleWrapper HideConfirmConvert(HideConfirmConvertRequestDto? hideConfirmConvertRequestDto = default);

        /// <summary>
        /// Hide the confirmation dialog when converting
        /// </summary>
        /// <remarks>
        /// Hides the confirmation dialog for saving the file copy in the original format when converting a file.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hideConfirmConvertRequestDto">The request parameters for hiding the confirmation dialog when converting. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-convert/">REST API Reference for HideConfirmConvert Operation</seealso>
        /// <returns>ApiResponse of ModuleWrapper</returns>
        ApiResponse<ModuleWrapper> HideConfirmConvertWithHttpInfo(HideConfirmConvertRequestDto? hideConfirmConvertRequestDto = default);
        /// <summary>
        /// Hide confirmation dialog when changing room lifetime settings
        /// </summary>
        /// <remarks>
        /// Hides the confirmation dialog when changing the room lifetime settings.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-room-lifetime/">REST API Reference for HideConfirmRoomLifetime Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper HideConfirmRoomLifetime(SettingsRequestDto? settingsRequestDto = default);

        /// <summary>
        /// Hide confirmation dialog when changing room lifetime settings
        /// </summary>
        /// <remarks>
        /// Hides the confirmation dialog when changing the room lifetime settings.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-room-lifetime/">REST API Reference for HideConfirmRoomLifetime Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> HideConfirmRoomLifetimeWithHttpInfo(SettingsRequestDto? settingsRequestDto = default);
        /// <summary>
        /// Check the \&quot;Private Room\&quot; availability
        /// </summary>
        /// <remarks>
        /// Checks if the \&quot;Private Room\&quot; settings are available or not.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-available-privacy-room-settings/">REST API Reference for IsAvailablePrivacyRoomSettings Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper IsAvailablePrivacyRoomSettings();

        /// <summary>
        /// Check the \&quot;Private Room\&quot; availability
        /// </summary>
        /// <remarks>
        /// Checks if the \&quot;Private Room\&quot; settings are available or not.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-available-privacy-room-settings/">REST API Reference for IsAvailablePrivacyRoomSettings Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> IsAvailablePrivacyRoomSettingsWithHttpInfo();
        /// <summary>
        /// Ask a new file name
        /// </summary>
        /// <remarks>
        /// Specifies whether to ask a user for a file name on creation or not.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/keep-new-file-name/">REST API Reference for KeepNewFileName Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper KeepNewFileName(SettingsRequestDto? settingsRequestDto = default);

        /// <summary>
        /// Ask a new file name
        /// </summary>
        /// <remarks>
        /// Specifies whether to ask a user for a file name on creation or not.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/keep-new-file-name/">REST API Reference for KeepNewFileName Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> KeepNewFileNameWithHttpInfo(SettingsRequestDto? settingsRequestDto = default);
        /// <summary>
        /// Open document in the same browser tab
        /// </summary>
        /// <remarks>
        /// Changes the ability to open the document in the same browser tab.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-open-editor-in-same-tab/">REST API Reference for SetOpenEditorInSameTab Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper SetOpenEditorInSameTab(SettingsRequestDto? settingsRequestDto = default);

        /// <summary>
        /// Open document in the same browser tab
        /// </summary>
        /// <remarks>
        /// Changes the ability to open the document in the same browser tab.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-open-editor-in-same-tab/">REST API Reference for SetOpenEditorInSameTab Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> SetOpenEditorInSameTabWithHttpInfo(SettingsRequestDto? settingsRequestDto = default);
        /// <summary>
        /// Change the ability to store the forcesaved files
        /// </summary>
        /// <remarks>
        /// Changes the ability to store the forcesaved file versions.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-forcesave/">REST API Reference for StoreForcesave Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper StoreForcesave();

        /// <summary>
        /// Change the ability to store the forcesaved files
        /// </summary>
        /// <remarks>
        /// Changes the ability to store the forcesaved file versions.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-forcesave/">REST API Reference for StoreForcesave Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> StoreForcesaveWithHttpInfo();
        /// <summary>
        /// Change the ability to upload original formats
        /// </summary>
        /// <remarks>
        /// Changes the ability to upload documents in the original formats as well.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-original/">REST API Reference for StoreOriginal Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper StoreOriginal(SettingsRequestDto? settingsRequestDto = default);

        /// <summary>
        /// Change the ability to upload original formats
        /// </summary>
        /// <remarks>
        /// Changes the ability to upload documents in the original formats as well.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-original/">REST API Reference for StoreOriginal Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> StoreOriginalWithHttpInfo(SettingsRequestDto? settingsRequestDto = default);
        /// <summary>
        /// Update a file version if it exists
        /// </summary>
        /// <remarks>
        /// Updates a file version if a file with such a name already exists.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-if-exist/">REST API Reference for UpdateFileIfExist Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper UpdateFileIfExist(SettingsRequestDto? settingsRequestDto = default);

        /// <summary>
        /// Update a file version if it exists
        /// </summary>
        /// <remarks>
        /// Updates a file version if a file with such a name already exists.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-if-exist/">REST API Reference for UpdateFileIfExist Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> UpdateFileIfExistWithHttpInfo(SettingsRequestDto? settingsRequestDto = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFilesSettingsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Change the third-party settings access
        /// </summary>
        /// <remarks>
        /// Changes the access to the third-party settings.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-access-to-thirdparty/">REST API Reference for ChangeAccessToThirdparty Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> ChangeAccessToThirdpartyAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Change the third-party settings access
        /// </summary>
        /// <remarks>
        /// Changes the access to the third-party settings.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-access-to-thirdparty/">REST API Reference for ChangeAccessToThirdparty Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> ChangeAccessToThirdpartyWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the trash bin auto-clearing setting
        /// </summary>
        /// <remarks>
        /// Updates the trash bin auto-clearing setting.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autoCleanupRequestDto">The auto-clearing request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-automatically-clean-up/">REST API Reference for ChangeAutomaticallyCleanUp Operation</seealso>
        /// <returns>Task of AutoCleanUpDataWrapper</returns>
        System.Threading.Tasks.Task<AutoCleanUpDataWrapper> ChangeAutomaticallyCleanUpAsync(AutoCleanupRequestDto? autoCleanupRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update the trash bin auto-clearing setting
        /// </summary>
        /// <remarks>
        /// Updates the trash bin auto-clearing setting.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autoCleanupRequestDto">The auto-clearing request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-automatically-clean-up/">REST API Reference for ChangeAutomaticallyCleanUp Operation</seealso>
        /// <returns>Task of ApiResponse (AutoCleanUpDataWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<AutoCleanUpDataWrapper>> ChangeAutomaticallyCleanUpWithHttpInfoAsync(AutoCleanupRequestDto? autoCleanupRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change the default access rights
        /// </summary>
        /// <remarks>
        /// Changes the default access rights in the sharing settings.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">Sharing rights (None, ReadWrite, Read, Restrict, Varies, Review, Comment, FillForms, CustomFilter, RoomAdmin, Editing, Collaborator). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-default-access-rights/">REST API Reference for ChangeDefaultAccessRights Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        System.Threading.Tasks.Task<FileShareArrayWrapper> ChangeDefaultAccessRightsAsync(List<int>? requestBody = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Change the default access rights
        /// </summary>
        /// <remarks>
        /// Changes the default access rights in the sharing settings.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">Sharing rights (None, ReadWrite, Read, Restrict, Varies, Review, Comment, FillForms, CustomFilter, RoomAdmin, Editing, Collaborator). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-default-access-rights/">REST API Reference for ChangeDefaultAccessRights Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileShareArrayWrapper>> ChangeDefaultAccessRightsWithHttpInfoAsync(List<int>? requestBody = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Confirm the file deletion
        /// </summary>
        /// <remarks>
        /// Specifies whether to confirm the file deletion or not.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-delete-confirm/">REST API Reference for ChangeDeleteConfirm Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> ChangeDeleteConfirmAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Confirm the file deletion
        /// </summary>
        /// <remarks>
        /// Specifies whether to confirm the file deletion or not.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-delete-confirm/">REST API Reference for ChangeDeleteConfirm Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> ChangeDeleteConfirmWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change the archive format (using body parameters)
        /// </summary>
        /// <remarks>
        /// Changes the format of the downloaded archive from .zip to .tar.gz. This method uses the body parameters.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-download-zip-from-body/">REST API Reference for ChangeDownloadZipFromBody Operation</seealso>
        /// <returns>Task of ICompressWrapper</returns>
        System.Threading.Tasks.Task<ICompressWrapper> ChangeDownloadZipFromBodyAsync(DisplayRequestDto? displayRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Change the archive format (using body parameters)
        /// </summary>
        /// <remarks>
        /// Changes the format of the downloaded archive from .zip to .tar.gz. This method uses the body parameters.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-download-zip-from-body/">REST API Reference for ChangeDownloadZipFromBody Operation</seealso>
        /// <returns>Task of ApiResponse (ICompressWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<ICompressWrapper>> ChangeDownloadZipFromBodyWithHttpInfoAsync(DisplayRequestDto? displayRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check the document service URL
        /// </summary>
        /// <remarks>
        /// Checks the document service location URL.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="checkDocServiceUrlRequestDto">The request parameters for checking the document service location. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-doc-service-url/">REST API Reference for CheckDocServiceUrl Operation</seealso>
        /// <returns>Task of DocServiceUrlWrapper</returns>
        System.Threading.Tasks.Task<DocServiceUrlWrapper> CheckDocServiceUrlAsync(CheckDocServiceUrlRequestDto? checkDocServiceUrlRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Check the document service URL
        /// </summary>
        /// <remarks>
        /// Checks the document service location URL.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="checkDocServiceUrlRequestDto">The request parameters for checking the document service location. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-doc-service-url/">REST API Reference for CheckDocServiceUrl Operation</seealso>
        /// <returns>Task of ApiResponse (DocServiceUrlWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocServiceUrlWrapper>> CheckDocServiceUrlWithHttpInfoAsync(CheckDocServiceUrlRequestDto? checkDocServiceUrlRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Display a file extension
        /// </summary>
        /// <remarks>
        /// Specifies whether to display a file extension or not.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/display-file-extension/">REST API Reference for DisplayFileExtension Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> DisplayFileExtensionAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Display a file extension
        /// </summary>
        /// <remarks>
        /// Specifies whether to display a file extension or not.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/display-file-extension/">REST API Reference for DisplayFileExtension Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> DisplayFileExtensionWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change the external sharing ability
        /// </summary>
        /// <remarks>
        /// Changes the ability to share a file externally.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share/">REST API Reference for ExternalShare Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> ExternalShareAsync(DisplayRequestDto? displayRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Change the external sharing ability
        /// </summary>
        /// <remarks>
        /// Changes the ability to share a file externally.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share/">REST API Reference for ExternalShare Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> ExternalShareWithHttpInfoAsync(DisplayRequestDto? displayRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change the external sharing ability on social networks
        /// </summary>
        /// <remarks>
        /// Changes the ability to share a file externally on social networks.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share-social-media/">REST API Reference for ExternalShareSocialMedia Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> ExternalShareSocialMediaAsync(DisplayRequestDto? displayRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Change the external sharing ability on social networks
        /// </summary>
        /// <remarks>
        /// Changes the ability to share a file externally on social networks.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share-social-media/">REST API Reference for ExternalShareSocialMedia Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> ExternalShareSocialMediaWithHttpInfoAsync(DisplayRequestDto? displayRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change the forcesaving ability
        /// </summary>
        /// <remarks>
        /// Specifies if the file forcesaving is enabled or not.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/forcesave/">REST API Reference for Forcesave Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> ForcesaveAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Change the forcesaving ability
        /// </summary>
        /// <remarks>
        /// Specifies if the file forcesaving is enabled or not.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/forcesave/">REST API Reference for Forcesave Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> ForcesaveWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the trash bin auto-clearing setting
        /// </summary>
        /// <remarks>
        /// Returns the trash bin auto-clearing setting.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-automatically-clean-up/">REST API Reference for GetAutomaticallyCleanUp Operation</seealso>
        /// <returns>Task of AutoCleanUpDataWrapper</returns>
        System.Threading.Tasks.Task<AutoCleanUpDataWrapper> GetAutomaticallyCleanUpAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the trash bin auto-clearing setting
        /// </summary>
        /// <remarks>
        /// Returns the trash bin auto-clearing setting.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-automatically-clean-up/">REST API Reference for GetAutomaticallyCleanUp Operation</seealso>
        /// <returns>Task of ApiResponse (AutoCleanUpDataWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<AutoCleanUpDataWrapper>> GetAutomaticallyCleanUpWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the document service URL
        /// </summary>
        /// <remarks>
        /// Returns the URL address of the connected editors.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Specifies whether to return the editor version or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-doc-service-url/">REST API Reference for GetDocServiceUrl Operation</seealso>
        /// <returns>Task of DocServiceUrlWrapper</returns>
        System.Threading.Tasks.Task<DocServiceUrlWrapper> GetDocServiceUrlAsync(bool? version = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the document service URL
        /// </summary>
        /// <remarks>
        /// Returns the URL address of the connected editors.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Specifies whether to return the editor version or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-doc-service-url/">REST API Reference for GetDocServiceUrl Operation</seealso>
        /// <returns>Task of ApiResponse (DocServiceUrlWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocServiceUrlWrapper>> GetDocServiceUrlWithHttpInfoAsync(bool? version = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the \&quot;Documents\&quot; information
        /// </summary>
        /// <remarks>
        /// Returns the information about the \&quot;Documents\&quot; module.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-module/">REST API Reference for GetFilesModule Operation</seealso>
        /// <returns>Task of ModuleWrapper</returns>
        System.Threading.Tasks.Task<ModuleWrapper> GetFilesModuleAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the \&quot;Documents\&quot; information
        /// </summary>
        /// <remarks>
        /// Returns the information about the \&quot;Documents\&quot; module.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-module/">REST API Reference for GetFilesModule Operation</seealso>
        /// <returns>Task of ApiResponse (ModuleWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModuleWrapper>> GetFilesModuleWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get file settings
        /// </summary>
        /// <remarks>
        /// Returns all the file settings.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-settings/">REST API Reference for GetFilesSettings Operation</seealso>
        /// <returns>Task of FilesSettingsWrapper</returns>
        System.Threading.Tasks.Task<FilesSettingsWrapper> GetFilesSettingsAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get file settings
        /// </summary>
        /// <remarks>
        /// Returns all the file settings.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-settings/">REST API Reference for GetFilesSettings Operation</seealso>
        /// <returns>Task of ApiResponse (FilesSettingsWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FilesSettingsWrapper>> GetFilesSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Hide confirmation dialog when canceling operations
        /// </summary>
        /// <remarks>
        /// Hides the confirmation dialog when canceling operations.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-cancel-operation/">REST API Reference for HideConfirmCancelOperation Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> HideConfirmCancelOperationAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Hide confirmation dialog when canceling operations
        /// </summary>
        /// <remarks>
        /// Hides the confirmation dialog when canceling operations.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-cancel-operation/">REST API Reference for HideConfirmCancelOperation Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> HideConfirmCancelOperationWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Hide the confirmation dialog when converting
        /// </summary>
        /// <remarks>
        /// Hides the confirmation dialog for saving the file copy in the original format when converting a file.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hideConfirmConvertRequestDto">The request parameters for hiding the confirmation dialog when converting. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-convert/">REST API Reference for HideConfirmConvert Operation</seealso>
        /// <returns>Task of ModuleWrapper</returns>
        System.Threading.Tasks.Task<ModuleWrapper> HideConfirmConvertAsync(HideConfirmConvertRequestDto? hideConfirmConvertRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Hide the confirmation dialog when converting
        /// </summary>
        /// <remarks>
        /// Hides the confirmation dialog for saving the file copy in the original format when converting a file.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hideConfirmConvertRequestDto">The request parameters for hiding the confirmation dialog when converting. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-convert/">REST API Reference for HideConfirmConvert Operation</seealso>
        /// <returns>Task of ApiResponse (ModuleWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModuleWrapper>> HideConfirmConvertWithHttpInfoAsync(HideConfirmConvertRequestDto? hideConfirmConvertRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Hide confirmation dialog when changing room lifetime settings
        /// </summary>
        /// <remarks>
        /// Hides the confirmation dialog when changing the room lifetime settings.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-room-lifetime/">REST API Reference for HideConfirmRoomLifetime Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> HideConfirmRoomLifetimeAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Hide confirmation dialog when changing room lifetime settings
        /// </summary>
        /// <remarks>
        /// Hides the confirmation dialog when changing the room lifetime settings.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-room-lifetime/">REST API Reference for HideConfirmRoomLifetime Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> HideConfirmRoomLifetimeWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check the \&quot;Private Room\&quot; availability
        /// </summary>
        /// <remarks>
        /// Checks if the \&quot;Private Room\&quot; settings are available or not.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-available-privacy-room-settings/">REST API Reference for IsAvailablePrivacyRoomSettings Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> IsAvailablePrivacyRoomSettingsAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Check the \&quot;Private Room\&quot; availability
        /// </summary>
        /// <remarks>
        /// Checks if the \&quot;Private Room\&quot; settings are available or not.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-available-privacy-room-settings/">REST API Reference for IsAvailablePrivacyRoomSettings Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> IsAvailablePrivacyRoomSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ask a new file name
        /// </summary>
        /// <remarks>
        /// Specifies whether to ask a user for a file name on creation or not.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/keep-new-file-name/">REST API Reference for KeepNewFileName Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> KeepNewFileNameAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Ask a new file name
        /// </summary>
        /// <remarks>
        /// Specifies whether to ask a user for a file name on creation or not.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/keep-new-file-name/">REST API Reference for KeepNewFileName Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> KeepNewFileNameWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Open document in the same browser tab
        /// </summary>
        /// <remarks>
        /// Changes the ability to open the document in the same browser tab.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-open-editor-in-same-tab/">REST API Reference for SetOpenEditorInSameTab Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> SetOpenEditorInSameTabAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Open document in the same browser tab
        /// </summary>
        /// <remarks>
        /// Changes the ability to open the document in the same browser tab.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-open-editor-in-same-tab/">REST API Reference for SetOpenEditorInSameTab Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> SetOpenEditorInSameTabWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change the ability to store the forcesaved files
        /// </summary>
        /// <remarks>
        /// Changes the ability to store the forcesaved file versions.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-forcesave/">REST API Reference for StoreForcesave Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> StoreForcesaveAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Change the ability to store the forcesaved files
        /// </summary>
        /// <remarks>
        /// Changes the ability to store the forcesaved file versions.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-forcesave/">REST API Reference for StoreForcesave Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> StoreForcesaveWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change the ability to upload original formats
        /// </summary>
        /// <remarks>
        /// Changes the ability to upload documents in the original formats as well.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-original/">REST API Reference for StoreOriginal Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> StoreOriginalAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Change the ability to upload original formats
        /// </summary>
        /// <remarks>
        /// Changes the ability to upload documents in the original formats as well.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-original/">REST API Reference for StoreOriginal Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> StoreOriginalWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a file version if it exists
        /// </summary>
        /// <remarks>
        /// Updates a file version if a file with such a name already exists.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-if-exist/">REST API Reference for UpdateFileIfExist Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> UpdateFileIfExistAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a file version if it exists
        /// </summary>
        /// <remarks>
        /// Updates a file version if a file with such a name already exists.
        /// </remarks>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-if-exist/">REST API Reference for UpdateFileIfExist Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> UpdateFileIfExistWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFilesSettingsApi : IFilesSettingsApiSync, IFilesSettingsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FilesSettingsApi : IDisposable, IFilesSettingsApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesSettingsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public FilesSettingsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesSettingsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public FilesSettingsApi(string basePath)
        {
            this.Configuration = DocSpace.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            this.ApiClient = new ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = DocSpace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesSettingsApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public FilesSettingsApi(Configuration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);

            this.Configuration = DocSpace.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = DocSpace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesSettingsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public FilesSettingsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesSettingsApi"/> class.
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
        public FilesSettingsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(client);

            this.Configuration = DocSpace.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            this.ApiClient = new ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = DocSpace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesSettingsApi"/> class using a Configuration object.
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
        public FilesSettingsApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            ArgumentNullException.ThrowIfNull(client);

            this.Configuration = DocSpace.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = DocSpace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesSettingsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public FilesSettingsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(client);
            ArgumentNullException.ThrowIfNull(asyncClient);
            ArgumentNullException.ThrowIfNull(configuration);

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = DocSpace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient.Dispose();
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
            return this.Configuration.BasePath;
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
        /// Change the third-party settings access Changes the access to the third-party settings.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-access-to-thirdparty/">REST API Reference for ChangeAccessToThirdparty Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper ChangeAccessToThirdparty(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarResponse = ChangeAccessToThirdpartyWithHttpInfo(settingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the third-party settings access Changes the access to the third-party settings.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<BooleanWrapper>("/api/2.0/files/thirdparty", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("ChangeAccessToThirdparty", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the third-party settings access Changes the access to the third-party settings.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-access-to-thirdparty/">REST API Reference for ChangeAccessToThirdparty Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> ChangeAccessToThirdpartyAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await ChangeAccessToThirdpartyWithHttpInfoAsync(settingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the third-party settings access Changes the access to the third-party settings.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-access-to-thirdparty/">REST API Reference for ChangeAccessToThirdparty Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> ChangeAccessToThirdpartyWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/thirdparty", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("ChangeAccessToThirdparty", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the trash bin auto-clearing setting Updates the trash bin auto-clearing setting.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autoCleanupRequestDto">The auto-clearing request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-automatically-clean-up/">REST API Reference for ChangeAutomaticallyCleanUp Operation</seealso>
        /// <returns>AutoCleanUpDataWrapper</returns>
        public AutoCleanUpDataWrapper ChangeAutomaticallyCleanUp(AutoCleanupRequestDto? autoCleanupRequestDto = default)
        {
            var localVarResponse = ChangeAutomaticallyCleanUpWithHttpInfo(autoCleanupRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update the trash bin auto-clearing setting Updates the trash bin auto-clearing setting.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<AutoCleanUpDataWrapper>("/api/2.0/files/settings/autocleanup", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("ChangeAutomaticallyCleanUp", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the trash bin auto-clearing setting Updates the trash bin auto-clearing setting.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autoCleanupRequestDto">The auto-clearing request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-automatically-clean-up/">REST API Reference for ChangeAutomaticallyCleanUp Operation</seealso>
        /// <returns>Task of AutoCleanUpDataWrapper</returns>
        public async System.Threading.Tasks.Task<AutoCleanUpDataWrapper> ChangeAutomaticallyCleanUpAsync(AutoCleanupRequestDto? autoCleanupRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AutoCleanUpDataWrapper> localVarResponse = await ChangeAutomaticallyCleanUpWithHttpInfoAsync(autoCleanupRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update the trash bin auto-clearing setting Updates the trash bin auto-clearing setting.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autoCleanupRequestDto">The auto-clearing request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-automatically-clean-up/">REST API Reference for ChangeAutomaticallyCleanUp Operation</seealso>
        /// <returns>Task of ApiResponse (AutoCleanUpDataWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AutoCleanUpDataWrapper>> ChangeAutomaticallyCleanUpWithHttpInfoAsync(AutoCleanupRequestDto? autoCleanupRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (autoCleanupRequestDto != null) localVarRequestOptions.Data = autoCleanupRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<AutoCleanUpDataWrapper>("/api/2.0/files/settings/autocleanup", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("ChangeAutomaticallyCleanUp", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the default access rights Changes the default access rights in the sharing settings.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">Sharing rights (None, ReadWrite, Read, Restrict, Varies, Review, Comment, FillForms, CustomFilter, RoomAdmin, Editing, Collaborator). (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-default-access-rights/">REST API Reference for ChangeDefaultAccessRights Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        public FileShareArrayWrapper ChangeDefaultAccessRights(List<int>? requestBody = default)
        {
            var localVarResponse = ChangeDefaultAccessRightsWithHttpInfo(requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the default access rights Changes the default access rights in the sharing settings.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<FileShareArrayWrapper>("/api/2.0/files/settings/dafaultaccessrights", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("ChangeDefaultAccessRights", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the default access rights Changes the default access rights in the sharing settings.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">Sharing rights (None, ReadWrite, Read, Restrict, Varies, Review, Comment, FillForms, CustomFilter, RoomAdmin, Editing, Collaborator). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-default-access-rights/">REST API Reference for ChangeDefaultAccessRights Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        public async System.Threading.Tasks.Task<FileShareArrayWrapper> ChangeDefaultAccessRightsAsync(List<int>? requestBody = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileShareArrayWrapper> localVarResponse = await ChangeDefaultAccessRightsWithHttpInfoAsync(requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the default access rights Changes the default access rights in the sharing settings.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">Sharing rights (None, ReadWrite, Read, Restrict, Varies, Review, Comment, FillForms, CustomFilter, RoomAdmin, Editing, Collaborator). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-default-access-rights/">REST API Reference for ChangeDefaultAccessRights Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileShareArrayWrapper>> ChangeDefaultAccessRightsWithHttpInfoAsync(List<int>? requestBody = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (requestBody != null) localVarRequestOptions.Data = requestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<FileShareArrayWrapper>("/api/2.0/files/settings/dafaultaccessrights", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("ChangeDefaultAccessRights", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Confirm the file deletion Specifies whether to confirm the file deletion or not.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-delete-confirm/">REST API Reference for ChangeDeleteConfirm Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper ChangeDeleteConfirm(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarResponse = ChangeDeleteConfirmWithHttpInfo(settingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Confirm the file deletion Specifies whether to confirm the file deletion or not.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<BooleanWrapper>("/api/2.0/files/changedeleteconfrim", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("ChangeDeleteConfirm", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Confirm the file deletion Specifies whether to confirm the file deletion or not.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-delete-confirm/">REST API Reference for ChangeDeleteConfirm Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> ChangeDeleteConfirmAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await ChangeDeleteConfirmWithHttpInfoAsync(settingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Confirm the file deletion Specifies whether to confirm the file deletion or not.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-delete-confirm/">REST API Reference for ChangeDeleteConfirm Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> ChangeDeleteConfirmWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/changedeleteconfrim", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("ChangeDeleteConfirm", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the archive format (using body parameters) Changes the format of the downloaded archive from .zip to .tar.gz. This method uses the body parameters.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-download-zip-from-body/">REST API Reference for ChangeDownloadZipFromBody Operation</seealso>
        /// <returns>ICompressWrapper</returns>
        public ICompressWrapper ChangeDownloadZipFromBody(DisplayRequestDto? displayRequestDto = default)
        {
            var localVarResponse = ChangeDownloadZipFromBodyWithHttpInfo(displayRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the archive format (using body parameters) Changes the format of the downloaded archive from .zip to .tar.gz. This method uses the body parameters.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<ICompressWrapper>("/api/2.0/files/settings/downloadtargz", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("ChangeDownloadZipFromBody", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the archive format (using body parameters) Changes the format of the downloaded archive from .zip to .tar.gz. This method uses the body parameters.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-download-zip-from-body/">REST API Reference for ChangeDownloadZipFromBody Operation</seealso>
        /// <returns>Task of ICompressWrapper</returns>
        public async System.Threading.Tasks.Task<ICompressWrapper> ChangeDownloadZipFromBodyAsync(DisplayRequestDto? displayRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ICompressWrapper> localVarResponse = await ChangeDownloadZipFromBodyWithHttpInfoAsync(displayRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the archive format (using body parameters) Changes the format of the downloaded archive from .zip to .tar.gz. This method uses the body parameters.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-download-zip-from-body/">REST API Reference for ChangeDownloadZipFromBody Operation</seealso>
        /// <returns>Task of ApiResponse (ICompressWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ICompressWrapper>> ChangeDownloadZipFromBodyWithHttpInfoAsync(DisplayRequestDto? displayRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (displayRequestDto != null) localVarRequestOptions.Data = displayRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<ICompressWrapper>("/api/2.0/files/settings/downloadtargz", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("ChangeDownloadZipFromBody", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check the document service URL Checks the document service location URL.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="checkDocServiceUrlRequestDto">The request parameters for checking the document service location. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-doc-service-url/">REST API Reference for CheckDocServiceUrl Operation</seealso>
        /// <returns>DocServiceUrlWrapper</returns>
        public DocServiceUrlWrapper CheckDocServiceUrl(CheckDocServiceUrlRequestDto? checkDocServiceUrlRequestDto = default)
        {
            var localVarResponse = CheckDocServiceUrlWithHttpInfo(checkDocServiceUrlRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check the document service URL Checks the document service location URL.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<DocServiceUrlWrapper>("/api/2.0/files/docservice", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CheckDocServiceUrl", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check the document service URL Checks the document service location URL.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="checkDocServiceUrlRequestDto">The request parameters for checking the document service location. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-doc-service-url/">REST API Reference for CheckDocServiceUrl Operation</seealso>
        /// <returns>Task of DocServiceUrlWrapper</returns>
        public async System.Threading.Tasks.Task<DocServiceUrlWrapper> CheckDocServiceUrlAsync(CheckDocServiceUrlRequestDto? checkDocServiceUrlRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<DocServiceUrlWrapper> localVarResponse = await CheckDocServiceUrlWithHttpInfoAsync(checkDocServiceUrlRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check the document service URL Checks the document service location URL.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="checkDocServiceUrlRequestDto">The request parameters for checking the document service location. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-doc-service-url/">REST API Reference for CheckDocServiceUrl Operation</seealso>
        /// <returns>Task of ApiResponse (DocServiceUrlWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocServiceUrlWrapper>> CheckDocServiceUrlWithHttpInfoAsync(CheckDocServiceUrlRequestDto? checkDocServiceUrlRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (checkDocServiceUrlRequestDto != null) localVarRequestOptions.Data = checkDocServiceUrlRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<DocServiceUrlWrapper>("/api/2.0/files/docservice", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CheckDocServiceUrl", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Display a file extension Specifies whether to display a file extension or not.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/display-file-extension/">REST API Reference for DisplayFileExtension Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper DisplayFileExtension(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarResponse = DisplayFileExtensionWithHttpInfo(settingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Display a file extension Specifies whether to display a file extension or not.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<BooleanWrapper>("/api/2.0/files/displayfileextension", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("DisplayFileExtension", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Display a file extension Specifies whether to display a file extension or not.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/display-file-extension/">REST API Reference for DisplayFileExtension Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> DisplayFileExtensionAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await DisplayFileExtensionWithHttpInfoAsync(settingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Display a file extension Specifies whether to display a file extension or not.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/display-file-extension/">REST API Reference for DisplayFileExtension Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> DisplayFileExtensionWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/displayfileextension", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("DisplayFileExtension", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the external sharing ability Changes the ability to share a file externally.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share/">REST API Reference for ExternalShare Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper ExternalShare(DisplayRequestDto? displayRequestDto = default)
        {
            var localVarResponse = ExternalShareWithHttpInfo(displayRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the external sharing ability Changes the ability to share a file externally.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<BooleanWrapper>("/api/2.0/files/settings/external", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("ExternalShare", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the external sharing ability Changes the ability to share a file externally.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share/">REST API Reference for ExternalShare Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> ExternalShareAsync(DisplayRequestDto? displayRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await ExternalShareWithHttpInfoAsync(displayRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the external sharing ability Changes the ability to share a file externally.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share/">REST API Reference for ExternalShare Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> ExternalShareWithHttpInfoAsync(DisplayRequestDto? displayRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (displayRequestDto != null) localVarRequestOptions.Data = displayRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/settings/external", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("ExternalShare", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the external sharing ability on social networks Changes the ability to share a file externally on social networks.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share-social-media/">REST API Reference for ExternalShareSocialMedia Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper ExternalShareSocialMedia(DisplayRequestDto? displayRequestDto = default)
        {
            var localVarResponse = ExternalShareSocialMediaWithHttpInfo(displayRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the external sharing ability on social networks Changes the ability to share a file externally on social networks.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<BooleanWrapper>("/api/2.0/files/settings/externalsocialmedia", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("ExternalShareSocialMedia", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the external sharing ability on social networks Changes the ability to share a file externally on social networks.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share-social-media/">REST API Reference for ExternalShareSocialMedia Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> ExternalShareSocialMediaAsync(DisplayRequestDto? displayRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await ExternalShareSocialMediaWithHttpInfoAsync(displayRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the external sharing ability on social networks Changes the ability to share a file externally on social networks.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/external-share-social-media/">REST API Reference for ExternalShareSocialMedia Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> ExternalShareSocialMediaWithHttpInfoAsync(DisplayRequestDto? displayRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (displayRequestDto != null) localVarRequestOptions.Data = displayRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/settings/externalsocialmedia", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("ExternalShareSocialMedia", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the forcesaving ability Specifies if the file forcesaving is enabled or not.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/forcesave/">REST API Reference for Forcesave Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper Forcesave()
        {
            var localVarResponse = ForcesaveWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the forcesaving ability Specifies if the file forcesaving is enabled or not.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<BooleanWrapper>("/api/2.0/files/forcesave", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("Forcesave", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the forcesaving ability Specifies if the file forcesaving is enabled or not.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/forcesave/">REST API Reference for Forcesave Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> ForcesaveAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await ForcesaveWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the forcesaving ability Specifies if the file forcesaving is enabled or not.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/forcesave/">REST API Reference for Forcesave Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> ForcesaveWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/forcesave", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("Forcesave", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the trash bin auto-clearing setting Returns the trash bin auto-clearing setting.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-automatically-clean-up/">REST API Reference for GetAutomaticallyCleanUp Operation</seealso>
        /// <returns>AutoCleanUpDataWrapper</returns>
        public AutoCleanUpDataWrapper GetAutomaticallyCleanUp()
        {
            var localVarResponse = GetAutomaticallyCleanUpWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the trash bin auto-clearing setting Returns the trash bin auto-clearing setting.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<AutoCleanUpDataWrapper>("/api/2.0/files/settings/autocleanup", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetAutomaticallyCleanUp", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the trash bin auto-clearing setting Returns the trash bin auto-clearing setting.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-automatically-clean-up/">REST API Reference for GetAutomaticallyCleanUp Operation</seealso>
        /// <returns>Task of AutoCleanUpDataWrapper</returns>
        public async System.Threading.Tasks.Task<AutoCleanUpDataWrapper> GetAutomaticallyCleanUpAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AutoCleanUpDataWrapper> localVarResponse = await GetAutomaticallyCleanUpWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the trash bin auto-clearing setting Returns the trash bin auto-clearing setting.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-automatically-clean-up/">REST API Reference for GetAutomaticallyCleanUp Operation</seealso>
        /// <returns>Task of ApiResponse (AutoCleanUpDataWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AutoCleanUpDataWrapper>> GetAutomaticallyCleanUpWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<AutoCleanUpDataWrapper>("/api/2.0/files/settings/autocleanup", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetAutomaticallyCleanUp", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the document service URL Returns the URL address of the connected editors.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Specifies whether to return the editor version or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-doc-service-url/">REST API Reference for GetDocServiceUrl Operation</seealso>
        /// <returns>DocServiceUrlWrapper</returns>
        public DocServiceUrlWrapper GetDocServiceUrl(bool? version = default)
        {
            var localVarResponse = GetDocServiceUrlWithHttpInfo(version);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the document service URL Returns the URL address of the connected editors.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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
            var localVarResponse = this.Client.Get<DocServiceUrlWrapper>("/api/2.0/files/docservice", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetDocServiceUrl", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the document service URL Returns the URL address of the connected editors.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Specifies whether to return the editor version or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-doc-service-url/">REST API Reference for GetDocServiceUrl Operation</seealso>
        /// <returns>Task of DocServiceUrlWrapper</returns>
        public async System.Threading.Tasks.Task<DocServiceUrlWrapper> GetDocServiceUrlAsync(bool? version = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<DocServiceUrlWrapper> localVarResponse = await GetDocServiceUrlWithHttpInfoAsync(version, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the document service URL Returns the URL address of the connected editors.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Specifies whether to return the editor version or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-doc-service-url/">REST API Reference for GetDocServiceUrl Operation</seealso>
        /// <returns>Task of ApiResponse (DocServiceUrlWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocServiceUrlWrapper>> GetDocServiceUrlWithHttpInfoAsync(bool? version = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (version != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "version", version));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<DocServiceUrlWrapper>("/api/2.0/files/docservice", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetDocServiceUrl", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the \&quot;Documents\&quot; information Returns the information about the \&quot;Documents\&quot; module.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-module/">REST API Reference for GetFilesModule Operation</seealso>
        /// <returns>ModuleWrapper</returns>
        public ModuleWrapper GetFilesModule()
        {
            var localVarResponse = GetFilesModuleWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the \&quot;Documents\&quot; information Returns the information about the \&quot;Documents\&quot; module.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<ModuleWrapper>("/api/2.0/files/info", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFilesModule", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the \&quot;Documents\&quot; information Returns the information about the \&quot;Documents\&quot; module.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-module/">REST API Reference for GetFilesModule Operation</seealso>
        /// <returns>Task of ModuleWrapper</returns>
        public async System.Threading.Tasks.Task<ModuleWrapper> GetFilesModuleAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ModuleWrapper> localVarResponse = await GetFilesModuleWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the \&quot;Documents\&quot; information Returns the information about the \&quot;Documents\&quot; module.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-module/">REST API Reference for GetFilesModule Operation</seealso>
        /// <returns>Task of ApiResponse (ModuleWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModuleWrapper>> GetFilesModuleWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ModuleWrapper>("/api/2.0/files/info", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFilesModule", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get file settings Returns all the file settings.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-settings/">REST API Reference for GetFilesSettings Operation</seealso>
        /// <returns>FilesSettingsWrapper</returns>
        public FilesSettingsWrapper GetFilesSettings()
        {
            var localVarResponse = GetFilesSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get file settings Returns all the file settings.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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
            var localVarResponse = this.Client.Get<FilesSettingsWrapper>("/api/2.0/files/settings", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFilesSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get file settings Returns all the file settings.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-settings/">REST API Reference for GetFilesSettings Operation</seealso>
        /// <returns>Task of FilesSettingsWrapper</returns>
        public async System.Threading.Tasks.Task<FilesSettingsWrapper> GetFilesSettingsAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FilesSettingsWrapper> localVarResponse = await GetFilesSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get file settings Returns all the file settings.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-settings/">REST API Reference for GetFilesSettings Operation</seealso>
        /// <returns>Task of ApiResponse (FilesSettingsWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FilesSettingsWrapper>> GetFilesSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<FilesSettingsWrapper>("/api/2.0/files/settings", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFilesSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Hide confirmation dialog when canceling operations Hides the confirmation dialog when canceling operations.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-cancel-operation/">REST API Reference for HideConfirmCancelOperation Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper HideConfirmCancelOperation(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarResponse = HideConfirmCancelOperationWithHttpInfo(settingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Hide confirmation dialog when canceling operations Hides the confirmation dialog when canceling operations.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<BooleanWrapper>("/api/2.0/files/hideconfirmcanceloperation", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("HideConfirmCancelOperation", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Hide confirmation dialog when canceling operations Hides the confirmation dialog when canceling operations.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-cancel-operation/">REST API Reference for HideConfirmCancelOperation Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> HideConfirmCancelOperationAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await HideConfirmCancelOperationWithHttpInfoAsync(settingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Hide confirmation dialog when canceling operations Hides the confirmation dialog when canceling operations.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-cancel-operation/">REST API Reference for HideConfirmCancelOperation Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> HideConfirmCancelOperationWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/hideconfirmcanceloperation", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("HideConfirmCancelOperation", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Hide the confirmation dialog when converting Hides the confirmation dialog for saving the file copy in the original format when converting a file.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hideConfirmConvertRequestDto">The request parameters for hiding the confirmation dialog when converting. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-convert/">REST API Reference for HideConfirmConvert Operation</seealso>
        /// <returns>ModuleWrapper</returns>
        public ModuleWrapper HideConfirmConvert(HideConfirmConvertRequestDto? hideConfirmConvertRequestDto = default)
        {
            var localVarResponse = HideConfirmConvertWithHttpInfo(hideConfirmConvertRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Hide the confirmation dialog when converting Hides the confirmation dialog for saving the file copy in the original format when converting a file.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<ModuleWrapper>("/api/2.0/files/hideconfirmconvert", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("HideConfirmConvert", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Hide the confirmation dialog when converting Hides the confirmation dialog for saving the file copy in the original format when converting a file.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hideConfirmConvertRequestDto">The request parameters for hiding the confirmation dialog when converting. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-convert/">REST API Reference for HideConfirmConvert Operation</seealso>
        /// <returns>Task of ModuleWrapper</returns>
        public async System.Threading.Tasks.Task<ModuleWrapper> HideConfirmConvertAsync(HideConfirmConvertRequestDto? hideConfirmConvertRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ModuleWrapper> localVarResponse = await HideConfirmConvertWithHttpInfoAsync(hideConfirmConvertRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Hide the confirmation dialog when converting Hides the confirmation dialog for saving the file copy in the original format when converting a file.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hideConfirmConvertRequestDto">The request parameters for hiding the confirmation dialog when converting. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-convert/">REST API Reference for HideConfirmConvert Operation</seealso>
        /// <returns>Task of ApiResponse (ModuleWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModuleWrapper>> HideConfirmConvertWithHttpInfoAsync(HideConfirmConvertRequestDto? hideConfirmConvertRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (hideConfirmConvertRequestDto != null) localVarRequestOptions.Data = hideConfirmConvertRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<ModuleWrapper>("/api/2.0/files/hideconfirmconvert", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("HideConfirmConvert", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Hide confirmation dialog when changing room lifetime settings Hides the confirmation dialog when changing the room lifetime settings.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-room-lifetime/">REST API Reference for HideConfirmRoomLifetime Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper HideConfirmRoomLifetime(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarResponse = HideConfirmRoomLifetimeWithHttpInfo(settingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Hide confirmation dialog when changing room lifetime settings Hides the confirmation dialog when changing the room lifetime settings.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<BooleanWrapper>("/api/2.0/files/hideconfirmroomlifetime", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("HideConfirmRoomLifetime", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Hide confirmation dialog when changing room lifetime settings Hides the confirmation dialog when changing the room lifetime settings.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-room-lifetime/">REST API Reference for HideConfirmRoomLifetime Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> HideConfirmRoomLifetimeAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await HideConfirmRoomLifetimeWithHttpInfoAsync(settingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Hide confirmation dialog when changing room lifetime settings Hides the confirmation dialog when changing the room lifetime settings.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/hide-confirm-room-lifetime/">REST API Reference for HideConfirmRoomLifetime Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> HideConfirmRoomLifetimeWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/hideconfirmroomlifetime", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("HideConfirmRoomLifetime", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check the \&quot;Private Room\&quot; availability Checks if the \&quot;Private Room\&quot; settings are available or not.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-available-privacy-room-settings/">REST API Reference for IsAvailablePrivacyRoomSettings Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper IsAvailablePrivacyRoomSettings()
        {
            var localVarResponse = IsAvailablePrivacyRoomSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check the \&quot;Private Room\&quot; availability Checks if the \&quot;Private Room\&quot; settings are available or not.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<BooleanWrapper>("/api/2.0/files/@privacy/available", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("IsAvailablePrivacyRoomSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check the \&quot;Private Room\&quot; availability Checks if the \&quot;Private Room\&quot; settings are available or not.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-available-privacy-room-settings/">REST API Reference for IsAvailablePrivacyRoomSettings Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> IsAvailablePrivacyRoomSettingsAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await IsAvailablePrivacyRoomSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check the \&quot;Private Room\&quot; availability Checks if the \&quot;Private Room\&quot; settings are available or not.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-available-privacy-room-settings/">REST API Reference for IsAvailablePrivacyRoomSettings Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> IsAvailablePrivacyRoomSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<BooleanWrapper>("/api/2.0/files/@privacy/available", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("IsAvailablePrivacyRoomSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Ask a new file name Specifies whether to ask a user for a file name on creation or not.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/keep-new-file-name/">REST API Reference for KeepNewFileName Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper KeepNewFileName(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarResponse = KeepNewFileNameWithHttpInfo(settingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Ask a new file name Specifies whether to ask a user for a file name on creation or not.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<BooleanWrapper>("/api/2.0/files/keepnewfilename", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("KeepNewFileName", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Ask a new file name Specifies whether to ask a user for a file name on creation or not.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/keep-new-file-name/">REST API Reference for KeepNewFileName Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> KeepNewFileNameAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await KeepNewFileNameWithHttpInfoAsync(settingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Ask a new file name Specifies whether to ask a user for a file name on creation or not.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/keep-new-file-name/">REST API Reference for KeepNewFileName Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> KeepNewFileNameWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/keepnewfilename", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("KeepNewFileName", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Open document in the same browser tab Changes the ability to open the document in the same browser tab.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-open-editor-in-same-tab/">REST API Reference for SetOpenEditorInSameTab Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper SetOpenEditorInSameTab(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarResponse = SetOpenEditorInSameTabWithHttpInfo(settingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Open document in the same browser tab Changes the ability to open the document in the same browser tab.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<BooleanWrapper>("/api/2.0/files/settings/openeditorinsametab", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SetOpenEditorInSameTab", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Open document in the same browser tab Changes the ability to open the document in the same browser tab.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-open-editor-in-same-tab/">REST API Reference for SetOpenEditorInSameTab Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> SetOpenEditorInSameTabAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await SetOpenEditorInSameTabWithHttpInfoAsync(settingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Open document in the same browser tab Changes the ability to open the document in the same browser tab.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-open-editor-in-same-tab/">REST API Reference for SetOpenEditorInSameTab Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> SetOpenEditorInSameTabWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/settings/openeditorinsametab", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SetOpenEditorInSameTab", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the ability to store the forcesaved files Changes the ability to store the forcesaved file versions.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-forcesave/">REST API Reference for StoreForcesave Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper StoreForcesave()
        {
            var localVarResponse = StoreForcesaveWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the ability to store the forcesaved files Changes the ability to store the forcesaved file versions.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<BooleanWrapper>("/api/2.0/files/storeforcesave", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("StoreForcesave", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the ability to store the forcesaved files Changes the ability to store the forcesaved file versions.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-forcesave/">REST API Reference for StoreForcesave Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> StoreForcesaveAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await StoreForcesaveWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the ability to store the forcesaved files Changes the ability to store the forcesaved file versions.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-forcesave/">REST API Reference for StoreForcesave Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> StoreForcesaveWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/storeforcesave", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("StoreForcesave", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the ability to upload original formats Changes the ability to upload documents in the original formats as well.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-original/">REST API Reference for StoreOriginal Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper StoreOriginal(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarResponse = StoreOriginalWithHttpInfo(settingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the ability to upload original formats Changes the ability to upload documents in the original formats as well.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<BooleanWrapper>("/api/2.0/files/storeoriginal", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("StoreOriginal", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the ability to upload original formats Changes the ability to upload documents in the original formats as well.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-original/">REST API Reference for StoreOriginal Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> StoreOriginalAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await StoreOriginalWithHttpInfoAsync(settingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the ability to upload original formats Changes the ability to upload documents in the original formats as well.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/store-original/">REST API Reference for StoreOriginal Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> StoreOriginalWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/storeoriginal", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("StoreOriginal", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a file version if it exists Updates a file version if a file with such a name already exists.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-if-exist/">REST API Reference for UpdateFileIfExist Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper UpdateFileIfExist(SettingsRequestDto? settingsRequestDto = default)
        {
            var localVarResponse = UpdateFileIfExistWithHttpInfo(settingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a file version if it exists Updates a file version if a file with such a name already exists.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
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

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<BooleanWrapper>("/api/2.0/files/updateifexist", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("UpdateFileIfExist", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a file version if it exists Updates a file version if a file with such a name already exists.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-if-exist/">REST API Reference for UpdateFileIfExist Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> UpdateFileIfExistAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await UpdateFileIfExistWithHttpInfoAsync(settingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a file version if it exists Updates a file version if a file with such a name already exists.
        /// </summary>
        /// <exception cref="DocSpace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsRequestDto">The settings request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-if-exist/">REST API Reference for UpdateFileIfExist Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> UpdateFileIfExistWithHttpInfoAsync(SettingsRequestDto? settingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (settingsRequestDto != null) localVarRequestOptions.Data = settingsRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/files/updateifexist", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("UpdateFileIfExist", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

    }
}
