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
using DocSpace.Model;
using DocSpace.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace DocSpace.Test.Model
{
    /// <summary>
    ///  Class for testing MigratingApiUser
    /// </summary>
    public class MigratingApiUserTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MigratingApiUser
        //private MigratingApiUser instance;

        public MigratingApiUserTests()
        {
            // TODO uncomment below to create an instance of MigratingApiUser
            //instance = new MigratingApiUser();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MigratingApiUser
        /// </summary>
        [Fact]
        public void MigratingApiUserInstanceTest()
        {
            // TODO uncomment below to test "IsType" MigratingApiUser
            //Assert.IsType<MigratingApiUser>(instance);
        }

        /// <summary>
        /// Test the property 'ShouldImport'
        /// </summary>
        [Fact]
        public void ShouldImportTest()
        {
            // TODO unit test for the property 'ShouldImport'
        }

        /// <summary>
        /// Test the property 'Key'
        /// </summary>
        [Fact]
        public void KeyTest()
        {
            // TODO unit test for the property 'Key'
        }

        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Fact]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }

        /// <summary>
        /// Test the property 'DisplayName'
        /// </summary>
        [Fact]
        public void DisplayNameTest()
        {
            // TODO unit test for the property 'DisplayName'
        }

        /// <summary>
        /// Test the property 'FirstName'
        /// </summary>
        [Fact]
        public void FirstNameTest()
        {
            // TODO unit test for the property 'FirstName'
        }

        /// <summary>
        /// Test the property 'LastName'
        /// </summary>
        [Fact]
        public void LastNameTest()
        {
            // TODO unit test for the property 'LastName'
        }

        /// <summary>
        /// Test the property 'UserType'
        /// </summary>
        [Fact]
        public void UserTypeTest()
        {
            // TODO unit test for the property 'UserType'
        }

        /// <summary>
        /// Test the property 'MigratingFiles'
        /// </summary>
        [Fact]
        public void MigratingFilesTest()
        {
            // TODO unit test for the property 'MigratingFiles'
        }
    }
}
