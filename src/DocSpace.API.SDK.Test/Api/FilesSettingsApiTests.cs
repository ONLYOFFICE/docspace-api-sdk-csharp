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

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Api;
// uncomment below to import models
//using DocSpace.API.SDK.Model;

namespace DocSpace.API.SDK.Test.Api
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
