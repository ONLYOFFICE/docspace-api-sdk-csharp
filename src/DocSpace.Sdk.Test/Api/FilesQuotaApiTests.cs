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
    ///  Class for testing FilesQuotaApi
    /// </summary>
    public class FilesQuotaApiTests : IDisposable
    {
        private FilesQuotaApi instance;

        public FilesQuotaApiTests()
        {
            instance = new FilesQuotaApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FilesQuotaApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FilesQuotaApi
            //Assert.IsType<FilesQuotaApi>(instance);
        }

        /// <summary>
        /// Test ResetRoomQuota
        /// </summary>
        [Fact]
        public void ResetRoomQuotaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateRoomsRoomIdsRequestDtoInteger? updateRoomsRoomIdsRequestDtoInteger = null;
            //var response = instance.ResetRoomQuota(updateRoomsRoomIdsRequestDtoInteger);
            //Assert.IsType<FolderIntegerArrayWrapper>(response);
        }

        /// <summary>
        /// Test UpdateRoomsQuota
        /// </summary>
        [Fact]
        public void UpdateRoomsQuotaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateRoomsQuotaRequestDtoInteger? updateRoomsQuotaRequestDtoInteger = null;
            //var response = instance.UpdateRoomsQuota(updateRoomsQuotaRequestDtoInteger);
            //Assert.IsType<FolderIntegerArrayWrapper>(response);
        }
    }
}
