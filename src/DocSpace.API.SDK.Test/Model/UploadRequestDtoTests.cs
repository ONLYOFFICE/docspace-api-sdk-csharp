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
    ///  Class for testing UploadRequestDto
    /// </summary>
    public class UploadRequestDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UploadRequestDto
        //private UploadRequestDto instance;

        public UploadRequestDtoTests()
        {
            // TODO uncomment below to create an instance of UploadRequestDto
            //instance = new UploadRequestDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UploadRequestDto
        /// </summary>
        [Fact]
        public void UploadRequestDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" UploadRequestDto
            //Assert.IsType<UploadRequestDto>(instance);
        }



        /// <summary>
        /// Test the property 'File'
        /// </summary>
        [Fact]
        public void FileTest()
        {
            // TODO unit test for the property 'File'
        }


        /// <summary>
        /// Test the property 'ContentType'
        /// </summary>
        [Fact]
        public void ContentTypeTest()
        {
            // TODO unit test for the property 'ContentType'
        }


        /// <summary>
        /// Test the property 'ContentDisposition'
        /// </summary>
        [Fact]
        public void ContentDispositionTest()
        {
            // TODO unit test for the property 'ContentDisposition'
        }


        /// <summary>
        /// Test the property 'Files'
        /// </summary>
        [Fact]
        public void FilesTest()
        {
            // TODO unit test for the property 'Files'
        }


        /// <summary>
        /// Test the property 'CreateNewIfExist'
        /// </summary>
        [Fact]
        public void CreateNewIfExistTest()
        {
            // TODO unit test for the property 'CreateNewIfExist'
        }


        /// <summary>
        /// Test the property 'StoreOriginalFileFlag'
        /// </summary>
        [Fact]
        public void StoreOriginalFileFlagTest()
        {
            // TODO unit test for the property 'StoreOriginalFileFlag'
        }


        /// <summary>
        /// Test the property 'KeepConvertStatus'
        /// </summary>
        [Fact]
        public void KeepConvertStatusTest()
        {
            // TODO unit test for the property 'KeepConvertStatus'
        }


        /// <summary>
        /// Test the property 'Stream'
        /// </summary>
        [Fact]
        public void StreamTest()
        {
            // TODO unit test for the property 'Stream'
        }
    }
}
