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
    ///  Class for testing MigrationApiInfo
    /// </summary>
    public class MigrationApiInfoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MigrationApiInfo
        //private MigrationApiInfo instance;

        public MigrationApiInfoTests()
        {
            // TODO uncomment below to create an instance of MigrationApiInfo
            //instance = new MigrationApiInfo();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MigrationApiInfo
        /// </summary>
        [Fact]
        public void MigrationApiInfoInstanceTest()
        {
            // TODO uncomment below to test "IsType" MigrationApiInfo
            //Assert.IsType<MigrationApiInfo>(instance);
        }



        /// <summary>
        /// Test the property 'MigratorName'
        /// </summary>
        [Fact]
        public void MigratorNameTest()
        {
            // TODO unit test for the property 'MigratorName'
        }


        /// <summary>
        /// Test the property 'Operation'
        /// </summary>
        [Fact]
        public void OperationTest()
        {
            // TODO unit test for the property 'Operation'
        }


        /// <summary>
        /// Test the property 'FailedArchives'
        /// </summary>
        [Fact]
        public void FailedArchivesTest()
        {
            // TODO unit test for the property 'FailedArchives'
        }


        /// <summary>
        /// Test the property 'Users'
        /// </summary>
        [Fact]
        public void UsersTest()
        {
            // TODO unit test for the property 'Users'
        }


        /// <summary>
        /// Test the property 'WithoutEmailUsers'
        /// </summary>
        [Fact]
        public void WithoutEmailUsersTest()
        {
            // TODO unit test for the property 'WithoutEmailUsers'
        }


        /// <summary>
        /// Test the property 'ExistUsers'
        /// </summary>
        [Fact]
        public void ExistUsersTest()
        {
            // TODO unit test for the property 'ExistUsers'
        }


        /// <summary>
        /// Test the property 'Groups'
        /// </summary>
        [Fact]
        public void GroupsTest()
        {
            // TODO unit test for the property 'Groups'
        }


        /// <summary>
        /// Test the property 'ImportPersonalFiles'
        /// </summary>
        [Fact]
        public void ImportPersonalFilesTest()
        {
            // TODO unit test for the property 'ImportPersonalFiles'
        }


        /// <summary>
        /// Test the property 'ImportSharedFiles'
        /// </summary>
        [Fact]
        public void ImportSharedFilesTest()
        {
            // TODO unit test for the property 'ImportSharedFiles'
        }


        /// <summary>
        /// Test the property 'ImportSharedFolders'
        /// </summary>
        [Fact]
        public void ImportSharedFoldersTest()
        {
            // TODO unit test for the property 'ImportSharedFolders'
        }


        /// <summary>
        /// Test the property 'ImportCommonFiles'
        /// </summary>
        [Fact]
        public void ImportCommonFilesTest()
        {
            // TODO unit test for the property 'ImportCommonFiles'
        }


        /// <summary>
        /// Test the property 'ImportProjectFiles'
        /// </summary>
        [Fact]
        public void ImportProjectFilesTest()
        {
            // TODO unit test for the property 'ImportProjectFiles'
        }


        /// <summary>
        /// Test the property 'ImportGroups'
        /// </summary>
        [Fact]
        public void ImportGroupsTest()
        {
            // TODO unit test for the property 'ImportGroups'
        }


        /// <summary>
        /// Test the property 'SuccessedUsers'
        /// </summary>
        [Fact]
        public void SuccessedUsersTest()
        {
            // TODO unit test for the property 'SuccessedUsers'
        }


        /// <summary>
        /// Test the property 'FailedUsers'
        /// </summary>
        [Fact]
        public void FailedUsersTest()
        {
            // TODO unit test for the property 'FailedUsers'
        }


        /// <summary>
        /// Test the property 'Files'
        /// </summary>
        [Fact]
        public void FilesTest()
        {
            // TODO unit test for the property 'Files'
        }


        /// <summary>
        /// Test the property 'Errors'
        /// </summary>
        [Fact]
        public void ErrorsTest()
        {
            // TODO unit test for the property 'Errors'
        }
    }
}
