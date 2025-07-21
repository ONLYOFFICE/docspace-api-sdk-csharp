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
    ///  Class for testing ConfirmDto
    /// </summary>
    public class ConfirmDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ConfirmDto
        //private ConfirmDto instance;

        public ConfirmDtoTests()
        {
            // TODO uncomment below to create an instance of ConfirmDto
            //instance = new ConfirmDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConfirmDto
        /// </summary>
        [Fact]
        public void ConfirmDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" ConfirmDto
            //Assert.IsType<ConfirmDto>(instance);
        }



        /// <summary>
        /// Test the property 'Result'
        /// </summary>
        [Fact]
        public void ResultTest()
        {
            // TODO unit test for the property 'Result'
        }


        /// <summary>
        /// Test the property 'RoomId'
        /// </summary>
        [Fact]
        public void RoomIdTest()
        {
            // TODO unit test for the property 'RoomId'
        }


        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Fact]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }
    }
}
