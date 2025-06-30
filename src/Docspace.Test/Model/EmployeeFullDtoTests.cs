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
    ///  Class for testing EmployeeFullDto
    /// </summary>
    public class EmployeeFullDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for EmployeeFullDto
        //private EmployeeFullDto instance;

        public EmployeeFullDtoTests()
        {
            // TODO uncomment below to create an instance of EmployeeFullDto
            //instance = new EmployeeFullDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EmployeeFullDto
        /// </summary>
        [Fact]
        public void EmployeeFullDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" EmployeeFullDto
            //Assert.IsType<EmployeeFullDto>(instance);
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
        /// Test the property 'DisplayName'
        /// </summary>
        [Fact]
        public void DisplayNameTest()
        {
            // TODO unit test for the property 'DisplayName'
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
        /// Test the property 'Avatar'
        /// </summary>
        [Fact]
        public void AvatarTest()
        {
            // TODO unit test for the property 'Avatar'
        }

        /// <summary>
        /// Test the property 'AvatarOriginal'
        /// </summary>
        [Fact]
        public void AvatarOriginalTest()
        {
            // TODO unit test for the property 'AvatarOriginal'
        }

        /// <summary>
        /// Test the property 'AvatarMax'
        /// </summary>
        [Fact]
        public void AvatarMaxTest()
        {
            // TODO unit test for the property 'AvatarMax'
        }

        /// <summary>
        /// Test the property 'AvatarMedium'
        /// </summary>
        [Fact]
        public void AvatarMediumTest()
        {
            // TODO unit test for the property 'AvatarMedium'
        }

        /// <summary>
        /// Test the property 'AvatarSmall'
        /// </summary>
        [Fact]
        public void AvatarSmallTest()
        {
            // TODO unit test for the property 'AvatarSmall'
        }

        /// <summary>
        /// Test the property 'ProfileUrl'
        /// </summary>
        [Fact]
        public void ProfileUrlTest()
        {
            // TODO unit test for the property 'ProfileUrl'
        }

        /// <summary>
        /// Test the property 'HasAvatar'
        /// </summary>
        [Fact]
        public void HasAvatarTest()
        {
            // TODO unit test for the property 'HasAvatar'
        }

        /// <summary>
        /// Test the property 'IsAnonim'
        /// </summary>
        [Fact]
        public void IsAnonimTest()
        {
            // TODO unit test for the property 'IsAnonim'
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
        /// Test the property 'Birthday'
        /// </summary>
        [Fact]
        public void BirthdayTest()
        {
            // TODO unit test for the property 'Birthday'
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
        /// Test the property 'Terminated'
        /// </summary>
        [Fact]
        public void TerminatedTest()
        {
            // TODO unit test for the property 'Terminated'
        }

        /// <summary>
        /// Test the property 'Department'
        /// </summary>
        [Fact]
        public void DepartmentTest()
        {
            // TODO unit test for the property 'Department'
        }

        /// <summary>
        /// Test the property 'WorkFrom'
        /// </summary>
        [Fact]
        public void WorkFromTest()
        {
            // TODO unit test for the property 'WorkFrom'
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
        /// Test the property 'IsAdmin'
        /// </summary>
        [Fact]
        public void IsAdminTest()
        {
            // TODO unit test for the property 'IsAdmin'
        }

        /// <summary>
        /// Test the property 'IsRoomAdmin'
        /// </summary>
        [Fact]
        public void IsRoomAdminTest()
        {
            // TODO unit test for the property 'IsRoomAdmin'
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
        /// Test the property 'ListAdminModules'
        /// </summary>
        [Fact]
        public void ListAdminModulesTest()
        {
            // TODO unit test for the property 'ListAdminModules'
        }

        /// <summary>
        /// Test the property 'IsOwner'
        /// </summary>
        [Fact]
        public void IsOwnerTest()
        {
            // TODO unit test for the property 'IsOwner'
        }

        /// <summary>
        /// Test the property 'IsVisitor'
        /// </summary>
        [Fact]
        public void IsVisitorTest()
        {
            // TODO unit test for the property 'IsVisitor'
        }

        /// <summary>
        /// Test the property 'IsCollaborator'
        /// </summary>
        [Fact]
        public void IsCollaboratorTest()
        {
            // TODO unit test for the property 'IsCollaborator'
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
        /// Test the property 'IsSSO'
        /// </summary>
        [Fact]
        public void IsSSOTest()
        {
            // TODO unit test for the property 'IsSSO'
        }

        /// <summary>
        /// Test the property 'Theme'
        /// </summary>
        [Fact]
        public void ThemeTest()
        {
            // TODO unit test for the property 'Theme'
        }

        /// <summary>
        /// Test the property 'QuotaLimit'
        /// </summary>
        [Fact]
        public void QuotaLimitTest()
        {
            // TODO unit test for the property 'QuotaLimit'
        }

        /// <summary>
        /// Test the property 'UsedSpace'
        /// </summary>
        [Fact]
        public void UsedSpaceTest()
        {
            // TODO unit test for the property 'UsedSpace'
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
        /// Test the property 'IsCustomQuota'
        /// </summary>
        [Fact]
        public void IsCustomQuotaTest()
        {
            // TODO unit test for the property 'IsCustomQuota'
        }

        /// <summary>
        /// Test the property 'LoginEventId'
        /// </summary>
        [Fact]
        public void LoginEventIdTest()
        {
            // TODO unit test for the property 'LoginEventId'
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
        /// Test the property 'RegistrationDate'
        /// </summary>
        [Fact]
        public void RegistrationDateTest()
        {
            // TODO unit test for the property 'RegistrationDate'
        }

        /// <summary>
        /// Test the property 'HasPersonalFolder'
        /// </summary>
        [Fact]
        public void HasPersonalFolderTest()
        {
            // TODO unit test for the property 'HasPersonalFolder'
        }

        /// <summary>
        /// Test the property 'TfaAppEnabled'
        /// </summary>
        [Fact]
        public void TfaAppEnabledTest()
        {
            // TODO unit test for the property 'TfaAppEnabled'
        }
    }
}
