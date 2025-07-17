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
    ///  Class for testing OAuth20ClientManagementApi
    /// </summary>
    public class OAuth20ClientManagementApiTests : IDisposable
    {
        private OAuth20ClientManagementApi instance;

        public OAuth20ClientManagementApiTests()
        {
            instance = new OAuth20ClientManagementApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OAuth20ClientManagementApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' OAuth20ClientManagementApi
            //Assert.IsType<OAuth20ClientManagementApi>(instance);
        }

        /// <summary>
        /// Test ChangeActivation
        /// </summary>
        [Fact]
        public void ChangeActivationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //ChangeClientActivationRequest changeClientActivationRequest = null;
            //var response = instance.ChangeActivation(clientId, changeClientActivationRequest);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test CreateClient
        /// </summary>
        [Fact]
        public void CreateClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateClientRequest createClientRequest = null;
            //var response = instance.CreateClient(createClientRequest);
            //Assert.IsType<ClientResponse>(response);
        }

        /// <summary>
        /// Test DeleteClient
        /// </summary>
        [Fact]
        public void DeleteClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //var response = instance.DeleteClient(clientId);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test RegenerateSecret
        /// </summary>
        [Fact]
        public void RegenerateSecretTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //var response = instance.RegenerateSecret(clientId);
            //Assert.IsType<ClientSecretResponse>(response);
        }

        /// <summary>
        /// Test RevokeUserClient
        /// </summary>
        [Fact]
        public void RevokeUserClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //var response = instance.RevokeUserClient(clientId);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test UpdateClient
        /// </summary>
        [Fact]
        public void UpdateClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //UpdateClientRequest updateClientRequest = null;
            //var response = instance.UpdateClient(clientId, updateClientRequest);
            //Assert.IsType<Object>(response);
        }
    }
}
