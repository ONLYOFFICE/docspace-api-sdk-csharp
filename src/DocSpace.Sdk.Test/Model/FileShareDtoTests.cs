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
    ///  Class for testing FileShareDto
    /// </summary>
    public class FileShareDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for FileShareDto
        //private FileShareDto instance;

        public FileShareDtoTests()
        {
            // TODO uncomment below to create an instance of FileShareDto
            //instance = new FileShareDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FileShareDto
        /// </summary>
        [Fact]
        public void FileShareDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" FileShareDto
            //Assert.IsType<FileShareDto>(instance);
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
        /// Test the property 'SharedTo'
        /// </summary>
        [Fact]
        public void SharedToTest()
        {
            // TODO unit test for the property 'SharedTo'
        }


        /// <summary>
        /// Test the property 'IsLocked'
        /// </summary>
        [Fact]
        public void IsLockedTest()
        {
            // TODO unit test for the property 'IsLocked'
        }


        /// <summary>
        /// Test the property 'IsOwner'
        /// </summary>
        [Fact]
        public void IsOwnerTest()
        {
            // TODO unit test for the property 'IsOwner'
        }


        /// <summary>
        /// Test the property 'CanEditAccess'
        /// </summary>
        [Fact]
        public void CanEditAccessTest()
        {
            // TODO unit test for the property 'CanEditAccess'
        }


        /// <summary>
        /// Test the property 'SubjectType'
        /// </summary>
        [Fact]
        public void SubjectTypeTest()
        {
            // TODO unit test for the property 'SubjectType'
        }
    }
}
