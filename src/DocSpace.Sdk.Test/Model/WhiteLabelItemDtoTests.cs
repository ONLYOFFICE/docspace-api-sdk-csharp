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
    ///  Class for testing WhiteLabelItemDto
    /// </summary>
    public class WhiteLabelItemDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for WhiteLabelItemDto
        //private WhiteLabelItemDto instance;

        public WhiteLabelItemDtoTests()
        {
            // TODO uncomment below to create an instance of WhiteLabelItemDto
            //instance = new WhiteLabelItemDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WhiteLabelItemDto
        /// </summary>
        [Fact]
        public void WhiteLabelItemDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" WhiteLabelItemDto
            //Assert.IsType<WhiteLabelItemDto>(instance);
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
        /// Test the property 'Size'
        /// </summary>
        [Fact]
        public void SizeTest()
        {
            // TODO unit test for the property 'Size'
        }


        /// <summary>
        /// Test the property 'Path'
        /// </summary>
        [Fact]
        public void PathTest()
        {
            // TODO unit test for the property 'Path'
        }
    }
}
