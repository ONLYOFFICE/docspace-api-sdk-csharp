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
    ///  Class for testing RoomTemplateStatusDto
    /// </summary>
    public class RoomTemplateStatusDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for RoomTemplateStatusDto
        //private RoomTemplateStatusDto instance;

        public RoomTemplateStatusDtoTests()
        {
            // TODO uncomment below to create an instance of RoomTemplateStatusDto
            //instance = new RoomTemplateStatusDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RoomTemplateStatusDto
        /// </summary>
        [Fact]
        public void RoomTemplateStatusDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" RoomTemplateStatusDto
            //Assert.IsType<RoomTemplateStatusDto>(instance);
        }



        /// <summary>
        /// Test the property 'TemplateId'
        /// </summary>
        [Fact]
        public void TemplateIdTest()
        {
            // TODO unit test for the property 'TemplateId'
        }


        /// <summary>
        /// Test the property 'Progress'
        /// </summary>
        [Fact]
        public void ProgressTest()
        {
            // TODO unit test for the property 'Progress'
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
        /// Test the property 'IsCompleted'
        /// </summary>
        [Fact]
        public void IsCompletedTest()
        {
            // TODO unit test for the property 'IsCompleted'
        }
    }
}
