/*
 * Api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using Docspace.Client;
using Docspace.Api;
// uncomment below to import models
//using Docspace.Model;

namespace Docspace.Test.Api
{
    /// <summary>
    ///  Class for testing FilesSettingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
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
        /// Test UpdateIfExist
        /// </summary>
        [Fact]
        public void UpdateIfExistTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SettingsRequestDto? settingsRequestDto = null;
            //var response = instance.UpdateIfExist(settingsRequestDto);
            //Assert.IsType<BooleanWrapper>(response);
        }
    }
}
