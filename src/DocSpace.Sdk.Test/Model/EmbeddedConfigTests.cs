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
    ///  Class for testing EmbeddedConfig
    /// </summary>
    public class EmbeddedConfigTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for EmbeddedConfig
        //private EmbeddedConfig instance;

        public EmbeddedConfigTests()
        {
            // TODO uncomment below to create an instance of EmbeddedConfig
            //instance = new EmbeddedConfig();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EmbeddedConfig
        /// </summary>
        [Fact]
        public void EmbeddedConfigInstanceTest()
        {
            // TODO uncomment below to test "IsType" EmbeddedConfig
            //Assert.IsType<EmbeddedConfig>(instance);
        }



        /// <summary>
        /// Test the property 'EmbedUrl'
        /// </summary>
        [Fact]
        public void EmbedUrlTest()
        {
            // TODO unit test for the property 'EmbedUrl'
        }


        /// <summary>
        /// Test the property 'SaveUrl'
        /// </summary>
        [Fact]
        public void SaveUrlTest()
        {
            // TODO unit test for the property 'SaveUrl'
        }


        /// <summary>
        /// Test the property 'ShareLinkParam'
        /// </summary>
        [Fact]
        public void ShareLinkParamTest()
        {
            // TODO unit test for the property 'ShareLinkParam'
        }


        /// <summary>
        /// Test the property 'ShareUrl'
        /// </summary>
        [Fact]
        public void ShareUrlTest()
        {
            // TODO unit test for the property 'ShareUrl'
        }


        /// <summary>
        /// Test the property 'ToolbarDocked'
        /// </summary>
        [Fact]
        public void ToolbarDockedTest()
        {
            // TODO unit test for the property 'ToolbarDocked'
        }
    }
}
