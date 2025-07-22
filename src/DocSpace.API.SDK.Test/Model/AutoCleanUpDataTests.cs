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
    ///  Class for testing AutoCleanUpData
    /// </summary>
    public class AutoCleanUpDataTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AutoCleanUpData
        //private AutoCleanUpData instance;

        public AutoCleanUpDataTests()
        {
            // TODO uncomment below to create an instance of AutoCleanUpData
            //instance = new AutoCleanUpData();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AutoCleanUpData
        /// </summary>
        [Fact]
        public void AutoCleanUpDataInstanceTest()
        {
            // TODO uncomment below to test "IsType" AutoCleanUpData
            //Assert.IsType<AutoCleanUpData>(instance);
        }



        /// <summary>
        /// Test the property 'IsAutoCleanUp'
        /// </summary>
        [Fact]
        public void IsAutoCleanUpTest()
        {
            // TODO unit test for the property 'IsAutoCleanUp'
        }


        /// <summary>
        /// Test the property 'Gap'
        /// </summary>
        [Fact]
        public void GapTest()
        {
            // TODO unit test for the property 'Gap'
        }
    }
}
