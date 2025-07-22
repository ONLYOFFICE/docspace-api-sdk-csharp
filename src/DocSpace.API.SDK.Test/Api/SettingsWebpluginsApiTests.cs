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
    ///  Class for testing SettingsWebpluginsApi
    /// </summary>
    public class SettingsWebpluginsApiTests : IDisposable
    {
        private SettingsWebpluginsApi instance;

        public SettingsWebpluginsApiTests()
        {
            instance = new SettingsWebpluginsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsWebpluginsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SettingsWebpluginsApi
            //Assert.IsType<SettingsWebpluginsApi>(instance);
        }

        /// <summary>
        /// Test AddWebPluginFromFile
        /// </summary>
        [Fact]
        public void AddWebPluginFromFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? @system = null;
            //var response = instance.AddWebPluginFromFile(@system);
            //Assert.IsType<WebPluginWrapper>(response);
        }

        /// <summary>
        /// Test DeleteWebPlugin
        /// </summary>
        [Fact]
        public void DeleteWebPluginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //instance.DeleteWebPlugin(name);
        }

        /// <summary>
        /// Test GetWebPlugin
        /// </summary>
        [Fact]
        public void GetWebPluginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.GetWebPlugin(name);
            //Assert.IsType<WebPluginWrapper>(response);
        }

        /// <summary>
        /// Test GetWebPlugins
        /// </summary>
        [Fact]
        public void GetWebPluginsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? enabled = null;
            //var response = instance.GetWebPlugins(enabled);
            //Assert.IsType<WebPluginArrayWrapper>(response);
        }

        /// <summary>
        /// Test UpdateWebPlugin
        /// </summary>
        [Fact]
        public void UpdateWebPluginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //WebPluginRequests? webPluginRequests = null;
            //instance.UpdateWebPlugin(name, webPluginRequests);
        }
    }
}
