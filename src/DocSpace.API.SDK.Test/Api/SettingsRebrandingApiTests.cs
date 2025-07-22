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
    ///  Class for testing SettingsRebrandingApi
    /// </summary>
    public class SettingsRebrandingApiTests : IDisposable
    {
        private SettingsRebrandingApi instance;

        public SettingsRebrandingApiTests()
        {
            instance = new SettingsRebrandingApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsRebrandingApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SettingsRebrandingApi
            //Assert.IsType<SettingsRebrandingApi>(instance);
        }

        /// <summary>
        /// Test DeleteAdditionalWhiteLabelSettings
        /// </summary>
        [Fact]
        public void DeleteAdditionalWhiteLabelSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.DeleteAdditionalWhiteLabelSettings();
            //Assert.IsType<AdditionalWhiteLabelSettingsWrapper>(response);
        }

        /// <summary>
        /// Test DeleteCompanyWhiteLabelSettings
        /// </summary>
        [Fact]
        public void DeleteCompanyWhiteLabelSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.DeleteCompanyWhiteLabelSettings();
            //Assert.IsType<CompanyWhiteLabelSettingsWrapper>(response);
        }

        /// <summary>
        /// Test GetAdditionalWhiteLabelSettings
        /// </summary>
        [Fact]
        public void GetAdditionalWhiteLabelSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAdditionalWhiteLabelSettings();
            //Assert.IsType<AdditionalWhiteLabelSettingsWrapper>(response);
        }

        /// <summary>
        /// Test GetCompanyWhiteLabelSettings
        /// </summary>
        [Fact]
        public void GetCompanyWhiteLabelSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetCompanyWhiteLabelSettings();
            //Assert.IsType<CompanyWhiteLabelSettingsWrapper>(response);
        }

        /// <summary>
        /// Test GetEnableWhitelabel
        /// </summary>
        [Fact]
        public void GetEnableWhitelabelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetEnableWhitelabel();
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test GetIsDefaultWhiteLabelLogoText
        /// </summary>
        [Fact]
        public void GetIsDefaultWhiteLabelLogoTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? isDark = null;
            //bool? isDefault = null;
            //var response = instance.GetIsDefaultWhiteLabelLogoText(isDark, isDefault);
            //Assert.IsType<IsDefaultWhiteLabelLogosWrapper>(response);
        }

        /// <summary>
        /// Test GetIsDefaultWhiteLabelLogos
        /// </summary>
        [Fact]
        public void GetIsDefaultWhiteLabelLogosTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? isDark = null;
            //bool? isDefault = null;
            //var response = instance.GetIsDefaultWhiteLabelLogos(isDark, isDefault);
            //Assert.IsType<IsDefaultWhiteLabelLogosArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetLicensorData
        /// </summary>
        [Fact]
        public void GetLicensorDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetLicensorData();
            //Assert.IsType<CompanyWhiteLabelSettingsArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetWhiteLabelLogoText
        /// </summary>
        [Fact]
        public void GetWhiteLabelLogoTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? isDark = null;
            //bool? isDefault = null;
            //var response = instance.GetWhiteLabelLogoText(isDark, isDefault);
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test GetWhiteLabelLogos
        /// </summary>
        [Fact]
        public void GetWhiteLabelLogosTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? isDark = null;
            //bool? isDefault = null;
            //var response = instance.GetWhiteLabelLogos(isDark, isDefault);
            //Assert.IsType<WhiteLabelItemArrayWrapper>(response);
        }

        /// <summary>
        /// Test RestoreWhiteLabelLogoText
        /// </summary>
        [Fact]
        public void RestoreWhiteLabelLogoTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? isDark = null;
            //bool? isDefault = null;
            //var response = instance.RestoreWhiteLabelLogoText(isDark, isDefault);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test RestoreWhiteLabelLogos
        /// </summary>
        [Fact]
        public void RestoreWhiteLabelLogosTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? isDark = null;
            //bool? isDefault = null;
            //var response = instance.RestoreWhiteLabelLogos(isDark, isDefault);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test SaveAdditionalWhiteLabelSettings
        /// </summary>
        [Fact]
        public void SaveAdditionalWhiteLabelSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AdditionalWhiteLabelSettingsWrapper? additionalWhiteLabelSettingsWrapper = null;
            //var response = instance.SaveAdditionalWhiteLabelSettings(additionalWhiteLabelSettingsWrapper);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test SaveCompanyWhiteLabelSettings
        /// </summary>
        [Fact]
        public void SaveCompanyWhiteLabelSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CompanyWhiteLabelSettingsWrapper? companyWhiteLabelSettingsWrapper = null;
            //var response = instance.SaveCompanyWhiteLabelSettings(companyWhiteLabelSettingsWrapper);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test SaveWhiteLabelLogoText
        /// </summary>
        [Fact]
        public void SaveWhiteLabelLogoTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? isDark = null;
            //bool? isDefault = null;
            //WhiteLabelRequestsDto? whiteLabelRequestsDto = null;
            //var response = instance.SaveWhiteLabelLogoText(isDark, isDefault, whiteLabelRequestsDto);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test SaveWhiteLabelSettings
        /// </summary>
        [Fact]
        public void SaveWhiteLabelSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? isDark = null;
            //bool? isDefault = null;
            //WhiteLabelRequestsDto? whiteLabelRequestsDto = null;
            //var response = instance.SaveWhiteLabelSettings(isDark, isDefault, whiteLabelRequestsDto);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test SaveWhiteLabelSettingsFromFiles
        /// </summary>
        [Fact]
        public void SaveWhiteLabelSettingsFromFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? isDark = null;
            //bool? isDefault = null;
            //var response = instance.SaveWhiteLabelSettingsFromFiles(isDark, isDefault);
            //Assert.IsType<BooleanWrapper>(response);
        }
    }
}
