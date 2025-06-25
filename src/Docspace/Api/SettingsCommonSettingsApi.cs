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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using Docspace.Client;
using Docspace.Model;

namespace Docspace.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsCommonSettingsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Close the admin helper
        /// </summary>
        /// <remarks>
        /// Closes the administrator helper notification.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/close-admin-helper/">REST API Reference for CloseAdminHelper Operation</seealso>
        /// <returns></returns>
        void CloseAdminHelper();

        /// <summary>
        /// Close the admin helper
        /// </summary>
        /// <remarks>
        /// Closes the administrator helper notification.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/close-admin-helper/">REST API Reference for CloseAdminHelper Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CloseAdminHelperWithHttpInfo();
        /// <summary>
        /// Complete the Wizard settings
        /// </summary>
        /// <remarks>
        /// Completes the Wizard settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/complete-wizard/">REST API Reference for CompleteWizard Operation</seealso>
        /// <returns>WizardSettingsWrapper</returns>
        WizardSettingsWrapper CompleteWizard(WizardRequestsDto? wizardRequestsDto = default);

        /// <summary>
        /// Complete the Wizard settings
        /// </summary>
        /// <remarks>
        /// Completes the Wizard settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/complete-wizard/">REST API Reference for CompleteWizard Operation</seealso>
        /// <returns>ApiResponse of WizardSettingsWrapper</returns>
        ApiResponse<WizardSettingsWrapper> CompleteWizardWithHttpInfo(WizardRequestsDto? wizardRequestsDto = default);
        /// <summary>
        /// Configure the deep link settings
        /// </summary>
        /// <remarks>
        /// Saves the deep link configuration settings for the portal.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/configure-deep-link/">REST API Reference for ConfigureDeepLink Operation</seealso>
        /// <returns>TenantDeepLinkSettingsWrapper</returns>
        TenantDeepLinkSettingsWrapper ConfigureDeepLink(DeepLinkConfigurationRequestsDto? deepLinkConfigurationRequestsDto = default);

        /// <summary>
        /// Configure the deep link settings
        /// </summary>
        /// <remarks>
        /// Saves the deep link configuration settings for the portal.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/configure-deep-link/">REST API Reference for ConfigureDeepLink Operation</seealso>
        /// <returns>ApiResponse of TenantDeepLinkSettingsWrapper</returns>
        ApiResponse<TenantDeepLinkSettingsWrapper> ConfigureDeepLinkWithHttpInfo(DeepLinkConfigurationRequestsDto? deepLinkConfigurationRequestsDto = default);
        /// <summary>
        /// Delete a color theme
        /// </summary>
        /// <remarks>
        /// Deletes the portal color theme with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the portal theme to delete. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-portal-color-theme/">REST API Reference for DeletePortalColorTheme Operation</seealso>
        /// <returns>CustomColorThemesSettingsWrapper</returns>
        CustomColorThemesSettingsWrapper DeletePortalColorTheme(int? id = default);

        /// <summary>
        /// Delete a color theme
        /// </summary>
        /// <remarks>
        /// Deletes the portal color theme with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the portal theme to delete. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-portal-color-theme/">REST API Reference for DeletePortalColorTheme Operation</seealso>
        /// <returns>ApiResponse of CustomColorThemesSettingsWrapper</returns>
        ApiResponse<CustomColorThemesSettingsWrapper> DeletePortalColorThemeWithHttpInfo(int? id = default);
        /// <summary>
        /// Get the deep link settings
        /// </summary>
        /// <remarks>
        /// Returns the deep link settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-deep-link-settings/">REST API Reference for GetDeepLinkSettings Operation</seealso>
        /// <returns>TenantDeepLinkSettingsWrapper</returns>
        TenantDeepLinkSettingsWrapper GetDeepLinkSettings();

        /// <summary>
        /// Get the deep link settings
        /// </summary>
        /// <remarks>
        /// Returns the deep link settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-deep-link-settings/">REST API Reference for GetDeepLinkSettings Operation</seealso>
        /// <returns>ApiResponse of TenantDeepLinkSettingsWrapper</returns>
        ApiResponse<TenantDeepLinkSettingsWrapper> GetDeepLinkSettingsWithHttpInfo();
        /// <summary>
        /// Get the payment settings
        /// </summary>
        /// <remarks>
        /// Returns the portal payment settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-settings/">REST API Reference for GetPaymentSettings Operation</seealso>
        /// <returns>PaymentSettingsWrapper</returns>
        PaymentSettingsWrapper GetPaymentSettings();

        /// <summary>
        /// Get the payment settings
        /// </summary>
        /// <remarks>
        /// Returns the portal payment settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-settings/">REST API Reference for GetPaymentSettings Operation</seealso>
        /// <returns>ApiResponse of PaymentSettingsWrapper</returns>
        ApiResponse<PaymentSettingsWrapper> GetPaymentSettingsWithHttpInfo();
        /// <summary>
        /// Get a color theme
        /// </summary>
        /// <remarks>
        /// Returns the portal color theme.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-color-theme/">REST API Reference for GetPortalColorTheme Operation</seealso>
        /// <returns>CustomColorThemesSettingsWrapper</returns>
        CustomColorThemesSettingsWrapper GetPortalColorTheme();

        /// <summary>
        /// Get a color theme
        /// </summary>
        /// <remarks>
        /// Returns the portal color theme.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-color-theme/">REST API Reference for GetPortalColorTheme Operation</seealso>
        /// <returns>ApiResponse of CustomColorThemesSettingsWrapper</returns>
        ApiResponse<CustomColorThemesSettingsWrapper> GetPortalColorThemeWithHttpInfo();
        /// <summary>
        /// Get hostname
        /// </summary>
        /// <remarks>
        /// Returns the portal hostname.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-hostname/">REST API Reference for GetPortalHostname Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        ObjectWrapper GetPortalHostname();

        /// <summary>
        /// Get hostname
        /// </summary>
        /// <remarks>
        /// Returns the portal hostname.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-hostname/">REST API Reference for GetPortalHostname Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        ApiResponse<ObjectWrapper> GetPortalHostnameWithHttpInfo();
        /// <summary>
        /// Get a portal logo
        /// </summary>
        /// <remarks>
        /// Returns the portal logo image URL.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-logo/">REST API Reference for GetPortalLogo Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper GetPortalLogo();

        /// <summary>
        /// Get a portal logo
        /// </summary>
        /// <remarks>
        /// Returns the portal logo image URL.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-logo/">REST API Reference for GetPortalLogo Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> GetPortalLogoWithHttpInfo();
        /// <summary>
        /// Get the portal settings
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal settings with the current values for each parameter.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withpassword">Specifies whether to include the password hashing configuration in the response. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-settings/">REST API Reference for GetPortalSettings Operation</seealso>
        /// <returns>SettingsWrapper</returns>
        SettingsWrapper GetPortalSettings(bool? withpassword = default);

        /// <summary>
        /// Get the portal settings
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal settings with the current values for each parameter.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withpassword">Specifies whether to include the password hashing configuration in the response. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-settings/">REST API Reference for GetPortalSettings Operation</seealso>
        /// <returns>ApiResponse of SettingsWrapper</returns>
        ApiResponse<SettingsWrapper> GetPortalSettingsWithHttpInfo(bool? withpassword = default);
        /// <summary>
        /// Get the socket settings
        /// </summary>
        /// <remarks>
        /// Returns the socket settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-socket-settings/">REST API Reference for GetSocketSettings Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        ObjectWrapper GetSocketSettings();

        /// <summary>
        /// Get the socket settings
        /// </summary>
        /// <remarks>
        /// Returns the socket settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-socket-settings/">REST API Reference for GetSocketSettings Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        ApiResponse<ObjectWrapper> GetSocketSettingsWithHttpInfo();
        /// <summary>
        /// Get supported languages
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal languages in the format of a two-letter or four-letter language code (e.g. \&quot;de\&quot;, \&quot;en-US\&quot;, etc.).
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-supported-cultures/">REST API Reference for GetSupportedCultures Operation</seealso>
        /// <returns>STRINGArrayWrapper</returns>
        STRINGArrayWrapper GetSupportedCultures();

        /// <summary>
        /// Get supported languages
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal languages in the format of a two-letter or four-letter language code (e.g. \&quot;de\&quot;, \&quot;en-US\&quot;, etc.).
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-supported-cultures/">REST API Reference for GetSupportedCultures Operation</seealso>
        /// <returns>ApiResponse of STRINGArrayWrapper</returns>
        ApiResponse<STRINGArrayWrapper> GetSupportedCulturesWithHttpInfo();
        /// <summary>
        /// Get the user invitation settings
        /// </summary>
        /// <remarks>
        /// Returns the portal user invitation settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-user-invitation-settings/">REST API Reference for GetTenantUserInvitationSettings Operation</seealso>
        /// <returns>TenantUserInvitationSettingsWrapper</returns>
        TenantUserInvitationSettingsWrapper GetTenantUserInvitationSettings();

        /// <summary>
        /// Get the user invitation settings
        /// </summary>
        /// <remarks>
        /// Returns the portal user invitation settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-user-invitation-settings/">REST API Reference for GetTenantUserInvitationSettings Operation</seealso>
        /// <returns>ApiResponse of TenantUserInvitationSettingsWrapper</returns>
        ApiResponse<TenantUserInvitationSettingsWrapper> GetTenantUserInvitationSettingsWithHttpInfo();
        /// <summary>
        /// Get time zones
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal time zones.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-time-zones/">REST API Reference for GetTimeZones Operation</seealso>
        /// <returns>TimezonesRequestsArrayWrapper</returns>
        TimezonesRequestsArrayWrapper GetTimeZones();

        /// <summary>
        /// Get time zones
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal time zones.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-time-zones/">REST API Reference for GetTimeZones Operation</seealso>
        /// <returns>ApiResponse of TimezonesRequestsArrayWrapper</returns>
        ApiResponse<TimezonesRequestsArrayWrapper> GetTimeZonesWithHttpInfo();
        /// <summary>
        /// Save the DNS settings
        /// </summary>
        /// <remarks>
        /// Saves the DNS settings specified in the request to the current portal.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-dns-settings/">REST API Reference for SaveDnsSettings Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper SaveDnsSettings(DnsSettingsRequestsDto? dnsSettingsRequestsDto = default);

        /// <summary>
        /// Save the DNS settings
        /// </summary>
        /// <remarks>
        /// Saves the DNS settings specified in the request to the current portal.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-dns-settings/">REST API Reference for SaveDnsSettings Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> SaveDnsSettingsWithHttpInfo(DnsSettingsRequestsDto? dnsSettingsRequestsDto = default);
        /// <summary>
        /// Save the mail domain settings
        /// </summary>
        /// <remarks>
        /// Saves the mail domain settings specified in the request to the portal.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mail-domain-settings/">REST API Reference for SaveMailDomainSettings Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper SaveMailDomainSettings(MailDomainSettingsRequestsDto? mailDomainSettingsRequestsDto = default);

        /// <summary>
        /// Save the mail domain settings
        /// </summary>
        /// <remarks>
        /// Saves the mail domain settings specified in the request to the portal.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mail-domain-settings/">REST API Reference for SaveMailDomainSettings Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> SaveMailDomainSettingsWithHttpInfo(MailDomainSettingsRequestsDto? mailDomainSettingsRequestsDto = default);
        /// <summary>
        /// Save a color theme
        /// </summary>
        /// <remarks>
        /// Saves the portal color theme specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-portal-color-theme/">REST API Reference for SavePortalColorTheme Operation</seealso>
        /// <returns>CustomColorThemesSettingsWrapper</returns>
        CustomColorThemesSettingsWrapper SavePortalColorTheme(CustomColorThemesSettingsRequestsDto? customColorThemesSettingsRequestsDto = default);

        /// <summary>
        /// Save a color theme
        /// </summary>
        /// <remarks>
        /// Saves the portal color theme specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-portal-color-theme/">REST API Reference for SavePortalColorTheme Operation</seealso>
        /// <returns>ApiResponse of CustomColorThemesSettingsWrapper</returns>
        ApiResponse<CustomColorThemesSettingsWrapper> SavePortalColorThemeWithHttpInfo(CustomColorThemesSettingsRequestsDto? customColorThemesSettingsRequestsDto = default);
        /// <summary>
        /// Update the email activation settings
        /// </summary>
        /// <remarks>
        /// Updates the email activation settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailActivationSettings"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-email-activation-settings/">REST API Reference for UpdateEmailActivationSettings Operation</seealso>
        /// <returns>EmailActivationSettingsWrapper</returns>
        EmailActivationSettingsWrapper UpdateEmailActivationSettings(EmailActivationSettings? emailActivationSettings = default);

        /// <summary>
        /// Update the email activation settings
        /// </summary>
        /// <remarks>
        /// Updates the email activation settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailActivationSettings"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-email-activation-settings/">REST API Reference for UpdateEmailActivationSettings Operation</seealso>
        /// <returns>ApiResponse of EmailActivationSettingsWrapper</returns>
        ApiResponse<EmailActivationSettingsWrapper> UpdateEmailActivationSettingsWithHttpInfo(EmailActivationSettings? emailActivationSettings = default);
        /// <summary>
        /// Update user invitation settings
        /// </summary>
        /// <remarks>
        /// Updates the portal user invitation settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-settings/">REST API Reference for UpdateInvitationSettings Operation</seealso>
        /// <returns>TenantUserInvitationSettingsWrapper</returns>
        TenantUserInvitationSettingsWrapper UpdateInvitationSettings(TenantUserInvitationSettingsRequestDto? tenantUserInvitationSettingsRequestDto = default);

        /// <summary>
        /// Update user invitation settings
        /// </summary>
        /// <remarks>
        /// Updates the portal user invitation settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-settings/">REST API Reference for UpdateInvitationSettings Operation</seealso>
        /// <returns>ApiResponse of TenantUserInvitationSettingsWrapper</returns>
        ApiResponse<TenantUserInvitationSettingsWrapper> UpdateInvitationSettingsWithHttpInfo(TenantUserInvitationSettingsRequestDto? tenantUserInvitationSettingsRequestDto = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsCommonSettingsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Close the admin helper
        /// </summary>
        /// <remarks>
        /// Closes the administrator helper notification.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/close-admin-helper/">REST API Reference for CloseAdminHelper Operation</seealso>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CloseAdminHelperAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Close the admin helper
        /// </summary>
        /// <remarks>
        /// Closes the administrator helper notification.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/close-admin-helper/">REST API Reference for CloseAdminHelper Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CloseAdminHelperWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Complete the Wizard settings
        /// </summary>
        /// <remarks>
        /// Completes the Wizard settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/complete-wizard/">REST API Reference for CompleteWizard Operation</seealso>
        /// <returns>Task of WizardSettingsWrapper</returns>
        System.Threading.Tasks.Task<WizardSettingsWrapper> CompleteWizardAsync(WizardRequestsDto? wizardRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Complete the Wizard settings
        /// </summary>
        /// <remarks>
        /// Completes the Wizard settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/complete-wizard/">REST API Reference for CompleteWizard Operation</seealso>
        /// <returns>Task of ApiResponse (WizardSettingsWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<WizardSettingsWrapper>> CompleteWizardWithHttpInfoAsync(WizardRequestsDto? wizardRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Configure the deep link settings
        /// </summary>
        /// <remarks>
        /// Saves the deep link configuration settings for the portal.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/configure-deep-link/">REST API Reference for ConfigureDeepLink Operation</seealso>
        /// <returns>Task of TenantDeepLinkSettingsWrapper</returns>
        System.Threading.Tasks.Task<TenantDeepLinkSettingsWrapper> ConfigureDeepLinkAsync(DeepLinkConfigurationRequestsDto? deepLinkConfigurationRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Configure the deep link settings
        /// </summary>
        /// <remarks>
        /// Saves the deep link configuration settings for the portal.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/configure-deep-link/">REST API Reference for ConfigureDeepLink Operation</seealso>
        /// <returns>Task of ApiResponse (TenantDeepLinkSettingsWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<TenantDeepLinkSettingsWrapper>> ConfigureDeepLinkWithHttpInfoAsync(DeepLinkConfigurationRequestsDto? deepLinkConfigurationRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a color theme
        /// </summary>
        /// <remarks>
        /// Deletes the portal color theme with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the portal theme to delete. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-portal-color-theme/">REST API Reference for DeletePortalColorTheme Operation</seealso>
        /// <returns>Task of CustomColorThemesSettingsWrapper</returns>
        System.Threading.Tasks.Task<CustomColorThemesSettingsWrapper> DeletePortalColorThemeAsync(int? id = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a color theme
        /// </summary>
        /// <remarks>
        /// Deletes the portal color theme with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the portal theme to delete. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-portal-color-theme/">REST API Reference for DeletePortalColorTheme Operation</seealso>
        /// <returns>Task of ApiResponse (CustomColorThemesSettingsWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomColorThemesSettingsWrapper>> DeletePortalColorThemeWithHttpInfoAsync(int? id = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the deep link settings
        /// </summary>
        /// <remarks>
        /// Returns the deep link settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-deep-link-settings/">REST API Reference for GetDeepLinkSettings Operation</seealso>
        /// <returns>Task of TenantDeepLinkSettingsWrapper</returns>
        System.Threading.Tasks.Task<TenantDeepLinkSettingsWrapper> GetDeepLinkSettingsAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the deep link settings
        /// </summary>
        /// <remarks>
        /// Returns the deep link settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-deep-link-settings/">REST API Reference for GetDeepLinkSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantDeepLinkSettingsWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<TenantDeepLinkSettingsWrapper>> GetDeepLinkSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the payment settings
        /// </summary>
        /// <remarks>
        /// Returns the portal payment settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-settings/">REST API Reference for GetPaymentSettings Operation</seealso>
        /// <returns>Task of PaymentSettingsWrapper</returns>
        System.Threading.Tasks.Task<PaymentSettingsWrapper> GetPaymentSettingsAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the payment settings
        /// </summary>
        /// <remarks>
        /// Returns the portal payment settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-settings/">REST API Reference for GetPaymentSettings Operation</seealso>
        /// <returns>Task of ApiResponse (PaymentSettingsWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaymentSettingsWrapper>> GetPaymentSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a color theme
        /// </summary>
        /// <remarks>
        /// Returns the portal color theme.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-color-theme/">REST API Reference for GetPortalColorTheme Operation</seealso>
        /// <returns>Task of CustomColorThemesSettingsWrapper</returns>
        System.Threading.Tasks.Task<CustomColorThemesSettingsWrapper> GetPortalColorThemeAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a color theme
        /// </summary>
        /// <remarks>
        /// Returns the portal color theme.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-color-theme/">REST API Reference for GetPortalColorTheme Operation</seealso>
        /// <returns>Task of ApiResponse (CustomColorThemesSettingsWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomColorThemesSettingsWrapper>> GetPortalColorThemeWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get hostname
        /// </summary>
        /// <remarks>
        /// Returns the portal hostname.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-hostname/">REST API Reference for GetPortalHostname Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        System.Threading.Tasks.Task<ObjectWrapper> GetPortalHostnameAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get hostname
        /// </summary>
        /// <remarks>
        /// Returns the portal hostname.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-hostname/">REST API Reference for GetPortalHostname Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<ObjectWrapper>> GetPortalHostnameWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a portal logo
        /// </summary>
        /// <remarks>
        /// Returns the portal logo image URL.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-logo/">REST API Reference for GetPortalLogo Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        System.Threading.Tasks.Task<StringWrapper> GetPortalLogoAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a portal logo
        /// </summary>
        /// <remarks>
        /// Returns the portal logo image URL.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-logo/">REST API Reference for GetPortalLogo Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringWrapper>> GetPortalLogoWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the portal settings
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal settings with the current values for each parameter.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withpassword">Specifies whether to include the password hashing configuration in the response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-settings/">REST API Reference for GetPortalSettings Operation</seealso>
        /// <returns>Task of SettingsWrapper</returns>
        System.Threading.Tasks.Task<SettingsWrapper> GetPortalSettingsAsync(bool? withpassword = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the portal settings
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal settings with the current values for each parameter.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withpassword">Specifies whether to include the password hashing configuration in the response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-settings/">REST API Reference for GetPortalSettings Operation</seealso>
        /// <returns>Task of ApiResponse (SettingsWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<SettingsWrapper>> GetPortalSettingsWithHttpInfoAsync(bool? withpassword = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the socket settings
        /// </summary>
        /// <remarks>
        /// Returns the socket settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-socket-settings/">REST API Reference for GetSocketSettings Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        System.Threading.Tasks.Task<ObjectWrapper> GetSocketSettingsAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the socket settings
        /// </summary>
        /// <remarks>
        /// Returns the socket settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-socket-settings/">REST API Reference for GetSocketSettings Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<ObjectWrapper>> GetSocketSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get supported languages
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal languages in the format of a two-letter or four-letter language code (e.g. \&quot;de\&quot;, \&quot;en-US\&quot;, etc.).
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-supported-cultures/">REST API Reference for GetSupportedCultures Operation</seealso>
        /// <returns>Task of STRINGArrayWrapper</returns>
        System.Threading.Tasks.Task<STRINGArrayWrapper> GetSupportedCulturesAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get supported languages
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal languages in the format of a two-letter or four-letter language code (e.g. \&quot;de\&quot;, \&quot;en-US\&quot;, etc.).
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-supported-cultures/">REST API Reference for GetSupportedCultures Operation</seealso>
        /// <returns>Task of ApiResponse (STRINGArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<STRINGArrayWrapper>> GetSupportedCulturesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the user invitation settings
        /// </summary>
        /// <remarks>
        /// Returns the portal user invitation settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-user-invitation-settings/">REST API Reference for GetTenantUserInvitationSettings Operation</seealso>
        /// <returns>Task of TenantUserInvitationSettingsWrapper</returns>
        System.Threading.Tasks.Task<TenantUserInvitationSettingsWrapper> GetTenantUserInvitationSettingsAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the user invitation settings
        /// </summary>
        /// <remarks>
        /// Returns the portal user invitation settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-user-invitation-settings/">REST API Reference for GetTenantUserInvitationSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantUserInvitationSettingsWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<TenantUserInvitationSettingsWrapper>> GetTenantUserInvitationSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get time zones
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal time zones.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-time-zones/">REST API Reference for GetTimeZones Operation</seealso>
        /// <returns>Task of TimezonesRequestsArrayWrapper</returns>
        System.Threading.Tasks.Task<TimezonesRequestsArrayWrapper> GetTimeZonesAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get time zones
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal time zones.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-time-zones/">REST API Reference for GetTimeZones Operation</seealso>
        /// <returns>Task of ApiResponse (TimezonesRequestsArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimezonesRequestsArrayWrapper>> GetTimeZonesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Save the DNS settings
        /// </summary>
        /// <remarks>
        /// Saves the DNS settings specified in the request to the current portal.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-dns-settings/">REST API Reference for SaveDnsSettings Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        System.Threading.Tasks.Task<StringWrapper> SaveDnsSettingsAsync(DnsSettingsRequestsDto? dnsSettingsRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Save the DNS settings
        /// </summary>
        /// <remarks>
        /// Saves the DNS settings specified in the request to the current portal.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-dns-settings/">REST API Reference for SaveDnsSettings Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringWrapper>> SaveDnsSettingsWithHttpInfoAsync(DnsSettingsRequestsDto? dnsSettingsRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Save the mail domain settings
        /// </summary>
        /// <remarks>
        /// Saves the mail domain settings specified in the request to the portal.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mail-domain-settings/">REST API Reference for SaveMailDomainSettings Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        System.Threading.Tasks.Task<StringWrapper> SaveMailDomainSettingsAsync(MailDomainSettingsRequestsDto? mailDomainSettingsRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Save the mail domain settings
        /// </summary>
        /// <remarks>
        /// Saves the mail domain settings specified in the request to the portal.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mail-domain-settings/">REST API Reference for SaveMailDomainSettings Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringWrapper>> SaveMailDomainSettingsWithHttpInfoAsync(MailDomainSettingsRequestsDto? mailDomainSettingsRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Save a color theme
        /// </summary>
        /// <remarks>
        /// Saves the portal color theme specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-portal-color-theme/">REST API Reference for SavePortalColorTheme Operation</seealso>
        /// <returns>Task of CustomColorThemesSettingsWrapper</returns>
        System.Threading.Tasks.Task<CustomColorThemesSettingsWrapper> SavePortalColorThemeAsync(CustomColorThemesSettingsRequestsDto? customColorThemesSettingsRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Save a color theme
        /// </summary>
        /// <remarks>
        /// Saves the portal color theme specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-portal-color-theme/">REST API Reference for SavePortalColorTheme Operation</seealso>
        /// <returns>Task of ApiResponse (CustomColorThemesSettingsWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomColorThemesSettingsWrapper>> SavePortalColorThemeWithHttpInfoAsync(CustomColorThemesSettingsRequestsDto? customColorThemesSettingsRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the email activation settings
        /// </summary>
        /// <remarks>
        /// Updates the email activation settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailActivationSettings"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-email-activation-settings/">REST API Reference for UpdateEmailActivationSettings Operation</seealso>
        /// <returns>Task of EmailActivationSettingsWrapper</returns>
        System.Threading.Tasks.Task<EmailActivationSettingsWrapper> UpdateEmailActivationSettingsAsync(EmailActivationSettings? emailActivationSettings = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update the email activation settings
        /// </summary>
        /// <remarks>
        /// Updates the email activation settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailActivationSettings"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-email-activation-settings/">REST API Reference for UpdateEmailActivationSettings Operation</seealso>
        /// <returns>Task of ApiResponse (EmailActivationSettingsWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailActivationSettingsWrapper>> UpdateEmailActivationSettingsWithHttpInfoAsync(EmailActivationSettings? emailActivationSettings = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update user invitation settings
        /// </summary>
        /// <remarks>
        /// Updates the portal user invitation settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-settings/">REST API Reference for UpdateInvitationSettings Operation</seealso>
        /// <returns>Task of TenantUserInvitationSettingsWrapper</returns>
        System.Threading.Tasks.Task<TenantUserInvitationSettingsWrapper> UpdateInvitationSettingsAsync(TenantUserInvitationSettingsRequestDto? tenantUserInvitationSettingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update user invitation settings
        /// </summary>
        /// <remarks>
        /// Updates the portal user invitation settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-settings/">REST API Reference for UpdateInvitationSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantUserInvitationSettingsWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<TenantUserInvitationSettingsWrapper>> UpdateInvitationSettingsWithHttpInfoAsync(TenantUserInvitationSettingsRequestDto? tenantUserInvitationSettingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsCommonSettingsApi : ISettingsCommonSettingsApiSync, ISettingsCommonSettingsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SettingsCommonSettingsApi : IDisposable, ISettingsCommonSettingsApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsCommonSettingsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public SettingsCommonSettingsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsCommonSettingsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public SettingsCommonSettingsApi(string basePath)
        {
            this.Configuration = Docspace.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            this.ApiClient = new ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Docspace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsCommonSettingsApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public SettingsCommonSettingsApi(Configuration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);

            this.Configuration = Docspace.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Docspace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsCommonSettingsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public SettingsCommonSettingsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsCommonSettingsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public SettingsCommonSettingsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(client);

            this.Configuration = Docspace.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            this.ApiClient = new ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Docspace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsCommonSettingsApi"/> class using a Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public SettingsCommonSettingsApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            ArgumentNullException.ThrowIfNull(client);

            this.Configuration = Docspace.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Docspace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsCommonSettingsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SettingsCommonSettingsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(client);
            ArgumentNullException.ThrowIfNull(asyncClient);
            ArgumentNullException.ThrowIfNull(configuration);

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Docspace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set => _exceptionFactory = value; 
        }

        /// <summary>
        /// Close the admin helper Closes the administrator helper notification.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/close-admin-helper/">REST API Reference for CloseAdminHelper Operation</seealso>
        /// <returns></returns>
        public void CloseAdminHelper()
        {
            CloseAdminHelperWithHttpInfo();
        }

        /// <summary>
        /// Close the admin helper Closes the administrator helper notification.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/close-admin-helper/">REST API Reference for CloseAdminHelper Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CloseAdminHelperWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<Object>("/api/2.0/settings/closeadminhelper", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CloseAdminHelper", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Close the admin helper Closes the administrator helper notification.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/close-admin-helper/">REST API Reference for CloseAdminHelper Operation</seealso>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CloseAdminHelperAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            await CloseAdminHelperWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Close the admin helper Closes the administrator helper notification.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/close-admin-helper/">REST API Reference for CloseAdminHelper Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CloseAdminHelperWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<Object>("/api/2.0/settings/closeadminhelper", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CloseAdminHelper", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Complete the Wizard settings Completes the Wizard settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/complete-wizard/">REST API Reference for CompleteWizard Operation</seealso>
        /// <returns>WizardSettingsWrapper</returns>
        public WizardSettingsWrapper CompleteWizard(WizardRequestsDto? wizardRequestsDto = default)
        {
            var localVarResponse = CompleteWizardWithHttpInfo(wizardRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Complete the Wizard settings Completes the Wizard settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/complete-wizard/">REST API Reference for CompleteWizard Operation</seealso>
        /// <returns>ApiResponse of WizardSettingsWrapper</returns>
        public ApiResponse<WizardSettingsWrapper> CompleteWizardWithHttpInfo(WizardRequestsDto? wizardRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (wizardRequestsDto != null) localVarRequestOptions.Data = wizardRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<WizardSettingsWrapper>("/api/2.0/settings/wizard/complete", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CompleteWizard", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Complete the Wizard settings Completes the Wizard settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/complete-wizard/">REST API Reference for CompleteWizard Operation</seealso>
        /// <returns>Task of WizardSettingsWrapper</returns>
        public async System.Threading.Tasks.Task<WizardSettingsWrapper> CompleteWizardAsync(WizardRequestsDto? wizardRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<WizardSettingsWrapper> localVarResponse = await CompleteWizardWithHttpInfoAsync(wizardRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Complete the Wizard settings Completes the Wizard settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/complete-wizard/">REST API Reference for CompleteWizard Operation</seealso>
        /// <returns>Task of ApiResponse (WizardSettingsWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WizardSettingsWrapper>> CompleteWizardWithHttpInfoAsync(WizardRequestsDto? wizardRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (wizardRequestsDto != null) localVarRequestOptions.Data = wizardRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<WizardSettingsWrapper>("/api/2.0/settings/wizard/complete", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CompleteWizard", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Configure the deep link settings Saves the deep link configuration settings for the portal.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/configure-deep-link/">REST API Reference for ConfigureDeepLink Operation</seealso>
        /// <returns>TenantDeepLinkSettingsWrapper</returns>
        public TenantDeepLinkSettingsWrapper ConfigureDeepLink(DeepLinkConfigurationRequestsDto? deepLinkConfigurationRequestsDto = default)
        {
            var localVarResponse = ConfigureDeepLinkWithHttpInfo(deepLinkConfigurationRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Configure the deep link settings Saves the deep link configuration settings for the portal.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/configure-deep-link/">REST API Reference for ConfigureDeepLink Operation</seealso>
        /// <returns>ApiResponse of TenantDeepLinkSettingsWrapper</returns>
        public ApiResponse<TenantDeepLinkSettingsWrapper> ConfigureDeepLinkWithHttpInfo(DeepLinkConfigurationRequestsDto? deepLinkConfigurationRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (deepLinkConfigurationRequestsDto != null) localVarRequestOptions.Data = deepLinkConfigurationRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Post<TenantDeepLinkSettingsWrapper>("/api/2.0/settings/deeplink", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("ConfigureDeepLink", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Configure the deep link settings Saves the deep link configuration settings for the portal.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/configure-deep-link/">REST API Reference for ConfigureDeepLink Operation</seealso>
        /// <returns>Task of TenantDeepLinkSettingsWrapper</returns>
        public async System.Threading.Tasks.Task<TenantDeepLinkSettingsWrapper> ConfigureDeepLinkAsync(DeepLinkConfigurationRequestsDto? deepLinkConfigurationRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<TenantDeepLinkSettingsWrapper> localVarResponse = await ConfigureDeepLinkWithHttpInfoAsync(deepLinkConfigurationRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Configure the deep link settings Saves the deep link configuration settings for the portal.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/configure-deep-link/">REST API Reference for ConfigureDeepLink Operation</seealso>
        /// <returns>Task of ApiResponse (TenantDeepLinkSettingsWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TenantDeepLinkSettingsWrapper>> ConfigureDeepLinkWithHttpInfoAsync(DeepLinkConfigurationRequestsDto? deepLinkConfigurationRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (deepLinkConfigurationRequestsDto != null) localVarRequestOptions.Data = deepLinkConfigurationRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<TenantDeepLinkSettingsWrapper>("/api/2.0/settings/deeplink", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("ConfigureDeepLink", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a color theme Deletes the portal color theme with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the portal theme to delete. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-portal-color-theme/">REST API Reference for DeletePortalColorTheme Operation</seealso>
        /// <returns>CustomColorThemesSettingsWrapper</returns>
        public CustomColorThemesSettingsWrapper DeletePortalColorTheme(int? id = default)
        {
            var localVarResponse = DeletePortalColorThemeWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a color theme Deletes the portal color theme with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the portal theme to delete. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-portal-color-theme/">REST API Reference for DeletePortalColorTheme Operation</seealso>
        /// <returns>ApiResponse of CustomColorThemesSettingsWrapper</returns>
        public ApiResponse<CustomColorThemesSettingsWrapper> DeletePortalColorThemeWithHttpInfo(int? id = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "id", id));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Delete<CustomColorThemesSettingsWrapper>("/api/2.0/settings/colortheme", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("DeletePortalColorTheme", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a color theme Deletes the portal color theme with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the portal theme to delete. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-portal-color-theme/">REST API Reference for DeletePortalColorTheme Operation</seealso>
        /// <returns>Task of CustomColorThemesSettingsWrapper</returns>
        public async System.Threading.Tasks.Task<CustomColorThemesSettingsWrapper> DeletePortalColorThemeAsync(int? id = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<CustomColorThemesSettingsWrapper> localVarResponse = await DeletePortalColorThemeWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a color theme Deletes the portal color theme with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the portal theme to delete. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-portal-color-theme/">REST API Reference for DeletePortalColorTheme Operation</seealso>
        /// <returns>Task of ApiResponse (CustomColorThemesSettingsWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CustomColorThemesSettingsWrapper>> DeletePortalColorThemeWithHttpInfoAsync(int? id = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "id", id));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<CustomColorThemesSettingsWrapper>("/api/2.0/settings/colortheme", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("DeletePortalColorTheme", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the deep link settings Returns the deep link settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-deep-link-settings/">REST API Reference for GetDeepLinkSettings Operation</seealso>
        /// <returns>TenantDeepLinkSettingsWrapper</returns>
        public TenantDeepLinkSettingsWrapper GetDeepLinkSettings()
        {
            var localVarResponse = GetDeepLinkSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the deep link settings Returns the deep link settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-deep-link-settings/">REST API Reference for GetDeepLinkSettings Operation</seealso>
        /// <returns>ApiResponse of TenantDeepLinkSettingsWrapper</returns>
        public ApiResponse<TenantDeepLinkSettingsWrapper> GetDeepLinkSettingsWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<TenantDeepLinkSettingsWrapper>("/api/2.0/settings/deeplink", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetDeepLinkSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the deep link settings Returns the deep link settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-deep-link-settings/">REST API Reference for GetDeepLinkSettings Operation</seealso>
        /// <returns>Task of TenantDeepLinkSettingsWrapper</returns>
        public async System.Threading.Tasks.Task<TenantDeepLinkSettingsWrapper> GetDeepLinkSettingsAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<TenantDeepLinkSettingsWrapper> localVarResponse = await GetDeepLinkSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the deep link settings Returns the deep link settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-deep-link-settings/">REST API Reference for GetDeepLinkSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantDeepLinkSettingsWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TenantDeepLinkSettingsWrapper>> GetDeepLinkSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<TenantDeepLinkSettingsWrapper>("/api/2.0/settings/deeplink", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetDeepLinkSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the payment settings Returns the portal payment settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-settings/">REST API Reference for GetPaymentSettings Operation</seealso>
        /// <returns>PaymentSettingsWrapper</returns>
        public PaymentSettingsWrapper GetPaymentSettings()
        {
            var localVarResponse = GetPaymentSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the payment settings Returns the portal payment settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-settings/">REST API Reference for GetPaymentSettings Operation</seealso>
        /// <returns>ApiResponse of PaymentSettingsWrapper</returns>
        public ApiResponse<PaymentSettingsWrapper> GetPaymentSettingsWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<PaymentSettingsWrapper>("/api/2.0/settings/payment", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetPaymentSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the payment settings Returns the portal payment settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-settings/">REST API Reference for GetPaymentSettings Operation</seealso>
        /// <returns>Task of PaymentSettingsWrapper</returns>
        public async System.Threading.Tasks.Task<PaymentSettingsWrapper> GetPaymentSettingsAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<PaymentSettingsWrapper> localVarResponse = await GetPaymentSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the payment settings Returns the portal payment settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-settings/">REST API Reference for GetPaymentSettings Operation</seealso>
        /// <returns>Task of ApiResponse (PaymentSettingsWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PaymentSettingsWrapper>> GetPaymentSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<PaymentSettingsWrapper>("/api/2.0/settings/payment", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetPaymentSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a color theme Returns the portal color theme.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-color-theme/">REST API Reference for GetPortalColorTheme Operation</seealso>
        /// <returns>CustomColorThemesSettingsWrapper</returns>
        public CustomColorThemesSettingsWrapper GetPortalColorTheme()
        {
            var localVarResponse = GetPortalColorThemeWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a color theme Returns the portal color theme.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-color-theme/">REST API Reference for GetPortalColorTheme Operation</seealso>
        /// <returns>ApiResponse of CustomColorThemesSettingsWrapper</returns>
        public ApiResponse<CustomColorThemesSettingsWrapper> GetPortalColorThemeWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = this.Client.Get<CustomColorThemesSettingsWrapper>("/api/2.0/settings/colortheme", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetPortalColorTheme", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a color theme Returns the portal color theme.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-color-theme/">REST API Reference for GetPortalColorTheme Operation</seealso>
        /// <returns>Task of CustomColorThemesSettingsWrapper</returns>
        public async System.Threading.Tasks.Task<CustomColorThemesSettingsWrapper> GetPortalColorThemeAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<CustomColorThemesSettingsWrapper> localVarResponse = await GetPortalColorThemeWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a color theme Returns the portal color theme.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-color-theme/">REST API Reference for GetPortalColorTheme Operation</seealso>
        /// <returns>Task of ApiResponse (CustomColorThemesSettingsWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CustomColorThemesSettingsWrapper>> GetPortalColorThemeWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<CustomColorThemesSettingsWrapper>("/api/2.0/settings/colortheme", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetPortalColorTheme", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get hostname Returns the portal hostname.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-hostname/">REST API Reference for GetPortalHostname Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        public ObjectWrapper GetPortalHostname()
        {
            var localVarResponse = GetPortalHostnameWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get hostname Returns the portal hostname.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-hostname/">REST API Reference for GetPortalHostname Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        public ApiResponse<ObjectWrapper> GetPortalHostnameWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<ObjectWrapper>("/api/2.0/settings/machine", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetPortalHostname", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get hostname Returns the portal hostname.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-hostname/">REST API Reference for GetPortalHostname Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        public async System.Threading.Tasks.Task<ObjectWrapper> GetPortalHostnameAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ObjectWrapper> localVarResponse = await GetPortalHostnameWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get hostname Returns the portal hostname.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-hostname/">REST API Reference for GetPortalHostname Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ObjectWrapper>> GetPortalHostnameWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ObjectWrapper>("/api/2.0/settings/machine", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetPortalHostname", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a portal logo Returns the portal logo image URL.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-logo/">REST API Reference for GetPortalLogo Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper GetPortalLogo()
        {
            var localVarResponse = GetPortalLogoWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a portal logo Returns the portal logo image URL.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-logo/">REST API Reference for GetPortalLogo Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> GetPortalLogoWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<StringWrapper>("/api/2.0/settings/logo", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetPortalLogo", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a portal logo Returns the portal logo image URL.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-logo/">REST API Reference for GetPortalLogo Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async System.Threading.Tasks.Task<StringWrapper> GetPortalLogoAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<StringWrapper> localVarResponse = await GetPortalLogoWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a portal logo Returns the portal logo image URL.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-logo/">REST API Reference for GetPortalLogo Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StringWrapper>> GetPortalLogoWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<StringWrapper>("/api/2.0/settings/logo", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetPortalLogo", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the portal settings Returns a list of all the available portal settings with the current values for each parameter.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withpassword">Specifies whether to include the password hashing configuration in the response. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-settings/">REST API Reference for GetPortalSettings Operation</seealso>
        /// <returns>SettingsWrapper</returns>
        public SettingsWrapper GetPortalSettings(bool? withpassword = default)
        {
            var localVarResponse = GetPortalSettingsWithHttpInfo(withpassword);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the portal settings Returns a list of all the available portal settings with the current values for each parameter.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withpassword">Specifies whether to include the password hashing configuration in the response. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-settings/">REST API Reference for GetPortalSettings Operation</seealso>
        /// <returns>ApiResponse of SettingsWrapper</returns>
        public ApiResponse<SettingsWrapper> GetPortalSettingsWithHttpInfo(bool? withpassword = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (withpassword != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "withpassword", withpassword));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<SettingsWrapper>("/api/2.0/settings", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetPortalSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the portal settings Returns a list of all the available portal settings with the current values for each parameter.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withpassword">Specifies whether to include the password hashing configuration in the response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-settings/">REST API Reference for GetPortalSettings Operation</seealso>
        /// <returns>Task of SettingsWrapper</returns>
        public async System.Threading.Tasks.Task<SettingsWrapper> GetPortalSettingsAsync(bool? withpassword = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<SettingsWrapper> localVarResponse = await GetPortalSettingsWithHttpInfoAsync(withpassword, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the portal settings Returns a list of all the available portal settings with the current values for each parameter.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withpassword">Specifies whether to include the password hashing configuration in the response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-settings/">REST API Reference for GetPortalSettings Operation</seealso>
        /// <returns>Task of ApiResponse (SettingsWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SettingsWrapper>> GetPortalSettingsWithHttpInfoAsync(bool? withpassword = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (withpassword != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "withpassword", withpassword));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<SettingsWrapper>("/api/2.0/settings", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetPortalSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the socket settings Returns the socket settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-socket-settings/">REST API Reference for GetSocketSettings Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        public ObjectWrapper GetSocketSettings()
        {
            var localVarResponse = GetSocketSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the socket settings Returns the socket settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-socket-settings/">REST API Reference for GetSocketSettings Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        public ApiResponse<ObjectWrapper> GetSocketSettingsWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<ObjectWrapper>("/api/2.0/settings/socket", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetSocketSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the socket settings Returns the socket settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-socket-settings/">REST API Reference for GetSocketSettings Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        public async System.Threading.Tasks.Task<ObjectWrapper> GetSocketSettingsAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ObjectWrapper> localVarResponse = await GetSocketSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the socket settings Returns the socket settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-socket-settings/">REST API Reference for GetSocketSettings Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ObjectWrapper>> GetSocketSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ObjectWrapper>("/api/2.0/settings/socket", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetSocketSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get supported languages Returns a list of all the available portal languages in the format of a two-letter or four-letter language code (e.g. \&quot;de\&quot;, \&quot;en-US\&quot;, etc.).
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-supported-cultures/">REST API Reference for GetSupportedCultures Operation</seealso>
        /// <returns>STRINGArrayWrapper</returns>
        public STRINGArrayWrapper GetSupportedCultures()
        {
            var localVarResponse = GetSupportedCulturesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get supported languages Returns a list of all the available portal languages in the format of a two-letter or four-letter language code (e.g. \&quot;de\&quot;, \&quot;en-US\&quot;, etc.).
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-supported-cultures/">REST API Reference for GetSupportedCultures Operation</seealso>
        /// <returns>ApiResponse of STRINGArrayWrapper</returns>
        public ApiResponse<STRINGArrayWrapper> GetSupportedCulturesWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = this.Client.Get<STRINGArrayWrapper>("/api/2.0/settings/cultures", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetSupportedCultures", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get supported languages Returns a list of all the available portal languages in the format of a two-letter or four-letter language code (e.g. \&quot;de\&quot;, \&quot;en-US\&quot;, etc.).
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-supported-cultures/">REST API Reference for GetSupportedCultures Operation</seealso>
        /// <returns>Task of STRINGArrayWrapper</returns>
        public async System.Threading.Tasks.Task<STRINGArrayWrapper> GetSupportedCulturesAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<STRINGArrayWrapper> localVarResponse = await GetSupportedCulturesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get supported languages Returns a list of all the available portal languages in the format of a two-letter or four-letter language code (e.g. \&quot;de\&quot;, \&quot;en-US\&quot;, etc.).
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-supported-cultures/">REST API Reference for GetSupportedCultures Operation</seealso>
        /// <returns>Task of ApiResponse (STRINGArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<STRINGArrayWrapper>> GetSupportedCulturesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<STRINGArrayWrapper>("/api/2.0/settings/cultures", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetSupportedCultures", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the user invitation settings Returns the portal user invitation settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-user-invitation-settings/">REST API Reference for GetTenantUserInvitationSettings Operation</seealso>
        /// <returns>TenantUserInvitationSettingsWrapper</returns>
        public TenantUserInvitationSettingsWrapper GetTenantUserInvitationSettings()
        {
            var localVarResponse = GetTenantUserInvitationSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the user invitation settings Returns the portal user invitation settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-user-invitation-settings/">REST API Reference for GetTenantUserInvitationSettings Operation</seealso>
        /// <returns>ApiResponse of TenantUserInvitationSettingsWrapper</returns>
        public ApiResponse<TenantUserInvitationSettingsWrapper> GetTenantUserInvitationSettingsWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = this.Client.Get<TenantUserInvitationSettingsWrapper>("/api/2.0/settings/invitationsettings", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetTenantUserInvitationSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the user invitation settings Returns the portal user invitation settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-user-invitation-settings/">REST API Reference for GetTenantUserInvitationSettings Operation</seealso>
        /// <returns>Task of TenantUserInvitationSettingsWrapper</returns>
        public async System.Threading.Tasks.Task<TenantUserInvitationSettingsWrapper> GetTenantUserInvitationSettingsAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<TenantUserInvitationSettingsWrapper> localVarResponse = await GetTenantUserInvitationSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the user invitation settings Returns the portal user invitation settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-user-invitation-settings/">REST API Reference for GetTenantUserInvitationSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantUserInvitationSettingsWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TenantUserInvitationSettingsWrapper>> GetTenantUserInvitationSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<TenantUserInvitationSettingsWrapper>("/api/2.0/settings/invitationsettings", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetTenantUserInvitationSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get time zones Returns a list of all the available portal time zones.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-time-zones/">REST API Reference for GetTimeZones Operation</seealso>
        /// <returns>TimezonesRequestsArrayWrapper</returns>
        public TimezonesRequestsArrayWrapper GetTimeZones()
        {
            var localVarResponse = GetTimeZonesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get time zones Returns a list of all the available portal time zones.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-time-zones/">REST API Reference for GetTimeZones Operation</seealso>
        /// <returns>ApiResponse of TimezonesRequestsArrayWrapper</returns>
        public ApiResponse<TimezonesRequestsArrayWrapper> GetTimeZonesWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<TimezonesRequestsArrayWrapper>("/api/2.0/settings/timezones", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetTimeZones", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get time zones Returns a list of all the available portal time zones.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-time-zones/">REST API Reference for GetTimeZones Operation</seealso>
        /// <returns>Task of TimezonesRequestsArrayWrapper</returns>
        public async System.Threading.Tasks.Task<TimezonesRequestsArrayWrapper> GetTimeZonesAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<TimezonesRequestsArrayWrapper> localVarResponse = await GetTimeZonesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get time zones Returns a list of all the available portal time zones.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-time-zones/">REST API Reference for GetTimeZones Operation</seealso>
        /// <returns>Task of ApiResponse (TimezonesRequestsArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimezonesRequestsArrayWrapper>> GetTimeZonesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<TimezonesRequestsArrayWrapper>("/api/2.0/settings/timezones", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetTimeZones", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save the DNS settings Saves the DNS settings specified in the request to the current portal.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-dns-settings/">REST API Reference for SaveDnsSettings Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper SaveDnsSettings(DnsSettingsRequestsDto? dnsSettingsRequestsDto = default)
        {
            var localVarResponse = SaveDnsSettingsWithHttpInfo(dnsSettingsRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save the DNS settings Saves the DNS settings specified in the request to the current portal.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-dns-settings/">REST API Reference for SaveDnsSettings Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> SaveDnsSettingsWithHttpInfo(DnsSettingsRequestsDto? dnsSettingsRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (dnsSettingsRequestsDto != null) localVarRequestOptions.Data = dnsSettingsRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<StringWrapper>("/api/2.0/settings/dns", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SaveDnsSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save the DNS settings Saves the DNS settings specified in the request to the current portal.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-dns-settings/">REST API Reference for SaveDnsSettings Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async System.Threading.Tasks.Task<StringWrapper> SaveDnsSettingsAsync(DnsSettingsRequestsDto? dnsSettingsRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<StringWrapper> localVarResponse = await SaveDnsSettingsWithHttpInfoAsync(dnsSettingsRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save the DNS settings Saves the DNS settings specified in the request to the current portal.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-dns-settings/">REST API Reference for SaveDnsSettings Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StringWrapper>> SaveDnsSettingsWithHttpInfoAsync(DnsSettingsRequestsDto? dnsSettingsRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (dnsSettingsRequestsDto != null) localVarRequestOptions.Data = dnsSettingsRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<StringWrapper>("/api/2.0/settings/dns", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SaveDnsSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save the mail domain settings Saves the mail domain settings specified in the request to the portal.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mail-domain-settings/">REST API Reference for SaveMailDomainSettings Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper SaveMailDomainSettings(MailDomainSettingsRequestsDto? mailDomainSettingsRequestsDto = default)
        {
            var localVarResponse = SaveMailDomainSettingsWithHttpInfo(mailDomainSettingsRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save the mail domain settings Saves the mail domain settings specified in the request to the portal.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mail-domain-settings/">REST API Reference for SaveMailDomainSettings Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> SaveMailDomainSettingsWithHttpInfo(MailDomainSettingsRequestsDto? mailDomainSettingsRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (mailDomainSettingsRequestsDto != null) localVarRequestOptions.Data = mailDomainSettingsRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Post<StringWrapper>("/api/2.0/settings/maildomainsettings", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SaveMailDomainSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save the mail domain settings Saves the mail domain settings specified in the request to the portal.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mail-domain-settings/">REST API Reference for SaveMailDomainSettings Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async System.Threading.Tasks.Task<StringWrapper> SaveMailDomainSettingsAsync(MailDomainSettingsRequestsDto? mailDomainSettingsRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<StringWrapper> localVarResponse = await SaveMailDomainSettingsWithHttpInfoAsync(mailDomainSettingsRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save the mail domain settings Saves the mail domain settings specified in the request to the portal.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mail-domain-settings/">REST API Reference for SaveMailDomainSettings Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StringWrapper>> SaveMailDomainSettingsWithHttpInfoAsync(MailDomainSettingsRequestsDto? mailDomainSettingsRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (mailDomainSettingsRequestsDto != null) localVarRequestOptions.Data = mailDomainSettingsRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<StringWrapper>("/api/2.0/settings/maildomainsettings", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SaveMailDomainSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save a color theme Saves the portal color theme specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-portal-color-theme/">REST API Reference for SavePortalColorTheme Operation</seealso>
        /// <returns>CustomColorThemesSettingsWrapper</returns>
        public CustomColorThemesSettingsWrapper SavePortalColorTheme(CustomColorThemesSettingsRequestsDto? customColorThemesSettingsRequestsDto = default)
        {
            var localVarResponse = SavePortalColorThemeWithHttpInfo(customColorThemesSettingsRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save a color theme Saves the portal color theme specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-portal-color-theme/">REST API Reference for SavePortalColorTheme Operation</seealso>
        /// <returns>ApiResponse of CustomColorThemesSettingsWrapper</returns>
        public ApiResponse<CustomColorThemesSettingsWrapper> SavePortalColorThemeWithHttpInfo(CustomColorThemesSettingsRequestsDto? customColorThemesSettingsRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (customColorThemesSettingsRequestsDto != null) localVarRequestOptions.Data = customColorThemesSettingsRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<CustomColorThemesSettingsWrapper>("/api/2.0/settings/colortheme", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SavePortalColorTheme", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save a color theme Saves the portal color theme specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-portal-color-theme/">REST API Reference for SavePortalColorTheme Operation</seealso>
        /// <returns>Task of CustomColorThemesSettingsWrapper</returns>
        public async System.Threading.Tasks.Task<CustomColorThemesSettingsWrapper> SavePortalColorThemeAsync(CustomColorThemesSettingsRequestsDto? customColorThemesSettingsRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<CustomColorThemesSettingsWrapper> localVarResponse = await SavePortalColorThemeWithHttpInfoAsync(customColorThemesSettingsRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save a color theme Saves the portal color theme specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-portal-color-theme/">REST API Reference for SavePortalColorTheme Operation</seealso>
        /// <returns>Task of ApiResponse (CustomColorThemesSettingsWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CustomColorThemesSettingsWrapper>> SavePortalColorThemeWithHttpInfoAsync(CustomColorThemesSettingsRequestsDto? customColorThemesSettingsRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (customColorThemesSettingsRequestsDto != null) localVarRequestOptions.Data = customColorThemesSettingsRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<CustomColorThemesSettingsWrapper>("/api/2.0/settings/colortheme", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SavePortalColorTheme", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the email activation settings Updates the email activation settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailActivationSettings"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-email-activation-settings/">REST API Reference for UpdateEmailActivationSettings Operation</seealso>
        /// <returns>EmailActivationSettingsWrapper</returns>
        public EmailActivationSettingsWrapper UpdateEmailActivationSettings(EmailActivationSettings? emailActivationSettings = default)
        {
            var localVarResponse = UpdateEmailActivationSettingsWithHttpInfo(emailActivationSettings);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update the email activation settings Updates the email activation settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailActivationSettings"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-email-activation-settings/">REST API Reference for UpdateEmailActivationSettings Operation</seealso>
        /// <returns>ApiResponse of EmailActivationSettingsWrapper</returns>
        public ApiResponse<EmailActivationSettingsWrapper> UpdateEmailActivationSettingsWithHttpInfo(EmailActivationSettings? emailActivationSettings = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (emailActivationSettings != null) localVarRequestOptions.Data = emailActivationSettings;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<EmailActivationSettingsWrapper>("/api/2.0/settings/emailactivation", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("UpdateEmailActivationSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the email activation settings Updates the email activation settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailActivationSettings"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-email-activation-settings/">REST API Reference for UpdateEmailActivationSettings Operation</seealso>
        /// <returns>Task of EmailActivationSettingsWrapper</returns>
        public async System.Threading.Tasks.Task<EmailActivationSettingsWrapper> UpdateEmailActivationSettingsAsync(EmailActivationSettings? emailActivationSettings = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<EmailActivationSettingsWrapper> localVarResponse = await UpdateEmailActivationSettingsWithHttpInfoAsync(emailActivationSettings, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update the email activation settings Updates the email activation settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailActivationSettings"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-email-activation-settings/">REST API Reference for UpdateEmailActivationSettings Operation</seealso>
        /// <returns>Task of ApiResponse (EmailActivationSettingsWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailActivationSettingsWrapper>> UpdateEmailActivationSettingsWithHttpInfoAsync(EmailActivationSettings? emailActivationSettings = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (emailActivationSettings != null) localVarRequestOptions.Data = emailActivationSettings;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<EmailActivationSettingsWrapper>("/api/2.0/settings/emailactivation", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("UpdateEmailActivationSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update user invitation settings Updates the portal user invitation settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-settings/">REST API Reference for UpdateInvitationSettings Operation</seealso>
        /// <returns>TenantUserInvitationSettingsWrapper</returns>
        public TenantUserInvitationSettingsWrapper UpdateInvitationSettings(TenantUserInvitationSettingsRequestDto? tenantUserInvitationSettingsRequestDto = default)
        {
            var localVarResponse = UpdateInvitationSettingsWithHttpInfo(tenantUserInvitationSettingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update user invitation settings Updates the portal user invitation settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-settings/">REST API Reference for UpdateInvitationSettings Operation</seealso>
        /// <returns>ApiResponse of TenantUserInvitationSettingsWrapper</returns>
        public ApiResponse<TenantUserInvitationSettingsWrapper> UpdateInvitationSettingsWithHttpInfo(TenantUserInvitationSettingsRequestDto? tenantUserInvitationSettingsRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (tenantUserInvitationSettingsRequestDto != null) localVarRequestOptions.Data = tenantUserInvitationSettingsRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<TenantUserInvitationSettingsWrapper>("/api/2.0/settings/invitationsettings", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("UpdateInvitationSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update user invitation settings Updates the portal user invitation settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-settings/">REST API Reference for UpdateInvitationSettings Operation</seealso>
        /// <returns>Task of TenantUserInvitationSettingsWrapper</returns>
        public async System.Threading.Tasks.Task<TenantUserInvitationSettingsWrapper> UpdateInvitationSettingsAsync(TenantUserInvitationSettingsRequestDto? tenantUserInvitationSettingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<TenantUserInvitationSettingsWrapper> localVarResponse = await UpdateInvitationSettingsWithHttpInfoAsync(tenantUserInvitationSettingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update user invitation settings Updates the portal user invitation settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-settings/">REST API Reference for UpdateInvitationSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantUserInvitationSettingsWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TenantUserInvitationSettingsWrapper>> UpdateInvitationSettingsWithHttpInfoAsync(TenantUserInvitationSettingsRequestDto? tenantUserInvitationSettingsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (tenantUserInvitationSettingsRequestDto != null) localVarRequestOptions.Data = tenantUserInvitationSettingsRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<TenantUserInvitationSettingsWrapper>("/api/2.0/settings/invitationsettings", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("UpdateInvitationSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

    }
}
