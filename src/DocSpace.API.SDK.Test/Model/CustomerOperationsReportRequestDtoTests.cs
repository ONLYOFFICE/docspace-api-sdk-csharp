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
    ///  Class for testing CustomerOperationsReportRequestDto
    /// </summary>
    public class CustomerOperationsReportRequestDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CustomerOperationsReportRequestDto
        //private CustomerOperationsReportRequestDto instance;

        public CustomerOperationsReportRequestDtoTests()
        {
            // TODO uncomment below to create an instance of CustomerOperationsReportRequestDto
            //instance = new CustomerOperationsReportRequestDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CustomerOperationsReportRequestDto
        /// </summary>
        [Fact]
        public void CustomerOperationsReportRequestDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" CustomerOperationsReportRequestDto
            //Assert.IsType<CustomerOperationsReportRequestDto>(instance);
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
        /// Test the property 'EndDate'
        /// </summary>
        [Fact]
        public void EndDateTest()
        {
            // TODO unit test for the property 'EndDate'
        }


        /// <summary>
        /// Test the property 'Credit'
        /// </summary>
        [Fact]
        public void CreditTest()
        {
            // TODO unit test for the property 'Credit'
        }


        /// <summary>
        /// Test the property 'Withdrawal'
        /// </summary>
        [Fact]
        public void WithdrawalTest()
        {
            // TODO unit test for the property 'Withdrawal'
        }
    }
}
