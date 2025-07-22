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

using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Api;
// uncomment below to import models
//using DocSpace.API.SDK.Model;

namespace DocSpace.API.SDK.Test.Api
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
