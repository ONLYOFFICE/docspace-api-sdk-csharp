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
    ///  Class for testing PaymentSettingsDto
    /// </summary>
    public class PaymentSettingsDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PaymentSettingsDto
        //private PaymentSettingsDto instance;

        public PaymentSettingsDtoTests()
        {
            // TODO uncomment below to create an instance of PaymentSettingsDto
            //instance = new PaymentSettingsDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PaymentSettingsDto
        /// </summary>
        [Fact]
        public void PaymentSettingsDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" PaymentSettingsDto
            //Assert.IsType<PaymentSettingsDto>(instance);
        }



        /// <summary>
        /// Test the property 'SalesEmail'
        /// </summary>
        [Fact]
        public void SalesEmailTest()
        {
            // TODO unit test for the property 'SalesEmail'
        }


        /// <summary>
        /// Test the property 'FeedbackAndSupportUrl'
        /// </summary>
        [Fact]
        public void FeedbackAndSupportUrlTest()
        {
            // TODO unit test for the property 'FeedbackAndSupportUrl'
        }


        /// <summary>
        /// Test the property 'BuyUrl'
        /// </summary>
        [Fact]
        public void BuyUrlTest()
        {
            // TODO unit test for the property 'BuyUrl'
        }


        /// <summary>
        /// Test the property 'Standalone'
        /// </summary>
        [Fact]
        public void StandaloneTest()
        {
            // TODO unit test for the property 'Standalone'
        }


        /// <summary>
        /// Test the property 'CurrentLicense'
        /// </summary>
        [Fact]
        public void CurrentLicenseTest()
        {
            // TODO unit test for the property 'CurrentLicense'
        }


        /// <summary>
        /// Test the property 'Max'
        /// </summary>
        [Fact]
        public void MaxTest()
        {
            // TODO unit test for the property 'Max'
        }
    }
}
