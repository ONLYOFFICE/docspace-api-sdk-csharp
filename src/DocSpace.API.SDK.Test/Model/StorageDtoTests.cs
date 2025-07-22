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
    ///  Class for testing StorageDto
    /// </summary>
    public class StorageDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for StorageDto
        //private StorageDto instance;

        public StorageDtoTests()
        {
            // TODO uncomment below to create an instance of StorageDto
            //instance = new StorageDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of StorageDto
        /// </summary>
        [Fact]
        public void StorageDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" StorageDto
            //Assert.IsType<StorageDto>(instance);
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
        /// Test the property 'Title'
        /// </summary>
        [Fact]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }


        /// <summary>
        /// Test the property 'Properties'
        /// </summary>
        [Fact]
        public void PropertiesTest()
        {
            // TODO unit test for the property 'Properties'
        }


        /// <summary>
        /// Test the property 'Current'
        /// </summary>
        [Fact]
        public void CurrentTest()
        {
            // TODO unit test for the property 'Current'
        }


        /// <summary>
        /// Test the property 'IsSet'
        /// </summary>
        [Fact]
        public void IsSetTest()
        {
            // TODO unit test for the property 'IsSet'
        }
    }
}
