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
    ///  Class for testing ApiKeysApi
    /// </summary>
    public class ApiKeysApiTests : IDisposable
    {
        private ApiKeysApi instance;

        public ApiKeysApiTests()
        {
            instance = new ApiKeysApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ApiKeysApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ApiKeysApi
            //Assert.IsType<ApiKeysApi>(instance);
        }

        /// <summary>
        /// Test CreateApiKey
        /// </summary>
        [Fact]
        public void CreateApiKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateApiKeyRequestDto? createApiKeyRequestDto = null;
            //var response = instance.CreateApiKey(createApiKeyRequestDto);
            //Assert.IsType<ApiKeyResponseWrapper>(response);
        }

        /// <summary>
        /// Test DeleteApiKey
        /// </summary>
        [Fact]
        public void DeleteApiKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid keyId = null;
            //var response = instance.DeleteApiKey(keyId);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test GetAllPermissions
        /// </summary>
        [Fact]
        public void GetAllPermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllPermissions();
            //Assert.IsType<STRINGArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetApiKey
        /// </summary>
        [Fact]
        public void GetApiKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetApiKey();
            //Assert.IsType<ApiKeyResponseWrapper>(response);
        }

        /// <summary>
        /// Test GetApiKeys
        /// </summary>
        [Fact]
        public void GetApiKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetApiKeys();
            //Assert.IsType<ApiKeyResponseArrayWrapper>(response);
        }

        /// <summary>
        /// Test UpdateApiKey
        /// </summary>
        [Fact]
        public void UpdateApiKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid keyId = null;
            //UpdateApiKeyRequest? updateApiKeyRequest = null;
            //var response = instance.UpdateApiKey(keyId, updateApiKeyRequest);
            //Assert.IsType<BooleanWrapper>(response);
        }
    }
}
