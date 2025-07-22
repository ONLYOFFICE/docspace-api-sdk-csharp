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
using DocSpace.API.SDK.Model;
using DocSpace.API.SDK.Client;
using System.Reflection;
using System.Text.Json;

namespace DocSpace.API.SDK.Test.Model
{
    /// <summary>
    ///  Class for testing WizardRequestsDto
    /// </summary>
    public class WizardRequestsDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for WizardRequestsDto
        //private WizardRequestsDto instance;

        public WizardRequestsDtoTests()
        {
            // TODO uncomment below to create an instance of WizardRequestsDto
            //instance = new WizardRequestsDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WizardRequestsDto
        /// </summary>
        [Fact]
        public void WizardRequestsDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" WizardRequestsDto
            //Assert.IsType<WizardRequestsDto>(instance);
        }



        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Fact]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }


        /// <summary>
        /// Test the property 'PasswordHash'
        /// </summary>
        [Fact]
        public void PasswordHashTest()
        {
            // TODO unit test for the property 'PasswordHash'
        }


        /// <summary>
        /// Test the property 'Lng'
        /// </summary>
        [Fact]
        public void LngTest()
        {
            // TODO unit test for the property 'Lng'
        }


        /// <summary>
        /// Test the property '@TimeZone'
        /// </summary>
        [Fact]
        public void @TimeZoneTest()
        {
            // TODO unit test for the property '@TimeZone'
        }


        /// <summary>
        /// Test the property 'AmiId'
        /// </summary>
        [Fact]
        public void AmiIdTest()
        {
            // TODO unit test for the property 'AmiId'
        }


        /// <summary>
        /// Test the property 'SubscribeFromSite'
        /// </summary>
        [Fact]
        public void SubscribeFromSiteTest()
        {
            // TODO unit test for the property 'SubscribeFromSite'
        }
    }
}
