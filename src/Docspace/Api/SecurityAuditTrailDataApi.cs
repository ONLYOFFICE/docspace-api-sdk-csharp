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
    public interface ISecurityAuditTrailDataApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Generate the audit trail report
        /// </summary>
        /// <remarks>
        /// Generates the audit trail report.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-audit-trail-report/">REST API Reference for CreateAuditTrailReport Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper CreateAuditTrailReport();

        /// <summary>
        /// Generate the audit trail report
        /// </summary>
        /// <remarks>
        /// Generates the audit trail report.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-audit-trail-report/">REST API Reference for CreateAuditTrailReport Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> CreateAuditTrailReportWithHttpInfo();
        /// <summary>
        /// Get filtered audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the audit events by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user who triggered the audit event. (optional)</param>
        /// <param name="productType">The type of product related to the audit event. (optional)</param>
        /// <param name="moduleType">The module within the product where the audit event occurred. (optional)</param>
        /// <param name="actionType">The type of action performed in the audit event (e.g., Create, Update, Delete). (optional)</param>
        /// <param name="action">The specific action that occurred within the audit event. (optional)</param>
        /// <param name="entryType">The type of audit entry (e.g., Folder, User, File). (optional)</param>
        /// <param name="target">The target object affected by the audit event (e.g., document ID, user account). (optional)</param>
        /// <param name="from">The starting date and time for filtering audit events. (optional)</param>
        /// <param name="to">The ending date and time for filtering audit events. (optional)</param>
        /// <param name="count">The maximum number of audit event records to retrieve. (optional)</param>
        /// <param name="startIndex">The index of the first audit event record to retrieve in a paged query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-events-by-filter/">REST API Reference for GetAuditEventsByFilter Operation</seealso>
        /// <returns>AuditEventArrayWrapper</returns>
        AuditEventArrayWrapper GetAuditEventsByFilter(Guid? userId = default, ProductType? productType = default, ModuleType? moduleType = default, ActionType? actionType = default, MessageAction? action = default, EntryType? entryType = default, string? target = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default);

        /// <summary>
        /// Get filtered audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the audit events by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user who triggered the audit event. (optional)</param>
        /// <param name="productType">The type of product related to the audit event. (optional)</param>
        /// <param name="moduleType">The module within the product where the audit event occurred. (optional)</param>
        /// <param name="actionType">The type of action performed in the audit event (e.g., Create, Update, Delete). (optional)</param>
        /// <param name="action">The specific action that occurred within the audit event. (optional)</param>
        /// <param name="entryType">The type of audit entry (e.g., Folder, User, File). (optional)</param>
        /// <param name="target">The target object affected by the audit event (e.g., document ID, user account). (optional)</param>
        /// <param name="from">The starting date and time for filtering audit events. (optional)</param>
        /// <param name="to">The ending date and time for filtering audit events. (optional)</param>
        /// <param name="count">The maximum number of audit event records to retrieve. (optional)</param>
        /// <param name="startIndex">The index of the first audit event record to retrieve in a paged query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-events-by-filter/">REST API Reference for GetAuditEventsByFilter Operation</seealso>
        /// <returns>ApiResponse of AuditEventArrayWrapper</returns>
        ApiResponse<AuditEventArrayWrapper> GetAuditEventsByFilterWithHttpInfo(Guid? userId = default, ProductType? productType = default, ModuleType? moduleType = default, ActionType? actionType = default, MessageAction? action = default, EntryType? entryType = default, string? target = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default);
        /// <summary>
        /// Get the audit trail settings
        /// </summary>
        /// <remarks>
        /// Returns the audit trail settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-settings/">REST API Reference for GetAuditSettings Operation</seealso>
        /// <returns>TenantAuditSettingsWrapper</returns>
        TenantAuditSettingsWrapper GetAuditSettings();

        /// <summary>
        /// Get the audit trail settings
        /// </summary>
        /// <remarks>
        /// Returns the audit trail settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-settings/">REST API Reference for GetAuditSettings Operation</seealso>
        /// <returns>ApiResponse of TenantAuditSettingsWrapper</returns>
        ApiResponse<TenantAuditSettingsWrapper> GetAuditSettingsWithHttpInfo();
        /// <summary>
        /// Get audit trail mappers
        /// </summary>
        /// <remarks>
        /// Returns the mappers for the audit trail types.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productType">The type of product related to the audit trail. (optional)</param>
        /// <param name="moduleType">The module within the product associated with the audit trail. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-mappers/">REST API Reference for GetAuditTrailMappers Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        ObjectWrapper GetAuditTrailMappers(ProductType? productType = default, ModuleType? moduleType = default);

        /// <summary>
        /// Get audit trail mappers
        /// </summary>
        /// <remarks>
        /// Returns the mappers for the audit trail types.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productType">The type of product related to the audit trail. (optional)</param>
        /// <param name="moduleType">The module within the product associated with the audit trail. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-mappers/">REST API Reference for GetAuditTrailMappers Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        ApiResponse<ObjectWrapper> GetAuditTrailMappersWithHttpInfo(ProductType? productType = default, ModuleType? moduleType = default);
        /// <summary>
        /// Get audit trail types
        /// </summary>
        /// <remarks>
        /// Returns all the available audit trail types.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-types/">REST API Reference for GetAuditTrailTypes Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        ObjectWrapper GetAuditTrailTypes();

        /// <summary>
        /// Get audit trail types
        /// </summary>
        /// <remarks>
        /// Returns all the available audit trail types.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-types/">REST API Reference for GetAuditTrailTypes Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        ApiResponse<ObjectWrapper> GetAuditTrailTypesWithHttpInfo();
        /// <summary>
        /// Get audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest changes (creation, modification, deletion, etc.) made by users to the entities on the portal.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-last-audit-events/">REST API Reference for GetLastAuditEvents Operation</seealso>
        /// <returns>AuditEventArrayWrapper</returns>
        AuditEventArrayWrapper GetLastAuditEvents();

        /// <summary>
        /// Get audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest changes (creation, modification, deletion, etc.) made by users to the entities on the portal.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-last-audit-events/">REST API Reference for GetLastAuditEvents Operation</seealso>
        /// <returns>ApiResponse of AuditEventArrayWrapper</returns>
        ApiResponse<AuditEventArrayWrapper> GetLastAuditEventsWithHttpInfo();
        /// <summary>
        /// Set the audit trail settings
        /// </summary>
        /// <remarks>
        /// Sets the audit trail settings for the current portal.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAuditSettingsWrapper"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-audit-settings/">REST API Reference for SetAuditSettings Operation</seealso>
        /// <returns>TenantAuditSettingsWrapper</returns>
        TenantAuditSettingsWrapper SetAuditSettings(TenantAuditSettingsWrapper? tenantAuditSettingsWrapper = default);

        /// <summary>
        /// Set the audit trail settings
        /// </summary>
        /// <remarks>
        /// Sets the audit trail settings for the current portal.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAuditSettingsWrapper"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-audit-settings/">REST API Reference for SetAuditSettings Operation</seealso>
        /// <returns>ApiResponse of TenantAuditSettingsWrapper</returns>
        ApiResponse<TenantAuditSettingsWrapper> SetAuditSettingsWithHttpInfo(TenantAuditSettingsWrapper? tenantAuditSettingsWrapper = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISecurityAuditTrailDataApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Generate the audit trail report
        /// </summary>
        /// <remarks>
        /// Generates the audit trail report.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-audit-trail-report/">REST API Reference for CreateAuditTrailReport Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        System.Threading.Tasks.Task<StringWrapper> CreateAuditTrailReportAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate the audit trail report
        /// </summary>
        /// <remarks>
        /// Generates the audit trail report.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-audit-trail-report/">REST API Reference for CreateAuditTrailReport Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringWrapper>> CreateAuditTrailReportWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get filtered audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the audit events by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user who triggered the audit event. (optional)</param>
        /// <param name="productType">The type of product related to the audit event. (optional)</param>
        /// <param name="moduleType">The module within the product where the audit event occurred. (optional)</param>
        /// <param name="actionType">The type of action performed in the audit event (e.g., Create, Update, Delete). (optional)</param>
        /// <param name="action">The specific action that occurred within the audit event. (optional)</param>
        /// <param name="entryType">The type of audit entry (e.g., Folder, User, File). (optional)</param>
        /// <param name="target">The target object affected by the audit event (e.g., document ID, user account). (optional)</param>
        /// <param name="from">The starting date and time for filtering audit events. (optional)</param>
        /// <param name="to">The ending date and time for filtering audit events. (optional)</param>
        /// <param name="count">The maximum number of audit event records to retrieve. (optional)</param>
        /// <param name="startIndex">The index of the first audit event record to retrieve in a paged query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-events-by-filter/">REST API Reference for GetAuditEventsByFilter Operation</seealso>
        /// <returns>Task of AuditEventArrayWrapper</returns>
        System.Threading.Tasks.Task<AuditEventArrayWrapper> GetAuditEventsByFilterAsync(Guid? userId = default, ProductType? productType = default, ModuleType? moduleType = default, ActionType? actionType = default, MessageAction? action = default, EntryType? entryType = default, string? target = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get filtered audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the audit events by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user who triggered the audit event. (optional)</param>
        /// <param name="productType">The type of product related to the audit event. (optional)</param>
        /// <param name="moduleType">The module within the product where the audit event occurred. (optional)</param>
        /// <param name="actionType">The type of action performed in the audit event (e.g., Create, Update, Delete). (optional)</param>
        /// <param name="action">The specific action that occurred within the audit event. (optional)</param>
        /// <param name="entryType">The type of audit entry (e.g., Folder, User, File). (optional)</param>
        /// <param name="target">The target object affected by the audit event (e.g., document ID, user account). (optional)</param>
        /// <param name="from">The starting date and time for filtering audit events. (optional)</param>
        /// <param name="to">The ending date and time for filtering audit events. (optional)</param>
        /// <param name="count">The maximum number of audit event records to retrieve. (optional)</param>
        /// <param name="startIndex">The index of the first audit event record to retrieve in a paged query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-events-by-filter/">REST API Reference for GetAuditEventsByFilter Operation</seealso>
        /// <returns>Task of ApiResponse (AuditEventArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuditEventArrayWrapper>> GetAuditEventsByFilterWithHttpInfoAsync(Guid? userId = default, ProductType? productType = default, ModuleType? moduleType = default, ActionType? actionType = default, MessageAction? action = default, EntryType? entryType = default, string? target = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the audit trail settings
        /// </summary>
        /// <remarks>
        /// Returns the audit trail settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-settings/">REST API Reference for GetAuditSettings Operation</seealso>
        /// <returns>Task of TenantAuditSettingsWrapper</returns>
        System.Threading.Tasks.Task<TenantAuditSettingsWrapper> GetAuditSettingsAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the audit trail settings
        /// </summary>
        /// <remarks>
        /// Returns the audit trail settings.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-settings/">REST API Reference for GetAuditSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantAuditSettingsWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<TenantAuditSettingsWrapper>> GetAuditSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get audit trail mappers
        /// </summary>
        /// <remarks>
        /// Returns the mappers for the audit trail types.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productType">The type of product related to the audit trail. (optional)</param>
        /// <param name="moduleType">The module within the product associated with the audit trail. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-mappers/">REST API Reference for GetAuditTrailMappers Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        System.Threading.Tasks.Task<ObjectWrapper> GetAuditTrailMappersAsync(ProductType? productType = default, ModuleType? moduleType = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get audit trail mappers
        /// </summary>
        /// <remarks>
        /// Returns the mappers for the audit trail types.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productType">The type of product related to the audit trail. (optional)</param>
        /// <param name="moduleType">The module within the product associated with the audit trail. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-mappers/">REST API Reference for GetAuditTrailMappers Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<ObjectWrapper>> GetAuditTrailMappersWithHttpInfoAsync(ProductType? productType = default, ModuleType? moduleType = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get audit trail types
        /// </summary>
        /// <remarks>
        /// Returns all the available audit trail types.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-types/">REST API Reference for GetAuditTrailTypes Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        System.Threading.Tasks.Task<ObjectWrapper> GetAuditTrailTypesAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get audit trail types
        /// </summary>
        /// <remarks>
        /// Returns all the available audit trail types.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-types/">REST API Reference for GetAuditTrailTypes Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<ObjectWrapper>> GetAuditTrailTypesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest changes (creation, modification, deletion, etc.) made by users to the entities on the portal.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-last-audit-events/">REST API Reference for GetLastAuditEvents Operation</seealso>
        /// <returns>Task of AuditEventArrayWrapper</returns>
        System.Threading.Tasks.Task<AuditEventArrayWrapper> GetLastAuditEventsAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest changes (creation, modification, deletion, etc.) made by users to the entities on the portal.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-last-audit-events/">REST API Reference for GetLastAuditEvents Operation</seealso>
        /// <returns>Task of ApiResponse (AuditEventArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuditEventArrayWrapper>> GetLastAuditEventsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the audit trail settings
        /// </summary>
        /// <remarks>
        /// Sets the audit trail settings for the current portal.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAuditSettingsWrapper"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-audit-settings/">REST API Reference for SetAuditSettings Operation</seealso>
        /// <returns>Task of TenantAuditSettingsWrapper</returns>
        System.Threading.Tasks.Task<TenantAuditSettingsWrapper> SetAuditSettingsAsync(TenantAuditSettingsWrapper? tenantAuditSettingsWrapper = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set the audit trail settings
        /// </summary>
        /// <remarks>
        /// Sets the audit trail settings for the current portal.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAuditSettingsWrapper"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-audit-settings/">REST API Reference for SetAuditSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantAuditSettingsWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<TenantAuditSettingsWrapper>> SetAuditSettingsWithHttpInfoAsync(TenantAuditSettingsWrapper? tenantAuditSettingsWrapper = default, System.Threading.CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISecurityAuditTrailDataApi : ISecurityAuditTrailDataApiSync, ISecurityAuditTrailDataApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SecurityAuditTrailDataApi : IDisposable, ISecurityAuditTrailDataApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAuditTrailDataApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public SecurityAuditTrailDataApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAuditTrailDataApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public SecurityAuditTrailDataApi(string basePath)
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
        /// Initializes a new instance of the <see cref="SecurityAuditTrailDataApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public SecurityAuditTrailDataApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="SecurityAuditTrailDataApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public SecurityAuditTrailDataApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAuditTrailDataApi"/> class.
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
        public SecurityAuditTrailDataApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="SecurityAuditTrailDataApi"/> class using a Configuration object.
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
        public SecurityAuditTrailDataApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="SecurityAuditTrailDataApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SecurityAuditTrailDataApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Generate the audit trail report Generates the audit trail report.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-audit-trail-report/">REST API Reference for CreateAuditTrailReport Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper CreateAuditTrailReport()
        {
            var localVarResponse = CreateAuditTrailReportWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Generate the audit trail report Generates the audit trail report.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-audit-trail-report/">REST API Reference for CreateAuditTrailReport Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> CreateAuditTrailReportWithHttpInfo()
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
            var localVarResponse = this.Client.Post<StringWrapper>("/api/2.0/security/audit/events/report", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CreateAuditTrailReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Generate the audit trail report Generates the audit trail report.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-audit-trail-report/">REST API Reference for CreateAuditTrailReport Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async System.Threading.Tasks.Task<StringWrapper> CreateAuditTrailReportAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<StringWrapper> localVarResponse = await CreateAuditTrailReportWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Generate the audit trail report Generates the audit trail report.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-audit-trail-report/">REST API Reference for CreateAuditTrailReport Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StringWrapper>> CreateAuditTrailReportWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
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

            var localVarResponse = await this.AsynchronousClient.PostAsync<StringWrapper>("/api/2.0/security/audit/events/report", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CreateAuditTrailReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get filtered audit trail data Returns a list of the audit events by the parameters specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user who triggered the audit event. (optional)</param>
        /// <param name="productType">The type of product related to the audit event. (optional)</param>
        /// <param name="moduleType">The module within the product where the audit event occurred. (optional)</param>
        /// <param name="actionType">The type of action performed in the audit event (e.g., Create, Update, Delete). (optional)</param>
        /// <param name="action">The specific action that occurred within the audit event. (optional)</param>
        /// <param name="entryType">The type of audit entry (e.g., Folder, User, File). (optional)</param>
        /// <param name="target">The target object affected by the audit event (e.g., document ID, user account). (optional)</param>
        /// <param name="from">The starting date and time for filtering audit events. (optional)</param>
        /// <param name="to">The ending date and time for filtering audit events. (optional)</param>
        /// <param name="count">The maximum number of audit event records to retrieve. (optional)</param>
        /// <param name="startIndex">The index of the first audit event record to retrieve in a paged query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-events-by-filter/">REST API Reference for GetAuditEventsByFilter Operation</seealso>
        /// <returns>AuditEventArrayWrapper</returns>
        public AuditEventArrayWrapper GetAuditEventsByFilter(Guid? userId = default, ProductType? productType = default, ModuleType? moduleType = default, ActionType? actionType = default, MessageAction? action = default, EntryType? entryType = default, string? target = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default)
        {
            var localVarResponse = GetAuditEventsByFilterWithHttpInfo(userId, productType, moduleType, actionType, action, entryType, target, from, to, count, startIndex);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get filtered audit trail data Returns a list of the audit events by the parameters specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user who triggered the audit event. (optional)</param>
        /// <param name="productType">The type of product related to the audit event. (optional)</param>
        /// <param name="moduleType">The module within the product where the audit event occurred. (optional)</param>
        /// <param name="actionType">The type of action performed in the audit event (e.g., Create, Update, Delete). (optional)</param>
        /// <param name="action">The specific action that occurred within the audit event. (optional)</param>
        /// <param name="entryType">The type of audit entry (e.g., Folder, User, File). (optional)</param>
        /// <param name="target">The target object affected by the audit event (e.g., document ID, user account). (optional)</param>
        /// <param name="from">The starting date and time for filtering audit events. (optional)</param>
        /// <param name="to">The ending date and time for filtering audit events. (optional)</param>
        /// <param name="count">The maximum number of audit event records to retrieve. (optional)</param>
        /// <param name="startIndex">The index of the first audit event record to retrieve in a paged query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-events-by-filter/">REST API Reference for GetAuditEventsByFilter Operation</seealso>
        /// <returns>ApiResponse of AuditEventArrayWrapper</returns>
        public ApiResponse<AuditEventArrayWrapper> GetAuditEventsByFilterWithHttpInfo(Guid? userId = default, ProductType? productType = default, ModuleType? moduleType = default, ActionType? actionType = default, MessageAction? action = default, EntryType? entryType = default, string? target = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userId", userId));
            }
            if (productType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "productType", productType));
            }
            if (moduleType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "moduleType", moduleType));
            }
            if (actionType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "actionType", actionType));
            }
            if (action != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "action", action));
            }
            if (entryType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entryType", entryType));
            }
            if (target != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "target", target));
            }
            if (from != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "from", from));
            }
            if (to != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "to", to));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
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
            var localVarResponse = this.Client.Get<AuditEventArrayWrapper>("/api/2.0/security/audit/events/filter", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetAuditEventsByFilter", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get filtered audit trail data Returns a list of the audit events by the parameters specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user who triggered the audit event. (optional)</param>
        /// <param name="productType">The type of product related to the audit event. (optional)</param>
        /// <param name="moduleType">The module within the product where the audit event occurred. (optional)</param>
        /// <param name="actionType">The type of action performed in the audit event (e.g., Create, Update, Delete). (optional)</param>
        /// <param name="action">The specific action that occurred within the audit event. (optional)</param>
        /// <param name="entryType">The type of audit entry (e.g., Folder, User, File). (optional)</param>
        /// <param name="target">The target object affected by the audit event (e.g., document ID, user account). (optional)</param>
        /// <param name="from">The starting date and time for filtering audit events. (optional)</param>
        /// <param name="to">The ending date and time for filtering audit events. (optional)</param>
        /// <param name="count">The maximum number of audit event records to retrieve. (optional)</param>
        /// <param name="startIndex">The index of the first audit event record to retrieve in a paged query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-events-by-filter/">REST API Reference for GetAuditEventsByFilter Operation</seealso>
        /// <returns>Task of AuditEventArrayWrapper</returns>
        public async System.Threading.Tasks.Task<AuditEventArrayWrapper> GetAuditEventsByFilterAsync(Guid? userId = default, ProductType? productType = default, ModuleType? moduleType = default, ActionType? actionType = default, MessageAction? action = default, EntryType? entryType = default, string? target = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AuditEventArrayWrapper> localVarResponse = await GetAuditEventsByFilterWithHttpInfoAsync(userId, productType, moduleType, actionType, action, entryType, target, from, to, count, startIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get filtered audit trail data Returns a list of the audit events by the parameters specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user who triggered the audit event. (optional)</param>
        /// <param name="productType">The type of product related to the audit event. (optional)</param>
        /// <param name="moduleType">The module within the product where the audit event occurred. (optional)</param>
        /// <param name="actionType">The type of action performed in the audit event (e.g., Create, Update, Delete). (optional)</param>
        /// <param name="action">The specific action that occurred within the audit event. (optional)</param>
        /// <param name="entryType">The type of audit entry (e.g., Folder, User, File). (optional)</param>
        /// <param name="target">The target object affected by the audit event (e.g., document ID, user account). (optional)</param>
        /// <param name="from">The starting date and time for filtering audit events. (optional)</param>
        /// <param name="to">The ending date and time for filtering audit events. (optional)</param>
        /// <param name="count">The maximum number of audit event records to retrieve. (optional)</param>
        /// <param name="startIndex">The index of the first audit event record to retrieve in a paged query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-events-by-filter/">REST API Reference for GetAuditEventsByFilter Operation</seealso>
        /// <returns>Task of ApiResponse (AuditEventArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuditEventArrayWrapper>> GetAuditEventsByFilterWithHttpInfoAsync(Guid? userId = default, ProductType? productType = default, ModuleType? moduleType = default, ActionType? actionType = default, MessageAction? action = default, EntryType? entryType = default, string? target = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "userId", userId));
            }
            if (productType != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "productType", productType));
            }
            if (moduleType != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "moduleType", moduleType));
            }
            if (actionType != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "actionType", actionType));
            }
            if (action != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "action", action));
            }
            if (entryType != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "entryType", entryType));
            }
            if (target != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "target", target));
            }
            if (from != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "from", from));
            }
            if (to != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "to", to));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<AuditEventArrayWrapper>("/api/2.0/security/audit/events/filter", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetAuditEventsByFilter", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the audit trail settings Returns the audit trail settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-settings/">REST API Reference for GetAuditSettings Operation</seealso>
        /// <returns>TenantAuditSettingsWrapper</returns>
        public TenantAuditSettingsWrapper GetAuditSettings()
        {
            var localVarResponse = GetAuditSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the audit trail settings Returns the audit trail settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-settings/">REST API Reference for GetAuditSettings Operation</seealso>
        /// <returns>ApiResponse of TenantAuditSettingsWrapper</returns>
        public ApiResponse<TenantAuditSettingsWrapper> GetAuditSettingsWithHttpInfo()
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
            var localVarResponse = this.Client.Get<TenantAuditSettingsWrapper>("/api/2.0/security/audit/settings/lifetime", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetAuditSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the audit trail settings Returns the audit trail settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-settings/">REST API Reference for GetAuditSettings Operation</seealso>
        /// <returns>Task of TenantAuditSettingsWrapper</returns>
        public async System.Threading.Tasks.Task<TenantAuditSettingsWrapper> GetAuditSettingsAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<TenantAuditSettingsWrapper> localVarResponse = await GetAuditSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the audit trail settings Returns the audit trail settings.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-settings/">REST API Reference for GetAuditSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantAuditSettingsWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TenantAuditSettingsWrapper>> GetAuditSettingsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<TenantAuditSettingsWrapper>("/api/2.0/security/audit/settings/lifetime", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetAuditSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get audit trail mappers Returns the mappers for the audit trail types.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productType">The type of product related to the audit trail. (optional)</param>
        /// <param name="moduleType">The module within the product associated with the audit trail. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-mappers/">REST API Reference for GetAuditTrailMappers Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        public ObjectWrapper GetAuditTrailMappers(ProductType? productType = default, ModuleType? moduleType = default)
        {
            var localVarResponse = GetAuditTrailMappersWithHttpInfo(productType, moduleType);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get audit trail mappers Returns the mappers for the audit trail types.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productType">The type of product related to the audit trail. (optional)</param>
        /// <param name="moduleType">The module within the product associated with the audit trail. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-mappers/">REST API Reference for GetAuditTrailMappers Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        public ApiResponse<ObjectWrapper> GetAuditTrailMappersWithHttpInfo(ProductType? productType = default, ModuleType? moduleType = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (productType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "productType", productType));
            }
            if (moduleType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "moduleType", moduleType));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<ObjectWrapper>("/api/2.0/security/audit/mappers", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetAuditTrailMappers", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get audit trail mappers Returns the mappers for the audit trail types.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productType">The type of product related to the audit trail. (optional)</param>
        /// <param name="moduleType">The module within the product associated with the audit trail. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-mappers/">REST API Reference for GetAuditTrailMappers Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        public async System.Threading.Tasks.Task<ObjectWrapper> GetAuditTrailMappersAsync(ProductType? productType = default, ModuleType? moduleType = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ObjectWrapper> localVarResponse = await GetAuditTrailMappersWithHttpInfoAsync(productType, moduleType, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get audit trail mappers Returns the mappers for the audit trail types.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productType">The type of product related to the audit trail. (optional)</param>
        /// <param name="moduleType">The module within the product associated with the audit trail. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-mappers/">REST API Reference for GetAuditTrailMappers Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ObjectWrapper>> GetAuditTrailMappersWithHttpInfoAsync(ProductType? productType = default, ModuleType? moduleType = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (productType != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "productType", productType));
            }
            if (moduleType != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "moduleType", moduleType));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ObjectWrapper>("/api/2.0/security/audit/mappers", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetAuditTrailMappers", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get audit trail types Returns all the available audit trail types.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-types/">REST API Reference for GetAuditTrailTypes Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        public ObjectWrapper GetAuditTrailTypes()
        {
            var localVarResponse = GetAuditTrailTypesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get audit trail types Returns all the available audit trail types.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-types/">REST API Reference for GetAuditTrailTypes Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        public ApiResponse<ObjectWrapper> GetAuditTrailTypesWithHttpInfo()
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
            var localVarResponse = this.Client.Get<ObjectWrapper>("/api/2.0/security/audit/types", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetAuditTrailTypes", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get audit trail types Returns all the available audit trail types.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-types/">REST API Reference for GetAuditTrailTypes Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        public async System.Threading.Tasks.Task<ObjectWrapper> GetAuditTrailTypesAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ObjectWrapper> localVarResponse = await GetAuditTrailTypesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get audit trail types Returns all the available audit trail types.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-types/">REST API Reference for GetAuditTrailTypes Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ObjectWrapper>> GetAuditTrailTypesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<ObjectWrapper>("/api/2.0/security/audit/types", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetAuditTrailTypes", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get audit trail data Returns a list of the latest changes (creation, modification, deletion, etc.) made by users to the entities on the portal.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-last-audit-events/">REST API Reference for GetLastAuditEvents Operation</seealso>
        /// <returns>AuditEventArrayWrapper</returns>
        public AuditEventArrayWrapper GetLastAuditEvents()
        {
            var localVarResponse = GetLastAuditEventsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get audit trail data Returns a list of the latest changes (creation, modification, deletion, etc.) made by users to the entities on the portal.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-last-audit-events/">REST API Reference for GetLastAuditEvents Operation</seealso>
        /// <returns>ApiResponse of AuditEventArrayWrapper</returns>
        public ApiResponse<AuditEventArrayWrapper> GetLastAuditEventsWithHttpInfo()
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
            var localVarResponse = this.Client.Get<AuditEventArrayWrapper>("/api/2.0/security/audit/events/last", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetLastAuditEvents", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get audit trail data Returns a list of the latest changes (creation, modification, deletion, etc.) made by users to the entities on the portal.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-last-audit-events/">REST API Reference for GetLastAuditEvents Operation</seealso>
        /// <returns>Task of AuditEventArrayWrapper</returns>
        public async System.Threading.Tasks.Task<AuditEventArrayWrapper> GetLastAuditEventsAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AuditEventArrayWrapper> localVarResponse = await GetLastAuditEventsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get audit trail data Returns a list of the latest changes (creation, modification, deletion, etc.) made by users to the entities on the portal.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-last-audit-events/">REST API Reference for GetLastAuditEvents Operation</seealso>
        /// <returns>Task of ApiResponse (AuditEventArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuditEventArrayWrapper>> GetLastAuditEventsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<AuditEventArrayWrapper>("/api/2.0/security/audit/events/last", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetLastAuditEvents", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the audit trail settings Sets the audit trail settings for the current portal.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAuditSettingsWrapper"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-audit-settings/">REST API Reference for SetAuditSettings Operation</seealso>
        /// <returns>TenantAuditSettingsWrapper</returns>
        public TenantAuditSettingsWrapper SetAuditSettings(TenantAuditSettingsWrapper? tenantAuditSettingsWrapper = default)
        {
            var localVarResponse = SetAuditSettingsWithHttpInfo(tenantAuditSettingsWrapper);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the audit trail settings Sets the audit trail settings for the current portal.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAuditSettingsWrapper"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-audit-settings/">REST API Reference for SetAuditSettings Operation</seealso>
        /// <returns>ApiResponse of TenantAuditSettingsWrapper</returns>
        public ApiResponse<TenantAuditSettingsWrapper> SetAuditSettingsWithHttpInfo(TenantAuditSettingsWrapper? tenantAuditSettingsWrapper = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (tenantAuditSettingsWrapper != null) localVarRequestOptions.Data = tenantAuditSettingsWrapper;

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
            var localVarResponse = this.Client.Post<TenantAuditSettingsWrapper>("/api/2.0/security/audit/settings/lifetime", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SetAuditSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the audit trail settings Sets the audit trail settings for the current portal.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAuditSettingsWrapper"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-audit-settings/">REST API Reference for SetAuditSettings Operation</seealso>
        /// <returns>Task of TenantAuditSettingsWrapper</returns>
        public async System.Threading.Tasks.Task<TenantAuditSettingsWrapper> SetAuditSettingsAsync(TenantAuditSettingsWrapper? tenantAuditSettingsWrapper = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<TenantAuditSettingsWrapper> localVarResponse = await SetAuditSettingsWithHttpInfoAsync(tenantAuditSettingsWrapper, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the audit trail settings Sets the audit trail settings for the current portal.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAuditSettingsWrapper"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-audit-settings/">REST API Reference for SetAuditSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantAuditSettingsWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TenantAuditSettingsWrapper>> SetAuditSettingsWithHttpInfoAsync(TenantAuditSettingsWrapper? tenantAuditSettingsWrapper = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (tenantAuditSettingsWrapper != null) localVarRequestOptions.Data = tenantAuditSettingsWrapper;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<TenantAuditSettingsWrapper>("/api/2.0/security/audit/settings/lifetime", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SetAuditSettings", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

    }
}
