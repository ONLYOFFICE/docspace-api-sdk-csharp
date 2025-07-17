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
    ///  Class for testing FilesStatisticsResultDto
    /// </summary>
    public class FilesStatisticsResultDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for FilesStatisticsResultDto
        //private FilesStatisticsResultDto instance;

        public FilesStatisticsResultDtoTests()
        {
            // TODO uncomment below to create an instance of FilesStatisticsResultDto
            //instance = new FilesStatisticsResultDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FilesStatisticsResultDto
        /// </summary>
        [Fact]
        public void FilesStatisticsResultDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" FilesStatisticsResultDto
            //Assert.IsType<FilesStatisticsResultDto>(instance);
        }



        /// <summary>
        /// Test the property 'MyDocumentsUsedSpace'
        /// </summary>
        [Fact]
        public void MyDocumentsUsedSpaceTest()
        {
            // TODO unit test for the property 'MyDocumentsUsedSpace'
        }


        /// <summary>
        /// Test the property 'TrashUsedSpace'
        /// </summary>
        [Fact]
        public void TrashUsedSpaceTest()
        {
            // TODO unit test for the property 'TrashUsedSpace'
        }


        /// <summary>
        /// Test the property 'ArchiveUsedSpace'
        /// </summary>
        [Fact]
        public void ArchiveUsedSpaceTest()
        {
            // TODO unit test for the property 'ArchiveUsedSpace'
        }


        /// <summary>
        /// Test the property 'RoomsUsedSpace'
        /// </summary>
        [Fact]
        public void RoomsUsedSpaceTest()
        {
            // TODO unit test for the property 'RoomsUsedSpace'
        }
    }
}
