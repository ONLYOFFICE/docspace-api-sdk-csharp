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
    ///  Class for testing CurrenciesDto
    /// </summary>
    public class CurrenciesDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CurrenciesDto
        //private CurrenciesDto instance;

        public CurrenciesDtoTests()
        {
            // TODO uncomment below to create an instance of CurrenciesDto
            //instance = new CurrenciesDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CurrenciesDto
        /// </summary>
        [Fact]
        public void CurrenciesDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" CurrenciesDto
            //Assert.IsType<CurrenciesDto>(instance);
        }



        /// <summary>
        /// Test the property 'IsoCountryCode'
        /// </summary>
        [Fact]
        public void IsoCountryCodeTest()
        {
            // TODO unit test for the property 'IsoCountryCode'
        }


        /// <summary>
        /// Test the property 'IsoCurrencySymbol'
        /// </summary>
        [Fact]
        public void IsoCurrencySymbolTest()
        {
            // TODO unit test for the property 'IsoCurrencySymbol'
        }


        /// <summary>
        /// Test the property 'CurrencyNativeName'
        /// </summary>
        [Fact]
        public void CurrencyNativeNameTest()
        {
            // TODO unit test for the property 'CurrencyNativeName'
        }
    }
}
