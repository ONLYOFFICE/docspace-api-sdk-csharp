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
    ///  Class for testing SsoIdpCertificateAdvanced
    /// </summary>
    public class SsoIdpCertificateAdvancedTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SsoIdpCertificateAdvanced
        //private SsoIdpCertificateAdvanced instance;

        public SsoIdpCertificateAdvancedTests()
        {
            // TODO uncomment below to create an instance of SsoIdpCertificateAdvanced
            //instance = new SsoIdpCertificateAdvanced();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SsoIdpCertificateAdvanced
        /// </summary>
        [Fact]
        public void SsoIdpCertificateAdvancedInstanceTest()
        {
            // TODO uncomment below to test "IsType" SsoIdpCertificateAdvanced
            //Assert.IsType<SsoIdpCertificateAdvanced>(instance);
        }



        /// <summary>
        /// Test the property 'VerifyAlgorithm'
        /// </summary>
        [Fact]
        public void VerifyAlgorithmTest()
        {
            // TODO unit test for the property 'VerifyAlgorithm'
        }


        /// <summary>
        /// Test the property 'VerifyAuthResponsesSign'
        /// </summary>
        [Fact]
        public void VerifyAuthResponsesSignTest()
        {
            // TODO unit test for the property 'VerifyAuthResponsesSign'
        }


        /// <summary>
        /// Test the property 'VerifyLogoutRequestsSign'
        /// </summary>
        [Fact]
        public void VerifyLogoutRequestsSignTest()
        {
            // TODO unit test for the property 'VerifyLogoutRequestsSign'
        }


        /// <summary>
        /// Test the property 'VerifyLogoutResponsesSign'
        /// </summary>
        [Fact]
        public void VerifyLogoutResponsesSignTest()
        {
            // TODO unit test for the property 'VerifyLogoutResponsesSign'
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
        /// Test the property 'DecryptAssertions'
        /// </summary>
        [Fact]
        public void DecryptAssertionsTest()
        {
            // TODO unit test for the property 'DecryptAssertions'
        }
    }
}
