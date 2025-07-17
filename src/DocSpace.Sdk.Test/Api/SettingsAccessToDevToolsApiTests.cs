/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

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
    ///  Class for testing SettingsAccessToDevToolsApi
    /// </summary>
    public class SettingsAccessToDevToolsApiTests : IDisposable
    {
        private SettingsAccessToDevToolsApi instance;

        public SettingsAccessToDevToolsApiTests()
        {
            instance = new SettingsAccessToDevToolsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsAccessToDevToolsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SettingsAccessToDevToolsApi
            //Assert.IsType<SettingsAccessToDevToolsApi>(instance);
        }

        /// <summary>
        /// Test GetTenantAccessDevToolsSettings
        /// </summary>
        [Fact]
        public void GetTenantAccessDevToolsSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTenantAccessDevToolsSettings();
            //Assert.IsType<TenantDevToolsAccessSettingsWrapper>(response);
        }
    }
}
