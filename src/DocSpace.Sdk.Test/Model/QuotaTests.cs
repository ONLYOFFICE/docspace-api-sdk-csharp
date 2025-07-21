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
    ///  Class for testing Quota
    /// </summary>
    public class QuotaTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Quota
        //private Quota instance;

        public QuotaTests()
        {
            // TODO uncomment below to create an instance of Quota
            //instance = new Quota();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Quota
        /// </summary>
        [Fact]
        public void QuotaInstanceTest()
        {
            // TODO uncomment below to test "IsType" Quota
            //Assert.IsType<Quota>(instance);
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
        /// Test the property 'Quantity'
        /// </summary>
        [Fact]
        public void QuantityTest()
        {
            // TODO unit test for the property 'Quantity'
        }


        /// <summary>
        /// Test the property 'Wallet'
        /// </summary>
        [Fact]
        public void WalletTest()
        {
            // TODO unit test for the property 'Wallet'
        }


        /// <summary>
        /// Test the property 'DueDate'
        /// </summary>
        [Fact]
        public void DueDateTest()
        {
            // TODO unit test for the property 'DueDate'
        }


        /// <summary>
        /// Test the property 'NextQuantity'
        /// </summary>
        [Fact]
        public void NextQuantityTest()
        {
            // TODO unit test for the property 'NextQuantity'
        }


        /// <summary>
        /// Test the property 'State'
        /// </summary>
        [Fact]
        public void StateTest()
        {
            // TODO unit test for the property 'State'
        }
    }
}
