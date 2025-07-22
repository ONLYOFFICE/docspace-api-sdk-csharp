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
    ///  Class for testing EncryptionKeysConfig
    /// </summary>
    public class EncryptionKeysConfigTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for EncryptionKeysConfig
        //private EncryptionKeysConfig instance;

        public EncryptionKeysConfigTests()
        {
            // TODO uncomment below to create an instance of EncryptionKeysConfig
            //instance = new EncryptionKeysConfig();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EncryptionKeysConfig
        /// </summary>
        [Fact]
        public void EncryptionKeysConfigInstanceTest()
        {
            // TODO uncomment below to test "IsType" EncryptionKeysConfig
            //Assert.IsType<EncryptionKeysConfig>(instance);
        }



        /// <summary>
        /// Test the property 'CryptoEngineId'
        /// </summary>
        [Fact]
        public void CryptoEngineIdTest()
        {
            // TODO unit test for the property 'CryptoEngineId'
        }


        /// <summary>
        /// Test the property 'PrivateKeyEnc'
        /// </summary>
        [Fact]
        public void PrivateKeyEncTest()
        {
            // TODO unit test for the property 'PrivateKeyEnc'
        }


        /// <summary>
        /// Test the property 'PublicKey'
        /// </summary>
        [Fact]
        public void PublicKeyTest()
        {
            // TODO unit test for the property 'PublicKey'
        }
    }
}
