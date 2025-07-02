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
            //var response = instance.GetAllProfiles(count, startIndex, filterBy, sortBy, sortOrder, filterSeparator, filterValue);
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
