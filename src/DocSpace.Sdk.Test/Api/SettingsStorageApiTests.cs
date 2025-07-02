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
