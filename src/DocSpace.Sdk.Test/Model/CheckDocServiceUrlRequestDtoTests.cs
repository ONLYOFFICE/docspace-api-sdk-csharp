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
    ///  Class for testing CheckDocServiceUrlRequestDto
    /// </summary>
    public class CheckDocServiceUrlRequestDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CheckDocServiceUrlRequestDto
        //private CheckDocServiceUrlRequestDto instance;

        public CheckDocServiceUrlRequestDtoTests()
        {
            // TODO uncomment below to create an instance of CheckDocServiceUrlRequestDto
            //instance = new CheckDocServiceUrlRequestDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CheckDocServiceUrlRequestDto
        /// </summary>
        [Fact]
        public void CheckDocServiceUrlRequestDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" CheckDocServiceUrlRequestDto
            //Assert.IsType<CheckDocServiceUrlRequestDto>(instance);
        }



        /// <summary>
        /// Test the property 'DocServiceUrl'
        /// </summary>
        [Fact]
        public void DocServiceUrlTest()
        {
            // TODO unit test for the property 'DocServiceUrl'
        }


        /// <summary>
        /// Test the property 'DocServiceUrlInternal'
        /// </summary>
        [Fact]
        public void DocServiceUrlInternalTest()
        {
            // TODO unit test for the property 'DocServiceUrlInternal'
        }


        /// <summary>
        /// Test the property 'DocServiceUrlPortal'
        /// </summary>
        [Fact]
        public void DocServiceUrlPortalTest()
        {
            // TODO unit test for the property 'DocServiceUrlPortal'
        }


        /// <summary>
        /// Test the property 'DocServiceSignatureSecret'
        /// </summary>
        [Fact]
        public void DocServiceSignatureSecretTest()
        {
            // TODO unit test for the property 'DocServiceSignatureSecret'
        }


        /// <summary>
        /// Test the property 'DocServiceSignatureHeader'
        /// </summary>
        [Fact]
        public void DocServiceSignatureHeaderTest()
        {
            // TODO unit test for the property 'DocServiceSignatureHeader'
        }


        /// <summary>
        /// Test the property 'DocServiceSslVerification'
        /// </summary>
        [Fact]
        public void DocServiceSslVerificationTest()
        {
            // TODO unit test for the property 'DocServiceSslVerification'
        }
    }
}
