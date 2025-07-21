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
    ///  Class for testing OrderBy
    /// </summary>
    public class OrderByTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for OrderBy
        //private OrderBy instance;

        public OrderByTests()
        {
            // TODO uncomment below to create an instance of OrderBy
            //instance = new OrderBy();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OrderBy
        /// </summary>
        [Fact]
        public void OrderByInstanceTest()
        {
            // TODO uncomment below to test "IsType" OrderBy
            //Assert.IsType<OrderBy>(instance);
        }



        /// <summary>
        /// Test the property 'IsAsc'
        /// </summary>
        [Fact]
        public void IsAscTest()
        {
            // TODO unit test for the property 'IsAsc'
        }


        /// <summary>
        /// Test the property 'Property'
        /// </summary>
        [Fact]
        public void PropertyTest()
        {
            // TODO unit test for the property 'Property'
        }
    }
}
