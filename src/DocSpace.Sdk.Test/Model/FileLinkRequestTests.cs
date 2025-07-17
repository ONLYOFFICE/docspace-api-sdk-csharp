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
    ///  Class for testing FileLinkRequest
    /// </summary>
    public class FileLinkRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for FileLinkRequest
        //private FileLinkRequest instance;

        public FileLinkRequestTests()
        {
            // TODO uncomment below to create an instance of FileLinkRequest
            //instance = new FileLinkRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FileLinkRequest
        /// </summary>
        [Fact]
        public void FileLinkRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" FileLinkRequest
            //Assert.IsType<FileLinkRequest>(instance);
        }



        /// <summary>
        /// Test the property 'LinkId'
        /// </summary>
        [Fact]
        public void LinkIdTest()
        {
            // TODO unit test for the property 'LinkId'
        }


        /// <summary>
        /// Test the property 'Access'
        /// </summary>
        [Fact]
        public void AccessTest()
        {
            // TODO unit test for the property 'Access'
        }


        /// <summary>
        /// Test the property 'ExpirationDate'
        /// </summary>
        [Fact]
        public void ExpirationDateTest()
        {
            // TODO unit test for the property 'ExpirationDate'
        }


        /// <summary>
        /// Test the property 'Internal'
        /// </summary>
        [Fact]
        public void InternalTest()
        {
            // TODO unit test for the property 'Internal'
        }


        /// <summary>
        /// Test the property 'Primary'
        /// </summary>
        [Fact]
        public void PrimaryTest()
        {
            // TODO unit test for the property 'Primary'
        }
    }
}
