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


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using DocSpace.Model;
using DocSpace.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace DocSpace.Test.Model
{
    /// <summary>
    ///  Class for testing FilesSettingsDto
    /// </summary>
    public class FilesSettingsDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for FilesSettingsDto
        //private FilesSettingsDto instance;

        public FilesSettingsDtoTests()
        {
            // TODO uncomment below to create an instance of FilesSettingsDto
            //instance = new FilesSettingsDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FilesSettingsDto
        /// </summary>
        [Fact]
        public void FilesSettingsDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" FilesSettingsDto
            //Assert.IsType<FilesSettingsDto>(instance);
        }

        /// <summary>
        /// Test the property 'ExtsImagePreviewed'
        /// </summary>
        [Fact]
        public void ExtsImagePreviewedTest()
        {
            // TODO unit test for the property 'ExtsImagePreviewed'
        }

        /// <summary>
        /// Test the property 'ExtsMediaPreviewed'
        /// </summary>
        [Fact]
        public void ExtsMediaPreviewedTest()
        {
            // TODO unit test for the property 'ExtsMediaPreviewed'
        }

        /// <summary>
        /// Test the property 'ExtsWebPreviewed'
        /// </summary>
        [Fact]
        public void ExtsWebPreviewedTest()
        {
            // TODO unit test for the property 'ExtsWebPreviewed'
        }

        /// <summary>
        /// Test the property 'ExtsWebEdited'
        /// </summary>
        [Fact]
        public void ExtsWebEditedTest()
        {
            // TODO unit test for the property 'ExtsWebEdited'
        }

        /// <summary>
        /// Test the property 'ExtsWebEncrypt'
        /// </summary>
        [Fact]
        public void ExtsWebEncryptTest()
        {
            // TODO unit test for the property 'ExtsWebEncrypt'
        }

        /// <summary>
        /// Test the property 'ExtsWebReviewed'
        /// </summary>
        [Fact]
        public void ExtsWebReviewedTest()
        {
            // TODO unit test for the property 'ExtsWebReviewed'
        }

        /// <summary>
        /// Test the property 'ExtsWebCustomFilterEditing'
        /// </summary>
        [Fact]
        public void ExtsWebCustomFilterEditingTest()
        {
            // TODO unit test for the property 'ExtsWebCustomFilterEditing'
        }

        /// <summary>
        /// Test the property 'ExtsWebRestrictedEditing'
        /// </summary>
        [Fact]
        public void ExtsWebRestrictedEditingTest()
        {
            // TODO unit test for the property 'ExtsWebRestrictedEditing'
        }

        /// <summary>
        /// Test the property 'ExtsWebCommented'
        /// </summary>
        [Fact]
        public void ExtsWebCommentedTest()
        {
            // TODO unit test for the property 'ExtsWebCommented'
        }

        /// <summary>
        /// Test the property 'ExtsWebTemplate'
        /// </summary>
        [Fact]
        public void ExtsWebTemplateTest()
        {
            // TODO unit test for the property 'ExtsWebTemplate'
        }

        /// <summary>
        /// Test the property 'ExtsCoAuthoring'
        /// </summary>
        [Fact]
        public void ExtsCoAuthoringTest()
        {
            // TODO unit test for the property 'ExtsCoAuthoring'
        }

        /// <summary>
        /// Test the property 'ExtsMustConvert'
        /// </summary>
        [Fact]
        public void ExtsMustConvertTest()
        {
            // TODO unit test for the property 'ExtsMustConvert'
        }

        /// <summary>
        /// Test the property 'ExtsConvertible'
        /// </summary>
        [Fact]
        public void ExtsConvertibleTest()
        {
            // TODO unit test for the property 'ExtsConvertible'
        }

        /// <summary>
        /// Test the property 'ExtsUploadable'
        /// </summary>
        [Fact]
        public void ExtsUploadableTest()
        {
            // TODO unit test for the property 'ExtsUploadable'
        }

        /// <summary>
        /// Test the property 'ExtsArchive'
        /// </summary>
        [Fact]
        public void ExtsArchiveTest()
        {
            // TODO unit test for the property 'ExtsArchive'
        }

        /// <summary>
        /// Test the property 'ExtsVideo'
        /// </summary>
        [Fact]
        public void ExtsVideoTest()
        {
            // TODO unit test for the property 'ExtsVideo'
        }

        /// <summary>
        /// Test the property 'ExtsAudio'
        /// </summary>
        [Fact]
        public void ExtsAudioTest()
        {
            // TODO unit test for the property 'ExtsAudio'
        }

        /// <summary>
        /// Test the property 'ExtsImage'
        /// </summary>
        [Fact]
        public void ExtsImageTest()
        {
            // TODO unit test for the property 'ExtsImage'
        }

        /// <summary>
        /// Test the property 'ExtsSpreadsheet'
        /// </summary>
        [Fact]
        public void ExtsSpreadsheetTest()
        {
            // TODO unit test for the property 'ExtsSpreadsheet'
        }

        /// <summary>
        /// Test the property 'ExtsPresentation'
        /// </summary>
        [Fact]
        public void ExtsPresentationTest()
        {
            // TODO unit test for the property 'ExtsPresentation'
        }

        /// <summary>
        /// Test the property 'ExtsDocument'
        /// </summary>
        [Fact]
        public void ExtsDocumentTest()
        {
            // TODO unit test for the property 'ExtsDocument'
        }

        /// <summary>
        /// Test the property 'InternalFormats'
        /// </summary>
        [Fact]
        public void InternalFormatsTest()
        {
            // TODO unit test for the property 'InternalFormats'
        }

        /// <summary>
        /// Test the property 'MasterFormExtension'
        /// </summary>
        [Fact]
        public void MasterFormExtensionTest()
        {
            // TODO unit test for the property 'MasterFormExtension'
        }

        /// <summary>
        /// Test the property 'ParamVersion'
        /// </summary>
        [Fact]
        public void ParamVersionTest()
        {
            // TODO unit test for the property 'ParamVersion'
        }

        /// <summary>
        /// Test the property 'ParamOutType'
        /// </summary>
        [Fact]
        public void ParamOutTypeTest()
        {
            // TODO unit test for the property 'ParamOutType'
        }

        /// <summary>
        /// Test the property 'FileDownloadUrlString'
        /// </summary>
        [Fact]
        public void FileDownloadUrlStringTest()
        {
            // TODO unit test for the property 'FileDownloadUrlString'
        }

        /// <summary>
        /// Test the property 'FileWebViewerUrlString'
        /// </summary>
        [Fact]
        public void FileWebViewerUrlStringTest()
        {
            // TODO unit test for the property 'FileWebViewerUrlString'
        }

        /// <summary>
        /// Test the property 'FileWebViewerExternalUrlString'
        /// </summary>
        [Fact]
        public void FileWebViewerExternalUrlStringTest()
        {
            // TODO unit test for the property 'FileWebViewerExternalUrlString'
        }

        /// <summary>
        /// Test the property 'FileWebEditorUrlString'
        /// </summary>
        [Fact]
        public void FileWebEditorUrlStringTest()
        {
            // TODO unit test for the property 'FileWebEditorUrlString'
        }

        /// <summary>
        /// Test the property 'FileWebEditorExternalUrlString'
        /// </summary>
        [Fact]
        public void FileWebEditorExternalUrlStringTest()
        {
            // TODO unit test for the property 'FileWebEditorExternalUrlString'
        }

        /// <summary>
        /// Test the property 'FileRedirectPreviewUrlString'
        /// </summary>
        [Fact]
        public void FileRedirectPreviewUrlStringTest()
        {
            // TODO unit test for the property 'FileRedirectPreviewUrlString'
        }

        /// <summary>
        /// Test the property 'FileThumbnailUrlString'
        /// </summary>
        [Fact]
        public void FileThumbnailUrlStringTest()
        {
            // TODO unit test for the property 'FileThumbnailUrlString'
        }

        /// <summary>
        /// Test the property 'ConfirmDelete'
        /// </summary>
        [Fact]
        public void ConfirmDeleteTest()
        {
            // TODO unit test for the property 'ConfirmDelete'
        }

        /// <summary>
        /// Test the property 'EnableThirdParty'
        /// </summary>
        [Fact]
        public void EnableThirdPartyTest()
        {
            // TODO unit test for the property 'EnableThirdParty'
        }

        /// <summary>
        /// Test the property 'ExternalShare'
        /// </summary>
        [Fact]
        public void ExternalShareTest()
        {
            // TODO unit test for the property 'ExternalShare'
        }

        /// <summary>
        /// Test the property 'ExternalShareSocialMedia'
        /// </summary>
        [Fact]
        public void ExternalShareSocialMediaTest()
        {
            // TODO unit test for the property 'ExternalShareSocialMedia'
        }

        /// <summary>
        /// Test the property 'StoreOriginalFiles'
        /// </summary>
        [Fact]
        public void StoreOriginalFilesTest()
        {
            // TODO unit test for the property 'StoreOriginalFiles'
        }

        /// <summary>
        /// Test the property 'KeepNewFileName'
        /// </summary>
        [Fact]
        public void KeepNewFileNameTest()
        {
            // TODO unit test for the property 'KeepNewFileName'
        }

        /// <summary>
        /// Test the property 'DisplayFileExtension'
        /// </summary>
        [Fact]
        public void DisplayFileExtensionTest()
        {
            // TODO unit test for the property 'DisplayFileExtension'
        }

        /// <summary>
        /// Test the property 'ConvertNotify'
        /// </summary>
        [Fact]
        public void ConvertNotifyTest()
        {
            // TODO unit test for the property 'ConvertNotify'
        }

        /// <summary>
        /// Test the property 'HideConfirmCancelOperation'
        /// </summary>
        [Fact]
        public void HideConfirmCancelOperationTest()
        {
            // TODO unit test for the property 'HideConfirmCancelOperation'
        }

        /// <summary>
        /// Test the property 'HideConfirmConvertSave'
        /// </summary>
        [Fact]
        public void HideConfirmConvertSaveTest()
        {
            // TODO unit test for the property 'HideConfirmConvertSave'
        }

        /// <summary>
        /// Test the property 'HideConfirmConvertOpen'
        /// </summary>
        [Fact]
        public void HideConfirmConvertOpenTest()
        {
            // TODO unit test for the property 'HideConfirmConvertOpen'
        }

        /// <summary>
        /// Test the property 'HideConfirmRoomLifetime'
        /// </summary>
        [Fact]
        public void HideConfirmRoomLifetimeTest()
        {
            // TODO unit test for the property 'HideConfirmRoomLifetime'
        }

        /// <summary>
        /// Test the property 'DefaultOrder'
        /// </summary>
        [Fact]
        public void DefaultOrderTest()
        {
            // TODO unit test for the property 'DefaultOrder'
        }

        /// <summary>
        /// Test the property 'Forcesave'
        /// </summary>
        [Fact]
        public void ForcesaveTest()
        {
            // TODO unit test for the property 'Forcesave'
        }

        /// <summary>
        /// Test the property 'StoreForcesave'
        /// </summary>
        [Fact]
        public void StoreForcesaveTest()
        {
            // TODO unit test for the property 'StoreForcesave'
        }

        /// <summary>
        /// Test the property 'RecentSection'
        /// </summary>
        [Fact]
        public void RecentSectionTest()
        {
            // TODO unit test for the property 'RecentSection'
        }

        /// <summary>
        /// Test the property 'FavoritesSection'
        /// </summary>
        [Fact]
        public void FavoritesSectionTest()
        {
            // TODO unit test for the property 'FavoritesSection'
        }

        /// <summary>
        /// Test the property 'TemplatesSection'
        /// </summary>
        [Fact]
        public void TemplatesSectionTest()
        {
            // TODO unit test for the property 'TemplatesSection'
        }

        /// <summary>
        /// Test the property 'DownloadTarGz'
        /// </summary>
        [Fact]
        public void DownloadTarGzTest()
        {
            // TODO unit test for the property 'DownloadTarGz'
        }

        /// <summary>
        /// Test the property 'AutomaticallyCleanUp'
        /// </summary>
        [Fact]
        public void AutomaticallyCleanUpTest()
        {
            // TODO unit test for the property 'AutomaticallyCleanUp'
        }

        /// <summary>
        /// Test the property 'CanSearchByContent'
        /// </summary>
        [Fact]
        public void CanSearchByContentTest()
        {
            // TODO unit test for the property 'CanSearchByContent'
        }

        /// <summary>
        /// Test the property 'DefaultSharingAccessRights'
        /// </summary>
        [Fact]
        public void DefaultSharingAccessRightsTest()
        {
            // TODO unit test for the property 'DefaultSharingAccessRights'
        }

        /// <summary>
        /// Test the property 'MaxUploadThreadCount'
        /// </summary>
        [Fact]
        public void MaxUploadThreadCountTest()
        {
            // TODO unit test for the property 'MaxUploadThreadCount'
        }

        /// <summary>
        /// Test the property 'ChunkUploadSize'
        /// </summary>
        [Fact]
        public void ChunkUploadSizeTest()
        {
            // TODO unit test for the property 'ChunkUploadSize'
        }

        /// <summary>
        /// Test the property 'OpenEditorInSameTab'
        /// </summary>
        [Fact]
        public void OpenEditorInSameTabTest()
        {
            // TODO unit test for the property 'OpenEditorInSameTab'
        }
    }
}
