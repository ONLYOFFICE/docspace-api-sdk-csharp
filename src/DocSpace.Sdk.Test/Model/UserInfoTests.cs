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
using DocSpace.Sdk.Model;
using DocSpace.Sdk.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace DocSpace.Sdk.Test.Model
{
    /// <summary>
    ///  Class for testing UserInfo
    /// </summary>
    public class UserInfoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UserInfo
        //private UserInfo instance;

        public UserInfoTests()
        {
            // TODO uncomment below to create an instance of UserInfo
            //instance = new UserInfo();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserInfo
        /// </summary>
        [Fact]
        public void UserInfoInstanceTest()
        {
            // TODO uncomment below to test "IsType" UserInfo
            //Assert.IsType<UserInfo>(instance);
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
        /// Test the property 'UserName'
        /// </summary>
        [Fact]
        public void UserNameTest()
        {
            // TODO unit test for the property 'UserName'
        }

        /// <summary>
        /// Test the property 'BirthDate'
        /// </summary>
        [Fact]
        public void BirthDateTest()
        {
            // TODO unit test for the property 'BirthDate'
        }

        /// <summary>
        /// Test the property 'Sex'
        /// </summary>
        [Fact]
        public void SexTest()
        {
            // TODO unit test for the property 'Sex'
        }

        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }

        /// <summary>
        /// Test the property 'ActivationStatus'
        /// </summary>
        [Fact]
        public void ActivationStatusTest()
        {
            // TODO unit test for the property 'ActivationStatus'
        }

        /// <summary>
        /// Test the property 'TerminatedDate'
        /// </summary>
        [Fact]
        public void TerminatedDateTest()
        {
            // TODO unit test for the property 'TerminatedDate'
        }

        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Fact]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }

        /// <summary>
        /// Test the property 'WorkFromDate'
        /// </summary>
        [Fact]
        public void WorkFromDateTest()
        {
            // TODO unit test for the property 'WorkFromDate'
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
        /// Test the property 'Contacts'
        /// </summary>
        [Fact]
        public void ContactsTest()
        {
            // TODO unit test for the property 'Contacts'
        }

        /// <summary>
        /// Test the property 'ContactsList'
        /// </summary>
        [Fact]
        public void ContactsListTest()
        {
            // TODO unit test for the property 'ContactsList'
        }

        /// <summary>
        /// Test the property 'Location'
        /// </summary>
        [Fact]
        public void LocationTest()
        {
            // TODO unit test for the property 'Location'
        }

        /// <summary>
        /// Test the property 'Notes'
        /// </summary>
        [Fact]
        public void NotesTest()
        {
            // TODO unit test for the property 'Notes'
        }

        /// <summary>
        /// Test the property 'Removed'
        /// </summary>
        [Fact]
        public void RemovedTest()
        {
            // TODO unit test for the property 'Removed'
        }

        /// <summary>
        /// Test the property 'LastModified'
        /// </summary>
        [Fact]
        public void LastModifiedTest()
        {
            // TODO unit test for the property 'LastModified'
        }

        /// <summary>
        /// Test the property 'TenantId'
        /// </summary>
        [Fact]
        public void TenantIdTest()
        {
            // TODO unit test for the property 'TenantId'
        }

        /// <summary>
        /// Test the property 'IsActive'
        /// </summary>
        [Fact]
        public void IsActiveTest()
        {
            // TODO unit test for the property 'IsActive'
        }

        /// <summary>
        /// Test the property 'CultureName'
        /// </summary>
        [Fact]
        public void CultureNameTest()
        {
            // TODO unit test for the property 'CultureName'
        }

        /// <summary>
        /// Test the property 'MobilePhone'
        /// </summary>
        [Fact]
        public void MobilePhoneTest()
        {
            // TODO unit test for the property 'MobilePhone'
        }

        /// <summary>
        /// Test the property 'MobilePhoneActivationStatus'
        /// </summary>
        [Fact]
        public void MobilePhoneActivationStatusTest()
        {
            // TODO unit test for the property 'MobilePhoneActivationStatus'
        }

        /// <summary>
        /// Test the property 'Sid'
        /// </summary>
        [Fact]
        public void SidTest()
        {
            // TODO unit test for the property 'Sid'
        }

        /// <summary>
        /// Test the property 'LdapQouta'
        /// </summary>
        [Fact]
        public void LdapQoutaTest()
        {
            // TODO unit test for the property 'LdapQouta'
        }

        /// <summary>
        /// Test the property 'SsoNameId'
        /// </summary>
        [Fact]
        public void SsoNameIdTest()
        {
            // TODO unit test for the property 'SsoNameId'
        }

        /// <summary>
        /// Test the property 'SsoSessionId'
        /// </summary>
        [Fact]
        public void SsoSessionIdTest()
        {
            // TODO unit test for the property 'SsoSessionId'
        }

        /// <summary>
        /// Test the property 'CreateDate'
        /// </summary>
        [Fact]
        public void CreateDateTest()
        {
            // TODO unit test for the property 'CreateDate'
        }

        /// <summary>
        /// Test the property 'CreatedBy'
        /// </summary>
        [Fact]
        public void CreatedByTest()
        {
            // TODO unit test for the property 'CreatedBy'
        }

        /// <summary>
        /// Test the property 'Spam'
        /// </summary>
        [Fact]
        public void SpamTest()
        {
            // TODO unit test for the property 'Spam'
        }

        /// <summary>
        /// Test the property 'CheckActivation'
        /// </summary>
        [Fact]
        public void CheckActivationTest()
        {
            // TODO unit test for the property 'CheckActivation'
        }
    }
}
