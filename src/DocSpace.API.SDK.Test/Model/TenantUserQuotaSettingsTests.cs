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
    ///  Class for testing TenantUserQuotaSettings
    /// </summary>
    public class TenantUserQuotaSettingsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TenantUserQuotaSettings
        //private TenantUserQuotaSettings instance;

        public TenantUserQuotaSettingsTests()
        {
            // TODO uncomment below to create an instance of TenantUserQuotaSettings
            //instance = new TenantUserQuotaSettings();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TenantUserQuotaSettings
        /// </summary>
        [Fact]
        public void TenantUserQuotaSettingsInstanceTest()
        {
            // TODO uncomment below to test "IsType" TenantUserQuotaSettings
            //Assert.IsType<TenantUserQuotaSettings>(instance);
        }



        /// <summary>
        /// Test the property 'EnableQuota'
        /// </summary>
        [Fact]
        public void EnableQuotaTest()
        {
            // TODO unit test for the property 'EnableQuota'
        }


        /// <summary>
        /// Test the property 'DefaultQuota'
        /// </summary>
        [Fact]
        public void DefaultQuotaTest()
        {
            // TODO unit test for the property 'DefaultQuota'
        }


        /// <summary>
        /// Test the property 'LastRecalculateDate'
        /// </summary>
        [Fact]
        public void LastRecalculateDateTest()
        {
            // TODO unit test for the property 'LastRecalculateDate'
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
