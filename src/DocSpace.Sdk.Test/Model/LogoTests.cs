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
    ///  Class for testing Logo
    /// </summary>
    public class LogoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Logo
        //private Logo instance;

        public LogoTests()
        {
            // TODO uncomment below to create an instance of Logo
            //instance = new Logo();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Logo
        /// </summary>
        [Fact]
        public void LogoInstanceTest()
        {
            // TODO uncomment below to test "IsType" Logo
            //Assert.IsType<Logo>(instance);
        }



        /// <summary>
        /// Test the property 'Original'
        /// </summary>
        [Fact]
        public void OriginalTest()
        {
            // TODO unit test for the property 'Original'
        }


        /// <summary>
        /// Test the property 'Large'
        /// </summary>
        [Fact]
        public void LargeTest()
        {
            // TODO unit test for the property 'Large'
        }


        /// <summary>
        /// Test the property 'Medium'
        /// </summary>
        [Fact]
        public void MediumTest()
        {
            // TODO unit test for the property 'Medium'
        }


        /// <summary>
        /// Test the property 'Small'
        /// </summary>
        [Fact]
        public void SmallTest()
        {
            // TODO unit test for the property 'Small'
        }


        /// <summary>
        /// Test the property 'Color'
        /// </summary>
        [Fact]
        public void ColorTest()
        {
            // TODO unit test for the property 'Color'
        }


        /// <summary>
        /// Test the property 'Cover'
        /// </summary>
        [Fact]
        public void CoverTest()
        {
            // TODO unit test for the property 'Cover'
        }
    }
}
