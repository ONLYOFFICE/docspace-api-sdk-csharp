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

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using DocSpace.Sdk.Client;
using DocSpace.Sdk.Api;
// uncomment below to import models
//using DocSpace.Sdk.Model;

namespace DocSpace.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing PeopleThirdPartyAccountsApi
    /// </summary>
    public class PeopleThirdPartyAccountsApiTests : IDisposable
    {
        private PeopleThirdPartyAccountsApi instance;

        public PeopleThirdPartyAccountsApiTests()
        {
            instance = new PeopleThirdPartyAccountsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PeopleThirdPartyAccountsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PeopleThirdPartyAccountsApi
            //Assert.IsType<PeopleThirdPartyAccountsApi>(instance);
        }

        /// <summary>
        /// Test GetThirdPartyAuthProviders
        /// </summary>
        [Fact]
        public void GetThirdPartyAuthProvidersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? inviteView = null;
            //bool? settingsView = null;
            //string? clientCallback = null;
            //string? fromOnly = null;
            //var response = instance.GetThirdPartyAuthProviders(inviteView, settingsView, clientCallback, fromOnly);
            //Assert.IsType<AccountInfoArrayWrapper>(response);
        }

        /// <summary>
        /// Test LinkThirdPartyAccount
        /// </summary>
        [Fact]
        public void LinkThirdPartyAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LinkAccountRequestDto? linkAccountRequestDto = null;
            //instance.LinkThirdPartyAccount(linkAccountRequestDto);
        }

        /// <summary>
        /// Test SignupThirdPartyAccount
        /// </summary>
        [Fact]
        public void SignupThirdPartyAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SignupAccountRequestDto? signupAccountRequestDto = null;
            //instance.SignupThirdPartyAccount(signupAccountRequestDto);
        }

        /// <summary>
        /// Test UnlinkThirdPartyAccount
        /// </summary>
        [Fact]
        public void UnlinkThirdPartyAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? provider = null;
            //instance.UnlinkThirdPartyAccount(provider);
        }
    }
}
