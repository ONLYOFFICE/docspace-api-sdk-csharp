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
            //string fields = null;
            //var response = instance.GetGroups(userId, manager, count, startIndex, sortBy, sortOrder, filterValue, fields);
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
