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
    ///  Class for testing AuthenticationTokenDto
    /// </summary>
    public class AuthenticationTokenDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AuthenticationTokenDto
        //private AuthenticationTokenDto instance;

        public AuthenticationTokenDtoTests()
        {
            // TODO uncomment below to create an instance of AuthenticationTokenDto
            //instance = new AuthenticationTokenDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AuthenticationTokenDto
        /// </summary>
        [Fact]
        public void AuthenticationTokenDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" AuthenticationTokenDto
            //Assert.IsType<AuthenticationTokenDto>(instance);
        }



        /// <summary>
        /// Test the property 'Token'
        /// </summary>
        [Fact]
        public void TokenTest()
        {
            // TODO unit test for the property 'Token'
        }


        /// <summary>
        /// Test the property 'Expires'
        /// </summary>
        [Fact]
        public void ExpiresTest()
        {
            // TODO unit test for the property 'Expires'
        }


        /// <summary>
        /// Test the property 'Sms'
        /// </summary>
        [Fact]
        public void SmsTest()
        {
            // TODO unit test for the property 'Sms'
        }


        /// <summary>
        /// Test the property 'PhoneNoise'
        /// </summary>
        [Fact]
        public void PhoneNoiseTest()
        {
            // TODO unit test for the property 'PhoneNoise'
        }


        /// <summary>
        /// Test the property 'Tfa'
        /// </summary>
        [Fact]
        public void TfaTest()
        {
            // TODO unit test for the property 'Tfa'
        }


        /// <summary>
        /// Test the property 'TfaKey'
        /// </summary>
        [Fact]
        public void TfaKeyTest()
        {
            // TODO unit test for the property 'TfaKey'
        }


        /// <summary>
        /// Test the property 'ConfirmUrl'
        /// </summary>
        [Fact]
        public void ConfirmUrlTest()
        {
            // TODO unit test for the property 'ConfirmUrl'
        }
    }
}
