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
    ///  Class for testing ProviderDto
    /// </summary>
    public class ProviderDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ProviderDto
        //private ProviderDto instance;

        public ProviderDtoTests()
        {
            // TODO uncomment below to create an instance of ProviderDto
            //instance = new ProviderDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProviderDto
        /// </summary>
        [Fact]
        public void ProviderDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" ProviderDto
            //Assert.IsType<ProviderDto>(instance);
        }



        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }


        /// <summary>
        /// Test the property 'Key'
        /// </summary>
        [Fact]
        public void KeyTest()
        {
            // TODO unit test for the property 'Key'
        }


        /// <summary>
        /// Test the property 'Connected'
        /// </summary>
        [Fact]
        public void ConnectedTest()
        {
            // TODO unit test for the property 'Connected'
        }


        /// <summary>
        /// Test the property 'Oauth'
        /// </summary>
        [Fact]
        public void OauthTest()
        {
            // TODO unit test for the property 'Oauth'
        }


        /// <summary>
        /// Test the property 'RedirectUrl'
        /// </summary>
        [Fact]
        public void RedirectUrlTest()
        {
            // TODO unit test for the property 'RedirectUrl'
        }


        /// <summary>
        /// Test the property 'RequiredConnectionUrl'
        /// </summary>
        [Fact]
        public void RequiredConnectionUrlTest()
        {
            // TODO unit test for the property 'RequiredConnectionUrl'
        }


        /// <summary>
        /// Test the property 'ClientId'
        /// </summary>
        [Fact]
        public void ClientIdTest()
        {
            // TODO unit test for the property 'ClientId'
        }
    }
}
