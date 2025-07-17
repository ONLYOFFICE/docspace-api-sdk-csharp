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
    ///  Class for testing SettingsIPRestrictionsApi
    /// </summary>
    public class SettingsIPRestrictionsApiTests : IDisposable
    {
        private SettingsIPRestrictionsApi instance;

        public SettingsIPRestrictionsApiTests()
        {
            instance = new SettingsIPRestrictionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsIPRestrictionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SettingsIPRestrictionsApi
            //Assert.IsType<SettingsIPRestrictionsApi>(instance);
        }

        /// <summary>
        /// Test GetIpRestrictions
        /// </summary>
        [Fact]
        public void GetIpRestrictionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetIpRestrictions();
            //Assert.IsType<IPRestrictionArrayWrapper>(response);
        }

        /// <summary>
        /// Test ReadIpRestrictionsSettings
        /// </summary>
        [Fact]
        public void ReadIpRestrictionsSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ReadIpRestrictionsSettings();
            //Assert.IsType<IPRestrictionsSettingsWrapper>(response);
        }

        /// <summary>
        /// Test SaveIpRestrictions
        /// </summary>
        [Fact]
        public void SaveIpRestrictionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IpRestrictionsDto? ipRestrictionsDto = null;
            //var response = instance.SaveIpRestrictions(ipRestrictionsDto);
            //Assert.IsType<IpRestrictionsWrapper>(response);
        }

        /// <summary>
        /// Test UpdateIpRestrictionsSettings
        /// </summary>
        [Fact]
        public void UpdateIpRestrictionsSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IpRestrictionsDto? ipRestrictionsDto = null;
            //var response = instance.UpdateIpRestrictionsSettings(ipRestrictionsDto);
            //Assert.IsType<IpRestrictionsWrapper>(response);
        }
    }
}
