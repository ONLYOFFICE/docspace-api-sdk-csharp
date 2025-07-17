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
    ///  Class for testing PeopleUserStatusApi
    /// </summary>
    public class PeopleUserStatusApiTests : IDisposable
    {
        private PeopleUserStatusApi instance;

        public PeopleUserStatusApiTests()
        {
            instance = new PeopleUserStatusApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PeopleUserStatusApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PeopleUserStatusApi
            //Assert.IsType<PeopleUserStatusApi>(instance);
        }

        /// <summary>
        /// Test GetByStatus
        /// </summary>
        [Fact]
        public void GetByStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmployeeStatus status = null;
            //string? filterBy = null;
            //int? count = null;
            //int? startIndex = null;
            //string? sortBy = null;
            //SortOrder? sortOrder = null;
            //string? filterSeparator = null;
            //string? filterValue = null;
            //var response = instance.GetByStatus(status, filterBy, count, startIndex, sortBy, sortOrder, filterSeparator, filterValue);
            //Assert.IsType<EmployeeFullArrayWrapper>(response);
        }

        /// <summary>
        /// Test UpdateUserActivationStatus
        /// </summary>
        [Fact]
        public void UpdateUserActivationStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmployeeActivationStatus activationstatus = null;
            //UpdateMembersRequestDto? updateMembersRequestDto = null;
            //var response = instance.UpdateUserActivationStatus(activationstatus, updateMembersRequestDto);
            //Assert.IsType<EmployeeFullArrayWrapper>(response);
        }

        /// <summary>
        /// Test UpdateUserStatus
        /// </summary>
        [Fact]
        public void UpdateUserStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmployeeStatus status = null;
            //UpdateMembersRequestDto? updateMembersRequestDto = null;
            //var response = instance.UpdateUserStatus(status, updateMembersRequestDto);
            //Assert.IsType<EmployeeFullArrayWrapper>(response);
        }
    }
}
