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


using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Model;
namespace DocSpace.API.SDK.Api.Settings
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICommonSettingsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Close the admin helper
        /// </summary>
        /// <remarks>
        /// Closes the administrator helper notification.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/close-admin-helper/">REST API Reference for CloseAdminHelper Operation</seealso>
        /// <returns></returns>
        void CloseAdminHelper();

        /// <summary>
        /// Close the admin helper
        /// </summary>
        /// <remarks>
        /// Closes the administrator helper notification.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/close-admin-helper/">REST API Reference for CloseAdminHelper Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CloseAdminHelperWithHttpInfo();
        /// <summary>
        /// Complete the Wizard settings
        /// </summary>
        /// <remarks>
        /// Completes the Wizard settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto">The request parameters for initial configuration of the setup wizard. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/complete-wizard/">REST API Reference for CompleteWizard Operation</seealso>
        /// <returns>WizardSettingsWrapper</returns>
        WizardSettingsWrapper CompleteWizard(WizardRequestsDto? wizardRequestsDto = default);

        /// <summary>
        /// Complete the Wizard settings
        /// </summary>
        /// <remarks>
        /// Completes the Wizard settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto">The request parameters for initial configuration of the setup wizard. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/complete-wizard/">REST API Reference for CompleteWizard Operation</seealso>
        /// <returns>ApiResponse of WizardSettingsWrapper</returns>
        ApiResponse<WizardSettingsWrapper> CompleteWizardWithHttpInfo(WizardRequestsDto? wizardRequestsDto = default);
        /// <summary>
        /// Configure the deep link settings
        /// </summary>
        /// <remarks>
        /// Saves the deep link configuration settings for the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto">The request parameters for managing the deep link configuration. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/configure-deep-link/">REST API Reference for ConfigureDeepLink Operation</seealso>
        /// <returns>TenantDeepLinkSettingsWrapper</returns>
        TenantDeepLinkSettingsWrapper ConfigureDeepLink(DeepLinkConfigurationRequestsDto? deepLinkConfigurationRequestsDto = default);

        /// <summary>
        /// Configure the deep link settings
        /// </summary>
        /// <remarks>
        /// Saves the deep link configuration settings for the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto">The request parameters for managing the deep link configuration. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/configure-deep-link/">REST API Reference for ConfigureDeepLink Operation</seealso>
        /// <returns>ApiResponse of TenantDeepLinkSettingsWrapper</returns>
        ApiResponse<TenantDeepLinkSettingsWrapper> ConfigureDeepLinkWithHttpInfo(DeepLinkConfigurationRequestsDto? deepLinkConfigurationRequestsDto = default);
        /// <summary>
        /// Delete a color theme
        /// </summary>
        /// <remarks>
        /// Deletes the portal color theme with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-deep-link-settings/">REST API Reference for GetDeepLinkSettings Operation</seealso>
        /// <returns>TenantDeepLinkSettingsWrapper</returns>
        TenantDeepLinkSettingsWrapper GetDeepLinkSettings();

        /// <summary>
        /// Get the deep link settings
        /// </summary>
        /// <remarks>
        /// Returns the deep link settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-deep-link-settings/">REST API Reference for GetDeepLinkSettings Operation</seealso>
        /// <returns>ApiResponse of TenantDeepLinkSettingsWrapper</returns>
        ApiResponse<TenantDeepLinkSettingsWrapper> GetDeepLinkSettingsWithHttpInfo();
        /// <summary>
        /// Get the payment settings
        /// </summary>
        /// <remarks>
        /// Returns the portal payment settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-settings/">REST API Reference for GetPaymentSettings Operation</seealso>
        /// <returns>PaymentSettingsWrapper</returns>
        PaymentSettingsWrapper GetPaymentSettings();

        /// <summary>
        /// Get the payment settings
        /// </summary>
        /// <remarks>
        /// Returns the portal payment settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-settings/">REST API Reference for GetPaymentSettings Operation</seealso>
        /// <returns>ApiResponse of PaymentSettingsWrapper</returns>
        ApiResponse<PaymentSettingsWrapper> GetPaymentSettingsWithHttpInfo();
        /// <summary>
        /// Get a color theme
        /// </summary>
        /// <remarks>
        /// Returns the portal color theme.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-color-theme/">REST API Reference for GetPortalColorTheme Operation</seealso>
        /// <returns>CustomColorThemesSettingsWrapper</returns>
        CustomColorThemesSettingsWrapper GetPortalColorTheme();

        /// <summary>
        /// Get a color theme
        /// </summary>
        /// <remarks>
        /// Returns the portal color theme.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-color-theme/">REST API Reference for GetPortalColorTheme Operation</seealso>
        /// <returns>ApiResponse of CustomColorThemesSettingsWrapper</returns>
        ApiResponse<CustomColorThemesSettingsWrapper> GetPortalColorThemeWithHttpInfo();
        /// <summary>
        /// Get hostname
        /// </summary>
        /// <remarks>
        /// Returns the portal hostname.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-hostname/">REST API Reference for GetPortalHostname Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        ObjectWrapper GetPortalHostname();

        /// <summary>
        /// Get hostname
        /// </summary>
        /// <remarks>
        /// Returns the portal hostname.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-hostname/">REST API Reference for GetPortalHostname Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        ApiResponse<ObjectWrapper> GetPortalHostnameWithHttpInfo();
        /// <summary>
        /// Get a portal logo
        /// </summary>
        /// <remarks>
        /// Returns the portal logo image URL.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-logo/">REST API Reference for GetPortalLogo Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper GetPortalLogo();

        /// <summary>
        /// Get a portal logo
        /// </summary>
        /// <remarks>
        /// Returns the portal logo image URL.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-logo/">REST API Reference for GetPortalLogo Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> GetPortalLogoWithHttpInfo();
        /// <summary>
        /// Get the portal settings
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal settings with the current values for each parameter.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-socket-settings/">REST API Reference for GetSocketSettings Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        ObjectWrapper GetSocketSettings();

        /// <summary>
        /// Get the socket settings
        /// </summary>
        /// <remarks>
        /// Returns the socket settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-socket-settings/">REST API Reference for GetSocketSettings Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        ApiResponse<ObjectWrapper> GetSocketSettingsWithHttpInfo();
        /// <summary>
        /// Get supported languages
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal languages in the format of a two-letter or four-letter language code (e.g. \&quot;de\&quot;, \&quot;en-US\&quot;, etc.).
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-supported-cultures/">REST API Reference for GetSupportedCultures Operation</seealso>
        /// <returns>STRINGArrayWrapper</returns>
        STRINGArrayWrapper GetSupportedCultures();

        /// <summary>
        /// Get supported languages
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal languages in the format of a two-letter or four-letter language code (e.g. \&quot;de\&quot;, \&quot;en-US\&quot;, etc.).
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-supported-cultures/">REST API Reference for GetSupportedCultures Operation</seealso>
        /// <returns>ApiResponse of STRINGArrayWrapper</returns>
        ApiResponse<STRINGArrayWrapper> GetSupportedCulturesWithHttpInfo();
        /// <summary>
        /// Get the user invitation settings
        /// </summary>
        /// <remarks>
        /// Returns the portal user invitation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-user-invitation-settings/">REST API Reference for GetTenantUserInvitationSettings Operation</seealso>
        /// <returns>TenantUserInvitationSettingsWrapper</returns>
        TenantUserInvitationSettingsWrapper GetTenantUserInvitationSettings();

        /// <summary>
        /// Get the user invitation settings
        /// </summary>
        /// <remarks>
        /// Returns the portal user invitation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-user-invitation-settings/">REST API Reference for GetTenantUserInvitationSettings Operation</seealso>
        /// <returns>ApiResponse of TenantUserInvitationSettingsWrapper</returns>
        ApiResponse<TenantUserInvitationSettingsWrapper> GetTenantUserInvitationSettingsWithHttpInfo();
        /// <summary>
        /// Get time zones
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal time zones.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-time-zones/">REST API Reference for GetTimeZones Operation</seealso>
        /// <returns>TimezonesRequestsArrayWrapper</returns>
        TimezonesRequestsArrayWrapper GetTimeZones();

        /// <summary>
        /// Get time zones
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal time zones.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-time-zones/">REST API Reference for GetTimeZones Operation</seealso>
        /// <returns>ApiResponse of TimezonesRequestsArrayWrapper</returns>
        ApiResponse<TimezonesRequestsArrayWrapper> GetTimeZonesWithHttpInfo();
        /// <summary>
        /// Save the DNS settings
        /// </summary>
        /// <remarks>
        /// Saves the DNS settings specified in the request to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto">The request parameters for managing the DNS (Domain Name System) settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-dns-settings/">REST API Reference for SaveDnsSettings Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper SaveDnsSettings(DnsSettingsRequestsDto? dnsSettingsRequestsDto = default);

        /// <summary>
        /// Save the DNS settings
        /// </summary>
        /// <remarks>
        /// Saves the DNS settings specified in the request to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto">The request parameters for managing the DNS (Domain Name System) settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-dns-settings/">REST API Reference for SaveDnsSettings Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> SaveDnsSettingsWithHttpInfo(DnsSettingsRequestsDto? dnsSettingsRequestsDto = default);
        /// <summary>
        /// Save the mail domain settings
        /// </summary>
        /// <remarks>
        /// Saves the mail domain settings specified in the request to the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto">The request parameters for configuring trusted mail domains and visitor invitation settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mail-domain-settings/">REST API Reference for SaveMailDomainSettings Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper SaveMailDomainSettings(MailDomainSettingsRequestsDto? mailDomainSettingsRequestsDto = default);

        /// <summary>
        /// Save the mail domain settings
        /// </summary>
        /// <remarks>
        /// Saves the mail domain settings specified in the request to the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto">The request parameters for configuring trusted mail domains and visitor invitation settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mail-domain-settings/">REST API Reference for SaveMailDomainSettings Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> SaveMailDomainSettingsWithHttpInfo(MailDomainSettingsRequestsDto? mailDomainSettingsRequestsDto = default);
        /// <summary>
        /// Save a color theme
        /// </summary>
        /// <remarks>
        /// Saves the portal color theme specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto">The request parameters for managing the portal theme settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-portal-color-theme/">REST API Reference for SavePortalColorTheme Operation</seealso>
        /// <returns>CustomColorThemesSettingsWrapper</returns>
        CustomColorThemesSettingsWrapper SavePortalColorTheme(CustomColorThemesSettingsRequestsDto? customColorThemesSettingsRequestsDto = default);

        /// <summary>
        /// Save a color theme
        /// </summary>
        /// <remarks>
        /// Saves the portal color theme specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto">The request parameters for managing the portal theme settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-portal-color-theme/">REST API Reference for SavePortalColorTheme Operation</seealso>
        /// <returns>ApiResponse of CustomColorThemesSettingsWrapper</returns>
        ApiResponse<CustomColorThemesSettingsWrapper> SavePortalColorThemeWithHttpInfo(CustomColorThemesSettingsRequestsDto? customColorThemesSettingsRequestsDto = default);
        /// <summary>
        /// Update the email activation settings
        /// </summary>
        /// <remarks>
        /// Updates the email activation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailActivationSettings">The email activation settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-email-activation-settings/">REST API Reference for UpdateEmailActivationSettings Operation</seealso>
        /// <returns>EmailActivationSettingsWrapper</returns>
        EmailActivationSettingsWrapper UpdateEmailActivationSettings(EmailActivationSettings? emailActivationSettings = default);

        /// <summary>
        /// Update the email activation settings
        /// </summary>
        /// <remarks>
        /// Updates the email activation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailActivationSettings">The email activation settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-email-activation-settings/">REST API Reference for UpdateEmailActivationSettings Operation</seealso>
        /// <returns>ApiResponse of EmailActivationSettingsWrapper</returns>
        ApiResponse<EmailActivationSettingsWrapper> UpdateEmailActivationSettingsWithHttpInfo(EmailActivationSettings? emailActivationSettings = default);
        /// <summary>
        /// Update user invitation settings
        /// </summary>
        /// <remarks>
        /// Updates the portal user invitation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto">User invitation settings (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-settings/">REST API Reference for UpdateInvitationSettings Operation</seealso>
        /// <returns>TenantUserInvitationSettingsWrapper</returns>
        TenantUserInvitationSettingsWrapper UpdateInvitationSettings(TenantUserInvitationSettingsRequestDto? tenantUserInvitationSettingsRequestDto = default);

        /// <summary>
        /// Update user invitation settings
        /// </summary>
        /// <remarks>
        /// Updates the portal user invitation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto">User invitation settings (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-settings/">REST API Reference for UpdateInvitationSettings Operation</seealso>
        /// <returns>ApiResponse of TenantUserInvitationSettingsWrapper</returns>
        ApiResponse<TenantUserInvitationSettingsWrapper> UpdateInvitationSettingsWithHttpInfo(TenantUserInvitationSettingsRequestDto? tenantUserInvitationSettingsRequestDto = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICommonSettingsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Close the admin helper
        /// </summary>
        /// <remarks>
        /// Closes the administrator helper notification.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/close-admin-helper/">REST API Reference for CloseAdminHelper Operation</seealso>
        /// <returns>Task of void</returns>
        Task CloseAdminHelperAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Close the admin helper
        /// </summary>
        /// <remarks>
        /// Closes the administrator helper notification.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/close-admin-helper/">REST API Reference for CloseAdminHelper Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> CloseAdminHelperWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Complete the Wizard settings
        /// </summary>
        /// <remarks>
        /// Completes the Wizard settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto">The request parameters for initial configuration of the setup wizard. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/complete-wizard/">REST API Reference for CompleteWizard Operation</seealso>
        /// <returns>Task of WizardSettingsWrapper</returns>
        Task<WizardSettingsWrapper> CompleteWizardAsync(WizardRequestsDto? wizardRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Complete the Wizard settings
        /// </summary>
        /// <remarks>
        /// Completes the Wizard settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto">The request parameters for initial configuration of the setup wizard. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/complete-wizard/">REST API Reference for CompleteWizard Operation</seealso>
        /// <returns>Task of ApiResponse (WizardSettingsWrapper)</returns>
        Task<ApiResponse<WizardSettingsWrapper>> CompleteWizardWithHttpInfoAsync(WizardRequestsDto? wizardRequestsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Configure the deep link settings
        /// </summary>
        /// <remarks>
        /// Saves the deep link configuration settings for the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto">The request parameters for managing the deep link configuration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/configure-deep-link/">REST API Reference for ConfigureDeepLink Operation</seealso>
        /// <returns>Task of TenantDeepLinkSettingsWrapper</returns>
        Task<TenantDeepLinkSettingsWrapper> ConfigureDeepLinkAsync(DeepLinkConfigurationRequestsDto? deepLinkConfigurationRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Configure the deep link settings
        /// </summary>
        /// <remarks>
        /// Saves the deep link configuration settings for the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto">The request parameters for managing the deep link configuration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/configure-deep-link/">REST API Reference for ConfigureDeepLink Operation</seealso>
        /// <returns>Task of ApiResponse (TenantDeepLinkSettingsWrapper)</returns>
        Task<ApiResponse<TenantDeepLinkSettingsWrapper>> ConfigureDeepLinkWithHttpInfoAsync(DeepLinkConfigurationRequestsDto? deepLinkConfigurationRequestsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a color theme
        /// </summary>
        /// <remarks>
        /// Deletes the portal color theme with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the portal theme to delete. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-portal-color-theme/">REST API Reference for DeletePortalColorTheme Operation</seealso>
        /// <returns>Task of CustomColorThemesSettingsWrapper</returns>
        Task<CustomColorThemesSettingsWrapper> DeletePortalColorThemeAsync(int? id = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a color theme
        /// </summary>
        /// <remarks>
        /// Deletes the portal color theme with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the portal theme to delete. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-portal-color-theme/">REST API Reference for DeletePortalColorTheme Operation</seealso>
        /// <returns>Task of ApiResponse (CustomColorThemesSettingsWrapper)</returns>
        Task<ApiResponse<CustomColorThemesSettingsWrapper>> DeletePortalColorThemeWithHttpInfoAsync(int? id = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the deep link settings
        /// </summary>
        /// <remarks>
        /// Returns the deep link settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-deep-link-settings/">REST API Reference for GetDeepLinkSettings Operation</seealso>
        /// <returns>Task of TenantDeepLinkSettingsWrapper</returns>
        Task<TenantDeepLinkSettingsWrapper> GetDeepLinkSettingsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the deep link settings
        /// </summary>
        /// <remarks>
        /// Returns the deep link settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-deep-link-settings/">REST API Reference for GetDeepLinkSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantDeepLinkSettingsWrapper)</returns>
        Task<ApiResponse<TenantDeepLinkSettingsWrapper>> GetDeepLinkSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the payment settings
        /// </summary>
        /// <remarks>
        /// Returns the portal payment settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-settings/">REST API Reference for GetPaymentSettings Operation</seealso>
        /// <returns>Task of PaymentSettingsWrapper</returns>
        Task<PaymentSettingsWrapper> GetPaymentSettingsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the payment settings
        /// </summary>
        /// <remarks>
        /// Returns the portal payment settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-settings/">REST API Reference for GetPaymentSettings Operation</seealso>
        /// <returns>Task of ApiResponse (PaymentSettingsWrapper)</returns>
        Task<ApiResponse<PaymentSettingsWrapper>> GetPaymentSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a color theme
        /// </summary>
        /// <remarks>
        /// Returns the portal color theme.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-color-theme/">REST API Reference for GetPortalColorTheme Operation</seealso>
        /// <returns>Task of CustomColorThemesSettingsWrapper</returns>
        Task<CustomColorThemesSettingsWrapper> GetPortalColorThemeAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a color theme
        /// </summary>
        /// <remarks>
        /// Returns the portal color theme.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-color-theme/">REST API Reference for GetPortalColorTheme Operation</seealso>
        /// <returns>Task of ApiResponse (CustomColorThemesSettingsWrapper)</returns>
        Task<ApiResponse<CustomColorThemesSettingsWrapper>> GetPortalColorThemeWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get hostname
        /// </summary>
        /// <remarks>
        /// Returns the portal hostname.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-hostname/">REST API Reference for GetPortalHostname Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        Task<ObjectWrapper> GetPortalHostnameAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get hostname
        /// </summary>
        /// <remarks>
        /// Returns the portal hostname.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-hostname/">REST API Reference for GetPortalHostname Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        Task<ApiResponse<ObjectWrapper>> GetPortalHostnameWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a portal logo
        /// </summary>
        /// <remarks>
        /// Returns the portal logo image URL.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-logo/">REST API Reference for GetPortalLogo Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> GetPortalLogoAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a portal logo
        /// </summary>
        /// <remarks>
        /// Returns the portal logo image URL.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-logo/">REST API Reference for GetPortalLogo Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> GetPortalLogoWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the portal settings
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal settings with the current values for each parameter.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withpassword">Specifies whether to include the password hashing configuration in the response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-settings/">REST API Reference for GetPortalSettings Operation</seealso>
        /// <returns>Task of SettingsWrapper</returns>
        Task<SettingsWrapper> GetPortalSettingsAsync(bool? withpassword = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the portal settings
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal settings with the current values for each parameter.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withpassword">Specifies whether to include the password hashing configuration in the response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-settings/">REST API Reference for GetPortalSettings Operation</seealso>
        /// <returns>Task of ApiResponse (SettingsWrapper)</returns>
        Task<ApiResponse<SettingsWrapper>> GetPortalSettingsWithHttpInfoAsync(bool? withpassword = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the socket settings
        /// </summary>
        /// <remarks>
        /// Returns the socket settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-socket-settings/">REST API Reference for GetSocketSettings Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        Task<ObjectWrapper> GetSocketSettingsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the socket settings
        /// </summary>
        /// <remarks>
        /// Returns the socket settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-socket-settings/">REST API Reference for GetSocketSettings Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        Task<ApiResponse<ObjectWrapper>> GetSocketSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get supported languages
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal languages in the format of a two-letter or four-letter language code (e.g. \&quot;de\&quot;, \&quot;en-US\&quot;, etc.).
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-supported-cultures/">REST API Reference for GetSupportedCultures Operation</seealso>
        /// <returns>Task of STRINGArrayWrapper</returns>
        Task<STRINGArrayWrapper> GetSupportedCulturesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get supported languages
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal languages in the format of a two-letter or four-letter language code (e.g. \&quot;de\&quot;, \&quot;en-US\&quot;, etc.).
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-supported-cultures/">REST API Reference for GetSupportedCultures Operation</seealso>
        /// <returns>Task of ApiResponse (STRINGArrayWrapper)</returns>
        Task<ApiResponse<STRINGArrayWrapper>> GetSupportedCulturesWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the user invitation settings
        /// </summary>
        /// <remarks>
        /// Returns the portal user invitation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-user-invitation-settings/">REST API Reference for GetTenantUserInvitationSettings Operation</seealso>
        /// <returns>Task of TenantUserInvitationSettingsWrapper</returns>
        Task<TenantUserInvitationSettingsWrapper> GetTenantUserInvitationSettingsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the user invitation settings
        /// </summary>
        /// <remarks>
        /// Returns the portal user invitation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-user-invitation-settings/">REST API Reference for GetTenantUserInvitationSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantUserInvitationSettingsWrapper)</returns>
        Task<ApiResponse<TenantUserInvitationSettingsWrapper>> GetTenantUserInvitationSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get time zones
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal time zones.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-time-zones/">REST API Reference for GetTimeZones Operation</seealso>
        /// <returns>Task of TimezonesRequestsArrayWrapper</returns>
        Task<TimezonesRequestsArrayWrapper> GetTimeZonesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get time zones
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal time zones.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-time-zones/">REST API Reference for GetTimeZones Operation</seealso>
        /// <returns>Task of ApiResponse (TimezonesRequestsArrayWrapper)</returns>
        Task<ApiResponse<TimezonesRequestsArrayWrapper>> GetTimeZonesWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Save the DNS settings
        /// </summary>
        /// <remarks>
        /// Saves the DNS settings specified in the request to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto">The request parameters for managing the DNS (Domain Name System) settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-dns-settings/">REST API Reference for SaveDnsSettings Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> SaveDnsSettingsAsync(DnsSettingsRequestsDto? dnsSettingsRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Save the DNS settings
        /// </summary>
        /// <remarks>
        /// Saves the DNS settings specified in the request to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto">The request parameters for managing the DNS (Domain Name System) settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-dns-settings/">REST API Reference for SaveDnsSettings Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> SaveDnsSettingsWithHttpInfoAsync(DnsSettingsRequestsDto? dnsSettingsRequestsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Save the mail domain settings
        /// </summary>
        /// <remarks>
        /// Saves the mail domain settings specified in the request to the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto">The request parameters for configuring trusted mail domains and visitor invitation settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mail-domain-settings/">REST API Reference for SaveMailDomainSettings Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> SaveMailDomainSettingsAsync(MailDomainSettingsRequestsDto? mailDomainSettingsRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Save the mail domain settings
        /// </summary>
        /// <remarks>
        /// Saves the mail domain settings specified in the request to the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto">The request parameters for configuring trusted mail domains and visitor invitation settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mail-domain-settings/">REST API Reference for SaveMailDomainSettings Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> SaveMailDomainSettingsWithHttpInfoAsync(MailDomainSettingsRequestsDto? mailDomainSettingsRequestsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Save a color theme
        /// </summary>
        /// <remarks>
        /// Saves the portal color theme specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto">The request parameters for managing the portal theme settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-portal-color-theme/">REST API Reference for SavePortalColorTheme Operation</seealso>
        /// <returns>Task of CustomColorThemesSettingsWrapper</returns>
        Task<CustomColorThemesSettingsWrapper> SavePortalColorThemeAsync(CustomColorThemesSettingsRequestsDto? customColorThemesSettingsRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Save a color theme
        /// </summary>
        /// <remarks>
        /// Saves the portal color theme specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto">The request parameters for managing the portal theme settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-portal-color-theme/">REST API Reference for SavePortalColorTheme Operation</seealso>
        /// <returns>Task of ApiResponse (CustomColorThemesSettingsWrapper)</returns>
        Task<ApiResponse<CustomColorThemesSettingsWrapper>> SavePortalColorThemeWithHttpInfoAsync(CustomColorThemesSettingsRequestsDto? customColorThemesSettingsRequestsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the email activation settings
        /// </summary>
        /// <remarks>
        /// Updates the email activation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailActivationSettings">The email activation settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-email-activation-settings/">REST API Reference for UpdateEmailActivationSettings Operation</seealso>
        /// <returns>Task of EmailActivationSettingsWrapper</returns>
        Task<EmailActivationSettingsWrapper> UpdateEmailActivationSettingsAsync(EmailActivationSettings? emailActivationSettings = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update the email activation settings
        /// </summary>
        /// <remarks>
        /// Updates the email activation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailActivationSettings">The email activation settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-email-activation-settings/">REST API Reference for UpdateEmailActivationSettings Operation</seealso>
        /// <returns>Task of ApiResponse (EmailActivationSettingsWrapper)</returns>
        Task<ApiResponse<EmailActivationSettingsWrapper>> UpdateEmailActivationSettingsWithHttpInfoAsync(EmailActivationSettings? emailActivationSettings = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update user invitation settings
        /// </summary>
        /// <remarks>
        /// Updates the portal user invitation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto">User invitation settings (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-settings/">REST API Reference for UpdateInvitationSettings Operation</seealso>
        /// <returns>Task of TenantUserInvitationSettingsWrapper</returns>
        Task<TenantUserInvitationSettingsWrapper> UpdateInvitationSettingsAsync(TenantUserInvitationSettingsRequestDto? tenantUserInvitationSettingsRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update user invitation settings
        /// </summary>
        /// <remarks>
        /// Updates the portal user invitation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto">User invitation settings (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-settings/">REST API Reference for UpdateInvitationSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantUserInvitationSettingsWrapper)</returns>
        Task<ApiResponse<TenantUserInvitationSettingsWrapper>> UpdateInvitationSettingsWithHttpInfoAsync(TenantUserInvitationSettingsRequestDto? tenantUserInvitationSettingsRequestDto = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICommonSettingsApi : ICommonSettingsApiSync, ICommonSettingsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CommonSettingsApi : IDisposable, ICommonSettingsApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonSettingsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public CommonSettingsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonSettingsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public CommonSettingsApi(string basePath)
        {
            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            ApiClient = new ApiClient(Configuration.BasePath);
            Client =  ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonSettingsApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public CommonSettingsApi(Configuration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);

            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            ApiClient = new ApiClient(Configuration.BasePath);
            Client = ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonSettingsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public CommonSettingsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonSettingsApi"/> class.
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
        public CommonSettingsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(client);

            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            ApiClient = new ApiClient(client, Configuration.BasePath, handler);
            Client =  ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonSettingsApi"/> class using a Configuration object.
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
        public CommonSettingsApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            ArgumentNullException.ThrowIfNull(client);

            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            ApiClient = new ApiClient(client, Configuration.BasePath, handler);
            Client = ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonSettingsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public CommonSettingsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(client);
            ArgumentNullException.ThrowIfNull(asyncClient);
            ArgumentNullException.ThrowIfNull(configuration);

            Client = client;
            AsynchronousClient = asyncClient;
            Configuration = configuration;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            ApiClient.Dispose();
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
            return Configuration.BasePath;
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
        /// Close the admin helper
        /// </summary>
        /// <remarks>
        /// Closes the administrator helper notification.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/close-admin-helper/">REST API Reference for CloseAdminHelper Operation</seealso>
        /// <returns></returns>
        public void CloseAdminHelper()
        {
            CloseAdminHelperWithHttpInfo();
        }

        /// <summary>
        /// Close the admin helper
        /// </summary>
        /// <remarks>
        /// Closes the administrator helper notification.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<Object>("/api/2.0/settings/closeadminhelper", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CloseAdminHelper", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Close the admin helper
        /// </summary>
        /// <remarks>
        /// Closes the administrator helper notification.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/close-admin-helper/">REST API Reference for CloseAdminHelper Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task CloseAdminHelperAsync(CancellationToken cancellationToken = default)
        {
            await CloseAdminHelperWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Close the admin helper
        /// </summary>
        /// <remarks>
        /// Closes the administrator helper notification.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/close-admin-helper/">REST API Reference for CloseAdminHelper Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> CloseAdminHelperWithHttpInfoAsync(CancellationToken cancellationToken = default)
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
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<Object>("/api/2.0/settings/closeadminhelper", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CloseAdminHelper", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Complete the Wizard settings
        /// </summary>
        /// <remarks>
        /// Completes the Wizard settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto">The request parameters for initial configuration of the setup wizard. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/complete-wizard/">REST API Reference for CompleteWizard Operation</seealso>
        /// <returns>WizardSettingsWrapper</returns>
        public WizardSettingsWrapper CompleteWizard(WizardRequestsDto? wizardRequestsDto = default)
        {
            var localVarResponse = CompleteWizardWithHttpInfo(wizardRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Complete the Wizard settings
        /// </summary>
        /// <remarks>
        /// Completes the Wizard settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto">The request parameters for initial configuration of the setup wizard. (optional)</param>
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
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<WizardSettingsWrapper>("/api/2.0/settings/wizard/complete", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CompleteWizard", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Complete the Wizard settings
        /// </summary>
        /// <remarks>
        /// Completes the Wizard settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto">The request parameters for initial configuration of the setup wizard. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/complete-wizard/">REST API Reference for CompleteWizard Operation</seealso>
        /// <returns>Task of WizardSettingsWrapper</returns>
        public async Task<WizardSettingsWrapper> CompleteWizardAsync(WizardRequestsDto? wizardRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CompleteWizardWithHttpInfoAsync(wizardRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Complete the Wizard settings
        /// </summary>
        /// <remarks>
        /// Completes the Wizard settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto">The request parameters for initial configuration of the setup wizard. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/complete-wizard/">REST API Reference for CompleteWizard Operation</seealso>
        /// <returns>Task of ApiResponse (WizardSettingsWrapper)</returns>
        public async Task<ApiResponse<WizardSettingsWrapper>> CompleteWizardWithHttpInfoAsync(WizardRequestsDto? wizardRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (wizardRequestsDto != null) localVarRequestOptions.Data = wizardRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<WizardSettingsWrapper>("/api/2.0/settings/wizard/complete", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CompleteWizard", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Configure the deep link settings
        /// </summary>
        /// <remarks>
        /// Saves the deep link configuration settings for the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto">The request parameters for managing the deep link configuration. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/configure-deep-link/">REST API Reference for ConfigureDeepLink Operation</seealso>
        /// <returns>TenantDeepLinkSettingsWrapper</returns>
        public TenantDeepLinkSettingsWrapper ConfigureDeepLink(DeepLinkConfigurationRequestsDto? deepLinkConfigurationRequestsDto = default)
        {
            var localVarResponse = ConfigureDeepLinkWithHttpInfo(deepLinkConfigurationRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Configure the deep link settings
        /// </summary>
        /// <remarks>
        /// Saves the deep link configuration settings for the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto">The request parameters for managing the deep link configuration. (optional)</param>
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
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Post<TenantDeepLinkSettingsWrapper>("/api/2.0/settings/deeplink", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ConfigureDeepLink", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Configure the deep link settings
        /// </summary>
        /// <remarks>
        /// Saves the deep link configuration settings for the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto">The request parameters for managing the deep link configuration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/configure-deep-link/">REST API Reference for ConfigureDeepLink Operation</seealso>
        /// <returns>Task of TenantDeepLinkSettingsWrapper</returns>
        public async Task<TenantDeepLinkSettingsWrapper> ConfigureDeepLinkAsync(DeepLinkConfigurationRequestsDto? deepLinkConfigurationRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ConfigureDeepLinkWithHttpInfoAsync(deepLinkConfigurationRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Configure the deep link settings
        /// </summary>
        /// <remarks>
        /// Saves the deep link configuration settings for the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto">The request parameters for managing the deep link configuration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/configure-deep-link/">REST API Reference for ConfigureDeepLink Operation</seealso>
        /// <returns>Task of ApiResponse (TenantDeepLinkSettingsWrapper)</returns>
        public async Task<ApiResponse<TenantDeepLinkSettingsWrapper>> ConfigureDeepLinkWithHttpInfoAsync(DeepLinkConfigurationRequestsDto? deepLinkConfigurationRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (deepLinkConfigurationRequestsDto != null) localVarRequestOptions.Data = deepLinkConfigurationRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<TenantDeepLinkSettingsWrapper>("/api/2.0/settings/deeplink", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ConfigureDeepLink", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a color theme
        /// </summary>
        /// <remarks>
        /// Deletes the portal color theme with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the portal theme to delete. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-portal-color-theme/">REST API Reference for DeletePortalColorTheme Operation</seealso>
        /// <returns>CustomColorThemesSettingsWrapper</returns>
        public CustomColorThemesSettingsWrapper DeletePortalColorTheme(int? id = default)
        {
            var localVarResponse = DeletePortalColorThemeWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a color theme
        /// </summary>
        /// <remarks>
        /// Deletes the portal color theme with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Delete<CustomColorThemesSettingsWrapper>("/api/2.0/settings/colortheme", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeletePortalColorTheme", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a color theme
        /// </summary>
        /// <remarks>
        /// Deletes the portal color theme with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the portal theme to delete. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-portal-color-theme/">REST API Reference for DeletePortalColorTheme Operation</seealso>
        /// <returns>Task of CustomColorThemesSettingsWrapper</returns>
        public async Task<CustomColorThemesSettingsWrapper> DeletePortalColorThemeAsync(int? id = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeletePortalColorThemeWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a color theme
        /// </summary>
        /// <remarks>
        /// Deletes the portal color theme with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the portal theme to delete. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-portal-color-theme/">REST API Reference for DeletePortalColorTheme Operation</seealso>
        /// <returns>Task of ApiResponse (CustomColorThemesSettingsWrapper)</returns>
        public async Task<ApiResponse<CustomColorThemesSettingsWrapper>> DeletePortalColorThemeWithHttpInfoAsync(int? id = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


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
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<CustomColorThemesSettingsWrapper>("/api/2.0/settings/colortheme", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeletePortalColorTheme", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the deep link settings
        /// </summary>
        /// <remarks>
        /// Returns the deep link settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-deep-link-settings/">REST API Reference for GetDeepLinkSettings Operation</seealso>
        /// <returns>TenantDeepLinkSettingsWrapper</returns>
        public TenantDeepLinkSettingsWrapper GetDeepLinkSettings()
        {
            var localVarResponse = GetDeepLinkSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the deep link settings
        /// </summary>
        /// <remarks>
        /// Returns the deep link settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<TenantDeepLinkSettingsWrapper>("/api/2.0/settings/deeplink", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetDeepLinkSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the deep link settings
        /// </summary>
        /// <remarks>
        /// Returns the deep link settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-deep-link-settings/">REST API Reference for GetDeepLinkSettings Operation</seealso>
        /// <returns>Task of TenantDeepLinkSettingsWrapper</returns>
        public async Task<TenantDeepLinkSettingsWrapper> GetDeepLinkSettingsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetDeepLinkSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the deep link settings
        /// </summary>
        /// <remarks>
        /// Returns the deep link settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-deep-link-settings/">REST API Reference for GetDeepLinkSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantDeepLinkSettingsWrapper)</returns>
        public async Task<ApiResponse<TenantDeepLinkSettingsWrapper>> GetDeepLinkSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<TenantDeepLinkSettingsWrapper>("/api/2.0/settings/deeplink", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetDeepLinkSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the payment settings
        /// </summary>
        /// <remarks>
        /// Returns the portal payment settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-settings/">REST API Reference for GetPaymentSettings Operation</seealso>
        /// <returns>PaymentSettingsWrapper</returns>
        public PaymentSettingsWrapper GetPaymentSettings()
        {
            var localVarResponse = GetPaymentSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the payment settings
        /// </summary>
        /// <remarks>
        /// Returns the portal payment settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<PaymentSettingsWrapper>("/api/2.0/settings/payment", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPaymentSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the payment settings
        /// </summary>
        /// <remarks>
        /// Returns the portal payment settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-settings/">REST API Reference for GetPaymentSettings Operation</seealso>
        /// <returns>Task of PaymentSettingsWrapper</returns>
        public async Task<PaymentSettingsWrapper> GetPaymentSettingsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetPaymentSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the payment settings
        /// </summary>
        /// <remarks>
        /// Returns the portal payment settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-settings/">REST API Reference for GetPaymentSettings Operation</seealso>
        /// <returns>Task of ApiResponse (PaymentSettingsWrapper)</returns>
        public async Task<ApiResponse<PaymentSettingsWrapper>> GetPaymentSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<PaymentSettingsWrapper>("/api/2.0/settings/payment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPaymentSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a color theme
        /// </summary>
        /// <remarks>
        /// Returns the portal color theme.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-color-theme/">REST API Reference for GetPortalColorTheme Operation</seealso>
        /// <returns>CustomColorThemesSettingsWrapper</returns>
        public CustomColorThemesSettingsWrapper GetPortalColorTheme()
        {
            var localVarResponse = GetPortalColorThemeWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a color theme
        /// </summary>
        /// <remarks>
        /// Returns the portal color theme.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
            var localVarResponse = Client.Get<CustomColorThemesSettingsWrapper>("/api/2.0/settings/colortheme", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPortalColorTheme", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a color theme
        /// </summary>
        /// <remarks>
        /// Returns the portal color theme.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-color-theme/">REST API Reference for GetPortalColorTheme Operation</seealso>
        /// <returns>Task of CustomColorThemesSettingsWrapper</returns>
        public async Task<CustomColorThemesSettingsWrapper> GetPortalColorThemeAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetPortalColorThemeWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a color theme
        /// </summary>
        /// <remarks>
        /// Returns the portal color theme.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-color-theme/">REST API Reference for GetPortalColorTheme Operation</seealso>
        /// <returns>Task of ApiResponse (CustomColorThemesSettingsWrapper)</returns>
        public async Task<ApiResponse<CustomColorThemesSettingsWrapper>> GetPortalColorThemeWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<CustomColorThemesSettingsWrapper>("/api/2.0/settings/colortheme", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPortalColorTheme", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get hostname
        /// </summary>
        /// <remarks>
        /// Returns the portal hostname.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-hostname/">REST API Reference for GetPortalHostname Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        public ObjectWrapper GetPortalHostname()
        {
            var localVarResponse = GetPortalHostnameWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get hostname
        /// </summary>
        /// <remarks>
        /// Returns the portal hostname.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<ObjectWrapper>("/api/2.0/settings/machine", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPortalHostname", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get hostname
        /// </summary>
        /// <remarks>
        /// Returns the portal hostname.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-hostname/">REST API Reference for GetPortalHostname Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        public async Task<ObjectWrapper> GetPortalHostnameAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetPortalHostnameWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get hostname
        /// </summary>
        /// <remarks>
        /// Returns the portal hostname.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-hostname/">REST API Reference for GetPortalHostname Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        public async Task<ApiResponse<ObjectWrapper>> GetPortalHostnameWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<ObjectWrapper>("/api/2.0/settings/machine", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPortalHostname", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a portal logo
        /// </summary>
        /// <remarks>
        /// Returns the portal logo image URL.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-logo/">REST API Reference for GetPortalLogo Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper GetPortalLogo()
        {
            var localVarResponse = GetPortalLogoWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a portal logo
        /// </summary>
        /// <remarks>
        /// Returns the portal logo image URL.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<StringWrapper>("/api/2.0/settings/logo", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPortalLogo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a portal logo
        /// </summary>
        /// <remarks>
        /// Returns the portal logo image URL.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-logo/">REST API Reference for GetPortalLogo Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> GetPortalLogoAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetPortalLogoWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a portal logo
        /// </summary>
        /// <remarks>
        /// Returns the portal logo image URL.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-logo/">REST API Reference for GetPortalLogo Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async Task<ApiResponse<StringWrapper>> GetPortalLogoWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<StringWrapper>("/api/2.0/settings/logo", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPortalLogo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the portal settings
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal settings with the current values for each parameter.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withpassword">Specifies whether to include the password hashing configuration in the response. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-settings/">REST API Reference for GetPortalSettings Operation</seealso>
        /// <returns>SettingsWrapper</returns>
        public SettingsWrapper GetPortalSettings(bool? withpassword = default)
        {
            var localVarResponse = GetPortalSettingsWithHttpInfo(withpassword);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the portal settings
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal settings with the current values for each parameter.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
            var localVarResponse = Client.Get<SettingsWrapper>("/api/2.0/settings", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPortalSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the portal settings
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal settings with the current values for each parameter.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withpassword">Specifies whether to include the password hashing configuration in the response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-settings/">REST API Reference for GetPortalSettings Operation</seealso>
        /// <returns>Task of SettingsWrapper</returns>
        public async Task<SettingsWrapper> GetPortalSettingsAsync(bool? withpassword = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetPortalSettingsWithHttpInfoAsync(withpassword, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the portal settings
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal settings with the current values for each parameter.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withpassword">Specifies whether to include the password hashing configuration in the response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-settings/">REST API Reference for GetPortalSettings Operation</seealso>
        /// <returns>Task of ApiResponse (SettingsWrapper)</returns>
        public async Task<ApiResponse<SettingsWrapper>> GetPortalSettingsWithHttpInfoAsync(bool? withpassword = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (withpassword != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "withpassword", withpassword));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<SettingsWrapper>("/api/2.0/settings", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPortalSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the socket settings
        /// </summary>
        /// <remarks>
        /// Returns the socket settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-socket-settings/">REST API Reference for GetSocketSettings Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        public ObjectWrapper GetSocketSettings()
        {
            var localVarResponse = GetSocketSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the socket settings
        /// </summary>
        /// <remarks>
        /// Returns the socket settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<ObjectWrapper>("/api/2.0/settings/socket", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetSocketSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the socket settings
        /// </summary>
        /// <remarks>
        /// Returns the socket settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-socket-settings/">REST API Reference for GetSocketSettings Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        public async Task<ObjectWrapper> GetSocketSettingsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetSocketSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the socket settings
        /// </summary>
        /// <remarks>
        /// Returns the socket settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-socket-settings/">REST API Reference for GetSocketSettings Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        public async Task<ApiResponse<ObjectWrapper>> GetSocketSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<ObjectWrapper>("/api/2.0/settings/socket", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetSocketSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get supported languages
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal languages in the format of a two-letter or four-letter language code (e.g. \&quot;de\&quot;, \&quot;en-US\&quot;, etc.).
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-supported-cultures/">REST API Reference for GetSupportedCultures Operation</seealso>
        /// <returns>STRINGArrayWrapper</returns>
        public STRINGArrayWrapper GetSupportedCultures()
        {
            var localVarResponse = GetSupportedCulturesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get supported languages
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal languages in the format of a two-letter or four-letter language code (e.g. \&quot;de\&quot;, \&quot;en-US\&quot;, etc.).
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
            var localVarResponse = Client.Get<STRINGArrayWrapper>("/api/2.0/settings/cultures", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetSupportedCultures", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get supported languages
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal languages in the format of a two-letter or four-letter language code (e.g. \&quot;de\&quot;, \&quot;en-US\&quot;, etc.).
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-supported-cultures/">REST API Reference for GetSupportedCultures Operation</seealso>
        /// <returns>Task of STRINGArrayWrapper</returns>
        public async Task<STRINGArrayWrapper> GetSupportedCulturesAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetSupportedCulturesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get supported languages
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal languages in the format of a two-letter or four-letter language code (e.g. \&quot;de\&quot;, \&quot;en-US\&quot;, etc.).
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-supported-cultures/">REST API Reference for GetSupportedCultures Operation</seealso>
        /// <returns>Task of ApiResponse (STRINGArrayWrapper)</returns>
        public async Task<ApiResponse<STRINGArrayWrapper>> GetSupportedCulturesWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<STRINGArrayWrapper>("/api/2.0/settings/cultures", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetSupportedCultures", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the user invitation settings
        /// </summary>
        /// <remarks>
        /// Returns the portal user invitation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-user-invitation-settings/">REST API Reference for GetTenantUserInvitationSettings Operation</seealso>
        /// <returns>TenantUserInvitationSettingsWrapper</returns>
        public TenantUserInvitationSettingsWrapper GetTenantUserInvitationSettings()
        {
            var localVarResponse = GetTenantUserInvitationSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the user invitation settings
        /// </summary>
        /// <remarks>
        /// Returns the portal user invitation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
            var localVarResponse = Client.Get<TenantUserInvitationSettingsWrapper>("/api/2.0/settings/invitationsettings", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetTenantUserInvitationSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the user invitation settings
        /// </summary>
        /// <remarks>
        /// Returns the portal user invitation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-user-invitation-settings/">REST API Reference for GetTenantUserInvitationSettings Operation</seealso>
        /// <returns>Task of TenantUserInvitationSettingsWrapper</returns>
        public async Task<TenantUserInvitationSettingsWrapper> GetTenantUserInvitationSettingsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetTenantUserInvitationSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the user invitation settings
        /// </summary>
        /// <remarks>
        /// Returns the portal user invitation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-user-invitation-settings/">REST API Reference for GetTenantUserInvitationSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantUserInvitationSettingsWrapper)</returns>
        public async Task<ApiResponse<TenantUserInvitationSettingsWrapper>> GetTenantUserInvitationSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<TenantUserInvitationSettingsWrapper>("/api/2.0/settings/invitationsettings", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetTenantUserInvitationSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get time zones
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal time zones.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-time-zones/">REST API Reference for GetTimeZones Operation</seealso>
        /// <returns>TimezonesRequestsArrayWrapper</returns>
        public TimezonesRequestsArrayWrapper GetTimeZones()
        {
            var localVarResponse = GetTimeZonesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get time zones
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal time zones.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<TimezonesRequestsArrayWrapper>("/api/2.0/settings/timezones", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetTimeZones", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get time zones
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal time zones.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-time-zones/">REST API Reference for GetTimeZones Operation</seealso>
        /// <returns>Task of TimezonesRequestsArrayWrapper</returns>
        public async Task<TimezonesRequestsArrayWrapper> GetTimeZonesAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetTimeZonesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get time zones
        /// </summary>
        /// <remarks>
        /// Returns a list of all the available portal time zones.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-time-zones/">REST API Reference for GetTimeZones Operation</seealso>
        /// <returns>Task of ApiResponse (TimezonesRequestsArrayWrapper)</returns>
        public async Task<ApiResponse<TimezonesRequestsArrayWrapper>> GetTimeZonesWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<TimezonesRequestsArrayWrapper>("/api/2.0/settings/timezones", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetTimeZones", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save the DNS settings
        /// </summary>
        /// <remarks>
        /// Saves the DNS settings specified in the request to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto">The request parameters for managing the DNS (Domain Name System) settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-dns-settings/">REST API Reference for SaveDnsSettings Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper SaveDnsSettings(DnsSettingsRequestsDto? dnsSettingsRequestsDto = default)
        {
            var localVarResponse = SaveDnsSettingsWithHttpInfo(dnsSettingsRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save the DNS settings
        /// </summary>
        /// <remarks>
        /// Saves the DNS settings specified in the request to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto">The request parameters for managing the DNS (Domain Name System) settings. (optional)</param>
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
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<StringWrapper>("/api/2.0/settings/dns", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SaveDnsSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save the DNS settings
        /// </summary>
        /// <remarks>
        /// Saves the DNS settings specified in the request to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto">The request parameters for managing the DNS (Domain Name System) settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-dns-settings/">REST API Reference for SaveDnsSettings Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> SaveDnsSettingsAsync(DnsSettingsRequestsDto? dnsSettingsRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SaveDnsSettingsWithHttpInfoAsync(dnsSettingsRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save the DNS settings
        /// </summary>
        /// <remarks>
        /// Saves the DNS settings specified in the request to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto">The request parameters for managing the DNS (Domain Name System) settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-dns-settings/">REST API Reference for SaveDnsSettings Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async Task<ApiResponse<StringWrapper>> SaveDnsSettingsWithHttpInfoAsync(DnsSettingsRequestsDto? dnsSettingsRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (dnsSettingsRequestsDto != null) localVarRequestOptions.Data = dnsSettingsRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<StringWrapper>("/api/2.0/settings/dns", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SaveDnsSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save the mail domain settings
        /// </summary>
        /// <remarks>
        /// Saves the mail domain settings specified in the request to the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto">The request parameters for configuring trusted mail domains and visitor invitation settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mail-domain-settings/">REST API Reference for SaveMailDomainSettings Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper SaveMailDomainSettings(MailDomainSettingsRequestsDto? mailDomainSettingsRequestsDto = default)
        {
            var localVarResponse = SaveMailDomainSettingsWithHttpInfo(mailDomainSettingsRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save the mail domain settings
        /// </summary>
        /// <remarks>
        /// Saves the mail domain settings specified in the request to the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto">The request parameters for configuring trusted mail domains and visitor invitation settings. (optional)</param>
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
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Post<StringWrapper>("/api/2.0/settings/maildomainsettings", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SaveMailDomainSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save the mail domain settings
        /// </summary>
        /// <remarks>
        /// Saves the mail domain settings specified in the request to the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto">The request parameters for configuring trusted mail domains and visitor invitation settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mail-domain-settings/">REST API Reference for SaveMailDomainSettings Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> SaveMailDomainSettingsAsync(MailDomainSettingsRequestsDto? mailDomainSettingsRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SaveMailDomainSettingsWithHttpInfoAsync(mailDomainSettingsRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save the mail domain settings
        /// </summary>
        /// <remarks>
        /// Saves the mail domain settings specified in the request to the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto">The request parameters for configuring trusted mail domains and visitor invitation settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mail-domain-settings/">REST API Reference for SaveMailDomainSettings Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async Task<ApiResponse<StringWrapper>> SaveMailDomainSettingsWithHttpInfoAsync(MailDomainSettingsRequestsDto? mailDomainSettingsRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (mailDomainSettingsRequestsDto != null) localVarRequestOptions.Data = mailDomainSettingsRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<StringWrapper>("/api/2.0/settings/maildomainsettings", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SaveMailDomainSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save a color theme
        /// </summary>
        /// <remarks>
        /// Saves the portal color theme specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto">The request parameters for managing the portal theme settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-portal-color-theme/">REST API Reference for SavePortalColorTheme Operation</seealso>
        /// <returns>CustomColorThemesSettingsWrapper</returns>
        public CustomColorThemesSettingsWrapper SavePortalColorTheme(CustomColorThemesSettingsRequestsDto? customColorThemesSettingsRequestsDto = default)
        {
            var localVarResponse = SavePortalColorThemeWithHttpInfo(customColorThemesSettingsRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save a color theme
        /// </summary>
        /// <remarks>
        /// Saves the portal color theme specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto">The request parameters for managing the portal theme settings. (optional)</param>
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
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<CustomColorThemesSettingsWrapper>("/api/2.0/settings/colortheme", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SavePortalColorTheme", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save a color theme
        /// </summary>
        /// <remarks>
        /// Saves the portal color theme specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto">The request parameters for managing the portal theme settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-portal-color-theme/">REST API Reference for SavePortalColorTheme Operation</seealso>
        /// <returns>Task of CustomColorThemesSettingsWrapper</returns>
        public async Task<CustomColorThemesSettingsWrapper> SavePortalColorThemeAsync(CustomColorThemesSettingsRequestsDto? customColorThemesSettingsRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SavePortalColorThemeWithHttpInfoAsync(customColorThemesSettingsRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save a color theme
        /// </summary>
        /// <remarks>
        /// Saves the portal color theme specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto">The request parameters for managing the portal theme settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-portal-color-theme/">REST API Reference for SavePortalColorTheme Operation</seealso>
        /// <returns>Task of ApiResponse (CustomColorThemesSettingsWrapper)</returns>
        public async Task<ApiResponse<CustomColorThemesSettingsWrapper>> SavePortalColorThemeWithHttpInfoAsync(CustomColorThemesSettingsRequestsDto? customColorThemesSettingsRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (customColorThemesSettingsRequestsDto != null) localVarRequestOptions.Data = customColorThemesSettingsRequestsDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<CustomColorThemesSettingsWrapper>("/api/2.0/settings/colortheme", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SavePortalColorTheme", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the email activation settings
        /// </summary>
        /// <remarks>
        /// Updates the email activation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailActivationSettings">The email activation settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-email-activation-settings/">REST API Reference for UpdateEmailActivationSettings Operation</seealso>
        /// <returns>EmailActivationSettingsWrapper</returns>
        public EmailActivationSettingsWrapper UpdateEmailActivationSettings(EmailActivationSettings? emailActivationSettings = default)
        {
            var localVarResponse = UpdateEmailActivationSettingsWithHttpInfo(emailActivationSettings);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update the email activation settings
        /// </summary>
        /// <remarks>
        /// Updates the email activation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailActivationSettings">The email activation settings. (optional)</param>
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
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<EmailActivationSettingsWrapper>("/api/2.0/settings/emailactivation", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateEmailActivationSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the email activation settings
        /// </summary>
        /// <remarks>
        /// Updates the email activation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailActivationSettings">The email activation settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-email-activation-settings/">REST API Reference for UpdateEmailActivationSettings Operation</seealso>
        /// <returns>Task of EmailActivationSettingsWrapper</returns>
        public async Task<EmailActivationSettingsWrapper> UpdateEmailActivationSettingsAsync(EmailActivationSettings? emailActivationSettings = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateEmailActivationSettingsWithHttpInfoAsync(emailActivationSettings, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update the email activation settings
        /// </summary>
        /// <remarks>
        /// Updates the email activation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailActivationSettings">The email activation settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-email-activation-settings/">REST API Reference for UpdateEmailActivationSettings Operation</seealso>
        /// <returns>Task of ApiResponse (EmailActivationSettingsWrapper)</returns>
        public async Task<ApiResponse<EmailActivationSettingsWrapper>> UpdateEmailActivationSettingsWithHttpInfoAsync(EmailActivationSettings? emailActivationSettings = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (emailActivationSettings != null) localVarRequestOptions.Data = emailActivationSettings;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<EmailActivationSettingsWrapper>("/api/2.0/settings/emailactivation", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateEmailActivationSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update user invitation settings
        /// </summary>
        /// <remarks>
        /// Updates the portal user invitation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto">User invitation settings (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-settings/">REST API Reference for UpdateInvitationSettings Operation</seealso>
        /// <returns>TenantUserInvitationSettingsWrapper</returns>
        public TenantUserInvitationSettingsWrapper UpdateInvitationSettings(TenantUserInvitationSettingsRequestDto? tenantUserInvitationSettingsRequestDto = default)
        {
            var localVarResponse = UpdateInvitationSettingsWithHttpInfo(tenantUserInvitationSettingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update user invitation settings
        /// </summary>
        /// <remarks>
        /// Updates the portal user invitation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto">User invitation settings (optional)</param>
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
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<TenantUserInvitationSettingsWrapper>("/api/2.0/settings/invitationsettings", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateInvitationSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update user invitation settings
        /// </summary>
        /// <remarks>
        /// Updates the portal user invitation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto">User invitation settings (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-settings/">REST API Reference for UpdateInvitationSettings Operation</seealso>
        /// <returns>Task of TenantUserInvitationSettingsWrapper</returns>
        public async Task<TenantUserInvitationSettingsWrapper> UpdateInvitationSettingsAsync(TenantUserInvitationSettingsRequestDto? tenantUserInvitationSettingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateInvitationSettingsWithHttpInfoAsync(tenantUserInvitationSettingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update user invitation settings
        /// </summary>
        /// <remarks>
        /// Updates the portal user invitation settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto">User invitation settings (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-settings/">REST API Reference for UpdateInvitationSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantUserInvitationSettingsWrapper)</returns>
        public async Task<ApiResponse<TenantUserInvitationSettingsWrapper>> UpdateInvitationSettingsWithHttpInfoAsync(TenantUserInvitationSettingsRequestDto? tenantUserInvitationSettingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (tenantUserInvitationSettingsRequestDto != null) localVarRequestOptions.Data = tenantUserInvitationSettingsRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<TenantUserInvitationSettingsWrapper>("/api/2.0/settings/invitationsettings", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateInvitationSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
