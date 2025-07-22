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
    ///  Class for testing MentionMessageWrapper
    /// </summary>
    public class MentionMessageWrapperTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MentionMessageWrapper
        //private MentionMessageWrapper instance;

        public MentionMessageWrapperTests()
        {
            // TODO uncomment below to create an instance of MentionMessageWrapper
            //instance = new MentionMessageWrapper();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MentionMessageWrapper
        /// </summary>
        [Fact]
        public void MentionMessageWrapperInstanceTest()
        {
            // TODO uncomment below to test "IsType" MentionMessageWrapper
            //Assert.IsType<MentionMessageWrapper>(instance);
        }



        /// <summary>
        /// Test the property 'ActionLink'
        /// </summary>
        [Fact]
        public void ActionLinkTest()
        {
            // TODO unit test for the property 'ActionLink'
        }


        /// <summary>
        /// Test the property 'Emails'
        /// </summary>
        [Fact]
        public void EmailsTest()
        {
            // TODO unit test for the property 'Emails'
        }


        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [Fact]
        public void MessageTest()
        {
            // TODO unit test for the property 'Message'
        }
    }
}
