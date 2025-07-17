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
    ///  Class for testing OAuth20AuthorizationApi
    /// </summary>
    public class OAuth20AuthorizationApiTests : IDisposable
    {
        private OAuth20AuthorizationApi instance;

        public OAuth20AuthorizationApiTests()
        {
            instance = new OAuth20AuthorizationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OAuth20AuthorizationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' OAuth20AuthorizationApi
            //Assert.IsType<OAuth20AuthorizationApi>(instance);
        }

        /// <summary>
        /// Test AuthorizeOAuth
        /// </summary>
        [Fact]
        public void AuthorizeOAuthTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string responseType = null;
            //string clientId = null;
            //string redirectUri = null;
            //string scope = null;
            //instance.AuthorizeOAuth(responseType, clientId, redirectUri, scope);
        }

        /// <summary>
        /// Test ExchangeToken
        /// </summary>
        [Fact]
        public void ExchangeTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? grantType = null;
            //string? code = null;
            //string? redirectUri = null;
            //string? clientId = null;
            //string? clientSecret = null;
            //var response = instance.ExchangeToken(grantType, code, redirectUri, clientId, clientSecret);
            //Assert.IsType<ExchangeToken200Response>(response);
        }

        /// <summary>
        /// Test SubmitConsent
        /// </summary>
        [Fact]
        public void SubmitConsentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? clientId = null;
            //string? state = null;
            //string? scope = null;
            //instance.SubmitConsent(clientId, state, scope);
        }
    }
}
