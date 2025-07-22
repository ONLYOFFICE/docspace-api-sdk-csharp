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
    ///  Class for testing SettingsCommonSettingsApi
    /// </summary>
    public class SettingsCommonSettingsApiTests : IDisposable
    {
        private SettingsCommonSettingsApi instance;

        public SettingsCommonSettingsApiTests()
        {
            instance = new SettingsCommonSettingsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsCommonSettingsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SettingsCommonSettingsApi
            //Assert.IsType<SettingsCommonSettingsApi>(instance);
        }

        /// <summary>
        /// Test CloseAdminHelper
        /// </summary>
        [Fact]
        public void CloseAdminHelperTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.CloseAdminHelper();
        }

        /// <summary>
        /// Test CompleteWizard
        /// </summary>
        [Fact]
        public void CompleteWizardTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WizardRequestsDto? wizardRequestsDto = null;
            //var response = instance.CompleteWizard(wizardRequestsDto);
            //Assert.IsType<WizardSettingsWrapper>(response);
        }

        /// <summary>
        /// Test ConfigureDeepLink
        /// </summary>
        [Fact]
        public void ConfigureDeepLinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeepLinkConfigurationRequestsDto? deepLinkConfigurationRequestsDto = null;
            //var response = instance.ConfigureDeepLink(deepLinkConfigurationRequestsDto);
            //Assert.IsType<TenantDeepLinkSettingsWrapper>(response);
        }

        /// <summary>
        /// Test DeletePortalColorTheme
        /// </summary>
        [Fact]
        public void DeletePortalColorThemeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.DeletePortalColorTheme(id);
            //Assert.IsType<CustomColorThemesSettingsWrapper>(response);
        }

        /// <summary>
        /// Test GetDeepLinkSettings
        /// </summary>
        [Fact]
        public void GetDeepLinkSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetDeepLinkSettings();
            //Assert.IsType<TenantDeepLinkSettingsWrapper>(response);
        }

        /// <summary>
        /// Test GetPaymentSettings
        /// </summary>
        [Fact]
        public void GetPaymentSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPaymentSettings();
            //Assert.IsType<PaymentSettingsWrapper>(response);
        }

        /// <summary>
        /// Test GetPortalColorTheme
        /// </summary>
        [Fact]
        public void GetPortalColorThemeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPortalColorTheme();
            //Assert.IsType<CustomColorThemesSettingsWrapper>(response);
        }

        /// <summary>
        /// Test GetPortalHostname
        /// </summary>
        [Fact]
        public void GetPortalHostnameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPortalHostname();
            //Assert.IsType<ObjectWrapper>(response);
        }

        /// <summary>
        /// Test GetPortalLogo
        /// </summary>
        [Fact]
        public void GetPortalLogoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPortalLogo();
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test GetPortalSettings
        /// </summary>
        [Fact]
        public void GetPortalSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? withpassword = null;
            //var response = instance.GetPortalSettings(withpassword);
            //Assert.IsType<SettingsWrapper>(response);
        }

        /// <summary>
        /// Test GetSocketSettings
        /// </summary>
        [Fact]
        public void GetSocketSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetSocketSettings();
            //Assert.IsType<ObjectWrapper>(response);
        }

        /// <summary>
        /// Test GetSupportedCultures
        /// </summary>
        [Fact]
        public void GetSupportedCulturesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetSupportedCultures();
            //Assert.IsType<STRINGArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetTenantUserInvitationSettings
        /// </summary>
        [Fact]
        public void GetTenantUserInvitationSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTenantUserInvitationSettings();
            //Assert.IsType<TenantUserInvitationSettingsWrapper>(response);
        }

        /// <summary>
        /// Test GetTimeZones
        /// </summary>
        [Fact]
        public void GetTimeZonesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTimeZones();
            //Assert.IsType<TimezonesRequestsArrayWrapper>(response);
        }

        /// <summary>
        /// Test SaveDnsSettings
        /// </summary>
        [Fact]
        public void SaveDnsSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DnsSettingsRequestsDto? dnsSettingsRequestsDto = null;
            //var response = instance.SaveDnsSettings(dnsSettingsRequestsDto);
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test SaveMailDomainSettings
        /// </summary>
        [Fact]
        public void SaveMailDomainSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MailDomainSettingsRequestsDto? mailDomainSettingsRequestsDto = null;
            //var response = instance.SaveMailDomainSettings(mailDomainSettingsRequestsDto);
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test SavePortalColorTheme
        /// </summary>
        [Fact]
        public void SavePortalColorThemeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CustomColorThemesSettingsRequestsDto? customColorThemesSettingsRequestsDto = null;
            //var response = instance.SavePortalColorTheme(customColorThemesSettingsRequestsDto);
            //Assert.IsType<CustomColorThemesSettingsWrapper>(response);
        }

        /// <summary>
        /// Test UpdateEmailActivationSettings
        /// </summary>
        [Fact]
        public void UpdateEmailActivationSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmailActivationSettings? emailActivationSettings = null;
            //var response = instance.UpdateEmailActivationSettings(emailActivationSettings);
            //Assert.IsType<EmailActivationSettingsWrapper>(response);
        }

        /// <summary>
        /// Test UpdateInvitationSettings
        /// </summary>
        [Fact]
        public void UpdateInvitationSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TenantUserInvitationSettingsRequestDto? tenantUserInvitationSettingsRequestDto = null;
            //var response = instance.UpdateInvitationSettings(tenantUserInvitationSettingsRequestDto);
            //Assert.IsType<TenantUserInvitationSettingsWrapper>(response);
        }
    }
}
