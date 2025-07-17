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
    ///  Class for testing SettingsLicenseApi
    /// </summary>
    public class SettingsLicenseApiTests : IDisposable
    {
        private SettingsLicenseApi instance;

        public SettingsLicenseApiTests()
        {
            instance = new SettingsLicenseApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsLicenseApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SettingsLicenseApi
            //Assert.IsType<SettingsLicenseApi>(instance);
        }

        /// <summary>
        /// Test AcceptLicense
        /// </summary>
        [Fact]
        public void AcceptLicenseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.AcceptLicense();
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test GetIsLicenseRequired
        /// </summary>
        [Fact]
        public void GetIsLicenseRequiredTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetIsLicenseRequired();
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test RefreshLicense
        /// </summary>
        [Fact]
        public void RefreshLicenseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.RefreshLicense();
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test UploadLicense
        /// </summary>
        [Fact]
        public void UploadLicenseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<FileParameter> files = null;
            //var response = instance.UploadLicense(files);
            //Assert.IsType<StringWrapper>(response);
        }
    }
}
