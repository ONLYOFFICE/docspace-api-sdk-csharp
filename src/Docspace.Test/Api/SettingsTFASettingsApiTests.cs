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

using DocSpace.Client;
using DocSpace.Api;
// uncomment below to import models
//using DocSpace.Model;

namespace DocSpace.Test.Api
{
    /// <summary>
    ///  Class for testing SettingsTFASettingsApi
    /// </summary>
    public class SettingsTFASettingsApiTests : IDisposable
    {
        private SettingsTFASettingsApi instance;

        public SettingsTFASettingsApiTests()
        {
            instance = new SettingsTFASettingsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsTFASettingsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SettingsTFASettingsApi
            //Assert.IsType<SettingsTFASettingsApi>(instance);
        }

        /// <summary>
        /// Test GetTfaAppCodes
        /// </summary>
        [Fact]
        public void GetTfaAppCodesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTfaAppCodes();
            //Assert.IsType<ObjectArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetTfaConfirmUrl
        /// </summary>
        [Fact]
        public void GetTfaConfirmUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTfaConfirmUrl();
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test GetTfaSettings
        /// </summary>
        [Fact]
        public void GetTfaSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTfaSettings();
            //Assert.IsType<TfaSettingsArrayWrapper>(response);
        }

        /// <summary>
        /// Test TfaAppGenerateSetupCode
        /// </summary>
        [Fact]
        public void TfaAppGenerateSetupCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.TfaAppGenerateSetupCode();
            //Assert.IsType<SetupCodeWrapper>(response);
        }

        /// <summary>
        /// Test TfaValidateAuthCode
        /// </summary>
        [Fact]
        public void TfaValidateAuthCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TfaValidateRequestsDto? tfaValidateRequestsDto = null;
            //var response = instance.TfaValidateAuthCode(tfaValidateRequestsDto);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test UnlinkTfaApp
        /// </summary>
        [Fact]
        public void UnlinkTfaAppTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TfaRequestsDto? tfaRequestsDto = null;
            //var response = instance.UnlinkTfaApp(tfaRequestsDto);
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test UpdateTfaAppCodes
        /// </summary>
        [Fact]
        public void UpdateTfaAppCodesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UpdateTfaAppCodes();
            //Assert.IsType<ObjectArrayWrapper>(response);
        }

        /// <summary>
        /// Test UpdateTfaSettings
        /// </summary>
        [Fact]
        public void UpdateTfaSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TfaRequestsDto? tfaRequestsDto = null;
            //var response = instance.UpdateTfaSettings(tfaRequestsDto);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test UpdateTfaSettingsLink
        /// </summary>
        [Fact]
        public void UpdateTfaSettingsLinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TfaRequestsDto? tfaRequestsDto = null;
            //var response = instance.UpdateTfaSettingsLink(tfaRequestsDto);
            //Assert.IsType<StringWrapper>(response);
        }
    }
}
