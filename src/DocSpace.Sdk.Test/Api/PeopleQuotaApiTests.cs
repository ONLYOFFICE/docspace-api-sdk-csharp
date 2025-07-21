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
    ///  Class for testing PeopleQuotaApi
    /// </summary>
    public class PeopleQuotaApiTests : IDisposable
    {
        private PeopleQuotaApi instance;

        public PeopleQuotaApiTests()
        {
            instance = new PeopleQuotaApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PeopleQuotaApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PeopleQuotaApi
            //Assert.IsType<PeopleQuotaApi>(instance);
        }

        /// <summary>
        /// Test ResetUsersQuota
        /// </summary>
        [Fact]
        public void ResetUsersQuotaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateMembersQuotaRequestDto? updateMembersQuotaRequestDto = null;
            //var response = instance.ResetUsersQuota(updateMembersQuotaRequestDto);
            //Assert.IsType<EmployeeFullArrayWrapper>(response);
        }

        /// <summary>
        /// Test UpdateUserQuota
        /// </summary>
        [Fact]
        public void UpdateUserQuotaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateMembersQuotaRequestDto? updateMembersQuotaRequestDto = null;
            //var response = instance.UpdateUserQuota(updateMembersQuotaRequestDto);
            //Assert.IsType<EmployeeFullArrayWrapper>(response);
        }
    }
}
