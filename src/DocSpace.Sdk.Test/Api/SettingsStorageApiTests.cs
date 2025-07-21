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

using DocSpace.Sdk.Client;
using DocSpace.Sdk.Api;
// uncomment below to import models
//using DocSpace.Sdk.Model;

namespace DocSpace.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing SettingsStorageApi
    /// </summary>
    public class SettingsStorageApiTests : IDisposable
    {
        private SettingsStorageApi instance;

        public SettingsStorageApiTests()
        {
            instance = new SettingsStorageApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsStorageApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SettingsStorageApi
            //Assert.IsType<SettingsStorageApi>(instance);
        }

        /// <summary>
        /// Test GetAllBackupStorages
        /// </summary>
        [Fact]
        public void GetAllBackupStoragesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? dump = null;
            //var response = instance.GetAllBackupStorages(dump);
            //Assert.IsType<StorageArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetAllCdnStorages
        /// </summary>
        [Fact]
        public void GetAllCdnStoragesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllCdnStorages();
            //Assert.IsType<StorageArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetAllStorages
        /// </summary>
        [Fact]
        public void GetAllStoragesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllStorages();
            //Assert.IsType<StorageArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetAmazonS3Regions
        /// </summary>
        [Fact]
        public void GetAmazonS3RegionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAmazonS3Regions();
            //Assert.IsType<ObjectWrapper>(response);
        }

        /// <summary>
        /// Test GetStorageProgress
        /// </summary>
        [Fact]
        public void GetStorageProgressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetStorageProgress();
            //Assert.IsType<DoubleWrapper>(response);
        }

        /// <summary>
        /// Test ResetCdnToDefault
        /// </summary>
        [Fact]
        public void ResetCdnToDefaultTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.ResetCdnToDefault();
        }

        /// <summary>
        /// Test ResetStorageToDefault
        /// </summary>
        [Fact]
        public void ResetStorageToDefaultTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.ResetStorageToDefault();
        }

        /// <summary>
        /// Test UpdateCdnStorage
        /// </summary>
        [Fact]
        public void UpdateCdnStorageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //StorageRequestsDto? storageRequestsDto = null;
            //var response = instance.UpdateCdnStorage(storageRequestsDto);
            //Assert.IsType<CdnStorageSettingsWrapper>(response);
        }

        /// <summary>
        /// Test UpdateStorage
        /// </summary>
        [Fact]
        public void UpdateStorageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //StorageRequestsDto? storageRequestsDto = null;
            //var response = instance.UpdateStorage(storageRequestsDto);
            //Assert.IsType<StorageSettingsWrapper>(response);
        }
    }
}
