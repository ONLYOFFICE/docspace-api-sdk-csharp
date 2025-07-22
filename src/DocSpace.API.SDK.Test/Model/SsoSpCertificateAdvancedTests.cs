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
    ///  Class for testing SsoSpCertificateAdvanced
    /// </summary>
    public class SsoSpCertificateAdvancedTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SsoSpCertificateAdvanced
        //private SsoSpCertificateAdvanced instance;

        public SsoSpCertificateAdvancedTests()
        {
            // TODO uncomment below to create an instance of SsoSpCertificateAdvanced
            //instance = new SsoSpCertificateAdvanced();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SsoSpCertificateAdvanced
        /// </summary>
        [Fact]
        public void SsoSpCertificateAdvancedInstanceTest()
        {
            // TODO uncomment below to test "IsType" SsoSpCertificateAdvanced
            //Assert.IsType<SsoSpCertificateAdvanced>(instance);
        }



        /// <summary>
        /// Test the property 'SigningAlgorithm'
        /// </summary>
        [Fact]
        public void SigningAlgorithmTest()
        {
            // TODO unit test for the property 'SigningAlgorithm'
        }


        /// <summary>
        /// Test the property 'SignAuthRequests'
        /// </summary>
        [Fact]
        public void SignAuthRequestsTest()
        {
            // TODO unit test for the property 'SignAuthRequests'
        }


        /// <summary>
        /// Test the property 'SignLogoutRequests'
        /// </summary>
        [Fact]
        public void SignLogoutRequestsTest()
        {
            // TODO unit test for the property 'SignLogoutRequests'
        }


        /// <summary>
        /// Test the property 'SignLogoutResponses'
        /// </summary>
        [Fact]
        public void SignLogoutResponsesTest()
        {
            // TODO unit test for the property 'SignLogoutResponses'
        }


        /// <summary>
        /// Test the property 'EncryptAlgorithm'
        /// </summary>
        [Fact]
        public void EncryptAlgorithmTest()
        {
            // TODO unit test for the property 'EncryptAlgorithm'
        }


        /// <summary>
        /// Test the property 'DecryptAlgorithm'
        /// </summary>
        [Fact]
        public void DecryptAlgorithmTest()
        {
            // TODO unit test for the property 'DecryptAlgorithm'
        }


        /// <summary>
        /// Test the property 'EncryptAssertions'
        /// </summary>
        [Fact]
        public void EncryptAssertionsTest()
        {
            // TODO unit test for the property 'EncryptAssertions'
        }
    }
}
