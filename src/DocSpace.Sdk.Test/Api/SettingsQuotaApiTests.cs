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

using DocSpace.Sdk.Client;
using DocSpace.Sdk.Api;
// uncomment below to import models
//using DocSpace.Sdk.Model;

namespace DocSpace.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing SettingsQuotaApi
    /// </summary>
    public class SettingsQuotaApiTests : IDisposable
    {
        private SettingsQuotaApi instance;

        public SettingsQuotaApiTests()
        {
            instance = new SettingsQuotaApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsQuotaApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SettingsQuotaApi
            //Assert.IsType<SettingsQuotaApi>(instance);
        }

        /// <summary>
        /// Test GetUserQuotaSettings
        /// </summary>
        [Fact]
        public void GetUserQuotaSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetUserQuotaSettings();
            //Assert.IsType<TenantUserQuotaSettingsWrapper>(response);
        }

        /// <summary>
        /// Test SaveRoomQuotaSettings
        /// </summary>
        [Fact]
        public void SaveRoomQuotaSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QuotaSettingsRequestsDto? quotaSettingsRequestsDto = null;
            //var response = instance.SaveRoomQuotaSettings(quotaSettingsRequestsDto);
            //Assert.IsType<TenantRoomQuotaSettingsWrapper>(response);
        }

        /// <summary>
        /// Test SetTenantQuotaSettings
        /// </summary>
        [Fact]
        public void SetTenantQuotaSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TenantQuotaSettingsRequestsDto? tenantQuotaSettingsRequestsDto = null;
            //var response = instance.SetTenantQuotaSettings(tenantQuotaSettingsRequestsDto);
            //Assert.IsType<TenantQuotaSettingsWrapper>(response);
        }
    }
}
