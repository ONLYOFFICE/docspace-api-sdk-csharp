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
    ///  Class for testing Paragraph
    /// </summary>
    public class ParagraphTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Paragraph
        //private Paragraph instance;

        public ParagraphTests()
        {
            // TODO uncomment below to create an instance of Paragraph
            //instance = new Paragraph();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Paragraph
        /// </summary>
        [Fact]
        public void ParagraphInstanceTest()
        {
            // TODO uncomment below to test "IsType" Paragraph
            //Assert.IsType<Paragraph>(instance);
        }



        /// <summary>
        /// Test the property 'Align'
        /// </summary>
        [Fact]
        public void AlignTest()
        {
            // TODO unit test for the property 'Align'
        }


        /// <summary>
        /// Test the property 'Runs'
        /// </summary>
        [Fact]
        public void RunsTest()
        {
            // TODO unit test for the property 'Runs'
        }
    }
}
