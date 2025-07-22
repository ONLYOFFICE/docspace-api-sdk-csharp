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
    ///  Class for testing BackupProgress
    /// </summary>
    public class BackupProgressTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for BackupProgress
        //private BackupProgress instance;

        public BackupProgressTests()
        {
            // TODO uncomment below to create an instance of BackupProgress
            //instance = new BackupProgress();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BackupProgress
        /// </summary>
        [Fact]
        public void BackupProgressInstanceTest()
        {
            // TODO uncomment below to test "IsType" BackupProgress
            //Assert.IsType<BackupProgress>(instance);
        }



        /// <summary>
        /// Test the property 'IsCompleted'
        /// </summary>
        [Fact]
        public void IsCompletedTest()
        {
            // TODO unit test for the property 'IsCompleted'
        }


        /// <summary>
        /// Test the property 'Progress'
        /// </summary>
        [Fact]
        public void ProgressTest()
        {
            // TODO unit test for the property 'Progress'
        }


        /// <summary>
        /// Test the property 'Error'
        /// </summary>
        [Fact]
        public void ErrorTest()
        {
            // TODO unit test for the property 'Error'
        }


        /// <summary>
        /// Test the property 'Link'
        /// </summary>
        [Fact]
        public void LinkTest()
        {
            // TODO unit test for the property 'Link'
        }


        /// <summary>
        /// Test the property 'TenantId'
        /// </summary>
        [Fact]
        public void TenantIdTest()
        {
            // TODO unit test for the property 'TenantId'
        }


        /// <summary>
        /// Test the property 'BackupProgressEnum'
        /// </summary>
        [Fact]
        public void BackupProgressEnumTest()
        {
            // TODO unit test for the property 'BackupProgressEnum'
        }


        /// <summary>
        /// Test the property 'TaskId'
        /// </summary>
        [Fact]
        public void TaskIdTest()
        {
            // TODO unit test for the property 'TaskId'
        }
    }
}
