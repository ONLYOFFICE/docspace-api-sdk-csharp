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
    ///  Class for testing SettingsSSOApi
    /// </summary>
    public class SettingsSSOApiTests : IDisposable
    {
        private SettingsSSOApi instance;

        public SettingsSSOApiTests()
        {
            instance = new SettingsSSOApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsSSOApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SettingsSSOApi
            //Assert.IsType<SettingsSSOApi>(instance);
        }

        /// <summary>
        /// Test GetDefaultSsoSettingsV2
        /// </summary>
        [Fact]
        public void GetDefaultSsoSettingsV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetDefaultSsoSettingsV2();
            //Assert.IsType<SsoSettingsV2Wrapper>(response);
        }

        /// <summary>
        /// Test GetSsoSettingsV2
        /// </summary>
        [Fact]
        public void GetSsoSettingsV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetSsoSettingsV2();
            //Assert.IsType<SsoSettingsV2Wrapper>(response);
        }

        /// <summary>
        /// Test GetSsoSettingsV2Constants
        /// </summary>
        [Fact]
        public void GetSsoSettingsV2ConstantsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetSsoSettingsV2Constants();
            //Assert.IsType<ObjectWrapper>(response);
        }

        /// <summary>
        /// Test ResetSsoSettingsV2
        /// </summary>
        [Fact]
        public void ResetSsoSettingsV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ResetSsoSettingsV2();
            //Assert.IsType<SsoSettingsV2Wrapper>(response);
        }

        /// <summary>
        /// Test SaveSsoSettingsV2
        /// </summary>
        [Fact]
        public void SaveSsoSettingsV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SsoSettingsRequestsDto? ssoSettingsRequestsDto = null;
            //var response = instance.SaveSsoSettingsV2(ssoSettingsRequestsDto);
            //Assert.IsType<SsoSettingsV2Wrapper>(response);
        }
    }
}
