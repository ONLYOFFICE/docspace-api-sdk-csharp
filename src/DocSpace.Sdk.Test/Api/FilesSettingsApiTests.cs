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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using DocSpace.Sdk.Client;
using DocSpace.Sdk.Api;
// uncomment below to import models
//using DocSpace.Sdk.Model;

namespace DocSpace.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing FilesSettingsApi
    /// </summary>
    public class FilesSettingsApiTests : IDisposable
    {
        private FilesSettingsApi instance;

        public FilesSettingsApiTests()
        {
            instance = new FilesSettingsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FilesSettingsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FilesSettingsApi
            //Assert.IsType<FilesSettingsApi>(instance);
        }

        /// <summary>
        /// Test ChangeAccessToThirdparty
        /// </summary>
        [Fact]
        public void ChangeAccessToThirdpartyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SettingsRequestDto? settingsRequestDto = null;
            //var response = instance.ChangeAccessToThirdparty(settingsRequestDto);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test ChangeAutomaticallyCleanUp
        /// </summary>
        [Fact]
        public void ChangeAutomaticallyCleanUpTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AutoCleanupRequestDto? autoCleanupRequestDto = null;
            //var response = instance.ChangeAutomaticallyCleanUp(autoCleanupRequestDto);
            //Assert.IsType<AutoCleanUpDataWrapper>(response);
        }

        /// <summary>
        /// Test ChangeDefaultAccessRights
        /// </summary>
        [Fact]
        public void ChangeDefaultAccessRightsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int>? requestBody = null;
            //var response = instance.ChangeDefaultAccessRights(requestBody);
            //Assert.IsType<FileShareArrayWrapper>(response);
        }

        /// <summary>
        /// Test ChangeDeleteConfirm
        /// </summary>
        [Fact]
        public void ChangeDeleteConfirmTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SettingsRequestDto? settingsRequestDto = null;
            //var response = instance.ChangeDeleteConfirm(settingsRequestDto);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test ChangeDownloadZipFromBody
        /// </summary>
        [Fact]
        public void ChangeDownloadZipFromBodyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DisplayRequestDto? displayRequestDto = null;
            //var response = instance.ChangeDownloadZipFromBody(displayRequestDto);
            //Assert.IsType<ICompressWrapper>(response);
        }

        /// <summary>
        /// Test CheckDocServiceUrl
        /// </summary>
        [Fact]
        public void CheckDocServiceUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CheckDocServiceUrlRequestDto? checkDocServiceUrlRequestDto = null;
            //var response = instance.CheckDocServiceUrl(checkDocServiceUrlRequestDto);
            //Assert.IsType<DocServiceUrlWrapper>(response);
        }

        /// <summary>
        /// Test DisplayFileExtension
        /// </summary>
        [Fact]
        public void DisplayFileExtensionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SettingsRequestDto? settingsRequestDto = null;
            //var response = instance.DisplayFileExtension(settingsRequestDto);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test ExternalShare
        /// </summary>
        [Fact]
        public void ExternalShareTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DisplayRequestDto? displayRequestDto = null;
            //var response = instance.ExternalShare(displayRequestDto);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test ExternalShareSocialMedia
        /// </summary>
        [Fact]
        public void ExternalShareSocialMediaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DisplayRequestDto? displayRequestDto = null;
            //var response = instance.ExternalShareSocialMedia(displayRequestDto);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test Forcesave
        /// </summary>
        [Fact]
        public void ForcesaveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Forcesave();
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test GetAutomaticallyCleanUp
        /// </summary>
        [Fact]
        public void GetAutomaticallyCleanUpTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAutomaticallyCleanUp();
            //Assert.IsType<AutoCleanUpDataWrapper>(response);
        }

        /// <summary>
        /// Test GetDocServiceUrl
        /// </summary>
        [Fact]
        public void GetDocServiceUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? version = null;
            //var response = instance.GetDocServiceUrl(version);
            //Assert.IsType<DocServiceUrlWrapper>(response);
        }

        /// <summary>
        /// Test GetFilesModule
        /// </summary>
        [Fact]
        public void GetFilesModuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetFilesModule();
            //Assert.IsType<ModuleWrapper>(response);
        }

        /// <summary>
        /// Test GetFilesSettings
        /// </summary>
        [Fact]
        public void GetFilesSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetFilesSettings();
            //Assert.IsType<FilesSettingsWrapper>(response);
        }

        /// <summary>
        /// Test HideConfirmCancelOperation
        /// </summary>
        [Fact]
        public void HideConfirmCancelOperationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SettingsRequestDto? settingsRequestDto = null;
            //var response = instance.HideConfirmCancelOperation(settingsRequestDto);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test HideConfirmConvert
        /// </summary>
        [Fact]
        public void HideConfirmConvertTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //HideConfirmConvertRequestDto? hideConfirmConvertRequestDto = null;
            //var response = instance.HideConfirmConvert(hideConfirmConvertRequestDto);
            //Assert.IsType<ModuleWrapper>(response);
        }

        /// <summary>
        /// Test HideConfirmRoomLifetime
        /// </summary>
        [Fact]
        public void HideConfirmRoomLifetimeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SettingsRequestDto? settingsRequestDto = null;
            //var response = instance.HideConfirmRoomLifetime(settingsRequestDto);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test IsAvailablePrivacyRoomSettings
        /// </summary>
        [Fact]
        public void IsAvailablePrivacyRoomSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.IsAvailablePrivacyRoomSettings();
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test KeepNewFileName
        /// </summary>
        [Fact]
        public void KeepNewFileNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SettingsRequestDto? settingsRequestDto = null;
            //var response = instance.KeepNewFileName(settingsRequestDto);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test SetOpenEditorInSameTab
        /// </summary>
        [Fact]
        public void SetOpenEditorInSameTabTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SettingsRequestDto? settingsRequestDto = null;
            //var response = instance.SetOpenEditorInSameTab(settingsRequestDto);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test StoreForcesave
        /// </summary>
        [Fact]
        public void StoreForcesaveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.StoreForcesave();
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test StoreOriginal
        /// </summary>
        [Fact]
        public void StoreOriginalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SettingsRequestDto? settingsRequestDto = null;
            //var response = instance.StoreOriginal(settingsRequestDto);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test UpdateFileIfExist
        /// </summary>
        [Fact]
        public void UpdateFileIfExistTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SettingsRequestDto? settingsRequestDto = null;
            //var response = instance.UpdateFileIfExist(settingsRequestDto);
            //Assert.IsType<BooleanWrapper>(response);
        }
    }
}
