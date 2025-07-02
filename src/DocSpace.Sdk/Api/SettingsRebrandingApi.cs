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
using DocSpace.Sdk.Client;
using DocSpace.Sdk.Model;

namespace DocSpace.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsRebrandingApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete the additional white label settings
        /// </summary>
        /// <remarks>
        /// Deletes the additional white label settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-additional-white-label-settings/">REST API Reference for DeleteAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>AdditionalWhiteLabelSettingsWrapper</returns>
        AdditionalWhiteLabelSettingsWrapper DeleteAdditionalWhiteLabelSettings();

        /// <summary>
        /// Delete the additional white label settings
        /// </summary>
        /// <remarks>
        /// Deletes the additional white label settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-additional-white-label-settings/">REST API Reference for DeleteAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>ApiResponse of AdditionalWhiteLabelSettingsWrapper</returns>
        ApiResponse<AdditionalWhiteLabelSettingsWrapper> DeleteAdditionalWhiteLabelSettingsWithHttpInfo();
        /// <summary>
        /// Delete the company white label settings
        /// </summary>
        /// <remarks>
        /// Deletes the company white label settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-company-white-label-settings/">REST API Reference for DeleteCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>CompanyWhiteLabelSettingsWrapper</returns>
        CompanyWhiteLabelSettingsWrapper DeleteCompanyWhiteLabelSettings();

        /// <summary>
        /// Delete the company white label settings
        /// </summary>
        /// <remarks>
        /// Deletes the company white label settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-company-white-label-settings/">REST API Reference for DeleteCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>ApiResponse of CompanyWhiteLabelSettingsWrapper</returns>
        ApiResponse<CompanyWhiteLabelSettingsWrapper> DeleteCompanyWhiteLabelSettingsWithHttpInfo();
        /// <summary>
        /// Get the additional white label settings
        /// </summary>
        /// <remarks>
        /// Returns the additional white label settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-additional-white-label-settings/">REST API Reference for GetAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>AdditionalWhiteLabelSettingsWrapper</returns>
        AdditionalWhiteLabelSettingsWrapper GetAdditionalWhiteLabelSettings();

        /// <summary>
        /// Get the additional white label settings
        /// </summary>
        /// <remarks>
        /// Returns the additional white label settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-additional-white-label-settings/">REST API Reference for GetAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>ApiResponse of AdditionalWhiteLabelSettingsWrapper</returns>
        ApiResponse<AdditionalWhiteLabelSettingsWrapper> GetAdditionalWhiteLabelSettingsWithHttpInfo();
        /// <summary>
        /// Get the company white label settings
        /// </summary>
        /// <remarks>
        /// Returns the company white label settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-company-white-label-settings/">REST API Reference for GetCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>CompanyWhiteLabelSettingsWrapper</returns>
        CompanyWhiteLabelSettingsWrapper GetCompanyWhiteLabelSettings();

        /// <summary>
        /// Get the company white label settings
        /// </summary>
        /// <remarks>
        /// Returns the company white label settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-company-white-label-settings/">REST API Reference for GetCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>ApiResponse of CompanyWhiteLabelSettingsWrapper</returns>
        ApiResponse<CompanyWhiteLabelSettingsWrapper> GetCompanyWhiteLabelSettingsWithHttpInfo();
        /// <summary>
        /// Check the white label availability
        /// </summary>
        /// <remarks>
        /// Checks if the white label is enabled or not.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-enable-whitelabel/">REST API Reference for GetEnableWhitelabel Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper GetEnableWhitelabel();

        /// <summary>
        /// Check the white label availability
        /// </summary>
        /// <remarks>
        /// Checks if the white label is enabled or not.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-enable-whitelabel/">REST API Reference for GetEnableWhitelabel Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> GetEnableWhitelabelWithHttpInfo();
        /// <summary>
        /// Check the default white label logo text
        /// </summary>
        /// <remarks>
        /// Specifies if the white label logo text are default or not.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-default-white-label-logo-text/">REST API Reference for GetIsDefaultWhiteLabelLogoText Operation</seealso>
        /// <returns>IsDefaultWhiteLabelLogosWrapper</returns>
        IsDefaultWhiteLabelLogosWrapper GetIsDefaultWhiteLabelLogoText(bool? isDark = default, bool? isDefault = default);

        /// <summary>
        /// Check the default white label logo text
        /// </summary>
        /// <remarks>
        /// Specifies if the white label logo text are default or not.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-default-white-label-logo-text/">REST API Reference for GetIsDefaultWhiteLabelLogoText Operation</seealso>
        /// <returns>ApiResponse of IsDefaultWhiteLabelLogosWrapper</returns>
        ApiResponse<IsDefaultWhiteLabelLogosWrapper> GetIsDefaultWhiteLabelLogoTextWithHttpInfo(bool? isDark = default, bool? isDefault = default);
        /// <summary>
        /// Check the default white label logos
        /// </summary>
        /// <remarks>
        /// Specifies if the white label logos are default or not.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-default-white-label-logos/">REST API Reference for GetIsDefaultWhiteLabelLogos Operation</seealso>
        /// <returns>IsDefaultWhiteLabelLogosArrayWrapper</returns>
        IsDefaultWhiteLabelLogosArrayWrapper GetIsDefaultWhiteLabelLogos(bool? isDark = default, bool? isDefault = default);

        /// <summary>
        /// Check the default white label logos
        /// </summary>
        /// <remarks>
        /// Specifies if the white label logos are default or not.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-default-white-label-logos/">REST API Reference for GetIsDefaultWhiteLabelLogos Operation</seealso>
        /// <returns>ApiResponse of IsDefaultWhiteLabelLogosArrayWrapper</returns>
        ApiResponse<IsDefaultWhiteLabelLogosArrayWrapper> GetIsDefaultWhiteLabelLogosWithHttpInfo(bool? isDark = default, bool? isDefault = default);
        /// <summary>
        /// Get the licensor data
        /// </summary>
        /// <remarks>
        /// Returns the licensor data.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-licensor-data/">REST API Reference for GetLicensorData Operation</seealso>
        /// <returns>CompanyWhiteLabelSettingsArrayWrapper</returns>
        CompanyWhiteLabelSettingsArrayWrapper GetLicensorData();

        /// <summary>
        /// Get the licensor data
        /// </summary>
        /// <remarks>
        /// Returns the licensor data.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-licensor-data/">REST API Reference for GetLicensorData Operation</seealso>
        /// <returns>ApiResponse of CompanyWhiteLabelSettingsArrayWrapper</returns>
        ApiResponse<CompanyWhiteLabelSettingsArrayWrapper> GetLicensorDataWithHttpInfo();
        /// <summary>
        /// Get the white label logo text
        /// </summary>
        /// <remarks>
        /// Returns the white label logo text.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-white-label-logo-text/">REST API Reference for GetWhiteLabelLogoText Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper GetWhiteLabelLogoText(bool? isDark = default, bool? isDefault = default);

        /// <summary>
        /// Get the white label logo text
        /// </summary>
        /// <remarks>
        /// Returns the white label logo text.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-white-label-logo-text/">REST API Reference for GetWhiteLabelLogoText Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> GetWhiteLabelLogoTextWithHttpInfo(bool? isDark = default, bool? isDefault = default);
        /// <summary>
        /// Get the white label logos
        /// </summary>
        /// <remarks>
        /// Returns the white label logos.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-white-label-logos/">REST API Reference for GetWhiteLabelLogos Operation</seealso>
        /// <returns>WhiteLabelItemArrayWrapper</returns>
        WhiteLabelItemArrayWrapper GetWhiteLabelLogos(bool? isDark = default, bool? isDefault = default);

        /// <summary>
        /// Get the white label logos
        /// </summary>
        /// <remarks>
        /// Returns the white label logos.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-white-label-logos/">REST API Reference for GetWhiteLabelLogos Operation</seealso>
        /// <returns>ApiResponse of WhiteLabelItemArrayWrapper</returns>
        ApiResponse<WhiteLabelItemArrayWrapper> GetWhiteLabelLogosWithHttpInfo(bool? isDark = default, bool? isDefault = default);
        /// <summary>
        /// Restore the white label logo text
        /// </summary>
        /// <remarks>
        /// Restores the white label logo text.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-white-label-logo-text/">REST API Reference for RestoreWhiteLabelLogoText Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper RestoreWhiteLabelLogoText(bool? isDark = default, bool? isDefault = default);

        /// <summary>
        /// Restore the white label logo text
        /// </summary>
        /// <remarks>
        /// Restores the white label logo text.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-white-label-logo-text/">REST API Reference for RestoreWhiteLabelLogoText Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> RestoreWhiteLabelLogoTextWithHttpInfo(bool? isDark = default, bool? isDefault = default);
        /// <summary>
        /// Restore the white label logos
        /// </summary>
        /// <remarks>
        /// Restores the white label logos.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-white-label-logos/">REST API Reference for RestoreWhiteLabelLogos Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper RestoreWhiteLabelLogos(bool? isDark = default, bool? isDefault = default);

        /// <summary>
        /// Restore the white label logos
        /// </summary>
        /// <remarks>
        /// Restores the white label logos.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-white-label-logos/">REST API Reference for RestoreWhiteLabelLogos Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> RestoreWhiteLabelLogosWithHttpInfo(bool? isDark = default, bool? isDefault = default);
        /// <summary>
        /// Save the additional white label settings
        /// </summary>
        /// <remarks>
        /// Saves the additional white label settings specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="additionalWhiteLabelSettingsWrapper">The additional white label settings wrapper. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-additional-white-label-settings/">REST API Reference for SaveAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper SaveAdditionalWhiteLabelSettings(AdditionalWhiteLabelSettingsWrapper? additionalWhiteLabelSettingsWrapper = default);

        /// <summary>
        /// Save the additional white label settings
        /// </summary>
        /// <remarks>
        /// Saves the additional white label settings specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="additionalWhiteLabelSettingsWrapper">The additional white label settings wrapper. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-additional-white-label-settings/">REST API Reference for SaveAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> SaveAdditionalWhiteLabelSettingsWithHttpInfo(AdditionalWhiteLabelSettingsWrapper? additionalWhiteLabelSettingsWrapper = default);
        /// <summary>
        /// Save the company white label settings
        /// </summary>
        /// <remarks>
        /// Saves the company white label settings specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyWhiteLabelSettingsWrapper">The company white label settings wrapper. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-company-white-label-settings/">REST API Reference for SaveCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper SaveCompanyWhiteLabelSettings(CompanyWhiteLabelSettingsWrapper? companyWhiteLabelSettingsWrapper = default);

        /// <summary>
        /// Save the company white label settings
        /// </summary>
        /// <remarks>
        /// Saves the company white label settings specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyWhiteLabelSettingsWrapper">The company white label settings wrapper. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-company-white-label-settings/">REST API Reference for SaveCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> SaveCompanyWhiteLabelSettingsWithHttpInfo(CompanyWhiteLabelSettingsWrapper? companyWhiteLabelSettingsWrapper = default);
        /// <summary>
        /// Save the white label logo text settings
        /// </summary>
        /// <remarks>
        /// Saves the white label logo text specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="whiteLabelRequestsDto">The request parameters for configuring the white label branding settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-logo-text/">REST API Reference for SaveWhiteLabelLogoText Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper SaveWhiteLabelLogoText(bool? isDark = default, bool? isDefault = default, WhiteLabelRequestsDto? whiteLabelRequestsDto = default);

        /// <summary>
        /// Save the white label logo text settings
        /// </summary>
        /// <remarks>
        /// Saves the white label logo text specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="whiteLabelRequestsDto">The request parameters for configuring the white label branding settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-logo-text/">REST API Reference for SaveWhiteLabelLogoText Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> SaveWhiteLabelLogoTextWithHttpInfo(bool? isDark = default, bool? isDefault = default, WhiteLabelRequestsDto? whiteLabelRequestsDto = default);
        /// <summary>
        /// Save the white label logos
        /// </summary>
        /// <remarks>
        /// Saves the white label logos specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="whiteLabelRequestsDto">The request parameters for configuring the white label branding settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-settings/">REST API Reference for SaveWhiteLabelSettings Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper SaveWhiteLabelSettings(bool? isDark = default, bool? isDefault = default, WhiteLabelRequestsDto? whiteLabelRequestsDto = default);

        /// <summary>
        /// Save the white label logos
        /// </summary>
        /// <remarks>
        /// Saves the white label logos specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="whiteLabelRequestsDto">The request parameters for configuring the white label branding settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-settings/">REST API Reference for SaveWhiteLabelSettings Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> SaveWhiteLabelSettingsWithHttpInfo(bool? isDark = default, bool? isDefault = default, WhiteLabelRequestsDto? whiteLabelRequestsDto = default);
        /// <summary>
        /// Save the white label logos from files
        /// </summary>
        /// <remarks>
        /// Saves the white label logos from files.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-settings-from-files/">REST API Reference for SaveWhiteLabelSettingsFromFiles Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper SaveWhiteLabelSettingsFromFiles(bool? isDark = default, bool? isDefault = default);

        /// <summary>
        /// Save the white label logos from files
        /// </summary>
        /// <remarks>
        /// Saves the white label logos from files.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-settings-from-files/">REST API Reference for SaveWhiteLabelSettingsFromFiles Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> SaveWhiteLabelSettingsFromFilesWithHttpInfo(bool? isDark = default, bool? isDefault = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsRebrandingApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Delete the additional white label settings
        /// </summary>
        /// <remarks>
        /// Deletes the additional white label settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-additional-white-label-settings/">REST API Reference for DeleteAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>Task of AdditionalWhiteLabelSettingsWrapper</returns>
        System.Threading.Tasks.Task<AdditionalWhiteLabelSettingsWrapper> DeleteAdditionalWhiteLabelSettingsAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete the additional white label settings
        /// </summary>
        /// <remarks>
        /// Deletes the additional white label settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-additional-white-label-settings/">REST API Reference for DeleteAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>Task of ApiResponse (AdditionalWhiteLabelSettingsWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdditionalWhiteLabelSettingsWrapper>> DeleteAdditionalWhiteLabelSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete the company white label settings
        /// </summary>
        /// <remarks>
        /// Deletes the company white label settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-company-white-label-settings/">REST API Reference for DeleteCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>Task of CompanyWhiteLabelSettingsWrapper</returns>
        System.Threading.Tasks.Task<CompanyWhiteLabelSettingsWrapper> DeleteCompanyWhiteLabelSettingsAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete the company white label settings
        /// </summary>
        /// <remarks>
        /// Deletes the company white label settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-company-white-label-settings/">REST API Reference for DeleteCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>Task of ApiResponse (CompanyWhiteLabelSettingsWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<CompanyWhiteLabelSettingsWrapper>> DeleteCompanyWhiteLabelSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the additional white label settings
        /// </summary>
        /// <remarks>
        /// Returns the additional white label settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-additional-white-label-settings/">REST API Reference for GetAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>Task of AdditionalWhiteLabelSettingsWrapper</returns>
        System.Threading.Tasks.Task<AdditionalWhiteLabelSettingsWrapper> GetAdditionalWhiteLabelSettingsAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the additional white label settings
        /// </summary>
        /// <remarks>
        /// Returns the additional white label settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-additional-white-label-settings/">REST API Reference for GetAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>Task of ApiResponse (AdditionalWhiteLabelSettingsWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdditionalWhiteLabelSettingsWrapper>> GetAdditionalWhiteLabelSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the company white label settings
        /// </summary>
        /// <remarks>
        /// Returns the company white label settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-company-white-label-settings/">REST API Reference for GetCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>Task of CompanyWhiteLabelSettingsWrapper</returns>
        System.Threading.Tasks.Task<CompanyWhiteLabelSettingsWrapper> GetCompanyWhiteLabelSettingsAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the company white label settings
        /// </summary>
        /// <remarks>
        /// Returns the company white label settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-company-white-label-settings/">REST API Reference for GetCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>Task of ApiResponse (CompanyWhiteLabelSettingsWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<CompanyWhiteLabelSettingsWrapper>> GetCompanyWhiteLabelSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check the white label availability
        /// </summary>
        /// <remarks>
        /// Checks if the white label is enabled or not.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-enable-whitelabel/">REST API Reference for GetEnableWhitelabel Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> GetEnableWhitelabelAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Check the white label availability
        /// </summary>
        /// <remarks>
        /// Checks if the white label is enabled or not.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-enable-whitelabel/">REST API Reference for GetEnableWhitelabel Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> GetEnableWhitelabelWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check the default white label logo text
        /// </summary>
        /// <remarks>
        /// Specifies if the white label logo text are default or not.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-default-white-label-logo-text/">REST API Reference for GetIsDefaultWhiteLabelLogoText Operation</seealso>
        /// <returns>Task of IsDefaultWhiteLabelLogosWrapper</returns>
        System.Threading.Tasks.Task<IsDefaultWhiteLabelLogosWrapper> GetIsDefaultWhiteLabelLogoTextAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Check the default white label logo text
        /// </summary>
        /// <remarks>
        /// Specifies if the white label logo text are default or not.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-default-white-label-logo-text/">REST API Reference for GetIsDefaultWhiteLabelLogoText Operation</seealso>
        /// <returns>Task of ApiResponse (IsDefaultWhiteLabelLogosWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<IsDefaultWhiteLabelLogosWrapper>> GetIsDefaultWhiteLabelLogoTextWithHttpInfoAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check the default white label logos
        /// </summary>
        /// <remarks>
        /// Specifies if the white label logos are default or not.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-default-white-label-logos/">REST API Reference for GetIsDefaultWhiteLabelLogos Operation</seealso>
        /// <returns>Task of IsDefaultWhiteLabelLogosArrayWrapper</returns>
        System.Threading.Tasks.Task<IsDefaultWhiteLabelLogosArrayWrapper> GetIsDefaultWhiteLabelLogosAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Check the default white label logos
        /// </summary>
        /// <remarks>
        /// Specifies if the white label logos are default or not.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-default-white-label-logos/">REST API Reference for GetIsDefaultWhiteLabelLogos Operation</seealso>
        /// <returns>Task of ApiResponse (IsDefaultWhiteLabelLogosArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<IsDefaultWhiteLabelLogosArrayWrapper>> GetIsDefaultWhiteLabelLogosWithHttpInfoAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the licensor data
        /// </summary>
        /// <remarks>
        /// Returns the licensor data.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-licensor-data/">REST API Reference for GetLicensorData Operation</seealso>
        /// <returns>Task of CompanyWhiteLabelSettingsArrayWrapper</returns>
        System.Threading.Tasks.Task<CompanyWhiteLabelSettingsArrayWrapper> GetLicensorDataAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the licensor data
        /// </summary>
        /// <remarks>
        /// Returns the licensor data.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-licensor-data/">REST API Reference for GetLicensorData Operation</seealso>
        /// <returns>Task of ApiResponse (CompanyWhiteLabelSettingsArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<CompanyWhiteLabelSettingsArrayWrapper>> GetLicensorDataWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the white label logo text
        /// </summary>
        /// <remarks>
        /// Returns the white label logo text.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-white-label-logo-text/">REST API Reference for GetWhiteLabelLogoText Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        System.Threading.Tasks.Task<StringWrapper> GetWhiteLabelLogoTextAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the white label logo text
        /// </summary>
        /// <remarks>
        /// Returns the white label logo text.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-white-label-logo-text/">REST API Reference for GetWhiteLabelLogoText Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringWrapper>> GetWhiteLabelLogoTextWithHttpInfoAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the white label logos
        /// </summary>
        /// <remarks>
        /// Returns the white label logos.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-white-label-logos/">REST API Reference for GetWhiteLabelLogos Operation</seealso>
        /// <returns>Task of WhiteLabelItemArrayWrapper</returns>
        System.Threading.Tasks.Task<WhiteLabelItemArrayWrapper> GetWhiteLabelLogosAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the white label logos
        /// </summary>
        /// <remarks>
        /// Returns the white label logos.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-white-label-logos/">REST API Reference for GetWhiteLabelLogos Operation</seealso>
        /// <returns>Task of ApiResponse (WhiteLabelItemArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<WhiteLabelItemArrayWrapper>> GetWhiteLabelLogosWithHttpInfoAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Restore the white label logo text
        /// </summary>
        /// <remarks>
        /// Restores the white label logo text.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-white-label-logo-text/">REST API Reference for RestoreWhiteLabelLogoText Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> RestoreWhiteLabelLogoTextAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Restore the white label logo text
        /// </summary>
        /// <remarks>
        /// Restores the white label logo text.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-white-label-logo-text/">REST API Reference for RestoreWhiteLabelLogoText Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> RestoreWhiteLabelLogoTextWithHttpInfoAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Restore the white label logos
        /// </summary>
        /// <remarks>
        /// Restores the white label logos.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-white-label-logos/">REST API Reference for RestoreWhiteLabelLogos Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> RestoreWhiteLabelLogosAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Restore the white label logos
        /// </summary>
        /// <remarks>
        /// Restores the white label logos.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-white-label-logos/">REST API Reference for RestoreWhiteLabelLogos Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> RestoreWhiteLabelLogosWithHttpInfoAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Save the additional white label settings
        /// </summary>
        /// <remarks>
        /// Saves the additional white label settings specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="additionalWhiteLabelSettingsWrapper">The additional white label settings wrapper. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-additional-white-label-settings/">REST API Reference for SaveAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> SaveAdditionalWhiteLabelSettingsAsync(AdditionalWhiteLabelSettingsWrapper? additionalWhiteLabelSettingsWrapper = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Save the additional white label settings
        /// </summary>
        /// <remarks>
        /// Saves the additional white label settings specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="additionalWhiteLabelSettingsWrapper">The additional white label settings wrapper. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-additional-white-label-settings/">REST API Reference for SaveAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> SaveAdditionalWhiteLabelSettingsWithHttpInfoAsync(AdditionalWhiteLabelSettingsWrapper? additionalWhiteLabelSettingsWrapper = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Save the company white label settings
        /// </summary>
        /// <remarks>
        /// Saves the company white label settings specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyWhiteLabelSettingsWrapper">The company white label settings wrapper. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-company-white-label-settings/">REST API Reference for SaveCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> SaveCompanyWhiteLabelSettingsAsync(CompanyWhiteLabelSettingsWrapper? companyWhiteLabelSettingsWrapper = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Save the company white label settings
        /// </summary>
        /// <remarks>
        /// Saves the company white label settings specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyWhiteLabelSettingsWrapper">The company white label settings wrapper. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-company-white-label-settings/">REST API Reference for SaveCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> SaveCompanyWhiteLabelSettingsWithHttpInfoAsync(CompanyWhiteLabelSettingsWrapper? companyWhiteLabelSettingsWrapper = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Save the white label logo text settings
        /// </summary>
        /// <remarks>
        /// Saves the white label logo text specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="whiteLabelRequestsDto">The request parameters for configuring the white label branding settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-logo-text/">REST API Reference for SaveWhiteLabelLogoText Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> SaveWhiteLabelLogoTextAsync(bool? isDark = default, bool? isDefault = default, WhiteLabelRequestsDto? whiteLabelRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Save the white label logo text settings
        /// </summary>
        /// <remarks>
        /// Saves the white label logo text specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="whiteLabelRequestsDto">The request parameters for configuring the white label branding settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-logo-text/">REST API Reference for SaveWhiteLabelLogoText Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> SaveWhiteLabelLogoTextWithHttpInfoAsync(bool? isDark = default, bool? isDefault = default, WhiteLabelRequestsDto? whiteLabelRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Save the white label logos
        /// </summary>
        /// <remarks>
        /// Saves the white label logos specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="whiteLabelRequestsDto">The request parameters for configuring the white label branding settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-settings/">REST API Reference for SaveWhiteLabelSettings Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> SaveWhiteLabelSettingsAsync(bool? isDark = default, bool? isDefault = default, WhiteLabelRequestsDto? whiteLabelRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Save the white label logos
        /// </summary>
        /// <remarks>
        /// Saves the white label logos specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="whiteLabelRequestsDto">The request parameters for configuring the white label branding settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-settings/">REST API Reference for SaveWhiteLabelSettings Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> SaveWhiteLabelSettingsWithHttpInfoAsync(bool? isDark = default, bool? isDefault = default, WhiteLabelRequestsDto? whiteLabelRequestsDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Save the white label logos from files
        /// </summary>
        /// <remarks>
        /// Saves the white label logos from files.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-settings-from-files/">REST API Reference for SaveWhiteLabelSettingsFromFiles Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> SaveWhiteLabelSettingsFromFilesAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Save the white label logos from files
        /// </summary>
        /// <remarks>
        /// Saves the white label logos from files.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-settings-from-files/">REST API Reference for SaveWhiteLabelSettingsFromFiles Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> SaveWhiteLabelSettingsFromFilesWithHttpInfoAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsRebrandingApi : ISettingsRebrandingApiSync, ISettingsRebrandingApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SettingsRebrandingApi : IDisposable, ISettingsRebrandingApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsRebrandingApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public SettingsRebrandingApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsRebrandingApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public SettingsRebrandingApi(string basePath)
        {
            this.Configuration = DocSpace.Sdk.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            this.ApiClient = new ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsRebrandingApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public SettingsRebrandingApi(Configuration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);

            this.Configuration = DocSpace.Sdk.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsRebrandingApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public SettingsRebrandingApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsRebrandingApi"/> class.
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
        public SettingsRebrandingApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(client);

            this.Configuration = DocSpace.Sdk.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            this.ApiClient = new ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsRebrandingApi"/> class using a Configuration object.
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
        public SettingsRebrandingApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            ArgumentNullException.ThrowIfNull(client);

            this.Configuration = DocSpace.Sdk.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsRebrandingApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SettingsRebrandingApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(client);
            ArgumentNullException.ThrowIfNull(asyncClient);
            ArgumentNullException.ThrowIfNull(configuration);

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
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
        /// Delete the additional white label settings Deletes the additional white label settings.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-additional-white-label-settings/">REST API Reference for DeleteAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>AdditionalWhiteLabelSettingsWrapper</returns>
        public AdditionalWhiteLabelSettingsWrapper DeleteAdditionalWhiteLabelSettings()
        {
            var localVarResponse = DeleteAdditionalWhiteLabelSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete the additional white label settings Deletes the additional white label settings.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-additional-white-label-settings/">REST API Reference for DeleteAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>ApiResponse of AdditionalWhiteLabelSettingsWrapper</returns>
        public ApiResponse<AdditionalWhiteLabelSettingsWrapper> DeleteAdditionalWhiteLabelSettingsWithHttpInfo()
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
            var localVarResponse = this.Client.Delete<AdditionalWhiteLabelSettingsWrapper>("/api/2.0/settings/rebranding/additional", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("DeleteAdditionalWhiteLabelSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete the additional white label settings Deletes the additional white label settings.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-additional-white-label-settings/">REST API Reference for DeleteAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>Task of AdditionalWhiteLabelSettingsWrapper</returns>
        public async System.Threading.Tasks.Task<AdditionalWhiteLabelSettingsWrapper> DeleteAdditionalWhiteLabelSettingsAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AdditionalWhiteLabelSettingsWrapper> localVarResponse = await DeleteAdditionalWhiteLabelSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete the additional white label settings Deletes the additional white label settings.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-additional-white-label-settings/">REST API Reference for DeleteAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>Task of ApiResponse (AdditionalWhiteLabelSettingsWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdditionalWhiteLabelSettingsWrapper>> DeleteAdditionalWhiteLabelSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
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

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<AdditionalWhiteLabelSettingsWrapper>("/api/2.0/settings/rebranding/additional", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("DeleteAdditionalWhiteLabelSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete the company white label settings Deletes the company white label settings.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-company-white-label-settings/">REST API Reference for DeleteCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>CompanyWhiteLabelSettingsWrapper</returns>
        public CompanyWhiteLabelSettingsWrapper DeleteCompanyWhiteLabelSettings()
        {
            var localVarResponse = DeleteCompanyWhiteLabelSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete the company white label settings Deletes the company white label settings.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-company-white-label-settings/">REST API Reference for DeleteCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>ApiResponse of CompanyWhiteLabelSettingsWrapper</returns>
        public ApiResponse<CompanyWhiteLabelSettingsWrapper> DeleteCompanyWhiteLabelSettingsWithHttpInfo()
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
            var localVarResponse = this.Client.Delete<CompanyWhiteLabelSettingsWrapper>("/api/2.0/settings/rebranding/company", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("DeleteCompanyWhiteLabelSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete the company white label settings Deletes the company white label settings.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-company-white-label-settings/">REST API Reference for DeleteCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>Task of CompanyWhiteLabelSettingsWrapper</returns>
        public async System.Threading.Tasks.Task<CompanyWhiteLabelSettingsWrapper> DeleteCompanyWhiteLabelSettingsAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<CompanyWhiteLabelSettingsWrapper> localVarResponse = await DeleteCompanyWhiteLabelSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete the company white label settings Deletes the company white label settings.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-company-white-label-settings/">REST API Reference for DeleteCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>Task of ApiResponse (CompanyWhiteLabelSettingsWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CompanyWhiteLabelSettingsWrapper>> DeleteCompanyWhiteLabelSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
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

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<CompanyWhiteLabelSettingsWrapper>("/api/2.0/settings/rebranding/company", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("DeleteCompanyWhiteLabelSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the additional white label settings Returns the additional white label settings.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-additional-white-label-settings/">REST API Reference for GetAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>AdditionalWhiteLabelSettingsWrapper</returns>
        public AdditionalWhiteLabelSettingsWrapper GetAdditionalWhiteLabelSettings()
        {
            var localVarResponse = GetAdditionalWhiteLabelSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the additional white label settings Returns the additional white label settings.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-additional-white-label-settings/">REST API Reference for GetAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>ApiResponse of AdditionalWhiteLabelSettingsWrapper</returns>
        public ApiResponse<AdditionalWhiteLabelSettingsWrapper> GetAdditionalWhiteLabelSettingsWithHttpInfo()
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
            var localVarResponse = this.Client.Get<AdditionalWhiteLabelSettingsWrapper>("/api/2.0/settings/rebranding/additional", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetAdditionalWhiteLabelSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the additional white label settings Returns the additional white label settings.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-additional-white-label-settings/">REST API Reference for GetAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>Task of AdditionalWhiteLabelSettingsWrapper</returns>
        public async System.Threading.Tasks.Task<AdditionalWhiteLabelSettingsWrapper> GetAdditionalWhiteLabelSettingsAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AdditionalWhiteLabelSettingsWrapper> localVarResponse = await GetAdditionalWhiteLabelSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the additional white label settings Returns the additional white label settings.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-additional-white-label-settings/">REST API Reference for GetAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>Task of ApiResponse (AdditionalWhiteLabelSettingsWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdditionalWhiteLabelSettingsWrapper>> GetAdditionalWhiteLabelSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<AdditionalWhiteLabelSettingsWrapper>("/api/2.0/settings/rebranding/additional", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetAdditionalWhiteLabelSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the company white label settings Returns the company white label settings.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-company-white-label-settings/">REST API Reference for GetCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>CompanyWhiteLabelSettingsWrapper</returns>
        public CompanyWhiteLabelSettingsWrapper GetCompanyWhiteLabelSettings()
        {
            var localVarResponse = GetCompanyWhiteLabelSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the company white label settings Returns the company white label settings.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-company-white-label-settings/">REST API Reference for GetCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>ApiResponse of CompanyWhiteLabelSettingsWrapper</returns>
        public ApiResponse<CompanyWhiteLabelSettingsWrapper> GetCompanyWhiteLabelSettingsWithHttpInfo()
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
            var localVarResponse = this.Client.Get<CompanyWhiteLabelSettingsWrapper>("/api/2.0/settings/rebranding/company", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetCompanyWhiteLabelSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the company white label settings Returns the company white label settings.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-company-white-label-settings/">REST API Reference for GetCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>Task of CompanyWhiteLabelSettingsWrapper</returns>
        public async System.Threading.Tasks.Task<CompanyWhiteLabelSettingsWrapper> GetCompanyWhiteLabelSettingsAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<CompanyWhiteLabelSettingsWrapper> localVarResponse = await GetCompanyWhiteLabelSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the company white label settings Returns the company white label settings.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-company-white-label-settings/">REST API Reference for GetCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>Task of ApiResponse (CompanyWhiteLabelSettingsWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CompanyWhiteLabelSettingsWrapper>> GetCompanyWhiteLabelSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<CompanyWhiteLabelSettingsWrapper>("/api/2.0/settings/rebranding/company", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetCompanyWhiteLabelSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check the white label availability Checks if the white label is enabled or not.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-enable-whitelabel/">REST API Reference for GetEnableWhitelabel Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper GetEnableWhitelabel()
        {
            var localVarResponse = GetEnableWhitelabelWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check the white label availability Checks if the white label is enabled or not.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-enable-whitelabel/">REST API Reference for GetEnableWhitelabel Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> GetEnableWhitelabelWithHttpInfo()
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
            var localVarResponse = this.Client.Get<BooleanWrapper>("/api/2.0/settings/enablewhitelabel", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetEnableWhitelabel", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check the white label availability Checks if the white label is enabled or not.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-enable-whitelabel/">REST API Reference for GetEnableWhitelabel Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> GetEnableWhitelabelAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await GetEnableWhitelabelWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check the white label availability Checks if the white label is enabled or not.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-enable-whitelabel/">REST API Reference for GetEnableWhitelabel Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> GetEnableWhitelabelWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<BooleanWrapper>("/api/2.0/settings/enablewhitelabel", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetEnableWhitelabel", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check the default white label logo text Specifies if the white label logo text are default or not.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-default-white-label-logo-text/">REST API Reference for GetIsDefaultWhiteLabelLogoText Operation</seealso>
        /// <returns>IsDefaultWhiteLabelLogosWrapper</returns>
        public IsDefaultWhiteLabelLogosWrapper GetIsDefaultWhiteLabelLogoText(bool? isDark = default, bool? isDefault = default)
        {
            var localVarResponse = GetIsDefaultWhiteLabelLogoTextWithHttpInfo(isDark, isDefault);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check the default white label logo text Specifies if the white label logo text are default or not.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-default-white-label-logo-text/">REST API Reference for GetIsDefaultWhiteLabelLogoText Operation</seealso>
        /// <returns>ApiResponse of IsDefaultWhiteLabelLogosWrapper</returns>
        public ApiResponse<IsDefaultWhiteLabelLogosWrapper> GetIsDefaultWhiteLabelLogoTextWithHttpInfo(bool? isDark = default, bool? isDefault = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (isDark != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDark", isDark));
            }
            if (isDefault != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDefault", isDefault));
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
            var localVarResponse = this.Client.Get<IsDefaultWhiteLabelLogosWrapper>("/api/2.0/settings/whitelabel/logotext/isdefault", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetIsDefaultWhiteLabelLogoText", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check the default white label logo text Specifies if the white label logo text are default or not.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-default-white-label-logo-text/">REST API Reference for GetIsDefaultWhiteLabelLogoText Operation</seealso>
        /// <returns>Task of IsDefaultWhiteLabelLogosWrapper</returns>
        public async System.Threading.Tasks.Task<IsDefaultWhiteLabelLogosWrapper> GetIsDefaultWhiteLabelLogoTextAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<IsDefaultWhiteLabelLogosWrapper> localVarResponse = await GetIsDefaultWhiteLabelLogoTextWithHttpInfoAsync(isDark, isDefault, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check the default white label logo text Specifies if the white label logo text are default or not.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-default-white-label-logo-text/">REST API Reference for GetIsDefaultWhiteLabelLogoText Operation</seealso>
        /// <returns>Task of ApiResponse (IsDefaultWhiteLabelLogosWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IsDefaultWhiteLabelLogosWrapper>> GetIsDefaultWhiteLabelLogoTextWithHttpInfoAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (isDark != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDark", isDark));
            }
            if (isDefault != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDefault", isDefault));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<IsDefaultWhiteLabelLogosWrapper>("/api/2.0/settings/whitelabel/logotext/isdefault", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetIsDefaultWhiteLabelLogoText", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check the default white label logos Specifies if the white label logos are default or not.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-default-white-label-logos/">REST API Reference for GetIsDefaultWhiteLabelLogos Operation</seealso>
        /// <returns>IsDefaultWhiteLabelLogosArrayWrapper</returns>
        public IsDefaultWhiteLabelLogosArrayWrapper GetIsDefaultWhiteLabelLogos(bool? isDark = default, bool? isDefault = default)
        {
            var localVarResponse = GetIsDefaultWhiteLabelLogosWithHttpInfo(isDark, isDefault);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check the default white label logos Specifies if the white label logos are default or not.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-default-white-label-logos/">REST API Reference for GetIsDefaultWhiteLabelLogos Operation</seealso>
        /// <returns>ApiResponse of IsDefaultWhiteLabelLogosArrayWrapper</returns>
        public ApiResponse<IsDefaultWhiteLabelLogosArrayWrapper> GetIsDefaultWhiteLabelLogosWithHttpInfo(bool? isDark = default, bool? isDefault = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (isDark != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDark", isDark));
            }
            if (isDefault != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDefault", isDefault));
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
            var localVarResponse = this.Client.Get<IsDefaultWhiteLabelLogosArrayWrapper>("/api/2.0/settings/whitelabel/logos/isdefault", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetIsDefaultWhiteLabelLogos", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check the default white label logos Specifies if the white label logos are default or not.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-default-white-label-logos/">REST API Reference for GetIsDefaultWhiteLabelLogos Operation</seealso>
        /// <returns>Task of IsDefaultWhiteLabelLogosArrayWrapper</returns>
        public async System.Threading.Tasks.Task<IsDefaultWhiteLabelLogosArrayWrapper> GetIsDefaultWhiteLabelLogosAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<IsDefaultWhiteLabelLogosArrayWrapper> localVarResponse = await GetIsDefaultWhiteLabelLogosWithHttpInfoAsync(isDark, isDefault, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check the default white label logos Specifies if the white label logos are default or not.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-default-white-label-logos/">REST API Reference for GetIsDefaultWhiteLabelLogos Operation</seealso>
        /// <returns>Task of ApiResponse (IsDefaultWhiteLabelLogosArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IsDefaultWhiteLabelLogosArrayWrapper>> GetIsDefaultWhiteLabelLogosWithHttpInfoAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (isDark != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDark", isDark));
            }
            if (isDefault != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDefault", isDefault));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<IsDefaultWhiteLabelLogosArrayWrapper>("/api/2.0/settings/whitelabel/logos/isdefault", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetIsDefaultWhiteLabelLogos", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the licensor data Returns the licensor data.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-licensor-data/">REST API Reference for GetLicensorData Operation</seealso>
        /// <returns>CompanyWhiteLabelSettingsArrayWrapper</returns>
        public CompanyWhiteLabelSettingsArrayWrapper GetLicensorData()
        {
            var localVarResponse = GetLicensorDataWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the licensor data Returns the licensor data.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-licensor-data/">REST API Reference for GetLicensorData Operation</seealso>
        /// <returns>ApiResponse of CompanyWhiteLabelSettingsArrayWrapper</returns>
        public ApiResponse<CompanyWhiteLabelSettingsArrayWrapper> GetLicensorDataWithHttpInfo()
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
            var localVarResponse = this.Client.Get<CompanyWhiteLabelSettingsArrayWrapper>("/api/2.0/settings/companywhitelabel", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetLicensorData", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the licensor data Returns the licensor data.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-licensor-data/">REST API Reference for GetLicensorData Operation</seealso>
        /// <returns>Task of CompanyWhiteLabelSettingsArrayWrapper</returns>
        public async System.Threading.Tasks.Task<CompanyWhiteLabelSettingsArrayWrapper> GetLicensorDataAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<CompanyWhiteLabelSettingsArrayWrapper> localVarResponse = await GetLicensorDataWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the licensor data Returns the licensor data.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-licensor-data/">REST API Reference for GetLicensorData Operation</seealso>
        /// <returns>Task of ApiResponse (CompanyWhiteLabelSettingsArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CompanyWhiteLabelSettingsArrayWrapper>> GetLicensorDataWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<CompanyWhiteLabelSettingsArrayWrapper>("/api/2.0/settings/companywhitelabel", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetLicensorData", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the white label logo text Returns the white label logo text.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-white-label-logo-text/">REST API Reference for GetWhiteLabelLogoText Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper GetWhiteLabelLogoText(bool? isDark = default, bool? isDefault = default)
        {
            var localVarResponse = GetWhiteLabelLogoTextWithHttpInfo(isDark, isDefault);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the white label logo text Returns the white label logo text.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-white-label-logo-text/">REST API Reference for GetWhiteLabelLogoText Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> GetWhiteLabelLogoTextWithHttpInfo(bool? isDark = default, bool? isDefault = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (isDark != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDark", isDark));
            }
            if (isDefault != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDefault", isDefault));
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
            var localVarResponse = this.Client.Get<StringWrapper>("/api/2.0/settings/whitelabel/logotext", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetWhiteLabelLogoText", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the white label logo text Returns the white label logo text.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-white-label-logo-text/">REST API Reference for GetWhiteLabelLogoText Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async System.Threading.Tasks.Task<StringWrapper> GetWhiteLabelLogoTextAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<StringWrapper> localVarResponse = await GetWhiteLabelLogoTextWithHttpInfoAsync(isDark, isDefault, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the white label logo text Returns the white label logo text.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-white-label-logo-text/">REST API Reference for GetWhiteLabelLogoText Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StringWrapper>> GetWhiteLabelLogoTextWithHttpInfoAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (isDark != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDark", isDark));
            }
            if (isDefault != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDefault", isDefault));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<StringWrapper>("/api/2.0/settings/whitelabel/logotext", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetWhiteLabelLogoText", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the white label logos Returns the white label logos.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-white-label-logos/">REST API Reference for GetWhiteLabelLogos Operation</seealso>
        /// <returns>WhiteLabelItemArrayWrapper</returns>
        public WhiteLabelItemArrayWrapper GetWhiteLabelLogos(bool? isDark = default, bool? isDefault = default)
        {
            var localVarResponse = GetWhiteLabelLogosWithHttpInfo(isDark, isDefault);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the white label logos Returns the white label logos.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-white-label-logos/">REST API Reference for GetWhiteLabelLogos Operation</seealso>
        /// <returns>ApiResponse of WhiteLabelItemArrayWrapper</returns>
        public ApiResponse<WhiteLabelItemArrayWrapper> GetWhiteLabelLogosWithHttpInfo(bool? isDark = default, bool? isDefault = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (isDark != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDark", isDark));
            }
            if (isDefault != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDefault", isDefault));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<WhiteLabelItemArrayWrapper>("/api/2.0/settings/whitelabel/logos", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetWhiteLabelLogos", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the white label logos Returns the white label logos.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-white-label-logos/">REST API Reference for GetWhiteLabelLogos Operation</seealso>
        /// <returns>Task of WhiteLabelItemArrayWrapper</returns>
        public async System.Threading.Tasks.Task<WhiteLabelItemArrayWrapper> GetWhiteLabelLogosAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<WhiteLabelItemArrayWrapper> localVarResponse = await GetWhiteLabelLogosWithHttpInfoAsync(isDark, isDefault, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the white label logos Returns the white label logos.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-white-label-logos/">REST API Reference for GetWhiteLabelLogos Operation</seealso>
        /// <returns>Task of ApiResponse (WhiteLabelItemArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WhiteLabelItemArrayWrapper>> GetWhiteLabelLogosWithHttpInfoAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (isDark != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDark", isDark));
            }
            if (isDefault != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDefault", isDefault));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<WhiteLabelItemArrayWrapper>("/api/2.0/settings/whitelabel/logos", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetWhiteLabelLogos", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Restore the white label logo text Restores the white label logo text.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-white-label-logo-text/">REST API Reference for RestoreWhiteLabelLogoText Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper RestoreWhiteLabelLogoText(bool? isDark = default, bool? isDefault = default)
        {
            var localVarResponse = RestoreWhiteLabelLogoTextWithHttpInfo(isDark, isDefault);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Restore the white label logo text Restores the white label logo text.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-white-label-logo-text/">REST API Reference for RestoreWhiteLabelLogoText Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> RestoreWhiteLabelLogoTextWithHttpInfo(bool? isDark = default, bool? isDefault = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (isDark != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDark", isDark));
            }
            if (isDefault != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDefault", isDefault));
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
            var localVarResponse = this.Client.Put<BooleanWrapper>("/api/2.0/settings/whitelabel/logotext/restore", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("RestoreWhiteLabelLogoText", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Restore the white label logo text Restores the white label logo text.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-white-label-logo-text/">REST API Reference for RestoreWhiteLabelLogoText Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> RestoreWhiteLabelLogoTextAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await RestoreWhiteLabelLogoTextWithHttpInfoAsync(isDark, isDefault, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Restore the white label logo text Restores the white label logo text.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-white-label-logo-text/">REST API Reference for RestoreWhiteLabelLogoText Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> RestoreWhiteLabelLogoTextWithHttpInfoAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (isDark != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDark", isDark));
            }
            if (isDefault != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDefault", isDefault));
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

            var localVarResponse = await this.AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/settings/whitelabel/logotext/restore", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("RestoreWhiteLabelLogoText", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Restore the white label logos Restores the white label logos.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-white-label-logos/">REST API Reference for RestoreWhiteLabelLogos Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper RestoreWhiteLabelLogos(bool? isDark = default, bool? isDefault = default)
        {
            var localVarResponse = RestoreWhiteLabelLogosWithHttpInfo(isDark, isDefault);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Restore the white label logos Restores the white label logos.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-white-label-logos/">REST API Reference for RestoreWhiteLabelLogos Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> RestoreWhiteLabelLogosWithHttpInfo(bool? isDark = default, bool? isDefault = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (isDark != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDark", isDark));
            }
            if (isDefault != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDefault", isDefault));
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
            var localVarResponse = this.Client.Put<BooleanWrapper>("/api/2.0/settings/whitelabel/logos/restore", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("RestoreWhiteLabelLogos", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Restore the white label logos Restores the white label logos.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-white-label-logos/">REST API Reference for RestoreWhiteLabelLogos Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> RestoreWhiteLabelLogosAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await RestoreWhiteLabelLogosWithHttpInfoAsync(isDark, isDefault, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Restore the white label logos Restores the white label logos.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-white-label-logos/">REST API Reference for RestoreWhiteLabelLogos Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> RestoreWhiteLabelLogosWithHttpInfoAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (isDark != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDark", isDark));
            }
            if (isDefault != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDefault", isDefault));
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

            var localVarResponse = await this.AsynchronousClient.PutAsync<BooleanWrapper>("/api/2.0/settings/whitelabel/logos/restore", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("RestoreWhiteLabelLogos", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save the additional white label settings Saves the additional white label settings specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="additionalWhiteLabelSettingsWrapper">The additional white label settings wrapper. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-additional-white-label-settings/">REST API Reference for SaveAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper SaveAdditionalWhiteLabelSettings(AdditionalWhiteLabelSettingsWrapper? additionalWhiteLabelSettingsWrapper = default)
        {
            var localVarResponse = SaveAdditionalWhiteLabelSettingsWithHttpInfo(additionalWhiteLabelSettingsWrapper);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save the additional white label settings Saves the additional white label settings specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="additionalWhiteLabelSettingsWrapper">The additional white label settings wrapper. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-additional-white-label-settings/">REST API Reference for SaveAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> SaveAdditionalWhiteLabelSettingsWithHttpInfo(AdditionalWhiteLabelSettingsWrapper? additionalWhiteLabelSettingsWrapper = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (additionalWhiteLabelSettingsWrapper != null) localVarRequestOptions.Data = additionalWhiteLabelSettingsWrapper;

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
            var localVarResponse = this.Client.Post<BooleanWrapper>("/api/2.0/settings/rebranding/additional", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SaveAdditionalWhiteLabelSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save the additional white label settings Saves the additional white label settings specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="additionalWhiteLabelSettingsWrapper">The additional white label settings wrapper. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-additional-white-label-settings/">REST API Reference for SaveAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> SaveAdditionalWhiteLabelSettingsAsync(AdditionalWhiteLabelSettingsWrapper? additionalWhiteLabelSettingsWrapper = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await SaveAdditionalWhiteLabelSettingsWithHttpInfoAsync(additionalWhiteLabelSettingsWrapper, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save the additional white label settings Saves the additional white label settings specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="additionalWhiteLabelSettingsWrapper">The additional white label settings wrapper. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-additional-white-label-settings/">REST API Reference for SaveAdditionalWhiteLabelSettings Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> SaveAdditionalWhiteLabelSettingsWithHttpInfoAsync(AdditionalWhiteLabelSettingsWrapper? additionalWhiteLabelSettingsWrapper = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (additionalWhiteLabelSettingsWrapper != null) localVarRequestOptions.Data = additionalWhiteLabelSettingsWrapper;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<BooleanWrapper>("/api/2.0/settings/rebranding/additional", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SaveAdditionalWhiteLabelSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save the company white label settings Saves the company white label settings specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyWhiteLabelSettingsWrapper">The company white label settings wrapper. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-company-white-label-settings/">REST API Reference for SaveCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper SaveCompanyWhiteLabelSettings(CompanyWhiteLabelSettingsWrapper? companyWhiteLabelSettingsWrapper = default)
        {
            var localVarResponse = SaveCompanyWhiteLabelSettingsWithHttpInfo(companyWhiteLabelSettingsWrapper);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save the company white label settings Saves the company white label settings specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyWhiteLabelSettingsWrapper">The company white label settings wrapper. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-company-white-label-settings/">REST API Reference for SaveCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> SaveCompanyWhiteLabelSettingsWithHttpInfo(CompanyWhiteLabelSettingsWrapper? companyWhiteLabelSettingsWrapper = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (companyWhiteLabelSettingsWrapper != null) localVarRequestOptions.Data = companyWhiteLabelSettingsWrapper;

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
            var localVarResponse = this.Client.Post<BooleanWrapper>("/api/2.0/settings/rebranding/company", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SaveCompanyWhiteLabelSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save the company white label settings Saves the company white label settings specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyWhiteLabelSettingsWrapper">The company white label settings wrapper. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-company-white-label-settings/">REST API Reference for SaveCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> SaveCompanyWhiteLabelSettingsAsync(CompanyWhiteLabelSettingsWrapper? companyWhiteLabelSettingsWrapper = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await SaveCompanyWhiteLabelSettingsWithHttpInfoAsync(companyWhiteLabelSettingsWrapper, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save the company white label settings Saves the company white label settings specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyWhiteLabelSettingsWrapper">The company white label settings wrapper. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-company-white-label-settings/">REST API Reference for SaveCompanyWhiteLabelSettings Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> SaveCompanyWhiteLabelSettingsWithHttpInfoAsync(CompanyWhiteLabelSettingsWrapper? companyWhiteLabelSettingsWrapper = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (companyWhiteLabelSettingsWrapper != null) localVarRequestOptions.Data = companyWhiteLabelSettingsWrapper;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<BooleanWrapper>("/api/2.0/settings/rebranding/company", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SaveCompanyWhiteLabelSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save the white label logo text settings Saves the white label logo text specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="whiteLabelRequestsDto">The request parameters for configuring the white label branding settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-logo-text/">REST API Reference for SaveWhiteLabelLogoText Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper SaveWhiteLabelLogoText(bool? isDark = default, bool? isDefault = default, WhiteLabelRequestsDto? whiteLabelRequestsDto = default)
        {
            var localVarResponse = SaveWhiteLabelLogoTextWithHttpInfo(isDark, isDefault, whiteLabelRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save the white label logo text settings Saves the white label logo text specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="whiteLabelRequestsDto">The request parameters for configuring the white label branding settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-logo-text/">REST API Reference for SaveWhiteLabelLogoText Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> SaveWhiteLabelLogoTextWithHttpInfo(bool? isDark = default, bool? isDefault = default, WhiteLabelRequestsDto? whiteLabelRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (isDark != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDark", isDark));
            }
            if (isDefault != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDefault", isDefault));
            }
            if (whiteLabelRequestsDto != null) localVarRequestOptions.Data = whiteLabelRequestsDto;

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
            var localVarResponse = this.Client.Post<BooleanWrapper>("/api/2.0/settings/whitelabel/logotext/save", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SaveWhiteLabelLogoText", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save the white label logo text settings Saves the white label logo text specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="whiteLabelRequestsDto">The request parameters for configuring the white label branding settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-logo-text/">REST API Reference for SaveWhiteLabelLogoText Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> SaveWhiteLabelLogoTextAsync(bool? isDark = default, bool? isDefault = default, WhiteLabelRequestsDto? whiteLabelRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await SaveWhiteLabelLogoTextWithHttpInfoAsync(isDark, isDefault, whiteLabelRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save the white label logo text settings Saves the white label logo text specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="whiteLabelRequestsDto">The request parameters for configuring the white label branding settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-logo-text/">REST API Reference for SaveWhiteLabelLogoText Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> SaveWhiteLabelLogoTextWithHttpInfoAsync(bool? isDark = default, bool? isDefault = default, WhiteLabelRequestsDto? whiteLabelRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (isDark != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDark", isDark));
            }
            if (isDefault != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDefault", isDefault));
            }
            if (whiteLabelRequestsDto != null) localVarRequestOptions.Data = whiteLabelRequestsDto;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<BooleanWrapper>("/api/2.0/settings/whitelabel/logotext/save", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SaveWhiteLabelLogoText", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save the white label logos Saves the white label logos specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="whiteLabelRequestsDto">The request parameters for configuring the white label branding settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-settings/">REST API Reference for SaveWhiteLabelSettings Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper SaveWhiteLabelSettings(bool? isDark = default, bool? isDefault = default, WhiteLabelRequestsDto? whiteLabelRequestsDto = default)
        {
            var localVarResponse = SaveWhiteLabelSettingsWithHttpInfo(isDark, isDefault, whiteLabelRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save the white label logos Saves the white label logos specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="whiteLabelRequestsDto">The request parameters for configuring the white label branding settings. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-settings/">REST API Reference for SaveWhiteLabelSettings Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> SaveWhiteLabelSettingsWithHttpInfo(bool? isDark = default, bool? isDefault = default, WhiteLabelRequestsDto? whiteLabelRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (isDark != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDark", isDark));
            }
            if (isDefault != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDefault", isDefault));
            }
            if (whiteLabelRequestsDto != null) localVarRequestOptions.Data = whiteLabelRequestsDto;

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
            var localVarResponse = this.Client.Post<BooleanWrapper>("/api/2.0/settings/whitelabel/logos/save", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SaveWhiteLabelSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save the white label logos Saves the white label logos specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="whiteLabelRequestsDto">The request parameters for configuring the white label branding settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-settings/">REST API Reference for SaveWhiteLabelSettings Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> SaveWhiteLabelSettingsAsync(bool? isDark = default, bool? isDefault = default, WhiteLabelRequestsDto? whiteLabelRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await SaveWhiteLabelSettingsWithHttpInfoAsync(isDark, isDefault, whiteLabelRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save the white label logos Saves the white label logos specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="whiteLabelRequestsDto">The request parameters for configuring the white label branding settings. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-settings/">REST API Reference for SaveWhiteLabelSettings Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> SaveWhiteLabelSettingsWithHttpInfoAsync(bool? isDark = default, bool? isDefault = default, WhiteLabelRequestsDto? whiteLabelRequestsDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (isDark != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDark", isDark));
            }
            if (isDefault != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDefault", isDefault));
            }
            if (whiteLabelRequestsDto != null) localVarRequestOptions.Data = whiteLabelRequestsDto;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<BooleanWrapper>("/api/2.0/settings/whitelabel/logos/save", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SaveWhiteLabelSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save the white label logos from files Saves the white label logos from files.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-settings-from-files/">REST API Reference for SaveWhiteLabelSettingsFromFiles Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper SaveWhiteLabelSettingsFromFiles(bool? isDark = default, bool? isDefault = default)
        {
            var localVarResponse = SaveWhiteLabelSettingsFromFilesWithHttpInfo(isDark, isDefault);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save the white label logos from files Saves the white label logos from files.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-settings-from-files/">REST API Reference for SaveWhiteLabelSettingsFromFiles Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> SaveWhiteLabelSettingsFromFilesWithHttpInfo(bool? isDark = default, bool? isDefault = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (isDark != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDark", isDark));
            }
            if (isDefault != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDefault", isDefault));
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
            var localVarResponse = this.Client.Post<BooleanWrapper>("/api/2.0/settings/whitelabel/logos/savefromfiles", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SaveWhiteLabelSettingsFromFiles", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save the white label logos from files Saves the white label logos from files.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-settings-from-files/">REST API Reference for SaveWhiteLabelSettingsFromFiles Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> SaveWhiteLabelSettingsFromFilesAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await SaveWhiteLabelSettingsFromFilesWithHttpInfoAsync(isDark, isDefault, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save the white label logos from files Saves the white label logos from files.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isDark">Specifies if the white label logo is for the dark theme or not. (optional)</param>
        /// <param name="isDefault">Specifies if the logo is for a default tenant or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-white-label-settings-from-files/">REST API Reference for SaveWhiteLabelSettingsFromFiles Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> SaveWhiteLabelSettingsFromFilesWithHttpInfoAsync(bool? isDark = default, bool? isDefault = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (isDark != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDark", isDark));
            }
            if (isDefault != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "IsDefault", isDefault));
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

            var localVarResponse = await this.AsynchronousClient.PostAsync<BooleanWrapper>("/api/2.0/settings/whitelabel/logos/savefromfiles", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SaveWhiteLabelSettingsFromFiles", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

    }
}
