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

using DocSpace.Client;
using DocSpace.Api;
// uncomment below to import models
//using DocSpace.Model;

namespace DocSpace.Test.Api
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
