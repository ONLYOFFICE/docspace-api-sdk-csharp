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
    ///  Class for testing ExchangeToken200Response
    /// </summary>
    public class ExchangeToken200ResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ExchangeToken200Response
        //private ExchangeToken200Response instance;

        public ExchangeToken200ResponseTests()
        {
            // TODO uncomment below to create an instance of ExchangeToken200Response
            //instance = new ExchangeToken200Response();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ExchangeToken200Response
        /// </summary>
        [Fact]
        public void ExchangeToken200ResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" ExchangeToken200Response
            //Assert.IsType<ExchangeToken200Response>(instance);
        }



        /// <summary>
        /// Test the property 'AccessToken'
        /// </summary>
        [Fact]
        public void AccessTokenTest()
        {
            // TODO unit test for the property 'AccessToken'
        }


        /// <summary>
        /// Test the property 'TokenType'
        /// </summary>
        [Fact]
        public void TokenTypeTest()
        {
            // TODO unit test for the property 'TokenType'
        }


        /// <summary>
        /// Test the property 'ExpiresIn'
        /// </summary>
        [Fact]
        public void ExpiresInTest()
        {
            // TODO unit test for the property 'ExpiresIn'
        }


        /// <summary>
        /// Test the property 'RefreshToken'
        /// </summary>
        [Fact]
        public void RefreshTokenTest()
        {
            // TODO unit test for the property 'RefreshToken'
        }
    }
}
