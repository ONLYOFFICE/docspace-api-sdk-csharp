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
    ///  Class for testing MigrationApi
    /// </summary>
    public class MigrationApiTests : IDisposable
    {
        private MigrationApi instance;

        public MigrationApiTests()
        {
            instance = new MigrationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MigrationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MigrationApi
            //Assert.IsType<MigrationApi>(instance);
        }

        /// <summary>
        /// Test CancelMigration
        /// </summary>
        [Fact]
        public void CancelMigrationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.CancelMigration();
        }

        /// <summary>
        /// Test ClearMigration
        /// </summary>
        [Fact]
        public void ClearMigrationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.ClearMigration();
        }

        /// <summary>
        /// Test FinishMigration
        /// </summary>
        [Fact]
        public void FinishMigrationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FinishDto? finishDto = null;
            //instance.FinishMigration(finishDto);
        }

        /// <summary>
        /// Test GetMigrationLogs
        /// </summary>
        [Fact]
        public void GetMigrationLogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.GetMigrationLogs();
        }

        /// <summary>
        /// Test GetMigrationStatus
        /// </summary>
        [Fact]
        public void GetMigrationStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetMigrationStatus();
            //Assert.IsType<MigrationStatusWrapper>(response);
        }

        /// <summary>
        /// Test ListMigrations
        /// </summary>
        [Fact]
        public void ListMigrationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListMigrations();
            //Assert.IsType<STRINGArrayWrapper>(response);
        }

        /// <summary>
        /// Test StartMigration
        /// </summary>
        [Fact]
        public void StartMigrationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MigrationApiInfo? migrationApiInfo = null;
            //instance.StartMigration(migrationApiInfo);
        }

        /// <summary>
        /// Test UploadAndInitializeMigration
        /// </summary>
        [Fact]
        public void UploadAndInitializeMigrationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string migratorName = null;
            //instance.UploadAndInitializeMigration(migratorName);
        }
    }
}
