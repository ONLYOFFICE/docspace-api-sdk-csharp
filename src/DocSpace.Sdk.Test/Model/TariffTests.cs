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
    ///  Class for testing Tariff
    /// </summary>
    public class TariffTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Tariff
        //private Tariff instance;

        public TariffTests()
        {
            // TODO uncomment below to create an instance of Tariff
            //instance = new Tariff();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Tariff
        /// </summary>
        [Fact]
        public void TariffInstanceTest()
        {
            // TODO uncomment below to test "IsType" Tariff
            //Assert.IsType<Tariff>(instance);
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
        /// Test the property 'State'
        /// </summary>
        [Fact]
        public void StateTest()
        {
            // TODO unit test for the property 'State'
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
        /// Test the property 'DelayDueDate'
        /// </summary>
        [Fact]
        public void DelayDueDateTest()
        {
            // TODO unit test for the property 'DelayDueDate'
        }


        /// <summary>
        /// Test the property 'LicenseDate'
        /// </summary>
        [Fact]
        public void LicenseDateTest()
        {
            // TODO unit test for the property 'LicenseDate'
        }


        /// <summary>
        /// Test the property 'CustomerId'
        /// </summary>
        [Fact]
        public void CustomerIdTest()
        {
            // TODO unit test for the property 'CustomerId'
        }


        /// <summary>
        /// Test the property 'Quotas'
        /// </summary>
        [Fact]
        public void QuotasTest()
        {
            // TODO unit test for the property 'Quotas'
        }


        /// <summary>
        /// Test the property 'OverdueQuotas'
        /// </summary>
        [Fact]
        public void OverdueQuotasTest()
        {
            // TODO unit test for the property 'OverdueQuotas'
        }
    }
}
