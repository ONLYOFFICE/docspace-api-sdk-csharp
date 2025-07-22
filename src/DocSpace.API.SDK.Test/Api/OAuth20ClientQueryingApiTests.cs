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

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Api;
// uncomment below to import models
//using DocSpace.API.SDK.Model;

namespace DocSpace.API.SDK.Test.Api
{
    /// <summary>
    ///  Class for testing OAuth20ClientQueryingApi
    /// </summary>
    public class OAuth20ClientQueryingApiTests : IDisposable
    {
        private OAuth20ClientQueryingApi instance;

        public OAuth20ClientQueryingApiTests()
        {
            instance = new OAuth20ClientQueryingApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OAuth20ClientQueryingApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' OAuth20ClientQueryingApi
            //Assert.IsType<OAuth20ClientQueryingApi>(instance);
        }

        /// <summary>
        /// Test GetClient
        /// </summary>
        [Fact]
        public void GetClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //var response = instance.GetClient(clientId);
            //Assert.IsType<ClientResponse>(response);
        }

        /// <summary>
        /// Test GetClientInfo
        /// </summary>
        [Fact]
        public void GetClientInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //var response = instance.GetClientInfo(clientId);
            //Assert.IsType<ClientInfoResponse>(response);
        }

        /// <summary>
        /// Test GetClients
        /// </summary>
        [Fact]
        public void GetClientsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int limit = null;
            //string? lastClientId = null;
            //DateTime? lastCreatedOn = null;
            //var response = instance.GetClients(limit, lastClientId, lastCreatedOn);
            //Assert.IsType<PageableResponse>(response);
        }

        /// <summary>
        /// Test GetClientsInfo
        /// </summary>
        [Fact]
        public void GetClientsInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int limit = null;
            //string? lastClientId = null;
            //DateTime? lastCreatedOn = null;
            //var response = instance.GetClientsInfo(limit, lastClientId, lastCreatedOn);
            //Assert.IsType<PageableResponseClientInfoResponse>(response);
        }

        /// <summary>
        /// Test GetConsents
        /// </summary>
        [Fact]
        public void GetConsentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int limit = null;
            //DateTime? lastModifiedOn = null;
            //var response = instance.GetConsents(limit, lastModifiedOn);
            //Assert.IsType<PageableModificationResponse>(response);
        }

        /// <summary>
        /// Test GetPublicClientInfo
        /// </summary>
        [Fact]
        public void GetPublicClientInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //var response = instance.GetPublicClientInfo(clientId);
            //Assert.IsType<ClientInfoResponse>(response);
        }
    }
}
