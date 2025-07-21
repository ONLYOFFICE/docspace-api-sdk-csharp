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
using DocSpace.Sdk.Model;
using DocSpace.Sdk.Client;
using System.Reflection;
using System.Text.Json;

namespace DocSpace.Sdk.Test.Model
{
    /// <summary>
    ///  Class for testing MigratingApiFiles
    /// </summary>
    public class MigratingApiFilesTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MigratingApiFiles
        //private MigratingApiFiles instance;

        public MigratingApiFilesTests()
        {
            // TODO uncomment below to create an instance of MigratingApiFiles
            //instance = new MigratingApiFiles();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MigratingApiFiles
        /// </summary>
        [Fact]
        public void MigratingApiFilesInstanceTest()
        {
            // TODO uncomment below to test "IsType" MigratingApiFiles
            //Assert.IsType<MigratingApiFiles>(instance);
        }



        /// <summary>
        /// Test the property 'FoldersCount'
        /// </summary>
        [Fact]
        public void FoldersCountTest()
        {
            // TODO unit test for the property 'FoldersCount'
        }


        /// <summary>
        /// Test the property 'FilesCount'
        /// </summary>
        [Fact]
        public void FilesCountTest()
        {
            // TODO unit test for the property 'FilesCount'
        }


        /// <summary>
        /// Test the property 'BytesTotal'
        /// </summary>
        [Fact]
        public void BytesTotalTest()
        {
            // TODO unit test for the property 'BytesTotal'
        }
    }
}
