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
    ///  Class for testing ThirdPartyParams
    /// </summary>
    public class ThirdPartyParamsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ThirdPartyParams
        //private ThirdPartyParams instance;

        public ThirdPartyParamsTests()
        {
            // TODO uncomment below to create an instance of ThirdPartyParams
            //instance = new ThirdPartyParams();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ThirdPartyParams
        /// </summary>
        [Fact]
        public void ThirdPartyParamsInstanceTest()
        {
            // TODO uncomment below to test "IsType" ThirdPartyParams
            //Assert.IsType<ThirdPartyParams>(instance);
        }



        /// <summary>
        /// Test the property 'AuthData'
        /// </summary>
        [Fact]
        public void AuthDataTest()
        {
            // TODO unit test for the property 'AuthData'
        }


        /// <summary>
        /// Test the property 'Corporate'
        /// </summary>
        [Fact]
        public void CorporateTest()
        {
            // TODO unit test for the property 'Corporate'
        }


        /// <summary>
        /// Test the property 'RoomsStorage'
        /// </summary>
        [Fact]
        public void RoomsStorageTest()
        {
            // TODO unit test for the property 'RoomsStorage'
        }


        /// <summary>
        /// Test the property 'CustomerTitle'
        /// </summary>
        [Fact]
        public void CustomerTitleTest()
        {
            // TODO unit test for the property 'CustomerTitle'
        }


        /// <summary>
        /// Test the property 'ProviderId'
        /// </summary>
        [Fact]
        public void ProviderIdTest()
        {
            // TODO unit test for the property 'ProviderId'
        }


        /// <summary>
        /// Test the property 'ProviderKey'
        /// </summary>
        [Fact]
        public void ProviderKeyTest()
        {
            // TODO unit test for the property 'ProviderKey'
        }
    }
}
