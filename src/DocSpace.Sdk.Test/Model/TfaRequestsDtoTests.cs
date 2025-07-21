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
    ///  Class for testing TfaRequestsDto
    /// </summary>
    public class TfaRequestsDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TfaRequestsDto
        //private TfaRequestsDto instance;

        public TfaRequestsDtoTests()
        {
            // TODO uncomment below to create an instance of TfaRequestsDto
            //instance = new TfaRequestsDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TfaRequestsDto
        /// </summary>
        [Fact]
        public void TfaRequestsDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" TfaRequestsDto
            //Assert.IsType<TfaRequestsDto>(instance);
        }



        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
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
        /// Test the property 'TrustedIps'
        /// </summary>
        [Fact]
        public void TrustedIpsTest()
        {
            // TODO unit test for the property 'TrustedIps'
        }


        /// <summary>
        /// Test the property 'MandatoryUsers'
        /// </summary>
        [Fact]
        public void MandatoryUsersTest()
        {
            // TODO unit test for the property 'MandatoryUsers'
        }


        /// <summary>
        /// Test the property 'MandatoryGroups'
        /// </summary>
        [Fact]
        public void MandatoryGroupsTest()
        {
            // TODO unit test for the property 'MandatoryGroups'
        }
    }
}
