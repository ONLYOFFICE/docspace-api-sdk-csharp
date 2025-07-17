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
    ///  Class for testing SmtpSettingsDto
    /// </summary>
    public class SmtpSettingsDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SmtpSettingsDto
        //private SmtpSettingsDto instance;

        public SmtpSettingsDtoTests()
        {
            // TODO uncomment below to create an instance of SmtpSettingsDto
            //instance = new SmtpSettingsDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SmtpSettingsDto
        /// </summary>
        [Fact]
        public void SmtpSettingsDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" SmtpSettingsDto
            //Assert.IsType<SmtpSettingsDto>(instance);
        }



        /// <summary>
        /// Test the property 'Host'
        /// </summary>
        [Fact]
        public void HostTest()
        {
            // TODO unit test for the property 'Host'
        }


        /// <summary>
        /// Test the property 'Port'
        /// </summary>
        [Fact]
        public void PortTest()
        {
            // TODO unit test for the property 'Port'
        }


        /// <summary>
        /// Test the property 'SenderAddress'
        /// </summary>
        [Fact]
        public void SenderAddressTest()
        {
            // TODO unit test for the property 'SenderAddress'
        }


        /// <summary>
        /// Test the property 'SenderDisplayName'
        /// </summary>
        [Fact]
        public void SenderDisplayNameTest()
        {
            // TODO unit test for the property 'SenderDisplayName'
        }


        /// <summary>
        /// Test the property 'CredentialsUserName'
        /// </summary>
        [Fact]
        public void CredentialsUserNameTest()
        {
            // TODO unit test for the property 'CredentialsUserName'
        }


        /// <summary>
        /// Test the property 'CredentialsUserPassword'
        /// </summary>
        [Fact]
        public void CredentialsUserPasswordTest()
        {
            // TODO unit test for the property 'CredentialsUserPassword'
        }


        /// <summary>
        /// Test the property 'EnableSSL'
        /// </summary>
        [Fact]
        public void EnableSSLTest()
        {
            // TODO unit test for the property 'EnableSSL'
        }


        /// <summary>
        /// Test the property 'EnableAuth'
        /// </summary>
        [Fact]
        public void EnableAuthTest()
        {
            // TODO unit test for the property 'EnableAuth'
        }


        /// <summary>
        /// Test the property 'UseNtlm'
        /// </summary>
        [Fact]
        public void UseNtlmTest()
        {
            // TODO unit test for the property 'UseNtlm'
        }


        /// <summary>
        /// Test the property 'IsDefaultSettings'
        /// </summary>
        [Fact]
        public void IsDefaultSettingsTest()
        {
            // TODO unit test for the property 'IsDefaultSettings'
        }
    }
}
