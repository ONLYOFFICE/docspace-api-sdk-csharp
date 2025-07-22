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
    ///  Class for testing OAuth20Token
    /// </summary>
    public class OAuth20TokenTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for OAuth20Token
        //private OAuth20Token instance;

        public OAuth20TokenTests()
        {
            // TODO uncomment below to create an instance of OAuth20Token
            //instance = new OAuth20Token();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OAuth20Token
        /// </summary>
        [Fact]
        public void OAuth20TokenInstanceTest()
        {
            // TODO uncomment below to test "IsType" OAuth20Token
            //Assert.IsType<OAuth20Token>(instance);
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
        /// Test the property 'RefreshToken'
        /// </summary>
        [Fact]
        public void RefreshTokenTest()
        {
            // TODO unit test for the property 'RefreshToken'
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
        /// Test the property 'ClientId'
        /// </summary>
        [Fact]
        public void ClientIdTest()
        {
            // TODO unit test for the property 'ClientId'
        }


        /// <summary>
        /// Test the property 'ClientSecret'
        /// </summary>
        [Fact]
        public void ClientSecretTest()
        {
            // TODO unit test for the property 'ClientSecret'
        }


        /// <summary>
        /// Test the property 'RedirectUri'
        /// </summary>
        [Fact]
        public void RedirectUriTest()
        {
            // TODO unit test for the property 'RedirectUri'
        }


        /// <summary>
        /// Test the property 'Timestamp'
        /// </summary>
        [Fact]
        public void TimestampTest()
        {
            // TODO unit test for the property 'Timestamp'
        }


        /// <summary>
        /// Test the property 'IsExpired'
        /// </summary>
        [Fact]
        public void IsExpiredTest()
        {
            // TODO unit test for the property 'IsExpired'
        }
    }
}
