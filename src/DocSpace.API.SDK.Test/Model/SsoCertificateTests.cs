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
    ///  Class for testing SsoCertificate
    /// </summary>
    public class SsoCertificateTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SsoCertificate
        //private SsoCertificate instance;

        public SsoCertificateTests()
        {
            // TODO uncomment below to create an instance of SsoCertificate
            //instance = new SsoCertificate();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SsoCertificate
        /// </summary>
        [Fact]
        public void SsoCertificateInstanceTest()
        {
            // TODO uncomment below to test "IsType" SsoCertificate
            //Assert.IsType<SsoCertificate>(instance);
        }



        /// <summary>
        /// Test the property 'SelfSigned'
        /// </summary>
        [Fact]
        public void SelfSignedTest()
        {
            // TODO unit test for the property 'SelfSigned'
        }


        /// <summary>
        /// Test the property 'Crt'
        /// </summary>
        [Fact]
        public void CrtTest()
        {
            // TODO unit test for the property 'Crt'
        }


        /// <summary>
        /// Test the property 'Key'
        /// </summary>
        [Fact]
        public void KeyTest()
        {
            // TODO unit test for the property 'Key'
        }


        /// <summary>
        /// Test the property 'Action'
        /// </summary>
        [Fact]
        public void ActionTest()
        {
            // TODO unit test for the property 'Action'
        }


        /// <summary>
        /// Test the property 'DomainName'
        /// </summary>
        [Fact]
        public void DomainNameTest()
        {
            // TODO unit test for the property 'DomainName'
        }


        /// <summary>
        /// Test the property 'StartDate'
        /// </summary>
        [Fact]
        public void StartDateTest()
        {
            // TODO unit test for the property 'StartDate'
        }


        /// <summary>
        /// Test the property 'ExpiredDate'
        /// </summary>
        [Fact]
        public void ExpiredDateTest()
        {
            // TODO unit test for the property 'ExpiredDate'
        }
    }
}
