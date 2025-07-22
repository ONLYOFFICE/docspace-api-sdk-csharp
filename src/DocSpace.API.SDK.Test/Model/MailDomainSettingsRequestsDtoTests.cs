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
    ///  Class for testing MailDomainSettingsRequestsDto
    /// </summary>
    public class MailDomainSettingsRequestsDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MailDomainSettingsRequestsDto
        //private MailDomainSettingsRequestsDto instance;

        public MailDomainSettingsRequestsDtoTests()
        {
            // TODO uncomment below to create an instance of MailDomainSettingsRequestsDto
            //instance = new MailDomainSettingsRequestsDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MailDomainSettingsRequestsDto
        /// </summary>
        [Fact]
        public void MailDomainSettingsRequestsDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" MailDomainSettingsRequestsDto
            //Assert.IsType<MailDomainSettingsRequestsDto>(instance);
        }



        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }


        /// <summary>
        /// Test the property 'Domains'
        /// </summary>
        [Fact]
        public void DomainsTest()
        {
            // TODO unit test for the property 'Domains'
        }


        /// <summary>
        /// Test the property 'InviteUsersAsVisitors'
        /// </summary>
        [Fact]
        public void InviteUsersAsVisitorsTest()
        {
            // TODO unit test for the property 'InviteUsersAsVisitors'
        }
    }
}
