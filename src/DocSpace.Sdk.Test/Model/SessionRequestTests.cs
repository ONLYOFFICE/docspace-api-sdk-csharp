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
    ///  Class for testing SessionRequest
    /// </summary>
    public class SessionRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SessionRequest
        //private SessionRequest instance;

        public SessionRequestTests()
        {
            // TODO uncomment below to create an instance of SessionRequest
            //instance = new SessionRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SessionRequest
        /// </summary>
        [Fact]
        public void SessionRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" SessionRequest
            //Assert.IsType<SessionRequest>(instance);
        }



        /// <summary>
        /// Test the property 'FileName'
        /// </summary>
        [Fact]
        public void FileNameTest()
        {
            // TODO unit test for the property 'FileName'
        }


        /// <summary>
        /// Test the property 'FileSize'
        /// </summary>
        [Fact]
        public void FileSizeTest()
        {
            // TODO unit test for the property 'FileSize'
        }


        /// <summary>
        /// Test the property 'RelativePath'
        /// </summary>
        [Fact]
        public void RelativePathTest()
        {
            // TODO unit test for the property 'RelativePath'
        }


        /// <summary>
        /// Test the property 'CreateOn'
        /// </summary>
        [Fact]
        public void CreateOnTest()
        {
            // TODO unit test for the property 'CreateOn'
        }


        /// <summary>
        /// Test the property 'Encrypted'
        /// </summary>
        [Fact]
        public void EncryptedTest()
        {
            // TODO unit test for the property 'Encrypted'
        }


        /// <summary>
        /// Test the property 'CreateNewIfExist'
        /// </summary>
        [Fact]
        public void CreateNewIfExistTest()
        {
            // TODO unit test for the property 'CreateNewIfExist'
        }
    }
}
