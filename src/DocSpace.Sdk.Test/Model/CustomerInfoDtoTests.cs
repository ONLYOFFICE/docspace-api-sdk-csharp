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
    ///  Class for testing CustomerInfoDto
    /// </summary>
    public class CustomerInfoDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CustomerInfoDto
        //private CustomerInfoDto instance;

        public CustomerInfoDtoTests()
        {
            // TODO uncomment below to create an instance of CustomerInfoDto
            //instance = new CustomerInfoDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CustomerInfoDto
        /// </summary>
        [Fact]
        public void CustomerInfoDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" CustomerInfoDto
            //Assert.IsType<CustomerInfoDto>(instance);
        }



        /// <summary>
        /// Test the property 'PortalId'
        /// </summary>
        [Fact]
        public void PortalIdTest()
        {
            // TODO unit test for the property 'PortalId'
        }


        /// <summary>
        /// Test the property 'PaymentMethodStatus'
        /// </summary>
        [Fact]
        public void PaymentMethodStatusTest()
        {
            // TODO unit test for the property 'PaymentMethodStatus'
        }


        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Fact]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }


        /// <summary>
        /// Test the property 'Payer'
        /// </summary>
        [Fact]
        public void PayerTest()
        {
            // TODO unit test for the property 'Payer'
        }
    }
}
