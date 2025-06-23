// (c) Copyright Ascensio System SIA 2009-2025
// 
// This program is a free software product.
// You can redistribute it and/or modify it under the terms
// of the GNU Affero General Public License (AGPL) version 3 as published by the Free Software
// Foundation. In accordance with Section 7(a) of the GNU AGPL its Section 15 shall be amended
// to the effect that Ascensio System SIA expressly excludes the warranty of non-infringement of
// any third-party rights.
// 
// This program is distributed WITHOUT ANY WARRANTY, without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR  PURPOSE. For details, see
// the GNU AGPL at: http://www.gnu.org/licenses/agpl-3.0.html
// 
// You can contact Ascensio System SIA at Lubanas st. 125a-25, Riga, Latvia, EU, LV-1021.
// 
// The  interactive user interfaces in modified source and object code versions of the Program must
// display Appropriate Legal Notices, as required under Section 5 of the GNU AGPL version 3.
// 
// Pursuant to Section 7(b) of the License you must retain the original Product logo when
// distributing the program. Pursuant to Section 7(e) we decline to grant you any rights under
// trademark law for use of our trademarks.
// 
// All the Product's GUI elements, including illustrations and icon sets, as well as technical writing
// content are licensed under the terms of the Creative Commons Attribution-ShareAlike 4.0
// International. See the License terms at http://creativecommons.org/licenses/by-sa/4.0/legalcode

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using Docspace.Client;
using Docspace.Api;
// uncomment below to import models
//using Docspace.Model;

namespace Docspace.Test.Api
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
