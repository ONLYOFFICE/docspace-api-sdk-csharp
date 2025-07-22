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
    ///  Class for testing PeopleUserTypeApi
    /// </summary>
    public class PeopleUserTypeApiTests : IDisposable
    {
        private PeopleUserTypeApi instance;

        public PeopleUserTypeApiTests()
        {
            instance = new PeopleUserTypeApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PeopleUserTypeApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PeopleUserTypeApi
            //Assert.IsType<PeopleUserTypeApi>(instance);
        }

        /// <summary>
        /// Test GetUserTypeUpdateProgress
        /// </summary>
        [Fact]
        public void GetUserTypeUpdateProgressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid userid = null;
            //var response = instance.GetUserTypeUpdateProgress(userid);
            //Assert.IsType<TaskProgressResponseWrapper>(response);
        }

        /// <summary>
        /// Test StarUserTypetUpdate
        /// </summary>
        [Fact]
        public void StarUserTypetUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //StartUpdateUserTypeDto? startUpdateUserTypeDto = null;
            //var response = instance.StarUserTypetUpdate(startUpdateUserTypeDto);
            //Assert.IsType<TaskProgressResponseWrapper>(response);
        }

        /// <summary>
        /// Test TerminateUserTypeUpdate
        /// </summary>
        [Fact]
        public void TerminateUserTypeUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TerminateRequestDto? terminateRequestDto = null;
            //var response = instance.TerminateUserTypeUpdate(terminateRequestDto);
            //Assert.IsType<TaskProgressResponseWrapper>(response);
        }

        /// <summary>
        /// Test UpdateUserType
        /// </summary>
        [Fact]
        public void UpdateUserTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmployeeType type = null;
            //UpdateMembersRequestDto? updateMembersRequestDto = null;
            //var response = instance.UpdateUserType(type, updateMembersRequestDto);
            //Assert.IsType<EmployeeFullArrayWrapper>(response);
        }
    }
}
