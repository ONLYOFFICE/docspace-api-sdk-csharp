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
    ///  Class for testing ReportDto
    /// </summary>
    public class ReportDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ReportDto
        //private ReportDto instance;

        public ReportDtoTests()
        {
            // TODO uncomment below to create an instance of ReportDto
            //instance = new ReportDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReportDto
        /// </summary>
        [Fact]
        public void ReportDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" ReportDto
            //Assert.IsType<ReportDto>(instance);
        }



        /// <summary>
        /// Test the property 'Collection'
        /// </summary>
        [Fact]
        public void CollectionTest()
        {
            // TODO unit test for the property 'Collection'
        }


        /// <summary>
        /// Test the property 'Offset'
        /// </summary>
        [Fact]
        public void OffsetTest()
        {
            // TODO unit test for the property 'Offset'
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
        /// Test the property 'TotalQuantity'
        /// </summary>
        [Fact]
        public void TotalQuantityTest()
        {
            // TODO unit test for the property 'TotalQuantity'
        }


        /// <summary>
        /// Test the property 'TotalPage'
        /// </summary>
        [Fact]
        public void TotalPageTest()
        {
            // TODO unit test for the property 'TotalPage'
        }


        /// <summary>
        /// Test the property 'CurrentPage'
        /// </summary>
        [Fact]
        public void CurrentPageTest()
        {
            // TODO unit test for the property 'CurrentPage'
        }
    }
}
