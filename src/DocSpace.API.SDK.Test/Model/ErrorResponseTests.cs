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
    ///  Class for testing ErrorResponse
    /// </summary>
    public class ErrorResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ErrorResponse
        //private ErrorResponse instance;

        public ErrorResponseTests()
        {
            // TODO uncomment below to create an instance of ErrorResponse
            //instance = new ErrorResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ErrorResponse
        /// </summary>
        [Fact]
        public void ErrorResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" ErrorResponse
            //Assert.IsType<ErrorResponse>(instance);
        }



        /// <summary>
        /// Test the property 'Reason'
        /// </summary>
        [Fact]
        public void ReasonTest()
        {
            // TODO unit test for the property 'Reason'
        }
    }
}
