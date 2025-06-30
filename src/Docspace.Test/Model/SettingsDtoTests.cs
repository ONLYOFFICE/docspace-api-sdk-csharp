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
    ///  Class for testing SettingsDto
    /// </summary>
    public class SettingsDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SettingsDto
        //private SettingsDto instance;

        public SettingsDtoTests()
        {
            // TODO uncomment below to create an instance of SettingsDto
            //instance = new SettingsDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsDto
        /// </summary>
        [Fact]
        public void SettingsDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" SettingsDto
            //Assert.IsType<SettingsDto>(instance);
        }

        /// <summary>
        /// Test the property 'Timezone'
        /// </summary>
        [Fact]
        public void TimezoneTest()
        {
            // TODO unit test for the property 'Timezone'
        }

        /// <summary>
        /// Test the property 'TrustedDomains'
        /// </summary>
        [Fact]
        public void TrustedDomainsTest()
        {
            // TODO unit test for the property 'TrustedDomains'
        }

        /// <summary>
        /// Test the property 'TrustedDomainsType'
        /// </summary>
        [Fact]
        public void TrustedDomainsTypeTest()
        {
            // TODO unit test for the property 'TrustedDomainsType'
        }

        /// <summary>
        /// Test the property 'Culture'
        /// </summary>
        [Fact]
        public void CultureTest()
        {
            // TODO unit test for the property 'Culture'
        }

        /// <summary>
        /// Test the property 'UtcOffset'
        /// </summary>
        [Fact]
        public void UtcOffsetTest()
        {
            // TODO unit test for the property 'UtcOffset'
        }

        /// <summary>
        /// Test the property 'UtcHoursOffset'
        /// </summary>
        [Fact]
        public void UtcHoursOffsetTest()
        {
            // TODO unit test for the property 'UtcHoursOffset'
        }

        /// <summary>
        /// Test the property 'GreetingSettings'
        /// </summary>
        [Fact]
        public void GreetingSettingsTest()
        {
            // TODO unit test for the property 'GreetingSettings'
        }

        /// <summary>
        /// Test the property 'OwnerId'
        /// </summary>
        [Fact]
        public void OwnerIdTest()
        {
            // TODO unit test for the property 'OwnerId'
        }

        /// <summary>
        /// Test the property 'NameSchemaId'
        /// </summary>
        [Fact]
        public void NameSchemaIdTest()
        {
            // TODO unit test for the property 'NameSchemaId'
        }

        /// <summary>
        /// Test the property 'EnabledJoin'
        /// </summary>
        [Fact]
        public void EnabledJoinTest()
        {
            // TODO unit test for the property 'EnabledJoin'
        }

        /// <summary>
        /// Test the property 'EnableAdmMess'
        /// </summary>
        [Fact]
        public void EnableAdmMessTest()
        {
            // TODO unit test for the property 'EnableAdmMess'
        }

        /// <summary>
        /// Test the property 'ThirdpartyEnable'
        /// </summary>
        [Fact]
        public void ThirdpartyEnableTest()
        {
            // TODO unit test for the property 'ThirdpartyEnable'
        }

        /// <summary>
        /// Test the property 'DocSpace'
        /// </summary>
        [Fact]
        public void DocSpaceTest()
        {
            // TODO unit test for the property 'DocSpace'
        }

        /// <summary>
        /// Test the property 'Standalone'
        /// </summary>
        [Fact]
        public void StandaloneTest()
        {
            // TODO unit test for the property 'Standalone'
        }

        /// <summary>
        /// Test the property 'IsAmi'
        /// </summary>
        [Fact]
        public void IsAmiTest()
        {
            // TODO unit test for the property 'IsAmi'
        }

        /// <summary>
        /// Test the property 'BaseDomain'
        /// </summary>
        [Fact]
        public void BaseDomainTest()
        {
            // TODO unit test for the property 'BaseDomain'
        }

        /// <summary>
        /// Test the property 'WizardToken'
        /// </summary>
        [Fact]
        public void WizardTokenTest()
        {
            // TODO unit test for the property 'WizardToken'
        }

        /// <summary>
        /// Test the property 'PasswordHash'
        /// </summary>
        [Fact]
        public void PasswordHashTest()
        {
            // TODO unit test for the property 'PasswordHash'
        }

        /// <summary>
        /// Test the property 'Firebase'
        /// </summary>
        [Fact]
        public void FirebaseTest()
        {
            // TODO unit test for the property 'Firebase'
        }

        /// <summary>
        /// Test the property 'VarVersion'
        /// </summary>
        [Fact]
        public void VarVersionTest()
        {
            // TODO unit test for the property 'VarVersion'
        }

        /// <summary>
        /// Test the property 'RecaptchaType'
        /// </summary>
        [Fact]
        public void RecaptchaTypeTest()
        {
            // TODO unit test for the property 'RecaptchaType'
        }

        /// <summary>
        /// Test the property 'RecaptchaPublicKey'
        /// </summary>
        [Fact]
        public void RecaptchaPublicKeyTest()
        {
            // TODO unit test for the property 'RecaptchaPublicKey'
        }

        /// <summary>
        /// Test the property 'DebugInfo'
        /// </summary>
        [Fact]
        public void DebugInfoTest()
        {
            // TODO unit test for the property 'DebugInfo'
        }

        /// <summary>
        /// Test the property 'SocketUrl'
        /// </summary>
        [Fact]
        public void SocketUrlTest()
        {
            // TODO unit test for the property 'SocketUrl'
        }

        /// <summary>
        /// Test the property 'TenantStatus'
        /// </summary>
        [Fact]
        public void TenantStatusTest()
        {
            // TODO unit test for the property 'TenantStatus'
        }

        /// <summary>
        /// Test the property 'TenantAlias'
        /// </summary>
        [Fact]
        public void TenantAliasTest()
        {
            // TODO unit test for the property 'TenantAlias'
        }

        /// <summary>
        /// Test the property 'DisplayAbout'
        /// </summary>
        [Fact]
        public void DisplayAboutTest()
        {
            // TODO unit test for the property 'DisplayAbout'
        }

        /// <summary>
        /// Test the property 'DomainValidator'
        /// </summary>
        [Fact]
        public void DomainValidatorTest()
        {
            // TODO unit test for the property 'DomainValidator'
        }

        /// <summary>
        /// Test the property 'ZendeskKey'
        /// </summary>
        [Fact]
        public void ZendeskKeyTest()
        {
            // TODO unit test for the property 'ZendeskKey'
        }

        /// <summary>
        /// Test the property 'TagManagerId'
        /// </summary>
        [Fact]
        public void TagManagerIdTest()
        {
            // TODO unit test for the property 'TagManagerId'
        }

        /// <summary>
        /// Test the property 'CookieSettingsEnabled'
        /// </summary>
        [Fact]
        public void CookieSettingsEnabledTest()
        {
            // TODO unit test for the property 'CookieSettingsEnabled'
        }

        /// <summary>
        /// Test the property 'LimitedAccessSpace'
        /// </summary>
        [Fact]
        public void LimitedAccessSpaceTest()
        {
            // TODO unit test for the property 'LimitedAccessSpace'
        }

        /// <summary>
        /// Test the property 'LimitedAccessDevToolsForUsers'
        /// </summary>
        [Fact]
        public void LimitedAccessDevToolsForUsersTest()
        {
            // TODO unit test for the property 'LimitedAccessDevToolsForUsers'
        }

        /// <summary>
        /// Test the property 'UserNameRegex'
        /// </summary>
        [Fact]
        public void UserNameRegexTest()
        {
            // TODO unit test for the property 'UserNameRegex'
        }

        /// <summary>
        /// Test the property 'InvitationLimit'
        /// </summary>
        [Fact]
        public void InvitationLimitTest()
        {
            // TODO unit test for the property 'InvitationLimit'
        }

        /// <summary>
        /// Test the property 'Plugins'
        /// </summary>
        [Fact]
        public void PluginsTest()
        {
            // TODO unit test for the property 'Plugins'
        }

        /// <summary>
        /// Test the property 'DeepLink'
        /// </summary>
        [Fact]
        public void DeepLinkTest()
        {
            // TODO unit test for the property 'DeepLink'
        }

        /// <summary>
        /// Test the property 'FormGallery'
        /// </summary>
        [Fact]
        public void FormGalleryTest()
        {
            // TODO unit test for the property 'FormGallery'
        }

        /// <summary>
        /// Test the property 'MaxImageUploadSize'
        /// </summary>
        [Fact]
        public void MaxImageUploadSizeTest()
        {
            // TODO unit test for the property 'MaxImageUploadSize'
        }

        /// <summary>
        /// Test the property 'LogoText'
        /// </summary>
        [Fact]
        public void LogoTextTest()
        {
            // TODO unit test for the property 'LogoText'
        }

        /// <summary>
        /// Test the property 'ExternalResources'
        /// </summary>
        [Fact]
        public void ExternalResourcesTest()
        {
            // TODO unit test for the property 'ExternalResources'
        }
    }
}
