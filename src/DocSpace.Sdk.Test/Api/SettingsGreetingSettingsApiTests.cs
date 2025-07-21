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
    ///  Class for testing SettingsGreetingSettingsApi
    /// </summary>
    public class SettingsGreetingSettingsApiTests : IDisposable
    {
        private SettingsGreetingSettingsApi instance;

        public SettingsGreetingSettingsApiTests()
        {
            instance = new SettingsGreetingSettingsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsGreetingSettingsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SettingsGreetingSettingsApi
            //Assert.IsType<SettingsGreetingSettingsApi>(instance);
        }

        /// <summary>
        /// Test GetGreetingSettings
        /// </summary>
        [Fact]
        public void GetGreetingSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetGreetingSettings();
            //Assert.IsType<ObjectWrapper>(response);
        }

        /// <summary>
        /// Test GetIsDefaultGreetingSettings
        /// </summary>
        [Fact]
        public void GetIsDefaultGreetingSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetIsDefaultGreetingSettings();
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test RestoreGreetingSettings
        /// </summary>
        [Fact]
        public void RestoreGreetingSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.RestoreGreetingSettings();
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test SaveGreetingSettings
        /// </summary>
        [Fact]
        public void SaveGreetingSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GreetingSettingsRequestsDto? greetingSettingsRequestsDto = null;
            //var response = instance.SaveGreetingSettings(greetingSettingsRequestsDto);
            //Assert.IsType<StringWrapper>(response);
        }
    }
}
