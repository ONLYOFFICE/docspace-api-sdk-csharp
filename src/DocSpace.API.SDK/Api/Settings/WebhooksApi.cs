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
    public interface IWebhooksApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a webhook
        /// </summary>
        /// <remarks>
        /// Creates a new tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWebhooksConfigRequestsDto">The request parameters for creating the webhook configuration. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-webhook/">REST API Reference for CreateWebhook Operation</seealso>
        /// <returns>WebhooksConfigWrapper</returns>
        WebhooksConfigWrapper CreateWebhook(CreateWebhooksConfigRequestsDto? createWebhooksConfigRequestsDto = default);

        /// <summary>
        /// Create a webhook
        /// </summary>
        /// <remarks>
        /// Creates a new tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWebhooksConfigRequestsDto">The request parameters for creating the webhook configuration. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-webhook/">REST API Reference for CreateWebhook Operation</seealso>
        /// <returns>ApiResponse of WebhooksConfigWrapper</returns>
        ApiResponse<WebhooksConfigWrapper> CreateWebhookWithHttpInfo(CreateWebhooksConfigRequestsDto? createWebhooksConfigRequestsDto = default);
        /// <summary>
        /// Enable a webhook
        /// </summary>
        /// <remarks>
        /// Enables or disables a tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The request parameters for updating the webhook configuration. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-webhook/">REST API Reference for EnableWebhook Operation</seealso>
        /// <returns>WebhooksConfigWrapper</returns>
        WebhooksConfigWrapper EnableWebhook(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default);

        /// <summary>
        /// Enable a webhook
        /// </summary>
        /// <remarks>
        /// Enables or disables a tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The request parameters for updating the webhook configuration. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-webhook/">REST API Reference for EnableWebhook Operation</seealso>
        /// <returns>ApiResponse of WebhooksConfigWrapper</returns>
        ApiResponse<WebhooksConfigWrapper> EnableWebhookWithHttpInfo(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default);
        /// <summary>
        /// Get webhooks
        /// </summary>
        /// <remarks>
        /// Returns a list of the tenant webhooks.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-webhooks/">REST API Reference for GetTenantWebhooks Operation</seealso>
        /// <returns>WebhooksConfigWithStatusArrayWrapper</returns>
        WebhooksConfigWithStatusArrayWrapper GetTenantWebhooks();

        /// <summary>
        /// Get webhooks
        /// </summary>
        /// <remarks>
        /// Returns a list of the tenant webhooks.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-webhooks/">REST API Reference for GetTenantWebhooks Operation</seealso>
        /// <returns>ApiResponse of WebhooksConfigWithStatusArrayWrapper</returns>
        ApiResponse<WebhooksConfigWithStatusArrayWrapper> GetTenantWebhooksWithHttpInfo();
        /// <summary>
        /// Get webhook triggers
        /// </summary>
        /// <remarks>
        /// Returns a list of triggers for a webhook.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhook-triggers/">REST API Reference for GetWebhookTriggers Operation</seealso>
        /// <returns>UnknownWrapper</returns>
        UnknownWrapper GetWebhookTriggers();

        /// <summary>
        /// Get webhook triggers
        /// </summary>
        /// <remarks>
        /// Returns a list of triggers for a webhook.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhook-triggers/">REST API Reference for GetWebhookTriggers Operation</seealso>
        /// <returns>ApiResponse of UnknownWrapper</returns>
        ApiResponse<UnknownWrapper> GetWebhookTriggersWithHttpInfo();
        /// <summary>
        /// Get webhook logs
        /// </summary>
        /// <remarks>
        /// Returns the logs of the webhook activities.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryFrom">The delivery start time for filtering webhook logs. (optional)</param>
        /// <param name="deliveryTo">The delivery end time for filtering webhook logs. (optional)</param>
        /// <param name="hookUri">The destination URL where webhooks are delivered. (optional)</param>
        /// <param name="configId">The webhook configuration identifier. (optional)</param>
        /// <param name="eventId">The unique identifier of the event that triggered the webhook. (optional)</param>
        /// <param name="groupStatus">The status of the webhook delivery group. (optional)</param>
        /// <param name="userId">The identifier of the user associated with the webhook event. (optional)</param>
        /// <param name="trigger">The type of event that triggered the webhook. (optional)</param>
        /// <param name="count">The maximum number of webhook log records to return in the query response. (optional)</param>
        /// <param name="startIndex">Specifies the starting index for retrieving webhook logs.  Used for pagination in the webhook delivery log queries. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhooks-logs/">REST API Reference for GetWebhooksLogs Operation</seealso>
        /// <returns>WebhooksLogArrayWrapper</returns>
        WebhooksLogArrayWrapper GetWebhooksLogs(DateTime? deliveryFrom = default, DateTime? deliveryTo = default, string? hookUri = default, int? configId = default, int? eventId = default, WebhookGroupStatus? groupStatus = default, Guid? userId = default, WebhookTrigger? trigger = default, int? count = default, int? startIndex = default, string fields = default);

        /// <summary>
        /// Get webhook logs
        /// </summary>
        /// <remarks>
        /// Returns the logs of the webhook activities.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryFrom">The delivery start time for filtering webhook logs. (optional)</param>
        /// <param name="deliveryTo">The delivery end time for filtering webhook logs. (optional)</param>
        /// <param name="hookUri">The destination URL where webhooks are delivered. (optional)</param>
        /// <param name="configId">The webhook configuration identifier. (optional)</param>
        /// <param name="eventId">The unique identifier of the event that triggered the webhook. (optional)</param>
        /// <param name="groupStatus">The status of the webhook delivery group. (optional)</param>
        /// <param name="userId">The identifier of the user associated with the webhook event. (optional)</param>
        /// <param name="trigger">The type of event that triggered the webhook. (optional)</param>
        /// <param name="count">The maximum number of webhook log records to return in the query response. (optional)</param>
        /// <param name="startIndex">Specifies the starting index for retrieving webhook logs.  Used for pagination in the webhook delivery log queries. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhooks-logs/">REST API Reference for GetWebhooksLogs Operation</seealso>
        /// <returns>ApiResponse of WebhooksLogArrayWrapper</returns>
        ApiResponse<WebhooksLogArrayWrapper> GetWebhooksLogsWithHttpInfo(DateTime? deliveryFrom = default, DateTime? deliveryTo = default, string? hookUri = default, int? configId = default, int? eventId = default, WebhookGroupStatus? groupStatus = default, Guid? userId = default, WebhookTrigger? trigger = default, int? count = default, int? startIndex = default, string fields = default);
        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <remarks>
        /// Removes a tenant webhook with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID extracted from the route parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-webhook/">REST API Reference for RemoveWebhook Operation</seealso>
        /// <returns>WebhooksConfigWrapper</returns>
        WebhooksConfigWrapper RemoveWebhook(int id);

        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <remarks>
        /// Removes a tenant webhook with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID extracted from the route parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-webhook/">REST API Reference for RemoveWebhook Operation</seealso>
        /// <returns>ApiResponse of WebhooksConfigWrapper</returns>
        ApiResponse<WebhooksConfigWrapper> RemoveWebhookWithHttpInfo(int id);
        /// <summary>
        /// Retry a webhook
        /// </summary>
        /// <remarks>
        /// Retries a webhook with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID extracted from the route parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhook/">REST API Reference for RetryWebhook Operation</seealso>
        /// <returns>WebhooksLogWrapper</returns>
        WebhooksLogWrapper RetryWebhook(int id);

        /// <summary>
        /// Retry a webhook
        /// </summary>
        /// <remarks>
        /// Retries a webhook with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID extracted from the route parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhook/">REST API Reference for RetryWebhook Operation</seealso>
        /// <returns>ApiResponse of WebhooksLogWrapper</returns>
        ApiResponse<WebhooksLogWrapper> RetryWebhookWithHttpInfo(int id);
        /// <summary>
        /// Retry webhooks
        /// </summary>
        /// <remarks>
        /// Retries all the webhooks with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookRetryRequestsDto">The request parameters for requesting the webhook delivery retries. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhooks/">REST API Reference for RetryWebhooks Operation</seealso>
        /// <returns>WebhooksLogArrayWrapper</returns>
        WebhooksLogArrayWrapper RetryWebhooks(WebhookRetryRequestsDto? webhookRetryRequestsDto = default);

        /// <summary>
        /// Retry webhooks
        /// </summary>
        /// <remarks>
        /// Retries all the webhooks with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookRetryRequestsDto">The request parameters for requesting the webhook delivery retries. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhooks/">REST API Reference for RetryWebhooks Operation</seealso>
        /// <returns>ApiResponse of WebhooksLogArrayWrapper</returns>
        ApiResponse<WebhooksLogArrayWrapper> RetryWebhooksWithHttpInfo(WebhookRetryRequestsDto? webhookRetryRequestsDto = default);
        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <remarks>
        /// Updates a tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The request parameters for updating the webhook configuration. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-webhook/">REST API Reference for UpdateWebhook Operation</seealso>
        /// <returns>WebhooksConfigWrapper</returns>
        WebhooksConfigWrapper UpdateWebhook(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default);

        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <remarks>
        /// Updates a tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The request parameters for updating the webhook configuration. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-webhook/">REST API Reference for UpdateWebhook Operation</seealso>
        /// <returns>ApiResponse of WebhooksConfigWrapper</returns>
        ApiResponse<WebhooksConfigWrapper> UpdateWebhookWithHttpInfo(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWebhooksApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create a webhook
        /// </summary>
        /// <remarks>
        /// Creates a new tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWebhooksConfigRequestsDto">The request parameters for creating the webhook configuration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-webhook/">REST API Reference for CreateWebhook Operation</seealso>
        /// <returns>Task of WebhooksConfigWrapper</returns>
        Task<WebhooksConfigWrapper> CreateWebhookAsync(CreateWebhooksConfigRequestsDto? createWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a webhook
        /// </summary>
        /// <remarks>
        /// Creates a new tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWebhooksConfigRequestsDto">The request parameters for creating the webhook configuration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-webhook/">REST API Reference for CreateWebhook Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksConfigWrapper)</returns>
        Task<ApiResponse<WebhooksConfigWrapper>> CreateWebhookWithHttpInfoAsync(CreateWebhooksConfigRequestsDto? createWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Enable a webhook
        /// </summary>
        /// <remarks>
        /// Enables or disables a tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The request parameters for updating the webhook configuration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-webhook/">REST API Reference for EnableWebhook Operation</seealso>
        /// <returns>Task of WebhooksConfigWrapper</returns>
        Task<WebhooksConfigWrapper> EnableWebhookAsync(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Enable a webhook
        /// </summary>
        /// <remarks>
        /// Enables or disables a tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The request parameters for updating the webhook configuration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-webhook/">REST API Reference for EnableWebhook Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksConfigWrapper)</returns>
        Task<ApiResponse<WebhooksConfigWrapper>> EnableWebhookWithHttpInfoAsync(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get webhooks
        /// </summary>
        /// <remarks>
        /// Returns a list of the tenant webhooks.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-webhooks/">REST API Reference for GetTenantWebhooks Operation</seealso>
        /// <returns>Task of WebhooksConfigWithStatusArrayWrapper</returns>
        Task<WebhooksConfigWithStatusArrayWrapper> GetTenantWebhooksAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get webhooks
        /// </summary>
        /// <remarks>
        /// Returns a list of the tenant webhooks.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-webhooks/">REST API Reference for GetTenantWebhooks Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksConfigWithStatusArrayWrapper)</returns>
        Task<ApiResponse<WebhooksConfigWithStatusArrayWrapper>> GetTenantWebhooksWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get webhook triggers
        /// </summary>
        /// <remarks>
        /// Returns a list of triggers for a webhook.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhook-triggers/">REST API Reference for GetWebhookTriggers Operation</seealso>
        /// <returns>Task of UnknownWrapper</returns>
        Task<UnknownWrapper> GetWebhookTriggersAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get webhook triggers
        /// </summary>
        /// <remarks>
        /// Returns a list of triggers for a webhook.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhook-triggers/">REST API Reference for GetWebhookTriggers Operation</seealso>
        /// <returns>Task of ApiResponse (UnknownWrapper)</returns>
        Task<ApiResponse<UnknownWrapper>> GetWebhookTriggersWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get webhook logs
        /// </summary>
        /// <remarks>
        /// Returns the logs of the webhook activities.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryFrom">The delivery start time for filtering webhook logs. (optional)</param>
        /// <param name="deliveryTo">The delivery end time for filtering webhook logs. (optional)</param>
        /// <param name="hookUri">The destination URL where webhooks are delivered. (optional)</param>
        /// <param name="configId">The webhook configuration identifier. (optional)</param>
        /// <param name="eventId">The unique identifier of the event that triggered the webhook. (optional)</param>
        /// <param name="groupStatus">The status of the webhook delivery group. (optional)</param>
        /// <param name="userId">The identifier of the user associated with the webhook event. (optional)</param>
        /// <param name="trigger">The type of event that triggered the webhook. (optional)</param>
        /// <param name="count">The maximum number of webhook log records to return in the query response. (optional)</param>
        /// <param name="startIndex">Specifies the starting index for retrieving webhook logs.  Used for pagination in the webhook delivery log queries. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhooks-logs/">REST API Reference for GetWebhooksLogs Operation</seealso>
        /// <returns>Task of WebhooksLogArrayWrapper</returns>
        Task<WebhooksLogArrayWrapper> GetWebhooksLogsAsync(DateTime? deliveryFrom = default, DateTime? deliveryTo = default, string? hookUri = default, int? configId = default, int? eventId = default, WebhookGroupStatus? groupStatus = default, Guid? userId = default, WebhookTrigger? trigger = default, int? count = default, int? startIndex = default, string fields = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get webhook logs
        /// </summary>
        /// <remarks>
        /// Returns the logs of the webhook activities.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryFrom">The delivery start time for filtering webhook logs. (optional)</param>
        /// <param name="deliveryTo">The delivery end time for filtering webhook logs. (optional)</param>
        /// <param name="hookUri">The destination URL where webhooks are delivered. (optional)</param>
        /// <param name="configId">The webhook configuration identifier. (optional)</param>
        /// <param name="eventId">The unique identifier of the event that triggered the webhook. (optional)</param>
        /// <param name="groupStatus">The status of the webhook delivery group. (optional)</param>
        /// <param name="userId">The identifier of the user associated with the webhook event. (optional)</param>
        /// <param name="trigger">The type of event that triggered the webhook. (optional)</param>
        /// <param name="count">The maximum number of webhook log records to return in the query response. (optional)</param>
        /// <param name="startIndex">Specifies the starting index for retrieving webhook logs.  Used for pagination in the webhook delivery log queries. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhooks-logs/">REST API Reference for GetWebhooksLogs Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksLogArrayWrapper)</returns>
        Task<ApiResponse<WebhooksLogArrayWrapper>> GetWebhooksLogsWithHttpInfoAsync(DateTime? deliveryFrom = default, DateTime? deliveryTo = default, string? hookUri = default, int? configId = default, int? eventId = default, WebhookGroupStatus? groupStatus = default, Guid? userId = default, WebhookTrigger? trigger = default, int? count = default, int? startIndex = default, string fields = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <remarks>
        /// Removes a tenant webhook with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID extracted from the route parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-webhook/">REST API Reference for RemoveWebhook Operation</seealso>
        /// <returns>Task of WebhooksConfigWrapper</returns>
        Task<WebhooksConfigWrapper> RemoveWebhookAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <remarks>
        /// Removes a tenant webhook with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID extracted from the route parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-webhook/">REST API Reference for RemoveWebhook Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksConfigWrapper)</returns>
        Task<ApiResponse<WebhooksConfigWrapper>> RemoveWebhookWithHttpInfoAsync(int id, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retry a webhook
        /// </summary>
        /// <remarks>
        /// Retries a webhook with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID extracted from the route parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhook/">REST API Reference for RetryWebhook Operation</seealso>
        /// <returns>Task of WebhooksLogWrapper</returns>
        Task<WebhooksLogWrapper> RetryWebhookAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retry a webhook
        /// </summary>
        /// <remarks>
        /// Retries a webhook with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID extracted from the route parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhook/">REST API Reference for RetryWebhook Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksLogWrapper)</returns>
        Task<ApiResponse<WebhooksLogWrapper>> RetryWebhookWithHttpInfoAsync(int id, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retry webhooks
        /// </summary>
        /// <remarks>
        /// Retries all the webhooks with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookRetryRequestsDto">The request parameters for requesting the webhook delivery retries. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhooks/">REST API Reference for RetryWebhooks Operation</seealso>
        /// <returns>Task of WebhooksLogArrayWrapper</returns>
        Task<WebhooksLogArrayWrapper> RetryWebhooksAsync(WebhookRetryRequestsDto? webhookRetryRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retry webhooks
        /// </summary>
        /// <remarks>
        /// Retries all the webhooks with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookRetryRequestsDto">The request parameters for requesting the webhook delivery retries. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhooks/">REST API Reference for RetryWebhooks Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksLogArrayWrapper)</returns>
        Task<ApiResponse<WebhooksLogArrayWrapper>> RetryWebhooksWithHttpInfoAsync(WebhookRetryRequestsDto? webhookRetryRequestsDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <remarks>
        /// Updates a tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The request parameters for updating the webhook configuration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-webhook/">REST API Reference for UpdateWebhook Operation</seealso>
        /// <returns>Task of WebhooksConfigWrapper</returns>
        Task<WebhooksConfigWrapper> UpdateWebhookAsync(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <remarks>
        /// Updates a tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The request parameters for updating the webhook configuration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-webhook/">REST API Reference for UpdateWebhook Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksConfigWrapper)</returns>
        Task<ApiResponse<WebhooksConfigWrapper>> UpdateWebhookWithHttpInfoAsync(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWebhooksApi : IWebhooksApiSync, IWebhooksApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WebhooksApi : IDisposable, IWebhooksApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public WebhooksApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public WebhooksApi(string basePath)
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
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public WebhooksApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public WebhooksApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class.
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
        public WebhooksApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class using a Configuration object.
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
        public WebhooksApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public WebhooksApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Create a webhook
        /// </summary>
        /// <remarks>
        /// Creates a new tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWebhooksConfigRequestsDto">The request parameters for creating the webhook configuration. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-webhook/">REST API Reference for CreateWebhook Operation</seealso>
        /// <returns>WebhooksConfigWrapper</returns>
        public WebhooksConfigWrapper CreateWebhook(CreateWebhooksConfigRequestsDto? createWebhooksConfigRequestsDto = default)
        {
            var localVarResponse = CreateWebhookWithHttpInfo(createWebhooksConfigRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a webhook
        /// </summary>
        /// <remarks>
        /// Creates a new tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWebhooksConfigRequestsDto">The request parameters for creating the webhook configuration. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-webhook/">REST API Reference for CreateWebhook Operation</seealso>
        /// <returns>ApiResponse of WebhooksConfigWrapper</returns>
        public ApiResponse<WebhooksConfigWrapper> CreateWebhookWithHttpInfo(CreateWebhooksConfigRequestsDto? createWebhooksConfigRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createWebhooksConfigRequestsDto != null) localVarRequestOptions.Data = createWebhooksConfigRequestsDto;

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
            var localVarResponse = Client.Post<WebhooksConfigWrapper>("/api/2.0/settings/webhook", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateWebhook", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a webhook
        /// </summary>
        /// <remarks>
        /// Creates a new tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWebhooksConfigRequestsDto">The request parameters for creating the webhook configuration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-webhook/">REST API Reference for CreateWebhook Operation</seealso>
        /// <returns>Task of WebhooksConfigWrapper</returns>
        public async Task<WebhooksConfigWrapper> CreateWebhookAsync(CreateWebhooksConfigRequestsDto? createWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateWebhookWithHttpInfoAsync(createWebhooksConfigRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a webhook
        /// </summary>
        /// <remarks>
        /// Creates a new tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWebhooksConfigRequestsDto">The request parameters for creating the webhook configuration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-webhook/">REST API Reference for CreateWebhook Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksConfigWrapper)</returns>
        public async Task<ApiResponse<WebhooksConfigWrapper>> CreateWebhookWithHttpInfoAsync(CreateWebhooksConfigRequestsDto? createWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createWebhooksConfigRequestsDto != null) localVarRequestOptions.Data = createWebhooksConfigRequestsDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<WebhooksConfigWrapper>("/api/2.0/settings/webhook", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateWebhook", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Enable a webhook
        /// </summary>
        /// <remarks>
        /// Enables or disables a tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The request parameters for updating the webhook configuration. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-webhook/">REST API Reference for EnableWebhook Operation</seealso>
        /// <returns>WebhooksConfigWrapper</returns>
        public WebhooksConfigWrapper EnableWebhook(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default)
        {
            var localVarResponse = EnableWebhookWithHttpInfo(updateWebhooksConfigRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Enable a webhook
        /// </summary>
        /// <remarks>
        /// Enables or disables a tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The request parameters for updating the webhook configuration. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-webhook/">REST API Reference for EnableWebhook Operation</seealso>
        /// <returns>ApiResponse of WebhooksConfigWrapper</returns>
        public ApiResponse<WebhooksConfigWrapper> EnableWebhookWithHttpInfo(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (updateWebhooksConfigRequestsDto != null) localVarRequestOptions.Data = updateWebhooksConfigRequestsDto;

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
            var localVarResponse = Client.Put<WebhooksConfigWrapper>("/api/2.0/settings/webhook/enable", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("EnableWebhook", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Enable a webhook
        /// </summary>
        /// <remarks>
        /// Enables or disables a tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The request parameters for updating the webhook configuration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-webhook/">REST API Reference for EnableWebhook Operation</seealso>
        /// <returns>Task of WebhooksConfigWrapper</returns>
        public async Task<WebhooksConfigWrapper> EnableWebhookAsync(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await EnableWebhookWithHttpInfoAsync(updateWebhooksConfigRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Enable a webhook
        /// </summary>
        /// <remarks>
        /// Enables or disables a tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The request parameters for updating the webhook configuration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-webhook/">REST API Reference for EnableWebhook Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksConfigWrapper)</returns>
        public async Task<ApiResponse<WebhooksConfigWrapper>> EnableWebhookWithHttpInfoAsync(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (updateWebhooksConfigRequestsDto != null) localVarRequestOptions.Data = updateWebhooksConfigRequestsDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<WebhooksConfigWrapper>("/api/2.0/settings/webhook/enable", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("EnableWebhook", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get webhooks
        /// </summary>
        /// <remarks>
        /// Returns a list of the tenant webhooks.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-webhooks/">REST API Reference for GetTenantWebhooks Operation</seealso>
        /// <returns>WebhooksConfigWithStatusArrayWrapper</returns>
        public WebhooksConfigWithStatusArrayWrapper GetTenantWebhooks()
        {
            var localVarResponse = GetTenantWebhooksWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get webhooks
        /// </summary>
        /// <remarks>
        /// Returns a list of the tenant webhooks.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-webhooks/">REST API Reference for GetTenantWebhooks Operation</seealso>
        /// <returns>ApiResponse of WebhooksConfigWithStatusArrayWrapper</returns>
        public ApiResponse<WebhooksConfigWithStatusArrayWrapper> GetTenantWebhooksWithHttpInfo()
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
            var localVarResponse = Client.Get<WebhooksConfigWithStatusArrayWrapper>("/api/2.0/settings/webhook", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetTenantWebhooks", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get webhooks
        /// </summary>
        /// <remarks>
        /// Returns a list of the tenant webhooks.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-webhooks/">REST API Reference for GetTenantWebhooks Operation</seealso>
        /// <returns>Task of WebhooksConfigWithStatusArrayWrapper</returns>
        public async Task<WebhooksConfigWithStatusArrayWrapper> GetTenantWebhooksAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetTenantWebhooksWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get webhooks
        /// </summary>
        /// <remarks>
        /// Returns a list of the tenant webhooks.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tenant-webhooks/">REST API Reference for GetTenantWebhooks Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksConfigWithStatusArrayWrapper)</returns>
        public async Task<ApiResponse<WebhooksConfigWithStatusArrayWrapper>> GetTenantWebhooksWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<WebhooksConfigWithStatusArrayWrapper>("/api/2.0/settings/webhook", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetTenantWebhooks", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get webhook triggers
        /// </summary>
        /// <remarks>
        /// Returns a list of triggers for a webhook.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhook-triggers/">REST API Reference for GetWebhookTriggers Operation</seealso>
        /// <returns>UnknownWrapper</returns>
        public UnknownWrapper GetWebhookTriggers()
        {
            var localVarResponse = GetWebhookTriggersWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get webhook triggers
        /// </summary>
        /// <remarks>
        /// Returns a list of triggers for a webhook.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhook-triggers/">REST API Reference for GetWebhookTriggers Operation</seealso>
        /// <returns>ApiResponse of UnknownWrapper</returns>
        public ApiResponse<UnknownWrapper> GetWebhookTriggersWithHttpInfo()
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
            var localVarResponse = Client.Get<UnknownWrapper>("/api/2.0/settings/webhook/triggers", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetWebhookTriggers", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get webhook triggers
        /// </summary>
        /// <remarks>
        /// Returns a list of triggers for a webhook.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhook-triggers/">REST API Reference for GetWebhookTriggers Operation</seealso>
        /// <returns>Task of UnknownWrapper</returns>
        public async Task<UnknownWrapper> GetWebhookTriggersAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetWebhookTriggersWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get webhook triggers
        /// </summary>
        /// <remarks>
        /// Returns a list of triggers for a webhook.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhook-triggers/">REST API Reference for GetWebhookTriggers Operation</seealso>
        /// <returns>Task of ApiResponse (UnknownWrapper)</returns>
        public async Task<ApiResponse<UnknownWrapper>> GetWebhookTriggersWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<UnknownWrapper>("/api/2.0/settings/webhook/triggers", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetWebhookTriggers", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get webhook logs
        /// </summary>
        /// <remarks>
        /// Returns the logs of the webhook activities.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryFrom">The delivery start time for filtering webhook logs. (optional)</param>
        /// <param name="deliveryTo">The delivery end time for filtering webhook logs. (optional)</param>
        /// <param name="hookUri">The destination URL where webhooks are delivered. (optional)</param>
        /// <param name="configId">The webhook configuration identifier. (optional)</param>
        /// <param name="eventId">The unique identifier of the event that triggered the webhook. (optional)</param>
        /// <param name="groupStatus">The status of the webhook delivery group. (optional)</param>
        /// <param name="userId">The identifier of the user associated with the webhook event. (optional)</param>
        /// <param name="trigger">The type of event that triggered the webhook. (optional)</param>
        /// <param name="count">The maximum number of webhook log records to return in the query response. (optional)</param>
        /// <param name="startIndex">Specifies the starting index for retrieving webhook logs.  Used for pagination in the webhook delivery log queries. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhooks-logs/">REST API Reference for GetWebhooksLogs Operation</seealso>
        /// <returns>WebhooksLogArrayWrapper</returns>
        public WebhooksLogArrayWrapper GetWebhooksLogs(DateTime? deliveryFrom = default, DateTime? deliveryTo = default, string? hookUri = default, int? configId = default, int? eventId = default, WebhookGroupStatus? groupStatus = default, Guid? userId = default, WebhookTrigger? trigger = default, int? count = default, int? startIndex = default, string fields = default)
        {
            var localVarResponse = GetWebhooksLogsWithHttpInfo(deliveryFrom, deliveryTo, hookUri, configId, eventId, groupStatus, userId, trigger, count, startIndex, fields);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get webhook logs
        /// </summary>
        /// <remarks>
        /// Returns the logs of the webhook activities.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryFrom">The delivery start time for filtering webhook logs. (optional)</param>
        /// <param name="deliveryTo">The delivery end time for filtering webhook logs. (optional)</param>
        /// <param name="hookUri">The destination URL where webhooks are delivered. (optional)</param>
        /// <param name="configId">The webhook configuration identifier. (optional)</param>
        /// <param name="eventId">The unique identifier of the event that triggered the webhook. (optional)</param>
        /// <param name="groupStatus">The status of the webhook delivery group. (optional)</param>
        /// <param name="userId">The identifier of the user associated with the webhook event. (optional)</param>
        /// <param name="trigger">The type of event that triggered the webhook. (optional)</param>
        /// <param name="count">The maximum number of webhook log records to return in the query response. (optional)</param>
        /// <param name="startIndex">Specifies the starting index for retrieving webhook logs.  Used for pagination in the webhook delivery log queries. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhooks-logs/">REST API Reference for GetWebhooksLogs Operation</seealso>
        /// <returns>ApiResponse of WebhooksLogArrayWrapper</returns>
        public ApiResponse<WebhooksLogArrayWrapper> GetWebhooksLogsWithHttpInfo(DateTime? deliveryFrom = default, DateTime? deliveryTo = default, string? hookUri = default, int? configId = default, int? eventId = default, WebhookGroupStatus? groupStatus = default, Guid? userId = default, WebhookTrigger? trigger = default, int? count = default, int? startIndex = default, string fields = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (deliveryFrom != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "deliveryFrom", deliveryFrom));
            }
            if (deliveryTo != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "deliveryTo", deliveryTo));
            }
            if (hookUri != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "hookUri", hookUri));
            }
            if (configId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "configId", configId));
            }
            if (eventId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "eventId", eventId));
            }
            if (groupStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "groupStatus", groupStatus));
            }
            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userId", userId));
            }
            if (trigger != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "trigger", trigger));
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
            var localVarResponse = Client.Get<WebhooksLogArrayWrapper>("/api/2.0/settings/webhooks/log", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetWebhooksLogs", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get webhook logs
        /// </summary>
        /// <remarks>
        /// Returns the logs of the webhook activities.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryFrom">The delivery start time for filtering webhook logs. (optional)</param>
        /// <param name="deliveryTo">The delivery end time for filtering webhook logs. (optional)</param>
        /// <param name="hookUri">The destination URL where webhooks are delivered. (optional)</param>
        /// <param name="configId">The webhook configuration identifier. (optional)</param>
        /// <param name="eventId">The unique identifier of the event that triggered the webhook. (optional)</param>
        /// <param name="groupStatus">The status of the webhook delivery group. (optional)</param>
        /// <param name="userId">The identifier of the user associated with the webhook event. (optional)</param>
        /// <param name="trigger">The type of event that triggered the webhook. (optional)</param>
        /// <param name="count">The maximum number of webhook log records to return in the query response. (optional)</param>
        /// <param name="startIndex">Specifies the starting index for retrieving webhook logs.  Used for pagination in the webhook delivery log queries. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhooks-logs/">REST API Reference for GetWebhooksLogs Operation</seealso>
        /// <returns>Task of WebhooksLogArrayWrapper</returns>
        public async Task<WebhooksLogArrayWrapper> GetWebhooksLogsAsync(DateTime? deliveryFrom = default, DateTime? deliveryTo = default, string? hookUri = default, int? configId = default, int? eventId = default, WebhookGroupStatus? groupStatus = default, Guid? userId = default, WebhookTrigger? trigger = default, int? count = default, int? startIndex = default, string fields = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetWebhooksLogsWithHttpInfoAsync(deliveryFrom, deliveryTo, hookUri, configId, eventId, groupStatus, userId, trigger, count, startIndex, fields, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get webhook logs
        /// </summary>
        /// <remarks>
        /// Returns the logs of the webhook activities.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryFrom">The delivery start time for filtering webhook logs. (optional)</param>
        /// <param name="deliveryTo">The delivery end time for filtering webhook logs. (optional)</param>
        /// <param name="hookUri">The destination URL where webhooks are delivered. (optional)</param>
        /// <param name="configId">The webhook configuration identifier. (optional)</param>
        /// <param name="eventId">The unique identifier of the event that triggered the webhook. (optional)</param>
        /// <param name="groupStatus">The status of the webhook delivery group. (optional)</param>
        /// <param name="userId">The identifier of the user associated with the webhook event. (optional)</param>
        /// <param name="trigger">The type of event that triggered the webhook. (optional)</param>
        /// <param name="count">The maximum number of webhook log records to return in the query response. (optional)</param>
        /// <param name="startIndex">Specifies the starting index for retrieving webhook logs.  Used for pagination in the webhook delivery log queries. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-webhooks-logs/">REST API Reference for GetWebhooksLogs Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksLogArrayWrapper)</returns>
        public async Task<ApiResponse<WebhooksLogArrayWrapper>> GetWebhooksLogsWithHttpInfoAsync(DateTime? deliveryFrom = default, DateTime? deliveryTo = default, string? hookUri = default, int? configId = default, int? eventId = default, WebhookGroupStatus? groupStatus = default, Guid? userId = default, WebhookTrigger? trigger = default, int? count = default, int? startIndex = default, string fields = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (deliveryFrom != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "deliveryFrom", deliveryFrom));
            }
            if (deliveryTo != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "deliveryTo", deliveryTo));
            }
            if (hookUri != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "hookUri", hookUri));
            }
            if (configId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "configId", configId));
            }
            if (eventId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "eventId", eventId));
            }
            if (groupStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "groupStatus", groupStatus));
            }
            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userId", userId));
            }
            if (trigger != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "trigger", trigger));
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

            var localVarResponse = await AsynchronousClient.GetAsync<WebhooksLogArrayWrapper>("/api/2.0/settings/webhooks/log", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetWebhooksLogs", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <remarks>
        /// Removes a tenant webhook with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID extracted from the route parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-webhook/">REST API Reference for RemoveWebhook Operation</seealso>
        /// <returns>WebhooksConfigWrapper</returns>
        public WebhooksConfigWrapper RemoveWebhook(int id)
        {
            var localVarResponse = RemoveWebhookWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <remarks>
        /// Removes a tenant webhook with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID extracted from the route parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-webhook/">REST API Reference for RemoveWebhook Operation</seealso>
        /// <returns>ApiResponse of WebhooksConfigWrapper</returns>
        public ApiResponse<WebhooksConfigWrapper> RemoveWebhookWithHttpInfo(int id)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

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
            var localVarResponse = Client.Delete<WebhooksConfigWrapper>("/api/2.0/settings/webhook/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RemoveWebhook", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <remarks>
        /// Removes a tenant webhook with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID extracted from the route parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-webhook/">REST API Reference for RemoveWebhook Operation</seealso>
        /// <returns>Task of WebhooksConfigWrapper</returns>
        public async Task<WebhooksConfigWrapper> RemoveWebhookAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await RemoveWebhookWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <remarks>
        /// Removes a tenant webhook with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID extracted from the route parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-webhook/">REST API Reference for RemoveWebhook Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksConfigWrapper)</returns>
        public async Task<ApiResponse<WebhooksConfigWrapper>> RemoveWebhookWithHttpInfoAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<WebhooksConfigWrapper>("/api/2.0/settings/webhook/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RemoveWebhook", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retry a webhook
        /// </summary>
        /// <remarks>
        /// Retries a webhook with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID extracted from the route parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhook/">REST API Reference for RetryWebhook Operation</seealso>
        /// <returns>WebhooksLogWrapper</returns>
        public WebhooksLogWrapper RetryWebhook(int id)
        {
            var localVarResponse = RetryWebhookWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retry a webhook
        /// </summary>
        /// <remarks>
        /// Retries a webhook with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID extracted from the route parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhook/">REST API Reference for RetryWebhook Operation</seealso>
        /// <returns>ApiResponse of WebhooksLogWrapper</returns>
        public ApiResponse<WebhooksLogWrapper> RetryWebhookWithHttpInfo(int id)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

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
            var localVarResponse = Client.Put<WebhooksLogWrapper>("/api/2.0/settings/webhook/{id}/retry", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RetryWebhook", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retry a webhook
        /// </summary>
        /// <remarks>
        /// Retries a webhook with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID extracted from the route parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhook/">REST API Reference for RetryWebhook Operation</seealso>
        /// <returns>Task of WebhooksLogWrapper</returns>
        public async Task<WebhooksLogWrapper> RetryWebhookAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await RetryWebhookWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retry a webhook
        /// </summary>
        /// <remarks>
        /// Retries a webhook with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID extracted from the route parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhook/">REST API Reference for RetryWebhook Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksLogWrapper)</returns>
        public async Task<ApiResponse<WebhooksLogWrapper>> RetryWebhookWithHttpInfoAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

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

            var localVarResponse = await AsynchronousClient.PutAsync<WebhooksLogWrapper>("/api/2.0/settings/webhook/{id}/retry", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RetryWebhook", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retry webhooks
        /// </summary>
        /// <remarks>
        /// Retries all the webhooks with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookRetryRequestsDto">The request parameters for requesting the webhook delivery retries. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhooks/">REST API Reference for RetryWebhooks Operation</seealso>
        /// <returns>WebhooksLogArrayWrapper</returns>
        public WebhooksLogArrayWrapper RetryWebhooks(WebhookRetryRequestsDto? webhookRetryRequestsDto = default)
        {
            var localVarResponse = RetryWebhooksWithHttpInfo(webhookRetryRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retry webhooks
        /// </summary>
        /// <remarks>
        /// Retries all the webhooks with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookRetryRequestsDto">The request parameters for requesting the webhook delivery retries. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhooks/">REST API Reference for RetryWebhooks Operation</seealso>
        /// <returns>ApiResponse of WebhooksLogArrayWrapper</returns>
        public ApiResponse<WebhooksLogArrayWrapper> RetryWebhooksWithHttpInfo(WebhookRetryRequestsDto? webhookRetryRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (webhookRetryRequestsDto != null) localVarRequestOptions.Data = webhookRetryRequestsDto;

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
            var localVarResponse = Client.Put<WebhooksLogArrayWrapper>("/api/2.0/settings/webhook/retry", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RetryWebhooks", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retry webhooks
        /// </summary>
        /// <remarks>
        /// Retries all the webhooks with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookRetryRequestsDto">The request parameters for requesting the webhook delivery retries. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhooks/">REST API Reference for RetryWebhooks Operation</seealso>
        /// <returns>Task of WebhooksLogArrayWrapper</returns>
        public async Task<WebhooksLogArrayWrapper> RetryWebhooksAsync(WebhookRetryRequestsDto? webhookRetryRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await RetryWebhooksWithHttpInfoAsync(webhookRetryRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retry webhooks
        /// </summary>
        /// <remarks>
        /// Retries all the webhooks with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="webhookRetryRequestsDto">The request parameters for requesting the webhook delivery retries. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/retry-webhooks/">REST API Reference for RetryWebhooks Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksLogArrayWrapper)</returns>
        public async Task<ApiResponse<WebhooksLogArrayWrapper>> RetryWebhooksWithHttpInfoAsync(WebhookRetryRequestsDto? webhookRetryRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (webhookRetryRequestsDto != null) localVarRequestOptions.Data = webhookRetryRequestsDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<WebhooksLogArrayWrapper>("/api/2.0/settings/webhook/retry", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RetryWebhooks", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <remarks>
        /// Updates a tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The request parameters for updating the webhook configuration. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-webhook/">REST API Reference for UpdateWebhook Operation</seealso>
        /// <returns>WebhooksConfigWrapper</returns>
        public WebhooksConfigWrapper UpdateWebhook(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default)
        {
            var localVarResponse = UpdateWebhookWithHttpInfo(updateWebhooksConfigRequestsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <remarks>
        /// Updates a tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The request parameters for updating the webhook configuration. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-webhook/">REST API Reference for UpdateWebhook Operation</seealso>
        /// <returns>ApiResponse of WebhooksConfigWrapper</returns>
        public ApiResponse<WebhooksConfigWrapper> UpdateWebhookWithHttpInfo(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (updateWebhooksConfigRequestsDto != null) localVarRequestOptions.Data = updateWebhooksConfigRequestsDto;

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
            var localVarResponse = Client.Put<WebhooksConfigWrapper>("/api/2.0/settings/webhook", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateWebhook", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <remarks>
        /// Updates a tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The request parameters for updating the webhook configuration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-webhook/">REST API Reference for UpdateWebhook Operation</seealso>
        /// <returns>Task of WebhooksConfigWrapper</returns>
        public async Task<WebhooksConfigWrapper> UpdateWebhookAsync(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateWebhookWithHttpInfoAsync(updateWebhooksConfigRequestsDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <remarks>
        /// Updates a tenant webhook with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateWebhooksConfigRequestsDto">The request parameters for updating the webhook configuration. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-webhook/">REST API Reference for UpdateWebhook Operation</seealso>
        /// <returns>Task of ApiResponse (WebhooksConfigWrapper)</returns>
        public async Task<ApiResponse<WebhooksConfigWrapper>> UpdateWebhookWithHttpInfoAsync(UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (updateWebhooksConfigRequestsDto != null) localVarRequestOptions.Data = updateWebhooksConfigRequestsDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<WebhooksConfigWrapper>("/api/2.0/settings/webhook", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateWebhook", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
