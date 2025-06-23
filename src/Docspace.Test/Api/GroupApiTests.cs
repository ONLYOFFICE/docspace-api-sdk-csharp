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

using Docspace.Client;
using Docspace.Api;
// uncomment below to import models
//using Docspace.Model;

namespace Docspace.Test.Api
{
    /// <summary>
    ///  Class for testing GroupApi
    /// </summary>
    public class GroupApiTests : IDisposable
    {
        private GroupApi instance;

        public GroupApiTests()
        {
            instance = new GroupApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GroupApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' GroupApi
            //Assert.IsType<GroupApi>(instance);
        }

        /// <summary>
        /// Test AddGroup
        /// </summary>
        [Fact]
        public void AddGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GroupRequestDto? groupRequestDto = null;
            //var response = instance.AddGroup(groupRequestDto);
            //Assert.IsType<GroupWrapper>(response);
        }

        /// <summary>
        /// Test AddMembersTo
        /// </summary>
        [Fact]
        public void AddMembersToTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //MembersRequest? membersRequest = null;
            //var response = instance.AddMembersTo(id, membersRequest);
            //Assert.IsType<GroupWrapper>(response);
        }

        /// <summary>
        /// Test DeleteGroup
        /// </summary>
        [Fact]
        public void DeleteGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.DeleteGroup(id);
            //Assert.IsType<NoContentResultWrapper>(response);
        }

        /// <summary>
        /// Test GetGroup
        /// </summary>
        [Fact]
        public void GetGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //bool? includeMembers = null;
            //var response = instance.GetGroup(id, includeMembers);
            //Assert.IsType<GroupWrapper>(response);
        }

        /// <summary>
        /// Test GetGroupByUserId
        /// </summary>
        [Fact]
        public void GetGroupByUserIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid userid = null;
            //var response = instance.GetGroupByUserId(userid);
            //Assert.IsType<GroupSummaryArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetGroups
        /// </summary>
        [Fact]
        public void GetGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? userId = null;
            //bool? manager = null;
            //int? count = null;
            //int? startIndex = null;
            //string? sortBy = null;
            //SortOrder? sortOrder = null;
            //string? filterValue = null;
            //var response = instance.GetGroups(userId, manager, count, startIndex, sortBy, sortOrder, filterValue);
            //Assert.IsType<GroupArrayWrapper>(response);
        }

        /// <summary>
        /// Test MoveMembersTo
        /// </summary>
        [Fact]
        public void MoveMembersToTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid fromId = null;
            //Guid toId = null;
            //var response = instance.MoveMembersTo(fromId, toId);
            //Assert.IsType<GroupWrapper>(response);
        }

        /// <summary>
        /// Test RemoveMembersFrom
        /// </summary>
        [Fact]
        public void RemoveMembersFromTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //MembersRequest? membersRequest = null;
            //var response = instance.RemoveMembersFrom(id, membersRequest);
            //Assert.IsType<GroupWrapper>(response);
        }

        /// <summary>
        /// Test SetGroupManager
        /// </summary>
        [Fact]
        public void SetGroupManagerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //SetManagerRequest? setManagerRequest = null;
            //var response = instance.SetGroupManager(id, setManagerRequest);
            //Assert.IsType<GroupWrapper>(response);
        }

        /// <summary>
        /// Test SetMembersTo
        /// </summary>
        [Fact]
        public void SetMembersToTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //MembersRequest? membersRequest = null;
            //var response = instance.SetMembersTo(id, membersRequest);
            //Assert.IsType<GroupWrapper>(response);
        }

        /// <summary>
        /// Test UpdateGroup
        /// </summary>
        [Fact]
        public void UpdateGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //UpdateGroupRequest? updateGroupRequest = null;
            //var response = instance.UpdateGroup(id, updateGroupRequest);
            //Assert.IsType<GroupWrapper>(response);
        }
    }
}
