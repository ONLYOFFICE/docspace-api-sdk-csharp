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
    ///  Class for testing SettingsSecurityApi
    /// </summary>
    public class SettingsSecurityApiTests : IDisposable
    {
        private SettingsSecurityApi instance;

        public SettingsSecurityApiTests()
        {
            instance = new SettingsSecurityApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsSecurityApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SettingsSecurityApi
            //Assert.IsType<SettingsSecurityApi>(instance);
        }

        /// <summary>
        /// Test GetEnabledModules
        /// </summary>
        [Fact]
        public void GetEnabledModulesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetEnabledModules();
            //Assert.IsType<ObjectWrapper>(response);
        }

        /// <summary>
        /// Test GetIsProductAdministrator
        /// </summary>
        [Fact]
        public void GetIsProductAdministratorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? productid = null;
            //Guid? userid = null;
            //var response = instance.GetIsProductAdministrator(productid, userid);
            //Assert.IsType<ProductAdministratorWrapper>(response);
        }

        /// <summary>
        /// Test GetPasswordSettings
        /// </summary>
        [Fact]
        public void GetPasswordSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPasswordSettings();
            //Assert.IsType<PasswordSettingsWrapper>(response);
        }

        /// <summary>
        /// Test GetProductAdministrators
        /// </summary>
        [Fact]
        public void GetProductAdministratorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid productid = null;
            //var response = instance.GetProductAdministrators(productid);
            //Assert.IsType<EmployeeArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetWebItemSecurityInfo
        /// </summary>
        [Fact]
        public void GetWebItemSecurityInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.GetWebItemSecurityInfo(id);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test GetWebItemSettingsSecurityInfo
        /// </summary>
        [Fact]
        public void GetWebItemSettingsSecurityInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string>? ids = null;
            //var response = instance.GetWebItemSettingsSecurityInfo(ids);
            //Assert.IsType<SecurityArrayWrapper>(response);
        }

        /// <summary>
        /// Test SetAccessToWebItems
        /// </summary>
        [Fact]
        public void SetAccessToWebItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WebItemsSecurityRequestsDto? webItemsSecurityRequestsDto = null;
            //var response = instance.SetAccessToWebItems(webItemsSecurityRequestsDto);
            //Assert.IsType<SecurityArrayWrapper>(response);
        }

        /// <summary>
        /// Test SetProductAdministrator
        /// </summary>
        [Fact]
        public void SetProductAdministratorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SecurityRequestsDto? securityRequestsDto = null;
            //var response = instance.SetProductAdministrator(securityRequestsDto);
            //Assert.IsType<ProductAdministratorWrapper>(response);
        }

        /// <summary>
        /// Test SetWebItemSecurity
        /// </summary>
        [Fact]
        public void SetWebItemSecurityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WebItemSecurityRequestsDto? webItemSecurityRequestsDto = null;
            //var response = instance.SetWebItemSecurity(webItemSecurityRequestsDto);
            //Assert.IsType<SecurityArrayWrapper>(response);
        }

        /// <summary>
        /// Test UpdatePasswordSettings
        /// </summary>
        [Fact]
        public void UpdatePasswordSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PasswordSettingsRequestsDto? passwordSettingsRequestsDto = null;
            //var response = instance.UpdatePasswordSettings(passwordSettingsRequestsDto);
            //Assert.IsType<PasswordSettingsWrapper>(response);
        }
    }
}
