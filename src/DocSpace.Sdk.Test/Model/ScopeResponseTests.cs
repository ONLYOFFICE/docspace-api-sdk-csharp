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
    ///  Class for testing ScopeResponse
    /// </summary>
    public class ScopeResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ScopeResponse
        //private ScopeResponse instance;

        public ScopeResponseTests()
        {
            // TODO uncomment below to create an instance of ScopeResponse
            //instance = new ScopeResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ScopeResponse
        /// </summary>
        [Fact]
        public void ScopeResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" ScopeResponse
            //Assert.IsType<ScopeResponse>(instance);
        }



        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }


        /// <summary>
        /// Test the property 'Group'
        /// </summary>
        [Fact]
        public void GroupTest()
        {
            // TODO unit test for the property 'Group'
        }


        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
    }
}
