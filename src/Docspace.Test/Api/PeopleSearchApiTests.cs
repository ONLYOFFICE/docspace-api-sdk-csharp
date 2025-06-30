// (c) Copyright Ascensio System SIA 2009-2025
// 
// This program is a free software product.
// You can redistribute it and/or modify it under the terms
// of the GNU Affero General Public License (AGPL) version 3 as published by the Free Software
// Foundation. In accordance with Section 7(a) of the GNU AGPL its Section 15 shall be amended
// to the effect that Ascensio System SIA expressly excludes the warranty of non-infringement of
// any third-party rights.
// 
// This program is distributed WITHOUT ANY WARRANTY, without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR  PURPOSE. For details, see
// the GNU AGPL at: http://www.gnu.org/licenses/agpl-3.0.html
// 
// You can contact Ascensio System SIA at Lubanas st. 125a-25, Riga, Latvia, EU, LV-1021.
// 
// The  interactive user interfaces in modified source and object code versions of the Program must
// display Appropriate Legal Notices, as required under Section 5 of the GNU AGPL version 3.
// 
// Pursuant to Section 7(b) of the License you must retain the original Product logo when
// distributing the program. Pursuant to Section 7(e) we decline to grant you any rights under
// trademark law for use of our trademarks.
// 
// All the Product's GUI elements, including illustrations and icon sets, as well as technical writing
// content are licensed under the terms of the Creative Commons Attribution-ShareAlike 4.0
// International. See the License terms at http://creativecommons.org/licenses/by-sa/4.0/legalcode

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using DocSpace.Client;
using DocSpace.Api;
// uncomment below to import models
//using DocSpace.Model;

namespace DocSpace.Test.Api
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
            //var response = instance.GetSimpleByFilter(employeeStatus, groupId, activationStatus, employeeType, employeeTypes, isAdministrator, payments, accountLoginType, quotaFilter, withoutGroup, excludeGroup, invitedByMe, inviterId, area, count, startIndex, sortBy, sortOrder, filterSeparator, filterValue);
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
            //var response = instance.SearchUsersByExtendedFilter(employeeStatus, groupId, activationStatus, employeeType, employeeTypes, isAdministrator, payments, accountLoginType, quotaFilter, withoutGroup, excludeGroup, invitedByMe, inviterId, area, count, startIndex, sortBy, sortOrder, filterSeparator, filterValue);
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
