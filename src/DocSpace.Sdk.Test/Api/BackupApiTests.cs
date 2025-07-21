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
    ///  Class for testing BackupApi
    /// </summary>
    public class BackupApiTests : IDisposable
    {
        private BackupApi instance;

        public BackupApiTests()
        {
            instance = new BackupApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BackupApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BackupApi
            //Assert.IsType<BackupApi>(instance);
        }

        /// <summary>
        /// Test CreateBackupSchedule
        /// </summary>
        [Fact]
        public void CreateBackupScheduleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BackupScheduleDto? backupScheduleDto = null;
            //var response = instance.CreateBackupSchedule(backupScheduleDto);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test DeleteBackup
        /// </summary>
        [Fact]
        public void DeleteBackupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.DeleteBackup(id);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test DeleteBackupHistory
        /// </summary>
        [Fact]
        public void DeleteBackupHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? dump = null;
            //var response = instance.DeleteBackupHistory(dump);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test DeleteBackupSchedule
        /// </summary>
        [Fact]
        public void DeleteBackupScheduleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? dump = null;
            //var response = instance.DeleteBackupSchedule(dump);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test GetBackupHistory
        /// </summary>
        [Fact]
        public void GetBackupHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? dump = null;
            //var response = instance.GetBackupHistory(dump);
            //Assert.IsType<BackupHistoryRecordArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetBackupProgress
        /// </summary>
        [Fact]
        public void GetBackupProgressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? dump = null;
            //var response = instance.GetBackupProgress(dump);
            //Assert.IsType<BackupProgressWrapper>(response);
        }

        /// <summary>
        /// Test GetBackupSchedule
        /// </summary>
        [Fact]
        public void GetBackupScheduleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? dump = null;
            //var response = instance.GetBackupSchedule(dump);
            //Assert.IsType<ScheduleWrapper>(response);
        }

        /// <summary>
        /// Test GetRestoreProgress
        /// </summary>
        [Fact]
        public void GetRestoreProgressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? dump = null;
            //var response = instance.GetRestoreProgress(dump);
            //Assert.IsType<BackupProgressWrapper>(response);
        }

        /// <summary>
        /// Test StartBackup
        /// </summary>
        [Fact]
        public void StartBackupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BackupDto? backupDto = null;
            //var response = instance.StartBackup(backupDto);
            //Assert.IsType<BackupProgressWrapper>(response);
        }

        /// <summary>
        /// Test StartBackupRestore
        /// </summary>
        [Fact]
        public void StartBackupRestoreTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BackupRestoreDto? backupRestoreDto = null;
            //var response = instance.StartBackupRestore(backupRestoreDto);
            //Assert.IsType<BackupProgressWrapper>(response);
        }
    }
}
