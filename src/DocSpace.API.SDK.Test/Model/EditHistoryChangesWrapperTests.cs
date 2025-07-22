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
    ///  Class for testing EditHistoryChangesWrapper
    /// </summary>
    public class EditHistoryChangesWrapperTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for EditHistoryChangesWrapper
        //private EditHistoryChangesWrapper instance;

        public EditHistoryChangesWrapperTests()
        {
            // TODO uncomment below to create an instance of EditHistoryChangesWrapper
            //instance = new EditHistoryChangesWrapper();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EditHistoryChangesWrapper
        /// </summary>
        [Fact]
        public void EditHistoryChangesWrapperInstanceTest()
        {
            // TODO uncomment below to test "IsType" EditHistoryChangesWrapper
            //Assert.IsType<EditHistoryChangesWrapper>(instance);
        }



        /// <summary>
        /// Test the property 'User'
        /// </summary>
        [Fact]
        public void UserTest()
        {
            // TODO unit test for the property 'User'
        }


        /// <summary>
        /// Test the property 'Created'
        /// </summary>
        [Fact]
        public void CreatedTest()
        {
            // TODO unit test for the property 'Created'
        }


        /// <summary>
        /// Test the property 'DocumentSha256'
        /// </summary>
        [Fact]
        public void DocumentSha256Test()
        {
            // TODO unit test for the property 'DocumentSha256'
        }
    }
}
