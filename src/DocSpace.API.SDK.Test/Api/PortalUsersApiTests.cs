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
    ///  Class for testing PortalUsersApi
    /// </summary>
    public class PortalUsersApiTests : IDisposable
    {
        private PortalUsersApi instance;

        public PortalUsersApiTests()
        {
            instance = new PortalUsersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PortalUsersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PortalUsersApi
            //Assert.IsType<PortalUsersApi>(instance);
        }

        /// <summary>
        /// Test GetInvitationLink
        /// </summary>
        [Fact]
        public void GetInvitationLinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmployeeType employeeType = null;
            //var response = instance.GetInvitationLink(employeeType);
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test GetPortalUsersCount
        /// </summary>
        [Fact]
        public void GetPortalUsersCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPortalUsersCount();
            //Assert.IsType<Int64Wrapper>(response);
        }

        /// <summary>
        /// Test GetUserById
        /// </summary>
        [Fact]
        public void GetUserByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid userID = null;
            //var response = instance.GetUserById(userID);
            //Assert.IsType<UserInfoWrapper>(response);
        }

        /// <summary>
        /// Test MarkGiftMessageAsRead
        /// </summary>
        [Fact]
        public void MarkGiftMessageAsReadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.MarkGiftMessageAsRead();
        }

        /// <summary>
        /// Test SendCongratulations
        /// </summary>
        [Fact]
        public void SendCongratulationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? userid = null;
            //string? key = null;
            //instance.SendCongratulations(userid, key);
        }
    }
}
