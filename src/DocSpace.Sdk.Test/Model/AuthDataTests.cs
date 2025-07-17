/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using DocSpace.Sdk.Model;
using DocSpace.Sdk.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace DocSpace.Sdk.Test.Model
{
    /// <summary>
    ///  Class for testing AuthData
    /// </summary>
    public class AuthDataTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AuthData
        //private AuthData instance;

        public AuthDataTests()
        {
            // TODO uncomment below to create an instance of AuthData
            //instance = new AuthData();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AuthData
        /// </summary>
        [Fact]
        public void AuthDataInstanceTest()
        {
            // TODO uncomment below to test "IsType" AuthData
            //Assert.IsType<AuthData>(instance);
        }



        /// <summary>
        /// Test the property 'Login'
        /// </summary>
        [Fact]
        public void LoginTest()
        {
            // TODO unit test for the property 'Login'
        }


        /// <summary>
        /// Test the property 'Password'
        /// </summary>
        [Fact]
        public void PasswordTest()
        {
            // TODO unit test for the property 'Password'
        }


        /// <summary>
        /// Test the property 'RawToken'
        /// </summary>
        [Fact]
        public void RawTokenTest()
        {
            // TODO unit test for the property 'RawToken'
        }


        /// <summary>
        /// Test the property 'Url'
        /// </summary>
        [Fact]
        public void UrlTest()
        {
            // TODO unit test for the property 'Url'
        }


        /// <summary>
        /// Test the property 'Provider'
        /// </summary>
        [Fact]
        public void ProviderTest()
        {
            // TODO unit test for the property 'Provider'
        }


        /// <summary>
        /// Test the property 'Token'
        /// </summary>
        [Fact]
        public void TokenTest()
        {
            // TODO unit test for the property 'Token'
        }
    }
}
