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


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Docspace.Model;
using Docspace.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Docspace.Test.Model
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
