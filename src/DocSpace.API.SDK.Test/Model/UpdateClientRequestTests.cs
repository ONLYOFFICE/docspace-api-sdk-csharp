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
    ///  Class for testing UpdateClientRequest
    /// </summary>
    public class UpdateClientRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UpdateClientRequest
        //private UpdateClientRequest instance;

        public UpdateClientRequestTests()
        {
            // TODO uncomment below to create an instance of UpdateClientRequest
            //instance = new UpdateClientRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UpdateClientRequest
        /// </summary>
        [Fact]
        public void UpdateClientRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" UpdateClientRequest
            //Assert.IsType<UpdateClientRequest>(instance);
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
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }


        /// <summary>
        /// Test the property 'Logo'
        /// </summary>
        [Fact]
        public void LogoTest()
        {
            // TODO unit test for the property 'Logo'
        }


        /// <summary>
        /// Test the property 'AllowPkce'
        /// </summary>
        [Fact]
        public void AllowPkceTest()
        {
            // TODO unit test for the property 'AllowPkce'
        }


        /// <summary>
        /// Test the property 'IsPublic'
        /// </summary>
        [Fact]
        public void IsPublicTest()
        {
            // TODO unit test for the property 'IsPublic'
        }


        /// <summary>
        /// Test the property 'AllowedOrigins'
        /// </summary>
        [Fact]
        public void AllowedOriginsTest()
        {
            // TODO unit test for the property 'AllowedOrigins'
        }
    }
}
