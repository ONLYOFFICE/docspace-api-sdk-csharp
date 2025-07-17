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
    ///  Class for testing SecuritySMTPSettingsApi
    /// </summary>
    public class SecuritySMTPSettingsApiTests : IDisposable
    {
        private SecuritySMTPSettingsApi instance;

        public SecuritySMTPSettingsApiTests()
        {
            instance = new SecuritySMTPSettingsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SecuritySMTPSettingsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SecuritySMTPSettingsApi
            //Assert.IsType<SecuritySMTPSettingsApi>(instance);
        }

        /// <summary>
        /// Test GetSmtpOperationStatus
        /// </summary>
        [Fact]
        public void GetSmtpOperationStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetSmtpOperationStatus();
            //Assert.IsType<SmtpOperationStatusRequestsWrapper>(response);
        }

        /// <summary>
        /// Test GetSmtpSettings
        /// </summary>
        [Fact]
        public void GetSmtpSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetSmtpSettings();
            //Assert.IsType<SmtpSettingsWrapper>(response);
        }

        /// <summary>
        /// Test ResetSmtpSettings
        /// </summary>
        [Fact]
        public void ResetSmtpSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ResetSmtpSettings();
            //Assert.IsType<SmtpSettingsWrapper>(response);
        }

        /// <summary>
        /// Test SaveSmtpSettings
        /// </summary>
        [Fact]
        public void SaveSmtpSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SmtpSettingsDto? smtpSettingsDto = null;
            //var response = instance.SaveSmtpSettings(smtpSettingsDto);
            //Assert.IsType<SmtpSettingsWrapper>(response);
        }

        /// <summary>
        /// Test TestSmtpSettings
        /// </summary>
        [Fact]
        public void TestSmtpSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.TestSmtpSettings();
            //Assert.IsType<SmtpOperationStatusRequestsWrapper>(response);
        }
    }
}
