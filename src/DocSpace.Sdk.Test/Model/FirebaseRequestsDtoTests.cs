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
    ///  Class for testing FirebaseRequestsDto
    /// </summary>
    public class FirebaseRequestsDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for FirebaseRequestsDto
        //private FirebaseRequestsDto instance;

        public FirebaseRequestsDtoTests()
        {
            // TODO uncomment below to create an instance of FirebaseRequestsDto
            //instance = new FirebaseRequestsDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FirebaseRequestsDto
        /// </summary>
        [Fact]
        public void FirebaseRequestsDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" FirebaseRequestsDto
            //Assert.IsType<FirebaseRequestsDto>(instance);
        }



        /// <summary>
        /// Test the property 'FirebaseDeviceToken'
        /// </summary>
        [Fact]
        public void FirebaseDeviceTokenTest()
        {
            // TODO unit test for the property 'FirebaseDeviceToken'
        }


        /// <summary>
        /// Test the property 'IsSubscribed'
        /// </summary>
        [Fact]
        public void IsSubscribedTest()
        {
            // TODO unit test for the property 'IsSubscribed'
        }
    }
}
