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
    ///  Class for testing GroupDto
    /// </summary>
    public class GroupDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GroupDto
        //private GroupDto instance;

        public GroupDtoTests()
        {
            // TODO uncomment below to create an instance of GroupDto
            //instance = new GroupDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GroupDto
        /// </summary>
        [Fact]
        public void GroupDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" GroupDto
            //Assert.IsType<GroupDto>(instance);
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

        /// <summary>
        /// Test the property 'Parent'
        /// </summary>
        [Fact]
        public void ParentTest()
        {
            // TODO unit test for the property 'Parent'
        }

        /// <summary>
        /// Test the property 'Category'
        /// </summary>
        [Fact]
        public void CategoryTest()
        {
            // TODO unit test for the property 'Category'
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }

        /// <summary>
        /// Test the property 'IsLDAP'
        /// </summary>
        [Fact]
        public void IsLDAPTest()
        {
            // TODO unit test for the property 'IsLDAP'
        }

        /// <summary>
        /// Test the property 'Manager'
        /// </summary>
        [Fact]
        public void ManagerTest()
        {
            // TODO unit test for the property 'Manager'
        }

        /// <summary>
        /// Test the property 'Members'
        /// </summary>
        [Fact]
        public void MembersTest()
        {
            // TODO unit test for the property 'Members'
        }

        /// <summary>
        /// Test the property 'Shared'
        /// </summary>
        [Fact]
        public void SharedTest()
        {
            // TODO unit test for the property 'Shared'
        }

        /// <summary>
        /// Test the property 'MembersCount'
        /// </summary>
        [Fact]
        public void MembersCountTest()
        {
            // TODO unit test for the property 'MembersCount'
        }
    }
}
