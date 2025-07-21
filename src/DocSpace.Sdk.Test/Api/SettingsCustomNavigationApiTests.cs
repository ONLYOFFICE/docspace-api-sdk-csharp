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
    ///  Class for testing SettingsCustomNavigationApi
    /// </summary>
    public class SettingsCustomNavigationApiTests : IDisposable
    {
        private SettingsCustomNavigationApi instance;

        public SettingsCustomNavigationApiTests()
        {
            instance = new SettingsCustomNavigationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsCustomNavigationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SettingsCustomNavigationApi
            //Assert.IsType<SettingsCustomNavigationApi>(instance);
        }

        /// <summary>
        /// Test CreateCustomNavigationItem
        /// </summary>
        [Fact]
        public void CreateCustomNavigationItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CustomNavigationItem? customNavigationItem = null;
            //var response = instance.CreateCustomNavigationItem(customNavigationItem);
            //Assert.IsType<CustomNavigationItemWrapper>(response);
        }

        /// <summary>
        /// Test DeleteCustomNavigationItem
        /// </summary>
        [Fact]
        public void DeleteCustomNavigationItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //instance.DeleteCustomNavigationItem(id);
        }

        /// <summary>
        /// Test GetCustomNavigationItem
        /// </summary>
        [Fact]
        public void GetCustomNavigationItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.GetCustomNavigationItem(id);
            //Assert.IsType<CustomNavigationItemWrapper>(response);
        }

        /// <summary>
        /// Test GetCustomNavigationItemSample
        /// </summary>
        [Fact]
        public void GetCustomNavigationItemSampleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetCustomNavigationItemSample();
            //Assert.IsType<CustomNavigationItemWrapper>(response);
        }

        /// <summary>
        /// Test GetCustomNavigationItems
        /// </summary>
        [Fact]
        public void GetCustomNavigationItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetCustomNavigationItems();
            //Assert.IsType<CustomNavigationItemArrayWrapper>(response);
        }
    }
}
