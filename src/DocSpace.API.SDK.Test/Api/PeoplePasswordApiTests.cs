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

using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Api;
// uncomment below to import models
//using DocSpace.API.SDK.Model;

namespace DocSpace.API.SDK.Test.Api
{
    /// <summary>
    ///  Class for testing PeoplePasswordApi
    /// </summary>
    public class PeoplePasswordApiTests : IDisposable
    {
        private PeoplePasswordApi instance;

        public PeoplePasswordApiTests()
        {
            instance = new PeoplePasswordApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PeoplePasswordApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PeoplePasswordApi
            //Assert.IsType<PeoplePasswordApi>(instance);
        }

        /// <summary>
        /// Test ChangeUserPassword
        /// </summary>
        [Fact]
        public void ChangeUserPasswordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid userid = null;
            //MemberBaseRequestDto? memberBaseRequestDto = null;
            //var response = instance.ChangeUserPassword(userid, memberBaseRequestDto);
            //Assert.IsType<EmployeeFullWrapper>(response);
        }

        /// <summary>
        /// Test SendUserPassword
        /// </summary>
        [Fact]
        public void SendUserPasswordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmailMemberRequestDto? emailMemberRequestDto = null;
            //var response = instance.SendUserPassword(emailMemberRequestDto);
            //Assert.IsType<StringWrapper>(response);
        }
    }
}
