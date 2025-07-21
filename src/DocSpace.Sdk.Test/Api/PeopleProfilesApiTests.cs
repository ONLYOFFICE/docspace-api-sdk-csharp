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
    ///  Class for testing PeopleProfilesApi
    /// </summary>
    public class PeopleProfilesApiTests : IDisposable
    {
        private PeopleProfilesApi instance;

        public PeopleProfilesApiTests()
        {
            instance = new PeopleProfilesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PeopleProfilesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PeopleProfilesApi
            //Assert.IsType<PeopleProfilesApi>(instance);
        }

        /// <summary>
        /// Test AddMember
        /// </summary>
        [Fact]
        public void AddMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MemberRequestDto? memberRequestDto = null;
            //var response = instance.AddMember(memberRequestDto);
            //Assert.IsType<EmployeeFullWrapper>(response);
        }

        /// <summary>
        /// Test DeleteMember
        /// </summary>
        [Fact]
        public void DeleteMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userid = null;
            //var response = instance.DeleteMember(userid);
            //Assert.IsType<EmployeeFullWrapper>(response);
        }

        /// <summary>
        /// Test DeleteProfile
        /// </summary>
        [Fact]
        public void DeleteProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.DeleteProfile();
            //Assert.IsType<EmployeeFullWrapper>(response);
        }

        /// <summary>
        /// Test GetAllProfiles
        /// </summary>
        [Fact]
        public void GetAllProfilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? count = null;
            //int? startIndex = null;
            //string? filterBy = null;
            //string? sortBy = null;
            //SortOrder? sortOrder = null;
            //string? filterSeparator = null;
            //string? filterValue = null;
            //string fields = null;
            //var response = instance.GetAllProfiles(count, startIndex, filterBy, sortBy, sortOrder, filterSeparator, filterValue, fields);
            //Assert.IsType<EmployeeFullArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetClaims
        /// </summary>
        [Fact]
        public void GetClaimsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetClaims();
            //Assert.IsType<ObjectWrapper>(response);
        }

        /// <summary>
        /// Test GetProfileByEmail
        /// </summary>
        [Fact]
        public void GetProfileByEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? email = null;
            //string? culture = null;
            //var response = instance.GetProfileByEmail(email, culture);
            //Assert.IsType<EmployeeFullWrapper>(response);
        }

        /// <summary>
        /// Test GetProfileByUserId
        /// </summary>
        [Fact]
        public void GetProfileByUserIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userid = null;
            //var response = instance.GetProfileByUserId(userid);
            //Assert.IsType<EmployeeFullWrapper>(response);
        }

        /// <summary>
        /// Test GetSelfProfile
        /// </summary>
        [Fact]
        public void GetSelfProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetSelfProfile();
            //Assert.IsType<EmployeeFullWrapper>(response);
        }

        /// <summary>
        /// Test InviteUsers
        /// </summary>
        [Fact]
        public void InviteUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InviteUsersRequestDto? inviteUsersRequestDto = null;
            //var response = instance.InviteUsers(inviteUsersRequestDto);
            //Assert.IsType<EmployeeArrayWrapper>(response);
        }

        /// <summary>
        /// Test RemoveUsers
        /// </summary>
        [Fact]
        public void RemoveUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateMembersRequestDto? updateMembersRequestDto = null;
            //var response = instance.RemoveUsers(updateMembersRequestDto);
            //Assert.IsType<EmployeeFullArrayWrapper>(response);
        }

        /// <summary>
        /// Test ResendUserInvites
        /// </summary>
        [Fact]
        public void ResendUserInvitesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateMembersRequestDto? updateMembersRequestDto = null;
            //var response = instance.ResendUserInvites(updateMembersRequestDto);
            //Assert.IsType<EmployeeFullArrayWrapper>(response);
        }

        /// <summary>
        /// Test SendEmailChangeInstructions
        /// </summary>
        [Fact]
        public void SendEmailChangeInstructionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateMemberRequestDto? updateMemberRequestDto = null;
            //var response = instance.SendEmailChangeInstructions(updateMemberRequestDto);
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test UpdateMember
        /// </summary>
        [Fact]
        public void UpdateMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userid = null;
            //UpdateMemberRequestDto? updateMemberRequestDto = null;
            //var response = instance.UpdateMember(userid, updateMemberRequestDto);
            //Assert.IsType<EmployeeFullWrapper>(response);
        }

        /// <summary>
        /// Test UpdateMemberCulture
        /// </summary>
        [Fact]
        public void UpdateMemberCultureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userid = null;
            //Culture? culture = null;
            //var response = instance.UpdateMemberCulture(userid, culture);
            //Assert.IsType<EmployeeFullWrapper>(response);
        }
    }
}
