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


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using DocSpace.Sdk.Model;
using DocSpace.Sdk.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace DocSpace.Sdk.Test.Model
{
    /// <summary>
    ///  Class for testing UpdateGroupRequest
    /// </summary>
    public class UpdateGroupRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UpdateGroupRequest
        //private UpdateGroupRequest instance;

        public UpdateGroupRequestTests()
        {
            // TODO uncomment below to create an instance of UpdateGroupRequest
            //instance = new UpdateGroupRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UpdateGroupRequest
        /// </summary>
        [Fact]
        public void UpdateGroupRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" UpdateGroupRequest
            //Assert.IsType<UpdateGroupRequest>(instance);
        }



        /// <summary>
        /// Test the property 'MembersToAdd'
        /// </summary>
        [Fact]
        public void MembersToAddTest()
        {
            // TODO unit test for the property 'MembersToAdd'
        }


        /// <summary>
        /// Test the property 'MembersToRemove'
        /// </summary>
        [Fact]
        public void MembersToRemoveTest()
        {
            // TODO unit test for the property 'MembersToRemove'
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
