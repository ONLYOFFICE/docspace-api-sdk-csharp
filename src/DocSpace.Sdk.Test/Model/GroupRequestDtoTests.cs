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
using DocSpace.Sdk.Model;
using DocSpace.Sdk.Client;
using System.Reflection;
using System.Text.Json;

namespace DocSpace.Sdk.Test.Model
{
    /// <summary>
    ///  Class for testing GroupRequestDto
    /// </summary>
    public class GroupRequestDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GroupRequestDto
        //private GroupRequestDto instance;

        public GroupRequestDtoTests()
        {
            // TODO uncomment below to create an instance of GroupRequestDto
            //instance = new GroupRequestDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GroupRequestDto
        /// </summary>
        [Fact]
        public void GroupRequestDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" GroupRequestDto
            //Assert.IsType<GroupRequestDto>(instance);
        }



        /// <summary>
        /// Test the property 'Members'
        /// </summary>
        [Fact]
        public void MembersTest()
        {
            // TODO unit test for the property 'Members'
        }


        /// <summary>
        /// Test the property 'GroupManager'
        /// </summary>
        [Fact]
        public void GroupManagerTest()
        {
            // TODO unit test for the property 'GroupManager'
        }


        /// <summary>
        /// Test the property 'GroupName'
        /// </summary>
        [Fact]
        public void GroupNameTest()
        {
            // TODO unit test for the property 'GroupName'
        }
    }
}
