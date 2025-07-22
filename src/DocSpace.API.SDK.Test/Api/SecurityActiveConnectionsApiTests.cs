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
    ///  Class for testing SecurityActiveConnectionsApi
    /// </summary>
    public class SecurityActiveConnectionsApiTests : IDisposable
    {
        private SecurityActiveConnectionsApi instance;

        public SecurityActiveConnectionsApiTests()
        {
            instance = new SecurityActiveConnectionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SecurityActiveConnectionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SecurityActiveConnectionsApi
            //Assert.IsType<SecurityActiveConnectionsApi>(instance);
        }

        /// <summary>
        /// Test GetAllActiveConnections
        /// </summary>
        [Fact]
        public void GetAllActiveConnectionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllActiveConnections();
            //Assert.IsType<ActiveConnectionsWrapper>(response);
        }

        /// <summary>
        /// Test LogOutActiveConnection
        /// </summary>
        [Fact]
        public void LogOutActiveConnectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int loginEventId = null;
            //var response = instance.LogOutActiveConnection(loginEventId);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test LogOutAllActiveConnectionsChangePassword
        /// </summary>
        [Fact]
        public void LogOutAllActiveConnectionsChangePasswordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.LogOutAllActiveConnectionsChangePassword();
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test LogOutAllActiveConnectionsForUser
        /// </summary>
        [Fact]
        public void LogOutAllActiveConnectionsForUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid userId = null;
            //instance.LogOutAllActiveConnectionsForUser(userId);
        }

        /// <summary>
        /// Test LogOutAllExceptThisConnection
        /// </summary>
        [Fact]
        public void LogOutAllExceptThisConnectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.LogOutAllExceptThisConnection();
            //Assert.IsType<StringWrapper>(response);
        }
    }
}
