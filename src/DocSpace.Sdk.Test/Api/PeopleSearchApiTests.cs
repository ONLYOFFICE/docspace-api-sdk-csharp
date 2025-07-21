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
    ///  Class for testing PeopleSearchApi
    /// </summary>
    public class PeopleSearchApiTests : IDisposable
    {
        private PeopleSearchApi instance;

        public PeopleSearchApiTests()
        {
            instance = new PeopleSearchApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PeopleSearchApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PeopleSearchApi
            //Assert.IsType<PeopleSearchApi>(instance);
        }

        /// <summary>
        /// Test GetAccountsEntriesWithShared
        /// </summary>
        [Fact]
        public void GetAccountsEntriesWithSharedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //EmployeeStatus? employeeStatus = null;
            //EmployeeActivationStatus? activationStatus = null;
            //bool? excludeShared = null;
            //bool? includeShared = null;
            //bool? invitedByMe = null;
            //Guid? inviterId = null;
            //Area? area = null;
            //List<EmployeeType>? employeeTypes = null;
            //int? count = null;
            //int? startIndex = null;
            //string? filterSeparator = null;
            //string? filterValue = null;
            //var response = instance.GetAccountsEntriesWithShared(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
            //Assert.IsType<ObjectArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetSearch
        /// </summary>
        [Fact]
        public void GetSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string query = null;
            //string? filterBy = null;
            //string? filterValue = null;
            //var response = instance.GetSearch(query, filterBy, filterValue);
            //Assert.IsType<EmployeeFullArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetSimpleByFilter
        /// </summary>
        [Fact]
        public void GetSimpleByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmployeeStatus? employeeStatus = null;
            //Guid? groupId = null;
            //EmployeeActivationStatus? activationStatus = null;
            //EmployeeType? employeeType = null;
            //List<int>? employeeTypes = null;
            //bool? isAdministrator = null;
            //Payments? payments = null;
            //AccountLoginType? accountLoginType = null;
            //QuotaFilter? quotaFilter = null;
            //bool? withoutGroup = null;
            //bool? excludeGroup = null;
            //bool? invitedByMe = null;
            //Guid? inviterId = null;
            //Area? area = null;
            //int? count = null;
            //int? startIndex = null;
            //string? sortBy = null;
            //SortOrder? sortOrder = null;
            //string? filterSeparator = null;
            //string? filterValue = null;
            //string fields = null;
            //var response = instance.GetSimpleByFilter(employeeStatus, groupId, activationStatus, employeeType, employeeTypes, isAdministrator, payments, accountLoginType, quotaFilter, withoutGroup, excludeGroup, invitedByMe, inviterId, area, count, startIndex, sortBy, sortOrder, filterSeparator, filterValue, fields);
            //Assert.IsType<EmployeeArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetUsersWithRoomShared
        /// </summary>
        [Fact]
        public void GetUsersWithRoomSharedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //EmployeeStatus? employeeStatus = null;
            //EmployeeActivationStatus? activationStatus = null;
            //bool? excludeShared = null;
            //bool? includeShared = null;
            //bool? invitedByMe = null;
            //Guid? inviterId = null;
            //Area? area = null;
            //List<EmployeeType>? employeeTypes = null;
            //int? count = null;
            //int? startIndex = null;
            //string? filterSeparator = null;
            //string? filterValue = null;
            //var response = instance.GetUsersWithRoomShared(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
            //Assert.IsType<EmployeeFullArrayWrapper>(response);
        }

        /// <summary>
        /// Test SearchUsersByExtendedFilter
        /// </summary>
        [Fact]
        public void SearchUsersByExtendedFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmployeeStatus? employeeStatus = null;
            //Guid? groupId = null;
            //EmployeeActivationStatus? activationStatus = null;
            //EmployeeType? employeeType = null;
            //List<int>? employeeTypes = null;
            //bool? isAdministrator = null;
            //Payments? payments = null;
            //AccountLoginType? accountLoginType = null;
            //QuotaFilter? quotaFilter = null;
            //bool? withoutGroup = null;
            //bool? excludeGroup = null;
            //bool? invitedByMe = null;
            //Guid? inviterId = null;
            //Area? area = null;
            //int? count = null;
            //int? startIndex = null;
            //string? sortBy = null;
            //SortOrder? sortOrder = null;
            //string? filterSeparator = null;
            //string? filterValue = null;
            //string fields = null;
            //var response = instance.SearchUsersByExtendedFilter(employeeStatus, groupId, activationStatus, employeeType, employeeTypes, isAdministrator, payments, accountLoginType, quotaFilter, withoutGroup, excludeGroup, invitedByMe, inviterId, area, count, startIndex, sortBy, sortOrder, filterSeparator, filterValue, fields);
            //Assert.IsType<EmployeeFullArrayWrapper>(response);
        }

        /// <summary>
        /// Test SearchUsersByQuery
        /// </summary>
        [Fact]
        public void SearchUsersByQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? query = null;
            //var response = instance.SearchUsersByQuery(query);
            //Assert.IsType<EmployeeArrayWrapper>(response);
        }

        /// <summary>
        /// Test SearchUsersByStatus
        /// </summary>
        [Fact]
        public void SearchUsersByStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmployeeStatus status = null;
            //string? query = null;
            //string? filterBy = null;
            //string? filterValue = null;
            //var response = instance.SearchUsersByStatus(status, query, filterBy, filterValue);
            //Assert.IsType<EmployeeFullArrayWrapper>(response);
        }
    }
}
