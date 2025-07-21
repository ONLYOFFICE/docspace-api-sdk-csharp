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
    ///  Class for testing TaskProgressResponseDto
    /// </summary>
    public class TaskProgressResponseDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TaskProgressResponseDto
        //private TaskProgressResponseDto instance;

        public TaskProgressResponseDtoTests()
        {
            // TODO uncomment below to create an instance of TaskProgressResponseDto
            //instance = new TaskProgressResponseDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TaskProgressResponseDto
        /// </summary>
        [Fact]
        public void TaskProgressResponseDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" TaskProgressResponseDto
            //Assert.IsType<TaskProgressResponseDto>(instance);
        }



        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }


        /// <summary>
        /// Test the property 'Error'
        /// </summary>
        [Fact]
        public void ErrorTest()
        {
            // TODO unit test for the property 'Error'
        }


        /// <summary>
        /// Test the property 'Percentage'
        /// </summary>
        [Fact]
        public void PercentageTest()
        {
            // TODO unit test for the property 'Percentage'
        }


        /// <summary>
        /// Test the property 'IsCompleted'
        /// </summary>
        [Fact]
        public void IsCompletedTest()
        {
            // TODO unit test for the property 'IsCompleted'
        }


        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
    }
}
