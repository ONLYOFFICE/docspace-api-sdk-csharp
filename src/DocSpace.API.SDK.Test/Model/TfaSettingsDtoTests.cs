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
    ///  Class for testing TfaSettingsDto
    /// </summary>
    public class TfaSettingsDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TfaSettingsDto
        //private TfaSettingsDto instance;

        public TfaSettingsDtoTests()
        {
            // TODO uncomment below to create an instance of TfaSettingsDto
            //instance = new TfaSettingsDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TfaSettingsDto
        /// </summary>
        [Fact]
        public void TfaSettingsDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" TfaSettingsDto
            //Assert.IsType<TfaSettingsDto>(instance);
        }



        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }


        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Fact]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }


        /// <summary>
        /// Test the property 'Enabled'
        /// </summary>
        [Fact]
        public void EnabledTest()
        {
            // TODO unit test for the property 'Enabled'
        }


        /// <summary>
        /// Test the property 'Avaliable'
        /// </summary>
        [Fact]
        public void AvaliableTest()
        {
            // TODO unit test for the property 'Avaliable'
        }


        /// <summary>
        /// Test the property 'TrustedIps'
        /// </summary>
        [Fact]
        public void TrustedIpsTest()
        {
            // TODO unit test for the property 'TrustedIps'
        }


        /// <summary>
        /// Test the property 'MandatoryUsers'
        /// </summary>
        [Fact]
        public void MandatoryUsersTest()
        {
            // TODO unit test for the property 'MandatoryUsers'
        }


        /// <summary>
        /// Test the property 'MandatoryGroups'
        /// </summary>
        [Fact]
        public void MandatoryGroupsTest()
        {
            // TODO unit test for the property 'MandatoryGroups'
        }
    }
}
