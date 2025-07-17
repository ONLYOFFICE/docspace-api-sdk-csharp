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
    ///  Class for testing CoEditingConfig
    /// </summary>
    public class CoEditingConfigTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CoEditingConfig
        //private CoEditingConfig instance;

        public CoEditingConfigTests()
        {
            // TODO uncomment below to create an instance of CoEditingConfig
            //instance = new CoEditingConfig();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CoEditingConfig
        /// </summary>
        [Fact]
        public void CoEditingConfigInstanceTest()
        {
            // TODO uncomment below to test "IsType" CoEditingConfig
            //Assert.IsType<CoEditingConfig>(instance);
        }



        /// <summary>
        /// Test the property 'Change'
        /// </summary>
        [Fact]
        public void ChangeTest()
        {
            // TODO unit test for the property 'Change'
        }


        /// <summary>
        /// Test the property 'Fast'
        /// </summary>
        [Fact]
        public void FastTest()
        {
            // TODO unit test for the property 'Fast'
        }


        /// <summary>
        /// Test the property 'Mode'
        /// </summary>
        [Fact]
        public void ModeTest()
        {
            // TODO unit test for the property 'Mode'
        }
    }
}
