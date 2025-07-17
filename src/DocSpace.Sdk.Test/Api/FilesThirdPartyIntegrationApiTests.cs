/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

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
    ///  Class for testing FilesThirdPartyIntegrationApi
    /// </summary>
    public class FilesThirdPartyIntegrationApiTests : IDisposable
    {
        private FilesThirdPartyIntegrationApi instance;

        public FilesThirdPartyIntegrationApiTests()
        {
            instance = new FilesThirdPartyIntegrationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FilesThirdPartyIntegrationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FilesThirdPartyIntegrationApi
            //Assert.IsType<FilesThirdPartyIntegrationApi>(instance);
        }

        /// <summary>
        /// Test DeleteThirdParty
        /// </summary>
        [Fact]
        public void DeleteThirdPartyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int providerId = null;
            //var response = instance.DeleteThirdParty(providerId);
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test GetAllProviders
        /// </summary>
        [Fact]
        public void GetAllProvidersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllProviders();
            //Assert.IsType<ProviderArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetBackupThirdPartyAccount
        /// </summary>
        [Fact]
        public void GetBackupThirdPartyAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetBackupThirdPartyAccount();
            //Assert.IsType<FolderStringWrapper>(response);
        }

        /// <summary>
        /// Test GetCapabilities
        /// </summary>
        [Fact]
        public void GetCapabilitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetCapabilities();
            //Assert.IsType<ArrayArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetCommonThirdPartyFolders
        /// </summary>
        [Fact]
        public void GetCommonThirdPartyFoldersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetCommonThirdPartyFolders();
            //Assert.IsType<FolderStringArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetThirdPartyAccounts
        /// </summary>
        [Fact]
        public void GetThirdPartyAccountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetThirdPartyAccounts();
            //Assert.IsType<ThirdPartyParamsArrayWrapper>(response);
        }

        /// <summary>
        /// Test SaveThirdParty
        /// </summary>
        [Fact]
        public void SaveThirdPartyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ThirdPartyRequestDto? thirdPartyRequestDto = null;
            //var response = instance.SaveThirdParty(thirdPartyRequestDto);
            //Assert.IsType<FolderStringWrapper>(response);
        }

        /// <summary>
        /// Test SaveThirdPartyBackup
        /// </summary>
        [Fact]
        public void SaveThirdPartyBackupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ThirdPartyBackupRequestDto? thirdPartyBackupRequestDto = null;
            //var response = instance.SaveThirdPartyBackup(thirdPartyBackupRequestDto);
            //Assert.IsType<FolderStringWrapper>(response);
        }
    }
}
