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
    ///  Class for testing PaymentCalculation
    /// </summary>
    public class PaymentCalculationTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PaymentCalculation
        //private PaymentCalculation instance;

        public PaymentCalculationTests()
        {
            // TODO uncomment below to create an instance of PaymentCalculation
            //instance = new PaymentCalculation();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PaymentCalculation
        /// </summary>
        [Fact]
        public void PaymentCalculationInstanceTest()
        {
            // TODO uncomment below to test "IsType" PaymentCalculation
            //Assert.IsType<PaymentCalculation>(instance);
        }



        /// <summary>
        /// Test the property 'OperationId'
        /// </summary>
        [Fact]
        public void OperationIdTest()
        {
            // TODO unit test for the property 'OperationId'
        }


        /// <summary>
        /// Test the property 'Amount'
        /// </summary>
        [Fact]
        public void AmountTest()
        {
            // TODO unit test for the property 'Amount'
        }


        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Fact]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
        }


        /// <summary>
        /// Test the property 'Quantity'
        /// </summary>
        [Fact]
        public void QuantityTest()
        {
            // TODO unit test for the property 'Quantity'
        }
    }
}
