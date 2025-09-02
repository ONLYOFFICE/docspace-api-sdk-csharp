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
namespace DocSpace.API.SDK.Api.Security
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuditTrailDataApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Generate the audit trail report
        /// </summary>
        /// <remarks>
        /// Generates the audit trail report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-audit-trail-report/">REST API Reference for CreateAuditTrailReport Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper CreateAuditTrailReport();

        /// <summary>
        /// Generate the audit trail report
        /// </summary>
        /// <remarks>
        /// Generates the audit trail report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-audit-trail-report/">REST API Reference for CreateAuditTrailReport Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> CreateAuditTrailReportWithHttpInfo();
        /// <summary>
        /// Get filtered audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the audit events by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user who triggered the audit event. (optional)</param>
        /// <param name="moduleType">The location where the audit event occurred. (optional)</param>
        /// <param name="actionType">The type of action performed in the audit event (e.g., Create, Update, Delete). (optional)</param>
        /// <param name="action">The specific action that occurred within the audit event. (optional)</param>
        /// <param name="entryType">The type of audit entry (e.g., Folder, User, File). (optional)</param>
        /// <param name="target">The target object affected by the audit event (e.g., document ID, user account). (optional)</param>
        /// <param name="from">The starting date and time for filtering audit events. (optional)</param>
        /// <param name="to">The ending date and time for filtering audit events. (optional)</param>
        /// <param name="count">The maximum number of audit event records to retrieve. (optional)</param>
        /// <param name="startIndex">The index of the first audit event record to retrieve in a paged query. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-events-by-filter/">REST API Reference for GetAuditEventsByFilter Operation</seealso>
        /// <returns>AuditEventArrayWrapper</returns>
        AuditEventArrayWrapper GetAuditEventsByFilter(Guid? userId = default, LocationType? moduleType = default, ActionType? actionType = default, MessageAction? action = default, EntryType? entryType = default, string? target = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default, string fields = default);

        /// <summary>
        /// Get filtered audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the audit events by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user who triggered the audit event. (optional)</param>
        /// <param name="moduleType">The location where the audit event occurred. (optional)</param>
        /// <param name="actionType">The type of action performed in the audit event (e.g., Create, Update, Delete). (optional)</param>
        /// <param name="action">The specific action that occurred within the audit event. (optional)</param>
        /// <param name="entryType">The type of audit entry (e.g., Folder, User, File). (optional)</param>
        /// <param name="target">The target object affected by the audit event (e.g., document ID, user account). (optional)</param>
        /// <param name="from">The starting date and time for filtering audit events. (optional)</param>
        /// <param name="to">The ending date and time for filtering audit events. (optional)</param>
        /// <param name="count">The maximum number of audit event records to retrieve. (optional)</param>
        /// <param name="startIndex">The index of the first audit event record to retrieve in a paged query. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-events-by-filter/">REST API Reference for GetAuditEventsByFilter Operation</seealso>
        /// <returns>ApiResponse of AuditEventArrayWrapper</returns>
        ApiResponse<AuditEventArrayWrapper> GetAuditEventsByFilterWithHttpInfo(Guid? userId = default, LocationType? moduleType = default, ActionType? actionType = default, MessageAction? action = default, EntryType? entryType = default, string? target = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default, string fields = default);
        /// <summary>
        /// Get the audit trail settings
        /// </summary>
        /// <remarks>
        /// Returns the audit trail settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-settings/">REST API Reference for GetAuditSettings Operation</seealso>
        /// <returns>TenantAuditSettingsWrapper</returns>
        TenantAuditSettingsWrapper GetAuditSettings();

        /// <summary>
        /// Get the audit trail settings
        /// </summary>
        /// <remarks>
        /// Returns the audit trail settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-settings/">REST API Reference for GetAuditSettings Operation</seealso>
        /// <returns>ApiResponse of TenantAuditSettingsWrapper</returns>
        ApiResponse<TenantAuditSettingsWrapper> GetAuditSettingsWithHttpInfo();
        /// <summary>
        /// Get audit trail mappers
        /// </summary>
        /// <remarks>
        /// Returns the mappers for the audit trail types.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productType">The type of product related to the audit trail. (optional)</param>
        /// <param name="moduleType">The location associated with the audit trail. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-mappers/">REST API Reference for GetAuditTrailMappers Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        ObjectWrapper GetAuditTrailMappers(ProductType? productType = default, LocationType? moduleType = default);

        /// <summary>
        /// Get audit trail mappers
        /// </summary>
        /// <remarks>
        /// Returns the mappers for the audit trail types.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productType">The type of product related to the audit trail. (optional)</param>
        /// <param name="moduleType">The location associated with the audit trail. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-mappers/">REST API Reference for GetAuditTrailMappers Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        ApiResponse<ObjectWrapper> GetAuditTrailMappersWithHttpInfo(ProductType? productType = default, LocationType? moduleType = default);
        /// <summary>
        /// Get audit trail types
        /// </summary>
        /// <remarks>
        /// Returns all the available audit trail types.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-types/">REST API Reference for GetAuditTrailTypes Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        ObjectWrapper GetAuditTrailTypes();

        /// <summary>
        /// Get audit trail types
        /// </summary>
        /// <remarks>
        /// Returns all the available audit trail types.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-types/">REST API Reference for GetAuditTrailTypes Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        ApiResponse<ObjectWrapper> GetAuditTrailTypesWithHttpInfo();
        /// <summary>
        /// Get audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest changes (creation, modification, deletion, etc.) made by users to the entities on the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-last-audit-events/">REST API Reference for GetLastAuditEvents Operation</seealso>
        /// <returns>AuditEventArrayWrapper</returns>
        AuditEventArrayWrapper GetLastAuditEvents();

        /// <summary>
        /// Get audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest changes (creation, modification, deletion, etc.) made by users to the entities on the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-last-audit-events/">REST API Reference for GetLastAuditEvents Operation</seealso>
        /// <returns>ApiResponse of AuditEventArrayWrapper</returns>
        ApiResponse<AuditEventArrayWrapper> GetLastAuditEventsWithHttpInfo();
        /// <summary>
        /// Set the audit trail settings
        /// </summary>
        /// <remarks>
        /// Sets the audit trail settings for the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAuditSettingsWrapper">The tenant audit settings wrapper. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-audit-settings/">REST API Reference for SetAuditSettings Operation</seealso>
        /// <returns>TenantAuditSettingsWrapper</returns>
        TenantAuditSettingsWrapper SetAuditSettings(TenantAuditSettingsWrapper? tenantAuditSettingsWrapper = default);

        /// <summary>
        /// Set the audit trail settings
        /// </summary>
        /// <remarks>
        /// Sets the audit trail settings for the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAuditSettingsWrapper">The tenant audit settings wrapper. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-audit-settings/">REST API Reference for SetAuditSettings Operation</seealso>
        /// <returns>ApiResponse of TenantAuditSettingsWrapper</returns>
        ApiResponse<TenantAuditSettingsWrapper> SetAuditSettingsWithHttpInfo(TenantAuditSettingsWrapper? tenantAuditSettingsWrapper = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuditTrailDataApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Generate the audit trail report
        /// </summary>
        /// <remarks>
        /// Generates the audit trail report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-audit-trail-report/">REST API Reference for CreateAuditTrailReport Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> CreateAuditTrailReportAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate the audit trail report
        /// </summary>
        /// <remarks>
        /// Generates the audit trail report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-audit-trail-report/">REST API Reference for CreateAuditTrailReport Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> CreateAuditTrailReportWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get filtered audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the audit events by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user who triggered the audit event. (optional)</param>
        /// <param name="moduleType">The location where the audit event occurred. (optional)</param>
        /// <param name="actionType">The type of action performed in the audit event (e.g., Create, Update, Delete). (optional)</param>
        /// <param name="action">The specific action that occurred within the audit event. (optional)</param>
        /// <param name="entryType">The type of audit entry (e.g., Folder, User, File). (optional)</param>
        /// <param name="target">The target object affected by the audit event (e.g., document ID, user account). (optional)</param>
        /// <param name="from">The starting date and time for filtering audit events. (optional)</param>
        /// <param name="to">The ending date and time for filtering audit events. (optional)</param>
        /// <param name="count">The maximum number of audit event records to retrieve. (optional)</param>
        /// <param name="startIndex">The index of the first audit event record to retrieve in a paged query. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-events-by-filter/">REST API Reference for GetAuditEventsByFilter Operation</seealso>
        /// <returns>Task of AuditEventArrayWrapper</returns>
        Task<AuditEventArrayWrapper> GetAuditEventsByFilterAsync(Guid? userId = default, LocationType? moduleType = default, ActionType? actionType = default, MessageAction? action = default, EntryType? entryType = default, string? target = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default, string fields = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get filtered audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the audit events by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user who triggered the audit event. (optional)</param>
        /// <param name="moduleType">The location where the audit event occurred. (optional)</param>
        /// <param name="actionType">The type of action performed in the audit event (e.g., Create, Update, Delete). (optional)</param>
        /// <param name="action">The specific action that occurred within the audit event. (optional)</param>
        /// <param name="entryType">The type of audit entry (e.g., Folder, User, File). (optional)</param>
        /// <param name="target">The target object affected by the audit event (e.g., document ID, user account). (optional)</param>
        /// <param name="from">The starting date and time for filtering audit events. (optional)</param>
        /// <param name="to">The ending date and time for filtering audit events. (optional)</param>
        /// <param name="count">The maximum number of audit event records to retrieve. (optional)</param>
        /// <param name="startIndex">The index of the first audit event record to retrieve in a paged query. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-events-by-filter/">REST API Reference for GetAuditEventsByFilter Operation</seealso>
        /// <returns>Task of ApiResponse (AuditEventArrayWrapper)</returns>
        Task<ApiResponse<AuditEventArrayWrapper>> GetAuditEventsByFilterWithHttpInfoAsync(Guid? userId = default, LocationType? moduleType = default, ActionType? actionType = default, MessageAction? action = default, EntryType? entryType = default, string? target = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default, string fields = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the audit trail settings
        /// </summary>
        /// <remarks>
        /// Returns the audit trail settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-settings/">REST API Reference for GetAuditSettings Operation</seealso>
        /// <returns>Task of TenantAuditSettingsWrapper</returns>
        Task<TenantAuditSettingsWrapper> GetAuditSettingsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the audit trail settings
        /// </summary>
        /// <remarks>
        /// Returns the audit trail settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-settings/">REST API Reference for GetAuditSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantAuditSettingsWrapper)</returns>
        Task<ApiResponse<TenantAuditSettingsWrapper>> GetAuditSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get audit trail mappers
        /// </summary>
        /// <remarks>
        /// Returns the mappers for the audit trail types.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productType">The type of product related to the audit trail. (optional)</param>
        /// <param name="moduleType">The location associated with the audit trail. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-mappers/">REST API Reference for GetAuditTrailMappers Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        Task<ObjectWrapper> GetAuditTrailMappersAsync(ProductType? productType = default, LocationType? moduleType = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get audit trail mappers
        /// </summary>
        /// <remarks>
        /// Returns the mappers for the audit trail types.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productType">The type of product related to the audit trail. (optional)</param>
        /// <param name="moduleType">The location associated with the audit trail. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-mappers/">REST API Reference for GetAuditTrailMappers Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        Task<ApiResponse<ObjectWrapper>> GetAuditTrailMappersWithHttpInfoAsync(ProductType? productType = default, LocationType? moduleType = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get audit trail types
        /// </summary>
        /// <remarks>
        /// Returns all the available audit trail types.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-types/">REST API Reference for GetAuditTrailTypes Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        Task<ObjectWrapper> GetAuditTrailTypesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get audit trail types
        /// </summary>
        /// <remarks>
        /// Returns all the available audit trail types.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-types/">REST API Reference for GetAuditTrailTypes Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        Task<ApiResponse<ObjectWrapper>> GetAuditTrailTypesWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest changes (creation, modification, deletion, etc.) made by users to the entities on the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-last-audit-events/">REST API Reference for GetLastAuditEvents Operation</seealso>
        /// <returns>Task of AuditEventArrayWrapper</returns>
        Task<AuditEventArrayWrapper> GetLastAuditEventsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest changes (creation, modification, deletion, etc.) made by users to the entities on the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-last-audit-events/">REST API Reference for GetLastAuditEvents Operation</seealso>
        /// <returns>Task of ApiResponse (AuditEventArrayWrapper)</returns>
        Task<ApiResponse<AuditEventArrayWrapper>> GetLastAuditEventsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the audit trail settings
        /// </summary>
        /// <remarks>
        /// Sets the audit trail settings for the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAuditSettingsWrapper">The tenant audit settings wrapper. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-audit-settings/">REST API Reference for SetAuditSettings Operation</seealso>
        /// <returns>Task of TenantAuditSettingsWrapper</returns>
        Task<TenantAuditSettingsWrapper> SetAuditSettingsAsync(TenantAuditSettingsWrapper? tenantAuditSettingsWrapper = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set the audit trail settings
        /// </summary>
        /// <remarks>
        /// Sets the audit trail settings for the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAuditSettingsWrapper">The tenant audit settings wrapper. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-audit-settings/">REST API Reference for SetAuditSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantAuditSettingsWrapper)</returns>
        Task<ApiResponse<TenantAuditSettingsWrapper>> SetAuditSettingsWithHttpInfoAsync(TenantAuditSettingsWrapper? tenantAuditSettingsWrapper = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuditTrailDataApi : IAuditTrailDataApiSync, IAuditTrailDataApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuditTrailDataApi : IDisposable, IAuditTrailDataApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditTrailDataApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public AuditTrailDataApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditTrailDataApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public AuditTrailDataApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AuditTrailDataApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public AuditTrailDataApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AuditTrailDataApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public AuditTrailDataApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditTrailDataApi"/> class.
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
        public AuditTrailDataApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="AuditTrailDataApi"/> class using a Configuration object.
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
        public AuditTrailDataApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="AuditTrailDataApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public AuditTrailDataApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Generate the audit trail report
        /// </summary>
        /// <remarks>
        /// Generates the audit trail report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-audit-trail-report/">REST API Reference for CreateAuditTrailReport Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper CreateAuditTrailReport()
        {
            var localVarResponse = CreateAuditTrailReportWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Generate the audit trail report
        /// </summary>
        /// <remarks>
        /// Generates the audit trail report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
            var localVarResponse = Client.Post<StringWrapper>("/api/2.0/security/audit/events/report", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateAuditTrailReport", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Generate the audit trail report
        /// </summary>
        /// <remarks>
        /// Generates the audit trail report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-audit-trail-report/">REST API Reference for CreateAuditTrailReport Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> CreateAuditTrailReportAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateAuditTrailReportWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Generate the audit trail report
        /// </summary>
        /// <remarks>
        /// Generates the audit trail report.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-audit-trail-report/">REST API Reference for CreateAuditTrailReport Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async Task<ApiResponse<StringWrapper>> CreateAuditTrailReportWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.PostAsync<StringWrapper>("/api/2.0/security/audit/events/report", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateAuditTrailReport", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get filtered audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the audit events by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user who triggered the audit event. (optional)</param>
        /// <param name="moduleType">The location where the audit event occurred. (optional)</param>
        /// <param name="actionType">The type of action performed in the audit event (e.g., Create, Update, Delete). (optional)</param>
        /// <param name="action">The specific action that occurred within the audit event. (optional)</param>
        /// <param name="entryType">The type of audit entry (e.g., Folder, User, File). (optional)</param>
        /// <param name="target">The target object affected by the audit event (e.g., document ID, user account). (optional)</param>
        /// <param name="from">The starting date and time for filtering audit events. (optional)</param>
        /// <param name="to">The ending date and time for filtering audit events. (optional)</param>
        /// <param name="count">The maximum number of audit event records to retrieve. (optional)</param>
        /// <param name="startIndex">The index of the first audit event record to retrieve in a paged query. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-events-by-filter/">REST API Reference for GetAuditEventsByFilter Operation</seealso>
        /// <returns>AuditEventArrayWrapper</returns>
        public AuditEventArrayWrapper GetAuditEventsByFilter(Guid? userId = default, LocationType? moduleType = default, ActionType? actionType = default, MessageAction? action = default, EntryType? entryType = default, string? target = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default, string fields = default)
        {
            var localVarResponse = GetAuditEventsByFilterWithHttpInfo(userId, moduleType, actionType, action, entryType, target, from, to, count, startIndex, fields);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get filtered audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the audit events by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user who triggered the audit event. (optional)</param>
        /// <param name="moduleType">The location where the audit event occurred. (optional)</param>
        /// <param name="actionType">The type of action performed in the audit event (e.g., Create, Update, Delete). (optional)</param>
        /// <param name="action">The specific action that occurred within the audit event. (optional)</param>
        /// <param name="entryType">The type of audit entry (e.g., Folder, User, File). (optional)</param>
        /// <param name="target">The target object affected by the audit event (e.g., document ID, user account). (optional)</param>
        /// <param name="from">The starting date and time for filtering audit events. (optional)</param>
        /// <param name="to">The ending date and time for filtering audit events. (optional)</param>
        /// <param name="count">The maximum number of audit event records to retrieve. (optional)</param>
        /// <param name="startIndex">The index of the first audit event record to retrieve in a paged query. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-events-by-filter/">REST API Reference for GetAuditEventsByFilter Operation</seealso>
        /// <returns>ApiResponse of AuditEventArrayWrapper</returns>
        public ApiResponse<AuditEventArrayWrapper> GetAuditEventsByFilterWithHttpInfo(Guid? userId = default, LocationType? moduleType = default, ActionType? actionType = default, MessageAction? action = default, EntryType? entryType = default, string? target = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default, string fields = default)
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
            if (fields != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("csv", "fields", fields));
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
            var localVarResponse = Client.Get<AuditEventArrayWrapper>("/api/2.0/security/audit/events/filter", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAuditEventsByFilter", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get filtered audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the audit events by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user who triggered the audit event. (optional)</param>
        /// <param name="moduleType">The location where the audit event occurred. (optional)</param>
        /// <param name="actionType">The type of action performed in the audit event (e.g., Create, Update, Delete). (optional)</param>
        /// <param name="action">The specific action that occurred within the audit event. (optional)</param>
        /// <param name="entryType">The type of audit entry (e.g., Folder, User, File). (optional)</param>
        /// <param name="target">The target object affected by the audit event (e.g., document ID, user account). (optional)</param>
        /// <param name="from">The starting date and time for filtering audit events. (optional)</param>
        /// <param name="to">The ending date and time for filtering audit events. (optional)</param>
        /// <param name="count">The maximum number of audit event records to retrieve. (optional)</param>
        /// <param name="startIndex">The index of the first audit event record to retrieve in a paged query. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-events-by-filter/">REST API Reference for GetAuditEventsByFilter Operation</seealso>
        /// <returns>Task of AuditEventArrayWrapper</returns>
        public async Task<AuditEventArrayWrapper> GetAuditEventsByFilterAsync(Guid? userId = default, LocationType? moduleType = default, ActionType? actionType = default, MessageAction? action = default, EntryType? entryType = default, string? target = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default, string fields = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAuditEventsByFilterWithHttpInfoAsync(userId, moduleType, actionType, action, entryType, target, from, to, count, startIndex, fields, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get filtered audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the audit events by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user who triggered the audit event. (optional)</param>
        /// <param name="moduleType">The location where the audit event occurred. (optional)</param>
        /// <param name="actionType">The type of action performed in the audit event (e.g., Create, Update, Delete). (optional)</param>
        /// <param name="action">The specific action that occurred within the audit event. (optional)</param>
        /// <param name="entryType">The type of audit entry (e.g., Folder, User, File). (optional)</param>
        /// <param name="target">The target object affected by the audit event (e.g., document ID, user account). (optional)</param>
        /// <param name="from">The starting date and time for filtering audit events. (optional)</param>
        /// <param name="to">The ending date and time for filtering audit events. (optional)</param>
        /// <param name="count">The maximum number of audit event records to retrieve. (optional)</param>
        /// <param name="startIndex">The index of the first audit event record to retrieve in a paged query. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-events-by-filter/">REST API Reference for GetAuditEventsByFilter Operation</seealso>
        /// <returns>Task of ApiResponse (AuditEventArrayWrapper)</returns>
        public async Task<ApiResponse<AuditEventArrayWrapper>> GetAuditEventsByFilterWithHttpInfoAsync(Guid? userId = default, LocationType? moduleType = default, ActionType? actionType = default, MessageAction? action = default, EntryType? entryType = default, string? target = default, ApiDateTime? from = default, ApiDateTime? to = default, int? count = default, int? startIndex = default, string fields = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userId", userId));
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
            if (fields != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("csv", "fields", fields));
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

            var localVarResponse = await AsynchronousClient.GetAsync<AuditEventArrayWrapper>("/api/2.0/security/audit/events/filter", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAuditEventsByFilter", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the audit trail settings
        /// </summary>
        /// <remarks>
        /// Returns the audit trail settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-settings/">REST API Reference for GetAuditSettings Operation</seealso>
        /// <returns>TenantAuditSettingsWrapper</returns>
        public TenantAuditSettingsWrapper GetAuditSettings()
        {
            var localVarResponse = GetAuditSettingsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the audit trail settings
        /// </summary>
        /// <remarks>
        /// Returns the audit trail settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
            var localVarResponse = Client.Get<TenantAuditSettingsWrapper>("/api/2.0/security/audit/settings/lifetime", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAuditSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the audit trail settings
        /// </summary>
        /// <remarks>
        /// Returns the audit trail settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-settings/">REST API Reference for GetAuditSettings Operation</seealso>
        /// <returns>Task of TenantAuditSettingsWrapper</returns>
        public async Task<TenantAuditSettingsWrapper> GetAuditSettingsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAuditSettingsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the audit trail settings
        /// </summary>
        /// <remarks>
        /// Returns the audit trail settings.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-settings/">REST API Reference for GetAuditSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantAuditSettingsWrapper)</returns>
        public async Task<ApiResponse<TenantAuditSettingsWrapper>> GetAuditSettingsWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<TenantAuditSettingsWrapper>("/api/2.0/security/audit/settings/lifetime", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAuditSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get audit trail mappers
        /// </summary>
        /// <remarks>
        /// Returns the mappers for the audit trail types.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productType">The type of product related to the audit trail. (optional)</param>
        /// <param name="moduleType">The location associated with the audit trail. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-mappers/">REST API Reference for GetAuditTrailMappers Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        public ObjectWrapper GetAuditTrailMappers(ProductType? productType = default, LocationType? moduleType = default)
        {
            var localVarResponse = GetAuditTrailMappersWithHttpInfo(productType, moduleType);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get audit trail mappers
        /// </summary>
        /// <remarks>
        /// Returns the mappers for the audit trail types.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productType">The type of product related to the audit trail. (optional)</param>
        /// <param name="moduleType">The location associated with the audit trail. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-mappers/">REST API Reference for GetAuditTrailMappers Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        public ApiResponse<ObjectWrapper> GetAuditTrailMappersWithHttpInfo(ProductType? productType = default, LocationType? moduleType = default)
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
            var localVarResponse = Client.Get<ObjectWrapper>("/api/2.0/security/audit/mappers", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAuditTrailMappers", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get audit trail mappers
        /// </summary>
        /// <remarks>
        /// Returns the mappers for the audit trail types.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productType">The type of product related to the audit trail. (optional)</param>
        /// <param name="moduleType">The location associated with the audit trail. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-mappers/">REST API Reference for GetAuditTrailMappers Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        public async Task<ObjectWrapper> GetAuditTrailMappersAsync(ProductType? productType = default, LocationType? moduleType = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAuditTrailMappersWithHttpInfoAsync(productType, moduleType, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get audit trail mappers
        /// </summary>
        /// <remarks>
        /// Returns the mappers for the audit trail types.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productType">The type of product related to the audit trail. (optional)</param>
        /// <param name="moduleType">The location associated with the audit trail. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-mappers/">REST API Reference for GetAuditTrailMappers Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        public async Task<ApiResponse<ObjectWrapper>> GetAuditTrailMappersWithHttpInfoAsync(ProductType? productType = default, LocationType? moduleType = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


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

            var localVarResponse = await AsynchronousClient.GetAsync<ObjectWrapper>("/api/2.0/security/audit/mappers", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAuditTrailMappers", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get audit trail types
        /// </summary>
        /// <remarks>
        /// Returns all the available audit trail types.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-types/">REST API Reference for GetAuditTrailTypes Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        public ObjectWrapper GetAuditTrailTypes()
        {
            var localVarResponse = GetAuditTrailTypesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get audit trail types
        /// </summary>
        /// <remarks>
        /// Returns all the available audit trail types.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
            var localVarResponse = Client.Get<ObjectWrapper>("/api/2.0/security/audit/types", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAuditTrailTypes", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get audit trail types
        /// </summary>
        /// <remarks>
        /// Returns all the available audit trail types.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-types/">REST API Reference for GetAuditTrailTypes Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        public async Task<ObjectWrapper> GetAuditTrailTypesAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAuditTrailTypesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get audit trail types
        /// </summary>
        /// <remarks>
        /// Returns all the available audit trail types.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-audit-trail-types/">REST API Reference for GetAuditTrailTypes Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        public async Task<ApiResponse<ObjectWrapper>> GetAuditTrailTypesWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<ObjectWrapper>("/api/2.0/security/audit/types", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAuditTrailTypes", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest changes (creation, modification, deletion, etc.) made by users to the entities on the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-last-audit-events/">REST API Reference for GetLastAuditEvents Operation</seealso>
        /// <returns>AuditEventArrayWrapper</returns>
        public AuditEventArrayWrapper GetLastAuditEvents()
        {
            var localVarResponse = GetLastAuditEventsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest changes (creation, modification, deletion, etc.) made by users to the entities on the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
            var localVarResponse = Client.Get<AuditEventArrayWrapper>("/api/2.0/security/audit/events/last", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetLastAuditEvents", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest changes (creation, modification, deletion, etc.) made by users to the entities on the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-last-audit-events/">REST API Reference for GetLastAuditEvents Operation</seealso>
        /// <returns>Task of AuditEventArrayWrapper</returns>
        public async Task<AuditEventArrayWrapper> GetLastAuditEventsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetLastAuditEventsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get audit trail data
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest changes (creation, modification, deletion, etc.) made by users to the entities on the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-last-audit-events/">REST API Reference for GetLastAuditEvents Operation</seealso>
        /// <returns>Task of ApiResponse (AuditEventArrayWrapper)</returns>
        public async Task<ApiResponse<AuditEventArrayWrapper>> GetLastAuditEventsWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<AuditEventArrayWrapper>("/api/2.0/security/audit/events/last", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetLastAuditEvents", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the audit trail settings
        /// </summary>
        /// <remarks>
        /// Sets the audit trail settings for the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAuditSettingsWrapper">The tenant audit settings wrapper. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-audit-settings/">REST API Reference for SetAuditSettings Operation</seealso>
        /// <returns>TenantAuditSettingsWrapper</returns>
        public TenantAuditSettingsWrapper SetAuditSettings(TenantAuditSettingsWrapper? tenantAuditSettingsWrapper = default)
        {
            var localVarResponse = SetAuditSettingsWithHttpInfo(tenantAuditSettingsWrapper);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the audit trail settings
        /// </summary>
        /// <remarks>
        /// Sets the audit trail settings for the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAuditSettingsWrapper">The tenant audit settings wrapper. (optional)</param>
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
            var localVarResponse = Client.Post<TenantAuditSettingsWrapper>("/api/2.0/security/audit/settings/lifetime", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetAuditSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the audit trail settings
        /// </summary>
        /// <remarks>
        /// Sets the audit trail settings for the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAuditSettingsWrapper">The tenant audit settings wrapper. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-audit-settings/">REST API Reference for SetAuditSettings Operation</seealso>
        /// <returns>Task of TenantAuditSettingsWrapper</returns>
        public async Task<TenantAuditSettingsWrapper> SetAuditSettingsAsync(TenantAuditSettingsWrapper? tenantAuditSettingsWrapper = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetAuditSettingsWithHttpInfoAsync(tenantAuditSettingsWrapper, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the audit trail settings
        /// </summary>
        /// <remarks>
        /// Sets the audit trail settings for the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tenantAuditSettingsWrapper">The tenant audit settings wrapper. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-audit-settings/">REST API Reference for SetAuditSettings Operation</seealso>
        /// <returns>Task of ApiResponse (TenantAuditSettingsWrapper)</returns>
        public async Task<ApiResponse<TenantAuditSettingsWrapper>> SetAuditSettingsWithHttpInfoAsync(TenantAuditSettingsWrapper? tenantAuditSettingsWrapper = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (tenantAuditSettingsWrapper != null) localVarRequestOptions.Data = tenantAuditSettingsWrapper;

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

            var localVarResponse = await AsynchronousClient.PostAsync<TenantAuditSettingsWrapper>("/api/2.0/security/audit/settings/lifetime", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetAuditSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
