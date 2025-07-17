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


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using DocSpace.Sdk.Model;
using DocSpace.Sdk.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace DocSpace.Sdk.Test.Model
{
    /// <summary>
    ///  Class for testing BackupRestoreDto
    /// </summary>
    public class BackupRestoreDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for BackupRestoreDto
        //private BackupRestoreDto instance;

        public BackupRestoreDtoTests()
        {
            // TODO uncomment below to create an instance of BackupRestoreDto
            //instance = new BackupRestoreDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BackupRestoreDto
        /// </summary>
        [Fact]
        public void BackupRestoreDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" BackupRestoreDto
            //Assert.IsType<BackupRestoreDto>(instance);
        }



        /// <summary>
        /// Test the property 'BackupId'
        /// </summary>
        [Fact]
        public void BackupIdTest()
        {
            // TODO unit test for the property 'BackupId'
        }


        /// <summary>
        /// Test the property 'StorageType'
        /// </summary>
        [Fact]
        public void StorageTypeTest()
        {
            // TODO unit test for the property 'StorageType'
        }


        /// <summary>
        /// Test the property 'StorageParams'
        /// </summary>
        [Fact]
        public void StorageParamsTest()
        {
            // TODO unit test for the property 'StorageParams'
        }


        /// <summary>
        /// Test the property 'Notify'
        /// </summary>
        [Fact]
        public void NotifyTest()
        {
            // TODO unit test for the property 'Notify'
        }


        /// <summary>
        /// Test the property 'Dump'
        /// </summary>
        [Fact]
        public void DumpTest()
        {
            // TODO unit test for the property 'Dump'
        }
    }
}
