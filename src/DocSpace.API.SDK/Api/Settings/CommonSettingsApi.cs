// (c) Copyright Ascensio System SIA 2026
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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
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
        /// Dismisses the administrator helper tip for the caller, so it is not shown again on this account. Available  only to a DocSpace administrator, which includes the portal Owner, on a Standalone (self-hosted) installation  running outside white-label custom mode; every other caller is refused. This is a mutating, idempotent call  scoped to the calling account only; it never affects other administrators. It returns no data on success.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/close-admin-helper/">REST API Reference for CloseAdminHelper Operation</seealso>
        /// <returns></returns>
        void CloseAdminHelper();

        /// <summary>
        /// Close the admin helper
        /// </summary>
        /// <remarks>
        /// Dismisses the administrator helper tip for the caller, so it is not shown again on this account. Available  only to a DocSpace administrator, which includes the portal Owner, on a Standalone (self-hosted) installation  running outside white-label custom mode; every other caller is refused. This is a mutating, idempotent call  scoped to the calling account only; it never affects other administrators. It returns no data on success.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/close-admin-helper/">REST API Reference for CloseAdminHelper Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CloseAdminHelperWithHttpInfo();
        /// <summary>
        /// Complete the Wizard settings
        /// </summary>
        /// <remarks>
        /// Finishes the initial portal setup wizard: sets the owner's password and locale, applies the supplied license  if one is required, and marks the wizard as completed so it is not shown again. This call is not for a normal  logged-in session: it requires a confirmation link bearing the Wizard claim, of the kind issued when a new  portal is created, and the link is consumed as part of authenticating the request; the caller must also hold  the EditPortalSettings permission. An empty password or a malformed email address is rejected without  completing the wizard, and so is a missing, invalid, or expired license, or a license whose user quota does  not cover the portal. This call is meant to run once per portal; running it again is accepted but has no  further effect once the wizard is already completed. It returns the resulting wizard settings, including the  completed flag.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto">What the initial setup wizard needs to finish a new portal: the owner credentials and the portal locale. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/complete-wizard/">REST API Reference for CompleteWizard Operation</seealso>
        /// <returns>WizardSettingsWrapper</returns>
        WizardSettingsWrapper CompleteWizard(WizardRequestsDto? wizardRequestsDto = default);

        /// <summary>
        /// Complete the Wizard settings
        /// </summary>
        /// <remarks>
        /// Finishes the initial portal setup wizard: sets the owner's password and locale, applies the supplied license  if one is required, and marks the wizard as completed so it is not shown again. This call is not for a normal  logged-in session: it requires a confirmation link bearing the Wizard claim, of the kind issued when a new  portal is created, and the link is consumed as part of authenticating the request; the caller must also hold  the EditPortalSettings permission. An empty password or a malformed email address is rejected without  completing the wizard, and so is a missing, invalid, or expired license, or a license whose user quota does  not cover the portal. This call is meant to run once per portal; running it again is accepted but has no  further effect once the wizard is already completed. It returns the resulting wizard settings, including the  completed flag.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto">What the initial setup wizard needs to finish a new portal: the owner credentials and the portal locale. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/complete-wizard/">REST API Reference for CompleteWizard Operation</seealso>
        /// <returns>ApiResponse of WizardSettingsWrapper</returns>
        ApiResponse<WizardSettingsWrapper> CompleteWizardWithHttpInfo(WizardRequestsDto? wizardRequestsDto = default);
        /// <summary>
        /// Configure the deep link settings
        /// </summary>
        /// <remarks>
        /// Sets how the portal responds when a client opens a DocSpace link on a mobile device: always in the browser,  always in the native app, or asking the user to choose each time. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). The handling mode must be one of the documented enum values; anything else is  rejected without being saved. This is a mutating, idempotent call: sending the same mode again leaves the  setting unchanged. It returns the saved deep link settings, including the timestamp of the last change; read  the current value at any time, including anonymously, from `GET api/2.0/settings/deeplink`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto">How the portal opens its links on a mobile device. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/configure-deep-link/">REST API Reference for ConfigureDeepLink Operation</seealso>
        /// <returns>TenantDeepLinkSettingsWrapper</returns>
        TenantDeepLinkSettingsWrapper ConfigureDeepLink(DeepLinkConfigurationRequestsDto? deepLinkConfigurationRequestsDto = default);

        /// <summary>
        /// Configure the deep link settings
        /// </summary>
        /// <remarks>
        /// Sets how the portal responds when a client opens a DocSpace link on a mobile device: always in the browser,  always in the native app, or asking the user to choose each time. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). The handling mode must be one of the documented enum values; anything else is  rejected without being saved. This is a mutating, idempotent call: sending the same mode again leaves the  setting unchanged. It returns the saved deep link settings, including the timestamp of the last change; read  the current value at any time, including anonymously, from `GET api/2.0/settings/deeplink`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto">How the portal opens its links on a mobile device. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/configure-deep-link/">REST API Reference for ConfigureDeepLink Operation</seealso>
        /// <returns>ApiResponse of TenantDeepLinkSettingsWrapper</returns>
        ApiResponse<TenantDeepLinkSettingsWrapper> ConfigureDeepLinkWithHttpInfo(DeepLinkConfigurationRequestsDto? deepLinkConfigurationRequestsDto = default);
        /// <summary>
        /// Delete a color theme
        /// </summary>
        /// <remarks>
        /// Removes a custom color theme from the portal by its ID. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). An ID belonging to one of the built-in default themes is not removable; the  call succeeds but leaves the theme list unchanged. If the deleted theme was the currently selected one, the  theme with the lowest remaining ID is selected automatically. This is a mutating, idempotent call: deleting an  ID that is already gone succeeds without error and again leaves nothing changed. It returns the full updated  theme configuration, including the (possibly new) selected theme.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The theme to remove, by theme ID. An ID belonging to a built-in theme leaves the list untouched, and so does  one that is already gone - neither is reported as an error. Removing the theme currently in use moves the  portal to the remaining theme with the lowest ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-portal-color-theme/">REST API Reference for DeletePortalColorTheme Operation</seealso>
        /// <returns>CustomColorThemesSettingsWrapper</returns>
        CustomColorThemesSettingsWrapper DeletePortalColorTheme(int id);

        /// <summary>
        /// Delete a color theme
        /// </summary>
        /// <remarks>
        /// Removes a custom color theme from the portal by its ID. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). An ID belonging to one of the built-in default themes is not removable; the  call succeeds but leaves the theme list unchanged. If the deleted theme was the currently selected one, the  theme with the lowest remaining ID is selected automatically. This is a mutating, idempotent call: deleting an  ID that is already gone succeeds without error and again leaves nothing changed. It returns the full updated  theme configuration, including the (possibly new) selected theme.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The theme to remove, by theme ID. An ID belonging to a built-in theme leaves the list untouched, and so does  one that is already gone - neither is reported as an error. Removing the theme currently in use moves the  portal to the remaining theme with the lowest ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-portal-color-theme/">REST API Reference for DeletePortalColorTheme Operation</seealso>
        /// <returns>ApiResponse of CustomColorThemesSettingsWrapper</returns>
        ApiResponse<CustomColorThemesSettingsWrapper> DeletePortalColorThemeWithHttpInfo(int id);
        /// <summary>
        /// Get the deep link settings
        /// </summary>
        /// <remarks>
        /// Returns how the portal currently responds when a client opens a DocSpace link on a mobile device: always in  the browser, always in the native app, or asking the user to choose. No permission is required; anonymous  callers can read it too. This is a read-only, idempotent call. The response supports conditional requests:  send the standard If-Modified-Since header with the previous `lastModified` value, and an unchanged response  comes back empty instead of resending the settings. Change the mode with `POST api/2.0/settings/deeplink`,  which requires the EditPortalSettings permission.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-deep-link-settings/">REST API Reference for GetDeepLinkSettings Operation</seealso>
        /// <returns>TenantDeepLinkSettingsWrapper</returns>
        TenantDeepLinkSettingsWrapper GetDeepLinkSettings();

        /// <summary>
        /// Get the deep link settings
        /// </summary>
        /// <remarks>
        /// Returns how the portal currently responds when a client opens a DocSpace link on a mobile device: always in  the browser, always in the native app, or asking the user to choose. No permission is required; anonymous  callers can read it too. This is a read-only, idempotent call. The response supports conditional requests:  send the standard If-Modified-Since header with the previous `lastModified` value, and an unchanged response  comes back empty instead of resending the settings. Change the mode with `POST api/2.0/settings/deeplink`,  which requires the EditPortalSettings permission.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-deep-link-settings/">REST API Reference for GetDeepLinkSettings Operation</seealso>
        /// <returns>ApiResponse of TenantDeepLinkSettingsWrapper</returns>
        ApiResponse<TenantDeepLinkSettingsWrapper> GetDeepLinkSettingsWithHttpInfo();
        /// <summary>
        /// Get the payment settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's payment-related configuration: the sales contact email, the URL to buy or extend a  subscription, whether the portal is Standalone, the current license's trial status and expiration date, and  the maximum quota quantity that can be purchased at once. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). This is a read-only, idempotent call. It remains reachable even while the  portal's own subscription payment is overdue, since this is how the caller finds the link to resolve it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-settings/">REST API Reference for GetPaymentSettings Operation</seealso>
        /// <returns>PaymentSettingsWrapper</returns>
        PaymentSettingsWrapper GetPaymentSettings();

        /// <summary>
        /// Get the payment settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's payment-related configuration: the sales contact email, the URL to buy or extend a  subscription, whether the portal is Standalone, the current license's trial status and expiration date, and  the maximum quota quantity that can be purchased at once. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). This is a read-only, idempotent call. It remains reachable even while the  portal's own subscription payment is overdue, since this is how the caller finds the link to resolve it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-payment-settings/">REST API Reference for GetPaymentSettings Operation</seealso>
        /// <returns>ApiResponse of PaymentSettingsWrapper</returns>
        ApiResponse<PaymentSettingsWrapper> GetPaymentSettingsWithHttpInfo();
        /// <summary>
        /// Get a color theme
        /// </summary>
        /// <remarks>
        /// Returns the portal's color theme configuration: every saved custom theme, which one is currently selected, and  how many custom themes the plan still allows. No permission is required; anonymous callers can read it too.  This is a read-only, idempotent call. The response supports conditional requests: send the standard  If-Modified-Since header with the previous `lastModified` value, and an unchanged response comes back empty  instead of resending the same settings. A `limit` of `0` means the plan does not cap the number of custom  themes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-color-theme/">REST API Reference for GetPortalColorTheme Operation</seealso>
        /// <returns>CustomColorThemesSettingsWrapper</returns>
        CustomColorThemesSettingsWrapper GetPortalColorTheme();

        /// <summary>
        /// Get a color theme
        /// </summary>
        /// <remarks>
        /// Returns the portal's color theme configuration: every saved custom theme, which one is currently selected, and  how many custom themes the plan still allows. No permission is required; anonymous callers can read it too.  This is a read-only, idempotent call. The response supports conditional requests: send the standard  If-Modified-Since header with the previous `lastModified` value, and an unchanged response comes back empty  instead of resending the same settings. A `limit` of `0` means the plan does not cap the number of custom  themes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-color-theme/">REST API Reference for GetPortalColorTheme Operation</seealso>
        /// <returns>ApiResponse of CustomColorThemesSettingsWrapper</returns>
        ApiResponse<CustomColorThemesSettingsWrapper> GetPortalColorThemeWithHttpInfo();
        /// <summary>
        /// Get the portal hostname
        /// </summary>
        /// <remarks>
        /// Returns the hostname the current request arrived on, exactly as sent in the HTTP Host header, so a client  mid-setup can learn the address the portal is actually reachable at. This call is not for a normal logged-in  session: it requires a confirmation link bearing the Wizard claim, of the kind generated during initial portal  setup, and the link is consumed as part of authenticating the request. This is a read-only, idempotent call.  The value reflects whatever the caller connected through, including a reverse proxy's public name, and is not  necessarily the tenant's configured alias or mapped domain.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-hostname/">REST API Reference for GetPortalHostname Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper GetPortalHostname();

        /// <summary>
        /// Get the portal hostname
        /// </summary>
        /// <remarks>
        /// Returns the hostname the current request arrived on, exactly as sent in the HTTP Host header, so a client  mid-setup can learn the address the portal is actually reachable at. This call is not for a normal logged-in  session: it requires a confirmation link bearing the Wizard claim, of the kind generated during initial portal  setup, and the link is consumed as part of authenticating the request. This is a read-only, idempotent call.  The value reflects whatever the caller connected through, including a reverse proxy's public name, and is not  necessarily the tenant's configured alias or mapped domain.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-hostname/">REST API Reference for GetPortalHostname Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> GetPortalHostnameWithHttpInfo();
        /// <summary>
        /// Get a portal logo
        /// </summary>
        /// <remarks>
        /// Returns the absolute URL of the portal's current logo image, already resolved against the active white-label  branding. Requires an authenticated session; every role, including Guest, can read it. This is a read-only,  idempotent call. The response supports conditional requests: send the standard If-Modified-Since header with  the previous `lastModified` value, and an unchanged response comes back empty instead of resending the same  URL. The URL points at whatever image is currently configured, including the default DocSpace logo when no  custom branding has been set.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-logo/">REST API Reference for GetPortalLogo Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper GetPortalLogo();

        /// <summary>
        /// Get a portal logo
        /// </summary>
        /// <remarks>
        /// Returns the absolute URL of the portal's current logo image, already resolved against the active white-label  branding. Requires an authenticated session; every role, including Guest, can read it. This is a read-only,  idempotent call. The response supports conditional requests: send the standard If-Modified-Since header with  the previous `lastModified` value, and an unchanged response comes back empty instead of resending the same  URL. The URL points at whatever image is currently configured, including the default DocSpace logo when no  custom branding has been set.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-logo/">REST API Reference for GetPortalLogo Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> GetPortalLogoWithHttpInfo();
        /// <summary>
        /// Get the portal settings
        /// </summary>
        /// <remarks>
        /// Returns the current portal's general configuration: branding, culture, feature flags, and DocSpace/Standalone  mode, everything the client needs to render its shell before or after login. No permission is required, but  the response shape depends on the caller's identity. An anonymous caller receives only the public subset  (culture, branding, DocSpace/Standalone flags, deep link data, setup-wizard and join-by-domain hints); once  authenticated, the response also includes tenant-specific fields such as the owner ID, time zone, invitation  limit, AI/banner/dev-tools flags, and, for a DocSpace administrator, the tenant wallet's low-balance flag.  This is a read-only, idempotent call. Pass `withPassword=true` to also receive the parameters (`salt`,  iteration count, hash size) used to hash the password client-side before it is sent to the authentication  endpoints; these are only added for an anonymous caller or when explicitly requested, never as part of the  default authenticated response.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withpassword">Whether the answer also carries the salt, iteration count and hash size a client needs to hash a password  before sending it to the authentication operations. They are included for an anonymous caller anyway; for a  signed-in one they are left out unless this is set. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-settings/">REST API Reference for GetPortalSettings Operation</seealso>
        /// <returns>SettingsWrapper</returns>
        SettingsWrapper GetPortalSettings(bool? withpassword = default);

        /// <summary>
        /// Get the portal settings
        /// </summary>
        /// <remarks>
        /// Returns the current portal's general configuration: branding, culture, feature flags, and DocSpace/Standalone  mode, everything the client needs to render its shell before or after login. No permission is required, but  the response shape depends on the caller's identity. An anonymous caller receives only the public subset  (culture, branding, DocSpace/Standalone flags, deep link data, setup-wizard and join-by-domain hints); once  authenticated, the response also includes tenant-specific fields such as the owner ID, time zone, invitation  limit, AI/banner/dev-tools flags, and, for a DocSpace administrator, the tenant wallet's low-balance flag.  This is a read-only, idempotent call. Pass `withPassword=true` to also receive the parameters (`salt`,  iteration count, hash size) used to hash the password client-side before it is sent to the authentication  endpoints; these are only added for an anonymous caller or when explicitly requested, never as part of the  default authenticated response.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withpassword">Whether the answer also carries the salt, iteration count and hash size a client needs to hash a password  before sending it to the authentication operations. They are included for an anonymous caller anyway; for a  signed-in one they are left out unless this is set. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-settings/">REST API Reference for GetPortalSettings Operation</seealso>
        /// <returns>ApiResponse of SettingsWrapper</returns>
        ApiResponse<SettingsWrapper> GetPortalSettingsWithHttpInfo(bool? withpassword = default);
        /// <summary>
        /// Get the socket settings
        /// </summary>
        /// <remarks>
        /// Returns the base URL of the portal's real-time notification hub (Socket.IO), which the client connects to for  live updates such as file changes, presence, or quota alerts. Requires an authenticated session; every role  can read it. This is a read-only, idempotent call. The value comes from server-side configuration and cannot  be changed through this API; an empty `url` means the portal has no notification hub configured and the client  should not attempt to connect.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-socket-settings/">REST API Reference for GetSocketSettings Operation</seealso>
        /// <returns>SocketSettingsWrapper</returns>
        SocketSettingsWrapper GetSocketSettings();

        /// <summary>
        /// Get the socket settings
        /// </summary>
        /// <remarks>
        /// Returns the base URL of the portal's real-time notification hub (Socket.IO), which the client connects to for  live updates such as file changes, presence, or quota alerts. Requires an authenticated session; every role  can read it. This is a read-only, idempotent call. The value comes from server-side configuration and cannot  be changed through this API; an empty `url` means the portal has no notification hub configured and the client  should not attempt to connect.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-socket-settings/">REST API Reference for GetSocketSettings Operation</seealso>
        /// <returns>ApiResponse of SocketSettingsWrapper</returns>
        ApiResponse<SocketSettingsWrapper> GetSocketSettingsWithHttpInfo();
        /// <summary>
        /// Get supported languages
        /// </summary>
        /// <remarks>
        /// Returns the two- or four-letter language codes of every culture currently enabled on the portal (for example  `en-US`), used to populate a language picker before or after login. No permission is required; anonymous  callers can read it too. This is a read-only, idempotent call, and the list is not paginated. The response  supports conditional requests: an unchanged result is signaled instead of resending the same list. The set of  enabled cultures is a portal-wide configuration value, not a per-user preference.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-supported-cultures/">REST API Reference for GetSupportedCultures Operation</seealso>
        /// <returns>STRINGArrayWrapper</returns>
        STRINGArrayWrapper GetSupportedCultures();

        /// <summary>
        /// Get supported languages
        /// </summary>
        /// <remarks>
        /// Returns the two- or four-letter language codes of every culture currently enabled on the portal (for example  `en-US`), used to populate a language picker before or after login. No permission is required; anonymous  callers can read it too. This is a read-only, idempotent call, and the list is not paginated. The response  supports conditional requests: an unchanged result is signaled instead of resending the same list. The set of  enabled cultures is a portal-wide configuration value, not a per-user preference.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-supported-cultures/">REST API Reference for GetSupportedCultures Operation</seealso>
        /// <returns>ApiResponse of STRINGArrayWrapper</returns>
        ApiResponse<STRINGArrayWrapper> GetSupportedCulturesWithHttpInfo();
        /// <summary>
        /// Get the AI access settings
        /// </summary>
        /// <remarks>
        /// Returns whether AI functionality (chat, agents, vectorization) is currently available on the portal at all; AI  is enabled by default. Requires an authenticated session; every role can read it. This is a read-only,  idempotent call. When the setting is disabled, every AI-specific endpoint and folder is unavailable regardless  of the caller's own permissions; this call only reports the portal-wide switch, not any per-user entitlement.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-ai-access-settings/">REST API Reference for GetTenantAiAccessSettings Operation</seealso>
        /// <returns>TenantAiAccessSettingsWrapper</returns>
        TenantAiAccessSettingsWrapper GetTenantAiAccessSettings();

        /// <summary>
        /// Get the AI access settings
        /// </summary>
        /// <remarks>
        /// Returns whether AI functionality (chat, agents, vectorization) is currently available on the portal at all; AI  is enabled by default. Requires an authenticated session; every role can read it. This is a read-only,  idempotent call. When the setting is disabled, every AI-specific endpoint and folder is unavailable regardless  of the caller's own permissions; this call only reports the portal-wide switch, not any per-user entitlement.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-ai-access-settings/">REST API Reference for GetTenantAiAccessSettings Operation</seealso>
        /// <returns>ApiResponse of TenantAiAccessSettingsWrapper</returns>
        ApiResponse<TenantAiAccessSettingsWrapper> GetTenantAiAccessSettingsWithHttpInfo();
        /// <summary>
        /// Get the user invitation settings
        /// </summary>
        /// <remarks>
        /// Returns whether the portal currently allows inviting new members and new guests at all. No permission is  required; anonymous callers can read it too, since the invitation flow itself may run before the caller has  signed in. This is a read-only, idempotent call. The response supports conditional requests: send the standard  If-Modified-Since header with the previous `lastModified` value, and an unchanged response comes back empty  instead of resending the same settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-user-invitation-settings/">REST API Reference for GetTenantUserInvitationSettings Operation</seealso>
        /// <returns>TenantUserInvitationSettingsWrapper</returns>
        TenantUserInvitationSettingsWrapper GetTenantUserInvitationSettings();

        /// <summary>
        /// Get the user invitation settings
        /// </summary>
        /// <remarks>
        /// Returns whether the portal currently allows inviting new members and new guests at all. No permission is  required; anonymous callers can read it too, since the invitation flow itself may run before the caller has  signed in. This is a read-only, idempotent call. The response supports conditional requests: send the standard  If-Modified-Since header with the previous `lastModified` value, and an unchanged response comes back empty  instead of resending the same settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-user-invitation-settings/">REST API Reference for GetTenantUserInvitationSettings Operation</seealso>
        /// <returns>ApiResponse of TenantUserInvitationSettingsWrapper</returns>
        ApiResponse<TenantUserInvitationSettingsWrapper> GetTenantUserInvitationSettingsWithHttpInfo();
        /// <summary>
        /// Get time zones
        /// </summary>
        /// <remarks>
        /// Returns every time zone known to the host machine, each with its IANA identifier and a human-readable display  name, ordered from the most negative to the most positive UTC offset. This call is not for a normal logged-in  session: it requires a confirmation link bearing the Wizard or Administrators claim, of the kind generated  during initial portal setup or issued by an administrator, and the link is consumed as part of authenticating  the request. This is a read-only, idempotent call, and the list is not paginated. Use the returned `id` values  wherever the portal expects a time zone identifier; an unrecognized value is rejected there, not here.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-time-zones/">REST API Reference for GetTimeZones Operation</seealso>
        /// <returns>TimezonesRequestsArrayWrapper</returns>
        TimezonesRequestsArrayWrapper GetTimeZones();

        /// <summary>
        /// Get time zones
        /// </summary>
        /// <remarks>
        /// Returns every time zone known to the host machine, each with its IANA identifier and a human-readable display  name, ordered from the most negative to the most positive UTC offset. This call is not for a normal logged-in  session: it requires a confirmation link bearing the Wizard or Administrators claim, of the kind generated  during initial portal setup or issued by an administrator, and the link is consumed as part of authenticating  the request. This is a read-only, idempotent call, and the list is not paginated. Use the returned `id` values  wherever the portal expects a time zone identifier; an unrecognized value is rejected there, not here.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-time-zones/">REST API Reference for GetTimeZones Operation</seealso>
        /// <returns>ApiResponse of TimezonesRequestsArrayWrapper</returns>
        ApiResponse<TimezonesRequestsArrayWrapper> GetTimeZonesWithHttpInfo();
        /// <summary>
        /// Set the default folder
        /// </summary>
        /// <remarks>
        /// Sets which folder the current user's account opens into by default, such as My Documents, the rooms list, or  favorites. Requires an authenticated session; every role may set its own default, and the change never affects  any other user. Only folder types the client actually offers as a landing page are accepted; picking My  Documents (`USER`) as a Guest is rejected too, since guests have no personal storage. This is a mutating,  idempotent call. It returns the saved setting.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="defaultProductRequestDto">The section the calling user's account opens into after signing in. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-default-folder/">REST API Reference for SaveDefaultFolder Operation</seealso>
        /// <returns>StudioDefaultPageSettingsWrapper</returns>
        StudioDefaultPageSettingsWrapper SaveDefaultFolder(DefaultProductRequestDto? defaultProductRequestDto = default);

        /// <summary>
        /// Set the default folder
        /// </summary>
        /// <remarks>
        /// Sets which folder the current user's account opens into by default, such as My Documents, the rooms list, or  favorites. Requires an authenticated session; every role may set its own default, and the change never affects  any other user. Only folder types the client actually offers as a landing page are accepted; picking My  Documents (`USER`) as a Guest is rejected too, since guests have no personal storage. This is a mutating,  idempotent call. It returns the saved setting.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="defaultProductRequestDto">The section the calling user's account opens into after signing in. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-default-folder/">REST API Reference for SaveDefaultFolder Operation</seealso>
        /// <returns>ApiResponse of StudioDefaultPageSettingsWrapper</returns>
        ApiResponse<StudioDefaultPageSettingsWrapper> SaveDefaultFolderWithHttpInfo(DefaultProductRequestDto? defaultProductRequestDto = default);
        /// <summary>
        /// Save the DNS settings
        /// </summary>
        /// <remarks>
        /// Maps a custom domain name onto the current tenant, or clears the mapping, so the portal becomes reachable  under the caller's own DNS name instead of only its default alias. Available only on a Standalone  (self-hosted) installation; on SaaS the call is always refused. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). Disable the mapping by passing `enable=false`, in which case the domain name  in the request is ignored. A domain that collides with the portal's reserved base domain, or otherwise fails  validation, is rejected without changing the current mapping. This is a mutating, idempotent call. On success  the previous domain also stops answering, and any CSP configuration referencing it is updated to the new one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto">The custom domain the portal answers on, and whether that mapping is in force. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-dns-settings/">REST API Reference for SaveDnsSettings Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper SaveDnsSettings(DnsSettingsRequestsDto? dnsSettingsRequestsDto = default);

        /// <summary>
        /// Save the DNS settings
        /// </summary>
        /// <remarks>
        /// Maps a custom domain name onto the current tenant, or clears the mapping, so the portal becomes reachable  under the caller's own DNS name instead of only its default alias. Available only on a Standalone  (self-hosted) installation; on SaaS the call is always refused. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). Disable the mapping by passing `enable=false`, in which case the domain name  in the request is ignored. A domain that collides with the portal's reserved base domain, or otherwise fails  validation, is rejected without changing the current mapping. This is a mutating, idempotent call. On success  the previous domain also stops answering, and any CSP configuration referencing it is updated to the new one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto">The custom domain the portal answers on, and whether that mapping is in force. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-dns-settings/">REST API Reference for SaveDnsSettings Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> SaveDnsSettingsWithHttpInfo(DnsSettingsRequestsDto? dnsSettingsRequestsDto = default);
        /// <summary>
        /// Save the mail domain settings
        /// </summary>
        /// <remarks>
        /// Overwrites the portal's trusted mail domain configuration, which controls which email domains are treated as  already verified when a user is invited or self-registers. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). When the requested mode is a custom domain list, every domain is normalized to  lowercase and checked against the expected hostname format; a domain that fails the check, or an empty custom  list, causes the whole call to be rejected without saving anything. For the other modes the domain list in the  request is ignored. The `inviteUsersAsVisitors` flag controls whether users who join through a trusted domain  are added as full members or as visitors, and takes effect on the next join rather than retroactively. This is  a mutating, idempotent call: repeating it with the same body leaves the portal in the same state. On success  it returns a confirmation message, not the saved settings themselves; read them back from  `GET api/2.0/settings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto">Which email domains the portal treats as already verified, and how their users join. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mail-domain-settings/">REST API Reference for SaveMailDomainSettings Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper SaveMailDomainSettings(MailDomainSettingsRequestsDto? mailDomainSettingsRequestsDto = default);

        /// <summary>
        /// Save the mail domain settings
        /// </summary>
        /// <remarks>
        /// Overwrites the portal's trusted mail domain configuration, which controls which email domains are treated as  already verified when a user is invited or self-registers. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). When the requested mode is a custom domain list, every domain is normalized to  lowercase and checked against the expected hostname format; a domain that fails the check, or an empty custom  list, causes the whole call to be rejected without saving anything. For the other modes the domain list in the  request is ignored. The `inviteUsersAsVisitors` flag controls whether users who join through a trusted domain  are added as full members or as visitors, and takes effect on the next join rather than retroactively. This is  a mutating, idempotent call: repeating it with the same body leaves the portal in the same state. On success  it returns a confirmation message, not the saved settings themselves; read them back from  `GET api/2.0/settings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto">Which email domains the portal treats as already verified, and how their users join. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mail-domain-settings/">REST API Reference for SaveMailDomainSettings Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> SaveMailDomainSettingsWithHttpInfo(MailDomainSettingsRequestsDto? mailDomainSettingsRequestsDto = default);
        /// <summary>
        /// Save a color theme
        /// </summary>
        /// <remarks>
        /// Adds or updates a custom color theme, or changes which theme is selected, for the whole portal. Requires Owner  or DocSpaceAdmin (the EditPortalSettings permission). Pass `theme` to create or edit one: an existing theme is  matched and updated by its ID, a new one is appended, and an ID that collides with a built-in default theme is  treated as a request to create a new custom theme instead of overwriting the default. Once the plan's  custom-theme limit is reached, a new theme is silently not added rather than rejected with an error, so check  the returned `themes` count against `limit` before assuming it was saved. Pass `selected` to switch the active  theme; an ID that does not match any existing theme is ignored. This is a mutating call, not strictly  idempotent once the limit has been reached. It returns the full updated theme configuration.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto">The custom colour theme being saved, the theme being selected, or both. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-portal-color-theme/">REST API Reference for SavePortalColorTheme Operation</seealso>
        /// <returns>CustomColorThemesSettingsWrapper</returns>
        CustomColorThemesSettingsWrapper SavePortalColorTheme(CustomColorThemesSettingsRequestsDto? customColorThemesSettingsRequestsDto = default);

        /// <summary>
        /// Save a color theme
        /// </summary>
        /// <remarks>
        /// Adds or updates a custom color theme, or changes which theme is selected, for the whole portal. Requires Owner  or DocSpaceAdmin (the EditPortalSettings permission). Pass `theme` to create or edit one: an existing theme is  matched and updated by its ID, a new one is appended, and an ID that collides with a built-in default theme is  treated as a request to create a new custom theme instead of overwriting the default. Once the plan's  custom-theme limit is reached, a new theme is silently not added rather than rejected with an error, so check  the returned `themes` count against `limit` before assuming it was saved. Pass `selected` to switch the active  theme; an ID that does not match any existing theme is ignored. This is a mutating call, not strictly  idempotent once the limit has been reached. It returns the full updated theme configuration.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto">The custom colour theme being saved, the theme being selected, or both. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-portal-color-theme/">REST API Reference for SavePortalColorTheme Operation</seealso>
        /// <returns>ApiResponse of CustomColorThemesSettingsWrapper</returns>
        ApiResponse<CustomColorThemesSettingsWrapper> SavePortalColorThemeWithHttpInfo(CustomColorThemesSettingsRequestsDto? customColorThemesSettingsRequestsDto = default);
        /// <summary>
        /// Set the AI access settings
        /// </summary>
        /// <remarks>
        /// Turns AI functionality (chat, agents, vectorization) on or off for the whole portal; AI is enabled by default.  Requires Owner or DocSpaceAdmin (the EditPortalSettings permission); every other caller is refused. Disabling  it immediately hides the AI Agents folder from root folder listings, makes AI status checks report disabled,  and makes AI chat endpoints unreachable for every user on the tenant, not only the caller. This is a mutating,  idempotent, portal-wide call, and the change is pushed to already-connected clients over the real-time  notification hub rather than waiting for their next request. It returns the saved setting.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAiAccessSettingsDto">Whether AI functionality is available on the portal. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-ai-access-settings/">REST API Reference for SetTenantAiAccessSettings Operation</seealso>
        /// <returns>TenantAiAccessSettingsWrapper</returns>
        TenantAiAccessSettingsWrapper SetTenantAiAccessSettings(TenantAiAccessSettingsDto? tenantAiAccessSettingsDto = default);

        /// <summary>
        /// Set the AI access settings
        /// </summary>
        /// <remarks>
        /// Turns AI functionality (chat, agents, vectorization) on or off for the whole portal; AI is enabled by default.  Requires Owner or DocSpaceAdmin (the EditPortalSettings permission); every other caller is refused. Disabling  it immediately hides the AI Agents folder from root folder listings, makes AI status checks report disabled,  and makes AI chat endpoints unreachable for every user on the tenant, not only the caller. This is a mutating,  idempotent, portal-wide call, and the change is pushed to already-connected clients over the real-time  notification hub rather than waiting for their next request. It returns the saved setting.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAiAccessSettingsDto">Whether AI functionality is available on the portal. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-ai-access-settings/">REST API Reference for SetTenantAiAccessSettings Operation</seealso>
        /// <returns>ApiResponse of TenantAiAccessSettingsWrapper</returns>
        ApiResponse<TenantAiAccessSettingsWrapper> SetTenantAiAccessSettingsWithHttpInfo(TenantAiAccessSettingsDto? tenantAiAccessSettingsDto = default);
        /// <summary>
        /// Update the email activation settings
        /// </summary>
        /// <remarks>
        /// Updates the current user's own preference for whether the email confirmation prompt is displayed on their  account. Requires an authenticated session; every role may change its own setting, and the change never  affects any other user. This is a mutating, idempotent call. It returns the settings exactly as submitted,  without validating them against the account's actual email confirmation state, so `show` can be set to `true`  even after the address is already confirmed.
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
        /// Updates the current user's own preference for whether the email confirmation prompt is displayed on their  account. Requires an authenticated session; every role may change its own setting, and the change never  affects any other user. This is a mutating, idempotent call. It returns the settings exactly as submitted,  without validating them against the account's actual email confirmation state, so `show` can be set to `true`  even after the address is already confirmed.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailActivationSettings">The email activation settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-email-activation-settings/">REST API Reference for UpdateEmailActivationSettings Operation</seealso>
        /// <returns>ApiResponse of EmailActivationSettingsWrapper</returns>
        ApiResponse<EmailActivationSettingsWrapper> UpdateEmailActivationSettingsWithHttpInfo(EmailActivationSettings? emailActivationSettings = default);
        /// <summary>
        /// Update the user invitation settings
        /// </summary>
        /// <remarks>
        /// Sets whether the portal allows inviting new members and new guests. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). Disabling member or guest invitations only blocks creating new invitations  going forward; it does not revoke links already issued or remove members already invited. This is a mutating,  idempotent, portal-wide call. It returns the saved setting; read the current value at any time, including  anonymously, from `GET api/2.0/settings/invitationsettings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto">Whether the portal still lets its members invite new members and new guests. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-settings/">REST API Reference for UpdateInvitationSettings Operation</seealso>
        /// <returns>TenantUserInvitationSettingsWrapper</returns>
        TenantUserInvitationSettingsWrapper UpdateInvitationSettings(TenantUserInvitationSettingsRequestDto? tenantUserInvitationSettingsRequestDto = default);

        /// <summary>
        /// Update the user invitation settings
        /// </summary>
        /// <remarks>
        /// Sets whether the portal allows inviting new members and new guests. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). Disabling member or guest invitations only blocks creating new invitations  going forward; it does not revoke links already issued or remove members already invited. This is a mutating,  idempotent, portal-wide call. It returns the saved setting; read the current value at any time, including  anonymously, from `GET api/2.0/settings/invitationsettings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto">Whether the portal still lets its members invite new members and new guests. (optional)</param>
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
        /// Dismisses the administrator helper tip for the caller, so it is not shown again on this account. Available  only to a DocSpace administrator, which includes the portal Owner, on a Standalone (self-hosted) installation  running outside white-label custom mode; every other caller is refused. This is a mutating, idempotent call  scoped to the calling account only; it never affects other administrators. It returns no data on success.
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
        /// Dismisses the administrator helper tip for the caller, so it is not shown again on this account. Available  only to a DocSpace administrator, which includes the portal Owner, on a Standalone (self-hosted) installation  running outside white-label custom mode; every other caller is refused. This is a mutating, idempotent call  scoped to the calling account only; it never affects other administrators. It returns no data on success.
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
        /// Finishes the initial portal setup wizard: sets the owner's password and locale, applies the supplied license  if one is required, and marks the wizard as completed so it is not shown again. This call is not for a normal  logged-in session: it requires a confirmation link bearing the Wizard claim, of the kind issued when a new  portal is created, and the link is consumed as part of authenticating the request; the caller must also hold  the EditPortalSettings permission. An empty password or a malformed email address is rejected without  completing the wizard, and so is a missing, invalid, or expired license, or a license whose user quota does  not cover the portal. This call is meant to run once per portal; running it again is accepted but has no  further effect once the wizard is already completed. It returns the resulting wizard settings, including the  completed flag.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto">What the initial setup wizard needs to finish a new portal: the owner credentials and the portal locale. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/complete-wizard/">REST API Reference for CompleteWizard Operation</seealso>
        /// <returns>Task of WizardSettingsWrapper</returns>
        Task<WizardSettingsWrapper> CompleteWizardAsync(WizardRequestsDto? wizardRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Complete the Wizard settings
        /// </summary>
        /// <remarks>
        /// Finishes the initial portal setup wizard: sets the owner's password and locale, applies the supplied license  if one is required, and marks the wizard as completed so it is not shown again. This call is not for a normal  logged-in session: it requires a confirmation link bearing the Wizard claim, of the kind issued when a new  portal is created, and the link is consumed as part of authenticating the request; the caller must also hold  the EditPortalSettings permission. An empty password or a malformed email address is rejected without  completing the wizard, and so is a missing, invalid, or expired license, or a license whose user quota does  not cover the portal. This call is meant to run once per portal; running it again is accepted but has no  further effect once the wizard is already completed. It returns the resulting wizard settings, including the  completed flag.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto">What the initial setup wizard needs to finish a new portal: the owner credentials and the portal locale. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/complete-wizard/">REST API Reference for CompleteWizard Operation</seealso>
        /// <returns>Task of ApiResponse (WizardSettingsWrapper)</returns>
        Task<ApiResponse<WizardSettingsWrapper>> CompleteWizardWithHttpInfoAsync(WizardRequestsDto? wizardRequestsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Configure the deep link settings
        /// </summary>
        /// <remarks>
        /// Sets how the portal responds when a client opens a DocSpace link on a mobile device: always in the browser,  always in the native app, or asking the user to choose each time. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). The handling mode must be one of the documented enum values; anything else is  rejected without being saved. This is a mutating, idempotent call: sending the same mode again leaves the  setting unchanged. It returns the saved deep link settings, including the timestamp of the last change; read  the current value at any time, including anonymously, from `GET api/2.0/settings/deeplink`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto">How the portal opens its links on a mobile device. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/configure-deep-link/">REST API Reference for ConfigureDeepLink Operation</seealso>
        /// <returns>Task of TenantDeepLinkSettingsWrapper</returns>
        Task<TenantDeepLinkSettingsWrapper> ConfigureDeepLinkAsync(DeepLinkConfigurationRequestsDto? deepLinkConfigurationRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Configure the deep link settings
        /// </summary>
        /// <remarks>
        /// Sets how the portal responds when a client opens a DocSpace link on a mobile device: always in the browser,  always in the native app, or asking the user to choose each time. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). The handling mode must be one of the documented enum values; anything else is  rejected without being saved. This is a mutating, idempotent call: sending the same mode again leaves the  setting unchanged. It returns the saved deep link settings, including the timestamp of the last change; read  the current value at any time, including anonymously, from `GET api/2.0/settings/deeplink`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto">How the portal opens its links on a mobile device. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/configure-deep-link/">REST API Reference for ConfigureDeepLink Operation</seealso>
        /// <returns>Task of ApiResponse (TenantDeepLinkSettingsWrapper)</returns>
        Task<ApiResponse<TenantDeepLinkSettingsWrapper>> ConfigureDeepLinkWithHttpInfoAsync(DeepLinkConfigurationRequestsDto? deepLinkConfigurationRequestsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a color theme
        /// </summary>
        /// <remarks>
        /// Removes a custom color theme from the portal by its ID. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). An ID belonging to one of the built-in default themes is not removable; the  call succeeds but leaves the theme list unchanged. If the deleted theme was the currently selected one, the  theme with the lowest remaining ID is selected automatically. This is a mutating, idempotent call: deleting an  ID that is already gone succeeds without error and again leaves nothing changed. It returns the full updated  theme configuration, including the (possibly new) selected theme.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The theme to remove, by theme ID. An ID belonging to a built-in theme leaves the list untouched, and so does  one that is already gone - neither is reported as an error. Removing the theme currently in use moves the  portal to the remaining theme with the lowest ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-portal-color-theme/">REST API Reference for DeletePortalColorTheme Operation</seealso>
        /// <returns>Task of CustomColorThemesSettingsWrapper</returns>
        Task<CustomColorThemesSettingsWrapper> DeletePortalColorThemeAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a color theme
        /// </summary>
        /// <remarks>
        /// Removes a custom color theme from the portal by its ID. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). An ID belonging to one of the built-in default themes is not removable; the  call succeeds but leaves the theme list unchanged. If the deleted theme was the currently selected one, the  theme with the lowest remaining ID is selected automatically. This is a mutating, idempotent call: deleting an  ID that is already gone succeeds without error and again leaves nothing changed. It returns the full updated  theme configuration, including the (possibly new) selected theme.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The theme to remove, by theme ID. An ID belonging to a built-in theme leaves the list untouched, and so does  one that is already gone - neither is reported as an error. Removing the theme currently in use moves the  portal to the remaining theme with the lowest ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-portal-color-theme/">REST API Reference for DeletePortalColorTheme Operation</seealso>
        /// <returns>Task of ApiResponse (CustomColorThemesSettingsWrapper)</returns>
        Task<ApiResponse<CustomColorThemesSettingsWrapper>> DeletePortalColorThemeWithHttpInfoAsync(int id, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the deep link settings
        /// </summary>
        /// <remarks>
        /// Returns how the portal currently responds when a client opens a DocSpace link on a mobile device: always in  the browser, always in the native app, or asking the user to choose. No permission is required; anonymous  callers can read it too. This is a read-only, idempotent call. The response supports conditional requests:  send the standard If-Modified-Since header with the previous `lastModified` value, and an unchanged response  comes back empty instead of resending the settings. Change the mode with `POST api/2.0/settings/deeplink`,  which requires the EditPortalSettings permission.
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
        /// Returns how the portal currently responds when a client opens a DocSpace link on a mobile device: always in  the browser, always in the native app, or asking the user to choose. No permission is required; anonymous  callers can read it too. This is a read-only, idempotent call. The response supports conditional requests:  send the standard If-Modified-Since header with the previous `lastModified` value, and an unchanged response  comes back empty instead of resending the settings. Change the mode with `POST api/2.0/settings/deeplink`,  which requires the EditPortalSettings permission.
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
        /// Returns the portal's payment-related configuration: the sales contact email, the URL to buy or extend a  subscription, whether the portal is Standalone, the current license's trial status and expiration date, and  the maximum quota quantity that can be purchased at once. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). This is a read-only, idempotent call. It remains reachable even while the  portal's own subscription payment is overdue, since this is how the caller finds the link to resolve it.
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
        /// Returns the portal's payment-related configuration: the sales contact email, the URL to buy or extend a  subscription, whether the portal is Standalone, the current license's trial status and expiration date, and  the maximum quota quantity that can be purchased at once. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). This is a read-only, idempotent call. It remains reachable even while the  portal's own subscription payment is overdue, since this is how the caller finds the link to resolve it.
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
        /// Returns the portal's color theme configuration: every saved custom theme, which one is currently selected, and  how many custom themes the plan still allows. No permission is required; anonymous callers can read it too.  This is a read-only, idempotent call. The response supports conditional requests: send the standard  If-Modified-Since header with the previous `lastModified` value, and an unchanged response comes back empty  instead of resending the same settings. A `limit` of `0` means the plan does not cap the number of custom  themes.
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
        /// Returns the portal's color theme configuration: every saved custom theme, which one is currently selected, and  how many custom themes the plan still allows. No permission is required; anonymous callers can read it too.  This is a read-only, idempotent call. The response supports conditional requests: send the standard  If-Modified-Since header with the previous `lastModified` value, and an unchanged response comes back empty  instead of resending the same settings. A `limit` of `0` means the plan does not cap the number of custom  themes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-color-theme/">REST API Reference for GetPortalColorTheme Operation</seealso>
        /// <returns>Task of ApiResponse (CustomColorThemesSettingsWrapper)</returns>
        Task<ApiResponse<CustomColorThemesSettingsWrapper>> GetPortalColorThemeWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the portal hostname
        /// </summary>
        /// <remarks>
        /// Returns the hostname the current request arrived on, exactly as sent in the HTTP Host header, so a client  mid-setup can learn the address the portal is actually reachable at. This call is not for a normal logged-in  session: it requires a confirmation link bearing the Wizard claim, of the kind generated during initial portal  setup, and the link is consumed as part of authenticating the request. This is a read-only, idempotent call.  The value reflects whatever the caller connected through, including a reverse proxy's public name, and is not  necessarily the tenant's configured alias or mapped domain.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-hostname/">REST API Reference for GetPortalHostname Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> GetPortalHostnameAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the portal hostname
        /// </summary>
        /// <remarks>
        /// Returns the hostname the current request arrived on, exactly as sent in the HTTP Host header, so a client  mid-setup can learn the address the portal is actually reachable at. This call is not for a normal logged-in  session: it requires a confirmation link bearing the Wizard claim, of the kind generated during initial portal  setup, and the link is consumed as part of authenticating the request. This is a read-only, idempotent call.  The value reflects whatever the caller connected through, including a reverse proxy's public name, and is not  necessarily the tenant's configured alias or mapped domain.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-hostname/">REST API Reference for GetPortalHostname Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> GetPortalHostnameWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a portal logo
        /// </summary>
        /// <remarks>
        /// Returns the absolute URL of the portal's current logo image, already resolved against the active white-label  branding. Requires an authenticated session; every role, including Guest, can read it. This is a read-only,  idempotent call. The response supports conditional requests: send the standard If-Modified-Since header with  the previous `lastModified` value, and an unchanged response comes back empty instead of resending the same  URL. The URL points at whatever image is currently configured, including the default DocSpace logo when no  custom branding has been set.
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
        /// Returns the absolute URL of the portal's current logo image, already resolved against the active white-label  branding. Requires an authenticated session; every role, including Guest, can read it. This is a read-only,  idempotent call. The response supports conditional requests: send the standard If-Modified-Since header with  the previous `lastModified` value, and an unchanged response comes back empty instead of resending the same  URL. The URL points at whatever image is currently configured, including the default DocSpace logo when no  custom branding has been set.
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
        /// Returns the current portal's general configuration: branding, culture, feature flags, and DocSpace/Standalone  mode, everything the client needs to render its shell before or after login. No permission is required, but  the response shape depends on the caller's identity. An anonymous caller receives only the public subset  (culture, branding, DocSpace/Standalone flags, deep link data, setup-wizard and join-by-domain hints); once  authenticated, the response also includes tenant-specific fields such as the owner ID, time zone, invitation  limit, AI/banner/dev-tools flags, and, for a DocSpace administrator, the tenant wallet's low-balance flag.  This is a read-only, idempotent call. Pass `withPassword=true` to also receive the parameters (`salt`,  iteration count, hash size) used to hash the password client-side before it is sent to the authentication  endpoints; these are only added for an anonymous caller or when explicitly requested, never as part of the  default authenticated response.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withpassword">Whether the answer also carries the salt, iteration count and hash size a client needs to hash a password  before sending it to the authentication operations. They are included for an anonymous caller anyway; for a  signed-in one they are left out unless this is set. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-settings/">REST API Reference for GetPortalSettings Operation</seealso>
        /// <returns>Task of SettingsWrapper</returns>
        Task<SettingsWrapper> GetPortalSettingsAsync(bool? withpassword = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the portal settings
        /// </summary>
        /// <remarks>
        /// Returns the current portal's general configuration: branding, culture, feature flags, and DocSpace/Standalone  mode, everything the client needs to render its shell before or after login. No permission is required, but  the response shape depends on the caller's identity. An anonymous caller receives only the public subset  (culture, branding, DocSpace/Standalone flags, deep link data, setup-wizard and join-by-domain hints); once  authenticated, the response also includes tenant-specific fields such as the owner ID, time zone, invitation  limit, AI/banner/dev-tools flags, and, for a DocSpace administrator, the tenant wallet's low-balance flag.  This is a read-only, idempotent call. Pass `withPassword=true` to also receive the parameters (`salt`,  iteration count, hash size) used to hash the password client-side before it is sent to the authentication  endpoints; these are only added for an anonymous caller or when explicitly requested, never as part of the  default authenticated response.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withpassword">Whether the answer also carries the salt, iteration count and hash size a client needs to hash a password  before sending it to the authentication operations. They are included for an anonymous caller anyway; for a  signed-in one they are left out unless this is set. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-settings/">REST API Reference for GetPortalSettings Operation</seealso>
        /// <returns>Task of ApiResponse (SettingsWrapper)</returns>
        Task<ApiResponse<SettingsWrapper>> GetPortalSettingsWithHttpInfoAsync(bool? withpassword = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the socket settings
        /// </summary>
        /// <remarks>
        /// Returns the base URL of the portal's real-time notification hub (Socket.IO), which the client connects to for  live updates such as file changes, presence, or quota alerts. Requires an authenticated session; every role  can read it. This is a read-only, idempotent call. The value comes from server-side configuration and cannot  be changed through this API; an empty `url` means the portal has no notification hub configured and the client  should not attempt to connect.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-socket-settings/">REST API Reference for GetSocketSettings Operation</seealso>
        /// <returns>Task of SocketSettingsWrapper</returns>
        Task<SocketSettingsWrapper> GetSocketSettingsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the socket settings
        /// </summary>
        /// <remarks>
        /// Returns the base URL of the portal's real-time notification hub (Socket.IO), which the client connects to for  live updates such as file changes, presence, or quota alerts. Requires an authenticated session; every role  can read it. This is a read-only, idempotent call. The value comes from server-side configuration and cannot  be changed through this API; an empty `url` means the portal has no notification hub configured and the client  should not attempt to connect.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-socket-settings/">REST API Reference for GetSocketSettings Operation</seealso>
        /// <returns>Task of ApiResponse (SocketSettingsWrapper)</returns>
        Task<ApiResponse<SocketSettingsWrapper>> GetSocketSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get supported languages
        /// </summary>
        /// <remarks>
        /// Returns the two- or four-letter language codes of every culture currently enabled on the portal (for example  `en-US`), used to populate a language picker before or after login. No permission is required; anonymous  callers can read it too. This is a read-only, idempotent call, and the list is not paginated. The response  supports conditional requests: an unchanged result is signaled instead of resending the same list. The set of  enabled cultures is a portal-wide configuration value, not a per-user preference.
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
        /// Returns the two- or four-letter language codes of every culture currently enabled on the portal (for example  `en-US`), used to populate a language picker before or after login. No permission is required; anonymous  callers can read it too. This is a read-only, idempotent call, and the list is not paginated. The response  supports conditional requests: an unchanged result is signaled instead of resending the same list. The set of  enabled cultures is a portal-wide configuration value, not a per-user preference.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-supported-cultures/">REST API Reference for GetSupportedCultures Operation</seealso>
        /// <returns>Task of ApiResponse (STRINGArrayWrapper)</returns>
        Task<ApiResponse<STRINGArrayWrapper>> GetSupportedCulturesWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the AI access settings
        /// </summary>
        /// <remarks>
        /// Returns whether AI functionality (chat, agents, vectorization) is currently available on the portal at all; AI  is enabled by default. Requires an authenticated session; every role can read it. This is a read-only,  idempotent call. When the setting is disabled, every AI-specific endpoint and folder is unavailable regardless  of the caller's own permissions; this call only reports the portal-wide switch, not any per-user entitlement.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-ai-access-settings/">REST API Reference for GetTenantAiAccessSettings Operation</seealso>
        /// <returns>Task of TenantAiAccessSettingsWrapper</returns>
        Task<TenantAiAccessSettingsWrapper> GetTenantAiAccessSettingsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the AI access settings
        /// </summary>
        /// <remarks>
        /// Returns whether AI functionality (chat, agents, vectorization) is currently available on the portal at all; AI  is enabled by default. Requires an authenticated session; every role can read it. This is a read-only,  idempotent call. When the setting is disabled, every AI-specific endpoint and folder is unavailable regardless  of the caller's own permissions; this call only reports the portal-wide switch, not any per-user entitlement.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-ai-access-settings/">REST API Reference for GetTenantAiAccessSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantAiAccessSettingsWrapper)</returns>
        Task<ApiResponse<TenantAiAccessSettingsWrapper>> GetTenantAiAccessSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the user invitation settings
        /// </summary>
        /// <remarks>
        /// Returns whether the portal currently allows inviting new members and new guests at all. No permission is  required; anonymous callers can read it too, since the invitation flow itself may run before the caller has  signed in. This is a read-only, idempotent call. The response supports conditional requests: send the standard  If-Modified-Since header with the previous `lastModified` value, and an unchanged response comes back empty  instead of resending the same settings.
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
        /// Returns whether the portal currently allows inviting new members and new guests at all. No permission is  required; anonymous callers can read it too, since the invitation flow itself may run before the caller has  signed in. This is a read-only, idempotent call. The response supports conditional requests: send the standard  If-Modified-Since header with the previous `lastModified` value, and an unchanged response comes back empty  instead of resending the same settings.
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
        /// Returns every time zone known to the host machine, each with its IANA identifier and a human-readable display  name, ordered from the most negative to the most positive UTC offset. This call is not for a normal logged-in  session: it requires a confirmation link bearing the Wizard or Administrators claim, of the kind generated  during initial portal setup or issued by an administrator, and the link is consumed as part of authenticating  the request. This is a read-only, idempotent call, and the list is not paginated. Use the returned `id` values  wherever the portal expects a time zone identifier; an unrecognized value is rejected there, not here.
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
        /// Returns every time zone known to the host machine, each with its IANA identifier and a human-readable display  name, ordered from the most negative to the most positive UTC offset. This call is not for a normal logged-in  session: it requires a confirmation link bearing the Wizard or Administrators claim, of the kind generated  during initial portal setup or issued by an administrator, and the link is consumed as part of authenticating  the request. This is a read-only, idempotent call, and the list is not paginated. Use the returned `id` values  wherever the portal expects a time zone identifier; an unrecognized value is rejected there, not here.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-time-zones/">REST API Reference for GetTimeZones Operation</seealso>
        /// <returns>Task of ApiResponse (TimezonesRequestsArrayWrapper)</returns>
        Task<ApiResponse<TimezonesRequestsArrayWrapper>> GetTimeZonesWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the default folder
        /// </summary>
        /// <remarks>
        /// Sets which folder the current user's account opens into by default, such as My Documents, the rooms list, or  favorites. Requires an authenticated session; every role may set its own default, and the change never affects  any other user. Only folder types the client actually offers as a landing page are accepted; picking My  Documents (`USER`) as a Guest is rejected too, since guests have no personal storage. This is a mutating,  idempotent call. It returns the saved setting.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="defaultProductRequestDto">The section the calling user's account opens into after signing in. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-default-folder/">REST API Reference for SaveDefaultFolder Operation</seealso>
        /// <returns>Task of StudioDefaultPageSettingsWrapper</returns>
        Task<StudioDefaultPageSettingsWrapper> SaveDefaultFolderAsync(DefaultProductRequestDto? defaultProductRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set the default folder
        /// </summary>
        /// <remarks>
        /// Sets which folder the current user's account opens into by default, such as My Documents, the rooms list, or  favorites. Requires an authenticated session; every role may set its own default, and the change never affects  any other user. Only folder types the client actually offers as a landing page are accepted; picking My  Documents (`USER`) as a Guest is rejected too, since guests have no personal storage. This is a mutating,  idempotent call. It returns the saved setting.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="defaultProductRequestDto">The section the calling user's account opens into after signing in. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-default-folder/">REST API Reference for SaveDefaultFolder Operation</seealso>
        /// <returns>Task of ApiResponse (StudioDefaultPageSettingsWrapper)</returns>
        Task<ApiResponse<StudioDefaultPageSettingsWrapper>> SaveDefaultFolderWithHttpInfoAsync(DefaultProductRequestDto? defaultProductRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Save the DNS settings
        /// </summary>
        /// <remarks>
        /// Maps a custom domain name onto the current tenant, or clears the mapping, so the portal becomes reachable  under the caller's own DNS name instead of only its default alias. Available only on a Standalone  (self-hosted) installation; on SaaS the call is always refused. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). Disable the mapping by passing `enable=false`, in which case the domain name  in the request is ignored. A domain that collides with the portal's reserved base domain, or otherwise fails  validation, is rejected without changing the current mapping. This is a mutating, idempotent call. On success  the previous domain also stops answering, and any CSP configuration referencing it is updated to the new one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto">The custom domain the portal answers on, and whether that mapping is in force. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-dns-settings/">REST API Reference for SaveDnsSettings Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> SaveDnsSettingsAsync(DnsSettingsRequestsDto? dnsSettingsRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Save the DNS settings
        /// </summary>
        /// <remarks>
        /// Maps a custom domain name onto the current tenant, or clears the mapping, so the portal becomes reachable  under the caller's own DNS name instead of only its default alias. Available only on a Standalone  (self-hosted) installation; on SaaS the call is always refused. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). Disable the mapping by passing `enable=false`, in which case the domain name  in the request is ignored. A domain that collides with the portal's reserved base domain, or otherwise fails  validation, is rejected without changing the current mapping. This is a mutating, idempotent call. On success  the previous domain also stops answering, and any CSP configuration referencing it is updated to the new one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto">The custom domain the portal answers on, and whether that mapping is in force. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-dns-settings/">REST API Reference for SaveDnsSettings Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> SaveDnsSettingsWithHttpInfoAsync(DnsSettingsRequestsDto? dnsSettingsRequestsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Save the mail domain settings
        /// </summary>
        /// <remarks>
        /// Overwrites the portal's trusted mail domain configuration, which controls which email domains are treated as  already verified when a user is invited or self-registers. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). When the requested mode is a custom domain list, every domain is normalized to  lowercase and checked against the expected hostname format; a domain that fails the check, or an empty custom  list, causes the whole call to be rejected without saving anything. For the other modes the domain list in the  request is ignored. The `inviteUsersAsVisitors` flag controls whether users who join through a trusted domain  are added as full members or as visitors, and takes effect on the next join rather than retroactively. This is  a mutating, idempotent call: repeating it with the same body leaves the portal in the same state. On success  it returns a confirmation message, not the saved settings themselves; read them back from  `GET api/2.0/settings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto">Which email domains the portal treats as already verified, and how their users join. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mail-domain-settings/">REST API Reference for SaveMailDomainSettings Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> SaveMailDomainSettingsAsync(MailDomainSettingsRequestsDto? mailDomainSettingsRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Save the mail domain settings
        /// </summary>
        /// <remarks>
        /// Overwrites the portal's trusted mail domain configuration, which controls which email domains are treated as  already verified when a user is invited or self-registers. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). When the requested mode is a custom domain list, every domain is normalized to  lowercase and checked against the expected hostname format; a domain that fails the check, or an empty custom  list, causes the whole call to be rejected without saving anything. For the other modes the domain list in the  request is ignored. The `inviteUsersAsVisitors` flag controls whether users who join through a trusted domain  are added as full members or as visitors, and takes effect on the next join rather than retroactively. This is  a mutating, idempotent call: repeating it with the same body leaves the portal in the same state. On success  it returns a confirmation message, not the saved settings themselves; read them back from  `GET api/2.0/settings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto">Which email domains the portal treats as already verified, and how their users join. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-mail-domain-settings/">REST API Reference for SaveMailDomainSettings Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> SaveMailDomainSettingsWithHttpInfoAsync(MailDomainSettingsRequestsDto? mailDomainSettingsRequestsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Save a color theme
        /// </summary>
        /// <remarks>
        /// Adds or updates a custom color theme, or changes which theme is selected, for the whole portal. Requires Owner  or DocSpaceAdmin (the EditPortalSettings permission). Pass `theme` to create or edit one: an existing theme is  matched and updated by its ID, a new one is appended, and an ID that collides with a built-in default theme is  treated as a request to create a new custom theme instead of overwriting the default. Once the plan's  custom-theme limit is reached, a new theme is silently not added rather than rejected with an error, so check  the returned `themes` count against `limit` before assuming it was saved. Pass `selected` to switch the active  theme; an ID that does not match any existing theme is ignored. This is a mutating call, not strictly  idempotent once the limit has been reached. It returns the full updated theme configuration.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto">The custom colour theme being saved, the theme being selected, or both. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-portal-color-theme/">REST API Reference for SavePortalColorTheme Operation</seealso>
        /// <returns>Task of CustomColorThemesSettingsWrapper</returns>
        Task<CustomColorThemesSettingsWrapper> SavePortalColorThemeAsync(CustomColorThemesSettingsRequestsDto? customColorThemesSettingsRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Save a color theme
        /// </summary>
        /// <remarks>
        /// Adds or updates a custom color theme, or changes which theme is selected, for the whole portal. Requires Owner  or DocSpaceAdmin (the EditPortalSettings permission). Pass `theme` to create or edit one: an existing theme is  matched and updated by its ID, a new one is appended, and an ID that collides with a built-in default theme is  treated as a request to create a new custom theme instead of overwriting the default. Once the plan's  custom-theme limit is reached, a new theme is silently not added rather than rejected with an error, so check  the returned `themes` count against `limit` before assuming it was saved. Pass `selected` to switch the active  theme; an ID that does not match any existing theme is ignored. This is a mutating call, not strictly  idempotent once the limit has been reached. It returns the full updated theme configuration.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto">The custom colour theme being saved, the theme being selected, or both. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-portal-color-theme/">REST API Reference for SavePortalColorTheme Operation</seealso>
        /// <returns>Task of ApiResponse (CustomColorThemesSettingsWrapper)</returns>
        Task<ApiResponse<CustomColorThemesSettingsWrapper>> SavePortalColorThemeWithHttpInfoAsync(CustomColorThemesSettingsRequestsDto? customColorThemesSettingsRequestsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the AI access settings
        /// </summary>
        /// <remarks>
        /// Turns AI functionality (chat, agents, vectorization) on or off for the whole portal; AI is enabled by default.  Requires Owner or DocSpaceAdmin (the EditPortalSettings permission); every other caller is refused. Disabling  it immediately hides the AI Agents folder from root folder listings, makes AI status checks report disabled,  and makes AI chat endpoints unreachable for every user on the tenant, not only the caller. This is a mutating,  idempotent, portal-wide call, and the change is pushed to already-connected clients over the real-time  notification hub rather than waiting for their next request. It returns the saved setting.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAiAccessSettingsDto">Whether AI functionality is available on the portal. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-ai-access-settings/">REST API Reference for SetTenantAiAccessSettings Operation</seealso>
        /// <returns>Task of TenantAiAccessSettingsWrapper</returns>
        Task<TenantAiAccessSettingsWrapper> SetTenantAiAccessSettingsAsync(TenantAiAccessSettingsDto? tenantAiAccessSettingsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set the AI access settings
        /// </summary>
        /// <remarks>
        /// Turns AI functionality (chat, agents, vectorization) on or off for the whole portal; AI is enabled by default.  Requires Owner or DocSpaceAdmin (the EditPortalSettings permission); every other caller is refused. Disabling  it immediately hides the AI Agents folder from root folder listings, makes AI status checks report disabled,  and makes AI chat endpoints unreachable for every user on the tenant, not only the caller. This is a mutating,  idempotent, portal-wide call, and the change is pushed to already-connected clients over the real-time  notification hub rather than waiting for their next request. It returns the saved setting.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAiAccessSettingsDto">Whether AI functionality is available on the portal. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-ai-access-settings/">REST API Reference for SetTenantAiAccessSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantAiAccessSettingsWrapper)</returns>
        Task<ApiResponse<TenantAiAccessSettingsWrapper>> SetTenantAiAccessSettingsWithHttpInfoAsync(TenantAiAccessSettingsDto? tenantAiAccessSettingsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the email activation settings
        /// </summary>
        /// <remarks>
        /// Updates the current user's own preference for whether the email confirmation prompt is displayed on their  account. Requires an authenticated session; every role may change its own setting, and the change never  affects any other user. This is a mutating, idempotent call. It returns the settings exactly as submitted,  without validating them against the account's actual email confirmation state, so `show` can be set to `true`  even after the address is already confirmed.
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
        /// Updates the current user's own preference for whether the email confirmation prompt is displayed on their  account. Requires an authenticated session; every role may change its own setting, and the change never  affects any other user. This is a mutating, idempotent call. It returns the settings exactly as submitted,  without validating them against the account's actual email confirmation state, so `show` can be set to `true`  even after the address is already confirmed.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailActivationSettings">The email activation settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-email-activation-settings/">REST API Reference for UpdateEmailActivationSettings Operation</seealso>
        /// <returns>Task of ApiResponse (EmailActivationSettingsWrapper)</returns>
        Task<ApiResponse<EmailActivationSettingsWrapper>> UpdateEmailActivationSettingsWithHttpInfoAsync(EmailActivationSettings? emailActivationSettings = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the user invitation settings
        /// </summary>
        /// <remarks>
        /// Sets whether the portal allows inviting new members and new guests. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). Disabling member or guest invitations only blocks creating new invitations  going forward; it does not revoke links already issued or remove members already invited. This is a mutating,  idempotent, portal-wide call. It returns the saved setting; read the current value at any time, including  anonymously, from `GET api/2.0/settings/invitationsettings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto">Whether the portal still lets its members invite new members and new guests. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-settings/">REST API Reference for UpdateInvitationSettings Operation</seealso>
        /// <returns>Task of TenantUserInvitationSettingsWrapper</returns>
        Task<TenantUserInvitationSettingsWrapper> UpdateInvitationSettingsAsync(TenantUserInvitationSettingsRequestDto? tenantUserInvitationSettingsRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update the user invitation settings
        /// </summary>
        /// <remarks>
        /// Sets whether the portal allows inviting new members and new guests. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). Disabling member or guest invitations only blocks creating new invitations  going forward; it does not revoke links already issued or remove members already invited. This is a mutating,  idempotent, portal-wide call. It returns the saved setting; read the current value at any time, including  anonymously, from `GET api/2.0/settings/invitationsettings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto">Whether the portal still lets its members invite new members and new guests. (optional)</param>
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
        /// Dismisses the administrator helper tip for the caller, so it is not shown again on this account. Available  only to a DocSpace administrator, which includes the portal Owner, on a Standalone (self-hosted) installation  running outside white-label custom mode; every other caller is refused. This is a mutating, idempotent call  scoped to the calling account only; it never affects other administrators. It returns no data on success.
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
        /// Dismisses the administrator helper tip for the caller, so it is not shown again on this account. Available  only to a DocSpace administrator, which includes the portal Owner, on a Standalone (self-hosted) installation  running outside white-label custom mode; every other caller is refused. This is a mutating, idempotent call  scoped to the calling account only; it never affects other administrators. It returns no data on success.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/close-admin-helper/">REST API Reference for CloseAdminHelper Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CloseAdminHelperWithHttpInfo()
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
        /// Dismisses the administrator helper tip for the caller, so it is not shown again on this account. Available  only to a DocSpace administrator, which includes the portal Owner, on a Standalone (self-hosted) installation  running outside white-label custom mode; every other caller is refused. This is a mutating, idempotent call  scoped to the calling account only; it never affects other administrators. It returns no data on success.
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
        /// Dismisses the administrator helper tip for the caller, so it is not shown again on this account. Available  only to a DocSpace administrator, which includes the portal Owner, on a Standalone (self-hosted) installation  running outside white-label custom mode; every other caller is refused. This is a mutating, idempotent call  scoped to the calling account only; it never affects other administrators. It returns no data on success.
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
        /// Finishes the initial portal setup wizard: sets the owner's password and locale, applies the supplied license  if one is required, and marks the wizard as completed so it is not shown again. This call is not for a normal  logged-in session: it requires a confirmation link bearing the Wizard claim, of the kind issued when a new  portal is created, and the link is consumed as part of authenticating the request; the caller must also hold  the EditPortalSettings permission. An empty password or a malformed email address is rejected without  completing the wizard, and so is a missing, invalid, or expired license, or a license whose user quota does  not cover the portal. This call is meant to run once per portal; running it again is accepted but has no  further effect once the wizard is already completed. It returns the resulting wizard settings, including the  completed flag.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto">What the initial setup wizard needs to finish a new portal: the owner credentials and the portal locale. (optional)</param>
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
        /// Finishes the initial portal setup wizard: sets the owner's password and locale, applies the supplied license  if one is required, and marks the wizard as completed so it is not shown again. This call is not for a normal  logged-in session: it requires a confirmation link bearing the Wizard claim, of the kind issued when a new  portal is created, and the link is consumed as part of authenticating the request; the caller must also hold  the EditPortalSettings permission. An empty password or a malformed email address is rejected without  completing the wizard, and so is a missing, invalid, or expired license, or a license whose user quota does  not cover the portal. This call is meant to run once per portal; running it again is accepted but has no  further effect once the wizard is already completed. It returns the resulting wizard settings, including the  completed flag.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto">What the initial setup wizard needs to finish a new portal: the owner credentials and the portal locale. (optional)</param>
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
        /// Finishes the initial portal setup wizard: sets the owner's password and locale, applies the supplied license  if one is required, and marks the wizard as completed so it is not shown again. This call is not for a normal  logged-in session: it requires a confirmation link bearing the Wizard claim, of the kind issued when a new  portal is created, and the link is consumed as part of authenticating the request; the caller must also hold  the EditPortalSettings permission. An empty password or a malformed email address is rejected without  completing the wizard, and so is a missing, invalid, or expired license, or a license whose user quota does  not cover the portal. This call is meant to run once per portal; running it again is accepted but has no  further effect once the wizard is already completed. It returns the resulting wizard settings, including the  completed flag.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto">What the initial setup wizard needs to finish a new portal: the owner credentials and the portal locale. (optional)</param>
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
        /// Finishes the initial portal setup wizard: sets the owner's password and locale, applies the supplied license  if one is required, and marks the wizard as completed so it is not shown again. This call is not for a normal  logged-in session: it requires a confirmation link bearing the Wizard claim, of the kind issued when a new  portal is created, and the link is consumed as part of authenticating the request; the caller must also hold  the EditPortalSettings permission. An empty password or a malformed email address is rejected without  completing the wizard, and so is a missing, invalid, or expired license, or a license whose user quota does  not cover the portal. This call is meant to run once per portal; running it again is accepted but has no  further effect once the wizard is already completed. It returns the resulting wizard settings, including the  completed flag.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wizardRequestsDto">What the initial setup wizard needs to finish a new portal: the owner credentials and the portal locale. (optional)</param>
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
        /// Sets how the portal responds when a client opens a DocSpace link on a mobile device: always in the browser,  always in the native app, or asking the user to choose each time. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). The handling mode must be one of the documented enum values; anything else is  rejected without being saved. This is a mutating, idempotent call: sending the same mode again leaves the  setting unchanged. It returns the saved deep link settings, including the timestamp of the last change; read  the current value at any time, including anonymously, from `GET api/2.0/settings/deeplink`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto">How the portal opens its links on a mobile device. (optional)</param>
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
        /// Sets how the portal responds when a client opens a DocSpace link on a mobile device: always in the browser,  always in the native app, or asking the user to choose each time. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). The handling mode must be one of the documented enum values; anything else is  rejected without being saved. This is a mutating, idempotent call: sending the same mode again leaves the  setting unchanged. It returns the saved deep link settings, including the timestamp of the last change; read  the current value at any time, including anonymously, from `GET api/2.0/settings/deeplink`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto">How the portal opens its links on a mobile device. (optional)</param>
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
        /// Sets how the portal responds when a client opens a DocSpace link on a mobile device: always in the browser,  always in the native app, or asking the user to choose each time. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). The handling mode must be one of the documented enum values; anything else is  rejected without being saved. This is a mutating, idempotent call: sending the same mode again leaves the  setting unchanged. It returns the saved deep link settings, including the timestamp of the last change; read  the current value at any time, including anonymously, from `GET api/2.0/settings/deeplink`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto">How the portal opens its links on a mobile device. (optional)</param>
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
        /// Sets how the portal responds when a client opens a DocSpace link on a mobile device: always in the browser,  always in the native app, or asking the user to choose each time. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). The handling mode must be one of the documented enum values; anything else is  rejected without being saved. This is a mutating, idempotent call: sending the same mode again leaves the  setting unchanged. It returns the saved deep link settings, including the timestamp of the last change; read  the current value at any time, including anonymously, from `GET api/2.0/settings/deeplink`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deepLinkConfigurationRequestsDto">How the portal opens its links on a mobile device. (optional)</param>
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
        /// Removes a custom color theme from the portal by its ID. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). An ID belonging to one of the built-in default themes is not removable; the  call succeeds but leaves the theme list unchanged. If the deleted theme was the currently selected one, the  theme with the lowest remaining ID is selected automatically. This is a mutating, idempotent call: deleting an  ID that is already gone succeeds without error and again leaves nothing changed. It returns the full updated  theme configuration, including the (possibly new) selected theme.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The theme to remove, by theme ID. An ID belonging to a built-in theme leaves the list untouched, and so does  one that is already gone - neither is reported as an error. Removing the theme currently in use moves the  portal to the remaining theme with the lowest ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-portal-color-theme/">REST API Reference for DeletePortalColorTheme Operation</seealso>
        /// <returns>CustomColorThemesSettingsWrapper</returns>
        public CustomColorThemesSettingsWrapper DeletePortalColorTheme(int id)
        {
            var localVarResponse = DeletePortalColorThemeWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a color theme
        /// </summary>
        /// <remarks>
        /// Removes a custom color theme from the portal by its ID. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). An ID belonging to one of the built-in default themes is not removable; the  call succeeds but leaves the theme list unchanged. If the deleted theme was the currently selected one, the  theme with the lowest remaining ID is selected automatically. This is a mutating, idempotent call: deleting an  ID that is already gone succeeds without error and again leaves nothing changed. It returns the full updated  theme configuration, including the (possibly new) selected theme.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The theme to remove, by theme ID. An ID belonging to a built-in theme leaves the list untouched, and so does  one that is already gone - neither is reported as an error. Removing the theme currently in use moves the  portal to the remaining theme with the lowest ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-portal-color-theme/">REST API Reference for DeletePortalColorTheme Operation</seealso>
        /// <returns>ApiResponse of CustomColorThemesSettingsWrapper</returns>
        public ApiResponse<CustomColorThemesSettingsWrapper> DeletePortalColorThemeWithHttpInfo(int id)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "id", id));

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
        /// Removes a custom color theme from the portal by its ID. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). An ID belonging to one of the built-in default themes is not removable; the  call succeeds but leaves the theme list unchanged. If the deleted theme was the currently selected one, the  theme with the lowest remaining ID is selected automatically. This is a mutating, idempotent call: deleting an  ID that is already gone succeeds without error and again leaves nothing changed. It returns the full updated  theme configuration, including the (possibly new) selected theme.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The theme to remove, by theme ID. An ID belonging to a built-in theme leaves the list untouched, and so does  one that is already gone - neither is reported as an error. Removing the theme currently in use moves the  portal to the remaining theme with the lowest ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-portal-color-theme/">REST API Reference for DeletePortalColorTheme Operation</seealso>
        /// <returns>Task of CustomColorThemesSettingsWrapper</returns>
        public async Task<CustomColorThemesSettingsWrapper> DeletePortalColorThemeAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeletePortalColorThemeWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a color theme
        /// </summary>
        /// <remarks>
        /// Removes a custom color theme from the portal by its ID. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). An ID belonging to one of the built-in default themes is not removable; the  call succeeds but leaves the theme list unchanged. If the deleted theme was the currently selected one, the  theme with the lowest remaining ID is selected automatically. This is a mutating, idempotent call: deleting an  ID that is already gone succeeds without error and again leaves nothing changed. It returns the full updated  theme configuration, including the (possibly new) selected theme.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The theme to remove, by theme ID. An ID belonging to a built-in theme leaves the list untouched, and so does  one that is already gone - neither is reported as an error. Removing the theme currently in use moves the  portal to the remaining theme with the lowest ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-portal-color-theme/">REST API Reference for DeletePortalColorTheme Operation</seealso>
        /// <returns>Task of ApiResponse (CustomColorThemesSettingsWrapper)</returns>
        public async Task<ApiResponse<CustomColorThemesSettingsWrapper>> DeletePortalColorThemeWithHttpInfoAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "id", id));

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
        /// Returns how the portal currently responds when a client opens a DocSpace link on a mobile device: always in  the browser, always in the native app, or asking the user to choose. No permission is required; anonymous  callers can read it too. This is a read-only, idempotent call. The response supports conditional requests:  send the standard If-Modified-Since header with the previous `lastModified` value, and an unchanged response  comes back empty instead of resending the settings. Change the mode with `POST api/2.0/settings/deeplink`,  which requires the EditPortalSettings permission.
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
        /// Returns how the portal currently responds when a client opens a DocSpace link on a mobile device: always in  the browser, always in the native app, or asking the user to choose. No permission is required; anonymous  callers can read it too. This is a read-only, idempotent call. The response supports conditional requests:  send the standard If-Modified-Since header with the previous `lastModified` value, and an unchanged response  comes back empty instead of resending the settings. Change the mode with `POST api/2.0/settings/deeplink`,  which requires the EditPortalSettings permission.
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
        /// Returns how the portal currently responds when a client opens a DocSpace link on a mobile device: always in  the browser, always in the native app, or asking the user to choose. No permission is required; anonymous  callers can read it too. This is a read-only, idempotent call. The response supports conditional requests:  send the standard If-Modified-Since header with the previous `lastModified` value, and an unchanged response  comes back empty instead of resending the settings. Change the mode with `POST api/2.0/settings/deeplink`,  which requires the EditPortalSettings permission.
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
        /// Returns how the portal currently responds when a client opens a DocSpace link on a mobile device: always in  the browser, always in the native app, or asking the user to choose. No permission is required; anonymous  callers can read it too. This is a read-only, idempotent call. The response supports conditional requests:  send the standard If-Modified-Since header with the previous `lastModified` value, and an unchanged response  comes back empty instead of resending the settings. Change the mode with `POST api/2.0/settings/deeplink`,  which requires the EditPortalSettings permission.
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
        /// Returns the portal's payment-related configuration: the sales contact email, the URL to buy or extend a  subscription, whether the portal is Standalone, the current license's trial status and expiration date, and  the maximum quota quantity that can be purchased at once. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). This is a read-only, idempotent call. It remains reachable even while the  portal's own subscription payment is overdue, since this is how the caller finds the link to resolve it.
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
        /// Returns the portal's payment-related configuration: the sales contact email, the URL to buy or extend a  subscription, whether the portal is Standalone, the current license's trial status and expiration date, and  the maximum quota quantity that can be purchased at once. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). This is a read-only, idempotent call. It remains reachable even while the  portal's own subscription payment is overdue, since this is how the caller finds the link to resolve it.
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
        /// Returns the portal's payment-related configuration: the sales contact email, the URL to buy or extend a  subscription, whether the portal is Standalone, the current license's trial status and expiration date, and  the maximum quota quantity that can be purchased at once. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). This is a read-only, idempotent call. It remains reachable even while the  portal's own subscription payment is overdue, since this is how the caller finds the link to resolve it.
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
        /// Returns the portal's payment-related configuration: the sales contact email, the URL to buy or extend a  subscription, whether the portal is Standalone, the current license's trial status and expiration date, and  the maximum quota quantity that can be purchased at once. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). This is a read-only, idempotent call. It remains reachable even while the  portal's own subscription payment is overdue, since this is how the caller finds the link to resolve it.
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
        /// Returns the portal's color theme configuration: every saved custom theme, which one is currently selected, and  how many custom themes the plan still allows. No permission is required; anonymous callers can read it too.  This is a read-only, idempotent call. The response supports conditional requests: send the standard  If-Modified-Since header with the previous `lastModified` value, and an unchanged response comes back empty  instead of resending the same settings. A `limit` of `0` means the plan does not cap the number of custom  themes.
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
        /// Returns the portal's color theme configuration: every saved custom theme, which one is currently selected, and  how many custom themes the plan still allows. No permission is required; anonymous callers can read it too.  This is a read-only, idempotent call. The response supports conditional requests: send the standard  If-Modified-Since header with the previous `lastModified` value, and an unchanged response comes back empty  instead of resending the same settings. A `limit` of `0` means the plan does not cap the number of custom  themes.
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
        /// Returns the portal's color theme configuration: every saved custom theme, which one is currently selected, and  how many custom themes the plan still allows. No permission is required; anonymous callers can read it too.  This is a read-only, idempotent call. The response supports conditional requests: send the standard  If-Modified-Since header with the previous `lastModified` value, and an unchanged response comes back empty  instead of resending the same settings. A `limit` of `0` means the plan does not cap the number of custom  themes.
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
        /// Returns the portal's color theme configuration: every saved custom theme, which one is currently selected, and  how many custom themes the plan still allows. No permission is required; anonymous callers can read it too.  This is a read-only, idempotent call. The response supports conditional requests: send the standard  If-Modified-Since header with the previous `lastModified` value, and an unchanged response comes back empty  instead of resending the same settings. A `limit` of `0` means the plan does not cap the number of custom  themes.
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
        /// Get the portal hostname
        /// </summary>
        /// <remarks>
        /// Returns the hostname the current request arrived on, exactly as sent in the HTTP Host header, so a client  mid-setup can learn the address the portal is actually reachable at. This call is not for a normal logged-in  session: it requires a confirmation link bearing the Wizard claim, of the kind generated during initial portal  setup, and the link is consumed as part of authenticating the request. This is a read-only, idempotent call.  The value reflects whatever the caller connected through, including a reverse proxy's public name, and is not  necessarily the tenant's configured alias or mapped domain.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-hostname/">REST API Reference for GetPortalHostname Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper GetPortalHostname()
        {
            var localVarResponse = GetPortalHostnameWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the portal hostname
        /// </summary>
        /// <remarks>
        /// Returns the hostname the current request arrived on, exactly as sent in the HTTP Host header, so a client  mid-setup can learn the address the portal is actually reachable at. This call is not for a normal logged-in  session: it requires a confirmation link bearing the Wizard claim, of the kind generated during initial portal  setup, and the link is consumed as part of authenticating the request. This is a read-only, idempotent call.  The value reflects whatever the caller connected through, including a reverse proxy's public name, and is not  necessarily the tenant's configured alias or mapped domain.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-hostname/">REST API Reference for GetPortalHostname Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> GetPortalHostnameWithHttpInfo()
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
            var localVarResponse = Client.Get<StringWrapper>("/api/2.0/settings/machine", localVarRequestOptions, Configuration);

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
        /// Get the portal hostname
        /// </summary>
        /// <remarks>
        /// Returns the hostname the current request arrived on, exactly as sent in the HTTP Host header, so a client  mid-setup can learn the address the portal is actually reachable at. This call is not for a normal logged-in  session: it requires a confirmation link bearing the Wizard claim, of the kind generated during initial portal  setup, and the link is consumed as part of authenticating the request. This is a read-only, idempotent call.  The value reflects whatever the caller connected through, including a reverse proxy's public name, and is not  necessarily the tenant's configured alias or mapped domain.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-hostname/">REST API Reference for GetPortalHostname Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> GetPortalHostnameAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetPortalHostnameWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the portal hostname
        /// </summary>
        /// <remarks>
        /// Returns the hostname the current request arrived on, exactly as sent in the HTTP Host header, so a client  mid-setup can learn the address the portal is actually reachable at. This call is not for a normal logged-in  session: it requires a confirmation link bearing the Wizard claim, of the kind generated during initial portal  setup, and the link is consumed as part of authenticating the request. This is a read-only, idempotent call.  The value reflects whatever the caller connected through, including a reverse proxy's public name, and is not  necessarily the tenant's configured alias or mapped domain.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-hostname/">REST API Reference for GetPortalHostname Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async Task<ApiResponse<StringWrapper>> GetPortalHostnameWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<StringWrapper>("/api/2.0/settings/machine", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

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
        /// Returns the absolute URL of the portal's current logo image, already resolved against the active white-label  branding. Requires an authenticated session; every role, including Guest, can read it. This is a read-only,  idempotent call. The response supports conditional requests: send the standard If-Modified-Since header with  the previous `lastModified` value, and an unchanged response comes back empty instead of resending the same  URL. The URL points at whatever image is currently configured, including the default DocSpace logo when no  custom branding has been set.
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
        /// Returns the absolute URL of the portal's current logo image, already resolved against the active white-label  branding. Requires an authenticated session; every role, including Guest, can read it. This is a read-only,  idempotent call. The response supports conditional requests: send the standard If-Modified-Since header with  the previous `lastModified` value, and an unchanged response comes back empty instead of resending the same  URL. The URL points at whatever image is currently configured, including the default DocSpace logo when no  custom branding has been set.
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
        /// Returns the absolute URL of the portal's current logo image, already resolved against the active white-label  branding. Requires an authenticated session; every role, including Guest, can read it. This is a read-only,  idempotent call. The response supports conditional requests: send the standard If-Modified-Since header with  the previous `lastModified` value, and an unchanged response comes back empty instead of resending the same  URL. The URL points at whatever image is currently configured, including the default DocSpace logo when no  custom branding has been set.
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
        /// Returns the absolute URL of the portal's current logo image, already resolved against the active white-label  branding. Requires an authenticated session; every role, including Guest, can read it. This is a read-only,  idempotent call. The response supports conditional requests: send the standard If-Modified-Since header with  the previous `lastModified` value, and an unchanged response comes back empty instead of resending the same  URL. The URL points at whatever image is currently configured, including the default DocSpace logo when no  custom branding has been set.
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
        /// Returns the current portal's general configuration: branding, culture, feature flags, and DocSpace/Standalone  mode, everything the client needs to render its shell before or after login. No permission is required, but  the response shape depends on the caller's identity. An anonymous caller receives only the public subset  (culture, branding, DocSpace/Standalone flags, deep link data, setup-wizard and join-by-domain hints); once  authenticated, the response also includes tenant-specific fields such as the owner ID, time zone, invitation  limit, AI/banner/dev-tools flags, and, for a DocSpace administrator, the tenant wallet's low-balance flag.  This is a read-only, idempotent call. Pass `withPassword=true` to also receive the parameters (`salt`,  iteration count, hash size) used to hash the password client-side before it is sent to the authentication  endpoints; these are only added for an anonymous caller or when explicitly requested, never as part of the  default authenticated response.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withpassword">Whether the answer also carries the salt, iteration count and hash size a client needs to hash a password  before sending it to the authentication operations. They are included for an anonymous caller anyway; for a  signed-in one they are left out unless this is set. (optional)</param>
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
        /// Returns the current portal's general configuration: branding, culture, feature flags, and DocSpace/Standalone  mode, everything the client needs to render its shell before or after login. No permission is required, but  the response shape depends on the caller's identity. An anonymous caller receives only the public subset  (culture, branding, DocSpace/Standalone flags, deep link data, setup-wizard and join-by-domain hints); once  authenticated, the response also includes tenant-specific fields such as the owner ID, time zone, invitation  limit, AI/banner/dev-tools flags, and, for a DocSpace administrator, the tenant wallet's low-balance flag.  This is a read-only, idempotent call. Pass `withPassword=true` to also receive the parameters (`salt`,  iteration count, hash size) used to hash the password client-side before it is sent to the authentication  endpoints; these are only added for an anonymous caller or when explicitly requested, never as part of the  default authenticated response.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withpassword">Whether the answer also carries the salt, iteration count and hash size a client needs to hash a password  before sending it to the authentication operations. They are included for an anonymous caller anyway; for a  signed-in one they are left out unless this is set. (optional)</param>
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
        /// Returns the current portal's general configuration: branding, culture, feature flags, and DocSpace/Standalone  mode, everything the client needs to render its shell before or after login. No permission is required, but  the response shape depends on the caller's identity. An anonymous caller receives only the public subset  (culture, branding, DocSpace/Standalone flags, deep link data, setup-wizard and join-by-domain hints); once  authenticated, the response also includes tenant-specific fields such as the owner ID, time zone, invitation  limit, AI/banner/dev-tools flags, and, for a DocSpace administrator, the tenant wallet's low-balance flag.  This is a read-only, idempotent call. Pass `withPassword=true` to also receive the parameters (`salt`,  iteration count, hash size) used to hash the password client-side before it is sent to the authentication  endpoints; these are only added for an anonymous caller or when explicitly requested, never as part of the  default authenticated response.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withpassword">Whether the answer also carries the salt, iteration count and hash size a client needs to hash a password  before sending it to the authentication operations. They are included for an anonymous caller anyway; for a  signed-in one they are left out unless this is set. (optional)</param>
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
        /// Returns the current portal's general configuration: branding, culture, feature flags, and DocSpace/Standalone  mode, everything the client needs to render its shell before or after login. No permission is required, but  the response shape depends on the caller's identity. An anonymous caller receives only the public subset  (culture, branding, DocSpace/Standalone flags, deep link data, setup-wizard and join-by-domain hints); once  authenticated, the response also includes tenant-specific fields such as the owner ID, time zone, invitation  limit, AI/banner/dev-tools flags, and, for a DocSpace administrator, the tenant wallet's low-balance flag.  This is a read-only, idempotent call. Pass `withPassword=true` to also receive the parameters (`salt`,  iteration count, hash size) used to hash the password client-side before it is sent to the authentication  endpoints; these are only added for an anonymous caller or when explicitly requested, never as part of the  default authenticated response.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="withpassword">Whether the answer also carries the salt, iteration count and hash size a client needs to hash a password  before sending it to the authentication operations. They are included for an anonymous caller anyway; for a  signed-in one they are left out unless this is set. (optional)</param>
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
        /// Returns the base URL of the portal's real-time notification hub (Socket.IO), which the client connects to for  live updates such as file changes, presence, or quota alerts. Requires an authenticated session; every role  can read it. This is a read-only, idempotent call. The value comes from server-side configuration and cannot  be changed through this API; an empty `url` means the portal has no notification hub configured and the client  should not attempt to connect.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-socket-settings/">REST API Reference for GetSocketSettings Operation</seealso>
        /// <returns>SocketSettingsWrapper</returns>
        public SocketSettingsWrapper GetSocketSettings()
        {
            var localVarResponse = GetSocketSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the socket settings
        /// </summary>
        /// <remarks>
        /// Returns the base URL of the portal's real-time notification hub (Socket.IO), which the client connects to for  live updates such as file changes, presence, or quota alerts. Requires an authenticated session; every role  can read it. This is a read-only, idempotent call. The value comes from server-side configuration and cannot  be changed through this API; an empty `url` means the portal has no notification hub configured and the client  should not attempt to connect.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-socket-settings/">REST API Reference for GetSocketSettings Operation</seealso>
        /// <returns>ApiResponse of SocketSettingsWrapper</returns>
        public ApiResponse<SocketSettingsWrapper> GetSocketSettingsWithHttpInfo()
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
            var localVarResponse = Client.Get<SocketSettingsWrapper>("/api/2.0/settings/socket", localVarRequestOptions, Configuration);

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
        /// Returns the base URL of the portal's real-time notification hub (Socket.IO), which the client connects to for  live updates such as file changes, presence, or quota alerts. Requires an authenticated session; every role  can read it. This is a read-only, idempotent call. The value comes from server-side configuration and cannot  be changed through this API; an empty `url` means the portal has no notification hub configured and the client  should not attempt to connect.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-socket-settings/">REST API Reference for GetSocketSettings Operation</seealso>
        /// <returns>Task of SocketSettingsWrapper</returns>
        public async Task<SocketSettingsWrapper> GetSocketSettingsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetSocketSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the socket settings
        /// </summary>
        /// <remarks>
        /// Returns the base URL of the portal's real-time notification hub (Socket.IO), which the client connects to for  live updates such as file changes, presence, or quota alerts. Requires an authenticated session; every role  can read it. This is a read-only, idempotent call. The value comes from server-side configuration and cannot  be changed through this API; an empty `url` means the portal has no notification hub configured and the client  should not attempt to connect.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-socket-settings/">REST API Reference for GetSocketSettings Operation</seealso>
        /// <returns>Task of ApiResponse (SocketSettingsWrapper)</returns>
        public async Task<ApiResponse<SocketSettingsWrapper>> GetSocketSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<SocketSettingsWrapper>("/api/2.0/settings/socket", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

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
        /// Returns the two- or four-letter language codes of every culture currently enabled on the portal (for example  `en-US`), used to populate a language picker before or after login. No permission is required; anonymous  callers can read it too. This is a read-only, idempotent call, and the list is not paginated. The response  supports conditional requests: an unchanged result is signaled instead of resending the same list. The set of  enabled cultures is a portal-wide configuration value, not a per-user preference.
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
        /// Returns the two- or four-letter language codes of every culture currently enabled on the portal (for example  `en-US`), used to populate a language picker before or after login. No permission is required; anonymous  callers can read it too. This is a read-only, idempotent call, and the list is not paginated. The response  supports conditional requests: an unchanged result is signaled instead of resending the same list. The set of  enabled cultures is a portal-wide configuration value, not a per-user preference.
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
        /// Returns the two- or four-letter language codes of every culture currently enabled on the portal (for example  `en-US`), used to populate a language picker before or after login. No permission is required; anonymous  callers can read it too. This is a read-only, idempotent call, and the list is not paginated. The response  supports conditional requests: an unchanged result is signaled instead of resending the same list. The set of  enabled cultures is a portal-wide configuration value, not a per-user preference.
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
        /// Returns the two- or four-letter language codes of every culture currently enabled on the portal (for example  `en-US`), used to populate a language picker before or after login. No permission is required; anonymous  callers can read it too. This is a read-only, idempotent call, and the list is not paginated. The response  supports conditional requests: an unchanged result is signaled instead of resending the same list. The set of  enabled cultures is a portal-wide configuration value, not a per-user preference.
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
        /// Get the AI access settings
        /// </summary>
        /// <remarks>
        /// Returns whether AI functionality (chat, agents, vectorization) is currently available on the portal at all; AI  is enabled by default. Requires an authenticated session; every role can read it. This is a read-only,  idempotent call. When the setting is disabled, every AI-specific endpoint and folder is unavailable regardless  of the caller's own permissions; this call only reports the portal-wide switch, not any per-user entitlement.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-ai-access-settings/">REST API Reference for GetTenantAiAccessSettings Operation</seealso>
        /// <returns>TenantAiAccessSettingsWrapper</returns>
        public TenantAiAccessSettingsWrapper GetTenantAiAccessSettings()
        {
            var localVarResponse = GetTenantAiAccessSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the AI access settings
        /// </summary>
        /// <remarks>
        /// Returns whether AI functionality (chat, agents, vectorization) is currently available on the portal at all; AI  is enabled by default. Requires an authenticated session; every role can read it. This is a read-only,  idempotent call. When the setting is disabled, every AI-specific endpoint and folder is unavailable regardless  of the caller's own permissions; this call only reports the portal-wide switch, not any per-user entitlement.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-ai-access-settings/">REST API Reference for GetTenantAiAccessSettings Operation</seealso>
        /// <returns>ApiResponse of TenantAiAccessSettingsWrapper</returns>
        public ApiResponse<TenantAiAccessSettingsWrapper> GetTenantAiAccessSettingsWithHttpInfo()
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
            var localVarResponse = Client.Get<TenantAiAccessSettingsWrapper>("/api/2.0/settings/ai-access", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetTenantAiAccessSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the AI access settings
        /// </summary>
        /// <remarks>
        /// Returns whether AI functionality (chat, agents, vectorization) is currently available on the portal at all; AI  is enabled by default. Requires an authenticated session; every role can read it. This is a read-only,  idempotent call. When the setting is disabled, every AI-specific endpoint and folder is unavailable regardless  of the caller's own permissions; this call only reports the portal-wide switch, not any per-user entitlement.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-ai-access-settings/">REST API Reference for GetTenantAiAccessSettings Operation</seealso>
        /// <returns>Task of TenantAiAccessSettingsWrapper</returns>
        public async Task<TenantAiAccessSettingsWrapper> GetTenantAiAccessSettingsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetTenantAiAccessSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the AI access settings
        /// </summary>
        /// <remarks>
        /// Returns whether AI functionality (chat, agents, vectorization) is currently available on the portal at all; AI  is enabled by default. Requires an authenticated session; every role can read it. This is a read-only,  idempotent call. When the setting is disabled, every AI-specific endpoint and folder is unavailable regardless  of the caller's own permissions; this call only reports the portal-wide switch, not any per-user entitlement.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-ai-access-settings/">REST API Reference for GetTenantAiAccessSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantAiAccessSettingsWrapper)</returns>
        public async Task<ApiResponse<TenantAiAccessSettingsWrapper>> GetTenantAiAccessSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<TenantAiAccessSettingsWrapper>("/api/2.0/settings/ai-access", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetTenantAiAccessSettings", localVarResponse);
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
        /// Returns whether the portal currently allows inviting new members and new guests at all. No permission is  required; anonymous callers can read it too, since the invitation flow itself may run before the caller has  signed in. This is a read-only, idempotent call. The response supports conditional requests: send the standard  If-Modified-Since header with the previous `lastModified` value, and an unchanged response comes back empty  instead of resending the same settings.
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
        /// Returns whether the portal currently allows inviting new members and new guests at all. No permission is  required; anonymous callers can read it too, since the invitation flow itself may run before the caller has  signed in. This is a read-only, idempotent call. The response supports conditional requests: send the standard  If-Modified-Since header with the previous `lastModified` value, and an unchanged response comes back empty  instead of resending the same settings.
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
        /// Returns whether the portal currently allows inviting new members and new guests at all. No permission is  required; anonymous callers can read it too, since the invitation flow itself may run before the caller has  signed in. This is a read-only, idempotent call. The response supports conditional requests: send the standard  If-Modified-Since header with the previous `lastModified` value, and an unchanged response comes back empty  instead of resending the same settings.
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
        /// Returns whether the portal currently allows inviting new members and new guests at all. No permission is  required; anonymous callers can read it too, since the invitation flow itself may run before the caller has  signed in. This is a read-only, idempotent call. The response supports conditional requests: send the standard  If-Modified-Since header with the previous `lastModified` value, and an unchanged response comes back empty  instead of resending the same settings.
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
        /// Returns every time zone known to the host machine, each with its IANA identifier and a human-readable display  name, ordered from the most negative to the most positive UTC offset. This call is not for a normal logged-in  session: it requires a confirmation link bearing the Wizard or Administrators claim, of the kind generated  during initial portal setup or issued by an administrator, and the link is consumed as part of authenticating  the request. This is a read-only, idempotent call, and the list is not paginated. Use the returned `id` values  wherever the portal expects a time zone identifier; an unrecognized value is rejected there, not here.
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
        /// Returns every time zone known to the host machine, each with its IANA identifier and a human-readable display  name, ordered from the most negative to the most positive UTC offset. This call is not for a normal logged-in  session: it requires a confirmation link bearing the Wizard or Administrators claim, of the kind generated  during initial portal setup or issued by an administrator, and the link is consumed as part of authenticating  the request. This is a read-only, idempotent call, and the list is not paginated. Use the returned `id` values  wherever the portal expects a time zone identifier; an unrecognized value is rejected there, not here.
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
        /// Returns every time zone known to the host machine, each with its IANA identifier and a human-readable display  name, ordered from the most negative to the most positive UTC offset. This call is not for a normal logged-in  session: it requires a confirmation link bearing the Wizard or Administrators claim, of the kind generated  during initial portal setup or issued by an administrator, and the link is consumed as part of authenticating  the request. This is a read-only, idempotent call, and the list is not paginated. Use the returned `id` values  wherever the portal expects a time zone identifier; an unrecognized value is rejected there, not here.
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
        /// Returns every time zone known to the host machine, each with its IANA identifier and a human-readable display  name, ordered from the most negative to the most positive UTC offset. This call is not for a normal logged-in  session: it requires a confirmation link bearing the Wizard or Administrators claim, of the kind generated  during initial portal setup or issued by an administrator, and the link is consumed as part of authenticating  the request. This is a read-only, idempotent call, and the list is not paginated. Use the returned `id` values  wherever the portal expects a time zone identifier; an unrecognized value is rejected there, not here.
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
        /// Set the default folder
        /// </summary>
        /// <remarks>
        /// Sets which folder the current user's account opens into by default, such as My Documents, the rooms list, or  favorites. Requires an authenticated session; every role may set its own default, and the change never affects  any other user. Only folder types the client actually offers as a landing page are accepted; picking My  Documents (`USER`) as a Guest is rejected too, since guests have no personal storage. This is a mutating,  idempotent call. It returns the saved setting.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="defaultProductRequestDto">The section the calling user's account opens into after signing in. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-default-folder/">REST API Reference for SaveDefaultFolder Operation</seealso>
        /// <returns>StudioDefaultPageSettingsWrapper</returns>
        public StudioDefaultPageSettingsWrapper SaveDefaultFolder(DefaultProductRequestDto? defaultProductRequestDto = default)
        {
            var localVarResponse = SaveDefaultFolderWithHttpInfo(defaultProductRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the default folder
        /// </summary>
        /// <remarks>
        /// Sets which folder the current user's account opens into by default, such as My Documents, the rooms list, or  favorites. Requires an authenticated session; every role may set its own default, and the change never affects  any other user. Only folder types the client actually offers as a landing page are accepted; picking My  Documents (`USER`) as a Guest is rejected too, since guests have no personal storage. This is a mutating,  idempotent call. It returns the saved setting.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="defaultProductRequestDto">The section the calling user's account opens into after signing in. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-default-folder/">REST API Reference for SaveDefaultFolder Operation</seealso>
        /// <returns>ApiResponse of StudioDefaultPageSettingsWrapper</returns>
        public ApiResponse<StudioDefaultPageSettingsWrapper> SaveDefaultFolderWithHttpInfo(DefaultProductRequestDto? defaultProductRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (defaultProductRequestDto != null) localVarRequestOptions.Data = defaultProductRequestDto;

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
            var localVarResponse = Client.Put<StudioDefaultPageSettingsWrapper>("/api/2.0/settings/defaultfolder", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SaveDefaultFolder", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the default folder
        /// </summary>
        /// <remarks>
        /// Sets which folder the current user's account opens into by default, such as My Documents, the rooms list, or  favorites. Requires an authenticated session; every role may set its own default, and the change never affects  any other user. Only folder types the client actually offers as a landing page are accepted; picking My  Documents (`USER`) as a Guest is rejected too, since guests have no personal storage. This is a mutating,  idempotent call. It returns the saved setting.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="defaultProductRequestDto">The section the calling user's account opens into after signing in. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-default-folder/">REST API Reference for SaveDefaultFolder Operation</seealso>
        /// <returns>Task of StudioDefaultPageSettingsWrapper</returns>
        public async Task<StudioDefaultPageSettingsWrapper> SaveDefaultFolderAsync(DefaultProductRequestDto? defaultProductRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SaveDefaultFolderWithHttpInfoAsync(defaultProductRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the default folder
        /// </summary>
        /// <remarks>
        /// Sets which folder the current user's account opens into by default, such as My Documents, the rooms list, or  favorites. Requires an authenticated session; every role may set its own default, and the change never affects  any other user. Only folder types the client actually offers as a landing page are accepted; picking My  Documents (`USER`) as a Guest is rejected too, since guests have no personal storage. This is a mutating,  idempotent call. It returns the saved setting.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="defaultProductRequestDto">The section the calling user's account opens into after signing in. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-default-folder/">REST API Reference for SaveDefaultFolder Operation</seealso>
        /// <returns>Task of ApiResponse (StudioDefaultPageSettingsWrapper)</returns>
        public async Task<ApiResponse<StudioDefaultPageSettingsWrapper>> SaveDefaultFolderWithHttpInfoAsync(DefaultProductRequestDto? defaultProductRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (defaultProductRequestDto != null) localVarRequestOptions.Data = defaultProductRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<StudioDefaultPageSettingsWrapper>("/api/2.0/settings/defaultfolder", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SaveDefaultFolder", localVarResponse);
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
        /// Maps a custom domain name onto the current tenant, or clears the mapping, so the portal becomes reachable  under the caller's own DNS name instead of only its default alias. Available only on a Standalone  (self-hosted) installation; on SaaS the call is always refused. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). Disable the mapping by passing `enable=false`, in which case the domain name  in the request is ignored. A domain that collides with the portal's reserved base domain, or otherwise fails  validation, is rejected without changing the current mapping. This is a mutating, idempotent call. On success  the previous domain also stops answering, and any CSP configuration referencing it is updated to the new one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto">The custom domain the portal answers on, and whether that mapping is in force. (optional)</param>
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
        /// Maps a custom domain name onto the current tenant, or clears the mapping, so the portal becomes reachable  under the caller's own DNS name instead of only its default alias. Available only on a Standalone  (self-hosted) installation; on SaaS the call is always refused. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). Disable the mapping by passing `enable=false`, in which case the domain name  in the request is ignored. A domain that collides with the portal's reserved base domain, or otherwise fails  validation, is rejected without changing the current mapping. This is a mutating, idempotent call. On success  the previous domain also stops answering, and any CSP configuration referencing it is updated to the new one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto">The custom domain the portal answers on, and whether that mapping is in force. (optional)</param>
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
        /// Maps a custom domain name onto the current tenant, or clears the mapping, so the portal becomes reachable  under the caller's own DNS name instead of only its default alias. Available only on a Standalone  (self-hosted) installation; on SaaS the call is always refused. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). Disable the mapping by passing `enable=false`, in which case the domain name  in the request is ignored. A domain that collides with the portal's reserved base domain, or otherwise fails  validation, is rejected without changing the current mapping. This is a mutating, idempotent call. On success  the previous domain also stops answering, and any CSP configuration referencing it is updated to the new one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto">The custom domain the portal answers on, and whether that mapping is in force. (optional)</param>
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
        /// Maps a custom domain name onto the current tenant, or clears the mapping, so the portal becomes reachable  under the caller's own DNS name instead of only its default alias. Available only on a Standalone  (self-hosted) installation; on SaaS the call is always refused. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). Disable the mapping by passing `enable=false`, in which case the domain name  in the request is ignored. A domain that collides with the portal's reserved base domain, or otherwise fails  validation, is rejected without changing the current mapping. This is a mutating, idempotent call. On success  the previous domain also stops answering, and any CSP configuration referencing it is updated to the new one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsSettingsRequestsDto">The custom domain the portal answers on, and whether that mapping is in force. (optional)</param>
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
        /// Overwrites the portal's trusted mail domain configuration, which controls which email domains are treated as  already verified when a user is invited or self-registers. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). When the requested mode is a custom domain list, every domain is normalized to  lowercase and checked against the expected hostname format; a domain that fails the check, or an empty custom  list, causes the whole call to be rejected without saving anything. For the other modes the domain list in the  request is ignored. The `inviteUsersAsVisitors` flag controls whether users who join through a trusted domain  are added as full members or as visitors, and takes effect on the next join rather than retroactively. This is  a mutating, idempotent call: repeating it with the same body leaves the portal in the same state. On success  it returns a confirmation message, not the saved settings themselves; read them back from  `GET api/2.0/settings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto">Which email domains the portal treats as already verified, and how their users join. (optional)</param>
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
        /// Overwrites the portal's trusted mail domain configuration, which controls which email domains are treated as  already verified when a user is invited or self-registers. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). When the requested mode is a custom domain list, every domain is normalized to  lowercase and checked against the expected hostname format; a domain that fails the check, or an empty custom  list, causes the whole call to be rejected without saving anything. For the other modes the domain list in the  request is ignored. The `inviteUsersAsVisitors` flag controls whether users who join through a trusted domain  are added as full members or as visitors, and takes effect on the next join rather than retroactively. This is  a mutating, idempotent call: repeating it with the same body leaves the portal in the same state. On success  it returns a confirmation message, not the saved settings themselves; read them back from  `GET api/2.0/settings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto">Which email domains the portal treats as already verified, and how their users join. (optional)</param>
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
        /// Overwrites the portal's trusted mail domain configuration, which controls which email domains are treated as  already verified when a user is invited or self-registers. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). When the requested mode is a custom domain list, every domain is normalized to  lowercase and checked against the expected hostname format; a domain that fails the check, or an empty custom  list, causes the whole call to be rejected without saving anything. For the other modes the domain list in the  request is ignored. The `inviteUsersAsVisitors` flag controls whether users who join through a trusted domain  are added as full members or as visitors, and takes effect on the next join rather than retroactively. This is  a mutating, idempotent call: repeating it with the same body leaves the portal in the same state. On success  it returns a confirmation message, not the saved settings themselves; read them back from  `GET api/2.0/settings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto">Which email domains the portal treats as already verified, and how their users join. (optional)</param>
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
        /// Overwrites the portal's trusted mail domain configuration, which controls which email domains are treated as  already verified when a user is invited or self-registers. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). When the requested mode is a custom domain list, every domain is normalized to  lowercase and checked against the expected hostname format; a domain that fails the check, or an empty custom  list, causes the whole call to be rejected without saving anything. For the other modes the domain list in the  request is ignored. The `inviteUsersAsVisitors` flag controls whether users who join through a trusted domain  are added as full members or as visitors, and takes effect on the next join rather than retroactively. This is  a mutating, idempotent call: repeating it with the same body leaves the portal in the same state. On success  it returns a confirmation message, not the saved settings themselves; read them back from  `GET api/2.0/settings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mailDomainSettingsRequestsDto">Which email domains the portal treats as already verified, and how their users join. (optional)</param>
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
        /// Adds or updates a custom color theme, or changes which theme is selected, for the whole portal. Requires Owner  or DocSpaceAdmin (the EditPortalSettings permission). Pass `theme` to create or edit one: an existing theme is  matched and updated by its ID, a new one is appended, and an ID that collides with a built-in default theme is  treated as a request to create a new custom theme instead of overwriting the default. Once the plan's  custom-theme limit is reached, a new theme is silently not added rather than rejected with an error, so check  the returned `themes` count against `limit` before assuming it was saved. Pass `selected` to switch the active  theme; an ID that does not match any existing theme is ignored. This is a mutating call, not strictly  idempotent once the limit has been reached. It returns the full updated theme configuration.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto">The custom colour theme being saved, the theme being selected, or both. (optional)</param>
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
        /// Adds or updates a custom color theme, or changes which theme is selected, for the whole portal. Requires Owner  or DocSpaceAdmin (the EditPortalSettings permission). Pass `theme` to create or edit one: an existing theme is  matched and updated by its ID, a new one is appended, and an ID that collides with a built-in default theme is  treated as a request to create a new custom theme instead of overwriting the default. Once the plan's  custom-theme limit is reached, a new theme is silently not added rather than rejected with an error, so check  the returned `themes` count against `limit` before assuming it was saved. Pass `selected` to switch the active  theme; an ID that does not match any existing theme is ignored. This is a mutating call, not strictly  idempotent once the limit has been reached. It returns the full updated theme configuration.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto">The custom colour theme being saved, the theme being selected, or both. (optional)</param>
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
        /// Adds or updates a custom color theme, or changes which theme is selected, for the whole portal. Requires Owner  or DocSpaceAdmin (the EditPortalSettings permission). Pass `theme` to create or edit one: an existing theme is  matched and updated by its ID, a new one is appended, and an ID that collides with a built-in default theme is  treated as a request to create a new custom theme instead of overwriting the default. Once the plan's  custom-theme limit is reached, a new theme is silently not added rather than rejected with an error, so check  the returned `themes` count against `limit` before assuming it was saved. Pass `selected` to switch the active  theme; an ID that does not match any existing theme is ignored. This is a mutating call, not strictly  idempotent once the limit has been reached. It returns the full updated theme configuration.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto">The custom colour theme being saved, the theme being selected, or both. (optional)</param>
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
        /// Adds or updates a custom color theme, or changes which theme is selected, for the whole portal. Requires Owner  or DocSpaceAdmin (the EditPortalSettings permission). Pass `theme` to create or edit one: an existing theme is  matched and updated by its ID, a new one is appended, and an ID that collides with a built-in default theme is  treated as a request to create a new custom theme instead of overwriting the default. Once the plan's  custom-theme limit is reached, a new theme is silently not added rather than rejected with an error, so check  the returned `themes` count against `limit` before assuming it was saved. Pass `selected` to switch the active  theme; an ID that does not match any existing theme is ignored. This is a mutating call, not strictly  idempotent once the limit has been reached. It returns the full updated theme configuration.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customColorThemesSettingsRequestsDto">The custom colour theme being saved, the theme being selected, or both. (optional)</param>
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
        /// Set the AI access settings
        /// </summary>
        /// <remarks>
        /// Turns AI functionality (chat, agents, vectorization) on or off for the whole portal; AI is enabled by default.  Requires Owner or DocSpaceAdmin (the EditPortalSettings permission); every other caller is refused. Disabling  it immediately hides the AI Agents folder from root folder listings, makes AI status checks report disabled,  and makes AI chat endpoints unreachable for every user on the tenant, not only the caller. This is a mutating,  idempotent, portal-wide call, and the change is pushed to already-connected clients over the real-time  notification hub rather than waiting for their next request. It returns the saved setting.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAiAccessSettingsDto">Whether AI functionality is available on the portal. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-ai-access-settings/">REST API Reference for SetTenantAiAccessSettings Operation</seealso>
        /// <returns>TenantAiAccessSettingsWrapper</returns>
        public TenantAiAccessSettingsWrapper SetTenantAiAccessSettings(TenantAiAccessSettingsDto? tenantAiAccessSettingsDto = default)
        {
            var localVarResponse = SetTenantAiAccessSettingsWithHttpInfo(tenantAiAccessSettingsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the AI access settings
        /// </summary>
        /// <remarks>
        /// Turns AI functionality (chat, agents, vectorization) on or off for the whole portal; AI is enabled by default.  Requires Owner or DocSpaceAdmin (the EditPortalSettings permission); every other caller is refused. Disabling  it immediately hides the AI Agents folder from root folder listings, makes AI status checks report disabled,  and makes AI chat endpoints unreachable for every user on the tenant, not only the caller. This is a mutating,  idempotent, portal-wide call, and the change is pushed to already-connected clients over the real-time  notification hub rather than waiting for their next request. It returns the saved setting.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAiAccessSettingsDto">Whether AI functionality is available on the portal. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-ai-access-settings/">REST API Reference for SetTenantAiAccessSettings Operation</seealso>
        /// <returns>ApiResponse of TenantAiAccessSettingsWrapper</returns>
        public ApiResponse<TenantAiAccessSettingsWrapper> SetTenantAiAccessSettingsWithHttpInfo(TenantAiAccessSettingsDto? tenantAiAccessSettingsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (tenantAiAccessSettingsDto != null) localVarRequestOptions.Data = tenantAiAccessSettingsDto;

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
            var localVarResponse = Client.Post<TenantAiAccessSettingsWrapper>("/api/2.0/settings/ai-access", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetTenantAiAccessSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the AI access settings
        /// </summary>
        /// <remarks>
        /// Turns AI functionality (chat, agents, vectorization) on or off for the whole portal; AI is enabled by default.  Requires Owner or DocSpaceAdmin (the EditPortalSettings permission); every other caller is refused. Disabling  it immediately hides the AI Agents folder from root folder listings, makes AI status checks report disabled,  and makes AI chat endpoints unreachable for every user on the tenant, not only the caller. This is a mutating,  idempotent, portal-wide call, and the change is pushed to already-connected clients over the real-time  notification hub rather than waiting for their next request. It returns the saved setting.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAiAccessSettingsDto">Whether AI functionality is available on the portal. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-ai-access-settings/">REST API Reference for SetTenantAiAccessSettings Operation</seealso>
        /// <returns>Task of TenantAiAccessSettingsWrapper</returns>
        public async Task<TenantAiAccessSettingsWrapper> SetTenantAiAccessSettingsAsync(TenantAiAccessSettingsDto? tenantAiAccessSettingsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetTenantAiAccessSettingsWithHttpInfoAsync(tenantAiAccessSettingsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the AI access settings
        /// </summary>
        /// <remarks>
        /// Turns AI functionality (chat, agents, vectorization) on or off for the whole portal; AI is enabled by default.  Requires Owner or DocSpaceAdmin (the EditPortalSettings permission); every other caller is refused. Disabling  it immediately hides the AI Agents folder from root folder listings, makes AI status checks report disabled,  and makes AI chat endpoints unreachable for every user on the tenant, not only the caller. This is a mutating,  idempotent, portal-wide call, and the change is pushed to already-connected clients over the real-time  notification hub rather than waiting for their next request. It returns the saved setting.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAiAccessSettingsDto">Whether AI functionality is available on the portal. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tenant-ai-access-settings/">REST API Reference for SetTenantAiAccessSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantAiAccessSettingsWrapper)</returns>
        public async Task<ApiResponse<TenantAiAccessSettingsWrapper>> SetTenantAiAccessSettingsWithHttpInfoAsync(TenantAiAccessSettingsDto? tenantAiAccessSettingsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (tenantAiAccessSettingsDto != null) localVarRequestOptions.Data = tenantAiAccessSettingsDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<TenantAiAccessSettingsWrapper>("/api/2.0/settings/ai-access", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetTenantAiAccessSettings", localVarResponse);
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
        /// Updates the current user's own preference for whether the email confirmation prompt is displayed on their  account. Requires an authenticated session; every role may change its own setting, and the change never  affects any other user. This is a mutating, idempotent call. It returns the settings exactly as submitted,  without validating them against the account's actual email confirmation state, so `show` can be set to `true`  even after the address is already confirmed.
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
        /// Updates the current user's own preference for whether the email confirmation prompt is displayed on their  account. Requires an authenticated session; every role may change its own setting, and the change never  affects any other user. This is a mutating, idempotent call. It returns the settings exactly as submitted,  without validating them against the account's actual email confirmation state, so `show` can be set to `true`  even after the address is already confirmed.
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
        /// Updates the current user's own preference for whether the email confirmation prompt is displayed on their  account. Requires an authenticated session; every role may change its own setting, and the change never  affects any other user. This is a mutating, idempotent call. It returns the settings exactly as submitted,  without validating them against the account's actual email confirmation state, so `show` can be set to `true`  even after the address is already confirmed.
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
        /// Updates the current user's own preference for whether the email confirmation prompt is displayed on their  account. Requires an authenticated session; every role may change its own setting, and the change never  affects any other user. This is a mutating, idempotent call. It returns the settings exactly as submitted,  without validating them against the account's actual email confirmation state, so `show` can be set to `true`  even after the address is already confirmed.
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
        /// Update the user invitation settings
        /// </summary>
        /// <remarks>
        /// Sets whether the portal allows inviting new members and new guests. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). Disabling member or guest invitations only blocks creating new invitations  going forward; it does not revoke links already issued or remove members already invited. This is a mutating,  idempotent, portal-wide call. It returns the saved setting; read the current value at any time, including  anonymously, from `GET api/2.0/settings/invitationsettings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto">Whether the portal still lets its members invite new members and new guests. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-settings/">REST API Reference for UpdateInvitationSettings Operation</seealso>
        /// <returns>TenantUserInvitationSettingsWrapper</returns>
        public TenantUserInvitationSettingsWrapper UpdateInvitationSettings(TenantUserInvitationSettingsRequestDto? tenantUserInvitationSettingsRequestDto = default)
        {
            var localVarResponse = UpdateInvitationSettingsWithHttpInfo(tenantUserInvitationSettingsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update the user invitation settings
        /// </summary>
        /// <remarks>
        /// Sets whether the portal allows inviting new members and new guests. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). Disabling member or guest invitations only blocks creating new invitations  going forward; it does not revoke links already issued or remove members already invited. This is a mutating,  idempotent, portal-wide call. It returns the saved setting; read the current value at any time, including  anonymously, from `GET api/2.0/settings/invitationsettings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto">Whether the portal still lets its members invite new members and new guests. (optional)</param>
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
        /// Update the user invitation settings
        /// </summary>
        /// <remarks>
        /// Sets whether the portal allows inviting new members and new guests. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). Disabling member or guest invitations only blocks creating new invitations  going forward; it does not revoke links already issued or remove members already invited. This is a mutating,  idempotent, portal-wide call. It returns the saved setting; read the current value at any time, including  anonymously, from `GET api/2.0/settings/invitationsettings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto">Whether the portal still lets its members invite new members and new guests. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-invitation-settings/">REST API Reference for UpdateInvitationSettings Operation</seealso>
        /// <returns>Task of TenantUserInvitationSettingsWrapper</returns>
        public async Task<TenantUserInvitationSettingsWrapper> UpdateInvitationSettingsAsync(TenantUserInvitationSettingsRequestDto? tenantUserInvitationSettingsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateInvitationSettingsWithHttpInfoAsync(tenantUserInvitationSettingsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update the user invitation settings
        /// </summary>
        /// <remarks>
        /// Sets whether the portal allows inviting new members and new guests. Requires Owner or DocSpaceAdmin (the  EditPortalSettings permission). Disabling member or guest invitations only blocks creating new invitations  going forward; it does not revoke links already issued or remove members already invited. This is a mutating,  idempotent, portal-wide call. It returns the saved setting; read the current value at any time, including  anonymously, from `GET api/2.0/settings/invitationsettings`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantUserInvitationSettingsRequestDto">Whether the portal still lets its members invite new members and new guests. (optional)</param>
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
