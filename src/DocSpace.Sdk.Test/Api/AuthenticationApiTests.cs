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


using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using DocSpace.Sdk.Client;
using DocSpace.Sdk.Api;
// uncomment below to import models
//using DocSpace.Sdk.Model;

namespace DocSpace.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing AuthenticationApi
    /// </summary>
    public class AuthenticationApiTests : IDisposable
    {
        private AuthenticationApi instance;

        public AuthenticationApiTests()
        {
            instance = new AuthenticationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AuthenticationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AuthenticationApi
            //Assert.IsType<AuthenticationApi>(instance);
        }

        /// <summary>
        /// Test AuthenticateMe
        /// </summary>
        [Fact]
        public void AuthenticateMeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AuthRequestsDto? authRequestsDto = null;
            //var response = instance.AuthenticateMe(authRequestsDto);
            //Assert.IsType<AuthenticationTokenWrapper>(response);
        }

        /// <summary>
        /// Test AuthenticateMeFromBodyWithCode
        /// </summary>
        [Fact]
        public void AuthenticateMeFromBodyWithCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string code = null;
            //AuthRequestsDto? authRequestsDto = null;
            //var response = instance.AuthenticateMeFromBodyWithCode(code, authRequestsDto);
            //Assert.IsType<AuthenticationTokenWrapper>(response);
        }

        /// <summary>
        /// Test CheckConfirm
        /// </summary>
        [Fact]
        public void CheckConfirmTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmailValidationKeyModel? emailValidationKeyModel = null;
            //var response = instance.CheckConfirm(emailValidationKeyModel);
            //Assert.IsType<ConfirmWrapper>(response);
        }

        /// <summary>
        /// Test GetIsAuthentificated
        /// </summary>
        [Fact]
        public void GetIsAuthentificatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetIsAuthentificated();
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test Logout
        /// </summary>
        [Fact]
        public void LogoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Logout();
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test SaveMobilePhone
        /// </summary>
        [Fact]
        public void SaveMobilePhoneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MobileRequestsDto? mobileRequestsDto = null;
            //var response = instance.SaveMobilePhone(mobileRequestsDto);
            //Assert.IsType<AuthenticationTokenWrapper>(response);
        }

        /// <summary>
        /// Test SendSmsCode
        /// </summary>
        [Fact]
        public void SendSmsCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AuthRequestsDto? authRequestsDto = null;
            //var response = instance.SendSmsCode(authRequestsDto);
            //Assert.IsType<AuthenticationTokenWrapper>(response);
        }
    }
}
