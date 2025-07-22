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
    ///  Class for testing UpdateApiKeyRequest
    /// </summary>
    public class UpdateApiKeyRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UpdateApiKeyRequest
        //private UpdateApiKeyRequest instance;

        public UpdateApiKeyRequestTests()
        {
            // TODO uncomment below to create an instance of UpdateApiKeyRequest
            //instance = new UpdateApiKeyRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UpdateApiKeyRequest
        /// </summary>
        [Fact]
        public void UpdateApiKeyRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" UpdateApiKeyRequest
            //Assert.IsType<UpdateApiKeyRequest>(instance);
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
        /// Test the property 'Permissions'
        /// </summary>
        [Fact]
        public void PermissionsTest()
        {
            // TODO unit test for the property 'Permissions'
        }


        /// <summary>
        /// Test the property 'IsActive'
        /// </summary>
        [Fact]
        public void IsActiveTest()
        {
            // TODO unit test for the property 'IsActive'
        }
    }
}
