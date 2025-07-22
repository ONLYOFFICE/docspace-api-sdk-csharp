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
    ///  Class for testing TenantWalletSettings
    /// </summary>
    public class TenantWalletSettingsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TenantWalletSettings
        //private TenantWalletSettings instance;

        public TenantWalletSettingsTests()
        {
            // TODO uncomment below to create an instance of TenantWalletSettings
            //instance = new TenantWalletSettings();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TenantWalletSettings
        /// </summary>
        [Fact]
        public void TenantWalletSettingsInstanceTest()
        {
            // TODO uncomment below to test "IsType" TenantWalletSettings
            //Assert.IsType<TenantWalletSettings>(instance);
        }



        /// <summary>
        /// Test the property 'Enabled'
        /// </summary>
        [Fact]
        public void EnabledTest()
        {
            // TODO unit test for the property 'Enabled'
        }


        /// <summary>
        /// Test the property 'MinBalance'
        /// </summary>
        [Fact]
        public void MinBalanceTest()
        {
            // TODO unit test for the property 'MinBalance'
        }


        /// <summary>
        /// Test the property 'UpToBalance'
        /// </summary>
        [Fact]
        public void UpToBalanceTest()
        {
            // TODO unit test for the property 'UpToBalance'
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
        /// Test the property 'LastModified'
        /// </summary>
        [Fact]
        public void LastModifiedTest()
        {
            // TODO unit test for the property 'LastModified'
        }
    }
}
