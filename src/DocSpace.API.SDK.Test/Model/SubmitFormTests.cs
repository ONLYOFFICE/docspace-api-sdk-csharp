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
    ///  Class for testing SubmitForm
    /// </summary>
    public class SubmitFormTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SubmitForm
        //private SubmitForm instance;

        public SubmitFormTests()
        {
            // TODO uncomment below to create an instance of SubmitForm
            //instance = new SubmitForm();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SubmitForm
        /// </summary>
        [Fact]
        public void SubmitFormInstanceTest()
        {
            // TODO uncomment below to test "IsType" SubmitForm
            //Assert.IsType<SubmitForm>(instance);
        }



        /// <summary>
        /// Test the property 'Visible'
        /// </summary>
        [Fact]
        public void VisibleTest()
        {
            // TODO unit test for the property 'Visible'
        }


        /// <summary>
        /// Test the property 'ResultMessage'
        /// </summary>
        [Fact]
        public void ResultMessageTest()
        {
            // TODO unit test for the property 'ResultMessage'
        }
    }
}
