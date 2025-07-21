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
    ///  Class for testing PageableResponseClientInfoResponse
    /// </summary>
    public class PageableResponseClientInfoResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PageableResponseClientInfoResponse
        //private PageableResponseClientInfoResponse instance;

        public PageableResponseClientInfoResponseTests()
        {
            // TODO uncomment below to create an instance of PageableResponseClientInfoResponse
            //instance = new PageableResponseClientInfoResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PageableResponseClientInfoResponse
        /// </summary>
        [Fact]
        public void PageableResponseClientInfoResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" PageableResponseClientInfoResponse
            //Assert.IsType<PageableResponseClientInfoResponse>(instance);
        }



        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            // TODO unit test for the property 'Data'
        }


        /// <summary>
        /// Test the property 'Limit'
        /// </summary>
        [Fact]
        public void LimitTest()
        {
            // TODO unit test for the property 'Limit'
        }


        /// <summary>
        /// Test the property 'LastClientId'
        /// </summary>
        [Fact]
        public void LastClientIdTest()
        {
            // TODO unit test for the property 'LastClientId'
        }


        /// <summary>
        /// Test the property 'LastCreatedOn'
        /// </summary>
        [Fact]
        public void LastCreatedOnTest()
        {
            // TODO unit test for the property 'LastCreatedOn'
        }
    }
}
