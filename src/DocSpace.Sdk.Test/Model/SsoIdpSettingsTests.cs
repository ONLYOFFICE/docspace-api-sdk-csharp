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



using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using DocSpace.Sdk.Model;
using DocSpace.Sdk.Client;
using System.Reflection;
using System.Text.Json;

namespace DocSpace.Sdk.Test.Model
{
    /// <summary>
    ///  Class for testing SsoIdpSettings
    /// </summary>
    public class SsoIdpSettingsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SsoIdpSettings
        //private SsoIdpSettings instance;

        public SsoIdpSettingsTests()
        {
            // TODO uncomment below to create an instance of SsoIdpSettings
            //instance = new SsoIdpSettings();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SsoIdpSettings
        /// </summary>
        [Fact]
        public void SsoIdpSettingsInstanceTest()
        {
            // TODO uncomment below to test "IsType" SsoIdpSettings
            //Assert.IsType<SsoIdpSettings>(instance);
        }



        /// <summary>
        /// Test the property 'EntityId'
        /// </summary>
        [Fact]
        public void EntityIdTest()
        {
            // TODO unit test for the property 'EntityId'
        }


        /// <summary>
        /// Test the property 'SsoUrl'
        /// </summary>
        [Fact]
        public void SsoUrlTest()
        {
            // TODO unit test for the property 'SsoUrl'
        }


        /// <summary>
        /// Test the property 'SsoBinding'
        /// </summary>
        [Fact]
        public void SsoBindingTest()
        {
            // TODO unit test for the property 'SsoBinding'
        }


        /// <summary>
        /// Test the property 'SloUrl'
        /// </summary>
        [Fact]
        public void SloUrlTest()
        {
            // TODO unit test for the property 'SloUrl'
        }


        /// <summary>
        /// Test the property 'SloBinding'
        /// </summary>
        [Fact]
        public void SloBindingTest()
        {
            // TODO unit test for the property 'SloBinding'
        }


        /// <summary>
        /// Test the property 'NameIdFormat'
        /// </summary>
        [Fact]
        public void NameIdFormatTest()
        {
            // TODO unit test for the property 'NameIdFormat'
        }
    }
}
