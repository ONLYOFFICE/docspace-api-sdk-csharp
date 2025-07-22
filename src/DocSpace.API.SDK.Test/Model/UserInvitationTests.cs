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


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using DocSpace.API.SDK.Model;
using DocSpace.API.SDK.Client;
using System.Reflection;
using System.Text.Json;

namespace DocSpace.API.SDK.Test.Model
{
    /// <summary>
    ///  Class for testing UserInvitation
    /// </summary>
    public class UserInvitationTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UserInvitation
        //private UserInvitation instance;

        public UserInvitationTests()
        {
            // TODO uncomment below to create an instance of UserInvitation
            //instance = new UserInvitation();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserInvitation
        /// </summary>
        [Fact]
        public void UserInvitationInstanceTest()
        {
            // TODO uncomment below to test "IsType" UserInvitation
            //Assert.IsType<UserInvitation>(instance);
        }



        /// <summary>
        /// Test the property 'UsersIds'
        /// </summary>
        [Fact]
        public void UsersIdsTest()
        {
            // TODO unit test for the property 'UsersIds'
        }


        /// <summary>
        /// Test the property 'ResendAll'
        /// </summary>
        [Fact]
        public void ResendAllTest()
        {
            // TODO unit test for the property 'ResendAll'
        }
    }
}
